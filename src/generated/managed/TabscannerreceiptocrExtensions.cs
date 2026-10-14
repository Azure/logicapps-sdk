//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tabscannerreceiptocr
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TabscannerreceiptocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Process> Process(Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydocumentType = null, Expression<Func<string>> bodydefaultDateParsing = null, Expression<Func<string>> bodydecimalPlaces = null)
        {
            var __workflow_bodyimage = bodyimage == null ? null : WorkflowExpression.Compile(bodyimage);
            WorkflowExpression.Validate(__workflow_bodyimage, nameof(bodyimage), required: false);
            var __workflow_bodyregion = bodyregion == null ? null : WorkflowExpression.Compile(bodyregion);
            WorkflowExpression.Validate(__workflow_bodyregion, nameof(bodyregion), required: false);
            var __workflow_bodydocumentType = bodydocumentType == null ? null : WorkflowExpression.Compile(bodydocumentType);
            WorkflowExpression.Validate(__workflow_bodydocumentType, nameof(bodydocumentType), required: false);
            var __workflow_bodydefaultDateParsing = bodydefaultDateParsing == null ? null : WorkflowExpression.Compile(bodydefaultDateParsing);
            WorkflowExpression.Validate(__workflow_bodydefaultDateParsing, nameof(bodydefaultDateParsing), required: false);
            var __workflow_bodydecimalPlaces = bodydecimalPlaces == null ? null : WorkflowExpression.Compile(bodydecimalPlaces);
            WorkflowExpression.Validate(__workflow_bodydecimalPlaces, nameof(bodydecimalPlaces), required: false);
            return new DeferredBodyAction<Process>(() =>
            {
                var apiCallPath = "/api/2/processbase64";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyimage != null)
                {
                    body["image"] = ExpressionConverter.ConvertO(__workflow_bodyimage);
                    bodypropCount++;
                }

                if (__workflow_bodyregion != null)
                {
                    body["region"] = ExpressionConverter.ConvertO(__workflow_bodyregion);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentType != null)
                {
                    body["documentType"] = ExpressionConverter.ConvertO(__workflow_bodydocumentType);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultDateParsing != null)
                {
                    body["defaultDateParsing"] = ExpressionConverter.ConvertO(__workflow_bodydefaultDateParsing);
                    bodypropCount++;
                }

                if (__workflow_bodydecimalPlaces != null)
                {
                    body["decimalPlaces"] = ExpressionConverter.ConvertO(__workflow_bodydecimalPlaces);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Process>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Result> Result(Expression<Func<string>> token)
        {
            var __workflow_token = token == null ? null : WorkflowExpression.Compile(token);
            WorkflowExpression.Validate(__workflow_token, nameof(token), required: true);
            return new DeferredBodyAction<Result>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/api/result/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_token, 1));
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
