//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smartcommondemanddoc
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmartcommondemanddocActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smartcommondemanddoc")]
        public IBodyWorkflowAction<GenerateDocumentResponse, ApiConnectionActionConfiguration> GenerateDocument(Expression<Func<bool>> includeDocumentData, Expression<Func<GenerateDocumentInput>> body)
        {
            var __workflow_includeDocumentData = WorkflowExpression.Compile(includeDocumentData, nameof(includeDocumentData), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GenerateDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/one/oauth2/api/v11/job/generateDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeDocumentData"] = ExpressionConverter.Convert(__workflow_includeDocumentData);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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
        public int MsgId { get; set; }

        [JsonProperty("destID")]
        public int DestId { get; set; }

        [JsonProperty("msgType")]
        public string MsgType { get; set; }

        [JsonProperty("msgText")]
        public string MsgText { get; set; }

        [JsonProperty("msgDate")]
        public string MsgDate { get; set; }

        [JsonProperty("transactionNo")]
        public int TransactionNo { get; set; }

        [JsonProperty("packageID")]
        public int PackageId { get; set; }

        [JsonProperty("batchID")]
        public int BatchId { get; set; }

        [JsonProperty("docID")]
        public int DocId { get; set; }

        [JsonProperty("channelID")]
        public int ChannelId { get; set; }
    }

    public class GenerateDocumentInput
    {
        [JsonProperty("projectId")]
        public int? ProjectId { get; set; }

        [JsonProperty("transactionData", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TransactionData { get; set; }

        [JsonProperty("batchConfigResId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int BatchConfigResId { get; set; }

        [JsonProperty("transactionRange", DefaultValueHandling = DefaultValueHandling.Include)]
        public int? TransactionRange { get; set; } = 1;

        [JsonProperty("transactionDataType", DefaultValueHandling = DefaultValueHandling.Include)]
        public GenerateDocumentInputTransactionDataTypeType? TransactionDataType { get; set; } = GenerateDocumentInputTransactionDataTypeType.ApplicationXml;

        [JsonProperty("properties")]
        public GenerateDocumentInputPropertiesTypeItem[] Properties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GenerateDocumentInputTransactionDataTypeType
    {
        [EnumMember(Value = "application/xml")]
        ApplicationXml,
        [EnumMember(Value = "application/json")]
        ApplicationJson
    }

    public class GenerateDocumentInputPropertiesTypeItem
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