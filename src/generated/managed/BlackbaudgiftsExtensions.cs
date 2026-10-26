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
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAcknowledgement(Expression<Func<string>> acknowledgementId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyletter = null)
        {
            var __workflow_acknowledgementId = WorkflowExpression.Compile(acknowledgementId, nameof(acknowledgementId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyletter = WorkflowExpression.Compile(bodyletter, nameof(bodyletter), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftacknowledgements/{0}", __workflow_acknowledgementId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyletter != null)
                {
                    body["letter"] = ExpressionConverter.ConvertO(__workflow_bodyletter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftReceipt(Expression<Func<string>> receiptId, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<double>> bodyamountamount = null, Expression<Func<string>> bodydate = null, Expression<Func<int>> bodynumber = null)
        {
            var __workflow_receiptId = WorkflowExpression.Compile(receiptId, nameof(receiptId), required: true);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/giftreceipts/{0}", __workflow_receiptId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodystatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodynumber != null)
                {
                    body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreateGift(Expression<Func<string>> bodyconstituentId, Expression<Func<string>> bodydate, Expression<Func<bodytypeInput>> bodytype, Expression<Func<GiftApiGiftSplitAdd[]>> bodysplits, Expression<Func<bodyreceiptsreceiptStatusInput>> bodyreceiptsreceiptStatus, Expression<Func<double>> bodyreceiptsamountreceiptAmount, Expression<Func<double>> bodyamountamount = null, Expression<Func<bodypaymentspaymentMethodInput>> bodypaymentspaymentMethod = null, Expression<Func<string>> bodypaymentscheckNumber = null, Expression<Func<int>> bodypaymentscheckDateday = null, Expression<Func<int>> bodypaymentscheckDatemonth = null, Expression<Func<int>> bodypaymentscheckDateyear = null, Expression<Func<string>> bodypaymentsreference = null, Expression<Func<int>> bodypaymentsreferenceDateday = null, Expression<Func<int>> bodypaymentsreferenceDatemonth = null, Expression<Func<int>> bodypaymentsreferenceDateyear = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodysubtype = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodylookupId = null, Expression<Func<bool>> bodyuseFundraiserCredits = null, Expression<Func<bool>> bodyuseSoftCredits = null, Expression<Func<string>> bodyconstituency = null, Expression<Func<string>> bodybatchPrefix = null, Expression<Func<string>> bodybatchNumber = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodyreceiptsreceiptDate = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyreceiptsreceiptStatus = WorkflowExpression.Compile(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            var __workflow_bodyreceiptsamountreceiptAmount = WorkflowExpression.Compile(bodyreceiptsamountreceiptAmount, nameof(bodyreceiptsamountreceiptAmount), required: true);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodypaymentspaymentMethod = WorkflowExpression.Compile(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            var __workflow_bodypaymentscheckNumber = WorkflowExpression.Compile(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            var __workflow_bodypaymentscheckDateday = WorkflowExpression.Compile(bodypaymentscheckDateday, nameof(bodypaymentscheckDateday), required: false);
            var __workflow_bodypaymentscheckDatemonth = WorkflowExpression.Compile(bodypaymentscheckDatemonth, nameof(bodypaymentscheckDatemonth), required: false);
            var __workflow_bodypaymentscheckDateyear = WorkflowExpression.Compile(bodypaymentscheckDateyear, nameof(bodypaymentscheckDateyear), required: false);
            var __workflow_bodypaymentsreference = WorkflowExpression.Compile(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            var __workflow_bodypaymentsreferenceDateday = WorkflowExpression.Compile(bodypaymentsreferenceDateday, nameof(bodypaymentsreferenceDateday), required: false);
            var __workflow_bodypaymentsreferenceDatemonth = WorkflowExpression.Compile(bodypaymentsreferenceDatemonth, nameof(bodypaymentsreferenceDatemonth), required: false);
            var __workflow_bodypaymentsreferenceDateyear = WorkflowExpression.Compile(bodypaymentsreferenceDateyear, nameof(bodypaymentsreferenceDateyear), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodysubtype = WorkflowExpression.Compile(bodysubtype, nameof(bodysubtype), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodyuseFundraiserCredits = WorkflowExpression.Compile(bodyuseFundraiserCredits, nameof(bodyuseFundraiserCredits), required: false);
            var __workflow_bodyuseSoftCredits = WorkflowExpression.Compile(bodyuseSoftCredits, nameof(bodyuseSoftCredits), required: false);
            var __workflow_bodyconstituency = WorkflowExpression.Compile(bodyconstituency, nameof(bodyconstituency), required: false);
            var __workflow_bodybatchPrefix = WorkflowExpression.Compile(bodybatchPrefix, nameof(bodybatchPrefix), required: false);
            var __workflow_bodybatchNumber = WorkflowExpression.Compile(bodybatchNumber, nameof(bodybatchNumber), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodyreceiptsreceiptDate = WorkflowExpression.Compile(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                bodypropCount++;
                body["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (__workflow_bodypaymentspaymentMethod != null)
                {
                    if (__workflow_bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["payment_method"] = ExpressionConverter.ConvertO(__workflow_bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["payment_method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (__workflow_bodypaymentscheckDateday != null)
                {
                    checkDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentsreference != null)
                {
                    paymentsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (__workflow_bodypaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodypaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodypaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["is_anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                if (__workflow_bodysubtype != null)
                {
                    body["subtype"] = ExpressionConverter.ConvertO(__workflow_bodysubtype);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                if (__workflow_bodyuseFundraiserCredits != null)
                {
                    body["default_fundraiser_credits"] = ExpressionConverter.ConvertO(__workflow_bodyuseFundraiserCredits);
                    bodypropCount++;
                }

                if (__workflow_bodyuseSoftCredits != null)
                {
                    body["default_soft_credits"] = ExpressionConverter.ConvertO(__workflow_bodyuseSoftCredits);
                    bodypropCount++;
                }

                if (__workflow_bodyconstituency != null)
                {
                    body["constituency"] = ExpressionConverter.ConvertO(__workflow_bodyconstituency);
                    bodypropCount++;
                }

                if (__workflow_bodybatchPrefix != null)
                {
                    body["batch_prefix"] = ExpressionConverter.ConvertO(__workflow_bodybatchPrefix);
                    bodypropCount++;
                }

                if (__workflow_bodybatchNumber != null)
                {
                    body["batch_number"] = ExpressionConverter.ConvertO(__workflow_bodybatchNumber);
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration> CreateGiftAttachment(Expression<Func<string>> bodygiftId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileName = null, Expression<Func<string>> bodyfileId = null, Expression<Func<string>> bodythumbnailId = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodyfileName = WorkflowExpression.Compile(bodyfileName, nameof(bodyfileName), required: false);
            var __workflow_bodyfileId = WorkflowExpression.Compile(bodyfileId, nameof(bodyfileId), required: false);
            var __workflow_bodythumbnailId = WorkflowExpression.Compile(bodythumbnailId, nameof(bodythumbnailId), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredBodyAction<GiftApiCreatedGiftAttachment, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["type"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodyfileName != null)
                {
                    body["file_name"] = ExpressionConverter.ConvertO(__workflow_bodyfileName);
                    bodypropCount++;
                }

                if (__workflow_bodyfileId != null)
                {
                    body["file_id"] = ExpressionConverter.ConvertO(__workflow_bodyfileId);
                    bodypropCount++;
                }

                if (__workflow_bodythumbnailId != null)
                {
                    body["thumbnail_id"] = ExpressionConverter.ConvertO(__workflow_bodythumbnailId);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftAttachment(Expression<Func<string>> attachmentId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodyuRL = null, Expression<Func<string[]>> bodytags = null)
        {
            var __workflow_attachmentId = WorkflowExpression.Compile(attachmentId, nameof(attachmentId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodyuRL = WorkflowExpression.Compile(bodyuRL, nameof(bodyuRL), required: false);
            var __workflow_bodytags = WorkflowExpression.Compile(bodytags, nameof(bodytags), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/attachments/{0}", __workflow_attachmentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodyuRL != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyuRL);
                    bodypropCount++;
                }

                if (__workflow_bodytags != null)
                {
                    body["tags"] = ExpressionConverter.ConvertO(__workflow_bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration> CreateGiftCustomField(Expression<Func<string>> bodygiftId, Expression<Func<string>> bodycategory, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredBodyAction<GiftApiCreatedGiftCustomField, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift/v1/gifts/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftCustomField(Expression<Func<string>> customFieldId, Expression<Func<string>> bodycategory = null, Expression<Func<object>> bodyvalue = null, Expression<Func<string>> bodydate = null, Expression<Func<string>> bodycomment = null)
        {
            var __workflow_customFieldId = WorkflowExpression.Compile(customFieldId, nameof(customFieldId), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/gifts/customfields/{0}", __workflow_customFieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycategory != null)
                {
                    body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (__workflow_bodydate != null)
                {
                    body["date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration> AddGiftToBatch(Expression<Func<string>> batchId, Expression<Func<double>> bodygiftsamountamount, Expression<Func<bodygiftspaymentspaymentMethodInput>> bodygiftspaymentspaymentMethod, Expression<Func<bodygiftsreceiptsreceiptStatusInput>> bodygiftsreceiptsreceiptStatus, Expression<Func<double>> bodygiftsreceiptsamountreceiptAmount, Expression<Func<string>> bodygiftsconstituentId = null, Expression<Func<string>> bodygiftsdate = null, Expression<Func<bodygiftstypeInput>> bodygiftstype = null, Expression<Func<GiftApiVirtualBatchGiftSplitAdd[]>> bodygiftssplits = null, Expression<Func<string>> bodygiftspaymentscheckNumber = null, Expression<Func<int>> bodygiftspaymentscheckDateday = null, Expression<Func<int>> bodygiftspaymentscheckDatemonth = null, Expression<Func<int>> bodygiftspaymentscheckDateyear = null, Expression<Func<string>> bodygiftspaymentsreference = null, Expression<Func<int>> bodygiftspaymentsreferenceDateday = null, Expression<Func<int>> bodygiftspaymentsreferenceDatemonth = null, Expression<Func<int>> bodygiftspaymentsreferenceDateyear = null, Expression<Func<bool>> bodygiftsisAnonymous = null, Expression<Func<string>> bodygiftssubtype = null, Expression<Func<string>> bodygiftscomment = null, Expression<Func<string>> bodygiftslookupId = null, Expression<Func<bool>> bodygiftsuseFundraiserCredits = null, Expression<Func<bool>> bodygiftsuseSoftCredits = null, Expression<Func<string>> bodygiftsconstituency = null, Expression<Func<bodygiftspostStatusInput>> bodygiftspostStatus = null, Expression<Func<string>> bodygiftspostDate = null, Expression<Func<string>> bodygiftsreceiptsreceiptDate = null)
        {
            var __workflow_batchId = WorkflowExpression.Compile(batchId, nameof(batchId), required: true);
            var __workflow_bodygiftsamountamount = WorkflowExpression.Compile(bodygiftsamountamount, nameof(bodygiftsamountamount), required: true);
            var __workflow_bodygiftspaymentspaymentMethod = WorkflowExpression.Compile(bodygiftspaymentspaymentMethod, nameof(bodygiftspaymentspaymentMethod), required: true);
            var __workflow_bodygiftsreceiptsreceiptStatus = WorkflowExpression.Compile(bodygiftsreceiptsreceiptStatus, nameof(bodygiftsreceiptsreceiptStatus), required: true);
            var __workflow_bodygiftsreceiptsamountreceiptAmount = WorkflowExpression.Compile(bodygiftsreceiptsamountreceiptAmount, nameof(bodygiftsreceiptsamountreceiptAmount), required: true);
            var __workflow_bodygiftsconstituentId = WorkflowExpression.Compile(bodygiftsconstituentId, nameof(bodygiftsconstituentId), required: false);
            var __workflow_bodygiftsdate = WorkflowExpression.Compile(bodygiftsdate, nameof(bodygiftsdate), required: false);
            var __workflow_bodygiftstype = WorkflowExpression.Compile(bodygiftstype, nameof(bodygiftstype), required: false);
            var __workflow_bodygiftssplits = WorkflowExpression.Compile(bodygiftssplits, nameof(bodygiftssplits), required: false);
            var __workflow_bodygiftspaymentscheckNumber = WorkflowExpression.Compile(bodygiftspaymentscheckNumber, nameof(bodygiftspaymentscheckNumber), required: false);
            var __workflow_bodygiftspaymentscheckDateday = WorkflowExpression.Compile(bodygiftspaymentscheckDateday, nameof(bodygiftspaymentscheckDateday), required: false);
            var __workflow_bodygiftspaymentscheckDatemonth = WorkflowExpression.Compile(bodygiftspaymentscheckDatemonth, nameof(bodygiftspaymentscheckDatemonth), required: false);
            var __workflow_bodygiftspaymentscheckDateyear = WorkflowExpression.Compile(bodygiftspaymentscheckDateyear, nameof(bodygiftspaymentscheckDateyear), required: false);
            var __workflow_bodygiftspaymentsreference = WorkflowExpression.Compile(bodygiftspaymentsreference, nameof(bodygiftspaymentsreference), required: false);
            var __workflow_bodygiftspaymentsreferenceDateday = WorkflowExpression.Compile(bodygiftspaymentsreferenceDateday, nameof(bodygiftspaymentsreferenceDateday), required: false);
            var __workflow_bodygiftspaymentsreferenceDatemonth = WorkflowExpression.Compile(bodygiftspaymentsreferenceDatemonth, nameof(bodygiftspaymentsreferenceDatemonth), required: false);
            var __workflow_bodygiftspaymentsreferenceDateyear = WorkflowExpression.Compile(bodygiftspaymentsreferenceDateyear, nameof(bodygiftspaymentsreferenceDateyear), required: false);
            var __workflow_bodygiftsisAnonymous = WorkflowExpression.Compile(bodygiftsisAnonymous, nameof(bodygiftsisAnonymous), required: false);
            var __workflow_bodygiftssubtype = WorkflowExpression.Compile(bodygiftssubtype, nameof(bodygiftssubtype), required: false);
            var __workflow_bodygiftscomment = WorkflowExpression.Compile(bodygiftscomment, nameof(bodygiftscomment), required: false);
            var __workflow_bodygiftslookupId = WorkflowExpression.Compile(bodygiftslookupId, nameof(bodygiftslookupId), required: false);
            var __workflow_bodygiftsuseFundraiserCredits = WorkflowExpression.Compile(bodygiftsuseFundraiserCredits, nameof(bodygiftsuseFundraiserCredits), required: false);
            var __workflow_bodygiftsuseSoftCredits = WorkflowExpression.Compile(bodygiftsuseSoftCredits, nameof(bodygiftsuseSoftCredits), required: false);
            var __workflow_bodygiftsconstituency = WorkflowExpression.Compile(bodygiftsconstituency, nameof(bodygiftsconstituency), required: false);
            var __workflow_bodygiftspostStatus = WorkflowExpression.Compile(bodygiftspostStatus, nameof(bodygiftspostStatus), required: false);
            var __workflow_bodygiftspostDate = WorkflowExpression.Compile(bodygiftspostDate, nameof(bodygiftspostDate), required: false);
            var __workflow_bodygiftsreceiptsreceiptDate = WorkflowExpression.Compile(bodygiftsreceiptsreceiptDate, nameof(bodygiftsreceiptsreceiptDate), required: false);
            return new DeferredBodyAction<GiftApiBatchGiftAddResults, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gift/v1/virtual/giftbatches/{0}/gifts", __workflow_batchId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var giftsObject = new JObject();
                var giftsObjectpropCount = 0;
                if (__workflow_bodygiftsconstituentId != null)
                {
                    giftsObject["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftsconstituentId);
                    giftsObjectpropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftsamountamount);
                if (amountObjectpropCount > 0)
                {
                    giftsObject["amount"] = amountObject;
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsdate != null)
                {
                    giftsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodygiftsdate);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftstype != null)
                {
                    giftsObject["type"] = ExpressionConverter.ConvertO(__workflow_bodygiftstype);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftssplits != null)
                {
                    giftsObject["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodygiftssplits);
                    giftsObjectpropCount++;
                }

                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                paymentsObjectpropCount++;
                paymentsObject["payment_method"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentspaymentMethod);
                if (__workflow_bodygiftspaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (__workflow_bodygiftspaymentscheckDateday != null)
                {
                    checkDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreference != null)
                {
                    paymentsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (__workflow_bodygiftspaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (__workflow_bodygiftspaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodygiftspaymentsreferenceDateyear);
                    referenceDateObjectpropCount++;
                }

                if (referenceDateObjectpropCount > 0)
                {
                    paymentsObject["reference_date"] = referenceDateObject;
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    giftsObject["payments"] = paymentsObject;
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsisAnonymous != null)
                {
                    giftsObject["is_anonymous"] = ExpressionConverter.ConvertO(__workflow_bodygiftsisAnonymous);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftssubtype != null)
                {
                    giftsObject["subtype"] = ExpressionConverter.ConvertO(__workflow_bodygiftssubtype);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftscomment != null)
                {
                    giftsObject["reference"] = ExpressionConverter.ConvertO(__workflow_bodygiftscomment);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftslookupId != null)
                {
                    giftsObject["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftslookupId);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsuseFundraiserCredits != null)
                {
                    giftsObject["default_fundraiser_credits"] = ExpressionConverter.ConvertO(__workflow_bodygiftsuseFundraiserCredits);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsuseSoftCredits != null)
                {
                    giftsObject["default_soft_credits"] = ExpressionConverter.ConvertO(__workflow_bodygiftsuseSoftCredits);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftsconstituency != null)
                {
                    giftsObject["constituency"] = ExpressionConverter.ConvertO(__workflow_bodygiftsconstituency);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftspostStatus != null)
                {
                    giftsObject["post_status"] = ExpressionConverter.ConvertO(__workflow_bodygiftspostStatus);
                    giftsObjectpropCount++;
                }

                if (__workflow_bodygiftspostDate != null)
                {
                    giftsObject["post_date"] = ExpressionConverter.ConvertO(__workflow_bodygiftspostDate);
                    giftsObjectpropCount++;
                }

                giftsObject["origin"] = "{ \"name\": \"Power Platform\" }";
                giftsObjectpropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodygiftsreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = ExpressionConverter.ConvertO(__workflow_bodygiftsreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    giftsObject["receipts"] = receiptsObject;
                    giftsObjectpropCount++;
                }

                if (giftsObjectpropCount > 0)
                {
                    body["gifts"] = giftsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration> CreateGiftBatch(Expression<Func<string>> bodydescription = null, Expression<Func<int>> bodyexpectedNumber = null, Expression<Func<double>> bodyexpectedTotal = null, Expression<Func<string>> bodybatchNumber = null)
        {
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyexpectedNumber = WorkflowExpression.Compile(bodyexpectedNumber, nameof(bodyexpectedNumber), required: false);
            var __workflow_bodyexpectedTotal = WorkflowExpression.Compile(bodyexpectedTotal, nameof(bodyexpectedTotal), required: false);
            var __workflow_bodybatchNumber = WorkflowExpression.Compile(bodybatchNumber, nameof(bodybatchNumber), required: false);
            return new DeferredBodyAction<GiftBatchApiCreatedBatch, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydescription != null)
                {
                    body["batch_description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedNumber != null)
                {
                    body["expected_number"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedNumber);
                    bodypropCount++;
                }

                if (__workflow_bodyexpectedTotal != null)
                {
                    body["expected_batch_total"] = ExpressionConverter.ConvertO(__workflow_bodyexpectedTotal);
                    bodypropCount++;
                }

                if (__workflow_bodybatchNumber != null)
                {
                    body["batch_number"] = ExpressionConverter.ConvertO(__workflow_bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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
        public IWorkflowAction<ApiConnectionActionConfiguration> SellStockGift(Expression<Func<string>> giftId, Expression<Func<string>> bodysaleDate, Expression<Func<double>> bodysaleValue, Expression<Func<double>> bodybrokerFee = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodynotes = null, Expression<Func<string>> bodystockIssuerissuer = null, Expression<Func<string>> bodystockIssuerissuerSymbol = null, Expression<Func<int>> bodystockIssuernumberOfUnits = null, Expression<Func<double>> bodystockIssuermedianPricePerUnit = null)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            var __workflow_bodysaleDate = WorkflowExpression.Compile(bodysaleDate, nameof(bodysaleDate), required: true);
            var __workflow_bodysaleValue = WorkflowExpression.Compile(bodysaleValue, nameof(bodysaleValue), required: true);
            var __workflow_bodybrokerFee = WorkflowExpression.Compile(bodybrokerFee, nameof(bodybrokerFee), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodynotes = WorkflowExpression.Compile(bodynotes, nameof(bodynotes), required: false);
            var __workflow_bodystockIssuerissuer = WorkflowExpression.Compile(bodystockIssuerissuer, nameof(bodystockIssuerissuer), required: false);
            var __workflow_bodystockIssuerissuerSymbol = WorkflowExpression.Compile(bodystockIssuerissuerSymbol, nameof(bodystockIssuerissuerSymbol), required: false);
            var __workflow_bodystockIssuernumberOfUnits = WorkflowExpression.Compile(bodystockIssuernumberOfUnits, nameof(bodystockIssuernumberOfUnits), required: false);
            var __workflow_bodystockIssuermedianPricePerUnit = WorkflowExpression.Compile(bodystockIssuermedianPricePerUnit, nameof(bodystockIssuermedianPricePerUnit), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/gft-gifts/v2/gifts/{0}/stock/sell", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stock_sale_date"] = ExpressionConverter.ConvertO(__workflow_bodysaleDate);
                bodypropCount++;
                body["stock_sale_value"] = ExpressionConverter.ConvertO(__workflow_bodysaleValue);
                if (__workflow_bodybrokerFee != null)
                {
                    body["broker_fee"] = ExpressionConverter.ConvertO(__workflow_bodybrokerFee);
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                if (__workflow_bodynotes != null)
                {
                    body["notes"] = ExpressionConverter.ConvertO(__workflow_bodynotes);
                    bodypropCount++;
                }

                var stockIssuerObject = new JObject();
                var stockIssuerObjectpropCount = 0;
                if (__workflow_bodystockIssuerissuer != null)
                {
                    stockIssuerObject["issuer"] = ExpressionConverter.ConvertO(__workflow_bodystockIssuerissuer);
                    stockIssuerObjectpropCount++;
                }

                if (__workflow_bodystockIssuerissuerSymbol != null)
                {
                    stockIssuerObject["symbol"] = ExpressionConverter.ConvertO(__workflow_bodystockIssuerissuerSymbol);
                    stockIssuerObjectpropCount++;
                }

                if (__workflow_bodystockIssuernumberOfUnits != null)
                {
                    stockIssuerObject["units"] = ExpressionConverter.ConvertO(__workflow_bodystockIssuernumberOfUnits);
                    stockIssuerObjectpropCount++;
                }

                if (__workflow_bodystockIssuermedianPricePerUnit != null)
                {
                    stockIssuerObject["unit_price"] = ExpressionConverter.ConvertO(__workflow_bodystockIssuermedianPricePerUnit);
                    stockIssuerObjectpropCount++;
                }

                if (stockIssuerObjectpropCount > 0)
                {
                    body["stock_issuer"] = stockIssuerObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreatePledge(Expression<Func<string>> bodydate, Expression<Func<Gift2ApiNewGiftSplit[]>> bodysplits, Expression<Func<bodyreceiptsreceiptStatusInput>> bodyreceiptsreceiptStatus, Expression<Func<double>> bodyreceiptsreceiptAmountreceiptAmount, Expression<Func<bodyacknowledgementsacknowledgeStatusInput>> bodyacknowledgementsacknowledgeStatus, Expression<Func<string>> bodyconstituentconstituentId = null, Expression<Func<double>> bodyamountamount = null, Expression<Func<bodyschedulefrequencyInput>> bodyschedulefrequency = null, Expression<Func<int>> bodyscheduleOfInstallments = null, Expression<Func<string>> bodyschedulestartDate = null, Expression<Func<bodypaymentspaymentMethodInput>> bodypaymentspaymentMethod = null, Expression<Func<string>> bodypaymentscheckNumber = null, Expression<Func<string>> bodypaymentsreference = null, Expression<Func<bool>> bodysendReminder = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodygiftSubtypesubtype = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodygiftCodegiftCode = null, Expression<Func<string>> bodygiftConstituencyconstituency = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<int>> bodygiftStatusDateday = null, Expression<Func<int>> bodygiftStatusDatemonth = null, Expression<Func<int>> bodygiftStatusDateyear = null, Expression<Func<string>> bodyreceiptsreceiptDate = null, Expression<Func<int>> bodyreceiptsreceiptNumber = null, Expression<Func<string>> bodyreceiptsreceiptStackreceiptStack = null, Expression<Func<string>> bodyacknowledgementsacknowledgeDate = null, Expression<Func<string>> bodyacknowledgementsletterletter = null, Expression<Func<Gift2ApiNewRecognitionCredit[]>> bodycredits = null, Expression<Func<Gift2ApiNewInstallment[]>> bodyinstallments = null)
        {
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyreceiptsreceiptStatus = WorkflowExpression.Compile(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            var __workflow_bodyreceiptsreceiptAmountreceiptAmount = WorkflowExpression.Compile(bodyreceiptsreceiptAmountreceiptAmount, nameof(bodyreceiptsreceiptAmountreceiptAmount), required: true);
            var __workflow_bodyacknowledgementsacknowledgeStatus = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeStatus, nameof(bodyacknowledgementsacknowledgeStatus), required: true);
            var __workflow_bodyconstituentconstituentId = WorkflowExpression.Compile(bodyconstituentconstituentId, nameof(bodyconstituentconstituentId), required: false);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodyschedulefrequency = WorkflowExpression.Compile(bodyschedulefrequency, nameof(bodyschedulefrequency), required: false);
            var __workflow_bodyscheduleOfInstallments = WorkflowExpression.Compile(bodyscheduleOfInstallments, nameof(bodyscheduleOfInstallments), required: false);
            var __workflow_bodyschedulestartDate = WorkflowExpression.Compile(bodyschedulestartDate, nameof(bodyschedulestartDate), required: false);
            var __workflow_bodypaymentspaymentMethod = WorkflowExpression.Compile(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            var __workflow_bodypaymentscheckNumber = WorkflowExpression.Compile(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            var __workflow_bodypaymentsreference = WorkflowExpression.Compile(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            var __workflow_bodysendReminder = WorkflowExpression.Compile(bodysendReminder, nameof(bodysendReminder), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodygiftSubtypesubtype = WorkflowExpression.Compile(bodygiftSubtypesubtype, nameof(bodygiftSubtypesubtype), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodygiftCodegiftCode = WorkflowExpression.Compile(bodygiftCodegiftCode, nameof(bodygiftCodegiftCode), required: false);
            var __workflow_bodygiftConstituencyconstituency = WorkflowExpression.Compile(bodygiftConstituencyconstituency, nameof(bodygiftConstituencyconstituency), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodygiftStatusDateday = WorkflowExpression.Compile(bodygiftStatusDateday, nameof(bodygiftStatusDateday), required: false);
            var __workflow_bodygiftStatusDatemonth = WorkflowExpression.Compile(bodygiftStatusDatemonth, nameof(bodygiftStatusDatemonth), required: false);
            var __workflow_bodygiftStatusDateyear = WorkflowExpression.Compile(bodygiftStatusDateyear, nameof(bodygiftStatusDateyear), required: false);
            var __workflow_bodyreceiptsreceiptDate = WorkflowExpression.Compile(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            var __workflow_bodyreceiptsreceiptNumber = WorkflowExpression.Compile(bodyreceiptsreceiptNumber, nameof(bodyreceiptsreceiptNumber), required: false);
            var __workflow_bodyreceiptsreceiptStackreceiptStack = WorkflowExpression.Compile(bodyreceiptsreceiptStackreceiptStack, nameof(bodyreceiptsreceiptStackreceiptStack), required: false);
            var __workflow_bodyacknowledgementsacknowledgeDate = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeDate, nameof(bodyacknowledgementsacknowledgeDate), required: false);
            var __workflow_bodyacknowledgementsletterletter = WorkflowExpression.Compile(bodyacknowledgementsletterletter, nameof(bodyacknowledgementsletterletter), required: false);
            var __workflow_bodycredits = WorkflowExpression.Compile(bodycredits, nameof(bodycredits), required: false);
            var __workflow_bodyinstallments = WorkflowExpression.Compile(bodyinstallments, nameof(bodyinstallments), required: false);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (__workflow_bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                body["gift_type"] = "Pledge";
                bodypropCount++;
                var scheduleObject = new JObject();
                var scheduleObjectpropCount = 0;
                if (__workflow_bodyschedulefrequency != null)
                {
                    scheduleObject["frequency"] = ExpressionConverter.ConvertO(__workflow_bodyschedulefrequency);
                    scheduleObjectpropCount++;
                }

                if (__workflow_bodyscheduleOfInstallments != null)
                {
                    scheduleObject["number_of_installments"] = ExpressionConverter.ConvertO(__workflow_bodyscheduleOfInstallments);
                    scheduleObjectpropCount++;
                }

                if (__workflow_bodyschedulestartDate != null)
                {
                    scheduleObject["start_date"] = ExpressionConverter.ConvertO(__workflow_bodyschedulestartDate);
                    scheduleObjectpropCount++;
                }

                if (scheduleObjectpropCount > 0)
                {
                    body["schedule"] = scheduleObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (__workflow_bodypaymentspaymentMethod != null)
                {
                    if (__workflow_bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = ExpressionConverter.ConvertO(__workflow_bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (__workflow_bodysendReminder != null)
                {
                    body["send_reminder"] = ExpressionConverter.ConvertO(__workflow_bodysendReminder);
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (__workflow_bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = ExpressionConverter.ConvertO(__workflow_bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (__workflow_bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (__workflow_bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["gift_post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["gift_post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["gift_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                var giftStatusDateObject = new JObject();
                var giftStatusDateObjectpropCount = 0;
                if (__workflow_bodygiftStatusDateday != null)
                {
                    giftStatusDateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodygiftStatusDateday);
                    giftStatusDateObjectpropCount++;
                }

                if (__workflow_bodygiftStatusDatemonth != null)
                {
                    giftStatusDateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodygiftStatusDatemonth);
                    giftStatusDateObjectpropCount++;
                }

                if (__workflow_bodygiftStatusDateyear != null)
                {
                    giftStatusDateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodygiftStatusDateyear);
                    giftStatusDateObjectpropCount++;
                }

                if (giftStatusDateObjectpropCount > 0)
                {
                    body["gift_status_date"] = giftStatusDateObject;
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["receipt_status"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (__workflow_bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStackreceiptStack);
                    receiptStackObjectpropCount++;
                }

                if (receiptStackObjectpropCount > 0)
                {
                    receiptsObject["receipt_stack"] = receiptStackObject;
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                var acknowledgementsObject = new JObject();
                var acknowledgementsObjectpropCount = 0;
                acknowledgementsObjectpropCount++;
                acknowledgementsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeStatus);
                if (__workflow_bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (__workflow_bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsletterletter);
                    letterObjectpropCount++;
                }

                if (letterObjectpropCount > 0)
                {
                    acknowledgementsObject["letter"] = letterObject;
                    acknowledgementsObjectpropCount++;
                }

                if (acknowledgementsObjectpropCount > 0)
                {
                    body["acknowledgements"] = acknowledgementsObject;
                    bodypropCount++;
                }

                if (__workflow_bodycredits != null)
                {
                    body["recognition_credits"] = ExpressionConverter.ConvertO(__workflow_bodycredits);
                    bodypropCount++;
                }

                if (__workflow_bodyinstallments != null)
                {
                    body["pledge_installments"] = ExpressionConverter.ConvertO(__workflow_bodyinstallments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreatePledgePayment(Expression<Func<string>> bodydate, Expression<Func<Gift2ApiNewGiftSplit[]>> bodysplits, Expression<Func<Gift2ApiNewInstallmentPayment[]>> bodyapplyTo, Expression<Func<bodyreceiptsreceiptStatusInput>> bodyreceiptsreceiptStatus, Expression<Func<double>> bodyreceiptsreceiptAmountreceiptAmount, Expression<Func<bodyacknowledgementsacknowledgeStatusInput>> bodyacknowledgementsacknowledgeStatus, Expression<Func<string>> bodyconstituentconstituentId = null, Expression<Func<double>> bodyamountamount = null, Expression<Func<bodypaymentspaymentMethodInput>> bodypaymentspaymentMethod = null, Expression<Func<string>> bodypaymentscheckNumber = null, Expression<Func<string>> bodypaymentsreference = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodygiftSubtypesubtype = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodygiftCodegiftCode = null, Expression<Func<string>> bodygiftConstituencyconstituency = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodyreceiptsreceiptDate = null, Expression<Func<int>> bodyreceiptsreceiptNumber = null, Expression<Func<string>> bodyreceiptsreceiptStackreceiptStack = null, Expression<Func<string>> bodyacknowledgementsacknowledgeDate = null, Expression<Func<string>> bodyacknowledgementsletterletter = null, Expression<Func<Gift2ApiNewRecognitionCredit[]>> bodycredits = null)
        {
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyapplyTo = WorkflowExpression.Compile(bodyapplyTo, nameof(bodyapplyTo), required: true);
            var __workflow_bodyreceiptsreceiptStatus = WorkflowExpression.Compile(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            var __workflow_bodyreceiptsreceiptAmountreceiptAmount = WorkflowExpression.Compile(bodyreceiptsreceiptAmountreceiptAmount, nameof(bodyreceiptsreceiptAmountreceiptAmount), required: true);
            var __workflow_bodyacknowledgementsacknowledgeStatus = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeStatus, nameof(bodyacknowledgementsacknowledgeStatus), required: true);
            var __workflow_bodyconstituentconstituentId = WorkflowExpression.Compile(bodyconstituentconstituentId, nameof(bodyconstituentconstituentId), required: false);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodypaymentspaymentMethod = WorkflowExpression.Compile(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            var __workflow_bodypaymentscheckNumber = WorkflowExpression.Compile(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            var __workflow_bodypaymentsreference = WorkflowExpression.Compile(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodygiftSubtypesubtype = WorkflowExpression.Compile(bodygiftSubtypesubtype, nameof(bodygiftSubtypesubtype), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodygiftCodegiftCode = WorkflowExpression.Compile(bodygiftCodegiftCode, nameof(bodygiftCodegiftCode), required: false);
            var __workflow_bodygiftConstituencyconstituency = WorkflowExpression.Compile(bodygiftConstituencyconstituency, nameof(bodygiftConstituencyconstituency), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodyreceiptsreceiptDate = WorkflowExpression.Compile(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            var __workflow_bodyreceiptsreceiptNumber = WorkflowExpression.Compile(bodyreceiptsreceiptNumber, nameof(bodyreceiptsreceiptNumber), required: false);
            var __workflow_bodyreceiptsreceiptStackreceiptStack = WorkflowExpression.Compile(bodyreceiptsreceiptStackreceiptStack, nameof(bodyreceiptsreceiptStackreceiptStack), required: false);
            var __workflow_bodyacknowledgementsacknowledgeDate = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeDate, nameof(bodyacknowledgementsacknowledgeDate), required: false);
            var __workflow_bodyacknowledgementsletterletter = WorkflowExpression.Compile(bodyacknowledgementsletterletter, nameof(bodyacknowledgementsletterletter), required: false);
            var __workflow_bodycredits = WorkflowExpression.Compile(bodycredits, nameof(bodycredits), required: false);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledgepayments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (__workflow_bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                body["gift_type"] = "PledgePayment";
                bodypropCount++;
                bodypropCount++;
                body["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (__workflow_bodypaymentspaymentMethod != null)
                {
                    if (__workflow_bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = ExpressionConverter.ConvertO(__workflow_bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                bodypropCount++;
                body["installment_payments"] = ExpressionConverter.ConvertO(__workflow_bodyapplyTo);
                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (__workflow_bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = ExpressionConverter.ConvertO(__workflow_bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (__workflow_bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (__workflow_bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["gift_post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["gift_post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["receipt_status"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (__workflow_bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStackreceiptStack);
                    receiptStackObjectpropCount++;
                }

                if (receiptStackObjectpropCount > 0)
                {
                    receiptsObject["receipt_stack"] = receiptStackObject;
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                var acknowledgementsObject = new JObject();
                var acknowledgementsObjectpropCount = 0;
                acknowledgementsObjectpropCount++;
                acknowledgementsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeStatus);
                if (__workflow_bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (__workflow_bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsletterletter);
                    letterObjectpropCount++;
                }

                if (letterObjectpropCount > 0)
                {
                    acknowledgementsObject["letter"] = letterObject;
                    acknowledgementsObjectpropCount++;
                }

                if (acknowledgementsObjectpropCount > 0)
                {
                    body["acknowledgements"] = acknowledgementsObject;
                    bodypropCount++;
                }

                if (__workflow_bodycredits != null)
                {
                    body["recognition_credits"] = ExpressionConverter.ConvertO(__workflow_bodycredits);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift, ApiConnectionActionConfiguration> CreateStock(Expression<Func<string>> bodydate, Expression<Func<Gift2ApiNewGiftSplit[]>> bodysplits, Expression<Func<bodyreceiptsreceiptStatusInput>> bodyreceiptsreceiptStatus, Expression<Func<double>> bodyreceiptsreceiptAmountreceiptAmount, Expression<Func<bodyacknowledgementsacknowledgeStatusInput>> bodyacknowledgementsacknowledgeStatus, Expression<Func<string>> bodyconstituentconstituentId = null, Expression<Func<double>> bodyamountamount = null, Expression<Func<string>> bodyissuerDetailsissuer = null, Expression<Func<string>> bodyissuerDetailsissuerSymbol = null, Expression<Func<int>> bodyissuerDetailsnumberOfUnits = null, Expression<Func<double>> bodyissuerDetailsmedianPricePerUnit = null, Expression<Func<bodypaymentspaymentMethodInput>> bodypaymentspaymentMethod = null, Expression<Func<string>> bodypaymentscheckNumber = null, Expression<Func<string>> bodypaymentsreference = null, Expression<Func<bool>> bodyisAnonymous = null, Expression<Func<string>> bodygiftSubtypesubtype = null, Expression<Func<string>> bodycomment = null, Expression<Func<string>> bodylookupId = null, Expression<Func<string>> bodygiftCodegiftCode = null, Expression<Func<string>> bodygiftConstituencyconstituency = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodyreceiptsreceiptDate = null, Expression<Func<int>> bodyreceiptsreceiptNumber = null, Expression<Func<string>> bodyreceiptsreceiptStackreceiptStack = null, Expression<Func<string>> bodyacknowledgementsacknowledgeDate = null, Expression<Func<string>> bodyacknowledgementsletterletter = null, Expression<Func<Gift2ApiNewRecognitionCredit[]>> bodycredits = null)
        {
            var __workflow_bodydate = WorkflowExpression.Compile(bodydate, nameof(bodydate), required: true);
            var __workflow_bodysplits = WorkflowExpression.Compile(bodysplits, nameof(bodysplits), required: true);
            var __workflow_bodyreceiptsreceiptStatus = WorkflowExpression.Compile(bodyreceiptsreceiptStatus, nameof(bodyreceiptsreceiptStatus), required: true);
            var __workflow_bodyreceiptsreceiptAmountreceiptAmount = WorkflowExpression.Compile(bodyreceiptsreceiptAmountreceiptAmount, nameof(bodyreceiptsreceiptAmountreceiptAmount), required: true);
            var __workflow_bodyacknowledgementsacknowledgeStatus = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeStatus, nameof(bodyacknowledgementsacknowledgeStatus), required: true);
            var __workflow_bodyconstituentconstituentId = WorkflowExpression.Compile(bodyconstituentconstituentId, nameof(bodyconstituentconstituentId), required: false);
            var __workflow_bodyamountamount = WorkflowExpression.Compile(bodyamountamount, nameof(bodyamountamount), required: false);
            var __workflow_bodyissuerDetailsissuer = WorkflowExpression.Compile(bodyissuerDetailsissuer, nameof(bodyissuerDetailsissuer), required: false);
            var __workflow_bodyissuerDetailsissuerSymbol = WorkflowExpression.Compile(bodyissuerDetailsissuerSymbol, nameof(bodyissuerDetailsissuerSymbol), required: false);
            var __workflow_bodyissuerDetailsnumberOfUnits = WorkflowExpression.Compile(bodyissuerDetailsnumberOfUnits, nameof(bodyissuerDetailsnumberOfUnits), required: false);
            var __workflow_bodyissuerDetailsmedianPricePerUnit = WorkflowExpression.Compile(bodyissuerDetailsmedianPricePerUnit, nameof(bodyissuerDetailsmedianPricePerUnit), required: false);
            var __workflow_bodypaymentspaymentMethod = WorkflowExpression.Compile(bodypaymentspaymentMethod, nameof(bodypaymentspaymentMethod), required: false);
            var __workflow_bodypaymentscheckNumber = WorkflowExpression.Compile(bodypaymentscheckNumber, nameof(bodypaymentscheckNumber), required: false);
            var __workflow_bodypaymentsreference = WorkflowExpression.Compile(bodypaymentsreference, nameof(bodypaymentsreference), required: false);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: false);
            var __workflow_bodygiftSubtypesubtype = WorkflowExpression.Compile(bodygiftSubtypesubtype, nameof(bodygiftSubtypesubtype), required: false);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: false);
            var __workflow_bodylookupId = WorkflowExpression.Compile(bodylookupId, nameof(bodylookupId), required: false);
            var __workflow_bodygiftCodegiftCode = WorkflowExpression.Compile(bodygiftCodegiftCode, nameof(bodygiftCodegiftCode), required: false);
            var __workflow_bodygiftConstituencyconstituency = WorkflowExpression.Compile(bodygiftConstituencyconstituency, nameof(bodygiftConstituencyconstituency), required: false);
            var __workflow_bodypostStatus = WorkflowExpression.Compile(bodypostStatus, nameof(bodypostStatus), required: false);
            var __workflow_bodypostDate = WorkflowExpression.Compile(bodypostDate, nameof(bodypostDate), required: false);
            var __workflow_bodyreceiptsreceiptDate = WorkflowExpression.Compile(bodyreceiptsreceiptDate, nameof(bodyreceiptsreceiptDate), required: false);
            var __workflow_bodyreceiptsreceiptNumber = WorkflowExpression.Compile(bodyreceiptsreceiptNumber, nameof(bodyreceiptsreceiptNumber), required: false);
            var __workflow_bodyreceiptsreceiptStackreceiptStack = WorkflowExpression.Compile(bodyreceiptsreceiptStackreceiptStack, nameof(bodyreceiptsreceiptStackreceiptStack), required: false);
            var __workflow_bodyacknowledgementsacknowledgeDate = WorkflowExpression.Compile(bodyacknowledgementsacknowledgeDate, nameof(bodyacknowledgementsacknowledgeDate), required: false);
            var __workflow_bodyacknowledgementsletterletter = WorkflowExpression.Compile(bodyacknowledgementsletterletter, nameof(bodyacknowledgementsletterletter), required: false);
            var __workflow_bodycredits = WorkflowExpression.Compile(bodycredits, nameof(bodycredits), required: false);
            return new DeferredBodyAction<GiftApiCreatedGift, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/gft-gifts/v2/virtual/stock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (__workflow_bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (__workflow_bodyamountamount != null)
                {
                    amountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = ExpressionConverter.ConvertO(__workflow_bodydate);
                body["gift_type"] = "Stock";
                bodypropCount++;
                var issuerDetailsObject = new JObject();
                var issuerDetailsObjectpropCount = 0;
                if (__workflow_bodyissuerDetailsissuer != null)
                {
                    issuerDetailsObject["issuer"] = ExpressionConverter.ConvertO(__workflow_bodyissuerDetailsissuer);
                    issuerDetailsObjectpropCount++;
                }

                if (__workflow_bodyissuerDetailsissuerSymbol != null)
                {
                    issuerDetailsObject["symbol"] = ExpressionConverter.ConvertO(__workflow_bodyissuerDetailsissuerSymbol);
                    issuerDetailsObjectpropCount++;
                }

                if (__workflow_bodyissuerDetailsnumberOfUnits != null)
                {
                    issuerDetailsObject["units"] = ExpressionConverter.ConvertO(__workflow_bodyissuerDetailsnumberOfUnits);
                    issuerDetailsObjectpropCount++;
                }

                if (__workflow_bodyissuerDetailsmedianPricePerUnit != null)
                {
                    issuerDetailsObject["unit_price"] = ExpressionConverter.ConvertO(__workflow_bodyissuerDetailsmedianPricePerUnit);
                    issuerDetailsObjectpropCount++;
                }

                if (issuerDetailsObjectpropCount > 0)
                {
                    body["issuer_details"] = issuerDetailsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_splits"] = ExpressionConverter.ConvertO(__workflow_bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (__workflow_bodypaymentspaymentMethod != null)
                {
                    if (__workflow_bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = ExpressionConverter.ConvertO(__workflow_bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (__workflow_bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = ExpressionConverter.ConvertO(__workflow_bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyisAnonymous != null)
                {
                    body["anonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                    bodypropCount++;
                }

                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (__workflow_bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = ExpressionConverter.ConvertO(__workflow_bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (__workflow_bodycomment != null)
                {
                    body["comments"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                    bodypropCount++;
                }

                if (__workflow_bodylookupId != null)
                {
                    body["lookup_id"] = ExpressionConverter.ConvertO(__workflow_bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (__workflow_bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (__workflow_bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = ExpressionConverter.ConvertO(__workflow_bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (__workflow_bodypostStatus != null)
                {
                    body["gift_post_status"] = ExpressionConverter.ConvertO(__workflow_bodypostStatus);
                    bodypropCount++;
                }

                if (__workflow_bodypostDate != null)
                {
                    body["gift_post_date"] = ExpressionConverter.ConvertO(__workflow_bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["receipt_status"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (__workflow_bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (__workflow_bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyreceiptsreceiptStackreceiptStack);
                    receiptStackObjectpropCount++;
                }

                if (receiptStackObjectpropCount > 0)
                {
                    receiptsObject["receipt_stack"] = receiptStackObject;
                    receiptsObjectpropCount++;
                }

                if (receiptsObjectpropCount > 0)
                {
                    body["receipts"] = receiptsObject;
                    bodypropCount++;
                }

                var acknowledgementsObject = new JObject();
                var acknowledgementsObjectpropCount = 0;
                acknowledgementsObjectpropCount++;
                acknowledgementsObject["status"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeStatus);
                if (__workflow_bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (__workflow_bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgementsletterletter);
                    letterObjectpropCount++;
                }

                if (letterObjectpropCount > 0)
                {
                    acknowledgementsObject["letter"] = letterObject;
                    acknowledgementsObjectpropCount++;
                }

                if (acknowledgementsObjectpropCount > 0)
                {
                    body["acknowledgements"] = acknowledgementsObject;
                    bodypropCount++;
                }

                if (__workflow_bodycredits != null)
                {
                    body["recognition_credits"] = ExpressionConverter.ConvertO(__workflow_bodycredits);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GiftApiCreatedGift>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTaxDeclarationCollection, ApiConnectionActionConfiguration> ListConstituentTaxDeclarations(Expression<Func<int>> constituentId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_constituentId = WorkflowExpression.Compile(constituentId, nameof(constituentId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiTaxDeclarationCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftaid/constituents/{0}/taxdeclarations", __workflow_constituentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NXTDataIntegrationApiTaxDeclarationCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTaxDeclaration, ApiConnectionActionConfiguration> CreateTaxDeclaration(Expression<Func<int>> bodyconstituentId, Expression<Func<string>> bodydeclarationStarts, Expression<Func<string>> bodydeclarationEnds = null, Expression<Func<string>> bodydeclarationMade = null, Expression<Func<string>> bodyindicator = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconfirmationSent = null, Expression<Func<string>> bodyconfirmationReturned = null, Expression<Func<bodypaysTaxInput>> bodypaysTax = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_bodyconstituentId = WorkflowExpression.Compile(bodyconstituentId, nameof(bodyconstituentId), required: true);
            var __workflow_bodydeclarationStarts = WorkflowExpression.Compile(bodydeclarationStarts, nameof(bodydeclarationStarts), required: true);
            var __workflow_bodydeclarationEnds = WorkflowExpression.Compile(bodydeclarationEnds, nameof(bodydeclarationEnds), required: false);
            var __workflow_bodydeclarationMade = WorkflowExpression.Compile(bodydeclarationMade, nameof(bodydeclarationMade), required: false);
            var __workflow_bodyindicator = WorkflowExpression.Compile(bodyindicator, nameof(bodyindicator), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyconfirmationSent = WorkflowExpression.Compile(bodyconfirmationSent, nameof(bodyconfirmationSent), required: false);
            var __workflow_bodyconfirmationReturned = WorkflowExpression.Compile(bodyconfirmationReturned, nameof(bodyconfirmationReturned), required: false);
            var __workflow_bodypaysTax = WorkflowExpression.Compile(bodypaysTax, nameof(bodypaysTax), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedTaxDeclaration, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/giftaid/taxdeclarations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = ExpressionConverter.ConvertO(__workflow_bodyconstituentId);
                bodypropCount++;
                body["declaration_starts"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationStarts);
                if (__workflow_bodydeclarationEnds != null)
                {
                    body["declaration_ends"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationEnds);
                    bodypropCount++;
                }

                if (__workflow_bodydeclarationMade != null)
                {
                    body["declaration_made"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationMade);
                    bodypropCount++;
                }

                if (__workflow_bodyindicator != null)
                {
                    body["declaration_indicator"] = ExpressionConverter.ConvertO(__workflow_bodyindicator);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["declaration_source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationSent != null)
                {
                    body["confirmation_sent"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationSent);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationReturned != null)
                {
                    body["confirmation_returned"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationReturned);
                    bodypropCount++;
                }

                if (__workflow_bodypaysTax != null)
                {
                    body["constituent_pays_tax"] = ExpressionConverter.ConvertO(__workflow_bodypaysTax);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["tax_payer_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["tax_notes"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NXTDataIntegrationApiCreatedTaxDeclaration>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditTaxDeclaration(Expression<Func<int>> taxDeclarationId, Expression<Func<string>> bodydeclarationStarts = null, Expression<Func<string>> bodydeclarationEnds = null, Expression<Func<string>> bodydeclarationMade = null, Expression<Func<string>> bodyindicator = null, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyconfirmationSent = null, Expression<Func<string>> bodyconfirmationReturned = null, Expression<Func<bodypaysTaxInput>> bodypaysTax = null, Expression<Func<string>> bodystatus = null, Expression<Func<string>> bodycomments = null, Expression<Func<int>> bodysequence = null)
        {
            var __workflow_taxDeclarationId = WorkflowExpression.Compile(taxDeclarationId, nameof(taxDeclarationId), required: true);
            var __workflow_bodydeclarationStarts = WorkflowExpression.Compile(bodydeclarationStarts, nameof(bodydeclarationStarts), required: false);
            var __workflow_bodydeclarationEnds = WorkflowExpression.Compile(bodydeclarationEnds, nameof(bodydeclarationEnds), required: false);
            var __workflow_bodydeclarationMade = WorkflowExpression.Compile(bodydeclarationMade, nameof(bodydeclarationMade), required: false);
            var __workflow_bodyindicator = WorkflowExpression.Compile(bodyindicator, nameof(bodyindicator), required: false);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyconfirmationSent = WorkflowExpression.Compile(bodyconfirmationSent, nameof(bodyconfirmationSent), required: false);
            var __workflow_bodyconfirmationReturned = WorkflowExpression.Compile(bodyconfirmationReturned, nameof(bodyconfirmationReturned), required: false);
            var __workflow_bodypaysTax = WorkflowExpression.Compile(bodypaysTax, nameof(bodypaysTax), required: false);
            var __workflow_bodystatus = WorkflowExpression.Compile(bodystatus, nameof(bodystatus), required: false);
            var __workflow_bodycomments = WorkflowExpression.Compile(bodycomments, nameof(bodycomments), required: false);
            var __workflow_bodysequence = WorkflowExpression.Compile(bodysequence, nameof(bodysequence), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftaid/taxdeclarations/{0}", __workflow_taxDeclarationId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodydeclarationStarts != null)
                {
                    body["declaration_starts"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationStarts);
                    bodypropCount++;
                }

                if (__workflow_bodydeclarationEnds != null)
                {
                    body["declaration_ends"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationEnds);
                    bodypropCount++;
                }

                if (__workflow_bodydeclarationMade != null)
                {
                    body["declaration_made"] = ExpressionConverter.ConvertO(__workflow_bodydeclarationMade);
                    bodypropCount++;
                }

                if (__workflow_bodyindicator != null)
                {
                    body["declaration_indicator"] = ExpressionConverter.ConvertO(__workflow_bodyindicator);
                    bodypropCount++;
                }

                if (__workflow_bodysource != null)
                {
                    body["declaration_source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationSent != null)
                {
                    body["confirmation_sent"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationSent);
                    bodypropCount++;
                }

                if (__workflow_bodyconfirmationReturned != null)
                {
                    body["confirmation_returned"] = ExpressionConverter.ConvertO(__workflow_bodyconfirmationReturned);
                    bodypropCount++;
                }

                if (__workflow_bodypaysTax != null)
                {
                    body["constituent_pays_tax"] = ExpressionConverter.ConvertO(__workflow_bodypaysTax);
                    bodypropCount++;
                }

                if (__workflow_bodystatus != null)
                {
                    body["tax_payer_status"] = ExpressionConverter.ConvertO(__workflow_bodystatus);
                    bodypropCount++;
                }

                if (__workflow_bodycomments != null)
                {
                    body["tax_notes"] = ExpressionConverter.ConvertO(__workflow_bodycomments);
                    bodypropCount++;
                }

                if (__workflow_bodysequence != null)
                {
                    body["sequence"] = ExpressionConverter.ConvertO(__workflow_bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftIdMap, ApiConnectionActionConfiguration> GetGiftIdFromLookupId(Expression<Func<string>> giftlookupid)
        {
            var __workflow_giftlookupid = WorkflowExpression.Compile(giftlookupid, nameof(giftlookupid), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiGiftIdMap, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/giftidmap/{0}", __workflow_giftlookupid.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiGiftIdMap>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedGiftNote, ApiConnectionActionConfiguration> CreateGiftNote(Expression<Func<int>> bodygiftId, Expression<Func<int>> bodytype, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyauthor = null)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: true);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyauthor = WorkflowExpression.Compile(bodyauthor, nameof(bodyauthor), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedGiftNote, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifts/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["note_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NXTDataIntegrationApiCreatedGiftNote>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftNote(Expression<Func<int>> id, Expression<Func<int>> bodytype = null, Expression<Func<int>> bodydateday = null, Expression<Func<int>> bodydatemonth = null, Expression<Func<int>> bodydateyear = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodynote = null, Expression<Func<string>> bodyauthor = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodytype = WorkflowExpression.Compile(bodytype, nameof(bodytype), required: false);
            var __workflow_bodydateday = WorkflowExpression.Compile(bodydateday, nameof(bodydateday), required: false);
            var __workflow_bodydatemonth = WorkflowExpression.Compile(bodydatemonth, nameof(bodydatemonth), required: false);
            var __workflow_bodydateyear = WorkflowExpression.Compile(bodydateyear, nameof(bodydateyear), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodynote = WorkflowExpression.Compile(bodynote, nameof(bodynote), required: false);
            var __workflow_bodyauthor = WorkflowExpression.Compile(bodyauthor, nameof(bodyauthor), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifts/notes/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytype != null)
                {
                    body["note_type_id"] = ExpressionConverter.ConvertO(__workflow_bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (__workflow_bodydateday != null)
                {
                    dateObject["d"] = ExpressionConverter.ConvertO(__workflow_bodydateday);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydatemonth != null)
                {
                    dateObject["m"] = ExpressionConverter.ConvertO(__workflow_bodydatemonth);
                    dateObjectpropCount++;
                }

                if (__workflow_bodydateyear != null)
                {
                    dateObject["y"] = ExpressionConverter.ConvertO(__workflow_bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodynote != null)
                {
                    body["text"] = ExpressionConverter.ConvertO(__workflow_bodynote);
                    bodypropCount++;
                }

                if (__workflow_bodyauthor != null)
                {
                    body["author"] = ExpressionConverter.ConvertO(__workflow_bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftNoteCollection, ApiConnectionActionConfiguration> ListGiftNotes(Expression<Func<int>> giftId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_offset = WorkflowExpression.Compile(offset, nameof(offset), required: false);
            return new DeferredBodyAction<NXTDataIntegrationApiGiftNoteCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifts/{0}/notes", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_offset != null)
                    callPayload.Queries["offset"] = ExpressionConverter.Convert(__workflow_offset);
                return new ApiConnectionAction<NXTDataIntegrationApiGiftNoteCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedGiftTribute, ApiConnectionActionConfiguration> CreateGiftTribute(Expression<Func<int>> bodygiftId, Expression<Func<int>> bodytributeId)
        {
            var __workflow_bodygiftId = WorkflowExpression.Compile(bodygiftId, nameof(bodygiftId), required: true);
            var __workflow_bodytributeId = WorkflowExpression.Compile(bodytributeId, nameof(bodytributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiCreatedGiftTribute, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifttribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = ExpressionConverter.ConvertO(__workflow_bodygiftId);
                bodypropCount++;
                body["tribute_id"] = ExpressionConverter.ConvertO(__workflow_bodytributeId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<NXTDataIntegrationApiCreatedGiftTribute>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftTribute(Expression<Func<int>> giftTributeId, Expression<Func<int>> bodytributeType = null, Expression<Func<bodyacknowledgeStatusInput>> bodyacknowledgeStatus = null)
        {
            var __workflow_giftTributeId = WorkflowExpression.Compile(giftTributeId, nameof(giftTributeId), required: true);
            var __workflow_bodytributeType = WorkflowExpression.Compile(bodytributeType, nameof(bodytributeType), required: false);
            var __workflow_bodyacknowledgeStatus = WorkflowExpression.Compile(bodyacknowledgeStatus, nameof(bodyacknowledgeStatus), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}", __workflow_giftTributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytributeType != null)
                {
                    body["tribute_type"] = ExpressionConverter.ConvertO(__workflow_bodytributeType);
                    bodypropCount++;
                }

                if (__workflow_bodyacknowledgeStatus != null)
                {
                    body["acknowledge"] = ExpressionConverter.ConvertO(__workflow_bodyacknowledgeStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection, ApiConnectionActionConfiguration> ListGiftTributeAcknowledgees(Expression<Func<int>> giftTributeId)
        {
            var __workflow_giftTributeId = WorkflowExpression.Compile(giftTributeId, nameof(giftTributeId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}/acknowledgees", __workflow_giftTributeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeCollection, ApiConnectionActionConfiguration> ListGiftTributes(Expression<Func<int>> giftId)
        {
            var __workflow_giftId = WorkflowExpression.Compile(giftId, nameof(giftId), required: true);
            return new DeferredBodyAction<NXTDataIntegrationApiGiftTributeCollection, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/gift/{0}", __workflow_giftId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeCollection>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction<ApiConnectionActionConfiguration> EditGiftTributeAcknowledgee(Expression<Func<int>> giftTributeAcknowledgeeId, Expression<Func<int>> bodyletter = null, Expression<Func<string>> bodyletterDate = null)
        {
            var __workflow_giftTributeAcknowledgeeId = WorkflowExpression.Compile(giftTributeAcknowledgeeId, nameof(giftTributeAcknowledgeeId), required: true);
            var __workflow_bodyletter = WorkflowExpression.Compile(bodyletter, nameof(bodyletter), required: false);
            var __workflow_bodyletterDate = WorkflowExpression.Compile(bodyletterDate, nameof(bodyletterDate), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/nxt-data-integration/v1/re/gifttribute/acknowledgees/{0}", __workflow_giftTributeAcknowledgeeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyletter != null)
                {
                    body["letter"] = ExpressionConverter.ConvertO(__workflow_bodyletter);
                    bodypropCount++;
                }

                if (__workflow_bodyletterDate != null)
                {
                    body["letter_date"] = ExpressionConverter.ConvertO(__workflow_bodyletterDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodystatusInput
    {
        Active,
        Held,
        Terminated,
        Completed,
        Canceled
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
        public string BBPSConfigurationId { get; set; }

        [JsonProperty("bbps_transaction_id")]
        public string BBPSTransactionId { get; set; }

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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class GiftApiGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreceiptsreceiptStatusInput
    {
        [EnumMember(Value = "NotReceipted")]
        NeedsReceipt,
        DoNotReceipt,
        Receipted
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypaymentspaymentMethodInput
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypostStatusInput
    {
        [EnumMember(Value = "NotPosted")]
        PostToLedger,
        DoNotPost,
        Posted
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
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailId { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

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

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftspaymentspaymentMethodInput
    {
        Cash,
        CreditCard,
        PersonalCheck,
        DirectDebit,
        Other,
        PayPal,
        Venmo
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftsreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftstypeInput
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiVirtualBatchGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignId { get; set; }

        [JsonProperty("fund_id")]
        public string FundId { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealId { get; set; }

        [JsonProperty("package_id")]
        public string PackageId { get; set; }

        [JsonProperty("amount")]
        public GiftApiVirtualBatchGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiVirtualBatchGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodygiftspostStatusInput
    {
        Posted,
        NotPosted,
        DoNotPost
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

    public class Gift2ApiNewGiftSplit
    {
        [JsonProperty("amount")]
        public Gift2ApiNewGiftSplitAmountType Amount { get; set; }

        [JsonProperty("fund_id")]
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
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyacknowledgementsacknowledgeStatusInput
    {
        [EnumMember(Value = "NotAcknowledged")]
        NeedsAcknowledgement,
        DoNotAcknowledge,
        Acknowledged
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyschedulefrequencyInput
    {
        Annually,
        Quarterly,
        Monthly,
        [EnumMember(Value = "EVERY_TWO_WEEKS")]
        EveryTwoWeeks,
        Single,
        Irregular
    }

    public class Gift2ApiNewRecognitionCredit
    {
        [JsonProperty("credit_type")]
        public Gift2ApiNewRecognitionCreditTypeType Type { get; set; }

        [JsonProperty("constituent_id")]
        public string RecipientId { get; set; }

        [JsonProperty("amount")]
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
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    public class Gift2ApiNewInstallment
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }

    public class Gift2ApiNewInstallmentPayment
    {
        [JsonProperty("pledge_id")]
        public string Pledge { get; set; }

        [JsonProperty("installment_id")]
        public string Installment { get; set; }

        [JsonProperty("amount_applied")]
        public double Amount { get; set; }
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
        public NXTDataIntegrationApiTaxDeclarationPaysTaxType PaysTax { get; set; }

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
    public enum NXTDataIntegrationApiTaxDeclarationPaysTaxType
    {
        No,
        Yes,
        Unknown
    }

    public class NXTDataIntegrationApiCreatedTaxDeclaration
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodypaysTaxInput
    {
        No,
        Yes,
        Unknown
    }

    public class NXTDataIntegrationApiGiftIdMap
    {
        [JsonProperty("system_record_id")]
        public int Id { get; set; }
    }

    public class NXTDataIntegrationApiCreatedGiftNote
    {
        [JsonProperty("id")]
        public string Id { get; set; }
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
        public int GiftId { get; set; }

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
        public string Id { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public int Id { get; set; }

        [JsonProperty("gift_id")]
        public int GiftId { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeId { get; set; }

        [JsonProperty("tribute_type")]
        public int TributeType { get; set; }

        [JsonProperty("acknowledge")]
        public NXTDataIntegrationApiGiftTributeAcknowledgeStatusType AcknowledgeStatus { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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