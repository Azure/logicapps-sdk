// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.A365adminmcp;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline;
    using Newtonsoft.Json.Linq;

    public class GeneratedConnectorCSharpExpressionTests
    {
        [Fact]
        public void McpAdminTools_OmitsUntouchedOptionalInputs()
        {
            var action = new A365adminmcpActions("a365adminmcp").McpAdminTools();

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "ApiConnection",
                  "inputs": {
                    "method": "post",
                    "path": "/servers/mcp_AdminTools",
                    "host": {
                      "connection": {
                        "referenceName": "a365adminmcp"
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void DropboxCreateFile_SerializesDesignerEquivalentQueries()
        {
            var action = new DropboxActions("dropbox").CreateFile(
                folderPath: () => "/parity/incoming",
                name: () => "payload.json",
                body: () => """{"orderId":42,"ready":true}""");

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "ApiConnection",
                  "inputs": {
                    "method": "post",
                    "body": "{\"orderId\":42,\"ready\":true}",
                    "queries": {
                      "folderPath": "/parity/incoming",
                      "name": "payload.json"
                    },
                    "path": "/datasets/default/files",
                    "host": {
                      "connection": {
                        "referenceName": "dropbox"
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void StaticConnectorValues_RemainPlainValues()
        {
            var action = new AbbreviationsipActions("connection").AbbrGet(
                term: () => "term");

            var input = GetActionInput(action);
            var serializedQueries = JObject.Parse(action.GetActionDefinition("workflow").ToJson())
                ["inputs"]?["queries"];

            Assert.Equal("/abbr.php", input.Path);
            Assert.Equal("get", input.Method);
            Assert.Equal("p", input.Queries["sortby"]);
            Assert.Equal("e", input.Queries["searchtype"]);
            Assert.Equal("json", input.Queries["format"]);
            Assert.Equal(JTokenType.String, serializedQueries?["sortby"]?.Type);
            Assert.Equal(JTokenType.String, serializedQueries?["searchtype"]?.Type);
            Assert.Equal(JTokenType.String, serializedQueries?["format"]?.Type);
        }

        [Fact]
        public void SharePointGetFileMetadataByPath_PreservesBooleanHiddenDefault()
        {
            var action = new SharepointonlineActions("sharepointonline").GetFileMetadataByPath(
                dataset: () => "https://contoso.sharepoint.com/sites/parity",
                path: () => "/Shared Documents/payload.json");

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var queries = actual["inputs"]?["queries"];

            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/GetFileByPath\", encodeURIComponent(encodeURIComponent(\"https://contoso.sharepoint.com/sites/parity\")))}",
                actual["inputs"]?["path"]?.Value<string>());
            Assert.Equal("/Shared Documents/payload.json", queries?["path"]?.Value<string>());
            Assert.Equal(JTokenType.Boolean, queries?["queryParametersSingleEncoded"]?.Type);
            Assert.True(queries?["queryParametersSingleEncoded"]?.Value<bool>());
        }

        [Fact]
        public void HiddenQueryDefaults_PreserveSwaggerPrimitiveTypes()
        {
            var input = new ApiConnectionActionInput("/path", "get", "connection");
            input.SetHiddenQueryDefault("booleanFalse", false);
            input.SetHiddenQueryDefault("integer", 10);
            input.SetHiddenQueryDefault("string", "10");

            var queries = JObject.Parse(input.ToJson())["queries"];

            Assert.Equal(JTokenType.Boolean, queries?["booleanFalse"]?.Type);
            Assert.False(queries?["booleanFalse"]?.Value<bool>());
            Assert.Equal(JTokenType.Integer, queries?["integer"]?.Type);
            Assert.Equal(10, queries?["integer"]?.Value<int>());
            Assert.Equal(JTokenType.String, queries?["string"]?.Type);
            Assert.Equal("10", queries?["string"]?.Value<string>());
        }

        [Fact]
        public void QueryAndEnumInputs_SelectCSharpAndLiteralValues()
        {
            var action = new AbbreviationsipActions("connection").AbbrGet(
                term: () => "term".ToUpper(),
                sortby: () => sortbyInput.Alphabetically);

            var input = GetActionInput(action);

            Assert.Equal("#{\"term\".ToUpper()}", input.Queries["term"]);
            Assert.Equal("a", input.Queries["sortby"]);
        }

        [Fact]
        public void TypedWorkflowReferenceInput_EmitsCSharpAccessor()
        {
            var variable = WorkflowActions.BuiltIn.Variables.InitializeVariable(
                name: () => "searchTerm",
                value: () => "term");
            var action = new AbbreviationsipActions("connection").AbbrGet(
                term: () => variable.Value.Value<string>());

            var input = GetActionInput(action);

            Assert.Equal(
                "#{variables(\"searchTerm\").Value<string>()}",
                input.Queries["term"]);
        }

        [Fact]
        public void HeaderInput_EmitsCSharpExpression()
        {
            var action = new A365adminmcpActions("connection").McpAdminTools(
                mcpSessionId: () => "session".ToUpper());

            var input = GetActionInput(action);

            Assert.Equal("#{\"session\".ToUpper()}", input.Headers["Mcp-Session-Id"]);
        }

        [Fact]
        public void NestedBodyInputs_EmitCSharpExpressions()
        {
            var resetRedemption = false;
            var action = new AadinvitationmanagerActions("connection").CreateInvitation(
                bodyinvitedUserDisplayName: () => "Ada".ToUpper(),
                bodyinvitedUserMessageInfomessageLanguage: () => "fr-FR",
                bodyresetRedemption: () => !resetRedemption);

            var input = GetActionInput(action);
            var body = Assert.IsType<JObject>(input.Body);

            Assert.Equal("#{\"Ada\".ToUpper()}", body["invitedUserDisplayName"]?.Value<string>());
            Assert.Equal("fr-FR", body["invitedUserMessageInfo"]?["messageLanguage"]?.Value<string>());
            Assert.Equal("#{!false}", body["resetRedemption"]?.Value<string>());
        }

        [Fact]
        public void CreateInvitation_EmitsRequiredEmptyObjectBody()
        {
            var action = new AadinvitationmanagerActions("connection").CreateInvitation();

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "ApiConnection",
                  "inputs": {
                    "method": "post",
                    "body": {
                      "invitedUserMessageInfo": {
                        "messageLanguage": "en-US"
                      }
                    },
                    "path": "/v1.0/invitations",
                    "host": {
                      "connection": {
                        "referenceName": "connection"
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void CreateInvitation_PreservesPopulatedNestedCcRecipients()
        {
            var action = new AadinvitationmanagerActions("connection").CreateInvitation(
                bodyinvitedUserMessageInfoccRecipients: () => new[]
                {
                    new bodyinvitedUserMessageInfoccRecipientsInputItem
                    {
                        EmailAddress = new Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager.EmailAddress
                        {
                            Address = "ada@example.com",
                            Name = "Ada",
                        },
                    },
                });

            var body = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"]?["body"];
            var expected = JObject.Parse(
                """
                {
                  "invitedUserMessageInfo": {
                    "ccRecipients": [
                      {
                        "emailAddress": {
                          "address": "ada@example.com",
                          "name": "Ada"
                        }
                      }
                    ],
                    "messageLanguage": "en-US"
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, body), body?.ToString());
        }

        [Fact]
        public void EnumBodyInput_EmitsQuotedWireValue()
        {
            var action = new AcsemailActions("connection").SendEmailGAVersion(
                emailMessagesenderAddress: () => "sender@example.com",
                emailMessagecontentsubject: () => "subject",
                emailMessageimportance: () => Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail.emailMessageimportanceInput.High);

            var input = GetActionInput(action);
            var body = Assert.IsType<JObject>(input.Body);

            Assert.Equal("High", body["importance"]?.Value<string>());
        }

        [Fact]
        public void FormattedPath_EmitsCompleteCSharpExpression()
        {
            var action = new SharepointonlineActions("connection").GetItem(
                dataset: () => "site",
                table: () => "list",
                id: () => 42);

            var input = GetActionInput(action);

            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/tables/{1}/items/{2}\", encodeURIComponent(encodeURIComponent(\"site\")), encodeURIComponent(encodeURIComponent(\"list\")), encodeURIComponent(42))}",
                input.Path);
        }

        [Fact]
        public void Base64BodyInput_EmitsCSharpExpression()
        {
            var action = new ServicebusActions("connection").SendMessage(
                entityName: () => "queue",
                messagecontent: () => JToken.FromObject("hello"));

            var input = GetActionInput(action);
            var body = Assert.IsType<JObject>(input.Body);

            Assert.Equal(
                "#{base64(global::Newtonsoft.Json.Linq.JToken.FromObject(\"hello\"))}",
                body["ContentData"]?.Value<string>());
        }

        [Fact]
        public void NotificationTriggerInputs_EmitCSharpExpressions()
        {
            var fetchOnlyWithAttachment = false;
            var trigger = new Office365Triggers("connection").OnFlaggedEmail(
                folderPath: () => "Inbox".ToLower(),
                importance: () => importanceInput.High,
                fetchOnlyWithAttachment: () => !fetchOnlyWithAttachment);

            var input = Assert.IsType<ApiConnectionNotificationActionInput>(
                trigger.GetTriggerDefinition().Inputs);

            Assert.Equal("#{\"Inbox\".ToLower()}", input.Fetch.Queries["folderPath"]);
            Assert.Equal("High", input.Fetch.Queries["importance"]);
            Assert.Equal("#{!false}", input.Fetch.Queries["fetchOnlyWithAttachment"]);
            Assert.Equal("#{\"Inbox\".ToLower()}", input.Subscribe.Queries["folderPath"]);
            Assert.Equal("High", input.Subscribe.Queries["importance"]);
            Assert.Equal("#{!false}", input.Subscribe.Queries["fetchOnlyWithAttachment"]);
        }

        [Fact]
        public void WorkflowReferences_UseJsonNativeCSharpInQueryHeaderAndBody()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var query = GetActionInput(new AbbreviationsipActions("connection")
                .AbbrGet(term: () => source.Output));
            var header = GetActionInput(new A365adminmcpActions("connection")
                .McpAdminTools(mcpSessionId: () => source.Output));
            var body = GetActionInput(new AadinvitationmanagerActions("connection")
                .CreateInvitation(bodyinvitedUserDisplayName: () => source.Output));

            Assert.Equal("#{outputs(\"Source\")}", query.Queries["term"]);
            Assert.Equal("#{outputs(\"Source\")}", header.Headers["Mcp-Session-Id"]);
            Assert.Equal("#{outputs(\"Source\")}",
                Assert.IsType<JObject>(body.Body)["invitedUserDisplayName"].Value<string>());
        }

        [Fact]
        public void NativeSibling_PreservesJsonReferencesAndLiteralBodyFields()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Source");
            var input = GetActionInput(new AadinvitationmanagerActions("connection").CreateInvitation(
                bodyinvitedUserDisplayName: () => source.Output.ToUpperInvariant(),
                bodyinvitedUserEmailAddress: () => source.Output,
                bodyresetRedemption: () => false));
            var body = Assert.IsType<JObject>(input.Body);

            Assert.StartsWith("#{", body["invitedUserDisplayName"].Value<string>());
            Assert.Equal("#{outputs(\"Source\")}", body["invitedUserEmailAddress"].Value<string>());
            Assert.Equal(JTokenType.Boolean, body["resetRedemption"].Type);
            Assert.False(body["resetRedemption"].Value<bool>());
            Assert.Null(body["sendInvitationMessage"]);
        }

        [Fact]
        public void NotificationTriggerReferences_UseCSharpOnFetchAndSubscribe()
        {
            var source = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("Folder");
            var trigger = new Office365Triggers("connection").OnFlaggedEmail(
                folderPath: () => source.Output);
            var input = Assert.IsType<ApiConnectionNotificationActionInput>(
                trigger.GetTriggerDefinition().Inputs);

            Assert.Equal("#{outputs(\"Folder\")}", input.Fetch.Queries["folderPath"]);
            Assert.Equal("#{outputs(\"Folder\")}", input.Subscribe.Queries["folderPath"]);
        }

        [Fact]
        public void Base64WorkflowReference_UsesCSharpInGeneratedBody()
        {
            var trigger = WorkflowTriggers.BuiltIn.CreateHttpTrigger();
            var input = GetActionInput(new ServicebusActions("connection").SendMessage(
                entityName: () => "queue",
                messagecontent: () => trigger.TriggerOutput.Body));

            Assert.Equal("#{base64(triggerBody())}",
                Assert.IsType<JObject>(input.Body)["ContentData"].Value<string>());
        }

        private static ApiConnectionActionInput GetActionInput(IWorkflowAction action) =>
            Assert.IsType<ApiConnectionActionInput>(action.GetActionDefinition("workflow").Inputs);
    }
}
