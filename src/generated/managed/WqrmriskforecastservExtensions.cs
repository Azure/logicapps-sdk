//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wqrmriskforecastserv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WqrmriskforecastservActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/play/371c4dca-f7af-48b7-8dfa-cd6864969ba5";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = CSharpExpressionConverter.ConvertO(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = CSharpExpressionConverter.ConvertToken(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = CSharpExpressionConverter.ConvertToken(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/play/e5f00dbd-dc28-4b35-8550-1901efa36af7";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = CSharpExpressionConverter.ConvertO(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = CSharpExpressionConverter.ConvertToken(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = CSharpExpressionConverter.ConvertToken(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/play/158ed27b-9e89-45d2-a216-617d0b2d4355";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = CSharpExpressionConverter.ConvertO(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = CSharpExpressionConverter.ConvertToken(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = CSharpExpressionConverter.ConvertToken(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodytenantFirstName = null, Expression<Func<string>> bodytenantLastName = null, Expression<Func<string>> bodycompanyName = null, Expression<Func<string>> bodyemail = null)
        {
            var apiCallPath = "/play/b60262a8-7cf2-4526-8e78-c7fc7bd21ae9";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = CSharpExpressionConverter.ConvertO(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = CSharpExpressionConverter.ConvertO(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = CSharpExpressionConverter.ConvertO(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["Name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = CSharpExpressionConverter.ConvertToken(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = CSharpExpressionConverter.ConvertToken(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = CSharpExpressionConverter.ConvertToken(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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