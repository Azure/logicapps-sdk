//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vena
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VenaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportAttributes(Expression<Func<string>> modelIdPath, Expression<Func<LidsBodyInput>> lidsBody)
        {
            var __workflow_modelIdPath = WorkflowExpression.Compile(modelIdPath, nameof(modelIdPath), required: true);
            var __workflow_lidsBody = WorkflowExpression.Compile(lidsBody, nameof(lidsBody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/etl/query/attributes", __workflow_modelIdPath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lidsBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportHierarchies(Expression<Func<string>> modelIdPath, Expression<Func<HierarchiesBodyInput>> hierarchiesBody = null)
        {
            var __workflow_modelIdPath = WorkflowExpression.Compile(modelIdPath, nameof(modelIdPath), required: true);
            var __workflow_hierarchiesBody = WorkflowExpression.Compile(hierarchiesBody, nameof(hierarchiesBody), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/etl/query/hierarchies", __workflow_modelIdPath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_hierarchiesBody != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_hierarchiesBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportValues(Expression<Func<string>> modelIdPath, Expression<Func<ValuesBodyInput>> valuesBody)
        {
            var __workflow_modelIdPath = WorkflowExpression.Compile(modelIdPath, nameof(modelIdPath), required: true);
            var __workflow_valuesBody = WorkflowExpression.Compile(valuesBody, nameof(valuesBody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/etl/query/intersections2", __workflow_modelIdPath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_valuesBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ExportLIDs(Expression<Func<string>> modelIdPath, Expression<Func<LidsBodyInput>> lidsBody)
        {
            var __workflow_modelIdPath = WorkflowExpression.Compile(modelIdPath, nameof(modelIdPath), required: true);
            var __workflow_lidsBody = WorkflowExpression.Compile(lidsBody, nameof(lidsBody), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/models/{0}/etl/query/lids2", __workflow_modelIdPath.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_lidsBody);
                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class VenaTriggers([ConnectionName] string connectionId)
    {
    }

    public class LidsBodyInput
    {
        [JsonProperty("showHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHeader { get; set; } = false;

        [JsonProperty("queryString")]
        public string MQLQueryString { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public FileFormat? FileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.FileFormat.CSV;

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        public Encoding? FileEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.Encoding.UTF8;

        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Destination { get; set; } = "ToCSV";
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum FileFormat
    {
        CSV,
        PSV,
        TDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Encoding
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    public class HierarchiesBodyInput
    {
        [JsonProperty("showHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHeader { get; set; } = false;

        [JsonProperty("queryString")]
        public string MQLQueryString { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public FileFormat? FileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.FileFormat.CSV;

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        public Encoding? FileEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.Encoding.UTF8;

        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Destination { get; set; } = "ToCSV";

        [JsonProperty("exportMemberIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ExportMemberIDs { get; set; } = false;
    }

    public class ValuesBodyInput
    {
        [JsonProperty("showHeaders", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? ShowHeader { get; set; } = false;

        [JsonProperty("queryString")]
        public string MQLQueryString { get; set; }

        [JsonProperty("format", DefaultValueHandling = DefaultValueHandling.Include)]
        public FileFormat? FileFormat { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.FileFormat.CSV;

        [JsonProperty("encoding", DefaultValueHandling = DefaultValueHandling.Include)]
        public Encoding? FileEncoding { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Vena.Encoding.UTF8;

        [JsonProperty("destination", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Destination { get; set; } = "ToCSV";

        [JsonProperty("includeExternalId", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? IncludeExternalIDs { get; set; } = false;

        [JsonProperty("isNamedHeader", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool? NamedDimensions { get; set; } = false;
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Vena;

    public partial class WorkflowManagedActions
    {
        public VenaActions Vena(string connectionId) => new VenaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VenaTriggers Vena(string connectionId) => new VenaTriggers(connectionId);
    }
}