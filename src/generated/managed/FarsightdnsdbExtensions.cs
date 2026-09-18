//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Farsightdnsdb
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class FarsightdnsdbActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSET([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(aggr, nameof(aggr), required: false);
            SourceExpression.Validate(humantime, nameof(humantime), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (aggr != null)
                    callPayload.Queries["aggr"] = SourceExpressionConverter.ConvertO(aggr);
                if (humantime != null)
                    callPayload.Queries["humantime"] = SourceExpressionConverter.ConvertO(humantime);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<RRSetResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPE([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(rrtype, nameof(rrtype), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(aggr, nameof(aggr), required: false);
            SourceExpression.Validate(humantime, nameof(humantime), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rrtype, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (aggr != null)
                    callPayload.Queries["aggr"] = SourceExpressionConverter.ConvertO(aggr);
                if (humantime != null)
                    callPayload.Queries["humantime"] = SourceExpressionConverter.ConvertO(humantime);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<RRSetResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RRSetResults[]> RRSETRRTYPEBAILIWICK([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<string> bailiwick, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(rrtype, nameof(rrtype), required: true);
            SourceExpression.Validate(bailiwick, nameof(bailiwick), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(aggr, nameof(aggr), required: false);
            SourceExpression.Validate(humantime, nameof(humantime), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/rrset/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rrtype, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(bailiwick, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (aggr != null)
                    callPayload.Queries["aggr"] = SourceExpressionConverter.ConvertO(aggr);
                if (humantime != null)
                    callPayload.Queries["humantime"] = SourceExpressionConverter.ConvertO(humantime);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<RRSetResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATA([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(aggr, nameof(aggr), required: false);
            SourceExpression.Validate(humantime, nameof(humantime), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (aggr != null)
                    callPayload.Queries["aggr"] = SourceExpressionConverter.ConvertO(aggr);
                if (humantime != null)
                    callPayload.Queries["humantime"] = SourceExpressionConverter.ConvertO(humantime);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<RDataResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RDataResults[]> RDATARRTYPE([WorkflowExpression] Func<typeInput> type, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<string> rrtype, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<bool> aggr = null, [WorkflowExpression] Func<bool> humantime = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(type, nameof(type), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(rrtype, nameof(rrtype), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(aggr, nameof(aggr), required: false);
            SourceExpression.Validate(humantime, nameof(humantime), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lookup/rdata/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(type, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(rrtype, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (aggr != null)
                    callPayload.Queries["aggr"] = SourceExpressionConverter.ConvertO(aggr);
                if (humantime != null)
                    callPayload.Queries["humantime"] = SourceExpressionConverter.ConvertO(humantime);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<RDataResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<FlexResults[]> FLEX([WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<keyInput> key, [WorkflowExpression] Func<string> value, [WorkflowExpression] Func<double> timeFirstBefore = null, [WorkflowExpression] Func<double> timeFirstAfter = null, [WorkflowExpression] Func<double> timeLastBefore = null, [WorkflowExpression] Func<double> timeLastAfter = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<string> exclude = null, [WorkflowExpression] Func<double> offset = null)
        {
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(key, nameof(key), required: true);
            SourceExpression.Validate(value, nameof(value), required: true);
            SourceExpression.Validate(timeFirstBefore, nameof(timeFirstBefore), required: false);
            SourceExpression.Validate(timeFirstAfter, nameof(timeFirstAfter), required: false);
            SourceExpression.Validate(timeLastBefore, nameof(timeLastBefore), required: false);
            SourceExpression.Validate(timeLastAfter, nameof(timeLastAfter), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(exclude, nameof(exclude), required: false);
            SourceExpression.Validate(offset, nameof(offset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(method, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(key, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(value, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (timeFirstBefore != null)
                    callPayload.Queries["time_first_before"] = SourceExpressionConverter.ConvertO(timeFirstBefore);
                if (timeFirstAfter != null)
                    callPayload.Queries["time_first_after"] = SourceExpressionConverter.ConvertO(timeFirstAfter);
                if (timeLastBefore != null)
                    callPayload.Queries["time_last_before"] = SourceExpressionConverter.ConvertO(timeLastBefore);
                if (timeLastAfter != null)
                    callPayload.Queries["time_last_after"] = SourceExpressionConverter.ConvertO(timeLastAfter);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (exclude != null)
                    callPayload.Queries["exclude"] = SourceExpressionConverter.ConvertO(exclude);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<FlexResults[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<RateLimitResults> RATELIMIT()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/rate_limit";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RateLimitResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "farsightdnsdb")]
        public IBodyWorkflowAction<PINGResponse> PING()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/ping";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PINGResponse>(BuildSourceInput);
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