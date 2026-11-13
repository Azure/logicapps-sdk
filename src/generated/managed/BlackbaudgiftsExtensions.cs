//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudgiftsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentFirstGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/first", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentGreatestGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/greatest", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration> GetConstituentLatestGift(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiGivingSummaryRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/latest", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead, ApiConnectionActionConfiguration> GetConstituentLifetimeGiving(Expression<Func<string>> constituentId)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            return new DeferredBodyAction<ConstituentApiLifetimeGivingRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAcknowledgement(Expression<Func<string>> acknowledgementId, Expression<Func<EditGiftAcknowledgementBodyInput>> body)
        {
            var __workflow_acknowledgementId = WorkflowExpression.Compile(acknowledgementId, nameof(acknowledgementId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftacknowledgements/{0}", __workflow_acknowledgementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftReceipt(Expression<Func<string>> receiptId, Expression<Func<EditGiftReceiptBodyInput>> body)
        {
            var __workflow_receiptId = WorkflowExpression.Compile(receiptId, nameof(receiptId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftreceipts/{0}", __workflow_receiptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead, ApiConnectionActionConfiguration> ListGifts(Expression<Func<string>> listId = null, Expression<Func<string>> giftType = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> campaignId = null, Expression<Func<string>> fundId = null, Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> startGiftDate = null, Expression<Func<string>> endGiftDate = null, Expression<Func<double>> startGiftAmount = null, Expression<Func<double>> endGiftAmount = null, Expression<Func<string>> postStatus = null, Expression<Func<string>> receiptStatus = null, Expression<Func<string>> acknowledgementStatus = null, Expression<Func<string>> sort = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: false);
            var __workflow_giftType = WorkflowExpression.Compile(giftType, nameof(giftType), required: false);
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: false);
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: false);
            var __workflow_fundId = WorkflowExpression.Compile(fundId, nameof(fundId), required: false);
            var __workflow_appealId = WorkflowExpression.Compile(appealId, nameof(appealId), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_startGiftDate = WorkflowExpression.Compile(startGiftDate, nameof(startGiftDate), required: false);
            var __workflow_endGiftDate = WorkflowExpression.Compile(endGiftDate, nameof(endGiftDate), required: false);
            var __workflow_startGiftAmount = WorkflowExpression.Compile(startGiftAmount, nameof(startGiftAmount), required: false);
            var __workflow_endGiftAmount = WorkflowExpression.Compile(endGiftAmount, nameof(endGiftAmount), required: false);
            var __workflow_postStatus = WorkflowExpression.Compile(postStatus, nameof(postStatus), required: false);
            var __workflow_receiptStatus = WorkflowExpression.Compile(receiptStatus, nameof(receiptStatus), required: false);
            var __workflow_acknowledgementStatus = WorkflowExpression.Compile(acknowledgementStatus, nameof(acknowledgementStatus), required: false);
            var __workflow_sort = WorkflowExpression.Compile(sort, nameof(sort), required: false);
            var __workflow_dateAdded = WorkflowExpression.Compile(dateAdded, nameof(dateAdded), required: false);
            var __workflow_lastModified = WorkflowExpression.Compile(lastModified, nameof(lastModified), required: false);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_listId != null)
                    callPayload.Queries["list_id"] = ExpressionConverter.Convert(__workflow_listId);
                if (__workflow_giftType != null)
                    callPayload.Queries["gift_type"] = ExpressionConverter.Convert(__workflow_giftType);
                if (__workflow_constituentId != null)
                    callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(__workflow_constituentId);
                if (__workflow_campaignId != null)
                    callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(__workflow_campaignId);
                if (__workflow_fundId != null)
                    callPayload.Queries["fund_id"] = ExpressionConverter.Convert(__workflow_fundId);
                if (__workflow_appealId != null)
                    callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(__workflow_appealId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_startGiftDate != null)
                    callPayload.Queries["start_gift_date"] = ExpressionConverter.Convert(__workflow_startGiftDate);
                if (__workflow_endGiftDate != null)
                    callPayload.Queries["end_gift_date"] = ExpressionConverter.Convert(__workflow_endGiftDate);
                if (__workflow_startGiftAmount != null)
                    callPayload.Queries["start_gift_amount"] = ExpressionConverter.Convert(__workflow_startGiftAmount);
                if (__workflow_endGiftAmount != null)
                    callPayload.Queries["end_gift_amount"] = ExpressionConverter.Convert(__workflow_endGiftAmount);
                if (__workflow_postStatus != null)
                    callPayload.Queries["post_status"] = ExpressionConverter.Convert(__workflow_postStatus);
                if (__workflow_receiptStatus != null)
                    callPayload.Queries["receipt_status"] = ExpressionConverter.Convert(__workflow_receiptStatus);
                if (__workflow_acknowledgementStatus != null)
                    callPayload.Queries["acknowledgement_status"] = ExpressionConverter.Convert(__workflow_acknowledgementStatus);
                if (__workflow_sort != null)
                    callPayload.Queries["sort"] = ExpressionConverter.Convert(__workflow_sort);
                if (__workflow_dateAdded != null)
                    callPayload.Queries["date_added"] = ExpressionConverter.Convert(__workflow_dateAdded);
                if (__workflow_lastModified != null)
                    callPayload.Queries["last_modified"] = ExpressionConverter.Convert(__workflow_lastModified);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreateGift(Expression<Func<CreateGiftBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiGiftRead, ApiConnectionActionConfiguration> GetGift(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiGiftRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiGiftRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead, ApiConnectionActionConfiguration> ListGiftAttachments(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftAttachmentRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}/attachments", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead, ApiConnectionActionConfiguration> ListGiftCustomFields(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<GiftApiApiCollectionOfGiftCustomFieldRead, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/{0}/customfields", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration> CreateGiftAttachment(Expression<Func<CreateGiftAttachmentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAttachment(Expression<Func<string>> attachmentId, Expression<Func<EditGiftAttachmentBodyInput>> body)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration> CreateGiftCustomField(Expression<Func<CreateGiftCustomFieldBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftCustomField(Expression<Func<string>> customFieldId, Expression<Func<EditGiftCustomFieldBodyInput>> body)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration> AddGiftToBatch(Expression<Func<string>> batchId, Expression<Func<AddGiftToBatchBodyInput>> body)
        {
            var __workflow_batchId = WorkflowExpression.Compile(batchId, nameof(batchId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/virtual/giftbatches/{0}/gifts", __workflow_batchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiBatchGiftAddResults>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch, ApiConnectionActionConfiguration> ListGiftBatches(Expression<Func<string>> batchNumber = null, Expression<Func<bool>> approved = null, Expression<Func<bool>> hasExceptions = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchText = null, Expression<Func<string>> createdBy = null)
        {
            var __workflow_batchNumber = WorkflowExpression.Compile(batchNumber, nameof(batchNumber), required: false);
            var __workflow_approved = WorkflowExpression.Compile(approved, nameof(approved), required: false);
            var __workflow_hasExceptions = WorkflowExpression.Compile(hasExceptions, nameof(hasExceptions), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            var __workflow_searchText = WorkflowExpression.Compile(searchText, nameof(searchText), required: false);
            var __workflow_createdBy = WorkflowExpression.Compile(createdBy, nameof(createdBy), required: false);
            return new DeferredBodyAction<GiftBatchApiApiCollectionOfGiftBatch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_batchNumber != null)
                    callPayload.Queries["batch_number"] = ExpressionConverter.Convert(__workflow_batchNumber);
                if (__workflow_approved != null)
                    callPayload.Queries["approved"] = ExpressionConverter.Convert(__workflow_approved);
                if (__workflow_hasExceptions != null)
                    callPayload.Queries["has_exceptions"] = ExpressionConverter.Convert(__workflow_hasExceptions);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                if (__workflow_searchText != null)
                    callPayload.Queries["search_text"] = ExpressionConverter.Convert(__workflow_searchText);
                if (__workflow_createdBy != null)
                    callPayload.Queries["created_by"] = ExpressionConverter.Convert(__workflow_createdBy);
                return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration> CreateGiftBatch(Expression<Func<CreateGiftBatchBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftBatchApiCreatedBatch>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgeInstallmentCollection, ApiConnectionActionConfiguration> ListPledgeInstallments(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<Gift2ApiPledgeInstallmentCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gft-gifts/v2/gifts/{0}/installments", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Gift2ApiPledgeInstallmentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgePaymentCollection, ApiConnectionActionConfiguration> ListPledgePayments(Expression<Func<string>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<Gift2ApiPledgePaymentCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gft-gifts/v2/gifts/{0}/pledgepayments", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Gift2ApiPledgePaymentCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SellStockGift(Expression<Func<string>> giftId, Expression<Func<SellStockGiftBodyInput>> body)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gft-gifts/v2/gifts/{0}/stock/sell", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreatePledge(Expression<Func<CreatePledgeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreatePledgePayment(Expression<Func<CreatePledgePaymentBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledgepayments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreateStock(Expression<Func<CreateStockBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/stock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiTaxDeclarationCollection, ApiConnectionActionConfiguration> ListConstituentTaxDeclarations(Expression<Func<int>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NxtDataIntegrationApiTaxDeclarationCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftaid/constituents/{0}/taxdeclarations", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NxtDataIntegrationApiTaxDeclarationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiCreatedTaxDeclaration, ApiConnectionActionConfiguration> CreateTaxDeclaration(Expression<Func<CreateTaxDeclarationBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiCreatedTaxDeclaration, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/giftaid/taxdeclarations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NxtDataIntegrationApiCreatedTaxDeclaration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditTaxDeclaration(Expression<Func<int>> taxDeclarationId, Expression<Func<EditTaxDeclarationBodyInput>> body)
        {
            var __workflow_taxDeclarationId = WorkflowExpression.Compile(taxDeclarationId, nameof(taxDeclarationId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftaid/taxdeclarations/{0}", __workflow_taxDeclarationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiGiftIdMap, ApiConnectionActionConfiguration> GetGiftIdFromLookupId(Expression<Func<string>> giftlookupid)
        {
            var __workflow_giftlookupid = WorkflowExpression.Compile(giftlookupid, nameof(giftlookupid), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiGiftIdMap, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftidmap/{0}", __workflow_giftlookupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NxtDataIntegrationApiGiftIdMap>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiCreatedGiftNote, ApiConnectionActionConfiguration> CreateGiftNote(Expression<Func<CreateGiftNoteBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiCreatedGiftNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifts/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NxtDataIntegrationApiCreatedGiftNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftNote(Expression<Func<int>> id, Expression<Func<EditGiftNoteBodyInput>> body)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifts/notes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiGiftNoteCollection, ApiConnectionActionConfiguration> ListGiftNotes(Expression<Func<int>> giftId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NxtDataIntegrationApiGiftNoteCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifts/{0}/notes", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NxtDataIntegrationApiGiftNoteCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiCreatedGiftTribute, ApiConnectionActionConfiguration> CreateGiftTribute(Expression<Func<CreateGiftTributeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiCreatedGiftTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifttribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<NxtDataIntegrationApiCreatedGiftTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftTribute(Expression<Func<int>> giftTributeId, Expression<Func<EditGiftTributeBodyInput>> body)
        {
            var __workflow_giftTributeId = WorkflowExpression.Compile(giftTributeId, nameof(giftTributeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}", __workflow_giftTributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiGiftTributeAcknowledgeeCollection, ApiConnectionActionConfiguration> ListGiftTributeAcknowledgees(Expression<Func<int>> giftTributeId)
        {
            var __workflow_giftTributeId = WorkflowExpression.Compile(giftTributeId, nameof(giftTributeId), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiGiftTributeAcknowledgeeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}/acknowledgees", __workflow_giftTributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NxtDataIntegrationApiGiftTributeAcknowledgeeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NxtDataIntegrationApiGiftTributeCollection, ApiConnectionActionConfiguration> ListGiftTributes(Expression<Func<int>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<NxtDataIntegrationApiGiftTributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/gift/{0}", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NxtDataIntegrationApiGiftTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftTributeAcknowledgee(Expression<Func<int>> giftTributeAcknowledgeeId, Expression<Func<EditGiftTributeAcknowledgeeBodyInput>> body)
        {
            var __workflow_giftTributeAcknowledgeeId = WorkflowExpression.Compile(giftTributeAcknowledgeeId, nameof(giftTributeAcknowledgeeId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/acknowledgees/{0}", __workflow_giftTributeAcknowledgeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class BlackbaudgiftsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiGivingSummaryRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiGivingSummaryReadAmountType Amount { get; set; }

        [JsonProperty("appeals")]
        public ConstituentApiAppealRead[] Appeal { get; set; }

        [JsonProperty("campaigns")]
        public ConstituentApiCampaignRead[] Campaign { get; set; }

        [JsonProperty("funds")]
        public ConstituentApiFundRead[] Fund { get; set; }
    }

    public class ConstituentApiGivingSummaryReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiAppealRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiCampaignRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiFundRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiLifetimeGivingRead
    {
        [JsonProperty("consecutive_years_given")]
        public int ConsecutiveYearsGiven { get; set; }

        [JsonProperty("total_years_given")]
        public int TotalYearsGiven { get; set; }

        [JsonProperty("total_giving")]
        public ConstituentApiLifetimeGivingReadTotalGivingType TotalGiving { get; set; }

        [JsonProperty("total_pledge_balance")]
        public ConstituentApiLifetimeGivingReadTotalPledgeBalanceType TotalPledgeBalance { get; set; }

        [JsonProperty("total_received_giving")]
        public ConstituentApiLifetimeGivingReadTotalReceivedGivingType TotalReceivedGiving { get; set; }

        [JsonProperty("total_committed_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType TotalCommittedMatchingGifts { get; set; }

        [JsonProperty("total_received_matching_gifts")]
        public ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType TotalReceivedMatchingGifts { get; set; }

        [JsonProperty("total_soft_credits")]
        public ConstituentApiLifetimeGivingReadTotalSoftCreditsType TotalSoftCredits { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalPledgeBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedGivingType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalCommittedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalReceivedMatchingGiftsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiLifetimeGivingReadTotalSoftCreditsType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class EditGiftAcknowledgementBodyInput
    {
        [JsonProperty("status")]
        public EditGiftAcknowledgementBodyInputStatusType? Status { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditGiftAcknowledgementBodyInputStatusType
    {
        Acknowledged,
        NeedsAcknowledgement,
        DoNotAcknowledge
    }

    public class EditGiftReceiptBodyInput
    {
        [JsonProperty("status")]
        public EditGiftReceiptBodyInputStatusType? Status { get; set; }

        [JsonProperty("amount")]
        public EditGiftReceiptBodyInputAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int? Number { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum EditGiftReceiptBodyInputStatusType
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class EditGiftReceiptBodyInputAmountType
    {
        [JsonProperty("value")]
        public double? Amount { get; set; }
    }

    public class GiftApiApiCollectionOfGiftRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftRead[] Value { get; set; }
    }

    public class GiftApiGiftRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitReadAmountType Amount { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftSplitReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }
    }

    public class GiftApiGiftSplitReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftSplitReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiGiftFundraiserRead
    {
        [JsonProperty("amount")]
        public GiftApiGiftFundraiserReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string FundraiserId { get; set; }
    }

    public class GiftApiGiftFundraiserReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiSoftCreditRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("amount")]
        public GiftApiSoftCreditReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }
    }

    public class GiftApiSoftCreditReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiReceiptRead
    {
        [JsonProperty("amount")]
        public GiftApiReceiptReadAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiReceiptReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiAcknowledgementRead
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("letter")]
        public string Letter { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class GiftApiPaymentRead
    {
        [JsonProperty("account_token")]
        public string AccountToken { get; set; }

        [JsonProperty("bbps_configuration_id")]
        public string BbpsConfigurationId { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BbpsTransactionId { get; set; }

        [JsonProperty("check_date")]
        public GiftApiPaymentReadCheckDateType CheckDate { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("checkout_transaction_id")]
        public string CheckoutTransactionId { get; set; }

        [JsonProperty("payment_method")]
        public string PaymentMethod { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public GiftApiPaymentReadReferenceDateType ReferenceDate { get; set; }
    }

    public class GiftApiPaymentReadCheckDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiPaymentReadReferenceDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiCreatedGift
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGiftBodyInput
    {
        public CreateGiftBodyInput(string constituentId, CreateGiftBodyInputAmountType amount, string date, CreateGiftBodyInputTypeType type, GiftApiGiftSplitAdd[] splits)
        {
            this.ConstituentId = constituentId;
            this.Amount = amount;
            this.Date = date;
            this.Type = type;
            this.Splits = splits;
        }

        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputAmountType Amount { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputTypeType Type { get; set; }

        [JsonProperty("gift_splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public GiftApiGiftSplitAdd[] Splits { get; set; }

        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputPaymentsType Payments { get; set; } = new CreateGiftBodyInputPaymentsType();

        [JsonProperty("is_anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("reference")]
        public string Comment { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("default_fundraiser_credits")]
        public bool? UseFundraiserCredits { get; set; }

        [JsonProperty("default_soft_credits")]
        public bool? UseSoftCredits { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("batch_prefix")]
        public string BatchPrefix { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("post_status")]
        public CreateGiftBodyInputPostStatusType? PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Origin { get; set; } = "{ \"name\": \"Power Platform\" }";

        [JsonProperty("receipts", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputReceiptsType Receipts { get; set; } = new CreateGiftBodyInputReceiptsType();
    }

    public class CreateGiftBodyInputAmountType
    {
        public CreateGiftBodyInputAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGiftBodyInputTypeType
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiGiftSplitAdd
    {
        public GiftApiGiftSplitAdd(string fundId, GiftApiGiftSplitAddAmountType amount)
        {
            this.FundId = fundId;
            this.Amount = amount;
        }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public GiftApiGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiGiftSplitAddAmountType
    {
        public GiftApiGiftSplitAddAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    public class CreateGiftBodyInputPaymentsType
    {
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputPaymentsTypePaymentMethodType PaymentMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.CreateGiftBodyInputPaymentsTypePaymentMethodType.Cash;

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("check_date")]
        public BodyInputPaymentsTypeCheckDateType CheckDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public BodyInputPaymentsTypeReferenceDateType ReferenceDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGiftBodyInputPaymentsTypePaymentMethodType
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    public class BodyInputPaymentsTypeCheckDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class BodyInputPaymentsTypeReferenceDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGiftBodyInputPostStatusType
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class CreateGiftBodyInputReceiptsType
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputReceiptsTypeReceiptStatusType ReceiptStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.CreateGiftBodyInputReceiptsTypeReceiptStatusType.NeedsReceipt;

        [JsonProperty("amount")]
        public BodyInputReceiptsTypeAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string ReceiptDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGiftBodyInputReceiptsTypeReceiptStatusType
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class BodyInputReceiptsTypeAmountType
    {
        public BodyInputReceiptsTypeAmountType(double receiptAmount)
        {
            this.ReceiptAmount = receiptAmount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double ReceiptAmount { get; set; }
    }

    public class GiftApiApiCollectionOfGiftAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftAttachmentRead[] Value { get; set; }
    }

    public class GiftApiGiftAttachmentRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string GiftId { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GiftApiGiftAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class GiftApiApiCollectionOfGiftCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftApiGiftCustomFieldRead[] Value { get; set; }
    }

    public class GiftApiGiftCustomFieldRead
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parent_id")]
        public string GiftId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIdValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public GiftApiGiftCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GiftApiGiftCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class GiftApiGiftCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiCreatedGiftAttachment
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGiftAttachmentBodyInput
    {
        public CreateGiftAttachmentBodyInput(string giftId, CreateGiftAttachmentBodyInputTypeType type)
        {
            this.GiftId = giftId;
            this.Type = type;
        }

        [JsonProperty("parent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GiftId { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftAttachmentBodyInputTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateGiftAttachmentBodyInputTypeType
    {
        Link,
        Physical
    }

    public class EditGiftAttachmentBodyInput
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGiftCustomFieldBodyInput
    {
        public CreateGiftCustomFieldBodyInput(string giftId, string category)
        {
            this.GiftId = giftId;
            this.Category = category;
        }

        [JsonProperty("parent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string GiftId { get; set; }

        [JsonProperty("category", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Category { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class EditGiftCustomFieldBodyInput
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class GiftApiBatchGiftAddResults
    {
        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("gifts")]
        public GiftApiBatchGiftRead[] Gifts { get; set; }
    }

    public class GiftApiGiftBatchGiftError
    {
        [JsonProperty("affected_field")]
        public string AffectedField { get; set; }

        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        [JsonProperty("exception_error_code")]
        public int ExceptionErrorCode { get; set; }

        [JsonProperty("exception_error_message")]
        public string ExceptionErrorMessage { get; set; }

        [JsonProperty("exception_error_name")]
        public string ExceptionErrorName { get; set; }

        [JsonProperty("gift_id")]
        public string GiftId { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }
    }

    public class GiftApiBatchGiftRead
    {
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public GiftApiBatchGiftReadAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public GiftApiBatchGiftReadBalanceType Balance { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("gift_status")]
        public string Status { get; set; }

        [JsonProperty("is_anonymous")]
        public bool Anonymous { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("post_status")]
        public string PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("recurring_gift_status_date")]
        public GiftApiBatchGiftReadRecurringGiftDateType RecurringGiftDate { get; set; }

        [JsonProperty("recurring_gift_schedule")]
        public GiftApiBatchGiftReadRecurringGiftScheduleType RecurringGiftSchedule { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiBatchGiftReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("gift_code")]
        public string GiftCode { get; set; }

        [JsonProperty("gift_splits")]
        public GiftApiGiftSplitRead[] GiftSplits { get; set; }

        [JsonProperty("fundraisers")]
        public GiftApiGiftFundraiserRead[] Fundraisers { get; set; }

        [JsonProperty("soft_credits")]
        public GiftApiSoftCreditRead[] SoftCredits { get; set; }

        [JsonProperty("receipts")]
        public GiftApiReceiptRead[] Receipts { get; set; }

        [JsonProperty("acknowledgements")]
        public GiftApiAcknowledgementRead[] Acknowledgements { get; set; }

        [JsonProperty("payments")]
        public GiftApiPaymentRead[] Payments { get; set; }

        [JsonProperty("linked_gifts")]
        public string[] LinkedGifts { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class GiftApiBatchGiftReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadBalanceType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class GiftApiBatchGiftReadRecurringGiftScheduleType
    {
        [JsonProperty("frequency")]
        public string Frequency { get; set; }

        [JsonProperty("start_date")]
        public string Start { get; set; }

        [JsonProperty("end_date")]
        public string End { get; set; }
    }

    public class GiftApiBatchGiftReadGiftAidAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class AddGiftToBatchBodyInput
    {
        public AddGiftToBatchBodyInput(BodyInputGiftsType gifts)
        {
            this.Gifts = gifts;
        }

        [JsonProperty("gifts", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsType Gifts { get; set; }
    }

    public class BodyInputGiftsType
    {
        public BodyInputGiftsType(string constituentId, BodyInputGiftsTypeAmountType amount, string date, BodyInputGiftsTypeTypeType type, GiftApiVirtualBatchGiftSplitAdd[] splits)
        {
            this.ConstituentId = constituentId;
            this.Amount = amount;
            this.Date = date;
            this.Type = type;
            this.Splits = splits;
        }

        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypeAmountType Amount { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("type", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypeTypeType Type { get; set; }

        [JsonProperty("gift_splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public GiftApiVirtualBatchGiftSplitAdd[] Splits { get; set; }

        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypePaymentsType Payments { get; set; } = new BodyInputGiftsTypePaymentsType();

        [JsonProperty("is_anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("subtype")]
        public string Subtype { get; set; }

        [JsonProperty("reference")]
        public string Comment { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("default_fundraiser_credits")]
        public bool? UseFundraiserCredits { get; set; }

        [JsonProperty("default_soft_credits")]
        public bool? UseSoftCredits { get; set; }

        [JsonProperty("constituency")]
        public string Constituency { get; set; }

        [JsonProperty("post_status")]
        public BodyInputGiftsTypePostStatusType? PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Origin { get; set; } = "{ \"name\": \"Power Platform\" }";

        [JsonProperty("receipts", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypeReceiptsType Receipts { get; set; } = new BodyInputGiftsTypeReceiptsType();
    }

    public class BodyInputGiftsTypeAmountType
    {
        public BodyInputGiftsTypeAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGiftsTypeTypeType
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiVirtualBatchGiftSplitAdd
    {
        public GiftApiVirtualBatchGiftSplitAdd(string fundId, GiftApiVirtualBatchGiftSplitAddAmountType amount)
        {
            this.FundId = fundId;
            this.Amount = amount;
        }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public GiftApiVirtualBatchGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiVirtualBatchGiftSplitAddAmountType
    {
        public GiftApiVirtualBatchGiftSplitAddAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    public class BodyInputGiftsTypePaymentsType
    {
        [JsonProperty("payment_method", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypePaymentsTypePaymentMethodType PaymentMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.BodyInputGiftsTypePaymentsTypePaymentMethodType.Cash;

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("check_date")]
        public BodyInputGiftsTypePaymentsTypeCheckDateType CheckDate { get; set; }

        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("reference_date")]
        public BodyInputGiftsTypePaymentsTypeReferenceDateType ReferenceDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGiftsTypePaymentsTypePaymentMethodType
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    public class BodyInputGiftsTypePaymentsTypeCheckDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class BodyInputGiftsTypePaymentsTypeReferenceDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGiftsTypePostStatusType
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class BodyInputGiftsTypeReceiptsType
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputGiftsTypeReceiptsTypeReceiptStatusType ReceiptStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.BodyInputGiftsTypeReceiptsTypeReceiptStatusType.NeedsReceipt;

        [JsonProperty("amount")]
        public BodyInputGiftsTypeReceiptsTypeAmountType Amount { get; set; }

        [JsonProperty("date")]
        public string ReceiptDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputGiftsTypeReceiptsTypeReceiptStatusType
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public class BodyInputGiftsTypeReceiptsTypeAmountType
    {
        public BodyInputGiftsTypeReceiptsTypeAmountType(double receiptAmount)
        {
            this.ReceiptAmount = receiptAmount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double ReceiptAmount { get; set; }
    }

    public class GiftBatchApiApiCollectionOfGiftBatch
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public GiftBatchApiGiftBatch[] Value { get; set; }
    }

    public class GiftBatchApiGiftBatch
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("batch_description")]
        public string Description { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }

        [JsonProperty("projected_number_of_gifts")]
        public int ProjectedNumber { get; set; }

        [JsonProperty("number_of_gifts")]
        public int ActualNumber { get; set; }

        [JsonProperty("projected_amount")]
        public double ProjectedAmount { get; set; }

        [JsonProperty("actual_amount")]
        public double ActualAmount { get; set; }

        [JsonProperty("has_exceptions")]
        public bool HasExceptions { get; set; }

        [JsonProperty("is_approved")]
        public bool Approved { get; set; }

        [JsonProperty("created_by")]
        public string CreatedBy { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }
    }

    public class GiftBatchApiCreatedBatch
    {
        [JsonProperty("batch_id")]
        public string Id { get; set; }
    }

    public class CreateGiftBatchBodyInput
    {
        [JsonProperty("batch_description")]
        public string Description { get; set; }

        [JsonProperty("expected_number")]
        public int? ExpectedNumber { get; set; }

        [JsonProperty("expected_batch_total")]
        public double? ExpectedTotal { get; set; }

        [JsonProperty("batch_number")]
        public string BatchNumber { get; set; }
    }

    public class Gift2ApiPledgeInstallmentCollection
    {
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("frequency")]
        public Gift2ApiPledgeInstallmentCollectionFrequencyType Frequency { get; set; }

        [JsonProperty("concurrency_token")]
        public string ConcurrencyToken { get; set; }

        [JsonProperty("installments")]
        public Gift2ApiPledgeInstallment[] Installments { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Gift2ApiPledgeInstallmentCollectionFrequencyType
    {
        Annually,
        [EnumMember(Value = "EVERY_SIX_MONTHS")]
        EverySixMonths,
        Quarterly,
        Monthly,
        [EnumMember(Value = "EVERY_FOUR_WEEKS")]
        EveryFourWeeks,
        [EnumMember(Value = "EVERY_TWO_WEEKS")]
        EveryTwoWeeks,
        Weekly,
        Irregular,
        Single
    }

    public class Gift2ApiPledgeInstallment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("amount")]
        public Gift2ApiPledgeInstallmentAmountType Amount { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("remaining_pledge_balance")]
        public double RemainingPledgeBalance { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class Gift2ApiPledgeInstallmentAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class Gift2ApiPledgePaymentCollection
    {
        [JsonProperty("pledge_payments")]
        public Gift2ApiPledgePayment[] PledgePayments { get; set; }
    }

    public class Gift2ApiPledgePayment
    {
        [JsonProperty("installment_id")]
        public string InstallmentId { get; set; }

        [JsonProperty("payment_gift_id")]
        public string GiftId { get; set; }

        [JsonProperty("amount_applied")]
        public Gift2ApiPledgePaymentAmountType Amount { get; set; }
    }

    public class Gift2ApiPledgePaymentAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class SellStockGiftBodyInput
    {
        public SellStockGiftBodyInput(string saleDate, double saleValue)
        {
            this.SaleDate = saleDate;
            this.SaleValue = saleValue;
        }

        [JsonProperty("stock_sale_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string SaleDate { get; set; }

        [JsonProperty("stock_sale_value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double SaleValue { get; set; }

        [JsonProperty("broker_fee")]
        public double? BrokerFee { get; set; }

        [JsonProperty("post_status")]
        public CreateGiftBodyInputPostStatusType? PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("stock_issuer")]
        public BodyInputStockIssuerType StockIssuer { get; set; }
    }

    public class BodyInputStockIssuerType
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("symbol")]
        public string IssuerSymbol { get; set; }

        [JsonProperty("units")]
        public int? NumberOfUnits { get; set; }

        [JsonProperty("unit_price")]
        public double? MedianPricePerUnit { get; set; }
    }

    public class CreatePledgeBodyInput
    {
        public CreatePledgeBodyInput(BodyInputConstituentType constituent, CreateGiftBodyInputAmountType amount, string date, BodyInputScheduleType schedule, Gift2ApiNewGiftSplit[] splits)
        {
            this.Constituent = constituent;
            this.Amount = amount;
            this.Date = date;
            this.Schedule = schedule;
            this.Splits = splits;
        }

        [JsonProperty("constituent", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConstituentType Constituent { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputAmountType Amount { get; set; }

        [JsonProperty("gift_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("gift_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "Pledge";

        [JsonProperty("schedule", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputScheduleType Schedule { get; set; }

        [JsonProperty("gift_splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewGiftSplit[] Splits { get; set; }

        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputPaymentsType Payments { get; set; } = new CreatePledgeBodyInputPaymentsType();

        [JsonProperty("send_reminder")]
        public bool? SendReminder { get; set; }

        [JsonProperty("anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("gift_subtype")]
        public BodyInputGiftSubtypeType GiftSubtype { get; set; }

        [JsonProperty("comments")]
        public string Comment { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("gift_code")]
        public BodyInputGiftCodeType GiftCode { get; set; }

        [JsonProperty("gift_constituency")]
        public BodyInputGiftConstituencyType GiftConstituency { get; set; }

        [JsonProperty("gift_post_status")]
        public CreatePledgeBodyInputPostStatusType? PostStatus { get; set; }

        [JsonProperty("gift_post_date")]
        public string PostDate { get; set; }

        [JsonProperty("gift_status")]
        public CreatePledgeBodyInputStatusType? Status { get; set; }

        [JsonProperty("gift_status_date")]
        public BodyInputGiftStatusDateType GiftStatusDate { get; set; }

        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Origin { get; set; } = "{ \"name\": \"Power Platform\" }";

        [JsonProperty("receipts", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputReceiptsType Receipts { get; set; } = new CreatePledgeBodyInputReceiptsType();

        [JsonProperty("acknowledgements", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAcknowledgementsType Acknowledgements { get; set; } = new BodyInputAcknowledgementsType();

        [JsonProperty("recognition_credits")]
        public Gift2ApiNewRecognitionCredit[] Credits { get; set; }

        [JsonProperty("pledge_installments")]
        public Gift2ApiNewInstallment[] Installments { get; set; }
    }

    public class BodyInputConstituentType
    {
        public BodyInputConstituentType(string constituentId)
        {
            this.ConstituentId = constituentId;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string ConstituentId { get; set; }
    }

    public class BodyInputScheduleType
    {
        public BodyInputScheduleType(BodyInputScheduleTypeFrequencyType frequency, int ofInstallments, string startDate)
        {
            this.Frequency = frequency;
            this.OfInstallments = ofInstallments;
            this.StartDate = startDate;
        }

        [JsonProperty("frequency", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputScheduleTypeFrequencyType Frequency { get; set; }

        [JsonProperty("number_of_installments", DefaultValueHandling = DefaultValueHandling.Include)]
        public int OfInstallments { get; set; }

        [JsonProperty("start_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string StartDate { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputScheduleTypeFrequencyType
    {
        Annually,
        Quarterly,
        Monthly,
        [EnumMember(Value = "EVERY_TWO_WEEKS")]
        EveryTwoWeeks,
        Single,
        Irregular
    }

    public class Gift2ApiNewGiftSplit
    {
        public Gift2ApiNewGiftSplit(Gift2ApiNewGiftSplitAmountType amount, string fundId)
        {
            this.Amount = amount;
            this.FundId = fundId;
        }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewGiftSplitAmountType Amount { get; set; }

        [JsonProperty("fund_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string FundId { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }
    }

    public class Gift2ApiNewGiftSplitAmountType
    {
        public Gift2ApiNewGiftSplitAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    public class CreatePledgeBodyInputPaymentsType
    {
        [JsonProperty("method", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputPaymentsTypePaymentMethodType PaymentMethod { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.CreatePledgeBodyInputPaymentsTypePaymentMethodType.Cash;

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("reference_number")]
        public string Reference { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePledgeBodyInputPaymentsTypePaymentMethodType
    {
        Cash,
        Check,
        CreditCard,
        StandingOrder,
        DirectDebit,
        Voucher,
        Other,
        PayPal,
        Venmo
    }

    public class BodyInputGiftSubtypeType
    {
        [JsonProperty("name")]
        public string Subtype { get; set; }
    }

    public class BodyInputGiftCodeType
    {
        [JsonProperty("value")]
        public string GiftCode { get; set; }
    }

    public class BodyInputGiftConstituencyType
    {
        [JsonProperty("value")]
        public string Constituency { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePledgeBodyInputPostStatusType
    {
        [EnumMember(Value = "NotPosted")]
        PostToLedger,
        DoNotPost,
        Posted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePledgeBodyInputStatusType
    {
        Active,
        Held,
        Terminated,
        Completed,
        Canceled
    }

    public class BodyInputGiftStatusDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class CreatePledgeBodyInputReceiptsType
    {
        [JsonProperty("receipt_status", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputReceiptsTypeReceiptStatusType ReceiptStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.CreatePledgeBodyInputReceiptsTypeReceiptStatusType.NeedsReceipt;

        [JsonProperty("receipt_amount")]
        public BodyInputReceiptsTypeReceiptAmountType ReceiptAmount { get; set; }

        [JsonProperty("receipt_date")]
        public string ReceiptDate { get; set; }

        [JsonProperty("receipt_number")]
        public int? ReceiptNumber { get; set; }

        [JsonProperty("receipt_stack")]
        public BodyInputReceiptsTypeReceiptStackType ReceiptStack { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreatePledgeBodyInputReceiptsTypeReceiptStatusType
    {
        [EnumMember(Value = "NotReceipted")]
        NeedsReceipt,
        DoNotReceipt,
        Receipted
    }

    public class BodyInputReceiptsTypeReceiptAmountType
    {
        public BodyInputReceiptsTypeReceiptAmountType(double receiptAmount)
        {
            this.ReceiptAmount = receiptAmount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double ReceiptAmount { get; set; }
    }

    public class BodyInputReceiptsTypeReceiptStackType
    {
        [JsonProperty("value")]
        public string ReceiptStack { get; set; }
    }

    public class BodyInputAcknowledgementsType
    {
        [JsonProperty("status", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAcknowledgementsTypeAcknowledgeStatusType AcknowledgeStatus { get; set; } = global::Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts.BodyInputAcknowledgementsTypeAcknowledgeStatusType.NeedsAcknowledgement;

        [JsonProperty("acknowledgement_date")]
        public string AcknowledgeDate { get; set; }

        [JsonProperty("letter")]
        public BodyInputAcknowledgementsTypeLetterType Letter { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAcknowledgementsTypeAcknowledgeStatusType
    {
        [EnumMember(Value = "NotAcknowledged")]
        NeedsAcknowledgement,
        DoNotAcknowledge,
        Acknowledged
    }

    public class BodyInputAcknowledgementsTypeLetterType
    {
        [JsonProperty("value")]
        public string Letter { get; set; }
    }

    public class Gift2ApiNewRecognitionCredit
    {
        public Gift2ApiNewRecognitionCredit(Gift2ApiNewRecognitionCreditTypeType type, string recipientId, Gift2ApiNewRecognitionCreditAmountType amount)
        {
            this.Type = type;
            this.RecipientId = recipientId;
            this.Amount = amount;
        }

        [JsonProperty("credit_type", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewRecognitionCreditTypeType Type { get; set; }

        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public string RecipientId { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewRecognitionCreditAmountType Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Gift2ApiNewRecognitionCreditTypeType
    {
        SoftCredit,
        Fundraiser
    }

    public class Gift2ApiNewRecognitionCreditAmountType
    {
        public Gift2ApiNewRecognitionCreditAmountType(double amount)
        {
            this.Amount = amount;
        }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public double Amount { get; set; }
    }

    public class Gift2ApiNewInstallment
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public double? Amount { get; set; }
    }

    public class CreatePledgePaymentBodyInput
    {
        public CreatePledgePaymentBodyInput(BodyInputConstituentType constituent, CreateGiftBodyInputAmountType amount, string date, Gift2ApiNewGiftSplit[] splits, Gift2ApiNewInstallmentPayment[] applyTo)
        {
            this.Constituent = constituent;
            this.Amount = amount;
            this.Date = date;
            this.Splits = splits;
            this.ApplyTo = applyTo;
        }

        [JsonProperty("constituent", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConstituentType Constituent { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputAmountType Amount { get; set; }

        [JsonProperty("gift_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("gift_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "PledgePayment";

        [JsonProperty("gift_splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewGiftSplit[] Splits { get; set; }

        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputPaymentsType Payments { get; set; } = new CreatePledgeBodyInputPaymentsType();

        [JsonProperty("anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("installment_payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewInstallmentPayment[] ApplyTo { get; set; }

        [JsonProperty("gift_subtype")]
        public BodyInputGiftSubtypeType GiftSubtype { get; set; }

        [JsonProperty("comments")]
        public string Comment { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("gift_code")]
        public BodyInputGiftCodeType GiftCode { get; set; }

        [JsonProperty("gift_constituency")]
        public BodyInputGiftConstituencyType GiftConstituency { get; set; }

        [JsonProperty("gift_post_status")]
        public CreatePledgeBodyInputPostStatusType? PostStatus { get; set; }

        [JsonProperty("gift_post_date")]
        public string PostDate { get; set; }

        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Origin { get; set; } = "{ \"name\": \"Power Platform\" }";

        [JsonProperty("receipts", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputReceiptsType Receipts { get; set; } = new CreatePledgeBodyInputReceiptsType();

        [JsonProperty("acknowledgements", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAcknowledgementsType Acknowledgements { get; set; } = new BodyInputAcknowledgementsType();

        [JsonProperty("recognition_credits")]
        public Gift2ApiNewRecognitionCredit[] Credits { get; set; }
    }

    public class Gift2ApiNewInstallmentPayment
    {
        [JsonProperty("pledge_id")]
        public string Pledge { get; set; }

        [JsonProperty("installment_id")]
        public string Installment { get; set; }

        [JsonProperty("amount_applied")]
        public double? Amount { get; set; }
    }

    public class CreateStockBodyInput
    {
        public CreateStockBodyInput(BodyInputConstituentType constituent, CreateGiftBodyInputAmountType amount, string date, Gift2ApiNewGiftSplit[] splits)
        {
            this.Constituent = constituent;
            this.Amount = amount;
            this.Date = date;
            this.Splits = splits;
        }

        [JsonProperty("constituent", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputConstituentType Constituent { get; set; }

        [JsonProperty("amount", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateGiftBodyInputAmountType Amount { get; set; }

        [JsonProperty("gift_date", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Date { get; set; }

        [JsonProperty("gift_type", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Type { get; set; } = "Stock";

        [JsonProperty("issuer_details")]
        public BodyInputIssuerDetailsType IssuerDetails { get; set; }

        [JsonProperty("gift_splits", DefaultValueHandling = DefaultValueHandling.Include)]
        public Gift2ApiNewGiftSplit[] Splits { get; set; }

        [JsonProperty("payments", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputPaymentsType Payments { get; set; } = new CreatePledgeBodyInputPaymentsType();

        [JsonProperty("anonymous")]
        public bool? IsAnonymous { get; set; }

        [JsonProperty("gift_subtype")]
        public BodyInputGiftSubtypeType GiftSubtype { get; set; }

        [JsonProperty("comments")]
        public string Comment { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupId { get; set; }

        [JsonProperty("gift_code")]
        public BodyInputGiftCodeType GiftCode { get; set; }

        [JsonProperty("gift_constituency")]
        public BodyInputGiftConstituencyType GiftConstituency { get; set; }

        [JsonProperty("gift_post_status")]
        public CreatePledgeBodyInputPostStatusType? PostStatus { get; set; }

        [JsonProperty("gift_post_date")]
        public string PostDate { get; set; }

        [JsonProperty("origin", DefaultValueHandling = DefaultValueHandling.Include)]
        internal string Origin { get; set; } = "{ \"name\": \"Power Platform\" }";

        [JsonProperty("receipts", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreatePledgeBodyInputReceiptsType Receipts { get; set; } = new CreatePledgeBodyInputReceiptsType();

        [JsonProperty("acknowledgements", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputAcknowledgementsType Acknowledgements { get; set; } = new BodyInputAcknowledgementsType();

        [JsonProperty("recognition_credits")]
        public Gift2ApiNewRecognitionCredit[] Credits { get; set; }
    }

    public class BodyInputIssuerDetailsType
    {
        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("symbol")]
        public string IssuerSymbol { get; set; }

        [JsonProperty("units")]
        public int? NumberOfUnits { get; set; }

        [JsonProperty("unit_price")]
        public double? MedianPricePerUnit { get; set; }
    }

    public class NxtDataIntegrationApiTaxDeclarationCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NxtDataIntegrationApiTaxDeclaration[] Value { get; set; }
    }

    public class NxtDataIntegrationApiTaxDeclaration
    {
        [JsonProperty("declaration_id")]
        public int Id { get; set; }

        [JsonProperty("declaration_starts")]
        public string DeclarationStarts { get; set; }

        [JsonProperty("declaration_ends")]
        public string DeclarationEnds { get; set; }

        [JsonProperty("declaration_made")]
        public string DeclarationMade { get; set; }

        [JsonProperty("declaration_indicator_id")]
        public int IndicatorId { get; set; }

        [JsonProperty("declaration_indicator")]
        public string Indicator { get; set; }

        [JsonProperty("declaration_source_id")]
        public int SourceId { get; set; }

        [JsonProperty("declaration_source")]
        public string Source { get; set; }

        [JsonProperty("confirmation_sent")]
        public string ConfirmationSent { get; set; }

        [JsonProperty("confirmation_returned")]
        public string ConfirmationReturned { get; set; }

        [JsonProperty("constituent_pays_tax")]
        public NxtDataIntegrationApiTaxDeclarationPaysTaxType PaysTax { get; set; }

        [JsonProperty("tax_payer_status_id")]
        public int StatusId { get; set; }

        [JsonProperty("tax_payer_status")]
        public string Status { get; set; }

        [JsonProperty("tax_notes")]
        public string Comments { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NxtDataIntegrationApiTaxDeclarationPaysTaxType
    {
        No,
        Yes,
        Unknown
    }

    public class NxtDataIntegrationApiCreatedTaxDeclaration
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateTaxDeclarationBodyInput
    {
        public CreateTaxDeclarationBodyInput(int constituentId, string declarationStarts)
        {
            this.ConstituentId = constituentId;
            this.DeclarationStarts = declarationStarts;
        }

        [JsonProperty("constituent_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int ConstituentId { get; set; }

        [JsonProperty("declaration_starts", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DeclarationStarts { get; set; }

        [JsonProperty("declaration_ends")]
        public string DeclarationEnds { get; set; }

        [JsonProperty("declaration_made")]
        public string DeclarationMade { get; set; }

        [JsonProperty("declaration_indicator")]
        public string Indicator { get; set; }

        [JsonProperty("declaration_source")]
        public string Source { get; set; }

        [JsonProperty("confirmation_sent")]
        public string ConfirmationSent { get; set; }

        [JsonProperty("confirmation_returned")]
        public string ConfirmationReturned { get; set; }

        [JsonProperty("constituent_pays_tax")]
        public BodyInputPaysTaxType? PaysTax { get; set; }

        [JsonProperty("tax_payer_status")]
        public string Status { get; set; }

        [JsonProperty("tax_notes")]
        public string Comments { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputPaysTaxType
    {
        No,
        Yes,
        Unknown
    }

    public class EditTaxDeclarationBodyInput
    {
        [JsonProperty("declaration_starts")]
        public string DeclarationStarts { get; set; }

        [JsonProperty("declaration_ends")]
        public string DeclarationEnds { get; set; }

        [JsonProperty("declaration_made")]
        public string DeclarationMade { get; set; }

        [JsonProperty("declaration_indicator")]
        public string Indicator { get; set; }

        [JsonProperty("declaration_source")]
        public string Source { get; set; }

        [JsonProperty("confirmation_sent")]
        public string ConfirmationSent { get; set; }

        [JsonProperty("confirmation_returned")]
        public string ConfirmationReturned { get; set; }

        [JsonProperty("constituent_pays_tax")]
        public BodyInputPaysTaxType? PaysTax { get; set; }

        [JsonProperty("tax_payer_status")]
        public string Status { get; set; }

        [JsonProperty("tax_notes")]
        public string Comments { get; set; }

        [JsonProperty("sequence")]
        public int? Sequence { get; set; }
    }

    public class NxtDataIntegrationApiGiftIdMap
    {
        [JsonProperty("system_record_id")]
        public int Id { get; set; }
    }

    public class NxtDataIntegrationApiCreatedGiftNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGiftNoteBodyInput
    {
        public CreateGiftNoteBodyInput(int giftId, int type, BodyInputDateType date)
        {
            this.GiftId = giftId;
            this.Type = type;
            this.Date = date;
        }

        [JsonProperty("gift_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GiftId { get; set; }

        [JsonProperty("note_type_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Type { get; set; }

        [JsonProperty("date", DefaultValueHandling = DefaultValueHandling.Include)]
        public BodyInputDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }

    public class BodyInputDateType
    {
        [JsonProperty("d")]
        public int? Day { get; set; }

        [JsonProperty("m")]
        public int? Month { get; set; }

        [JsonProperty("y")]
        public int? Year { get; set; }
    }

    public class EditGiftNoteBodyInput
    {
        [JsonProperty("note_type_id")]
        public int? Type { get; set; }

        [JsonProperty("date")]
        public BodyInputDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }

    public class NxtDataIntegrationApiGiftNoteCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NxtDataIntegrationApiGiftNote[] Value { get; set; }
    }

    public class NxtDataIntegrationApiGiftNote
    {
        [JsonProperty("gift_id")]
        public int GiftId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public NxtDataIntegrationApiGiftNoteDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }

    public class NxtDataIntegrationApiGiftNoteDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NxtDataIntegrationApiCreatedGiftTribute
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateGiftTributeBodyInput
    {
        public CreateGiftTributeBodyInput(int giftId, int tributeId)
        {
            this.GiftId = giftId;
            this.TributeId = tributeId;
        }

        [JsonProperty("gift_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int GiftId { get; set; }

        [JsonProperty("tribute_id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int TributeId { get; set; }
    }

    public class EditGiftTributeBodyInput
    {
        [JsonProperty("tribute_type")]
        public int? TributeType { get; set; }

        [JsonProperty("acknowledge")]
        public BodyInputAcknowledgeStatusType? AcknowledgeStatus { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BodyInputAcknowledgeStatusType
    {
        Acknowledged,
        NotAcknowledged,
        DoNotAcknowledge
    }

    public class NxtDataIntegrationApiGiftTributeAcknowledgeeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NxtDataIntegrationApiGiftTributeAcknowledgee[] Value { get; set; }
    }

    public class NxtDataIntegrationApiGiftTributeAcknowledgee
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("gift_tribute_id")]
        public int GiftTributeId { get; set; }

        [JsonProperty("self_acknowledge")]
        public bool IsSelfAcknowledge { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipsId { get; set; }

        [JsonProperty("letter")]
        public int Letter { get; set; }

        [JsonProperty("letter_date")]
        public string LetterDate { get; set; }
    }

    public class NxtDataIntegrationApiGiftTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NxtDataIntegrationApiGiftTribute[] Value { get; set; }
    }

    public class NxtDataIntegrationApiGiftTribute
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("gift_id")]
        public int GiftId { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeId { get; set; }

        [JsonProperty("tribute_type")]
        public int TributeType { get; set; }

        [JsonProperty("acknowledge")]
        public NxtDataIntegrationApiGiftTributeAcknowledgeStatusType AcknowledgeStatus { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum NxtDataIntegrationApiGiftTributeAcknowledgeStatusType
    {
        Acknowledged,
        NotAcknowledged,
        DoNotAcknowledge
    }

    public class EditGiftTributeAcknowledgeeBodyInput
    {
        [JsonProperty("letter")]
        public int? Letter { get; set; }

        [JsonProperty("letter_date")]
        public string LetterDate { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts;

    public partial class WorkflowManagedActions
    {
        public BlackbaudgiftsActions Blackbaudgifts(string connectionId) => new BlackbaudgiftsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudgiftsTriggers Blackbaudgifts(string connectionId) => new BlackbaudgiftsTriggers(connectionId);
    }
}