//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Tyntecwa
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TyntecwaActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<TestPhoneNumberResponse, ApiConnectionActionConfiguration> TestPhoneNumber(Expression<Func<string>> whatsAppBusinessNumber)
        {
            var __workflow_whatsAppBusinessNumber = WorkflowExpression.Compile(whatsAppBusinessNumber, nameof(whatsAppBusinessNumber), required: true);
            return new DeferredBodyAction<TestPhoneNumberResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/channels/whatsapp/phone-numbers/{0}", __workflow_whatsAppBusinessNumber.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TestPhoneNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration> SendWhatsAppText(Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<string>> bodycontenttext = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: true);
            var __workflow_bodycontenttext = WorkflowExpression.Compile(bodycontenttext, nameof(bodycontenttext), required: false);
            return new DeferredBodyAction<SendWhatsAppTextResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration> SendWhatsAppContact(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<bodycontentcontactsInputItem[]>> bodycontentcontacts = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentcontacts = WorkflowExpression.Compile(bodycontentcontacts, nameof(bodycontentcontacts), required: false);
            return new DeferredBodyAction<SendWhatsAppContactResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<double>> bodycontentlocationlongitude = null, Expression<Func<double>> bodycontentlocationlatitude = null, Expression<Func<string>> bodycontentlocationname = null, Expression<Func<string>> bodycontentlocationaddress = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentlocationlongitude = WorkflowExpression.Compile(bodycontentlocationlongitude, nameof(bodycontentlocationlongitude), required: false);
            var __workflow_bodycontentlocationlatitude = WorkflowExpression.Compile(bodycontentlocationlatitude, nameof(bodycontentlocationlatitude), required: false);
            var __workflow_bodycontentlocationname = WorkflowExpression.Compile(bodycontentlocationname, nameof(bodycontentlocationname), required: false);
            var __workflow_bodycontentlocationaddress = WorkflowExpression.Compile(bodycontentlocationaddress, nameof(bodycontentlocationaddress), required: false);
            return new DeferredBodyAction<SendWhatsAppLocationResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<bodycontentinteractivecomponentsbuttonsInputItem[]>> bodycontentinteractivecomponentsbuttons = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbuttons = WorkflowExpression.Compile(bodycontentinteractivecomponentsbuttons, nameof(bodycontentinteractivecomponentsbuttons), required: false);
            return new DeferredBodyAction<SendWhatsAppQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration> SendWhatsAppProductList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductListcatalogId = null, Expression<Func<bodycontentinteractivecomponentsproductListsectionsInputItem[]>> bodycontentinteractivecomponentsproductListsections = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsproductListcatalogId = WorkflowExpression.Compile(bodycontentinteractivecomponentsproductListcatalogId, nameof(bodycontentinteractivecomponentsproductListcatalogId), required: false);
            var __workflow_bodycontentinteractivecomponentsproductListsections = WorkflowExpression.Compile(bodycontentinteractivecomponentsproductListsections, nameof(bodycontentinteractivecomponentsproductListsections), required: false);
            return new DeferredBodyAction<SendWhatsAppProductListResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration> SendWhatsAppProduct(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentsproductcatalogId = null, Expression<Func<string>> bodycontentinteractivecomponentsproductproductId = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentsproductcatalogId = WorkflowExpression.Compile(bodycontentinteractivecomponentsproductcatalogId, nameof(bodycontentinteractivecomponentsproductcatalogId), required: false);
            var __workflow_bodycontentinteractivecomponentsproductproductId = WorkflowExpression.Compile(bodycontentinteractivecomponentsproductproductId, nameof(bodycontentinteractivecomponentsproductproductId), required: false);
            return new DeferredBodyAction<SendWhatsAppProductResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration> SendWhatsAppList(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertype = null, Expression<Func<string>> bodycontentinteractivecomponentsheadertext = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytype = null, Expression<Func<string>> bodycontentinteractivecomponentsbodytext = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertype = null, Expression<Func<string>> bodycontentinteractivecomponentsfootertext = null, Expression<Func<string>> bodycontentinteractivecomponentslisttitle = null, Expression<Func<bodycontentinteractivecomponentslistsectionsInputItem[]>> bodycontentinteractivecomponentslistsections = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            var __workflow_bodycontentinteractivecomponentsheadertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytype = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            var __workflow_bodycontentinteractivecomponentsbodytext = WorkflowExpression.Compile(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertype = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            var __workflow_bodycontentinteractivecomponentsfootertext = WorkflowExpression.Compile(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            var __workflow_bodycontentinteractivecomponentslisttitle = WorkflowExpression.Compile(bodycontentinteractivecomponentslisttitle, nameof(bodycontentinteractivecomponentslisttitle), required: false);
            var __workflow_bodycontentinteractivecomponentslistsections = WorkflowExpression.Compile(bodycontentinteractivecomponentslistsections, nameof(bodycontentinteractivecomponentslistsections), required: false);
            return new DeferredBodyAction<SendWhatsAppListResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration> SendsWhatsAppImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentimageurl = null, Expression<Func<string>> bodycontentimagecaption = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentimageurl = WorkflowExpression.Compile(bodycontentimageurl, nameof(bodycontentimageurl), required: false);
            var __workflow_bodycontentimagecaption = WorkflowExpression.Compile(bodycontentimagecaption, nameof(bodycontentimagecaption), required: false);
            return new DeferredBodyAction<SendsWhatsAppImageResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentvideourl = null, Expression<Func<string>> bodycontentvideocaption = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentvideourl = WorkflowExpression.Compile(bodycontentvideourl, nameof(bodycontentvideourl), required: false);
            var __workflow_bodycontentvideocaption = WorkflowExpression.Compile(bodycontentvideocaption, nameof(bodycontentvideocaption), required: false);
            return new DeferredBodyAction<SendWhatsAppVideoResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentdocumenturl = null, Expression<Func<string>> bodycontentdocumentcaption = null, Expression<Func<string>> bodycontentdocumentfilename = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentdocumenturl = WorkflowExpression.Compile(bodycontentdocumenturl, nameof(bodycontentdocumenturl), required: false);
            var __workflow_bodycontentdocumentcaption = WorkflowExpression.Compile(bodycontentdocumentcaption, nameof(bodycontentdocumentcaption), required: false);
            var __workflow_bodycontentdocumentfilename = WorkflowExpression.Compile(bodycontentdocumentfilename, nameof(bodycontentdocumentfilename), required: false);
            return new DeferredBodyAction<SendWhatsAppDocumentResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration> SendWhatsAppAudio(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentaudiourl = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentaudiourl = WorkflowExpression.Compile(bodycontentaudiourl, nameof(bodycontentaudiourl), required: false);
            return new DeferredBodyAction<SendWhatsAppAudioResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration> SendWhatsAppSticker(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontentstickerurl = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontentstickerurl = WorkflowExpression.Compile(bodycontentstickerurl, nameof(bodycontentstickerurl), required: false);
            return new DeferredBodyAction<SendWhatsAppStickerResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateText(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = WorkflowExpression.Compile(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateTextResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateLocation(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = WorkflowExpression.Compile(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateLocationResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateImage(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem22[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = WorkflowExpression.Compile(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateImageResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDocument(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = WorkflowExpression.Compile(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDocumentResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateVideo(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodychannel = null, Expression<Func<string>> bodycontentcontentType = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsheaderInputItem2222[]>> bodycontenttemplatecomponentsheader = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodychannel = WorkflowExpression.Compile(bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodycontentcontentType = WorkflowExpression.Compile(bodycontentcontentType, nameof(bodycontentcontentType), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsheader = WorkflowExpression.Compile(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateVideoResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateDynamicButton(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem[]>> bodycontenttemplatecomponentsbutton = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            var __workflow_bodycontenttemplatecomponentsbutton = WorkflowExpression.Compile(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateDynamicButtonResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration> SendWhatsAppTemplateQuickReply(Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyto = null, Expression<Func<string>> bodycontenttemplatetemplateId = null, Expression<Func<string>> bodycontenttemplatetemplateLanguage = null, Expression<Func<bodycontenttemplatecomponentsbodyInputItem[]>> bodycontenttemplatecomponentsbody = null, Expression<Func<bodycontenttemplatecomponentsbuttonInputItem2[]>> bodycontenttemplatecomponentsbutton = null)
        {
            var __workflow_bodyfrom = WorkflowExpression.Compile(bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyto = WorkflowExpression.Compile(bodyto, nameof(bodyto), required: false);
            var __workflow_bodycontenttemplatetemplateId = WorkflowExpression.Compile(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            var __workflow_bodycontenttemplatetemplateLanguage = WorkflowExpression.Compile(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            var __workflow_bodycontenttemplatecomponentsbody = WorkflowExpression.Compile(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            var __workflow_bodycontenttemplatecomponentsbutton = WorkflowExpression.Compile(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            return new DeferredBodyAction<SendWhatsAppTemplateQuickReplyResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<StatusCheckV3Response, ApiConnectionActionConfiguration> StatusCheck(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<StatusCheckV3Response, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/messages/{0}/status", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<StatusCheckV3Response>(callPayload);
            });
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> Incoming(Expression<Func<string>> wABA, FlowRecurrence recurrence = null)
        {
            var __workflow_wABA = WorkflowExpression.Compile(wABA, nameof(wABA), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", __workflow_wABA.WithUrlEncoding(1)));
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