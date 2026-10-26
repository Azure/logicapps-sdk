//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluidkinnectorzforpr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FluidkinnectorzforprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanyDeleteBidType(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/project_bid_types/{1}", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DeleteDepartment(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/departments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanyDeleteProjectOwnerTypes(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/project_owner_types/{1}", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProjectDeleteFile(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<string>> folderId, Expression<Func<int>> fileId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            var __workflow_fileId = WorkflowExpression.Compile(fileId, nameof(fileId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}", __workflow_fileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["folderId"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProjectDeleteFolder(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<string>> folderId)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}", __workflow_folderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanyDeleteProjectType(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/project_types/{1}", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ResourcesDeleteResource(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/resources/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanySendUserInvite(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/users/{1}/invite", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProjectDeleteProjectUser(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/users/{1}/actions/remove", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ImageCategoriesDeleteImageCategory(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/image_categories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ImagesDeleteImage(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/images/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProjectDeleteInstructionType(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/instruction_types/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> InstructionsDeleteInstruction(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/instructions/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> ProjectDeleteLocation(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/locations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MeetingDeleteMeeting(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meetings/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> MeetingDeleteMeetingAttendeeRecord(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> meetingId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_meetingId = WorkflowExpression.Compile(meetingId, nameof(meetingId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meeting_attendee_records/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["meeting_id"] = ExpressionConverter.Convert(__workflow_meetingId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanyDeleteProjectRegion(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/project_regions/{1}", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CompanyDeleteProjectStage(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/companies/{0}/project_stages/{1}", __workflow_companyId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TasksDeleteTask(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/tasks/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ToDosDeleteTodo(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/todos/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CoordinationIssuesDeleteAssociation(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> coordinationIssueId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_coordinationIssueId = WorkflowExpression.Compile(coordinationIssueId, nameof(coordinationIssueId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/coordination_issues/{0}/procore_item_associations/{1}", __workflow_coordinationIssueId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                callPayload.Queries["item_type"] = Convert.ToString("rfi");
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CoordinationIssuesDeleteCoordinationIssue(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/coordination_issues/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                callPayload.Queries["project_id"] = ExpressionConverter.Convert(__workflow_projectId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DrawingsDeleteDrawingSet(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/drawing_sets/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> DrawingsDeleteDrawingUpload(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/drawing_uploads/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> RepliesDeleteAnRFIResponse(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> rfiId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_rfiId = WorkflowExpression.Compile(rfiId, nameof(rfiId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/rfis/{1}/replies/{2}", __workflow_projectId.WithUrlEncoding(1), __workflow_rfiId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TimeCardDeleteTimecardEntry(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var __workflow_companyId = WorkflowExpression.Compile(companyId, nameof(companyId), required: true);
            var __workflow_projectId = WorkflowExpression.Compile(projectId, nameof(projectId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/projects/{0}/timecard_entries/{1}", __workflow_projectId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = ExpressionConverter.Convert(__workflow_companyId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class FluidkinnectorzforprTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Fluidkinnectorzforpr;

    public partial class WorkflowManagedActions
    {
        public FluidkinnectorzforprActions Fluidkinnectorzforpr(string connectionId) => new FluidkinnectorzforprActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FluidkinnectorzforprTriggers Fluidkinnectorzforpr(string connectionId) => new FluidkinnectorzforprTriggers(connectionId);
    }
}