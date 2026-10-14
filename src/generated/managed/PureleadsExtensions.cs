//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pureleads
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class PureleadsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pureleads")]
        public IWorkflowAction NewLeadSubmission(Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname, Expression<Func<string>> bodymobileNo = null, Expression<Func<string>> bodysecondaryEmail = null, Expression<Func<int>> bodylifecycleStageName = null)
        {
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodymobileNo = bodymobileNo == null ? null : WorkflowExpression.Compile(bodymobileNo);
            WorkflowExpression.Validate(__workflow_bodymobileNo, nameof(bodymobileNo), required: false);
            var __workflow_bodysecondaryEmail = bodysecondaryEmail == null ? null : WorkflowExpression.Compile(bodysecondaryEmail);
            WorkflowExpression.Validate(__workflow_bodysecondaryEmail, nameof(bodysecondaryEmail), required: false);
            var __workflow_bodylifecycleStageName = bodylifecycleStageName == null ? null : WorkflowExpression.Compile(bodylifecycleStageName);
            WorkflowExpression.Validate(__workflow_bodylifecycleStageName, nameof(bodylifecycleStageName), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IBodyWorkflowTrigger<CreatedLeadSubmissionResponse> CreatedLeadSubmission(FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CreatedLeadSubmissionResponse>(callPayload, recurrence: recurrence);
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
