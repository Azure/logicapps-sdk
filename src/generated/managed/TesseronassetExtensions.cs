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
        public IBodyWorkflowAction<AddAssetResponse> AddAsset(Expression<Func<int>> bodyassetTemplateId, Expression<Func<bodyfieldsInputItem[]>> bodyfields, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<string>> bodydocumentationName = null, Expression<Func<string>> bodyliveCycleName = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var apiCallPath = "/AddAsset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetTemplateId"] = CSharpExpressionConverter.ConvertToken(bodyassetTemplateId);
            if (bodyenterpriseId != null)
            {
                body["EnterpriseId"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseId);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyreferenceNumber != null)
            {
                body["ReferenceNumber"] = CSharpExpressionConverter.ConvertToken(bodyreferenceNumber);
                bodypropCount++;
            }

            if (bodydocumentationId != null)
            {
                body["DocumentationId"] = CSharpExpressionConverter.ConvertToken(bodydocumentationId);
                bodypropCount++;
            }

            if (bodydocumentationName != null)
            {
                body["DocumentationName"] = CSharpExpressionConverter.ConvertToken(bodydocumentationName);
                bodypropCount++;
            }

            if (bodyliveCycleName != null)
            {
                body["LiveCycleName"] = CSharpExpressionConverter.ConvertToken(bodyliveCycleName);
                bodypropCount++;
            }

            bodypropCount++;
            body["Fields"] = CSharpExpressionConverter.ConvertToken(bodyfields);
            if (bodyattachments != null)
            {
                body["Attachments"] = CSharpExpressionConverter.ConvertToken(bodyattachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AddAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<int>> bodyassetId, Expression<Func<int>> bodyassetTemplateId, Expression<Func<bodyfieldsInputItem[]>> bodyfields, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<string>> bodydocumentationName = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodyliveCycleState = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var apiCallPath = "/UpdateAsset";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetId"] = CSharpExpressionConverter.ConvertToken(bodyassetId);
            bodypropCount++;
            body["AssetTemplateId"] = CSharpExpressionConverter.ConvertToken(bodyassetTemplateId);
            if (bodyreferenceNumber != null)
            {
                body["ReferenceNumber"] = CSharpExpressionConverter.ConvertToken(bodyreferenceNumber);
                bodypropCount++;
            }

            if (bodyenterpriseId != null)
            {
                body["EnterpriseId"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseId);
                bodypropCount++;
            }

            if (bodydocumentationId != null)
            {
                body["DocumentationId"] = CSharpExpressionConverter.ConvertToken(bodydocumentationId);
                bodypropCount++;
            }

            if (bodydocumentationName != null)
            {
                body["DocumentationName"] = CSharpExpressionConverter.ConvertToken(bodydocumentationName);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["Status"] = CSharpExpressionConverter.ConvertToken(bodystatus);
                bodypropCount++;
            }

            if (bodyliveCycleState != null)
            {
                body["LiveCycleState"] = CSharpExpressionConverter.ConvertToken(bodyliveCycleState);
                bodypropCount++;
            }

            bodypropCount++;
            body["Fields"] = CSharpExpressionConverter.ConvertToken(bodyfields);
            if (bodyattachments != null)
            {
                body["Attachments"] = CSharpExpressionConverter.ConvertToken(bodyattachments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetSearchResponse> GetAssetSearch(Expression<Func<int>> bodyskip, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyassetTemplateId, Expression<Func<string>> bodysearch = null, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<int>> bodyassetStatus = null, Expression<Func<bool>> bodyisDeprecated = null, Expression<Func<string>> bodylastUpdateDateStart = null, Expression<Func<string>> bodylastUpdateDateEnd = null, Expression<Func<int>> bodyresponseType = null, Expression<Func<bool>> bodyincludeAccessAuditedFieldValues = null)
        {
            var apiCallPath = "/GetAssetSearch";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Skip"] = CSharpExpressionConverter.ConvertToken(bodyskip);
            bodypropCount++;
            body["PageSize"] = CSharpExpressionConverter.ConvertToken(bodypageSize);
            if (bodysearch != null)
            {
                body["search"] = CSharpExpressionConverter.ConvertToken(bodysearch);
                bodypropCount++;
            }

            bodypropCount++;
            body["AssetTemplateId"] = CSharpExpressionConverter.ConvertToken(bodyassetTemplateId);
            if (bodyenterpriseId != null)
            {
                body["EnterpriseId"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseId);
                bodypropCount++;
            }

            if (bodydocumentationId != null)
            {
                body["DocumentationId"] = CSharpExpressionConverter.ConvertToken(bodydocumentationId);
                bodypropCount++;
            }

            if (bodyassetStatus != null)
            {
                body["AssetStatus"] = CSharpExpressionConverter.ConvertToken(bodyassetStatus);
                bodypropCount++;
            }

            if (bodyisDeprecated != null)
            {
                body["IsDeprecated"] = CSharpExpressionConverter.ConvertToken(bodyisDeprecated);
                bodypropCount++;
            }

            if (bodylastUpdateDateStart != null)
            {
                body["LastUpdateDateStart"] = CSharpExpressionConverter.ConvertToken(bodylastUpdateDateStart);
                bodypropCount++;
            }

            if (bodylastUpdateDateEnd != null)
            {
                body["LastUpdateDateEnd"] = CSharpExpressionConverter.ConvertToken(bodylastUpdateDateEnd);
                bodypropCount++;
            }

            if (bodyresponseType != null)
            {
                body["ResponseType"] = CSharpExpressionConverter.ConvertToken(bodyresponseType);
                bodypropCount++;
            }

            if (bodyincludeAccessAuditedFieldValues != null)
            {
                body["IncludeAccessAuditedFieldValues"] = CSharpExpressionConverter.ConvertToken(bodyincludeAccessAuditedFieldValues);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAssetSearchResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetInfoResponse> GetAssetInfo(Expression<Func<int>> bodyassetId, Expression<Func<bool>> bodyincludeAccessAuditedFieldValues = null, Expression<Func<int>> bodyresponseType = null)
        {
            var apiCallPath = "/GetAssetInfo";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetId"] = CSharpExpressionConverter.ConvertToken(bodyassetId);
            if (bodyincludeAccessAuditedFieldValues != null)
            {
                body["IncludeAccessAuditedFieldValues"] = CSharpExpressionConverter.ConvertToken(bodyincludeAccessAuditedFieldValues);
                bodypropCount++;
            }

            if (bodyresponseType != null)
            {
                body["ResponseType"] = CSharpExpressionConverter.ConvertToken(bodyresponseType);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetAssetInfoResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetConfigResponse> GetConfig(Expression<Func<int>> bodyassetTemplateId, Expression<Func<int>> bodyenterpriseId = null)
        {
            var apiCallPath = "/GetConfig";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["AssetTemplateId"] = CSharpExpressionConverter.ConvertToken(bodyassetTemplateId);
            if (bodyenterpriseId != null)
            {
                body["EnterpriseId"] = CSharpExpressionConverter.ConvertToken(bodyenterpriseId);
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

    public class bodyfieldsInputItem
    {
        public string FieldName { get; set; }
        public string Value { get; set; }
    }

    public class bodyattachmentsInputItem
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