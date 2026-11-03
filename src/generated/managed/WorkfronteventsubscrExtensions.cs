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
        public IBodyWorkflowTrigger<OnWorkfrontEventResponse, ApiConnectionTriggerConfiguration> OnWorkfrontEvent(Expression<Func<bodyobjectTypeInput>> bodyobjectType, Expression<Func<bodyeventTypeInput>> bodyeventType, Expression<Func<bodyeventFiltersInputItem[]>> bodyeventFilters = null, Expression<Func<bodyfilterConnectorInput>> bodyfilterConnector = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyobjectType = WorkflowExpression.Compile(bodyobjectType, nameof(bodyobjectType), required: true);
            var __workflow_bodyeventType = WorkflowExpression.Compile(bodyeventType, nameof(bodyeventType), required: true);
            var __workflow_bodyeventFilters = WorkflowExpression.Compile(bodyeventFilters, nameof(bodyeventFilters), required: false);
            var __workflow_bodyfilterConnector = WorkflowExpression.Compile(bodyfilterConnector, nameof(bodyfilterConnector), required: false);
            return new DeferredBodyTrigger<OnWorkfrontEventResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/attask/eventsubscription/api/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objCode"] = ExpressionConverter.ConvertO(__workflow_bodyobjectType);
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (__workflow_bodyeventFilters != null)
                {
                    body["filters"] = ExpressionConverter.ConvertO(__workflow_bodyeventFilters);
                    bodypropCount++;
                }

                if (__workflow_bodyfilterConnector != null)
                {
                    if (__workflow_bodyfilterConnector != null)
                    {
                        body["filterConnector"] = ExpressionConverter.ConvertO(__workflow_bodyfilterConnector);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["filterConnector"] = "AND";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyobjectTypeInput
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
    public enum bodyeventTypeInput
    {
        CREATE,
        UPDATE,
        DELETE
    }

    public class bodyeventFiltersInputItem
    {
        [JsonProperty("fieldName")]
        public string FieldName { get; set; }

        [JsonProperty("fieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("state")]
        public bodyeventFiltersInputItemStateType State { get; set; }

        [JsonProperty("comparison")]
        public bodyeventFiltersInputItemComparisonOperatorType ComparisonOperator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventFiltersInputItemStateType
    {
        [EnumMember(Value = "newState")]
        NewState,
        [EnumMember(Value = "oldState")]
        OldState
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyeventFiltersInputItemComparisonOperatorType
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
    public enum bodyfilterConnectorInput
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