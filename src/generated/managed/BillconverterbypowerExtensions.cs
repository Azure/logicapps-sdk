//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Billconverterbypower
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BillconverterbypowerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf> T10A002AV01CV01ExtractXmlFromInvoicePdf([WorkflowExpression] Func<string> dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF = null)
        {
            SourceExpression.Validate(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF, nameof(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A002_AV01_CV01_ExtractXmlFromInvoicePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf = new JObject();
                var dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount = 0;
                if (dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF != null)
                {
                    dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf["invoicePdf"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF);
                    dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount++;
                }

                if (dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf> T10A003AV01CV01ConvertXmlInvoiceToPdf([WorkflowExpression] Func<string> dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML = null, [WorkflowExpression] Func<string> dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType = null)
        {
            SourceExpression.Validate(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML, nameof(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML), required: false);
            SourceExpression.Validate(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType, nameof(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A003_AV01_CV01_ConvertXmlInvoiceToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf = new JObject();
                var dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount = 0;
                if (dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML != null)
                {
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf["xml"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML);
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount++;
                }

                if (dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType != null)
                {
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf["type"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType);
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount++;
                }

                if (dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf> T10A001AV02CV02ConvertInvoiceToZugferdPdf([WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote = null, [WorkflowExpression] Func<DtoPrecedingInvoice[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate = null, [WorkflowExpression] Func<DtoSkontoTerm[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms = null, [WorkflowExpression] Func<double> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason = null, [WorkflowExpression] Func<string> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode = null, [WorkflowExpression] Func<DtoInvoiceLineV2[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems = null, [WorkflowExpression] Func<DtoAllowanceCharge[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts = null, [WorkflowExpression] Func<DtoAllowanceCharge[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges = null, [WorkflowExpression] Func<DtoAttachment[]> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments = null, [WorkflowExpression] Func<bool> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments = null)
        {
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments), required: false);
            SourceExpression.Validate(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A001_AV02_CV02_ConvertInvoiceToZugferdPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf = new JObject();
                var dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount = 0;
                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoicePdf"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceNumber"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceDate"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceTypeCode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryDate"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["servicePeriodStart"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["servicePeriodEnd"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["currencyCode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["businessProcess"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerReference"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerOrderNumber"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["contractReference"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["projectReference"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceNote"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["precedingInvoices"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerName"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerIdentifier"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerVatId"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerTaxNumber"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerLegalRegistrationId"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerStreet"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerPostcode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerCity"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerCountry"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerEmail"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactName"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactPhone"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactEmail"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerName"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerVatId"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerStreet"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerPostcode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerCity"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerCountry"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerEmail"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerContactName"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerContactEmail"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryName"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryStreet"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryPostcode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryCity"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryCountry"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["iban"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["bic"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentRecipient"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentInfo"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentMeansCode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentTerm"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentDueDate"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["skontoTerms"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["prepaidAmount"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["taxExemptionReason"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["taxExemptionReasonCode"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceLines"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["documentAllowances"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["documentCharges"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["attachments"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["autoAdjustAttachments"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan> T10A004AV01CV02ExtractInvoiceDataFromScan([WorkflowExpression] Func<string> dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile = null, [WorkflowExpression] Func<string> dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions = null)
        {
            SourceExpression.Validate(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile, nameof(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile), required: false);
            SourceExpression.Validate(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions, nameof(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A004_AV01_CV02_ExtractInvoiceDataFromScan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan = new JObject();
                var dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount = 0;
                if (dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile != null)
                {
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan["invoiceFile"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile);
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount++;
                }

                if (dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions != null)
                {
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan["additionalInstructions"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions);
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount++;
                }

                if (dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A005AV01CV02ValidateIban> T10A005AV01CV02ValidateIban([WorkflowExpression] Func<string> dtoRequestT10A005AV01CV02ValidateIbaniBAN)
        {
            SourceExpression.Validate(dtoRequestT10A005AV01CV02ValidateIbaniBAN, nameof(dtoRequestT10A005AV01CV02ValidateIbaniBAN), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A005_AV01_CV02_ValidateIban";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A005AV01CV02ValidateIban = new JObject();
                var dtoRequestT10A005AV01CV02ValidateIbanpropCount = 0;
                dtoRequestT10A005AV01CV02ValidateIbanpropCount++;
                dtoRequestT10A005AV01CV02ValidateIban["iban"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A005AV01CV02ValidateIbaniBAN);
                if (dtoRequestT10A005AV01CV02ValidateIbanpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A005AV01CV02ValidateIban;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A005AV01CV02ValidateIban>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A006AV01CV02ValidateVatId> T10A006AV01CV02ValidateVatId([WorkflowExpression] Func<string> dtoRequestT10A006AV01CV02ValidateVatIdvATId, [WorkflowExpression] Func<string> dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId = null)
        {
            SourceExpression.Validate(dtoRequestT10A006AV01CV02ValidateVatIdvATId, nameof(dtoRequestT10A006AV01CV02ValidateVatIdvATId), required: true);
            SourceExpression.Validate(dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId, nameof(dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A006_AV01_CV02_ValidateVatId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A006AV01CV02ValidateVatId = new JObject();
                var dtoRequestT10A006AV01CV02ValidateVatIdpropCount = 0;
                dtoRequestT10A006AV01CV02ValidateVatIdpropCount++;
                dtoRequestT10A006AV01CV02ValidateVatId["vatId"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A006AV01CV02ValidateVatIdvATId);
                if (dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId != null)
                {
                    dtoRequestT10A006AV01CV02ValidateVatId["requesterVatId"] = SourceExpressionConverter.ConvertToken(dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId);
                    dtoRequestT10A006AV01CV02ValidateVatIdpropCount++;
                }

                if (dtoRequestT10A006AV01CV02ValidateVatIdpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A006AV01CV02ValidateVatId;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DtoResponseT10A006AV01CV02ValidateVatId>(BuildSourceInput);
        }
    }

    public class BillconverterbypowerTriggers([ConnectionName] string connectionId)
    {
    }

    public class DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf
    {
        [JsonProperty("xml")]
        public string XML { get; set; }
    }

    public class DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf
    {
        [JsonProperty("pdf")]
        public string VisualizedInvoicePDF { get; set; }
    }

    public class DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf
    {
        [JsonProperty("zugferdPdf")]
        public string ZUGFeRDPDF { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoPrecedingInvoice
    {
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }
    }

    public class DtoSkontoTerm
    {
        [JsonProperty("days")]
        public int Days { get; set; }

        [JsonProperty("percent")]
        public double Percent { get; set; }

        [JsonProperty("baseAmount")]
        public double BaseAmount { get; set; }
    }

    public class DtoInvoiceLineV2
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("categoryCode")]
        public string TaxCategoryCode { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class DtoAllowanceCharge
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("categoryCode")]
        public string TaxCategoryCode { get; set; }

        [JsonProperty("taxType")]
        public string TaxType { get; set; }
    }

    public class DtoAttachment
    {
        [JsonProperty("content")]
        public string FileContent { get; set; }

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan
    {
        [JsonProperty("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonProperty("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonProperty("deliveryDate")]
        public string DeliveryDate { get; set; }

        [JsonProperty("currencyCode")]
        public string Currency { get; set; }

        [JsonProperty("buyerReference")]
        public string BuyerReference { get; set; }

        [JsonProperty("buyerOrderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty("sellerName")]
        public string SellerName { get; set; }

        [JsonProperty("sellerStreet")]
        public string SellerStreet { get; set; }

        [JsonProperty("sellerPostcode")]
        public string SellerPostcode { get; set; }

        [JsonProperty("sellerCity")]
        public string SellerCity { get; set; }

        [JsonProperty("sellerCountry")]
        public string SellerCountry { get; set; }

        [JsonProperty("sellerVatId")]
        public string SellerVATID { get; set; }

        [JsonProperty("sellerEmail")]
        public string SellerEmail { get; set; }

        [JsonProperty("buyerName")]
        public string BuyerName { get; set; }

        [JsonProperty("buyerStreet")]
        public string BuyerStreet { get; set; }

        [JsonProperty("buyerPostcode")]
        public string BuyerPostcode { get; set; }

        [JsonProperty("buyerCity")]
        public string BuyerCity { get; set; }

        [JsonProperty("buyerCountry")]
        public string BuyerCountry { get; set; }

        [JsonProperty("buyerVatId")]
        public string BuyerVATID { get; set; }

        [JsonProperty("iban")]
        public string IBAN { get; set; }

        [JsonProperty("bic")]
        public string BIC { get; set; }

        [JsonProperty("paymentRecipient")]
        public string PaymentRecipient { get; set; }

        [JsonProperty("paymentTerm")]
        public string PaymentTerm { get; set; }

        [JsonProperty("paymentDueDate")]
        public string PaymentDueDate { get; set; }

        [JsonProperty("totalNetAmount")]
        public double TotalNetAmount { get; set; }

        [JsonProperty("totalVatAmount")]
        public double TotalVATAmount { get; set; }

        [JsonProperty("totalGrossAmount")]
        public double TotalGrossAmount { get; set; }

        [JsonProperty("invoiceLines")]
        public DtoRecognizedInvoiceLine[] InvoiceItems { get; set; }

        [JsonProperty("isReadyForEInvoice")]
        public bool ReadyForEInvoice { get; set; }

        [JsonProperty("missingRequiredFields")]
        public string[] MissingRequiredFields { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoRecognizedInvoiceLine
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unitCode")]
        public string UnitCode { get; set; }

        [JsonProperty("unitPrice")]
        public double UnitPrice { get; set; }

        [JsonProperty("vatPercent")]
        public double VATPercent { get; set; }

        [JsonProperty("lineNetAmount")]
        public double LineNetAmount { get; set; }
    }

    public class DtoResponseT10A005AV01CV02ValidateIban
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("compactIban")]
        public string CompactIBAN { get; set; }

        [JsonProperty("formattedIban")]
        public string FormattedIBAN { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("isSepaCountry")]
        public bool IsSEPACountry { get; set; }

        [JsonProperty("bankName")]
        public string BankName { get; set; }

        [JsonProperty("bic")]
        public string BICSWIFTCode { get; set; }

        [JsonProperty("bankCity")]
        public string BankCity { get; set; }

        [JsonProperty("bankPostcode")]
        public string BankPostalCode { get; set; }

        [JsonProperty("bankCode")]
        public string BankCode { get; set; }

        [JsonProperty("branchCode")]
        public string BranchCode { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonProperty("bban")]
        public string BBAN { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }

    public class DtoResponseT10A006AV01CV02ValidateVatId
    {
        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("isFormatValid")]
        public bool IsFormatValid { get; set; }

        [JsonProperty("validationMessage")]
        public string ValidationMessage { get; set; }

        [JsonProperty("compactVatId")]
        public string CompactVATID { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("countryName")]
        public string CountryName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("companyAddress")]
        public string CompanyAddress { get; set; }

        [JsonProperty("consultationNumber")]
        public string ConsultationNumber { get; set; }

        [JsonProperty("requestDate")]
        public string RequestDate { get; set; }

        [JsonProperty("vatNumber")]
        public string VATNumber { get; set; }

        [JsonProperty("notes")]
        public string[] Notes { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Billconverterbypower;

    public partial class WorkflowManagedActions
    {
        public BillconverterbypowerActions Billconverterbypower(string connectionId) => new BillconverterbypowerActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BillconverterbypowerTriggers Billconverterbypower(string connectionId) => new BillconverterbypowerTriggers(connectionId);
    }
}