//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Assentlyesign
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AssentlyesignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken> GetCase([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/getCase";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
            callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken[]> FindCases([WorkflowExpression] Func<object> findCasesModel = null)
        {
            var apiCallPath = "/v2/findCases";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["includeAllStatuses"] = Convert.ToString(true);
            callPayload.Queries["IncludePendingApprovalStatus"] = Convert.ToString(true);
            callPayload.Body = ExpressionConverter.ConvertO(findCasesModel);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<JToken[]> FindTemplates([WorkflowExpression] Func<object> findTemplatesModel = null)
        {
            var apiCallPath = "/v2/findTemplates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(findTemplatesModel);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction CreateCase([WorkflowExpression] Func<object> caseModel = null)
        {
            var apiCallPath = "/v2/createCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(caseModel);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction CreateCaseFromTemplate([WorkflowExpression] Func<object> createCaseFromTemplateModel = null)
        {
            var apiCallPath = "/v2/createCaseFromTemplate";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(createCaseFromTemplateModel);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction UpdateCase()
        {
            var apiCallPath = "/v2/updateCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var caseModel = new JObject();
            var caseModelpropCount = 0;
            if (caseModelpropCount > 0)
            {
                callPayload.Body = caseModel;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction UpdateCaseMetadata([WorkflowExpression] Func<object> updateCaseMetadataModel = null)
        {
            var apiCallPath = "/v2/updateCaseMetadata";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(updateCaseMetadataModel);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction SendCase([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/sendCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RequestApproval([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/requestApproval";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RemindCase([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/remindCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction DeleteCase([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/deleteCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction RecallCase([WorkflowExpression] Func<string> id)
        {
            var apiCallPath = "/v2/recallCase";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IWorkflowAction GetCaseByTemporaryId([WorkflowExpression] Func<int> id)
        {
            var apiCallPath = "/v2/getCaseByTemporaryId";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["Id"] = ExpressionConverter.Convert(id);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "assentlyesign")]
        public IBodyWorkflowAction<string> GetFileOfCase([WorkflowExpression] Func<string> caseid, [WorkflowExpression] Func<string> documentid)
        {
            var apiCallPath = "/v2/getdocumentdata";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["caseid"] = ExpressionConverter.Convert(caseid);
            callPayload.Queries["documentid"] = ExpressionConverter.Convert(documentid);
            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class AssentlyesignTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger CaseEventTrigger([WorkflowExpression] Func<string> eventPath, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/hook/v1/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["EventPath"] = ExpressionConverter.Convert(eventPath);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Assentlyesign;

    public partial class WorkflowManagedActions
    {
        public AssentlyesignActions Assentlyesign(string connectionId) => new AssentlyesignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AssentlyesignTriggers Assentlyesign(string connectionId) => new AssentlyesignTriggers(connectionId);
    }
}