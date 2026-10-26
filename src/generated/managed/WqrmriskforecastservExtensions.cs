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
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupReportBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytenantFirstName = WorkflowExpression.Compile(bodytenantFirstName, nameof(bodytenantFirstName), required: false);
            var __workflow_bodytenantLastName = WorkflowExpression.Compile(bodytenantLastName, nameof(bodytenantLastName), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytenantFirstName != null)
                {
                    body["TenantFirstName"] = ExpressionConverter.ConvertO(__workflow_bodytenantFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodytenantLastName != null)
                {
                    body["TenantLastName"] = ExpressionConverter.ConvertO(__workflow_bodytenantLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GroupReportCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytenantFirstName = WorkflowExpression.Compile(bodytenantFirstName, nameof(bodytenantFirstName), required: false);
            var __workflow_bodytenantLastName = WorkflowExpression.Compile(bodytenantLastName, nameof(bodytenantLastName), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytenantFirstName != null)
                {
                    body["TenantFirstName"] = ExpressionConverter.ConvertO(__workflow_bodytenantFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodytenantLastName != null)
                {
                    body["TenantLastName"] = ExpressionConverter.ConvertO(__workflow_bodytenantLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReportManagementBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytenantFirstName = WorkflowExpression.Compile(bodytenantFirstName, nameof(bodytenantFirstName), required: false);
            var __workflow_bodytenantLastName = WorkflowExpression.Compile(bodytenantLastName, nameof(bodytenantLastName), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytenantFirstName != null)
                {
                    body["TenantFirstName"] = ExpressionConverter.ConvertO(__workflow_bodytenantFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodytenantLastName != null)
                {
                    body["TenantLastName"] = ExpressionConverter.ConvertO(__workflow_bodytenantLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ReportManagementCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var __workflow_tenantId = WorkflowExpression.Compile(tenantId, nameof(tenantId), required: false);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_accept = WorkflowExpression.Compile(accept, nameof(accept), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodytenantFirstName = WorkflowExpression.Compile(bodytenantFirstName, nameof(bodytenantFirstName), required: false);
            var __workflow_bodytenantLastName = WorkflowExpression.Compile(bodytenantLastName, nameof(bodytenantLastName), required: false);
            var __workflow_bodycompanyName = WorkflowExpression.Compile(bodycompanyName, nameof(bodycompanyName), required: false);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
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
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["Name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodytenantFirstName != null)
                {
                    body["TenantFirstName"] = ExpressionConverter.ConvertO(__workflow_bodytenantFirstName);
                    bodypropCount++;
                }

                if (__workflow_bodytenantLastName != null)
                {
                    body["TenantLastName"] = ExpressionConverter.ConvertO(__workflow_bodytenantLastName);
                    bodypropCount++;
                }

                if (__workflow_bodycompanyName != null)
                {
                    body["CompanyName"] = ExpressionConverter.ConvertO(__workflow_bodycompanyName);
                    bodypropCount++;
                }

                if (__workflow_bodyemail != null)
                {
                    body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class WqrmriskforecastservTriggers([ConnectionName] string connectionId)
    {
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