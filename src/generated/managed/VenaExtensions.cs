//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Vena
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VenaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<ETLJob> ETLUpload([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<fileTypeInput> fileType, [WorkflowExpression] Func<fileEncodingInput> fileEncoding = null)
        {
            SourceExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(file, nameof(file), required: true);
            SourceExpression.Validate(fileType, nameof(fileType), required: true);
            SourceExpression.Validate(fileEncoding, nameof(fileEncoding), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/templates/{1}/upload", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelIdPath, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["fileName"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Queries["fileType"] = SourceExpressionConverter.Convert(fileType);
                callPayload.Queries["fileEncoding"] = Convert.ToString("UTF-8");
                if (fileEncoding != null)
                    callPayload.Queries["fileEncoding"] = SourceExpressionConverter.Convert(fileEncoding);
                return callPayload;
            }

            return new ApiConnectionAction<ETLJob>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportAttributes([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> lidsBodyshowHeader = null, [WorkflowExpression] Func<string> lidsBodymQLQueryString = null, [WorkflowExpression] Func<lidsBodyfileFormatInput> lidsBodyfileFormat = null, [WorkflowExpression] Func<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            SourceExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            SourceExpression.Validate(lidsBodyshowHeader, nameof(lidsBodyshowHeader), required: false);
            SourceExpression.Validate(lidsBodymQLQueryString, nameof(lidsBodymQLQueryString), required: false);
            SourceExpression.Validate(lidsBodyfileFormat, nameof(lidsBodyfileFormat), required: false);
            SourceExpression.Validate(lidsBodyfileEncoding, nameof(lidsBodyfileEncoding), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/attributes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lidsBody = new JObject();
                var lidsBodypropCount = 0;
                if (lidsBodyshowHeader != null)
                {
                    if (lidsBodyshowHeader != null)
                    {
                        lidsBody["showHeaders"] = SourceExpressionConverter.ConvertToken(lidsBodyshowHeader);
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
                    lidsBody["queryString"] = SourceExpressionConverter.ConvertToken(lidsBodymQLQueryString);
                    lidsBodypropCount++;
                }

                if (lidsBodyfileFormat != null)
                {
                    if (lidsBodyfileFormat != null)
                    {
                        lidsBody["format"] = SourceExpressionConverter.Convert(lidsBodyfileFormat);
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
                        lidsBody["encoding"] = SourceExpressionConverter.Convert(lidsBodyfileEncoding);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportHierarchies([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> hierarchiesBodyshowHeader = null, [WorkflowExpression] Func<string> hierarchiesBodymQLQueryString = null, [WorkflowExpression] Func<hierarchiesBodyfileFormatInput> hierarchiesBodyfileFormat = null, [WorkflowExpression] Func<hierarchiesBodyfileEncodingInput> hierarchiesBodyfileEncoding = null, [WorkflowExpression] Func<bool> hierarchiesBodyexportMemberIDs = null)
        {
            SourceExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            SourceExpression.Validate(hierarchiesBodyshowHeader, nameof(hierarchiesBodyshowHeader), required: false);
            SourceExpression.Validate(hierarchiesBodymQLQueryString, nameof(hierarchiesBodymQLQueryString), required: false);
            SourceExpression.Validate(hierarchiesBodyfileFormat, nameof(hierarchiesBodyfileFormat), required: false);
            SourceExpression.Validate(hierarchiesBodyfileEncoding, nameof(hierarchiesBodyfileEncoding), required: false);
            SourceExpression.Validate(hierarchiesBodyexportMemberIDs, nameof(hierarchiesBodyexportMemberIDs), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/hierarchies", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hierarchiesBody = new JObject();
                var hierarchiesBodypropCount = 0;
                if (hierarchiesBodyshowHeader != null)
                {
                    if (hierarchiesBodyshowHeader != null)
                    {
                        hierarchiesBody["showHeaders"] = SourceExpressionConverter.ConvertToken(hierarchiesBodyshowHeader);
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
                    hierarchiesBody["queryString"] = SourceExpressionConverter.ConvertToken(hierarchiesBodymQLQueryString);
                    hierarchiesBodypropCount++;
                }

                if (hierarchiesBodyfileFormat != null)
                {
                    if (hierarchiesBodyfileFormat != null)
                    {
                        hierarchiesBody["format"] = SourceExpressionConverter.Convert(hierarchiesBodyfileFormat);
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
                        hierarchiesBody["encoding"] = SourceExpressionConverter.Convert(hierarchiesBodyfileEncoding);
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
                        hierarchiesBody["exportMemberIds"] = SourceExpressionConverter.ConvertToken(hierarchiesBodyexportMemberIDs);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportValues([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> valuesBodyshowHeader = null, [WorkflowExpression] Func<string> valuesBodymQLQueryString = null, [WorkflowExpression] Func<valuesBodyfileFormatInput> valuesBodyfileFormat = null, [WorkflowExpression] Func<valuesBodyfileEncodingInput> valuesBodyfileEncoding = null, [WorkflowExpression] Func<bool> valuesBodyincludeExternalIDs = null, [WorkflowExpression] Func<bool> valuesBodynamedDimensions = null)
        {
            SourceExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            SourceExpression.Validate(valuesBodyshowHeader, nameof(valuesBodyshowHeader), required: false);
            SourceExpression.Validate(valuesBodymQLQueryString, nameof(valuesBodymQLQueryString), required: false);
            SourceExpression.Validate(valuesBodyfileFormat, nameof(valuesBodyfileFormat), required: false);
            SourceExpression.Validate(valuesBodyfileEncoding, nameof(valuesBodyfileEncoding), required: false);
            SourceExpression.Validate(valuesBodyincludeExternalIDs, nameof(valuesBodyincludeExternalIDs), required: false);
            SourceExpression.Validate(valuesBodynamedDimensions, nameof(valuesBodynamedDimensions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/intersections2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var valuesBody = new JObject();
                var valuesBodypropCount = 0;
                if (valuesBodyshowHeader != null)
                {
                    if (valuesBodyshowHeader != null)
                    {
                        valuesBody["showHeaders"] = SourceExpressionConverter.ConvertToken(valuesBodyshowHeader);
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
                    valuesBody["queryString"] = SourceExpressionConverter.ConvertToken(valuesBodymQLQueryString);
                    valuesBodypropCount++;
                }

                if (valuesBodyfileFormat != null)
                {
                    if (valuesBodyfileFormat != null)
                    {
                        valuesBody["format"] = SourceExpressionConverter.Convert(valuesBodyfileFormat);
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
                        valuesBody["encoding"] = SourceExpressionConverter.Convert(valuesBodyfileEncoding);
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
                        valuesBody["includeExternalId"] = SourceExpressionConverter.ConvertToken(valuesBodyincludeExternalIDs);
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
                        valuesBody["isNamedHeader"] = SourceExpressionConverter.ConvertToken(valuesBodynamedDimensions);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportLIDs([WorkflowExpression] Func<string> modelIdPath, [WorkflowExpression] Func<bool> lidsBodyshowHeader = null, [WorkflowExpression] Func<string> lidsBodymQLQueryString = null, [WorkflowExpression] Func<lidsBodyfileFormatInput> lidsBodyfileFormat = null, [WorkflowExpression] Func<lidsBodyfileEncodingInput> lidsBodyfileEncoding = null)
        {
            SourceExpression.Validate(modelIdPath, nameof(modelIdPath), required: true);
            SourceExpression.Validate(lidsBodyshowHeader, nameof(lidsBodyshowHeader), required: false);
            SourceExpression.Validate(lidsBodymQLQueryString, nameof(lidsBodymQLQueryString), required: false);
            SourceExpression.Validate(lidsBodyfileFormat, nameof(lidsBodyfileFormat), required: false);
            SourceExpression.Validate(lidsBodyfileEncoding, nameof(lidsBodyfileEncoding), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/models/{0}/etl/query/lids2", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(modelIdPath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var lidsBody = new JObject();
                var lidsBodypropCount = 0;
                if (lidsBodyshowHeader != null)
                {
                    if (lidsBodyshowHeader != null)
                    {
                        lidsBody["showHeaders"] = SourceExpressionConverter.ConvertToken(lidsBodyshowHeader);
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
                    lidsBody["queryString"] = SourceExpressionConverter.ConvertToken(lidsBodymQLQueryString);
                    lidsBodypropCount++;
                }

                if (lidsBodyfileFormat != null)
                {
                    if (lidsBodyfileFormat != null)
                    {
                        lidsBody["format"] = SourceExpressionConverter.Convert(lidsBodyfileFormat);
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
                        lidsBody["encoding"] = SourceExpressionConverter.Convert(lidsBodyfileEncoding);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
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

    public enum fileTypeInput
    {
        CSV,
        PSV,
        TDF
    }

    public enum fileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    public enum lidsBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

    public enum lidsBodyfileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    public enum hierarchiesBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

    public enum hierarchiesBodyfileEncodingInput
    {
        [EnumMember(Value = "UTF-8")]
        UTF8,
        [EnumMember(Value = "UTF-16")]
        UTF16,
        Cp1252
    }

    public enum valuesBodyfileFormatInput
    {
        CSV,
        PSV,
        TDF
    }

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