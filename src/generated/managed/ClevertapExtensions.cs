//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClevertapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clevertap")]
        public IWorkflowAction UploadProfiles([WorkflowExpression] Func<bodydInputItem[]> bodyd)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/1/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["d"] = SourceExpressionConverter.ConvertToken(bodyd);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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