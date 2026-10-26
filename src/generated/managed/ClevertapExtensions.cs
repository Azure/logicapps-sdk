//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Clevertap
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ClevertapActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "clevertap")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UploadProfiles(Expression<Func<UploadProfilesInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/1/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class ClevertapTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadProfilesInput
    {
        [JsonProperty("d", DefaultValueHandling = DefaultValueHandling.Include)]
        public UploadProfilesInputDTypeItem[] D { get; set; }
    }

    public class UploadProfilesInputDTypeItem
    {
        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string RecordType { get; set; } = "profile";

        [JsonProperty("identity", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CleverTapIdentity { get; set; }

        [JsonProperty("$source", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string DataSource { get; set; } = "Dynamics_CRM";

        [JsonProperty("profileData", DefaultValueHandling = DefaultValueHandling.Include)]
        public UploadProfilesInputDTypeItemProfileDataType ProfileData { get; set; }
    }

    public class UploadProfilesInputDTypeItemProfileDataType
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