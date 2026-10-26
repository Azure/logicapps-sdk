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
        public IBodyWorkflowAction<PublishDocxResponse, ApiConnectionActionConfiguration> PublishDocx(Expression<Func<PublishDocxInput>> requestBody)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<PublishDocxResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/docx";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<PublishDocxResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        public IBodyWorkflowAction<PublishPDFResponse, ApiConnectionActionConfiguration> PublishPDF(Expression<Func<PublishPDFInput>> requestBody)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<PublishPDFResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/pdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
                return new ApiConnectionAction<PublishPDFResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "wendocslinker")]
        public IBodyWorkflowAction<PublishHtmlResponse, ApiConnectionActionConfiguration> PublishHtml(Expression<Func<PublishHtmlInput>> requestBody)
        {
            var __workflow_requestBody = WorkflowExpression.Compile(requestBody, nameof(requestBody), required: true);
            return new DeferredBodyAction<PublishHtmlResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/dynamicdoc/html";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_requestBody);
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

    public class PublishDocxInput
    {
        [JsonProperty("docName")]
        public string DocName { get; set; }

        [JsonProperty("documentTemplateData")]
        public string DocumentTemplateData { get; set; }

        [JsonProperty("jsonData")]
        public string JsonData { get; set; }

        [JsonProperty("logLevel")]
        public string LogLevel { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }
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

    public class PublishPDFInput
    {
        [JsonProperty("docName")]
        public string DocName { get; set; }

        [JsonProperty("documentTemplateData")]
        public string DocumentTemplateData { get; set; }

        [JsonProperty("jsonData")]
        public string JsonData { get; set; }

        [JsonProperty("logLevel")]
        public string LogLevel { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }
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

    public class PublishHtmlInput
    {
        [JsonProperty("docName")]
        public string DocName { get; set; }

        [JsonProperty("documentTemplateData")]
        public string DocumentTemplateData { get; set; }

        [JsonProperty("jsonData")]
        public string JsonData { get; set; }

        [JsonProperty("logLevel")]
        public string LogLevel { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }
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