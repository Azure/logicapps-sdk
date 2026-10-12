//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companieshouseip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CompanieshouseipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyByNumber))]
        public IBodyWorkflowAction<CompanyByNumberResponse> CompanyByNumber([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyByNumberResponse> __BuildCompanyByNumber(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<CompanyByNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyByNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildListPsc))]
        public IBodyWorkflowAction<ListPscResponse> ListPsc([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListPscResponse> __BuildListPsc(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<ListPscResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/persons-with-significant-control-statements", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListPscResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildListStatementsPsc))]
        public IBodyWorkflowAction<ListStatementsPscResponse> ListStatementsPsc([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListStatementsPscResponse> __BuildListStatementsPsc(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<ListStatementsPscResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/persons-with-significant-control", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListStatementsPscResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildIndividualPsc))]
        public IBodyWorkflowAction<IndividualPscResponse> IndividualPsc([WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<string> pCSId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IndividualPscResponse> __BuildIndividualPsc(WorkflowExpression<string> companyNumber, WorkflowExpression<string> pCSId)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            WorkflowExpression.Validate(pCSId, nameof(pCSId), required: true);
            return new DeferredBodyAction<IndividualPscResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/persons-with-significant-control/individual/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(pCSId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<IndividualPscResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildUKEstablishments))]
        public IBodyWorkflowAction<UKEstablishmentsResponse> UKEstablishments([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UKEstablishmentsResponse> __BuildUKEstablishments(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<UKEstablishmentsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/uk-establishments", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<UKEstablishmentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildOfficerAppointmentByOfficerId))]
        public IBodyWorkflowAction<OfficerAppointmentByOfficerIdResponse> OfficerAppointmentByOfficerId([WorkflowExpression] Func<string> officerId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficerAppointmentByOfficerIdResponse> __BuildOfficerAppointmentByOfficerId(WorkflowExpression<string> officerId)
        {
            WorkflowExpression.Validate(officerId, nameof(officerId), required: true);
            return new DeferredBodyAction<OfficerAppointmentByOfficerIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/officers/{0}/appointments", ExpressionConverter.ConvertWithUrlEncoding(officerId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfficerAppointmentByOfficerIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildFilingHistoryByNumberAndId))]
        public IBodyWorkflowAction<FilingHistoryByNumberAndIdResponse> FilingHistoryByNumberAndId([WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<string> transactionId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilingHistoryByNumberAndIdResponse> __BuildFilingHistoryByNumberAndId(WorkflowExpression<string> companyNumber, WorkflowExpression<string> transactionId)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            WorkflowExpression.Validate(transactionId, nameof(transactionId), required: true);
            return new DeferredBodyAction<FilingHistoryByNumberAndIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/filing-history/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(transactionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FilingHistoryByNumberAndIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildChargesByNumber))]
        public IBodyWorkflowAction<ChargesByNumberResponse> ChargesByNumber([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChargesByNumberResponse> __BuildChargesByNumber(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<ChargesByNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/charges", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChargesByNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildChargesByNumberAndChargeId))]
        public IBodyWorkflowAction<ChargesByNumberAndChargeIdResponse> ChargesByNumberAndChargeId([WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<string> chargeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ChargesByNumberAndChargeIdResponse> __BuildChargesByNumberAndChargeId(WorkflowExpression<string> companyNumber, WorkflowExpression<string> chargeId)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            WorkflowExpression.Validate(chargeId, nameof(chargeId), required: true);
            return new DeferredBodyAction<ChargesByNumberAndChargeIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/charges/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(chargeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ChargesByNumberAndChargeIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildAddressByNumber))]
        public IBodyWorkflowAction<AddressByNumberResponse> AddressByNumber([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AddressByNumberResponse> __BuildAddressByNumber(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<AddressByNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/registered-office-address", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AddressByNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyOfficersByNumber))]
        public IBodyWorkflowAction<CompanyOfficersByNumberResponse> CompanyOfficersByNumber([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyOfficersByNumberResponse> __BuildCompanyOfficersByNumber(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<CompanyOfficersByNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/officers", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyOfficersByNumberResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildCompanyOfficersByNumberAndAppointmentId))]
        public IBodyWorkflowAction<CompanyOfficersByNumberAndAppointmentIdResponse> CompanyOfficersByNumberAndAppointmentId([WorkflowExpression] Func<string> companyNumber, [WorkflowExpression] Func<string> appointmentId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CompanyOfficersByNumberAndAppointmentIdResponse> __BuildCompanyOfficersByNumberAndAppointmentId(WorkflowExpression<string> companyNumber, WorkflowExpression<string> appointmentId)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            WorkflowExpression.Validate(appointmentId, nameof(appointmentId), required: true);
            return new DeferredBodyAction<CompanyOfficersByNumberAndAppointmentIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/appointments/{1}", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1), ExpressionConverter.ConvertWithUrlEncoding(appointmentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CompanyOfficersByNumberAndAppointmentIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companieshouseip")]
        [WorkflowExpressionFactory(nameof(__BuildFilingHistoryByCompNumber))]
        public IBodyWorkflowAction<FilingHistoryByCompNumberResponse> FilingHistoryByCompNumber([WorkflowExpression] Func<string> companyNumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FilingHistoryByCompNumberResponse> __BuildFilingHistoryByCompNumber(WorkflowExpression<string> companyNumber)
        {
            WorkflowExpression.Validate(companyNumber, nameof(companyNumber), required: true);
            return new DeferredBodyAction<FilingHistoryByCompNumberResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/company/{0}/filing-history", ExpressionConverter.ConvertWithUrlEncoding(companyNumber, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<FilingHistoryByCompNumberResponse>(callPayload);
            });
        }
    }

    public class CompanieshouseipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CompanyByNumberResponse
    {
        [JsonProperty("jurisdiction")]
        public string Jurisdiction { get; set; }

        [JsonProperty("has_been_liquidated")]
        public bool HasBeenLiquidated { get; set; }

        [JsonProperty("registered_office_address")]
        public CompanyByNumberResponseRegisteredOfficeAddressType RegisteredOfficeAddress { get; set; }

        [JsonProperty("date_of_creation")]
        public string DateOfCreation { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("accounts")]
        public CompanyByNumberResponseAccountsType Accounts { get; set; }

        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("undeliverable_registered_office_address")]
        public bool UndeliverableRegisteredOfficeAddress { get; set; }

        [JsonProperty("sic_codes")]
        public string[] SicCodes { get; set; }

        [JsonProperty("last_full_members_list_date")]
        public string LastFullMembersListDate { get; set; }

        [JsonProperty("has_insolvency_history")]
        public bool HasInsolvencyHistory { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("has_charges")]
        public bool HasCharges { get; set; }

        [JsonProperty("company_status")]
        public string CompanyStatus { get; set; }

        [JsonProperty("confirmation_statement")]
        public CompanyByNumberResponseConfirmationStatementType ConfirmationStatement { get; set; }

        [JsonProperty("links")]
        public CompanyByNumberResponseLinksType Links { get; set; }

        [JsonProperty("registered_office_is_in_dispute")]
        public bool RegisteredOfficeIsInDispute { get; set; }

        [JsonProperty("has_super_secure_pscs")]
        public bool HasSuperSecurePscs { get; set; }

        [JsonProperty("can_file")]
        public bool CanFile { get; set; }
    }

    public class CompanyByNumberResponseRegisteredOfficeAddressType
    {
        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }
    }

    public class CompanyByNumberResponseAccountsType
    {
        [JsonProperty("accounting_reference_date")]
        public CompanyByNumberResponseAccountsTypeAccountingReferenceDateType AccountingReferenceDate { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }

        [JsonProperty("last_accounts")]
        public CompanyByNumberResponseAccountsTypeLastAccountsType LastAccounts { get; set; }

        [JsonProperty("next_due")]
        public string NextDue { get; set; }

        [JsonProperty("next_accounts")]
        public CompanyByNumberResponseAccountsTypeNextAccountsType NextAccounts { get; set; }

        [JsonProperty("next_made_up_to")]
        public string NextMadeUpTo { get; set; }
    }

    public class CompanyByNumberResponseAccountsTypeAccountingReferenceDateType
    {
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }
    }

    public class CompanyByNumberResponseAccountsTypeLastAccountsType
    {
        [JsonProperty("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonProperty("made_up_to")]
        public string MadeUpTo { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("period_start_on")]
        public string PeriodStartOn { get; set; }
    }

    public class CompanyByNumberResponseAccountsTypeNextAccountsType
    {
        [JsonProperty("period_start_on")]
        public string PeriodStartOn { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }

        [JsonProperty("period_end_on")]
        public string PeriodEndOn { get; set; }

        [JsonProperty("due_on")]
        public string DueOn { get; set; }
    }

    public class CompanyByNumberResponseConfirmationStatementType
    {
        [JsonProperty("last_made_up_to")]
        public string LastMadeUpTo { get; set; }

        [JsonProperty("next_made_up_to")]
        public string NextMadeUpTo { get; set; }

        [JsonProperty("overdue")]
        public bool Overdue { get; set; }

        [JsonProperty("next_due")]
        public string NextDue { get; set; }
    }

    public class CompanyByNumberResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("filing_history")]
        public string FilingHistory { get; set; }

        [JsonProperty("officers")]
        public string Officers { get; set; }

        [JsonProperty("charges")]
        public string Charges { get; set; }

        [JsonProperty("persons_with_significant_control_statements")]
        public string PersonsWithSignificantControlStatements { get; set; }

        [JsonProperty("persons_with_significant_control")]
        public string PersonsWithSignificantControl { get; set; }
    }

    public class ListPscResponse
    {
        [JsonProperty("links")]
        public ListPscResponseLinksType Links { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("ceased_count")]
        public int CeasedCount { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("active_count")]
        public int ActiveCount { get; set; }

        [JsonProperty("items")]
        public ListPscResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }
    }

    public class ListPscResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("persons_with_significant_control")]
        public string PersonsWithSignificantControl { get; set; }
    }

    public class ListPscResponseItemsTypeItem
    {
        [JsonProperty("notified_on")]
        public string NotifiedOn { get; set; }

        [JsonProperty("statement")]
        public string Statement { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("links")]
        public ListPscResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("ceased_on")]
        public string CeasedOn { get; set; }
    }

    public class ListPscResponseItemsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ListStatementsPscResponse
    {
        [JsonProperty("items")]
        public ListStatementsPscResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("active_count")]
        public int ActiveCount { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("ceased_count")]
        public int CeasedCount { get; set; }

        [JsonProperty("links")]
        public ListStatementsPscResponseLinksType Links { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }
    }

    public class ListStatementsPscResponseItemsTypeItem
    {
        [JsonProperty("address")]
        public ListStatementsPscResponseItemsTypeItemAddressType Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty("notified_on")]
        public string NotifiedOn { get; set; }

        [JsonProperty("natures_of_control")]
        public string[] NaturesOfControl { get; set; }

        [JsonProperty("name_elements")]
        public ListStatementsPscResponseItemsTypeItemNameElementsType NameElements { get; set; }

        [JsonProperty("date_of_birth")]
        public ListStatementsPscResponseItemsTypeItemDateOfBirthType DateOfBirth { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("links")]
        public ListStatementsPscResponseItemsTypeItemLinksType Links { get; set; }
    }

    public class ListStatementsPscResponseItemsTypeItemAddressType
    {
        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("premises")]
        public string Premises { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }
    }

    public class ListStatementsPscResponseItemsTypeItemNameElementsType
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("forename")]
        public string Forename { get; set; }
    }

    public class ListStatementsPscResponseItemsTypeItemDateOfBirthType
    {
        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("month")]
        public int Month { get; set; }
    }

    public class ListStatementsPscResponseItemsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ListStatementsPscResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("persons_with_significant_control_statements")]
        public string PersonsWithSignificantControlStatements { get; set; }
    }

    public class IndividualPscResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("natures_of_control")]
        public string[] NaturesOfControl { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("name_elements")]
        public IndividualPscResponseNameElementsType NameElements { get; set; }

        [JsonProperty("date_of_birth")]
        public IndividualPscResponseDateOfBirthType DateOfBirth { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("notified_on")]
        public string NotifiedOn { get; set; }

        [JsonProperty("links")]
        public IndividualPscResponseLinksType Links { get; set; }

        [JsonProperty("address")]
        public IndividualPscResponseAddressType Address { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("country_of_residence")]
        public string CountryOfResidence { get; set; }
    }

    public class IndividualPscResponseNameElementsType
    {
        [JsonProperty("forename")]
        public string Forename { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }
    }

    public class IndividualPscResponseDateOfBirthType
    {
        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class IndividualPscResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class IndividualPscResponseAddressType
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("premises")]
        public string Premises { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public class UKEstablishmentsResponse
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("items")]
        public UKEstablishmentsResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("links")]
        public UKEstablishmentsResponseLinksType Links { get; set; }
    }

    public class UKEstablishmentsResponseItemsTypeItem
    {
        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("company_status")]
        public string CompanyStatus { get; set; }

        [JsonProperty("links")]
        public UKEstablishmentsResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }
    }

    public class UKEstablishmentsResponseItemsTypeItemLinksType
    {
        [JsonProperty("company")]
        public string Company { get; set; }
    }

    public class UKEstablishmentsResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponse
    {
        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("links")]
        public OfficerAppointmentByOfficerIdResponseLinksType Links { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("is_corporate_officer")]
        public bool IsCorporateOfficer { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("items")]
        public OfficerAppointmentByOfficerIdResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseItemsTypeItem
    {
        [JsonProperty("officer_role")]
        public string OfficerRole { get; set; }

        [JsonProperty("name_elements")]
        public OfficerAppointmentByOfficerIdResponseItemsTypeItemNameElementsType NameElements { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("appointed_to")]
        public OfficerAppointmentByOfficerIdResponseItemsTypeItemAppointedToType AppointedTo { get; set; }

        [JsonProperty("links")]
        public OfficerAppointmentByOfficerIdResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("appointed_on")]
        public string AppointedOn { get; set; }

        [JsonProperty("address")]
        public OfficerAppointmentByOfficerIdResponseItemsTypeItemAddressType Address { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseItemsTypeItemNameElementsType
    {
        [JsonProperty("forename")]
        public string Forename { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseItemsTypeItemAppointedToType
    {
        [JsonProperty("company_number")]
        public string CompanyNumber { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("company_status")]
        public string CompanyStatus { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseItemsTypeItemLinksType
    {
        [JsonProperty("company")]
        public string Company { get; set; }
    }

    public class OfficerAppointmentByOfficerIdResponseItemsTypeItemAddressType
    {
        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("premises")]
        public string Premises { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class FilingHistoryByNumberAndIdResponse
    {
        [JsonProperty("action_date")]
        public string ActionDate { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_values")]
        public FilingHistoryByNumberAndIdResponseDescriptionValuesType DescriptionValues { get; set; }

        [JsonProperty("links")]
        public FilingHistoryByNumberAndIdResponseLinksType Links { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }

    public class FilingHistoryByNumberAndIdResponseDescriptionValuesType
    {
        [JsonProperty("change_date")]
        public string ChangeDate { get; set; }

        [JsonProperty("new_address")]
        public string NewAddress { get; set; }

        [JsonProperty("old_address")]
        public string OldAddress { get; set; }
    }

    public class FilingHistoryByNumberAndIdResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("document_metadata")]
        public string DocumentMetadata { get; set; }
    }

    public class ChargesByNumberResponse
    {
        [JsonProperty("total_count")]
        public int TotalCount { get; set; }

        [JsonProperty("items")]
        public ChargesByNumberResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("satisfied_count")]
        public int SatisfiedCount { get; set; }

        [JsonProperty("unfiltered_count")]
        public int UnfilteredCount { get; set; }

        [JsonProperty("part_satisfied_count")]
        public int PartSatisfiedCount { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItem
    {
        [JsonProperty("charge_number")]
        public int ChargeNumber { get; set; }

        [JsonProperty("links")]
        public ChargesByNumberResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("transactions")]
        public ChargesByNumberResponseItemsTypeItemTransactionsTypeItem[] Transactions { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("charge_code")]
        public string ChargeCode { get; set; }

        [JsonProperty("classification")]
        public ChargesByNumberResponseItemsTypeItemClassificationType Classification { get; set; }

        [JsonProperty("particulars")]
        public ChargesByNumberResponseItemsTypeItemParticularsType Particulars { get; set; }

        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }

        [JsonProperty("persons_entitled")]
        public ChargesByNumberResponseItemsTypeItemPersonsEntitledTypeItem[] PersonsEntitled { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemTransactionsTypeItem
    {
        [JsonProperty("filing_type")]
        public string FilingType { get; set; }

        [JsonProperty("links")]
        public ChargesByNumberResponseItemsTypeItemTransactionsTypeItemLinksType Links { get; set; }

        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemTransactionsTypeItemLinksType
    {
        [JsonProperty("filing")]
        public string Filing { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemClassificationType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemParticularsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contains_fixed_charge")]
        public bool ContainsFixedCharge { get; set; }

        [JsonProperty("floating_charge_covers_all")]
        public bool FloatingChargeCoversAll { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contains_floating_charge")]
        public bool ContainsFloatingCharge { get; set; }
    }

    public class ChargesByNumberResponseItemsTypeItemPersonsEntitledTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponse
    {
        [JsonProperty("charge_number")]
        public int ChargeNumber { get; set; }

        [JsonProperty("links")]
        public ChargesByNumberAndChargeIdResponseLinksType Links { get; set; }

        [JsonProperty("created_on")]
        public string CreatedOn { get; set; }

        [JsonProperty("transactions")]
        public ChargesByNumberAndChargeIdResponseTransactionsTypeItem[] Transactions { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("charge_code")]
        public string ChargeCode { get; set; }

        [JsonProperty("classification")]
        public ChargesByNumberAndChargeIdResponseClassificationType Classification { get; set; }

        [JsonProperty("particulars")]
        public ChargesByNumberAndChargeIdResponseParticularsType Particulars { get; set; }

        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }

        [JsonProperty("persons_entitled")]
        public ChargesByNumberAndChargeIdResponsePersonsEntitledTypeItem[] PersonsEntitled { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponseTransactionsTypeItem
    {
        [JsonProperty("filing_type")]
        public string FilingType { get; set; }

        [JsonProperty("links")]
        public ChargesByNumberAndChargeIdResponseTransactionsTypeItemLinksType Links { get; set; }

        [JsonProperty("delivered_on")]
        public string DeliveredOn { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponseTransactionsTypeItemLinksType
    {
        [JsonProperty("filing")]
        public string Filing { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponseClassificationType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponseParticularsType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contains_fixed_charge")]
        public bool ContainsFixedCharge { get; set; }

        [JsonProperty("floating_charge_covers_all")]
        public bool FloatingChargeCoversAll { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("contains_floating_charge")]
        public bool ContainsFloatingCharge { get; set; }
    }

    public class ChargesByNumberAndChargeIdResponsePersonsEntitledTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AddressByNumberResponse
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("links")]
        public AddressByNumberResponseLinksType Links { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }
    }

    public class AddressByNumberResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class CompanyOfficersByNumberResponse
    {
        [JsonProperty("etag")]
        public string Etag { get; set; }

        [JsonProperty("active_count")]
        public int ActiveCount { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("inactive_count")]
        public int InactiveCount { get; set; }

        [JsonProperty("resigned_count")]
        public int ResignedCount { get; set; }

        [JsonProperty("items")]
        public CompanyOfficersByNumberResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("links")]
        public CompanyOfficersByNumberResponseLinksType Links { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItem
    {
        [JsonProperty("links")]
        public CompanyOfficersByNumberResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("address")]
        public CompanyOfficersByNumberResponseItemsTypeItemAddressType Address { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("officer_role")]
        public string OfficerRole { get; set; }

        [JsonProperty("appointed_on")]
        public string AppointedOn { get; set; }

        [JsonProperty("date_of_birth")]
        public CompanyOfficersByNumberResponseItemsTypeItemDateOfBirthType DateOfBirth { get; set; }

        [JsonProperty("country_of_residence")]
        public string CountryOfResidence { get; set; }

        [JsonProperty("occupation")]
        public string Occupation { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("former_names")]
        public CompanyOfficersByNumberResponseItemsTypeItemFormerNamesTypeItem[] FormerNames { get; set; }

        [JsonProperty("resigned_on")]
        public string ResignedOn { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItemLinksType
    {
        [JsonProperty("officer")]
        public CompanyOfficersByNumberResponseItemsTypeItemLinksTypeOfficerType Officer { get; set; }

        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItemLinksTypeOfficerType
    {
        [JsonProperty("appointments")]
        public string Appointments { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItemAddressType
    {
        [JsonProperty("premises")]
        public string Premises { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("address_line_2")]
        public string AddressLine2 { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItemDateOfBirthType
    {
        [JsonProperty("month")]
        public int Month { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }
    }

    public class CompanyOfficersByNumberResponseItemsTypeItemFormerNamesTypeItem
    {
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }

    public class CompanyOfficersByNumberResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }
    }

    public class CompanyOfficersByNumberAndAppointmentIdResponse
    {
        [JsonProperty("links")]
        public CompanyOfficersByNumberAndAppointmentIdResponseLinksType Links { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public CompanyOfficersByNumberAndAppointmentIdResponseAddressType Address { get; set; }

        [JsonProperty("appointed_on")]
        public string AppointedOn { get; set; }

        [JsonProperty("officer_role")]
        public string OfficerRole { get; set; }
    }

    public class CompanyOfficersByNumberAndAppointmentIdResponseLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("officer")]
        public CompanyOfficersByNumberAndAppointmentIdResponseLinksTypeOfficerType Officer { get; set; }
    }

    public class CompanyOfficersByNumberAndAppointmentIdResponseLinksTypeOfficerType
    {
        [JsonProperty("appointments")]
        public string Appointments { get; set; }
    }

    public class CompanyOfficersByNumberAndAppointmentIdResponseAddressType
    {
        [JsonProperty("address_line_1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("premises")]
        public string Premises { get; set; }
    }

    public class FilingHistoryByCompNumberResponse
    {
        [JsonProperty("filing_history_status")]
        public string FilingHistoryStatus { get; set; }

        [JsonProperty("items_per_page")]
        public int ItemsPerPage { get; set; }

        [JsonProperty("start_index")]
        public int StartIndex { get; set; }

        [JsonProperty("items")]
        public FilingHistoryByCompNumberResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("total_count")]
        public int TotalCount { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItem
    {
        [JsonProperty("action_date")]
        public string ActionDate { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_values")]
        public FilingHistoryByCompNumberResponseItemsTypeItemDescriptionValuesType DescriptionValues { get; set; }

        [JsonProperty("links")]
        public FilingHistoryByCompNumberResponseItemsTypeItemLinksType Links { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("barcode")]
        public string Barcode { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("paper_filed")]
        public bool PaperFiled { get; set; }

        [JsonProperty("resolutions")]
        public FilingHistoryByCompNumberResponseItemsTypeItemResolutionsTypeItem[] Resolutions { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItemDescriptionValuesType
    {
        [JsonProperty("change_date")]
        public string ChangeDate { get; set; }

        [JsonProperty("new_address")]
        public string NewAddress { get; set; }

        [JsonProperty("old_address")]
        public string OldAddress { get; set; }

        [JsonProperty("made_up_date")]
        public string MadeUpDate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("capital")]
        public FilingHistoryByCompNumberResponseItemsTypeItemDescriptionValuesTypeCapitalTypeItem[] Capital { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("officer_name")]
        public string OfficerName { get; set; }

        [JsonProperty("appointment_date")]
        public string AppointmentDate { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItemDescriptionValuesTypeCapitalTypeItem
    {
        [JsonProperty("figure")]
        public string Figure { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItemLinksType
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("document_metadata")]
        public string DocumentMetadata { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItemResolutionsTypeItem
    {
        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("description_values")]
        public FilingHistoryByCompNumberResponseItemsTypeItemResolutionsTypeItemDescriptionValuesType DescriptionValues { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class FilingHistoryByCompNumberResponseItemsTypeItemResolutionsTypeItemDescriptionValuesType
    {
        [JsonProperty("res_type")]
        public string ResType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Companieshouseip;

    public partial class WorkflowManagedActions
    {
        public CompanieshouseipActions Companieshouseip(string connectionId) => new CompanieshouseipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CompanieshouseipTriggers Companieshouseip(string connectionId) => new CompanieshouseipTriggers(connectionId);
    }
}