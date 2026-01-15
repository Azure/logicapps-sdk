//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Data8
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Data8Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsUsableNameResponse> IsUsableName(Expression<Func<string>> bodynameTitle = null, Expression<Func<string>> bodynameForename = null, Expression<Func<string>> bodynameMiddleName = null, Expression<Func<string>> bodynameSurname = null)
        {
            var apiCallPath = "/SalaciousName/IsUnusableName.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynameTitle != null)
            {
                nameObject["Title"] = ExpressionConverter.ConvertO(bodynameTitle);
                nameObjectpropCount++;
            }

            if (bodynameForename != null)
            {
                nameObject["Forename"] = ExpressionConverter.ConvertO(bodynameForename);
                nameObjectpropCount++;
            }

            if (bodynameMiddleName != null)
            {
                nameObject["MiddleName"] = ExpressionConverter.ConvertO(bodynameMiddleName);
                nameObjectpropCount++;
            }

            if (bodynameSurname != null)
            {
                nameObject["Surname"] = ExpressionConverter.ConvertO(bodynameSurname);
                nameObjectpropCount++;
            }

            if (nameObjectpropCount > 0)
            {
                body["name"] = nameObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsUsableNameResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableTPSResponse> IsCallableTPS(Expression<Func<string>> bodynumber)
        {
            var apiCallPath = "/TPS/IsCallable.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsCallableTPSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableCTPSResponse> IsCallableCTPS(Expression<Func<string>> bodynumber)
        {
            var apiCallPath = "/CTPS/IsCallable.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["number"] = ExpressionConverter.ConvertO(bodynumber);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsCallableCTPSResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidBankAccountResponse> IsValidBankAccount(Expression<Func<string>> bodysortCode, Expression<Func<string>> bodybankAccountNumber = null)
        {
            var apiCallPath = "/BankAccountValidation/IsValid.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sortCode"] = ExpressionConverter.ConvertO(bodysortCode);
            if (bodybankAccountNumber != null)
            {
                body["bankAccountNumber"] = ExpressionConverter.ConvertO(bodybankAccountNumber);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsValidBankAccountResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidEmailResponse> IsValidEmail(Expression<Func<string>> bodyemail, Expression<Func<bodylevelInput>> bodylevel)
        {
            var apiCallPath = "/EmailValidation/IsValid.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["level"] = ExpressionConverter.ConvertO(bodylevel);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsValidEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidTelephoneResponse> IsValidTelephone(Expression<Func<string>> bodytelephoneNumber, Expression<Func<string>> bodydefaultCountry, Expression<Func<bool>> bodyoptionsUseLineValidation = null, Expression<Func<bool>> bodyoptionsUseMobileValidation = null)
        {
            var apiCallPath = "/InternationalTelephoneValidation/IsValid.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["telephoneNumber"] = ExpressionConverter.ConvertO(bodytelephoneNumber);
            bodypropCount++;
            body["defaultCountry"] = ExpressionConverter.ConvertO(bodydefaultCountry);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsUseLineValidation != null)
            {
                optionsObject["UseLineValidation"] = ExpressionConverter.ConvertO(bodyoptionsUseLineValidation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsUseMobileValidation != null)
            {
                optionsObject["UseMobileValidation"] = ExpressionConverter.ConvertO(bodyoptionsUseMobileValidation);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsValidTelephoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<GetFullAddressResponse> GetFullAddress(Expression<Func<bodylicenceInput>> bodylicence, Expression<Func<string>> bodypostcode, Expression<Func<string>> bodybuilding = null, Expression<Func<bool>> bodyoptionsFixTownCounty = null, Expression<Func<int>> bodyoptionsMaxLines = null, Expression<Func<int>> bodyoptionsMaxLineLength = null, Expression<Func<bool>> bodyoptionsNormalizeCase = null, Expression<Func<bool>> bodyoptionsNormalizeTownCase = null, Expression<Func<bool>> bodyoptionsExcludeCounty = null, Expression<Func<bool>> bodyoptionsUseAnyAvailableCounty = null, Expression<Func<bool>> bodyoptionsUnwantedPunctuation = null, Expression<Func<bool>> bodyoptionsFixBuilding = null, Expression<Func<bool>> bodyoptionsIncludeUDPRN = null, Expression<Func<bool>> bodyoptionsIncludeLocation = null, Expression<Func<bool>> bodyoptionsReturnResultCount = null, Expression<Func<bool>> bodyoptionsIncludeNYB = null, Expression<Func<bool>> bodyoptionsIncludeMR = null, Expression<Func<bodyoptionsFormatterInput>> bodyoptionsFormatter = null)
        {
            var apiCallPath = "/AddressCapture/GetFullAddress.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["licence"] = ExpressionConverter.ConvertO(bodylicence);
            bodypropCount++;
            body["postcode"] = ExpressionConverter.ConvertO(bodypostcode);
            if (bodybuilding != null)
            {
                body["building"] = ExpressionConverter.ConvertO(bodybuilding);
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsFixTownCounty != null)
            {
                optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(bodyoptionsFixTownCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsMaxLines != null)
            {
                optionsObject["MaxLines"] = ExpressionConverter.ConvertO(bodyoptionsMaxLines);
                optionsObjectpropCount++;
            }

            if (bodyoptionsMaxLineLength != null)
            {
                optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(bodyoptionsMaxLineLength);
                optionsObjectpropCount++;
            }

            if (bodyoptionsNormalizeCase != null)
            {
                optionsObject["NormalizeCase"] = ExpressionConverter.ConvertO(bodyoptionsNormalizeCase);
                optionsObjectpropCount++;
            }

            if (bodyoptionsNormalizeTownCase != null)
            {
                optionsObject["NormalizeTownCase"] = ExpressionConverter.ConvertO(bodyoptionsNormalizeTownCase);
                optionsObjectpropCount++;
            }

            if (bodyoptionsExcludeCounty != null)
            {
                optionsObject["ExcludeCounty"] = ExpressionConverter.ConvertO(bodyoptionsExcludeCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsUseAnyAvailableCounty != null)
            {
                optionsObject["UseAnyAvailableCounty"] = ExpressionConverter.ConvertO(bodyoptionsUseAnyAvailableCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsUnwantedPunctuation != null)
            {
                optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(bodyoptionsUnwantedPunctuation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFixBuilding != null)
            {
                optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(bodyoptionsFixBuilding);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeUDPRN != null)
            {
                optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(bodyoptionsIncludeUDPRN);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeLocation != null)
            {
                optionsObject["IncludeLocation"] = ExpressionConverter.ConvertO(bodyoptionsIncludeLocation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsReturnResultCount != null)
            {
                optionsObject["ReturnResultCount"] = ExpressionConverter.ConvertO(bodyoptionsReturnResultCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsIncludeNYB);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsIncludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFormatter != null)
            {
                optionsObject["Formatter"] = ExpressionConverter.ConvertO(bodyoptionsFormatter);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<GetFullAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> SearchPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodysearch, Expression<Func<string>> bodytelephoneNumber = null, Expression<Func<string>> bodysession = null, Expression<Func<bool>> bodyoptionsIncludeMR = null, Expression<Func<bool>> bodyoptionsIncludeNYB = null)
        {
            var apiCallPath = "/PredictiveAddress/Search.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["country"] = ExpressionConverter.ConvertO(bodycountry);
            bodypropCount++;
            body["search"] = ExpressionConverter.ConvertO(bodysearch);
            if (bodytelephoneNumber != null)
            {
                body["telephoneNumber"] = ExpressionConverter.ConvertO(bodytelephoneNumber);
                bodypropCount++;
            }

            if (bodysession != null)
            {
                body["session"] = ExpressionConverter.ConvertO(bodysession);
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsIncludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsIncludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsIncludeNYB);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<SearchPredictiveAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> DrilldownPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyoptionsIncludeMR = null, Expression<Func<bool>> bodyoptionsIncludeNYB = null)
        {
            var apiCallPath = "/PredictiveAddress/DrillDown.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["country"] = ExpressionConverter.ConvertO(bodycountry);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsIncludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsIncludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsIncludeNYB);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<DrilldownPredictiveAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> RetrievePredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<int>> bodyoptionsMaxLineLength = null, Expression<Func<int>> bodyoptionsMaxLines = null, Expression<Func<bool>> bodyoptionsFixTownCounty = null, Expression<Func<bool>> bodyoptionsFixPostcode = null, Expression<Func<bool>> bodyoptionsFixBuilding = null, Expression<Func<string>> bodyoptionsUnwantedPunctuation = null, Expression<Func<bodyoptionsFormatterInput>> bodyoptionsFormatter = null, Expression<Func<bool>> bodyoptionsIncludeUDPRN = null, Expression<Func<bool>> bodyoptionsIncludeUPRN = null)
        {
            var apiCallPath = "/PredictiveAddress/Retrieve.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["country"] = ExpressionConverter.ConvertO(bodycountry);
            bodypropCount++;
            body["id"] = ExpressionConverter.ConvertO(bodyid);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsMaxLineLength != null)
            {
                optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(bodyoptionsMaxLineLength);
                optionsObjectpropCount++;
            }

            if (bodyoptionsMaxLines != null)
            {
                optionsObject["MaxLines"] = ExpressionConverter.ConvertO(bodyoptionsMaxLines);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFixTownCounty != null)
            {
                optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(bodyoptionsFixTownCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFixPostcode != null)
            {
                optionsObject["FixPostcode"] = ExpressionConverter.ConvertO(bodyoptionsFixPostcode);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFixBuilding != null)
            {
                optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(bodyoptionsFixBuilding);
                optionsObjectpropCount++;
            }

            if (bodyoptionsUnwantedPunctuation != null)
            {
                optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(bodyoptionsUnwantedPunctuation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsFormatter != null)
            {
                optionsObject["Formatter"] = ExpressionConverter.ConvertO(bodyoptionsFormatter);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeUDPRN != null)
            {
                optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(bodyoptionsIncludeUDPRN);
                optionsObjectpropCount++;
            }

            if (bodyoptionsIncludeUPRN != null)
            {
                optionsObject["IncludeUPRN"] = ExpressionConverter.ConvertO(bodyoptionsIncludeUPRN);
                optionsObjectpropCount++;
            }

            if (optionsObjectpropCount > 0)
            {
                body["options"] = optionsObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RetrievePredictiveAddressResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanseEmailResponse> CleanseEmail(Expression<Func<string>> bodyEmail, Expression<Func<bodyLevelInput>> bodyLevel, Expression<Func<string>> bodyTitle = null, Expression<Func<string>> bodyForename = null, Expression<Func<string>> bodyMiddleName = null, Expression<Func<string>> bodySurname = null, Expression<Func<string>> bodyCompany = null)
        {
            var apiCallPath = "/EmailValidation/CleanseSimple.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyEmail);
            bodypropCount++;
            body["Level"] = ExpressionConverter.ConvertO(bodyLevel);
            if (bodyTitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodyTitle);
                bodypropCount++;
            }

            if (bodyForename != null)
            {
                body["Forename"] = ExpressionConverter.ConvertO(bodyForename);
                bodypropCount++;
            }

            if (bodyMiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodyMiddleName);
                bodypropCount++;
            }

            if (bodySurname != null)
            {
                body["Surname"] = ExpressionConverter.ConvertO(bodySurname);
                bodypropCount++;
            }

            if (bodyCompany != null)
            {
                body["Company"] = ExpressionConverter.ConvertO(bodyCompany);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CleanseEmailResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidPhoneResponse> IsValidPhone(Expression<Func<string>> bodytelephoneNumber, Expression<Func<int>> bodydefaultCountry)
        {
            var apiCallPath = "/PhoneValidation/IsValid.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["telephoneNumber"] = ExpressionConverter.ConvertO(bodytelephoneNumber);
            bodypropCount++;
            body["defaultCountry"] = ExpressionConverter.ConvertO(bodydefaultCountry);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<IsValidPhoneResponse>(callPayload);
        }
    }

    public class Data8Triggers([ConnectionName] string connectionId)
    {
    }

    public class IsUsableNameResponse
    {
        public IsUsableNameResponseStatusType Status { get; set; }
        public IsUsableNameResponseResultType Result { get; set; }
    }

    public class IsUsableNameResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public enum IsUsableNameResponseResultType
    {
        [EnumMember(Value = "")]
        None,
        IncompleteName,
        RandomName,
        SalaciousName
    }

    public class IsCallableTPSResponse
    {
        public IsCallableTPSResponseStatusType Status { get; set; }
        public bool Callable { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public class IsCallableTPSResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsCallableCTPSResponse
    {
        public IsCallableCTPSResponseStatusType Status { get; set; }
        public bool Callable { get; set; }
        public string TelephoneNumber { get; set; }
    }

    public class IsCallableCTPSResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidBankAccountResponse
    {
        public IsValidBankAccountResponseStatusType Status { get; set; }
        public string Valid { get; set; }
        public string SortCode { get; set; }
        public string AccountNumber { get; set; }
        public string BICCode { get; set; }
        public string IBAN { get; set; }
        public string BranchName { get; set; }
        public string ShortBankName { get; set; }
        public string FullBankName { get; set; }
        public IsValidBankAccountResponseAddressType Address { get; set; }
        public bool AcceptsBACSPayments { get; set; }
        public bool AcceptsDirectDebitTransactions { get; set; }
        public bool AcceptsDirectCreditTransactions { get; set; }
        public bool AcceptsUnpaidChequeClaimTransactions { get; set; }
        public bool AcceptsBuildingSocietyCreditTransactions { get; set; }
        public bool AcceptsDividendInterestPaymentTransactions { get; set; }
        public bool AcceptsDirectDebitInstructionTransactions { get; set; }
        public bool AcceptsCHAPSPayments { get; set; }
        public bool AcceptsCheques { get; set; }
        public bool AcceptsFasterPayments { get; set; }
    }

    public class IsValidBankAccountResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidBankAccountResponseAddressType
    {
        public IsValidBankAccountResponseAddressTypeAddressType Address { get; set; }
    }

    public class IsValidBankAccountResponseAddressTypeAddressType
    {
        public string[] Lines { get; set; }
    }

    public class IsValidEmailResponse
    {
        public IsValidEmailResponseStatusType Status { get; set; }
        public string Result { get; set; }
    }

    public class IsValidEmailResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public enum bodylevelInput
    {
        Syntax,
        MX,
        Server,
        Address
    }

    public class IsValidTelephoneResponse
    {
        public IsValidTelephoneResponseStatusType Status { get; set; }
        public IsValidTelephoneResponseResultType Result { get; set; }
    }

    public class IsValidTelephoneResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidTelephoneResponseResultType
    {
        public string TelephoneNumber { get; set; }
        public string ValidationResult { get; set; }
        public string ValidationLevel { get; set; }
        public string NumberType { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    public class GetFullAddressResponse
    {
        public GetFullAddressResponseStatusType Status { get; set; }
        public int ResultCount { get; set; }
        public GetFullAddressResponseResultsTypeItem[] Results { get; set; }
    }

    public class GetFullAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItem
    {
        public GetFullAddressResponseResultsTypeItemAddressType Address { get; set; }
        public GetFullAddressResponseResultsTypeItemRawAddressType RawAddress { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemAddressType
    {
        public string[] Lines { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemRawAddressType
    {
        public string Organisation { get; set; }
        public string Department { get; set; }
        public int AddressKey { get; set; }
        public int OrganisationKey { get; set; }
        public string PostcodeType { get; set; }
        public int BuildingNumber { get; set; }
        public string SubBuildingName { get; set; }
        public string BuildingName { get; set; }
        public string DependentThoroughfareName { get; set; }
        public string DependentThoroughfareDesc { get; set; }
        public string ThoroughfareName { get; set; }
        public string ThoroughfareDesc { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
        public string Dps { get; set; }
        public string PoBox { get; set; }
        public string PostalCounty { get; set; }
        public string TraditionalCounty { get; set; }
        public string AdministrativeCounty { get; set; }
        public string CountryISO2 { get; set; }
        public string UniqueReference { get; set; }
        public GetFullAddressResponseResultsTypeItemRawAddressTypeLocationType Location { get; set; }
    }

    public class GetFullAddressResponseResultsTypeItemRawAddressTypeLocationType
    {
        public int Easting { get; set; }
        public int Northing { get; set; }
        public string GridReference { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string CountyCode { get; set; }
        public string County { get; set; }
        public string DistrictCode { get; set; }
        public string District { get; set; }
        public string WardCode { get; set; }
        public string Ward { get; set; }
        public string Country { get; set; }
    }

    public enum bodylicenceInput
    {
        InternalUserFull,
        InternalUserFullArea,
        SmallUserFull,
        WebClickFull,
        WebServerFull,
        Lookup,
        InternalServerFull,
        FreeTrial
    }

    public enum bodyoptionsFormatterInput
    {
        DefaultFormatter,
        PAFStandardFormatter,
        NoOrganisationFormatter
    }

    public class SearchPredictiveAddressResponse
    {
        public SearchPredictiveAddressResponseStatusType Status { get; set; }
        public SearchPredictiveAddressResponseResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }
        public string SessionID { get; set; }
    }

    public class SearchPredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class SearchPredictiveAddressResponseResultsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("container")]
        public bool Container { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }
    }

    public class DrilldownPredictiveAddressResponse
    {
        public DrilldownPredictiveAddressResponseStatusType Status { get; set; }
        public DrilldownPredictiveAddressResponseResultsTypeItem[] Results { get; set; }
        public int Count { get; set; }
        public string SessionID { get; set; }
    }

    public class DrilldownPredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class DrilldownPredictiveAddressResponseResultsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("container")]
        public bool Container { get; set; }

        [JsonProperty("items")]
        public int Items { get; set; }
    }

    public class RetrievePredictiveAddressResponse
    {
        public RetrievePredictiveAddressResponseStatusType Status { get; set; }
        public RetrievePredictiveAddressResponseResultType Result { get; set; }
    }

    public class RetrievePredictiveAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultType
    {
        public RetrievePredictiveAddressResponseResultTypeAddressType Address { get; set; }
        public RetrievePredictiveAddressResponseResultTypeRawAddressType RawAddress { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeAddressType
    {
        public string[] Lines { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeRawAddressType
    {
        public string Organisation { get; set; }
        public string Department { get; set; }
        public int AddressKey { get; set; }
        public int OrganisationKey { get; set; }
        public string PostcodeType { get; set; }
        public int BuildingNumber { get; set; }
        public string SubBuildingName { get; set; }
        public string BuildingName { get; set; }
        public string DependentThoroughfareName { get; set; }
        public string DependentThoroughfareDesc { get; set; }
        public string ThoroughfareName { get; set; }
        public string ThoroughfareDesc { get; set; }
        public string DoubleDependentLocality { get; set; }
        public string DependentLocality { get; set; }
        public string Locality { get; set; }
        public string Postcode { get; set; }
        public string Dps { get; set; }
        public string PoBox { get; set; }
        public string PostalCounty { get; set; }
        public string TraditionalCounty { get; set; }
        public string AdministrativeCounty { get; set; }
        public string CountryISO2 { get; set; }
        public string UniqueReference { get; set; }
        public RetrievePredictiveAddressResponseResultTypeRawAddressTypeLocationType Location { get; set; }
        public string AdditionalData { get; set; }
    }

    public class RetrievePredictiveAddressResponseResultTypeRawAddressTypeLocationType
    {
        public int Easting { get; set; }
        public int Northing { get; set; }
        public string GridReference { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string CountyCode { get; set; }
        public string County { get; set; }
        public string DistrictCode { get; set; }
        public string District { get; set; }
        public string WardCode { get; set; }
        public string Ward { get; set; }
        public string Country { get; set; }
    }

    public class CleanseEmailResponse
    {
        public CleanseEmailResponseStatusType Status { get; set; }
        public string Result { get; set; }
        public bool OriginalValid { get; set; }
        public string EmailType { get; set; }
        public string SuggestedEmailAddress { get; set; }
        public string Comment { get; set; }
        public string Salutation { get; set; }
        public string StructureUsed { get; set; }
        public string ParsedName { get; set; }
    }

    public class CleanseEmailResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public int CreditsRemaining { get; set; }
    }

    public enum bodyLevelInput
    {
        Syntax,
        MX,
        Server,
        Address
    }

    public class IsValidPhoneResponse
    {
        public IsValidPhoneResponseStatusType Status { get; set; }
        public IsValidPhoneResponseResultType Result { get; set; }
    }

    public class IsValidPhoneResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class IsValidPhoneResponseResultType
    {
        public string TelephoneNumber { get; set; }
        public string ValidationResult { get; set; }
        public string ValidationLevel { get; set; }
        public string NumberType { get; set; }
        public string Location { get; set; }
        public string Provider { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Data8;

    public partial class WorkflowManagedActions
    {
        public Data8Actions Data8(string connectionId) => new Data8Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Data8Triggers Data8(string connectionId) => new Data8Triggers(connectionId);
    }
}