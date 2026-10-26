//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Badgrip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BadgripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerGetResponse, ApiConnectionActionConfiguration> IssuerGet()
        {
            return new DeferredBodyAction<IssuerGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/issuers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IssuerGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerCreateResponse, ApiConnectionActionConfiguration> IssuerCreate(Expression<Func<IssuerCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IssuerCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/issuers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IssuerCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerGetAResponse, ApiConnectionActionConfiguration> IssuerGetA(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<IssuerGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IssuerGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> IssuerDelete(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<IssuerUpdateResponse, ApiConnectionActionConfiguration> IssuerUpdate(Expression<Func<string>> entityId, Expression<Func<IssuerUpdateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<IssuerUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<IssuerUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionGetResponse, ApiConnectionActionConfiguration> AssertionGet(Expression<Func<string>> entityId, Expression<Func<string>> recipient = null, Expression<Func<string>> num = null, Expression<Func<bool>> includeExpired = null, Expression<Func<bool>> includeRevoked = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: false);
            var __workflow_includeExpired = WorkflowExpression.Compile(includeExpired, nameof(includeExpired), required: false);
            var __workflow_includeRevoked = WorkflowExpression.Compile(includeRevoked, nameof(includeRevoked), required: false);
            return new DeferredBodyAction<AssertionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}/assertions", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                if (__workflow_num != null)
                    callPayload.Queries["num"] = ExpressionConverter.Convert(__workflow_num);
                if (__workflow_includeExpired != null)
                    callPayload.Queries["include_expired"] = ExpressionConverter.Convert(__workflow_includeExpired);
                if (__workflow_includeRevoked != null)
                    callPayload.Queries["include_revoked"] = ExpressionConverter.Convert(__workflow_includeRevoked);
                return new ApiConnectionAction<AssertionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionIssueResponse, ApiConnectionActionConfiguration> AssertionIssue(Expression<Func<string>> entityId, Expression<Func<AssertionIssueInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AssertionIssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}/assertions", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AssertionIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetIssuerResponse, ApiConnectionActionConfiguration> ClassGetIssuer(Expression<Func<string>> entityId, Expression<Func<string>> num = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: false);
            return new DeferredBodyAction<ClassGetIssuerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}/badgeclasses", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_num != null)
                    callPayload.Queries["num"] = ExpressionConverter.Convert(__workflow_num);
                return new ApiConnectionAction<ClassGetIssuerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassCreateIssuerResponse, ApiConnectionActionConfiguration> ClassCreateIssuer(Expression<Func<string>> entityId, Expression<Func<ClassCreateIssuerInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassCreateIssuerResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issuers/{0}/badgeclasses", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassCreateIssuerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetUserResponse, ApiConnectionActionConfiguration> ClassGetUser()
        {
            return new DeferredBodyAction<ClassGetUserResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/badgeclasses";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClassGetUserResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassCreateResponse, ApiConnectionActionConfiguration> ClassCreate(Expression<Func<int>> num = null, Expression<Func<ClassCreateInput>> body = null)
        {
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/badgeclasses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_num != null)
                    callPayload.Queries["num"] = ExpressionConverter.Convert(__workflow_num);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetResponse, ApiConnectionActionConfiguration> ClassGet(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<ClassGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ClassGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ClassDelete(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassUpdateResponse, ApiConnectionActionConfiguration> ClassUpdate(Expression<Func<string>> entityId, Expression<Func<ClassUpdateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassGetAssertionResponse, ApiConnectionActionConfiguration> ClassGetAssertion(Expression<Func<string>> entityId, Expression<Func<string>> recipient = null, Expression<Func<string>> num = null, Expression<Func<bool>> includeExpired = null, Expression<Func<bool>> includeRevoked = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_num = WorkflowExpression.Compile(num, nameof(num), required: false);
            var __workflow_includeExpired = WorkflowExpression.Compile(includeExpired, nameof(includeExpired), required: false);
            var __workflow_includeRevoked = WorkflowExpression.Compile(includeRevoked, nameof(includeRevoked), required: false);
            return new DeferredBodyAction<ClassGetAssertionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}/assertions", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                if (__workflow_num != null)
                    callPayload.Queries["num"] = ExpressionConverter.Convert(__workflow_num);
                if (__workflow_includeExpired != null)
                    callPayload.Queries["include_expired"] = ExpressionConverter.Convert(__workflow_includeExpired);
                if (__workflow_includeRevoked != null)
                    callPayload.Queries["include_revoked"] = ExpressionConverter.Convert(__workflow_includeRevoked);
                return new ApiConnectionAction<ClassGetAssertionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassIssueAssertionResponse, ApiConnectionActionConfiguration> ClassIssueAssertion(Expression<Func<string>> entityId, Expression<Func<ClassIssueAssertionInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassIssueAssertionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}/assertions", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassIssueAssertionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionGetAResponse, ApiConnectionActionConfiguration> AssertionGetA(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<AssertionGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AssertionGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AssertionRevoke(Expression<Func<string>> entityId, Expression<Func<AssertionRevokeInput>> body)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionUpdateResponse, ApiConnectionActionConfiguration> AssertionUpdate(Expression<Func<string>> entityId, Expression<Func<AssertionUpdateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AssertionUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AssertionUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<TokenGetResponse, ApiConnectionActionConfiguration> TokenGet()
        {
            return new DeferredBodyAction<TokenGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/auth/tokens";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TokenGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<TokenGetAResponse, ApiConnectionActionConfiguration> TokenGetA(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<TokenGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/auth/tokens/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TokenGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TokenRevoke(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/auth/tokens/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserGetProfileResponse, ApiConnectionActionConfiguration> UserGetProfile(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<UserGetProfileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/users/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UserGetProfileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserCreateResponse, ApiConnectionActionConfiguration> UserCreate(Expression<Func<string>> entityId, Expression<Func<UserCreateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/users/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<UserUpdateResponse, ApiConnectionActionConfiguration> UserUpdate(Expression<Func<string>> entityId, Expression<Func<UserUpdateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UserUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/users/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UserUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackGetAssertionResponse, ApiConnectionActionConfiguration> BackpackGetAssertion()
        {
            return new DeferredBodyAction<BackpackGetAssertionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/backpack/assertions";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BackpackGetAssertionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackUploadAssertionResponse, ApiConnectionActionConfiguration> BackpackUploadAssertion(Expression<Func<BackpackUploadAssertionInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BackpackUploadAssertionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/backpack/assertions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BackpackUploadAssertionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackGetAssertionDetailsResponse, ApiConnectionActionConfiguration> BackpackGetAssertionDetails(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<BackpackGetAssertionDetailsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BackpackGetAssertionDetailsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BackpackRemoteAssertion(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<BackpackUpdateAcceptanceResponse, ApiConnectionActionConfiguration> BackpackUpdateAcceptance(Expression<Func<string>> entityId, Expression<Func<BackpackUpdateAcceptanceInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<BackpackUpdateAcceptanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/assertions/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<BackpackUpdateAcceptanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionGetResponse, ApiConnectionActionConfiguration> CollectionGet()
        {
            return new DeferredBodyAction<CollectionGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/backpack/collections";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CollectionGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionCreateResponse, ApiConnectionActionConfiguration> CollectionCreate(Expression<Func<CollectionCreateInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CollectionCreateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/backpack/collections";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CollectionCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionGetAResponse, ApiConnectionActionConfiguration> CollectionGetA(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredBodyAction<CollectionGetAResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/collections/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CollectionGetAResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CollectionDelete(Expression<Func<string>> entityId)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/collections/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<CollectionUpdateResponse, ApiConnectionActionConfiguration> CollectionUpdate(Expression<Func<string>> entityId, Expression<Func<CollectionUpdateInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CollectionUpdateResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/backpack/collections/{0}", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CollectionUpdateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<ClassIssueBulkResponse, ApiConnectionActionConfiguration> ClassIssueBulk(Expression<Func<string>> entityId, Expression<Func<ClassIssueBulkInput>> body = null)
        {
            var __workflow_entityId = WorkflowExpression.Compile(entityId, nameof(entityId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ClassIssueBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/badgeclasses/{0}/issue", __workflow_entityId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ClassIssueBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AssertionRevokeBulkResponse, ApiConnectionActionConfiguration> AssertionRevokeBulk(Expression<Func<AssertionRevokeBulkInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<AssertionRevokeBulkResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/assertions/revoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AssertionRevokeBulkResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> TokenRetrieve(Expression<Func<object>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/tokens/issuers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AccountRequestRecovery(Expression<Func<AccountRequestRecoveryInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/auth/forgot-password";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IBodyWorkflowAction<AccountRecoverResponse, ApiConnectionActionConfiguration> AccountRecover(Expression<Func<AccountRecoverInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AccountRecoverResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/auth/forgot-password";
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AccountRecoverResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "badgrip")]
        public IWorkflowAction<ApiConnectionActionConfiguration> BackpackImportAssertion(Expression<Func<BackpackImportAssertionInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/backpack/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BadgripTriggers([ConnectionName] string connectionId)
    {
    }

    public class IssuerGetResponse
    {
        [JsonProperty("status")]
        public IssuerGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerGetResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerGetResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public IssuerGetResponseResultTypeItemStaffTypeItemUserProfileType UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItemUserProfileType
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public IssuerGetResponseResultTypeItemStaffTypeItemUserProfileTypeEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string[] Url { get; set; }

        [JsonProperty("telephone")]
        public string[] Telephone { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetResponseResultTypeItemStaffTypeItemUserProfileTypeEmailsTypeItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string[] CaseVariants { get; set; }
    }

    public class IssuerCreateResponse
    {
        [JsonProperty("status")]
        public IssuerCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerCreateResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerCreateResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerCreateInput
    {
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerCreateInputStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerCreateInputStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerGetAResponse
    {
        [JsonProperty("status")]
        public IssuerGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerGetAResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerGetAResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerUpdateResponse
    {
        [JsonProperty("status")]
        public IssuerUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public IssuerUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class IssuerUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class IssuerUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerUpdateResponseResultTypeItemStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerUpdateResponseResultTypeItemStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class IssuerUpdateInput
    {
        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("staff")]
        public IssuerUpdateInputStaffTypeItem[] Staff { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }
    }

    public class IssuerUpdateInputStaffTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("userProfile")]
        public string UserProfile { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }

    public class AssertionGetResponse
    {
        [JsonProperty("status")]
        public AssertionGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionGetResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionGetResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionGetResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionGetResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionGetResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionIssueResponse
    {
        [JsonProperty("status")]
        public AssertionIssueResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionIssueResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionIssueResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionIssueResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionIssueResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionIssueResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionIssueResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionIssueResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionIssueInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public AssertionIssueInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionIssueInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionIssueInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionIssueInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassGetIssuerResponse
    {
        [JsonProperty("status")]
        public ClassGetIssuerResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetIssuerResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetIssuerResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetIssuerResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetIssuerResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetIssuerResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateIssuerResponse
    {
        [JsonProperty("status")]
        public ClassCreateIssuerResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassCreateIssuerResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassCreateIssuerResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateIssuerResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateIssuerResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateIssuerResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateIssuerInput
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateIssuerInputAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateIssuerInputExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateIssuerInputAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateIssuerInputExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassGetUserResponse
    {
        [JsonProperty("status")]
        public ClassGetUserResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetUserResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetUserResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetUserResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetUserResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetUserResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetUserResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetUserResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateResponse
    {
        [JsonProperty("status")]
        public ClassCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassCreateInput
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassCreateInputAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassCreateInputExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassCreateInputAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassCreateInputExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassGetResponse
    {
        [JsonProperty("status")]
        public ClassGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassGetResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassGetResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassGetResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassGetResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassUpdateResponse
    {
        [JsonProperty("status")]
        public ClassUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassUpdateResponseResultTypeItemAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassUpdateResponseResultTypeItemExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassUpdateResponseResultTypeItemAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassUpdateResponseResultTypeItemExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassUpdateInput
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("achievementType")]
        public string AchievementType { get; set; }

        [JsonProperty("criteriaUrl")]
        public string CriteriaUrl { get; set; }

        [JsonProperty("criteriaNarrative")]
        public string CriteriaNarrative { get; set; }

        [JsonProperty("alignments")]
        public ClassUpdateInputAlignmentsTypeItem[] Alignments { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("expires")]
        public ClassUpdateInputExpiresType Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }
    }

    public class ClassUpdateInputAlignmentsTypeItem
    {
        [JsonProperty("targetName")]
        public string TargetName { get; set; }

        [JsonProperty("targetUrl")]
        public string TargetUrl { get; set; }

        [JsonProperty("targetDescription")]
        public string TargetDescription { get; set; }

        [JsonProperty("targetFramework")]
        public string TargetFramework { get; set; }

        [JsonProperty("targetCode")]
        public string TargetCode { get; set; }
    }

    public class ClassUpdateInputExpiresType
    {
        [JsonProperty("amount")]
        public string Amount { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }
    }

    public class ClassGetAssertionResponse
    {
        [JsonProperty("status")]
        public ClassGetAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassGetAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassGetAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassGetAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassGetAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassGetAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueAssertionResponse
    {
        [JsonProperty("status")]
        public ClassIssueAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassIssueAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassIssueAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueAssertionInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueAssertionInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueAssertionInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueAssertionInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueAssertionInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionGetAResponse
    {
        [JsonProperty("status")]
        public AssertionGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionGetAResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionGetAResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionGetAResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionGetAResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionRevokeInput
    {
        [JsonProperty("revocation_reason")]
        public string RevocationReason { get; set; }
    }

    public class AssertionUpdateResponse
    {
        [JsonProperty("status")]
        public AssertionUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionUpdateResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionUpdateResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionUpdateResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionUpdateInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public AssertionUpdateInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionUpdateInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionUpdateInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionUpdateInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class TokenGetResponse
    {
        [JsonProperty("status")]
        public TokenGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken[] Result { get; set; }
    }

    public class TokenGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class TokenGetAResponse
    {
        [JsonProperty("status")]
        public TokenGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class TokenGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserGetProfileResponse
    {
        [JsonProperty("status")]
        public UserGetProfileResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserGetProfileResponseResultTypeItem[] Result { get; set; }
    }

    public class UserGetProfileResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserGetProfileResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserGetProfileResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserGetProfileResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserCreateResponse
    {
        [JsonProperty("status")]
        public UserCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class UserCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserCreateResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserCreateResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserCreateInput
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserCreateInputEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserCreateInputEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserUpdateResponse
    {
        [JsonProperty("status")]
        public UserUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public UserUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class UserUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class UserUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserUpdateResponseResultTypeItemEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserUpdateResponseResultTypeItemEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class UserUpdateInput
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("emails")]
        public UserUpdateInputEmailsTypeItem[] Emails { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("agreedTermsVersion")]
        public string AgreedTermsVersion { get; set; }

        [JsonProperty("hasAgreedToLatestTermsVersion")]
        public string HasAgreedToLatestTermsVersion { get; set; }

        [JsonProperty("marketingOptIn")]
        public string MarketingOptIn { get; set; }

        [JsonProperty("badgrDomain")]
        public string BadgrDomain { get; set; }

        [JsonProperty("hasPasswordSet")]
        public string HasPasswordSet { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }
    }

    public class UserUpdateInputEmailsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }

        [JsonProperty("primary")]
        public bool? Primary { get; set; }

        [JsonProperty("caseVariants")]
        public string CaseVariants { get; set; }
    }

    public class BackpackGetAssertionResponse
    {
        [JsonProperty("status")]
        public BackpackGetAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackGetAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackGetAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackGetAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackGetAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class BackpackGetAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUploadAssertionResponse
    {
        [JsonProperty("status")]
        public BackpackUploadAssertionResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackUploadAssertionResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackUploadAssertionResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackUploadAssertionResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUploadAssertionResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class BackpackUploadAssertionResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUploadAssertionInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public BackpackUploadAssertionInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUploadAssertionInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class BackpackUploadAssertionInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class BackpackUploadAssertionInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackGetAssertionDetailsResponse
    {
        [JsonProperty("status")]
        public BackpackGetAssertionDetailsResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackGetAssertionDetailsResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackGetAssertionDetailsResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackGetAssertionDetailsResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("pending")]
        public string Pending { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }
    }

    public class BackpackGetAssertionDetailsResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUpdateAcceptanceResponse
    {
        [JsonProperty("status")]
        public BackpackUpdateAcceptanceResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public BackpackUpdateAcceptanceResponseResultTypeItem[] Result { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public BackpackUpdateAcceptanceResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUpdateAcceptanceResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("pending")]
        public string Pending { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }
    }

    public class BackpackUpdateAcceptanceResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class BackpackUpdateAcceptanceInput
    {
        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public BackpackUpdateAcceptanceInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public BackpackUpdateAcceptanceInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("pending")]
        public string Pending { get; set; }
    }

    public class BackpackUpdateAcceptanceInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }
    }

    public class BackpackUpdateAcceptanceInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionGetResponse
    {
        [JsonProperty("status")]
        public CollectionGetResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionGetResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionGetResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionGetResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionGetResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionGetResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionCreateResponse
    {
        [JsonProperty("status")]
        public CollectionCreateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionCreateResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionCreateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionCreateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionCreateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionCreateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionCreateInput
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool? Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionCreateInputAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionCreateInputAssertionsTypeItem
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public CollectionCreateInputAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionCreateInputAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionCreateInputAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionCreateInputAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionGetAResponse
    {
        [JsonProperty("status")]
        public CollectionGetAResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionGetAResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionGetAResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionGetAResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionGetAResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionGetAResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionUpdateResponse
    {
        [JsonProperty("status")]
        public CollectionUpdateResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public CollectionUpdateResponseResultTypeItem[] Result { get; set; }
    }

    public class CollectionUpdateResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionUpdateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionUpdateResponseResultTypeItemAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class CollectionUpdateInput
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("share_url")]
        public string ShareUrl { get; set; }

        [JsonProperty("shareHash")]
        public string ShareHash { get; set; }

        [JsonProperty("published")]
        public bool? Published { get; set; }

        [JsonProperty("assertions")]
        public CollectionUpdateInputAssertionsTypeItem[] Assertions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class CollectionUpdateInputAssertionsTypeItem
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public CollectionUpdateInputAssertionsTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public CollectionUpdateInputAssertionsTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class CollectionUpdateInputAssertionsTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class CollectionUpdateInputAssertionsTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueBulkResponse
    {
        [JsonProperty("status")]
        public ClassIssueBulkResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public ClassIssueBulkResponseResultTypeItem[] Result { get; set; }
    }

    public class ClassIssueBulkResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueBulkResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueBulkResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueBulkResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class ClassIssueBulkInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public ClassIssueBulkInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public ClassIssueBulkInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class ClassIssueBulkInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class ClassIssueBulkInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionRevokeBulkResponse
    {
        [JsonProperty("status")]
        public AssertionRevokeBulkResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public AssertionRevokeBulkResponseResultTypeItem[] Result { get; set; }
    }

    public class AssertionRevokeBulkResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItem
    {
        [JsonProperty("entityType")]
        public string EntityType { get; set; }

        [JsonProperty("entityId")]
        public string EntityId { get; set; }

        [JsonProperty("openBadgeId")]
        public string OpenBadgeId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("recipient")]
        public AssertionRevokeBulkResponseResultTypeItemRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionRevokeBulkResponseResultTypeItemEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("revoked")]
        public bool Revoked { get; set; }

        [JsonProperty("revocationReason")]
        public string RevocationReason { get; set; }

        [JsonProperty("acceptance")]
        public string Acceptance { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItemRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionRevokeBulkResponseResultTypeItemEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AssertionRevokeBulkInput
    {
        [JsonProperty("badgeclass")]
        public string Badgeclass { get; set; }

        [JsonProperty("badgeclassOpenBadgeId")]
        public string BadgeclassOpenBadgeId { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("issuerOpenBadgeId")]
        public string IssuerOpenBadgeId { get; set; }

        [JsonProperty("recipient")]
        public AssertionRevokeBulkInputRecipientType Recipient { get; set; }

        [JsonProperty("issuedOn")]
        public string IssuedOn { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }

        [JsonProperty("evidence")]
        public AssertionRevokeBulkInputEvidenceTypeItem[] Evidence { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("extensions")]
        public string Extensions { get; set; }

        [JsonProperty("badgeclassName")]
        public string BadgeclassName { get; set; }
    }

    public class AssertionRevokeBulkInputRecipientType
    {
        [JsonProperty("identity")]
        public string Identity { get; set; }

        [JsonProperty("hashed")]
        public bool? Hashed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("plaintextIdentity")]
        public string PlaintextIdentity { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
    }

    public class AssertionRevokeBulkInputEvidenceTypeItem
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("narrative")]
        public string Narrative { get; set; }
    }

    public class AccountRequestRecoveryInput
    {
        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AccountRecoverResponse
    {
        [JsonProperty("status")]
        public AccountRecoverResponseStatusType Status { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class AccountRecoverResponseStatusType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class AccountRecoverInput
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }

    public class BackpackImportAssertionInput
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("assertion")]
        public JToken Assertion { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Badgrip;

    public partial class WorkflowManagedActions
    {
        public BadgripActions Badgrip(string connectionId) => new BadgripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BadgripTriggers Badgrip(string connectionId) => new BadgripTriggers(connectionId);
    }
}