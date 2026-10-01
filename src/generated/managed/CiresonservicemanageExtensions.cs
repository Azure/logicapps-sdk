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
        public IBodyWorkflowAction<WorkItemGetResponse> GetWorkItem([WorkflowExpression] Func<string> workItemId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(workItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<DeleteWorkItemResponse> DeleteWorkItem([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DeleteWorkItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateIncident([WorkflowExpression] Func<string> bodyclassification, [WorkflowExpression] Func<string> bodyurgency, [WorkflowExpression] Func<string> bodyimpact, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloudConnector/Incident";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Classification"] = SourceExpressionConverter.ConvertToken(bodyclassification);
                bodypropCount++;
                body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
                body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                bodypropCount++;
                body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                if (bodysupportGroup != null)
                {
                    body["SupportGroup"] = SourceExpressionConverter.ConvertToken(bodysupportGroup);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyaffectedUser);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyclassification = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Incident/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyclassification != null)
                {
                    body["Classification"] = SourceExpressionConverter.ConvertToken(bodyclassification);
                    bodypropCount++;
                }

                if (bodyurgency != null)
                {
                    body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodysupportGroup != null)
                {
                    body["SupportGroup"] = SourceExpressionConverter.ConvertToken(bodysupportGroup);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyaffectedUser);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateServiceRequest([WorkflowExpression] Func<string> bodyarea, [WorkflowExpression] Func<string> bodyurgency, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloudConnector/ServiceRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Area"] = SourceExpressionConverter.ConvertToken(bodyarea);
                bodypropCount++;
                body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                bodypropCount++;
                body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                if (bodysupportGroup != null)
                {
                    body["SupportGroup"] = SourceExpressionConverter.ConvertToken(bodysupportGroup);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyaffectedUser);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateServiceRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyclassification = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ServiceRequest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyclassification != null)
                {
                    body["Classification"] = SourceExpressionConverter.ConvertToken(bodyclassification);
                    bodypropCount++;
                }

                if (bodyurgency != null)
                {
                    body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodysupportGroup != null)
                {
                    body["SupportGroup"] = SourceExpressionConverter.ConvertToken(bodysupportGroup);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyaffectedUser);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateChangeRequest([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloudConnector/ChangeRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyarea != null)
                {
                    body["Area"] = SourceExpressionConverter.ConvertToken(bodyarea);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyrisk != null)
                {
                    body["Risk"] = SourceExpressionConverter.ConvertToken(bodyrisk);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateChangeRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ChangeRequest/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodyarea != null)
                {
                    body["Area"] = SourceExpressionConverter.ConvertToken(bodyarea);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyrisk != null)
                {
                    body["Risk"] = SourceExpressionConverter.ConvertToken(bodyrisk);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateProblem([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloudConnector/Problem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyurgency != null)
                {
                    body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateProblem([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Problem/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["Source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyurgency != null)
                {
                    body["Urgency"] = SourceExpressionConverter.ConvertToken(bodyurgency);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedIRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateReleaseRecord([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloudConnector/ReleaseRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["Type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyrisk != null)
                {
                    body["Risk"] = SourceExpressionConverter.ConvertToken(bodyrisk);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateReleaseRecord([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ReleaseRecord/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["Type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodycategory != null)
                {
                    body["Category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyimpact != null)
                {
                    body["Impact"] = SourceExpressionConverter.ConvertToken(bodyimpact);
                    bodypropCount++;
                }

                if (bodyrisk != null)
                {
                    body["Risk"] = SourceExpressionConverter.ConvertToken(bodyrisk);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.ConvertToken(bodypriority);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = SourceExpressionConverter.ConvertToken(bodyassignedUser);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemCreatedSRResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemActionLogResponse> AddCommentLog([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyenteredBy = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<bodyactionTypeInput> bodyactionType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/cloudconnector/workItems/{0}/ActionLogComment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["Description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyenteredBy != null)
                {
                    body["EnteredBy"] = SourceExpressionConverter.ConvertToken(bodyenteredBy);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["IsPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodyactionType != null)
                {
                    body["ActionType"] = SourceExpressionConverter.Convert(bodyactionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorkItemActionLogResponse>(BuildSourceInput);
        }
    }

    public class CiresonservicemanageTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<WebhookSettings> CreateWebhook([WorkflowExpression] Func<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/platform/api/CreateWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webhookSettingsObject = new JObject();
                var webhookSettingsObjectpropCount = 0;
                webhookSettingsObject["Url"] = "#{listCallbackUrl()}";
                webhookSettingsObjectpropCount++;
                if (bodywebhookSettingsworkItemClassType != null)
                {
                    if (bodywebhookSettingsworkItemClassType != null)
                    {
                        webhookSettingsObject["WorkItemClassType"] = SourceExpressionConverter.Convert(bodywebhookSettingsworkItemClassType);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSettings>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<WebhookSettings> CreateActionLogWebhook([WorkflowExpression] Func<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/platform/api/CreateActionLogWebhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                var webhookSettingsObject = new JObject();
                var webhookSettingsObjectpropCount = 0;
                webhookSettingsObject["Url"] = "#{listCallbackUrl()}";
                webhookSettingsObjectpropCount++;
                if (bodywebhookSettingsworkItemClassType != null)
                {
                    if (bodywebhookSettingsworkItemClassType != null)
                    {
                        webhookSettingsObject["WorkItemClassType"] = SourceExpressionConverter.Convert(bodywebhookSettingsworkItemClassType);
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
                return callPayload;
            }

            return new ApiConnectionTrigger<WebhookSettings>(BuildSourceInput, triggerName, recurrence);
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