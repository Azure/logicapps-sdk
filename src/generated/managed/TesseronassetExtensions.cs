//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasset
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronassetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<AddAssetResponse> AddAsset(Expression<Func<int>> bodyassetTemplateId, Expression<Func<bodyfieldsInputItem[]>> bodyfields, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<string>> bodydocumentationName = null, Expression<Func<string>> bodyliveCycleName = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var __workflow_bodyassetTemplateId = WorkflowExpression.Compile(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: true);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodydocumentationId = WorkflowExpression.Compile(bodydocumentationId, nameof(bodydocumentationId), required: false);
            var __workflow_bodydocumentationName = WorkflowExpression.Compile(bodydocumentationName, nameof(bodydocumentationName), required: false);
            var __workflow_bodyliveCycleName = WorkflowExpression.Compile(bodyliveCycleName, nameof(bodyliveCycleName), required: false);
            var __workflow_bodyattachments = WorkflowExpression.Compile(bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredBodyAction<AddAssetResponse>(() =>
            {
                var apiCallPath = "/AddAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyassetTemplateId);
                if (__workflow_bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentationId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentationName != null)
                {
                    body["DocumentationName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentationName);
                    bodypropCount++;
                }

                if (__workflow_bodyliveCycleName != null)
                {
                    body["LiveCycleName"] = ExpressionConverter.ConvertO(__workflow_bodyliveCycleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                if (__workflow_bodyattachments != null)
                {
                    body["Attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AddAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset(Expression<Func<int>> bodyassetId, Expression<Func<int>> bodyassetTemplateId, Expression<Func<bodyfieldsInputItem[]>> bodyfields, Expression<Func<string>> bodyreferenceNumber = null, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<string>> bodydocumentationName = null, Expression<Func<int>> bodystatus = null, Expression<Func<string>> bodyliveCycleState = null, Expression<Func<bodyattachmentsInputItem[]>> bodyattachments = null)
        {
            var __workflow_bodyassetId = WorkflowExpression.Compile(bodyassetId, nameof(bodyassetId), required: true);
            var __workflow_bodyassetTemplateId = WorkflowExpression.Compile(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            var __workflow_bodyfields = WorkflowExpression.Compile(bodyfields, nameof(bodyfields), required: true);
            var __workflow_bodyreferenceNumber = WorkflowExpression.Compile(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodydocumentationId = WorkflowExpression.Compile(bodydocumentationId, nameof(bodydocumentationId), required: false);
            var __workflow_bodydocumentationName = WorkflowExpression.Compile(bodydocumentationName, nameof(bodydocumentationName), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyliveCycleState = WorkflowExpression.Compile(bodyliveCycleState, nameof(bodyliveCycleState), required: false);
            var __workflow_bodyattachments = WorkflowExpression.Compile(bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredBodyAction<UpdateAssetResponse>(() =>
            {
                var apiCallPath = "/UpdateAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetId"] = ExpressionConverter.ConvertO(__workflow_bodyassetId);
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyassetTemplateId);
                if (__workflow_bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentationId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentationName != null)
                {
                    body["DocumentationName"] = ExpressionConverter.ConvertO(__workflow_bodydocumentationName);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodyliveCycleState != null)
                {
                    body["LiveCycleState"] = ExpressionConverter.ConvertO(__workflow_bodyliveCycleState);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Fields"] = ExpressionConverter.ConvertO(__workflow_bodyfields);
                if (__workflow_bodyattachments != null)
                {
                    body["Attachments"] = ExpressionConverter.ConvertO(__workflow_bodyattachments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetSearchResponse> GetAssetSearch(Expression<Func<int>> bodyskip, Expression<Func<int>> bodypageSize, Expression<Func<int>> bodyassetTemplateId, Expression<Func<string>> bodysearch = null, Expression<Func<int>> bodyenterpriseId = null, Expression<Func<int>> bodydocumentationId = null, Expression<Func<int>> bodyassetStatus = null, Expression<Func<bool>> bodyisDeprecated = null, Expression<Func<string>> bodylastUpdateDateStart = null, Expression<Func<string>> bodylastUpdateDateEnd = null, Expression<Func<int>> bodyresponseType = null, Expression<Func<bool>> bodyincludeAccessAuditedFieldValues = null)
        {
            var __workflow_bodyskip = WorkflowExpression.Compile(bodyskip, nameof(bodyskip), required: true);
            var __workflow_bodypageSize = WorkflowExpression.Compile(bodypageSize, nameof(bodypageSize), required: true);
            var __workflow_bodyassetTemplateId = WorkflowExpression.Compile(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: false);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            var __workflow_bodydocumentationId = WorkflowExpression.Compile(bodydocumentationId, nameof(bodydocumentationId), required: false);
            var __workflow_bodyassetStatus = WorkflowExpression.Compile(bodyassetStatus, nameof(bodyassetStatus), required: false);
            var __workflow_bodyisDeprecated = WorkflowExpression.Compile(bodyisDeprecated, nameof(bodyisDeprecated), required: false);
            var __workflow_bodylastUpdateDateStart = WorkflowExpression.Compile(bodylastUpdateDateStart, nameof(bodylastUpdateDateStart), required: false);
            var __workflow_bodylastUpdateDateEnd = WorkflowExpression.Compile(bodylastUpdateDateEnd, nameof(bodylastUpdateDateEnd), required: false);
            var __workflow_bodyresponseType = WorkflowExpression.Compile(bodyresponseType, nameof(bodyresponseType), required: false);
            var __workflow_bodyincludeAccessAuditedFieldValues = WorkflowExpression.Compile(bodyincludeAccessAuditedFieldValues, nameof(bodyincludeAccessAuditedFieldValues), required: false);
            return new DeferredBodyAction<GetAssetSearchResponse>(() =>
            {
                var apiCallPath = "/GetAssetSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(__workflow_bodyskip);
                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(__workflow_bodypageSize);
                if (__workflow_bodysearch != null)
                {
                    body["search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyassetTemplateId);
                if (__workflow_bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                if (__workflow_bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(__workflow_bodydocumentationId);
                    bodypropCount++;
                }

                if (__workflow_bodyassetStatus != null)
                {
                    body["AssetStatus"] = ExpressionConverter.ConvertO(__workflow_bodyassetStatus);
                    bodypropCount++;
                }

                if (__workflow_bodyisDeprecated != null)
                {
                    body["IsDeprecated"] = ExpressionConverter.ConvertO(__workflow_bodyisDeprecated);
                    bodypropCount++;
                }

                if (__workflow_bodylastUpdateDateStart != null)
                {
                    body["LastUpdateDateStart"] = ExpressionConverter.ConvertO(__workflow_bodylastUpdateDateStart);
                    bodypropCount++;
                }

                if (__workflow_bodylastUpdateDateEnd != null)
                {
                    body["LastUpdateDateEnd"] = ExpressionConverter.ConvertO(__workflow_bodylastUpdateDateEnd);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeAccessAuditedFieldValues != null)
                {
                    body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyincludeAccessAuditedFieldValues);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAssetSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetInfoResponse> GetAssetInfo(Expression<Func<int>> bodyassetId, Expression<Func<bool>> bodyincludeAccessAuditedFieldValues = null, Expression<Func<int>> bodyresponseType = null)
        {
            var __workflow_bodyassetId = WorkflowExpression.Compile(bodyassetId, nameof(bodyassetId), required: true);
            var __workflow_bodyincludeAccessAuditedFieldValues = WorkflowExpression.Compile(bodyincludeAccessAuditedFieldValues, nameof(bodyincludeAccessAuditedFieldValues), required: false);
            var __workflow_bodyresponseType = WorkflowExpression.Compile(bodyresponseType, nameof(bodyresponseType), required: false);
            return new DeferredBodyAction<GetAssetInfoResponse>(() =>
            {
                var apiCallPath = "/GetAssetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetId"] = ExpressionConverter.ConvertO(__workflow_bodyassetId);
                if (__workflow_bodyincludeAccessAuditedFieldValues != null)
                {
                    body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(__workflow_bodyincludeAccessAuditedFieldValues);
                    bodypropCount++;
                }

                if (__workflow_bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(__workflow_bodyresponseType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetAssetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetConfigResponse> GetConfig(Expression<Func<int>> bodyassetTemplateId, Expression<Func<int>> bodyenterpriseId = null)
        {
            var __workflow_bodyassetTemplateId = WorkflowExpression.Compile(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            var __workflow_bodyenterpriseId = WorkflowExpression.Compile(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredBodyAction<GetConfigResponse>(() =>
            {
                var apiCallPath = "/GetConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodyassetTemplateId);
                if (__workflow_bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(__workflow_bodyenterpriseId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetConfigResponse>(callPayload);
            });
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
