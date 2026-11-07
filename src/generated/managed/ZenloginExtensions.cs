//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Zenlogin
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ZenloginActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "zenlogin")]
        public IBodyWorkflowAction<LoginResponse, ApiConnectionActionConfiguration> Login(Expression<Func<string>> appId, Expression<Func<BodyInput>> body = null)
        {
            var __workflow_appId = WorkflowExpression.Compile(appId, nameof(appId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<LoginResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/applications/{0}/logins/checks", __workflow_appId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LoginResponse>(callPayload);
            });
        }
    }

    public class ZenloginTriggers([ConnectionName] string connectionId)
    {
    }

    public class LoginResponse
    {
        [JsonProperty("data")]
        public LoginResponseDataType Data { get; set; }

        [JsonProperty("errors")]
        public LoginResponseErrorsTypeItem[] Errors { get; set; }
    }

    public class LoginResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }
    }

    public class LoginResponseErrorsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("detail")]
        public string Detail { get; set; }
    }

    public class BodyInput
    {
        [JsonProperty("identity_key", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IdentityKey { get; set; }

        [JsonProperty("identity_email_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IdentityEmailAddress { get; set; }

        [JsonProperty("user_agent", DefaultValueHandling = DefaultValueHandling.Include)]
        public string UserAgent { get; set; }

        [JsonProperty("ip_address", DefaultValueHandling = DefaultValueHandling.Include)]
        public string IpAddress { get; set; }

        [JsonProperty("identity_first_name")]
        public string IdentityFirstName { get; set; }

        [JsonProperty("identity_last_name")]
        public string IdentityLastName { get; set; }

        [JsonProperty("identity_full_name")]
        public string IdentityFullName { get; set; }

        [JsonProperty("req_process", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputReqProcessType? ReqProcess { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Zenlogin.BodyInputReqProcessType._1;
    }

    public enum BodyInputReqProcessType
    {
        _0 = 0,
        _1 = 1
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Zenlogin;

    public partial class WorkflowManagedActions
    {
        public ZenloginActions Zenlogin(string connectionId) => new ZenloginActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ZenloginTriggers Zenlogin(string connectionId) => new ZenloginTriggers(connectionId);
    }
}