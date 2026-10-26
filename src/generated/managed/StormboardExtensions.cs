//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class StormboardActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateIdeaResponse, ApiConnectionActionConfiguration> CreateIdea(Expression<Func<CreateIdeaInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateIdeaResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ideas";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateIdeaResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "stormboard")]
        public IBodyWorkflowAction<CreateStormResponse, ApiConnectionActionConfiguration> CreateStorm(Expression<Func<CreateStormInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateStormResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storms";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateStormResponse>(callPayload);
            });
        }
    }

    public class StormboardTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> LegendChange(Expression<Func<LegendChangeInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaSection(Expression<Func<IdeaSectionInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaSection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaCreated(Expression<Func<IdeaCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaDeleted(Expression<Func<IdeaDeletedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CommentCreated(Expression<Func<CommentCreatedInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/commentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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

    public class CreateIdeaInput
    {
        [JsonProperty("stormid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Stormid { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateIdeaInputTypeType Type { get; set; } = CreateIdeaInputTypeType.Text;

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateIdeaInputColorType Color { get; set; } = CreateIdeaInputColorType.Yellow;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateIdeaInputTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "title")]
        Title
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateIdeaInputColorType
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

    public class CreateStormInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("plan", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Plan { get; set; } = "0";

        [JsonProperty("goals")]
        public string Goals { get; set; }

        [JsonProperty("ideacreator", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? Ideacreator { get; set; } = true;
    }

    public class LegendChangeInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.color";
    }

    public class IdeaSectionInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.section";
    }

    public class IdeaCreatedInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.create";
    }

    public class IdeaDeletedInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.delete";
    }

    public class CommentCreatedInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "comment.create";
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