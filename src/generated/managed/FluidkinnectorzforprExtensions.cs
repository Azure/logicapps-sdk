//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Fluidkinnectorzforpr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FluidkinnectorzforprActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteBidType(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/project_bid_types/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DeleteDepartment(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/departments/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectOwnerTypes(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/project_owner_types/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteFile(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<string>> folderId, Expression<Func<int>> fileId)
        {
            var apiCallPath = String.Format("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["folderId"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteFolder(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<string>> folderId)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(folderId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectType(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/project_types/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ResourcesDeleteResource(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/resources/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanySendUserInvite(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/users/{1}/invite", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteProjectUser(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/users/{1}/actions/remove", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ImageCategoriesDeleteImageCategory(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/image_categories/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ImagesDeleteImage(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/images/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteInstructionType(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/instruction_types/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> InstructionsDeleteInstruction(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/instructions/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteLocation(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/locations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> MeetingDeleteMeeting(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/meetings/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> MeetingDeleteMeetingAttendeeRecord(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> meetingId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/meeting_attendee_records/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["meeting_id"] = ExpressionConverter.Convert(meetingId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectRegion(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/project_regions/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectStage(Expression<Func<int>> companyId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/companies/{0}/project_stages/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> TasksDeleteTask(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/tasks/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IWorkflowAction ToDosDeleteTodo(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/todos/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CoordinationIssuesDeleteAssociation(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> coordinationIssueId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/coordination_issues/{0}/procore_item_associations/{1}", ExpressionConverter.ConvertWithUrlEncoding(coordinationIssueId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            callPayload.Queries["item_type"] = Convert.ToString("rfi");
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CoordinationIssuesDeleteCoordinationIssue(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/coordination_issues/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            callPayload.Queries["project_id"] = ExpressionConverter.Convert(projectId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DrawingsDeleteDrawingSet(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/drawing_sets/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DrawingsDeleteDrawingUpload(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/drawing_uploads/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> RepliesDeleteAnRFIResponse(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> rfiId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/rfis/{1}/replies/{2}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(rfiId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> TimeCardDeleteTimecardEntry(Expression<Func<int>> companyId, Expression<Func<int>> projectId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/projects/{0}/timecard_entries/{1}", ExpressionConverter.ConvertWithUrlEncoding(projectId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["company_id"] = ExpressionConverter.Convert(companyId);
            return new ApiConnectionAction<JToken>(callPayload);
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