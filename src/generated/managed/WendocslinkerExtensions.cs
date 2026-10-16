//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Wendocslinker
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class WendocslinkerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        public IBodyWorkflowAction<PublishDocxResponse> PublishDocx(Expression<Func<string>> requestBodydocName = null, Expression<Func<string>> requestBodydocumentTemplateData = null, Expression<Func<string>> requestBodyjsonData = null, Expression<Func<string>> requestBodylogLevel = null, Expression<Func<string>> requestBodylanguage = null, Expression<Func<string>> requestBodycountry = null, Expression<Func<string>> requestBodyclientType = null)
        {
            var __workflow_requestBodydocName = WorkflowExpression.Compile(requestBodydocName, nameof(requestBodydocName), required: false);
            var __workflow_requestBodydocumentTemplateData = WorkflowExpression.Compile(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            var __workflow_requestBodyjsonData = WorkflowExpression.Compile(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            var __workflow_requestBodylogLevel = WorkflowExpression.Compile(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            var __workflow_requestBodylanguage = WorkflowExpression.Compile(requestBodylanguage, nameof(requestBodylanguage), required: false);
            var __workflow_requestBodycountry = WorkflowExpression.Compile(requestBodycountry, nameof(requestBodycountry), required: false);
            var __workflow_requestBodyclientType = WorkflowExpression.Compile(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishDocxResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(__workflow_requestBodydocName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(__workflow_requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(__workflow_requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(__workflow_requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(__workflow_requestBodylanguage);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(__workflow_requestBodycountry);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(__workflow_requestBodyclientType);
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
        public IBodyWorkflowAction<PublishPDFResponse> PublishPDF(Expression<Func<string>> requestBodydocName = null, Expression<Func<string>> requestBodydocumentTemplateData = null, Expression<Func<string>> requestBodyjsonData = null, Expression<Func<string>> requestBodylogLevel = null, Expression<Func<string>> requestBodylanguage = null, Expression<Func<string>> requestBodycountry = null, Expression<Func<string>> requestBodyclientType = null)
        {
            var __workflow_requestBodydocName = WorkflowExpression.Compile(requestBodydocName, nameof(requestBodydocName), required: false);
            var __workflow_requestBodydocumentTemplateData = WorkflowExpression.Compile(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            var __workflow_requestBodyjsonData = WorkflowExpression.Compile(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            var __workflow_requestBodylogLevel = WorkflowExpression.Compile(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            var __workflow_requestBodylanguage = WorkflowExpression.Compile(requestBodylanguage, nameof(requestBodylanguage), required: false);
            var __workflow_requestBodycountry = WorkflowExpression.Compile(requestBodycountry, nameof(requestBodycountry), required: false);
            var __workflow_requestBodyclientType = WorkflowExpression.Compile(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishPDFResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(__workflow_requestBodydocName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(__workflow_requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(__workflow_requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(__workflow_requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(__workflow_requestBodylanguage);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(__workflow_requestBodycountry);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(__workflow_requestBodyclientType);
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
        public IBodyWorkflowAction<PublishHtmlResponse> PublishHtml(Expression<Func<string>> requestBodydocName = null, Expression<Func<string>> requestBodydocumentTemplateData = null, Expression<Func<string>> requestBodyjsonData = null, Expression<Func<string>> requestBodylogLevel = null, Expression<Func<string>> requestBodylanguage = null, Expression<Func<string>> requestBodycountry = null, Expression<Func<string>> requestBodyclientType = null)
        {
            var __workflow_requestBodydocName = WorkflowExpression.Compile(requestBodydocName, nameof(requestBodydocName), required: false);
            var __workflow_requestBodydocumentTemplateData = WorkflowExpression.Compile(requestBodydocumentTemplateData, nameof(requestBodydocumentTemplateData), required: false);
            var __workflow_requestBodyjsonData = WorkflowExpression.Compile(requestBodyjsonData, nameof(requestBodyjsonData), required: false);
            var __workflow_requestBodylogLevel = WorkflowExpression.Compile(requestBodylogLevel, nameof(requestBodylogLevel), required: false);
            var __workflow_requestBodylanguage = WorkflowExpression.Compile(requestBodylanguage, nameof(requestBodylanguage), required: false);
            var __workflow_requestBodycountry = WorkflowExpression.Compile(requestBodycountry, nameof(requestBodycountry), required: false);
            var __workflow_requestBodyclientType = WorkflowExpression.Compile(requestBodyclientType, nameof(requestBodyclientType), required: false);
            return new DeferredBodyAction<PublishHtmlResponse>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBody = new JObject();
                var requestBodypropCount = 0;
                if (__workflow_requestBodydocName != null)
                {
                    requestBody["docName"] = ExpressionConverter.ConvertO(__workflow_requestBodydocName);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodydocumentTemplateData != null)
                {
                    requestBody["documentTemplateData"] = ExpressionConverter.ConvertO(__workflow_requestBodydocumentTemplateData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyjsonData != null)
                {
                    requestBody["jsonData"] = ExpressionConverter.ConvertO(__workflow_requestBodyjsonData);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylogLevel != null)
                {
                    requestBody["logLevel"] = ExpressionConverter.ConvertO(__workflow_requestBodylogLevel);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodylanguage != null)
                {
                    requestBody["language"] = ExpressionConverter.ConvertO(__workflow_requestBodylanguage);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodycountry != null)
                {
                    requestBody["country"] = ExpressionConverter.ConvertO(__workflow_requestBodycountry);
                    requestBodypropCount++;
                }

                if (__workflow_requestBodyclientType != null)
                {
                    requestBody["clientType"] = ExpressionConverter.ConvertO(__workflow_requestBodyclientType);
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
