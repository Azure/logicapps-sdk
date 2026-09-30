//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Farsightdnsdb
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FarsightdnsdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSET([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/lookup/rrset/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (aggr != null)
                callPayload.Queries["aggr"] = ExpressionConverter.Convert(aggr);
            if (humantime != null)
                callPayload.Queries["humantime"] = ExpressionConverter.Convert(humantime);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RRSetResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<typeInput> type, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/lookup/rrset/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (aggr != null)
                callPayload.Queries["aggr"] = ExpressionConverter.Convert(aggr);
            if (humantime != null)
                callPayload.Queries["humantime"] = ExpressionConverter.Convert(humantime);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RRSetResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPEBAILIWICK([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<typeInput> type, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> value, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> rrtype, [WorkflowExpression] Func<string> bailiwick, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/lookup/rrset/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1), ExpressionConverter.ConvertWithUrlEncoding(bailiwick, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (aggr != null)
                callPayload.Queries["aggr"] = ExpressionConverter.Convert(aggr);
            if (humantime != null)
                callPayload.Queries["humantime"] = ExpressionConverter.Convert(humantime);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RRSetResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATA([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/lookup/rdata/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (aggr != null)
                callPayload.Queries["aggr"] = ExpressionConverter.Convert(aggr);
            if (humantime != null)
                callPayload.Queries["humantime"] = ExpressionConverter.Convert(humantime);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RDataResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATARRTYPE([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<typeInput> type, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/lookup/rdata/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (aggr != null)
                callPayload.Queries["aggr"] = ExpressionConverter.Convert(aggr);
            if (humantime != null)
                callPayload.Queries["humantime"] = ExpressionConverter.Convert(humantime);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<RDataResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<FlexResults[]> FLEX([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<methodInput> method, [WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<keyInput> key, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<string> exclude = null, [WorkflowExpression] Func<double> offset = null)
        {
            var apiCallPath = String.Format("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(method, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (timeFirstBefore != null)
                callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(timeFirstBefore);
            if (timeFirstAfter != null)
                callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(timeFirstAfter);
            if (timeLastBefore != null)
                callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(timeLastBefore);
            if (timeLastAfter != null)
                callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(timeLastAfter);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (exclude != null)
                callPayload.Queries["exclude"] = ExpressionConverter.Convert(exclude);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<FlexResults[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RateLimitResults> RATELIMIT()
        {
            var apiCallPath = "/rate_limit";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RateLimitResults>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<PINGResponse> PING()
        {
            var apiCallPath = "/ping";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<PINGResponse>(callPayload);
        }
    }

    public class FarsightdnsdbTriggers([ConnectionName] string connectionId)
    {
    }

    public class RRSetResults
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("time_first")]
        public double TimeFirst { get; set; }

        [JsonProperty("time_last")]
        public double TimeLast { get; set; }

        [JsonProperty("zone_time_first")]
        public double ZoneTimeFirst { get; set; }

        [JsonProperty("zone_time_last")]
        public double ZoneTimeLast { get; set; }

        [JsonProperty("rrname")]
        public string Rrname { get; set; }

        [JsonProperty("rrtype")]
        public string Rrtype { get; set; }

        [JsonProperty("bailiwick")]
        public string Bailiwick { get; set; }

        [JsonProperty("rdata")]
        public string[] Rdata { get; set; }
    }

    public enum typeInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "ip")]
        Ip,
        [EnumMember(Value = "raw")]
        Raw
    }

    public class RDataResults
    {
        [JsonProperty("count")]
        public double Count { get; set; }

        [JsonProperty("time_first")]
        public double TimeFirst { get; set; }

        [JsonProperty("time_last")]
        public double TimeLast { get; set; }

        [JsonProperty("zone_time_first")]
        public double ZoneTimeFirst { get; set; }

        [JsonProperty("zone_time_last")]
        public double ZoneTimeLast { get; set; }

        [JsonProperty("rrname")]
        public string Rrname { get; set; }

        [JsonProperty("rrtype")]
        public string Rrtype { get; set; }

        [JsonProperty("rdata")]
        public string[] Rdata { get; set; }
    }

    public class FlexResults
    {
        [JsonProperty("rdata")]
        public string Rdata { get; set; }

        [JsonProperty("rrname")]
        public string Rrname { get; set; }

        [JsonProperty("rrtype")]
        public string Rrtype { get; set; }

        [JsonProperty("raw_rdata")]
        public string RawRdata { get; set; }
    }

    public enum methodInput
    {
        [EnumMember(Value = "regex")]
        Regex,
        [EnumMember(Value = "glob")]
        Glob
    }

    public enum keyInput
    {
        [EnumMember(Value = "rrnames")]
        Rrnames,
        [EnumMember(Value = "rdata")]
        Rdata
    }

    public class RateLimitResults
    {
        [JsonProperty("limit")]
        public double Limit { get; set; }

        [JsonProperty("remaining")]
        public double Remaining { get; set; }

        [JsonProperty("reset")]
        public double Reset { get; set; }

        [JsonProperty("expires")]
        public double Expires { get; set; }

        [JsonProperty("results_max")]
        public double ResultsMax { get; set; }

        [JsonProperty("offset_max")]
        public double OffsetMax { get; set; }

        [JsonProperty("burst_size")]
        public double BurstSize { get; set; }

        [JsonProperty("burst_window")]
        public double BurstWindow { get; set; }
    }

    public class PINGResponse
    {
        [JsonProperty("ping")]
        public string Ping { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Farsightdnsdb;

    public partial class WorkflowManagedActions
    {
        public FarsightdnsdbActions Farsightdnsdb(string connectionId) => new FarsightdnsdbActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public FarsightdnsdbTriggers Farsightdnsdb(string connectionId) => new FarsightdnsdbTriggers(connectionId);
    }
}