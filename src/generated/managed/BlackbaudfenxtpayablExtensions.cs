//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtpayabl
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudfenxtpayablActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IWorkflowAction DeleteCreditMemo(Expression<Func<int>> creditMemoId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/creditmemos/{0}", ExpressionConverter.ConvertWithUrlEncoding(creditMemoId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiInvoiceSummaryCollection> ListInvoices(Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<string>> vendorName = null, Expression<Func<invoiceStatusInput>> invoiceStatus = null, Expression<Func<postStatusInput>> postStatus = null, Expression<Func<paymentMethodInput>> paymentMethod = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> addedBy = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> lastModifiedBy = null)
        {
            var apiCallPath = "/accountspayable/v1/invoices";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fromDate != null)
                callPayload.Queries["from_date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to_date"] = ExpressionConverter.Convert(toDate);
            if (vendorName != null)
                callPayload.Queries["vendor_name"] = ExpressionConverter.Convert(vendorName);
            if (invoiceStatus != null)
                callPayload.Queries["invoice_status"] = ExpressionConverter.Convert(invoiceStatus);
            if (postStatus != null)
                callPayload.Queries["post_status"] = ExpressionConverter.Convert(postStatus);
            if (paymentMethod != null)
                callPayload.Queries["payment_method"] = ExpressionConverter.Convert(paymentMethod);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (addedBy != null)
                callPayload.Queries["added_by"] = ExpressionConverter.Convert(addedBy);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            if (lastModifiedBy != null)
                callPayload.Queries["last_modified_by"] = ExpressionConverter.Convert(lastModifiedBy);
            return new ApiConnectionAction<APApiInvoiceSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedInvoice> EditInvoice(Expression<Func<int>> invoiceId, Expression<Func<string>> bodyinvoiceNumber = null, Expression<Func<string>> bodyinvoiceDate = null, Expression<Func<string>> bodydueDate = null, Expression<Func<bodypostStatusInput>> bodypostStatus = null, Expression<Func<string>> bodypostDate = null, Expression<Func<double>> bodyamount = null, Expression<Func<string>> bodydescription = null, Expression<Func<bodyapprovalStatusInput>> bodyapprovalStatus = null, Expression<Func<bool>> bodydistributeDiscounts = null, Expression<Func<bodypaymentDetailspaymentMethodInput>> bodypaymentDetailspaymentMethod = null, Expression<Func<int>> bodypaymentDetailsremitToremitTo = null, Expression<Func<string>> bodypaymentDetailspaidFrom = null, Expression<Func<int>> bodypaymentDetailscardAccountID = null, Expression<Func<int>> bodypaymentDetailscardID = null, Expression<Func<bool>> bodypaymentDetailsholdPayment = null, Expression<Func<bool>> bodypaymentDetailsseparatePayment = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyinvoiceNumber != null)
            {
                body["invoice_number"] = ExpressionConverter.ConvertO(bodyinvoiceNumber);
                bodypropCount++;
            }

            if (bodyinvoiceDate != null)
            {
                body["invoice_date"] = ExpressionConverter.ConvertO(bodyinvoiceDate);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["due_date"] = ExpressionConverter.ConvertO(bodydueDate);
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

            if (bodyamount != null)
            {
                body["amount"] = ExpressionConverter.ConvertO(bodyamount);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyapprovalStatus != null)
            {
                body["status"] = ExpressionConverter.ConvertO(bodyapprovalStatus);
                bodypropCount++;
            }

            if (bodydistributeDiscounts != null)
            {
                body["distribute_discounts"] = ExpressionConverter.ConvertO(bodydistributeDiscounts);
                bodypropCount++;
            }

            var payment_detailsObject = new JObject();
            var payment_detailsObjectpropCount = 0;
            if (bodypaymentDetailspaymentMethod != null)
            {
                payment_detailsObject["payment_method"] = ExpressionConverter.ConvertO(bodypaymentDetailspaymentMethod);
                payment_detailsObjectpropCount++;
            }

            var remit_toObject = new JObject();
            var remit_toObjectpropCount = 0;
            if (bodypaymentDetailsremitToremitTo != null)
            {
                remit_toObject["address_id"] = ExpressionConverter.ConvertO(bodypaymentDetailsremitToremitTo);
                remit_toObjectpropCount++;
            }

            if (remit_toObjectpropCount > 0)
            {
                payment_detailsObject["remit_to"] = remit_toObject;
                payment_detailsObjectpropCount++;
            }

            if (bodypaymentDetailspaidFrom != null)
            {
                payment_detailsObject["paid_from"] = ExpressionConverter.ConvertO(bodypaymentDetailspaidFrom);
                payment_detailsObjectpropCount++;
            }

            if (bodypaymentDetailscardAccountID != null)
            {
                payment_detailsObject["credit_card_account_id"] = ExpressionConverter.ConvertO(bodypaymentDetailscardAccountID);
                payment_detailsObjectpropCount++;
            }

            if (bodypaymentDetailscardID != null)
            {
                payment_detailsObject["credit_card_id"] = ExpressionConverter.ConvertO(bodypaymentDetailscardID);
                payment_detailsObjectpropCount++;
            }

            if (bodypaymentDetailsholdPayment != null)
            {
                payment_detailsObject["hold_payment"] = ExpressionConverter.ConvertO(bodypaymentDetailsholdPayment);
                payment_detailsObjectpropCount++;
            }

            if (bodypaymentDetailsseparatePayment != null)
            {
                payment_detailsObject["create_separate_payment"] = ExpressionConverter.ConvertO(bodypaymentDetailsseparatePayment);
                payment_detailsObjectpropCount++;
            }

            if (payment_detailsObjectpropCount > 0)
            {
                body["payment_details"] = payment_detailsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedInvoice>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiInvoiceDetail> GetInvoice(Expression<Func<int>> invoiceId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiInvoiceDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiForm1099> GetInvoice1099Amount(Expression<Func<int>> invoiceId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}/1099amount", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiForm1099>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiInvoice1099BoxNumberCollection> ListInvoice1099BoxNumbers(Expression<Func<int>> invoiceId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}/1099boxnumber", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiInvoice1099BoxNumberCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiInvoiceAdjustmentSummaryCollection> ListInvoiceAdjustments(Expression<Func<int>> invoiceId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}/adjustments", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiInvoiceAdjustmentSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IWorkflowAction DeleteInvoiceAdjustment(Expression<Func<int>> invoiceId, Expression<Func<int>> adjustmentId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}/adjustments/{1}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1), ExpressionConverter.ConvertWithUrlEncoding(adjustmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiInvoiceAdjustmentDetail> GetInvoiceAdjustment(Expression<Func<int>> invoiceId, Expression<Func<int>> adjustmentId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/invoices/{0}/adjustments/{1}", ExpressionConverter.ConvertWithUrlEncoding(invoiceId, 1), ExpressionConverter.ConvertWithUrlEncoding(adjustmentId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiInvoiceAdjustmentDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedInvoiceAttachment> CreateInvoiceAttachment(Expression<Func<int>> bodyinvoiceID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname, Expression<Func<string>> bodyattachmentType, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileContents = null, Expression<Func<string>> bodyfileName = null)
        {
            var apiCallPath = "/accountspayable/v1/invoices/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyinvoiceID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["media_type"] = ExpressionConverter.ConvertO(bodyattachmentType);
            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileContents != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfileContents);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedInvoiceAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedPurchaseOrder> CreatePurchaseOrder(Expression<Func<int>> bodyvendorID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<int>> bodyorderNumber, Expression<Func<string>> bodyorderDate, Expression<Func<bodystatusInput>> bodystatus, Expression<Func<int>> bodyorderFrom, Expression<Func<string>> bodyshipVia, Expression<Func<string>> bodyterms, Expression<Func<string>> bodyfOB = null, Expression<Func<string>> bodybuyer = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyconfirmTo = null, Expression<Func<int>> bodyshipTo = null, Expression<Func<string>> bodyexpires = null, Expression<Func<string>> bodyattention = null, Expression<Func<string>> bodycomments = null)
        {
            var apiCallPath = "/accountspayable/v1/purchaseorders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["vendor_id"] = ExpressionConverter.ConvertO(bodyvendorID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["order_number"] = ExpressionConverter.ConvertO(bodyorderNumber);
            bodypropCount++;
            body["order_date"] = ExpressionConverter.ConvertO(bodyorderDate);
            bodypropCount++;
            body["order_status"] = ExpressionConverter.ConvertO(bodystatus);
            bodypropCount++;
            body["order_from_contact_id"] = ExpressionConverter.ConvertO(bodyorderFrom);
            bodypropCount++;
            body["ship_via"] = ExpressionConverter.ConvertO(bodyshipVia);
            if (bodyfOB != null)
            {
                body["fob"] = ExpressionConverter.ConvertO(bodyfOB);
                bodypropCount++;
            }

            bodypropCount++;
            body["terms"] = ExpressionConverter.ConvertO(bodyterms);
            if (bodybuyer != null)
            {
                body["buyer"] = ExpressionConverter.ConvertO(bodybuyer);
                bodypropCount++;
            }

            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyconfirmTo != null)
            {
                body["ordered_by"] = ExpressionConverter.ConvertO(bodyconfirmTo);
                bodypropCount++;
            }

            if (bodyshipTo != null)
            {
                body["ship_to_address_id"] = ExpressionConverter.ConvertO(bodyshipTo);
                bodypropCount++;
            }

            if (bodyexpires != null)
            {
                body["expiration_date"] = ExpressionConverter.ConvertO(bodyexpires);
                bodypropCount++;
            }

            if (bodyattention != null)
            {
                body["attention"] = ExpressionConverter.ConvertO(bodyattention);
                bodypropCount++;
            }

            if (bodycomments != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodycomments);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedPurchaseOrder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiPurchaseOrderSummaryCollection> ListPurchaseOrders(Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<typeInput>> type = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/accountspayable/v1/purchaseorders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fromDate != null)
                callPayload.Queries["from_date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to_date"] = ExpressionConverter.Convert(toDate);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<APApiPurchaseOrderSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiPurchaseOrderDetail> GetPurchaseOrder(Expression<Func<int>> purchaseOrderId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/purchaseorders/{0}", ExpressionConverter.ConvertWithUrlEncoding(purchaseOrderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiPurchaseOrderDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IWorkflowAction CreatePurchaseOrderLineItem(Expression<Func<int>> purchaseOrderId, Expression<Func<bodytypeInput>> bodytype, Expression<Func<double>> bodyquantity, Expression<Func<double>> bodyunitCost, Expression<Func<double>> bodyextendedCost, Expression<Func<int>> bodyproductID, Expression<Func<bodypostStatusInput>> bodypostStatus, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyunitOfMeasure = null, Expression<Func<string>> bodyvendorPartNumber = null, Expression<Func<string>> bodydepartment = null, Expression<Func<string>> bodyrequestedBy = null, Expression<Func<string>> bodydeliverTo = null, Expression<Func<string>> bodypostDate = null, Expression<Func<string>> bodyinternalNotes = null, Expression<Func<string>> bodyexternalNotes = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/purchaseorders/{0}/lineitems", ExpressionConverter.ConvertWithUrlEncoding(purchaseOrderId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodyunitOfMeasure != null)
            {
                body["unit_of_measure"] = ExpressionConverter.ConvertO(bodyunitOfMeasure);
                bodypropCount++;
            }

            bodypropCount++;
            body["quantity_ordered"] = ExpressionConverter.ConvertO(bodyquantity);
            bodypropCount++;
            body["unit_cost"] = ExpressionConverter.ConvertO(bodyunitCost);
            bodypropCount++;
            body["extended_cost"] = ExpressionConverter.ConvertO(bodyextendedCost);
            if (bodyvendorPartNumber != null)
            {
                body["vendor_part_number"] = ExpressionConverter.ConvertO(bodyvendorPartNumber);
                bodypropCount++;
            }

            bodypropCount++;
            body["product_id"] = ExpressionConverter.ConvertO(bodyproductID);
            if (bodydepartment != null)
            {
                body["department"] = ExpressionConverter.ConvertO(bodydepartment);
                bodypropCount++;
            }

            if (bodyrequestedBy != null)
            {
                body["requested_by"] = ExpressionConverter.ConvertO(bodyrequestedBy);
                bodypropCount++;
            }

            if (bodydeliverTo != null)
            {
                body["deliver_to"] = ExpressionConverter.ConvertO(bodydeliverTo);
                bodypropCount++;
            }

            bodypropCount++;
            body["post_status"] = ExpressionConverter.ConvertO(bodypostStatus);
            if (bodypostDate != null)
            {
                body["post_date"] = ExpressionConverter.ConvertO(bodypostDate);
                bodypropCount++;
            }

            if (bodyinternalNotes != null)
            {
                body["notes"] = ExpressionConverter.ConvertO(bodyinternalNotes);
                bodypropCount++;
            }

            if (bodyexternalNotes != null)
            {
                body["comments"] = ExpressionConverter.ConvertO(bodyexternalNotes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiLineItemSummaryCollection> ListPurchaseOrderLineItems(Expression<Func<int>> purchaseOrderId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/purchaseorders/{0}/lineitems", ExpressionConverter.ConvertWithUrlEncoding(purchaseOrderId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<APApiLineItemSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiLineItemDetail> GetPurchaseOrderLineItem(Expression<Func<int>> purchaseOrderId, Expression<Func<int>> lineItemId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/purchaseorders/{0}/lineitems/{1}", ExpressionConverter.ConvertWithUrlEncoding(purchaseOrderId, 1), ExpressionConverter.ConvertWithUrlEncoding(lineItemId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiLineItemDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiReceiptSummaryCollection> ListReceipts(Expression<Func<int>> purchaseOrderId = null, Expression<Func<string>> receivedBy = null, Expression<Func<string>> fromDate = null, Expression<Func<string>> toDate = null, Expression<Func<string>> vendorName = null, Expression<Func<string>> searchText = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = "/accountspayable/v1/receipts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (purchaseOrderId != null)
                callPayload.Queries["purchase_order_id"] = ExpressionConverter.Convert(purchaseOrderId);
            if (receivedBy != null)
                callPayload.Queries["received_by"] = ExpressionConverter.Convert(receivedBy);
            if (fromDate != null)
                callPayload.Queries["from_date"] = ExpressionConverter.Convert(fromDate);
            if (toDate != null)
                callPayload.Queries["to_date"] = ExpressionConverter.Convert(toDate);
            if (vendorName != null)
                callPayload.Queries["vendor_name"] = ExpressionConverter.Convert(vendorName);
            if (searchText != null)
                callPayload.Queries["search_text"] = ExpressionConverter.Convert(searchText);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<APApiReceiptSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiReceiptDetail> GetReceipt(Expression<Func<int>> receiptId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/receipts/{0}", ExpressionConverter.ConvertWithUrlEncoding(receiptId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiReceiptDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendor> CreateVendor(Expression<Func<string>> bodyname, Expression<Func<string>> bodyaddressaddressDescription, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyvendorID = null, Expression<Func<string>> bodytaxIDNumber = null, Expression<Func<string>> bodycustomerNumber = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyissue1099Statement = null, Expression<Func<string>> bodyaddressaddressCountry = null, Expression<Func<string>> bodyaddressaddressLines = null, Expression<Func<string>> bodyaddressaddressCity = null, Expression<Func<string>> bodyaddressaddressState = null, Expression<Func<string>> bodyaddressaddressPostalCode = null, Expression<Func<string>> bodyaddressaddressCounty = null, Expression<Func<bool>> bodyaddressaddressIsPrimary = null, Expression<Func<bool>> bodyaddresssendInvoices = null, Expression<Func<bool>> bodyaddresssendPOs = null, Expression<Func<bool>> bodyaddresssend1099s = null, Expression<Func<string>> bodyaddresscontactTitle = null, Expression<Func<string>> bodyaddresscontactFirstName = null, Expression<Func<string>> bodyaddresscontactMiddleName = null, Expression<Func<string>> bodyaddresscontactLastName = null, Expression<Func<string>> bodyaddresscontactSuffix = null, Expression<Func<string>> bodyaddresscontactPosition = null, Expression<Func<bool>> bodyvendorPaymentDefaultcreditLimit = null, Expression<Func<double>> bodyvendorPaymentDefaultcreditLimitAmount = null, Expression<Func<string>> bodyvendorPaymentDefaultpaymentTerms = null, Expression<Func<string>> bodyvendorPaymentDefaultpaymentAccount = null, Expression<Func<bodyvendorPaymentDefaultpaymentMethodInput>> bodyvendorPaymentDefaultpaymentMethod = null, Expression<Func<bodyvendorPaymentDefaultpaymentOptionInput>> bodyvendorPaymentDefaultpaymentOption = null, Expression<Func<string>> bodygSTBranch = null, Expression<Func<int>> bodygSTTaxTypeID = null, Expression<Func<int>> bodypSBActivityCodeID = null)
        {
            var apiCallPath = "/accountspayable/v1/vendors";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["vendor_name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodytype != null)
            {
                body["vendor_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyvendorID != null)
            {
                body["ui_defined_id"] = ExpressionConverter.ConvertO(bodyvendorID);
                bodypropCount++;
            }

            if (bodytaxIDNumber != null)
            {
                body["tax_id_number"] = ExpressionConverter.ConvertO(bodytaxIDNumber);
                bodypropCount++;
            }

            if (bodycustomerNumber != null)
            {
                body["customer_number"] = ExpressionConverter.ConvertO(bodycustomerNumber);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["vendor_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyissue1099Statement != null)
            {
                body["issue_1099s"] = ExpressionConverter.ConvertO(bodyissue1099Statement);
                bodypropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["description"] = ExpressionConverter.ConvertO(bodyaddressaddressDescription);
            if (bodyaddressaddressCountry != null)
            {
                addressObject["country"] = ExpressionConverter.ConvertO(bodyaddressaddressCountry);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressLines != null)
            {
                addressObject["address_line"] = ExpressionConverter.ConvertO(bodyaddressaddressLines);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressCity != null)
            {
                addressObject["city"] = ExpressionConverter.ConvertO(bodyaddressaddressCity);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressState != null)
            {
                addressObject["state"] = ExpressionConverter.ConvertO(bodyaddressaddressState);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressPostalCode != null)
            {
                addressObject["postal"] = ExpressionConverter.ConvertO(bodyaddressaddressPostalCode);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressCounty != null)
            {
                addressObject["county"] = ExpressionConverter.ConvertO(bodyaddressaddressCounty);
                addressObjectpropCount++;
            }

            if (bodyaddressaddressIsPrimary != null)
            {
                addressObject["is_primary"] = ExpressionConverter.ConvertO(bodyaddressaddressIsPrimary);
                addressObjectpropCount++;
            }

            if (bodyaddresssendInvoices != null)
            {
                addressObject["is_invoices"] = ExpressionConverter.ConvertO(bodyaddresssendInvoices);
                addressObjectpropCount++;
            }

            if (bodyaddresssendPOs != null)
            {
                addressObject["is_pos"] = ExpressionConverter.ConvertO(bodyaddresssendPOs);
                addressObjectpropCount++;
            }

            if (bodyaddresssend1099s != null)
            {
                addressObject["is_1099"] = ExpressionConverter.ConvertO(bodyaddresssend1099s);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactTitle != null)
            {
                addressObject["title"] = ExpressionConverter.ConvertO(bodyaddresscontactTitle);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactFirstName != null)
            {
                addressObject["first_name"] = ExpressionConverter.ConvertO(bodyaddresscontactFirstName);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactMiddleName != null)
            {
                addressObject["middle_name"] = ExpressionConverter.ConvertO(bodyaddresscontactMiddleName);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactLastName != null)
            {
                addressObject["last_name"] = ExpressionConverter.ConvertO(bodyaddresscontactLastName);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactSuffix != null)
            {
                addressObject["suffix"] = ExpressionConverter.ConvertO(bodyaddresscontactSuffix);
                addressObjectpropCount++;
            }

            if (bodyaddresscontactPosition != null)
            {
                addressObject["position"] = ExpressionConverter.ConvertO(bodyaddresscontactPosition);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            var vendor_payment_defaultObject = new JObject();
            var vendor_payment_defaultObjectpropCount = 0;
            if (bodyvendorPaymentDefaultcreditLimit != null)
            {
                vendor_payment_defaultObject["has_credit_limit"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultcreditLimit);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultcreditLimitAmount != null)
            {
                vendor_payment_defaultObject["credit_limit"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultcreditLimitAmount);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentTerms != null)
            {
                vendor_payment_defaultObject["payment_terms"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentTerms);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentAccount != null)
            {
                vendor_payment_defaultObject["account_name"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentAccount);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentMethod != null)
            {
                vendor_payment_defaultObject["payment_method"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentMethod);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentOption != null)
            {
                vendor_payment_defaultObject["payment_option"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentOption);
                vendor_payment_defaultObjectpropCount++;
            }

            if (vendor_payment_defaultObjectpropCount > 0)
            {
                body["vendor_payment_default"] = vendor_payment_defaultObject;
                bodypropCount++;
            }

            if (bodygSTBranch != null)
            {
                body["gst_branch"] = ExpressionConverter.ConvertO(bodygSTBranch);
                bodypropCount++;
            }

            if (bodygSTTaxTypeID != null)
            {
                body["gst_tax_type_id"] = ExpressionConverter.ConvertO(bodygSTTaxTypeID);
                bodypropCount++;
            }

            if (bodypSBActivityCodeID != null)
            {
                body["psb_activity_code_id"] = ExpressionConverter.ConvertO(bodypSBActivityCodeID);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorSummaryCollection> ListVendors(Expression<Func<statusInput>> status = null, Expression<Func<string>> vendorName = null, Expression<Func<string>> uiVendorId = null, Expression<Func<string>> customerNumber = null, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null, Expression<Func<string>> dateAdded = null, Expression<Func<string>> addedBy = null, Expression<Func<string>> lastModified = null, Expression<Func<string>> lastModifiedBy = null)
        {
            var apiCallPath = "/accountspayable/v1/vendors";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (status != null)
                callPayload.Queries["status"] = ExpressionConverter.Convert(status);
            if (vendorName != null)
                callPayload.Queries["vendor_name"] = ExpressionConverter.Convert(vendorName);
            if (uiVendorId != null)
                callPayload.Queries["ui_vendor_id"] = ExpressionConverter.Convert(uiVendorId);
            if (customerNumber != null)
                callPayload.Queries["customer_number"] = ExpressionConverter.Convert(customerNumber);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            if (dateAdded != null)
                callPayload.Queries["date_added"] = ExpressionConverter.Convert(dateAdded);
            if (addedBy != null)
                callPayload.Queries["added_by"] = ExpressionConverter.Convert(addedBy);
            if (lastModified != null)
                callPayload.Queries["last_modified"] = ExpressionConverter.Convert(lastModified);
            if (lastModifiedBy != null)
                callPayload.Queries["last_modified_by"] = ExpressionConverter.Convert(lastModifiedBy);
            return new ApiConnectionAction<APApiVendorSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendor> EditVendor(Expression<Func<int>> vendorId, Expression<Func<string>> bodyname = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodycustomerNumber = null, Expression<Func<bodystatusInput>> bodystatus = null, Expression<Func<bool>> bodyissue1099Statement = null, Expression<Func<bool>> bodyvendorPaymentDefaultcreditLimit = null, Expression<Func<double>> bodyvendorPaymentDefaultcreditLimitAmount = null, Expression<Func<string>> bodyvendorPaymentDefaultpaymentTerms = null, Expression<Func<string>> bodyvendorPaymentDefaultpaymentAccount = null, Expression<Func<bodyvendorPaymentDefaultpaymentMethodInput>> bodyvendorPaymentDefaultpaymentMethod = null, Expression<Func<bodyvendorPaymentDefaultpaymentOptionInput>> bodyvendorPaymentDefaultpaymentOption = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["vendor_name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["vendor_type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodycustomerNumber != null)
            {
                body["customer_number"] = ExpressionConverter.ConvertO(bodycustomerNumber);
                bodypropCount++;
            }

            if (bodystatus != null)
            {
                body["vendor_status"] = ExpressionConverter.ConvertO(bodystatus);
                bodypropCount++;
            }

            if (bodyissue1099Statement != null)
            {
                body["issue_1099s"] = ExpressionConverter.ConvertO(bodyissue1099Statement);
                bodypropCount++;
            }

            var vendor_payment_defaultObject = new JObject();
            var vendor_payment_defaultObjectpropCount = 0;
            if (bodyvendorPaymentDefaultcreditLimit != null)
            {
                vendor_payment_defaultObject["has_credit_limit"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultcreditLimit);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultcreditLimitAmount != null)
            {
                vendor_payment_defaultObject["credit_limit"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultcreditLimitAmount);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentTerms != null)
            {
                vendor_payment_defaultObject["payment_terms"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentTerms);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentAccount != null)
            {
                vendor_payment_defaultObject["account_name"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentAccount);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentMethod != null)
            {
                vendor_payment_defaultObject["payment_method"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentMethod);
                vendor_payment_defaultObjectpropCount++;
            }

            if (bodyvendorPaymentDefaultpaymentOption != null)
            {
                vendor_payment_defaultObject["payment_option"] = ExpressionConverter.ConvertO(bodyvendorPaymentDefaultpaymentOption);
                vendor_payment_defaultObjectpropCount++;
            }

            if (vendor_payment_defaultObjectpropCount > 0)
            {
                body["vendor_payment_default"] = vendor_payment_defaultObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendor>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorDetail> GetVendor(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendorDetail>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendor1099Information> GetVendor1099Info(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/1099info", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendor1099Information>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorAddress> CreateVendorAddress(Expression<Func<int>> vendorId, Expression<Func<string>> bodydescription, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycounty = null, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<bool>> bodysendInvoices = null, Expression<Func<bool>> bodysendPOs = null, Expression<Func<bool>> bodysend1099s = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactMiddleName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactSuffix = null, Expression<Func<string>> bodycontactPosition = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_line"] = ExpressionConverter.ConvertO(bodyaddressLines);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyisPrimary != null)
            {
                body["is_primary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                bodypropCount++;
            }

            if (bodysendInvoices != null)
            {
                body["is_invoices"] = ExpressionConverter.ConvertO(bodysendInvoices);
                bodypropCount++;
            }

            if (bodysendPOs != null)
            {
                body["is_pos"] = ExpressionConverter.ConvertO(bodysendPOs);
                bodypropCount++;
            }

            if (bodysend1099s != null)
            {
                body["issue_1099s"] = ExpressionConverter.ConvertO(bodysend1099s);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactFirstName != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodycontactFirstName);
                bodypropCount++;
            }

            if (bodycontactMiddleName != null)
            {
                body["middle_name"] = ExpressionConverter.ConvertO(bodycontactMiddleName);
                bodypropCount++;
            }

            if (bodycontactLastName != null)
            {
                body["last_name"] = ExpressionConverter.ConvertO(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactSuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodycontactSuffix);
                bodypropCount++;
            }

            if (bodycontactPosition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodycontactPosition);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorAddressCollection> ListVendorAddresses(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendorAddressCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IWorkflowAction DeleteVendorAddress(Expression<Func<int>> vendorId, Expression<Func<int>> addressId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses/{1}", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1), ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorAddress> EditVendorAddress(Expression<Func<int>> vendorId, Expression<Func<int>> addressId, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodycountry = null, Expression<Func<string>> bodyaddressLines = null, Expression<Func<string>> bodycity = null, Expression<Func<string>> bodystate = null, Expression<Func<string>> bodypostalCode = null, Expression<Func<string>> bodycounty = null, Expression<Func<bool>> bodyisPrimary = null, Expression<Func<bool>> bodysendInvoices = null, Expression<Func<bool>> bodysendPOs = null, Expression<Func<bool>> bodysend1099s = null, Expression<Func<string>> bodycontactTitle = null, Expression<Func<string>> bodycontactFirstName = null, Expression<Func<string>> bodycontactMiddleName = null, Expression<Func<string>> bodycontactLastName = null, Expression<Func<string>> bodycontactSuffix = null, Expression<Func<string>> bodycontactPosition = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses/{1}", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1), ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodycountry != null)
            {
                body["country"] = ExpressionConverter.ConvertO(bodycountry);
                bodypropCount++;
            }

            if (bodyaddressLines != null)
            {
                body["address_line"] = ExpressionConverter.ConvertO(bodyaddressLines);
                bodypropCount++;
            }

            if (bodycity != null)
            {
                body["city"] = ExpressionConverter.ConvertO(bodycity);
                bodypropCount++;
            }

            if (bodystate != null)
            {
                body["state"] = ExpressionConverter.ConvertO(bodystate);
                bodypropCount++;
            }

            if (bodypostalCode != null)
            {
                body["postal"] = ExpressionConverter.ConvertO(bodypostalCode);
                bodypropCount++;
            }

            if (bodycounty != null)
            {
                body["county"] = ExpressionConverter.ConvertO(bodycounty);
                bodypropCount++;
            }

            if (bodyisPrimary != null)
            {
                body["is_primary"] = ExpressionConverter.ConvertO(bodyisPrimary);
                bodypropCount++;
            }

            if (bodysendInvoices != null)
            {
                body["is_invoices"] = ExpressionConverter.ConvertO(bodysendInvoices);
                bodypropCount++;
            }

            if (bodysendPOs != null)
            {
                body["is_pos"] = ExpressionConverter.ConvertO(bodysendPOs);
                bodypropCount++;
            }

            if (bodysend1099s != null)
            {
                body["issue_1099s"] = ExpressionConverter.ConvertO(bodysend1099s);
                bodypropCount++;
            }

            if (bodycontactTitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodycontactTitle);
                bodypropCount++;
            }

            if (bodycontactFirstName != null)
            {
                body["first_name"] = ExpressionConverter.ConvertO(bodycontactFirstName);
                bodypropCount++;
            }

            if (bodycontactMiddleName != null)
            {
                body["middle_name"] = ExpressionConverter.ConvertO(bodycontactMiddleName);
                bodypropCount++;
            }

            if (bodycontactLastName != null)
            {
                body["last_name"] = ExpressionConverter.ConvertO(bodycontactLastName);
                bodypropCount++;
            }

            if (bodycontactSuffix != null)
            {
                body["suffix"] = ExpressionConverter.ConvertO(bodycontactSuffix);
                bodypropCount++;
            }

            if (bodycontactPosition != null)
            {
                body["position"] = ExpressionConverter.ConvertO(bodycontactPosition);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorAddress>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorAddressContactMethod> CreateVendorAddressContactMethod(Expression<Func<int>> vendorId, Expression<Func<int>> addressId, Expression<Func<string>> bodycontactInfo, Expression<Func<string>> bodycontactType = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses/{1}/contactmethods", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1), ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactType != null)
            {
                body["contact_type"] = ExpressionConverter.ConvertO(bodycontactType);
                bodypropCount++;
            }

            bodypropCount++;
            body["contact_info"] = ExpressionConverter.ConvertO(bodycontactInfo);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorAddressContactMethod>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorAddressContactMethodCollection> ListVendorAddressContactMethods(Expression<Func<int>> vendorId, Expression<Func<int>> addressId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/addresses/{1}/contactmethods", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1), ExpressionConverter.ConvertWithUrlEncoding(addressId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendorAddressContactMethodCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiAttachmentSummaryCollection> ListVendorAttachments(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/attachments", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiAttachmentSummaryCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IWorkflowAction DeleteVendorAttachment(Expression<Func<int>> vendorId, Expression<Func<int>> attachmentId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/attachments/{1}", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1), ExpressionConverter.ConvertWithUrlEncoding(attachmentId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorContactCollection> ListVendorContacts(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/contacts", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendorContactCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiDefaultDistributionCollection> ListVendorDefaultDistributions(Expression<Func<int>> vendorId, Expression<Func<int>> limit = null, Expression<Func<int>> offset = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/defaultdistributions", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            if (offset != null)
                callPayload.Queries["offset"] = ExpressionConverter.Convert(offset);
            return new ApiConnectionAction<APApiDefaultDistributionCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorNote> CreateVendorNote(Expression<Func<int>> vendorId, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodynote = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["note_type"] = "Note";
            bodypropCount++;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["content"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorNote>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiVendorNoteActionCollection> ListVendorNotesActions(Expression<Func<int>> vendorId)
        {
            var apiCallPath = String.Format("/accountspayable/v1/vendors/{0}/notes", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<APApiVendorNoteActionCollection>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorAttachment> CreateVendorAttachment(Expression<Func<int>> bodyvendorID, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyname, Expression<Func<string>> bodyattachmentType, Expression<Func<string>> bodyuRL = null, Expression<Func<string>> bodyfileContents = null, Expression<Func<string>> bodyfileName = null)
        {
            var apiCallPath = "/accountspayable/v1/vendors/attachments";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["parent_id"] = ExpressionConverter.ConvertO(bodyvendorID);
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            bodypropCount++;
            body["media_type"] = ExpressionConverter.ConvertO(bodyattachmentType);
            if (bodyuRL != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyuRL);
                bodypropCount++;
            }

            if (bodyfileContents != null)
            {
                body["file"] = ExpressionConverter.ConvertO(bodyfileContents);
                bodypropCount++;
            }

            if (bodyfileName != null)
            {
                body["file_name"] = ExpressionConverter.ConvertO(bodyfileName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorAttachment>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedVendorAction> CreateVendorAction(Expression<Func<int>> vendorId, Expression<Func<string>> bodytype, Expression<Func<string>> bodydate, Expression<Func<string>> bodyassignedTo, Expression<Func<string>> bodydescription = null, Expression<Func<bool>> bodyisComplete = null, Expression<Func<string>> bodycompletedOn = null)
        {
            var apiCallPath = String.Format("/accountspayable/v1/virtual/vendors/{0}/actions", ExpressionConverter.ConvertWithUrlEncoding(vendorId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["note_type"] = "Action";
            bodypropCount++;
            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["date"] = ExpressionConverter.ConvertO(bodydate);
            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            bodypropCount++;
            body["assign_to"] = ExpressionConverter.ConvertO(bodyassignedTo);
            if (bodyisComplete != null)
            {
                body["is_complete"] = ExpressionConverter.ConvertO(bodyisComplete);
                bodypropCount++;
            }

            if (bodycompletedOn != null)
            {
                body["completed_date"] = ExpressionConverter.ConvertO(bodycompletedOn);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<APApiCreatedVendorAction>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudfenxtpayabl")]
        public IBodyWorkflowAction<APApiCreatedInvoice> CreateSingleDistributionInvoice(Expression<Func<object>> body = null)
        {
            var apiCallPath = "/accountspayable/v1/virtual/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(body);
            return new ApiConnectionAction<APApiCreatedInvoice>(callPayload);
        }
    }

    public class BlackbaudfenxtpayablTriggers([ConnectionName] string connectionId)
    {
    }

    public class APApiInvoiceSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiInvoiceSummary[] Value { get; set; }
    }

    public class APApiInvoiceSummary
    {
        [JsonProperty("invoice_id")]
        public int ID { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("vendor_status")]
        public APApiInvoiceSummaryVendorStatusType VendorStatus { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_date")]
        public string InvoiceDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("amount_due")]
        public double AmountDue { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("status")]
        public APApiInvoiceSummaryStatusType Status { get; set; }

        [JsonProperty("post_status")]
        public APApiInvoiceSummaryPostStatusType PostStatus { get; set; }

        [JsonProperty("payment_method")]
        public APApiInvoiceSummaryPaymentMethodType PaymentMethod { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("is_past_due")]
        public bool IsPastDue { get; set; }

        [JsonProperty("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty("gst_tax_type")]
        public string GSTTaxType { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiInvoiceSummaryVendorStatusType
    {
        Active,
        Inactive,
        OnHold
    }

    public enum APApiInvoiceSummaryStatusType
    {
        Pending,
        Approved,
        Paid,
        PartiallyPaid,
        Deleted
    }

    public enum APApiInvoiceSummaryPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public enum APApiInvoiceSummaryPaymentMethodType
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public enum invoiceStatusInput
    {
        Pending,
        Approved,
        Paid,
        PartiallyPaid,
        Deleted
    }

    public enum postStatusInput
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public enum paymentMethodInput
    {
        Check,
        [EnumMember(Value = "EFT")]
        ElectronicFundsTransfer,
        BankDraft,
        CreditCard
    }

    public class APApiCreatedInvoice
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodypostStatusInput
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public enum bodyapprovalStatusInput
    {
        Pending,
        Approved,
        Deleted,
        Paid,
        PartiallyPaid
    }

    public enum bodypaymentDetailspaymentMethodInput
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public class APApiInvoiceDetail
    {
        [JsonProperty("invoice_id")]
        public int ID { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoice_date")]
        public string InvoiceDate { get; set; }

        [JsonProperty("due_date")]
        public string DueDate { get; set; }

        [JsonProperty("post_status")]
        public APApiInvoiceDetailPostStatusType PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("total_paid")]
        public double TotalPaid { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("invoice_amount_before_tax")]
        public double InvoiceAmountBeforeTax { get; set; }

        [JsonProperty("include_tax")]
        public bool IncludeTax { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }

        [JsonProperty("tax_distribution")]
        public APApiRebateDistribution[] TaxDistribution { get; set; }

        [JsonProperty("gst_tax_type_id")]
        public int GSTTaxTypeID { get; set; }

        [JsonProperty("gst_rebate_amount")]
        public double GSTRebateAmount { get; set; }

        [JsonProperty("gst_rebate_distribution")]
        public APApiRebateDistribution[] GSTRebateDistribution { get; set; }

        [JsonProperty("psb_activity_code_id")]
        public int PSBActivityCodeID { get; set; }

        [JsonProperty("pst_rebate_amount")]
        public double PSTRebateAmount { get; set; }

        [JsonProperty("pst_rebate_distribution")]
        public APApiRebateDistribution[] PSTRebateDistribution { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("status")]
        public APApiInvoiceDetailApprovalStatusType ApprovalStatus { get; set; }

        [JsonProperty("distribute_discounts")]
        public bool DistributeDiscounts { get; set; }

        [JsonProperty("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty("invoice_payment_detail")]
        public APApiInvoiceDetailPaymentDetailType PaymentDetail { get; set; }

        [JsonProperty("distributions")]
        public APApiDistribution[] Distribution { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiInvoiceDetailPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public class APApiRebateDistribution
    {
        [JsonProperty("distribution_id")]
        public int ID { get; set; }

        [JsonProperty("tax_entity_id")]
        public string TaxEntityID { get; set; }

        [JsonProperty("type_code")]
        public APApiRebateDistributionTypeType Type { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distribution_splits")]
        public APApiDistributionSplit[] Split { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }
    }

    public enum APApiRebateDistributionTypeType
    {
        Debit,
        Credit
    }

    public class APApiDistributionSplit
    {
        [JsonProperty("distribution_split_id")]
        public int ID { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("ui_project_id")]
        public string Project { get; set; }

        [JsonProperty("account_class")]
        public string Class { get; set; }

        [JsonProperty("transaction_code_values")]
        public APApiTransactionCodeValue[] TransactionCodeValues { get; set; }
    }

    public class APApiTransactionCodeValue
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
    }

    public class APApiCustomField
    {
        [JsonProperty("field_name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public APApiCustomFieldTypeType Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("is_required")]
        public bool IsRequired { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comments")]
        public string Comment { get; set; }
    }

    public enum APApiCustomFieldTypeType
    {
        Text,
        Number,
        DateTime,
        Currency,
        Boolean,
        Table,
        FuzzyDate
    }

    public enum APApiInvoiceDetailApprovalStatusType
    {
        Pending,
        Approved,
        Paid,
        PartiallyPaid,
        Deleted
    }

    public class APApiInvoiceDetailPaymentDetailType
    {
        [JsonProperty("payment_method")]
        public APApiInvoiceDetailPaymentDetailTypePaymentMethodType PaymentMethod { get; set; }

        [JsonProperty("remit_to")]
        public APApiInvoiceDetailPaymentDetailTypeRemitToType RemitTo { get; set; }

        [JsonProperty("paid_from")]
        public string PaidFrom { get; set; }

        [JsonProperty("credit_card_account_id")]
        public int CardAccountID { get; set; }

        [JsonProperty("credit_card_account_name")]
        public string CardAccountName { get; set; }

        [JsonProperty("credit_card_id")]
        public int CardID { get; set; }

        [JsonProperty("credit_card_name")]
        public string CardName { get; set; }

        [JsonProperty("hold_payment")]
        public bool HoldPayment { get; set; }

        [JsonProperty("create_separate_payment")]
        public bool SeparatePayment { get; set; }

        [JsonProperty("payments")]
        public APApiInvoicePaymentSummary[] Payment { get; set; }
    }

    public enum APApiInvoiceDetailPaymentDetailTypePaymentMethodType
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public class APApiInvoiceDetailPaymentDetailTypeRemitToType
    {
        [JsonProperty("address_id")]
        public int AddressID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_line")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string PostalCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("contact_name")]
        public string ContactName { get; set; }
    }

    public class APApiInvoicePaymentSummary
    {
        [JsonProperty("br_transaction_id")]
        public int TransactionID { get; set; }

        [JsonProperty("transaction_number")]
        public string TransactionNumber { get; set; }

        [JsonProperty("payment_date")]
        public string Date { get; set; }

        [JsonProperty("payment_status")]
        public APApiInvoicePaymentSummaryStatusType Status { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("checks_7_id")]
        public int ChecksIdentifier { get; set; }
    }

    public enum APApiInvoicePaymentSummaryStatusType
    {
        Deleted,
        Voided,
        Scheduled,
        Paid
    }

    public class APApiDistribution
    {
        [JsonProperty("distribution_id")]
        public int ID { get; set; }

        [JsonProperty("type_code")]
        public APApiDistributionTypeType Type { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("distribution_splits")]
        public APApiDistributionSplit[] Split { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }
    }

    public enum APApiDistributionTypeType
    {
        Debit,
        Credit
    }

    public class APApiForm1099
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("excluded_amount")]
        public double ExcludedAmount { get; set; }
    }

    public class APApiInvoice1099BoxNumberCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public APApiInvoice1099BoxNumber[] Results { get; set; }
    }

    public class APApiInvoice1099BoxNumber
    {
        [JsonProperty("number")]
        public string BoxNumber { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }
    }

    public class APApiInvoiceAdjustmentSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiInvoiceAdjustmentSummary[] Value { get; set; }
    }

    public class APApiInvoiceAdjustmentSummary
    {
        [JsonProperty("adjustment_id")]
        public int ID { get; set; }

        [JsonProperty("adjustment_date")]
        public string Date { get; set; }

        [JsonProperty("post_status")]
        public APApiInvoiceAdjustmentSummaryPostStatusType PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }
    }

    public enum APApiInvoiceAdjustmentSummaryPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public class APApiInvoiceAdjustmentDetail
    {
        [JsonProperty("adjustment_id")]
        public int ID { get; set; }

        [JsonProperty("adjustment_date")]
        public string Date { get; set; }

        [JsonProperty("post_status")]
        public APApiInvoiceAdjustmentDetailPostStatusType PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("adjustment_distributions")]
        public APApiInvoiceAdjustmentDetailDistributionType Distribution { get; set; }
    }

    public enum APApiInvoiceAdjustmentDetailPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public class APApiInvoiceAdjustmentDetailDistributionType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiDistribution[] Value { get; set; }
    }

    public class APApiCreatedInvoiceAttachment
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodytypeInput
    {
        Link,
        Physical
    }

    public class APApiCreatedPurchaseOrder
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodystatusInput
    {
        Active,
        Inactive,
        OnHold
    }

    public class APApiPurchaseOrderSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiPurchaseOrderSummary[] Value { get; set; }
    }

    public class APApiPurchaseOrderSummary
    {
        [JsonProperty("purchase_order_id")]
        public int ID { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public APApiPurchaseOrderSummaryTypeType Type { get; set; }

        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("order_status")]
        public APApiPurchaseOrderSummaryStatusType Status { get; set; }

        [JsonProperty("order_total")]
        public double Total { get; set; }

        [JsonProperty("receipted_total")]
        public double ReceiptedTotal { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiPurchaseOrderSummaryTypeType
    {
        Template,
        Blanket,
        Regular
    }

    public enum APApiPurchaseOrderSummaryStatusType
    {
        UnprintedPurchaseOrder,
        OpenPurchaseOrder,
        UprintedChangeOrder,
        ReprintOrder,
        CanceledOrder,
        UnprintedCancellationNotice,
        ClosedOrder,
        DeletedOrder
    }

    public enum typeInput
    {
        Template,
        Blanket,
        Regular
    }

    public class APApiPurchaseOrderDetail
    {
        [JsonProperty("purchase_order_id")]
        public int ID { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public APApiPurchaseOrderDetailTypeType Type { get; set; }

        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("order_date")]
        public string OrderDate { get; set; }

        [JsonProperty("order_status")]
        public APApiPurchaseOrderDetailStatusType Status { get; set; }

        [JsonProperty("ordered_from_contact_id")]
        public int OrderFromContactID { get; set; }

        [JsonProperty("ship_via")]
        public string ShipVia { get; set; }

        [JsonProperty("fob")]
        public string FOB { get; set; }

        [JsonProperty("terms")]
        public string Terms { get; set; }

        [JsonProperty("buyer")]
        public string Buyer { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("ordered_by")]
        public string ConfirmTo { get; set; }

        [JsonProperty("ship_to_address")]
        public string ShipTo { get; set; }

        [JsonProperty("attention")]
        public string Attention { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("order_total")]
        public double Total { get; set; }

        [JsonProperty("receipted_total")]
        public double ReceiptedTotal { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiPurchaseOrderDetailTypeType
    {
        Template,
        Blanket,
        Regular
    }

    public enum APApiPurchaseOrderDetailStatusType
    {
        UnprintedPurchaseOrder,
        OpenPurchaseOrder,
        UprintedChangeOrder,
        ReprintOrder,
        CanceledOrder,
        UnprintedCancellationNotice,
        ClosedOrder,
        DeletedOrder
    }

    public class APApiLineItemSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiLineItemSummary[] Value { get; set; }
    }

    public class APApiLineItemSummary
    {
        [JsonProperty("line_item_id")]
        public int ID { get; set; }

        [JsonProperty("line_number")]
        public int LineNumber { get; set; }

        [JsonProperty("type")]
        public APApiLineItemSummaryTypeType Type { get; set; }

        [JsonProperty("product_id")]
        public int ProductID { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("vendor_part_number")]
        public string VendorPartNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unit_of_measure")]
        public string UnitOfMeasure { get; set; }

        [JsonProperty("quantity_ordered")]
        public double QuantityOrdered { get; set; }

        [JsonProperty("quantity_received")]
        public double QuantityReceived { get; set; }

        [JsonProperty("quantity_rejected")]
        public double QuantityRejected { get; set; }

        [JsonProperty("quantity_cancelled")]
        public double QuantityCancelled { get; set; }

        [JsonProperty("unit_cost")]
        public double UnitCost { get; set; }

        [JsonProperty("extended_cost")]
        public double ExtendedCost { get; set; }

        [JsonProperty("post_status")]
        public APApiLineItemSummaryPostStatusType PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("status")]
        public APApiLineItemSummaryStatusType Status { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("deliver_to")]
        public string DeliverTo { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiLineItemSummaryTypeType
    {
        Regular,
        Miscellaneous,
        Comment
    }

    public enum APApiLineItemSummaryPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public enum APApiLineItemSummaryStatusType
    {
        NotReceipted,
        PartiallyReceipted,
        FullyReceipted
    }

    public class APApiLineItemDetail
    {
        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string VendorName { get; set; }

        [JsonProperty("order_number")]
        public int OrderNumber { get; set; }

        [JsonProperty("line_item_id")]
        public int ID { get; set; }

        [JsonProperty("line_number")]
        public int LineNumber { get; set; }

        [JsonProperty("type")]
        public APApiLineItemDetailTypeType Type { get; set; }

        [JsonProperty("product_id")]
        public int ProductID { get; set; }

        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        [JsonProperty("vendor_part_number")]
        public string VendorPartNumber { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("unit_of_measure")]
        public string UnitOfMeasure { get; set; }

        [JsonProperty("quantity_ordered")]
        public double QuantityOrdered { get; set; }

        [JsonProperty("quantity_received")]
        public double QuantityReceived { get; set; }

        [JsonProperty("quantity_rejected")]
        public double QuantityRejected { get; set; }

        [JsonProperty("quantity_cancelled")]
        public double QuantityCancelled { get; set; }

        [JsonProperty("unit_cost")]
        public double UnitCost { get; set; }

        [JsonProperty("extended_cost")]
        public double ExtendedCost { get; set; }

        [JsonProperty("post_status")]
        public APApiLineItemDetailPostStatusType PostStatus { get; set; }

        [JsonProperty("post_date")]
        public string PostDate { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("status")]
        public APApiLineItemDetailStatusType Status { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("deliver_to")]
        public string DeliverTo { get; set; }

        [JsonProperty("distributions")]
        public APApiDistribution[] Distribution { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiLineItemDetailTypeType
    {
        Regular,
        Miscellaneous,
        Comment
    }

    public enum APApiLineItemDetailPostStatusType
    {
        Posted,
        NotYetPosted,
        DoNotPost
    }

    public enum APApiLineItemDetailStatusType
    {
        NotReceipted,
        PartiallyReceipted,
        FullyReceipted
    }

    public class APApiReceiptSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiReceiptSummary[] Value { get; set; }
    }

    public class APApiReceiptSummary
    {
        [JsonProperty("receipt_id")]
        public int ID { get; set; }

        [JsonProperty("receipt_number")]
        public int ReceiptNumber { get; set; }

        [JsonProperty("received_by")]
        public string ReceivedBy { get; set; }

        [JsonProperty("receipt_date")]
        public string ReceiptDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("receipt_total")]
        public double ReceiptTotal { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("purchase_order_id")]
        public int PurchaseOrderID { get; set; }

        [JsonProperty("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty("invoice_id")]
        public int InvoiceID { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public class APApiReceiptDetail
    {
        [JsonProperty("receipt_id")]
        public int ID { get; set; }

        [JsonProperty("receipt_number")]
        public int ReceiptNumber { get; set; }

        [JsonProperty("received_by")]
        public string ReceivedBy { get; set; }

        [JsonProperty("receipt_date")]
        public string ReceiptDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("receipt_total")]
        public double ReceiptTotal { get; set; }

        [JsonProperty("vendor_id")]
        public int VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("purchase_order_id")]
        public int PurchaseOrderID { get; set; }

        [JsonProperty("purchase_order_number")]
        public string PurchaseOrderNumber { get; set; }

        [JsonProperty("invoice_id")]
        public int InvoiceID { get; set; }

        [JsonProperty("invoice_number")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public class APApiCreatedVendor
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public enum bodyvendorPaymentDefaultpaymentMethodInput
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public enum bodyvendorPaymentDefaultpaymentOptionInput
    {
        OnePerInvoice,
        OneForAll
    }

    public class APApiVendorSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiVendorSummary[] Value { get; set; }
    }

    public class APApiVendorSummary
    {
        [JsonProperty("vendor_id")]
        public int ID { get; set; }

        [JsonProperty("ui_defined_id")]
        public string VendorID { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("customer_number")]
        public string CustomerNumber { get; set; }

        [JsonProperty("vendor_status")]
        public APApiVendorSummaryStatusType Status { get; set; }

        [JsonProperty("issue_1099s")]
        public bool Issue1099Statement { get; set; }

        [JsonProperty("balance_due")]
        public double BalanceDue { get; set; }

        [JsonProperty("payment_method")]
        public APApiVendorSummaryPaymentMethodType PaymentMethod { get; set; }

        [JsonProperty("primary_address")]
        public APApiVendorSummaryPrimaryAddressType PrimaryAddress { get; set; }

        [JsonProperty("payment_defaults")]
        public APApiVendorPaymentDefault PaymentDefaults { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiVendorSummaryStatusType
    {
        Active,
        Inactive,
        OnHold
    }

    public enum APApiVendorSummaryPaymentMethodType
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public class APApiVendorSummaryPrimaryAddressType
    {
        [JsonProperty("address_id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_line")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string PostalCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("is_invoices")]
        public bool SendInvoices { get; set; }

        [JsonProperty("is_pos")]
        public bool SendPOs { get; set; }

        [JsonProperty("is_1099")]
        public bool Send1099s { get; set; }

        [JsonProperty("title")]
        public string ContactTitle { get; set; }

        [JsonProperty("first_name")]
        public string ContactFirstName { get; set; }

        [JsonProperty("middle_name")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("last_name")]
        public string ContactLastName { get; set; }

        [JsonProperty("suffix")]
        public string ContactSuffix { get; set; }

        [JsonProperty("position")]
        public string ContactPosition { get; set; }

        [JsonProperty("address_contact_methods")]
        public APApiAddressContactMethod[] AddressContactMethods { get; set; }
    }

    public class APApiAddressContactMethod
    {
        [JsonProperty("contact_method_id")]
        public int ID { get; set; }

        [JsonProperty("contact_type")]
        public string Type { get; set; }

        [JsonProperty("contact_info")]
        public string Information { get; set; }
    }

    public class APApiVendorPaymentDefault
    {
        [JsonProperty("has_credit_limit")]
        public bool CreditLimit { get; set; }

        [JsonProperty("credit_limit")]
        public double CreditLimitAmount { get; set; }

        [JsonProperty("payment_terms")]
        public string Terms { get; set; }

        [JsonProperty("account_name")]
        public string AccountName { get; set; }

        [JsonProperty("payment_method")]
        public APApiVendorPaymentDefaultMethodType Method { get; set; }

        [JsonProperty("payment_option")]
        public APApiVendorPaymentDefaultOptionType Option { get; set; }
    }

    public enum APApiVendorPaymentDefaultMethodType
    {
        Check,
        EFT,
        BankDraft,
        CreditCard
    }

    public enum APApiVendorPaymentDefaultOptionType
    {
        OnePerInvoice,
        OneForAll
    }

    public enum statusInput
    {
        Active,
        Inactive,
        OnHold
    }

    public class APApiVendorDetail
    {
        [JsonProperty("vendor_id")]
        public int ID { get; set; }

        [JsonProperty("ui_defined_id")]
        public string VendorID { get; set; }

        [JsonProperty("tax_id_number")]
        public string TaxIDNumber { get; set; }

        [JsonProperty("psb_activity_code_id")]
        public int PSBActivityCodeID { get; set; }

        [JsonProperty("psb_activity_code")]
        public string PSBActivityCode { get; set; }

        [JsonProperty("psb_activity_code_desc")]
        public string PSBActivityCodeDescription { get; set; }

        [JsonProperty("gst_tax_type")]
        public string GSTTaxType { get; set; }

        [JsonProperty("gst_tax_type_desc")]
        public string GSTTaxTypeDescription { get; set; }

        [JsonProperty("gst_branch")]
        public string GSTBranch { get; set; }

        [JsonProperty("vendor_name")]
        public string Name { get; set; }

        [JsonProperty("vendor_type")]
        public APApiVendorDetailTypeType Type { get; set; }

        [JsonProperty("customer_number")]
        public string CustomerNumber { get; set; }

        [JsonProperty("vendor_status")]
        public APApiVendorDetailStatusType Status { get; set; }

        [JsonProperty("issue_1099s")]
        public bool Issue1099Statement { get; set; }

        [JsonProperty("balance_due")]
        public double BalanceDue { get; set; }

        [JsonProperty("addresses")]
        public APApiVendorAddress[] Address { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }

        [JsonProperty("vendor_payment_default")]
        public APApiVendorPaymentDefault VendorPaymentDefault { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("added_by")]
        public string AddedBy { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }

        [JsonProperty("modified_by")]
        public string ModifiedBy { get; set; }
    }

    public enum APApiVendorDetailTypeType
    {
        Organization,
        Individual
    }

    public enum APApiVendorDetailStatusType
    {
        Active,
        Inactive,
        OnHold
    }

    public class APApiVendorAddress
    {
        [JsonProperty("address_id")]
        public int ID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_line")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal")]
        public string PostalCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("is_primary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("is_invoices")]
        public bool SendInvoices { get; set; }

        [JsonProperty("is_pos")]
        public bool SendPOs { get; set; }

        [JsonProperty("is_1099")]
        public bool Send1099s { get; set; }

        [JsonProperty("payee_name")]
        public string PayeeName { get; set; }

        [JsonProperty("title")]
        public string ContactTitle { get; set; }

        [JsonProperty("first_name")]
        public string ContactFirstName { get; set; }

        [JsonProperty("middle_name")]
        public string ContactMiddleName { get; set; }

        [JsonProperty("last_name")]
        public string ContactLastName { get; set; }

        [JsonProperty("suffix")]
        public string ContactSuffix { get; set; }

        [JsonProperty("position")]
        public string ContactPosition { get; set; }

        [JsonProperty("address_contact_methods")]
        public APApiAddressContactMethod[] ContactMethod { get; set; }
    }

    public class APApiVendor1099Information
    {
        [JsonProperty("default_box_numbers")]
        public APApiVendorDefaultBoxNumber[] DefaultBoxNumbers { get; set; }
    }

    public class APApiVendorDefaultBoxNumber
    {
        [JsonProperty("number")]
        public string BoxNumber { get; set; }

        [JsonProperty("state")]
        public string ReportingState { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }
    }

    public class APApiCreatedVendorAddress
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public class APApiVendorAddressCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public APApiVendorAddress[] Results { get; set; }
    }

    public class APApiCreatedVendorAddressContactMethod
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public class APApiVendorAddressContactMethodCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public APApiVendorAddressContactMethod[] Results { get; set; }
    }

    public class APApiVendorAddressContactMethod
    {
        [JsonProperty("contact_method_id")]
        public int ID { get; set; }

        [JsonProperty("contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("contact_info")]
        public string ContactInfo { get; set; }
    }

    public class APApiAttachmentSummaryCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiAttachmentSummary[] Value { get; set; }
    }

    public class APApiAttachmentSummary
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("type")]
        public APApiAttachmentSummaryTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("media_type")]
        public string AttachmentType { get; set; }

        [JsonProperty("date_attached")]
        public string DateAttached { get; set; }
    }

    public enum APApiAttachmentSummaryTypeType
    {
        Link,
        Physical
    }

    public class APApiVendorContactCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiVendorContact[] Value { get; set; }
    }

    public class APApiVendorContact
    {
        [JsonProperty("vendor_contact_id")]
        public int ID { get; set; }

        [JsonProperty("contact_display_name")]
        public string Name { get; set; }

        [JsonProperty("address_description")]
        public string AddressDescription { get; set; }

        [JsonProperty("address_line")]
        public string Address { get; set; }
    }

    public class APApiDefaultDistributionCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public APApiDefaultDistribution[] Value { get; set; }
    }

    public class APApiDefaultDistribution
    {
        [JsonProperty("distribution_id")]
        public int ID { get; set; }

        [JsonProperty("type_code")]
        public APApiDefaultDistributionTypeType Type { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("default_distribution_splits")]
        public APApiDefaultDistributionSplit[] Split { get; set; }

        [JsonProperty("custom_fields")]
        public APApiCustomField[] CustomField { get; set; }
    }

    public enum APApiDefaultDistributionTypeType
    {
        Debit,
        Credit
    }

    public class APApiDefaultDistributionSplit
    {
        [JsonProperty("distribution_split_id")]
        public int ID { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("ui_project_id")]
        public string Project { get; set; }

        [JsonProperty("account_class")]
        public string Class { get; set; }

        [JsonProperty("transaction_code_values")]
        public APApiTransactionCodeValue[] TransactionCodeValues { get; set; }
    }

    public class APApiCreatedVendorNote
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public class APApiVendorNoteActionCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("results")]
        public APApiVendorNoteAction[] Results { get; set; }
    }

    public class APApiVendorNoteAction
    {
        [JsonProperty("note_action_id")]
        public int ID { get; set; }

        [JsonProperty("note_type")]
        public APApiVendorNoteActionRecordTypeType RecordType { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("content")]
        public string Note { get; set; }

        [JsonProperty("assign_to")]
        public string AssignedTo { get; set; }

        [JsonProperty("is_complete")]
        public bool IsComplete { get; set; }

        [JsonProperty("completed_date")]
        public string CompletedOn { get; set; }
    }

    public enum APApiVendorNoteActionRecordTypeType
    {
        Note,
        Action
    }

    public class APApiCreatedVendorAttachment
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }

    public class APApiCreatedVendorAction
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudfenxtpayabl;

    public partial class WorkflowManagedActions
    {
        public BlackbaudfenxtpayablActions Blackbaudfenxtpayabl(string connectionId) => new BlackbaudfenxtpayablActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudfenxtpayablTriggers Blackbaudfenxtpayabl(string connectionId) => new BlackbaudfenxtpayablTriggers(connectionId);
    }
}