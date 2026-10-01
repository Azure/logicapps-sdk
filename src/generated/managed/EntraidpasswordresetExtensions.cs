//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Entraidpasswordreset
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class EntraidpasswordresetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entraidpasswordreset")]
        public IBodyWorkflowAction<PasswordListGetResponse> PasswordListGet([WorkflowExpression] Func<string> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}/authentication/passwordMethods", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PasswordListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "entraidpasswordreset")]
        public IBodyWorkflowAction<PasswordResetPostResponse> PasswordReset([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> passwordId, [WorkflowExpression] Func<string> bodynewPassword = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1.0/users/{0}/authentication/methods/{1}/resetPassword", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(passwordId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodynewPassword != null)
                {
                    body["newPassword"] = SourceExpressionConverter.ConvertToken(bodynewPassword);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<PasswordResetPostResponse>(BuildSourceInput);
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