//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Data8
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Data8Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsUsableNameResponse> IsUsableName(Expression<Func<string>> bodynametitle = null, Expression<Func<string>> bodynameforename = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesurname = null)
        {
            var __workflow_bodynametitle = WorkflowExpression.Compile(bodynametitle, nameof(bodynametitle), required: false);
            var __workflow_bodynameforename = WorkflowExpression.Compile(bodynameforename, nameof(bodynameforename), required: false);
            var __workflow_bodynamemiddleName = WorkflowExpression.Compile(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            var __workflow_bodynamesurname = WorkflowExpression.Compile(bodynamesurname, nameof(bodynamesurname), required: false);
            return new DeferredBodyAction<IsUsableNameResponse>(() =>
            {
                var apiCallPath = "/SalaciousName/IsUnusableName.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (__workflow_bodynametitle != null)
                {
                    nameObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodynametitle);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynameforename != null)
                {
                    nameObject["Forename"] = ExpressionConverter.ConvertO(__workflow_bodynameforename);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamemiddleName != null)
                {
                    nameObject["MiddleName"] = ExpressionConverter.ConvertO(__workflow_bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (__workflow_bodynamesurname != null)
                {
                    nameObject["Surname"] = ExpressionConverter.ConvertO(__workflow_bodynamesurname);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableTPSResponse> IsCallableTPS(Expression<Func<string>> bodynumber)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<IsCallableTPSResponse>(() =>
            {
                var apiCallPath = "/TPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IsCallableTPSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableCTPSResponse> IsCallableCTPS(Expression<Func<string>> bodynumber)
        {
            var __workflow_bodynumber = WorkflowExpression.Compile(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<IsCallableCTPSResponse>(() =>
            {
                var apiCallPath = "/CTPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = ExpressionConverter.ConvertO(__workflow_bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IsCallableCTPSResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidBankAccountResponse> IsValidBankAccount(Expression<Func<string>> bodysortCode, Expression<Func<string>> bodybankAccountNumber = null)
        {
            var __workflow_bodysortCode = WorkflowExpression.Compile(bodysortCode, nameof(bodysortCode), required: true);
            var __workflow_bodybankAccountNumber = WorkflowExpression.Compile(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            return new DeferredBodyAction<IsValidBankAccountResponse>(() =>
            {
                var apiCallPath = "/BankAccountValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sortCode"] = ExpressionConverter.ConvertO(__workflow_bodysortCode);
                if (__workflow_bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = ExpressionConverter.ConvertO(__workflow_bodybankAccountNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IsValidBankAccountResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidEmailResponse> IsValidEmail(Expression<Func<string>> bodyemail, Expression<Func<bodylevelInput>> bodylevel)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: true);
            return new DeferredBodyAction<IsValidEmailResponse>(() =>
            {
                var apiCallPath = "/EmailValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IsValidEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidTelephoneResponse> IsValidTelephone(Expression<Func<string>> bodytelephoneNumber, Expression<Func<string>> bodydefaultCountry, Expression<Func<bool>> bodyoptionsuseLineValidation = null, Expression<Func<bool>> bodyoptionsuseMobileValidation = null)
        {
            var __workflow_bodytelephoneNumber = WorkflowExpression.Compile(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            var __workflow_bodydefaultCountry = WorkflowExpression.Compile(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            var __workflow_bodyoptionsuseLineValidation = WorkflowExpression.Compile(bodyoptionsuseLineValidation, nameof(bodyoptionsuseLineValidation), required: false);
            var __workflow_bodyoptionsuseMobileValidation = WorkflowExpression.Compile(bodyoptionsuseMobileValidation, nameof(bodyoptionsuseMobileValidation), required: false);
            return new DeferredBodyAction<IsValidTelephoneResponse>(() =>
            {
                var apiCallPath = "/InternationalTelephoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["telephoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneNumber);
                bodypropCount++;
                body["defaultCountry"] = ExpressionConverter.ConvertO(__workflow_bodydefaultCountry);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsuseLineValidation != null)
                {
                    optionsObject["UseLineValidation"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseLineValidation);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsuseMobileValidation != null)
                {
                    optionsObject["UseMobileValidation"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseMobileValidation);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanAddressResponse> CleanAddress(Expression<Func<string[]>> bodyaddresslines = null, Expression<Func<string>> bodyoptionsdefaultCountryCode = null, Expression<Func<bool>> bodyoptionsdetectCountry = null, Expression<Func<string>> bodyoptionscountry = null, Expression<Func<bool>> bodyoptionsincludeCountry = null)
        {
            var __workflow_bodyaddresslines = WorkflowExpression.Compile(bodyaddresslines, nameof(bodyaddresslines), required: false);
            var __workflow_bodyoptionsdefaultCountryCode = WorkflowExpression.Compile(bodyoptionsdefaultCountryCode, nameof(bodyoptionsdefaultCountryCode), required: false);
            var __workflow_bodyoptionsdetectCountry = WorkflowExpression.Compile(bodyoptionsdetectCountry, nameof(bodyoptionsdetectCountry), required: false);
            var __workflow_bodyoptionscountry = WorkflowExpression.Compile(bodyoptionscountry, nameof(bodyoptionscountry), required: false);
            var __workflow_bodyoptionsincludeCountry = WorkflowExpression.Compile(bodyoptionsincludeCountry, nameof(bodyoptionsincludeCountry), required: false);
            return new DeferredBodyAction<CleanAddressResponse>(() =>
            {
                var apiCallPath = "/Postcoder/CleanAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyaddresslines != null)
                {
                    addressObject["Lines"] = ExpressionConverter.ConvertO(__workflow_bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsdefaultCountryCode != null)
                {
                    optionsObject["DefaultCountryCode"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsdefaultCountryCode);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsdetectCountry != null)
                {
                    optionsObject["DetectCountry"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsdetectCountry);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionscountry != null)
                {
                    optionsObject["Country"] = ExpressionConverter.ConvertO(__workflow_bodyoptionscountry);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeCountry != null)
                {
                    optionsObject["IncludeCountry"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeCountry);
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

                return new ApiConnectionAction<CleanAddressResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<GetFullAddressResponse> GetFullAddress(Expression<Func<bodylicenceInput>> bodylicence, Expression<Func<string>> bodypostcode, Expression<Func<string>> bodybuilding = null, Expression<Func<bool>> bodyoptionsfixTownCounty = null, Expression<Func<int>> bodyoptionsmaxLines = null, Expression<Func<int>> bodyoptionsmaxLineLength = null, Expression<Func<bool>> bodyoptionsnormalizeCase = null, Expression<Func<bool>> bodyoptionsnormalizeTownCase = null, Expression<Func<bool>> bodyoptionsexcludeCounty = null, Expression<Func<bool>> bodyoptionsuseAnyAvailableCounty = null, Expression<Func<bool>> bodyoptionsunwantedPunctuation = null, Expression<Func<bool>> bodyoptionsfixBuilding = null, Expression<Func<bool>> bodyoptionsincludeUDPRN = null, Expression<Func<bool>> bodyoptionsincludeLocation = null, Expression<Func<bool>> bodyoptionsreturnResultCount = null, Expression<Func<bool>> bodyoptionsincludeNYB = null, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bodyoptionsformatterInput>> bodyoptionsformatter = null)
        {
            var __workflow_bodylicence = WorkflowExpression.Compile(bodylicence, nameof(bodylicence), required: true);
            var __workflow_bodypostcode = WorkflowExpression.Compile(bodypostcode, nameof(bodypostcode), required: true);
            var __workflow_bodybuilding = WorkflowExpression.Compile(bodybuilding, nameof(bodybuilding), required: false);
            var __workflow_bodyoptionsfixTownCounty = WorkflowExpression.Compile(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            var __workflow_bodyoptionsmaxLines = WorkflowExpression.Compile(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            var __workflow_bodyoptionsmaxLineLength = WorkflowExpression.Compile(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            var __workflow_bodyoptionsnormalizeCase = WorkflowExpression.Compile(bodyoptionsnormalizeCase, nameof(bodyoptionsnormalizeCase), required: false);
            var __workflow_bodyoptionsnormalizeTownCase = WorkflowExpression.Compile(bodyoptionsnormalizeTownCase, nameof(bodyoptionsnormalizeTownCase), required: false);
            var __workflow_bodyoptionsexcludeCounty = WorkflowExpression.Compile(bodyoptionsexcludeCounty, nameof(bodyoptionsexcludeCounty), required: false);
            var __workflow_bodyoptionsuseAnyAvailableCounty = WorkflowExpression.Compile(bodyoptionsuseAnyAvailableCounty, nameof(bodyoptionsuseAnyAvailableCounty), required: false);
            var __workflow_bodyoptionsunwantedPunctuation = WorkflowExpression.Compile(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            var __workflow_bodyoptionsfixBuilding = WorkflowExpression.Compile(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            var __workflow_bodyoptionsincludeUDPRN = WorkflowExpression.Compile(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            var __workflow_bodyoptionsincludeLocation = WorkflowExpression.Compile(bodyoptionsincludeLocation, nameof(bodyoptionsincludeLocation), required: false);
            var __workflow_bodyoptionsreturnResultCount = WorkflowExpression.Compile(bodyoptionsreturnResultCount, nameof(bodyoptionsreturnResultCount), required: false);
            var __workflow_bodyoptionsincludeNYB = WorkflowExpression.Compile(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            var __workflow_bodyoptionsincludeMR = WorkflowExpression.Compile(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            var __workflow_bodyoptionsformatter = WorkflowExpression.Compile(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            return new DeferredBodyAction<GetFullAddressResponse>(() =>
            {
                var apiCallPath = "/AddressCapture/GetFullAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["licence"] = ExpressionConverter.ConvertO(__workflow_bodylicence);
                bodypropCount++;
                body["postcode"] = ExpressionConverter.ConvertO(__workflow_bodypostcode);
                if (__workflow_bodybuilding != null)
                {
                    body["building"] = ExpressionConverter.ConvertO(__workflow_bodybuilding);
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsfixTownCounty != null)
                {
                    optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsfixTownCounty);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsmaxLines != null)
                {
                    if (__workflow_bodyoptionsmaxLines != null)
                    {
                        optionsObject["MaxLines"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsmaxLines);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["MaxLines"] = 6;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsmaxLineLength != null)
                {
                    optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsmaxLineLength);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsnormalizeCase != null)
                {
                    optionsObject["NormalizeCase"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsnormalizeCase);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsnormalizeTownCase != null)
                {
                    optionsObject["NormalizeTownCase"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsnormalizeTownCase);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsexcludeCounty != null)
                {
                    optionsObject["ExcludeCounty"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsexcludeCounty);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsuseAnyAvailableCounty != null)
                {
                    optionsObject["UseAnyAvailableCounty"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsuseAnyAvailableCounty);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsunwantedPunctuation != null)
                {
                    optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsunwantedPunctuation);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsfixBuilding != null)
                {
                    optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsfixBuilding);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeUDPRN != null)
                {
                    optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeUDPRN);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeLocation != null)
                {
                    if (__workflow_bodyoptionsincludeLocation != null)
                    {
                        optionsObject["IncludeLocation"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeLocation);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["IncludeLocation"] = true;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsreturnResultCount != null)
                {
                    optionsObject["ReturnResultCount"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsreturnResultCount);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeNYB);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsformatter != null)
                {
                    optionsObject["Formatter"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsformatter);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsDeceasedResponse> IsDeceased(Expression<Func<string>> bodyrecordnamesurname, Expression<Func<string[]>> bodyrecordaddresslines, Expression<Func<bool>> bodymarketing, Expression<Func<string>> bodyrecordnametitle = null, Expression<Func<string>> bodyrecordnameforename = null, Expression<Func<string>> bodyrecordnamemiddleName = null, Expression<Func<bodyoptionsmatchLevelInput>> bodyoptionsmatchLevel = null)
        {
            var __workflow_bodyrecordnamesurname = WorkflowExpression.Compile(bodyrecordnamesurname, nameof(bodyrecordnamesurname), required: true);
            var __workflow_bodyrecordaddresslines = WorkflowExpression.Compile(bodyrecordaddresslines, nameof(bodyrecordaddresslines), required: true);
            var __workflow_bodymarketing = WorkflowExpression.Compile(bodymarketing, nameof(bodymarketing), required: true);
            var __workflow_bodyrecordnametitle = WorkflowExpression.Compile(bodyrecordnametitle, nameof(bodyrecordnametitle), required: false);
            var __workflow_bodyrecordnameforename = WorkflowExpression.Compile(bodyrecordnameforename, nameof(bodyrecordnameforename), required: false);
            var __workflow_bodyrecordnamemiddleName = WorkflowExpression.Compile(bodyrecordnamemiddleName, nameof(bodyrecordnamemiddleName), required: false);
            var __workflow_bodyoptionsmatchLevel = WorkflowExpression.Compile(bodyoptionsmatchLevel, nameof(bodyoptionsmatchLevel), required: false);
            return new DeferredBodyAction<IsDeceasedResponse>(() =>
            {
                var apiCallPath = "/Deceased/IsDeceased.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var recordObject = new JObject();
                var recordObjectpropCount = 0;
                var nameObject = new JObject();
                var nameObjectpropCount = 0;
                if (__workflow_bodyrecordnametitle != null)
                {
                    nameObject["Title"] = ExpressionConverter.ConvertO(__workflow_bodyrecordnametitle);
                    nameObjectpropCount++;
                }

                if (__workflow_bodyrecordnameforename != null)
                {
                    nameObject["Forename"] = ExpressionConverter.ConvertO(__workflow_bodyrecordnameforename);
                    nameObjectpropCount++;
                }

                if (__workflow_bodyrecordnamemiddleName != null)
                {
                    nameObject["MiddleName"] = ExpressionConverter.ConvertO(__workflow_bodyrecordnamemiddleName);
                    nameObjectpropCount++;
                }

                nameObjectpropCount++;
                nameObject["Surname"] = ExpressionConverter.ConvertO(__workflow_bodyrecordnamesurname);
                if (nameObjectpropCount > 0)
                {
                    recordObject["Name"] = nameObject;
                    recordObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["Lines"] = ExpressionConverter.ConvertO(__workflow_bodyrecordaddresslines);
                if (addressObjectpropCount > 0)
                {
                    recordObject["Address"] = addressObject;
                    recordObjectpropCount++;
                }

                if (recordObjectpropCount > 0)
                {
                    body["record"] = recordObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["marketing"] = ExpressionConverter.ConvertO(__workflow_bodymarketing);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsmatchLevel != null)
                {
                    if (__workflow_bodyoptionsmatchLevel != null)
                    {
                        optionsObject["MatchLevel"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsmatchLevel);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["MatchLevel"] = "I";
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

                return new ApiConnectionAction<IsDeceasedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> SearchPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodysearch, Expression<Func<string>> bodytelephoneNumber = null, Expression<Func<string>> bodysession = null, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bool>> bodyoptionsincludeNYB = null)
        {
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: true);
            var __workflow_bodysearch = WorkflowExpression.Compile(bodysearch, nameof(bodysearch), required: true);
            var __workflow_bodytelephoneNumber = WorkflowExpression.Compile(bodytelephoneNumber, nameof(bodytelephoneNumber), required: false);
            var __workflow_bodysession = WorkflowExpression.Compile(bodysession, nameof(bodysession), required: false);
            var __workflow_bodyoptionsincludeMR = WorkflowExpression.Compile(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            var __workflow_bodyoptionsincludeNYB = WorkflowExpression.Compile(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            return new DeferredBodyAction<SearchPredictiveAddressResponse>(() =>
            {
                var apiCallPath = "/PredictiveAddress/Search.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                bodypropCount++;
                body["search"] = ExpressionConverter.ConvertO(__workflow_bodysearch);
                if (__workflow_bodytelephoneNumber != null)
                {
                    body["telephoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneNumber);
                    bodypropCount++;
                }

                if (__workflow_bodysession != null)
                {
                    body["session"] = ExpressionConverter.ConvertO(__workflow_bodysession);
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeNYB);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> DrilldownPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bool>> bodyoptionsincludeNYB = null)
        {
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyoptionsincludeMR = WorkflowExpression.Compile(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            var __workflow_bodyoptionsincludeNYB = WorkflowExpression.Compile(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            return new DeferredBodyAction<DrilldownPredictiveAddressResponse>(() =>
            {
                var apiCallPath = "/PredictiveAddress/DrillDown.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeNYB);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> RetrievePredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<int>> bodyoptionsmaxLineLength = null, Expression<Func<int>> bodyoptionsmaxLines = null, Expression<Func<bool>> bodyoptionsfixTownCounty = null, Expression<Func<bool>> bodyoptionsfixPostcode = null, Expression<Func<bool>> bodyoptionsfixBuilding = null, Expression<Func<string>> bodyoptionsunwantedPunctuation = null, Expression<Func<bodyoptionsformatterInput>> bodyoptionsformatter = null, Expression<Func<bool>> bodyoptionsincludeUDPRN = null, Expression<Func<bool>> bodyoptionsincludeUPRN = null)
        {
            var __workflow_bodycountry = WorkflowExpression.Compile(bodycountry, nameof(bodycountry), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: true);
            var __workflow_bodyoptionsmaxLineLength = WorkflowExpression.Compile(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            var __workflow_bodyoptionsmaxLines = WorkflowExpression.Compile(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            var __workflow_bodyoptionsfixTownCounty = WorkflowExpression.Compile(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            var __workflow_bodyoptionsfixPostcode = WorkflowExpression.Compile(bodyoptionsfixPostcode, nameof(bodyoptionsfixPostcode), required: false);
            var __workflow_bodyoptionsfixBuilding = WorkflowExpression.Compile(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            var __workflow_bodyoptionsunwantedPunctuation = WorkflowExpression.Compile(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            var __workflow_bodyoptionsformatter = WorkflowExpression.Compile(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            var __workflow_bodyoptionsincludeUDPRN = WorkflowExpression.Compile(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            var __workflow_bodyoptionsincludeUPRN = WorkflowExpression.Compile(bodyoptionsincludeUPRN, nameof(bodyoptionsincludeUPRN), required: false);
            return new DeferredBodyAction<RetrievePredictiveAddressResponse>(() =>
            {
                var apiCallPath = "/PredictiveAddress/Retrieve.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = ExpressionConverter.ConvertO(__workflow_bodycountry);
                bodypropCount++;
                body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsmaxLineLength != null)
                {
                    if (__workflow_bodyoptionsmaxLineLength != null)
                    {
                        optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsmaxLineLength);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["MaxLineLength"] = 100;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsmaxLines != null)
                {
                    if (__workflow_bodyoptionsmaxLines != null)
                    {
                        optionsObject["MaxLines"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsmaxLines);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["MaxLines"] = 5;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsfixTownCounty != null)
                {
                    if (__workflow_bodyoptionsfixTownCounty != null)
                    {
                        optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsfixTownCounty);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["FixTownCounty"] = false;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsfixPostcode != null)
                {
                    if (__workflow_bodyoptionsfixPostcode != null)
                    {
                        optionsObject["FixPostcode"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsfixPostcode);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["FixPostcode"] = false;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsfixBuilding != null)
                {
                    if (__workflow_bodyoptionsfixBuilding != null)
                    {
                        optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsfixBuilding);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["FixBuilding"] = false;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsunwantedPunctuation != null)
                {
                    optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsunwantedPunctuation);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsformatter != null)
                {
                    if (__workflow_bodyoptionsformatter != null)
                    {
                        optionsObject["Formatter"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsformatter);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["Formatter"] = "DefaultFormatter";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeUDPRN != null)
                {
                    if (__workflow_bodyoptionsincludeUDPRN != null)
                    {
                        optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeUDPRN);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["IncludeUDPRN"] = false;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsincludeUPRN != null)
                {
                    if (__workflow_bodyoptionsincludeUPRN != null)
                    {
                        optionsObject["IncludeUPRN"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsincludeUPRN);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["IncludeUPRN"] = false;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanseEmailResponse> CleanseEmail(Expression<Func<string>> bodyemail, Expression<Func<bodylevelInput>> bodylevel, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyforename = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodysurname = null, Expression<Func<string>> bodycompany = null)
        {
            var __workflow_bodyemail = WorkflowExpression.Compile(bodyemail, nameof(bodyemail), required: true);
            var __workflow_bodylevel = WorkflowExpression.Compile(bodylevel, nameof(bodylevel), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: false);
            var __workflow_bodyforename = WorkflowExpression.Compile(bodyforename, nameof(bodyforename), required: false);
            var __workflow_bodymiddleName = WorkflowExpression.Compile(bodymiddleName, nameof(bodymiddleName), required: false);
            var __workflow_bodysurname = WorkflowExpression.Compile(bodysurname, nameof(bodysurname), required: false);
            var __workflow_bodycompany = WorkflowExpression.Compile(bodycompany, nameof(bodycompany), required: false);
            return new DeferredBodyAction<CleanseEmailResponse>(() =>
            {
                var apiCallPath = "/EmailValidation/CleanseSimple.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = ExpressionConverter.ConvertO(__workflow_bodyemail);
                bodypropCount++;
                body["Level"] = ExpressionConverter.ConvertO(__workflow_bodylevel);
                if (__workflow_bodytitle != null)
                {
                    body["Title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                    bodypropCount++;
                }

                if (__workflow_bodyforename != null)
                {
                    body["Forename"] = ExpressionConverter.ConvertO(__workflow_bodyforename);
                    bodypropCount++;
                }

                if (__workflow_bodymiddleName != null)
                {
                    body["MiddleName"] = ExpressionConverter.ConvertO(__workflow_bodymiddleName);
                    bodypropCount++;
                }

                if (__workflow_bodysurname != null)
                {
                    body["Surname"] = ExpressionConverter.ConvertO(__workflow_bodysurname);
                    bodypropCount++;
                }

                if (__workflow_bodycompany != null)
                {
                    body["Company"] = ExpressionConverter.ConvertO(__workflow_bodycompany);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CleanseEmailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidPhoneResponse> IsValidPhone(Expression<Func<string>> bodytelephoneNumber, Expression<Func<int>> bodydefaultCountry)
        {
            var __workflow_bodytelephoneNumber = WorkflowExpression.Compile(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            var __workflow_bodydefaultCountry = WorkflowExpression.Compile(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            return new DeferredBodyAction<IsValidPhoneResponse>(() =>
            {
                var apiCallPath = "/PhoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["telephoneNumber"] = ExpressionConverter.ConvertO(__workflow_bodytelephoneNumber);
                bodypropCount++;
                body["defaultCountry"] = ExpressionConverter.ConvertO(__workflow_bodydefaultCountry);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<IsValidPhoneResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    public class CleanAddressResponse
    {
        public CleanAddressResponseStatusType Status { get; set; }
        public CleanAddressResponseResultType Result { get; set; }
        public string MatchLevel { get; set; }
        public string CountryName { get; set; }
    }

    public class CleanAddressResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    public class CleanAddressResponseResultType
    {
        public CleanAddressResponseResultTypeAddressType Address { get; set; }
    }

    public class CleanAddressResponseResultTypeAddressType
    {
        public string[] Lines { get; set; }
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionsformatterInput
    {
        DefaultFormatter,
        PAFStandardFormatter,
        NoOrganisationFormatter
    }

    public class IsDeceasedResponse
    {
        public IsDeceasedResponseStatusType Status { get; set; }
        public bool Result { get; set; }
    }

    public class IsDeceasedResponseStatusType
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
        public double CreditsRemaining { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionsmatchLevelInput
    {
        S,
        I,
        F
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Data8;

    public partial class WorkflowManagedActions
    {
        public Data8Actions Data8(string connectionId) => new Data8Actions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public Data8Triggers Data8(string connectionId) => new Data8Triggers(connectionId);
    }
}
