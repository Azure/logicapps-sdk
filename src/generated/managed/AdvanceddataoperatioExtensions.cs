//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AdvanceddataoperatioActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> Aggregate(Expression<Func<AggregateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Aggregate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> CartesianJoin(Expression<Func<CartesianJoinBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CartesianJoin";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Concatenate(Expression<Func<ConcatenateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Concatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CSharpEvaluate(Expression<Func<CSharpEvaluateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CSharpEvaluate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> CSharpScriptExecute(Expression<Func<CSharpScriptExecuteBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CSharpScriptExecute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> CsvToJson(Expression<Func<CsvToJsonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/CsvToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Distinct(Expression<Func<DistinctBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Distinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> Expert(Expression<Func<ExpertBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Expert";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> FilterObjectArray(Expression<Func<FilterObjectArrayBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FilterObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> FlattenObjectArray(Expression<Func<FlattenObjectArrayBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/FlattenObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> GetDataSchema(Expression<Func<GetDataSchemaBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetDataSchema";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GZipCompress(Expression<Func<GZipCompressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GZipCompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GZipDecompress(Expression<Func<GZipCompressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GZipDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> Join(Expression<Func<JoinBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Join";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> JsonSchemaValidate(Expression<Func<JsonSchemaValidateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JsonSchemaValidate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> JsonToTable(Expression<Func<JsonToTableBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JsonToTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> JsonToText(Expression<Func<JsonToTextBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JsonToText";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> JsonToCsv(Expression<Func<JsonToCsvBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JsonToCsv";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction<ApiConnectionActionConfiguration> JsonPropertiesToNameValuePairArray(Expression<Func<JsonPropertiesToNameValuePairArrayBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/JsonPropertiesToNameValuePairArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<LevenshteinDistanceResponse, ApiConnectionActionConfiguration> LevenshteinDistance(Expression<Func<LevenshteinDistanceBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<LevenshteinDistanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/LevenshteinDistance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<LevenshteinDistanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> ParquetToJson(Expression<Func<ParquetToJsonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ParquetToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string[], ApiConnectionActionConfiguration> RegexMatches(Expression<Func<RegexMatchesBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/RegexMatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> SimpleConcatenate(Expression<Func<SimpleConcatenateBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SimpleConcatenate";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SimpleDistinct(Expression<Func<SimpleDistinctBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SimpleDistinct";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> SortObjectArray(Expression<Func<SortObjectArrayBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/SortObjectArray";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> Split(Expression<Func<SplitBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Split";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> TextToJson(Expression<Func<TextToJsonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/TextToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> Transform(Expression<Func<TransformBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/Transform";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<JToken[], ApiConnectionActionConfiguration> XmlToJson(Expression<Func<XmlToJsonBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<JToken[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/XmlToJson";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "advanceddataoperatio")]
        public IBodyWorkflowAction<ZipArchiveDecompressResponseItem[], ApiConnectionActionConfiguration> ZipArchiveDecompress(Expression<Func<ZipArchiveDecompressBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ZipArchiveDecompressResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/ZipArchiveDecompress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ZipArchiveDecompressResponseItem[]>(callPayload);
            });
        }
    }

    public class AdvanceddataoperatioTriggers([ConnectionName] string connectionId)
    {
    }

    public class AggregateBodyInput
    {
        public AggregateBodyInput(BodyInputAggregationTypeType aggregationType, string[] aggregateBy, string[] aggregateOn, JToken[] data)
        {
            this.AggregationType = aggregationType;
            this.AggregateBy = aggregateBy;
            this.AggregateOn = aggregateOn;
            this.Data = data;
        }

        [JsonProperty("aggregationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAggregationTypeType AggregationType { get; set; }

        [JsonProperty("aggregateBy", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] AggregateBy { get; set; }

        [JsonProperty("aggregateOn", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] AggregateOn { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAggregationTypeType
    {
        AVG,
        SUM,
        COUNT,
        MAX,
        MIN
    }

    public class AdvancedOptions
    {
        [JsonProperty("cultureName")]
        public string CultureName { get; set; }

        [JsonProperty("isBoolean")]
        public string[] IsBoolean { get; set; }
    }

    public class CartesianJoinBodyInput
    {
        public CartesianJoinBodyInput(JToken data)
        {
            this.Data = data;
        }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    public class ConcatenateBodyInput
    {
        public ConcatenateBodyInput(string field, bool ignoreEmpty, JToken[] data)
        {
            this.Field = field;
            this.IgnoreEmpty = ignoreEmpty;
            this.Data = data;
        }

        [JsonProperty("field", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Field { get; set; }

        [JsonProperty("separator")]
        public string Separator { get; set; }

        [JsonProperty("ignoreEmpty", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IgnoreEmpty { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class CSharpEvaluateBodyInput
    {
        public CSharpEvaluateBodyInput(string expression)
        {
            this.Expression = expression;
        }

        [JsonProperty("expression", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Expression { get; set; }
    }

    public class CSharpScriptExecuteBodyInput
    {
        public CSharpScriptExecuteBodyInput(string script)
        {
            this.Script = script;
        }

        [JsonProperty("script", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Script { get; set; }

        [JsonProperty("classDefinitions")]
        public string[] ClassDefinitions { get; set; }

        [JsonProperty("parameters")]
        public JToken Parameters { get; set; }
    }

    public class CsvToJsonBodyInput
    {
        public CsvToJsonBodyInput(string data)
        {
            this.Data = data;
        }

        [JsonProperty("headerRow")]
        public bool? HeaderRow { get; set; }

        [JsonProperty("rowSeparator")]
        public string RowSeparator { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("encoding")]
        public BodyInputEncodingType? Encoding { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputEncodingType
    {
        ASCII,
        UTF8,
        UTF16LittleEndian,
        UTF16BigEndian,
        [EnumMember(Value = "ISO-8859-1")]
        ISO88591
    }

    public class DistinctBodyInput
    {
        public DistinctBodyInput(string[] fields, JToken[] data)
        {
            this.Fields = fields;
            this.Data = data;
        }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Fields { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class ExpertBodyInput
    {
        public ExpertBodyInput(string query, JToken data)
        {
            this.Query = query;
            this.Data = data;
        }

        [JsonProperty("query", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Query { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    public class FilterObjectArrayBodyInput
    {
        public FilterObjectArrayBodyInput(string filter, JToken[] data)
        {
            this.Filter = filter;
            this.Data = data;
        }

        [JsonProperty("filter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Filter { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class FlattenObjectArrayBodyInput
    {
        public FlattenObjectArrayBodyInput(string delimiter, bool balancedOutput, JToken[] data)
        {
            this.Delimiter = delimiter;
            this.BalancedOutput = balancedOutput;
            this.Data = data;
        }

        [JsonProperty("delimiter", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Delimiter { get; set; }

        [JsonProperty("balancedOutput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool BalancedOutput { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class GetDataSchemaBodyInput
    {
        public GetDataSchemaBodyInput(JToken[] data)
        {
            this.Data = data;
        }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class GZipCompressBodyInput
    {
        public GZipCompressBodyInput(string data)
        {
            this.Data = data;
        }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class JoinBodyInput
    {
        public JoinBodyInput(BodyInputJoinTypeType joinType, string[] joinFields, string[] fields, JToken data)
        {
            this.JoinType = joinType;
            this.JoinFields = joinFields;
            this.Fields = fields;
            this.Data = data;
        }

        [JsonProperty("joinType", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputJoinTypeType JoinType { get; set; }

        [JsonProperty("joinFields", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] JoinFields { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Fields { get; set; }

        [JsonProperty("forceFullyQualifiedFieldNames")]
        public bool? ForceFullyQualifiedFieldNames { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputJoinTypeType
    {
        Left,
        Inner
    }

    public class JsonSchemaValidateBodyInput
    {
        public JsonSchemaValidateBodyInput(JToken schema, JToken data)
        {
            this.Schema = schema;
            this.Data = data;
        }

        [JsonProperty("schema", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Schema { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    public class JsonToTableBodyInput
    {
        public JsonToTableBodyInput(JToken data)
        {
            this.Data = data;
        }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("balancedOutput")]
        public bool? BalancedOutput { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    public class JsonToTextBodyInput
    {
        public JsonToTextBodyInput(JToken[] data)
        {
            this.Data = data;
        }

        [JsonProperty("headerRow")]
        public bool? HeaderRow { get; set; }

        [JsonProperty("rowSeparator")]
        public string RowSeparator { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class JsonToCsvBodyInput
    {
        public JsonToCsvBodyInput(JToken[] data)
        {
            this.Data = data;
        }

        [JsonProperty("headerRow")]
        public bool? HeaderRow { get; set; }

        [JsonProperty("rowSeparator")]
        public string RowSeparator { get; set; }

        [JsonProperty("escapeCharacter")]
        public string EscapeCharacter { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class JsonPropertiesToNameValuePairArrayBodyInput
    {
        public JsonPropertiesToNameValuePairArrayBodyInput(JToken data)
        {
            this.Data = data;
        }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Data { get; set; }
    }

    public class LevenshteinDistanceResponse
    {
        public LevenshteinDistanceResponseBaseValueType BaseValue { get; set; }
        public LevenshteinDistanceResponseComparisonSettingsType ComparisonSettings { get; set; }
        public LevenshteinDistanceResponseComparisonsTypeItem[] Comparisons { get; set; }
    }

    public class LevenshteinDistanceResponseBaseValueType
    {
        public string Supplied { get; set; }
        public string Actual { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonSettingsType
    {
        public double RatioThreshold { get; set; }
        public string ApplyRatioThresholdTo { get; set; }
        public bool CaseSensitive { get; set; }
        public bool RemoveWhitespace { get; set; }
        public bool RemoveSpecialCharacters { get; set; }
        public string RatioSelectionType { get; set; }
        public string TokenSortType { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItem
    {
        public LevenshteinDistanceResponseComparisonsTypeItemComparisonType Comparison { get; set; }
        public LevenshteinDistanceResponseComparisonsTypeItemResultsType Results { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItemComparisonType
    {
        public string Supplied { get; set; }
        public string Actual { get; set; }
    }

    public class LevenshteinDistanceResponseComparisonsTypeItemResultsType
    {
        public double Ratio { get; set; }
        public double PartialRatio { get; set; }
        public double SortedRatio { get; set; }
        public double SortedPartialRatio { get; set; }
        public double MaxRatio { get; set; }
        public double AvgRatio { get; set; }
    }

    public class LevenshteinDistanceBodyInput
    {
        public LevenshteinDistanceBodyInput(string baseValue, string[] comparisonValues)
        {
            this.BaseValue = baseValue;
            this.ComparisonValues = comparisonValues;
        }

        [JsonProperty("baseValue", DefaultValueHandling = DefaultValueHandling.Include)]
        public string BaseValue { get; set; }

        [JsonProperty("comparisonValues", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] ComparisonValues { get; set; }
        public BodyInputSettingsType Settings { get; set; }
    }

    public class BodyInputSettingsType
    {
        [JsonProperty("ratioThreshold")]
        public double? RatioThreshold { get; set; }

        [JsonProperty("applyRatioThresholdTo")]
        public BodyInputSettingsTypeApplyRatioThresholdToType? ApplyRatioThresholdTo { get; set; }

        [JsonProperty("ratioSelectionType")]
        public BodyInputSettingsTypeRatioSelectionTypeType? RatioSelectionType { get; set; }

        [JsonProperty("tokenSortType")]
        public BodyInputSettingsTypeTokenSortTypeType? TokenSortType { get; set; }

        [JsonProperty("caseSensitive")]
        public bool? CaseSensitive { get; set; }

        [JsonProperty("removeWhitespace")]
        public bool? RemoveWhitespace { get; set; }

        [JsonProperty("removeSpecialCharacters")]
        public bool? RemoveSpecialCharacters { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSettingsTypeApplyRatioThresholdToType
    {
        Max,
        Avg
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSettingsTypeRatioSelectionTypeType
    {
        All,
        Standard,
        Partial
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputSettingsTypeTokenSortTypeType
    {
        All,
        [EnumMember(Value = "Not Sorted")]
        NotSorted,
        Sorted
    }

    public class ParquetToJsonBodyInput
    {
        public ParquetToJsonBodyInput(string data)
        {
            this.Data = data;
        }

        [JsonProperty("validateOnly")]
        public bool? ValidateOnly { get; set; }

        [JsonProperty("skip")]
        public int? Skip { get; set; }

        [JsonProperty("take")]
        public int? Take { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class RegexMatchesBodyInput
    {
        public RegexMatchesBodyInput(string pattern, string data)
        {
            this.Pattern = pattern;
            this.Data = data;
        }

        [JsonProperty("pattern", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Pattern { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class SimpleConcatenateBodyInput
    {
        public SimpleConcatenateBodyInput(string[] data)
        {
            this.Data = data;
        }

        [JsonProperty("separator")]
        public string Separator { get; set; }

        [JsonProperty("ignoreEmpty")]
        public bool? IgnoreEmpty { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public SimpleSortOrder? SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SimpleSortOrder
    {
        ASC,
        DESC
    }

    public class SimpleDistinctBodyInput
    {
        public SimpleDistinctBodyInput(string field, JToken[] data)
        {
            this.Field = field;
            this.Data = data;
        }

        [JsonProperty("field", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Field { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public SimpleSortOrder? SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class SortObjectArrayBodyInput
    {
        public SortObjectArrayBodyInput(JToken sortOrder, JToken[] data)
        {
            this.SortOrder = sortOrder;
            this.Data = data;
        }

        [JsonProperty("sortOrder", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken SortOrder { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class SplitBodyInput
    {
        public SplitBodyInput(JToken[] splits, JToken[] data)
        {
            this.Splits = splits;
            this.Data = data;
        }

        [JsonProperty("splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Splits { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class TextToJsonBodyInput
    {
        public TextToJsonBodyInput(string data)
        {
            this.Data = data;
        }

        [JsonProperty("headerRow")]
        public bool? HeaderRow { get; set; }

        [JsonProperty("rowSeparator")]
        public string RowSeparator { get; set; }

        [JsonProperty("delimiter")]
        public string Delimiter { get; set; }

        [JsonProperty("encoding")]
        public BodyInputEncodingType? Encoding { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class TransformBodyInput
    {
        public TransformBodyInput(JToken transformations, JToken[] data)
        {
            this.Transformations = transformations;
            this.Data = data;
        }

        [JsonProperty("transformations", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken Transformations { get; set; }

        [JsonProperty("preserveAllProperties")]
        public bool? PreserveAllProperties { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("advancedOptions")]
        public AdvancedOptions AdvancedOptions { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken[] Data { get; set; }
    }

    public class XmlToJsonBodyInput
    {
        public XmlToJsonBodyInput(string data)
        {
            this.Data = data;
        }

        [JsonProperty("primaryLoopAtElement")]
        public string PrimaryLoopAtElement { get; set; }

        [JsonProperty("map")]
        public JToken Map { get; set; }

        [JsonProperty("subLoopAtElements")]
        public BodyInputSubLoopAtElementsTypeItem[] SubLoopAtElements { get; set; }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }
    }

    public class BodyInputSubLoopAtElementsTypeItem
    {
        [JsonProperty("mapName")]
        public string MapName { get; set; }

        [JsonProperty("xPathQuery")]
        public string XPathQuery { get; set; }

        [JsonProperty("map")]
        public JToken Map { get; set; }
    }

    public class ZipArchiveDecompressResponseItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("compressedSize")]
        public double CompressedSize { get; set; }

        [JsonProperty("uncompressedSize")]
        public double UncompressedSize { get; set; }

        [JsonProperty("fileContent")]
        public string FileContent { get; set; }
    }

    public class ZipArchiveDecompressBodyInput
    {
        public ZipArchiveDecompressBodyInput(string data, bool getFileContents)
        {
            this.Data = data;
            this.GetFileContents = getFileContents;
        }

        [JsonProperty("data", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Data { get; set; }

        [JsonProperty("getFileContents", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool GetFileContents { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("sortOrder")]
        public JToken SortOrder { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Advanceddataoperatio;

    public partial class WorkflowManagedActions
    {
        public AdvanceddataoperatioActions Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AdvanceddataoperatioTriggers Advanceddataoperatio(string connectionId) => new AdvanceddataoperatioTriggers(connectionId);
    }
}