//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk._1mecorporate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

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
        public IBodyWorkflowAction<ApiResponse> SendInvitation(Expression<Func<string>> bodyCardTemplateId, Expression<Func<string>> bodyJobtitle, Expression<Func<string>> bodyWorkEmail, Expression<Func<string>> bodyNameOnCard = null, Expression<Func<string>> bodyExtension = null)
        {
            var apiCallPath = "/api/Invitation/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["CardTemplateId"] = ExpressionConverter.ConvertO(bodyCardTemplateId);
            if (bodyNameOnCard != null)
            {
                body["NameOnCard"] = ExpressionConverter.ConvertO(bodyNameOnCard);
                bodypropCount++;
            }

            bodypropCount++;
            body["Jobtitle"] = ExpressionConverter.ConvertO(bodyJobtitle);
            bodypropCount++;
            body["WorkEmail"] = ExpressionConverter.ConvertO(bodyWorkEmail);
            if (bodyExtension != null)
            {
                body["Extension"] = ExpressionConverter.ConvertO(bodyExtension);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse> DisassociateMember(Expression<Func<string>> contentType, Expression<Func<string>> bodyEmail)
        {
            var apiCallPath = "/api/Invitation/Disassociate";
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ApiResponse>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk._1mecorporate;

    public partial class WorkflowManagedActions
    {
        public _1mecorporateActions _1mecorporate(string connectionId) => new _1mecorporateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public _1mecorporateTriggers _1mecorporate(string connectionId) => new _1mecorporateTriggers(connectionId);
    }
}