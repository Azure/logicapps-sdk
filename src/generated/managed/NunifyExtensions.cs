//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nunify
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NunifyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nunify")]
        public IBodyWorkflowAction<ADDREGISTRANTResponse> ADDREGISTRANT(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyticketTypeId = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/tickets.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["map_by_labels"] = Convert.ToString(true);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyemail != null)
            {
                body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
            }

            if (bodyfirstName != null)
            {
                body["first_name"] = CSharpExpressionConverter.ConvertToken(bodyfirstName);
                bodypropCount++;
            }

            if (bodylastName != null)
            {
                body["last_name"] = CSharpExpressionConverter.ConvertToken(bodylastName);
                bodypropCount++;
            }

            if (bodydesignation != null)
            {
                body["designation"] = CSharpExpressionConverter.ConvertToken(bodydesignation);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["company"] = CSharpExpressionConverter.ConvertToken(bodycompany);
                bodypropCount++;
            }

            if (bodyticketTypeId != null)
            {
                if (bodyticketTypeId != null)
                {
                    body["ticket_type_id"] = CSharpExpressionConverter.ConvertToken(bodyticketTypeId);
                    bodypropCount++;
                }

                bodypropCount++;
            }
            else
            {
                body["ticket_type_id"] = "Default";
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ADDREGISTRANTResponse>(callPayload);
        }
    }

    public class NunifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NEWREGISTRATION(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/ticket_create.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["kind"] = "ticket_create";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger NEWCHECKIN(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/checkin.json", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["url"] = "@listCallbackUrl()";
            bodypropCount++;
            body["kind"] = "checkin";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }

    public class ADDREGISTRANTResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("designation")]
        public string Designation { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Nunify;

    public partial class WorkflowManagedActions
    {
        public NunifyActions Nunify(string connectionId) => new NunifyActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public NunifyTriggers Nunify(string connectionId) => new NunifyTriggers(connectionId);
    }
}