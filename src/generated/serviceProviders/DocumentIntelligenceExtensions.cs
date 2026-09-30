//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DocumentIntelligence
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Newtonsoft.Json.Linq;

    public class DocumentIntelligenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "documentIntelligence")]
        public IBodyWorkflowAction<AnalyzeDocumentOutput> AnalyzeDocument([WorkflowExpression] Func<AnalyzeDocumentInputModelIdType> modelId, [WorkflowExpression] Func<object> modelIdInputs = null)
        {
            var serviceProviderParameters = new JObject();
            serviceProviderParameters["modelId"] = ExpressionConverter.ConvertO(modelId);
            if (modelIdInputs != null)
            {
                serviceProviderParameters["modelIdInputs"] = ExpressionConverter.ConvertO(modelIdInputs);
            }

            var serviceProviderInput = new ServiceProviderOperationInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/documentIntelligence", operationId: "analyzeDocument", connectionName: connectionId),
                Parameters = serviceProviderParameters
            };
            return new ServiceProviderAction<AnalyzeDocumentOutput>(serviceProviderInput);
        }
    }

    public class AnalyzeDocumentOutput
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AnalyzeDocumentInputModelIdType
    {
        [EnumMember(Value = "prebuilt-read")]
        PrebuiltRead,
        [EnumMember(Value = "prebuilt-layout")]
        PrebuiltLayout,
        [EnumMember(Value = "prebuilt-contract")]
        PrebuiltContract,
        [EnumMember(Value = "prebuilt-healthInsuranceCard.us")]
        PrebuiltHealthInsuranceCardUs,
        [EnumMember(Value = "prebuilt-idDocument")]
        PrebuiltIdDocument,
        [EnumMember(Value = "prebuilt-invoice")]
        PrebuiltInvoice,
        [EnumMember(Value = "prebuilt-receipt")]
        PrebuiltReceipt,
        [EnumMember(Value = "prebuilt-marriageCertificate.us")]
        PrebuiltMarriageCertificateUs,
        [EnumMember(Value = "prebuilt-creditCard")]
        PrebuiltCreditCard,
        [EnumMember(Value = "prebuilt-check.us")]
        PrebuiltCheckUs,
        [EnumMember(Value = "prebuilt-payStub.us")]
        PrebuiltPayStubUs,
        [EnumMember(Value = "prebuilt-bankStatement")]
        PrebuiltBankStatement,
        [EnumMember(Value = "prebuilt-mortgage.us.1003")]
        PrebuiltMortgageUs1003,
        [EnumMember(Value = "prebuilt-mortgage.us.1004")]
        PrebuiltMortgageUs1004,
        [EnumMember(Value = "prebuilt-mortgage.us.1005")]
        PrebuiltMortgageUs1005,
        [EnumMember(Value = "prebuilt-mortgage.us.1008")]
        PrebuiltMortgageUs1008,
        [EnumMember(Value = "prebuilt-mortgage.us.closingDisclosure")]
        PrebuiltMortgageUsClosingDisclosure,
        [EnumMember(Value = "prebuilt-tax.us")]
        PrebuiltTaxUs,
        [EnumMember(Value = "prebuilt-tax.us.w2")]
        PrebuiltTaxUsW2,
        [EnumMember(Value = "prebuilt-tax.us.w4")]
        PrebuiltTaxUsW4,
        [EnumMember(Value = "prebuilt-tax.us.1040")]
        PrebuiltTaxUs1040,
        [EnumMember(Value = "prebuilt-tax.us.1095A")]
        PrebuiltTaxUs1095A,
        [EnumMember(Value = "prebuilt-tax.us.1095C")]
        PrebuiltTaxUs1095C,
        [EnumMember(Value = "prebuilt-tax.us.1098")]
        PrebuiltTaxUs1098,
        [EnumMember(Value = "prebuilt-tax.us.1098E")]
        PrebuiltTaxUs1098E,
        [EnumMember(Value = "prebuilt-tax.us.1098T")]
        PrebuiltTaxUs1098T,
        [EnumMember(Value = "prebuilt-tax.us.1099")]
        PrebuiltTaxUs1099,
        [EnumMember(Value = "prebuilt-tax.us.1099SSA")]
        PrebuiltTaxUs1099SSA
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.ServiceProviders.DocumentIntelligence;

    public partial class WorkflowServiceProviderActions
    {
        public DocumentIntelligenceActions DocumentIntelligence(string connectionId) => new DocumentIntelligenceActions(connectionId);
    }
}