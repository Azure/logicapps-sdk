//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StormboardActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateIdeaResponse> CreateIdea([WorkflowExpression] Func<int> bodystormid, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bodycolorInput> bodycolor)
        {
            SourceExpression.Validate(bodystormid, nameof(bodystormid), required: true);
            SourceExpression.Validate(bodytype, nameof(bodytype), required: true);
            SourceExpression.Validate(bodydata, nameof(bodydata), required: true);
            SourceExpression.Validate(bodycolor, nameof(bodycolor), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stormid"] = SourceExpressionConverter.ConvertToken(bodystormid);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["data"] = SourceExpressionConverter.ConvertToken(bodydata);
                bodypropCount++;
                body["color"] = SourceExpressionConverter.Convert(bodycolor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateIdeaResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateStormResponse> CreateStorm([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyplan, [WorkflowExpression] Func<string> bodygoals = null, [WorkflowExpression] Func<bool> bodyideacreator = null)
        {
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            SourceExpression.Validate(bodyplan, nameof(bodyplan), required: true);
            SourceExpression.Validate(bodygoals, nameof(bodygoals), required: false);
            SourceExpression.Validate(bodyideacreator, nameof(bodyideacreator), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["plan"] = SourceExpressionConverter.ConvertToken(bodyplan);
                if (bodygoals != null)
                {
                    body["goals"] = SourceExpressionConverter.ConvertToken(bodygoals);
                    bodypropCount++;
                }

                if (bodyideacreator != null)
                {
                    if (bodyideacreator != null)
                    {
                        body["ideacreator"] = SourceExpressionConverter.ConvertToken(bodyideacreator);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ideacreator"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateStormResponse>(BuildSourceInput);
        }
    }

    public class StormboardTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger LegendChange(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["service"] = "MicrosoftFlow";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["events"] = "idea.color";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger IdeaSection(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/ideaSection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["service"] = "MicrosoftFlow";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["events"] = "idea.section";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger IdeaCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/ideaCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["service"] = "MicrosoftFlow";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["events"] = "idea.create";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger IdeaDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/ideaDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["service"] = "MicrosoftFlow";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["events"] = "idea.delete";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger CommentCreated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/hooks/commentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["service"] = "MicrosoftFlow";
                bodypropCount++;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["events"] = "comment.create";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class CreateIdeaResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("storm")]
        public CreateIdeaResponseStormType Storm { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("lock")]
        public int Lock { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("z")]
        public int Z { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("data")]
        public CreateIdeaResponseDataType Data { get; set; }
    }

    public class CreateIdeaResponseStormType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class CreateIdeaResponseDataType
    {
        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "title")]
        Title
    }

    public enum bodycolorInput
    {
        [EnumMember(Value = "yellow")]
        Yellow,
        [EnumMember(Value = "pink")]
        Pink,
        [EnumMember(Value = "green")]
        Green,
        [EnumMember(Value = "blue")]
        Blue,
        [EnumMember(Value = "purple")]
        Purple,
        [EnumMember(Value = "grey")]
        Grey,
        [EnumMember(Value = "red")]
        Red,
        [EnumMember(Value = "silver")]
        Silver,
        [EnumMember(Value = "orange")]
        Orange
    }

    public class CreateStormResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("goals")]
        public string Goals { get; set; }

        [JsonProperty("lastactivity")]
        public string Lastactivity { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard;

    public partial class WorkflowManagedActions
    {
        public StormboardActions Stormboard(string connectionId) => new StormboardActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public StormboardTriggers Stormboard(string connectionId) => new StormboardTriggers(connectionId);
    }
}