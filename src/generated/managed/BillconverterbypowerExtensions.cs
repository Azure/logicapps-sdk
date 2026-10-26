//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Billconverterbypower
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BillconverterbypowerActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf, ApiConnectionActionConfiguration> T10A002AV01CV01ExtractXmlFromInvoicePdf(Expression<Func<string>> dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF = null)
        {
            var __workflow_dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF = WorkflowExpression.Compile(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF, nameof(dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF), required: false);
            return new DeferredBodyAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A002_AV01_CV01_ExtractXmlFromInvoicePdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf = new JObject();
                var dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount = 0;
                if (__workflow_dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF != null)
                {
                    dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf["invoicePdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfinvoicePDF);
                    dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount++;
                }

                if (dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A002AV01CV01ExtractXmlFromInvoicePdf;
                }

                return new ApiConnectionAction<DtoResponseT10A002AV01CV01ExtractXmlFromInvoicePdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf, ApiConnectionActionConfiguration> T10A003AV01CV01ConvertXmlInvoiceToPdf(Expression<Func<string>> dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML = null, Expression<Func<string>> dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType = null)
        {
            var __workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML = WorkflowExpression.Compile(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML, nameof(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML), required: false);
            var __workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType = WorkflowExpression.Compile(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType, nameof(dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType), required: false);
            return new DeferredBodyAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V01/T10_A003_AV01_CV01_ConvertXmlInvoiceToPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf = new JObject();
                var dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount = 0;
                if (__workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML != null)
                {
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf["xml"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceXML);
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType != null)
                {
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf["type"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfinvoiceType);
                    dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount++;
                }

                if (dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A003AV01CV01ConvertXmlInvoiceToPdf;
                }

                return new ApiConnectionAction<DtoResponseT10A003AV01CV01ConvertXmlInvoiceToPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf, ApiConnectionActionConfiguration> T10A001AV02CV02ConvertInvoiceToZugferdPdf(Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote = null, Expression<Func<DtoPrecedingInvoice[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate = null, Expression<Func<DtoSkontoTerm[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms = null, Expression<Func<double>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason = null, Expression<Func<string>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode = null, Expression<Func<DtoInvoiceLineV2[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems = null, Expression<Func<DtoAllowanceCharge[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts = null, Expression<Func<DtoAllowanceCharge[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges = null, Expression<Func<DtoAttachment[]>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments = null, Expression<Func<bool>> dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments = null)
        {
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments), required: false);
            var __workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments = WorkflowExpression.Compile(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments, nameof(dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments), required: false);
            return new DeferredBodyAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A001_AV02_CV02_ConvertInvoiceToZugferdPdf";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf = new JObject();
                var dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount = 0;
                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoicePdf"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoicePDF);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceNumber"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceDate"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceTypeCode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceType);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryDate"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["servicePeriodStart"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodStart);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["servicePeriodEnd"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfservicePeriodEnd);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["currencyCode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcurrency);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["businessProcess"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbusinessProcess);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerReference"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerOrderNumber"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdforderNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["contractReference"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcontractReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["projectReference"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprojectReference);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceNote"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceNote);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["precedingInvoices"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprecedingInvoices);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerIdentifier"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerIdentifier);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerVatId"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerVATId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerTaxNumber"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerTaxNumber);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerLegalRegistrationId"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerRegistrationId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerStreet"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerPostcode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerCity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerCountry"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerEmail"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactPhone"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactPhone);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["sellerContactEmail"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfsellerContactEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerVatId"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerVATId);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerStreet"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerPostcode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerCity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerCountry"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerEmail"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerContactName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["buyerContactEmail"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbuyerContactEmail);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryName"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryName);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryStreet"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryStreet);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryPostcode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryPostcode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryCity"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCity);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["deliveryCountry"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdeliveryCountry);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["iban"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfiBAN);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["bic"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfbIC);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentRecipient"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentRecipient);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentInfo"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentInfo);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentMeansCode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentMeans);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentTerm"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentTerm);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["paymentDueDate"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpaymentDueDate);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["skontoTerms"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfcashDiscountTerms);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["prepaidAmount"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfprepaidAmount);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["taxExemptionReason"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReason);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["taxExemptionReasonCode"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdftaxExemptionReasonCode);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["invoiceLines"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfinvoiceItems);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["documentAllowances"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentDiscounts);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["documentCharges"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfdocumentCharges);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["attachments"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfattachments);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments != null)
                {
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf["autoAdjustAttachments"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfautoAdjustAttachments);
                    dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount++;
                }

                if (dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdfpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A001AV02CV02ConvertInvoiceToZugferdPdf;
                }

                return new ApiConnectionAction<DtoResponseT10A001AV02CV02ConvertInvoiceToZugferdPdf>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan, ApiConnectionActionConfiguration> T10A004AV01CV02ExtractInvoiceDataFromScan(Expression<Func<string>> dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile = null, Expression<Func<string>> dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions = null)
        {
            var __workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile = WorkflowExpression.Compile(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile, nameof(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile), required: false);
            var __workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions = WorkflowExpression.Compile(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions, nameof(dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions), required: false);
            return new DeferredBodyAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A004_AV01_CV02_ExtractInvoiceDataFromScan";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan = new JObject();
                var dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount = 0;
                if (__workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile != null)
                {
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan["invoiceFile"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScaninvoiceFile);
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount++;
                }

                if (__workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions != null)
                {
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan["additionalInstructions"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanadditionalInstructions);
                    dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount++;
                }

                if (dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScanpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A004AV01CV02ExtractInvoiceDataFromScan;
                }

                return new ApiConnectionAction<DtoResponseT10A004AV01CV02ExtractInvoiceDataFromScan>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A005AV01CV02ValidateIban, ApiConnectionActionConfiguration> T10A005AV01CV02ValidateIban(Expression<Func<string>> dtoRequestT10A005AV01CV02ValidateIbaniBAN)
        {
            var __workflow_dtoRequestT10A005AV01CV02ValidateIbaniBAN = WorkflowExpression.Compile(dtoRequestT10A005AV01CV02ValidateIbaniBAN, nameof(dtoRequestT10A005AV01CV02ValidateIbaniBAN), required: true);
            return new DeferredBodyAction<DtoResponseT10A005AV01CV02ValidateIban, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A005_AV01_CV02_ValidateIban";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A005AV01CV02ValidateIban = new JObject();
                var dtoRequestT10A005AV01CV02ValidateIbanpropCount = 0;
                dtoRequestT10A005AV01CV02ValidateIbanpropCount++;
                dtoRequestT10A005AV01CV02ValidateIban["iban"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A005AV01CV02ValidateIbaniBAN);
                if (dtoRequestT10A005AV01CV02ValidateIbanpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A005AV01CV02ValidateIban;
                }

                return new ApiConnectionAction<DtoResponseT10A005AV01CV02ValidateIban>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "billconverterbypower")]
        public IBodyWorkflowAction<DtoResponseT10A006AV01CV02ValidateVatId, ApiConnectionActionConfiguration> T10A006AV01CV02ValidateVatId(Expression<Func<string>> dtoRequestT10A006AV01CV02ValidateVatIdvATId, Expression<Func<string>> dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId = null)
        {
            var __workflow_dtoRequestT10A006AV01CV02ValidateVatIdvATId = WorkflowExpression.Compile(dtoRequestT10A006AV01CV02ValidateVatIdvATId, nameof(dtoRequestT10A006AV01CV02ValidateVatIdvATId), required: true);
            var __workflow_dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId = WorkflowExpression.Compile(dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId, nameof(dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId), required: false);
            return new DeferredBodyAction<DtoResponseT10A006AV01CV02ValidateVatId, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/api/T10_Bill/V02/T10_A006_AV01_CV02_ValidateVatId";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var dtoRequestT10A006AV01CV02ValidateVatId = new JObject();
                var dtoRequestT10A006AV01CV02ValidateVatIdpropCount = 0;
                dtoRequestT10A006AV01CV02ValidateVatIdpropCount++;
                dtoRequestT10A006AV01CV02ValidateVatId["vatId"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A006AV01CV02ValidateVatIdvATId);
                if (__workflow_dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId != null)
                {
                    dtoRequestT10A006AV01CV02ValidateVatId["requesterVatId"] = ExpressionConverter.ConvertO(__workflow_dtoRequestT10A006AV01CV02ValidateVatIdyourCompanyVATId);
                    dtoRequestT10A006AV01CV02ValidateVatIdpropCount++;
                }

                if (dtoRequestT10A006AV01CV02ValidateVatIdpropCount > 0)
                {
                    callPayload.Body = dtoRequestT10A006AV01CV02ValidateVatId;
                }

                return new ApiConnectionAction<DtoResponseT10A006AV01CV02ValidateVatId>(callPayload);
            });
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
        public string SellerVATId { get; set; }

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
        public string BuyerVATId { get; set; }

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
        public string CompactVATId { get; set; }

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