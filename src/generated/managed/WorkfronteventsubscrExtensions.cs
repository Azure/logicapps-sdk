//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Workfronteventsubscr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WorkfronteventsubscrActions([ConnectionName] string connectionId)
    {
    }

    public class WorkfronteventsubscrTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<OnWorkfrontEventResponse> OnWorkfrontEvent([WorkflowExpression] Func<bodyobjectTypeInput> bodyobjectType, [WorkflowExpression] Func<bodyeventTypeInput> bodyeventType, [WorkflowExpression] Func<bodyeventFiltersInputItem[]> bodyeventFilters = null, [WorkflowExpression] Func<bodyfilterConnectorInput> bodyfilterConnector = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/attask/eventsubscription/api/v1/subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objCode"] = SourceExpressionConverter.Convert(bodyobjectType);
                bodypropCount++;
                body["eventType"] = SourceExpressionConverter.Convert(bodyeventType);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyeventFilters != null)
                {
                    body["filters"] = SourceExpressionConverter.ConvertToken(bodyeventFilters);
                    bodypropCount++;
                }

                if (bodyfilterConnector != null)
                {
                    if (bodyfilterConnector != null)
                    {
                        body["filterConnector"] = SourceExpressionConverter.Convert(bodyfilterConnector);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<OnWorkfrontEventResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class OnWorkfrontEventResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

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

    public enum bodyeventFiltersInputItemStateType
    {
        [EnumMember(Value = "newState")]
        NewState,
        [EnumMember(Value = "oldState")]
        OldState
    }

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