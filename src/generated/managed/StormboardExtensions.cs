//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class StormboardActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateIdeaResponse> CreateIdea(Expression<Func<int>> bodystormid, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodydata, Expression<Func<bodycolorInput>> bodycolor)
        {
            var __workflow_bodystormid = bodystormid == null ? null : WorkflowExpression.Compile(bodystormid);
            WorkflowExpression.Validate(__workflow_bodystormid, nameof(bodystormid), required: true);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: true);
            var __workflow_bodydata = bodydata == null ? null : WorkflowExpression.Compile(bodydata);
            WorkflowExpression.Validate(__workflow_bodydata, nameof(bodydata), required: true);
            var __workflow_bodycolor = bodycolor == null ? null : WorkflowExpression.Compile(bodycolor);
            WorkflowExpression.Validate(__workflow_bodycolor, nameof(bodycolor), required: true);
            return new DeferredBodyAction<CreateIdeaResponse>(() =>
            {
                var apiCallPath = "/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stormid"] = ExpressionConverter.ConvertO(__workflow_bodystormid);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["data"] = ExpressionConverter.ConvertO(__workflow_bodydata);
                bodypropCount++;
                body["color"] = ExpressionConverter.ConvertO(__workflow_bodycolor);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateStormResponse> CreateStorm(Expression<Func<string>> bodytitle, Expression<Func<string>> bodyplan, Expression<Func<string>> bodygoals = null, Expression<Func<bool>> bodyideacreator = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodyplan = bodyplan == null ? null : WorkflowExpression.Compile(bodyplan);
            WorkflowExpression.Validate(__workflow_bodyplan, nameof(bodyplan), required: true);
            var __workflow_bodygoals = bodygoals == null ? null : WorkflowExpression.Compile(bodygoals);
            WorkflowExpression.Validate(__workflow_bodygoals, nameof(bodygoals), required: false);
            var __workflow_bodyideacreator = bodyideacreator == null ? null : WorkflowExpression.Compile(bodyideacreator);
            WorkflowExpression.Validate(__workflow_bodyideacreator, nameof(bodyideacreator), required: false);
            return new DeferredBodyAction<CreateStormResponse>(() =>
            {
                var apiCallPath = "/storms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["plan"] = ExpressionConverter.ConvertO(__workflow_bodyplan);
                if (__workflow_bodygoals != null)
                {
                    body["goals"] = ExpressionConverter.ConvertO(__workflow_bodygoals);
                    bodypropCount++;
                }

                if (__workflow_bodyideacreator != null)
                {
                    if (__workflow_bodyideacreator != null)
                    {
                        body["ideacreator"] = ExpressionConverter.ConvertO(__workflow_bodyideacreator);
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
