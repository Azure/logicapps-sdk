//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkfronteventsubscrActions([ConnectionName] string connectionId)
    {
    }

    public class WorkfronteventsubscrTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnWorkfrontEventResponse, ApiConnectionTriggerConfiguration> OnWorkfrontEvent(Expression<Func<OnWorkfrontEventInput>> body, FlowRecurrence recurrence = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<OnWorkfrontEventResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/attask/eventsubscription/api/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionTrigger<OnWorkfrontEventResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class OnWorkfrontEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class OnWorkfrontEventInput
    {
        [JsonProperty("objCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnWorkfrontEventInputObjectTypeType ObjectType { get; set; }

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnWorkfrontEventInputEventTypeType EventType { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public OnWorkfrontEventInputEventFiltersTypeItem[] EventFilters { get; set; }

        [JsonProperty("filterConnector", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnWorkfrontEventInputFilterConnectorType? FilterConnector { get; set; } = OnWorkfrontEventInputFilterConnectorType.AND;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnWorkfrontEventInputObjectTypeType
    {
        PROJ,
        [EnumMember(Value = "TASK")]
        TaskObject,
        OPTASK,
        USER,
        DOCU,
        PORT,
        PRGM,
        TMPL,
        TMTSK,
        HOUR,
        NOTE,
        APPROVAL,
        ASSGN,
        EXPNS,
        CUSTRECORD
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnWorkfrontEventInputEventTypeType
    {
        CREATE,
        UPDATE,
        DELETE
    }

    public class OnWorkfrontEventInputEventFiltersTypeItem
    {
        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("fieldValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldValue { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnWorkfrontEventInputEventFiltersTypeItemStateType? State { get; set; } = OnWorkfrontEventInputEventFiltersTypeItemStateType.NewState;

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public OnWorkfrontEventInputEventFiltersTypeItemComparisonOperatorType? ComparisonOperator { get; set; } = OnWorkfrontEventInputEventFiltersTypeItemComparisonOperatorType.Eq;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnWorkfrontEventInputEventFiltersTypeItemStateType
    {
        [EnumMember(Value = "newState")]
        NewState,
        [EnumMember(Value = "oldState")]
        OldState
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnWorkfrontEventInputEventFiltersTypeItemComparisonOperatorType
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "ne")]
        Ne,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "lte")]
        Lte,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "gte")]
        Gte,
        [EnumMember(Value = "contains")]
        Contains
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OnWorkfrontEventInputFilterConnectorType
    {
        AND,
        OR
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr;

    public partial class WorkflowManagedActions
    {
        public WorkfronteventsubscrActions Workfronteventsubscr(string connectionId) => new WorkfronteventsubscrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WorkfronteventsubscrTriggers Workfronteventsubscr(string connectionId) => new WorkfronteventsubscrTriggers(connectionId);
    }
}