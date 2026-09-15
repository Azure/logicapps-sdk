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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(workItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<WorkItemGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<DeleteWorkItemResponse> DeleteWorkItem(Expression<Func<string>> id)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}/", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DeleteWorkItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateIncident(Expression<Func<string>> bodyclassification, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodyimpact, Expression<Func<string>> bodysource, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/Incident";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            bodypropCount++;
            body["Classification"] = CSharpExpressionConverter.ConvertToken(bodyclassification);
            bodypropCount++;
            body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
            bodypropCount++;
            body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
            bodypropCount++;
            body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = CSharpExpressionConverter.ConvertToken(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateIncident(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Incident/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["Classification"] = CSharpExpressionConverter.ConvertToken(bodyclassification);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = CSharpExpressionConverter.ConvertToken(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateServiceRequest(Expression<Func<string>> bodyarea, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodysource, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ServiceRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            bodypropCount++;
            body["Area"] = CSharpExpressionConverter.ConvertToken(bodyarea);
            bodypropCount++;
            body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
            bodypropCount++;
            body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = CSharpExpressionConverter.ConvertToken(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateServiceRequest(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ServiceRequest/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyclassification != null)
            {
                body["Classification"] = CSharpExpressionConverter.ConvertToken(bodyclassification);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodysupportGroup != null)
            {
                body["SupportGroup"] = CSharpExpressionConverter.ConvertToken(bodysupportGroup);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyaffectedUser != null)
            {
                body["RequestedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyaffectedUser);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateChangeRequest(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ChangeRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = CSharpExpressionConverter.ConvertToken(bodyarea);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = CSharpExpressionConverter.ConvertToken(bodyrisk);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateChangeRequest(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ChangeRequest/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodyarea != null)
            {
                body["Area"] = CSharpExpressionConverter.ConvertToken(bodyarea);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = CSharpExpressionConverter.ConvertToken(bodyrisk);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateProblem(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/Problem";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateProblem(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Problem/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["Source"] = CSharpExpressionConverter.ConvertToken(bodysource);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyurgency != null)
            {
                body["Urgency"] = CSharpExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateReleaseRecord(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = "/api/CloudConnector/ReleaseRecord";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = CSharpExpressionConverter.ConvertToken(bodyrisk);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateReleaseRecord(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ReleaseRecord/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytitle != null)
            {
                body["Title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["Type"] = CSharpExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
            }

            if (bodycategory != null)
            {
                body["Category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
                bodypropCount++;
            }

            if (bodyimpact != null)
            {
                body["Impact"] = CSharpExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
            }

            if (bodyrisk != null)
            {
                body["Risk"] = CSharpExpressionConverter.ConvertToken(bodyrisk);
                bodypropCount++;
            }

            if (bodypriority != null)
            {
                body["Priority"] = CSharpExpressionConverter.ConvertToken(bodypriority);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyassignedUser != null)
            {
                body["AssignedWorkItem"] = CSharpExpressionConverter.ConvertToken(bodyassignedUser);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemActionLogResponse> AddCommentLog(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyenteredBy = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<bodyactionTypeInput>> bodyactionType = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/cloudconnector/workItems/{0}/ActionLogComment", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["Description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyenteredBy != null)
            {
                body["EnteredBy"] = CSharpExpressionConverter.ConvertToken(bodyenteredBy);
                bodypropCount++;
            }

            if (bodyisPrivate != null)
            {
                body["IsPrivate"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
            }

            if (bodyactionType != null)
            {
                body["ActionType"] = CSharpExpressionConverter.Convert(bodyactionType);
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
        public IBodyWorkflowTrigger<WebhookSettings> CreateWebhook(Expression<Func<bodywebhookSettingsworkItemClassTypeInput>> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/platform/api/CreateWebhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webhookSettingsObject = new JObject();
            var webhookSettingsObjectpropCount = 0;
            webhookSettingsObject["Url"] = "@listCallbackUrl()";
            webhookSettingsObjectpropCount++;
            if (bodywebhookSettingsworkItemClassType != null)
            {
                if (bodywebhookSettingsworkItemClassType != null)
                {
                    webhookSettingsObject["WorkItemClassType"] = CSharpExpressionConverter.Convert(bodywebhookSettingsworkItemClassType);
                    webhookSettingsObjectpropCount++;
                }

                webhookSettingsObjectpropCount++;
            }
            else
            {
                webhookSettingsObject["WorkItemClassType"] = "Incident";
                webhookSettingsObjectpropCount++;
            }

            if (webhookSettingsObjectpropCount > 0)
            {
                body["webhookSettings"] = webhookSettingsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSettings>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSettings> CreateActionLogWebhook(Expression<Func<bodywebhookSettingsworkItemClassTypeInput>> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/platform/api/CreateActionLogWebhooks";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            var webhookSettingsObject = new JObject();
            var webhookSettingsObjectpropCount = 0;
            webhookSettingsObject["Url"] = "@listCallbackUrl()";
            webhookSettingsObjectpropCount++;
            if (bodywebhookSettingsworkItemClassType != null)
            {
                if (bodywebhookSettingsworkItemClassType != null)
                {
                    webhookSettingsObject["WorkItemClassType"] = CSharpExpressionConverter.Convert(bodywebhookSettingsworkItemClassType);
                    webhookSettingsObjectpropCount++;
                }

                webhookSettingsObjectpropCount++;
            }
            else
            {
                webhookSettingsObject["WorkItemClassType"] = "Analyst Comment";
                webhookSettingsObjectpropCount++;
            }

            if (webhookSettingsObjectpropCount > 0)
            {
                body["webhookSettings"] = webhookSettingsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<WebhookSettings>(callPayload, triggerName, recurrence);
        }
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

    public enum bodyactionTypeInput
    {
        [EnumMember(Value = "Analyst Comment")]
        AnalystComment,
        [EnumMember(Value = "End User Comment")]
        EndUserComment
    }

    public class WebhookSettings
    {
        [JsonProperty("Guid")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string ActionType { get; set; }
        public string SaveType { get; set; }
        public bool Enable { get; set; }
        public string WorkItemClassType { get; set; }
        public int WebHookClass { get; set; }
        public bool IsDeleted { get; set; }
        public int ModifiedById { get; set; }
        public string ModifiedDate { get; set; }
        public int CreatedById { get; set; }
        public string CreatedDate { get; set; }
    }

    public enum bodywebhookSettingsworkItemClassTypeInput
    {
        [EnumMember(Value = "Analyst Comment")]
        AnalystComment,
        [EnumMember(Value = "EndUser Comment")]
        EndUserComment
    }
}

namespace Microsoft.Azure.Workflows.Sdk
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