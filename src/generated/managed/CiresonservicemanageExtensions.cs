//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiresonservicemanageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemGetResponse> GetWorkItem(Expression<Func<string>> workItemId)
        {
            var apiCallPath = String.Format("/api/CloudConnector/WorkItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(workItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkItemGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<DeleteWorkItemResponse> DeleteWorkItem(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/api/CloudConnector/WorkItems/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteWorkItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateIncident(Expression<Func<string>> bodyclassification, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodyimpact, Expression<Func<string>> bodysource, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyPriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/Incident";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            bodypropCount++;
            body["Classification"] = ExpressionConverter.ConvertO(bodyclassification);
            bodypropCount++;
            body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
            bodypropCount++;
            body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
            bodypropCount++;
            body["Source"] = ExpressionConverter.ConvertO(bodysource);
            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = ExpressionConverter.ConvertO(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = ExpressionConverter.ConvertO(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateIncident(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyPriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = String.Format("/api/CloudConnector/Incident/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["Classification"] = ExpressionConverter.ConvertO(bodyclassification);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = ExpressionConverter.ConvertO(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = ExpressionConverter.ConvertO(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateServiceRequest(Expression<Func<string>> bodyarea, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodysource, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ServiceRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            bodypropCount++;
            body["Area"] = ExpressionConverter.ConvertO(bodyarea);
            bodypropCount++;
            body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
            bodypropCount++;
            body["Source"] = ExpressionConverter.ConvertO(bodysource);
            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = ExpressionConverter.ConvertO(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = ExpressionConverter.ConvertO(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateServiceRequest(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<int>> bodyPriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = String.Format("/api/CloudConnector/ServiceRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["Classification"] = ExpressionConverter.ConvertO(bodyclassification);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = ExpressionConverter.ConvertO(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = ExpressionConverter.ConvertO(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateChangeRequest(Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ChangeRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyarea);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = ExpressionConverter.ConvertO(bodyrisk);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateChangeRequest(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = String.Format("/api/CloudConnector/ChangeRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = ExpressionConverter.ConvertO(bodyarea);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = ExpressionConverter.ConvertO(bodyrisk);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateProblem(Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/Problem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateProblem(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyPriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = String.Format("/api/CloudConnector/Problem/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyPriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodyPriority);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = ExpressionConverter.ConvertO(bodyurgency);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateReleaseRecord(Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ReleaseRecord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = ExpressionConverter.ConvertO(bodyrisk);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateReleaseRecord(Expression<Func<string>> id, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = String.Format("/api/CloudConnector/ReleaseRecord/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = ExpressionConverter.ConvertO(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = ExpressionConverter.ConvertO(bodyrisk);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = ExpressionConverter.ConvertO(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemActionLogResponse> AddCommentLog(Expression<Func<string>> id, Expression<Func<string>> bodyDescription = null, Expression<Func<string>> bodyEnteredBy = null, Expression<Func<bool>> bodyIsPrivate = null, Expression<Func<bodyActionTypeInput>> bodyActionType = null)
        {
            var apiCallPath = String.Format("/api/cloudconnector/workItems/{0}/ActionLogComment", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyDescription != null)
            {
                body["Description"] = ExpressionConverter.ConvertO(bodyDescription);
                bodypropCount++;
            }

            if (bodyEnteredBy != null)
            {
                body["EnteredBy"] = ExpressionConverter.ConvertO(bodyEnteredBy);
                bodypropCount++;
            }

            if (bodyIsPrivate != null)
            {
                body["IsPrivate"] = ExpressionConverter.ConvertO(bodyIsPrivate);
                bodypropCount++;
            }

            if (bodyActionType != null)
            {
                body["ActionType"] = ExpressionConverter.ConvertO(bodyActionType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemActionLogResponse>(callPayload);
        }
    }

    public class CiresonservicemanageTriggers([ConnectionName] string connectionId)
    {
    }

    public class WorkItemGetResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PriorityText { get; set; }
        public JToken Classification { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class DeleteWorkItemResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
        public string BaseId { get; set; }
    }

    public class WorkItemCreatedIRResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class WorkItemCreatedSRResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public JToken Priority { get; set; }
        public JToken Classification { get; set; }
        public JToken Urgency { get; set; }
        public JToken Impact { get; set; }
        public JToken Source { get; set; }
        public JToken SupportGroup { get; set; }
        public JToken Status { get; set; }
        public JToken AssignedWorkItem { get; set; }
        public JToken RequestedWorkItem { get; set; }
    }

    public class WorkItemActionLogResponse
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public JToken AppliesToTroubleTicket { get; set; }
        public JToken AppliesToWorkItem { get; set; }
    }

    public enum bodyActionTypeInput
    {
        [EnumMember(Value = "Analyst Comment")]
        AnalystComment,
        [EnumMember(Value = "End User Comment")]
        EndUserComment
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage;

    public partial class WorkflowManagedActions
    {
        public CiresonservicemanageActions Ciresonservicemanage(string connectionId) => new CiresonservicemanageActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CiresonservicemanageTriggers Ciresonservicemanage(string connectionId) => new CiresonservicemanageTriggers(connectionId);
    }
}