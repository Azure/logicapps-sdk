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
            var apiCallPath = "/api/CardTempletes/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReturnCardTempleteItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse, ApiConnectionActionConfiguration> SendInvitation(Expression<Func<string>> bodycardTemplateId, Expression<Func<string>> bodyjobtitle, Expression<Func<string>> bodyworkEmail, Expression<Func<string>> bodynameOnCard = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_bodycardTemplateId = WorkflowExpression.Compile(bodycardTemplateId, nameof(bodycardTemplateId), required: true);
            var __workflow_bodyjobtitle = WorkflowExpression.Compile(bodyjobtitle, nameof(bodyjobtitle), required: true);
            var __workflow_bodyworkEmail = WorkflowExpression.Compile(bodyworkEmail, nameof(bodyworkEmail), required: true);
            var __workflow_bodynameOnCard = WorkflowExpression.Compile(bodynameOnCard, nameof(bodynameOnCard), required: false);
            var __workflow_bodyextension = WorkflowExpression.Compile(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<ApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Invitation/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CardTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodycardTemplateId);
                if (__workflow_bodynameOnCard != null)
                {
                    body["NameOnCard"] = ExpressionConverter.ConvertO(__workflow_bodynameOnCard);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Jobtitle"] = ExpressionConverter.ConvertO(__workflow_bodyjobtitle);
                bodypropCount++;
                body["WorkEmail"] = ExpressionConverter.ConvertO(__workflow_bodyworkEmail);
                if (__workflow_bodyextension != null)
                {
                    body["Extension"] = ExpressionConverter.ConvertO(__workflow_bodyextension);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse, ApiConnectionActionConfiguration> DisassociateMember(Expression<Func<string>> contentType, Expression<Func<string>> bodyemail)
        {
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<ApiResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/Invitation/Disassociate";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ApiResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<AccountInvitationsItem[], ApiConnectionActionConfiguration> RetrieveAllInvitations()
        {
            var apiCallPath = "/api/Invitation/GetAccountInvitations/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountInvitationsItem[]>(callPayload);
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

    public class AccountInvitationsItem
    {
        public string Code { get; set; }
        public string Date { get; set; }
        public string ModifiedOn { get; set; }
        public string CardTemplateID { get; set; }
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
