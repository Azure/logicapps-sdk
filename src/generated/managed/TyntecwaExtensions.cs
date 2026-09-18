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
        public IBodyWorkflowAction<TestPhoneNumberResponse> TestPhoneNumber([WorkflowExpression] Func<string> whatsAppBusinessNumber)
        {
            SourceExpression.Validate(whatsAppBusinessNumber, nameof(whatsAppBusinessNumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/channels/whatsapp/phone-numbers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(whatsAppBusinessNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TestPhoneNumberResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTextResponse> SendWhatsAppText([WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<string> bodycontenttext = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: true);
            SourceExpression.Validate(bodycontenttext, nameof(bodycontenttext), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                contentObject["contentType"] = "text";
                contentObjectpropCount++;
                if (bodycontenttext != null)
                {
                    contentObject["text"] = SourceExpressionConverter.ConvertToken(bodycontenttext);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppContactResponse> SendWhatsAppContact([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<bodycontentcontactsInputItem[]> bodycontentcontacts = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentcontacts, nameof(bodycontentcontacts), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/contact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                body["channel"] = "whatsapp";
                bodypropCount++;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentcontacts != null)
                {
                    contentObject["contacts"] = SourceExpressionConverter.ConvertToken(bodycontentcontacts);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppContactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppLocationResponse> SendWhatsAppLocation([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<double> bodycontentlocationlongitude = null, [WorkflowExpression] Func<double> bodycontentlocationlatitude = null, [WorkflowExpression] Func<string> bodycontentlocationname = null, [WorkflowExpression] Func<string> bodycontentlocationaddress = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentlocationlongitude, nameof(bodycontentlocationlongitude), required: false);
            SourceExpression.Validate(bodycontentlocationlatitude, nameof(bodycontentlocationlatitude), required: false);
            SourceExpression.Validate(bodycontentlocationname, nameof(bodycontentlocationname), required: false);
            SourceExpression.Validate(bodycontentlocationaddress, nameof(bodycontentlocationaddress), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    locationObject["longitude"] = SourceExpressionConverter.ConvertToken(bodycontentlocationlongitude);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationlatitude != null)
                {
                    locationObject["latitude"] = SourceExpressionConverter.ConvertToken(bodycontentlocationlatitude);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationname != null)
                {
                    locationObject["name"] = SourceExpressionConverter.ConvertToken(bodycontentlocationname);
                    locationObjectpropCount++;
                }

                if (bodycontentlocationaddress != null)
                {
                    locationObject["address"] = SourceExpressionConverter.ConvertToken(bodycontentlocationaddress);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppQuickReplyResponse> SendWhatsAppQuickReply([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<bodycontentinteractivecomponentsbuttonsInputItem[]> bodycontentinteractivecomponentsbuttons = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbuttons, nameof(bodycontentinteractivecomponentsbuttons), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    headerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertext);
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
                    bodyObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytext);
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
                    footerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertext);
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    componentsObject["footer"] = footerObject;
                    componentsObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbuttons != null)
                {
                    componentsObject["buttons"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbuttons);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppQuickReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductListResponse> SendWhatsAppProductList([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductListcatalogId = null, [WorkflowExpression] Func<bodycontentinteractivecomponentsproductListsectionsInputItem[]> bodycontentinteractivecomponentsproductListsections = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsproductListcatalogId, nameof(bodycontentinteractivecomponentsproductListcatalogId), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsproductListsections, nameof(bodycontentinteractivecomponentsproductListsections), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product-list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    headerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertext);
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
                    bodyObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytext);
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
                    footerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertext);
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
                    productListObject["catalogId"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsproductListcatalogId);
                    productListObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsproductListsections != null)
                {
                    productListObject["sections"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsproductListsections);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppProductListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppProductResponse> SendWhatsAppProduct([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductcatalogId = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsproductproductId = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsproductcatalogId, nameof(bodycontentinteractivecomponentsproductcatalogId), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsproductproductId, nameof(bodycontentinteractivecomponentsproductproductId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/product";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    headerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertext);
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
                    bodyObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytext);
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
                    footerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertext);
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
                    productObject["catalogId"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsproductcatalogId);
                    productObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsproductproductId != null)
                {
                    productObject["productId"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsproductproductId);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppProductResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppListResponse> SendWhatsAppList([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsheadertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsbodytext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertype = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentsfootertext = null, [WorkflowExpression] Func<string> bodycontentinteractivecomponentslisttitle = null, [WorkflowExpression] Func<bodycontentinteractivecomponentslistsectionsInputItem[]> bodycontentinteractivecomponentslistsections = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertype, nameof(bodycontentinteractivecomponentsheadertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsheadertext, nameof(bodycontentinteractivecomponentsheadertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytype, nameof(bodycontentinteractivecomponentsbodytype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsbodytext, nameof(bodycontentinteractivecomponentsbodytext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertype, nameof(bodycontentinteractivecomponentsfootertype), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentsfootertext, nameof(bodycontentinteractivecomponentsfootertext), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentslisttitle, nameof(bodycontentinteractivecomponentslisttitle), required: false);
            SourceExpression.Validate(bodycontentinteractivecomponentslistsections, nameof(bodycontentinteractivecomponentslistsections), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/list";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    headerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertype);
                    headerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsheadertext != null)
                {
                    headerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsheadertext);
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
                    bodyObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytype);
                    bodyObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsbodytext != null)
                {
                    bodyObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsbodytext);
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
                    footerObject["type"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertype);
                    footerObjectpropCount++;
                }

                if (bodycontentinteractivecomponentsfootertext != null)
                {
                    footerObject["text"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentsfootertext);
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
                    listObject["title"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentslisttitle);
                    listObjectpropCount++;
                }

                if (bodycontentinteractivecomponentslistsections != null)
                {
                    listObject["sections"] = SourceExpressionConverter.ConvertToken(bodycontentinteractivecomponentslistsections);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendsWhatsAppImageResponse> SendsWhatsAppImage([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentimageurl = null, [WorkflowExpression] Func<string> bodycontentimagecaption = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentimageurl, nameof(bodycontentimageurl), required: false);
            SourceExpression.Validate(bodycontentimagecaption, nameof(bodycontentimagecaption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    imageObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentimageurl);
                    imageObjectpropCount++;
                }

                if (bodycontentimagecaption != null)
                {
                    imageObject["caption"] = SourceExpressionConverter.ConvertToken(bodycontentimagecaption);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendsWhatsAppImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppVideoResponse> SendWhatsAppVideo([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentvideourl = null, [WorkflowExpression] Func<string> bodycontentvideocaption = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentvideourl, nameof(bodycontentvideourl), required: false);
            SourceExpression.Validate(bodycontentvideocaption, nameof(bodycontentvideocaption), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    videoObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentvideourl);
                    videoObjectpropCount++;
                }

                if (bodycontentvideocaption != null)
                {
                    videoObject["caption"] = SourceExpressionConverter.ConvertToken(bodycontentvideocaption);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppVideoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppDocumentResponse> SendWhatsAppDocument([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentdocumenturl = null, [WorkflowExpression] Func<string> bodycontentdocumentcaption = null, [WorkflowExpression] Func<string> bodycontentdocumentfilename = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentdocumenturl, nameof(bodycontentdocumenturl), required: false);
            SourceExpression.Validate(bodycontentdocumentcaption, nameof(bodycontentdocumentcaption), required: false);
            SourceExpression.Validate(bodycontentdocumentfilename, nameof(bodycontentdocumentfilename), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    documentObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentdocumenturl);
                    documentObjectpropCount++;
                }

                if (bodycontentdocumentcaption != null)
                {
                    documentObject["caption"] = SourceExpressionConverter.ConvertToken(bodycontentdocumentcaption);
                    documentObjectpropCount++;
                }

                if (bodycontentdocumentfilename != null)
                {
                    documentObject["filename"] = SourceExpressionConverter.ConvertToken(bodycontentdocumentfilename);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppAudioResponse> SendWhatsAppAudio([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentaudiourl = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentaudiourl, nameof(bodycontentaudiourl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/audio";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    audioObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentaudiourl);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppAudioResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppStickerResponse> SendWhatsAppSticker([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontentstickerurl = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontentstickerurl, nameof(bodycontentstickerurl), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/sticker";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    stickerObject["url"] = SourceExpressionConverter.ConvertToken(bodycontentstickerurl);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppStickerResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateTextResponse> SendWhatsAppTemplateText([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-text";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateTextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateLocationResponse> SendWhatsAppTemplateLocation([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem2[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-location";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateLocationResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateImageResponse> SendWhatsAppTemplateImage([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem22[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-image";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateImageResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDocumentResponse> SendWhatsAppTemplateDocument([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem222[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-document";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateVideoResponse> SendWhatsAppTemplateVideo([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodychannel = null, [WorkflowExpression] Func<string> bodycontentcontentType = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsheaderInputItem2222[]> bodycontenttemplatecomponentsheader = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            SourceExpression.Validate(bodycontentcontentType, nameof(bodycontentcontentType), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsheader, nameof(bodycontenttemplatecomponentsheader), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-video";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = SourceExpressionConverter.ConvertToken(bodychannel);
                    bodypropCount++;
                }

                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodycontentcontentType != null)
                {
                    contentObject["contentType"] = SourceExpressionConverter.ConvertToken(bodycontentcontentType);
                    contentObjectpropCount++;
                }

                var templateObject = new JObject();
                var templateObjectpropCount = 0;
                if (bodycontenttemplatetemplateId != null)
                {
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsheader != null)
                {
                    componentsObject["header"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsheader);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateVideoResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateDynamicButtonResponse> SendWhatsAppTemplateDynamicButton([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbuttonInputItem[]> bodycontenttemplatecomponentsbutton = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-dynamic-button";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbutton);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateDynamicButtonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<SendWhatsAppTemplateQuickReplyResponse> SendWhatsAppTemplateQuickReply([WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyto = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateId = null, [WorkflowExpression] Func<string> bodycontenttemplatetemplateLanguage = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbodyInputItem[]> bodycontenttemplatecomponentsbody = null, [WorkflowExpression] Func<bodycontenttemplatecomponentsbuttonInputItem2[]> bodycontenttemplatecomponentsbutton = null)
        {
            SourceExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            SourceExpression.Validate(bodyto, nameof(bodyto), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateId, nameof(bodycontenttemplatetemplateId), required: false);
            SourceExpression.Validate(bodycontenttemplatetemplateLanguage, nameof(bodycontenttemplatetemplateLanguage), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbody, nameof(bodycontenttemplatecomponentsbody), required: false);
            SourceExpression.Validate(bodycontenttemplatecomponentsbutton, nameof(bodycontenttemplatecomponentsbutton), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/conversations/v3/power-automate/messages/whatsapp/template-quick-reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

                if (bodyto != null)
                {
                    body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
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
                    templateObject["templateId"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateId);
                    templateObjectpropCount++;
                }

                if (bodycontenttemplatetemplateLanguage != null)
                {
                    templateObject["templateLanguage"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatetemplateLanguage);
                    templateObjectpropCount++;
                }

                var componentsObject = new JObject();
                var componentsObjectpropCount = 0;
                if (bodycontenttemplatecomponentsbody != null)
                {
                    componentsObject["body"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbody);
                    componentsObjectpropCount++;
                }

                if (bodycontenttemplatecomponentsbutton != null)
                {
                    componentsObject["button"] = SourceExpressionConverter.ConvertToken(bodycontenttemplatecomponentsbutton);
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
                return callPayload;
            }

            return new ApiConnectionAction<SendWhatsAppTemplateQuickReplyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tyntecwa")]
        public IBodyWorkflowAction<StatusCheckV3Response> StatusCheck([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/messages/{0}/status", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<StatusCheckV3Response>(BuildSourceInput);
        }
    }

    public class TyntecwaTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger Incoming([WorkflowExpression] Func<string> wABA, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(wABA, nameof(wABA), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/conversations/v3/power-automate/webhooks/channels/whatsapp/phone-numbers/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(wABA, 1));
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
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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