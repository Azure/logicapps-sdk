//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wendocslinker
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WendocslinkerActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [WorkflowExpressionFactory(nameof(__BuildPublishDocx))]
        public IBodyWorkflowAction<PublishDocxResponse> PublishDocx([WorkflowExpression] Func<string> requestBodydocName = null, [WorkflowExpression] Func<string> requestBodydocumentTemplateData = null, [WorkflowExpression] Func<string> requestBodyjsonData = null, [WorkflowExpression] Func<string> requestBodylogLevel = null, [WorkflowExpression] Func<string> requestBodylanguage = null, [WorkflowExpression] Func<string> requestBodycountry = null, [WorkflowExpression] Func<string> requestBodyclientType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PublishDocxResponse> __BuildPublishDocx(WorkflowExpression<string> requestBodydocName = null, WorkflowExpression<string> requestBodydocumentTemplateData = null, WorkflowExpression<string> requestBodyjsonData = null, WorkflowExpression<string> requestBodylogLevel = null, WorkflowExpression<string> requestBodylanguage = null, WorkflowExpression<string> requestBodycountry = null, WorkflowExpression<string> requestBodyclientType = null)
        {
            WorkflowExpression.Validate(requestBodydocName, nameof(requestBodydocName), required: false);
            WorkflowExpression.Validate(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            WorkflowExpression.Validate(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            WorkflowExpression.Validate(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            WorkflowExpression.Validate(requestBodylanguage, nameof(requestBodylanguage), required: false);
            WorkflowExpression.Validate(requestBodycountry, nameof(requestBodycountry), required: false);
            WorkflowExpression.Validate(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishDocxResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(requestBodydocName);
                    requestBodypropCount++;
                }

                if (requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(requestBodylanguage);
                    requestBodypropCount++;
                }

                if (requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(requestBodycountry);
                    requestBodypropCount++;
                }

                if (requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(requestBodyclientType);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<PublishDocxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [WorkflowExpressionFactory(nameof(__BuildPublishPDF))]
        public IBodyWorkflowAction<PublishPDFResponse> PublishPDF([WorkflowExpression] Func<string> requestBodydocName = null, [WorkflowExpression] Func<string> requestBodydocumentTemplateData = null, [WorkflowExpression] Func<string> requestBodyjsonData = null, [WorkflowExpression] Func<string> requestBodylogLevel = null, [WorkflowExpression] Func<string> requestBodylanguage = null, [WorkflowExpression] Func<string> requestBodycountry = null, [WorkflowExpression] Func<string> requestBodyclientType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PublishPDFResponse> __BuildPublishPDF(WorkflowExpression<string> requestBodydocName = null, WorkflowExpression<string> requestBodydocumentTemplateData = null, WorkflowExpression<string> requestBodyjsonData = null, WorkflowExpression<string> requestBodylogLevel = null, WorkflowExpression<string> requestBodylanguage = null, WorkflowExpression<string> requestBodycountry = null, WorkflowExpression<string> requestBodyclientType = null)
        {
            WorkflowExpression.Validate(requestBodydocName, nameof(requestBodydocName), required: false);
            WorkflowExpression.Validate(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            WorkflowExpression.Validate(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            WorkflowExpression.Validate(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            WorkflowExpression.Validate(requestBodylanguage, nameof(requestBodylanguage), required: false);
            WorkflowExpression.Validate(requestBodycountry, nameof(requestBodycountry), required: false);
            WorkflowExpression.Validate(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishPDFResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(requestBodydocName);
                    requestBodypropCount++;
                }

                if (requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(requestBodylanguage);
                    requestBodypropCount++;
                }

                if (requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(requestBodycountry);
                    requestBodypropCount++;
                }

                if (requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(requestBodyclientType);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<PublishPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [WorkflowExpressionFactory(nameof(__BuildPublishHtml))]
        public IBodyWorkflowAction<PublishHtmlResponse> PublishHtml([WorkflowExpression] Func<string> requestBodydocName = null, [WorkflowExpression] Func<string> requestBodydocumentTemplateData = null, [WorkflowExpression] Func<string> requestBodyjsonData = null, [WorkflowExpression] Func<string> requestBodylogLevel = null, [WorkflowExpression] Func<string> requestBodylanguage = null, [WorkflowExpression] Func<string> requestBodycountry = null, [WorkflowExpression] Func<string> requestBodyclientType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PublishHtmlResponse> __BuildPublishHtml(WorkflowExpression<string> requestBodydocName = null, WorkflowExpression<string> requestBodydocumentTemplateData = null, WorkflowExpression<string> requestBodyjsonData = null, WorkflowExpression<string> requestBodylogLevel = null, WorkflowExpression<string> requestBodylanguage = null, WorkflowExpression<string> requestBodycountry = null, WorkflowExpression<string> requestBodyclientType = null)
        {
            WorkflowExpression.Validate(requestBodydocName, nameof(requestBodydocName), required: false);
            WorkflowExpression.Validate(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            WorkflowExpression.Validate(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            WorkflowExpression.Validate(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            WorkflowExpression.Validate(requestBodylanguage, nameof(requestBodylanguage), required: false);
            WorkflowExpression.Validate(requestBodycountry, nameof(requestBodycountry), required: false);
            WorkflowExpression.Validate(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishHtmlResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(requestBodydocName);
                    requestBodypropCount++;
                }

                if (requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(requestBodylanguage);
                    requestBodypropCount++;
                }

                if (requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(requestBodycountry);
                    requestBodypropCount++;
                }

                if (requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(requestBodyclientType);
                    requestBodypropCount++;
                }

                if (requestBodypropCount > 0)
                {
                    callPayload.Body = requestBody;
                }

                return new ApiConnectionAction<PublishHtmlResponse>(callPayload);
            });
        }
    }

    public class WendocslinkerTriggers([ConnectionName] string connectionId)
    {
    }

    public class PublishDocxResponse
    {
        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("messages")]
        public PublishDocxResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class PublishDocxResponseMessagesTypeItem
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
    }

    public class PublishPDFResponse
    {
        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("messages")]
        public PublishPDFResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class PublishPDFResponseMessagesTypeItem
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
    }

    public class PublishHtmlResponse
    {
        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("messages")]
        public PublishHtmlResponseMessagesTypeItem[] Messages { get; set; }
    }

    public class PublishHtmlResponseMessagesTypeItem
    {
        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("parameters")]
        public string[] Parameters { get; set; }

        [JsonProperty("exception")]
        public string Exception { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Wendocslinker;

    public partial class WorkflowManagedActions
    {
        public WendocslinkerActions Wendocslinker(string connectionId) => new WendocslinkerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public WendocslinkerTriggers Wendocslinker(string connectionId) => new WendocslinkerTriggers(connectionId);
    }
}