//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Vena
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class VenaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<ETLJob> ETLUpload(Expression<Func<string>> modelIdPath, Expression<Func<string>> templateId, Expression<Func<string>> fileName, Expression<Func<string>> file, Expression<Func<fileTypeInput>> fileType, Expression<Func<fileEncodingInput>> fileEncoding = null)
        {
            var apiCallPath = String.Format("/models/{0}/etl/templates/{1}/upload", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["fileName"] = ExpressionConverter.Convert(fileName);
            callPayload.Queries["fileType"] = ExpressionConverter.Convert(fileType);
            callPayload.Queries["fileEncoding"] = Convert.ToString("UTF-8");
            if (fileEncoding != null)
                callPayload.Queries["fileEncoding"] = ExpressionConverter.Convert(fileEncoding);
            return new ApiConnectionAction<ETLJob>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportAttributes(Expression<Func<string>> modelIdPath, Expression<Func<bool>> lidsBodyshowHeader = null, Expression<Func<string>> lidsBodymQLQueryString = null, Expression<Func<lidsBodyfileFormatInput>> lidsBodyfileFormat = null, Expression<Func<lidsBodyfileEncodingInput>> lidsBodyfileEncoding = null)
        {
            var apiCallPath = String.Format("/models/{0}/etl/query/attributes", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lidsBody = new JObject();
            var lidsBodypropCount = 0;
            if (lidsBodyshowHeader != null)
            {
                lidsBody["showHeaders"] = ExpressionConverter.ConvertO(lidsBodyshowHeader);
                lidsBodypropCount++;
            }

            if (lidsBodymQLQueryString != null)
            {
                lidsBody["queryString"] = ExpressionConverter.ConvertO(lidsBodymQLQueryString);
                lidsBodypropCount++;
            }

            if (lidsBodyfileFormat != null)
            {
                lidsBody["format"] = ExpressionConverter.ConvertO(lidsBodyfileFormat);
                lidsBodypropCount++;
            }

            if (lidsBodyfileEncoding != null)
            {
                lidsBody["encoding"] = ExpressionConverter.ConvertO(lidsBodyfileEncoding);
                lidsBodypropCount++;
            }

            lidsBody["destination"] = "ToCSV";
            lidsBodypropCount++;
            if (lidsBodypropCount > 0)
            {
                callPayload.Body = lidsBody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportHierarchies(Expression<Func<string>> modelIdPath, Expression<Func<bool>> hierarchiesBodyshowHeader = null, Expression<Func<string>> hierarchiesBodymQLQueryString = null, Expression<Func<hierarchiesBodyfileFormatInput>> hierarchiesBodyfileFormat = null, Expression<Func<hierarchiesBodyfileEncodingInput>> hierarchiesBodyfileEncoding = null, Expression<Func<bool>> hierarchiesBodyexportMemberIDs = null)
        {
            var apiCallPath = String.Format("/models/{0}/etl/query/hierarchies", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var hierarchiesBody = new JObject();
            var hierarchiesBodypropCount = 0;
            if (hierarchiesBodyshowHeader != null)
            {
                hierarchiesBody["showHeaders"] = ExpressionConverter.ConvertO(hierarchiesBodyshowHeader);
                hierarchiesBodypropCount++;
            }

            if (hierarchiesBodymQLQueryString != null)
            {
                hierarchiesBody["queryString"] = ExpressionConverter.ConvertO(hierarchiesBodymQLQueryString);
                hierarchiesBodypropCount++;
            }

            if (hierarchiesBodyfileFormat != null)
            {
                hierarchiesBody["format"] = ExpressionConverter.ConvertO(hierarchiesBodyfileFormat);
                hierarchiesBodypropCount++;
            }

            if (hierarchiesBodyfileEncoding != null)
            {
                hierarchiesBody["encoding"] = ExpressionConverter.ConvertO(hierarchiesBodyfileEncoding);
                hierarchiesBodypropCount++;
            }

            hierarchiesBody["destination"] = "ToCSV";
            hierarchiesBodypropCount++;
            if (hierarchiesBodyexportMemberIDs != null)
            {
                hierarchiesBody["exportMemberIds"] = ExpressionConverter.ConvertO(hierarchiesBodyexportMemberIDs);
                hierarchiesBodypropCount++;
            }

            if (hierarchiesBodypropCount > 0)
            {
                callPayload.Body = hierarchiesBody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportValues(Expression<Func<string>> modelIdPath, Expression<Func<bool>> valuesBodyshowHeader = null, Expression<Func<string>> valuesBodymQLQueryString = null, Expression<Func<valuesBodyfileFormatInput>> valuesBodyfileFormat = null, Expression<Func<valuesBodyfileEncodingInput>> valuesBodyfileEncoding = null, Expression<Func<bool>> valuesBodyincludeExternalIDs = null, Expression<Func<bool>> valuesBodynamedDimensions = null)
        {
            var apiCallPath = String.Format("/models/{0}/etl/query/intersections2", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var valuesBody = new JObject();
            var valuesBodypropCount = 0;
            if (valuesBodyshowHeader != null)
            {
                valuesBody["showHeaders"] = ExpressionConverter.ConvertO(valuesBodyshowHeader);
                valuesBodypropCount++;
            }

            if (valuesBodymQLQueryString != null)
            {
                valuesBody["queryString"] = ExpressionConverter.ConvertO(valuesBodymQLQueryString);
                valuesBodypropCount++;
            }

            if (valuesBodyfileFormat != null)
            {
                valuesBody["format"] = ExpressionConverter.ConvertO(valuesBodyfileFormat);
                valuesBodypropCount++;
            }

            if (valuesBodyfileEncoding != null)
            {
                valuesBody["encoding"] = ExpressionConverter.ConvertO(valuesBodyfileEncoding);
                valuesBodypropCount++;
            }

            valuesBody["destination"] = "ToCSV";
            valuesBodypropCount++;
            if (valuesBodyincludeExternalIDs != null)
            {
                valuesBody["includeExternalId"] = ExpressionConverter.ConvertO(valuesBodyincludeExternalIDs);
                valuesBodypropCount++;
            }

            if (valuesBodynamedDimensions != null)
            {
                valuesBody["isNamedHeader"] = ExpressionConverter.ConvertO(valuesBodynamedDimensions);
                valuesBodypropCount++;
            }

            if (valuesBodypropCount > 0)
            {
                callPayload.Body = valuesBody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "vena")]
        public IBodyWorkflowAction<string> ExportLIDs(Expression<Func<string>> modelIdPath, Expression<Func<bool>> lidsBodyshowHeader = null, Expression<Func<string>> lidsBodymQLQueryString = null, Expression<Func<lidsBodyfileFormatInput>> lidsBodyfileFormat = null, Expression<Func<lidsBodyfileEncodingInput>> lidsBodyfileEncoding = null)
        {
            var apiCallPath = String.Format("/models/{0}/etl/query/lids2", ExpressionConverter.ConvertWithUrlEncoding(modelIdPath, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var lidsBody = new JObject();
            var lidsBodypropCount = 0;
            if (lidsBodyshowHeader != null)
            {
                lidsBody["showHeaders"] = ExpressionConverter.ConvertO(lidsBodyshowHeader);
                lidsBodypropCount++;
            }

            if (lidsBodymQLQueryString != null)
            {
                lidsBody["queryString"] = ExpressionConverter.ConvertO(lidsBodymQLQueryString);
                lidsBodypropCount++;
            }

            if (lidsBodyfileFormat != null)
            {
                lidsBody["format"] = ExpressionConverter.ConvertO(lidsBodyfileFormat);
                lidsBodypropCount++;
            }

            if (lidsBodyfileEncoding != null)
            {
                lidsBody["encoding"] = ExpressionConverter.ConvertO(lidsBodyfileEncoding);
                lidsBodypropCount++;
            }

            lidsBody["destination"] = "ToCSV";
            lidsBodypropCount++;
            if (lidsBodypropCount > 0)
            {
                callPayload.Body = lidsBody;
            }

            return new ApiConnectionAction<string>(callPayload);
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
    using Microsoft.Azure.Workflows.Sdk.Vena;

    public partial class WorkflowManagedActions
    {
        public VenaActions Vena(string connectionId) => new VenaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public VenaTriggers Vena(string connectionId) => new VenaTriggers(connectionId);
    }
}