//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vena
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VenaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        [WorkflowExpressionFactory(nameof(__BuildETLUpload))]
        public IBodyWorkflowAction<ETLJob> ETLUpload([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<fileTypeInput> fileType, [WorkflowExpression] Func<fileEncodingInput> fileEncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ETLJob> __BuildETLUpload(WorkflowExpression<string> modelIdPath, WorkflowExpression<string> templateId, WorkflowExpression<string> fileName, WorkflowExpression<string> file, WorkflowExpression<fileTypeInput> fileType, WorkflowExpression<fileEncodingInput> fileEncoding = null)
        {
            WorkflowExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(fileName, nameof(fileName), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(fileType, nameof(fileType), required: true);
            WorkflowExpression.Validate(fileEncoding, nameof(fileEncoding), required: false);
            return new DeferredBodyAction<ETLJob>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/templates/{1}/upload", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
                callPayload.Queries["fileType"] = ExpressionConverter.Convert(fileType);
                callPayload.Queries["fileEncoding"] = Convert.ToString("UTF-8");
                if (fileEncoding != null)
                    callPayload.Queries["fileEncoding"] = ExpressionConverter.Convert(fileEncoding);
                return new ApiConnectionAction<ETLJob>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        [WorkflowExpressionFactory(nameof(__BuildExportAttributes))]
        public IBodyWorkflowAction<string> ExportAttributes([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> lidsBodyshowHeader = null, [WorkflowExpression] Func<string> lidsBodymQLQueryString = null, [WorkflowExpression] Func<lidsBodyfileFormatInput> lidsBodyfileFormat = null, [WorkflowExpression] Func<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportAttributes(WorkflowExpression<string> modelIdPath, WorkflowExpression<bool> lidsBodyshowHeader = null, WorkflowExpression<string> lidsBodymQLQueryString = null, WorkflowExpression<lidsBodyfileFormatInput> lidsBodyfileFormat = null, WorkflowExpression<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            WorkflowExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            WorkflowExpression.Validate(lidsBodyshowHeader, nameof(lidsBodyshowHeader), required: false);
            WorkflowExpression.Validate(lidsBodymQLQueryString, nameof(lidsBodymQLQueryString), required: false);
            WorkflowExpression.Validate(lidsBodyfileFormat, nameof(lidsBodyfileFormat), required: false);
            WorkflowExpression.Validate(lidsBodyfileEncoding, nameof(lidsBodyfileEncoding), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/attributes", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lidsBody = new JObject();
                var lidsBodypropCount = 0;
                if (lidsBodyshowHeader != null)
                {
                    if (lidsBodyshowHeader != null)
                    {
                        lidsBody["showHeaders"] = ExpressionConverter.ConvertO(lidsBodyshowHeader);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["showHeaders"] = false;
                    lidsBodypropCount++;
                }

                if (lidsBodymQLQueryString != null)
                {
                    lidsBody["queryString"] = ExpressionConverter.ConvertO(lidsBodymQLQueryString);
                    lidsBodypropCount++;
                }

                if (lidsBodyfileFormat != null)
                {
                    if (lidsBodyfileFormat != null)
                    {
                        lidsBody["format"] = ExpressionConverter.ConvertO(lidsBodyfileFormat);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["format"] = "CSV";
                    lidsBodypropCount++;
                }

                if (lidsBodyfileEncoding != null)
                {
                    if (lidsBodyfileEncoding != null)
                    {
                        lidsBody["encoding"] = ExpressionConverter.ConvertO(lidsBodyfileEncoding);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["encoding"] = "UTF-8";
                    lidsBodypropCount++;
                }

                lidsBody["destination"] = "ToCSV";
                lidsBodypropCount++;
                if (lidsBodypropCount > 0)
                {
                    callPayload.Body = lidsBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        [WorkflowExpressionFactory(nameof(__BuildExportHierarchies))]
        public IBodyWorkflowAction<string> ExportHierarchies([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> hierarchiesBodyshowHeader = null, [WorkflowExpression] Func<string> hierarchiesBodymQLQueryString = null, [WorkflowExpression] Func<hierarchiesBodyfileFormatInput> hierarchiesBodyfileFormat = null, [WorkflowExpression] Func<hierarchiesBodyfileEncodingInput> hierarchiesBodyfileEncoding = null, [WorkflowExpression] Func<bool> hierarchiesBodyexportMemberIDs = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportHierarchies(WorkflowExpression<string> modelIdPath, WorkflowExpression<bool> hierarchiesBodyshowHeader = null, WorkflowExpression<string> hierarchiesBodymQLQueryString = null, WorkflowExpression<hierarchiesBodyfileFormatInput> hierarchiesBodyfileFormat = null, WorkflowExpression<hierarchiesBodyfileEncodingInput> hierarchiesBodyfileEncoding = null, WorkflowExpression<bool> hierarchiesBodyexportMemberIDs = null)
        {
            WorkflowExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            WorkflowExpression.Validate(hierarchiesBodyshowHeader, nameof(hierarchiesBodyshowHeader), required: false);
            WorkflowExpression.Validate(hierarchiesBodymQLQueryString, nameof(hierarchiesBodymQLQueryString), required: false);
            WorkflowExpression.Validate(hierarchiesBodyfileFormat, nameof(hierarchiesBodyfileFormat), required: false);
            WorkflowExpression.Validate(hierarchiesBodyfileEncoding, nameof(hierarchiesBodyfileEncoding), required: false);
            WorkflowExpression.Validate(hierarchiesBodyexportMemberIDs, nameof(hierarchiesBodyexportMemberIDs), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/hierarchies", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hierarchiesBody = new JObject();
                var hierarchiesBodypropCount = 0;
                if (hierarchiesBodyshowHeader != null)
                {
                    if (hierarchiesBodyshowHeader != null)
                    {
                        hierarchiesBody["showHeaders"] = ExpressionConverter.ConvertO(hierarchiesBodyshowHeader);
                        hierarchiesBodypropCount++;
                    }

                    hierarchiesBodypropCount++;
                }
                else
                {
                    hierarchiesBody["showHeaders"] = false;
                    hierarchiesBodypropCount++;
                }

                if (hierarchiesBodymQLQueryString != null)
                {
                    hierarchiesBody["queryString"] = ExpressionConverter.ConvertO(hierarchiesBodymQLQueryString);
                    hierarchiesBodypropCount++;
                }

                if (hierarchiesBodyfileFormat != null)
                {
                    if (hierarchiesBodyfileFormat != null)
                    {
                        hierarchiesBody["format"] = ExpressionConverter.ConvertO(hierarchiesBodyfileFormat);
                        hierarchiesBodypropCount++;
                    }

                    hierarchiesBodypropCount++;
                }
                else
                {
                    hierarchiesBody["format"] = "CSV";
                    hierarchiesBodypropCount++;
                }

                if (hierarchiesBodyfileEncoding != null)
                {
                    if (hierarchiesBodyfileEncoding != null)
                    {
                        hierarchiesBody["encoding"] = ExpressionConverter.ConvertO(hierarchiesBodyfileEncoding);
                        hierarchiesBodypropCount++;
                    }

                    hierarchiesBodypropCount++;
                }
                else
                {
                    hierarchiesBody["encoding"] = "UTF-8";
                    hierarchiesBodypropCount++;
                }

                hierarchiesBody["destination"] = "ToCSV";
                hierarchiesBodypropCount++;
                if (hierarchiesBodyexportMemberIDs != null)
                {
                    if (hierarchiesBodyexportMemberIDs != null)
                    {
                        hierarchiesBody["exportMemberIds"] = ExpressionConverter.ConvertO(hierarchiesBodyexportMemberIDs);
                        hierarchiesBodypropCount++;
                    }

                    hierarchiesBodypropCount++;
                }
                else
                {
                    hierarchiesBody["exportMemberIds"] = false;
                    hierarchiesBodypropCount++;
                }

                if (hierarchiesBodypropCount > 0)
                {
                    callPayload.Body = hierarchiesBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        [WorkflowExpressionFactory(nameof(__BuildExportValues))]
        public IBodyWorkflowAction<string> ExportValues([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> valuesBodyshowHeader = null, [WorkflowExpression] Func<string> valuesBodymQLQueryString = null, [WorkflowExpression] Func<valuesBodyfileFormatInput> valuesBodyfileFormat = null, [WorkflowExpression] Func<valuesBodyfileEncodingInput> valuesBodyfileEncoding = null, [WorkflowExpression] Func<bool> valuesBodyincludeExternalIDs = null, [WorkflowExpression] Func<bool> valuesBodynamedDimensions = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportValues(WorkflowExpression<string> modelIdPath, WorkflowExpression<bool> valuesBodyshowHeader = null, WorkflowExpression<string> valuesBodymQLQueryString = null, WorkflowExpression<valuesBodyfileFormatInput> valuesBodyfileFormat = null, WorkflowExpression<valuesBodyfileEncodingInput> valuesBodyfileEncoding = null, WorkflowExpression<bool> valuesBodyincludeExternalIDs = null, WorkflowExpression<bool> valuesBodynamedDimensions = null)
        {
            WorkflowExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            WorkflowExpression.Validate(valuesBodyshowHeader, nameof(valuesBodyshowHeader), required: false);
            WorkflowExpression.Validate(valuesBodymQLQueryString, nameof(valuesBodymQLQueryString), required: false);
            WorkflowExpression.Validate(valuesBodyfileFormat, nameof(valuesBodyfileFormat), required: false);
            WorkflowExpression.Validate(valuesBodyfileEncoding, nameof(valuesBodyfileEncoding), required: false);
            WorkflowExpression.Validate(valuesBodyincludeExternalIDs, nameof(valuesBodyincludeExternalIDs), required: false);
            WorkflowExpression.Validate(valuesBodynamedDimensions, nameof(valuesBodynamedDimensions), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/intersections2", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var valuesBody = new JObject();
                var valuesBodypropCount = 0;
                if (valuesBodyshowHeader != null)
                {
                    if (valuesBodyshowHeader != null)
                    {
                        valuesBody["showHeaders"] = ExpressionConverter.ConvertO(valuesBodyshowHeader);
                        valuesBodypropCount++;
                    }

                    valuesBodypropCount++;
                }
                else
                {
                    valuesBody["showHeaders"] = false;
                    valuesBodypropCount++;
                }

                if (valuesBodymQLQueryString != null)
                {
                    valuesBody["queryString"] = ExpressionConverter.ConvertO(valuesBodymQLQueryString);
                    valuesBodypropCount++;
                }

                if (valuesBodyfileFormat != null)
                {
                    if (valuesBodyfileFormat != null)
                    {
                        valuesBody["format"] = ExpressionConverter.ConvertO(valuesBodyfileFormat);
                        valuesBodypropCount++;
                    }

                    valuesBodypropCount++;
                }
                else
                {
                    valuesBody["format"] = "CSV";
                    valuesBodypropCount++;
                }

                if (valuesBodyfileEncoding != null)
                {
                    if (valuesBodyfileEncoding != null)
                    {
                        valuesBody["encoding"] = ExpressionConverter.ConvertO(valuesBodyfileEncoding);
                        valuesBodypropCount++;
                    }

                    valuesBodypropCount++;
                }
                else
                {
                    valuesBody["encoding"] = "UTF-8";
                    valuesBodypropCount++;
                }

                valuesBody["destination"] = "ToCSV";
                valuesBodypropCount++;
                if (valuesBodyincludeExternalIDs != null)
                {
                    if (valuesBodyincludeExternalIDs != null)
                    {
                        valuesBody["includeExternalId"] = ExpressionConverter.ConvertO(valuesBodyincludeExternalIDs);
                        valuesBodypropCount++;
                    }

                    valuesBodypropCount++;
                }
                else
                {
                    valuesBody["includeExternalId"] = false;
                    valuesBodypropCount++;
                }

                if (valuesBodynamedDimensions != null)
                {
                    if (valuesBodynamedDimensions != null)
                    {
                        valuesBody["isNamedHeader"] = ExpressionConverter.ConvertO(valuesBodynamedDimensions);
                        valuesBodypropCount++;
                    }

                    valuesBodypropCount++;
                }
                else
                {
                    valuesBody["isNamedHeader"] = false;
                    valuesBodypropCount++;
                }

                if (valuesBodypropCount > 0)
                {
                    callPayload.Body = valuesBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        [WorkflowExpressionFactory(nameof(__BuildExportLIDs))]
        public IBodyWorkflowAction<string> ExportLIDs([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> lidsBodyshowHeader = null, [WorkflowExpression] Func<string> lidsBodymQLQueryString = null, [WorkflowExpression] Func<lidsBodyfileFormatInput> lidsBodyfileFormat = null, [WorkflowExpression] Func<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildExportLIDs(WorkflowExpression<string> modelIdPath, WorkflowExpression<bool> lidsBodyshowHeader = null, WorkflowExpression<string> lidsBodymQLQueryString = null, WorkflowExpression<lidsBodyfileFormatInput> lidsBodyfileFormat = null, WorkflowExpression<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            WorkflowExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            WorkflowExpression.Validate(lidsBodyshowHeader, nameof(lidsBodyshowHeader), required: false);
            WorkflowExpression.Validate(lidsBodymQLQueryString, nameof(lidsBodymQLQueryString), required: false);
            WorkflowExpression.Validate(lidsBodyfileFormat, nameof(lidsBodyfileFormat), required: false);
            WorkflowExpression.Validate(lidsBodyfileEncoding, nameof(lidsBodyfileEncoding), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/lids2", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lidsBody = new JObject();
                var lidsBodypropCount = 0;
                if (lidsBodyshowHeader != null)
                {
                    if (lidsBodyshowHeader != null)
                    {
                        lidsBody["showHeaders"] = ExpressionConverter.ConvertO(lidsBodyshowHeader);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["showHeaders"] = false;
                    lidsBodypropCount++;
                }

                if (lidsBodymQLQueryString != null)
                {
                    lidsBody["queryString"] = ExpressionConverter.ConvertO(lidsBodymQLQueryString);
                    lidsBodypropCount++;
                }

                if (lidsBodyfileFormat != null)
                {
                    if (lidsBodyfileFormat != null)
                    {
                        lidsBody["format"] = ExpressionConverter.ConvertO(lidsBodyfileFormat);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["format"] = "CSV";
                    lidsBodypropCount++;
                }

                if (lidsBodyfileEncoding != null)
                {
                    if (lidsBodyfileEncoding != null)
                    {
                        lidsBody["encoding"] = ExpressionConverter.ConvertO(lidsBodyfileEncoding);
                        lidsBodypropCount++;
                    }

                    lidsBodypropCount++;
                }
                else
                {
                    lidsBody["encoding"] = "UTF-8";
                    lidsBodypropCount++;
                }

                lidsBody["destination"] = "ToCSV";
                lidsBodypropCount++;
                if (lidsBodypropCount > 0)
                {
                    callPayload.Body = lidsBody;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }
    }

    public class VenaTriggers([ConnectionName] string connectionId)
    {
    }

    public class ETLJob
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("pauseRequested")]
        public bool PauseRequested { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("lockProperty")]
        public string LockProperty { get; set; }

        [JsonProperty("resumable")]
        public bool Resumable { get; set; }

        [JsonProperty("user")]
        public JToken User { get; set; }

        [JsonProperty("createdDate")]
        public int CreatedDate { get; set; }

        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("shortMessage")]
        public string ShortMessage { get; set; }

        [JsonProperty("saveJob")]
        public bool SaveJob { get; set; }

        [JsonProperty("log")]
        public ETLJobLogTypeItem[] Log { get; set; }

        [JsonProperty("lockId")]
        public string LockId { get; set; }

        [JsonProperty("rollbackRequired")]
        public bool RollbackRequired { get; set; }

        [JsonProperty("cancelRequested")]
        public bool CancelRequested { get; set; }

        [JsonProperty("updatedDate")]
        public int UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("validationResults")]
        public string ValidationResults { get; set; }

        [JsonProperty("attributes")]
        public string[] Attributes { get; set; }

        [JsonProperty("currentStepNumber")]
        public int CurrentStepNumber { get; set; }

        [JsonProperty("numCalcOverwrite")]
        public int NumCalcOverwrite { get; set; }

        [JsonProperty("metadata")]
        public ETLMetadata Metadata { get; set; }
    }

    public class ETLJobLogTypeItem
    {
        [JsonProperty("date")]
        public int Date { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class ETLMetadata
    {
        [JsonProperty("schemaVersion")]
        public int SchemaVersion { get; set; }

        [JsonProperty("steps")]
        public ETLStep[] Steps { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ETLStep
    {
        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("stepType")]
        public string StepType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fileTypeInput
    {
        CSV,
        PSV,
        TDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum fileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum lidsBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum lidsBodyfileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum hierarchiesBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum hierarchiesBodyfileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum valuesBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum valuesBodyfileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
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