//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mobaro
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MobaroActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreatedResult, ApiConnectionActionConfiguration> CreateAsset(Expression<Func<CreateAssetBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreatedResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssetApiModelListApiResult, ApiConnectionActionConfiguration> GetAssets()
        {
            return new DeferredBodyAction<AssetApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssetApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAsset(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssetApiModel, ApiConnectionActionConfiguration> GetAsset(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AssetApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssetApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAsset(Expression<Func<string>> id, Expression<Func<UpdateAssetBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<IAssetActivity[], ApiConnectionActionConfiguration> GetAssetActivities(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<IAssetActivity[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assets/{0}/activities", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IAssetActivity[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> MoveAsset(Expression<Func<string>> asset, Expression<Func<string>> parent)
        {
            var __workflow_asset = WorkflowExpression.Compile(asset, nameof(asset), required: true);
            var __workflow_parent = WorkflowExpression.Compile(parent, nameof(parent), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assets/move";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["Asset"] = ExpressionConverter.Convert(__workflow_asset);
                callPayload.Queries["Parent"] = ExpressionConverter.Convert(__workflow_parent);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetAssetPropertiesDefinition()
        {
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assets/property-definition";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateAssignment(Expression<Func<CreateAssignmentBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssignmentApiModelListApiResult, ApiConnectionActionConfiguration> GetAssignments(Expression<Func<StatusInputItem[]>> status = null, Expression<Func<string[]>> definitions = null, Expression<Func<string[]>> definitionStates = null, Expression<Func<bool>> priority = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_definitions = WorkflowExpression.Compile(definitions, nameof(definitions), required: false);
            var __workflow_definitionStates = WorkflowExpression.Compile(definitionStates, nameof(definitionStates), required: false);
            var __workflow_priority = WorkflowExpression.Compile(priority, nameof(priority), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AssignmentApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assignments";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_status != null)
                    callPayload.Queries["Status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_definitions != null)
                    callPayload.Queries["Definitions"] = ExpressionConverter.Convert(__workflow_definitions);
                if (__workflow_definitionStates != null)
                    callPayload.Queries["DefinitionStates"] = ExpressionConverter.Convert(__workflow_definitionStates);
                if (__workflow_priority != null)
                    callPayload.Queries["Priority"] = ExpressionConverter.Convert(__workflow_priority);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["CreatedAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AssignmentApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAssignment(Expression<Func<string>> id, Expression<Func<string>> comment = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_comment = WorkflowExpression.Compile(comment, nameof(comment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assignments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_comment != null)
                    callPayload.Queries["comment"] = ExpressionConverter.Convert(__workflow_comment);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssignmentApiModel, ApiConnectionActionConfiguration> GetAssignment(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AssignmentApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assignments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssignmentApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAssignment(Expression<Func<string>> id, Expression<Func<UpdateAssignmentBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assignments/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssignmentDefinitionApiModelListApiResult, ApiConnectionActionConfiguration> GetAssignmentDefinitions(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<AssignmentDefinitionApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/assignmentdefinitions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<AssignmentDefinitionApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<AssignmentDefinitionApiModel, ApiConnectionActionConfiguration> GetAssignmentDefinition(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<AssignmentDefinitionApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/assignmentdefinitions/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssignmentDefinitionApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CalendarApiModelListApiResult, ApiConnectionActionConfiguration> GetCalendars(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CalendarApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/calendars";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<CalendarApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CalendarApiModel, ApiConnectionActionConfiguration> GetCalendar(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CalendarApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/calendars/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CalendarApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreatedResult, ApiConnectionActionConfiguration> CreateCertification(Expression<Func<CreateCertificationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreatedResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/certifications";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CertificationApiModelListApiResult, ApiConnectionActionConfiguration> GetCertifications(Expression<Func<string>> awardedBefore = null, Expression<Func<string>> awardedAfter = null, Expression<Func<string[]>> competencies = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_awardedBefore = WorkflowExpression.Compile(awardedBefore, nameof(awardedBefore), required: false);
            var __workflow_awardedAfter = WorkflowExpression.Compile(awardedAfter, nameof(awardedAfter), required: false);
            var __workflow_competencies = WorkflowExpression.Compile(competencies, nameof(competencies), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CertificationApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/certifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_awardedBefore != null)
                    callPayload.Queries["AwardedBefore"] = ExpressionConverter.Convert(__workflow_awardedBefore);
                if (__workflow_awardedAfter != null)
                    callPayload.Queries["AwardedAfter"] = ExpressionConverter.Convert(__workflow_awardedAfter);
                if (__workflow_competencies != null)
                    callPayload.Queries["Competencies"] = ExpressionConverter.Convert(__workflow_competencies);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<CertificationApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCertification(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/certifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CertificationApiModel, ApiConnectionActionConfiguration> GetCertification(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CertificationApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/certifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CertificationApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateCertification(Expression<Func<string>> id, Expression<Func<UpdateCertificationBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/certifications/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ChecklistApiModelListApiResult, ApiConnectionActionConfiguration> GetChecklists(Expression<Func<bool>> includeContent = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_includeContent = WorkflowExpression.Compile(includeContent, nameof(includeContent), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ChecklistApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/checklists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_includeContent != null)
                    callPayload.Queries["IncludeContent"] = ExpressionConverter.Convert(__workflow_includeContent);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ChecklistApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ChecklistApiModel, ApiConnectionActionConfiguration> GetChecklist(Expression<Func<string>> id, Expression<Func<string>> revision = null, Expression<Func<bool>> includeContent = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_revision = WorkflowExpression.Compile(revision, nameof(revision), required: false);
            var __workflow_includeContent = WorkflowExpression.Compile(includeContent, nameof(includeContent), required: false);
            return new DeferredBodyAction<ChecklistApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/checklists/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_revision != null)
                    callPayload.Queries["Revision"] = ExpressionConverter.Convert(__workflow_revision);
                if (__workflow_includeContent != null)
                    callPayload.Queries["IncludeContent"] = ExpressionConverter.Convert(__workflow_includeContent);
                return new ApiConnectionAction<ChecklistApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateChecklist(Expression<Func<string>> id, Expression<Func<UpdateChecklistBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/checklists/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetChecklistCategories()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/checklists/categories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> GetChecklistFolders()
        {
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/checklists/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreatedResult, ApiConnectionActionConfiguration> CreateCompetency(Expression<Func<CreateCompetencyBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreatedResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/competencies";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CompetencyApiModelListApiResult, ApiConnectionActionConfiguration> GetCompetencies(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<CompetencyApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/competencies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<CompetencyApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteCompetency(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/competencies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CompetencyApiModel, ApiConnectionActionConfiguration> GetCompetency(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<CompetencyApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/competencies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompetencyApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateCompetency(Expression<Func<string>> id, Expression<Func<UpdateCompetencyBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/competencies/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateDowntime(Expression<Func<CreateDowntimeBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/downtime";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDowntime(Expression<Func<string[]>> downtimes = null)
        {
            var __workflow_downtimes = WorkflowExpression.Compile(downtimes, nameof(downtimes), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/downtime";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_downtimes != null)
                    callPayload.Queries["Downtimes"] = ExpressionConverter.Convert(__workflow_downtimes);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<DowntimeApiModelListApiResult, ApiConnectionActionConfiguration> GetDowntimes(Expression<Func<string[]>> locations = null, Expression<Func<StatesInputItem[]>> states = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> startedBefore = null, Expression<Func<string>> startedAfter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_locations = WorkflowExpression.Compile(locations, nameof(locations), required: false);
            var __workflow_states = WorkflowExpression.Compile(states, nameof(states), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_startedBefore = WorkflowExpression.Compile(startedBefore, nameof(startedBefore), required: false);
            var __workflow_startedAfter = WorkflowExpression.Compile(startedAfter, nameof(startedAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<DowntimeApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/downtime";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locations != null)
                    callPayload.Queries["Locations"] = ExpressionConverter.Convert(__workflow_locations);
                if (__workflow_states != null)
                    callPayload.Queries["States"] = ExpressionConverter.Convert(__workflow_states);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["CreatedAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_startedBefore != null)
                    callPayload.Queries["StartedBefore"] = ExpressionConverter.Convert(__workflow_startedBefore);
                if (__workflow_startedAfter != null)
                    callPayload.Queries["StartedAfter"] = ExpressionConverter.Convert(__workflow_startedAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<DowntimeApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<DowntimeApiModel, ApiConnectionActionConfiguration> GetDowntime(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<DowntimeApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/downtime/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DowntimeApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateDowntime(Expression<Func<string>> id, Expression<Func<UpdateDowntimeBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/downtime/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseDowntime(Expression<Func<string>> id, Expression<Func<CloseDowntimeBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/downtime/close/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<FileApiModel, ApiConnectionActionConfiguration> GetFile(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FileApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/files/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddCommentToFile(Expression<Func<AddCommentToFileBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/files/comment";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreatedResult, ApiConnectionActionConfiguration> CreateFileCategory(Expression<Func<CreateFileCategoryBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreatedResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/filecategories";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatedResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<FileCategoryListApiResult, ApiConnectionActionConfiguration> GetFileCategories()
        {
            return new DeferredBodyAction<FileCategoryListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/filecategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileCategoryListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteFileCategory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/filecategories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<FileCategory, ApiConnectionActionConfiguration> GetFileCategory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<FileCategory, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/filecategories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FileCategory>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateFileCategory(Expression<Func<string>> id, Expression<Func<UpdateFileCategoryBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/filecategories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateLocation(Expression<Func<CreateLocationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationApiModelListApiResult, ApiConnectionActionConfiguration> GetLocations(Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string[]>> locationGroups = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_locationGroups = WorkflowExpression.Compile(locationGroups, nameof(locationGroups), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["CreatedAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_locationGroups != null)
                    callPayload.Queries["LocationGroups"] = ExpressionConverter.Convert(__workflow_locationGroups);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LocationApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLocation(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationApiModel, ApiConnectionActionConfiguration> GetLocation(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLocation(Expression<Func<string>> id, Expression<Func<UpdateLocationBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locations/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> OpenLocation(Expression<Func<CloseLocationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locations/open";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CloseLocation(Expression<Func<CloseLocationBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locations/close";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateLocationGroup(Expression<Func<CreateLocationGroupBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locationgroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationGroupApiModelListApiResult, ApiConnectionActionConfiguration> GetLocationGroups(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationGroupApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locationgroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LocationGroupApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLocationGroup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationgroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationGroupApiModel, ApiConnectionActionConfiguration> GetLocationGroup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationGroupApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationgroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationGroupApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLocationGroup(Expression<Func<string>> id, Expression<Func<UpdateLocationGroupBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationgroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateLocationProperty(Expression<Func<CreateLocationPropertyBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locationproperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationPropertyApiModelListApiResult, ApiConnectionActionConfiguration> GetLocationProperties(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<LocationPropertyApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/locationproperties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<LocationPropertyApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteLocationProperty(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<LocationPropertyApiModel, ApiConnectionActionConfiguration> GetLocationProperty(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<LocationPropertyApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<LocationPropertyApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateLocationProperty(Expression<Func<string>> id, Expression<Func<UpdateLocationPropertyBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/locationproperties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<NoteApiModelListApiResult, ApiConnectionActionConfiguration> GetNotes(Expression<Func<string[]>> locations = null, Expression<Func<string[]>> locationGroups = null, Expression<Func<string>> createdBefore = null)
        {
            var __workflow_locations = WorkflowExpression.Compile(locations, nameof(locations), required: false);
            var __workflow_locationGroups = WorkflowExpression.Compile(locationGroups, nameof(locationGroups), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            return new DeferredBodyAction<NoteApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/notes";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locations != null)
                    callPayload.Queries["Locations"] = ExpressionConverter.Convert(__workflow_locations);
                if (__workflow_locationGroups != null)
                    callPayload.Queries["LocationGroups"] = ExpressionConverter.Convert(__workflow_locationGroups);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                return new ApiConnectionAction<NoteApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<NoteApiModel, ApiConnectionActionConfiguration> GetNote(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<NoteApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/notes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NoteApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<QuestionCategoryApiModel, ApiConnectionActionConfiguration> GetQuestionCategory(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<QuestionCategoryApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/questioncategories/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<QuestionCategoryApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ResultApiModelListApiResult, ApiConnectionActionConfiguration> GetResults(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string[]>> checklists = null, Expression<Func<string[]>> locationGroups = null, Expression<Func<string[]>> locations = null, Expression<Func<string[]>> assets = null, Expression<Func<string[]>> schedules = null, Expression<Func<string[]>> slots = null, Expression<Func<string[]>> users = null, Expression<Func<string>> answeredBefore = null, Expression<Func<string>> answeredAfter = null, Expression<Func<string>> receivedBefore = null, Expression<Func<string>> receivedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_checklists = WorkflowExpression.Compile(checklists, nameof(checklists), required: false);
            var __workflow_locationGroups = WorkflowExpression.Compile(locationGroups, nameof(locationGroups), required: false);
            var __workflow_locations = WorkflowExpression.Compile(locations, nameof(locations), required: false);
            var __workflow_assets = WorkflowExpression.Compile(assets, nameof(assets), required: false);
            var __workflow_schedules = WorkflowExpression.Compile(schedules, nameof(schedules), required: false);
            var __workflow_slots = WorkflowExpression.Compile(slots, nameof(slots), required: false);
            var __workflow_users = WorkflowExpression.Compile(users, nameof(users), required: false);
            var __workflow_answeredBefore = WorkflowExpression.Compile(answeredBefore, nameof(answeredBefore), required: false);
            var __workflow_answeredAfter = WorkflowExpression.Compile(answeredAfter, nameof(answeredAfter), required: false);
            var __workflow_receivedBefore = WorkflowExpression.Compile(receivedBefore, nameof(receivedBefore), required: false);
            var __workflow_receivedAfter = WorkflowExpression.Compile(receivedAfter, nameof(receivedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            return new DeferredBodyAction<ResultApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/results";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_checklists != null)
                    callPayload.Queries["Checklists"] = ExpressionConverter.Convert(__workflow_checklists);
                if (__workflow_locationGroups != null)
                    callPayload.Queries["LocationGroups"] = ExpressionConverter.Convert(__workflow_locationGroups);
                if (__workflow_locations != null)
                    callPayload.Queries["Locations"] = ExpressionConverter.Convert(__workflow_locations);
                if (__workflow_assets != null)
                    callPayload.Queries["Assets"] = ExpressionConverter.Convert(__workflow_assets);
                if (__workflow_schedules != null)
                    callPayload.Queries["Schedules"] = ExpressionConverter.Convert(__workflow_schedules);
                if (__workflow_slots != null)
                    callPayload.Queries["Slots"] = ExpressionConverter.Convert(__workflow_slots);
                if (__workflow_users != null)
                    callPayload.Queries["Users"] = ExpressionConverter.Convert(__workflow_users);
                if (__workflow_answeredBefore != null)
                    callPayload.Queries["AnsweredBefore"] = ExpressionConverter.Convert(__workflow_answeredBefore);
                if (__workflow_answeredAfter != null)
                    callPayload.Queries["AnsweredAfter"] = ExpressionConverter.Convert(__workflow_answeredAfter);
                if (__workflow_receivedBefore != null)
                    callPayload.Queries["ReceivedBefore"] = ExpressionConverter.Convert(__workflow_receivedBefore);
                if (__workflow_receivedAfter != null)
                    callPayload.Queries["ReceivedAfter"] = ExpressionConverter.Convert(__workflow_receivedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                return new ApiConnectionAction<ResultApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ResultApiModel, ApiConnectionActionConfiguration> GetResult(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/results/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ApproveResult(Expression<Func<ApproveResultBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/results/approve";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DisapproveResult(Expression<Func<ApproveResultBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/results/disapprove";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChangeTargetOfResult(Expression<Func<string>> id, Expression<Func<ChangeTargetOfResultBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/results/{0}/change-target", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ResultProgressApiModel, ApiConnectionActionConfiguration> GetProgressOfResult(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ResultProgressApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/results/progress/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResultProgressApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<RideOpsDispatchApiModel[], ApiConnectionActionConfiguration> GetRideOpsDispatches(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> location, Expression<Func<string>> timeZone = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            return new DeferredBodyAction<RideOpsDispatchApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/rideops/dispatches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["Location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_timeZone != null)
                    callPayload.Queries["TimeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<RideOpsDispatchApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<RideOpsQueueApiModel[], ApiConnectionActionConfiguration> GetRideOpsQueue(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> location, Expression<Func<string>> timeZone = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            return new DeferredBodyAction<RideOpsQueueApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/rideops/queue";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["Location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_timeZone != null)
                    callPayload.Queries["TimeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<RideOpsQueueApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<RideOpsStatisticsApiModel, ApiConnectionActionConfiguration> GetRideOpsStatistics(Expression<Func<string>> from, Expression<Func<string>> to, Expression<Func<string>> location, Expression<Func<string>> timeZone = null)
        {
            var __workflow_from = WorkflowExpression.Compile(from, nameof(from), required: true);
            var __workflow_to = WorkflowExpression.Compile(to, nameof(to), required: true);
            var __workflow_location = WorkflowExpression.Compile(location, nameof(location), required: true);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            return new DeferredBodyAction<RideOpsStatisticsApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/rideops/statistics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["From"] = ExpressionConverter.Convert(__workflow_from);
                callPayload.Queries["To"] = ExpressionConverter.Convert(__workflow_to);
                callPayload.Queries["Location"] = ExpressionConverter.Convert(__workflow_location);
                if (__workflow_timeZone != null)
                    callPayload.Queries["TimeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                return new ApiConnectionAction<RideOpsStatisticsApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<RoleApiModelListApiResult, ApiConnectionActionConfiguration> GetRoles(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RoleApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/roles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RoleApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteRole(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/roles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<RoleApiModel, ApiConnectionActionConfiguration> GetRole(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<RoleApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/roles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RoleApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateRole(Expression<Func<string>> id, Expression<Func<UpdateRoleBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/roles/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ScheduleApiModelListApiResult, ApiConnectionActionConfiguration> GetSchedules(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<ScheduleApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/schedules";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<ScheduleApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ScheduleApiModel, ApiConnectionActionConfiguration> GetSchedule(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ScheduleApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/schedules/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScheduleApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateScheduleSlot(Expression<Func<CreateScheduleSlotBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/slots";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ScheduleSlotApiModel[], ApiConnectionActionConfiguration> GetScheduleSlots(Expression<Func<string>> startsAfter, Expression<Func<string>> startsBefore, Expression<Func<string>> type = null, Expression<Func<string[]>> targets = null, Expression<Func<string[]>> assignee = null, Expression<Func<string[]>> checklist = null, Expression<Func<string[]>> schedules = null, Expression<Func<string[]>> calendars = null)
        {
            var __workflow_startsAfter = WorkflowExpression.Compile(startsAfter, nameof(startsAfter), required: true);
            var __workflow_startsBefore = WorkflowExpression.Compile(startsBefore, nameof(startsBefore), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            var __workflow_targets = WorkflowExpression.Compile(targets, nameof(targets), required: false);
            var __workflow_assignee = WorkflowExpression.Compile(assignee, nameof(assignee), required: false);
            var __workflow_checklist = WorkflowExpression.Compile(checklist, nameof(checklist), required: false);
            var __workflow_schedules = WorkflowExpression.Compile(schedules, nameof(schedules), required: false);
            var __workflow_calendars = WorkflowExpression.Compile(calendars, nameof(calendars), required: false);
            return new DeferredBodyAction<ScheduleSlotApiModel[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/slots";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["StartsAfter"] = ExpressionConverter.Convert(__workflow_startsAfter);
                callPayload.Queries["StartsBefore"] = ExpressionConverter.Convert(__workflow_startsBefore);
                if (__workflow_type != null)
                    callPayload.Queries["Type"] = ExpressionConverter.Convert(__workflow_type);
                if (__workflow_targets != null)
                    callPayload.Queries["Targets"] = ExpressionConverter.Convert(__workflow_targets);
                if (__workflow_assignee != null)
                    callPayload.Queries["Assignee"] = ExpressionConverter.Convert(__workflow_assignee);
                if (__workflow_checklist != null)
                    callPayload.Queries["Checklist"] = ExpressionConverter.Convert(__workflow_checklist);
                if (__workflow_schedules != null)
                    callPayload.Queries["Schedules"] = ExpressionConverter.Convert(__workflow_schedules);
                if (__workflow_calendars != null)
                    callPayload.Queries["Calendars"] = ExpressionConverter.Convert(__workflow_calendars);
                return new ApiConnectionAction<ScheduleSlotApiModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteAdHocScheduleSlot(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/slots/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<ScheduleSlotApiModel, ApiConnectionActionConfiguration> GetScheduleSlot(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<ScheduleSlotApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/slots/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ScheduleSlotApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateAdHocScheduleSlot(Expression<Func<string>> id, Expression<Func<UpdateAdHocScheduleSlotBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/slots/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateTimesheet(Expression<Func<CreateTimesheetBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/timesheets";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteTimesheet(Expression<Func<string[]>> ids = null)
        {
            var __workflow_ids = WorkflowExpression.Compile(ids, nameof(ids), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/timesheets";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_ids != null)
                    callPayload.Queries["Ids"] = ExpressionConverter.Convert(__workflow_ids);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<TimesheetEntryApiModelListApiResult, ApiConnectionActionConfiguration> GetTimesheets(Expression<Func<string[]>> origins = null, Expression<Func<string[]>> users = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> startedBefore = null, Expression<Func<string>> startedAfter = null, Expression<Func<string>> stoppedBefore = null, Expression<Func<string>> stoppedAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_origins = WorkflowExpression.Compile(origins, nameof(origins), required: false);
            var __workflow_users = WorkflowExpression.Compile(users, nameof(users), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_startedBefore = WorkflowExpression.Compile(startedBefore, nameof(startedBefore), required: false);
            var __workflow_startedAfter = WorkflowExpression.Compile(startedAfter, nameof(startedAfter), required: false);
            var __workflow_stoppedBefore = WorkflowExpression.Compile(stoppedBefore, nameof(stoppedBefore), required: false);
            var __workflow_stoppedAfter = WorkflowExpression.Compile(stoppedAfter, nameof(stoppedAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TimesheetEntryApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/timesheets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_origins != null)
                    callPayload.Queries["Origins"] = ExpressionConverter.Convert(__workflow_origins);
                if (__workflow_users != null)
                    callPayload.Queries["Users"] = ExpressionConverter.Convert(__workflow_users);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_startedBefore != null)
                    callPayload.Queries["StartedBefore"] = ExpressionConverter.Convert(__workflow_startedBefore);
                if (__workflow_startedAfter != null)
                    callPayload.Queries["StartedAfter"] = ExpressionConverter.Convert(__workflow_startedAfter);
                if (__workflow_stoppedBefore != null)
                    callPayload.Queries["StoppedBefore"] = ExpressionConverter.Convert(__workflow_stoppedBefore);
                if (__workflow_stoppedAfter != null)
                    callPayload.Queries["StoppedAfter"] = ExpressionConverter.Convert(__workflow_stoppedAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TimesheetEntryApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTimesheet(Expression<Func<string>> id = null, Expression<Func<UpdateTimesheetBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/timesheets";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_id != null)
                    callPayload.Queries["id"] = ExpressionConverter.Convert(__workflow_id);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<TimesheetEntryApiModel, ApiConnectionActionConfiguration> GetTimesheet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<TimesheetEntryApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/timesheets/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TimesheetEntryApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<TimesheetEntryTypeApiModelListApiResult, ApiConnectionActionConfiguration> GetTimesheetTypes(Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<TimesheetEntryTypeApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/timesheets/types";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<TimesheetEntryTypeApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateUptimePeriod(Expression<Func<CreateUptimePeriodBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/uptimeperiods";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUptimePeriod(Expression<Func<DeleteUptimePeriodBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/uptimeperiods";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<UptimePeriodApiModelListApiResult, ApiConnectionActionConfiguration> GetUptimePeriods(Expression<Func<string[]>> locations = null, Expression<Func<string>> orderBy = null, Expression<Func<string>> openedBefore = null, Expression<Func<string>> openedAfter = null, Expression<Func<string>> closedBefore = null, Expression<Func<string>> closedAfter = null, Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_locations = WorkflowExpression.Compile(locations, nameof(locations), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_openedBefore = WorkflowExpression.Compile(openedBefore, nameof(openedBefore), required: false);
            var __workflow_openedAfter = WorkflowExpression.Compile(openedAfter, nameof(openedAfter), required: false);
            var __workflow_closedBefore = WorkflowExpression.Compile(closedBefore, nameof(closedBefore), required: false);
            var __workflow_closedAfter = WorkflowExpression.Compile(closedAfter, nameof(closedAfter), required: false);
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<UptimePeriodApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/uptimeperiods";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_locations != null)
                    callPayload.Queries["Locations"] = ExpressionConverter.Convert(__workflow_locations);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_openedBefore != null)
                    callPayload.Queries["OpenedBefore"] = ExpressionConverter.Convert(__workflow_openedBefore);
                if (__workflow_openedAfter != null)
                    callPayload.Queries["OpenedAfter"] = ExpressionConverter.Convert(__workflow_openedAfter);
                if (__workflow_closedBefore != null)
                    callPayload.Queries["ClosedBefore"] = ExpressionConverter.Convert(__workflow_closedBefore);
                if (__workflow_closedAfter != null)
                    callPayload.Queries["ClosedAfter"] = ExpressionConverter.Convert(__workflow_closedAfter);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["CreatedAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<UptimePeriodApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUptimePeriod(Expression<Func<UpdateUptimePeriodBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/uptimeperiods";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateUser(Expression<Func<CreateUserBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/users";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<UserApiModelListApiResult, ApiConnectionActionConfiguration> GetUsers(Expression<Func<string>> createdBefore = null, Expression<Func<string>> createdAfter = null, Expression<Func<string>> updatedBefore = null, Expression<Func<string>> updatedAfter = null, Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_createdBefore = WorkflowExpression.Compile(createdBefore, nameof(createdBefore), required: false);
            var __workflow_createdAfter = WorkflowExpression.Compile(createdAfter, nameof(createdAfter), required: false);
            var __workflow_updatedBefore = WorkflowExpression.Compile(updatedBefore, nameof(updatedBefore), required: false);
            var __workflow_updatedAfter = WorkflowExpression.Compile(updatedAfter, nameof(updatedAfter), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<UserApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_createdBefore != null)
                    callPayload.Queries["CreatedBefore"] = ExpressionConverter.Convert(__workflow_createdBefore);
                if (__workflow_createdAfter != null)
                    callPayload.Queries["CreatedAfter"] = ExpressionConverter.Convert(__workflow_createdAfter);
                if (__workflow_updatedBefore != null)
                    callPayload.Queries["UpdatedBefore"] = ExpressionConverter.Convert(__workflow_updatedBefore);
                if (__workflow_updatedAfter != null)
                    callPayload.Queries["UpdatedAfter"] = ExpressionConverter.Convert(__workflow_updatedAfter);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<UserApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<UserApiModel, ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUser(Expression<Func<string>> id, Expression<Func<UpdateUserBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/users/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<CreateResult, ApiConnectionActionConfiguration> CreateUserGroup(Expression<Func<CreateUserGroupBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/usergroups";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<UserGroupApiModelListApiResult, ApiConnectionActionConfiguration> GetUserGroups(Expression<Func<string>> orderBy = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<UserGroupApiModelListApiResult, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/customers/usergroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_orderBy != null)
                    callPayload.Queries["OrderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                if (__workflow_limit != null)
                    callPayload.Queries["Limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["Offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<UserGroupApiModelListApiResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteUserGroup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/usergroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IBodyWorkflowAction<UserGroupApiModel, ApiConnectionActionConfiguration> GetUserGroup(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<UserGroupApiModel, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/usergroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGroupApiModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mobaro")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateUserGroup(Expression<Func<string>> id, Expression<Func<UpdateUserGroupBodyInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/customers/usergroups/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class MobaroTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreatedResult
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("formatters")]
        public JToken[] Formatters { get; set; }

        [JsonProperty("contentTypes")]
        public string[] ContentTypes { get; set; }

        [JsonProperty("declaredType")]
        public string DeclaredType { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }

    public class CreateAssetBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }
    }

    public class AssetApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public AssetApiModel[] Items { get; set; }
    }

    public class AssetApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("ancestors")]
        public string[] Ancestors { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("descendants")]
        public string[] Descendants { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }

    public class UpdateAssetBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("serial")]
        public string Serial { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class IAssetActivity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    public class CreateResult
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateAssignmentBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionIsReadonly")]
        public bool? DescriptionIsReadonly { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("target", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Target { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("definitionPriority")]
        public string DefinitionPriority { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("definitionCategories")]
        public string[] DefinitionCategories { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class AssignmentApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public AssignmentApiModel[] Items { get; set; }
    }

    public class AssignmentApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("definitionState")]
        public string DefinitionState { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("priority")]
        public bool Priority { get; set; }

        [JsonProperty("definitionPriority")]
        public string DefinitionPriority { get; set; }

        [JsonProperty("status")]
        public AssignmentStatus Status { get; set; }

        [JsonProperty("assignees")]
        public Referenceable[] Assignees { get; set; }

        [JsonProperty("target")]
        public Referenceable Target { get; set; }

        [JsonProperty("asset")]
        public Referenceable Asset { get; set; }

        [JsonProperty("creator")]
        public Referenceable Creator { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("definitionCategories")]
        public string[] DefinitionCategories { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("resolution")]
        public AssignmentResolutionDetailsApiModel Resolution { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssignmentStatus
    {
        Created,
        Started,
        Finished
    }

    public class Referenceable
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssignmentResolutionDetailsApiModel
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatusInputItem
    {
        Created,
        Started,
        Finished
    }

    public class UpdateAssignmentBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionIsReadonly")]
        public bool? DescriptionIsReadonly { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("priority")]
        public bool? Priority { get; set; }

        [JsonProperty("definitionPriority")]
        public string DefinitionPriority { get; set; }

        [JsonProperty("stateChange")]
        public AssignmentStateChangeJustificationApiModelOptional StateChange { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("definitionCategories")]
        public string[] DefinitionCategories { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class AssignmentStateChangeJustificationApiModelOptional
    {
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("justification")]
        public JustificationModel Justification { get; set; }
    }

    public class JustificationModel
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class AssignmentDefinitionApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public AssignmentDefinitionApiModel[] Items { get; set; }
    }

    public class AssignmentDefinitionApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }

        [JsonProperty("limitAssigneesTo")]
        public string[] LimitAssigneesTo { get; set; }

        [JsonProperty("assignableType")]
        public AssignmentDefinitionAssignableType AssignableType { get; set; }

        [JsonProperty("assigneeSelectionMode")]
        public AssignmentDefinitionAssigneeSelectionMode AssigneeSelectionMode { get; set; }

        [JsonProperty("states")]
        public AssignmentDefinitionStateApiModel[] States { get; set; }

        [JsonProperty("disableOrganizationCategories")]
        public bool DisableOrganizationCategories { get; set; }

        [JsonProperty("categorySelectionType")]
        public CategorySelectionType CategorySelectionType { get; set; }

        [JsonProperty("categories")]
        public AssignmentDefinitionCategoryApiModel[] Categories { get; set; }

        [JsonProperty("priorities")]
        public AssignmentDefinitionPriorityApiModel[] Priorities { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssignmentDefinitionAssignableType
    {
        Users,
        UserGroups
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssignmentDefinitionAssigneeSelectionMode
    {
        Multiple,
        Single
    }

    public class AssignmentDefinitionStateApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public AssignmentDefinitionStateType Type { get; set; }

        [JsonProperty("requireDocumentation")]
        public bool RequireDocumentation { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AssignmentDefinitionStateType
    {
        Initial,
        Step,
        Final
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CategorySelectionType
    {
        Multiple,
        Single
    }

    public class AssignmentDefinitionCategoryApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AssignmentDefinitionPriorityApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("criticalForOperation")]
        public bool CriticalForOperation { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }
    }

    public class CalendarApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public CalendarApiModel[] Items { get; set; }
    }

    public class CalendarApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owners")]
        public string[] Owners { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CreateCertificationBodyInput
    {
        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("competency", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Competency { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("renewal")]
        public string Renewal { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class CertificationApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public CertificationApiModel[] Items { get; set; }
    }

    public class CertificationApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("user")]
        public Referenceable User { get; set; }

        [JsonProperty("competency")]
        public Referenceable Competency { get; set; }

        [JsonProperty("awarded")]
        public string Awarded { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("renewal")]
        public string Renewal { get; set; }

        [JsonProperty("type")]
        public CertificationType Type { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CertificationType
    {
        Manual,
        Process
    }

    public class UpdateCertificationBodyInput
    {
        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("expiration")]
        public string Expiration { get; set; }

        [JsonProperty("renewal")]
        public string Renewal { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class ChecklistApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public ChecklistApiModel[] Items { get; set; }
    }

    public class ChecklistApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("primaryLanguage")]
        public string PrimaryLanguage { get; set; }

        [JsonProperty("folders")]
        public string[] Folders { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("pages")]
        public ChecklistPageApiModel[] Pages { get; set; }
    }

    public class ChecklistPageApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("elements")]
        public JToken[] Elements { get; set; }
    }

    public class UpdateChecklistBodyInput
    {
        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("folders")]
        public string[] Folders { get; set; }
    }

    public class CreateCompetencyBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CompetencyApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public CompetencyApiModel[] Items { get; set; }
    }

    public class CompetencyApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class UpdateCompetencyBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class CreateDowntimeBodyInput
    {
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    public class DowntimeApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public DowntimeApiModel[] Items { get; set; }
    }

    public class DowntimeApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignment")]
        public DowntimeAssignmentApiModel Assignment { get; set; }

        [JsonProperty("location")]
        public Referenceable Location { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("resolved")]
        public string Resolved { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("state")]
        public DowntimeState State { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class DowntimeAssignmentApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("status")]
        public AssignmentStatus Status { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DowntimeState
    {
        Open,
        Blocking,
        Resolved,
        Closed
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum StatesInputItem
    {
        Open,
        Blocking,
        Resolved,
        Closed
    }

    public class UpdateDowntimeBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    public class CloseDowntimeBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    public class FileApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("subscribers")]
        public string[] Subscribers { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }
    }

    public class AddCommentToFileBodyInput
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Id { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class CreateFileCategoryBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class FileCategoryListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public FileCategory[] Items { get; set; }
    }

    public class FileCategory
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class UpdateFileCategoryBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }

    public class CreateLocationBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("scannerCode")]
        public string ScannerCode { get; set; }

        [JsonProperty("rideOps")]
        public bool? RideOps { get; set; }

        [JsonProperty("operationalLogging")]
        public bool? OperationalLogging { get; set; }

        [JsonProperty("rideOpsSettings")]
        public LocationRideOpsSettingsCreateModelOptional RideOpsSettings { get; set; }

        [JsonProperty("address")]
        public CreateLocationAddress Address { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("locationGroups")]
        public string[] LocationGroups { get; set; }
    }

    public class LocationRideOpsSettingsCreateModelOptional
    {
        [JsonProperty("positions")]
        public CreateLocationLocationPosition[] Positions { get; set; }

        [JsonProperty("dispatchUnits")]
        public int? DispatchUnits { get; set; }

        [JsonProperty("dispatchUnitCapacity")]
        public int? DispatchUnitCapacity { get; set; }

        [JsonProperty("secondsBetweenDispatch")]
        public int? SecondsBetweenDispatch { get; set; }

        [JsonProperty("idealSecondsBetweenDispatch")]
        public int? IdealSecondsBetweenDispatch { get; set; }

        [JsonProperty("allowStatisticsForOperator")]
        public bool? AllowStatisticsForOperator { get; set; }

        [JsonProperty("preopeningChecklist")]
        public string PreopeningChecklist { get; set; }

        [JsonProperty("closingChecklist")]
        public string ClosingChecklist { get; set; }

        [JsonProperty("requirePreopeningChecklistApproval")]
        public bool? RequirePreopeningChecklistApproval { get; set; }

        [JsonProperty("preopeningChecklistValidityInMinutes")]
        public int? PreopeningChecklistValidityInMinutes { get; set; }

        [JsonProperty("messageForOperatorWhenNotReadyForOperation")]
        public string MessageForOperatorWhenNotReadyForOperation { get; set; }

        [JsonProperty("messageForOperatorWhenNoCriticalForOperationChecklistsPlanned")]
        public string MessageForOperatorWhenNoCriticalForOperationChecklistsPlanned { get; set; }

        [JsonProperty("operators")]
        public string[] Operators { get; set; }

        [JsonProperty("attendants")]
        public string[] Attendants { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("requiredCompetenciesForAttendants")]
        public string[] RequiredCompetenciesForAttendants { get; set; }

        [JsonProperty("attractionsIo")]
        public CreateLocationAttractionsIoIntegration AttractionsIo { get; set; }

        [JsonProperty("queueTimeUpdateWarningThreshold")]
        public int? QueueTimeUpdateWarningThreshold { get; set; }

        [JsonProperty("dispatchUpdateWarningThreshold")]
        public int? DispatchUpdateWarningThreshold { get; set; }

        [JsonProperty("maximumQueueTimeMinutes")]
        public int? MaximumQueueTimeMinutes { get; set; }

        [JsonProperty("queueTimeStepSizeMinutes")]
        public int? QueueTimeStepSizeMinutes { get; set; }

        [JsonProperty("minumumSecondsBetweenDispatches")]
        public int? MinumumSecondsBetweenDispatches { get; set; }

        [JsonProperty("lockDeviceSettings")]
        public bool? LockDeviceSettings { get; set; }

        [JsonProperty("deviceSettings")]
        public CreateLocationDeviceSettings DeviceSettings { get; set; }
    }

    public class CreateLocationLocationPosition
    {
        [JsonProperty("identifier")]
        public int? Identifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mandatory")]
        public bool? Mandatory { get; set; }

        [JsonProperty("index")]
        public int? Index { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }
    }

    public class CreateLocationAttractionsIoIntegration
    {
        [JsonProperty("queueId")]
        public string QueueId { get; set; }
    }

    public class CreateLocationDeviceSettings
    {
        [JsonProperty("allowChangingDispatchesWhenClosingLocation")]
        public bool? AllowChangingDispatchesWhenClosingLocation { get; set; }

        [JsonProperty("allowChangingRidersWhenClosingLocation")]
        public bool? AllowChangingRidersWhenClosingLocation { get; set; }

        [JsonProperty("showQueueTimeWidget")]
        public bool? ShowQueueTimeWidget { get; set; }

        [JsonProperty("showDispatchWidget")]
        public bool? ShowDispatchWidget { get; set; }

        [JsonProperty("maximumRidersPerDispatch")]
        public int? MaximumRidersPerDispatch { get; set; }

        [JsonProperty("dispatchWidgetType")]
        public string DispatchWidgetType { get; set; }

        [JsonProperty("dispatchGridNumberDirection")]
        public string DispatchGridNumberDirection { get; set; }

        [JsonProperty("dispatchMetric")]
        public string DispatchMetric { get; set; }
    }

    public class CreateLocationAddress
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoLocation")]
        public CreateLocationGeoCoordinate GeoLocation { get; set; }
    }

    public class CreateLocationGeoCoordinate
    {
        [JsonProperty("radius")]
        public double? Radius { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }
    }

    public class LocationApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public LocationApiModel[] Items { get; set; }
    }

    public class LocationApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("scannerCode")]
        public string ScannerCode { get; set; }

        [JsonProperty("operations")]
        public LocationOperationsApiModel Operations { get; set; }

        [JsonProperty("rideOps")]
        public LocationRideOpsSettings RideOps { get; set; }

        [JsonProperty("address")]
        public GetLocationAddressResponse Address { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }

        [JsonProperty("properties")]
        public LocationPropertyApiModel[] Properties { get; set; }

        [JsonProperty("locationGroups")]
        public string[] LocationGroups { get; set; }
    }

    public class LocationOperationsApiModel
    {
        [JsonProperty("state")]
        public LocationOperationalState State { get; set; }

        [JsonProperty("stateLastUpdated")]
        public string StateLastUpdated { get; set; }

        [JsonProperty("downtimeState")]
        public DowntimeState DowntimeState { get; set; }

        [JsonProperty("queue")]
        public LocationQueueApiModel Queue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum LocationOperationalState
    {
        Closed,
        Open
    }

    public class LocationQueueApiModel
    {
        [JsonProperty("queueTimeInMinutes")]
        public double QueueTimeInMinutes { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }
    }

    public class LocationRideOpsSettings
    {
        [JsonProperty("dispatchUnits")]
        public int DispatchUnits { get; set; }

        [JsonProperty("dispatchUnitCapacity")]
        public int DispatchUnitCapacity { get; set; }

        [JsonProperty("secondsBetweenDispatch")]
        public int SecondsBetweenDispatch { get; set; }

        [JsonProperty("idealSecondsBetweenDispatch")]
        public int IdealSecondsBetweenDispatch { get; set; }

        [JsonProperty("allowStatisticsForOperator")]
        public bool AllowStatisticsForOperator { get; set; }

        [JsonProperty("preopeningChecklist")]
        public string PreopeningChecklist { get; set; }

        [JsonProperty("closingChecklist")]
        public string ClosingChecklist { get; set; }

        [JsonProperty("requirePreopeningChecklistApproval")]
        public bool RequirePreopeningChecklistApproval { get; set; }

        [JsonProperty("preopeningChecklistValidityInMinutes")]
        public int PreopeningChecklistValidityInMinutes { get; set; }

        [JsonProperty("messageForOperatorWhenNotReadyForOperation")]
        public string MessageForOperatorWhenNotReadyForOperation { get; set; }

        [JsonProperty("messageForOperatorWhenNoCriticalForOperationChecklistsPlanned")]
        public string MessageForOperatorWhenNoCriticalForOperationChecklistsPlanned { get; set; }

        [JsonProperty("operators")]
        public string[] Operators { get; set; }

        [JsonProperty("attendants")]
        public string[] Attendants { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("requiredCompetenciesForAttendants")]
        public string[] RequiredCompetenciesForAttendants { get; set; }

        [JsonProperty("positions")]
        public GetLocationLocationPositionResponse[] Positions { get; set; }

        [JsonProperty("attractionsIo")]
        public GetLocationAttractionsIoIntegrationResponse AttractionsIo { get; set; }

        [JsonProperty("queueTimeUpdateWarningThreshold")]
        public int QueueTimeUpdateWarningThreshold { get; set; }

        [JsonProperty("dispatchUpdateWarningThreshold")]
        public int DispatchUpdateWarningThreshold { get; set; }

        [JsonProperty("maximumQueueTimeMinutes")]
        public int MaximumQueueTimeMinutes { get; set; }

        [JsonProperty("queueTimeStepSizeMinutes")]
        public int QueueTimeStepSizeMinutes { get; set; }

        [JsonProperty("minumumSecondsBetweenDispatches")]
        public int MinumumSecondsBetweenDispatches { get; set; }

        [JsonProperty("lockDeviceSettings")]
        public bool LockDeviceSettings { get; set; }

        [JsonProperty("deviceSettings")]
        public GetLocationDeviceSettingsResponse DeviceSettings { get; set; }
    }

    public class GetLocationLocationPositionResponse
    {
        [JsonProperty("identifier")]
        public int Identifier { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }

        [JsonProperty("deleted")]
        public string Deleted { get; set; }
    }

    public class GetLocationAttractionsIoIntegrationResponse
    {
        [JsonProperty("queueId")]
        public string QueueId { get; set; }
    }

    public class GetLocationDeviceSettingsResponse
    {
        [JsonProperty("allowChangingDispatchesWhenClosingLocation")]
        public bool AllowChangingDispatchesWhenClosingLocation { get; set; }

        [JsonProperty("allowChangingRidersWhenClosingLocation")]
        public bool AllowChangingRidersWhenClosingLocation { get; set; }

        [JsonProperty("showQueueTimeWidget")]
        public bool ShowQueueTimeWidget { get; set; }

        [JsonProperty("showDispatchWidget")]
        public bool ShowDispatchWidget { get; set; }

        [JsonProperty("maximumRidersPerDispatch")]
        public int MaximumRidersPerDispatch { get; set; }

        [JsonProperty("dispatchWidgetType")]
        public string DispatchWidgetType { get; set; }

        [JsonProperty("dispatchGridNumberDirection")]
        public string DispatchGridNumberDirection { get; set; }

        [JsonProperty("dispatchMetric")]
        public string DispatchMetric { get; set; }
    }

    public class GetLocationAddressResponse
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoLocation")]
        public GetLocationGeoCoordinateResponse GeoLocation { get; set; }
    }

    public class GetLocationGeoCoordinateResponse
    {
        [JsonProperty("radius")]
        public double Radius { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }
    }

    public class LocationPropertyApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class UpdateLocationBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("scannerCode")]
        public string ScannerCode { get; set; }

        [JsonProperty("rideOps")]
        public bool? RideOps { get; set; }

        [JsonProperty("operationalLogging")]
        public bool? OperationalLogging { get; set; }

        [JsonProperty("rideOpsSettings")]
        public LocationRideOpsSettingsUpdateModelOptional RideOpsSettings { get; set; }

        [JsonProperty("address")]
        public UpdateAddressModelOptional Address { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }

        [JsonProperty("properties")]
        public string[] Properties { get; set; }

        [JsonProperty("locationGroups")]
        public string[] LocationGroups { get; set; }
    }

    public class LocationRideOpsSettingsUpdateModelOptional
    {
        [JsonProperty("positions")]
        public CreateLocationLocationPosition[] Positions { get; set; }

        [JsonProperty("dispatchUnits")]
        public int? DispatchUnits { get; set; }

        [JsonProperty("dispatchUnitCapacity")]
        public int? DispatchUnitCapacity { get; set; }

        [JsonProperty("secondsBetweenDispatch")]
        public int? SecondsBetweenDispatch { get; set; }

        [JsonProperty("idealSecondsBetweenDispatch")]
        public int? IdealSecondsBetweenDispatch { get; set; }

        [JsonProperty("allowStatisticsForOperator")]
        public bool? AllowStatisticsForOperator { get; set; }

        [JsonProperty("preopeningChecklist")]
        public string PreopeningChecklist { get; set; }

        [JsonProperty("closingChecklist")]
        public string ClosingChecklist { get; set; }

        [JsonProperty("requirePreopeningChecklistApproval")]
        public bool? RequirePreopeningChecklistApproval { get; set; }

        [JsonProperty("preopeningChecklistValidityInMinutes")]
        public int? PreopeningChecklistValidityInMinutes { get; set; }

        [JsonProperty("messageForOperatorWhenNotReadyForOperation")]
        public string MessageForOperatorWhenNotReadyForOperation { get; set; }

        [JsonProperty("messageForOperatorWhenNoCriticalForOperationChecklistsPlanned")]
        public string MessageForOperatorWhenNoCriticalForOperationChecklistsPlanned { get; set; }

        [JsonProperty("operators")]
        public string[] Operators { get; set; }

        [JsonProperty("attendants")]
        public string[] Attendants { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("requiredCompetenciesForAttendants")]
        public string[] RequiredCompetenciesForAttendants { get; set; }

        [JsonProperty("attractionsIo")]
        public CreateLocationAttractionsIoIntegration AttractionsIo { get; set; }

        [JsonProperty("queueTimeUpdateWarningThreshold")]
        public int? QueueTimeUpdateWarningThreshold { get; set; }

        [JsonProperty("dispatchUpdateWarningThreshold")]
        public int? DispatchUpdateWarningThreshold { get; set; }

        [JsonProperty("maximumQueueTimeMinutes")]
        public int? MaximumQueueTimeMinutes { get; set; }

        [JsonProperty("queueTimeStepSizeMinutes")]
        public int? QueueTimeStepSizeMinutes { get; set; }

        [JsonProperty("minumumSecondsBetweenDispatches")]
        public int? MinumumSecondsBetweenDispatches { get; set; }

        [JsonProperty("lockDeviceSettings")]
        public bool? LockDeviceSettings { get; set; }

        [JsonProperty("deviceSettings")]
        public CreateLocationDeviceSettings DeviceSettings { get; set; }
    }

    public class UpdateAddressModelOptional
    {
        [JsonProperty("line1")]
        public string Line1 { get; set; }

        [JsonProperty("line2")]
        public string Line2 { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("geoLocation")]
        public UpdateGeoCoordinateModelOptional GeoLocation { get; set; }
    }

    public class UpdateGeoCoordinateModelOptional
    {
        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("radius")]
        public double? Radius { get; set; }
    }

    public class CloseLocationBodyInput
    {
        [JsonProperty("locations")]
        public string[] Locations { get; set; }
    }

    public class CreateLocationGroupBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }
    }

    public class LocationGroupApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public LocationGroupApiModel[] Items { get; set; }
    }

    public class LocationGroupApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }

        [JsonProperty("children")]
        public string[] Children { get; set; }

        [JsonProperty("descendants")]
        public string[] Descendants { get; set; }

        [JsonProperty("ancestors")]
        public string[] Ancestors { get; set; }
    }

    public class UpdateLocationGroupBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }
    }

    public class CreateLocationPropertyBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }
    }

    public class LocationPropertyApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public LocationPropertyApiModel[] Items { get; set; }
    }

    public class UpdateLocationPropertyBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }
    }

    public class NoteApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public NoteApiModel[] Items { get; set; }
    }

    public class NoteApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("assignment")]
        public string Assignment { get; set; }

        [JsonProperty("requiresApproval")]
        public bool RequiresApproval { get; set; }

        [JsonProperty("hasApproval")]
        public bool HasApproval { get; set; }
    }

    public class QuestionCategoryApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hierarchy")]
        public Referenceable Hierarchy { get; set; }

        [JsonProperty("path")]
        public string[] Path { get; set; }
    }

    public class ResultApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public ResultApiModel[] Items { get; set; }
    }

    public class ResultApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checklist")]
        public ResultChecklistApiModel Checklist { get; set; }

        [JsonProperty("checklistRevision")]
        public string ChecklistRevision { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("scheduleSlot")]
        public string ScheduleSlot { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("answered")]
        public string Answered { get; set; }

        [JsonProperty("received")]
        public string Received { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("maximumPoints")]
        public int MaximumPoints { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("deviations")]
        public ResultDeviations Deviations { get; set; }

        [JsonProperty("requiresValidation")]
        public bool RequiresValidation { get; set; }

        [JsonProperty("approval")]
        public ResultApproval Approval { get; set; }

        [JsonProperty("disapproval")]
        public ResultDisapproval Disapproval { get; set; }

        [JsonProperty("values")]
        public ResultValueApiModel[] Values { get; set; }
    }

    public class ResultChecklistApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("primaryLanguage")]
        public string PrimaryLanguage { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }

        [JsonProperty("pages")]
        public ResultPageApiModel[] Pages { get; set; }
    }

    public class ResultPageApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public JToken Name { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("questions")]
        public ResultQuestionApiModel[] Questions { get; set; }
    }

    public class ResultQuestionApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public JToken Text { get; set; }

        [JsonProperty("description")]
        public JToken Description { get; set; }

        [JsonProperty("stereotype")]
        public ElementStereotype Stereotype { get; set; }

        [JsonProperty("variation")]
        public SelectVariation Variation { get; set; }

        [JsonProperty("scoreIntervals")]
        public ScoreInterval[] ScoreIntervals { get; set; }

        [JsonProperty("options")]
        public ResultOptionApiModel[] Options { get; set; }

        [JsonProperty("images")]
        public string[] Images { get; set; }

        [JsonProperty("categories")]
        public string[] Categories { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ElementStereotype
    {
        Static,
        Question,
        Group
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SelectVariation
    {
        Multiple,
        Single
    }

    public class ScoreInterval
    {
        [JsonProperty("from")]
        public double From { get; set; }

        [JsonProperty("to")]
        public double To { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }

    public class ResultOptionApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public JToken Text { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }
    }

    public class ResultDeviations
    {
        [JsonProperty("tests")]
        public ResultDeviationTests Tests { get; set; }

        [JsonProperty("requireValidation")]
        public bool RequireValidation { get; set; }

        [JsonProperty("missingCompetencies")]
        public string[] MissingCompetencies { get; set; }

        [JsonProperty("outOfBoundsQuestions")]
        public string[] OutOfBoundsQuestions { get; set; }

        [JsonProperty("answeredTooLateDeviation")]
        public ResultAnsweredTooLateDeviation AnsweredTooLateDeviation { get; set; }

        [JsonProperty("answeredTooFastDeviation")]
        public ResultAnsweredTooFastDeviation AnsweredTooFastDeviation { get; set; }

        [JsonProperty("scoredBelowMaximumDeviation")]
        public ResultScoredBelowMaximumDeviation ScoredBelowMaximumDeviation { get; set; }

        [JsonProperty("explanation")]
        public ResultDeviationExplanation Explanation { get; set; }
    }

    public class ResultDeviationTests
    {
        [JsonProperty("outOfBounds")]
        public bool OutOfBounds { get; set; }

        [JsonProperty("answeredTooLate")]
        public bool AnsweredTooLate { get; set; }

        [JsonProperty("answeredTooFast")]
        public bool AnsweredTooFast { get; set; }

        [JsonProperty("scoredBelowMaximum")]
        public bool ScoredBelowMaximum { get; set; }

        [JsonProperty("requiredCompetencies")]
        public bool RequiredCompetencies { get; set; }
    }

    public class ResultAnsweredTooLateDeviation
    {
        [JsonProperty("expectedAnswered")]
        public string ExpectedAnswered { get; set; }
    }

    public class ResultAnsweredTooFastDeviation
    {
        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("requiredMinimumDuration")]
        public int RequiredMinimumDuration { get; set; }
    }

    public class ResultScoredBelowMaximumDeviation
    {
        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public class ResultDeviationExplanation
    {
        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("attachments")]
        public ImageAttachment[] Attachments { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }
    }

    public class ImageAttachment
    {
        [JsonProperty("cameraRoll")]
        public bool CameraRoll { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("fileRevision")]
        public int FileRevision { get; set; }
    }

    public class ResultApproval
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("otherResultsInBatch")]
        public string[] OtherResultsInBatch { get; set; }
    }

    public class ResultDisapproval
    {
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("otherResultsInBatch")]
        public string[] OtherResultsInBatch { get; set; }
    }

    public class ResultValueApiModel
    {
        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("maximumPoints")]
        public int MaximumPoints { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("answered")]
        public string Answered { get; set; }

        [JsonProperty("position")]
        public GeoPosition Position { get; set; }

        [JsonProperty("answers")]
        public string[] Answers { get; set; }

        [JsonProperty("images")]
        public ImageAttachment[] Images { get; set; }

        [JsonProperty("slots")]
        public string[] Slots { get; set; }

        [JsonProperty("assignments")]
        public string[] Assignments { get; set; }
    }

    public class GeoPosition
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("altitude")]
        public double Altitude { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("altitudeAccuracy")]
        public double AltitudeAccuracy { get; set; }

        [JsonProperty("heading")]
        public double Heading { get; set; }

        [JsonProperty("speed")]
        public double Speed { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class ApproveResultBodyInput
    {
        [JsonProperty("results")]
        public string[] Results { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("attachments")]
        public string[] Attachments { get; set; }
    }

    public class ChangeTargetOfResultBodyInput
    {
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }
    }

    public class ResultProgressApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("checklist")]
        public string Checklist { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("scheduleSlot")]
        public string ScheduleSlot { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("received")]
        public string Received { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("maximumPoints")]
        public int MaximumPoints { get; set; }

        [JsonProperty("isResumed")]
        public bool IsResumed { get; set; }

        [JsonProperty("resumed")]
        public string Resumed { get; set; }

        [JsonProperty("resumedBy")]
        public string ResumedBy { get; set; }

        [JsonProperty("resumableBy")]
        public string ResumableBy { get; set; }

        [JsonProperty("resumableName")]
        public string ResumableName { get; set; }

        [JsonProperty("progress")]
        public ResultProgress Progress { get; set; }

        [JsonProperty("values")]
        public ResultValueApiModel[] Values { get; set; }
    }

    public class ResultProgress
    {
        [JsonProperty("answeredQuestions")]
        public int AnsweredQuestions { get; set; }

        [JsonProperty("visibleQuestions")]
        public int VisibleQuestions { get; set; }

        [JsonProperty("percentage")]
        public double Percentage { get; set; }
    }

    public class RideOpsDispatchApiModel
    {
        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("riders")]
        public int Riders { get; set; }

        [JsonProperty("dispatchUnitCapacity")]
        public int DispatchUnitCapacity { get; set; }

        [JsonProperty("dispatchUnitsAvailable")]
        public int DispatchUnitsAvailable { get; set; }

        [JsonProperty("dispatchUnitCapacityAvailable")]
        public int DispatchUnitCapacityAvailable { get; set; }

        [JsonProperty("totalUnavailableCapacity")]
        public int TotalUnavailableCapacity { get; set; }
    }

    public class RideOpsQueueApiModel
    {
        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("queueTimeInMinutes")]
        public int QueueTimeInMinutes { get; set; }
    }

    public class RideOpsStatisticsApiModel
    {
        [JsonProperty("groupingInterval")]
        public GroupingInterval GroupingInterval { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("intervals")]
        public RideOpsStatisticsIntervalApiModel[] Intervals { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupingInterval
    {
        Year,
        Month,
        Week,
        Day,
        Hour
    }

    public class RideOpsStatisticsIntervalApiModel
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("riders")]
        public double Riders { get; set; }

        [JsonProperty("dispatches")]
        public double Dispatches { get; set; }

        [JsonProperty("capacityUtilization")]
        public double CapacityUtilization { get; set; }

        [JsonProperty("dispatchUtilization")]
        public double DispatchUtilization { get; set; }

        [JsonProperty("averageDispatchTime")]
        public double AverageDispatchTime { get; set; }
    }

    public class RoleApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public RoleApiModel[] Items { get; set; }
    }

    public class RoleApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public Referenceable[] Users { get; set; }

        [JsonProperty("userGroups")]
        public Referenceable[] UserGroups { get; set; }
    }

    public class UpdateRoleBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("userGroups")]
        public string[] UserGroups { get; set; }
    }

    public class ScheduleApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public ScheduleApiModel[] Items { get; set; }
    }

    public class ScheduleApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("calendars")]
        public string[] Calendars { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("reviewers")]
        public string[] Reviewers { get; set; }

        [JsonProperty("checklists")]
        public string[] Checklists { get; set; }

        [JsonProperty("owners")]
        public string[] Owners { get; set; }

        [JsonProperty("targets")]
        public string[] Targets { get; set; }

        [JsonProperty("targetExclusions")]
        public string[] TargetExclusions { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CreateScheduleSlotBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("start", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Start { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("end", DefaultValueHandling = DefaultValueHandling.Include)]
        public string End { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("assignees", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Assignees { get; set; }

        [JsonProperty("reviewers")]
        public string[] Reviewers { get; set; }

        [JsonProperty("owners")]
        public string[] Owners { get; set; }

        [JsonProperty("checklists", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Checklists { get; set; }

        [JsonProperty("targets", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Targets { get; set; }

        [JsonProperty("targetExclusions")]
        public string[] TargetExclusions { get; set; }

        [JsonProperty("assets")]
        public string[] Assets { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("enforceRequiredCompetencies")]
        public bool? EnforceRequiredCompetencies { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("allowEarlyStart")]
        public bool? AllowEarlyStart { get; set; }

        [JsonProperty("earlyStartMessage")]
        public string EarlyStartMessage { get; set; }

        [JsonProperty("notifyWhenAvailable")]
        public bool? NotifyWhenAvailable { get; set; }

        [JsonProperty("ignoreMissingResults")]
        public bool? IgnoreMissingResults { get; set; }

        [JsonProperty("requireValidation")]
        public bool? RequireValidation { get; set; }

        [JsonProperty("requireValidationWhenOutOfBounds")]
        public bool? RequireValidationWhenOutOfBounds { get; set; }

        [JsonProperty("requireValidationWhenAnsweredTooLate")]
        public bool? RequireValidationWhenAnsweredTooLate { get; set; }

        [JsonProperty("requireValidationWhenScoredBelowMaximum")]
        public bool? RequireValidationWhenScoredBelowMaximum { get; set; }

        [JsonProperty("requiredMinimumDuration")]
        public int? RequiredMinimumDuration { get; set; }

        [JsonProperty("criticality")]
        public CreateScheduleSlotScheduleCriticality? Criticality { get; set; }

        [JsonProperty("reminders")]
        public string[] Reminders { get; set; }

        [JsonProperty("resultVisibility")]
        public ResultVisibility? ResultVisibility { get; set; }

        [JsonProperty("timeRegistration")]
        public TimeRegistration? TimeRegistration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateScheduleSlotScheduleCriticality
    {
        Always,
        Overdue,
        Missing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResultVisibility
    {
        Assignees,
        Creator,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeRegistration
    {
        Optional,
        Required
    }

    public class ScheduleSlotApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("schedule")]
        public string Schedule { get; set; }

        [JsonProperty("calendar")]
        public string Calendar { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("reviewers")]
        public string[] Reviewers { get; set; }

        [JsonProperty("targets")]
        public string[] Targets { get; set; }

        [JsonProperty("targetExclusions")]
        public string[] TargetExclusions { get; set; }

        [JsonProperty("checklists")]
        public string[] Checklists { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("allowEarlyStart")]
        public bool AllowEarlyStart { get; set; }

        [JsonProperty("earlyStartMessage")]
        public string EarlyStartMessage { get; set; }

        [JsonProperty("ignoreMissingResults")]
        public bool IgnoreMissingResults { get; set; }

        [JsonProperty("requireValidation")]
        public bool RequireValidation { get; set; }

        [JsonProperty("requireValidationWhenOutOfBounds")]
        public bool RequireValidationWhenOutOfBounds { get; set; }

        [JsonProperty("requireValidationWhenAnsweredTooLate")]
        public bool RequireValidationWhenAnsweredTooLate { get; set; }

        [JsonProperty("requireValidationWhenScoredBelowMaximum")]
        public bool RequireValidationWhenScoredBelowMaximum { get; set; }

        [JsonProperty("requiredMinimumDuration")]
        public int RequiredMinimumDuration { get; set; }

        [JsonProperty("criticality")]
        public GetScheduleSlotScheduleCriticalityResponse Criticality { get; set; }

        [JsonProperty("reminders")]
        public string[] Reminders { get; set; }

        [JsonProperty("completed")]
        public CompletedCalendarScheduleUnit[] Completed { get; set; }

        [JsonProperty("missing")]
        public MissingCalendarScheduleUnit[] Missing { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetScheduleSlotScheduleCriticalityResponse
    {
        Always,
        Overdue,
        Missing
    }

    public class CompletedCalendarScheduleUnit
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("checklist")]
        public string Checklist { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }

        [JsonProperty("answered")]
        public string Answered { get; set; }

        [JsonProperty("received")]
        public string Received { get; set; }
    }

    public class MissingCalendarScheduleUnit
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("checklist")]
        public string Checklist { get; set; }

        [JsonProperty("asset")]
        public string Asset { get; set; }
    }

    public class UpdateAdHocScheduleSlotBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("due")]
        public string Due { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("assignees")]
        public string[] Assignees { get; set; }

        [JsonProperty("reviewers")]
        public string[] Reviewers { get; set; }

        [JsonProperty("owners")]
        public string[] Owners { get; set; }

        [JsonProperty("checklists")]
        public string[] Checklists { get; set; }

        [JsonProperty("targets")]
        public string[] Targets { get; set; }

        [JsonProperty("targetExclusions")]
        public string[] TargetExclusions { get; set; }

        [JsonProperty("assets")]
        public string[] Assets { get; set; }

        [JsonProperty("requiredCompetencies")]
        public string[] RequiredCompetencies { get; set; }

        [JsonProperty("enforceRequiredCompetencies")]
        public bool? EnforceRequiredCompetencies { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("allowEarlyStart")]
        public bool? AllowEarlyStart { get; set; }

        [JsonProperty("earlyStartMessage")]
        public string EarlyStartMessage { get; set; }

        [JsonProperty("notifyWhenAvailable")]
        public bool? NotifyWhenAvailable { get; set; }

        [JsonProperty("ignoreMissingResults")]
        public bool? IgnoreMissingResults { get; set; }

        [JsonProperty("requireValidation")]
        public bool? RequireValidation { get; set; }

        [JsonProperty("requireValidationWhenOutOfBounds")]
        public bool? RequireValidationWhenOutOfBounds { get; set; }

        [JsonProperty("requireValidationWhenAnsweredTooLate")]
        public bool? RequireValidationWhenAnsweredTooLate { get; set; }

        [JsonProperty("requireValidationWhenScoredBelowMaximum")]
        public bool? RequireValidationWhenScoredBelowMaximum { get; set; }

        [JsonProperty("requiredMinimumDuration")]
        public int? RequiredMinimumDuration { get; set; }

        [JsonProperty("criticality")]
        public ScheduleCriticalityNullableOptional? Criticality { get; set; }

        [JsonProperty("reminders")]
        public string[] Reminders { get; set; }

        [JsonProperty("resultVisibility")]
        public ResultVisibilityOptional? ResultVisibility { get; set; }

        [JsonProperty("timeRegistration")]
        public TimeRegistrationNullableOptional? TimeRegistration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScheduleCriticalityNullableOptional
    {
        Always,
        Overdue,
        Missing
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ResultVisibilityOptional
    {
        Assignees,
        Creator,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TimeRegistrationNullableOptional
    {
        Optional,
        Required
    }

    public class CreateTimesheetBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user", DefaultValueHandling = DefaultValueHandling.Include)]
        public string User { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("started", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Started { get; set; }

        [JsonProperty("stopped")]
        public string Stopped { get; set; }
    }

    public class TimesheetEntryApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public TimesheetEntryApiModel[] Items { get; set; }
    }

    public class TimesheetEntryApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("startedFrom")]
        public Frontend StartedFrom { get; set; }

        [JsonProperty("stopped")]
        public string Stopped { get; set; }

        [JsonProperty("stoppedFrom")]
        public Frontend StoppedFrom { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Frontend
    {
        Unknown,
        RideOps,
        App,
        Web,
        Api
    }

    public class UpdateTimesheetBodyInput
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("started")]
        public string Started { get; set; }

        [JsonProperty("stopped")]
        public string Stopped { get; set; }
    }

    public class TimesheetEntryTypeApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public TimesheetEntryTypeApiModel[] Items { get; set; }
    }

    public class TimesheetEntryTypeApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isDeleted")]
        public bool IsDeleted { get; set; }
    }

    public class CreateUptimePeriodBodyInput
    {
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("opened", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opened { get; set; }

        [JsonProperty("closed", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Closed { get; set; }
    }

    public class DeleteUptimePeriodBodyInput
    {
        [JsonProperty("periods")]
        public UptimePeriodCompositeIdentifier[] Periods { get; set; }
    }

    public class UptimePeriodCompositeIdentifier
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }
    }

    public class UptimePeriodApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public UptimePeriodApiModel[] Items { get; set; }
    }

    public class UptimePeriodApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("opened")]
        public string Opened { get; set; }

        [JsonProperty("closed")]
        public string Closed { get; set; }

        [JsonProperty("openedBy")]
        public string OpenedBy { get; set; }

        [JsonProperty("closedBy")]
        public string ClosedBy { get; set; }

        [JsonProperty("downtime")]
        public UptimeDowntimeApiModel Downtime { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }
    }

    public class UptimeDowntimeApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignment")]
        public string Assignment { get; set; }

        [JsonProperty("state")]
        public DowntimeState State { get; set; }
    }

    public class UpdateUptimePeriodBodyInput
    {
        [JsonProperty("period", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Period { get; set; }

        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Location { get; set; }

        [JsonProperty("opened", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Opened { get; set; }

        [JsonProperty("closed", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Closed { get; set; }
    }

    public class CreateUserBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("password", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Password { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("forcePasswordChange")]
        public bool? ForcePasswordChange { get; set; }

        [JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("pinCode")]
        public string PinCode { get; set; }

        [JsonProperty("encouragePinCodeChange")]
        public bool? EncouragePinCodeChange { get; set; }

        [JsonProperty("additionalEmails")]
        public string[] AdditionalEmails { get; set; }

        [JsonProperty("address")]
        public CreateLocationAddress Address { get; set; }

        [JsonProperty("temperatureUnit")]
        public CreateUserTemperatureUnit? TemperatureUnit { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateUserTemperatureUnit
    {
        Celsius,
        Fahrenheit
    }

    public class UserApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public UserApiModel[] Items { get; set; }
    }

    public class UserApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("forcePasswordChange")]
        public bool ForcePasswordChange { get; set; }

        [JsonProperty("encouragePinCodeChange")]
        public bool EncouragePinCodeChange { get; set; }

        [JsonProperty("isSuperUser")]
        public bool IsSuperUser { get; set; }

        [JsonProperty("isDisabled")]
        public bool IsDisabled { get; set; }

        [JsonProperty("address")]
        public GetLocationAddressResponse Address { get; set; }

        [JsonProperty("temperatureUnit")]
        public GetUserTemperatureUnitResponse TemperatureUnit { get; set; }

        [JsonProperty("userGroups")]
        public Referenceable[] UserGroups { get; set; }

        [JsonProperty("additionalEmails")]
        public string[] AdditionalEmails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GetUserTemperatureUnitResponse
    {
        Celsius,
        Fahrenheit
    }

    public class UpdateUserBodyInput
    {
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("pinCode")]
        public string PinCode { get; set; }

        [JsonProperty("forcePasswordChange")]
        public bool? ForcePasswordChange { get; set; }

        [JsonProperty("isDisabled")]
        public bool? IsDisabled { get; set; }

        [JsonProperty("encouragePinCodeChange")]
        public bool? EncouragePinCodeChange { get; set; }

        [JsonProperty("lockedProfile")]
        public bool? LockedProfile { get; set; }

        [JsonProperty("disableMobaroAuthentication")]
        public bool? DisableMobaroAuthentication { get; set; }

        [JsonProperty("address")]
        public UpdateAddressModelOptional Address { get; set; }

        [JsonProperty("temperatureUnit")]
        public TemperatureUnitNullableOptional? TemperatureUnit { get; set; }

        [JsonProperty("additionalEmails")]
        public string[] AdditionalEmails { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TemperatureUnitNullableOptional
    {
        Celsius,
        Fahrenheit
    }

    public class CreateUserGroupBodyInput
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("delegateableUserGroups")]
        public string[] DelegateableUserGroups { get; set; }

        [JsonProperty("locations")]
        public string[] Locations { get; set; }

        [JsonProperty("locationGroups")]
        public string[] LocationGroups { get; set; }

        [JsonProperty("assignability")]
        public CreateUserGroupUserGroupAssignability Assignability { get; set; }
    }

    public class CreateUserGroupUserGroupAssignability
    {
        [JsonProperty("assignments")]
        public bool? Assignments { get; set; }
    }

    public class UserGroupApiModelListApiResult
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("items")]
        public UserGroupApiModel[] Items { get; set; }
    }

    public class UserGroupApiModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public Referenceable[] Users { get; set; }

        [JsonProperty("assignability")]
        public GetUserGroupUserGroupAssignabilityResponse Assignability { get; set; }
    }

    public class GetUserGroupUserGroupAssignabilityResponse
    {
        [JsonProperty("assignments")]
        public bool Assignments { get; set; }
    }

    public class UpdateUserGroupBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("users")]
        public string[] Users { get; set; }

        [JsonProperty("delegateableUserGroups")]
        public string[] DelegateableUserGroups { get; set; }

        [JsonProperty("assignability")]
        public UserGroupAssignabilityOptional Assignability { get; set; }
    }

    public class UserGroupAssignabilityOptional
    {
        [JsonProperty("assignments")]
        public bool? Assignments { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mobaro;

    public partial class WorkflowManagedActions
    {
        public MobaroActions Mobaro(string connectionId) => new MobaroActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MobaroTriggers Mobaro(string connectionId) => new MobaroTriggers(connectionId);
    }
}