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
        [WorkflowExpressionFactory(nameof(__BuildRRSET))]
        public IBodyWorkflowAction<RRSetResults[]> RRSET([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSetResults[]> __BuildRRSET(WorkflowValue<typeInput> type, WorkflowValue<string> value, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<bool> aggr = null, WorkflowValue<bool> humantime = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(aggr, nameof(aggr), required: false);
            WorkflowValue.Validate(humantime, nameof(humantime), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        [WorkflowExpressionFactory(nameof(__BuildRRSETRRTYPE))]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPE([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSetResults[]> __BuildRRSETRRTYPE(WorkflowValue<typeInput> type, WorkflowValue<string> value, WorkflowValue<string> rrtype, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<bool> aggr = null, WorkflowValue<bool> humantime = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(rrtype, nameof(rrtype), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(aggr, nameof(aggr), required: false);
            WorkflowValue.Validate(humantime, nameof(humantime), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        [WorkflowExpressionFactory(nameof(__BuildRRSETRRTYPEBAILIWICK))]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPEBAILIWICK([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<string> bailiwick, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RRSetResults[]> __BuildRRSETRRTYPEBAILIWICK(WorkflowValue<typeInput> type, WorkflowValue<string> value, WorkflowValue<string> rrtype, WorkflowValue<string> bailiwick, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<bool> aggr = null, WorkflowValue<bool> humantime = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(rrtype, nameof(rrtype), required: true);
            WorkflowValue.Validate(bailiwick, nameof(bailiwick), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(aggr, nameof(aggr), required: false);
            WorkflowValue.Validate(humantime, nameof(humantime), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1), ExpressionConverter.ConvertWithUrlEncoding(bailiwick, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        [WorkflowExpressionFactory(nameof(__BuildRDATA))]
        public IBodyWorkflowAction<RDataResults[]> RDATA([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RDataResults[]> __BuildRDATA(WorkflowValue<typeInput> type, WorkflowValue<string> value, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<bool> aggr = null, WorkflowValue<bool> humantime = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(aggr, nameof(aggr), required: false);
            WorkflowValue.Validate(humantime, nameof(humantime), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RDataResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        [WorkflowExpressionFactory(nameof(__BuildRDATARRTYPE))]
        public IBodyWorkflowAction<RDataResults[]> RDATARRTYPE([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RDataResults[]> __BuildRDATARRTYPE(WorkflowValue<typeInput> type, WorkflowValue<string> value, WorkflowValue<string> rrtype, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<bool> aggr = null, WorkflowValue<bool> humantime = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(type, nameof(type), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(rrtype, nameof(rrtype), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(aggr, nameof(aggr), required: false);
            WorkflowValue.Validate(humantime, nameof(humantime), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RDataResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(type, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1), ExpressionConverter.ConvertWithUrlEncoding(rrtype, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        [WorkflowExpressionFactory(nameof(__BuildFLEX))]
        public IBodyWorkflowAction<FlexResults[]> FLEX([WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<keyInput> key, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<string> exclude = null, [WorkflowExpression] Func<double> offset = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FlexResults[]> __BuildFLEX(WorkflowValue<methodInput> method, WorkflowValue<keyInput> key, WorkflowValue<string> value, WorkflowValue<double> timeFirstBefore = null, WorkflowValue<double> timeFirstAfter = null, WorkflowValue<double> timeLastBefore = null, WorkflowValue<double> timeLastAfter = null, WorkflowValue<double> limit = null, WorkflowValue<string> exclude = null, WorkflowValue<double> offset = null)
        {
            WorkflowValue.Validate(method, nameof(method), required: true);
            WorkflowValue.Validate(key, nameof(key), required: true);
            WorkflowValue.Validate(value, nameof(value), required: true);
            WorkflowValue.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            WorkflowValue.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            WorkflowValue.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            WorkflowValue.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(exclude, nameof(exclude), required: false);
            WorkflowValue.Validate(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FlexResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(method, 1), ExpressionConverter.ConvertWithUrlEncoding(key, 1), ExpressionConverter.ConvertWithUrlEncoding(value, 1));
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
            });
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
