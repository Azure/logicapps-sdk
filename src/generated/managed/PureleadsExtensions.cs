//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pureleads
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PureleadsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pureleads")]
        public IWorkflowAction<ApiConnectionActionConfiguration> NewLeadSubmission(Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname, Expression<Func<string>> bodymobileNo = null, Expression<Func<string>> bodysecondaryEmail = null, Expression<Func<int>> bodylifecycleStageName = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodymobileNo = WorkflowExpression.Compile(bodymobileNo, nameof(bodymobileNo), required: false);
            var __workflow_bodysecondaryEmail = WorkflowExpression.Compile(bodysecondaryEmail, nameof(bodysecondaryEmail), required: false);
            var __workflow_bodylifecycleStageName = WorkflowExpression.Compile(bodylifecycleStageName, nameof(bodylifecycleStageName), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodymobileNo != null)
                {
                    body["mobile_no"] = ExpressionConverter.ConvertO(__workflow_bodymobileNo);
                    bodypropCount++;
                }

                if (__workflow_bodysecondaryEmail != null)
                {
                    body["secondary_email"] = ExpressionConverter.ConvertO(__workflow_bodysecondaryEmail);
                    bodypropCount++;
                }

                if (__workflow_bodylifecycleStageName != null)
                {
                    if (__workflow_bodylifecycleStageName != null)
                    {
                        body["lifecycle_stage_name"] = ExpressionConverter.ConvertO(__workflow_bodylifecycleStageName);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["lifecycle_stage_name"] = 1;
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

    public class PureleadsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreatedLeadSubmissionResponse, ApiConnectionTriggerConfiguration> CreatedLeadSubmission(FlowRecurrence recurrence = null)
        {
            return new DeferredBodyTrigger<CreatedLeadSubmissionResponse, ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/trigger/contacts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionTrigger<CreatedLeadSubmissionResponse>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class CreatedLeadSubmissionResponse
    {
        [JsonProperty("value")]
        public CreatedLeadSubmissionResponseValueTypeItem[] Value { get; set; }
    }

    public class CreatedLeadSubmissionResponseValueTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        [JsonProperty("secondary_email")]
        public string SecondaryEmail { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("lifecycle_stage_name")]
        public string LifecycleStageName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pureleads;

    public partial class WorkflowManagedActions
    {
        public PureleadsActions Pureleads(string connectionId) => new PureleadsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PureleadsTriggers Pureleads(string connectionId) => new PureleadsTriggers(connectionId);
    }
}