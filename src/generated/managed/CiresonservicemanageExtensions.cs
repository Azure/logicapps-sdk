//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CiresonservicemanageActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildGetWorkItem))]
        public IBodyWorkflowAction<WorkItemGetResponse> GetWorkItem([WorkflowExpression] Func<string> workItemId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemGetResponse> __BuildGetWorkItem(WorkflowExpression<string> workItemId)
        {
            WorkflowExpression.Validate(workItemId, nameof(workItemId), required: true);
            return new DeferredBodyAction<WorkItemGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(workItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkItemGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWorkItem))]
        public IBodyWorkflowAction<DeleteWorkItemResponse> DeleteWorkItem([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteWorkItemResponse> __BuildDeleteWorkItem(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}/", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildCreateIncident))]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateIncident([WorkflowExpression] Func<string> bodyclassification, [WorkflowExpression] Func<string> bodyurgency, [WorkflowExpression] Func<string> bodyimpact, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> __BuildCreateIncident(WorkflowExpression<string> bodyclassification, WorkflowExpression<string> bodyurgency, WorkflowExpression<string> bodyimpact, WorkflowExpression<string> bodysource, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodypriority = null, WorkflowExpression<string> bodysupportGroup = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyaffectedUser = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(bodyclassification, nameof(bodyclassification), required: true);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: true);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: true);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysupportGroup, nameof(bodysupportGroup), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Incident";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateIncident))]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateIncident([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyclassification = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> __BuildUpdateIncident(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodypriority = null, WorkflowExpression<string> bodyclassification = null, WorkflowExpression<string> bodyurgency = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodysupportGroup = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyaffectedUser = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyclassification, nameof(bodyclassification), required: false);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodysupportGroup, nameof(bodysupportGroup), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Incident/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildCreateServiceRequest))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateServiceRequest([WorkflowExpression] Func<string> bodyarea, [WorkflowExpression] Func<string> bodyurgency, [WorkflowExpression] Func<string> bodysource, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildCreateServiceRequest(WorkflowExpression<string> bodyarea, WorkflowExpression<string> bodyurgency, WorkflowExpression<string> bodysource, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodysupportGroup = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyaffectedUser = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(bodyarea, nameof(bodyarea), required: true);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: true);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysupportGroup, nameof(bodysupportGroup), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ServiceRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateServiceRequest))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateServiceRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodypriority = null, [WorkflowExpression] Func<string> bodyclassification = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodysupportGroup = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyaffectedUser = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildUpdateServiceRequest(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<int> bodypriority = null, WorkflowExpression<string> bodyclassification = null, WorkflowExpression<string> bodyurgency = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodysupportGroup = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyaffectedUser = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyclassification, nameof(bodyclassification), required: false);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodysupportGroup, nameof(bodysupportGroup), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ServiceRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildCreateChangeRequest))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateChangeRequest([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildCreateChangeRequest(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodyarea = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyrisk = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyrisk, nameof(bodyrisk), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ChangeRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateChangeRequest))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateChangeRequest([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodyarea = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildUpdateChangeRequest(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodyarea = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyrisk = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodyarea, nameof(bodyarea), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyrisk, nameof(bodyrisk), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ChangeRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildCreateProblem))]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateProblem([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> __BuildCreateProblem(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyurgency = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Problem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateProblem))]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateProblem([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyurgency = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> __BuildUpdateProblem(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodysource = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyurgency = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyurgency, nameof(bodyurgency), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Problem/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(bodypriority);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildCreateReleaseRecord))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateReleaseRecord([WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildCreateReleaseRecord(WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyrisk = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyrisk, nameof(bodyrisk), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ReleaseRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateReleaseRecord))]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateReleaseRecord([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodyimpact = null, [WorkflowExpression] Func<string> bodyrisk = null, [WorkflowExpression] Func<string> bodypriority = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodyassignedUser = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> __BuildUpdateReleaseRecord(WorkflowExpression<string> id, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodytype = null, WorkflowExpression<string> bodycategory = null, WorkflowExpression<string> bodyimpact = null, WorkflowExpression<string> bodyrisk = null, WorkflowExpression<string> bodypriority = null, WorkflowExpression<string> bodystatus = null, WorkflowExpression<string> bodyassignedUser = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: false);
            WorkflowExpression.Validate(bodyimpact, nameof(bodyimpact), required: false);
            WorkflowExpression.Validate(bodyrisk, nameof(bodyrisk), required: false);
            WorkflowExpression.Validate(bodypriority, nameof(bodypriority), required: false);
            WorkflowExpression.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowExpression.Validate(bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ReleaseRecord/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [WorkflowExpressionFactory(nameof(__BuildAddCommentLog))]
        public IBodyWorkflowAction<WorkItemActionLogResponse> AddCommentLog([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyenteredBy = null, [WorkflowExpression] Func<bool> bodyisPrivate = null, [WorkflowExpression] Func<bodyactionTypeInput> bodyactionType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorkItemActionLogResponse> __BuildAddCommentLog(WorkflowExpression<string> id, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyenteredBy = null, WorkflowExpression<bool> bodyisPrivate = null, WorkflowExpression<bodyactionTypeInput> bodyactionType = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyenteredBy, nameof(bodyenteredBy), required: false);
            WorkflowExpression.Validate(bodyisPrivate, nameof(bodyisPrivate), required: false);
            WorkflowExpression.Validate(bodyactionType, nameof(bodyactionType), required: false);
            return new DeferredBodyAction<WorkItemActionLogResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/cloudconnector/workItems/{0}/ActionLogComment", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyenteredBy != null)
                {
                    body["EnteredBy"] = ExpressionConverter.ConvertO(bodyenteredBy);
                    bodypropCount++;
                }

                if (bodyisPrivate != null)
                {
                    body["IsPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                    bodypropCount++;
                }

                if (bodyactionType != null)
                {
                    body["ActionType"] = ExpressionConverter.ConvertO(bodyactionType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorkItemActionLogResponse>(callPayload);
            });
        }
    }

    public class CiresonservicemanageTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildCreateWebhook))]
        public IBodyWorkflowTrigger<WebhookSettings> CreateWebhook([WorkflowExpression] Func<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookSettings> __BuildCreateWebhook(WorkflowExpression<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebhookSettingsworkItemClassType, nameof(bodywebhookSettingsworkItemClassType), required: false);
            return new DeferredBodyTrigger<WebhookSettings>(() =>
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
                        webhookSettingsObject["WorkItemClassType"] = ExpressionConverter.ConvertO(bodywebhookSettingsworkItemClassType);
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
            }, triggerName);
        }

        [WorkflowExpressionFactory(nameof(__BuildCreateActionLogWebhook))]
        public IBodyWorkflowTrigger<WebhookSettings> CreateActionLogWebhook([WorkflowExpression] Func<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<WebhookSettings> __BuildCreateActionLogWebhook(WorkflowExpression<bodywebhookSettingsworkItemClassTypeInput> bodywebhookSettingsworkItemClassType = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodywebhookSettingsworkItemClassType, nameof(bodywebhookSettingsworkItemClassType), required: false);
            return new DeferredBodyTrigger<WebhookSettings>(() =>
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
                        webhookSettingsObject["WorkItemClassType"] = ExpressionConverter.ConvertO(bodywebhookSettingsworkItemClassType);
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
            }, triggerName);
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