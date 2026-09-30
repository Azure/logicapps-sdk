//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wqrmriskforecastserv
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WqrmriskforecastservActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportBanks([WorkflowExpression] Func<string> tenantId = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytenantFirstName = null, [WorkflowExpression] Func<string> bodytenantLastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyemail = null)
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
            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction GroupReportCUs([WorkflowExpression] Func<string> tenantId = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytenantFirstName = null, [WorkflowExpression] Func<string> bodytenantLastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyemail = null)
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
            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementBanks([WorkflowExpression] Func<string> tenantId = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytenantFirstName = null, [WorkflowExpression] Func<string> bodytenantLastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyemail = null)
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
            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wqrmriskforecastserv")]
        public IWorkflowAction ReportManagementCUs([WorkflowExpression] Func<string> tenantId = null, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> accept = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodytenantFirstName = null, [WorkflowExpression] Func<string> bodytenantLastName = null, [WorkflowExpression] Func<string> bodycompanyName = null, [WorkflowExpression] Func<string> bodyemail = null)
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
            if (bodyname != null)
            {
                body["Name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytenantFirstName != null)
            {
                body["TenantFirstName"] = ExpressionConverter.ConvertO(bodytenantFirstName);
                bodypropCount++;
            }

            if (bodytenantLastName != null)
            {
                body["TenantLastName"] = ExpressionConverter.ConvertO(bodytenantLastName);
                bodypropCount++;
            }

            if (bodycompanyName != null)
            {
                body["CompanyName"] = ExpressionConverter.ConvertO(bodycompanyName);
                bodypropCount++;
            }

            if (bodyemail != null)
            {
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
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