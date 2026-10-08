//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pureleads
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PureleadsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pureleads")]
        [WorkflowExpressionFactory(nameof(__BuildNewLeadSubmission))]
        public IWorkflowAction NewLeadSubmission([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodymobileNo = null, [WorkflowExpression] Func<string> bodysecondaryEmail = null, [WorkflowExpression] Func<int> bodylifecycleStageName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildNewLeadSubmission(WorkflowExpression<string> bodyemail, WorkflowExpression<string> bodyname, WorkflowExpression<string> bodymobileNo = null, WorkflowExpression<string> bodysecondaryEmail = null, WorkflowExpression<int> bodylifecycleStageName = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodymobileNo, nameof(bodymobileNo), required: false);
            WorkflowExpression.Validate(bodysecondaryEmail, nameof(bodysecondaryEmail), required: false);
            WorkflowExpression.Validate(bodylifecycleStageName, nameof(bodylifecycleStageName), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/contacts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(bodyemail);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodymobileNo != null)
                {
                    body["mobile_no"] = ExpressionConverter.ConvertO(bodymobileNo);
                    bodypropCount++;
                }

                if (bodysecondaryEmail != null)
                {
                    body["secondary_email"] = ExpressionConverter.ConvertO(bodysecondaryEmail);
                    bodypropCount++;
                }

                if (bodylifecycleStageName != null)
                {
                    if (bodylifecycleStageName != null)
                    {
                        body["lifecycle_stage_name"] = ExpressionConverter.ConvertO(bodylifecycleStageName);
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