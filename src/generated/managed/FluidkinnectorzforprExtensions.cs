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
        public IBodyWorkflowAction<JToken> CompanyDeleteBidType([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/project_bid_types/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DeleteDepartment([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/departments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectOwnerTypes([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/project_owner_types/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteFile([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<string> folderId, [WorkflowExpression] Func<int> fileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(fileId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["folderId"] = SourceExpressionConverter.ConvertO(folderId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteFolder([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<string> folderId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/folders/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(folderId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectType([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/project_types/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ResourcesDeleteResource([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/resources/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanySendUserInvite([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/users/{1}/invite", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteProjectUser([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/users/{1}/actions/remove", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ImageCategoriesDeleteImageCategory([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/image_categories/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ImagesDeleteImage([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/images/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteInstructionType([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/instruction_types/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> InstructionsDeleteInstruction([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/instructions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> ProjectDeleteLocation([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/locations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> MeetingDeleteMeeting([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meetings/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> MeetingDeleteMeetingAttendeeRecord([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> meetingId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meeting_attendee_records/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["meeting_id"] = SourceExpressionConverter.ConvertO(meetingId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectRegion([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/project_regions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CompanyDeleteProjectStage([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/companies/{0}/project_stages/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(companyId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> TasksDeleteTask([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/tasks/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IWorkflowAction ToDosDeleteTodo([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/todos/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CoordinationIssuesDeleteAssociation([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> coordinationIssueId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/coordination_issues/{0}/procore_item_associations/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(coordinationIssueId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                callPayload.Queries["item_type"] = Convert.ToString("rfi");
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> CoordinationIssuesDeleteCoordinationIssue([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/coordination_issues/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                callPayload.Queries["project_id"] = SourceExpressionConverter.ConvertO(projectId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DrawingsDeleteDrawingSet([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/drawing_sets/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> DrawingsDeleteDrawingUpload([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/drawing_uploads/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> RepliesDeleteAnRFIResponse([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> rfiId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/rfis/{1}/replies/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(rfiId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "fluidkinnectorzforpr")]
        public IBodyWorkflowAction<JToken> TimeCardDeleteTimecardEntry([WorkflowExpression] Func<int> companyId, [WorkflowExpression] Func<int> projectId, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/projects/{0}/timecard_entries/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(projectId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["company_id"] = SourceExpressionConverter.ConvertO(companyId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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