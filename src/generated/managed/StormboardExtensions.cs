//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StormboardActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIdea))]
        public IBodyWorkflowAction<CreateIdeaResponse> CreateIdea([WorkflowExpression] Func<int> bodystormid, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodydata, [WorkflowExpression] Func<bodycolorInput> bodycolor)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateIdeaResponse> __BuildCreateIdea(WorkflowExpression<int> bodystormid, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<string> bodydata, WorkflowExpression<bodycolorInput> bodycolor)
        {
            WorkflowExpression.Validate(bodystormid, nameof(bodystormid), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodydata, nameof(bodydata), required: true);
            WorkflowExpression.Validate(bodycolor, nameof(bodycolor), required: true);
            return new DeferredBodyAction<CreateIdeaResponse>(() =>
            {
                var apiCallPath = "/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stormid"] = ExpressionConverter.ConvertO(bodystormid);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(bodydata);
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(bodycolor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        [WorkflowExpressionFactory(nameof(__BuildCreateStorm))]
        public IBodyWorkflowAction<CreateStormResponse> CreateStorm([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodyplan, [WorkflowExpression] Func<string> bodygoals = null, [WorkflowExpression] Func<bool> bodyideacreator = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateStormResponse> __BuildCreateStorm(WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodyplan, WorkflowExpression<string> bodygoals = null, WorkflowExpression<bool> bodyideacreator = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodyplan, nameof(bodyplan), required: true);
            WorkflowExpression.Validate(bodygoals, nameof(bodygoals), required: false);
            WorkflowExpression.Validate(bodyideacreator, nameof(bodyideacreator), required: false);
            return new DeferredBodyAction<CreateStormResponse>(() =>
            {
                var apiCallPath = "/storms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["plan"] = ExpressionConverter.ConvertO(bodyplan);
                if (bodygoals != null)
                {
                    body["goals"] = ExpressionConverter.ConvertO(bodygoals);
                    bodypropCount++;
                }

                if (bodyideacreator != null)
                {
                    if (bodyideacreator != null)
                    {
                        body["ideacreator"] = ExpressionConverter.ConvertO(bodyideacreator);
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

                return new ApiConnectionAction<CreateStormResponse>(callPayload);
            });
        }
    }

    public class StormboardTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger LegendChange(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger IdeaSection(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger IdeaCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger IdeaDeleted(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
        }

        public IWorkflowTrigger CommentCreated(FlowRecurrence recurrence = null)
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

            return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "title")]
        Title
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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