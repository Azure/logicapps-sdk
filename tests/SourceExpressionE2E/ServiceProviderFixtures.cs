using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

internal static class ServiceProviderFixtures
{
    internal const string BlobConnection = "e2eAzureBlob";
    internal const string QueueConnection = "e2eAzureQueues";
    internal static readonly string[] CaseIds =
    [
        "ServiceProviderBlobLiteral", "ServiceProviderBlobTemplate", "ServiceProviderBlobNative",
        "ServiceProviderQueueLiteral", "ServiceProviderQueueTemplate", "ServiceProviderQueueNative",
    ];

    internal static string ResourceName(string caseId)
    {
        if (!CaseIds.Contains(caseId, StringComparer.Ordinal))
            throw new ArgumentException("Unknown service-provider case.", nameof(caseId));
        var prefix = Environment.GetEnvironmentVariable("E2E_SERVICE_PROVIDER_PREFIX") ?? "sdke2e-export";
        if (!Regex.IsMatch(prefix, "^sdke2e-[a-z0-9]{6,16}$"))
            throw new InvalidOperationException("Invalid isolated service-provider resource prefix.");
        return prefix + "-" + caseId["ServiceProvider".Length..].ToLowerInvariant();
    }

    internal static bool IsAllowedAction(string caseId, string name, JObject action)
    {
        if (!CaseIds.Contains(caseId, StringComparer.Ordinal) ||
            action["inputs"] is not JObject inputs ||
            inputs["serviceProviderConfiguration"] is not JObject configuration)
            return false;
        var blob = caseId.StartsWith("ServiceProviderBlob", StringComparison.Ordinal);
        var operation = (blob, name) switch
        {
            (true, "Upload") => "uploadBlob",
            (true, "Read") => "readBlob",
            (true, "Delete") => "deleteBlob",
            (true, "AfterDelete") => "blobExists",
            (false, "CreateQueue") => "putQueue",
            (false, "Send") => "putMessage",
            (false, "Read" or "AfterDelete") => "getMessages",
            (false, "Delete") => "deleteMessage",
            _ => null,
        };
        return operation != null && configuration.Count == 3 &&
            (string)configuration["serviceProviderId"] == (blob ? "/serviceProviders/AzureBlob" : "/serviceProviders/azurequeues") &&
            (string)configuration["connectionName"] == (blob ? BlobConnection : QueueConnection) &&
            (string)configuration["operationId"] == operation &&
            inputs["parameters"] is JObject parameters &&
            (string)parameters[blob ? "containerName" : "queueName"] == ResourceName(caseId) &&
            (!blob || (string)parameters["blobName"] == "value.txt");
    }

    internal static bool SatisfiesRoundTrip(JToken result)
    {
        var id = (string)result["id"];
        if (!CaseIds.Contains(id, StringComparer.Ordinal)) return true;
        var actions = result["actions"] as JArray;
        if (actions == null) return false;
        var blob = id.StartsWith("ServiceProviderBlob", StringComparison.Ordinal);
        var required = blob
            ? new[] { "Upload", "Read", "Result", "Delete", "AfterDelete", "Response" }
            : new[] { "CreateQueue", "InitializeReceived", "Send", "Read", "Consume", "Capture", "Delete", "AfterDelete", "Result", "Response" };
        if (!id.EndsWith("Literal", StringComparison.Ordinal)) required = required.Append("Source").ToArray();
        if (actions.Count != required.Length || required.Any(name =>
            actions.Count(action => (string)action["name"] == name && (string)action["status"] == "Succeeded") != 1))
            return false;
        JToken Body(string name)
        {
            var matches = actions.Where(action => (string)action["name"] == name).ToArray();
            if (matches.Length != 1 || (string)matches[0]["status"] != "Succeeded" ||
                matches[0]["outputs"]?["raw"]?.Type != JTokenType.String)
                return null;
            return JToken.Parse((string)matches[0]["outputs"]["raw"])["body"];
        }
        if (blob)
        {
            var exists = Body("AfterDelete")?["isBlobExists"];
            return exists?.Type == JTokenType.Boolean && (bool)exists == false;
        }
        return Body("Read") is JArray { Count: 1 } && Body("AfterDelete") is JArray { Count: 0 };
    }

    internal static void ValidateDefinition(string id, JObject workflow)
    {
        if (!CaseIds.Contains(id, StringComparer.Ordinal)) return;
        var blob = id.StartsWith("ServiceProviderBlob", StringComparison.Ordinal);
        var actions = (JObject)workflow["definition"]["actions"];
        var parameters = actions[blob ? "Upload" : "Send"]["inputs"]["parameters"];
        var payload = (string)parameters[blob ? "content" : "message"];
        var kind = blob ? "blob" : "queue";
        var expected = id.EndsWith("Native", StringComparison.Ordinal)
            ? "#{outputs(\"Source\").ToObject<string>().ToUpperInvariant()}"
            : id.EndsWith("Template", StringComparison.Ordinal) ? "#{outputs(\"Source\")}" : kind + " literal";
        if (payload != expected)
            throw new InvalidOperationException($"Provider payload conversion changed for {id}: {payload}");
        var expectedNativeCount = (blob ? 2 : 6) + (id.EndsWith("Literal", StringComparison.Ordinal) ? 0 : 1);
        var nativeCount = workflow.Descendants().OfType<JValue>().Count(value =>
            value.Type == JTokenType.String && ((string)value).StartsWith("#{", StringComparison.Ordinal));
        if (nativeCount != expectedNativeCount)
            throw new InvalidOperationException($"Unexpected native expression count for {id}: {nativeCount}");
    }

