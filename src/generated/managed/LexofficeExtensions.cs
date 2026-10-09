//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Lexoffice
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LexofficeActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildFilteringArticles))]
        public IBodyWorkflowAction<ResponseArticlesGet> FilteringArticles([WorkflowExpression] Func<string> articleNumber = null, [WorkflowExpression] Func<string> gtin = null, [WorkflowExpression] Func<string> type = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseArticlesGet> __BuildFilteringArticles(WorkflowExpression<string> articleNumber = null, WorkflowExpression<string> gtin = null, WorkflowExpression<string> type = null, WorkflowExpression<int> page = null, WorkflowExpression<int> size = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(articleNumber, nameof(articleNumber), required: false);
            WorkflowExpression.Validate(gtin, nameof(gtin), required: false);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ResponseArticlesGet>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateArticle))]
        public IBodyWorkflowAction<ResponseArticlesPost> CreateArticle([WorkflowExpression] Func<string> bodyarticleNumber = null, [WorkflowExpression] Func<double> bodypricegrossPrice = null, [WorkflowExpression] Func<string> bodypriceleadingPrice = null, [WorkflowExpression] Func<double> bodypricenetPrice = null, [WorkflowExpression] Func<double> bodypricetaxRate = null, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<bodytypeInput> bodytype = null, [WorkflowExpression] Func<string> bodyunitName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseArticlesPost> __BuildCreateArticle(WorkflowExpression<string> bodyarticleNumber = null, WorkflowExpression<double> bodypricegrossPrice = null, WorkflowExpression<string> bodypriceleadingPrice = null, WorkflowExpression<double> bodypricenetPrice = null, WorkflowExpression<double> bodypricetaxRate = null, WorkflowExpression<string> bodytitle = null, WorkflowExpression<bodytypeInput> bodytype = null, WorkflowExpression<string> bodyunitName = null)
        {
            WorkflowExpression.Validate(bodyarticleNumber, nameof(bodyarticleNumber), required: false);
            WorkflowExpression.Validate(bodypricegrossPrice, nameof(bodypricegrossPrice), required: false);
            WorkflowExpression.Validate(bodypriceleadingPrice, nameof(bodypriceleadingPrice), required: false);
            WorkflowExpression.Validate(bodypricenetPrice, nameof(bodypricenetPrice), required: false);
            WorkflowExpression.Validate(bodypricetaxRate, nameof(bodypricetaxRate), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: false);
            WorkflowExpression.Validate(bodyunitName, nameof(bodyunitName), required: false);
            return new DeferredBodyAction<ResponseArticlesPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAnArticle))]
        public IBodyWorkflowAction<RetrieveAnArticleResponse> RetrieveAnArticle([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveAnArticleResponse> __BuildRetrieveAnArticle(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveAnArticleResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveAnArticleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteAnArticle))]
        public IWorkflowAction DeleteAnArticle([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteAnArticle(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateAnArticle))]
        public IBodyWorkflowAction<ResponseArticlesIdGet> UpdateAnArticle([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyunitName, [WorkflowExpression] Func<int> bodyversion, [WorkflowExpression] Func<string> bodyarticleNumber = null, [WorkflowExpression] Func<string> bodygtin = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<double> bodypricegrossPrice = null, [WorkflowExpression] Func<bodypriceleadingPriceInput> bodypriceleadingPrice = null, [WorkflowExpression] Func<double> bodypricenetPrice = null, [WorkflowExpression] Func<double> bodypricetaxRate = null, [WorkflowExpression] Func<string> bodytitle = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseArticlesIdGet> __BuildUpdateAnArticle(WorkflowExpression<string> id, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<string> bodyunitName, WorkflowExpression<int> bodyversion, WorkflowExpression<string> bodyarticleNumber = null, WorkflowExpression<string> bodygtin = null, WorkflowExpression<string> bodynote = null, WorkflowExpression<double> bodypricegrossPrice = null, WorkflowExpression<bodypriceleadingPriceInput> bodypriceleadingPrice = null, WorkflowExpression<double> bodypricenetPrice = null, WorkflowExpression<double> bodypricetaxRate = null, WorkflowExpression<string> bodytitle = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyunitName, nameof(bodyunitName), required: true);
            WorkflowExpression.Validate(bodyversion, nameof(bodyversion), required: true);
            WorkflowExpression.Validate(bodyarticleNumber, nameof(bodyarticleNumber), required: false);
            WorkflowExpression.Validate(bodygtin, nameof(bodygtin), required: false);
            WorkflowExpression.Validate(bodynote, nameof(bodynote), required: false);
            WorkflowExpression.Validate(bodypricegrossPrice, nameof(bodypricegrossPrice), required: false);
            WorkflowExpression.Validate(bodypriceleadingPrice, nameof(bodypriceleadingPrice), required: false);
            WorkflowExpression.Validate(bodypricenetPrice, nameof(bodypricenetPrice), required: false);
            WorkflowExpression.Validate(bodypricetaxRate, nameof(bodypricetaxRate), required: false);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            return new DeferredBodyAction<ResponseArticlesIdGet>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/articles/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAllContacts))]
        public IBodyWorkflowAction<ResponseContactsGet> RetrieveAllContacts([WorkflowExpression] Func<int> number = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> name = null, [WorkflowExpression] Func<bool> vendor = null, [WorkflowExpression] Func<bool> customer = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseContactsGet> __BuildRetrieveAllContacts(WorkflowExpression<int> number = null, WorkflowExpression<string> email = null, WorkflowExpression<string> name = null, WorkflowExpression<bool> vendor = null, WorkflowExpression<bool> customer = null, WorkflowExpression<int> page = null, WorkflowExpression<int> size = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(number, nameof(number), required: false);
            WorkflowExpression.Validate(email, nameof(email), required: false);
            WorkflowExpression.Validate(name, nameof(name), required: false);
            WorkflowExpression.Validate(vendor, nameof(vendor), required: false);
            WorkflowExpression.Validate(customer, nameof(customer), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ResponseContactsGet>(() =>
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildRetrieveContact))]
        public IBodyWorkflowAction<RetrieveContactResponse> RetrieveContact([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveContactResponse> __BuildRetrieveContact(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveContactResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateContact))]
        public IBodyWorkflowAction<ResponseContactsIdPut> UpdateContact([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseContactsIdPut> __BuildUpdateContact(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<ResponseContactsIdPut>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/contacts/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildCreateCreditNote))]
        public IBodyWorkflowAction<ResponseCreditNotesPost> CreateCreditNote([WorkflowExpression] Func<bool> finalize, [WorkflowExpression] Func<string> precedingSalesVoucherId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseCreditNotesPost> __BuildCreateCreditNote(WorkflowExpression<bool> finalize, WorkflowExpression<string> precedingSalesVoucherId = null)
        {
            WorkflowExpression.Validate(finalize, nameof(finalize), required: true);
            WorkflowExpression.Validate(precedingSalesVoucherId, nameof(precedingSalesVoucherId), required: false);
            return new DeferredBodyAction<ResponseCreditNotesPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveCreditNote))]
        public IBodyWorkflowAction<RetrieveCreditNoteResponse> RetrieveCreditNote([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveCreditNoteResponse> __BuildRetrieveCreditNote(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveCreditNoteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/credit-notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveCreditNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderCreditNoteDocument))]
        public IBodyWorkflowAction<RenderCreditNoteDocumentResponse> RenderCreditNoteDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderCreditNoteDocumentResponse> __BuildRenderCreditNoteDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RenderCreditNoteDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/credit-notes/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderCreditNoteDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDeliveryNote))]
        public IBodyWorkflowAction<ResponseDeliveryNotesPost> CreateDeliveryNote([WorkflowExpression] Func<string> precedingSalesVoucherId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseDeliveryNotesPost> __BuildCreateDeliveryNote(WorkflowExpression<string> precedingSalesVoucherId = null)
        {
            WorkflowExpression.Validate(precedingSalesVoucherId, nameof(precedingSalesVoucherId), required: false);
            return new DeferredBodyAction<ResponseDeliveryNotesPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderDeliveryNoteDocument))]
        public IBodyWorkflowAction<RenderDeliveryNoteDocumentResponse> RenderDeliveryNoteDocument([WorkflowExpression] Func<string> deliveryNoteid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderDeliveryNoteDocumentResponse> __BuildRenderDeliveryNoteDocument(WorkflowExpression<string> deliveryNoteid)
        {
            WorkflowExpression.Validate(deliveryNoteid, nameof(deliveryNoteid), required: true);
            return new DeferredBodyAction<RenderDeliveryNoteDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/delivery-notes/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(deliveryNoteid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderDeliveryNoteDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveDeliveryNote))]
        public IBodyWorkflowAction<RetrieveDeliveryNoteResponse> RetrieveDeliveryNote([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveDeliveryNoteResponse> __BuildRetrieveDeliveryNote(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveDeliveryNoteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/delivery-notes/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveDeliveryNoteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveDownPaymentInvoice))]
        public IBodyWorkflowAction<RetrieveDownPaymentInvoiceResponse> RetrieveDownPaymentInvoice([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveDownPaymentInvoiceResponse> __BuildRetrieveDownPaymentInvoice(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveDownPaymentInvoiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/down-payment-invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveDownPaymentInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateDunning))]
        public IBodyWorkflowAction<ResponseDunningsPost> CreateDunning([WorkflowExpression] Func<string> precedingSalesVoucherId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseDunningsPost> __BuildCreateDunning(WorkflowExpression<string> precedingSalesVoucherId = null)
        {
            WorkflowExpression.Validate(precedingSalesVoucherId, nameof(precedingSalesVoucherId), required: false);
            return new DeferredBodyAction<ResponseDunningsPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveDunning))]
        public IBodyWorkflowAction<RetrieveDunningResponse> RetrieveDunning([WorkflowExpression] Func<string> dunningsid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveDunningResponse> __BuildRetrieveDunning(WorkflowExpression<string> dunningsid)
        {
            WorkflowExpression.Validate(dunningsid, nameof(dunningsid), required: true);
            return new DeferredBodyAction<RetrieveDunningResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/dunnings/{0}", ExpressionConverter.ConvertWithUrlEncoding(dunningsid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveDunningResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderDunningDocument))]
        public IBodyWorkflowAction<RenderDunningDocumentResponse> RenderDunningDocument([WorkflowExpression] Func<string> dunningsid)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderDunningDocumentResponse> __BuildRenderDunningDocument(WorkflowExpression<string> dunningsid)
        {
            WorkflowExpression.Validate(dunningsid, nameof(dunningsid), required: true);
            return new DeferredBodyAction<RenderDunningDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/dunnings/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(dunningsid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderDunningDocumentResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAEventSubscription))]
        public IBodyWorkflowAction<EventSubscriptionResponse> RetrieveAEventSubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<EventSubscriptionResponse> __BuildRetrieveAEventSubscription(WorkflowExpression<string> subscriptionId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredBodyAction<EventSubscriptionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event-subscriptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<EventSubscriptionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteEventSubscription))]
        public IWorkflowAction DeleteEventSubscription([WorkflowExpression] Func<string> subscriptionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteEventSubscription(WorkflowExpression<string> subscriptionId)
        {
            WorkflowExpression.Validate(subscriptionId, nameof(subscriptionId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/event-subscriptions/{0}", ExpressionConverter.ConvertWithUrlEncoding(subscriptionId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFileLexoffice))]
        public IBodyWorkflowAction<ResponseFilesPost> UploadFileLexoffice([WorkflowExpression] Func<object> file, [WorkflowExpression] Func<string> type)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseFilesPost> __BuildUploadFileLexoffice(WorkflowExpression<object> file, WorkflowExpression<string> type)
        {
            WorkflowExpression.Validate(file, nameof(file), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: true);
            return new DeferredBodyAction<ResponseFilesPost>(() =>
            {
                var apiCallPath = "/files";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ResponseFilesPost>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadFileLexoffice))]
        public IBodyWorkflowAction<object> DownloadFileLexoffice([WorkflowExpression] Func<string> fileId, [WorkflowExpression] Func<acceptInput> accept = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<object> __BuildDownloadFileLexoffice(WorkflowExpression<string> fileId, WorkflowExpression<acceptInput> accept = null)
        {
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            WorkflowExpression.Validate(accept, nameof(accept), required: false);
            return new DeferredBodyAction<object>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}", ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("*/*");
                if (accept != null)
                    callPayload.Headers["Accept"] = ExpressionConverter.Convert(accept);
                return new ApiConnectionAction<object>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateInvoice))]
        public IBodyWorkflowAction<ResponseInvoicesPost> CreateInvoice([WorkflowExpression] Func<bool> finalize, [WorkflowExpression] Func<string> precedingSalesVoucherId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseInvoicesPost> __BuildCreateInvoice(WorkflowExpression<bool> finalize, WorkflowExpression<string> precedingSalesVoucherId = null)
        {
            WorkflowExpression.Validate(finalize, nameof(finalize), required: true);
            WorkflowExpression.Validate(precedingSalesVoucherId, nameof(precedingSalesVoucherId), required: false);
            return new DeferredBodyAction<ResponseInvoicesPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveInvoice))]
        public IBodyWorkflowAction<RetrieveInvoiceResponse> RetrieveInvoice([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveInvoiceResponse> __BuildRetrieveInvoice(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveInvoiceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveInvoiceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderInvoiceDocument))]
        public IBodyWorkflowAction<RenderInvoiceDocumentResponse> RenderInvoiceDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderInvoiceDocumentResponse> __BuildRenderInvoiceDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RenderInvoiceDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/invoices/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderInvoiceDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateOrderConfirmation))]
        public IBodyWorkflowAction<ResponseOrderConfirmationsPost> CreateOrderConfirmation([WorkflowExpression] Func<string> precedingSalesVoucherId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseOrderConfirmationsPost> __BuildCreateOrderConfirmation(WorkflowExpression<string> precedingSalesVoucherId = null)
        {
            WorkflowExpression.Validate(precedingSalesVoucherId, nameof(precedingSalesVoucherId), required: false);
            return new DeferredBodyAction<ResponseOrderConfirmationsPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveOrderConfirmation))]
        public IBodyWorkflowAction<RetrieveOrderConfirmationResponse> RetrieveOrderConfirmation([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveOrderConfirmationResponse> __BuildRetrieveOrderConfirmation(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveOrderConfirmationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/order-confirmations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveOrderConfirmationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderOrderConfirmationDocument))]
        public IBodyWorkflowAction<RenderOrderConfirmationDocumentResponse> RenderOrderConfirmationDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderOrderConfirmationDocumentResponse> __BuildRenderOrderConfirmationDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RenderOrderConfirmationDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/order-confirmations/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderOrderConfirmationDocumentResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildRetrievePaymentInformation))]
        public IBodyWorkflowAction<RetrievePaymentInformationResponse> RetrievePaymentInformation([WorkflowExpression] Func<string> voucherId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrievePaymentInformationResponse> __BuildRetrievePaymentInformation(WorkflowExpression<string> voucherId)
        {
            WorkflowExpression.Validate(voucherId, nameof(voucherId), required: true);
            return new DeferredBodyAction<RetrievePaymentInformationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/payments/{0}", ExpressionConverter.ConvertWithUrlEncoding(voucherId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrievePaymentInformationResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildCreateQuotation))]
        public IBodyWorkflowAction<ResponseQuotationsPost> CreateQuotation([WorkflowExpression] Func<bool> finalize)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseQuotationsPost> __BuildCreateQuotation(WorkflowExpression<bool> finalize)
        {
            WorkflowExpression.Validate(finalize, nameof(finalize), required: true);
            return new DeferredBodyAction<ResponseQuotationsPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveQuotation))]
        public IBodyWorkflowAction<RetrieveQuotationResponse> RetrieveQuotation([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveQuotationResponse> __BuildRetrieveQuotation(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveQuotationResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/quotations/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveQuotationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRenderQuotationDocument))]
        public IBodyWorkflowAction<RenderQuotationDocumentResponse> RenderQuotationDocument([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RenderQuotationDocumentResponse> __BuildRenderQuotationDocument(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RenderQuotationDocumentResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/quotations/{0}/document", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RenderQuotationDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAllRecurringTemplates))]
        public IBodyWorkflowAction<ResponseRecurringTemplatesGet> RetrieveAllRecurringTemplates([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseRecurringTemplatesGet> __BuildRetrieveAllRecurringTemplates(WorkflowExpression<int> page = null, WorkflowExpression<int> size = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ResponseRecurringTemplatesGet>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveRecurringTemplate))]
        public IBodyWorkflowAction<RetrieveRecurringTemplateResponse> RetrieveRecurringTemplate([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveRecurringTemplateResponse> __BuildRetrieveRecurringTemplate(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveRecurringTemplateResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recurring-templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveRecurringTemplateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveAndFilterVoucherlist))]
        public IBodyWorkflowAction<ResponseVoucherlistGet> RetrieveAndFilterVoucherlist([WorkflowExpression] Func<voucherTypeInput> voucherType, [WorkflowExpression] Func<voucherStatusInput> voucherStatus, [WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> contactId = null, [WorkflowExpression] Func<string> voucherDateFrom = null, [WorkflowExpression] Func<string> voucherDateTo = null, [WorkflowExpression] Func<string> createdDateFrom = null, [WorkflowExpression] Func<string> createdDateTo = null, [WorkflowExpression] Func<string> updatedDateFrom = null, [WorkflowExpression] Func<string> updatedDateTo = null, [WorkflowExpression] Func<string> voucherNumber = null, [WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null, [WorkflowExpression] Func<string> sort = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseVoucherlistGet> __BuildRetrieveAndFilterVoucherlist(WorkflowExpression<voucherTypeInput> voucherType, WorkflowExpression<voucherStatusInput> voucherStatus, WorkflowExpression<bool> archived = null, WorkflowExpression<string> contactId = null, WorkflowExpression<string> voucherDateFrom = null, WorkflowExpression<string> voucherDateTo = null, WorkflowExpression<string> createdDateFrom = null, WorkflowExpression<string> createdDateTo = null, WorkflowExpression<string> updatedDateFrom = null, WorkflowExpression<string> updatedDateTo = null, WorkflowExpression<string> voucherNumber = null, WorkflowExpression<int> page = null, WorkflowExpression<int> size = null, WorkflowExpression<string> sort = null)
        {
            WorkflowExpression.Validate(voucherType, nameof(voucherType), required: true);
            WorkflowExpression.Validate(voucherStatus, nameof(voucherStatus), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(contactId, nameof(contactId), required: false);
            WorkflowExpression.Validate(voucherDateFrom, nameof(voucherDateFrom), required: false);
            WorkflowExpression.Validate(voucherDateTo, nameof(voucherDateTo), required: false);
            WorkflowExpression.Validate(createdDateFrom, nameof(createdDateFrom), required: false);
            WorkflowExpression.Validate(createdDateTo, nameof(createdDateTo), required: false);
            WorkflowExpression.Validate(updatedDateFrom, nameof(updatedDateFrom), required: false);
            WorkflowExpression.Validate(updatedDateTo, nameof(updatedDateTo), required: false);
            WorkflowExpression.Validate(voucherNumber, nameof(voucherNumber), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            WorkflowExpression.Validate(sort, nameof(sort), required: false);
            return new DeferredBodyAction<ResponseVoucherlistGet>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildCreateVoucher))]
        public IBodyWorkflowAction<ResponseVouchersPost> CreateVoucher([WorkflowExpression] Func<bodytaxTypeInput> bodytaxType, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bodyvoucherItemsInputItem[]> bodyvoucherItems, [WorkflowExpression] Func<string> bodycontactId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyshippingDate = null, [WorkflowExpression] Func<double> bodytotalGrossAmount = null, [WorkflowExpression] Func<double> bodytotalTaxAmount = null, [WorkflowExpression] Func<bool> bodyuseCollectiveContact = null, [WorkflowExpression] Func<string> bodyvoucherDate = null, [WorkflowExpression] Func<string> bodyvoucherNumber = null, [WorkflowExpression] Func<bodyvoucherStatusInput> bodyvoucherStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseVouchersPost> __BuildCreateVoucher(WorkflowExpression<bodytaxTypeInput> bodytaxType, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<bodyvoucherItemsInputItem[]> bodyvoucherItems, WorkflowExpression<string> bodycontactId = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyshippingDate = null, WorkflowExpression<double> bodytotalGrossAmount = null, WorkflowExpression<double> bodytotalTaxAmount = null, WorkflowExpression<bool> bodyuseCollectiveContact = null, WorkflowExpression<string> bodyvoucherDate = null, WorkflowExpression<string> bodyvoucherNumber = null, WorkflowExpression<bodyvoucherStatusInput> bodyvoucherStatus = null)
        {
            WorkflowExpression.Validate(bodytaxType, nameof(bodytaxType), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyvoucherItems, nameof(bodyvoucherItems), required: true);
            WorkflowExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyshippingDate, nameof(bodyshippingDate), required: false);
            WorkflowExpression.Validate(bodytotalGrossAmount, nameof(bodytotalGrossAmount), required: false);
            WorkflowExpression.Validate(bodytotalTaxAmount, nameof(bodytotalTaxAmount), required: false);
            WorkflowExpression.Validate(bodyuseCollectiveContact, nameof(bodyuseCollectiveContact), required: false);
            WorkflowExpression.Validate(bodyvoucherDate, nameof(bodyvoucherDate), required: false);
            WorkflowExpression.Validate(bodyvoucherNumber, nameof(bodyvoucherNumber), required: false);
            WorkflowExpression.Validate(bodyvoucherStatus, nameof(bodyvoucherStatus), required: false);
            return new DeferredBodyAction<ResponseVouchersPost>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildRetrieveVoucher))]
        public IBodyWorkflowAction<RetrieveVoucherResponse> RetrieveVoucher([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrieveVoucherResponse> __BuildRetrieveVoucher(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RetrieveVoucherResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vouchers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                return new ApiConnectionAction<RetrieveVoucherResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateVoucher))]
        public IBodyWorkflowAction<ResponseVouchersIdPut> UpdateVoucher([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodytaxTypeInput> bodytaxType, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bodyvoucherItemsInputItem[]> bodyvoucherItems, [WorkflowExpression] Func<string> bodycontactId = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<string[]> bodyfiles = null, [WorkflowExpression] Func<string> bodyremark = null, [WorkflowExpression] Func<string> bodyshippingDate = null, [WorkflowExpression] Func<double> bodytotalGrossAmount = null, [WorkflowExpression] Func<double> bodytotalTaxAmount = null, [WorkflowExpression] Func<bool> bodyuseCollectiveContact = null, [WorkflowExpression] Func<int> bodyversion = null, [WorkflowExpression] Func<string> bodyvoucherDate = null, [WorkflowExpression] Func<string> bodyvoucherNumber = null, [WorkflowExpression] Func<bodyvoucherStatusInput> bodyvoucherStatus = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResponseVouchersIdPut> __BuildUpdateVoucher(WorkflowExpression<string> id, WorkflowExpression<bodytaxTypeInput> bodytaxType, WorkflowExpression<bodytypeInput> bodytype, WorkflowExpression<bodyvoucherItemsInputItem[]> bodyvoucherItems, WorkflowExpression<string> bodycontactId = null, WorkflowExpression<string> bodydueDate = null, WorkflowExpression<string[]> bodyfiles = null, WorkflowExpression<string> bodyremark = null, WorkflowExpression<string> bodyshippingDate = null, WorkflowExpression<double> bodytotalGrossAmount = null, WorkflowExpression<double> bodytotalTaxAmount = null, WorkflowExpression<bool> bodyuseCollectiveContact = null, WorkflowExpression<int> bodyversion = null, WorkflowExpression<string> bodyvoucherDate = null, WorkflowExpression<string> bodyvoucherNumber = null, WorkflowExpression<bodyvoucherStatusInput> bodyvoucherStatus = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodytaxType, nameof(bodytaxType), required: true);
            WorkflowExpression.Validate(bodytype, nameof(bodytype), required: true);
            WorkflowExpression.Validate(bodyvoucherItems, nameof(bodyvoucherItems), required: true);
            WorkflowExpression.Validate(bodycontactId, nameof(bodycontactId), required: false);
            WorkflowExpression.Validate(bodydueDate, nameof(bodydueDate), required: false);
            WorkflowExpression.Validate(bodyfiles, nameof(bodyfiles), required: false);
            WorkflowExpression.Validate(bodyremark, nameof(bodyremark), required: false);
            WorkflowExpression.Validate(bodyshippingDate, nameof(bodyshippingDate), required: false);
            WorkflowExpression.Validate(bodytotalGrossAmount, nameof(bodytotalGrossAmount), required: false);
            WorkflowExpression.Validate(bodytotalTaxAmount, nameof(bodytotalTaxAmount), required: false);
            WorkflowExpression.Validate(bodyuseCollectiveContact, nameof(bodyuseCollectiveContact), required: false);
            WorkflowExpression.Validate(bodyversion, nameof(bodyversion), required: false);
            WorkflowExpression.Validate(bodyvoucherDate, nameof(bodyvoucherDate), required: false);
            WorkflowExpression.Validate(bodyvoucherNumber, nameof(bodyvoucherNumber), required: false);
            WorkflowExpression.Validate(bodyvoucherStatus, nameof(bodyvoucherStatus), required: false);
            return new DeferredBodyAction<ResponseVouchersIdPut>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vouchers/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "lexoffice")]
        [WorkflowExpressionFactory(nameof(__BuildUploadFileVoucherLexoffice))]
        public IWorkflowAction UploadFileVoucherLexoffice([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<object> file)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUploadFileVoucherLexoffice(WorkflowExpression<string> id, WorkflowExpression<object> file)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(file, nameof(file), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/vouchers/{0}/files", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class LexofficeTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildEventSubscriptionLexoffice))]
        public IBodyWorkflowTrigger<ResponseEventSubscriptionsPost> EventSubscriptionLexoffice([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<ResponseEventSubscriptionsPost> __BuildEventSubscriptionLexoffice(WorkflowExpression<bodyeventTypeInput> bodyeventType,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            return new DeferredBodyTrigger<ResponseEventSubscriptionsPost>(() =>
            {
                var apiCallPath = "/event-subscriptions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-Type"] = Convert.ToString("application/json");
                callPayload.Headers["Accept"] = Convert.ToString("application/json");
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<ResponseEventSubscriptionsPost>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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