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
        public IBodyWorkflowAction<CreateIdeaResponse, ApiConnectionActionConfiguration> CreateIdea(Expression<Func<CreateIdeaBodyInput>> body = null)
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
        public IBodyWorkflowAction<CreateStormResponse, ApiConnectionActionConfiguration> CreateStorm(Expression<Func<CreateStormBodyInput>> body = null)
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
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> LegendChange(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new LegendChangeBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaSection(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaSection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new IdeaSectionBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new IdeaCreatedBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> IdeaDeleted(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/ideaDeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = Convert.ToString("application/json");
                callPayload.Body = new IdeaDeletedBodyInput().ToJToken();
                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> CommentCreated(FlowRecurrence recurrence = null)
        {
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks/commentCreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Body = new CommentCreatedBodyInput().ToJToken();
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

    public class CreateIdeaBodyInput
    {
        [JsonProperty("stormid", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Stormid { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputTypeType Type { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard.BodyInputTypeType.Text;

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }

        [JsonProperty("color", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputColorType Color { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Stormboard.BodyInputColorType.Yellow;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "title")]
        Title
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputColorType
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

    public class CreateStormBodyInput
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

    public class LegendChangeBodyInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.color";
    }

    public class IdeaSectionBodyInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.section";
    }

    public class IdeaCreatedBodyInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.create";
    }

    public class IdeaDeletedBodyInput
    {
        [JsonProperty("service", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Service { get; set; } = "MicrosoftFlow";

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("events", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Events { get; set; } = "idea.delete";
    }

    public class CommentCreatedBodyInput
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