    internal static void SelfTest()
    {
        var caseId = "ServiceProviderBlobLiteral";
        var action = new JObject
        {
            ["inputs"] = new JObject
            {
                ["serviceProviderConfiguration"] = new JObject
                {
                    ["serviceProviderId"] = "/serviceProviders/AzureBlob",
                    ["operationId"] = "uploadBlob", ["connectionName"] = BlobConnection,
                },
                ["parameters"] = new JObject
                {
                    ["containerName"] = ResourceName(caseId), ["blobName"] = "value.txt",
                },
            },
        };
        if (!IsAllowedAction(caseId, "Upload", action))
            throw new InvalidOperationException("Reviewed Blob action was rejected.");
        foreach (var (field, replacement) in new[]
        {
            ("connectionName", "otherConnection"), ("serviceProviderId", "/serviceProviders/http"),
            ("operationId", "uploadBlobFromUri"),
        })
        {
            var invalid = (JObject)action.DeepClone();
            invalid["inputs"]["serviceProviderConfiguration"][field] = replacement;
            if (IsAllowedAction(caseId, "Upload", invalid))
                throw new InvalidOperationException("Unreviewed provider configuration was accepted: " + field);
        }
        var outside = (JObject)action.DeepClone();
        outside["inputs"]["parameters"]["containerName"] = "existing-container";
        if (IsAllowedAction(caseId, "Upload", outside) || IsAllowedAction("Uppercase", "Upload", action))
            throw new InvalidOperationException("Provider resource/case isolation was bypassed.");
        var queueAction = (JObject)action.DeepClone();
        queueAction["inputs"]["serviceProviderConfiguration"]["serviceProviderId"] = "/serviceProviders/azurequeues";
        queueAction["inputs"]["serviceProviderConfiguration"]["connectionName"] = QueueConnection;
        queueAction["inputs"]["serviceProviderConfiguration"]["operationId"] = "putMessage";
        queueAction["inputs"]["parameters"] = new JObject { ["queueName"] = ResourceName("ServiceProviderQueueLiteral") };
        if (!IsAllowedAction("ServiceProviderQueueLiteral", "Send", queueAction))
            throw new InvalidOperationException("Reviewed queue action was rejected.");
        var wrongQueue = (JObject)queueAction.DeepClone();
        wrongQueue["inputs"]["parameters"]["queueName"] = "existing-queue";
        if (IsAllowedAction("ServiceProviderQueueLiteral", "Send", wrongQueue))
            throw new InvalidOperationException("Queue resource isolation was bypassed.");
        foreach (var blob in new[] { true, false })
        {
            var names = blob
                ? new[] { "Upload", "Read", "Result", "Delete", "AfterDelete", "Response" }
                : new[] { "CreateQueue", "InitializeReceived", "Send", "Read", "Consume", "Capture", "Delete", "AfterDelete", "Result", "Response" };
            var evidence = new JObject
            {
                ["id"] = blob ? "ServiceProviderBlobLiteral" : "ServiceProviderQueueLiteral",
                ["actions"] = new JArray(names.Select(name => new JObject
                {
                    ["name"] = name, ["status"] = "Succeeded",
                    ["outputs"] = new JObject
                    {
                        ["raw"] = new JObject
                        {
                            ["body"] = blob ? new JObject { ["isBlobExists"] = false }
                                : name == "Read" ? new JArray(new JObject { ["content"] = "queue literal" }) : new JArray(),
                        }.ToString(),
                    },
                })),
            };
            if (!SatisfiesRoundTrip(evidence)) throw new InvalidOperationException("Valid provider evidence was rejected.");
            var remaining = (JObject)evidence.DeepClone();
            var afterDelete = remaining["actions"].Single(item => (string)item["name"] == "AfterDelete");
            afterDelete["outputs"]["raw"] = blob ? "{\"body\":{\"isBlobExists\":true}}" : "{\"body\":[{}]}";
            if (SatisfiesRoundTrip(remaining)) throw new InvalidOperationException("Undeleted provider data was accepted.");
            var missing = (JObject)evidence.DeepClone();
            missing["actions"].Last.Remove();
            if (SatisfiesRoundTrip(missing)) throw new InvalidOperationException("Incomplete provider evidence was accepted.");
            var failed = (JObject)evidence.DeepClone();
            failed["actions"][0]["status"] = "Failed";
            if (SatisfiesRoundTrip(failed)) throw new InvalidOperationException("Failed provider action was accepted.");
        }
        Console.WriteLine("Service-provider safety and round-trip evidence: sixteen self-tests passed.");
    }
}
