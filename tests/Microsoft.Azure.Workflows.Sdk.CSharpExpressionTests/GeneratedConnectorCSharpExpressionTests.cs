// -----------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.CSharpExpressionTests
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.A365copilotchatmcp;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Aadinvitationmanager;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Abbreviationsip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Acsemail;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Azureeventgrid;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Bkkfutarip;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Dropbox;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Impexium;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Office365;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Plivo;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Servicebus;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sharepointonline;
    using Microsoft.Azure.Workflows.Sdk.Connectors.Slack;
    using Newtonsoft.Json.Linq;

    public class GeneratedConnectorCSharpExpressionTests
    {
        [Fact]
        public void McpM365copilot_OmitsUntouchedOptionalInputs()
        {
            var action = new A365copilotchatmcpActions("a365copilotchatmcp").McpM365copilot();

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "ApiConnection",
                  "inputs": {
                    "method": "post",
                    "path": "/servers/mcp_m365copilot",
                    "host": {
                      "connection": {
                        "referenceName": "a365copilotchatmcp"
                      }
                    }
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, actual), actual.ToString());
        }

        [Fact]
        public void HiddenPathDefaults_UseLiteralMetadataAndDeclaredWireValues()
        {
            var alerts = GetActionInput(new BkkfutaripActions("connection").SearchAlerts());
            var messages = GetActionInput(new PlivoActions("connection").ListMessages());

            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/{0}/api/where/alert-search\", encodeURIComponent(\"otp\"))}",
                alerts.Path);
            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/v1/Account/{0}/Message/\", encodeURIComponent(\"auth_id_value\"))}",
                messages.Path);
        }

        [Fact]
        public void HiddenIntegerPathDefault_PreservesLateBoundPublicInput()
        {
            var person = WorkflowActions.BuiltIn.Compose<string>(() => "unused").WithName("OriginalPerson");
            var action = new ImpexiumActions("connection").FindIndividualIdOrEmail(() => person.Output);
            person.WithName("Person");

            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/api/v1/Individuals/Profile/{0}/{1}/\", encodeURIComponent(outputs(\"Person\").ToObject<string>()), encodeURIComponent(1))}",
                GetActionInput(action).Path);
        }

        [Fact]
        public void RepeatedNestedBodyNames_KeepDistinctObjectsAndCallback()
        {
            var trigger = new AzureeventgridTriggers("connection").CreateSubscription(
                () => "subscription",
                () => "resource-type",
                bodypropertiesresourceName: () => "topic",
                bodypropertiesfilterprefixFilter: () => "prefix");
            var input = Assert.IsType<ApiConnectionActionInput>(trigger.GetTriggerDefinition().Inputs);
            var body = Assert.IsType<JObject>(input.Body);
            var properties = Assert.IsType<JObject>(body["properties"]);
            var destination = Assert.IsType<JObject>(properties["destination"]);
            var destinationProperties = Assert.IsType<JObject>(destination["properties"]);

            Assert.Equal("topic", properties["topic"]?.Value<string>());
            Assert.Equal("prefix", properties["filter"]?["subjectBeginsWith"]?.Value<string>());
            Assert.Equal("webhook", destination["endpointType"]?.Value<string>());
            Assert.Equal("#{listCallbackUrl()}", destinationProperties["endpointUrl"]?.Value<string>());
            Assert.Null(properties["endpointUrl"]);
            Assert.Null(destinationProperties["topic"]);
        }

        [Fact]
        public void DropboxCreateFile_PreservesCurrentSchemaQueriesAndHiddenDefault()
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
                      "name": "payload.json",
                      "queryParametersSingleEncoded": "True"
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
        public void Office365CalendarGetTables_PreservesStringHiddenDefaults()
        {
            var action = new Office365Actions("office365").CalendarGetTables();
            var queries = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"]?["queries"];

            Assert.Equal(JTokenType.String, queries?["skip"]?.Type);
            Assert.Equal("0", queries?["skip"]?.Value<string>());
            Assert.Equal(JTokenType.String, queries?["top"]?.Type);
            Assert.Equal("256", queries?["top"]?.Value<string>());
        }

        [Fact]
        public void Office365ReplyTo_OmitsEmptyBodyButKeepsPopulatedBody()
        {
            var connector = new Office365Actions("office365");
            var empty = JObject.Parse(connector.ReplyTo(() => "message").GetActionDefinition("workflow").ToJson());
            var populated = JObject.Parse(connector.ReplyTo(
                () => "message", replyParametersbody: () => "reply").GetActionDefinition("workflow").ToJson());

            Assert.Null(empty["inputs"]?["body"]);
            Assert.Equal("reply", populated["inputs"]?["body"]?["Body"]?.Value<string>());
        }

        [Fact]
        public void Office365ReplyTo_BodyOmissionDoesNotSkipRequiredArgumentValidation()
        {
            var error = Assert.Throws<ArgumentNullException>(() => new Office365Actions("office365").ReplyTo(null));

            Assert.Equal("messageId", error.ParamName);
        }

        [Fact]
        public void SharePointFolderOperations_PreservePublicSurfaceAndPaths()
        {
            var connector = new SharepointonlineActions("sharepointonline");
            var root = GetActionInput(connector.ListRootFolder(() => "site"));
            var folder = GetActionInput(connector.ListFolder(() => "site", () => "folder"));

            Assert.Equal("get", root.Method);
            Assert.Equal("get", folder.Method);
            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/folders\", encodeURIComponent(encodeURIComponent(\"site\")))}",
                root.Path);
            Assert.Equal(
                "#{string.Format(global::System.Globalization.CultureInfo.InvariantCulture, \"/datasets/{0}/folders/{1}\", encodeURIComponent(encodeURIComponent(\"site\")), encodeURIComponent(\"folder\"))}",
                folder.Path);
        }

        [Fact]
        public void ManagedModelProperties_PreservePublicAcronymsAndWireNames()
        {
            var calendar = JObject.FromObject(new CalendarGetTablesV2ResponseValueTypeItem { ID = "calendar" });
            var folder = JObject.FromObject(new GraphContactFolder { ID = "folder", ParentFolderID = "parent" });

            Assert.Equal("calendar", calendar["id"]?.Value<string>());
            Assert.Equal("folder", folder["id"]?.Value<string>());
            Assert.Equal("parent", folder["parentFolderId"]?.Value<string>());
            Assert.Equal("ApprovalRequestID", nameof(ApprovalData.ApprovalRequestID));
            Assert.Equal("ID", nameof(DeletedItem.ID));
        }

        [Fact]
        public void SlackBodyEnum_PreservesLiteralAndNativeWireValues()
        {
            var literal = new SlackActions("slack").PostMessage(
                () => "channel", () => "message", messageparseMode: () => messageparseModeInput.Full);
            var source = WorkflowActions.BuiltIn.Compose<messageparseModeInput>(() => messageparseModeInput.Full)
                .WithName("Original");
            var native = new SlackActions("slack").PostMessage(
                () => "channel", () => "message", messageparseMode: () => source.Output);
            source.WithName("Mode");

            Assert.Equal("full", Assert.IsType<JObject>(GetActionInput(literal).Body)["parse"]?.Value<string>());
            var expression = Assert.IsType<JObject>(GetActionInput(native).Body)["parse"]?.Value<string>();
            Assert.StartsWith("#{", expression);
            Assert.Contains("outputs(\"Mode\")", expression);
            Assert.DoesNotContain("Original", expression);
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
            var action = new A365copilotchatmcpActions("connection").McpM365copilot(
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
        public void CreateInvitation_OmitsUntouchedOptionalBody()
        {
            var action = new AadinvitationmanagerActions("connection").CreateInvitation();

            var actual = JObject.Parse(action.GetActionDefinition("workflow").ToJson());
            var expected = JObject.Parse(
                """
                {
                  "type": "ApiConnection",
                  "inputs": {
                    "method": "post",
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
                    ]
                  }
                }
                """);

            Assert.True(JToken.DeepEquals(expected, body), body?.ToString());
        }

        [Fact]
        public void CreateInvitation_PreservesExplicitMessageLanguage()
        {
            var action = new AadinvitationmanagerActions("connection").CreateInvitation(
                bodyinvitedUserMessageInfomessageLanguage: () => "en-US");
            var body = JObject.Parse(action.GetActionDefinition("workflow").ToJson())["inputs"]?["body"];

            Assert.True(JToken.DeepEquals(
                JObject.Parse("""{"invitedUserMessageInfo":{"messageLanguage":"en-US"}}"""), body),
                body?.ToString());
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
            var header = GetActionInput(new A365copilotchatmcpActions("connection")
                .McpM365copilot(mcpSessionId: () => source.Output));
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
