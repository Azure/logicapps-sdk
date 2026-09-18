//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BoldsignActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<SendDocumentFromTemplateResponse> SendDocumentFromTemplate([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<bool> isSandbox, [WorkflowExpression] Func<string> title, [WorkflowExpression] Func<string> message = null, [WorkflowExpression] Func<string> cc = null, [WorkflowExpression] Func<string> brandId = null, [WorkflowExpression] Func<string> onBehalfOf = null, [WorkflowExpression] Func<int> expiryDays = null, [WorkflowExpression] Func<string> labels = null, [WorkflowExpression] Func<bool> hideDocumentId = null, [WorkflowExpression] Func<bool> enablePrintAndSign = null, [WorkflowExpression] Func<bool> enableReassign = null, [WorkflowExpression] Func<bool> enableAutoReminder = null, [WorkflowExpression] Func<object> signers = null)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(isSandbox, nameof(isSandbox), required: true);
            SourceExpression.Validate(title, nameof(title), required: true);
            SourceExpression.Validate(message, nameof(message), required: false);
            SourceExpression.Validate(cc, nameof(cc), required: false);
            SourceExpression.Validate(brandId, nameof(brandId), required: false);
            SourceExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            SourceExpression.Validate(expiryDays, nameof(expiryDays), required: false);
            SourceExpression.Validate(labels, nameof(labels), required: false);
            SourceExpression.Validate(hideDocumentId, nameof(hideDocumentId), required: false);
            SourceExpression.Validate(enablePrintAndSign, nameof(enablePrintAndSign), required: false);
            SourceExpression.Validate(enableReassign, nameof(enableReassign), required: false);
            SourceExpression.Validate(enableAutoReminder, nameof(enableAutoReminder), required: false);
            SourceExpression.Validate(signers, nameof(signers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/template/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["templateId"] = SourceExpressionConverter.ConvertO(templateId);
                callPayload.Queries["isSandbox"] = SourceExpressionConverter.ConvertO(isSandbox);
                callPayload.Queries["title"] = SourceExpressionConverter.ConvertO(title);
                if (message != null)
                    callPayload.Queries["message"] = SourceExpressionConverter.ConvertO(message);
                if (cc != null)
                    callPayload.Queries["cc"] = SourceExpressionConverter.ConvertO(cc);
                if (brandId != null)
                    callPayload.Queries["brandId"] = SourceExpressionConverter.ConvertO(brandId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = SourceExpressionConverter.ConvertO(onBehalfOf);
                callPayload.Queries["expiryDays"] = Convert.ToString(60);
                if (expiryDays != null)
                    callPayload.Queries["expiryDays"] = SourceExpressionConverter.ConvertO(expiryDays);
                if (labels != null)
                    callPayload.Queries["labels"] = SourceExpressionConverter.ConvertO(labels);
                if (hideDocumentId != null)
                    callPayload.Queries["hideDocumentId"] = SourceExpressionConverter.ConvertO(hideDocumentId);
                callPayload.Queries["enablePrintAndSign"] = Convert.ToString(false);
                if (enablePrintAndSign != null)
                    callPayload.Queries["enablePrintAndSign"] = SourceExpressionConverter.ConvertO(enablePrintAndSign);
                callPayload.Queries["enableReassign"] = Convert.ToString(true);
                if (enableReassign != null)
                    callPayload.Queries["enableReassign"] = SourceExpressionConverter.ConvertO(enableReassign);
                callPayload.Queries["enableAutoReminder"] = Convert.ToString(false);
                if (enableAutoReminder != null)
                    callPayload.Queries["enableAutoReminder"] = SourceExpressionConverter.ConvertO(enableAutoReminder);
                callPayload.Body = SourceExpressionConverter.ConvertToken(signers);
                return callPayload;
            }

            return new ApiConnectionAction<SendDocumentFromTemplateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction DownloadDocument([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> onBehalfOf = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/document/download";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = SourceExpressionConverter.ConvertO(documentId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = SourceExpressionConverter.ConvertO(onBehalfOf);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IWorkflowAction DownloadAuditTrail([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> onBehalfOf = null)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(onBehalfOf, nameof(onBehalfOf), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/document/downloadAuditLog";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = SourceExpressionConverter.ConvertO(documentId);
                if (onBehalfOf != null)
                    callPayload.Queries["onBehalfOf"] = SourceExpressionConverter.ConvertO(onBehalfOf);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "boldsign")]
        public IBodyWorkflowAction<DocumentPropertiesResponse> GetDocumentStatus([WorkflowExpression] Func<string> documentId)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/document/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["documentId"] = SourceExpressionConverter.ConvertO(documentId);
                return callPayload;
            }

            return new ApiConnectionAction<DocumentPropertiesResponse>(BuildSourceInput);
        }
    }

    public class BoldsignTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<AddWebHooksResponse> WebHooks([WorkflowExpression] Func<eventsInput> events, [WorkflowExpression] Func<bool> bodyadminMode, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(events, nameof(events), required: true);
            SourceExpression.Validate(bodyadminMode, nameof(bodyadminMode), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/WebHooks/AddWebHooksAPIForPowerAutomate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["events"] = SourceExpressionConverter.Convert(events);
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Webhook";
                bodypropCount++;
                body["events"] = "Sent";
                bodypropCount++;
                body["url"] = "@listCallbackUrl()";
                bodypropCount++;
                body["environment"] = "Live";
                bodypropCount++;
                body["isActive"] = true;
                bodypropCount++;
                body["webhookType"] = "AccountCallback";
                bodypropCount++;
                bodypropCount++;
                body["adminMode"] = SourceExpressionConverter.ConvertToken(bodyadminMode);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger<AddWebHooksResponse>(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class SendDocumentFromTemplateResponse
    {
        [JsonProperty("documentId")]
        public string DocumentId { get; set; }
    }

    public class DocumentPropertiesResponse
    {
        [JsonProperty("status")]
        public string DocumentStatus { get; set; }
    }

    public class AddWebHooksResponse
    {
        [JsonProperty("webhookId")]
        public string WebHookId { get; set; }
    }

    public enum eventsInput
    {
        Sent,
        Signed,
        Completed,
        Declined,
        Revoked,
        Reassigned,
        Expired,
        Viewed,
        AuthenticationFailed,
        DeliveryFailed,
        SendFailed,
        TemplateSendFailed,
        DraftCreated
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Boldsign;

    public partial class WorkflowManagedActions
    {
        public BoldsignActions Boldsign(string connectionId) => new BoldsignActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BoldsignTriggers Boldsign(string connectionId) => new BoldsignTriggers(connectionId);
    }
}