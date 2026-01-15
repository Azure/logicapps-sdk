//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Wqrmriskforecastserv
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WqrmriskforecastservActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyTenantFirstName = null, Expression<Func<string>> bodyTenantLastName = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyEmail = null)
        {
            var apiCallPath = "/play/371c4dca-f7af-48b7-8dfa-cd6864969ba5";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyTenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodyTenantFirstName);
                bodypropCount++;
            }

            if (bodyTenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodyTenantLastName);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyTenantFirstName = null, Expression<Func<string>> bodyTenantLastName = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyEmail = null)
        {
            var apiCallPath = "/play/e5f00dbd-dc28-4b35-8550-1901efa36af7";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyTenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodyTenantFirstName);
                bodypropCount++;
            }

            if (bodyTenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodyTenantLastName);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementBanks(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyTenantFirstName = null, Expression<Func<string>> bodyTenantLastName = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyEmail = null)
        {
            var apiCallPath = "/play/158ed27b-9e89-45d2-a216-617d0b2d4355";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyTenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodyTenantFirstName);
                bodypropCount++;
            }

            if (bodyTenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodyTenantLastName);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementCUs(Expression<Func<string>> tenantId = null, Expression<Func<string>> contentType = null, Expression<Func<string>> accept = null, Expression<Func<string>> bodyName = null, Expression<Func<string>> bodyTenantFirstName = null, Expression<Func<string>> bodyTenantLastName = null, Expression<Func<string>> bodyCompanyName = null, Expression<Func<string>> bodyEmail = null)
        {
            var apiCallPath = "/play/b60262a8-7cf2-4526-8e78-c7fc7bd21ae9";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (tenantId != null)
                callPayload.Queries["tenantId"] = ExpressionConverter.Convert(tenantId);
            if (contentType != null)
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyName != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyName);
                bodypropCount++;
            }

            if (bodyTenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodyTenantFirstName);
                bodypropCount++;
            }

            if (bodyTenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodyTenantLastName);
                bodypropCount++;
            }

            if (bodyCompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodyCompanyName);
                bodypropCount++;
            }

            if (bodyEmail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
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
    using Microsoft.Azure.Workflows.Sdk.Wqrmriskforecastserv;

    public partial class WorkflowManagedActions
    {
        public WqrmriskforecastservActions Wqrmriskforecastserv(string connectionId) => new WqrmriskforecastservActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WqrmriskforecastservTriggers Wqrmriskforecastserv(string connectionId) => new WqrmriskforecastservTriggers(connectionId);
    }
}