//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tabscannerreceiptocr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TabscannerreceiptocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Process> Process(Expression<Func<string>> bodyimage = null, Expression<Func<string>> bodyregion = null, Expression<Func<string>> bodydocumentType = null, Expression<Func<string>> bodydefaultDateParsing = null, Expression<Func<string>> bodydecimalPlaces = null)
        {
            var apiCallPath = "/api/2/processbase64";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyimage != null)
            {
                body["image"] = ExpressionConverter.ConvertO(bodyimage);
                bodypropCount++;
            }

            if (bodyregion != null)
            {
                body["region"] = ExpressionConverter.ConvertO(bodyregion);
                bodypropCount++;
            }

            if (bodydocumentType != null)
            {
                body["documentType"] = ExpressionConverter.ConvertO(bodydocumentType);
                bodypropCount++;
            }

            if (bodydefaultDateParsing != null)
            {
                body["defaultDateParsing"] = ExpressionConverter.ConvertO(bodydefaultDateParsing);
                bodypropCount++;
            }

            if (bodydecimalPlaces != null)
            {
                body["decimalPlaces"] = ExpressionConverter.ConvertO(bodydecimalPlaces);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Process>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tabscannerreceiptocr")]
        public IBodyWorkflowAction<Result> Result(Expression<Func<string>> token)
        {
            var apiCallPath = String.Format("/api/result/{0}", ExpressionConverter.ConvertWithUrlEncoding(token, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Result>(callPayload);
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