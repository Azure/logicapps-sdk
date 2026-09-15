//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pureleads
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PureleadsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pureleads")]
        public IWorkflowAction NewLeadSubmission(Expression<Func<string>> bodyemail, Expression<Func<string>> bodyname, Expression<Func<string>> bodymobileNo = null, Expression<Func<string>> bodysecondaryEmail = null, Expression<Func<int>> bodylifecycleStageName = null)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = CSharpExpressionConverter.ConvertToken(bodyemail);
            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            if (bodymobileNo != null)
            {
                body["mobile_no"] = CSharpExpressionConverter.ConvertToken(bodymobileNo);
                bodypropCount++;
            }

            if (bodysecondaryEmail != null)
            {
                body["secondary_email"] = CSharpExpressionConverter.ConvertToken(bodysecondaryEmail);
                bodypropCount++;
            }

            if (bodylifecycleStageName != null)
            {
                if (bodylifecycleStageName != null)
                {
                    body["lifecycle_stage_name"] = CSharpExpressionConverter.ConvertToken(bodylifecycleStageName);
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
        }
    }

    public class PureleadsTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<CreatedLeadSubmissionResponse> CreatedLeadSubmission(string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/trigger/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionTrigger<CreatedLeadSubmissionResponse>(callPayload, triggerName, recurrence);
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