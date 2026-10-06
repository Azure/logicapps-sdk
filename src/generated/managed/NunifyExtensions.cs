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
        public IBodyWorkflowAction<ADDREGISTRANTResponse> ADDREGISTRANT([WorkflowExpression] Func<string> platformId, [WorkflowExpression] Func<string> domainId, [WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodydesignation = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyticketTypeId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/tickets.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["map_by_labels"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodydesignation != null)
                {
                    body["designation"] = SourceExpressionConverter.ConvertToken(bodydesignation);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodyticketTypeId != null)
                {
                    if (bodyticketTypeId != null)
                    {
                        body["ticket_type_id"] = SourceExpressionConverter.ConvertToken(bodyticketTypeId);
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
                return callPayload;
            }

            return new ApiConnectionAction<ADDREGISTRANTResponse>(BuildSourceInput);
        }
    }

    public class NunifyTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger NEWREGISTRATION([WorkflowExpression] Func<string> platformId, [WorkflowExpression] Func<string> domainId, [WorkflowExpression] Func<string> appId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/ticket_create.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger NEWCHECKIN([WorkflowExpression] Func<string> platformId, [WorkflowExpression] Func<string> domainId, [WorkflowExpression] Func<string> appId, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/checkin.json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(platformId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(domainId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(appId, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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