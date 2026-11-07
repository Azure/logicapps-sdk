//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Receptful
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ReceptfulActions([ConnectionName] string connectionId)
    {
    }

    public class ReceptfulTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<VisitEventsResponse, ApiConnectionPollingTriggerConfiguration> VisitEvents(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<VisitEventsResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/hooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<VisitEventsResponse>(callPayload);
            });
        }
    }

    public class VisitEventsResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("event", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventType Event { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Receptful.BodyInputEventType.CheckedIn;

        [JsonProperty("source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Source { get; set; } = "microsoft";

        [JsonProperty("region_id")]
        public string RegionId { get; set; }

        [JsonProperty("location_id")]
        public string LocationId { get; set; }

        [JsonProperty("button_id")]
        public string ButtonId { get; set; }

        [JsonProperty("config_id")]
        public string ConfigId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventType
    {
        [EnumMember(Value = "checked_in")]
        CheckedIn,
        [EnumMember(Value = "checked_out")]
        CheckedOut,
        [EnumMember(Value = "delivered")]
        Delivered,
        [EnumMember(Value = "discarded")]
        Discarded,
        [EnumMember(Value = "incinerated")]
        Incinerated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Receptful;

    public partial class WorkflowManagedActions
    {
        public ReceptfulActions Receptful(string connectionId) => new ReceptfulActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ReceptfulTriggers Receptful(string connectionId) => new ReceptfulTriggers(connectionId);
    }
}