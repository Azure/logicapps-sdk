//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wqrmriskforecastserv
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WqrmriskforecastservActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupReportBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<GroupReportBanksInput>> body = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/play/371c4dca-f7af-48b7-8dfa-cd6864969ba5";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tenantId != null)
                    callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupReportCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<GroupReportCUsInput>> body = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/play/e5f00dbd-dc28-4b35-8550-1901efa36af7";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tenantId != null)
                    callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReportManagementBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<ReportManagementBanksInput>> body = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/play/158ed27b-9e89-45d2-a216-617d0b2d4355";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tenantId != null)
                    callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReportManagementCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<ReportManagementCUsInput>> body = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/play/b60262a8-7cf2-4526-8e78-c7fc7bd21ae9";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_tenantId != null)
                    callPayload.Queries["tenantId"] = ExpressionConverter.Convert(__workflow_tenantId);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(__workflow_accept);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WqrmriskforecastservTriggers([ConnectionName] string connectionId)
    {
    }

    public class GroupReportBanksInput
    {
        public string Name { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }

    public class GroupReportCUsInput
    {
        public string Name { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }

    public class ReportManagementBanksInput
    {
        public string Name { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }

    public class ReportManagementCUsInput
    {
        public string Name { get; set; }
        public string TenantFirstName { get; set; }
        public string TenantLastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wqrmriskforecastserv;

    public partial class WorkflowManagedActions
    {
        public WqrmriskforecastservActions Wqrmriskforecastserv(string connectionId) => new WqrmriskforecastservActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WqrmriskforecastservTriggers Wqrmriskforecastserv(string connectionId) => new WqrmriskforecastservTriggers(connectionId);
    }
}