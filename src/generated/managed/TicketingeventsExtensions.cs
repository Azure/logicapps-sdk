//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ticketingevents
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TicketingeventsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ticketingevents")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CreateListItem(Expression<Func<double>> eventId, Expression<Func<object>> dynamicListSchema = null)
        {
            var __workflow_eventId = WorkflowExpression.Compile(eventId, nameof(eventId), required: true);
            var __workflow_dynamicListSchema = WorkflowExpression.Compile(dynamicListSchema, nameof(dynamicListSchema), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/app/flow/addTicket/{0}", __workflow_eventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_dynamicListSchema != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_dynamicListSchema);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class TicketingeventsTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ticketingevents;

    public partial class WorkflowManagedActions
    {
        public TicketingeventsActions Ticketingevents(string connectionId) => new TicketingeventsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TicketingeventsTriggers Ticketingevents(string connectionId) => new TicketingeventsTriggers(connectionId);
    }
}