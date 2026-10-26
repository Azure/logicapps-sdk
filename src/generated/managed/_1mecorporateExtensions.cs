//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1mecorporate
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class _1mecorporateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ReturnCardTempleteItem[], ApiConnectionActionConfiguration> RetrieveCardTemplates()
        {
            return new DeferredBodyAction<ReturnCardTempleteItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/CardTempletes/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ReturnCardTempleteItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse, ApiConnectionActionConfiguration> SendInvitation(Expression<Func<SendInvitationInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Invitation/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse, ApiConnectionActionConfiguration> DisassociateMember(Expression<Func<string>> contentType, Expression<Func<DisassociateMemberInput>> body = null)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Invitation/Disassociate";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<AccountInvitationsItem[], ApiConnectionActionConfiguration> RetrieveAllInvitations()
        {
            return new DeferredBodyAction<AccountInvitationsItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Invitation/GetAccountInvitations/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AccountInvitationsItem[]>(callPayload);
            });
        }
    }

    public class _1mecorporateTriggers([ConnectionName] string connectionId)
    {
    }

    public class ReturnCardTempleteItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string CreatedOn { get; set; }
        public int CardsCount { get; set; }
    }

    public class ApiResponse
    {
        public string Data { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
    }

    public class SendInvitationInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string CardTemplateId { get; set; }
        public string NameOnCard { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Jobtitle { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string WorkEmail { get; set; }
        public string Extension { get; set; }
    }

    public class DisassociateMemberInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }
    }

    public class AccountInvitationsItem
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string ModifiedOn { get; set; }

        [JsonProperty("CardTemplateID")]
        public string CardTemplateId { get; set; }
        public string NameOnCard { get; set; }
        public string WorkEmail { get; set; }
        public string JobTitle { get; set; }
        public string Extention { get; set; }
        public string Status { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors._1mecorporate;

    public partial class WorkflowManagedActions
    {
        public _1mecorporateActions _1mecorporate(string connectionId) => new _1mecorporateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _1mecorporateTriggers _1mecorporate(string connectionId) => new _1mecorporateTriggers(connectionId);
    }
}