//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Entraidpasswordreset
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntraidpasswordresetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entraidpasswordreset")]
        public IBodyWorkflowAction<PasswordListGetResponse, ApiConnectionActionConfiguration> PasswordListGet(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<PasswordListGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}/authentication/passwordMethods", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PasswordListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entraidpasswordreset")]
        public IBodyWorkflowAction<PasswordResetPostResponse, ApiConnectionActionConfiguration> PasswordReset(Expression<Func<string>> id, Expression<Func<string>> passwordId, Expression<Func<PasswordResetPostInput>> body = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_passwordId = WorkflowExpression.Compile(passwordId, nameof(passwordId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<PasswordResetPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1.0/users/{0}/authentication/methods/{1}/resetPassword", __workflow_id.WithUrlEncoding(1), __workflow_passwordId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<PasswordResetPostResponse>(callPayload);
            });
        }
    }

    public class EntraidpasswordresetTriggers([ConnectionName] string connectionId)
    {
    }

    public class PasswordListGetResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public PasswordListGetResponseValueTypeItem[] Value { get; set; }
    }

    public class PasswordListGetResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("createdDateTime")]
        public string CreatedDateTime { get; set; }
    }

    public class PasswordResetPostResponse
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }

    public class PasswordResetPostInput
    {
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Entraidpasswordreset;

    public partial class WorkflowManagedActions
    {
        public EntraidpasswordresetActions Entraidpasswordreset(string connectionId) => new EntraidpasswordresetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public EntraidpasswordresetTriggers Entraidpasswordreset(string connectionId) => new EntraidpasswordresetTriggers(connectionId);
    }
}