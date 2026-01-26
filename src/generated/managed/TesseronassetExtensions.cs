//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasset
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronassetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<AddAssetResponse> AddAsset(Expression<Func<int>> bodyAssetTemplateId, Expression<Func<bodyFieldsInputItem[]>> bodyFields, Expression<Func<int>> bodyEnterpriseId = null, Expression<Func<int>> bodyStatus = null, Expression<Func<string>> bodyReferenceNumber = null, Expression<Func<int>> bodyDocumentationId = null, Expression<Func<string>> bodyDocumentationName = null, Expression<Func<string>> bodyLiveCycleName = null, Expression<Func<bodyAttachmentsInputItem[]>> bodyAttachments = null)
        {
            var apiCallPath = "/AddAsset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyAssetTemplateId);
            if (bodyEnterpriseId != null)
            {
                body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyEnterpriseId);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyReferenceNumber != null)
            {
                body["ReferenceNumber"] = ExpressionConverter.ConvertO(bodyReferenceNumber);
                bodypropCount++;
            }

            if (bodyDocumentationId != null)
            {
                body["DocumentationId"] = ExpressionConverter.ConvertO(bodyDocumentationId);
                bodypropCount++;
            }

            if (bodyDocumentationName != null)
            {
                body["DocumentationName"] = ExpressionConverter.ConvertO(bodyDocumentationName);
                bodypropCount++;
            }

            if (bodyLiveCycleName != null)
            {
                body["LiveCycleName"] = ExpressionConverter.ConvertO(bodyLiveCycleName);
                bodypropCount++;
            }

            bodypropCount++;
            body["Fields"] = ExpressionConverter.ConvertO(bodyFields);
            if (bodyAttachments != null)
            {
                body["Attachments"] = ExpressionConverter.ConvertO(bodyAttachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<int>> bodyAssetId, Expression<Func<int>> bodyAssetTemplateId, Expression<Func<bodyFieldsInputItem[]>> bodyFields, Expression<Func<string>> bodyReferenceNumber = null, Expression<Func<int>> bodyEnterpriseId = null, Expression<Func<int>> bodyDocumentationId = null, Expression<Func<string>> bodyDocumentationName = null, Expression<Func<int>> bodyStatus = null, Expression<Func<string>> bodyLiveCycleState = null, Expression<Func<bodyAttachmentsInputItem[]>> bodyAttachments = null)
        {
            var apiCallPath = "/UpdateAsset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetId"] = ExpressionConverter.ConvertO(bodyAssetId);
            bodypropCount++;
            body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyAssetTemplateId);
            if (bodyReferenceNumber != null)
            {
                body["ReferenceNumber"] = ExpressionConverter.ConvertO(bodyReferenceNumber);
                bodypropCount++;
            }

            if (bodyEnterpriseId != null)
            {
                body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyEnterpriseId);
                bodypropCount++;
            }

            if (bodyDocumentationId != null)
            {
                body["DocumentationId"] = ExpressionConverter.ConvertO(bodyDocumentationId);
                bodypropCount++;
            }

            if (bodyDocumentationName != null)
            {
                body["DocumentationName"] = ExpressionConverter.ConvertO(bodyDocumentationName);
                bodypropCount++;
            }

            if (bodyStatus != null)
            {
                body["Status"] = ExpressionConverter.ConvertO(bodyStatus);
                bodypropCount++;
            }

            if (bodyLiveCycleState != null)
            {
                body["LiveCycleState"] = ExpressionConverter.ConvertO(bodyLiveCycleState);
                bodypropCount++;
            }

            bodypropCount++;
            body["Fields"] = ExpressionConverter.ConvertO(bodyFields);
            if (bodyAttachments != null)
            {
                body["Attachments"] = ExpressionConverter.ConvertO(bodyAttachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetSearchResponse> GetAssetSearch(Expression<Func<int>> bodySkip, Expression<Func<int>> bodyPageSize, Expression<Func<int>> bodyAssetTemplateId, Expression<Func<string>> bodysearch = null, Expression<Func<int>> bodyEnterpriseId = null, Expression<Func<int>> bodyDocumentationId = null, Expression<Func<int>> bodyAssetStatus = null, Expression<Func<bool>> bodyIsDeprecated = null, Expression<Func<string>> bodyLastUpdateDateStart = null, Expression<Func<string>> bodyLastUpdateDateEnd = null, Expression<Func<int>> bodyResponseType = null, Expression<Func<bool>> bodyIncludeAccessAuditedFieldValues = null)
        {
            var apiCallPath = "/GetAssetSearch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Skip"] = ExpressionConverter.ConvertO(bodySkip);
            bodypropCount++;
            body["PageSize"] = ExpressionConverter.ConvertO(bodyPageSize);
            if (bodysearch != null)
            {
                body["search"] = ExpressionConverter.ConvertO(bodysearch);
                bodypropCount++;
            }

            bodypropCount++;
            body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyAssetTemplateId);
            if (bodyEnterpriseId != null)
            {
                body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyEnterpriseId);
                bodypropCount++;
            }

            if (bodyDocumentationId != null)
            {
                body["DocumentationId"] = ExpressionConverter.ConvertO(bodyDocumentationId);
                bodypropCount++;
            }

            if (bodyAssetStatus != null)
            {
                body["AssetStatus"] = ExpressionConverter.ConvertO(bodyAssetStatus);
                bodypropCount++;
            }

            if (bodyIsDeprecated != null)
            {
                body["IsDeprecated"] = ExpressionConverter.ConvertO(bodyIsDeprecated);
                bodypropCount++;
            }

            if (bodyLastUpdateDateStart != null)
            {
                body["LastUpdateDateStart"] = ExpressionConverter.ConvertO(bodyLastUpdateDateStart);
                bodypropCount++;
            }

            if (bodyLastUpdateDateEnd != null)
            {
                body["LastUpdateDateEnd"] = ExpressionConverter.ConvertO(bodyLastUpdateDateEnd);
                bodypropCount++;
            }

            if (bodyResponseType != null)
            {
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
                bodypropCount++;
            }

            if (bodyIncludeAccessAuditedFieldValues != null)
            {
                body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(bodyIncludeAccessAuditedFieldValues);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAssetSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetInfoResponse> GetAssetInfo(Expression<Func<int>> bodyAssetId, Expression<Func<bool>> bodyIncludeAccessAuditedFieldValues = null, Expression<Func<int>> bodyResponseType = null)
        {
            var apiCallPath = "/GetAssetInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetId"] = ExpressionConverter.ConvertO(bodyAssetId);
            if (bodyIncludeAccessAuditedFieldValues != null)
            {
                body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(bodyIncludeAccessAuditedFieldValues);
                bodypropCount++;
            }

            if (bodyResponseType != null)
            {
                body["ResponseType"] = ExpressionConverter.ConvertO(bodyResponseType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAssetInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetConfigResponse> GetConfig(Expression<Func<int>> bodyAssetTemplateId, Expression<Func<int>> bodyEnterpriseId = null)
        {
            var apiCallPath = "/GetConfig";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyAssetTemplateId);
            if (bodyEnterpriseId != null)
            {
                body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyEnterpriseId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetConfigResponse>(callPayload);
        }
    }

    public class TesseronassetTriggers([ConnectionName] string connectionId)
    {
    }

    public class AddAssetResponse
    {
        public int AssetId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class bodyFieldsInputItem
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
    }

    public class bodyAttachmentsInputItem
    {
        public string FileName { get; set; }
        public string Data { get; set; }
    }

    public class UpdateAssetResponse
    {
        public int AssetId { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetAssetSearchResponse
    {
        public GetAssetSearchResponseResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }
        public int Filtered { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetAssetSearchResponseResultsTypeItem
    {
        public int AssetId { get; set; }
        public int AssetTemplateId { get; set; }
        public string ReferenceNumber { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public int DocumentationId { get; set; }
        public string DocumentationName { get; set; }
        public int Status { get; set; }
        public string LiveCycleName { get; set; }
        public GetAssetSearchResponseResultsTypeItemFieldsTypeItem[] Fields { get; set; }
        public GetAssetSearchResponseResultsTypeItemAttachmentsTypeItem[] Attachments { get; set; }
        public string AssetTemplateName { get; set; }
        public string AssetName { get; set; }
        public string AssetSearchName { get; set; }
        public string CreationDate { get; set; }
        public string AlterationDate { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class GetAssetSearchResponseResultsTypeItemFieldsTypeItem
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
    }

    public class GetAssetSearchResponseResultsTypeItemAttachmentsTypeItem
    {
        public string FileName { get; set; }
        public string Data { get; set; }
    }

    public class GetAssetInfoResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
        public int AssetId { get; set; }
        public int AssetTemplateId { get; set; }
        public string ReferenceNumber { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public int DocumentationId { get; set; }
        public string DocumentationName { get; set; }
        public string AssetTemplateName { get; set; }
        public string AssetName { get; set; }
        public string AssetSearchName { get; set; }
        public string CreationDate { get; set; }
        public string AlterationDate { get; set; }
        public int Status { get; set; }
        public string LiveCycleName { get; set; }
        public GetAssetInfoResponseFieldsTypeItem[] Fields { get; set; }
        public GetAssetInfoResponseAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class GetAssetInfoResponseFieldsTypeItem
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
        public GetAssetInfoResponseFieldsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetAssetInfoResponseFieldsTypeItemOptionsTypeItem
    {
        public string OptionName { get; set; }
        public string Value { get; set; }
    }

    public class GetAssetInfoResponseAttachmentsTypeItem
    {
        public string FileName { get; set; }
        public string Data { get; set; }
    }

    public class GetConfigResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }
        public int AssetId { get; set; }
        public int AssetTemplateId { get; set; }
        public string AssetTemplateName { get; set; }
        public string ReferenceNumber { get; set; }
        public int EnterpriseId { get; set; }
        public string EnterpriseName { get; set; }
        public int DocumentationId { get; set; }
        public string DocumentationName { get; set; }
        public int Status { get; set; }
        public string LiveCycleName { get; set; }
        public string AssetName { get; set; }
        public string AssetSearchName { get; set; }
        public string CreationDate { get; set; }
        public string AlterationDate { get; set; }
        public GetConfigResponseFieldsTypeItem[] Fields { get; set; }
        public GetConfigResponseAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class GetConfigResponseFieldsTypeItem
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
        public GetConfigResponseFieldsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetConfigResponseFieldsTypeItemOptionsTypeItem
    {
        public string OptionName { get; set; }
        public string Value { get; set; }
    }

    public class GetConfigResponseAttachmentsTypeItem
    {
        public string FileName { get; set; }
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasset;

    public partial class WorkflowManagedActions
    {
        public TesseronassetActions Tesseronasset(string connectionId) => new TesseronassetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TesseronassetTriggers Tesseronasset(string connectionId) => new TesseronassetTriggers(connectionId);
    }
}