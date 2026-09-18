//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors._1mecorporate
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
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CardTempletes/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ReturnCardTempleteItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse> SendInvitation([WorkflowExpression] Func<string> bodycardTemplateId, [WorkflowExpression] Func<string> bodyjobtitle, [WorkflowExpression] Func<string> bodyworkEmail, [WorkflowExpression] Func<string> bodynameOnCard = null, [WorkflowExpression] Func<string> bodyextension = null)
        {
            SourceExpression.Validate(bodycardTemplateId, nameof(bodycardTemplateId), required: true);
            SourceExpression.Validate(bodyjobtitle, nameof(bodyjobtitle), required: true);
            SourceExpression.Validate(bodyworkEmail, nameof(bodyworkEmail), required: true);
            SourceExpression.Validate(bodynameOnCard, nameof(bodynameOnCard), required: false);
            SourceExpression.Validate(bodyextension, nameof(bodyextension), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Invitation/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["CardTemplateId"] = SourceExpressionConverter.ConvertToken(bodycardTemplateId);
                if (bodynameOnCard != null)
                {
                    body["NameOnCard"] = SourceExpressionConverter.ConvertToken(bodynameOnCard);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Jobtitle"] = SourceExpressionConverter.ConvertToken(bodyjobtitle);
                bodypropCount++;
                body["WorkEmail"] = SourceExpressionConverter.ConvertToken(bodyworkEmail);
                if (bodyextension != null)
                {
                    body["Extension"] = SourceExpressionConverter.ConvertToken(bodyextension);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<ApiResponse> DisassociateMember([WorkflowExpression] Func<string> contentType, [WorkflowExpression] Func<string> bodyemail)
        {
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Invitation/Disassociate";
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ApiResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "1mecorporate")]
        public IBodyWorkflowAction<AccountInvitationsItem[]> RetrieveAllInvitations()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Invitation/GetAccountInvitations/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountInvitationsItem[]>(BuildSourceInput);
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