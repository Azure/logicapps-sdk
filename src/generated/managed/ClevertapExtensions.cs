//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClevertapActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clevertap")]
        [WorkflowExpressionFactory(nameof(__BuildUploadProfiles))]
        public IWorkflowAction UploadProfiles([WorkflowExpression] Func<bodydInputItem[]> bodyd)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadProfiles(WorkflowExpression<bodydInputItem[]> bodyd)
        {
            WorkflowExpression.Validate(bodyd, nameof(bodyd), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/1/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["d"] = ExpressionConverter.ConvertO(bodyd);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ClevertapTriggers([ConnectionName] string connectionId)
    {
    }

    public class bodydInputItem
    {
        [JsonProperty("type")]
        public string RecordType { get; set; }

        [JsonProperty("identity")]
        public string CleverTapIdentity { get; set; }

        [JsonProperty("$source")]
        public string DataSource { get; set; }

        [JsonProperty("profileData")]
        public bodydInputItemProfileDataType ProfileData { get; set; }
    }

    public class bodydInputItemProfileDataType
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        [JsonProperty("Name")]
        public string FullName { get; set; }

        [JsonProperty("First Name")]
        public string FirstName { get; set; }

        [JsonProperty("Last Name")]
        public string LastName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap;

    public partial class WorkflowManagedActions
    {
        public ClevertapActions Clevertap(string connectionId) => new ClevertapActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ClevertapTriggers Clevertap(string connectionId) => new ClevertapTriggers(connectionId);
    }
}