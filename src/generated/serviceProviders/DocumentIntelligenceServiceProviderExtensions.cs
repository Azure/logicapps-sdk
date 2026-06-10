//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.ServiceProviders.DocumentIntelligence
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DocumentIntelligenceActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ServiceProvider, ConnectorName = "documentIntelligence")]
        public IBodyWorkflowAction<AnalyzeDocumentOutput> AnalyzeDocument(Expression<Func<AnalyzeDocumentModelIdType>> modelId, Expression<Func<object>> modelIdInputs = null)
        {
            var parameters = new JObject();
            parameters["modelId"] = ExpressionConverter.ConvertO(modelId);
            if (modelIdInputs != null)
            {
                parameters["modelIdInputs"] = ExpressionConverter.ConvertO(modelIdInputs);
            }

            var input = new ServiceProviderActionInput
            {
                ServiceProviderConfiguration = new ServiceProviderConfiguration(serviceProviderId: "/serviceProviders/documentIntelligence", operationId: "analyzeDocument", connectionName: connectionId),
                Parameters = parameters
            };
            return new ServiceProviderAction<AnalyzeDocumentOutput>(input);
        }
    }

    public class DocumentIntelligenceTriggers([ConnectionName] string connectionId)
    {
    }

    public class AnalyzeDocumentOutput
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("response")]
        public JToken Response { get; set; }
    }

    public enum AnalyzeDocumentModelIdType
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

    public partial class WorkflowServiceProviderTriggers
    {
        public DocumentIntelligenceTriggers DocumentIntelligence(string connectionId) => new DocumentIntelligenceTriggers(connectionId);
    }
}