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
        public IBodyWorkflowTrigger<OnWorkfrontEventResponse, ApiConnectionPollingTriggerConfiguration> OnWorkfrontEvent(Expression<Func<BodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyTrigger<OnWorkfrontEventResponse, ApiConnectionPollingTriggerConfiguration>(() =>
            {
                var apiCallPath = "/attask/eventsubscription/api/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionPollingTrigger<OnWorkfrontEventResponse>(callPayload);
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

    public class BodyInput
    {
        public BodyInput(BodyInputObjectTypeType objectType, BodyInputEventTypeType eventType)
        {
            this.ObjectType = objectType;
            this.EventType = eventType;
        }

        [JsonProperty("objCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputObjectTypeType ObjectType { get; set; }

        [JsonProperty("eventType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventTypeType EventType { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Url { get; set; } = "#{listCallbackUrl()}";

        [JsonProperty("filters")]
        public BodyInputEventFiltersTypeItem[] EventFilters { get; set; }

        [JsonProperty("filterConnector", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputFilterConnectorType? FilterConnector { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr.BodyInputFilterConnectorType.And;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputObjectTypeType
    {
        [EnumMember(Value = "PROJ")]
        Proj,
        [EnumMember(Value = "TASK")]
        TaskObject,
        [EnumMember(Value = "OPTASK")]
        Optask,
        [EnumMember(Value = "USER")]
        User,
        [EnumMember(Value = "DOCU")]
        Docu,
        [EnumMember(Value = "PORT")]
        Port,
        [EnumMember(Value = "PRGM")]
        Prgm,
        [EnumMember(Value = "TMPL")]
        Tmpl,
        [EnumMember(Value = "TMTSK")]
        Tmtsk,
        [EnumMember(Value = "HOUR")]
        Hour,
        [EnumMember(Value = "NOTE")]
        Note,
        [EnumMember(Value = "APPROVAL")]
        Approval,
        [EnumMember(Value = "ASSGN")]
        Assgn,
        [EnumMember(Value = "EXPNS")]
        Expns,
        [EnumMember(Value = "CUSTRECORD")]
        Custrecord
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventTypeType
    {
        [EnumMember(Value = "CREATE")]
        Create,
        [EnumMember(Value = "UPDATE")]
        Update,
        [EnumMember(Value = "DELETE")]
        Delete
    }

    public class BodyInputEventFiltersTypeItem
    {
        public BodyInputEventFiltersTypeItem(string fieldName, string fieldValue)
        {
            this.FieldName = fieldName;
            this.FieldValue = fieldValue;
        }

        [JsonProperty("fieldName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty("fieldValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldValue { get; set; }

        [JsonProperty("state", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventFiltersTypeItemStateType? State { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr.BodyInputEventFiltersTypeItemStateType.NewState;

        [JsonProperty("comparison", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputEventFiltersTypeItemComparisonOperatorType? ComparisonOperator { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr.BodyInputEventFiltersTypeItemComparisonOperatorType.Eq;
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventFiltersTypeItemStateType
    {
        [EnumMember(Value = "newState")]
        NewState,
        [EnumMember(Value = "oldState")]
        OldState
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEventFiltersTypeItemComparisonOperatorType
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
    public enum BodyInputFilterConnectorType
    {
        [EnumMember(Value = "AND")]
        And,
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