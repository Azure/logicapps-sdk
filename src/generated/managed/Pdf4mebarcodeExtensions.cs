//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class Pdf4mebarcodeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> AddBarcode(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocName, Expression<Func<string>> bodytext, Expression<Func<bodybarcodeTypeInput>> bodybarcodeType, Expression<Func<string>> bodypages, Expression<Func<bodyalignXInput>> bodyalignX, Expression<Func<bodyalignYInput>> bodyalignY, Expression<Func<string>> bodyheightInMM, Expression<Func<string>> bodywidthInMM, Expression<Func<string>> bodymarginXInMM, Expression<Func<string>> bodymarginYInMM, Expression<Func<int>> bodyopacity, Expression<Func<string>> bodydisplayText = null, Expression<Func<bool>> bodyisTextAbove = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocName = bodydocName == null ? null : WorkflowExpression.Compile(bodydocName);
            WorkflowExpression.Validate(__workflow_bodydocName, nameof(bodydocName), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            var __workflow_bodybarcodeType = bodybarcodeType == null ? null : WorkflowExpression.Compile(bodybarcodeType);
            WorkflowExpression.Validate(__workflow_bodybarcodeType, nameof(bodybarcodeType), required: true);
            var __workflow_bodypages = bodypages == null ? null : WorkflowExpression.Compile(bodypages);
            WorkflowExpression.Validate(__workflow_bodypages, nameof(bodypages), required: true);
            var __workflow_bodyalignX = bodyalignX == null ? null : WorkflowExpression.Compile(bodyalignX);
            WorkflowExpression.Validate(__workflow_bodyalignX, nameof(bodyalignX), required: true);
            var __workflow_bodyalignY = bodyalignY == null ? null : WorkflowExpression.Compile(bodyalignY);
            WorkflowExpression.Validate(__workflow_bodyalignY, nameof(bodyalignY), required: true);
            var __workflow_bodyheightInMM = bodyheightInMM == null ? null : WorkflowExpression.Compile(bodyheightInMM);
            WorkflowExpression.Validate(__workflow_bodyheightInMM, nameof(bodyheightInMM), required: true);
            var __workflow_bodywidthInMM = bodywidthInMM == null ? null : WorkflowExpression.Compile(bodywidthInMM);
            WorkflowExpression.Validate(__workflow_bodywidthInMM, nameof(bodywidthInMM), required: true);
            var __workflow_bodymarginXInMM = bodymarginXInMM == null ? null : WorkflowExpression.Compile(bodymarginXInMM);
            WorkflowExpression.Validate(__workflow_bodymarginXInMM, nameof(bodymarginXInMM), required: true);
            var __workflow_bodymarginYInMM = bodymarginYInMM == null ? null : WorkflowExpression.Compile(bodymarginYInMM);
            WorkflowExpression.Validate(__workflow_bodymarginYInMM, nameof(bodymarginYInMM), required: true);
            var __workflow_bodyopacity = bodyopacity == null ? null : WorkflowExpression.Compile(bodyopacity);
            WorkflowExpression.Validate(__workflow_bodyopacity, nameof(bodyopacity), required: true);
            var __workflow_bodydisplayText = bodydisplayText == null ? null : WorkflowExpression.Compile(bodydisplayText);
            WorkflowExpression.Validate(__workflow_bodydisplayText, nameof(bodydisplayText), required: false);
            var __workflow_bodyisTextAbove = bodyisTextAbove == null ? null : WorkflowExpression.Compile(bodyisTextAbove);
            WorkflowExpression.Validate(__workflow_bodyisTextAbove, nameof(bodyisTextAbove), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/AddBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                bodypropCount++;
                body["docName"] = ExpressionConverter.ConvertO(__workflow_bodydocName);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                bodypropCount++;
                body["barcodeType"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeType);
                bodypropCount++;
                body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                bodypropCount++;
                body["alignX"] = ExpressionConverter.ConvertO(__workflow_bodyalignX);
                bodypropCount++;
                body["alignY"] = ExpressionConverter.ConvertO(__workflow_bodyalignY);
                bodypropCount++;
                body["heightInMM"] = ExpressionConverter.ConvertO(__workflow_bodyheightInMM);
                bodypropCount++;
                body["widthInMM"] = ExpressionConverter.ConvertO(__workflow_bodywidthInMM);
                bodypropCount++;
                body["marginXInMM"] = ExpressionConverter.ConvertO(__workflow_bodymarginXInMM);
                bodypropCount++;
                body["marginYInMM"] = ExpressionConverter.ConvertO(__workflow_bodymarginYInMM);
                bodypropCount++;
                body["opacity"] = ExpressionConverter.ConvertO(__workflow_bodyopacity);
                if (__workflow_bodydisplayText != null)
                {
                    body["displayText"] = ExpressionConverter.ConvertO(__workflow_bodydisplayText);
                    bodypropCount++;
                }

                if (__workflow_bodyisTextAbove != null)
                {
                    if (__workflow_bodyisTextAbove != null)
                    {
                        body["isTextAbove"] = ExpressionConverter.ConvertO(__workflow_bodyisTextAbove);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isTextAbove"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> Createbarcode(Expression<Func<bodybarcodeTypeInput>> bodybarcodeType, Expression<Func<string>> bodytext, Expression<Func<bool>> bodyhideText = null)
        {
            var __workflow_bodybarcodeType = bodybarcodeType == null ? null : WorkflowExpression.Compile(bodybarcodeType);
            WorkflowExpression.Validate(__workflow_bodybarcodeType, nameof(bodybarcodeType), required: true);
            var __workflow_bodytext = bodytext == null ? null : WorkflowExpression.Compile(bodytext);
            WorkflowExpression.Validate(__workflow_bodytext, nameof(bodytext), required: true);
            var __workflow_bodyhideText = bodyhideText == null ? null : WorkflowExpression.Compile(bodyhideText);
            WorkflowExpression.Validate(__workflow_bodyhideText, nameof(bodyhideText), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["barcodeType"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeType);
                bodypropCount++;
                body["text"] = ExpressionConverter.ConvertO(__workflow_bodytext);
                if (__workflow_bodyhideText != null)
                {
                    if (__workflow_bodyhideText != null)
                    {
                        body["hideText"] = ExpressionConverter.ConvertO(__workflow_bodyhideText);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["hideText"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateEpcQrCode(Expression<Func<bodyepcQrCodeActionversionInput>> bodyepcQrCodeActionversion = null, Expression<Func<bodyepcQrCodeActioncharacterSetInput>> bodyepcQrCodeActioncharacterSet = null, Expression<Func<string>> bodyepcQrCodeActionbic = null, Expression<Func<string>> bodyepcQrCodeActionreceiverName = null, Expression<Func<string>> bodyepcQrCodeActioniban = null, Expression<Func<double>> bodyepcQrCodeActionamount = null, Expression<Func<string>> bodyepcQrCodeActionpurpose = null, Expression<Func<string>> bodyepcQrCodeActionremittanceReference = null, Expression<Func<string>> bodyepcQrCodeActionremittanceText = null, Expression<Func<string>> bodyepcQrCodeActioninformation = null)
        {
            var __workflow_bodyepcQrCodeActionversion = bodyepcQrCodeActionversion == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionversion);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionversion, nameof(bodyepcQrCodeActionversion), required: false);
            var __workflow_bodyepcQrCodeActioncharacterSet = bodyepcQrCodeActioncharacterSet == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActioncharacterSet);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActioncharacterSet, nameof(bodyepcQrCodeActioncharacterSet), required: false);
            var __workflow_bodyepcQrCodeActionbic = bodyepcQrCodeActionbic == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionbic);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionbic, nameof(bodyepcQrCodeActionbic), required: false);
            var __workflow_bodyepcQrCodeActionreceiverName = bodyepcQrCodeActionreceiverName == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionreceiverName);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionreceiverName, nameof(bodyepcQrCodeActionreceiverName), required: false);
            var __workflow_bodyepcQrCodeActioniban = bodyepcQrCodeActioniban == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActioniban);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActioniban, nameof(bodyepcQrCodeActioniban), required: false);
            var __workflow_bodyepcQrCodeActionamount = bodyepcQrCodeActionamount == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionamount);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionamount, nameof(bodyepcQrCodeActionamount), required: false);
            var __workflow_bodyepcQrCodeActionpurpose = bodyepcQrCodeActionpurpose == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionpurpose);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionpurpose, nameof(bodyepcQrCodeActionpurpose), required: false);
            var __workflow_bodyepcQrCodeActionremittanceReference = bodyepcQrCodeActionremittanceReference == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionremittanceReference);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionremittanceReference, nameof(bodyepcQrCodeActionremittanceReference), required: false);
            var __workflow_bodyepcQrCodeActionremittanceText = bodyepcQrCodeActionremittanceText == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActionremittanceText);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActionremittanceText, nameof(bodyepcQrCodeActionremittanceText), required: false);
            var __workflow_bodyepcQrCodeActioninformation = bodyepcQrCodeActioninformation == null ? null : WorkflowExpression.Compile(bodyepcQrCodeActioninformation);
            WorkflowExpression.Validate(__workflow_bodyepcQrCodeActioninformation, nameof(bodyepcQrCodeActioninformation), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateEpcQrCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var epcQrCodeActionObject = new JObject();
                var epcQrCodeActionObjectpropCount = 0;
                epcQrCodeActionObject["serviceTag"] = "BCD";
                epcQrCodeActionObjectpropCount++;
                if (__workflow_bodyepcQrCodeActionversion != null)
                {
                    if (__workflow_bodyepcQrCodeActionversion != null)
                    {
                        epcQrCodeActionObject["version"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionversion);
                        epcQrCodeActionObjectpropCount++;
                    }

                    epcQrCodeActionObjectpropCount++;
                }
                else
                {
                    epcQrCodeActionObject["version"] = "V2";
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActioncharacterSet != null)
                {
                    if (__workflow_bodyepcQrCodeActioncharacterSet != null)
                    {
                        epcQrCodeActionObject["characterSet"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActioncharacterSet);
                        epcQrCodeActionObjectpropCount++;
                    }

                    epcQrCodeActionObjectpropCount++;
                }
                else
                {
                    epcQrCodeActionObject["characterSet"] = "UTF8";
                    epcQrCodeActionObjectpropCount++;
                }

                epcQrCodeActionObject["identificationCode"] = "SCT";
                epcQrCodeActionObjectpropCount++;
                if (__workflow_bodyepcQrCodeActionbic != null)
                {
                    epcQrCodeActionObject["bic"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionbic);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActionreceiverName != null)
                {
                    epcQrCodeActionObject["receiverName"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionreceiverName);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActioniban != null)
                {
                    epcQrCodeActionObject["iban"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActioniban);
                    epcQrCodeActionObjectpropCount++;
                }

                epcQrCodeActionObject["currency"] = "EUR";
                epcQrCodeActionObjectpropCount++;
                if (__workflow_bodyepcQrCodeActionamount != null)
                {
                    epcQrCodeActionObject["amount"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionamount);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActionpurpose != null)
                {
                    epcQrCodeActionObject["purpose"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionpurpose);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActionremittanceReference != null)
                {
                    epcQrCodeActionObject["remittanceReference"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionremittanceReference);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActionremittanceText != null)
                {
                    epcQrCodeActionObject["remittanceText"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActionremittanceText);
                    epcQrCodeActionObjectpropCount++;
                }

                if (__workflow_bodyepcQrCodeActioninformation != null)
                {
                    epcQrCodeActionObject["information"] = ExpressionConverter.ConvertO(__workflow_bodyepcQrCodeActioninformation);
                    epcQrCodeActionObjectpropCount++;
                }

                if (epcQrCodeActionObjectpropCount > 0)
                {
                    body["epcQrCodeAction"] = epcQrCodeActionObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> CreateSwissQrBill(Expression<Func<bodycrAddressTypeInput>> bodycrAddressType, Expression<Func<string>> bodycrName, Expression<Func<string>> bodydocContent, Expression<Func<string>> bodyiban, Expression<Func<string>> bodyamount = null, Expression<Func<string>> bodyav1Parameters = null, Expression<Func<string>> bodyav2Parameters = null, Expression<Func<string>> bodybillingInfo = null, Expression<Func<string>> bodycrCity = null, Expression<Func<string>> bodycrPostalCode = null, Expression<Func<string>> bodycrStreetOrAddressLine1 = null, Expression<Func<string>> bodycrStreetOrAddressLine2 = null, Expression<Func<bodycurrencyInput>> bodycurrency = null, Expression<Func<string>> bodydocumentname = null, Expression<Func<bodylanguageTypeInput>> bodylanguageType = null, Expression<Func<string>> bodyreference = null, Expression<Func<bodyreferenceTypeInput>> bodyreferenceType = null, Expression<Func<bodyseperatorLineInput>> bodyseperatorLine = null, Expression<Func<bodyudAddressTypeInput>> bodyudAddressType = null, Expression<Func<string>> bodyudCity = null, Expression<Func<string>> bodyudName = null, Expression<Func<string>> bodyudPostalCode = null, Expression<Func<string>> bodyudStreetOrAddressLine1 = null, Expression<Func<string>> bodyudStreetOrAddressLine2 = null, Expression<Func<string>> bodyunstructuredMessage = null)
        {
            var __workflow_bodycrAddressType = bodycrAddressType == null ? null : WorkflowExpression.Compile(bodycrAddressType);
            WorkflowExpression.Validate(__workflow_bodycrAddressType, nameof(bodycrAddressType), required: true);
            var __workflow_bodycrName = bodycrName == null ? null : WorkflowExpression.Compile(bodycrName);
            WorkflowExpression.Validate(__workflow_bodycrName, nameof(bodycrName), required: true);
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodyiban = bodyiban == null ? null : WorkflowExpression.Compile(bodyiban);
            WorkflowExpression.Validate(__workflow_bodyiban, nameof(bodyiban), required: true);
            var __workflow_bodyamount = bodyamount == null ? null : WorkflowExpression.Compile(bodyamount);
            WorkflowExpression.Validate(__workflow_bodyamount, nameof(bodyamount), required: false);
            var __workflow_bodyav1Parameters = bodyav1Parameters == null ? null : WorkflowExpression.Compile(bodyav1Parameters);
            WorkflowExpression.Validate(__workflow_bodyav1Parameters, nameof(bodyav1Parameters), required: false);
            var __workflow_bodyav2Parameters = bodyav2Parameters == null ? null : WorkflowExpression.Compile(bodyav2Parameters);
            WorkflowExpression.Validate(__workflow_bodyav2Parameters, nameof(bodyav2Parameters), required: false);
            var __workflow_bodybillingInfo = bodybillingInfo == null ? null : WorkflowExpression.Compile(bodybillingInfo);
            WorkflowExpression.Validate(__workflow_bodybillingInfo, nameof(bodybillingInfo), required: false);
            var __workflow_bodycrCity = bodycrCity == null ? null : WorkflowExpression.Compile(bodycrCity);
            WorkflowExpression.Validate(__workflow_bodycrCity, nameof(bodycrCity), required: false);
            var __workflow_bodycrPostalCode = bodycrPostalCode == null ? null : WorkflowExpression.Compile(bodycrPostalCode);
            WorkflowExpression.Validate(__workflow_bodycrPostalCode, nameof(bodycrPostalCode), required: false);
            var __workflow_bodycrStreetOrAddressLine1 = bodycrStreetOrAddressLine1 == null ? null : WorkflowExpression.Compile(bodycrStreetOrAddressLine1);
            WorkflowExpression.Validate(__workflow_bodycrStreetOrAddressLine1, nameof(bodycrStreetOrAddressLine1), required: false);
            var __workflow_bodycrStreetOrAddressLine2 = bodycrStreetOrAddressLine2 == null ? null : WorkflowExpression.Compile(bodycrStreetOrAddressLine2);
            WorkflowExpression.Validate(__workflow_bodycrStreetOrAddressLine2, nameof(bodycrStreetOrAddressLine2), required: false);
            var __workflow_bodycurrency = bodycurrency == null ? null : WorkflowExpression.Compile(bodycurrency);
            WorkflowExpression.Validate(__workflow_bodycurrency, nameof(bodycurrency), required: false);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodylanguageType = bodylanguageType == null ? null : WorkflowExpression.Compile(bodylanguageType);
            WorkflowExpression.Validate(__workflow_bodylanguageType, nameof(bodylanguageType), required: false);
            var __workflow_bodyreference = bodyreference == null ? null : WorkflowExpression.Compile(bodyreference);
            WorkflowExpression.Validate(__workflow_bodyreference, nameof(bodyreference), required: false);
            var __workflow_bodyreferenceType = bodyreferenceType == null ? null : WorkflowExpression.Compile(bodyreferenceType);
            WorkflowExpression.Validate(__workflow_bodyreferenceType, nameof(bodyreferenceType), required: false);
            var __workflow_bodyseperatorLine = bodyseperatorLine == null ? null : WorkflowExpression.Compile(bodyseperatorLine);
            WorkflowExpression.Validate(__workflow_bodyseperatorLine, nameof(bodyseperatorLine), required: false);
            var __workflow_bodyudAddressType = bodyudAddressType == null ? null : WorkflowExpression.Compile(bodyudAddressType);
            WorkflowExpression.Validate(__workflow_bodyudAddressType, nameof(bodyudAddressType), required: false);
            var __workflow_bodyudCity = bodyudCity == null ? null : WorkflowExpression.Compile(bodyudCity);
            WorkflowExpression.Validate(__workflow_bodyudCity, nameof(bodyudCity), required: false);
            var __workflow_bodyudName = bodyudName == null ? null : WorkflowExpression.Compile(bodyudName);
            WorkflowExpression.Validate(__workflow_bodyudName, nameof(bodyudName), required: false);
            var __workflow_bodyudPostalCode = bodyudPostalCode == null ? null : WorkflowExpression.Compile(bodyudPostalCode);
            WorkflowExpression.Validate(__workflow_bodyudPostalCode, nameof(bodyudPostalCode), required: false);
            var __workflow_bodyudStreetOrAddressLine1 = bodyudStreetOrAddressLine1 == null ? null : WorkflowExpression.Compile(bodyudStreetOrAddressLine1);
            WorkflowExpression.Validate(__workflow_bodyudStreetOrAddressLine1, nameof(bodyudStreetOrAddressLine1), required: false);
            var __workflow_bodyudStreetOrAddressLine2 = bodyudStreetOrAddressLine2 == null ? null : WorkflowExpression.Compile(bodyudStreetOrAddressLine2);
            WorkflowExpression.Validate(__workflow_bodyudStreetOrAddressLine2, nameof(bodyudStreetOrAddressLine2), required: false);
            var __workflow_bodyunstructuredMessage = bodyunstructuredMessage == null ? null : WorkflowExpression.Compile(bodyunstructuredMessage);
            WorkflowExpression.Validate(__workflow_bodyunstructuredMessage, nameof(bodyunstructuredMessage), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/CreateSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyamount != null)
                {
                    body["amount"] = ExpressionConverter.ConvertO(__workflow_bodyamount);
                    bodypropCount++;
                }

                if (__workflow_bodyav1Parameters != null)
                {
                    body["av1Parameters"] = ExpressionConverter.ConvertO(__workflow_bodyav1Parameters);
                    bodypropCount++;
                }

                if (__workflow_bodyav2Parameters != null)
                {
                    body["av2Parameters"] = ExpressionConverter.ConvertO(__workflow_bodyav2Parameters);
                    bodypropCount++;
                }

                if (__workflow_bodybillingInfo != null)
                {
                    body["billingInfo"] = ExpressionConverter.ConvertO(__workflow_bodybillingInfo);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crAddressType"] = ExpressionConverter.ConvertO(__workflow_bodycrAddressType);
                if (__workflow_bodycrCity != null)
                {
                    body["crCity"] = ExpressionConverter.ConvertO(__workflow_bodycrCity);
                    bodypropCount++;
                }

                bodypropCount++;
                body["crName"] = ExpressionConverter.ConvertO(__workflow_bodycrName);
                if (__workflow_bodycrPostalCode != null)
                {
                    body["crPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodycrPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodycrStreetOrAddressLine1 != null)
                {
                    body["crStreetOrAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodycrStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodycrStreetOrAddressLine2 != null)
                {
                    body["crStreetOrAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodycrStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodycurrency != null)
                {
                    if (__workflow_bodycurrency != null)
                    {
                        body["currency"] = ExpressionConverter.ConvertO(__workflow_bodycurrency);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["currency"] = "CHF";
                    bodypropCount++;
                }

                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["iban"] = ExpressionConverter.ConvertO(__workflow_bodyiban);
                if (__workflow_bodylanguageType != null)
                {
                    if (__workflow_bodylanguageType != null)
                    {
                        body["languageType"] = ExpressionConverter.ConvertO(__workflow_bodylanguageType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["languageType"] = "English";
                    bodypropCount++;
                }

                if (__workflow_bodyreference != null)
                {
                    body["reference"] = ExpressionConverter.ConvertO(__workflow_bodyreference);
                    bodypropCount++;
                }

                if (__workflow_bodyreferenceType != null)
                {
                    if (__workflow_bodyreferenceType != null)
                    {
                        body["referenceType"] = ExpressionConverter.ConvertO(__workflow_bodyreferenceType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["referenceType"] = "QRR";
                    bodypropCount++;
                }

                if (__workflow_bodyseperatorLine != null)
                {
                    if (__workflow_bodyseperatorLine != null)
                    {
                        body["seperatorLine"] = ExpressionConverter.ConvertO(__workflow_bodyseperatorLine);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["seperatorLine"] = "LineWithScissor";
                    bodypropCount++;
                }

                if (__workflow_bodyudAddressType != null)
                {
                    if (__workflow_bodyudAddressType != null)
                    {
                        body["udAddressType"] = ExpressionConverter.ConvertO(__workflow_bodyudAddressType);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["udAddressType"] = "S";
                    bodypropCount++;
                }

                if (__workflow_bodyudCity != null)
                {
                    body["udCity"] = ExpressionConverter.ConvertO(__workflow_bodyudCity);
                    bodypropCount++;
                }

                if (__workflow_bodyudName != null)
                {
                    body["udName"] = ExpressionConverter.ConvertO(__workflow_bodyudName);
                    bodypropCount++;
                }

                if (__workflow_bodyudPostalCode != null)
                {
                    body["udPostalCode"] = ExpressionConverter.ConvertO(__workflow_bodyudPostalCode);
                    bodypropCount++;
                }

                if (__workflow_bodyudStreetOrAddressLine1 != null)
                {
                    body["udStreetOrAddressLine1"] = ExpressionConverter.ConvertO(__workflow_bodyudStreetOrAddressLine1);
                    bodypropCount++;
                }

                if (__workflow_bodyudStreetOrAddressLine2 != null)
                {
                    body["udStreetOrAddressLine2"] = ExpressionConverter.ConvertO(__workflow_bodyudStreetOrAddressLine2);
                    bodypropCount++;
                }

                if (__workflow_bodyunstructuredMessage != null)
                {
                    body["unstructuredMessage"] = ExpressionConverter.ConvertO(__workflow_bodyunstructuredMessage);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IWorkflowAction CustomAPI(Expression<Func<string>> featurePath, Expression<Func<string>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_featurePath = featurePath == null ? null : WorkflowExpression.Compile(featurePath);
            WorkflowExpression.Validate(__workflow_featurePath, nameof(featurePath), required: true);
            var __workflow_contentType = contentType == null ? null : WorkflowExpression.Compile(contentType);
            WorkflowExpression.Validate(__workflow_contentType, nameof(contentType), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v2/FlowV2/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_featurePath, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["Content-type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesV1Response> ReadBarcodes(Expression<Func<string>> bodydocContent, Expression<Func<bodybarcodeTypeInputItem[]>> bodybarcodeType, Expression<Func<string>> bodydocumentname = null, Expression<Func<string>> bodypages = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodybarcodeType = bodybarcodeType == null ? null : WorkflowExpression.Compile(bodybarcodeType);
            WorkflowExpression.Validate(__workflow_bodybarcodeType, nameof(bodybarcodeType), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodypages = bodypages == null ? null : WorkflowExpression.Compile(bodypages);
            WorkflowExpression.Validate(__workflow_bodypages, nameof(bodypages), required: false);
            return new DeferredBodyAction<ReadBarcodesV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["barcodeType"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeType);
                if (__workflow_bodypages != null)
                {
                    if (__workflow_bodypages != null)
                    {
                        body["pages"] = ExpressionConverter.ConvertO(__workflow_bodypages);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pages"] = "all";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadBarcodesV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<ReadBarcodesFromImageV1Response> ReadBarcodesFromImage(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<ReadBarcodesFromImageV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadBarcodesFromImage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadBarcodesFromImageV1Response>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<string> ReadSwissQrBill(Expression<Func<string>> bodydocContent, Expression<Func<string>> bodydocumentname = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/v2/FlowV2/ReadSwissQrBill";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pdf4mebarcode")]
        public IBodyWorkflowAction<SplitDocByBarcodeV1Response> SplitDocByBarcode(Expression<Func<string>> bodydocContent, Expression<Func<bodybarcodeFilterInput>> bodybarcodeFilter, Expression<Func<string>> bodybarcodeString, Expression<Func<bodybarcodeTypeInput>> bodybarcodeType, Expression<Func<bodysplitBarcodePageInput>> bodysplitBarcodePage, Expression<Func<string>> bodydocumentname = null, Expression<Func<bool>> bodycombinePagesWithSameConsecutiveBarcodes = null, Expression<Func<string>> bodypdfRenderDpi = null, Expression<Func<bool>> bodyisAsync = null)
        {
            var __workflow_bodydocContent = bodydocContent == null ? null : WorkflowExpression.Compile(bodydocContent);
            WorkflowExpression.Validate(__workflow_bodydocContent, nameof(bodydocContent), required: true);
            var __workflow_bodybarcodeFilter = bodybarcodeFilter == null ? null : WorkflowExpression.Compile(bodybarcodeFilter);
            WorkflowExpression.Validate(__workflow_bodybarcodeFilter, nameof(bodybarcodeFilter), required: true);
            var __workflow_bodybarcodeString = bodybarcodeString == null ? null : WorkflowExpression.Compile(bodybarcodeString);
            WorkflowExpression.Validate(__workflow_bodybarcodeString, nameof(bodybarcodeString), required: true);
            var __workflow_bodybarcodeType = bodybarcodeType == null ? null : WorkflowExpression.Compile(bodybarcodeType);
            WorkflowExpression.Validate(__workflow_bodybarcodeType, nameof(bodybarcodeType), required: true);
            var __workflow_bodysplitBarcodePage = bodysplitBarcodePage == null ? null : WorkflowExpression.Compile(bodysplitBarcodePage);
            WorkflowExpression.Validate(__workflow_bodysplitBarcodePage, nameof(bodysplitBarcodePage), required: true);
            var __workflow_bodydocumentname = bodydocumentname == null ? null : WorkflowExpression.Compile(bodydocumentname);
            WorkflowExpression.Validate(__workflow_bodydocumentname, nameof(bodydocumentname), required: false);
            var __workflow_bodycombinePagesWithSameConsecutiveBarcodes = bodycombinePagesWithSameConsecutiveBarcodes == null ? null : WorkflowExpression.Compile(bodycombinePagesWithSameConsecutiveBarcodes);
            WorkflowExpression.Validate(__workflow_bodycombinePagesWithSameConsecutiveBarcodes, nameof(bodycombinePagesWithSameConsecutiveBarcodes), required: false);
            var __workflow_bodypdfRenderDpi = bodypdfRenderDpi == null ? null : WorkflowExpression.Compile(bodypdfRenderDpi);
            WorkflowExpression.Validate(__workflow_bodypdfRenderDpi, nameof(bodypdfRenderDpi), required: false);
            var __workflow_bodyisAsync = bodyisAsync == null ? null : WorkflowExpression.Compile(bodyisAsync);
            WorkflowExpression.Validate(__workflow_bodyisAsync, nameof(bodyisAsync), required: false);
            return new DeferredBodyAction<SplitDocByBarcodeV1Response>(() =>
            {
                var apiCallPath = "/v2/FlowV2/SplitPdfByBarcode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["docContent"] = ExpressionConverter.ConvertO(__workflow_bodydocContent);
                var documentObject = new JObject();
                var documentObjectpropCount = 0;
                if (__workflow_bodydocumentname != null)
                {
                    documentObject["Name"] = ExpressionConverter.ConvertO(__workflow_bodydocumentname);
                    documentObjectpropCount++;
                }

                if (documentObjectpropCount > 0)
                {
                    body["document"] = documentObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["barcodeFilter"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeFilter);
                bodypropCount++;
                body["barcodeString"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeString);
                bodypropCount++;
                body["barcodeType"] = ExpressionConverter.ConvertO(__workflow_bodybarcodeType);
                bodypropCount++;
                body["splitBarcodePage"] = ExpressionConverter.ConvertO(__workflow_bodysplitBarcodePage);
                if (__workflow_bodycombinePagesWithSameConsecutiveBarcodes != null)
                {
                    if (__workflow_bodycombinePagesWithSameConsecutiveBarcodes != null)
                    {
                        body["combinePagesWithSameConsecutiveBarcodes"] = ExpressionConverter.ConvertO(__workflow_bodycombinePagesWithSameConsecutiveBarcodes);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["combinePagesWithSameConsecutiveBarcodes"] = false;
                    bodypropCount++;
                }

                if (__workflow_bodypdfRenderDpi != null)
                {
                    if (__workflow_bodypdfRenderDpi != null)
                    {
                        body["pdfRenderDpi"] = ExpressionConverter.ConvertO(__workflow_bodypdfRenderDpi);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["pdfRenderDpi"] = "150";
                    bodypropCount++;
                }

                if (__workflow_bodyisAsync != null)
                {
                    if (__workflow_bodyisAsync != null)
                    {
                        body["isAsync"] = ExpressionConverter.ConvertO(__workflow_bodyisAsync);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["isAsync"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<SplitDocByBarcodeV1Response>(callPayload);
            });
        }
    }

    public class Pdf4mebarcodeTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodybarcodeTypeInput
    {
        [EnumMember(Value = "any")]
        Any,
        [EnumMember(Value = "datamatrix")]
        Datamatrix,
        [EnumMember(Value = "qrcode")]
        Qrcode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyalignXInput
    {
        Left,
        Center,
        Right
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyalignYInput
    {
        Top,
        Middle,
        Bottom
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyepcQrCodeActionversionInput
    {
        V1,
        V2
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyepcQrCodeActioncharacterSetInput
    {
        UTF8,
        [EnumMember(Value = "ISO8859_1")]
        ISO88591,
        [EnumMember(Value = "ISO8859_2")]
        ISO88592,
        [EnumMember(Value = "ISO8859_4")]
        ISO88594,
        [EnumMember(Value = "ISO8859_5")]
        ISO88595,
        [EnumMember(Value = "ISO8859_7")]
        ISO88597,
        [EnumMember(Value = "ISO8859_10")]
        ISO885910,
        [EnumMember(Value = "ISO8859_15")]
        ISO885915
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycrAddressTypeInput
    {
        S,
        K
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodycurrencyInput
    {
        CHF,
        EUR
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylanguageTypeInput
    {
        German,
        French,
        Italian,
        English
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyreferenceTypeInput
    {
        QRR,
        SCOR,
        NON
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyseperatorLineInput
    {
        LineWithScissor,
        Line,
        None
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyudAddressTypeInput
    {
        S,
        K
    }

    public class ReadBarcodesV1Response
    {
        [JsonProperty("barcodes")]
        public ReadBarcodesV1ResponseBarcodesTypeItem[] Barcodes { get; set; }
    }

    public class ReadBarcodesV1ResponseBarcodesTypeItem
    {
        [JsonProperty("barcodeType")]
        public string BarcodeType { get; set; }
        public string Value { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodybarcodeTypeInputItem
    {
        All,
        QrCode,
        Datamatrix,
        Code128,
        Code39,
        Pdf417,
        Code93
    }

    public class ReadBarcodesFromImageV1Response
    {
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }

    public class SplitDocByBarcodeV1Response
    {
        [JsonProperty("splitedDocuments")]
        public SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem[] SplitedDocuments { get; set; }
    }

    public class SplitDocByBarcodeV1ResponseSplitedDocumentsTypeItem
    {
        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("barcodeText")]
        public string BarcodeText { get; set; }

        [JsonProperty("streamFile")]
        public string StreamFile { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodybarcodeFilterInput
    {
        [EnumMember(Value = "startsWith")]
        StartsWith,
        [EnumMember(Value = "endsWith")]
        EndsWith,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "exact")]
        Exact
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysplitBarcodePageInput
    {
        [EnumMember(Value = "before")]
        Before,
        [EnumMember(Value = "after")]
        After,
        [EnumMember(Value = "remove")]
        Remove
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pdf4mebarcode;

    public partial class WorkflowManagedActions
    {
        public Pdf4mebarcodeActions Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Pdf4mebarcodeTriggers Pdf4mebarcode(string connectionId) => new Pdf4mebarcodeTriggers(connectionId);
    }
}
