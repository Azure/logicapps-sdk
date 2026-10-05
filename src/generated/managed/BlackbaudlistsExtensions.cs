//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudlists
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudlistsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        [WorkflowExpressionFactory(nameof(__BuildAppendIDsToList))]
        public IWorkflowAction AppendIDsToList([WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<string> bodylist, [WorkflowExpression] Func<string[]> bodyiDS)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAppendIDsToList(WorkflowValue<bodylistTypeInput> bodylistType, WorkflowValue<string> bodylist, WorkflowValue<string[]> bodyiDS)
        {
            WorkflowValue.Validate(bodylistType, nameof(bodylistType), required: true);
            WorkflowValue.Validate(bodylist, nameof(bodylist), required: true);
            WorkflowValue.Validate(bodyiDS, nameof(bodyiDS), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/list/v1/appendidstolist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(bodylistType);
                bodypropCount++;
                body["list_id"] = ExpressionConverter.ConvertO(bodylist);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudlists")]
        [WorkflowExpressionFactory(nameof(__BuildCreateListFromIDs))]
        public IBodyWorkflowAction<ListApiCreatedList> CreateListFromIDs([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<bodylistTypeInput> bodylistType, [WorkflowExpression] Func<bodypermissionsInput> bodypermissions, [WorkflowExpression] Func<string[]> bodyiDS)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListApiCreatedList> __BuildCreateListFromIDs(WorkflowValue<string> bodyname, WorkflowValue<string> bodydescription, WorkflowValue<bodylistTypeInput> bodylistType, WorkflowValue<bodypermissionsInput> bodypermissions, WorkflowValue<string[]> bodyiDS)
        {
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowValue.Validate(bodylistType, nameof(bodylistType), required: true);
            WorkflowValue.Validate(bodypermissions, nameof(bodypermissions), required: true);
            WorkflowValue.Validate(bodyiDS, nameof(bodyiDS), required: true);
            return new DeferredBodyAction<ListApiCreatedList>(() =>
            {
                var apiCallPath = "/list/v1/createlistfromids";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
                body["list_type"] = ExpressionConverter.ConvertO(bodylistType);
                bodypropCount++;
                body["list_permissions"] = ExpressionConverter.ConvertO(bodypermissions);
                bodypropCount++;
                body["ids"] = ExpressionConverter.ConvertO(bodyiDS);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ListApiCreatedList>(callPayload);
            });
        }
    }

    public class BlackbaudlistsTriggers([ConnectionName] string connectionId)
    {
    }

    public enum bodylistTypeInput
    {
        Constituent,
        Gift,
        Action,
        Opportunity
    }

    public class ListApiCreatedList
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodypermissionsInput
    {
        OnlyOwnerCanAccess,
        OthersCanView,
        OthersCanViewAndEdit
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudlists;

    public partial class WorkflowManagedActions
    {
        public BlackbaudlistsActions Blackbaudlists(string connectionId) => new BlackbaudlistsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudlistsTriggers Blackbaudlists(string connectionId) => new BlackbaudlistsTriggers(connectionId);
    }
}
