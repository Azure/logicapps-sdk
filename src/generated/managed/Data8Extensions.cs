//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Data8
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class Data8Actions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsUsableName))]
        public IBodyWorkflowAction<IsUsableNameResponse> IsUsableName([WorkflowExpression] Func<string> bodynametitle = null, [WorkflowExpression] Func<string> bodynameforename = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesurname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsUsableNameResponse> __BuildIsUsableName(WorkflowExpression<string> bodynametitle = null, WorkflowExpression<string> bodynameforename = null, WorkflowExpression<string> bodynamemiddleName = null, WorkflowExpression<string> bodynamesurname = null)
        {
            WorkflowExpression.Validate(bodynametitle, nameof(bodynametitle), required: false);
            WorkflowExpression.Validate(bodynameforename, nameof(bodynameforename), required: false);
            WorkflowExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            WorkflowExpression.Validate(bodynamesurname, nameof(bodynamesurname), required: false);
            return new DeferredBodyAction<IsUsableNameResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsCallableTPS))]
        public IBodyWorkflowAction<IsCallableTPSResponse> IsCallableTPS([WorkflowExpression] Func<string> bodynumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsCallableTPSResponse> __BuildIsCallableTPS(WorkflowExpression<string> bodynumber)
        {
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<IsCallableTPSResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsCallableCTPS))]
        public IBodyWorkflowAction<IsCallableCTPSResponse> IsCallableCTPS([WorkflowExpression] Func<string> bodynumber)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsCallableCTPSResponse> __BuildIsCallableCTPS(WorkflowExpression<string> bodynumber)
        {
            WorkflowExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            return new DeferredBodyAction<IsCallableCTPSResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsValidBankAccount))]
        public IBodyWorkflowAction<IsValidBankAccountResponse> IsValidBankAccount([WorkflowExpression] Func<string> bodysortCode, [WorkflowExpression] Func<string> bodybankAccountNumber = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsValidBankAccountResponse> __BuildIsValidBankAccount(WorkflowExpression<string> bodysortCode, WorkflowExpression<string> bodybankAccountNumber = null)
        {
            WorkflowExpression.Validate(bodysortCode, nameof(bodysortCode), required: true);
            WorkflowExpression.Validate(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            return new DeferredBodyAction<IsValidBankAccountResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsValidEmail))]
        public IBodyWorkflowAction<IsValidEmailResponse> IsValidEmail([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodylevelInput> bodylevel)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsValidEmailResponse> __BuildIsValidEmail(WorkflowExpression<string> bodyemail, WorkflowExpression<bodylevelInput> bodylevel)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: true);
            return new DeferredBodyAction<IsValidEmailResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsValidTelephone))]
        public IBodyWorkflowAction<IsValidTelephoneResponse> IsValidTelephone([WorkflowExpression] Func<string> bodytelephoneNumber, [WorkflowExpression] Func<string> bodydefaultCountry, [WorkflowExpression] Func<bool> bodyoptionsuseLineValidation = null, [WorkflowExpression] Func<bool> bodyoptionsuseMobileValidation = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsValidTelephoneResponse> __BuildIsValidTelephone(WorkflowExpression<string> bodytelephoneNumber, WorkflowExpression<string> bodydefaultCountry, WorkflowExpression<bool> bodyoptionsuseLineValidation = null, WorkflowExpression<bool> bodyoptionsuseMobileValidation = null)
        {
            WorkflowExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            WorkflowExpression.Validate(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            WorkflowExpression.Validate(bodyoptionsuseLineValidation, nameof(bodyoptionsuseLineValidation), required: false);
            WorkflowExpression.Validate(bodyoptionsuseMobileValidation, nameof(bodyoptionsuseMobileValidation), required: false);
            return new DeferredBodyAction<IsValidTelephoneResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildCleanAddress))]
        public IBodyWorkflowAction<CleanAddressResponse> CleanAddress([WorkflowExpression] Func<string[]> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyoptionsdefaultCountryCode = null, [WorkflowExpression] Func<bool> bodyoptionsdetectCountry = null, [WorkflowExpression] Func<string> bodyoptionscountry = null, [WorkflowExpression] Func<bool> bodyoptionsincludeCountry = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CleanAddressResponse> __BuildCleanAddress(WorkflowExpression<string[]> bodyaddresslines = null, WorkflowExpression<string> bodyoptionsdefaultCountryCode = null, WorkflowExpression<bool> bodyoptionsdetectCountry = null, WorkflowExpression<string> bodyoptionscountry = null, WorkflowExpression<bool> bodyoptionsincludeCountry = null)
        {
            WorkflowExpression.Validate(bodyaddresslines, nameof(bodyaddresslines), required: false);
            WorkflowExpression.Validate(bodyoptionsdefaultCountryCode, nameof(bodyoptionsdefaultCountryCode), required: false);
            WorkflowExpression.Validate(bodyoptionsdetectCountry, nameof(bodyoptionsdetectCountry), required: false);
            WorkflowExpression.Validate(bodyoptionscountry, nameof(bodyoptionscountry), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeCountry, nameof(bodyoptionsincludeCountry), required: false);
            return new DeferredBodyAction<CleanAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildGetFullAddress))]
        public IBodyWorkflowAction<GetFullAddressResponse> GetFullAddress([WorkflowExpression] Func<bodylicenceInput> bodylicence, [WorkflowExpression] Func<string> bodypostcode, [WorkflowExpression] Func<string> bodybuilding = null, [WorkflowExpression] Func<bool> bodyoptionsfixTownCounty = null, [WorkflowExpression] Func<int> bodyoptionsmaxLines = null, [WorkflowExpression] Func<int> bodyoptionsmaxLineLength = null, [WorkflowExpression] Func<bool> bodyoptionsnormalizeCase = null, [WorkflowExpression] Func<bool> bodyoptionsnormalizeTownCase = null, [WorkflowExpression] Func<bool> bodyoptionsexcludeCounty = null, [WorkflowExpression] Func<bool> bodyoptionsuseAnyAvailableCounty = null, [WorkflowExpression] Func<bool> bodyoptionsunwantedPunctuation = null, [WorkflowExpression] Func<bool> bodyoptionsfixBuilding = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUDPRN = null, [WorkflowExpression] Func<bool> bodyoptionsincludeLocation = null, [WorkflowExpression] Func<bool> bodyoptionsreturnResultCount = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bodyoptionsformatterInput> bodyoptionsformatter = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFullAddressResponse> __BuildGetFullAddress(WorkflowExpression<bodylicenceInput> bodylicence, WorkflowExpression<string> bodypostcode, WorkflowExpression<string> bodybuilding = null, WorkflowExpression<bool> bodyoptionsfixTownCounty = null, WorkflowExpression<int> bodyoptionsmaxLines = null, WorkflowExpression<int> bodyoptionsmaxLineLength = null, WorkflowExpression<bool> bodyoptionsnormalizeCase = null, WorkflowExpression<bool> bodyoptionsnormalizeTownCase = null, WorkflowExpression<bool> bodyoptionsexcludeCounty = null, WorkflowExpression<bool> bodyoptionsuseAnyAvailableCounty = null, WorkflowExpression<bool> bodyoptionsunwantedPunctuation = null, WorkflowExpression<bool> bodyoptionsfixBuilding = null, WorkflowExpression<bool> bodyoptionsincludeUDPRN = null, WorkflowExpression<bool> bodyoptionsincludeLocation = null, WorkflowExpression<bool> bodyoptionsreturnResultCount = null, WorkflowExpression<bool> bodyoptionsincludeNYB = null, WorkflowExpression<bool> bodyoptionsincludeMR = null, WorkflowExpression<bodyoptionsformatterInput> bodyoptionsformatter = null)
        {
            WorkflowExpression.Validate(bodylicence, nameof(bodylicence), required: true);
            WorkflowExpression.Validate(bodypostcode, nameof(bodypostcode), required: true);
            WorkflowExpression.Validate(bodybuilding, nameof(bodybuilding), required: false);
            WorkflowExpression.Validate(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            WorkflowExpression.Validate(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            WorkflowExpression.Validate(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            WorkflowExpression.Validate(bodyoptionsnormalizeCase, nameof(bodyoptionsnormalizeCase), required: false);
            WorkflowExpression.Validate(bodyoptionsnormalizeTownCase, nameof(bodyoptionsnormalizeTownCase), required: false);
            WorkflowExpression.Validate(bodyoptionsexcludeCounty, nameof(bodyoptionsexcludeCounty), required: false);
            WorkflowExpression.Validate(bodyoptionsuseAnyAvailableCounty, nameof(bodyoptionsuseAnyAvailableCounty), required: false);
            WorkflowExpression.Validate(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            WorkflowExpression.Validate(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeLocation, nameof(bodyoptionsincludeLocation), required: false);
            WorkflowExpression.Validate(bodyoptionsreturnResultCount, nameof(bodyoptionsreturnResultCount), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            WorkflowExpression.Validate(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            return new DeferredBodyAction<GetFullAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsDeceased))]
        public IBodyWorkflowAction<IsDeceasedResponse> IsDeceased([WorkflowExpression] Func<string> bodyrecordnamesurname, [WorkflowExpression] Func<string[]> bodyrecordaddresslines, [WorkflowExpression] Func<bool> bodymarketing, [WorkflowExpression] Func<string> bodyrecordnametitle = null, [WorkflowExpression] Func<string> bodyrecordnameforename = null, [WorkflowExpression] Func<string> bodyrecordnamemiddleName = null, [WorkflowExpression] Func<bodyoptionsmatchLevelInput> bodyoptionsmatchLevel = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsDeceasedResponse> __BuildIsDeceased(WorkflowExpression<string> bodyrecordnamesurname, WorkflowExpression<string[]> bodyrecordaddresslines, WorkflowExpression<bool> bodymarketing, WorkflowExpression<string> bodyrecordnametitle = null, WorkflowExpression<string> bodyrecordnameforename = null, WorkflowExpression<string> bodyrecordnamemiddleName = null, WorkflowExpression<bodyoptionsmatchLevelInput> bodyoptionsmatchLevel = null)
        {
            WorkflowExpression.Validate(bodyrecordnamesurname, nameof(bodyrecordnamesurname), required: true);
            WorkflowExpression.Validate(bodyrecordaddresslines, nameof(bodyrecordaddresslines), required: true);
            WorkflowExpression.Validate(bodymarketing, nameof(bodymarketing), required: true);
            WorkflowExpression.Validate(bodyrecordnametitle, nameof(bodyrecordnametitle), required: false);
            WorkflowExpression.Validate(bodyrecordnameforename, nameof(bodyrecordnameforename), required: false);
            WorkflowExpression.Validate(bodyrecordnamemiddleName, nameof(bodyrecordnamemiddleName), required: false);
            WorkflowExpression.Validate(bodyoptionsmatchLevel, nameof(bodyoptionsmatchLevel), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildSearchPredictiveAddress))]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> SearchPredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodysearch, [WorkflowExpression] Func<string> bodytelephoneNumber = null, [WorkflowExpression] Func<string> bodysession = null, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> __BuildSearchPredictiveAddress(WorkflowExpression<string> bodycountry, WorkflowExpression<string> bodysearch, WorkflowExpression<string> bodytelephoneNumber = null, WorkflowExpression<string> bodysession = null, WorkflowExpression<bool> bodyoptionsincludeMR = null, WorkflowExpression<bool> bodyoptionsincludeNYB = null)
        {
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            WorkflowExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            WorkflowExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: false);
            WorkflowExpression.Validate(bodysession, nameof(bodysession), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            return new DeferredBodyAction<SearchPredictiveAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildDrilldownPredictiveAddress))]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> DrilldownPredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> __BuildDrilldownPredictiveAddress(WorkflowExpression<string> bodycountry, WorkflowExpression<string> bodyid, WorkflowExpression<bool> bodyoptionsincludeMR = null, WorkflowExpression<bool> bodyoptionsincludeNYB = null)
        {
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            return new DeferredBodyAction<DrilldownPredictiveAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildRetrievePredictiveAddress))]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> RetrievePredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<int> bodyoptionsmaxLineLength = null, [WorkflowExpression] Func<int> bodyoptionsmaxLines = null, [WorkflowExpression] Func<bool> bodyoptionsfixTownCounty = null, [WorkflowExpression] Func<bool> bodyoptionsfixPostcode = null, [WorkflowExpression] Func<bool> bodyoptionsfixBuilding = null, [WorkflowExpression] Func<string> bodyoptionsunwantedPunctuation = null, [WorkflowExpression] Func<bodyoptionsformatterInput> bodyoptionsformatter = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUDPRN = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUPRN = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> __BuildRetrievePredictiveAddress(WorkflowExpression<string> bodycountry, WorkflowExpression<string> bodyid, WorkflowExpression<int> bodyoptionsmaxLineLength = null, WorkflowExpression<int> bodyoptionsmaxLines = null, WorkflowExpression<bool> bodyoptionsfixTownCounty = null, WorkflowExpression<bool> bodyoptionsfixPostcode = null, WorkflowExpression<bool> bodyoptionsfixBuilding = null, WorkflowExpression<string> bodyoptionsunwantedPunctuation = null, WorkflowExpression<bodyoptionsformatterInput> bodyoptionsformatter = null, WorkflowExpression<bool> bodyoptionsincludeUDPRN = null, WorkflowExpression<bool> bodyoptionsincludeUPRN = null)
        {
            WorkflowExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: true);
            WorkflowExpression.Validate(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            WorkflowExpression.Validate(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            WorkflowExpression.Validate(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            WorkflowExpression.Validate(bodyoptionsfixPostcode, nameof(bodyoptionsfixPostcode), required: false);
            WorkflowExpression.Validate(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            WorkflowExpression.Validate(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            WorkflowExpression.Validate(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            WorkflowExpression.Validate(bodyoptionsincludeUPRN, nameof(bodyoptionsincludeUPRN), required: false);
            return new DeferredBodyAction<RetrievePredictiveAddressResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildCleanseEmail))]
        public IBodyWorkflowAction<CleanseEmailResponse> CleanseEmail([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodylevelInput> bodylevel, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyforename = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodysurname = null, [WorkflowExpression] Func<string> bodycompany = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CleanseEmailResponse> __BuildCleanseEmail(WorkflowExpression<string> bodyemail, WorkflowExpression<bodylevelInput> bodylevel, WorkflowExpression<string> bodytitle = null, WorkflowExpression<string> bodyforename = null, WorkflowExpression<string> bodymiddleName = null, WorkflowExpression<string> bodysurname = null, WorkflowExpression<string> bodycompany = null)
        {
            WorkflowExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            WorkflowExpression.Validate(bodylevel, nameof(bodylevel), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            WorkflowExpression.Validate(bodyforename, nameof(bodyforename), required: false);
            WorkflowExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            WorkflowExpression.Validate(bodysurname, nameof(bodysurname), required: false);
            WorkflowExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            return new DeferredBodyAction<CleanseEmailResponse>(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [WorkflowExpressionFactory(nameof(__BuildIsValidPhone))]
        public IBodyWorkflowAction<IsValidPhoneResponse> IsValidPhone([WorkflowExpression] Func<string> bodytelephoneNumber, [WorkflowExpression] Func<int> bodydefaultCountry)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<IsValidPhoneResponse> __BuildIsValidPhone(WorkflowExpression<string> bodytelephoneNumber, WorkflowExpression<int> bodydefaultCountry)
        {
            WorkflowExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            WorkflowExpression.Validate(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            return new DeferredBodyAction<IsValidPhoneResponse>(() =>
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