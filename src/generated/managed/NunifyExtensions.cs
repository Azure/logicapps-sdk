//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nunify
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class NunifyActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nunify")]
        public IBodyWorkflowAction<ADDREGISTRANTResponse> ADDREGISTRANT(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, Expression<Func<string>> bodyemail = null, Expression<Func<string>> bodyfirstName = null, Expression<Func<string>> bodylastName = null, Expression<Func<string>> bodydesignation = null, Expression<Func<string>> bodycompany = null, Expression<Func<string>> bodyticketTypeId = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: false);
            var __workflow_bodyfirstName = WorkflowExpression.Compile(bodyfirstName, nameof(bodyfirstName), required: false);
            var __workflow_bodylastName = WorkflowExpression.Compile(bodylastName, nameof(bodylastName), required: false);
            var __workflow_bodydesignation = WorkflowExpression.Compile(bodydesignation, nameof(bodydesignation), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            var __workflow_bodyticketTypeId = WorkflowExpression.Compile(bodyticketTypeId, nameof(bodyticketTypeId), required: false);
            return new DeferredBodyAction<ADDREGISTRANTResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/tickets.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_appId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["map_by_labels"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                    bodypropCount++;
                }

                if (__workflow_bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(__workflow_bodyfirstName);
                    bodypropCount++;
                }

                if (__workflow_bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(__workflow_bodylastName);
                    bodypropCount++;
                }

                if (__workflow_bodydesignation != null)
                {
                    body["designation"] = ExpressionConverter.ConvertO(__workflow_bodydesignation);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (__workflow_bodyticketTypeId != null)
                {
                    if (__workflow_bodyticketTypeId != null)
                    {
                        body["ticket_type_id"] = ExpressionConverter.ConvertO(__workflow_bodyticketTypeId);
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
            });
        }
    }

    public class NunifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NEWREGISTRATION(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, FlowRecurrence recurrence = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/ticket_create.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_appId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["kind"] = "ticket_create";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger NEWCHECKIN(Expression<Func<string>> platformId, Expression<Func<string>> domainId, Expression<Func<string>> appId, FlowRecurrence recurrence = null)
        {
            var __workflow_platformId = WorkflowExpression.Compile(platformId, nameof(platformId), required: true);
            var __workflow_domainId = WorkflowExpression.Compile(domainId, nameof(domainId), required: true);
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/checkin.json", ExpressionConverter.ConvertWithUrlEncoding(__workflow_platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_appId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["kind"] = "checkin";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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
