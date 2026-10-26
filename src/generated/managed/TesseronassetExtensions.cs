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
        public IBodyWorkflowAction<AddAssetResponse, ApiConnectionActionConfiguration> AddAsset(Expression<Func<AddAssetInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<AddAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/AddAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<AddAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<UpdateAssetResponse, ApiConnectionActionConfiguration> UpdateAsset(Expression<Func<UpdateAssetInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateAssetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UpdateAsset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateAssetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetSearchResponse, ApiConnectionActionConfiguration> GetAssetSearch(Expression<Func<GetAssetSearchInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAssetSearchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetAssetSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAssetSearchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetAssetInfoResponse, ApiConnectionActionConfiguration> GetAssetInfo(Expression<Func<GetAssetInfoInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetAssetInfoResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetAssetInfo";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GetAssetInfoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tesseronasset")]
        public IBodyWorkflowAction<GetConfigResponse, ApiConnectionActionConfiguration> GetConfig(Expression<Func<GetConfigInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GetConfigResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/GetConfig";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
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

    public class AddAssetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetTemplateId { get; set; }
        public int? EnterpriseId { get; set; }
        public int? Status { get; set; }
        public string ReferenceNumber { get; set; }
        public int? DocumentationId { get; set; }
        public string DocumentationName { get; set; }
        public string LiveCycleName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public AddAssetInputFieldsTypeItem[] Fields { get; set; }
        public AddAssetInputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class AddAssetInputFieldsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class AddAssetInputAttachmentsTypeItem
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

    public class UpdateAssetInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetId { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetTemplateId { get; set; }
        public string ReferenceNumber { get; set; }
        public int? EnterpriseId { get; set; }
        public int? DocumentationId { get; set; }
        public string DocumentationName { get; set; }
        public int? Status { get; set; }
        public string LiveCycleState { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public UpdateAssetInputFieldsTypeItem[] Fields { get; set; }
        public UpdateAssetInputAttachmentsTypeItem[] Attachments { get; set; }
    }

    public class UpdateAssetInputFieldsTypeItem
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string FieldName { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }
    }

    public class UpdateAssetInputAttachmentsTypeItem
    {
        public string FileName { get; set; }
        public string Data { get; set; }
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

    public class GetAssetSearchInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int Skip { get; set; } = 0;

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; } = 25;

        [JsonProperty("search")]
        public string Search { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetTemplateId { get; set; }
        public int? EnterpriseId { get; set; }
        public int? DocumentationId { get; set; }
        public int? AssetStatus { get; set; }
        public bool? IsDeprecated { get; set; }
        public string LastUpdateDateStart { get; set; }
        public string LastUpdateDateEnd { get; set; }
        public int? ResponseType { get; set; }
        public bool? IncludeAccessAuditedFieldValues { get; set; }
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

    public class GetAssetInfoInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetId { get; set; }
        public bool? IncludeAccessAuditedFieldValues { get; set; }
        public int? ResponseType { get; set; }
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

    public class GetConfigInput
    {
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public int AssetTemplateId { get; set; }
        public int? EnterpriseId { get; set; }
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