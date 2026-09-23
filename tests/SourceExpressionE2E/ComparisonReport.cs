namespace Microsoft.Azure.Workflows.Sdk.SourceExpressionE2E;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Text.Json;

public static class ComparisonReport
{
    public static void Write(string oursPath, string comparisonPath, string outputPath)
    {
        var ours = (JObject)ParseJson(File.ReadAllText(oursPath));
        var comparison = (JObject)ParseJson(File.ReadAllText(comparisonPath));
        var sourceManifestName = "source-fingerprints.json";
        var oursSources = JArray.Parse(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Path.GetFullPath(oursPath)), sourceManifestName)));
        var comparisonSources = JArray.Parse(File.ReadAllText(Path.Combine(Path.GetDirectoryName(Path.GetFullPath(comparisonPath)), sourceManifestName)));
        var sourceHashes = oursSources.ToDictionary(item => (string)item["path"], item => (string)item["sha256"], StringComparer.Ordinal);
        var otherHashes = comparisonSources.ToDictionary(item => (string)item["path"], item => (string)item["sha256"], StringComparer.Ordinal);
        if (sourceHashes.Count != otherHashes.Count || sourceHashes.Any(pair =>
            !otherHashes.TryGetValue(pair.Key, out var otherHash) || pair.Value != otherHash))
            throw new InvalidOperationException("Comparison requires identical workflow and harness source fingerprints.");
        var left = ((JArray)ours["results"]).ToDictionary(item => (string)item["id"], StringComparer.Ordinal);
        var right = ((JArray)comparison["results"]).ToDictionary(item => (string)item["id"], StringComparer.Ordinal);
        if (!left.Keys.Order().SequenceEqual(right.Keys.Order()))
            throw new InvalidOperationException("Comparison requires exactly the same case IDs on both sides.");
        foreach (var assembly in new[] { "bin\\Microsoft.Azure.Workflows.Templates.dll", "bin\\Microsoft.Azure.Workflows.Templates.Languages.Edge.CSharp.dll" })
        {
            var a = ours["assemblies"].Single(item => (string)item["path"] == assembly);
            var b = comparison["assemblies"].Single(item => (string)item["path"] == assembly);
            if ((string)a["sha256"] != (string)b["sha256"])
                throw new InvalidOperationException("Comparison backend differs: " + assembly);
        }
        var results = left.OrderBy(pair => pair.Key, StringComparer.Ordinal).Select(pair =>
        {
            var other = right[pair.Key];
            return new
            {
                id = pair.Key,
                failureIds = pair.Value["failureIds"],
                classification = Classify(pair.Value, other),
                ours = pair.Value,
                comparison = other,
            };
        }).ToArray();
        var report = new
        {
            evidenceKind = "paired-actual-local-workflow-execution",
            createdUtc = DateTimeOffset.UtcNow,
            oursEvidence = Path.GetFullPath(oursPath),
            comparisonEvidence = Path.GetFullPath(comparisonPath),
            sourceFingerprints = oursSources,
            counts = results.GroupBy(item => item.classification).ToDictionary(group => group.Key, group => group.Count()),
            results,
            limitations = new[]
            {
                "A mapped failure ID may be representative, not an exact reproduction; read case-coverage.json.",
                "Both-failed cases do not establish output equivalence.",
                "This is local runtime verification, not cloud/designer certification or a performance benchmark.",
            },
        };
        File.WriteAllText(outputPath, JsonConvert.SerializeObject(report, CaseCatalog.JsonSettings));
        Console.WriteLine(JsonConvert.SerializeObject(report.counts, Formatting.Indented));
    }

    internal static string Classify(JToken left, JToken right)
    {
        var leftSucceeded = (string)left["outcome"] == "RuntimeSucceeded";
        var rightSucceeded = (string)right["outcome"] == "RuntimeSucceeded";
        if (leftSucceeded && rightSucceeded)
        {
            if ((string)left["responseContract"] == "UtcTimestamp" &&
                (string)right["responseContract"] == "UtcTimestamp")
                return (bool?)left["passed"] == true && (bool?)right["passed"] == true
                    ? "BothSatisfyNondeterministicContract" : "TimeContractNotSatisfied";
            var a = ResponsePayload(left);
            var b = ResponsePayload(right);
            var jsonBodies = IsJsonBody(a) && IsJsonBody(b);
            if (!JToken.DeepEquals(left["httpStatus"], right["httpStatus"]) ||
                !EqualBody((string)left["httpBody"], (string)right["httpBody"], jsonBodies))
                return "DifferentResponse";
            if (a == null || b == null)
                return "SameHttpResponseWithoutResponseActionEvidence";
            return EqualBody((string)a["inputs"], (string)b["inputs"], true) &&
                EqualBody((string)a["outputs"], (string)b["outputs"], true)
                ? "SameResponseAndActionValues" : "DifferentResponseActionValues";
        }
        if (leftSucceeded != rightSucceeded)
            return "DifferentExecutionOutcome";
        if ((string)left["outcome"] == "RuntimeFailed" && (string)right["outcome"] == "RuntimeFailed" &&
            (bool?)left["passed"] == true && (bool?)right["passed"] == true)
            return "BothSatisfyExpectedFailureContract";
        if ((string)left["outcome"] == "GenerationRejected" &&
            (string)right["outcome"] == "GenerationRejected" &&
            (bool?)left["passed"] == true && (bool?)right["passed"] == true)
            return "BothRejectExpectedAuthoringContract";
        return "BothFailedOrBlocked";
    }

    public static bool ValidateResults(string path)
    {
        var document = (JObject)ParseJson(File.ReadAllText(path));
        foreach (var result in document["results"])
        {
            var passed = (bool?)result["generationExpectationMet"] == true;
            if ((string)result["outcome"] is not ("GenerationRejected" or "CompileRejected"))
            {
                var expectedError = (string)result["expectedActionError"];
                var bodyMatches = !string.IsNullOrEmpty(expectedError) && (string)result["expectedRunStatus"] == "Failed"
                    ? result["actions"].Any(action => (string)action["status"] == "Failed" &&
                        ((string)action["error"]?["message"])?.Contains(expectedError, StringComparison.Ordinal) == true)
                    : (string)result["responseContract"] == "UtcTimestamp"
                    ? SatisfiesTimeWindow(result)
                    : EqualBody((string)result["httpBody"], (string)result["expectedBody"], IsJsonBody(ResponsePayload(result)));
                passed = passed && JToken.DeepEquals(result["httpStatus"], result["expectedHttpStatus"])
                    && (string)result["runStatus"] == (string)result["expectedRunStatus"] && bodyMatches;
                if ((string)result["expectedRunStatus"] == "Succeeded")
                    passed = passed && result["actions"].Any()
                        && ((string)result["responseContract"] == "HandledResponseFailure"
                            ? SatisfiesHandledResponseFailure(result)
                            : result["actions"].All(action => (string)action["status"] == "Succeeded"));
            }
            result["passed"] = passed;
        }
        File.WriteAllText(path, document.ToString(Formatting.Indented));
        var failures = document["results"].Where(result => (bool?)result["passed"] != true).ToArray();
        Console.WriteLine($"Expected contracts satisfied: {document["results"].Count() - failures.Length}/{document["results"].Count()}.");
        return failures.Length == 0;
    }

    private static bool SatisfiesHandledResponseFailure(JToken result)
    {
        var name = (string)result["expectedFailedAction"];
        var code = (string)result["expectedActionErrorCode"];
        var message = (string)result["expectedActionError"];
        if (string.IsNullOrEmpty(name) || name == "Response" ||
            string.IsNullOrEmpty(code) || string.IsNullOrEmpty(message) ||
            result["actions"] is not JArray actions)
            return false;
        var failed = actions.Where(action => (string)action["name"] == name).ToArray();
        return failed.Length == 1 && (string)failed[0]["status"] == "Failed" &&
            (string)failed[0]["error"]?["code"] == code &&
            ((string)failed[0]["error"]?["message"])?.Contains(message, StringComparison.Ordinal) == true &&
            actions.Count(action => (string)action["name"] == "Response") == 1 &&
            actions.Where(action => (string)action["name"] != name)
                .All(action => (string)action["status"] == "Succeeded");
    }

    private static bool SatisfiesTimeWindow(JToken result)
    {
        var text = (string)result["httpBody"];
        if (text == null) return false;
        if (text.StartsWith('"'))
        {
            try { text = JsonConvert.DeserializeObject<string>(text); }
            catch (Newtonsoft.Json.JsonException) { return false; }
        }
        if (!DateTimeOffset.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out var value) ||
            value.Offset != TimeSpan.Zero ||
            !DateTimeOffset.TryParse((string)result["invokedUtc"], CultureInfo.InvariantCulture, DateTimeStyles.None, out var start) ||
            !DateTimeOffset.TryParse((string)result["runEndTime"], CultureInfo.InvariantCulture, DateTimeStyles.None, out var end))
            return false;
        return value >= start.AddSeconds(-1) && value <= end.AddSeconds(1);
    }

    private static bool IsJsonBody(JToken response)
    {
        if (response?["outputs"] is not JValue raw) return false;
        using var document = JsonDocument.Parse((string)raw);
        return document.RootElement.ValueKind == JsonValueKind.Object &&
            document.RootElement.TryGetProperty("body", out var body) && body.ValueKind != JsonValueKind.String;
    }

    private static bool EqualBody(string left, string right, bool jsonBody)
    {
        if (left == right) return true;
        if (!jsonBody || left == null || right == null) return false;
        try
        {
            using var a = JsonDocument.Parse(left);
            using var b = JsonDocument.Parse(right);
            return EqualJson(a.RootElement, b.RootElement);
        }
        catch (System.Text.Json.JsonException) { return false; }
    }

    private static JToken ParseJson(string text)
    {
        using var reader = new JsonTextReader(new StringReader(text)) { DateParseHandling = DateParseHandling.None };
        var token = JToken.ReadFrom(reader);
        if (reader.Read()) throw new JsonReaderException("Additional JSON content is not allowed.");
        return token;
    }

    private static bool EqualJson(JsonElement left, JsonElement right)
    {
        if (left.ValueKind != right.ValueKind) return false;
        if (left.ValueKind == JsonValueKind.Object)
        {
            var a = left.EnumerateObject().ToArray();
            var b = right.EnumerateObject().ToArray();
            return a.Length == b.Length && a.All(property =>
                right.TryGetProperty(property.Name, out var value) && EqualJson(property.Value, value));
        }
        if (left.ValueKind == JsonValueKind.Array)
            return left.GetArrayLength() == right.GetArrayLength()
                && left.EnumerateArray().Zip(right.EnumerateArray()).All(pair => EqualJson(pair.First, pair.Second));
        if (left.ValueKind == JsonValueKind.Number)
            return NormalizeNumber(left.GetRawText()) == NormalizeNumber(right.GetRawText());
        return left.ValueKind == JsonValueKind.String
            ? left.GetString() == right.GetString() : left.GetRawText() == right.GetRawText();
    }

    private static (BigInteger Mantissa, int Exponent) NormalizeNumber(string text)
    {
        var match = Regex.Match(text, @"^(?<sign>-?)(?<whole>\d+)(?:\.(?<fraction>\d+))?(?:[eE](?<exponent>[+-]?\d+))?$");
        if (!match.Success) throw new InvalidOperationException("Non-finite JSON number is not a comparison value.");
        var digits = match.Groups["whole"].Value + match.Groups["fraction"].Value;
        var value = BigInteger.Parse(match.Groups["sign"].Value + digits, CultureInfo.InvariantCulture);
        var exponent = match.Groups["exponent"].Success
            ? int.Parse(match.Groups["exponent"].Value, CultureInfo.InvariantCulture) : 0;
        exponent -= match.Groups["fraction"].Length;
        if (value.IsZero) return (BigInteger.Zero, 0);
        while (value % 10 == 0) { value /= 10; exponent++; }
        return (value, exponent);
    }

    private static JToken ResponsePayload(JToken result)
    {
        var responses = result["actions"]?.Where(action =>
            string.Equals((string)action["name"], "Response", StringComparison.OrdinalIgnoreCase)).ToArray();
        if (responses == null || responses.Length != 1) return null;
        var action = responses[0];
        var input = (string)action["inputs"]?["raw"];
        var output = (string)action["outputs"]?["raw"];
        if (input == null || output == null) return null;
        return new JObject { ["inputs"] = input, ["outputs"] = output };
    }

    public static void SelfTest()
    {
        var success = new JObject
        {
            ["outcome"] = "RuntimeSucceeded", ["httpStatus"] = 200, ["httpBody"] = "hello",
            ["actions"] = new JArray(new JObject
            {
                ["name"] = "Response",
                ["inputs"] = new JObject { ["raw"] = "{\"body\":\"hello\"}" },
                ["outputs"] = new JObject { ["raw"] = "{\"body\":\"hello\"}" },
            }),
        };
        Require(Classify(success, success.DeepClone()), "SameResponseAndActionValues");
        var changed = (JObject)success.DeepClone();
        changed["httpBody"] = "different";
        Require(Classify(success, changed), "DifferentResponse");
        changed = (JObject)success.DeepClone();
        changed["actions"][0]["outputs"]["raw"] = "{\"body\":7}";
        Require(Classify(success, changed), "DifferentResponseActionValues");
        var rejected = new JObject { ["outcome"] = "GenerationRejected", ["passed"] = false };
        Require(Classify(success, rejected), "DifferentExecutionOutcome");
        Require(Classify(rejected, rejected), "BothFailedOrBlocked");
        rejected["passed"] = true;
        Require(Classify(rejected, rejected), "BothRejectExpectedAuthoringContract");
        if (!EqualBody("{\"b\":2,\"a\":120.0}", "{\"a\":120,\"b\":2}", true) ||
            EqualBody("\"120\"", "120", true) || EqualBody("hello ", "hello", false) ||
            EqualBody("   3", "3", false) ||
            EqualBody("1.2345678901234567890123456789", "1.2345678901234567890123456788", true))
            throw new InvalidOperationException("JSON value comparison must ignore object order/numeric spelling, but preserve types and text.");
        var timeCase = new JObject
        {
            ["httpBody"] = "2026-09-18T12:00:01Z",
            ["invokedUtc"] = "2026-09-18T12:00:00Z",
            ["runEndTime"] = "2026-09-18T12:00:02Z",
        };
        if (!SatisfiesTimeWindow(ParseJson(timeCase.ToString()))) throw new InvalidOperationException("Valid UTC time contract rejected.");
        timeCase["httpBody"] = "2026-09-17T12:00:01Z";
        if (SatisfiesTimeWindow(timeCase)) throw new InvalidOperationException("Stale clock snapshot accepted.");
        var recovered = new JObject
        {
            ["expectedFailedAction"] = "InvalidResponse",
            ["expectedActionErrorCode"] = "InvalidResponseBody",
            ["expectedActionError"] = "unsupported response value",
            ["actions"] = new JArray(
                new JObject
                {
                    ["name"] = "InvalidResponse", ["status"] = "Failed",
                    ["error"] = new JObject { ["code"] = "InvalidResponseBody", ["message"] = "unsupported response value" },
                },
                new JObject { ["name"] = "Response", ["status"] = "Succeeded" }),
        };
        if (!SatisfiesHandledResponseFailure(recovered))
            throw new InvalidOperationException("An explicitly handled Response failure was rejected.");
        foreach (var mutation in new Action<JObject>[]
        {
            value => value["actions"][0]["error"]["code"] = "InternalServerError",
            value => value["actions"][0]["error"]["message"] = "unrelated failure",
            value => value["actions"][0]["status"] = "Succeeded",
            value => value["actions"][1]["status"] = "Failed",
            value => value["expectedFailedAction"] = "Response",
            value => ((JArray)value["actions"]).Add(new JObject { ["name"] = "Unexpected", ["status"] = "Failed" }),
            value => ((JArray)value["actions"]).RemoveAt(1),
        })
        {
            var invalid = (JObject)recovered.DeepClone();
            mutation(invalid);
            if (SatisfiesHandledResponseFailure(invalid))
                throw new InvalidOperationException("An invalid handled-response contract was accepted.");
        }
        Console.WriteLine("Comparison classifier: twenty-one self-tests passed.");
    }

    private static void Require(string actual, string expected)
    {
        if (actual != expected) throw new InvalidOperationException($"Classifier expected {expected}, received {actual}.");
    }
}
