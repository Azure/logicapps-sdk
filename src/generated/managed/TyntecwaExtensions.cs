//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<TestPhoneNumberResponse> TestPhoneNumber(Expression<Func<string>> whatsAppBusinessNumber)
        {
            var __workflow_whatsAppBusinessNumber = whatsAppBusinessNumber == null ? null : WorkflowExpression.Compile(whatsAppBusinessNumber);
            WorkflowExpression.Validate(__workflow_whatsAppBusinessNumber, nameof(whatsAppBusinessNumber), required: true);
            return new DeferredBodyAction<TestPhoneNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_whatsAppBusinessNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTextResponse> SendWhatsAppText(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodycontenttext = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodycontenttext = bodycontenttext == null ? null : WorkflowExpression.Compile(bodycontenttext);
            WorkflowExpression.Validate(__workflow_bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendWhatsAppTextResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (__workflow_bodycontenttext != null)
                {
                    contentObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontenttext);
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
        public IBodyWorkflowAction<SendWhatsAppContactResponse> SendWhatsAppContact(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<bodycontentcontactsInputItem[]>> bodycontentcontacts = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentcontacts = bodycontentcontacts == null ? null : WorkflowExpression.Compile(bodycontentcontacts);
            WorkflowExpression.Validate(__workflow_bodycontentcontacts, nameof(bodycontentcontacts), required: false);
            return new DeferredBodyAction<SendWhatsAppContactResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (__workflow_bodycontentcontacts != null)
                {
                    contentObject["contacts"] = ExpressionConverter.ConvertO(__workflow_bodycontentcontacts);
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
        public IBodyWorkflowAction<SendWhatsAppLocationResponse> SendWhatsAppLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<double>> bodycontentlocationlongitude = null, Expression<Func<double>> bodycontentlocationlatitude = null, Expression<Func<string>> bodycontentlocationname = null, Expression<Func<string>> bodycontentlocationaddress = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentlocationlongitude = bodycontentlocationlongitude == null ? null : WorkflowExpression.Compile(bodycontentlocationlongitude);
            WorkflowExpression.Validate(__workflow_bodycontentlocationlongitude, nameof(bodycontentlocationlongitude), required: false);
            var __workflow_bodycontentlocationlatitude = bodycontentlocationlatitude == null ? null : WorkflowExpression.Compile(bodycontentlocationlatitude);
            WorkflowExpression.Validate(__workflow_bodycontentlocationlatitude, nameof(bodycontentlocationlatitude), required: false);
            var __workflow_bodycontentlocationname = bodycontentlocationname == null ? null : WorkflowExpression.Compile(bodycontentlocationname);
            WorkflowExpression.Validate(__workflow_bodycontentlocationname, nameof(bodycontentlocationname), required: false);
            var __workflow_bodycontentlocationaddress = bodycontentlocationaddress == null ? null : WorkflowExpression.Compile(bodycontentlocationaddress);
            WorkflowExpression.Validate(__workflow_bodycontentlocationaddress, nameof(bodycontentlocationaddress), required: false);
            return new DeferredBodyAction<SendWhatsAppLocationResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                var locationObject = new JObject();
                var locationObjectpropCount = 0;
                if (__workflow_bodycontentlocationlongitude != null)
                {
                    locationObject["longitude"] = ExpressionConverter.ConvertO(__workflow_bodycontentlocationlongitude);
                    locationObjectpropCount++;
                }

                if (__workflow_bodycontentlocationlatitude != null)
                {
                    locationObject["latitude"] = ExpressionConverter.ConvertO(__workflow_bodycontentlocationlatitude);
                    locationObjectpropCount++;
                }

                if (__workflow_bodycontentlocationname != null)
                {
                    locationObject["name"] = ExpressionConverter.ConvertO(__workflow_bodycontentlocationname);
                    locationObjectpropCount++;
                }

                if (__workflow_bodycontentlocationaddress != null)
                {
                    locationObject["address"] = ExpressionConverter.ConvertO(__workflow_bodycontentlocationaddress);
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
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse> SendWhatsAppQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<bodycontentinteractivecomponentsbuttonsInputItem[]>> bodycontentinteractivecomponentsbuttons = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = bodycontentinteractivecomponentsheadertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = bodycontentinteractivecomponentsheadertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = bodycontentinteractivecomponentsbodytype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = bodycontentinteractivecomponentsbodytext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = bodycontentinteractivecomponentsfootertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = bodycontentinteractivecomponentsfootertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbuttons = bodycontentinteractivecomponentsbuttons == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbuttons);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbuttons, nameof(bodycontentinteractivecomponentsbuttons), required: false);
            return new DeferredBodyAction<SendWhatsAppQuickReplyResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsbuttons != null)
                {
                    componentsObject["buttons"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbuttons);
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
        public IBodyWorkflowAction<SendWhatsAppProductListResponse> SendWhatsAppProductList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductListcatalogId = null, Expression<Func<bodycontentinteractivecomponentsproductListsectionsInputItem[]>> bodycontentinteractivecomponentsproductListsections = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = bodycontentinteractivecomponentsheadertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = bodycontentinteractivecomponentsheadertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = bodycontentinteractivecomponentsbodytype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = bodycontentinteractivecomponentsbodytext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = bodycontentinteractivecomponentsfootertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = bodycontentinteractivecomponentsfootertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsproductListcatalogId = bodycontentinteractivecomponentsproductListcatalogId == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsproductListcatalogId);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsproductListcatalogId, nameof(bodycontentinteractivecomponentsproductListcatalogId), required: false);
            var __workflow_bodycontentinteractivecomponentsproductListsections = bodycontentinteractivecomponentsproductListsections == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsproductListsections);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsproductListsections, nameof(bodycontentinteractivecomponentsproductListsections), required: false);
            return new DeferredBodyAction<SendWhatsAppProductListResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var productListObject = new JObject();
                var productListObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsproductListcatalogId != null)
                {
                    productListObject["catalogId"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsproductListcatalogId);
                    productListObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsproductListsections != null)
                {
                    productListObject["sections"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsproductListsections);
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
        public IBodyWorkflowAction<SendWhatsAppProductResponse> SendWhatsAppProduct(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductcatalogId = null, Expression<Func<string>> bodycontentinteractivecomponentsproductproductId = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = bodycontentinteractivecomponentsheadertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = bodycontentinteractivecomponentsheadertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = bodycontentinteractivecomponentsbodytype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = bodycontentinteractivecomponentsbodytext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = bodycontentinteractivecomponentsfootertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = bodycontentinteractivecomponentsfootertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsproductcatalogId = bodycontentinteractivecomponentsproductcatalogId == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsproductcatalogId);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsproductcatalogId, nameof(bodycontentinteractivecomponentsproductcatalogId), required: false);
            var __workflow_bodycontentinteractivecomponentsproductproductId = bodycontentinteractivecomponentsproductproductId == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsproductproductId);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsproductproductId, nameof(bodycontentinteractivecomponentsproductproductId), required: false);
            return new DeferredBodyAction<SendWhatsAppProductResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var productObject = new JObject();
                var productObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsproductcatalogId != null)
                {
                    productObject["catalogId"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsproductcatalogId);
                    productObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsproductproductId != null)
                {
                    productObject["productId"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsproductproductId);
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
        public IBodyWorkflowAction<SendWhatsAppListResponse> SendWhatsAppList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentslisttitle = null, Expression<Func<bodycontentinteractivecomponentslistsectionsInputItem[]>> bodycontentinteractivecomponentslistsections = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = bodycontentinteractivecomponentsheadertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = bodycontentinteractivecomponentsheadertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = bodycontentinteractivecomponentsbodytype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = bodycontentinteractivecomponentsbodytext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = bodycontentinteractivecomponentsfootertype == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = bodycontentinteractivecomponentsfootertext == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentslisttitle = bodycontentinteractivecomponentslisttitle == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentslisttitle);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentslisttitle, nameof(bodycontentinteractivecomponentslisttitle), required: false);
            var __workflow_bodycontentinteractivecomponentslistsections = bodycontentinteractivecomponentslistsections == null ? null : WorkflowExpression.Compile(bodycontentinteractivecomponentslistsections);
            WorkflowExpression.Validate(__workflow_bodycontentinteractivecomponentslistsections, nameof(bodycontentinteractivecomponentslistsections), required: false);
            return new DeferredBodyAction<SendWhatsAppListResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentinteractivecomponentsheadertype != null)
                {
                    headerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsheadertext);
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    componentsObject["header"] = headerObject;
                    componentsObjectpropCount++;
                }

                var bodyObject = new JObject();
                var bodyObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsbodytype != null)
                {
                    bodyObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsbodytext);
                    bodyObjectpropCount++;
                }

                if (bodyObjectpropCount > 0)
                {
                    componentsObject["body"] = bodyObject;
                    componentsObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentsfootertype != null)
                {
                    footerObject["type"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                var listObject = new JObject();
                var listObjectpropCount = 0;
                if (__workflow_bodycontentinteractivecomponentslisttitle != null)
                {
                    listObject["title"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentslisttitle);
                    listObjectpropCount++;
                }

                if (__workflow_bodycontentinteractivecomponentslistsections != null)
                {
                    listObject["sections"] = ExpressionConverter.ConvertO(__workflow_bodycontentinteractivecomponentslistsections);
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
        public IBodyWorkflowAction<SendsWhatsAppImageResponse> SendsWhatsAppImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentimageurl = null, Expression<Func<string>> bodycontentimagecaption = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentimageurl = bodycontentimageurl == null ? null : WorkflowExpression.Compile(bodycontentimageurl);
            WorkflowExpression.Validate(__workflow_bodycontentimageurl, nameof(bodycontentimageurl), required: false);
            var __workflow_bodycontentimagecaption = bodycontentimagecaption == null ? null : WorkflowExpression.Compile(bodycontentimagecaption);
            WorkflowExpression.Validate(__workflow_bodycontentimagecaption, nameof(bodycontentimagecaption), required: false);
            return new DeferredBodyAction<SendsWhatsAppImageResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentimageurl != null)
                {
                    imageObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentimageurl);
                    imageObjectpropCount++;
                }

                if (__workflow_bodycontentimagecaption != null)
                {
                    imageObject["caption"] = ExpressionConverter.ConvertO(__workflow_bodycontentimagecaption);
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
        public IBodyWorkflowAction<SendWhatsAppVideoResponse> SendWhatsAppVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentvideourl = null, Expression<Func<string>> bodycontentvideocaption = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentvideourl = bodycontentvideourl == null ? null : WorkflowExpression.Compile(bodycontentvideourl);
            WorkflowExpression.Validate(__workflow_bodycontentvideourl, nameof(bodycontentvideourl), required: false);
            var __workflow_bodycontentvideocaption = bodycontentvideocaption == null ? null : WorkflowExpression.Compile(bodycontentvideocaption);
            WorkflowExpression.Validate(__workflow_bodycontentvideocaption, nameof(bodycontentvideocaption), required: false);
            return new DeferredBodyAction<SendWhatsAppVideoResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentvideourl != null)
                {
                    videoObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentvideourl);
                    videoObjectpropCount++;
                }

                if (__workflow_bodycontentvideocaption != null)
                {
                    videoObject["caption"] = ExpressionConverter.ConvertO(__workflow_bodycontentvideocaption);
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
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse> SendWhatsAppDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentdocumenturl = null, Expression<Func<string>> bodycontentdocumentcaption = null, Expression<Func<string>> bodycontentdocumentfilename = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentdocumenturl = bodycontentdocumenturl == null ? null : WorkflowExpression.Compile(bodycontentdocumenturl);
            WorkflowExpression.Validate(__workflow_bodycontentdocumenturl, nameof(bodycontentdocumenturl), required: false);
            var __workflow_bodycontentdocumentcaption = bodycontentdocumentcaption == null ? null : WorkflowExpression.Compile(bodycontentdocumentcaption);
            WorkflowExpression.Validate(__workflow_bodycontentdocumentcaption, nameof(bodycontentdocumentcaption), required: false);
            var __workflow_bodycontentdocumentfilename = bodycontentdocumentfilename == null ? null : WorkflowExpression.Compile(bodycontentdocumentfilename);
            WorkflowExpression.Validate(__workflow_bodycontentdocumentfilename, nameof(bodycontentdocumentfilename), required: false);
            return new DeferredBodyAction<SendWhatsAppDocumentResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentdocumenturl != null)
                {
                    documentObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentdocumenturl);
                    documentObjectpropCount++;
                }

                if (__workflow_bodycontentdocumentcaption != null)
                {
                    documentObject["caption"] = ExpressionConverter.ConvertO(__workflow_bodycontentdocumentcaption);
                    documentObjectpropCount++;
                }

                if (__workflow_bodycontentdocumentfilename != null)
                {
                    documentObject["filename"] = ExpressionConverter.ConvertO(__workflow_bodycontentdocumentfilename);
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
        public IBodyWorkflowAction<SendWhatsAppAudioResponse> SendWhatsAppAudio(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentaudiourl = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentaudiourl = bodycontentaudiourl == null ? null : WorkflowExpression.Compile(bodycontentaudiourl);
            WorkflowExpression.Validate(__workflow_bodycontentaudiourl, nameof(bodycontentaudiourl), required: false);
            return new DeferredBodyAction<SendWhatsAppAudioResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/audio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentaudiourl != null)
                {
                    audioObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentaudiourl);
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
        public IBodyWorkflowAction<SendWhatsAppStickerResponse> SendWhatsAppSticker(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentstickerurl = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentstickerurl = bodycontentstickerurl == null ? null : WorkflowExpression.Compile(bodycontentstickerurl);
            WorkflowExpression.Validate(__workflow_bodycontentstickerurl, nameof(bodycontentstickerurl), required: false);
            return new DeferredBodyAction<SendWhatsAppStickerResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/sticker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontentstickerurl != null)
                {
                    stickerObject["url"] = ExpressionConverter.ConvertO(__workflow_bodycontentstickerurl);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse> SendWhatsAppTemplateText(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = bodycontenttemplatecomponentsheader == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsheader);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateTextResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse> SendWhatsAppTemplateLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = bodycontenttemplatecomponentsheader == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsheader);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateLocationResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse> SendWhatsAppTemplateImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem22[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = bodycontenttemplatecomponentsheader == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsheader);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateImageResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse> SendWhatsAppTemplateDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = bodycontenttemplatecomponentsheader == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsheader);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDocumentResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> SendWhatsAppTemplateVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodycontentcontentType = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodychannel = bodychannel == null ? null : WorkflowExpression.Compile(bodychannel);
            WorkflowExpression.Validate(__workflow_bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodycontentcontentType = bodycontentcontentType == null ? null : WorkflowExpression.Compile(bodycontentcontentType);
            WorkflowExpression.Validate(__workflow_bodycontentcontentType, nameof(bodycontentcontentType), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = bodycontenttemplatecomponentsheader == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsheader);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateVideoResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                    bodypropCount++;
                }

                if (__workflow_bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (__workflow_bodycontentcontentType != null)
                {
                    contentObject["contentType"] = ExpressionConverter.ConvertO(__workflow_bodycontentcontentType);
                    contentObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse> SendWhatsAppTemplateDynamicButton(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem[]>> bodycontenttemplatecomponentsbutton = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            var __workflow_bodycontenttemplatecomponentsbutton = bodycontenttemplatecomponentsbutton == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbutton);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDynamicButtonResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-dynamic-button";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbutton);
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
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse> SendWhatsAppTemplateQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem2[]>> bodycontenttemplatecomponentsbutton = null)
        {
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = bodycontenttemplatetemplateId == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateId);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = bodycontenttemplatetemplateLanguage == null ? null : WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = bodycontenttemplatecomponentsbody == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbody);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            var __workflow_bodycontenttemplatecomponentsbutton = bodycontenttemplatecomponentsbutton == null ? null : WorkflowExpression.Compile(bodycontenttemplatecomponentsbutton);
            WorkflowExpression.Validate(__workflow_bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateQuickReplyResponse>(() =>
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

                if (__workflow_bodyto != null)
                {
                    body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
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
                if (__workflow_bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (__workflow_bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (__workflow_bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = ExpressionConverter.ConvertO(__workflow_bodycontenttemplatecomponentsbutton);
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
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming(Expression<Func<string>> wABA, FlowRecurrence recurrence = null)
        {
            var __workflow_wABA = wABA == null ? null : WorkflowExpression.Compile(wABA);
            WorkflowExpression.Validate(__workflow_wABA, nameof(wABA), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_wABA, 1));
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
