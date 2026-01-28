//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<TestPhoneNumberResponse> TestPhoneNumber(Expression<Func<string>> whatsAppBusinessNumber)
        {
            var apiCallPath = String.Format("/conversations/v3/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(whatsAppBusinessNumber, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheckV3(Expression<Func<string>> messageId)
        {
            var apiCallPath = String.Format("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTextResponse> SendWhatsAppText(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodycontenttext = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppContactResponse> SendWhatsAppContact(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<bodycontentcontactsInputItem[]>> bodycontentcontacts = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse> SendWhatsAppLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<double>> bodycontentlocationlongitude = null, Expression<Func<double>> bodycontentlocationlatitude = null, Expression<Func<string>> bodycontentlocationname = null, Expression<Func<string>> bodycontentlocationaddress = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse> SendWhatsAppQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<bodycontentinteractivecomponentsbuttonsInputItem[]>> bodycontentinteractivecomponentsbuttons = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse> SendWhatsAppProductList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductListcatalogId = null, Expression<Func<bodycontentinteractivecomponentsproductListsectionsInputItem[]>> bodycontentinteractivecomponentsproductListsections = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductResponse> SendWhatsAppProduct(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductcatalogId = null, Expression<Func<string>> bodycontentinteractivecomponentsproductproductId = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppListResponse> SendWhatsAppList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentslisttitle = null, Expression<Func<bodycontentinteractivecomponentslistsectionsInputItem[]>> bodycontentinteractivecomponentslistsections = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse> SendsWhatsAppImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentimageurl = null, Expression<Func<string>> bodycontentimagecaption = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse> SendWhatsAppVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentvideourl = null, Expression<Func<string>> bodycontentvideocaption = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse> SendWhatsAppDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentdocumenturl = null, Expression<Func<string>> bodycontentdocumentcaption = null, Expression<Func<string>> bodycontentdocumentfilename = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse> SendWhatsAppAudio(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentaudiourl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse> SendWhatsAppSticker(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentstickerurl = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse> SendWhatsAppTemplateText(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse> SendWhatsAppTemplateLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse> SendWhatsAppTemplateImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem22[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse> SendWhatsAppTemplateDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> SendWhatsAppTemplateVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodycontentcontentType = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse> SendWhatsAppTemplateDynamicButton(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem[]>> bodycontenttemplatecomponentsbutton = null)
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse> SendWhatsAppTemplateQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem2[]>> bodycontenttemplatecomponentsbutton = null)
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
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger IncomingV2(Expression<Func<string>> wABA, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = String.Format("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(wABA, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["inboundMessageUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
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

    public class StatusCheckV3Response
    {
        [JsonProperty("messageId")]
        public string MessageId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
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