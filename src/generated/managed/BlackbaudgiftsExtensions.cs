//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudgifts
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudgiftsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentFirstGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/first", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentGreatestGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/greatest", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentLatestGift(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/latest", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead> GetConstituentLifetimeGiving(Expression<Func<string>> constituentId)
        {
            var apiCallPath = String.Format("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftAcknowledgement(Expression<Func<string>> acknowledgementId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyletter = null)
        {
            var apiCallPath = String.Format("/gift/v1/giftacknowledgements/{0}", ExpressionConverter.ConvertWithUrlEncoding(acknowledgementId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyletter != null)
            {
                body["letter"] = ExpressionConverter.ConvertO(bodyletter);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftReceipt(Expression<Func<string>> receiptId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<double>> bodyamountamount = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodynumber = null)
        {
            var apiCallPath = String.Format("/gift/v1/giftreceipts/{0}", ExpressionConverter.ConvertWithUrlEncoding(receiptId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodystatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            var amountObject = new JObject();
            var amountObjectpropCount = 0;
            if (bodyamountamount != null)
            {
                amountObject["value"] = ExpressionConverter.ConvertO(bodyamountamount);
                amountObjectpropCount++;
            }

            if (amountObjectpropCount > 0)
            {
                body["amount"] = amountObject;
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodynumber != null)
            {
                body["number"] = ExpressionConverter.ConvertO(bodynumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead> ListGifts(Expression<Func<string>> listId = null, Expression<Func<string>> giftType = null, Expression<Func<string>> constituentId = null, Expression<Func<string>> campaignId = null, Expression<Func<string>> fundId = null, Expression<Func<string>> appealId = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> startGiftDate = null, Expression<Func<string>> endGiftDate = null, Expression<Func<double>> startGiftAmount = null, Expression<Func<double>> endGiftAmount = null, Expression<Func<string>> postStatus = null, Expression<Func<string>> receiptStatus = null, Expression<Func<string>> acknowledgementStatus = null, Expression<Func<string>> sort = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> lastModified = null)
        {
            var apiCallPath = "/gift/v1/gifts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (listId != null)
                callPayload.Queries["list_id"] = ExpressionConverter.Convert(listId);
            if (giftType != null)
                callPayload.Queries["gift_type"] = ExpressionConverter.Convert(giftType);
            if (constituentId != null)
                callPayload.Queries["constituent_id"] = ExpressionConverter.Convert(constituentId);
            if (campaignId != null)
                callPayload.Queries["campaign_id"] = ExpressionConverter.Convert(campaignId);
            if (fundId != null)
                callPayload.Queries["fund_id"] = ExpressionConverter.Convert(fundId);
            if (appealId != null)
                callPayload.Queries["appeal_id"] = ExpressionConverter.Convert(appealId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (startGiftDate != null)
                callPayload.Queries["start_gift_date"] = ExpressionConverter.Convert(startGiftDate);
            if (endGiftDate != null)
                callPayload.Queries["end_gift_date"] = ExpressionConverter.Convert(endGiftDate);
            if (startGiftAmount != null)
                callPayload.Queries["start_gift_amount"] = ExpressionConverter.Convert(startGiftAmount);
            if (endGiftAmount != null)
                callPayload.Queries["end_gift_amount"] = ExpressionConverter.Convert(endGiftAmount);
            if (postStatus != null)
                callPayload.Queries["post_status"] = ExpressionConverter.Convert(postStatus);
            if (receiptStatus != null)
                callPayload.Queries["receipt_status"] = ExpressionConverter.Convert(receiptStatus);
            if (acknowledgementStatus != null)
                callPayload.Queries["acknowledgement_status"] = ExpressionConverter.Convert(acknowledgementStatus);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiGiftRead> GetGift(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiGiftRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead> ListGiftAttachments(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead> ListGiftCustomFields(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/{0}/customfields", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment> CreateGiftAttachment(Expression<Func<string>> bodygiftID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileID = null, Expression<Func<string>> bodythumbnailID = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = "/gift/v1/gifts/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodygiftID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodyfileID != null)
            {
                body["file_id"] = ExpressionConverter.ConvertO(bodyfileID);
                bodypropCount++;
            }

            if (bodythumbnailID != null)
            {
                body["thumbnail_id"] = ExpressionConverter.ConvertO(bodythumbnailID);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/attachments/{0}", ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodytags != null)
            {
                body["tags"] = ExpressionConverter.ConvertO(bodytags);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField> CreateGiftCustomField(Expression<Func<string>> bodygiftID, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = "/gift/v1/gifts/customfields";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodygiftID);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var apiCallPath = String.Format("/gift/v1/gifts/customfields/{0}", ExpressionConverter.ConvertWithUrlEncoding(customFieldId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycategory != null)
            {
                body["category"] = ExpressionConverter.ConvertO(bodycategory);
                bodypropCount++;
            }

            if (bodyvalue != null)
            {
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                bodypropCount++;
            }

            if (bodydate != null)
            {
                body["date"] = ExpressionConverter.ConvertO(bodydate);
                bodypropCount++;
            }

            if (bodycomment != null)
            {
                body["comment"] = ExpressionConverter.ConvertO(bodycomment);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch> ListGiftBatches(Expression<Func<string>> batchNumber = null, Expression<Func<bool>> approved = null, Expression<Func<bool>> hasExceptions = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> searchText = null, Expression<Func<string>> createdBy = null)
        {
            var apiCallPath = "/gift-batch/v1/giftbatches";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (batchNumber != null)
                callPayload.Queries["batch_number"] = ExpressionConverter.Convert(batchNumber);
            if (approved != null)
                callPayload.Queries["approved"] = ExpressionConverter.Convert(approved);
            if (hasExceptions != null)
                callPayload.Queries["has_exceptions"] = ExpressionConverter.Convert(hasExceptions);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (createdBy != null)
                callPayload.Queries["created_by"] = ExpressionConverter.Convert(createdBy);
            return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch> CreateGiftBatch(Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyexpectedNumber = null, Expression<Func<double>> bodyexpectedTotal = null, Expression<Func<string>> bodybatchNumber = null)
        {
            var apiCallPath = "/gift-batch/v1/giftbatches";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["batch_description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyexpectedNumber != null)
            {
                body["expected_number"] = ExpressionConverter.ConvertO(bodyexpectedNumber);
                bodypropCount++;
            }

            if (bodyexpectedTotal != null)
            {
                body["expected_batch_total"] = ExpressionConverter.ConvertO(bodyexpectedTotal);
                bodypropCount++;
            }

            if (bodybatchNumber != null)
            {
                body["batch_number"] = ExpressionConverter.ConvertO(bodybatchNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GiftBatchApiCreatedBatch>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgeInstallmentCollection> ListPledgeInstallments(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gft-gifts/v2/gifts/{0}/installments", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Gift2ApiPledgeInstallmentCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgePaymentCollection> ListPledgePayments(Expression<Func<string>> giftId)
        {
            var apiCallPath = String.Format("/gft-gifts/v2/gifts/{0}/pledgepayments", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Gift2ApiPledgePaymentCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction SellStockGift(Expression<Func<string>> giftId, Expression<Func<string>> bodysaleDate, Expression<Func<double>> bodysaleValue, Expression<Func<double>> bodybrokerFee = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodystockIssuerissuer = null, Expression<Func<string>> bodystockIssuerissuerSymbol = null, Expression<Func<int>> bodystockIssuernumberOfUnits = null, Expression<Func<double>> bodystockIssuermedianPricePerUnit = null)
        {
            var apiCallPath = String.Format("/gft-gifts/v2/gifts/{0}/stock/sell", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["stock_sale_date"] = ExpressionConverter.ConvertO(bodysaleDate);
            bodypropCount++;
            body["stock_sale_value"] = ExpressionConverter.ConvertO(bodysaleValue);
            if (bodybrokerFee != null)
            {
                body["broker_fee"] = ExpressionConverter.ConvertO(bodybrokerFee);
                bodypropCount++;
            }

            if (bodypostStatus != null)
            {
                body["post_status"] = ExpressionConverter.ConvertO(bodypostStatus);
                bodypropCount++;
            }

            if (bodypostDate != null)
            {
                body["post_date"] = ExpressionConverter.ConvertO(bodypostDate);
                bodypropCount++;
            }

            if (bodynotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodynotes);
                bodypropCount++;
            }

            var stock_issuerObject = new JObject();
            var stock_issuerObjectpropCount = 0;
            if (bodystockIssuerissuer != null)
            {
                stock_issuerObject["issuer"] = ExpressionConverter.ConvertO(bodystockIssuerissuer);
                stock_issuerObjectpropCount++;
            }

            if (bodystockIssuerissuerSymbol != null)
            {
                stock_issuerObject["symbol"] = ExpressionConverter.ConvertO(bodystockIssuerissuerSymbol);
                stock_issuerObjectpropCount++;
            }

            if (bodystockIssuernumberOfUnits != null)
            {
                stock_issuerObject["units"] = ExpressionConverter.ConvertO(bodystockIssuernumberOfUnits);
                stock_issuerObjectpropCount++;
            }

            if (bodystockIssuermedianPricePerUnit != null)
            {
                stock_issuerObject["unit_price"] = ExpressionConverter.ConvertO(bodystockIssuermedianPricePerUnit);
                stock_issuerObjectpropCount++;
            }

            if (stock_issuerObjectpropCount > 0)
            {
                body["stock_issuer"] = stock_issuerObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTaxDeclarationCollection> ListConstituentTaxDeclarations(Expression<Func<int>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/giftaid/constituents/{0}/taxdeclarations", ExpressionConverter.ConvertWithUrlEncoding(constituentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NXTDataIntegrationApiTaxDeclarationCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTaxDeclaration> CreateTaxDeclaration(Expression<Func<int>> bodyconstituentID, Expression<Func<string>> bodydeclarationStarts, Expression<Func<string>> bodydeclarationEnds = null, Expression<Func<string>> bodydeclarationMade = null, Expression<Func<string>> bodyindicator = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconfirmationSent = null, Expression<Func<string>> bodyconfirmationReturned = null, Expression<Func<bodypaysTaxInput>> bodypaysTax = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/giftaid/taxdeclarations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["constituent_id"] = ExpressionConverter.ConvertO(bodyconstituentID);
            bodypropCount++;
            body["declaration_starts"] = ExpressionConverter.ConvertO(bodydeclarationStarts);
            if (bodydeclarationEnds != null)
            {
                body["declaration_ends"] = ExpressionConverter.ConvertO(bodydeclarationEnds);
                bodypropCount++;
            }

            if (bodydeclarationMade != null)
            {
                body["declaration_made"] = ExpressionConverter.ConvertO(bodydeclarationMade);
                bodypropCount++;
            }

            if (bodyindicator != null)
            {
                body["declaration_indicator"] = ExpressionConverter.ConvertO(bodyindicator);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["declaration_source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodyconfirmationSent != null)
            {
                body["confirmation_sent"] = ExpressionConverter.ConvertO(bodyconfirmationSent);
                bodypropCount++;
            }

            if (bodyconfirmationReturned != null)
            {
                body["confirmation_returned"] = ExpressionConverter.ConvertO(bodyconfirmationReturned);
                bodypropCount++;
            }

            if (bodypaysTax != null)
            {
                body["constituent_pays_tax"] = ExpressionConverter.ConvertO(bodypaysTax);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["tax_payer_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["tax_notes"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedTaxDeclaration>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditTaxDeclaration(Expression<Func<int>> taxDeclarationId, Expression<Func<string>> bodydeclarationStarts = null, Expression<Func<string>> bodydeclarationEnds = null, Expression<Func<string>> bodydeclarationMade = null, Expression<Func<string>> bodyindicator = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconfirmationSent = null, Expression<Func<string>> bodyconfirmationReturned = null, Expression<Func<bodypaysTaxInput>> bodypaysTax = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodysequence = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/giftaid/taxdeclarations/{0}", ExpressionConverter.ConvertWithUrlEncoding(taxDeclarationId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydeclarationStarts != null)
            {
                body["declaration_starts"] = ExpressionConverter.ConvertO(bodydeclarationStarts);
                bodypropCount++;
            }

            if (bodydeclarationEnds != null)
            {
                body["declaration_ends"] = ExpressionConverter.ConvertO(bodydeclarationEnds);
                bodypropCount++;
            }

            if (bodydeclarationMade != null)
            {
                body["declaration_made"] = ExpressionConverter.ConvertO(bodydeclarationMade);
                bodypropCount++;
            }

            if (bodyindicator != null)
            {
                body["declaration_indicator"] = ExpressionConverter.ConvertO(bodyindicator);
                bodypropCount++;
            }

            if (bodysource != null)
            {
                body["declaration_source"] = ExpressionConverter.ConvertO(bodysource);
                bodypropCount++;
            }

            if (bodyconfirmationSent != null)
            {
                body["confirmation_sent"] = ExpressionConverter.ConvertO(bodyconfirmationSent);
                bodypropCount++;
            }

            if (bodyconfirmationReturned != null)
            {
                body["confirmation_returned"] = ExpressionConverter.ConvertO(bodyconfirmationReturned);
                bodypropCount++;
            }

            if (bodypaysTax != null)
            {
                body["constituent_pays_tax"] = ExpressionConverter.ConvertO(bodypaysTax);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["tax_payer_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["tax_notes"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodysequence != null)
            {
                body["sequence"] = ExpressionConverter.ConvertO(bodysequence);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftIdMap> GetGiftIdFromLookupId(Expression<Func<string>> giftlookupid)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/giftidmap/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftlookupid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiGiftIdMap>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftNote(Expression<Func<int>> id, Expression<Func<int>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyauthor = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifts/notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytype != null)
            {
                body["note_type_id"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            var dateObject = new JObject();
            var dateObjectpropCount = 0;
            if (bodydateday != null)
            {
                dateObject["d"] = ExpressionConverter.ConvertO(bodydateday);
                dateObjectpropCount++;
            }

            if (bodydatemonth != null)
            {
                dateObject["m"] = ExpressionConverter.ConvertO(bodydatemonth);
                dateObjectpropCount++;
            }

            if (bodydateyear != null)
            {
                dateObject["y"] = ExpressionConverter.ConvertO(bodydateyear);
                dateObjectpropCount++;
            }

            if (dateObjectpropCount > 0)
            {
                body["date"] = dateObject;
                bodypropCount++;
            }

            if (bodysummary != null)
            {
                body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["text"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodyauthor != null)
            {
                body["author"] = ExpressionConverter.ConvertO(bodyauthor);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftNoteCollection> ListGiftNotes(Expression<Func<int>> giftId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifts/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<NXTDataIntegrationApiGiftNoteCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedGiftTribute> CreateGiftTribute(Expression<Func<int>> bodygiftID, Expression<Func<int>> bodytributeID)
        {
            var apiCallPath = "/nxt-data-integration/v1/re/gifttribute";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["gift_id"] = ExpressionConverter.ConvertO(bodygiftID);
            bodypropCount++;
            body["tribute_id"] = ExpressionConverter.ConvertO(bodytributeID);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedGiftTribute>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftTribute(Expression<Func<int>> giftTributeId, Expression<Func<int>> bodytributeType = null, Expression<Func<bodyacknowledgeStatusInput>> bodyacknowledgeStatus = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifttribute/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftTributeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodytributeType != null)
            {
                body["tribute_type"] = ExpressionConverter.ConvertO(bodytributeType);
                bodypropCount++;
            }

            if (bodyacknowledgeStatus != null)
            {
                body["acknowledge"] = ExpressionConverter.ConvertO(bodyacknowledgeStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection> ListGiftTributeAcknowledgees(Expression<Func<int>> giftTributeId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifttribute/{0}/acknowledgees", ExpressionConverter.ConvertWithUrlEncoding(giftTributeId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeCollection> ListGiftTributes(Expression<Func<int>> giftId)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifttribute/gift/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftTributeAcknowledgee(Expression<Func<int>> giftTributeAcknowledgeeId, Expression<Func<int>> bodyletter = null, Expression<Func<string>> bodyletterDate = null)
        {
            var apiCallPath = String.Format("/nxt-data-integration/v1/re/gifttribute/acknowledgees/{0}", ExpressionConverter.ConvertWithUrlEncoding(giftTributeAcknowledgeeId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyletter != null)
            {
                body["letter"] = ExpressionConverter.ConvertO(bodyletter);
                bodypropCount++;
            }

            if (bodyletterDate != null)
            {
                body["letter_date"] = ExpressionConverter.ConvertO(bodyletterDate);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class BlackbaudgiftsTriggers([ConnectionName] string connectionId)
    {
    }

    public class ConstituentApiGivingSummaryRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiCampaignRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class ConstituentApiFundRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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

    public enum bodystatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
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
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

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
        public string LookupID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitReadAmountType Amount { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("gift_aid_amount")]
        public GiftApiGiftSplitReadGiftAidAmountType GiftAidAmount { get; set; }

        [JsonProperty("gift_aid_qualification_status")]
        public string GiftAidQualificationStatus { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }
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
        public string FundraiserID { get; set; }
    }

    public class GiftApiGiftFundraiserReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class GiftApiSoftCreditRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("amount")]
        public GiftApiSoftCreditReadAmountType Amount { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }
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
        public string BBPSConfigurationID { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BBPSTransactionID { get; set; }

        [JsonProperty("check_date")]
        public GiftApiPaymentReadCheckDateType CheckDate { get; set; }

        [JsonProperty("check_number")]
        public string CheckNumber { get; set; }

        [JsonProperty("checkout_transaction_id")]
        public string CheckoutTransactionID { get; set; }

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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

        [JsonProperty("type")]
        public GiftApiGiftAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

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
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string GiftID { get; set; }

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
        public string ConstituentIDValue { get; set; }

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
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string ID { get; set; }

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
        public string ID { get; set; }
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

    public enum Gift2ApiPledgeInstallmentCollectionFrequencyType
    {
        Annually,
        [EnumMember(Value = "EVERY_SIX_MONTHS")]
        EVERYSIXMONTHS,
        Quarterly,
        Monthly,
        [EnumMember(Value = "EVERY_FOUR_WEEKS")]
        EVERYFOURWEEKS,
        [EnumMember(Value = "EVERY_TWO_WEEKS")]
        EVERYTWOWEEKS,
        Weekly,
        Irregular,
        Single
    }

    public class Gift2ApiPledgeInstallment
    {
        [JsonProperty("id")]
        public string ID { get; set; }

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
        public string InstallmentID { get; set; }

        [JsonProperty("payment_gift_id")]
        public string GiftID { get; set; }

        [JsonProperty("amount_applied")]
        public Gift2ApiPledgePaymentAmountType Amount { get; set; }
    }

    public class Gift2ApiPledgePaymentAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public enum bodypostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
    }

    public class NXTDataIntegrationApiTaxDeclarationCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTaxDeclaration[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTaxDeclaration
    {
        [JsonProperty("declaration_id")]
        public int ID { get; set; }

        [JsonProperty("declaration_starts")]
        public string DeclarationStarts { get; set; }

        [JsonProperty("declaration_ends")]
        public string DeclarationEnds { get; set; }

        [JsonProperty("declaration_made")]
        public string DeclarationMade { get; set; }

        [JsonProperty("declaration_indicator_id")]
        public int IndicatorID { get; set; }

        [JsonProperty("declaration_indicator")]
        public string Indicator { get; set; }

        [JsonProperty("declaration_source_id")]
        public int SourceID { get; set; }

        [JsonProperty("declaration_source")]
        public string Source { get; set; }

        [JsonProperty("confirmation_sent")]
        public string ConfirmationSent { get; set; }

        [JsonProperty("confirmation_returned")]
        public string ConfirmationReturned { get; set; }

        [JsonProperty("constituent_pays_tax")]
        public NXTDataIntegrationApiTaxDeclarationPaysTaxType PaysTax { get; set; }

        [JsonProperty("tax_payer_status_id")]
        public int StatusID { get; set; }

        [JsonProperty("tax_payer_status")]
        public string Status { get; set; }

        [JsonProperty("tax_notes")]
        public string Comments { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public enum NXTDataIntegrationApiTaxDeclarationPaysTaxType
    {
        No,
        Yes,
        Unknown
    }

    public class NXTDataIntegrationApiCreatedTaxDeclaration
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodypaysTaxInput
    {
        No,
        Yes,
        Unknown
    }

    public class NXTDataIntegrationApiGiftIdMap
    {
        [JsonProperty("system_record_id")]
        public int ID { get; set; }
    }

    public class NXTDataIntegrationApiGiftNoteCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiGiftNote[] Value { get; set; }
    }

    public class NXTDataIntegrationApiGiftNote
    {
        [JsonProperty("gift_id")]
        public int GiftID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public NXTDataIntegrationApiGiftNoteDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }
    }

    public class NXTDataIntegrationApiGiftNoteDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedGiftTribute
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyacknowledgeStatusInput
    {
        Acknowledged,
        NotAcknowledged,
        DoNotAcknowledge
    }

    public class NXTDataIntegrationApiGiftTributeAcknowledgeeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiGiftTributeAcknowledgee[] Value { get; set; }
    }

    public class NXTDataIntegrationApiGiftTributeAcknowledgee
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("gift_tribute_id")]
        public int GiftTributeID { get; set; }

        [JsonProperty("self_acknowledge")]
        public bool IsSelfAcknowledge { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipsID { get; set; }

        [JsonProperty("letter")]
        public int Letter { get; set; }

        [JsonProperty("letter_date")]
        public string LetterDate { get; set; }
    }

    public class NXTDataIntegrationApiGiftTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiGiftTribute[] Value { get; set; }
    }

    public class NXTDataIntegrationApiGiftTribute
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("gift_id")]
        public int GiftID { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeID { get; set; }

        [JsonProperty("tribute_type")]
        public int TributeType { get; set; }

        [JsonProperty("acknowledge")]
        public NXTDataIntegrationApiGiftTributeAcknowledgeStatusType AcknowledgeStatus { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public enum NXTDataIntegrationApiGiftTributeAcknowledgeStatusType
    {
        Acknowledged,
        NotAcknowledged,
        DoNotAcknowledge
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