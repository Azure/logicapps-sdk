//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors._1mecorporate
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class _1mecorporateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ReturnCardTempleteItem[]> RetrieveCardTemplates()
        {
            var apiCallPath = "/api/CardTempletes/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ReturnCardTempleteItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse> SendInvitation(Expression<Func<string>> bodycardTemplateId, Expression<Func<string>> bodyjobtitle, Expression<Func<string>> bodyworkEmail, Expression<Func<string>> bodynameOnCard = null, Expression<Func<string>> bodyextension = null)
        {
            var __workflow_bodycardTemplateId = bodycardTemplateId == null ? null : WorkflowExpression.Compile(bodycardTemplateId);
            WorkflowExpression.Validate(__workflow_bodycardTemplateId, nameof(bodycardTemplateId), required: true);
            var __workflow_bodyjobtitle = bodyjobtitle == null ? null : WorkflowExpression.Compile(bodyjobtitle);
            WorkflowExpression.Validate(__workflow_bodyjobtitle, nameof(bodyjobtitle), required: true);
            var __workflow_bodyworkEmail = bodyworkEmail == null ? null : WorkflowExpression.Compile(bodyworkEmail);
            WorkflowExpression.Validate(__workflow_bodyworkEmail, nameof(bodyworkEmail), required: true);
            var __workflow_bodynameOnCard = bodynameOnCard == null ? null : WorkflowExpression.Compile(bodynameOnCard);
            WorkflowExpression.Validate(__workflow_bodynameOnCard, nameof(bodynameOnCard), required: false);
            var __workflow_bodyextension = bodyextension == null ? null : WorkflowExpression.Compile(bodyextension);
            WorkflowExpression.Validate(__workflow_bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<ApiResponse>(() =>
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
        public IBodyWorkflowAction<ApiResponse> DisassociateMember(Expression<Func<string>> contentType, Expression<Func<string>> bodyemail)
        {
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_bodyemail = bodyemail == null ? null : WorkflowExpression.Compile(bodyemail);
            WorkflowExpression.Validate(__workflow_bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<ApiResponse>(() =>
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
        public IBodyWorkflowAction<AccountInvitationsItem[]> RetrieveAllInvitations()
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
