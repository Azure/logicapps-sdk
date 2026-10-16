//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Farsightdnsdb
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class FarsightdnsdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSET(Expression<Func<typeInput>> type, Expression<Func<string>> value, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<bool>> aggr = null, Expression<Func<bool>> humantime = null, Expression<Func<double>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_aggr = WorkflowExpression.Compile(aggr, nameof(aggr), required: false);
            var __workflow_humantime = WorkflowExpression.Compile(humantime, nameof(humantime), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_aggr != null)
                    callPayload.Queries["aggr"] = ExpressionConverter.Convert(__workflow_aggr);
                if (__workflow_humantime != null)
                    callPayload.Queries["humantime"] = ExpressionConverter.Convert(__workflow_humantime);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RRSetResults[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPE(Expression<Func<typeInput>> type, Expression<Func<string>> value, Expression<Func<string>> rrtype, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<bool>> aggr = null, Expression<Func<bool>> humantime = null, Expression<Func<double>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_rrtype = WorkflowExpression.Compile(rrtype, nameof(rrtype), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_aggr = WorkflowExpression.Compile(aggr, nameof(aggr), required: false);
            var __workflow_humantime = WorkflowExpression.Compile(humantime, nameof(humantime), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rrtype, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_aggr != null)
                    callPayload.Queries["aggr"] = ExpressionConverter.Convert(__workflow_aggr);
                if (__workflow_humantime != null)
                    callPayload.Queries["humantime"] = ExpressionConverter.Convert(__workflow_humantime);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RRSetResults[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPEBAILIWICK(Expression<Func<typeInput>> type, Expression<Func<string>> value, Expression<Func<string>> rrtype, Expression<Func<string>> bailiwick, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<bool>> aggr = null, Expression<Func<bool>> humantime = null, Expression<Func<double>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_rrtype = WorkflowExpression.Compile(rrtype, nameof(rrtype), required: true);
            var __workflow_bailiwick = WorkflowExpression.Compile(bailiwick, nameof(bailiwick), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_aggr = WorkflowExpression.Compile(aggr, nameof(aggr), required: false);
            var __workflow_humantime = WorkflowExpression.Compile(humantime, nameof(humantime), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RRSetResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rrtype, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_bailiwick, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_aggr != null)
                    callPayload.Queries["aggr"] = ExpressionConverter.Convert(__workflow_aggr);
                if (__workflow_humantime != null)
                    callPayload.Queries["humantime"] = ExpressionConverter.Convert(__workflow_humantime);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RRSetResults[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATA(Expression<Func<typeInput>> type, Expression<Func<string>> value, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<bool>> aggr = null, Expression<Func<bool>> humantime = null, Expression<Func<double>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_aggr = WorkflowExpression.Compile(aggr, nameof(aggr), required: false);
            var __workflow_humantime = WorkflowExpression.Compile(humantime, nameof(humantime), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RDataResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_aggr != null)
                    callPayload.Queries["aggr"] = ExpressionConverter.Convert(__workflow_aggr);
                if (__workflow_humantime != null)
                    callPayload.Queries["humantime"] = ExpressionConverter.Convert(__workflow_humantime);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RDataResults[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATARRTYPE(Expression<Func<typeInput>> type, Expression<Func<string>> value, Expression<Func<string>> rrtype, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<bool>> aggr = null, Expression<Func<bool>> humantime = null, Expression<Func<double>> offset = null)
        {
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_rrtype = WorkflowExpression.Compile(rrtype, nameof(rrtype), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_aggr = WorkflowExpression.Compile(aggr, nameof(aggr), required: false);
            var __workflow_humantime = WorkflowExpression.Compile(humantime, nameof(humantime), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<RDataResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_type, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_rrtype, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_aggr != null)
                    callPayload.Queries["aggr"] = ExpressionConverter.Convert(__workflow_aggr);
                if (__workflow_humantime != null)
                    callPayload.Queries["humantime"] = ExpressionConverter.Convert(__workflow_humantime);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<RDataResults[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<FlexResults[]> FLEX(Expression<Func<methodInput>> method, Expression<Func<keyInput>> key, Expression<Func<string>> value, Expression<Func<double>> timeFirstBefore = null, Expression<Func<double>> timeFirstAfter = null, Expression<Func<double>> timeLastBefore = null, Expression<Func<double>> timeLastAfter = null, Expression<Func<double>> limit = null, Expression<Func<string>> exclude = null, Expression<Func<double>> offset = null)
        {
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_key = WorkflowExpression.Compile(key, nameof(key), required: true);
            var __workflow_value = WorkflowExpression.Compile(value, nameof(value), required: true);
            var __workflow_timeFirstBefore = WorkflowExpression.Compile(timeFirstBefore, nameof(timeFirstBefore), required: false);
            var __workflow_timeFirstAfter = WorkflowExpression.Compile(timeFirstAfter, nameof(timeFirstAfter), required: false);
            var __workflow_timeLastBefore = WorkflowExpression.Compile(timeLastBefore, nameof(timeLastBefore), required: false);
            var __workflow_timeLastAfter = WorkflowExpression.Compile(timeLastAfter, nameof(timeLastAfter), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_exclude = WorkflowExpression.Compile(exclude, nameof(exclude), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<FlexResults[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_method, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_key, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = ExpressionConverter.Convert(__workflow_timeFirstBefore);
                if (__workflow_timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = ExpressionConverter.Convert(__workflow_timeFirstAfter);
                if (__workflow_timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = ExpressionConverter.Convert(__workflow_timeLastBefore);
                if (__workflow_timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = ExpressionConverter.Convert(__workflow_timeLastAfter);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_exclude != null)
                    callPayload.Queries["exclude"] = ExpressionConverter.Convert(__workflow_exclude);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        [EnumMember(Value = "regex")]
        Regex,
        [EnumMember(Value = "glob")]
        Glob
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
