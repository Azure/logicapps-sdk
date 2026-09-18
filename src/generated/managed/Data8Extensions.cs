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
        public IBodyWorkflowAction<IsUsableNameResponse> IsUsableName([WorkflowExpression] Func<string> bodynametitle = null, [WorkflowExpression] Func<string> bodynameforename = null, [WorkflowExpression] Func<string> bodynamemiddleName = null, [WorkflowExpression] Func<string> bodynamesurname = null)
        {
            SourceExpression.Validate(bodynametitle, nameof(bodynametitle), required: false);
            SourceExpression.Validate(bodynameforename, nameof(bodynameforename), required: false);
            SourceExpression.Validate(bodynamemiddleName, nameof(bodynamemiddleName), required: false);
            SourceExpression.Validate(bodynamesurname, nameof(bodynamesurname), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    nameObject["Title"] = SourceExpressionConverter.ConvertToken(bodynametitle);
                    nameObjectpropCount++;
                }

                if (bodynameforename != null)
                {
                    nameObject["Forename"] = SourceExpressionConverter.ConvertToken(bodynameforename);
                    nameObjectpropCount++;
                }

                if (bodynamemiddleName != null)
                {
                    nameObject["MiddleName"] = SourceExpressionConverter.ConvertToken(bodynamemiddleName);
                    nameObjectpropCount++;
                }

                if (bodynamesurname != null)
                {
                    nameObject["Surname"] = SourceExpressionConverter.ConvertToken(bodynamesurname);
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
                return callPayload;
            }

            return new ApiConnectionAction<IsUsableNameResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableTPSResponse> IsCallableTPS([WorkflowExpression] Func<string> bodynumber)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/TPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsCallableTPSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsCallableCTPSResponse> IsCallableCTPS([WorkflowExpression] Func<string> bodynumber)
        {
            SourceExpression.Validate(bodynumber, nameof(bodynumber), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/CTPS/IsCallable.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsCallableCTPSResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidBankAccountResponse> IsValidBankAccount([WorkflowExpression] Func<string> bodysortCode, [WorkflowExpression] Func<string> bodybankAccountNumber = null)
        {
            SourceExpression.Validate(bodysortCode, nameof(bodysortCode), required: true);
            SourceExpression.Validate(bodybankAccountNumber, nameof(bodybankAccountNumber), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/BankAccountValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sortCode"] = SourceExpressionConverter.ConvertToken(bodysortCode);
                if (bodybankAccountNumber != null)
                {
                    body["bankAccountNumber"] = SourceExpressionConverter.ConvertToken(bodybankAccountNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsValidBankAccountResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidEmailResponse> IsValidEmail([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodylevelInput> bodylevel)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodylevel, nameof(bodylevel), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EmailValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["level"] = SourceExpressionConverter.Convert(bodylevel);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsValidEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidTelephoneResponse> IsValidTelephone([WorkflowExpression] Func<string> bodytelephoneNumber, [WorkflowExpression] Func<string> bodydefaultCountry, [WorkflowExpression] Func<bool> bodyoptionsuseLineValidation = null, [WorkflowExpression] Func<bool> bodyoptionsuseMobileValidation = null)
        {
            SourceExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            SourceExpression.Validate(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            SourceExpression.Validate(bodyoptionsuseLineValidation, nameof(bodyoptionsuseLineValidation), required: false);
            SourceExpression.Validate(bodyoptionsuseMobileValidation, nameof(bodyoptionsuseMobileValidation), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/InternationalTelephoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["telephoneNumber"] = SourceExpressionConverter.ConvertToken(bodytelephoneNumber);
                bodypropCount++;
                body["defaultCountry"] = SourceExpressionConverter.ConvertToken(bodydefaultCountry);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsuseLineValidation != null)
                {
                    optionsObject["UseLineValidation"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseLineValidation);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsuseMobileValidation != null)
                {
                    optionsObject["UseMobileValidation"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseMobileValidation);
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
                return callPayload;
            }

            return new ApiConnectionAction<IsValidTelephoneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanAddressResponse> CleanAddress([WorkflowExpression] Func<string[]> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyoptionsdefaultCountryCode = null, [WorkflowExpression] Func<bool> bodyoptionsdetectCountry = null, [WorkflowExpression] Func<string> bodyoptionscountry = null, [WorkflowExpression] Func<bool> bodyoptionsincludeCountry = null)
        {
            SourceExpression.Validate(bodyaddresslines, nameof(bodyaddresslines), required: false);
            SourceExpression.Validate(bodyoptionsdefaultCountryCode, nameof(bodyoptionsdefaultCountryCode), required: false);
            SourceExpression.Validate(bodyoptionsdetectCountry, nameof(bodyoptionsdetectCountry), required: false);
            SourceExpression.Validate(bodyoptionscountry, nameof(bodyoptionscountry), required: false);
            SourceExpression.Validate(bodyoptionsincludeCountry, nameof(bodyoptionsincludeCountry), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    addressObject["Lines"] = SourceExpressionConverter.ConvertToken(bodyaddresslines);
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
                    optionsObject["DefaultCountryCode"] = SourceExpressionConverter.ConvertToken(bodyoptionsdefaultCountryCode);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsdetectCountry != null)
                {
                    optionsObject["DetectCountry"] = SourceExpressionConverter.ConvertToken(bodyoptionsdetectCountry);
                    optionsObjectpropCount++;
                }

                if (bodyoptionscountry != null)
                {
                    optionsObject["Country"] = SourceExpressionConverter.ConvertToken(bodyoptionscountry);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeCountry != null)
                {
                    optionsObject["IncludeCountry"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeCountry);
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
                return callPayload;
            }

            return new ApiConnectionAction<CleanAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<GetFullAddressResponse> GetFullAddress([WorkflowExpression] Func<bodylicenceInput> bodylicence, [WorkflowExpression] Func<string> bodypostcode, [WorkflowExpression] Func<string> bodybuilding = null, [WorkflowExpression] Func<bool> bodyoptionsfixTownCounty = null, [WorkflowExpression] Func<int> bodyoptionsmaxLines = null, [WorkflowExpression] Func<int> bodyoptionsmaxLineLength = null, [WorkflowExpression] Func<bool> bodyoptionsnormalizeCase = null, [WorkflowExpression] Func<bool> bodyoptionsnormalizeTownCase = null, [WorkflowExpression] Func<bool> bodyoptionsexcludeCounty = null, [WorkflowExpression] Func<bool> bodyoptionsuseAnyAvailableCounty = null, [WorkflowExpression] Func<bool> bodyoptionsunwantedPunctuation = null, [WorkflowExpression] Func<bool> bodyoptionsfixBuilding = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUDPRN = null, [WorkflowExpression] Func<bool> bodyoptionsincludeLocation = null, [WorkflowExpression] Func<bool> bodyoptionsreturnResultCount = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bodyoptionsformatterInput> bodyoptionsformatter = null)
        {
            SourceExpression.Validate(bodylicence, nameof(bodylicence), required: true);
            SourceExpression.Validate(bodypostcode, nameof(bodypostcode), required: true);
            SourceExpression.Validate(bodybuilding, nameof(bodybuilding), required: false);
            SourceExpression.Validate(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            SourceExpression.Validate(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            SourceExpression.Validate(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            SourceExpression.Validate(bodyoptionsnormalizeCase, nameof(bodyoptionsnormalizeCase), required: false);
            SourceExpression.Validate(bodyoptionsnormalizeTownCase, nameof(bodyoptionsnormalizeTownCase), required: false);
            SourceExpression.Validate(bodyoptionsexcludeCounty, nameof(bodyoptionsexcludeCounty), required: false);
            SourceExpression.Validate(bodyoptionsuseAnyAvailableCounty, nameof(bodyoptionsuseAnyAvailableCounty), required: false);
            SourceExpression.Validate(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            SourceExpression.Validate(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            SourceExpression.Validate(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            SourceExpression.Validate(bodyoptionsincludeLocation, nameof(bodyoptionsincludeLocation), required: false);
            SourceExpression.Validate(bodyoptionsreturnResultCount, nameof(bodyoptionsreturnResultCount), required: false);
            SourceExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            SourceExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            SourceExpression.Validate(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/AddressCapture/GetFullAddress.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["licence"] = SourceExpressionConverter.Convert(bodylicence);
                bodypropCount++;
                body["postcode"] = SourceExpressionConverter.ConvertToken(bodypostcode);
                if (bodybuilding != null)
                {
                    body["building"] = SourceExpressionConverter.ConvertToken(bodybuilding);
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsfixTownCounty != null)
                {
                    optionsObject["FixTownCounty"] = SourceExpressionConverter.ConvertToken(bodyoptionsfixTownCounty);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsmaxLines != null)
                {
                    if (bodyoptionsmaxLines != null)
                    {
                        optionsObject["MaxLines"] = SourceExpressionConverter.ConvertToken(bodyoptionsmaxLines);
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
                    optionsObject["MaxLineLength"] = SourceExpressionConverter.ConvertToken(bodyoptionsmaxLineLength);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsnormalizeCase != null)
                {
                    optionsObject["NormalizeCase"] = SourceExpressionConverter.ConvertToken(bodyoptionsnormalizeCase);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsnormalizeTownCase != null)
                {
                    optionsObject["NormalizeTownCase"] = SourceExpressionConverter.ConvertToken(bodyoptionsnormalizeTownCase);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsexcludeCounty != null)
                {
                    optionsObject["ExcludeCounty"] = SourceExpressionConverter.ConvertToken(bodyoptionsexcludeCounty);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsuseAnyAvailableCounty != null)
                {
                    optionsObject["UseAnyAvailableCounty"] = SourceExpressionConverter.ConvertToken(bodyoptionsuseAnyAvailableCounty);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsunwantedPunctuation != null)
                {
                    optionsObject["UnwantedPunctuation"] = SourceExpressionConverter.ConvertToken(bodyoptionsunwantedPunctuation);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsfixBuilding != null)
                {
                    optionsObject["FixBuilding"] = SourceExpressionConverter.ConvertToken(bodyoptionsfixBuilding);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeUDPRN != null)
                {
                    optionsObject["IncludeUDPRN"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeUDPRN);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeLocation != null)
                {
                    if (bodyoptionsincludeLocation != null)
                    {
                        optionsObject["IncludeLocation"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeLocation);
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
                    optionsObject["ReturnResultCount"] = SourceExpressionConverter.ConvertToken(bodyoptionsreturnResultCount);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeNYB);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsformatter != null)
                {
                    optionsObject["Formatter"] = SourceExpressionConverter.Convert(bodyoptionsformatter);
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
                return callPayload;
            }

            return new ApiConnectionAction<GetFullAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsDeceasedResponse> IsDeceased([WorkflowExpression] Func<string> bodyrecordnamesurname, [WorkflowExpression] Func<string[]> bodyrecordaddresslines, [WorkflowExpression] Func<bool> bodymarketing, [WorkflowExpression] Func<string> bodyrecordnametitle = null, [WorkflowExpression] Func<string> bodyrecordnameforename = null, [WorkflowExpression] Func<string> bodyrecordnamemiddleName = null, [WorkflowExpression] Func<bodyoptionsmatchLevelInput> bodyoptionsmatchLevel = null)
        {
            SourceExpression.Validate(bodyrecordnamesurname, nameof(bodyrecordnamesurname), required: true);
            SourceExpression.Validate(bodyrecordaddresslines, nameof(bodyrecordaddresslines), required: true);
            SourceExpression.Validate(bodymarketing, nameof(bodymarketing), required: true);
            SourceExpression.Validate(bodyrecordnametitle, nameof(bodyrecordnametitle), required: false);
            SourceExpression.Validate(bodyrecordnameforename, nameof(bodyrecordnameforename), required: false);
            SourceExpression.Validate(bodyrecordnamemiddleName, nameof(bodyrecordnamemiddleName), required: false);
            SourceExpression.Validate(bodyoptionsmatchLevel, nameof(bodyoptionsmatchLevel), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                    nameObject["Title"] = SourceExpressionConverter.ConvertToken(bodyrecordnametitle);
                    nameObjectpropCount++;
                }

                if (bodyrecordnameforename != null)
                {
                    nameObject["Forename"] = SourceExpressionConverter.ConvertToken(bodyrecordnameforename);
                    nameObjectpropCount++;
                }

                if (bodyrecordnamemiddleName != null)
                {
                    nameObject["MiddleName"] = SourceExpressionConverter.ConvertToken(bodyrecordnamemiddleName);
                    nameObjectpropCount++;
                }

                nameObjectpropCount++;
                nameObject["Surname"] = SourceExpressionConverter.ConvertToken(bodyrecordnamesurname);
                if (nameObjectpropCount > 0)
                {
                    recordObject["Name"] = nameObject;
                    recordObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["Lines"] = SourceExpressionConverter.ConvertToken(bodyrecordaddresslines);
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
                body["marketing"] = SourceExpressionConverter.ConvertToken(bodymarketing);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsmatchLevel != null)
                {
                    if (bodyoptionsmatchLevel != null)
                    {
                        optionsObject["MatchLevel"] = SourceExpressionConverter.Convert(bodyoptionsmatchLevel);
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
                return callPayload;
            }

            return new ApiConnectionAction<IsDeceasedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<SearchPredictiveAddressResponse> SearchPredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodysearch, [WorkflowExpression] Func<string> bodytelephoneNumber = null, [WorkflowExpression] Func<string> bodysession = null, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null)
        {
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            SourceExpression.Validate(bodysearch, nameof(bodysearch), required: true);
            SourceExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: false);
            SourceExpression.Validate(bodysession, nameof(bodysession), required: false);
            SourceExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            SourceExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PredictiveAddress/Search.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
                body["search"] = SourceExpressionConverter.ConvertToken(bodysearch);
                if (bodytelephoneNumber != null)
                {
                    body["telephoneNumber"] = SourceExpressionConverter.ConvertToken(bodytelephoneNumber);
                    bodypropCount++;
                }

                if (bodysession != null)
                {
                    body["session"] = SourceExpressionConverter.ConvertToken(bodysession);
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeNYB);
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
                return callPayload;
            }

            return new ApiConnectionAction<SearchPredictiveAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<DrilldownPredictiveAddressResponse> DrilldownPredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<bool> bodyoptionsincludeMR = null, [WorkflowExpression] Func<bool> bodyoptionsincludeNYB = null)
        {
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyoptionsincludeMR, nameof(bodyoptionsincludeMR), required: false);
            SourceExpression.Validate(bodyoptionsincludeNYB, nameof(bodyoptionsincludeNYB), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PredictiveAddress/DrillDown.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsincludeMR != null)
                {
                    optionsObject["IncludeMR"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeMR);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsincludeNYB != null)
                {
                    optionsObject["IncludeNYB"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeNYB);
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
                return callPayload;
            }

            return new ApiConnectionAction<DrilldownPredictiveAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<RetrievePredictiveAddressResponse> RetrievePredictiveAddress([WorkflowExpression] Func<string> bodycountry, [WorkflowExpression] Func<string> bodyid, [WorkflowExpression] Func<int> bodyoptionsmaxLineLength = null, [WorkflowExpression] Func<int> bodyoptionsmaxLines = null, [WorkflowExpression] Func<bool> bodyoptionsfixTownCounty = null, [WorkflowExpression] Func<bool> bodyoptionsfixPostcode = null, [WorkflowExpression] Func<bool> bodyoptionsfixBuilding = null, [WorkflowExpression] Func<string> bodyoptionsunwantedPunctuation = null, [WorkflowExpression] Func<bodyoptionsformatterInput> bodyoptionsformatter = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUDPRN = null, [WorkflowExpression] Func<bool> bodyoptionsincludeUPRN = null)
        {
            SourceExpression.Validate(bodycountry, nameof(bodycountry), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: true);
            SourceExpression.Validate(bodyoptionsmaxLineLength, nameof(bodyoptionsmaxLineLength), required: false);
            SourceExpression.Validate(bodyoptionsmaxLines, nameof(bodyoptionsmaxLines), required: false);
            SourceExpression.Validate(bodyoptionsfixTownCounty, nameof(bodyoptionsfixTownCounty), required: false);
            SourceExpression.Validate(bodyoptionsfixPostcode, nameof(bodyoptionsfixPostcode), required: false);
            SourceExpression.Validate(bodyoptionsfixBuilding, nameof(bodyoptionsfixBuilding), required: false);
            SourceExpression.Validate(bodyoptionsunwantedPunctuation, nameof(bodyoptionsunwantedPunctuation), required: false);
            SourceExpression.Validate(bodyoptionsformatter, nameof(bodyoptionsformatter), required: false);
            SourceExpression.Validate(bodyoptionsincludeUDPRN, nameof(bodyoptionsincludeUDPRN), required: false);
            SourceExpression.Validate(bodyoptionsincludeUPRN, nameof(bodyoptionsincludeUPRN), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PredictiveAddress/Retrieve.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                bodypropCount++;
                body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsmaxLineLength != null)
                {
                    if (bodyoptionsmaxLineLength != null)
                    {
                        optionsObject["MaxLineLength"] = SourceExpressionConverter.ConvertToken(bodyoptionsmaxLineLength);
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
                        optionsObject["MaxLines"] = SourceExpressionConverter.ConvertToken(bodyoptionsmaxLines);
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
                        optionsObject["FixTownCounty"] = SourceExpressionConverter.ConvertToken(bodyoptionsfixTownCounty);
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
                        optionsObject["FixPostcode"] = SourceExpressionConverter.ConvertToken(bodyoptionsfixPostcode);
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
                        optionsObject["FixBuilding"] = SourceExpressionConverter.ConvertToken(bodyoptionsfixBuilding);
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
                    optionsObject["UnwantedPunctuation"] = SourceExpressionConverter.ConvertToken(bodyoptionsunwantedPunctuation);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsformatter != null)
                {
                    if (bodyoptionsformatter != null)
                    {
                        optionsObject["Formatter"] = SourceExpressionConverter.Convert(bodyoptionsformatter);
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
                        optionsObject["IncludeUDPRN"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeUDPRN);
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
                        optionsObject["IncludeUPRN"] = SourceExpressionConverter.ConvertToken(bodyoptionsincludeUPRN);
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
                return callPayload;
            }

            return new ApiConnectionAction<RetrievePredictiveAddressResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<CleanseEmailResponse> CleanseEmail([WorkflowExpression] Func<string> bodyemail, [WorkflowExpression] Func<bodylevelInput> bodylevel, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyforename = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodysurname = null, [WorkflowExpression] Func<string> bodycompany = null)
        {
            SourceExpression.Validate(bodyemail, nameof(bodyemail), required: true);
            SourceExpression.Validate(bodylevel, nameof(bodylevel), required: true);
            SourceExpression.Validate(bodytitle, nameof(bodytitle), required: false);
            SourceExpression.Validate(bodyforename, nameof(bodyforename), required: false);
            SourceExpression.Validate(bodymiddleName, nameof(bodymiddleName), required: false);
            SourceExpression.Validate(bodysurname, nameof(bodysurname), required: false);
            SourceExpression.Validate(bodycompany, nameof(bodycompany), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/EmailValidation/CleanseSimple.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Email"] = SourceExpressionConverter.ConvertToken(bodyemail);
                bodypropCount++;
                body["Level"] = SourceExpressionConverter.Convert(bodylevel);
                if (bodytitle != null)
                {
                    body["Title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyforename != null)
                {
                    body["Forename"] = SourceExpressionConverter.ConvertToken(bodyforename);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["MiddleName"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodysurname != null)
                {
                    body["Surname"] = SourceExpressionConverter.ConvertToken(bodysurname);
                    bodypropCount++;
                }

                if (bodycompany != null)
                {
                    body["Company"] = SourceExpressionConverter.ConvertToken(bodycompany);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CleanseEmailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "data8")]
        public IBodyWorkflowAction<IsValidPhoneResponse> IsValidPhone([WorkflowExpression] Func<string> bodytelephoneNumber, [WorkflowExpression] Func<int> bodydefaultCountry)
        {
            SourceExpression.Validate(bodytelephoneNumber, nameof(bodytelephoneNumber), required: true);
            SourceExpression.Validate(bodydefaultCountry, nameof(bodydefaultCountry), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/PhoneValidation/IsValid.json";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["telephoneNumber"] = SourceExpressionConverter.ConvertToken(bodytelephoneNumber);
                bodypropCount++;
                body["defaultCountry"] = SourceExpressionConverter.ConvertToken(bodydefaultCountry);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<IsValidPhoneResponse>(BuildSourceInput);
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