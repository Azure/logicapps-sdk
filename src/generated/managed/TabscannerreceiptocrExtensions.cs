//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tabscannerreceiptocr
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TabscannerreceiptocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Process, ApiConnectionActionConfiguration> Process(Expression<Func<ProcessInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<Process, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/2/processbase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Process>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Result, ApiConnectionActionConfiguration> Result(Expression<Func<string>> token)
        {
            var __workflow_token = WorkflowExpression.Compile(token, nameof(token), required: true);
            return new DeferredBodyAction<Result, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/api/result/{0}", __workflow_token.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Result>(callPayload);
            });
        }
    }

    public class TabscannerreceiptocrTriggers([ConnectionName] string connectionId)
    {
    }

    public class Process
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_code")]
        public int StatusCode { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("duplicate")]
        public bool Duplicate { get; set; }

        [JsonProperty("duplicateToken")]
        public string DuplicateToken { get; set; }
    }

    public class ProcessInput
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }

        [JsonProperty("defaultDateParsing")]
        public string DefaultDateParsing { get; set; }

        [JsonProperty("decimalPlaces")]
        public string DecimalPlaces { get; set; }
    }

    public class Result
    {
        public string URL { get; set; }

        [JsonProperty("tax")]
        public int Tax { get; set; }

        [JsonProperty("tip")]
        public int Tip { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tabscannerreceiptocr;

    public partial class WorkflowManagedActions
    {
        public TabscannerreceiptocrActions Tabscannerreceiptocr(string connectionId) => new TabscannerreceiptocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TabscannerreceiptocrTriggers Tabscannerreceiptocr(string connectionId) => new TabscannerreceiptocrTriggers(connectionId);
    }
}