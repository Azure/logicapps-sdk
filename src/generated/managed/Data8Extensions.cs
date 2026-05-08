//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Data8
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Data8Actions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsUsableNameResponse> IsUsableName(Expression<Func<string>> bodynametitle = null, Expression<Func<string>> bodynameforename = null, Expression<Func<string>> bodynamemiddleName = null, Expression<Func<string>> bodynamesurname = null)
        {
            var apiCallPath = "/SalaciousName/IsUnusableName.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var nameObject = new JObject();
            var nameObjectpropCount = 0;
            if (bodynametitle != null)
            {
                nameObject["Title"] = ExpressionConverter.ConvertO(bodynametitle);
                nameObjectpropCount++;
            }

            if (bodynameforename != null)
            {
                nameObject["Forename"] = ExpressionConverter.ConvertO(bodynameforename);
                nameObjectpropCount++;
            }

            if (bodynamemiddleName != null)
            {
                nameObject["MiddleName"] = ExpressionConverter.ConvertO(bodynamemiddleName);
                nameObjectpropCount++;
            }

            if (bodynamesurname != null)
            {
                nameObject["Surname"] = ExpressionConverter.ConvertO(bodynamesurname);
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
        public IBodyWorkflowAction<IsValidTelephoneResponse> IsValidTelephone(Expression<Func<string>> bodytelephoneNumber, Expression<Func<string>> bodydefaultCountry, Expression<Func<bool>> bodyoptionsuseLineValidation = null, Expression<Func<bool>> bodyoptionsuseMobileValidation = null)
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
            if (bodyoptionsuseLineValidation != null)
            {
                optionsObject["UseLineValidation"] = ExpressionConverter.ConvertO(bodyoptionsuseLineValidation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseMobileValidation != null)
            {
                optionsObject["UseMobileValidation"] = ExpressionConverter.ConvertO(bodyoptionsuseMobileValidation);
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
        public IBodyWorkflowAction<CleanAddressResponse> CleanAddress(Expression<Func<string[]>> bodyaddresslines = null, Expression<Func<string>> bodyoptionsdefaultCountryCode = null, Expression<Func<bool>> bodyoptionsdetectCountry = null, Expression<Func<string>> bodyoptionscountry = null, Expression<Func<bool>> bodyoptionsincludeCountry = null)
        {
            var apiCallPath = "/Postcoder/CleanAddress.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyaddresslines != null)
            {
                addressObject["Lines"] = ExpressionConverter.ConvertO(bodyaddresslines);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                body["address"] = addressObject;
                bodypropCount++;
            }

            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsdefaultCountryCode != null)
            {
                optionsObject["DefaultCountryCode"] = ExpressionConverter.ConvertO(bodyoptionsdefaultCountryCode);
                optionsObjectpropCount++;
            }

            if (bodyoptionsdetectCountry != null)
            {
                optionsObject["DetectCountry"] = ExpressionConverter.ConvertO(bodyoptionsdetectCountry);
                optionsObjectpropCount++;
            }

            if (bodyoptionscountry != null)
            {
                optionsObject["Country"] = ExpressionConverter.ConvertO(bodyoptionscountry);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeCountry != null)
            {
                optionsObject["IncludeCountry"] = ExpressionConverter.ConvertO(bodyoptionsincludeCountry);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<GetFullAddressResponse> GetFullAddress(Expression<Func<bodylicenceInput>> bodylicence, Expression<Func<string>> bodypostcode, Expression<Func<string>> bodybuilding = null, Expression<Func<bool>> bodyoptionsfixTownCounty = null, Expression<Func<int>> bodyoptionsmaxLines = null, Expression<Func<int>> bodyoptionsmaxLineLength = null, Expression<Func<bool>> bodyoptionsnormalizeCase = null, Expression<Func<bool>> bodyoptionsnormalizeTownCase = null, Expression<Func<bool>> bodyoptionsexcludeCounty = null, Expression<Func<bool>> bodyoptionsuseAnyAvailableCounty = null, Expression<Func<bool>> bodyoptionsunwantedPunctuation = null, Expression<Func<bool>> bodyoptionsfixBuilding = null, Expression<Func<bool>> bodyoptionsincludeUDPRN = null, Expression<Func<bool>> bodyoptionsincludeLocation = null, Expression<Func<bool>> bodyoptionsreturnResultCount = null, Expression<Func<bool>> bodyoptionsincludeNYB = null, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bodyoptionsformatterInput>> bodyoptionsformatter = null)
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
            if (bodyoptionsfixTownCounty != null)
            {
                optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(bodyoptionsfixTownCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsmaxLines != null)
            {
                if (bodyoptionsmaxLines != null)
                {
                    optionsObject["MaxLines"] = ExpressionConverter.ConvertO(bodyoptionsmaxLines);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["MaxLines"] = 6;
                optionsObjectpropCount++;
            }

            if (bodyoptionsmaxLineLength != null)
            {
                optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(bodyoptionsmaxLineLength);
                optionsObjectpropCount++;
            }

            if (bodyoptionsnormalizeCase != null)
            {
                optionsObject["NormalizeCase"] = ExpressionConverter.ConvertO(bodyoptionsnormalizeCase);
                optionsObjectpropCount++;
            }

            if (bodyoptionsnormalizeTownCase != null)
            {
                optionsObject["NormalizeTownCase"] = ExpressionConverter.ConvertO(bodyoptionsnormalizeTownCase);
                optionsObjectpropCount++;
            }

            if (bodyoptionsexcludeCounty != null)
            {
                optionsObject["ExcludeCounty"] = ExpressionConverter.ConvertO(bodyoptionsexcludeCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsuseAnyAvailableCounty != null)
            {
                optionsObject["UseAnyAvailableCounty"] = ExpressionConverter.ConvertO(bodyoptionsuseAnyAvailableCounty);
                optionsObjectpropCount++;
            }

            if (bodyoptionsunwantedPunctuation != null)
            {
                optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(bodyoptionsunwantedPunctuation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsfixBuilding != null)
            {
                optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(bodyoptionsfixBuilding);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeUDPRN != null)
            {
                optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(bodyoptionsincludeUDPRN);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeLocation != null)
            {
                if (bodyoptionsincludeLocation != null)
                {
                    optionsObject["IncludeLocation"] = ExpressionConverter.ConvertO(bodyoptionsincludeLocation);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["IncludeLocation"] = true;
                optionsObjectpropCount++;
            }

            if (bodyoptionsreturnResultCount != null)
            {
                optionsObject["ReturnResultCount"] = ExpressionConverter.ConvertO(bodyoptionsreturnResultCount);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsincludeNYB);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsincludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsformatter != null)
            {
                optionsObject["Formatter"] = ExpressionConverter.ConvertO(bodyoptionsformatter);
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
        public IBodyWorkflowAction<IsDeceasedResponse> IsDeceased(Expression<Func<string>> bodyrecordnamesurname, Expression<Func<string[]>> bodyrecordaddresslines, Expression<Func<bool>> bodymarketing, Expression<Func<string>> bodyrecordnametitle = null, Expression<Func<string>> bodyrecordnameforename = null, Expression<Func<string>> bodyrecordnamemiddleName = null, Expression<Func<bodyoptionsmatchLevelInput>> bodyoptionsmatchLevel = null)
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
            if (bodyrecordnametitle != null)
            {
                nameObject["Title"] = ExpressionConverter.ConvertO(bodyrecordnametitle);
                nameObjectpropCount++;
            }

            if (bodyrecordnameforename != null)
            {
                nameObject["Forename"] = ExpressionConverter.ConvertO(bodyrecordnameforename);
                nameObjectpropCount++;
            }

            if (bodyrecordnamemiddleName != null)
            {
                nameObject["MiddleName"] = ExpressionConverter.ConvertO(bodyrecordnamemiddleName);
                nameObjectpropCount++;
            }

            nameObjectpropCount++;
            nameObject["Surname"] = ExpressionConverter.ConvertO(bodyrecordnamesurname);
            if (nameObjectpropCount > 0)
            {
                recordObject["Name"] = nameObject;
                recordObjectpropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            addressObjectpropCount++;
            addressObject["Lines"] = ExpressionConverter.ConvertO(bodyrecordaddresslines);
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
            body["marketing"] = ExpressionConverter.ConvertO(bodymarketing);
            var optionsObject = new JObject();
            var optionsObjectpropCount = 0;
            if (bodyoptionsmatchLevel != null)
            {
                if (bodyoptionsmatchLevel != null)
                {
                    optionsObject["MatchLevel"] = ExpressionConverter.ConvertO(bodyoptionsmatchLevel);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> SearchPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodysearch, Expression<Func<string>> bodytelephoneNumber = null, Expression<Func<string>> bodysession = null, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bool>> bodyoptionsincludeNYB = null)
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
            if (bodyoptionsincludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsincludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsincludeNYB);
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
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> DrilldownPredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<bool>> bodyoptionsincludeMR = null, Expression<Func<bool>> bodyoptionsincludeNYB = null)
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
            if (bodyoptionsincludeMR != null)
            {
                optionsObject["IncludeMR"] = ExpressionConverter.ConvertO(bodyoptionsincludeMR);
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeNYB != null)
            {
                optionsObject["IncludeNYB"] = ExpressionConverter.ConvertO(bodyoptionsincludeNYB);
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
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> RetrievePredictiveAddress(Expression<Func<string>> bodycountry, Expression<Func<string>> bodyid, Expression<Func<int>> bodyoptionsmaxLineLength = null, Expression<Func<int>> bodyoptionsmaxLines = null, Expression<Func<bool>> bodyoptionsfixTownCounty = null, Expression<Func<bool>> bodyoptionsfixPostcode = null, Expression<Func<bool>> bodyoptionsfixBuilding = null, Expression<Func<string>> bodyoptionsunwantedPunctuation = null, Expression<Func<bodyoptionsformatterInput>> bodyoptionsformatter = null, Expression<Func<bool>> bodyoptionsincludeUDPRN = null, Expression<Func<bool>> bodyoptionsincludeUPRN = null)
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
            if (bodyoptionsmaxLineLength != null)
            {
                if (bodyoptionsmaxLineLength != null)
                {
                    optionsObject["MaxLineLength"] = ExpressionConverter.ConvertO(bodyoptionsmaxLineLength);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["MaxLineLength"] = 100;
                optionsObjectpropCount++;
            }

            if (bodyoptionsmaxLines != null)
            {
                if (bodyoptionsmaxLines != null)
                {
                    optionsObject["MaxLines"] = ExpressionConverter.ConvertO(bodyoptionsmaxLines);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["MaxLines"] = 5;
                optionsObjectpropCount++;
            }

            if (bodyoptionsfixTownCounty != null)
            {
                if (bodyoptionsfixTownCounty != null)
                {
                    optionsObject["FixTownCounty"] = ExpressionConverter.ConvertO(bodyoptionsfixTownCounty);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["FixTownCounty"] = false;
                optionsObjectpropCount++;
            }

            if (bodyoptionsfixPostcode != null)
            {
                if (bodyoptionsfixPostcode != null)
                {
                    optionsObject["FixPostcode"] = ExpressionConverter.ConvertO(bodyoptionsfixPostcode);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["FixPostcode"] = false;
                optionsObjectpropCount++;
            }

            if (bodyoptionsfixBuilding != null)
            {
                if (bodyoptionsfixBuilding != null)
                {
                    optionsObject["FixBuilding"] = ExpressionConverter.ConvertO(bodyoptionsfixBuilding);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["FixBuilding"] = false;
                optionsObjectpropCount++;
            }

            if (bodyoptionsunwantedPunctuation != null)
            {
                optionsObject["UnwantedPunctuation"] = ExpressionConverter.ConvertO(bodyoptionsunwantedPunctuation);
                optionsObjectpropCount++;
            }

            if (bodyoptionsformatter != null)
            {
                if (bodyoptionsformatter != null)
                {
                    optionsObject["Formatter"] = ExpressionConverter.ConvertO(bodyoptionsformatter);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["Formatter"] = "DefaultFormatter";
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeUDPRN != null)
            {
                if (bodyoptionsincludeUDPRN != null)
                {
                    optionsObject["IncludeUDPRN"] = ExpressionConverter.ConvertO(bodyoptionsincludeUDPRN);
                    optionsObjectpropCount++;
                }

                optionsObjectpropCount++;
            }
            else
            {
                optionsObject["IncludeUDPRN"] = false;
                optionsObjectpropCount++;
            }

            if (bodyoptionsincludeUPRN != null)
            {
                if (bodyoptionsincludeUPRN != null)
                {
                    optionsObject["IncludeUPRN"] = ExpressionConverter.ConvertO(bodyoptionsincludeUPRN);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanseEmailResponse> CleanseEmail(Expression<Func<string>> bodyemail, Expression<Func<bodylevelInput>> bodylevel, Expression<Func<string>> bodytitle = null, Expression<Func<string>> bodyforename = null, Expression<Func<string>> bodymiddleName = null, Expression<Func<string>> bodysurname = null, Expression<Func<string>> bodycompany = null)
        {
            var apiCallPath = "/EmailValidation/CleanseSimple.json";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["Email"] = ExpressionConverter.ConvertO(bodyemail);
            bodypropCount++;
            body["Level"] = ExpressionConverter.ConvertO(bodylevel);
            if (bodytitle != null)
            {
                body["Title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
            }

            if (bodyforename != null)
            {
                body["Forename"] = ExpressionConverter.ConvertO(bodyforename);
                bodypropCount++;
            }

            if (bodymiddleName != null)
            {
                body["MiddleName"] = ExpressionConverter.ConvertO(bodymiddleName);
                bodypropCount++;
            }

            if (bodysurname != null)
            {
                body["Surname"] = ExpressionConverter.ConvertO(bodysurname);
                bodypropCount++;
            }

            if (bodycompany != null)
            {
                body["Company"] = ExpressionConverter.ConvertO(bodycompany);
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