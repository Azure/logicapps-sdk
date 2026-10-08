//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildTestPhoneNumber))]
        public IBodyWorkflowAction<TestPhoneNumberResponse> TestPhoneNumber([WorkflowExpression] Func<string> whatsAppBusinessNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TestPhoneNumberResponse> __BuildTestPhoneNumber(WorkflowExpression<string> whatsAppBusinessNumber)
        {
            WorkflowExpression.Validate(whatsAppBusinessNumber, nameof(whatsAppBusinessNumber), required: true);
            return new DeferredBodyAction<TestPhoneNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(whatsAppBusinessNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppText))]
        public IBodyWorkflowAction<SendWhatsAppTextResponse> SendWhatsAppText([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTextResponse> __BuildSendWhatsAppText(WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<string> bodycontenttext = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendWhatsAppTextResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (bodycontenttext != null)
                {
                    contentObject["text"] = ExpressionConverter.ConvertO(bodycontenttext);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppContact))]
        public IBodyWorkflowAction<SendWhatsAppContactResponse> SendWhatsAppContact([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<bodycontentcontactsInputItem[]> bodycontentcontacts = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppContactResponse> __BuildSendWhatsAppContact(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<bodycontentcontactsInputItem[]> bodycontentcontacts = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentcontacts, nameof(bodycontentcontacts), required: false);
            return new DeferredBodyAction<SendWhatsAppContactResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentcontacts != null)
                {
                    contentObject["contacts"] = ExpressionConverter.ConvertO(bodycontentcontacts);
                    contentObjectpropCount++;
                }

                contentObject["contentType"] = "contacts";
                contentObjectpropCount++;
                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppContactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppLocation))]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse> SendWhatsAppLocation([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<double> bodycontentlocationlongitude = null, [WorkflowExpression] Func<double> bodycontentlocationlatitude = null, [WorkflowExpression] Func<string> bodycontentlocationname = null, [WorkflowExpression] Func<string> bodycontentlocationaddress = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse> __BuildSendWhatsAppLocation(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<double> bodycontentlocationlongitude = null, WorkflowExpression<double> bodycontentlocationlatitude = null, WorkflowExpression<string> bodycontentlocationname = null, WorkflowExpression<string> bodycontentlocationaddress = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentlocationlongitude, nameof(bodycontentlocationlongitude), required: false);
            WorkflowExpression.Validate(bodycontentlocationlatitude, nameof(bodycontentlocationlatitude), required: false);
            WorkflowExpression.Validate(bodycontentlocationname, nameof(bodycontentlocationname), required: false);
            WorkflowExpression.Validate(bodycontentlocationaddress, nameof(bodycontentlocationaddress), required: false);
            return new DeferredBodyAction<SendWhatsAppLocationResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (bodycontentlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(bodycontentlocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(bodycontentlocationlatitude);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationname != null)
                {
                    locationObject["name"] = ExpressionConverter.ConvertO(bodycontentlocationname);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationaddress != null)
                {
                    locationObject["address"] = ExpressionConverter.ConvertO(bodycontentlocationaddress);
                    locationObjectpropCount++;
                }

                if (locationObjectpropCount > 0)
                {
                    contentObject["location"] = locationObject;
                    contentObjectpropCount++;
                }

                contentObject["contentType"] = "location";
                contentObjectpropCount++;
                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppQuickReply))]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse> SendWhatsAppQuickReply([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<bodycontentinteractivecomponentsbuttonsInputItem[]> bodycontentinteractivecomponentsbuttons = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse> __BuildSendWhatsAppQuickReply(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytype = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytext = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertext = null, WorkflowExpression<bodycontentinteractivecomponentsbuttonsInputItem[]> bodycontentinteractivecomponentsbuttons = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbuttons, nameof(bodycontentinteractivecomponentsbuttons), required: false);
            return new DeferredBodyAction<SendWhatsAppQuickReplyResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "interactive";
                contentObjectpropCount++;
                var interactiveObject = new JObject();
                var interactiveObjectpropCount = 0;
                interactiveObject["subType"] = "buttons";
                interactiveObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                var headerObject = new JObject();
                var headerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbuttons != null)
                {
                    componentsObject["buttons"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbuttons);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    interactiveObject["components"] = componentsObject;
                    interactiveObjectpropCount++;
                }

                if (interactiveObjectpropCount > 0)
                {
                    contentObject["interactive"] = interactiveObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppProductList))]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse> SendWhatsAppProductList([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductListcatalogId = null, [WorkflowExpression] Func<bodycontentinteractivecomponentsproductListsectionsInputItem[]> bodycontentinteractivecomponentsproductListsections = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse> __BuildSendWhatsAppProductList(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytype = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytext = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsproductListcatalogId = null, WorkflowExpression<bodycontentinteractivecomponentsproductListsectionsInputItem[]> bodycontentinteractivecomponentsproductListsections = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsproductListcatalogId, nameof(bodycontentinteractivecomponentsproductListcatalogId), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsproductListsections, nameof(bodycontentinteractivecomponentsproductListsections), required: false);
            return new DeferredBodyAction<SendWhatsAppProductListResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "interactive";
                contentObjectpropCount++;
                var interactiveObject = new JObject();
                var interactiveObjectpropCount = 0;
                interactiveObject["subType"] = "productList";
                interactiveObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                var headerObject = new JObject();
                var headerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var productListObject = new JObject();
                var productListObjectpropCount = 0;
                if (bodycontentinteractivecomponentsproductListcatalogId != null)
                {
                    productListObject["catalogId"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsproductListcatalogId);
                    productListObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsproductListsections != null)
                {
                    productListObject["sections"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsproductListsections);
                    productListObjectpropCount++;
                }

                if (productListObjectpropCount > 0)
                {
                    componentsObject["productList"] = productListObject;
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    interactiveObject["components"] = componentsObject;
                    interactiveObjectpropCount++;
                }

                if (interactiveObjectpropCount > 0)
                {
                    contentObject["interactive"] = interactiveObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppProductListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppProduct))]
        public IBodyWorkflowAction<SendWhatsAppProductResponse> SendWhatsAppProduct([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductcatalogId = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductproductId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppProductResponse> __BuildSendWhatsAppProduct(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytype = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytext = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsproductcatalogId = null, WorkflowExpression<string> bodycontentinteractivecomponentsproductproductId = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsproductcatalogId, nameof(bodycontentinteractivecomponentsproductcatalogId), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsproductproductId, nameof(bodycontentinteractivecomponentsproductproductId), required: false);
            return new DeferredBodyAction<SendWhatsAppProductResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "interactive";
                contentObjectpropCount++;
                var interactiveObject = new JObject();
                var interactiveObjectpropCount = 0;
                interactiveObject["subType"] = "product";
                interactiveObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                var headerObject = new JObject();
                var headerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                if (bodycontentinteractivecomponentsproductcatalogId != null)
                {
                    productObject["catalogId"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsproductcatalogId);
                    productObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsproductproductId != null)
                {
                    productObject["productId"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsproductproductId);
                    productObjectpropCount++;
                }

                if (productObjectpropCount > 0)
                {
                    componentsObject["product"] = productObject;
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    interactiveObject["components"] = componentsObject;
                    interactiveObjectpropCount++;
                }

                if (interactiveObjectpropCount > 0)
                {
                    contentObject["interactive"] = interactiveObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppProductResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppList))]
        public IBodyWorkflowAction<SendWhatsAppListResponse> SendWhatsAppList([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentslisttitle = null, [WorkflowExpression] Func<bodycontentinteractivecomponentslistsectionsInputItem[]> bodycontentinteractivecomponentslistsections = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppListResponse> __BuildSendWhatsAppList(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsheadertext = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytype = null, WorkflowExpression<string> bodycontentinteractivecomponentsbodytext = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertype = null, WorkflowExpression<string> bodycontentinteractivecomponentsfootertext = null, WorkflowExpression<string> bodycontentinteractivecomponentslisttitle = null, WorkflowExpression<bodycontentinteractivecomponentslistsectionsInputItem[]> bodycontentinteractivecomponentslistsections = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentslisttitle, nameof(bodycontentinteractivecomponentslisttitle), required: false);
            WorkflowExpression.Validate(bodycontentinteractivecomponentslistsections, nameof(bodycontentinteractivecomponentslistsections), required: false);
            return new DeferredBodyAction<SendWhatsAppListResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "interactive";
                contentObjectpropCount++;
                var interactiveObject = new JObject();
                var interactiveObjectpropCount = 0;
                interactiveObject["subType"] = "list";
                interactiveObjectpropCount++;
                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                var headerObject = new JObject();
                var headerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var listObject = new JObject();
                var listObjectpropCount = 0;
                if (bodycontentinteractivecomponentslisttitle != null)
                {
                    listObject["title"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentslisttitle);
                    listObjectpropCount++;
                }

                if (bodycontentinteractivecomponentslistsections != null)
                {
                    listObject["sections"] = ExpressionConverter.ConvertO(bodycontentinteractivecomponentslistsections);
                    listObjectpropCount++;
                }

                if (listObjectpropCount > 0)
                {
                    componentsObject["list"] = listObject;
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    interactiveObject["components"] = componentsObject;
                    interactiveObjectpropCount++;
                }

                if (interactiveObjectpropCount > 0)
                {
                    contentObject["interactive"] = interactiveObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendsWhatsAppImage))]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse> SendsWhatsAppImage([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentimageurl = null, [WorkflowExpression] Func<string> bodycontentimagecaption = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse> __BuildSendsWhatsAppImage(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentimageurl = null, WorkflowExpression<string> bodycontentimagecaption = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentimageurl, nameof(bodycontentimageurl), required: false);
            WorkflowExpression.Validate(bodycontentimagecaption, nameof(bodycontentimagecaption), required: false);
            return new DeferredBodyAction<SendsWhatsAppImageResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "image";
                contentObjectpropCount++;
                var imageObject = new JObject();
                var imageObjectpropCount = 0;
                if (bodycontentimageurl != null)
                {
                    imageObject["url"] = ExpressionConverter.ConvertO(bodycontentimageurl);
                    imageObjectpropCount++;
                }

                if (bodycontentimagecaption != null)
                {
                    imageObject["caption"] = ExpressionConverter.ConvertO(bodycontentimagecaption);
                    imageObjectpropCount++;
                }

                if (imageObjectpropCount > 0)
                {
                    contentObject["image"] = imageObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendsWhatsAppImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppVideo))]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse> SendWhatsAppVideo([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentvideourl = null, [WorkflowExpression] Func<string> bodycontentvideocaption = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse> __BuildSendWhatsAppVideo(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentvideourl = null, WorkflowExpression<string> bodycontentvideocaption = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentvideourl, nameof(bodycontentvideourl), required: false);
            WorkflowExpression.Validate(bodycontentvideocaption, nameof(bodycontentvideocaption), required: false);
            return new DeferredBodyAction<SendWhatsAppVideoResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "video";
                contentObjectpropCount++;
                var videoObject = new JObject();
                var videoObjectpropCount = 0;
                if (bodycontentvideourl != null)
                {
                    videoObject["url"] = ExpressionConverter.ConvertO(bodycontentvideourl);
                    videoObjectpropCount++;
                }

                if (bodycontentvideocaption != null)
                {
                    videoObject["caption"] = ExpressionConverter.ConvertO(bodycontentvideocaption);
                    videoObjectpropCount++;
                }

                if (videoObjectpropCount > 0)
                {
                    contentObject["video"] = videoObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppVideoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppDocument))]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse> SendWhatsAppDocument([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentdocumenturl = null, [WorkflowExpression] Func<string> bodycontentdocumentcaption = null, [WorkflowExpression] Func<string> bodycontentdocumentfilename = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse> __BuildSendWhatsAppDocument(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentdocumenturl = null, WorkflowExpression<string> bodycontentdocumentcaption = null, WorkflowExpression<string> bodycontentdocumentfilename = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentdocumenturl, nameof(bodycontentdocumenturl), required: false);
            WorkflowExpression.Validate(bodycontentdocumentcaption, nameof(bodycontentdocumentcaption), required: false);
            WorkflowExpression.Validate(bodycontentdocumentfilename, nameof(bodycontentdocumentfilename), required: false);
            return new DeferredBodyAction<SendWhatsAppDocumentResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "document";
                contentObjectpropCount++;
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (bodycontentdocumenturl != null)
                {
                    documentObject["url"] = ExpressionConverter.ConvertO(bodycontentdocumenturl);
                    documentObjectpropCount++;
                }

                if (bodycontentdocumentcaption != null)
                {
                    documentObject["caption"] = ExpressionConverter.ConvertO(bodycontentdocumentcaption);
                    documentObjectpropCount++;
                }

                if (bodycontentdocumentfilename != null)
                {
                    documentObject["filename"] = ExpressionConverter.ConvertO(bodycontentdocumentfilename);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    contentObject["document"] = documentObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppAudio))]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse> SendWhatsAppAudio([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentaudiourl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse> __BuildSendWhatsAppAudio(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentaudiourl = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentaudiourl, nameof(bodycontentaudiourl), required: false);
            return new DeferredBodyAction<SendWhatsAppAudioResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/audio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "audio";
                contentObjectpropCount++;
                var audioObject = new JObject();
                var audioObjectpropCount = 0;
                if (bodycontentaudiourl != null)
                {
                    audioObject["url"] = ExpressionConverter.ConvertO(bodycontentaudiourl);
                    audioObjectpropCount++;
                }

                if (audioObjectpropCount > 0)
                {
                    contentObject["audio"] = audioObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppAudioResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppSticker))]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse> SendWhatsAppSticker([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentstickerurl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse> __BuildSendWhatsAppSticker(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontentstickerurl = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontentstickerurl, nameof(bodycontentstickerurl), required: false);
            return new DeferredBodyAction<SendWhatsAppStickerResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/sticker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "sticker";
                contentObjectpropCount++;
                var stickerObject = new JObject();
                var stickerObjectpropCount = 0;
                if (bodycontentstickerurl != null)
                {
                    stickerObject["url"] = ExpressionConverter.ConvertO(bodycontentstickerurl);
                    stickerObjectpropCount++;
                }

                if (stickerObjectpropCount > 0)
                {
                    contentObject["sticker"] = stickerObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppStickerResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateText))]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse> SendWhatsAppTemplateText([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse> __BuildSendWhatsAppTemplateText(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsheaderInputItem[]> bodycontenttemplatecomponentsheader = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateTextResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateTextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateLocation))]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse> SendWhatsAppTemplateLocation([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem2[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse> __BuildSendWhatsAppTemplateLocation(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsheaderInputItem2[]> bodycontenttemplatecomponentsheader = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateLocationResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateImage))]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse> SendWhatsAppTemplateImage([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem22[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse> __BuildSendWhatsAppTemplateImage(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsheaderInputItem22[]> bodycontenttemplatecomponentsheader = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateImageResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateImageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateDocument))]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse> SendWhatsAppTemplateDocument([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem222[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse> __BuildSendWhatsAppTemplateDocument(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsheaderInputItem222[]> bodycontenttemplatecomponentsheader = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDocumentResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateVideo))]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> SendWhatsAppTemplateVideo([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodychannel = null, [WorkflowExpression] Func<string> bodycontentcontentType = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem2222[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> __BuildSendWhatsAppTemplateVideo(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodychannel = null, WorkflowExpression<string> bodycontentcontentType = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsheaderInputItem2222[]> bodycontenttemplatecomponentsheader = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            WorkflowExpression.Validate(bodycontentcontentType, nameof(bodycontentcontentType), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateVideoResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(bodychannel);
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentcontentType != null)
                {
                    contentObject["contentType"] = ExpressionConverter.ConvertO(bodycontentcontentType);
                    contentObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateVideoResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateDynamicButton))]
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse> SendWhatsAppTemplateDynamicButton([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbuttonInputItem[]> bodycontenttemplatecomponentsbutton = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse> __BuildSendWhatsAppTemplateDynamicButton(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, WorkflowExpression<bodycontenttemplatecomponentsbuttonInputItem[]> bodycontenttemplatecomponentsbutton = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDynamicButtonResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-dynamic-button";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbutton);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateDynamicButtonResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildSendWhatsAppTemplateQuickReply))]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse> SendWhatsAppTemplateQuickReply([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbuttonInputItem2[]> bodycontenttemplatecomponentsbutton = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse> __BuildSendWhatsAppTemplateQuickReply(WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyto = null, WorkflowExpression<string> bodycontenttemplatetemplateId = null, WorkflowExpression<string> bodycontenttemplatetemplateLanguage = null, WorkflowExpression<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, WorkflowExpression<bodycontenttemplatecomponentsbuttonInputItem2[]> bodycontenttemplatecomponentsbutton = null)
        {
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            WorkflowExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            WorkflowExpression.Validate(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateQuickReplyResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "template";
                contentObjectpropCount++;
                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = ExpressionConverter.ConvertO(bodycontenttemplatecomponentsbutton);
                    componentsObjectpropCount++;
                }

                if (componentsObjectpropCount > 0)
                {
                    templateObject["components"] = componentsObject;
                    templateObjectpropCount++;
                }

                if (templateObjectpropCount > 0)
                {
                    contentObject["template"] = templateObject;
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    body["content"] = contentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SendWhatsAppTemplateQuickReplyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        [WorkflowExpressionFactory(nameof(__BuildStatusCheck))]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<StatusCheckV3Response> __BuildStatusCheck(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildIncoming))]
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> wABA,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildIncoming(WorkflowExpression<string> wABA,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(wABA, nameof(wABA), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(wABA, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["inboundMessageUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }
    }

    public class TestPhoneNumberResponse
    {
        [JsonProperty("phoneNumber")]
        public string PhoneNumber { get; set; }

        [JsonProperty("displayPhoneNumber")]
        public string DisplayPhoneNumber { get; set; }

        [JsonProperty("verifiedName")]
        public string VerifiedName { get; set; }

        [JsonProperty("qualityRating")]
        public string QualityRating { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("whatsAppAccountId")]
        public string WhatsAppAccountId { get; set; }

        [JsonProperty("managedBy")]
        public TestPhoneNumberResponseManagedByType ManagedBy { get; set; }

        [JsonProperty("messagingVia")]
        public TestPhoneNumberResponseMessagingViaType MessagingVia { get; set; }

        [JsonProperty("messagingTier")]
        public string MessagingTier { get; set; }

        [JsonProperty("qualityScore")]
        public TestPhoneNumberResponseQualityScoreType QualityScore { get; set; }
    }

    public class TestPhoneNumberResponseManagedByType
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }

    public class TestPhoneNumberResponseMessagingViaType
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }

    public class TestPhoneNumberResponseQualityScoreType
    {
        [JsonProperty("score")]
        public string Score { get; set; }
    }

    public class SendWhatsAppTextResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppContactResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontentcontactsInputItem
    {
        [JsonProperty("addresses")]
        public bodycontentcontactsInputItemAddressesTypeItem[] Addresses { get; set; }

        [JsonProperty("name")]
        public bodycontentcontactsInputItemNameType Name { get; set; }
    }

    public class bodycontentcontactsInputItemAddressesTypeItem
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public class bodycontentcontactsInputItemNameType
    {
        [JsonProperty("formattedName")]
        public string FormattedName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }

    public class SendWhatsAppLocationResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppQuickReplyResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontentinteractivecomponentsbuttonsInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reply")]
        public bodycontentinteractivecomponentsbuttonsInputItemReplyType Reply { get; set; }
    }

    public class bodycontentinteractivecomponentsbuttonsInputItemReplyType
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class SendWhatsAppProductListResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontentinteractivecomponentsproductListsectionsInputItem
    {
        [JsonProperty("items")]
        public bodycontentinteractivecomponentsproductListsectionsInputItemItemsTypeItem[] Items { get; set; }
    }

    public class bodycontentinteractivecomponentsproductListsectionsInputItemItemsTypeItem
    {
        [JsonProperty("productId")]
        public string ProductId { get; set; }
    }

    public class SendWhatsAppProductResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppListResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontentinteractivecomponentslistsectionsInputItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("rows")]
        public bodycontentinteractivecomponentslistsectionsInputItemRowsTypeItem[] Rows { get; set; }
    }

    public class bodycontentinteractivecomponentslistsectionsInputItemRowsTypeItem
    {
        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class SendsWhatsAppImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppDocumentResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppAudioResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppStickerResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class SendWhatsAppTemplateTextResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class bodycontenttemplatecomponentsbodyInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateLocationResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem2
    {
        [JsonProperty("location")]
        public bodycontenttemplatecomponentsheaderInputItemLocationType Location { get; set; }

        [JsonProperty("header-type")]
        public string HeaderType { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItemLocationType
    {
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }
    }

    public class SendWhatsAppTemplateImageResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem22
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("image")]
        public bodycontenttemplatecomponentsheaderInputItemImageType Image { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItemImageType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateDocumentResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem222
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("document")]
        public bodycontenttemplatecomponentsheaderInputItemDocumentType Document { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItemDocumentType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateVideoResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItem2222
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("video")]
        public bodycontenttemplatecomponentsheaderInputItemVideoType Video { get; set; }
    }

    public class bodycontenttemplatecomponentsheaderInputItemVideoType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class SendWhatsAppTemplateDynamicButtonResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsbuttonInputItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class SendWhatsAppTemplateQuickReplyResponse
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class bodycontenttemplatecomponentsbuttonInputItem2
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
    }

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa;

    public partial class WorkflowManagedActions
    {
        public TyntecwaActions Tyntecwa(string connectionId) => new TyntecwaActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TyntecwaTriggers Tyntecwa(string connectionId) => new TyntecwaTriggers(connectionId);
    }
}