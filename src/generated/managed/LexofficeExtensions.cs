//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lexoffice
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LexofficeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseArticlesGet> FilteringArticles(Expression<Func<string>> articleNumber = null, Expression<Func<string>> gtin = null, Expression<Func<string>> type = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/articles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (articleNumber != null)
                callPayload.Queries["articleNumber"] = ExpressionConverter.Convert(articleNumber);
            if (gtin != null)
                callPayload.Queries["gtin"] = ExpressionConverter.Convert(gtin);
            if (type != null)
                callPayload.Queries["type"] = ExpressionConverter.Convert(type);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseArticlesGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseArticlesPost> CreateArticle(Expression<Func<string>> bodyarticleNumber = null, Expression<Func<double>> bodypricegrossPrice = null, Expression<Func<string>> bodypriceleadingPrice = null, Expression<Func<double>> bodypricenetPrice = null, Expression<Func<double>> bodypricetaxRate = null, Expression<Func<string>> bodytitle = null, Expression<Func<bodytypeInput>> bodytype = null, Expression<Func<string>> bodyunitName = null)
        {
            var apiCallPath = "/articles";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyarticleNumber != null)
            {
                body["articleNumber"] = ExpressionConverter.ConvertO(bodyarticleNumber);
                bodypropCount++;
            }

            var priceObject = new JObject();
            var priceObjectpropCount = 0;
            if (bodypricegrossPrice != null)
            {
                priceObject["grossPrice"] = ExpressionConverter.ConvertO(bodypricegrossPrice);
                priceObjectpropCount++;
            }

            if (bodypriceleadingPrice != null)
            {
                priceObject["leadingPrice"] = ExpressionConverter.ConvertO(bodypriceleadingPrice);
                priceObjectpropCount++;
            }

            if (bodypricenetPrice != null)
            {
                priceObject["netPrice"] = ExpressionConverter.ConvertO(bodypricenetPrice);
                priceObjectpropCount++;
            }

            if (bodypricetaxRate != null)
            {
                priceObject["taxRate"] = ExpressionConverter.ConvertO(bodypricetaxRate);
                priceObjectpropCount++;
            }

            if (priceObjectpropCount > 0)
            {
                body["price"] = priceObject;
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodytype != null)
            {
                body["type"] = ExpressionConverter.ConvertO(bodytype);
                bodypropCount++;
            }

            if (bodyunitName != null)
            {
                body["unitName"] = ExpressionConverter.ConvertO(bodyunitName);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseArticlesPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveAnArticleResponse> RetrieveAnArticle(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveAnArticleResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IWorkflowAction DeleteAnArticle(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseArticlesIdGet> UpdateAnArticle(Expression<Func<string>> id, Expression<Func<bodytypeInput>> bodytype, Expression<Func<string>> bodyunitName, Expression<Func<int>> bodyversion, Expression<Func<string>> bodyarticleNumber = null, Expression<Func<string>> bodygtin = null, Expression<Func<string>> bodynote = null, Expression<Func<double>> bodypricegrossPrice = null, Expression<Func<bodypriceleadingPriceInput>> bodypriceleadingPrice = null, Expression<Func<double>> bodypricenetPrice = null, Expression<Func<double>> bodypricetaxRate = null, Expression<Func<string>> bodytitle = null)
        {
            var apiCallPath = String.Format("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyarticleNumber != null)
            {
                body["articleNumber"] = ExpressionConverter.ConvertO(bodyarticleNumber);
                bodypropCount++;
            }

            if (bodygtin != null)
            {
                body["gtin"] = ExpressionConverter.ConvertO(bodygtin);
                bodypropCount++;
            }

            if (bodynote != null)
            {
                body["note"] = ExpressionConverter.ConvertO(bodynote);
                bodypropCount++;
            }

            var priceObject = new JObject();
            var priceObjectpropCount = 0;
            if (bodypricegrossPrice != null)
            {
                priceObject["grossPrice"] = ExpressionConverter.ConvertO(bodypricegrossPrice);
                priceObjectpropCount++;
            }

            if (bodypriceleadingPrice != null)
            {
                if (bodypriceleadingPrice != null)
                {
                    priceObject["leadingPrice"] = ExpressionConverter.ConvertO(bodypriceleadingPrice);
                    priceObjectpropCount++;
                }

                priceObjectpropCount++;
            }
            else
            {
                priceObject["leadingPrice"] = "GROSS";
                priceObjectpropCount++;
            }

            if (bodypricenetPrice != null)
            {
                priceObject["netPrice"] = ExpressionConverter.ConvertO(bodypricenetPrice);
                priceObjectpropCount++;
            }

            if (bodypricetaxRate != null)
            {
                priceObject["taxRate"] = ExpressionConverter.ConvertO(bodypricetaxRate);
                priceObjectpropCount++;
            }

            if (priceObjectpropCount > 0)
            {
                body["price"] = priceObject;
                bodypropCount++;
            }

            if (bodytitle != null)
            {
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            bodypropCount++;
            body["unitName"] = ExpressionConverter.ConvertO(bodyunitName);
            bodypropCount++;
            body["version"] = ExpressionConverter.ConvertO(bodyversion);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseArticlesIdGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseContactsGet> RetrieveAllContacts(Expression<Func<int>> number = null, Expression<Func<string>> email = null, Expression<Func<string>> name = null, Expression<Func<bool>> vendor = null, Expression<Func<bool>> customer = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (number != null)
                callPayload.Queries["number"] = ExpressionConverter.Convert(number);
            if (email != null)
                callPayload.Queries["email"] = ExpressionConverter.Convert(email);
            if (name != null)
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
            if (vendor != null)
                callPayload.Queries["vendor"] = ExpressionConverter.Convert(vendor);
            if (customer != null)
                callPayload.Queries["customer"] = ExpressionConverter.Convert(customer);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["size"] = Convert.ToString(250);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseContactsGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseContactsPost> CreateContact()
        {
            var apiCallPath = "/contacts";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseContactsPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveContactResponse> RetrieveContact(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveContactResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseContactsIdPut> UpdateContact(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseContactsIdPut>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseCountriesGetDefault[]> RetrieveListCountries()
        {
            var apiCallPath = "/countries";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseCountriesGetDefault[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseCreditNotesPost> CreateCreditNote(Expression<Func<bool>> finalize, Expression<Func<string>> precedingSalesVoucherId = null)
        {
            var apiCallPath = "/credit-notes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (precedingSalesVoucherId != null)
                callPayload.Queries["precedingSalesVoucherId"] = ExpressionConverter.Convert(precedingSalesVoucherId);
            callPayload.Queries["finalize"] = ExpressionConverter.Convert(finalize);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseCreditNotesPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveCreditNoteResponse> RetrieveCreditNote(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/credit-notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveCreditNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderCreditNoteDocumentResponse> RenderCreditNoteDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/credit-notes/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderCreditNoteDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseDeliveryNotesPost> CreateDeliveryNote(Expression<Func<string>> precedingSalesVoucherId = null)
        {
            var apiCallPath = "/delivery-notes";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (precedingSalesVoucherId != null)
                callPayload.Queries["precedingSalesVoucherId"] = ExpressionConverter.Convert(precedingSalesVoucherId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseDeliveryNotesPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderDeliveryNoteDocumentResponse> RenderDeliveryNoteDocument(Expression<Func<string>> deliveryNoteid)
        {
            var apiCallPath = String.Format("/delivery-notes/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(deliveryNoteid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderDeliveryNoteDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveDeliveryNoteResponse> RetrieveDeliveryNote(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/delivery-notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveDeliveryNoteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveDownPaymentInvoiceResponse> RetrieveDownPaymentInvoice(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/down-payment-invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveDownPaymentInvoiceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseDunningsPost> CreateDunning(Expression<Func<string>> precedingSalesVoucherId = null)
        {
            var apiCallPath = "/dunnings";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (precedingSalesVoucherId != null)
                callPayload.Queries["precedingSalesVoucherId"] = ExpressionConverter.Convert(precedingSalesVoucherId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseDunningsPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveDunningResponse> RetrieveDunning(Expression<Func<string>> dunningsid)
        {
            var apiCallPath = String.Format("/dunnings/{0}", ExpressionConverter.ConvertWithUrlEncoding(dunningsid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveDunningResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderDunningDocumentResponse> RenderDunningDocument(Expression<Func<string>> dunningsid)
        {
            var apiCallPath = String.Format("/dunnings/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(dunningsid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderDunningDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseEventSubscriptionsGet> RetrieveAllEventSubscriptions()
        {
            var apiCallPath = "/event-subscriptions/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseEventSubscriptionsGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<EventSubscriptionResponse> RetrieveAEventSubscription(Expression<Func<string>> subscriptionId)
        {
            var apiCallPath = String.Format("/event-subscriptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<EventSubscriptionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IWorkflowAction DeleteEventSubscription(Expression<Func<string>> subscriptionId)
        {
            var apiCallPath = String.Format("/event-subscriptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseFilesPost> UploadFileLexoffice(Expression<Func<object>> file, Expression<Func<string>> type)
        {
            var apiCallPath = "/files";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ResponseFilesPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<object> DownloadFileLexoffice(Expression<Func<string>> fileId, Expression<Func<acceptInput>> accept = null)
        {
            var apiCallPath = String.Format("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("*/*");
            if (accept != null)
                callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
            return new ApiConnectionAction<object>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseInvoicesPost> CreateInvoice(Expression<Func<bool>> finalize, Expression<Func<string>> precedingSalesVoucherId = null)
        {
            var apiCallPath = "/invoices";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (precedingSalesVoucherId != null)
                callPayload.Queries["precedingSalesVoucherId"] = ExpressionConverter.Convert(precedingSalesVoucherId);
            callPayload.Queries["finalize"] = ExpressionConverter.Convert(finalize);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseInvoicesPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveInvoiceResponse> RetrieveInvoice(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveInvoiceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderInvoiceDocumentResponse> RenderInvoiceDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/invoices/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderInvoiceDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseOrderConfirmationsPost> CreateOrderConfirmation(Expression<Func<string>> precedingSalesVoucherId = null)
        {
            var apiCallPath = "/order-confirmations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (precedingSalesVoucherId != null)
                callPayload.Queries["precedingSalesVoucherId"] = ExpressionConverter.Convert(precedingSalesVoucherId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseOrderConfirmationsPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveOrderConfirmationResponse> RetrieveOrderConfirmation(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/order-confirmations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveOrderConfirmationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderOrderConfirmationDocumentResponse> RenderOrderConfirmationDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/order-confirmations/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderOrderConfirmationDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponsePaymentConditionsGetItems[]> RetrieveListOfPaymentConditions()
        {
            var apiCallPath = "/payment-conditions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponsePaymentConditionsGetItems[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrievePaymentInformationResponse> RetrievePaymentInformation(Expression<Func<string>> voucherId)
        {
            var apiCallPath = String.Format("/payments/{0}", ExpressionConverter.ConvertWithUrlEncoding(voucherId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrievePaymentInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponsePostingCategoriesGetItems[]> RetrieveListPostingCategories()
        {
            var apiCallPath = "/posting-categories";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponsePostingCategoriesGetItems[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseProfileGet> RetrieveProfileInformation()
        {
            var apiCallPath = "/profile";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseProfileGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseQuotationsPost> CreateQuotation(Expression<Func<bool>> finalize)
        {
            var apiCallPath = "/quotations";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["finalize"] = ExpressionConverter.Convert(finalize);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseQuotationsPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveQuotationResponse> RetrieveQuotation(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/quotations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveQuotationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RenderQuotationDocumentResponse> RenderQuotationDocument(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/quotations/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RenderQuotationDocumentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseRecurringTemplatesGet> RetrieveAllRecurringTemplates(Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/recurring-templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseRecurringTemplatesGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveRecurringTemplateResponse> RetrieveRecurringTemplate(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/recurring-templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveRecurringTemplateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseVoucherlistGet> RetrieveAndFilterVoucherlist(Expression<Func<voucherTypeInput>> voucherType, Expression<Func<voucherStatusInput>> voucherStatus, Expression<Func<bool>> archived = null, Expression<Func<string>> contactId = null, Expression<Func<string>> voucherDateFrom = null, Expression<Func<string>> voucherDateTo = null, Expression<Func<string>> createdDateFrom = null, Expression<Func<string>> createdDateTo = null, Expression<Func<string>> updatedDateFrom = null, Expression<Func<string>> updatedDateTo = null, Expression<Func<string>> voucherNumber = null, Expression<Func<int>> page = null, Expression<Func<int>> size = null, Expression<Func<string>> sort = null)
        {
            var apiCallPath = "/voucherlist";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["voucherType"] = ExpressionConverter.Convert(voucherType);
            callPayload.Queries["voucherStatus"] = ExpressionConverter.Convert(voucherStatus);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            if (contactId != null)
                callPayload.Queries["contactId"] = ExpressionConverter.Convert(contactId);
            if (voucherDateFrom != null)
                callPayload.Queries["voucherDateFrom"] = ExpressionConverter.Convert(voucherDateFrom);
            if (voucherDateTo != null)
                callPayload.Queries["voucherDateTo"] = ExpressionConverter.Convert(voucherDateTo);
            if (createdDateFrom != null)
                callPayload.Queries["createdDateFrom"] = ExpressionConverter.Convert(createdDateFrom);
            if (createdDateTo != null)
                callPayload.Queries["createdDateTo"] = ExpressionConverter.Convert(createdDateTo);
            if (updatedDateFrom != null)
                callPayload.Queries["updatedDateFrom"] = ExpressionConverter.Convert(updatedDateFrom);
            if (updatedDateTo != null)
                callPayload.Queries["updatedDateTo"] = ExpressionConverter.Convert(updatedDateTo);
            if (voucherNumber != null)
                callPayload.Queries["voucherNumber"] = ExpressionConverter.Convert(voucherNumber);
            callPayload.Queries["page"] = Convert.ToString(0);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["size"] = Convert.ToString(250);
            if (size != null)
                callPayload.Queries["size"] = ExpressionConverter.Convert(size);
            callPayload.Queries["sort"] = Convert.ToString("voucherNumber,DESC");
            if (sort != null)
                callPayload.Queries["sort"] = ExpressionConverter.Convert(sort);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<ResponseVoucherlistGet>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseVouchersPost> CreateVoucher(Expression<Func<bodytaxTypeInput>> bodytaxType, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodyvoucherItemsInputItem[]>> bodyvoucherItems, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyshippingDate = null, Expression<Func<double>> bodytotalGrossAmount = null, Expression<Func<double>> bodytotalTaxAmount = null, Expression<Func<bool>> bodyuseCollectiveContact = null, Expression<Func<string>> bodyvoucherDate = null, Expression<Func<string>> bodyvoucherNumber = null, Expression<Func<bodyvoucherStatusInput>> bodyvoucherStatus = null)
        {
            var apiCallPath = "/vouchers";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactId != null)
            {
                body["contactId"] = ExpressionConverter.ConvertO(bodycontactId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyshippingDate != null)
            {
                body["shippingDate"] = ExpressionConverter.ConvertO(bodyshippingDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["taxType"] = ExpressionConverter.ConvertO(bodytaxType);
            if (bodytotalGrossAmount != null)
            {
                body["totalGrossAmount"] = ExpressionConverter.ConvertO(bodytotalGrossAmount);
                bodypropCount++;
            }

            if (bodytotalTaxAmount != null)
            {
                body["totalTaxAmount"] = ExpressionConverter.ConvertO(bodytotalTaxAmount);
                bodypropCount++;
            }

            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyuseCollectiveContact != null)
            {
                body["useCollectiveContact"] = ExpressionConverter.ConvertO(bodyuseCollectiveContact);
                bodypropCount++;
            }

            if (bodyvoucherDate != null)
            {
                body["voucherDate"] = ExpressionConverter.ConvertO(bodyvoucherDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["voucherItems"] = ExpressionConverter.ConvertO(bodyvoucherItems);
            if (bodyvoucherNumber != null)
            {
                body["voucherNumber"] = ExpressionConverter.ConvertO(bodyvoucherNumber);
                bodypropCount++;
            }

            if (bodyvoucherStatus != null)
            {
                body["voucherStatus"] = ExpressionConverter.ConvertO(bodyvoucherStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseVouchersPost>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<RetrieveVoucherResponse> RetrieveVoucher(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/vouchers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            return new ApiConnectionAction<RetrieveVoucherResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IBodyWorkflowAction<ResponseVouchersIdPut> UpdateVoucher(Expression<Func<string>> id, Expression<Func<bodytaxTypeInput>> bodytaxType, Expression<Func<bodytypeInput>> bodytype, Expression<Func<bodyvoucherItemsInputItem[]>> bodyvoucherItems, Expression<Func<string>> bodycontactId = null, Expression<Func<string>> bodydueDate = null, Expression<Func<string[]>> bodyfiles = null, Expression<Func<string>> bodyremark = null, Expression<Func<string>> bodyshippingDate = null, Expression<Func<double>> bodytotalGrossAmount = null, Expression<Func<double>> bodytotalTaxAmount = null, Expression<Func<bool>> bodyuseCollectiveContact = null, Expression<Func<int>> bodyversion = null, Expression<Func<string>> bodyvoucherDate = null, Expression<Func<string>> bodyvoucherNumber = null, Expression<Func<bodyvoucherStatusInput>> bodyvoucherStatus = null)
        {
            var apiCallPath = String.Format("/vouchers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            if (bodycontactId != null)
            {
                body["contactId"] = ExpressionConverter.ConvertO(bodycontactId);
                bodypropCount++;
            }

            if (bodydueDate != null)
            {
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
            }

            if (bodyfiles != null)
            {
                body["files"] = ExpressionConverter.ConvertO(bodyfiles);
                bodypropCount++;
            }

            if (bodyremark != null)
            {
                body["remark"] = ExpressionConverter.ConvertO(bodyremark);
                bodypropCount++;
            }

            if (bodyshippingDate != null)
            {
                body["shippingDate"] = ExpressionConverter.ConvertO(bodyshippingDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["taxType"] = ExpressionConverter.ConvertO(bodytaxType);
            if (bodytotalGrossAmount != null)
            {
                body["totalGrossAmount"] = ExpressionConverter.ConvertO(bodytotalGrossAmount);
                bodypropCount++;
            }

            if (bodytotalTaxAmount != null)
            {
                body["totalTaxAmount"] = ExpressionConverter.ConvertO(bodytotalTaxAmount);
                bodypropCount++;
            }

            bodypropCount++;
            body["type"] = ExpressionConverter.ConvertO(bodytype);
            if (bodyuseCollectiveContact != null)
            {
                body["useCollectiveContact"] = ExpressionConverter.ConvertO(bodyuseCollectiveContact);
                bodypropCount++;
            }

            if (bodyversion != null)
            {
                body["version"] = ExpressionConverter.ConvertO(bodyversion);
                bodypropCount++;
            }

            if (bodyvoucherDate != null)
            {
                body["voucherDate"] = ExpressionConverter.ConvertO(bodyvoucherDate);
                bodypropCount++;
            }

            bodypropCount++;
            body["voucherItems"] = ExpressionConverter.ConvertO(bodyvoucherItems);
            if (bodyvoucherNumber != null)
            {
                body["voucherNumber"] = ExpressionConverter.ConvertO(bodyvoucherNumber);
                bodypropCount++;
            }

            if (bodyvoucherStatus != null)
            {
                body["voucherStatus"] = ExpressionConverter.ConvertO(bodyvoucherStatus);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<ResponseVouchersIdPut>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        public IWorkflowAction UploadFileVoucherLexoffice(Expression<Func<string>> id, Expression<Func<object>> file)
        {
            var apiCallPath = String.Format("/vouchers/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }
    }

    public class LexofficeTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<ResponseEventSubscriptionsPost> EventSubscriptionLexoffice(Expression<Func<bodyeventTypeInput>> bodyeventType, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/event-subscriptions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
            callPayload.Headers["Accept"] = Convert.ToString("application/json");
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger<ResponseEventSubscriptionsPost>(callPayload, triggerName, recurrence);
        }
    }

    public class ResponseArticlesGet
    {
        [JsonProperty("content")]
        public ResponseArticlesGetContentTypeItem[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public ResponseArticlesGetSortTypeItem[] Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ResponseArticlesGetContentTypeItem
    {
        [JsonProperty("articleNumber")]
        public string ArticleNumber { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("price")]
        public ResponseArticlesGetContentTypeItemPriceType Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ResponseArticlesGetContentTypeItemPriceType
    {
        [JsonProperty("grossPrice")]
        public double GrossPrice { get; set; }

        [JsonProperty("leadingPrice")]
        public string LeadingPrice { get; set; }

        [JsonProperty("netPrice")]
        public double NetPrice { get; set; }

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; }
    }

    public class ResponseArticlesGetSortTypeItem
    {
        [JsonProperty("ascending")]
        public bool Ascending { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("ignoreCase")]
        public bool IgnoreCase { get; set; }

        [JsonProperty("nullHandling")]
        public string NullHandling { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }
    }

    public class ResponseArticlesPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public enum bodytypeInput
    {
        [EnumMember(Value = "salesinvoice")]
        Salesinvoice,
        [EnumMember(Value = "salescreditnote")]
        Salescreditnote,
        [EnumMember(Value = "purchaseinvoice")]
        Purchaseinvoice,
        [EnumMember(Value = "purchasecreditnote")]
        Purchasecreditnote,
        [EnumMember(Value = "invoice")]
        Invoice,
        [EnumMember(Value = "downpaymentinvoice")]
        Downpaymentinvoice,
        [EnumMember(Value = "creditnote")]
        Creditnote,
        [EnumMember(Value = "orderconfirmation")]
        Orderconfirmation,
        [EnumMember(Value = "quotation")]
        Quotation,
        [EnumMember(Value = "deliverynote")]
        Deliverynote
    }

    public class RetrieveAnArticleResponse
    {
        [JsonProperty("articleNumber")]
        public string ArticleNumber { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("price")]
        public RetrieveAnArticleResponsePriceType Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveAnArticleResponsePriceType
    {
        [JsonProperty("grossPrice")]
        public double GrossPrice { get; set; }

        [JsonProperty("leadingPrice")]
        public string LeadingPrice { get; set; }

        [JsonProperty("netPrice")]
        public double NetPrice { get; set; }

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; }
    }

    public class ResponseArticlesIdGet
    {
        [JsonProperty("articleNumber")]
        public string ArticleNumber { get; set; }

        [JsonProperty("gtin")]
        public string Gtin { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("price")]
        public ResponseArticlesIdGetPriceType Price { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ResponseArticlesIdGetPriceType
    {
        [JsonProperty("grossPrice")]
        public double GrossPrice { get; set; }

        [JsonProperty("leadingPrice")]
        public string LeadingPrice { get; set; }

        [JsonProperty("netPrice")]
        public double NetPrice { get; set; }

        [JsonProperty("taxRate")]
        public double TaxRate { get; set; }
    }

    public enum bodypriceleadingPriceInput
    {
        GROSS,
        NET
    }

    public class ResponseContactsGet
    {
        [JsonProperty("content")]
        public ResponseContactsGetContentTypeItem[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public ResponseContactsGetSortTypeItem[] Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ResponseContactsGetContentTypeItem
    {
        [JsonProperty("addresses")]
        public ResponseContactsGetContentTypeItemAddressesType Addresses { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("company")]
        public ResponseContactsGetContentTypeItemCompanyType Company { get; set; }

        [JsonProperty("emailAddresses")]
        public ResponseContactsGetContentTypeItemEmailAddressesType EmailAddresses { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("phoneNumbers")]
        public ResponseContactsGetContentTypeItemPhoneNumbersType PhoneNumbers { get; set; }

        [JsonProperty("roles")]
        public ResponseContactsGetContentTypeItemRolesType Roles { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ResponseContactsGetContentTypeItemAddressesType
    {
        [JsonProperty("billing")]
        public ResponseContactsGetContentTypeItemAddressesTypeBillingTypeItem[] Billing { get; set; }

        [JsonProperty("shipping")]
        public ResponseContactsGetContentTypeItemAddressesTypeShippingTypeItem[] Shipping { get; set; }
    }

    public class ResponseContactsGetContentTypeItemAddressesTypeBillingTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ResponseContactsGetContentTypeItemAddressesTypeShippingTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class ResponseContactsGetContentTypeItemCompanyType
    {
        [JsonProperty("allowTaxFreeInvoices")]
        public bool AllowTaxFreeInvoices { get; set; }

        [JsonProperty("contactPersons")]
        public ResponseContactsGetContentTypeItemCompanyTypeContactPersonsTypeItem[] ContactPersons { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("taxNumber")]
        public string TaxNumber { get; set; }

        [JsonProperty("vatRegistrationId")]
        public string VatRegistrationId { get; set; }
    }

    public class ResponseContactsGetContentTypeItemCompanyTypeContactPersonsTypeItem
    {
        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }
    }

    public class ResponseContactsGetContentTypeItemEmailAddressesType
    {
        [JsonProperty("business")]
        public string[] Business { get; set; }

        [JsonProperty("office")]
        public string[] Office { get; set; }

        [JsonProperty("other")]
        public string[] Other { get; set; }
    }

    public class ResponseContactsGetContentTypeItemPhoneNumbersType
    {
        [JsonProperty("business")]
        public string[] Business { get; set; }

        [JsonProperty("fax")]
        public string[] Fax { get; set; }

        [JsonProperty("office")]
        public string[] Office { get; set; }

        [JsonProperty("other")]
        public string[] Other { get; set; }
    }

    public class ResponseContactsGetContentTypeItemRolesType
    {
        [JsonProperty("customer")]
        public ResponseContactsGetContentTypeItemRolesTypeCustomerType Customer { get; set; }

        [JsonProperty("vendor")]
        public ResponseContactsGetContentTypeItemRolesTypeVendorType Vendor { get; set; }
    }

    public class ResponseContactsGetContentTypeItemRolesTypeCustomerType
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class ResponseContactsGetContentTypeItemRolesTypeVendorType
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class ResponseContactsGetSortTypeItem
    {
        [JsonProperty("ascending")]
        public bool Ascending { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("ignoreCase")]
        public bool IgnoreCase { get; set; }

        [JsonProperty("nullHandling")]
        public string NullHandling { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }
    }

    public class ResponseContactsPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveContactResponse
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("person")]
        public RetrieveContactResponsePersonType Person { get; set; }

        [JsonProperty("roles")]
        public RetrieveContactResponseRolesType Roles { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveContactResponsePersonType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }
    }

    public class RetrieveContactResponseRolesType
    {
        [JsonProperty("customer")]
        public RetrieveContactResponseRolesTypeCustomerType Customer { get; set; }
    }

    public class RetrieveContactResponseRolesTypeCustomerType
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class ResponseContactsIdPut
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("person")]
        public ResponseContactsIdPutPersonType Person { get; set; }

        [JsonProperty("roles")]
        public ResponseContactsIdPutRolesType Roles { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class ResponseContactsIdPutPersonType
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("salutation")]
        public string Salutation { get; set; }
    }

    public class ResponseContactsIdPutRolesType
    {
        [JsonProperty("customer")]
        public ResponseContactsIdPutRolesTypeCustomerType Customer { get; set; }
    }

    public class ResponseContactsIdPutRolesTypeCustomerType
    {
        [JsonProperty("number")]
        public int Number { get; set; }
    }

    public class ResponseCountriesGetDefault
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryNameDE")]
        public string CountryNameDE { get; set; }

        [JsonProperty("countryNameEN")]
        public string CountryNameEN { get; set; }

        [JsonProperty("taxClassification")]
        public string TaxClassification { get; set; }
    }

    public class ResponseCreditNotesPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveCreditNoteResponse
    {
        [JsonProperty("address")]
        public RetrieveCreditNoteResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveCreditNoteResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveCreditNoteResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveCreditNoteResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveCreditNoteResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveCreditNoteResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveCreditNoteResponseLineItemsTypeItem
    {
        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveCreditNoteResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveCreditNoteResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveCreditNoteResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveCreditNoteResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveCreditNoteResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class RenderCreditNoteDocumentResponse
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class ResponseDeliveryNotesPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RenderDeliveryNoteDocumentResponse
    {
        [JsonProperty("address")]
        public RenderDeliveryNoteDocumentResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("deliveryTerms")]
        public string DeliveryTerms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RenderDeliveryNoteDocumentResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("taxConditions")]
        public RenderDeliveryNoteDocumentResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RenderDeliveryNoteDocumentResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RenderDeliveryNoteDocumentResponseLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RenderDeliveryNoteDocumentResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RenderDeliveryNoteDocumentResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RenderDeliveryNoteDocumentResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveDeliveryNoteResponse
    {
        [JsonProperty("address")]
        public RetrieveDeliveryNoteResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("deliveryTerms")]
        public string DeliveryTerms { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveDeliveryNoteResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveDeliveryNoteResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveDeliveryNoteResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveDeliveryNoteResponseLineItemsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveDeliveryNoteResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveDeliveryNoteResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveDeliveryNoteResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponse
    {
        [JsonProperty("address")]
        public RetrieveDownPaymentInvoiceResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("closingInvoiceId")]
        public string ClosingInvoiceId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("files")]
        public RetrieveDownPaymentInvoiceResponseFilesType Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveDownPaymentInvoiceResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public RetrieveDownPaymentInvoiceResponsePaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingConditions")]
        public RetrieveDownPaymentInvoiceResponseShippingConditionsType ShippingConditions { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveDownPaymentInvoiceResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveDownPaymentInvoiceResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveDownPaymentInvoiceResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseFilesType
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseLineItemsTypeItem
    {
        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveDownPaymentInvoiceResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponsePaymentConditionsType
    {
        [JsonProperty("paymentDiscountConditions")]
        public RetrieveDownPaymentInvoiceResponsePaymentConditionsTypePaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponsePaymentConditionsTypePaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseShippingConditionsType
    {
        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveDownPaymentInvoiceResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class ResponseDunningsPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveDunningResponse
    {
        [JsonProperty("address")]
        public RetrieveDunningResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveDunningResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("relatedVouchers")]
        public RetrieveDunningResponseRelatedVouchersTypeItem[] RelatedVouchers { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingConditions")]
        public RetrieveDunningResponseShippingConditionsType ShippingConditions { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveDunningResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveDunningResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveDunningResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveDunningResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveDunningResponseLineItemsTypeItem
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveDunningResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveDunningResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveDunningResponseRelatedVouchersTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherType")]
        public string VoucherType { get; set; }
    }

    public class RetrieveDunningResponseShippingConditionsType
    {
        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }
    }

    public class RetrieveDunningResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveDunningResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveDunningResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class RenderDunningDocumentResponse
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class ResponseEventSubscriptionsGet
    {
        [JsonProperty("content")]
        public ResponseEventSubscriptionsGetContentTypeItem[] Content { get; set; }
    }

    public class ResponseEventSubscriptionsGetContentTypeItem
    {
        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }
    }

    public class EventSubscriptionResponse
    {
        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("eventType")]
        public string EventType { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }
    }

    public class ResponseFilesPost
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public enum acceptInput
    {
        [EnumMember(Value = "*/*")]
        Unnamed,
        [EnumMember(Value = "application/xml")]
        ApplicationXml,
        [EnumMember(Value = "application/pdf")]
        ApplicationPdf,
        [EnumMember(Value = "image/jpeg")]
        ImageJpeg,
        [EnumMember(Value = "image/png")]
        ImagePng
    }

    public class ResponseInvoicesPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveInvoiceResponse
    {
        [JsonProperty("address")]
        public RetrieveInvoiceResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveInvoiceResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public RetrieveInvoiceResponsePaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingConditions")]
        public RetrieveInvoiceResponseShippingConditionsType ShippingConditions { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveInvoiceResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveInvoiceResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveInvoiceResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveInvoiceResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveInvoiceResponseLineItemsTypeItem
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveInvoiceResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveInvoiceResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveInvoiceResponsePaymentConditionsType
    {
        [JsonProperty("paymentDiscountConditions")]
        public RetrieveInvoiceResponsePaymentConditionsTypePaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class RetrieveInvoiceResponsePaymentConditionsTypePaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class RetrieveInvoiceResponseShippingConditionsType
    {
        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }
    }

    public class RetrieveInvoiceResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveInvoiceResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveInvoiceResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class RenderInvoiceDocumentResponse
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class ResponseOrderConfirmationsPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveOrderConfirmationResponse
    {
        [JsonProperty("address")]
        public RetrieveOrderConfirmationResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("deliveryTerms")]
        public string DeliveryTerms { get; set; }

        [JsonProperty("files")]
        public RetrieveOrderConfirmationResponseFilesType Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveOrderConfirmationResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public RetrieveOrderConfirmationResponsePaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingConditions")]
        public RetrieveOrderConfirmationResponseShippingConditionsType ShippingConditions { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveOrderConfirmationResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveOrderConfirmationResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveOrderConfirmationResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveOrderConfirmationResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("supplement")]
        public string Supplement { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveOrderConfirmationResponseFilesType
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class RetrieveOrderConfirmationResponseLineItemsTypeItem
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveOrderConfirmationResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveOrderConfirmationResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveOrderConfirmationResponsePaymentConditionsType
    {
        [JsonProperty("paymentDiscountConditions")]
        public RetrieveOrderConfirmationResponsePaymentConditionsTypePaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class RetrieveOrderConfirmationResponsePaymentConditionsTypePaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class RetrieveOrderConfirmationResponseShippingConditionsType
    {
        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }
    }

    public class RetrieveOrderConfirmationResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveOrderConfirmationResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveOrderConfirmationResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class RenderOrderConfirmationDocumentResponse
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class ResponsePaymentConditionsGetItems
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationDefault")]
        public bool OrganizationDefault { get; set; }

        [JsonProperty("paymentDiscountConditions")]
        public ResponsePaymentConditionsGetItemsPaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class ResponsePaymentConditionsGetItemsPaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public int DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class RetrievePaymentInformationResponse
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("openAmount")]
        public string OpenAmount { get; set; }

        [JsonProperty("paymentItems")]
        public RetrievePaymentInformationResponsePaymentItemsTypeItem[] PaymentItems { get; set; }

        [JsonProperty("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }

        [JsonProperty("voucherType")]
        public string VoucherType { get; set; }
    }

    public class RetrievePaymentInformationResponsePaymentItemsTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("paymentItemType")]
        public string PaymentItemType { get; set; }

        [JsonProperty("postingDate")]
        public string PostingDate { get; set; }
    }

    public class ResponsePostingCategoriesGetItems
    {
        [JsonProperty("contactRequired")]
        public bool ContactRequired { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("splitAllowed")]
        public bool SplitAllowed { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ResponseProfileGet
    {
        [JsonProperty("businessFeatures")]
        public string[] BusinessFeatures { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("created")]
        public ResponseProfileGetCreatedType Created { get; set; }

        [JsonProperty("features")]
        public string[] Features { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("smallBusiness")]
        public bool SmallBusiness { get; set; }

        [JsonProperty("subscriptionStatus")]
        public string SubscriptionStatus { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class ResponseProfileGetCreatedType
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }
    }

    public class ResponseQuotationsPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveQuotationResponse
    {
        [JsonProperty("address")]
        public RetrieveQuotationResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("expirationDate")]
        public string ExpirationDate { get; set; }

        [JsonProperty("files")]
        public RetrieveQuotationResponseFilesType Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveQuotationResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public RetrieveQuotationResponsePaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveQuotationResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveQuotationResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveQuotationResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveQuotationResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveQuotationResponseFilesType
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class RetrieveQuotationResponseLineItemsTypeItem
    {
        [JsonProperty("alternative")]
        public bool Alternative { get; set; }

        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("subItems")]
        public RetrieveQuotationResponseLineItemsTypeItemSubItemsTypeItem[] SubItems { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveQuotationResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveQuotationResponseLineItemsTypeItemSubItemsTypeItem
    {
        [JsonProperty("alternative")]
        public bool Alternative { get; set; }

        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("optional")]
        public bool Optional { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveQuotationResponseLineItemsTypeItemSubItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveQuotationResponseLineItemsTypeItemSubItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveQuotationResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveQuotationResponsePaymentConditionsType
    {
        [JsonProperty("paymentDiscountConditions")]
        public RetrieveQuotationResponsePaymentConditionsTypePaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class RetrieveQuotationResponsePaymentConditionsTypePaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class RetrieveQuotationResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveQuotationResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveQuotationResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class RenderQuotationDocumentResponse
    {
        [JsonProperty("documentFileId")]
        public string DocumentFileId { get; set; }
    }

    public class ResponseRecurringTemplatesGet
    {
        [JsonProperty("content")]
        public ResponseRecurringTemplatesGetContentTypeItem[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public ResponseRecurringTemplatesGetSortTypeItem[] Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItem
    {
        [JsonProperty("address")]
        public ResponseRecurringTemplatesGetContentTypeItemAddressType Address { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public ResponseRecurringTemplatesGetContentTypeItemPaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("recurringTemplateSettings")]
        public ResponseRecurringTemplatesGetContentTypeItemRecurringTemplateSettingsType RecurringTemplateSettings { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public ResponseRecurringTemplatesGetContentTypeItemTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItemAddressType
    {
        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItemPaymentConditionsType
    {
        [JsonProperty("paymentDiscountConditions")]
        public ResponseRecurringTemplatesGetContentTypeItemPaymentConditionsTypePaymentDiscountConditionsType PaymentDiscountConditions { get; set; }

        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItemPaymentConditionsTypePaymentDiscountConditionsType
    {
        [JsonProperty("discountPercentage")]
        public int DiscountPercentage { get; set; }

        [JsonProperty("discountRange")]
        public int DiscountRange { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItemRecurringTemplateSettingsType
    {
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("executionInterval")]
        public string ExecutionInterval { get; set; }

        [JsonProperty("executionStatus")]
        public string ExecutionStatus { get; set; }

        [JsonProperty("finalize")]
        public bool Finalize { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("lastExecutionFailed")]
        public bool LastExecutionFailed { get; set; }

        [JsonProperty("nextExecutionDate")]
        public string NextExecutionDate { get; set; }

        [JsonProperty("shippingType")]
        public string ShippingType { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }
    }

    public class ResponseRecurringTemplatesGetContentTypeItemTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public int TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }
    }

    public class ResponseRecurringTemplatesGetSortTypeItem
    {
        [JsonProperty("ascending")]
        public bool Ascending { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("ignoreCase")]
        public bool IgnoreCase { get; set; }

        [JsonProperty("nullHandling")]
        public string NullHandling { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }
    }

    public class RetrieveRecurringTemplateResponse
    {
        [JsonProperty("address")]
        public RetrieveRecurringTemplateResponseAddressType Address { get; set; }

        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("introduction")]
        public string Introduction { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("lineItems")]
        public RetrieveRecurringTemplateResponseLineItemsTypeItem[] LineItems { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("paymentConditions")]
        public RetrieveRecurringTemplateResponsePaymentConditionsType PaymentConditions { get; set; }

        [JsonProperty("recurringTemplateSettings")]
        public JToken RecurringTemplateSettings { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("taxAmounts")]
        public RetrieveRecurringTemplateResponseTaxAmountsTypeItem[] TaxAmounts { get; set; }

        [JsonProperty("taxConditions")]
        public RetrieveRecurringTemplateResponseTaxConditionsType TaxConditions { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPrice")]
        public RetrieveRecurringTemplateResponseTotalPriceType TotalPrice { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public class RetrieveRecurringTemplateResponseAddressType
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class RetrieveRecurringTemplateResponseLineItemsTypeItem
    {
        [JsonProperty("discountPercentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("lineItemAmount")]
        public double LineItemAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitPrice")]
        public RetrieveRecurringTemplateResponseLineItemsTypeItemUnitPriceType UnitPrice { get; set; }
    }

    public class RetrieveRecurringTemplateResponseLineItemsTypeItemUnitPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("grossAmount")]
        public double GrossAmount { get; set; }

        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveRecurringTemplateResponsePaymentConditionsType
    {
        [JsonProperty("paymentTermDuration")]
        public int PaymentTermDuration { get; set; }

        [JsonProperty("paymentTermLabel")]
        public string PaymentTermLabel { get; set; }

        [JsonProperty("paymentTermLabelTemplate")]
        public string PaymentTermLabelTemplate { get; set; }
    }

    public class RetrieveRecurringTemplateResponseTaxAmountsTypeItem
    {
        [JsonProperty("netAmount")]
        public double NetAmount { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercentage")]
        public double TaxRatePercentage { get; set; }
    }

    public class RetrieveRecurringTemplateResponseTaxConditionsType
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class RetrieveRecurringTemplateResponseTotalPriceType
    {
        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }
    }

    public class ResponseVoucherlistGet
    {
        [JsonProperty("content")]
        public ResponseVoucherlistGetContentTypeItem[] Content { get; set; }

        [JsonProperty("first")]
        public bool First { get; set; }

        [JsonProperty("last")]
        public bool Last { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("numberOfElements")]
        public int NumberOfElements { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("sort")]
        public ResponseVoucherlistGetSortTypeItem[] Sort { get; set; }

        [JsonProperty("totalElements")]
        public int TotalElements { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }
    }

    public class ResponseVoucherlistGetContentTypeItem
    {
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("contactId")]
        public string ContactId { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("openAmount")]
        public double OpenAmount { get; set; }

        [JsonProperty("totalAmount")]
        public double TotalAmount { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }

        [JsonProperty("voucherType")]
        public string VoucherType { get; set; }
    }

    public class ResponseVoucherlistGetSortTypeItem
    {
        [JsonProperty("ascending")]
        public bool Ascending { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("ignoreCase")]
        public bool IgnoreCase { get; set; }

        [JsonProperty("nullHandling")]
        public string NullHandling { get; set; }

        [JsonProperty("property")]
        public string Property { get; set; }
    }

    public enum voucherTypeInput
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "salesinvoice")]
        Salesinvoice,
        [EnumMember(Value = "salescreditnote")]
        Salescreditnote,
        [EnumMember(Value = "purchaseinvoice")]
        Purchaseinvoice,
        [EnumMember(Value = "purchasecreditnote")]
        Purchasecreditnote,
        [EnumMember(Value = "invoice")]
        Invoice,
        [EnumMember(Value = "creditnote")]
        Creditnote,
        [EnumMember(Value = "orderconfirmation")]
        Orderconfirmation,
        [EnumMember(Value = "quotation")]
        Quotation,
        [EnumMember(Value = "downpaymentinvoice")]
        Downpaymentinvoice,
        [EnumMember(Value = "deliverynote")]
        Deliverynote
    }

    public enum voucherStatusInput
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "draft")]
        Draft,
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "overdue")]
        Overdue,
        [EnumMember(Value = "paid")]
        Paid,
        [EnumMember(Value = "paidoff")]
        Paidoff,
        [EnumMember(Value = "voided")]
        Voided,
        [EnumMember(Value = "transferred")]
        Transferred,
        [EnumMember(Value = "sepadebit")]
        Sepadebit,
        [EnumMember(Value = "accepted")]
        Accepted,
        [EnumMember(Value = "rejected")]
        Rejected,
        [EnumMember(Value = "uncheked")]
        Uncheked
    }

    public class ResponseVouchersPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public enum bodytaxTypeInput
    {
        [EnumMember(Value = "net")]
        Net,
        [EnumMember(Value = "gross")]
        Gross
    }

    public class bodyvoucherItemsInputItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercent")]
        public int TaxRatePercent { get; set; }
    }

    public enum bodyvoucherStatusInput
    {
        [EnumMember(Value = "unchecked")]
        Unchecked,
        [EnumMember(Value = "open")]
        Open
    }

    public class RetrieveVoucherResponse
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("files")]
        public string[] Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("useCollectiveContact")]
        public bool UseCollectiveContact { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherItems")]
        public RetrieveVoucherResponseVoucherItemsTypeItem[] VoucherItems { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class RetrieveVoucherResponseVoucherItemsTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercent")]
        public double TaxRatePercent { get; set; }
    }

    public class ResponseVouchersIdPut
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("files")]
        public JToken[] Files { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("organizationId")]
        public string OrganizationId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("shippingDate")]
        public string ShippingDate { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("totalTaxAmount")]
        public double TotalTaxAmount { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("useCollectiveContact")]
        public bool UseCollectiveContact { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("voucherDate")]
        public string VoucherDate { get; set; }

        [JsonProperty("voucherItems")]
        public ResponseVouchersIdPutVoucherItemsTypeItem[] VoucherItems { get; set; }

        [JsonProperty("voucherNumber")]
        public string VoucherNumber { get; set; }

        [JsonProperty("voucherStatus")]
        public string VoucherStatus { get; set; }
    }

    public class ResponseVouchersIdPutVoucherItemsTypeItem
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("taxAmount")]
        public double TaxAmount { get; set; }

        [JsonProperty("taxRatePercent")]
        public double TaxRatePercent { get; set; }
    }

    public class ResponseEventSubscriptionsPost
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("resourceUri")]
        public string ResourceUri { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }
    }

    public enum bodyeventTypeInput
    {
        [EnumMember(Value = "article.created")]
        ArticleCreated,
        [EnumMember(Value = "article.changed")]
        ArticleChanged,
        [EnumMember(Value = "article.deleted")]
        ArticleDeleted,
        [EnumMember(Value = "contact.created")]
        ContactCreated,
        [EnumMember(Value = "contact.changed")]
        ContactChanged,
        [EnumMember(Value = "contact.deleted")]
        ContactDeleted,
        [EnumMember(Value = "credit-note.created")]
        CreditNoteCreated,
        [EnumMember(Value = "credit-note.changed")]
        CreditNoteChanged,
        [EnumMember(Value = "credit-note.deleted")]
        CreditNoteDeleted,
        [EnumMember(Value = "credit-note.status.changed")]
        CreditNoteStatusChanged,
        [EnumMember(Value = "delivery-note.created")]
        DeliveryNoteCreated,
        [EnumMember(Value = "delivery-note.changed")]
        DeliveryNoteChanged,
        [EnumMember(Value = "delivery-note.deleted")]
        DeliveryNoteDeleted,
        [EnumMember(Value = "down-payment-invoice.created")]
        DownPaymentInvoiceCreated,
        [EnumMember(Value = "down-payment-invoice.changed")]
        DownPaymentInvoiceChanged,
        [EnumMember(Value = "down-payment-invoice.deleted")]
        DownPaymentInvoiceDeleted,
        [EnumMember(Value = "down-payment-invoice.status.changed")]
        DownPaymentInvoiceStatusChanged,
        [EnumMember(Value = "dunning.created")]
        DunningCreated,
        [EnumMember(Value = "dunning.changed")]
        DunningChanged,
        [EnumMember(Value = "dunning.deleted")]
        DunningDeleted,
        [EnumMember(Value = "invoice.created")]
        InvoiceCreated,
        [EnumMember(Value = "invoice.changed")]
        InvoiceChanged,
        [EnumMember(Value = "invoice.deleted")]
        InvoiceDeleted,
        [EnumMember(Value = "invoice.status.changed")]
        InvoiceStatusChanged,
        [EnumMember(Value = "order-confirmation.created")]
        OrderConfirmationCreated,
        [EnumMember(Value = "order-confirmation.changed")]
        OrderConfirmationChanged,
        [EnumMember(Value = "order-confirmation.deleted")]
        OrderConfirmationDeleted,
        [EnumMember(Value = "order-confirmation.status.changed")]
        OrderConfirmationStatusChanged,
        [EnumMember(Value = "payment.changed")]
        PaymentChanged,
        [EnumMember(Value = "quotation.created")]
        QuotationCreated,
        [EnumMember(Value = "quotation.changed")]
        QuotationChanged,
        [EnumMember(Value = "quotation.deleted")]
        QuotationDeleted,
        [EnumMember(Value = "quotation.status.changed")]
        QuotationStatusChanged,
        [EnumMember(Value = "recurring-template.created")]
        RecurringTemplateCreated,
        [EnumMember(Value = "recurring-template.changed")]
        RecurringTemplateChanged,
        [EnumMember(Value = "recurring-template.deleted")]
        RecurringTemplateDeleted,
        [EnumMember(Value = "token.revoked")]
        TokenRevoked,
        [EnumMember(Value = "voucher.created")]
        VoucherCreated,
        [EnumMember(Value = "voucher.changed")]
        VoucherChanged,
        [EnumMember(Value = "voucher.deleted")]
        VoucherDeleted,
        [EnumMember(Value = "voucher.status.changed")]
        VoucherStatusChanged
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Lexoffice;

    public partial class WorkflowManagedActions
    {
        public LexofficeActions Lexoffice(string connectionId) => new LexofficeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LexofficeTriggers Lexoffice(string connectionId) => new LexofficeTriggers(connectionId);
    }
}