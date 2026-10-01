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
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentFirstGift([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/first", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentGreatestGift([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/greatest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiGivingSummaryRead> GetConstituentLatestGift([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/latest", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiGivingSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<ConstituentApiLifetimeGivingRead> GetConstituentLifetimeGiving([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/givingsummary/lifetimegiving", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiLifetimeGivingRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftAcknowledgement([WorkflowExpression] Func<string> acknowledgementId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyletter = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/giftacknowledgements/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(acknowledgementId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyletter != null)
                {
                    body["letter"] = SourceExpressionConverter.ConvertToken(bodyletter);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftReceipt([WorkflowExpression] Func<string> receiptId, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<int> bodynumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/giftreceipts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(receiptId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftRead> ListGifts([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<string> giftType = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<string> campaignId = null, [WorkflowExpression] Func<string> fundId = null, [WorkflowExpression] Func<string> appealId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> startGiftDate = null, [WorkflowExpression] Func<string> endGiftDate = null, [WorkflowExpression] Func<double> startGiftAmount = null, [WorkflowExpression] Func<double> endGiftAmount = null, [WorkflowExpression] Func<string> postStatus = null, [WorkflowExpression] Func<string> receiptStatus = null, [WorkflowExpression] Func<string> acknowledgementStatus = null, [WorkflowExpression] Func<string> sort = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (giftType != null)
                    callPayload.Queries["gift_type"] = SourceExpressionConverter.ConvertO(giftType);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (campaignId != null)
                    callPayload.Queries["campaign_id"] = SourceExpressionConverter.ConvertO(campaignId);
                if (fundId != null)
                    callPayload.Queries["fund_id"] = SourceExpressionConverter.ConvertO(fundId);
                if (appealId != null)
                    callPayload.Queries["appeal_id"] = SourceExpressionConverter.ConvertO(appealId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (startGiftDate != null)
                    callPayload.Queries["start_gift_date"] = SourceExpressionConverter.ConvertO(startGiftDate);
                if (endGiftDate != null)
                    callPayload.Queries["end_gift_date"] = SourceExpressionConverter.ConvertO(endGiftDate);
                if (startGiftAmount != null)
                    callPayload.Queries["start_gift_amount"] = SourceExpressionConverter.ConvertO(startGiftAmount);
                if (endGiftAmount != null)
                    callPayload.Queries["end_gift_amount"] = SourceExpressionConverter.ConvertO(endGiftAmount);
                if (postStatus != null)
                    callPayload.Queries["post_status"] = SourceExpressionConverter.ConvertO(postStatus);
                if (receiptStatus != null)
                    callPayload.Queries["receipt_status"] = SourceExpressionConverter.ConvertO(receiptStatus);
                if (acknowledgementStatus != null)
                    callPayload.Queries["acknowledgement_status"] = SourceExpressionConverter.ConvertO(acknowledgementStatus);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift> CreateGift([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<GiftApiGiftSplitAdd[]> bodysplits, [WorkflowExpression] Func<bodyreceiptsreceiptStatusInput> bodyreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodyreceiptsamountreceiptAmount, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<bodypaymentspaymentMethodInput> bodypaymentspaymentMethod = null, [WorkflowExpression] Func<string> bodypaymentscheckNumber = null, [WorkflowExpression] Func<int> bodypaymentscheckDateday = null, [WorkflowExpression] Func<int> bodypaymentscheckDatemonth = null, [WorkflowExpression] Func<int> bodypaymentscheckDateyear = null, [WorkflowExpression] Func<string> bodypaymentsreference = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDateday = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDatemonth = null, [WorkflowExpression] Func<int> bodypaymentsreferenceDateyear = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodysubtype = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<bool> bodyuseFundraiserCredits = null, [WorkflowExpression] Func<bool> bodyuseSoftCredits = null, [WorkflowExpression] Func<string> bodyconstituency = null, [WorkflowExpression] Func<string> bodybatchPrefix = null, [WorkflowExpression] Func<string> bodybatchNumber = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                bodypropCount++;
                body["gift_splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (bodypaymentspaymentMethod != null)
                {
                    if (bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["payment_method"] = SourceExpressionConverter.Convert(bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["payment_method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (bodypaymentscheckDateday != null)
                {
                    checkDateObject["d"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (bodypaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (bodypaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (bodypaymentsreference != null)
                {
                    paymentsObject["reference"] = SourceExpressionConverter.ConvertToken(bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (bodypaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (bodypaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (bodypaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = SourceExpressionConverter.ConvertToken(bodypaymentsreferenceDateyear);
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

                if (bodyisAnonymous != null)
                {
                    body["is_anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                if (bodysubtype != null)
                {
                    body["subtype"] = SourceExpressionConverter.ConvertToken(bodysubtype);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["reference"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodyuseFundraiserCredits != null)
                {
                    body["default_fundraiser_credits"] = SourceExpressionConverter.ConvertToken(bodyuseFundraiserCredits);
                    bodypropCount++;
                }

                if (bodyuseSoftCredits != null)
                {
                    body["default_soft_credits"] = SourceExpressionConverter.ConvertToken(bodyuseSoftCredits);
                    bodypropCount++;
                }

                if (bodyconstituency != null)
                {
                    body["constituency"] = SourceExpressionConverter.ConvertToken(bodyconstituency);
                    bodypropCount++;
                }

                if (bodybatchPrefix != null)
                {
                    body["batch_prefix"] = SourceExpressionConverter.ConvertToken(bodybatchPrefix);
                    bodypropCount++;
                }

                if (bodybatchNumber != null)
                {
                    body["batch_number"] = SourceExpressionConverter.ConvertToken(bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = SourceExpressionConverter.Convert(bodyreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptDate);
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
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGift>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiGiftRead> GetGift([WorkflowExpression] Func<string> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiGiftRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftAttachmentRead> ListGiftAttachments([WorkflowExpression] Func<string> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiApiCollectionOfGiftCustomFieldRead> ListGiftCustomFields([WorkflowExpression] Func<string> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiApiCollectionOfGiftCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftAttachment> CreateGiftAttachment([WorkflowExpression] Func<string> bodygiftId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGiftCustomField> CreateGiftCustomField([WorkflowExpression] Func<string> bodygiftId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift/v1/gifts/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGiftCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/gifts/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiBatchGiftAddResults> AddGiftToBatch([WorkflowExpression] Func<string> batchId, [WorkflowExpression] Func<double> bodygiftsamountamount, [WorkflowExpression] Func<bodygiftspaymentspaymentMethodInput> bodygiftspaymentspaymentMethod, [WorkflowExpression] Func<bodygiftsreceiptsreceiptStatusInput> bodygiftsreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodygiftsreceiptsamountreceiptAmount, [WorkflowExpression] Func<string> bodygiftsconstituentId = null, [WorkflowExpression] Func<string> bodygiftsdate = null, [WorkflowExpression] Func<bodygiftstypeInput> bodygiftstype = null, [WorkflowExpression] Func<GiftApiVirtualBatchGiftSplitAdd[]> bodygiftssplits = null, [WorkflowExpression] Func<string> bodygiftspaymentscheckNumber = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDateday = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDatemonth = null, [WorkflowExpression] Func<int> bodygiftspaymentscheckDateyear = null, [WorkflowExpression] Func<string> bodygiftspaymentsreference = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDateday = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDatemonth = null, [WorkflowExpression] Func<int> bodygiftspaymentsreferenceDateyear = null, [WorkflowExpression] Func<bool> bodygiftsisAnonymous = null, [WorkflowExpression] Func<string> bodygiftssubtype = null, [WorkflowExpression] Func<string> bodygiftscomment = null, [WorkflowExpression] Func<string> bodygiftslookupId = null, [WorkflowExpression] Func<bool> bodygiftsuseFundraiserCredits = null, [WorkflowExpression] Func<bool> bodygiftsuseSoftCredits = null, [WorkflowExpression] Func<string> bodygiftsconstituency = null, [WorkflowExpression] Func<bodygiftspostStatusInput> bodygiftspostStatus = null, [WorkflowExpression] Func<string> bodygiftspostDate = null, [WorkflowExpression] Func<string> bodygiftsreceiptsreceiptDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gift/v1/virtual/giftbatches/{0}/gifts", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(batchId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var giftsObject = new JObject();
                var giftsObjectpropCount = 0;
                if (bodygiftsconstituentId != null)
                {
                    giftsObject["constituent_id"] = SourceExpressionConverter.ConvertToken(bodygiftsconstituentId);
                    giftsObjectpropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftsamountamount);
                if (amountObjectpropCount > 0)
                {
                    giftsObject["amount"] = amountObject;
                    giftsObjectpropCount++;
                }

                if (bodygiftsdate != null)
                {
                    giftsObject["date"] = SourceExpressionConverter.ConvertToken(bodygiftsdate);
                    giftsObjectpropCount++;
                }

                if (bodygiftstype != null)
                {
                    giftsObject["type"] = SourceExpressionConverter.Convert(bodygiftstype);
                    giftsObjectpropCount++;
                }

                if (bodygiftssplits != null)
                {
                    giftsObject["gift_splits"] = SourceExpressionConverter.ConvertToken(bodygiftssplits);
                    giftsObjectpropCount++;
                }

                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                paymentsObjectpropCount++;
                paymentsObject["payment_method"] = SourceExpressionConverter.Convert(bodygiftspaymentspaymentMethod);
                if (bodygiftspaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                var checkDateObject = new JObject();
                var checkDateObjectpropCount = 0;
                if (bodygiftspaymentscheckDateday != null)
                {
                    checkDateObject["d"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDateday);
                    checkDateObjectpropCount++;
                }

                if (bodygiftspaymentscheckDatemonth != null)
                {
                    checkDateObject["m"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDatemonth);
                    checkDateObjectpropCount++;
                }

                if (bodygiftspaymentscheckDateyear != null)
                {
                    checkDateObject["y"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentscheckDateyear);
                    checkDateObjectpropCount++;
                }

                if (checkDateObjectpropCount > 0)
                {
                    paymentsObject["check_date"] = checkDateObject;
                    paymentsObjectpropCount++;
                }

                if (bodygiftspaymentsreference != null)
                {
                    paymentsObject["reference"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreference);
                    paymentsObjectpropCount++;
                }

                var referenceDateObject = new JObject();
                var referenceDateObjectpropCount = 0;
                if (bodygiftspaymentsreferenceDateday != null)
                {
                    referenceDateObject["d"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDateday);
                    referenceDateObjectpropCount++;
                }

                if (bodygiftspaymentsreferenceDatemonth != null)
                {
                    referenceDateObject["m"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDatemonth);
                    referenceDateObjectpropCount++;
                }

                if (bodygiftspaymentsreferenceDateyear != null)
                {
                    referenceDateObject["y"] = SourceExpressionConverter.ConvertToken(bodygiftspaymentsreferenceDateyear);
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

                if (bodygiftsisAnonymous != null)
                {
                    giftsObject["is_anonymous"] = SourceExpressionConverter.ConvertToken(bodygiftsisAnonymous);
                    giftsObjectpropCount++;
                }

                if (bodygiftssubtype != null)
                {
                    giftsObject["subtype"] = SourceExpressionConverter.ConvertToken(bodygiftssubtype);
                    giftsObjectpropCount++;
                }

                if (bodygiftscomment != null)
                {
                    giftsObject["reference"] = SourceExpressionConverter.ConvertToken(bodygiftscomment);
                    giftsObjectpropCount++;
                }

                if (bodygiftslookupId != null)
                {
                    giftsObject["lookup_id"] = SourceExpressionConverter.ConvertToken(bodygiftslookupId);
                    giftsObjectpropCount++;
                }

                if (bodygiftsuseFundraiserCredits != null)
                {
                    giftsObject["default_fundraiser_credits"] = SourceExpressionConverter.ConvertToken(bodygiftsuseFundraiserCredits);
                    giftsObjectpropCount++;
                }

                if (bodygiftsuseSoftCredits != null)
                {
                    giftsObject["default_soft_credits"] = SourceExpressionConverter.ConvertToken(bodygiftsuseSoftCredits);
                    giftsObjectpropCount++;
                }

                if (bodygiftsconstituency != null)
                {
                    giftsObject["constituency"] = SourceExpressionConverter.ConvertToken(bodygiftsconstituency);
                    giftsObjectpropCount++;
                }

                if (bodygiftspostStatus != null)
                {
                    giftsObject["post_status"] = SourceExpressionConverter.Convert(bodygiftspostStatus);
                    giftsObjectpropCount++;
                }

                if (bodygiftspostDate != null)
                {
                    giftsObject["post_date"] = SourceExpressionConverter.ConvertToken(bodygiftspostDate);
                    giftsObjectpropCount++;
                }

                giftsObject["origin"] = "{ \"name\": \"Power Platform\" }";
                giftsObjectpropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["status"] = SourceExpressionConverter.Convert(bodygiftsreceiptsreceiptStatus);
                var amountObject2 = new JObject();
                var amountObject2propCount = 0;
                amountObject2propCount++;
                amountObject2["value"] = SourceExpressionConverter.ConvertToken(bodygiftsreceiptsamountreceiptAmount);
                if (amountObject2propCount > 0)
                {
                    receiptsObject["amount"] = amountObject2;
                    receiptsObjectpropCount++;
                }

                if (bodygiftsreceiptsreceiptDate != null)
                {
                    receiptsObject["date"] = SourceExpressionConverter.ConvertToken(bodygiftsreceiptsreceiptDate);
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
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiBatchGiftAddResults>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiApiCollectionOfGiftBatch> ListGiftBatches([WorkflowExpression] Func<string> batchNumber = null, [WorkflowExpression] Func<bool> approved = null, [WorkflowExpression] Func<bool> hasExceptions = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> searchText = null, [WorkflowExpression] Func<string> createdBy = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (batchNumber != null)
                    callPayload.Queries["batch_number"] = SourceExpressionConverter.ConvertO(batchNumber);
                if (approved != null)
                    callPayload.Queries["approved"] = SourceExpressionConverter.ConvertO(approved);
                if (hasExceptions != null)
                    callPayload.Queries["has_exceptions"] = SourceExpressionConverter.ConvertO(hasExceptions);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (searchText != null)
                    callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (createdBy != null)
                    callPayload.Queries["created_by"] = SourceExpressionConverter.ConvertO(createdBy);
                return callPayload;
            }

            return new ApiConnectionAction<GiftBatchApiApiCollectionOfGiftBatch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftBatchApiCreatedBatch> CreateGiftBatch([WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodyexpectedNumber = null, [WorkflowExpression] Func<double> bodyexpectedTotal = null, [WorkflowExpression] Func<string> bodybatchNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gift-batch/v1/giftbatches";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydescription != null)
                {
                    body["batch_description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyexpectedNumber != null)
                {
                    body["expected_number"] = SourceExpressionConverter.ConvertToken(bodyexpectedNumber);
                    bodypropCount++;
                }

                if (bodyexpectedTotal != null)
                {
                    body["expected_batch_total"] = SourceExpressionConverter.ConvertToken(bodyexpectedTotal);
                    bodypropCount++;
                }

                if (bodybatchNumber != null)
                {
                    body["batch_number"] = SourceExpressionConverter.ConvertToken(bodybatchNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftBatchApiCreatedBatch>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgeInstallmentCollection> ListPledgeInstallments([WorkflowExpression] Func<string> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gft-gifts/v2/gifts/{0}/installments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Gift2ApiPledgeInstallmentCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<Gift2ApiPledgePaymentCollection> ListPledgePayments([WorkflowExpression] Func<string> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gft-gifts/v2/gifts/{0}/pledgepayments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<Gift2ApiPledgePaymentCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction SellStockGift([WorkflowExpression] Func<string> giftId, [WorkflowExpression] Func<string> bodysaleDate, [WorkflowExpression] Func<double> bodysaleValue, [WorkflowExpression] Func<double> bodybrokerFee = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<string> bodystockIssuerissuer = null, [WorkflowExpression] Func<string> bodystockIssuerissuerSymbol = null, [WorkflowExpression] Func<int> bodystockIssuernumberOfUnits = null, [WorkflowExpression] Func<double> bodystockIssuermedianPricePerUnit = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/gft-gifts/v2/gifts/{0}/stock/sell", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["stock_sale_date"] = SourceExpressionConverter.ConvertToken(bodysaleDate);
                bodypropCount++;
                body["stock_sale_value"] = SourceExpressionConverter.ConvertToken(bodysaleValue);
                if (bodybrokerFee != null)
                {
                    body["broker_fee"] = SourceExpressionConverter.ConvertToken(bodybrokerFee);
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                var stockIssuerObject = new JObject();
                var stockIssuerObjectpropCount = 0;
                if (bodystockIssuerissuer != null)
                {
                    stockIssuerObject["issuer"] = SourceExpressionConverter.ConvertToken(bodystockIssuerissuer);
                    stockIssuerObjectpropCount++;
                }

                if (bodystockIssuerissuerSymbol != null)
                {
                    stockIssuerObject["symbol"] = SourceExpressionConverter.ConvertToken(bodystockIssuerissuerSymbol);
                    stockIssuerObjectpropCount++;
                }

                if (bodystockIssuernumberOfUnits != null)
                {
                    stockIssuerObject["units"] = SourceExpressionConverter.ConvertToken(bodystockIssuernumberOfUnits);
                    stockIssuerObjectpropCount++;
                }

                if (bodystockIssuermedianPricePerUnit != null)
                {
                    stockIssuerObject["unit_price"] = SourceExpressionConverter.ConvertToken(bodystockIssuermedianPricePerUnit);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift> CreatePledge([WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<Gift2ApiNewGiftSplit[]> bodysplits, [WorkflowExpression] Func<bodyreceiptsreceiptStatusInput> bodyreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodyreceiptsreceiptAmountreceiptAmount, [WorkflowExpression] Func<bodyacknowledgementsacknowledgeStatusInput> bodyacknowledgementsacknowledgeStatus, [WorkflowExpression] Func<string> bodyconstituentconstituentId = null, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<bodyschedulefrequencyInput> bodyschedulefrequency = null, [WorkflowExpression] Func<int> bodyscheduleOfInstallments = null, [WorkflowExpression] Func<string> bodyschedulestartDate = null, [WorkflowExpression] Func<bodypaymentspaymentMethodInput> bodypaymentspaymentMethod = null, [WorkflowExpression] Func<string> bodypaymentscheckNumber = null, [WorkflowExpression] Func<string> bodypaymentsreference = null, [WorkflowExpression] Func<bool> bodysendReminder = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodygiftSubtypesubtype = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodygiftCodegiftCode = null, [WorkflowExpression] Func<string> bodygiftConstituencyconstituency = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<bodystatusInput> bodystatus = null, [WorkflowExpression] Func<int> bodygiftStatusDateday = null, [WorkflowExpression] Func<int> bodygiftStatusDatemonth = null, [WorkflowExpression] Func<int> bodygiftStatusDateyear = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptDate = null, [WorkflowExpression] Func<int> bodyreceiptsreceiptNumber = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptStackreceiptStack = null, [WorkflowExpression] Func<string> bodyacknowledgementsacknowledgeDate = null, [WorkflowExpression] Func<string> bodyacknowledgementsletterletter = null, [WorkflowExpression] Func<Gift2ApiNewRecognitionCredit[]> bodycredits = null, [WorkflowExpression] Func<Gift2ApiNewInstallment[]> bodyinstallments = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledges";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = SourceExpressionConverter.ConvertToken(bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                body["gift_type"] = "Pledge";
                bodypropCount++;
                var scheduleObject = new JObject();
                var scheduleObjectpropCount = 0;
                if (bodyschedulefrequency != null)
                {
                    scheduleObject["frequency"] = SourceExpressionConverter.Convert(bodyschedulefrequency);
                    scheduleObjectpropCount++;
                }

                if (bodyscheduleOfInstallments != null)
                {
                    scheduleObject["number_of_installments"] = SourceExpressionConverter.ConvertToken(bodyscheduleOfInstallments);
                    scheduleObjectpropCount++;
                }

                if (bodyschedulestartDate != null)
                {
                    scheduleObject["start_date"] = SourceExpressionConverter.ConvertToken(bodyschedulestartDate);
                    scheduleObjectpropCount++;
                }

                if (scheduleObjectpropCount > 0)
                {
                    body["schedule"] = scheduleObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (bodypaymentspaymentMethod != null)
                {
                    if (bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = SourceExpressionConverter.Convert(bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = SourceExpressionConverter.ConvertToken(bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (bodysendReminder != null)
                {
                    body["send_reminder"] = SourceExpressionConverter.ConvertToken(bodysendReminder);
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = SourceExpressionConverter.ConvertToken(bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["gift_post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["gift_post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["gift_status"] = SourceExpressionConverter.Convert(bodystatus);
                    bodypropCount++;
                }

                var giftStatusDateObject = new JObject();
                var giftStatusDateObjectpropCount = 0;
                if (bodygiftStatusDateday != null)
                {
                    giftStatusDateObject["d"] = SourceExpressionConverter.ConvertToken(bodygiftStatusDateday);
                    giftStatusDateObjectpropCount++;
                }

                if (bodygiftStatusDatemonth != null)
                {
                    giftStatusDateObject["m"] = SourceExpressionConverter.ConvertToken(bodygiftStatusDatemonth);
                    giftStatusDateObjectpropCount++;
                }

                if (bodygiftStatusDateyear != null)
                {
                    giftStatusDateObject["y"] = SourceExpressionConverter.ConvertToken(bodygiftStatusDateyear);
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
                receiptsObject["receipt_status"] = SourceExpressionConverter.Convert(bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptStackreceiptStack);
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
                acknowledgementsObject["status"] = SourceExpressionConverter.Convert(bodyacknowledgementsacknowledgeStatus);
                if (bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsletterletter);
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

                if (bodycredits != null)
                {
                    body["recognition_credits"] = SourceExpressionConverter.ConvertToken(bodycredits);
                    bodypropCount++;
                }

                if (bodyinstallments != null)
                {
                    body["pledge_installments"] = SourceExpressionConverter.ConvertToken(bodyinstallments);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGift>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift> CreatePledgePayment([WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<Gift2ApiNewGiftSplit[]> bodysplits, [WorkflowExpression] Func<Gift2ApiNewInstallmentPayment[]> bodyapplyTo, [WorkflowExpression] Func<bodyreceiptsreceiptStatusInput> bodyreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodyreceiptsreceiptAmountreceiptAmount, [WorkflowExpression] Func<bodyacknowledgementsacknowledgeStatusInput> bodyacknowledgementsacknowledgeStatus, [WorkflowExpression] Func<string> bodyconstituentconstituentId = null, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<bodypaymentspaymentMethodInput> bodypaymentspaymentMethod = null, [WorkflowExpression] Func<string> bodypaymentscheckNumber = null, [WorkflowExpression] Func<string> bodypaymentsreference = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodygiftSubtypesubtype = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodygiftCodegiftCode = null, [WorkflowExpression] Func<string> bodygiftConstituencyconstituency = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptDate = null, [WorkflowExpression] Func<int> bodyreceiptsreceiptNumber = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptStackreceiptStack = null, [WorkflowExpression] Func<string> bodyacknowledgementsacknowledgeDate = null, [WorkflowExpression] Func<string> bodyacknowledgementsletterletter = null, [WorkflowExpression] Func<Gift2ApiNewRecognitionCredit[]> bodycredits = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gft-gifts/v2/virtual/pledgepayments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = SourceExpressionConverter.ConvertToken(bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                body["gift_type"] = "PledgePayment";
                bodypropCount++;
                bodypropCount++;
                body["gift_splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (bodypaymentspaymentMethod != null)
                {
                    if (bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = SourceExpressionConverter.Convert(bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = SourceExpressionConverter.ConvertToken(bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                bodypropCount++;
                body["installment_payments"] = SourceExpressionConverter.ConvertToken(bodyapplyTo);
                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = SourceExpressionConverter.ConvertToken(bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["gift_post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["gift_post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["receipt_status"] = SourceExpressionConverter.Convert(bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptStackreceiptStack);
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
                acknowledgementsObject["status"] = SourceExpressionConverter.Convert(bodyacknowledgementsacknowledgeStatus);
                if (bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsletterletter);
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

                if (bodycredits != null)
                {
                    body["recognition_credits"] = SourceExpressionConverter.ConvertToken(bodycredits);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGift>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<GiftApiCreatedGift> CreateStock([WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<Gift2ApiNewGiftSplit[]> bodysplits, [WorkflowExpression] Func<bodyreceiptsreceiptStatusInput> bodyreceiptsreceiptStatus, [WorkflowExpression] Func<double> bodyreceiptsreceiptAmountreceiptAmount, [WorkflowExpression] Func<bodyacknowledgementsacknowledgeStatusInput> bodyacknowledgementsacknowledgeStatus, [WorkflowExpression] Func<string> bodyconstituentconstituentId = null, [WorkflowExpression] Func<double> bodyamountamount = null, [WorkflowExpression] Func<string> bodyissuerDetailsissuer = null, [WorkflowExpression] Func<string> bodyissuerDetailsissuerSymbol = null, [WorkflowExpression] Func<int> bodyissuerDetailsnumberOfUnits = null, [WorkflowExpression] Func<double> bodyissuerDetailsmedianPricePerUnit = null, [WorkflowExpression] Func<bodypaymentspaymentMethodInput> bodypaymentspaymentMethod = null, [WorkflowExpression] Func<string> bodypaymentscheckNumber = null, [WorkflowExpression] Func<string> bodypaymentsreference = null, [WorkflowExpression] Func<bool> bodyisAnonymous = null, [WorkflowExpression] Func<string> bodygiftSubtypesubtype = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodygiftCodegiftCode = null, [WorkflowExpression] Func<string> bodygiftConstituencyconstituency = null, [WorkflowExpression] Func<bodypostStatusInput> bodypostStatus = null, [WorkflowExpression] Func<string> bodypostDate = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptDate = null, [WorkflowExpression] Func<int> bodyreceiptsreceiptNumber = null, [WorkflowExpression] Func<string> bodyreceiptsreceiptStackreceiptStack = null, [WorkflowExpression] Func<string> bodyacknowledgementsacknowledgeDate = null, [WorkflowExpression] Func<string> bodyacknowledgementsletterletter = null, [WorkflowExpression] Func<Gift2ApiNewRecognitionCredit[]> bodycredits = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/gft-gifts/v2/virtual/stock";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var constituentObject = new JObject();
                var constituentObjectpropCount = 0;
                if (bodyconstituentconstituentId != null)
                {
                    constituentObject["id"] = SourceExpressionConverter.ConvertToken(bodyconstituentconstituentId);
                    constituentObjectpropCount++;
                }

                if (constituentObjectpropCount > 0)
                {
                    body["constituent"] = constituentObject;
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                if (bodyamountamount != null)
                {
                    amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                    amountObjectpropCount++;
                }

                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                body["gift_type"] = "Stock";
                bodypropCount++;
                var issuerDetailsObject = new JObject();
                var issuerDetailsObjectpropCount = 0;
                if (bodyissuerDetailsissuer != null)
                {
                    issuerDetailsObject["issuer"] = SourceExpressionConverter.ConvertToken(bodyissuerDetailsissuer);
                    issuerDetailsObjectpropCount++;
                }

                if (bodyissuerDetailsissuerSymbol != null)
                {
                    issuerDetailsObject["symbol"] = SourceExpressionConverter.ConvertToken(bodyissuerDetailsissuerSymbol);
                    issuerDetailsObjectpropCount++;
                }

                if (bodyissuerDetailsnumberOfUnits != null)
                {
                    issuerDetailsObject["units"] = SourceExpressionConverter.ConvertToken(bodyissuerDetailsnumberOfUnits);
                    issuerDetailsObjectpropCount++;
                }

                if (bodyissuerDetailsmedianPricePerUnit != null)
                {
                    issuerDetailsObject["unit_price"] = SourceExpressionConverter.ConvertToken(bodyissuerDetailsmedianPricePerUnit);
                    issuerDetailsObjectpropCount++;
                }

                if (issuerDetailsObjectpropCount > 0)
                {
                    body["issuer_details"] = issuerDetailsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["gift_splits"] = SourceExpressionConverter.ConvertToken(bodysplits);
                var paymentsObject = new JObject();
                var paymentsObjectpropCount = 0;
                if (bodypaymentspaymentMethod != null)
                {
                    if (bodypaymentspaymentMethod != null)
                    {
                        paymentsObject["method"] = SourceExpressionConverter.Convert(bodypaymentspaymentMethod);
                        paymentsObjectpropCount++;
                    }

                    paymentsObjectpropCount++;
                }
                else
                {
                    paymentsObject["method"] = "Cash";
                    paymentsObjectpropCount++;
                }

                if (bodypaymentscheckNumber != null)
                {
                    paymentsObject["check_number"] = SourceExpressionConverter.ConvertToken(bodypaymentscheckNumber);
                    paymentsObjectpropCount++;
                }

                if (bodypaymentsreference != null)
                {
                    paymentsObject["reference_number"] = SourceExpressionConverter.ConvertToken(bodypaymentsreference);
                    paymentsObjectpropCount++;
                }

                if (paymentsObjectpropCount > 0)
                {
                    body["payments"] = paymentsObject;
                    bodypropCount++;
                }

                if (bodyisAnonymous != null)
                {
                    body["anonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                    bodypropCount++;
                }

                var giftSubtypeObject = new JObject();
                var giftSubtypeObjectpropCount = 0;
                if (bodygiftSubtypesubtype != null)
                {
                    giftSubtypeObject["name"] = SourceExpressionConverter.ConvertToken(bodygiftSubtypesubtype);
                    giftSubtypeObjectpropCount++;
                }

                if (giftSubtypeObjectpropCount > 0)
                {
                    body["gift_subtype"] = giftSubtypeObject;
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comments"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var giftCodeObject = new JObject();
                var giftCodeObjectpropCount = 0;
                if (bodygiftCodegiftCode != null)
                {
                    giftCodeObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftCodegiftCode);
                    giftCodeObjectpropCount++;
                }

                if (giftCodeObjectpropCount > 0)
                {
                    body["gift_code"] = giftCodeObject;
                    bodypropCount++;
                }

                var giftConstituencyObject = new JObject();
                var giftConstituencyObjectpropCount = 0;
                if (bodygiftConstituencyconstituency != null)
                {
                    giftConstituencyObject["value"] = SourceExpressionConverter.ConvertToken(bodygiftConstituencyconstituency);
                    giftConstituencyObjectpropCount++;
                }

                if (giftConstituencyObjectpropCount > 0)
                {
                    body["gift_constituency"] = giftConstituencyObject;
                    bodypropCount++;
                }

                if (bodypostStatus != null)
                {
                    body["gift_post_status"] = SourceExpressionConverter.Convert(bodypostStatus);
                    bodypropCount++;
                }

                if (bodypostDate != null)
                {
                    body["gift_post_date"] = SourceExpressionConverter.ConvertToken(bodypostDate);
                    bodypropCount++;
                }

                body["origin"] = "{ \"name\": \"Power Platform\" }";
                bodypropCount++;
                var receiptsObject = new JObject();
                var receiptsObjectpropCount = 0;
                receiptsObjectpropCount++;
                receiptsObject["receipt_status"] = SourceExpressionConverter.Convert(bodyreceiptsreceiptStatus);
                var receiptAmountObject = new JObject();
                var receiptAmountObjectpropCount = 0;
                receiptAmountObjectpropCount++;
                receiptAmountObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptAmountreceiptAmount);
                if (receiptAmountObjectpropCount > 0)
                {
                    receiptsObject["receipt_amount"] = receiptAmountObject;
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptDate != null)
                {
                    receiptsObject["receipt_date"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptDate);
                    receiptsObjectpropCount++;
                }

                if (bodyreceiptsreceiptNumber != null)
                {
                    receiptsObject["receipt_number"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptNumber);
                    receiptsObjectpropCount++;
                }

                var receiptStackObject = new JObject();
                var receiptStackObjectpropCount = 0;
                if (bodyreceiptsreceiptStackreceiptStack != null)
                {
                    receiptStackObject["value"] = SourceExpressionConverter.ConvertToken(bodyreceiptsreceiptStackreceiptStack);
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
                acknowledgementsObject["status"] = SourceExpressionConverter.Convert(bodyacknowledgementsacknowledgeStatus);
                if (bodyacknowledgementsacknowledgeDate != null)
                {
                    acknowledgementsObject["acknowledgement_date"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsacknowledgeDate);
                    acknowledgementsObjectpropCount++;
                }

                var letterObject = new JObject();
                var letterObjectpropCount = 0;
                if (bodyacknowledgementsletterletter != null)
                {
                    letterObject["value"] = SourceExpressionConverter.ConvertToken(bodyacknowledgementsletterletter);
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

                if (bodycredits != null)
                {
                    body["recognition_credits"] = SourceExpressionConverter.ConvertToken(bodycredits);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GiftApiCreatedGift>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTaxDeclarationCollection> ListConstituentTaxDeclarations([WorkflowExpression] Func<int> constituentId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/giftaid/constituents/{0}/taxdeclarations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiTaxDeclarationCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTaxDeclaration> CreateTaxDeclaration([WorkflowExpression] Func<int> bodyconstituentId, [WorkflowExpression] Func<string> bodydeclarationStarts, [WorkflowExpression] Func<string> bodydeclarationEnds = null, [WorkflowExpression] Func<string> bodydeclarationMade = null, [WorkflowExpression] Func<string> bodyindicator = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyconfirmationSent = null, [WorkflowExpression] Func<string> bodyconfirmationReturned = null, [WorkflowExpression] Func<bodypaysTaxInput> bodypaysTax = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/giftaid/taxdeclarations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["declaration_starts"] = SourceExpressionConverter.ConvertToken(bodydeclarationStarts);
                if (bodydeclarationEnds != null)
                {
                    body["declaration_ends"] = SourceExpressionConverter.ConvertToken(bodydeclarationEnds);
                    bodypropCount++;
                }

                if (bodydeclarationMade != null)
                {
                    body["declaration_made"] = SourceExpressionConverter.ConvertToken(bodydeclarationMade);
                    bodypropCount++;
                }

                if (bodyindicator != null)
                {
                    body["declaration_indicator"] = SourceExpressionConverter.ConvertToken(bodyindicator);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["declaration_source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodyconfirmationSent != null)
                {
                    body["confirmation_sent"] = SourceExpressionConverter.ConvertToken(bodyconfirmationSent);
                    bodypropCount++;
                }

                if (bodyconfirmationReturned != null)
                {
                    body["confirmation_returned"] = SourceExpressionConverter.ConvertToken(bodyconfirmationReturned);
                    bodypropCount++;
                }

                if (bodypaysTax != null)
                {
                    body["constituent_pays_tax"] = SourceExpressionConverter.Convert(bodypaysTax);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["tax_payer_status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["tax_notes"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedTaxDeclaration>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditTaxDeclaration([WorkflowExpression] Func<int> taxDeclarationId, [WorkflowExpression] Func<string> bodydeclarationStarts = null, [WorkflowExpression] Func<string> bodydeclarationEnds = null, [WorkflowExpression] Func<string> bodydeclarationMade = null, [WorkflowExpression] Func<string> bodyindicator = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyconfirmationSent = null, [WorkflowExpression] Func<string> bodyconfirmationReturned = null, [WorkflowExpression] Func<bodypaysTaxInput> bodypaysTax = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<string> bodycomments = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/giftaid/taxdeclarations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(taxDeclarationId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodydeclarationStarts != null)
                {
                    body["declaration_starts"] = SourceExpressionConverter.ConvertToken(bodydeclarationStarts);
                    bodypropCount++;
                }

                if (bodydeclarationEnds != null)
                {
                    body["declaration_ends"] = SourceExpressionConverter.ConvertToken(bodydeclarationEnds);
                    bodypropCount++;
                }

                if (bodydeclarationMade != null)
                {
                    body["declaration_made"] = SourceExpressionConverter.ConvertToken(bodydeclarationMade);
                    bodypropCount++;
                }

                if (bodyindicator != null)
                {
                    body["declaration_indicator"] = SourceExpressionConverter.ConvertToken(bodyindicator);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["declaration_source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodyconfirmationSent != null)
                {
                    body["confirmation_sent"] = SourceExpressionConverter.ConvertToken(bodyconfirmationSent);
                    bodypropCount++;
                }

                if (bodyconfirmationReturned != null)
                {
                    body["confirmation_returned"] = SourceExpressionConverter.ConvertToken(bodyconfirmationReturned);
                    bodypropCount++;
                }

                if (bodypaysTax != null)
                {
                    body["constituent_pays_tax"] = SourceExpressionConverter.Convert(bodypaysTax);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["tax_payer_status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                if (bodycomments != null)
                {
                    body["tax_notes"] = SourceExpressionConverter.ConvertToken(bodycomments);
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftIdMap> GetGiftIdFromLookupId([WorkflowExpression] Func<string> giftlookupid)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/giftidmap/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(giftlookupid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiGiftIdMap>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedGiftNote> CreateGiftNote([WorkflowExpression] Func<int> bodygiftId, [WorkflowExpression] Func<int> bodytype, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyauthor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifts/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["note_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedGiftNote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftNote([WorkflowExpression] Func<int> id, [WorkflowExpression] Func<int> bodytype = null, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyauthor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifts/notes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["note_type_id"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftNoteCollection> ListGiftNotes([WorkflowExpression] Func<int> giftId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifts/{0}/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiGiftNoteCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedGiftTribute> CreateGiftTribute([WorkflowExpression] Func<int> bodygiftId, [WorkflowExpression] Func<int> bodytributeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/gifttribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["gift_id"] = SourceExpressionConverter.ConvertToken(bodygiftId);
                bodypropCount++;
                body["tribute_id"] = SourceExpressionConverter.ConvertToken(bodytributeId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedGiftTribute>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftTribute([WorkflowExpression] Func<int> giftTributeId, [WorkflowExpression] Func<int> bodytributeType = null, [WorkflowExpression] Func<bodyacknowledgeStatusInput> bodyacknowledgeStatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(giftTributeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytributeType != null)
                {
                    body["tribute_type"] = SourceExpressionConverter.ConvertToken(bodytributeType);
                    bodypropCount++;
                }

                if (bodyacknowledgeStatus != null)
                {
                    body["acknowledge"] = SourceExpressionConverter.Convert(bodyacknowledgeStatus);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection> ListGiftTributeAcknowledgees([WorkflowExpression] Func<int> giftTributeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifttribute/{0}/acknowledgees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(giftTributeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeAcknowledgeeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IBodyWorkflowAction<NXTDataIntegrationApiGiftTributeCollection> ListGiftTributes([WorkflowExpression] Func<int> giftId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifttribute/gift/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(giftId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiGiftTributeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudgifts")]
        public IWorkflowAction EditGiftTributeAcknowledgee([WorkflowExpression] Func<int> giftTributeAcknowledgeeId, [WorkflowExpression] Func<int> bodyletter = null, [WorkflowExpression] Func<string> bodyletterDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/gifttribute/acknowledgees/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(giftTributeAcknowledgeeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyletter != null)
                {
                    body["letter"] = SourceExpressionConverter.ConvertToken(bodyletter);
                    bodypropCount++;
                }

                if (bodyletterDate != null)
                {
                    body["letter_date"] = SourceExpressionConverter.ConvertToken(bodyletterDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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

    public class GiftApiCreatedGift
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class GiftApiGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }

        [JsonProperty("amount")]
        public GiftApiGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    public enum bodyreceiptsreceiptStatusInput
    {
        [EnumMember(Value = "NotReceipted")]
        NeedsReceipt,
        DoNotReceipt,
        Receipted
    }

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

    public class GiftApiCreatedGiftCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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
        public string BatchID { get; set; }

        [JsonProperty("exception_error_code")]
        public int ExceptionErrorCode { get; set; }

        [JsonProperty("exception_error_message")]
        public string ExceptionErrorMessage { get; set; }

        [JsonProperty("exception_error_name")]
        public string ExceptionErrorName { get; set; }

        [JsonProperty("gift_id")]
        public string GiftID { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }
    }

    public class GiftApiBatchGiftRead
    {
        [JsonProperty("batch_id")]
        public string BatchID { get; set; }

        [JsonProperty("errors")]
        public GiftApiGiftBatchGiftError[] Errors { get; set; }

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

    public enum bodygiftsreceiptsreceiptStatusInput
    {
        Receipted,
        NeedsReceipt,
        DoNotReceipt
    }

    public enum bodygiftstypeInput
    {
        Donation,
        Other,
        GiftInKind
    }

    public class GiftApiVirtualBatchGiftSplitAdd
    {
        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }

        [JsonProperty("amount")]
        public GiftApiVirtualBatchGiftSplitAddAmountType Amount { get; set; }
    }

    public class GiftApiVirtualBatchGiftSplitAddAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

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

    public class Gift2ApiNewGiftSplit
    {
        [JsonProperty("amount")]
        public Gift2ApiNewGiftSplitAmountType Amount { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("package_id")]
        public string PackageID { get; set; }
    }

    public class Gift2ApiNewGiftSplitAmountType
    {
        [JsonProperty("value")]
        public double Amount { get; set; }
    }

    public enum bodyacknowledgementsacknowledgeStatusInput
    {
        [EnumMember(Value = "NotAcknowledged")]
        NeedsAcknowledgement,
        DoNotAcknowledge,
        Acknowledged
    }

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
        public string RecipientID { get; set; }

        [JsonProperty("amount")]
        public Gift2ApiNewRecognitionCreditAmountType Amount { get; set; }
    }

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

    public class NXTDataIntegrationApiCreatedGiftNote
    {
        [JsonProperty("id")]
        public string ID { get; set; }
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