//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Nunify
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class NunifyActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "nunify")]
        [WorkflowExpressionFactory(nameof(__BuildADDREGISTRANT))]
        public IBodyWorkflowAction<ADDREGISTRANTResponse> ADDREGISTRANT([WorkflowExpression] Func<string> platformId, [WorkflowExpression] Func<string> domainId, [WorkflowExpression] Func<string> appId, [WorkflowExpression] Func<string> bodyemail = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodydesignation = null, [WorkflowExpression] Func<string> bodycompany = null, [WorkflowExpression] Func<string> bodyticketTypeId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ADDREGISTRANTResponse> __BuildADDREGISTRANT(WorkflowExpression<string> platformId, WorkflowExpression<string> domainId, WorkflowExpression<string> appId, WorkflowExpression<string> bodyemail = null, WorkflowExpression<string> bodyfirstName = null, WorkflowExpression<string> bodylastName = null, WorkflowExpression<string> bodydesignation = null, WorkflowExpression<string> bodycompany = null, WorkflowExpression<string> bodyticketTypeId = null)
        {
            WorkflowExpression.Validate(platformId, nameof(platformId), required: true);
            WorkflowExpression.Validate(domainId, nameof(domainId), required: true);
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: false);
            WorkflowExpression.Validate(bodyfirstName, nameof(bodyfirstName), required: false);
            WorkflowExpression.Validate(bodylastName, nameof(bodylastName), required: false);
            WorkflowExpression.Validate(bodydesignation, nameof(bodydesignation), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            WorkflowExpression.Validate(bodyticketTypeId, nameof(bodyticketTypeId), required: false);
            return new DeferredBodyAction<ADDREGISTRANTResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/tickets.json", ExpressionConverter.ConvertWithUrlEncoding(platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["map_by_labels"] = Convert.ToString(true);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemail != null)
                {
                    body["email"] = ExpressionConverter.ConvertO(bodyemail);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first_name"] = ExpressionConverter.ConvertO(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last_name"] = ExpressionConverter.ConvertO(bodylastName);
                    bodypropCount++;
                }

                if (bodydesignation != null)
                {
                    body["designation"] = ExpressionConverter.ConvertO(bodydesignation);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["company"] = ExpressionConverter.ConvertO(bodycompany);
                    bodypropCount++;
                }

                if (bodyticketTypeId != null)
                {
                    if (bodyticketTypeId != null)
                    {
                        body["ticket_type_id"] = ExpressionConverter.ConvertO(bodyticketTypeId);
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

        [WorkflowExpressionFactory(nameof(__BuildNEWREGISTRATION))]
        public IWorkflowTrigger NEWREGISTRATION([WorkflowExpression] Func<string> platformId,[WorkflowExpression] Func<string> domainId,[WorkflowExpression] Func<string> appId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNEWREGISTRATION(WorkflowExpression<string> platformId,WorkflowExpression<string> domainId,WorkflowExpression<string> appId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(platformId, nameof(platformId), required: true);
            WorkflowExpression.Validate(domainId, nameof(domainId), required: true);
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/ticket_create.json", ExpressionConverter.ConvertWithUrlEncoding(platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
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

        [WorkflowExpressionFactory(nameof(__BuildNEWCHECKIN))]
        public IWorkflowTrigger NEWCHECKIN([WorkflowExpression] Func<string> platformId,[WorkflowExpression] Func<string> domainId,[WorkflowExpression] Func<string> appId,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildNEWCHECKIN(WorkflowExpression<string> platformId,WorkflowExpression<string> domainId,WorkflowExpression<string> appId,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(platformId, nameof(platformId), required: true);
            WorkflowExpression.Validate(domainId, nameof(domainId), required: true);
            WorkflowExpression.Validate(appId, nameof(appId), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/platforms/{0}/domains/{1}/organisations/{2}/hooks/checkin.json", ExpressionConverter.ConvertWithUrlEncoding(platformId, 1), ExpressionConverter.ConvertWithUrlEncoding(domainId, 1), ExpressionConverter.ConvertWithUrlEncoding(appId, 1));
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