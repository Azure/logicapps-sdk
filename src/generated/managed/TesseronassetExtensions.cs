//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tesseronasset
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TesseronassetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        [WorkflowExpressionFactory(nameof(__BuildAddAsset))]
        public IBodyWorkflowAction<AddAssetResponse> AddAsset([WorkflowExpression] Func<int> bodyassetTemplateId, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields, [WorkflowExpression] Func<int> bodyenterpriseId = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<int> bodydocumentationId = null, [WorkflowExpression] Func<string> bodydocumentationName = null, [WorkflowExpression] Func<string> bodyliveCycleName = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddAssetResponse> __BuildAddAsset(WorkflowValue<int> bodyassetTemplateId, WorkflowValue<bodyfieldsInputItem[]> bodyfields, WorkflowValue<int> bodyenterpriseId = null, WorkflowValue<int> bodystatus = null, WorkflowValue<string> bodyreferenceNumber = null, WorkflowValue<int> bodydocumentationId = null, WorkflowValue<string> bodydocumentationName = null, WorkflowValue<string> bodyliveCycleName = null, WorkflowValue<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            WorkflowValue.Validate(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            WorkflowValue.Validate(bodydocumentationId, nameof(bodydocumentationId), required: false);
            WorkflowValue.Validate(bodydocumentationName, nameof(bodydocumentationName), required: false);
            WorkflowValue.Validate(bodyliveCycleName, nameof(bodyliveCycleName), required: false);
            WorkflowValue.Validate(bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredBodyAction<AddAssetResponse>(() =>
            {
                var apiCallPath = "/AddAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyassetTemplateId);
                if (bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(bodydocumentationId);
                    bodypropCount++;
                }

                if (bodydocumentationName != null)
                {
                    body["DocumentationName"] = ExpressionConverter.ConvertO(bodydocumentationName);
                    bodypropCount++;
                }

                if (bodyliveCycleName != null)
                {
                    body["LiveCycleName"] = ExpressionConverter.ConvertO(bodyliveCycleName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Fields"] = ExpressionConverter.ConvertO(bodyfields);
                if (bodyattachments != null)
                {
                    body["Attachments"] = ExpressionConverter.ConvertO(bodyattachments);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateAsset))]
        public IBodyWorkflowAction<UpdateAssetResponse> UpdateAsset([WorkflowExpression] Func<int> bodyassetId, [WorkflowExpression] Func<int> bodyassetTemplateId, [WorkflowExpression] Func<bodyfieldsInputItem[]> bodyfields, [WorkflowExpression] Func<string> bodyreferenceNumber = null, [WorkflowExpression] Func<int> bodyenterpriseId = null, [WorkflowExpression] Func<int> bodydocumentationId = null, [WorkflowExpression] Func<string> bodydocumentationName = null, [WorkflowExpression] Func<int> bodystatus = null, [WorkflowExpression] Func<string> bodyliveCycleState = null, [WorkflowExpression] Func<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateAssetResponse> __BuildUpdateAsset(WorkflowValue<int> bodyassetId, WorkflowValue<int> bodyassetTemplateId, WorkflowValue<bodyfieldsInputItem[]> bodyfields, WorkflowValue<string> bodyreferenceNumber = null, WorkflowValue<int> bodyenterpriseId = null, WorkflowValue<int> bodydocumentationId = null, WorkflowValue<string> bodydocumentationName = null, WorkflowValue<int> bodystatus = null, WorkflowValue<string> bodyliveCycleState = null, WorkflowValue<bodyattachmentsInputItem[]> bodyattachments = null)
        {
            WorkflowValue.Validate(bodyassetId, nameof(bodyassetId), required: true);
            WorkflowValue.Validate(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            WorkflowValue.Validate(bodyfields, nameof(bodyfields), required: true);
            WorkflowValue.Validate(bodyreferenceNumber, nameof(bodyreferenceNumber), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowValue.Validate(bodydocumentationId, nameof(bodydocumentationId), required: false);
            WorkflowValue.Validate(bodydocumentationName, nameof(bodydocumentationName), required: false);
            WorkflowValue.Validate(bodystatus, nameof(bodystatus), required: false);
            WorkflowValue.Validate(bodyliveCycleState, nameof(bodyliveCycleState), required: false);
            WorkflowValue.Validate(bodyattachments, nameof(bodyattachments), required: false);
            return new DeferredBodyAction<UpdateAssetResponse>(() =>
            {
                var apiCallPath = "/UpdateAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetId"] = ExpressionConverter.ConvertO(bodyassetId);
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyassetTemplateId);
                if (bodyreferenceNumber != null)
                {
                    body["ReferenceNumber"] = ExpressionConverter.ConvertO(bodyreferenceNumber);
                    bodypropCount++;
                }

                if (bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                if (bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(bodydocumentationId);
                    bodypropCount++;
                }

                if (bodydocumentationName != null)
                {
                    body["DocumentationName"] = ExpressionConverter.ConvertO(bodydocumentationName);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["Status"] = ExpressionConverter.ConvertO(bodystatus);
                    bodypropCount++;
                }

                if (bodyliveCycleState != null)
                {
                    body["LiveCycleState"] = ExpressionConverter.ConvertO(bodyliveCycleState);
                    bodypropCount++;
                }

                bodypropCount++;
                body["Fields"] = ExpressionConverter.ConvertO(bodyfields);
                if (bodyattachments != null)
                {
                    body["Attachments"] = ExpressionConverter.ConvertO(bodyattachments);
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
        [WorkflowExpressionFactory(nameof(__BuildGetAssetSearch))]
        public IBodyWorkflowAction<GetAssetSearchResponse> GetAssetSearch([WorkflowExpression] Func<int> bodyskip, [WorkflowExpression] Func<int> bodypageSize, [WorkflowExpression] Func<int> bodyassetTemplateId, [WorkflowExpression] Func<string> bodysearch = null, [WorkflowExpression] Func<int> bodyenterpriseId = null, [WorkflowExpression] Func<int> bodydocumentationId = null, [WorkflowExpression] Func<int> bodyassetStatus = null, [WorkflowExpression] Func<bool> bodyisDeprecated = null, [WorkflowExpression] Func<string> bodylastUpdateDateStart = null, [WorkflowExpression] Func<string> bodylastUpdateDateEnd = null, [WorkflowExpression] Func<int> bodyresponseType = null, [WorkflowExpression] Func<bool> bodyincludeAccessAuditedFieldValues = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAssetSearchResponse> __BuildGetAssetSearch(WorkflowValue<int> bodyskip, WorkflowValue<int> bodypageSize, WorkflowValue<int> bodyassetTemplateId, WorkflowValue<string> bodysearch = null, WorkflowValue<int> bodyenterpriseId = null, WorkflowValue<int> bodydocumentationId = null, WorkflowValue<int> bodyassetStatus = null, WorkflowValue<bool> bodyisDeprecated = null, WorkflowValue<string> bodylastUpdateDateStart = null, WorkflowValue<string> bodylastUpdateDateEnd = null, WorkflowValue<int> bodyresponseType = null, WorkflowValue<bool> bodyincludeAccessAuditedFieldValues = null)
        {
            WorkflowValue.Validate(bodyskip, nameof(bodyskip), required: true);
            WorkflowValue.Validate(bodypageSize, nameof(bodypageSize), required: true);
            WorkflowValue.Validate(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            WorkflowValue.Validate(bodysearch, nameof(bodysearch), required: false);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            WorkflowValue.Validate(bodydocumentationId, nameof(bodydocumentationId), required: false);
            WorkflowValue.Validate(bodyassetStatus, nameof(bodyassetStatus), required: false);
            WorkflowValue.Validate(bodyisDeprecated, nameof(bodyisDeprecated), required: false);
            WorkflowValue.Validate(bodylastUpdateDateStart, nameof(bodylastUpdateDateStart), required: false);
            WorkflowValue.Validate(bodylastUpdateDateEnd, nameof(bodylastUpdateDateEnd), required: false);
            WorkflowValue.Validate(bodyresponseType, nameof(bodyresponseType), required: false);
            WorkflowValue.Validate(bodyincludeAccessAuditedFieldValues, nameof(bodyincludeAccessAuditedFieldValues), required: false);
            return new DeferredBodyAction<GetAssetSearchResponse>(() =>
            {
                var apiCallPath = "/GetAssetSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Skip"] = ExpressionConverter.ConvertO(bodyskip);
                bodypropCount++;
                body["PageSize"] = ExpressionConverter.ConvertO(bodypageSize);
                if (bodysearch != null)
                {
                    body["search"] = ExpressionConverter.ConvertO(bodysearch);
                    bodypropCount++;
                }

                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyassetTemplateId);
                if (bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
                    bodypropCount++;
                }

                if (bodydocumentationId != null)
                {
                    body["DocumentationId"] = ExpressionConverter.ConvertO(bodydocumentationId);
                    bodypropCount++;
                }

                if (bodyassetStatus != null)
                {
                    body["AssetStatus"] = ExpressionConverter.ConvertO(bodyassetStatus);
                    bodypropCount++;
                }

                if (bodyisDeprecated != null)
                {
                    body["IsDeprecated"] = ExpressionConverter.ConvertO(bodyisDeprecated);
                    bodypropCount++;
                }

                if (bodylastUpdateDateStart != null)
                {
                    body["LastUpdateDateStart"] = ExpressionConverter.ConvertO(bodylastUpdateDateStart);
                    bodypropCount++;
                }

                if (bodylastUpdateDateEnd != null)
                {
                    body["LastUpdateDateEnd"] = ExpressionConverter.ConvertO(bodylastUpdateDateEnd);
                    bodypropCount++;
                }

                if (bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
                    bodypropCount++;
                }

                if (bodyincludeAccessAuditedFieldValues != null)
                {
                    body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(bodyincludeAccessAuditedFieldValues);
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
        [WorkflowExpressionFactory(nameof(__BuildGetAssetInfo))]
        public IBodyWorkflowAction<GetAssetInfoResponse> GetAssetInfo([WorkflowExpression] Func<int> bodyassetId, [WorkflowExpression] Func<bool> bodyincludeAccessAuditedFieldValues = null, [WorkflowExpression] Func<int> bodyresponseType = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAssetInfoResponse> __BuildGetAssetInfo(WorkflowValue<int> bodyassetId, WorkflowValue<bool> bodyincludeAccessAuditedFieldValues = null, WorkflowValue<int> bodyresponseType = null)
        {
            WorkflowValue.Validate(bodyassetId, nameof(bodyassetId), required: true);
            WorkflowValue.Validate(bodyincludeAccessAuditedFieldValues, nameof(bodyincludeAccessAuditedFieldValues), required: false);
            WorkflowValue.Validate(bodyresponseType, nameof(bodyresponseType), required: false);
            return new DeferredBodyAction<GetAssetInfoResponse>(() =>
            {
                var apiCallPath = "/GetAssetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetId"] = ExpressionConverter.ConvertO(bodyassetId);
                if (bodyincludeAccessAuditedFieldValues != null)
                {
                    body["IncludeAccessAuditedFieldValues"] = ExpressionConverter.ConvertO(bodyincludeAccessAuditedFieldValues);
                    bodypropCount++;
                }

                if (bodyresponseType != null)
                {
                    body["ResponseType"] = ExpressionConverter.ConvertO(bodyresponseType);
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
        [WorkflowExpressionFactory(nameof(__BuildGetConfig))]
        public IBodyWorkflowAction<GetConfigResponse> GetConfig([WorkflowExpression] Func<int> bodyassetTemplateId, [WorkflowExpression] Func<int> bodyenterpriseId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetConfigResponse> __BuildGetConfig(WorkflowValue<int> bodyassetTemplateId, WorkflowValue<int> bodyenterpriseId = null)
        {
            WorkflowValue.Validate(bodyassetTemplateId, nameof(bodyassetTemplateId), required: true);
            WorkflowValue.Validate(bodyenterpriseId, nameof(bodyenterpriseId), required: false);
            return new DeferredBodyAction<GetConfigResponse>(() =>
            {
                var apiCallPath = "/GetConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["AssetTemplateId"] = ExpressionConverter.ConvertO(bodyassetTemplateId);
                if (bodyenterpriseId != null)
                {
                    body["EnterpriseId"] = ExpressionConverter.ConvertO(bodyenterpriseId);
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
