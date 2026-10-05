//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1mecorporate
{
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
        [WorkflowExpressionFactory(nameof(__BuildSendInvitation))]
        public IBodyWorkflowAction<ApiResponse> SendInvitation([WorkflowExpression] Func<string> bodycardTemplateId, [WorkflowExpression] Func<string> bodyjobtitle, [WorkflowExpression] Func<string> bodyworkEmail, [WorkflowExpression] Func<string> bodynameOnCard = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiResponse> __BuildSendInvitation(WorkflowValue<string> bodycardTemplateId, WorkflowValue<string> bodyjobtitle, WorkflowValue<string> bodyworkEmail, WorkflowValue<string> bodynameOnCard = null, WorkflowValue<string> bodyextension = null)
        {
            WorkflowValue.Validate(bodycardTemplateId, nameof(bodycardTemplateId), required: true);
            WorkflowValue.Validate(bodyjobtitle, nameof(bodyjobtitle), required: true);
            WorkflowValue.Validate(bodyworkEmail, nameof(bodyworkEmail), required: true);
            WorkflowValue.Validate(bodynameOnCard, nameof(bodynameOnCard), required: false);
            WorkflowValue.Validate(bodyextension, nameof(bodyextension), required: false);
            return new DeferredBodyAction<ApiResponse>(() =>
            {
                var apiCallPath = "/api/Invitation/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CardTemplateId"] = ExpressionConverter.ConvertO(bodycardTemplateId);
                if (bodynameOnCard != null)
                {
                    body["NameOnCard"] = ExpressionConverter.ConvertO(bodynameOnCard);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Jobtitle"] = ExpressionConverter.ConvertO(bodyjobtitle);
                bodypropCount++;
                body["WorkEmail"] = ExpressionConverter.ConvertO(bodyworkEmail);
                if (bodyextension != null)
                {
                    body["Extension"] = ExpressionConverter.ConvertO(bodyextension);
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
        [WorkflowExpressionFactory(nameof(__BuildDisassociateMember))]
        public IBodyWorkflowAction<ApiResponse> DisassociateMember([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyemail)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ApiResponse> __BuildDisassociateMember(WorkflowValue<string> contentType, WorkflowValue<string> bodyemail)
        {
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(bodyemail, nameof(bodyemail), required: true);
            return new DeferredBodyAction<ApiResponse>(() =>
            {
                var apiCallPath = "/api/Invitation/Disassociate";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(bodyemail);
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
