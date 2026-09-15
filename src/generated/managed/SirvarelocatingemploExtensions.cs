//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sirvarelocatingemplo
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SirvarelocatingemploActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sirvarelocatingemplo")]
        public IBodyWorkflowAction<GetRelocationsResponse> GetRelocations()
        {
            var apiCallPath = "/relocation";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRelocationsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sirvarelocatingemplo")]
        public IBodyWorkflowAction<GetRelocationPackageResponse> GetRelocationPackage(Expression<Func<string>> relocationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/package/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(relocationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetRelocationPackageResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sirvarelocatingemplo")]
        public IBodyWorkflowAction<GetCounselorContactInformationResponse> GetCounselorContactInformation(Expression<Func<bool>> includePicture, Expression<Func<string>> relocationId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/relocation/counselor/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(relocationId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["IncludePicture"] = CSharpExpressionConverter.ConvertO(includePicture);
            return new ApiConnectionAction<GetCounselorContactInformationResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sirvarelocatingemplo")]
        public IBodyWorkflowAction<AskSirvaBotAboutTopicResponse> AskSirvaBotAboutTopic(Expression<Func<string>> bodyrelocationId, Expression<Func<string>> bodyquery, Expression<Func<bodytopicInput>> bodytopic)
        {
            var apiCallPath = "/chat/topic";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["RelocationId"] = CSharpExpressionConverter.ConvertToken(bodyrelocationId);
            bodypropCount++;
            body["Query"] = CSharpExpressionConverter.ConvertToken(bodyquery);
            bodypropCount++;
            body["Topic"] = CSharpExpressionConverter.Convert(bodytopic);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<AskSirvaBotAboutTopicResponse>(callPayload);
        }
    }

    public class SirvarelocatingemploTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetRelocationsResponse
    {
        [JsonProperty("relocations")]
        public GetRelocationsResponseRelocationsTypeItem[] Relocations { get; set; }

        [JsonProperty("isTransitionFile")]
        public bool IsTransitionFile { get; set; }

        [JsonProperty("isExpenseBudgetEnabled")]
        public bool IsExpenseBudgetEnabled { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }
    }

    public class GetRelocationsResponseRelocationsTypeItem
    {
        [JsonProperty("relocationId")]
        public string RelocationId { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("transfereeFirstName")]
        public string TransfereeFirstName { get; set; }

        [JsonProperty("transfereeLastName")]
        public string TransfereeLastName { get; set; }

        [JsonProperty("userAccountId")]
        public string UserAccountId { get; set; }

        [JsonProperty("departureCountry")]
        public string DepartureCountry { get; set; }

        [JsonProperty("departureCountryCode")]
        public string DepartureCountryCode { get; set; }

        [JsonProperty("departureState")]
        public string DepartureState { get; set; }

        [JsonProperty("departureCity")]
        public string DepartureCity { get; set; }

        [JsonProperty("destinationCountry")]
        public string DestinationCountry { get; set; }

        [JsonProperty("destinationCountryCode")]
        public string DestinationCountryCode { get; set; }

        [JsonProperty("destinationState")]
        public string DestinationState { get; set; }

        [JsonProperty("destinationCity")]
        public string DestinationCity { get; set; }

        [JsonProperty("system")]
        public string System { get; set; }

        [JsonProperty("delegate")]
        public bool Delegate { get; set; }

        [JsonProperty("access")]
        public string Access { get; set; }

        [JsonProperty("sourceSystemId")]
        public int SourceSystemId { get; set; }

        [JsonProperty("estimatedStartDate")]
        public string EstimatedStartDate { get; set; }

        [JsonProperty("clientName")]
        public string ClientName { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("programName")]
        public string ProgramName { get; set; }

        [JsonProperty("isExpenseReceiptUploadRequired")]
        public bool IsExpenseReceiptUploadRequired { get; set; }

        [JsonProperty("isMyDocumentsAccessEnabled")]
        public bool IsMyDocumentsAccessEnabled { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("estimatedEndDate")]
        public string EstimatedEndDate { get; set; }

        [JsonProperty("isGovernmentClient")]
        public bool IsGovernmentClient { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isDPSClient")]
        public bool IsDPSClient { get; set; }

        [JsonProperty("orgUid")]
        public int OrgUid { get; set; }
    }

    public class GetRelocationPackageResponse
    {
        [JsonProperty("isStarted")]
        public bool IsStarted { get; set; }

        [JsonProperty("isComplete")]
        public bool IsComplete { get; set; }

        [JsonProperty("isAccepted")]
        public bool IsAccepted { get; set; }

        [JsonProperty("readyForNeedsAnalysis")]
        public bool ReadyForNeedsAnalysis { get; set; }

        [JsonProperty("allowances")]
        public GetRelocationPackageResponseAllowancesTypeItem[] Allowances { get; set; }

        [JsonProperty("services")]
        public GetRelocationPackageResponseServicesTypeItem[] Services { get; set; }

        [JsonProperty("servicesAvailable")]
        public JToken[] ServicesAvailable { get; set; }

        [JsonProperty("policy")]
        public GetRelocationPackageResponsePolicyType Policy { get; set; }

        [JsonProperty("status")]
        public GetRelocationPackageResponseStatusType Status { get; set; }

        [JsonProperty("isReadyForESC")]
        public bool IsReadyForESC { get; set; }

        [JsonProperty("packageOwnerShip")]
        public string PackageOwnerShip { get; set; }
    }

    public class GetRelocationPackageResponseAllowancesTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("amountIdentifiedAtConsultation")]
        public bool AmountIdentifiedAtConsultation { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyId")]
        public string CurrencyId { get; set; }

        [JsonProperty("categoryType")]
        public string CategoryType { get; set; }

        [JsonProperty("categoryTypeId")]
        public string CategoryTypeId { get; set; }

        [JsonProperty("occurrenceType")]
        public string OccurrenceType { get; set; }

        [JsonProperty("occurrenceTypeId")]
        public string OccurrenceTypeId { get; set; }

        [JsonProperty("paidByType")]
        public string PaidByType { get; set; }

        [JsonProperty("paidByTypeId")]
        public string PaidByTypeId { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("paymentRequest")]
        public GetRelocationPackageResponseAllowancesTypeItemPaymentRequestType PaymentRequest { get; set; }
    }

    public class GetRelocationPackageResponseAllowancesTypeItemPaymentRequestType
    {
        [JsonProperty("requestedBy")]
        public GetRelocationPackageResponseAllowancesTypeItemPaymentRequestTypeRequestedByType RequestedBy { get; set; }

        [JsonProperty("requestedDate")]
        public string RequestedDate { get; set; }

        [JsonProperty("remittanceMethod")]
        public string RemittanceMethod { get; set; }

        [JsonProperty("remittanceAccount")]
        public string RemittanceAccount { get; set; }
    }

    public class GetRelocationPackageResponseAllowancesTypeItemPaymentRequestTypeRequestedByType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItem
    {
        [JsonProperty("isInPackage")]
        public bool IsInPackage { get; set; }

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("categoryType")]
        public string CategoryType { get; set; }

        [JsonProperty("categoryTypeId")]
        public string CategoryTypeId { get; set; }

        [JsonProperty("shortDescription")]
        public string ShortDescription { get; set; }

        [JsonProperty("longDescription")]
        public string LongDescription { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("providerTypeId")]
        public string ProviderTypeId { get; set; }

        [JsonProperty("core")]
        public bool Core { get; set; }

        [JsonProperty("cashOutOption")]
        public bool CashOutOption { get; set; }

        [JsonProperty("cashOutPercentage")]
        public int CashOutPercentage { get; set; }

        [JsonProperty("outOfPocket")]
        public bool OutOfPocket { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("iconUrl")]
        public string IconUrl { get; set; }

        [JsonProperty("isIncluded")]
        public bool IsIncluded { get; set; }

        [JsonProperty("masterServiceId")]
        public string MasterServiceId { get; set; }

        [JsonProperty("isTravelService")]
        public bool IsTravelService { get; set; }

        [JsonProperty("useRemittance")]
        public bool UseRemittance { get; set; }

        [JsonProperty("cashOutAmount")]
        public double CashOutAmount { get; set; }

        [JsonProperty("benefits")]
        public GetRelocationPackageResponseServicesTypeItemBenefitsTypeItem[] Benefits { get; set; }

        [JsonProperty("serviceRequest")]
        public GetRelocationPackageResponseServicesTypeItemServiceRequestType ServiceRequest { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemBenefitsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("outOfPocket")]
        public bool OutOfPocket { get; set; }

        [JsonProperty("cashoutOption")]
        public bool CashoutOption { get; set; }

        [JsonProperty("cashoutPercentage")]
        public int CashoutPercentage { get; set; }

        [JsonProperty("cashoutAmount")]
        public double CashoutAmount { get; set; }

        [JsonProperty("isIncluded")]
        public bool IsIncluded { get; set; }

        [JsonProperty("amountOptions")]
        public GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemAmountOptionsTypeItem[] AmountOptions { get; set; }

        [JsonProperty("components")]
        public GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemComponentsTypeItem[] Components { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemAmountOptionsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("unitType")]
        public string UnitType { get; set; }

        [JsonProperty("unitTypeId")]
        public string UnitTypeId { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }

        [JsonProperty("conditionId")]
        public string ConditionId { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("actualCashOut")]
        public double ActualCashOut { get; set; }

        [JsonProperty("recommended")]
        public bool Recommended { get; set; }

        [JsonProperty("isSelected")]
        public bool IsSelected { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemComponentsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("componentType")]
        public string ComponentType { get; set; }

        [JsonProperty("componentTypeId")]
        public string ComponentTypeId { get; set; }

        [JsonProperty("options")]
        public GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemComponentsTypeItemOptionsTypeItem[] Options { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemBenefitsTypeItemComponentsTypeItemOptionsTypeItem
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("recommended")]
        public bool Recommended { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemServiceRequestType
    {
        [JsonProperty("requestType")]
        public string RequestType { get; set; }

        [JsonProperty("requestedDate")]
        public string RequestedDate { get; set; }

        [JsonProperty("requestedBy")]
        public GetRelocationPackageResponseServicesTypeItemServiceRequestTypeRequestedByType RequestedBy { get; set; }
    }

    public class GetRelocationPackageResponseServicesTypeItemServiceRequestTypeRequestedByType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class GetRelocationPackageResponsePolicyType
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("currencyId")]
        public string CurrencyId { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("flexAmountCap")]
        public int FlexAmountCap { get; set; }

        [JsonProperty("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonProperty("statusTypeId")]
        public string StatusTypeId { get; set; }

        [JsonProperty("statusType")]
        public string StatusType { get; set; }

        [JsonProperty("policyTypeId")]
        public string PolicyTypeId { get; set; }

        [JsonProperty("policyType")]
        public string PolicyType { get; set; }

        [JsonProperty("preDecision")]
        public bool PreDecision { get; set; }
    }

    public class GetRelocationPackageResponseStatusType
    {
        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedBy")]
        public GetRelocationPackageResponseStatusTypeCompletedByType CompletedBy { get; set; }

        [JsonProperty("modifiedBy")]
        public GetRelocationPackageResponseStatusTypeModifiedByType ModifiedBy { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }
    }

    public class GetRelocationPackageResponseStatusTypeCompletedByType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class GetRelocationPackageResponseStatusTypeModifiedByType
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first")]
        public string First { get; set; }

        [JsonProperty("last")]
        public string Last { get; set; }
    }

    public class GetCounselorContactInformationResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("initials")]
        public string Initials { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("bookingUrl")]
        public string BookingUrl { get; set; }

        [JsonProperty("userTime")]
        public string UserTime { get; set; }

        [JsonProperty("contUID")]
        public int ContUID { get; set; }

        [JsonProperty("outOfOffice")]
        public bool OutOfOffice { get; set; }

        [JsonProperty("outOfOfficeMessage")]
        public string OutOfOfficeMessage { get; set; }

        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        [JsonProperty("endTime")]
        public string EndTime { get; set; }
    }

    public class AskSirvaBotAboutTopicResponse
    {
        [JsonProperty("answer")]
        public string Answer { get; set; }
    }

    public enum bodytopicInput
    {
        Counselor,
        Contacts,
        Hhg,
        Policy
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sirvarelocatingemplo;

    public partial class WorkflowManagedActions
    {
        public SirvarelocatingemploActions Sirvarelocatingemplo(string connectionId) => new SirvarelocatingemploActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SirvarelocatingemploTriggers Sirvarelocatingemplo(string connectionId) => new SirvarelocatingemploTriggers(connectionId);
    }
}