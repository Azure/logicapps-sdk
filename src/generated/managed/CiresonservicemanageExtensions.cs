//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Ciresonservicemanage
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CiresonservicemanageActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemGetResponse> GetWorkItem(Expression<Func<string>> workItemId)
        {
            var __workflow_workItemId = workItemId == null ? null : WorkflowExpression.Compile(workItemId);
            WorkflowExpression.Validate(__workflow_workItemId, nameof(workItemId), required: true);
            return new DeferredBodyAction<WorkItemGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_workItemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<WorkItemGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<DeleteWorkItemResponse> DeleteWorkItem(Expression<Func<string>> id)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            return new DeferredBodyAction<DeleteWorkItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/WorkItems/{0}/", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DeleteWorkItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "ciresonservicemanage")]
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateIncident(Expression<Func<string>> bodyclassification, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodyimpact, Expression<Func<string>> bodysource, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_bodyclassification = bodyclassification == null ? null : WorkflowExpression.Compile(bodyclassification);
            WorkflowExpression.Validate(__workflow_bodyclassification, nameof(bodyclassification), required: true);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: true);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: true);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysupportGroup = bodysupportGroup == null ? null : WorkflowExpression.Compile(bodysupportGroup);
            WorkflowExpression.Validate(__workflow_bodysupportGroup, nameof(bodysupportGroup), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaffectedUser = bodyaffectedUser == null ? null : WorkflowExpression.Compile(bodyaffectedUser);
            WorkflowExpression.Validate(__workflow_bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Incident";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Classification"] = ExpressionConverter.ConvertO(__workflow_bodyclassification);
                bodypropCount++;
                body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                bodypropCount++;
                body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                bodypropCount++;
                body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                if (__workflow_bodysupportGroup != null)
                {
                    body["SupportGroup"] = ExpressionConverter.ConvertO(__workflow_bodysupportGroup);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyaffectedUser);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateIncident(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyclassification = bodyclassification == null ? null : WorkflowExpression.Compile(bodyclassification);
            WorkflowExpression.Validate(__workflow_bodyclassification, nameof(bodyclassification), required: false);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: false);
            var __workflow_bodysupportGroup = bodysupportGroup == null ? null : WorkflowExpression.Compile(bodysupportGroup);
            WorkflowExpression.Validate(__workflow_bodysupportGroup, nameof(bodysupportGroup), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaffectedUser = bodyaffectedUser == null ? null : WorkflowExpression.Compile(bodyaffectedUser);
            WorkflowExpression.Validate(__workflow_bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Incident/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyclassification != null)
                {
                    body["Classification"] = ExpressionConverter.ConvertO(__workflow_bodyclassification);
                    bodypropCount++;
                }

                if (__workflow_bodyurgency != null)
                {
                    body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodysupportGroup != null)
                {
                    body["SupportGroup"] = ExpressionConverter.ConvertO(__workflow_bodysupportGroup);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyaffectedUser);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateServiceRequest(Expression<Func<string>> bodyarea, Expression<Func<string>> bodyurgency, Expression<Func<string>> bodysource, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_bodyarea = bodyarea == null ? null : WorkflowExpression.Compile(bodyarea);
            WorkflowExpression.Validate(__workflow_bodyarea, nameof(bodyarea), required: true);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: true);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysupportGroup = bodysupportGroup == null ? null : WorkflowExpression.Compile(bodysupportGroup);
            WorkflowExpression.Validate(__workflow_bodysupportGroup, nameof(bodysupportGroup), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaffectedUser = bodyaffectedUser == null ? null : WorkflowExpression.Compile(bodyaffectedUser);
            WorkflowExpression.Validate(__workflow_bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ServiceRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Area"] = ExpressionConverter.ConvertO(__workflow_bodyarea);
                bodypropCount++;
                body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                bodypropCount++;
                body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                if (__workflow_bodysupportGroup != null)
                {
                    body["SupportGroup"] = ExpressionConverter.ConvertO(__workflow_bodysupportGroup);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyaffectedUser);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateServiceRequest(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodypriority = null, Expression<Func<string>> bodyclassification = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodysupportGroup = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyaffectedUser = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyclassification = bodyclassification == null ? null : WorkflowExpression.Compile(bodyclassification);
            WorkflowExpression.Validate(__workflow_bodyclassification, nameof(bodyclassification), required: false);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: false);
            var __workflow_bodysupportGroup = bodysupportGroup == null ? null : WorkflowExpression.Compile(bodysupportGroup);
            WorkflowExpression.Validate(__workflow_bodysupportGroup, nameof(bodysupportGroup), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyaffectedUser = bodyaffectedUser == null ? null : WorkflowExpression.Compile(bodyaffectedUser);
            WorkflowExpression.Validate(__workflow_bodyaffectedUser, nameof(bodyaffectedUser), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ServiceRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyclassification != null)
                {
                    body["Classification"] = ExpressionConverter.ConvertO(__workflow_bodyclassification);
                    bodypropCount++;
                }

                if (__workflow_bodyurgency != null)
                {
                    body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodysupportGroup != null)
                {
                    body["SupportGroup"] = ExpressionConverter.ConvertO(__workflow_bodysupportGroup);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyaffectedUser != null)
                {
                    body["RequestedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyaffectedUser);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateChangeRequest(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyarea = bodyarea == null ? null : WorkflowExpression.Compile(bodyarea);
            WorkflowExpression.Validate(__workflow_bodyarea, nameof(bodyarea), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyrisk = bodyrisk == null ? null : WorkflowExpression.Compile(bodyrisk);
            WorkflowExpression.Validate(__workflow_bodyrisk, nameof(bodyrisk), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ChangeRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyarea != null)
                {
                    body["Area"] = ExpressionConverter.ConvertO(__workflow_bodyarea);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyrisk != null)
                {
                    body["Risk"] = ExpressionConverter.ConvertO(__workflow_bodyrisk);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateChangeRequest(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodyarea = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodyarea = bodyarea == null ? null : WorkflowExpression.Compile(bodyarea);
            WorkflowExpression.Validate(__workflow_bodyarea, nameof(bodyarea), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyrisk = bodyrisk == null ? null : WorkflowExpression.Compile(bodyrisk);
            WorkflowExpression.Validate(__workflow_bodyrisk, nameof(bodyrisk), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ChangeRequest/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodyarea != null)
                {
                    body["Area"] = ExpressionConverter.ConvertO(__workflow_bodyarea);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyrisk != null)
                {
                    body["Risk"] = ExpressionConverter.ConvertO(__workflow_bodyrisk);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> CreateProblem(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/Problem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyurgency != null)
                {
                    body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedIRResponse> UpdateProblem(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyurgency = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodysource = bodysource == null ? null : WorkflowExpression.Compile(bodysource);
            WorkflowExpression.Validate(__workflow_bodysource, nameof(bodysource), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyurgency = bodyurgency == null ? null : WorkflowExpression.Compile(bodyurgency);
            WorkflowExpression.Validate(__workflow_bodyurgency, nameof(bodyurgency), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedIRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/Problem/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["Source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyurgency != null)
                {
                    body["Urgency"] = ExpressionConverter.ConvertO(__workflow_bodyurgency);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> CreateReleaseRecord(Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyrisk = bodyrisk == null ? null : WorkflowExpression.Compile(bodyrisk);
            WorkflowExpression.Validate(__workflow_bodyrisk, nameof(bodyrisk), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = "/api/CloudConnector/ReleaseRecord";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyrisk != null)
                {
                    body["Risk"] = ExpressionConverter.ConvertO(__workflow_bodyrisk);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemCreatedSRResponse> UpdateReleaseRecord(Expression<Func<string>> id, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodytype = null, Expression<Func<string>> bodycategory = null, Expression<Func<string>> bodyimpact = null, Expression<Func<string>> bodyrisk = null, Expression<Func<string>> bodypriority = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodyassignedUser = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodytype = bodytype == null ? null : WorkflowExpression.Compile(bodytype);
            WorkflowExpression.Validate(__workflow_bodytype, nameof(bodytype), required: false);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyimpact = bodyimpact == null ? null : WorkflowExpression.Compile(bodyimpact);
            WorkflowExpression.Validate(__workflow_bodyimpact, nameof(bodyimpact), required: false);
            var __workflow_bodyrisk = bodyrisk == null ? null : WorkflowExpression.Compile(bodyrisk);
            WorkflowExpression.Validate(__workflow_bodyrisk, nameof(bodyrisk), required: false);
            var __workflow_bodypriority = bodypriority == null ? null : WorkflowExpression.Compile(bodypriority);
            WorkflowExpression.Validate(__workflow_bodypriority, nameof(bodypriority), required: false);
            var __workflow_bodystatus = bodystatus == null ? null : WorkflowExpression.Compile(bodystatus);
            WorkflowExpression.Validate(__workflow_bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyassignedUser = bodyassignedUser == null ? null : WorkflowExpression.Compile(bodyassignedUser);
            WorkflowExpression.Validate(__workflow_bodyassignedUser, nameof(bodyassignedUser), required: false);
            return new DeferredBodyAction<WorkItemCreatedSRResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/CloudConnector/ReleaseRecord/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodytype != null)
                {
                    body["Type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                if (__workflow_bodycategory != null)
                {
                    body["Category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyimpact != null)
                {
                    body["Impact"] = ExpressionConverter.ConvertO(__workflow_bodyimpact);
                    bodypropCount++;
                }

                if (__workflow_bodyrisk != null)
                {
                    body["Risk"] = ExpressionConverter.ConvertO(__workflow_bodyrisk);
                    bodypropCount++;
                }

                if (__workflow_bodypriority != null)
                {
                    body["Priority"] = ExpressionConverter.ConvertO(__workflow_bodypriority);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyassignedUser != null)
                {
                    body["AssignedWorkItem"] = ExpressionConverter.ConvertO(__workflow_bodyassignedUser);
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
        public IBodyWorkflowAction<WorkItemActionLogResponse> AddCommentLog(Expression<Func<string>> id, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyenteredBy = null, Expression<Func<bool>> bodyisPrivate = null, Expression<Func<bodyactionTypeInput>> bodyactionType = null)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyenteredBy = bodyenteredBy == null ? null : WorkflowExpression.Compile(bodyenteredBy);
            WorkflowExpression.Validate(__workflow_bodyenteredBy, nameof(bodyenteredBy), required: false);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: false);
            var __workflow_bodyactionType = bodyactionType == null ? null : WorkflowExpression.Compile(bodyactionType);
            WorkflowExpression.Validate(__workflow_bodyactionType, nameof(bodyactionType), required: false);
            return new DeferredBodyAction<WorkItemActionLogResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/cloudconnector/workItems/{0}/ActionLogComment", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["Description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyenteredBy != null)
                {
                    body["EnteredBy"] = ExpressionConverter.ConvertO(__workflow_bodyenteredBy);
                    bodypropCount++;
                }

                if (__workflow_bodyisPrivate != null)
                {
                    body["IsPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                    bodypropCount++;
                }

                if (__workflow_bodyactionType != null)
                {
                    body["ActionType"] = ExpressionConverter.ConvertO(__workflow_bodyactionType);
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
        public IBodyWorkflowTrigger<WebhookSettings> CreateWebhook(Expression<Func<bodywebhookSettingsworkItemClassTypeInput>> bodywebhookSettingsworkItemClassType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebhookSettingsworkItemClassType = bodywebhookSettingsworkItemClassType == null ? null : WorkflowExpression.Compile(bodywebhookSettingsworkItemClassType);
            WorkflowExpression.Validate(__workflow_bodywebhookSettingsworkItemClassType, nameof(bodywebhookSettingsworkItemClassType), required: false);
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
                if (__workflow_bodywebhookSettingsworkItemClassType != null)
                {
                    if (__workflow_bodywebhookSettingsworkItemClassType != null)
                    {
                        webhookSettingsObject["WorkItemClassType"] = ExpressionConverter.ConvertO(__workflow_bodywebhookSettingsworkItemClassType);
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

                return new ApiConnectionTrigger<WebhookSettings>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<WebhookSettings> CreateActionLogWebhook(Expression<Func<bodywebhookSettingsworkItemClassTypeInput>> bodywebhookSettingsworkItemClassType = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodywebhookSettingsworkItemClassType = bodywebhookSettingsworkItemClassType == null ? null : WorkflowExpression.Compile(bodywebhookSettingsworkItemClassType);
            WorkflowExpression.Validate(__workflow_bodywebhookSettingsworkItemClassType, nameof(bodywebhookSettingsworkItemClassType), required: false);
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
                if (__workflow_bodywebhookSettingsworkItemClassType != null)
                {
                    if (__workflow_bodywebhookSettingsworkItemClassType != null)
                    {
                        webhookSettingsObject["WorkItemClassType"] = ExpressionConverter.ConvertO(__workflow_bodywebhookSettingsworkItemClassType);
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

                return new ApiConnectionTrigger<WebhookSettings>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
