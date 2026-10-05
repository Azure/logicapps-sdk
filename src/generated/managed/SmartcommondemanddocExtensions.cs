//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartcommondemanddoc
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartcommondemanddocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartcommondemanddoc")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateDocument))]
        public IBodyWorkflowAction<GenerateDocumentResponse> GenerateDocument([WorkflowExpression] Func<bool> includeDocumentData, [WorkflowExpression] Func<string> bodytransactionData, [WorkflowExpression] Func<int> bodybatchConfigResId, [WorkflowExpression] Func<int> bodyprojectID = null, [WorkflowExpression] Func<int> bodytransactionRange = null, [WorkflowExpression] Func<bodytransactionDataTypeInput> bodytransactionDataType = null, [WorkflowExpression] Func<bodypropertiesInputItem[]> bodyproperties = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GenerateDocumentResponse> __BuildGenerateDocument(WorkflowValue<bool> includeDocumentData, WorkflowValue<string> bodytransactionData, WorkflowValue<int> bodybatchConfigResId, WorkflowValue<int> bodyprojectID = null, WorkflowValue<int> bodytransactionRange = null, WorkflowValue<bodytransactionDataTypeInput> bodytransactionDataType = null, WorkflowValue<bodypropertiesInputItem[]> bodyproperties = null)
        {
            WorkflowValue.Validate(includeDocumentData, nameof(includeDocumentData), required: true);
            WorkflowValue.Validate(bodytransactionData, nameof(bodytransactionData), required: true);
            WorkflowValue.Validate(bodybatchConfigResId, nameof(bodybatchConfigResId), required: true);
            WorkflowValue.Validate(bodyprojectID, nameof(bodyprojectID), required: false);
            WorkflowValue.Validate(bodytransactionRange, nameof(bodytransactionRange), required: false);
            WorkflowValue.Validate(bodytransactionDataType, nameof(bodytransactionDataType), required: false);
            WorkflowValue.Validate(bodyproperties, nameof(bodyproperties), required: false);
            return new DeferredBodyAction<GenerateDocumentResponse>(() =>
            {
                var apiCallPath = "/one/oauth2/api/v11/job/generateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDocumentData"] = ExpressionConverter.Convert(includeDocumentData);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyprojectID != null)
                {
                    body["projectId"] = ExpressionConverter.ConvertO(bodyprojectID);
                    bodypropCount++;
                }

                bodypropCount++;
                body["transactionData"] = ExpressionConverter.ConvertO(bodytransactionData);
                bodypropCount++;
                body["batchConfigResId"] = ExpressionConverter.ConvertO(bodybatchConfigResId);
                if (bodytransactionRange != null)
                {
                    if (bodytransactionRange != null)
                    {
                        body["transactionRange"] = ExpressionConverter.ConvertO(bodytransactionRange);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["transactionRange"] = 1;
                    bodypropCount++;
                }

                if (bodytransactionDataType != null)
                {
                    if (bodytransactionDataType != null)
                    {
                        body["transactionDataType"] = ExpressionConverter.ConvertO(bodytransactionDataType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["transactionDataType"] = "application/xml";
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GenerateDocumentResponse>(callPayload);
            });
        }
    }

    public class SmartcommondemanddocTriggers([ConnectionName] string connectionId)
    {
    }

    public class GenerateDocumentResponse
    {
        [JsonProperty("exceptions")]
        public GenerateDocumentResponseExceptionsTypeItem[] Exceptions { get; set; }

        [JsonProperty("previewKey")]
        public string PreviewKey { get; set; }

        [JsonProperty("numberTransactions")]
        public int NumberTransactions { get; set; }

        [JsonProperty("dataModelValuesLocation")]
        public string DataModelValuesLocation { get; set; }

        [JsonProperty("envelopes")]
        public GenerateDocumentResponseEnvelopesTypeItem[] Envelopes { get; set; }

        [JsonProperty("jobMessages")]
        public GenerateDocumentResponseJobMessagesTypeItem[] JobMessages { get; set; }
    }

    public class GenerateDocumentResponseExceptionsTypeItem
    {
        [JsonProperty("classId")]
        public int ClassId { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("className")]
        public string ClassName { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }

    public class GenerateDocumentResponseEnvelopesTypeItem
    {
        [JsonProperty("primaryChannel")]
        public GenerateDocumentResponseEnvelopesTypeItemPrimaryChannelType PrimaryChannel { get; set; }

        [JsonProperty("enclosureChannels")]
        public GenerateDocumentResponseEnvelopesTypeItemEnclosureChannelsTypeItem[] EnclosureChannels { get; set; }
    }

    public class GenerateDocumentResponseEnvelopesTypeItemPrimaryChannelType
    {
        [JsonProperty("startPage")]
        public int StartPage { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("channelType")]
        public int ChannelType { get; set; }

        [JsonProperty("channelName")]
        public string ChannelName { get; set; }

        [JsonProperty("properties")]
        public GenerateDocumentResponseEnvelopesTypeItemPrimaryChannelTypePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        [JsonProperty("partLocation")]
        public string PartLocation { get; set; }
    }

    public class GenerateDocumentResponseEnvelopesTypeItemPrimaryChannelTypePropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GenerateDocumentResponseEnvelopesTypeItemEnclosureChannelsTypeItem
    {
        [JsonProperty("startPage")]
        public int StartPage { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("channelType")]
        public int ChannelType { get; set; }

        [JsonProperty("channelName")]
        public string ChannelName { get; set; }

        [JsonProperty("properties")]
        public GenerateDocumentResponseEnvelopesTypeItemEnclosureChannelsTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("documentName")]
        public string DocumentName { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        [JsonProperty("partLocation")]
        public string PartLocation { get; set; }
    }

    public class GenerateDocumentResponseEnvelopesTypeItemEnclosureChannelsTypeItemPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GenerateDocumentResponseJobMessagesTypeItem
    {
        [JsonProperty("args")]
        public string[] Args { get; set; }

        [JsonProperty("msgID")]
        public int MsgID { get; set; }

        [JsonProperty("destID")]
        public int DestID { get; set; }

        [JsonProperty("msgType")]
        public string MsgType { get; set; }

        [JsonProperty("msgText")]
        public string MsgText { get; set; }

        [JsonProperty("msgDate")]
        public string MsgDate { get; set; }

        [JsonProperty("transactionNo")]
        public int TransactionNo { get; set; }

        [JsonProperty("packageID")]
        public int PackageID { get; set; }

        [JsonProperty("batchID")]
        public int BatchID { get; set; }

        [JsonProperty("docID")]
        public int DocID { get; set; }

        [JsonProperty("channelID")]
        public int ChannelID { get; set; }
    }

    public enum bodytransactionDataTypeInput
    {
        [EnumMember(Value = "application/xml")]
        ApplicationXml,
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public class bodypropertiesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smartcommondemanddoc;

    public partial class WorkflowManagedActions
    {
        public SmartcommondemanddocActions Smartcommondemanddoc(string connectionId) => new SmartcommondemanddocActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmartcommondemanddocTriggers Smartcommondemanddoc(string connectionId) => new SmartcommondemanddocTriggers(connectionId);
    }
}
