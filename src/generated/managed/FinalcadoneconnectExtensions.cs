//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Finalcadoneconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FinalcadoneconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<GetOrganizationsResponseItem[]> GetOrganizations(Expression<Func<string>> acceptLanguage = null, Expression<Func<string>> xTimeZone = null)
        {
            var apiCallPath = "/organizations";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept-Language"] = Convert.ToString("en");
            if (acceptLanguage != null)
                callPayload.Headers["Accept-Language"] = ExpressionConverter.Convert(acceptLanguage);
            callPayload.Headers["X-TimeZone"] = Convert.ToString("");
            if (xTimeZone != null)
                callPayload.Headers["X-TimeZone"] = ExpressionConverter.Convert(xTimeZone);
            return new ApiConnectionAction<GetOrganizationsResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitParametersResponse> InitParameters(Expression<Func<string>> bodylanguage = null, Expression<Func<string>> bodytheUserSTimeZoneInIANAFormat = null)
        {
            var apiCallPath = "/InitParameters";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodylanguage != null)
            {
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                bodypropCount++;
            }

            if (bodytheUserSTimeZoneInIANAFormat != null)
            {
                body["timezone"] = ExpressionConverter.ConvertO(bodytheUserSTimeZoneInIANAFormat);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InitParametersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "finalcadoneconnect")]
        public IBodyWorkflowAction<InitResponse> Init(Expression<Func<string>> bodyorganizationID = null, Expression<Func<string>> bodyprojectID = null)
        {
            var apiCallPath = "/init";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyorganizationID != null)
            {
                body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
                bodypropCount++;
            }

            if (bodyprojectID != null)
            {
                body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<InitResponse>(callPayload);
        }
    }

    public class FinalcadoneconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ThenObsCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID)
        {
            var apiCallPath = "/webhooks/ev/201";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
            body["client_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ThenObsUpdated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID)
        {
            var apiCallPath = "/webhooks/ev/202";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
            body["client_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ThenFormCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID)
        {
            var apiCallPath = "/webhooks/ev/301";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
            body["client_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ThenFormUpdated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID)
        {
            var apiCallPath = "/webhooks/ev/302";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
            body["client_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger ThenDocumentCreated(Expression<Func<string>> bodyorganizationID, Expression<Func<string>> bodyprojectID)
        {
            var apiCallPath = "/webhooks/ev/401";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["business_organization_id"] = ExpressionConverter.ConvertO(bodyorganizationID);
            bodypropCount++;
            body["project_id"] = ExpressionConverter.ConvertO(bodyprojectID);
            body["client_url"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class GetOrganizationsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class InitParametersResponse
    {
        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }

    public class InitResponse
    {
        [JsonProperty("business_organization_id")]
        public string BusinessOrganizationId { get; set; }

        [JsonProperty("project_id")]
        public string ProjectId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Finalcadoneconnect;

    public partial class WorkflowManagedActions
    {
        public FinalcadoneconnectActions Finalcadoneconnect(string connectionId) => new FinalcadoneconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FinalcadoneconnectTriggers Finalcadoneconnect(string connectionId) => new FinalcadoneconnectTriggers(connectionId);
    }
}