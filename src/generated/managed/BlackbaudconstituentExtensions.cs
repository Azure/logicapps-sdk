//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class BlackbaudconstituentActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentConsent> CreateConstituentConsent([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodychannel, [WorkflowExpression] Func<bodyresponseInput> bodyresponse, [WorkflowExpression] Func<string> bodydate, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyconsentStatement = null, [WorkflowExpression] Func<string> bodyprivacyNotice = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/commpref/v1/consent/consents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["channel"] = SourceExpressionConverter.ConvertToken(bodychannel);
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                bodypropCount++;
                body["constituent_consent_response"] = SourceExpressionConverter.Convert(bodyresponse);
                bodypropCount++;
                body["consent_date"] = SourceExpressionConverter.ConvertToken(bodydate);
                if (bodyconsentStatement != null)
                {
                    body["consent_statement"] = SourceExpressionConverter.ConvertToken(bodyconsentStatement);
                    bodypropCount++;
                }

                if (bodyprivacyNotice != null)
                {
                    body["privacy_notice"] = SourceExpressionConverter.ConvertToken(bodyprivacyNotice);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentConsent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentConsentReadCollection> ListConstituentConsents([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> mostRecentOnly = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituents/{0}/consents", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (mostRecentOnly != null)
                    callPayload.Queries["most_recent_only"] = SourceExpressionConverter.ConvertO(mostRecentOnly);
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiConstituentConsentReadCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiConstituentSolicitCodeReadCollection> ListConstituentSolicitCodes([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituents/{0}/constituentsolicitcodes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiConstituentSolicitCodeReadCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<CommPrefApiCreatedConstituentSolicitCode> CreateConstituentSolicitCode([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodysolicitCode, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/commpref/v1/constituentsolicitcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommPrefApiCreatedConstituentSolicitCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentSolicitCode([WorkflowExpression] Func<string> constituentSolicitCodeId, [WorkflowExpression] Func<string> bodysolicitCode = null, [WorkflowExpression] Func<string> bodystartDate = null, [WorkflowExpression] Func<string> bodyendDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/commpref/v1/constituentsolicitcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentSolicitCodeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysolicitCode != null)
                {
                    body["solicit_code"] = SourceExpressionConverter.ConvertToken(bodysolicitCode);
                    bodypropCount++;
                }

                if (bodystartDate != null)
                {
                    body["start_date"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                    bodypropCount++;
                }

                if (bodyendDate != null)
                {
                    body["end_date"] = SourceExpressionConverter.ConvertToken(bodyendDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAddress> CreateConstituentAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyaddressType, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddressLines = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodysuburb = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodyvalidFrom = null, [WorkflowExpression] Func<string> bodyvalidTo = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartyear = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndyear = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/addresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddressLines != null)
                {
                    body["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddressLines);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodysuburb != null)
                {
                    body["suburb"] = SourceExpressionConverter.ConvertToken(bodysuburb);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["information_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodyvalidFrom != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyvalidFrom);
                    bodypropCount++;
                }

                if (bodyvalidTo != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyvalidTo);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["preferred"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAddress([WorkflowExpression] Func<string> addressId, [WorkflowExpression] Func<string> bodyaddressType = null, [WorkflowExpression] Func<string> bodycountry = null, [WorkflowExpression] Func<string> bodyaddressLines = null, [WorkflowExpression] Func<string> bodycity = null, [WorkflowExpression] Func<string> bodystate = null, [WorkflowExpression] Func<string> bodypostalCode = null, [WorkflowExpression] Func<string> bodysuburb = null, [WorkflowExpression] Func<string> bodycounty = null, [WorkflowExpression] Func<string> bodyinformationSource = null, [WorkflowExpression] Func<string> bodyregion = null, [WorkflowExpression] Func<string> bodycART = null, [WorkflowExpression] Func<string> bodylOT = null, [WorkflowExpression] Func<string> bodydPC = null, [WorkflowExpression] Func<string> bodyvalidFrom = null, [WorkflowExpression] Func<string> bodyvalidTo = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotMail = null, [WorkflowExpression] Func<int> bodyseasonalStartday = null, [WorkflowExpression] Func<int> bodyseasonalStartmonth = null, [WorkflowExpression] Func<int> bodyseasonalStartyear = null, [WorkflowExpression] Func<int> bodyseasonalEndday = null, [WorkflowExpression] Func<int> bodyseasonalEndmonth = null, [WorkflowExpression] Func<int> bodyseasonalEndyear = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/addresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(addressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyaddressType != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodyaddressType);
                    bodypropCount++;
                }

                if (bodycountry != null)
                {
                    body["country"] = SourceExpressionConverter.ConvertToken(bodycountry);
                    bodypropCount++;
                }

                if (bodyaddressLines != null)
                {
                    body["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddressLines);
                    bodypropCount++;
                }

                if (bodycity != null)
                {
                    body["city"] = SourceExpressionConverter.ConvertToken(bodycity);
                    bodypropCount++;
                }

                if (bodystate != null)
                {
                    body["state"] = SourceExpressionConverter.ConvertToken(bodystate);
                    bodypropCount++;
                }

                if (bodypostalCode != null)
                {
                    body["postal_code"] = SourceExpressionConverter.ConvertToken(bodypostalCode);
                    bodypropCount++;
                }

                if (bodysuburb != null)
                {
                    body["suburb"] = SourceExpressionConverter.ConvertToken(bodysuburb);
                    bodypropCount++;
                }

                if (bodycounty != null)
                {
                    body["county"] = SourceExpressionConverter.ConvertToken(bodycounty);
                    bodypropCount++;
                }

                if (bodyinformationSource != null)
                {
                    body["information_source"] = SourceExpressionConverter.ConvertToken(bodyinformationSource);
                    bodypropCount++;
                }

                if (bodyregion != null)
                {
                    body["region"] = SourceExpressionConverter.ConvertToken(bodyregion);
                    bodypropCount++;
                }

                if (bodycART != null)
                {
                    body["cart"] = SourceExpressionConverter.ConvertToken(bodycART);
                    bodypropCount++;
                }

                if (bodylOT != null)
                {
                    body["lot"] = SourceExpressionConverter.ConvertToken(bodylOT);
                    bodypropCount++;
                }

                if (bodydPC != null)
                {
                    body["dpc"] = SourceExpressionConverter.ConvertToken(bodydPC);
                    bodypropCount++;
                }

                if (bodyvalidFrom != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyvalidFrom);
                    bodypropCount++;
                }

                if (bodyvalidTo != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyvalidTo);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["preferred"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotMail != null)
                {
                    body["do_not_mail"] = SourceExpressionConverter.ConvertToken(bodydoNotMail);
                    bodypropCount++;
                }

                var seasonalStartObject = new JObject();
                var seasonalStartObjectpropCount = 0;
                if (bodyseasonalStartday != null)
                {
                    seasonalStartObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartday);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartmonth != null)
                {
                    seasonalStartObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartmonth);
                    seasonalStartObjectpropCount++;
                }

                if (bodyseasonalStartyear != null)
                {
                    seasonalStartObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalStartyear);
                    seasonalStartObjectpropCount++;
                }

                if (seasonalStartObjectpropCount > 0)
                {
                    body["seasonal_start"] = seasonalStartObject;
                    bodypropCount++;
                }

                var seasonalEndObject = new JObject();
                var seasonalEndObjectpropCount = 0;
                if (bodyseasonalEndday != null)
                {
                    seasonalEndObject["d"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndday);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndmonth != null)
                {
                    seasonalEndObject["m"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndmonth);
                    seasonalEndObjectpropCount++;
                }

                if (bodyseasonalEndyear != null)
                {
                    seasonalEndObject["y"] = SourceExpressionConverter.ConvertToken(bodyseasonalEndyear);
                    seasonalEndObjectpropCount++;
                }

                if (seasonalEndObjectpropCount > 0)
                {
                    body["seasonal_end"] = seasonalEndObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAlias> CreateConstituentAlias([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyalias, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/aliases";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyalias);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAlias>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAlias([WorkflowExpression] Func<string> aliasId, [WorkflowExpression] Func<string> bodyalias = null, [WorkflowExpression] Func<string> bodytype = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/aliases/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(aliasId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyalias != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyalias);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCode> CreateConstituentCode([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyconstituentCode, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituentcodes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodyconstituentCode);
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCode>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction DeleteConstituentCode([WorkflowExpression] Func<string> constituentCodeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituentcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCodeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentCode([WorkflowExpression] Func<string> constituentCodeId, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<int> bodysequence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituentcodes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentCodeId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodysequence != null)
                {
                    body["sequence"] = SourceExpressionConverter.ConvertToken(bodysequence);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentRead> ListConstituents([WorkflowExpression] Func<string> listId = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null, [WorkflowExpression] Func<string> constituentCode = null, [WorkflowExpression] Func<string> constituentId = null, [WorkflowExpression] Func<string> customFieldCategory = null, [WorkflowExpression] Func<string> fundraiserStatus = null, [WorkflowExpression] Func<bool> includeDeceased = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<string> postalCode = null, [WorkflowExpression] Func<string> dateAdded = null, [WorkflowExpression] Func<string> lastModified = null, [WorkflowExpression] Func<string> sort = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (listId != null)
                    callPayload.Queries["list_id"] = SourceExpressionConverter.ConvertO(listId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                if (constituentCode != null)
                    callPayload.Queries["constituent_code"] = SourceExpressionConverter.ConvertO(constituentCode);
                if (constituentId != null)
                    callPayload.Queries["constituent_id"] = SourceExpressionConverter.ConvertO(constituentId);
                if (customFieldCategory != null)
                    callPayload.Queries["custom_field_category"] = SourceExpressionConverter.ConvertO(customFieldCategory);
                if (fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = SourceExpressionConverter.ConvertO(fundraiserStatus);
                if (includeDeceased != null)
                    callPayload.Queries["include_deceased"] = SourceExpressionConverter.ConvertO(includeDeceased);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (postalCode != null)
                    callPayload.Queries["postal_code"] = SourceExpressionConverter.ConvertO(postalCode);
                if (dateAdded != null)
                    callPayload.Queries["date_added"] = SourceExpressionConverter.ConvertO(dateAdded);
                if (lastModified != null)
                    callPayload.Queries["last_modified"] = SourceExpressionConverter.ConvertO(lastModified);
                if (sort != null)
                    callPayload.Queries["sort"] = SourceExpressionConverter.ConvertO(sort);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConstituentRead> GetConstituent([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiConstituentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituent([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodylastName = null, [WorkflowExpression] Func<string> bodyorganizationName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyformerName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodyrequestsNoEmail = null, [WorkflowExpression] Func<bool> bodyisASolicitor = null, [WorkflowExpression] Func<bool> bodynoValidAddresses = null, [WorkflowExpression] Func<bool> bodyinactive = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<string> bodybirthplace = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<string> bodytarget = null, [WorkflowExpression] Func<string> bodyincome = null, [WorkflowExpression] Func<bodyreceiptTypeInput> bodyreceiptType = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynumberOfEmployees = null, [WorkflowExpression] Func<bool> bodymatchesGifts = null, [WorkflowExpression] Func<double> bodymatchingGiftFactor = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMinminMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMinminMatchPerConstit = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, [WorkflowExpression] Func<string> bodymatchingGiftNotes = null, [WorkflowExpression] Func<bool> bodydeceased = null, [WorkflowExpression] Func<int> bodydeceasedDateday = null, [WorkflowExpression] Func<int> bodydeceasedDatemonth = null, [WorkflowExpression] Func<int> bodydeceasedDateyear = null, [WorkflowExpression] Func<bool> bodyisMemorial = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                if (bodylastName != null)
                {
                    body["last"] = SourceExpressionConverter.ConvertToken(bodylastName);
                    bodypropCount++;
                }

                if (bodyorganizationName != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyorganizationName);
                    bodypropCount++;
                }

                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferred_name"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyformerName != null)
                {
                    body["former_name"] = SourceExpressionConverter.ConvertToken(bodyformerName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = SourceExpressionConverter.ConvertToken(bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (bodyisASolicitor != null)
                {
                    body["is_solicitor"] = SourceExpressionConverter.ConvertToken(bodyisASolicitor);
                    bodypropCount++;
                }

                if (bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = SourceExpressionConverter.ConvertToken(bodynoValidAddresses);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (bodybirthdateday != null)
                {
                    birthdateObject["d"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdateyear != null)
                {
                    birthdateObject["y"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (bodybirthplace != null)
                {
                    body["birthplace"] = SourceExpressionConverter.ConvertToken(bodybirthplace);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodytarget != null)
                {
                    body["target"] = SourceExpressionConverter.ConvertToken(bodytarget);
                    bodypropCount++;
                }

                if (bodyincome != null)
                {
                    body["income"] = SourceExpressionConverter.ConvertToken(bodyincome);
                    bodypropCount++;
                }

                if (bodyreceiptType != null)
                {
                    body["receipt_type"] = SourceExpressionConverter.Convert(bodyreceiptType);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynumberOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (bodymatchesGifts != null)
                {
                    body["matches_gifts"] = SourceExpressionConverter.ConvertToken(bodymatchesGifts);
                    bodypropCount++;
                }

                if (bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (bodydeceased != null)
                {
                    body["deceased"] = SourceExpressionConverter.ConvertToken(bodydeceased);
                    bodypropCount++;
                }

                var deceasedDateObject = new JObject();
                var deceasedDateObjectpropCount = 0;
                if (bodydeceasedDateday != null)
                {
                    deceasedDateObject["d"] = SourceExpressionConverter.ConvertToken(bodydeceasedDateday);
                    deceasedDateObjectpropCount++;
                }

                if (bodydeceasedDatemonth != null)
                {
                    deceasedDateObject["m"] = SourceExpressionConverter.ConvertToken(bodydeceasedDatemonth);
                    deceasedDateObjectpropCount++;
                }

                if (bodydeceasedDateyear != null)
                {
                    deceasedDateObject["y"] = SourceExpressionConverter.ConvertToken(bodydeceasedDateyear);
                    deceasedDateObjectpropCount++;
                }

                if (deceasedDateObjectpropCount > 0)
                {
                    body["deceased_date"] = deceasedDateObject;
                    bodypropCount++;
                }

                if (bodyisMemorial != null)
                {
                    body["is_memorial"] = SourceExpressionConverter.ConvertToken(bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAddressRead> ListConstituentAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/addresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfAddressRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfAliasRead> ListConstituentAliases([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/aliases", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfAliasRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentAttachmentRead> ListConstituentAttachments([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/attachments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentAttachmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCodeRead> ListConstituentCodes([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/constituentcodes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCodeRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead> ListConstituentCustomFields([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/customfields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfConstituentCustomFieldRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEducationRead> ListConstituentEducations([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/educations", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfEducationRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfEmailAddressRead> ListConstituentEmailAddresses([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/emailaddresses", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfEmailAddressRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead> ListConstituentFundraiserAssignments([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/fundraiserassignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfFundraiserAssignmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfMembershipRead> ListConstituentMemberships([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/memberships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfMembershipRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiNameFormatSummaryRead> GetConstituentNameFormatSummary([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/nameformats/summary", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiNameFormatSummaryRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfNoteRead> ListConstituentNotes([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/notes", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfNoteRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfOnlinePresenceRead> ListConstituentOnlinePresences([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/onlinepresences", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfOnlinePresenceRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfPhoneRead> ListConstituentPhones([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<bool> includeInactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/phones", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfPhoneRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiProfilePictureRead> GetConstituentProfilePicture([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/profilepicture", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiProfilePictureRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentProfilePicture([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<string> bodyfileName, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodythumbnailId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/profilepicture", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                bodypropCount++;
                body["document_id"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfRelationshipRead> ListConstituentRelationships([WorkflowExpression] Func<string> constituentId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/{0}/relationships", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfRelationshipRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiConvertedConstituent> ConvertToConstituent([WorkflowExpression] Func<string> nonConstituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/convert/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nonConstituentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiConvertedConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentAttachment> CreateConstituentAttachment([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string> bodyfileName = null, [WorkflowExpression] Func<string> bodyfileId = null, [WorkflowExpression] Func<string> bodythumbnailId = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/attachments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodyfileName != null)
                {
                    body["file_name"] = SourceExpressionConverter.ConvertToken(bodyfileName);
                    bodypropCount++;
                }

                if (bodyfileId != null)
                {
                    body["file_id"] = SourceExpressionConverter.ConvertToken(bodyfileId);
                    bodypropCount++;
                }

                if (bodythumbnailId != null)
                {
                    body["thumbnail_id"] = SourceExpressionConverter.ConvertToken(bodythumbnailId);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentAttachment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentAttachment([WorkflowExpression] Func<string> attachmentId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodyuRL = null, [WorkflowExpression] Func<string[]> bodytags = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/attachments/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(attachmentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodyuRL != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyuRL);
                    bodypropCount++;
                }

                if (bodytags != null)
                {
                    body["tags"] = SourceExpressionConverter.ConvertToken(bodytags);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentCustomField> CreateConstituentCustomField([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/customfields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["parent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentCustomField>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentCustomField([WorkflowExpression] Func<string> customFieldId, [WorkflowExpression] Func<string> bodycategory = null, [WorkflowExpression] Func<object> bodyvalue = null, [WorkflowExpression] Func<string> bodydate = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/constituents/customfields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(customFieldId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycategory != null)
                {
                    body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodydate != null)
                {
                    body["date"] = SourceExpressionConverter.ConvertToken(bodydate);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiDuplicateSearchResultCollection> GetDuplicateSearchResults([WorkflowExpression] Func<string> lastOrgName, [WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> middleName = null, [WorkflowExpression] Func<string> suffix = null, [WorkflowExpression] Func<string> addressBlock = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<string[]> email = null, [WorkflowExpression] Func<string[]> phone = null, [WorkflowExpression] Func<bool> searchIndividuals = null, [WorkflowExpression] Func<bool> searchAliases = null, [WorkflowExpression] Func<bool> searchContacts = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/duplicatesearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["last_org_name"] = SourceExpressionConverter.ConvertO(lastOrgName);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (middleName != null)
                    callPayload.Queries["middle_name"] = SourceExpressionConverter.ConvertO(middleName);
                if (suffix != null)
                    callPayload.Queries["suffix"] = SourceExpressionConverter.ConvertO(suffix);
                if (addressBlock != null)
                    callPayload.Queries["address_block"] = SourceExpressionConverter.ConvertO(addressBlock);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (postCode != null)
                    callPayload.Queries["post_code"] = SourceExpressionConverter.ConvertO(postCode);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (phone != null)
                    callPayload.Queries["phone"] = SourceExpressionConverter.ConvertO(phone);
                callPayload.Queries["search_individuals"] = Convert.ToString(true);
                if (searchIndividuals != null)
                    callPayload.Queries["search_individuals"] = SourceExpressionConverter.ConvertO(searchIndividuals);
                callPayload.Queries["search_aliases"] = Convert.ToString(false);
                if (searchAliases != null)
                    callPayload.Queries["search_aliases"] = SourceExpressionConverter.ConvertO(searchAliases);
                callPayload.Queries["search_contacts"] = Convert.ToString(false);
                if (searchContacts != null)
                    callPayload.Queries["search_contacts"] = SourceExpressionConverter.ConvertO(searchContacts);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiDuplicateSearchResultCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiApiCollectionOfSearchResultRead> SearchConstituent([WorkflowExpression] Func<string> searchText, [WorkflowExpression] Func<string> fundraiserStatus = null, [WorkflowExpression] Func<bool> includeInactive = null, [WorkflowExpression] Func<searchFieldInput> searchField = null, [WorkflowExpression] Func<bool> strictSearch = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/constituents/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["search_text"] = SourceExpressionConverter.ConvertO(searchText);
                if (fundraiserStatus != null)
                    callPayload.Queries["fundraiser_status"] = SourceExpressionConverter.ConvertO(fundraiserStatus);
                if (includeInactive != null)
                    callPayload.Queries["include_inactive"] = SourceExpressionConverter.ConvertO(includeInactive);
                if (searchField != null)
                    callPayload.Queries["search_field"] = SourceExpressionConverter.Convert(searchField);
                if (strictSearch != null)
                    callPayload.Queries["strict_search"] = SourceExpressionConverter.ConvertO(strictSearch);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiApiCollectionOfSearchResultRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEducation> CreateConstituentEducation([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyschool, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyclassOf = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateEnteredday = null, [WorkflowExpression] Func<int> bodydateEnteredmonth = null, [WorkflowExpression] Func<int> bodydateEnteredyear = null, [WorkflowExpression] Func<int> bodydateLeftday = null, [WorkflowExpression] Func<int> bodydateLeftmonth = null, [WorkflowExpression] Func<int> bodydateLeftyear = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<double> bodygPA = null, [WorkflowExpression] Func<string> bodysubjectOfStudy = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string[]> bodymajors = null, [WorkflowExpression] Func<string[]> bodyminors = null, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodysocialOrganization = null, [WorkflowExpression] Func<string> bodyknownName = null, [WorkflowExpression] Func<string> bodyclassOfDegree = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<string> bodyregistrationNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/educations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["school"] = SourceExpressionConverter.ConvertToken(bodyschool);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_of"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = SourceExpressionConverter.ConvertToken(bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = SourceExpressionConverter.ConvertToken(bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = SourceExpressionConverter.ConvertToken(bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (bodydateLeftday != null)
                {
                    dateLeftObject["d"] = SourceExpressionConverter.ConvertToken(bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = SourceExpressionConverter.ConvertToken(bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = SourceExpressionConverter.ConvertToken(bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodygPA != null)
                {
                    body["gpa"] = SourceExpressionConverter.ConvertToken(bodygPA);
                    bodypropCount++;
                }

                if (bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = SourceExpressionConverter.ConvertToken(bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodymajors != null)
                {
                    body["majors"] = SourceExpressionConverter.ConvertToken(bodymajors);
                    bodypropCount++;
                }

                if (bodyminors != null)
                {
                    body["minors"] = SourceExpressionConverter.ConvertToken(bodyminors);
                    bodypropCount++;
                }

                if (bodycampus != null)
                {
                    body["campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodysocialOrganization != null)
                {
                    body["social_organization"] = SourceExpressionConverter.ConvertToken(bodysocialOrganization);
                    bodypropCount++;
                }

                if (bodyknownName != null)
                {
                    body["known_name"] = SourceExpressionConverter.ConvertToken(bodyknownName);
                    bodypropCount++;
                }

                if (bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = SourceExpressionConverter.ConvertToken(bodyclassOfDegree);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyregistrationNumber != null)
                {
                    body["registration_number"] = SourceExpressionConverter.ConvertToken(bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEducation>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentEducation([WorkflowExpression] Func<string> educationId, [WorkflowExpression] Func<string> bodyschool = null, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyclassOf = null, [WorkflowExpression] Func<string> bodystatus = null, [WorkflowExpression] Func<int> bodydateEnteredday = null, [WorkflowExpression] Func<int> bodydateEnteredmonth = null, [WorkflowExpression] Func<int> bodydateEnteredyear = null, [WorkflowExpression] Func<int> bodydateLeftday = null, [WorkflowExpression] Func<int> bodydateLeftmonth = null, [WorkflowExpression] Func<int> bodydateLeftyear = null, [WorkflowExpression] Func<int> bodydateGraduatedday = null, [WorkflowExpression] Func<int> bodydateGraduatedmonth = null, [WorkflowExpression] Func<int> bodydateGraduatedyear = null, [WorkflowExpression] Func<string> bodydegree = null, [WorkflowExpression] Func<double> bodygPA = null, [WorkflowExpression] Func<string> bodysubjectOfStudy = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<string[]> bodymajors = null, [WorkflowExpression] Func<string[]> bodyminors = null, [WorkflowExpression] Func<string> bodycampus = null, [WorkflowExpression] Func<string> bodysocialOrganization = null, [WorkflowExpression] Func<string> bodyknownName = null, [WorkflowExpression] Func<string> bodyclassOfDegree = null, [WorkflowExpression] Func<string> bodydepartment = null, [WorkflowExpression] Func<string> bodyfaculty = null, [WorkflowExpression] Func<string> bodyregistrationNumber = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/educations/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(educationId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyschool != null)
                {
                    body["school"] = SourceExpressionConverter.ConvertToken(bodyschool);
                    bodypropCount++;
                }

                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyclassOf != null)
                {
                    body["class_of"] = SourceExpressionConverter.ConvertToken(bodyclassOf);
                    bodypropCount++;
                }

                if (bodystatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodystatus);
                    bodypropCount++;
                }

                var dateEnteredObject = new JObject();
                var dateEnteredObjectpropCount = 0;
                if (bodydateEnteredday != null)
                {
                    dateEnteredObject["d"] = SourceExpressionConverter.ConvertToken(bodydateEnteredday);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredmonth != null)
                {
                    dateEnteredObject["m"] = SourceExpressionConverter.ConvertToken(bodydateEnteredmonth);
                    dateEnteredObjectpropCount++;
                }

                if (bodydateEnteredyear != null)
                {
                    dateEnteredObject["y"] = SourceExpressionConverter.ConvertToken(bodydateEnteredyear);
                    dateEnteredObjectpropCount++;
                }

                if (dateEnteredObjectpropCount > 0)
                {
                    body["date_entered"] = dateEnteredObject;
                    bodypropCount++;
                }

                var dateLeftObject = new JObject();
                var dateLeftObjectpropCount = 0;
                if (bodydateLeftday != null)
                {
                    dateLeftObject["d"] = SourceExpressionConverter.ConvertToken(bodydateLeftday);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftmonth != null)
                {
                    dateLeftObject["m"] = SourceExpressionConverter.ConvertToken(bodydateLeftmonth);
                    dateLeftObjectpropCount++;
                }

                if (bodydateLeftyear != null)
                {
                    dateLeftObject["y"] = SourceExpressionConverter.ConvertToken(bodydateLeftyear);
                    dateLeftObjectpropCount++;
                }

                if (dateLeftObjectpropCount > 0)
                {
                    body["date_left"] = dateLeftObject;
                    bodypropCount++;
                }

                var dateGraduatedObject = new JObject();
                var dateGraduatedObjectpropCount = 0;
                if (bodydateGraduatedday != null)
                {
                    dateGraduatedObject["d"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedday);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedmonth != null)
                {
                    dateGraduatedObject["m"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedmonth);
                    dateGraduatedObjectpropCount++;
                }

                if (bodydateGraduatedyear != null)
                {
                    dateGraduatedObject["y"] = SourceExpressionConverter.ConvertToken(bodydateGraduatedyear);
                    dateGraduatedObjectpropCount++;
                }

                if (dateGraduatedObjectpropCount > 0)
                {
                    body["date_graduated"] = dateGraduatedObject;
                    bodypropCount++;
                }

                if (bodydegree != null)
                {
                    body["degree"] = SourceExpressionConverter.ConvertToken(bodydegree);
                    bodypropCount++;
                }

                if (bodygPA != null)
                {
                    body["gpa"] = SourceExpressionConverter.ConvertToken(bodygPA);
                    bodypropCount++;
                }

                if (bodysubjectOfStudy != null)
                {
                    body["subject_of_study"] = SourceExpressionConverter.ConvertToken(bodysubjectOfStudy);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodymajors != null)
                {
                    body["majors"] = SourceExpressionConverter.ConvertToken(bodymajors);
                    bodypropCount++;
                }

                if (bodyminors != null)
                {
                    body["minors"] = SourceExpressionConverter.ConvertToken(bodyminors);
                    bodypropCount++;
                }

                if (bodycampus != null)
                {
                    body["campus"] = SourceExpressionConverter.ConvertToken(bodycampus);
                    bodypropCount++;
                }

                if (bodysocialOrganization != null)
                {
                    body["social_organization"] = SourceExpressionConverter.ConvertToken(bodysocialOrganization);
                    bodypropCount++;
                }

                if (bodyknownName != null)
                {
                    body["known_name"] = SourceExpressionConverter.ConvertToken(bodyknownName);
                    bodypropCount++;
                }

                if (bodyclassOfDegree != null)
                {
                    body["class_of_degree"] = SourceExpressionConverter.ConvertToken(bodyclassOfDegree);
                    bodypropCount++;
                }

                if (bodydepartment != null)
                {
                    body["department"] = SourceExpressionConverter.ConvertToken(bodydepartment);
                    bodypropCount++;
                }

                if (bodyfaculty != null)
                {
                    body["faculty"] = SourceExpressionConverter.ConvertToken(bodyfaculty);
                    bodypropCount++;
                }

                if (bodyregistrationNumber != null)
                {
                    body["registration_number"] = SourceExpressionConverter.ConvertToken(bodyregistrationNumber);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentEmailAddress> CreateConstituentEmailAddress([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyemailType, [WorkflowExpression] Func<string> bodyemailAddress, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/emailaddresses";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentEmailAddress>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentEmailAddress([WorkflowExpression] Func<string> emailAddressId, [WorkflowExpression] Func<string> bodyemailType = null, [WorkflowExpression] Func<string> bodyemailAddress = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotEmail = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/emailaddresses/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(emailAddressId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyemailType != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodyemailType);
                    bodypropCount++;
                }

                if (bodyemailAddress != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodyemailAddress);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotEmail != null)
                {
                    body["do_not_email"] = SourceExpressionConverter.ConvertToken(bodydoNotEmail);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat> CreateConstituentNameFormat([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<bool> bodycustomNameFormat = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodycustomName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/nameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                if (bodycustomNameFormat != null)
                {
                    body["custom_format"] = SourceExpressionConverter.ConvertToken(bodycustomNameFormat);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                if (bodycustomName != null)
                {
                    body["formatted_name"] = SourceExpressionConverter.ConvertToken(bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentNameFormat([WorkflowExpression] Func<string> nameFormatId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<bool> bodycustomNameFormat = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodycustomName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/nameformats/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(nameFormatId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodycustomNameFormat != null)
                {
                    body["custom_format"] = SourceExpressionConverter.ConvertToken(bodycustomNameFormat);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                if (bodycustomName != null)
                {
                    body["formatted_name"] = SourceExpressionConverter.ConvertToken(bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentNote> CreateConstituentNote([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null, [WorkflowExpression] Func<string> bodyauthor = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/notes";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodyauthor != null)
                {
                    body["author"] = SourceExpressionConverter.ConvertToken(bodyauthor);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentNote>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentNote([WorkflowExpression] Func<string> noteId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<int> bodydateday = null, [WorkflowExpression] Func<int> bodydatemonth = null, [WorkflowExpression] Func<int> bodydateyear = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodynote = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/notes/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(noteId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                var dateObject = new JObject();
                var dateObjectpropCount = 0;
                if (bodydateday != null)
                {
                    dateObject["d"] = SourceExpressionConverter.ConvertToken(bodydateday);
                    dateObjectpropCount++;
                }

                if (bodydatemonth != null)
                {
                    dateObject["m"] = SourceExpressionConverter.ConvertToken(bodydatemonth);
                    dateObjectpropCount++;
                }

                if (bodydateyear != null)
                {
                    dateObject["y"] = SourceExpressionConverter.ConvertToken(bodydateyear);
                    dateObjectpropCount++;
                }

                if (dateObjectpropCount > 0)
                {
                    body["date"] = dateObject;
                    bodypropCount++;
                }

                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodynote != null)
                {
                    body["text"] = SourceExpressionConverter.ConvertToken(bodynote);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentOnlinePresence> CreateConstituentOnlinePresence([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodylink, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/onlinepresences";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["address"] = SourceExpressionConverter.ConvertToken(bodylink);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentOnlinePresence>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentOnlinePresence([WorkflowExpression] Func<string> onlinePresenceId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodylink = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/onlinepresences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(onlinePresenceId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodylink != null)
                {
                    body["address"] = SourceExpressionConverter.ConvertToken(bodylink);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedConstituentPhone> CreateConstituentPhone([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodytype, [WorkflowExpression] Func<string> bodynumber, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/phones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                bodypropCount++;
                body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedConstituentPhone>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentPhone([WorkflowExpression] Func<string> phoneId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodynumber = null, [WorkflowExpression] Func<bool> bodyprimary = null, [WorkflowExpression] Func<bool> bodydoNotCall = null, [WorkflowExpression] Func<bool> bodyinactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/phones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(phoneId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodynumber != null)
                {
                    body["number"] = SourceExpressionConverter.ConvertToken(bodynumber);
                    bodypropCount++;
                }

                if (bodyprimary != null)
                {
                    body["primary"] = SourceExpressionConverter.ConvertToken(bodyprimary);
                    bodypropCount++;
                }

                if (bodydoNotCall != null)
                {
                    body["do_not_call"] = SourceExpressionConverter.ConvertToken(bodydoNotCall);
                    bodypropCount++;
                }

                if (bodyinactive != null)
                {
                    body["inactive"] = SourceExpressionConverter.ConvertToken(bodyinactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedNameFormat> CreateConstituentPrimaryNameFormat([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<bodytypeInput> bodytype, [WorkflowExpression] Func<bool> bodycustomNameFormat = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodycustomName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/primarynameformats";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["primary_type"] = SourceExpressionConverter.Convert(bodytype);
                if (bodycustomNameFormat != null)
                {
                    body["custom_format"] = SourceExpressionConverter.ConvertToken(bodycustomNameFormat);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                if (bodycustomName != null)
                {
                    body["formatted_name"] = SourceExpressionConverter.ConvertToken(bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedNameFormat>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentPrimaryNameFormat([WorkflowExpression] Func<string> primaryNameFormatId, [WorkflowExpression] Func<bool> bodycustomNameFormat = null, [WorkflowExpression] Func<string> bodyformat = null, [WorkflowExpression] Func<string> bodycustomName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/primarynameformats/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(primaryNameFormatId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycustomNameFormat != null)
                {
                    body["custom_format"] = SourceExpressionConverter.ConvertToken(bodycustomNameFormat);
                    bodypropCount++;
                }

                if (bodyformat != null)
                {
                    body["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyformat);
                    bodypropCount++;
                }

                if (bodycustomName != null)
                {
                    body["formatted_name"] = SourceExpressionConverter.ConvertToken(bodycustomName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IWorkflowAction EditConstituentRelationship([WorkflowExpression] Func<string> relationshipId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisSpouse = null, [WorkflowExpression] Func<bool> bodyisConstituentHeadOfHousehold = null, [WorkflowExpression] Func<bool> bodyisSpouseHeadOfHousehold = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyisContact = null, [WorkflowExpression] Func<bool> bodyisPrimaryBusiness = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodyposition = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/constituent/v1/relationships/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(relationshipId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisSpouse != null)
                {
                    body["is_spouse"] = SourceExpressionConverter.ConvertToken(bodyisSpouse);
                    bodypropCount++;
                }

                if (bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyisContact != null)
                {
                    body["is_organization_contact"] = SourceExpressionConverter.ConvertToken(bodyisContact);
                    bodypropCount++;
                }

                if (bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["organization_contact_type"] = SourceExpressionConverter.ConvertToken(bodycontactType);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualConstituent> CreateIndividualConstituent([WorkflowExpression] Func<string> bodylastName, [WorkflowExpression] Func<string> bodyaddresstype, [WorkflowExpression] Func<string> bodyphonetype, [WorkflowExpression] Func<string> bodyphonenumber, [WorkflowExpression] Func<string> bodyemailtype, [WorkflowExpression] Func<string> bodyemailaddress, [WorkflowExpression] Func<string> bodyonlinePresencetype, [WorkflowExpression] Func<string> bodyonlinePresenceaddress, [WorkflowExpression] Func<string> bodytitle = null, [WorkflowExpression] Func<string> bodyfirstName = null, [WorkflowExpression] Func<string> bodysuffix = null, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddresssuburb = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddressstart = null, [WorkflowExpression] Func<string> bodyaddressend = null, [WorkflowExpression] Func<bool> bodyphoneisPrimary = null, [WorkflowExpression] Func<bool> bodyemailisPrimary = null, [WorkflowExpression] Func<bool> bodyonlinePresenceisPrimary = null, [WorkflowExpression] Func<string> bodypreferredName = null, [WorkflowExpression] Func<string> bodymiddleName = null, [WorkflowExpression] Func<string> bodyformerName = null, [WorkflowExpression] Func<string> bodytitle2 = null, [WorkflowExpression] Func<string> bodysuffix2 = null, [WorkflowExpression] Func<string> bodygender = null, [WorkflowExpression] Func<string> bodymaritalStatus = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodyrequestsNoEmail = null, [WorkflowExpression] Func<bool> bodyisASolicitor = null, [WorkflowExpression] Func<bool> bodynoValidAddresses = null, [WorkflowExpression] Func<int> bodybirthdateday = null, [WorkflowExpression] Func<int> bodybirthdatemonth = null, [WorkflowExpression] Func<int> bodybirthdateyear = null, [WorkflowExpression] Func<string> bodybirthplace = null, [WorkflowExpression] Func<string> bodyethnicity = null, [WorkflowExpression] Func<string> bodytarget = null, [WorkflowExpression] Func<string> bodyincome = null, [WorkflowExpression] Func<bodyreceiptTypeInput> bodyreceiptType = null, [WorkflowExpression] Func<string> bodyreligion = null, [WorkflowExpression] Func<bool> bodyprimaryAddresseecustomAddressee = null, [WorkflowExpression] Func<string> bodyprimaryAddresseeaddresseeFormat = null, [WorkflowExpression] Func<string> bodyprimaryAddresseeaddresseeCustomName = null, [WorkflowExpression] Func<bool> bodyprimarySalutationcustomSalutation = null, [WorkflowExpression] Func<string> bodyprimarySalutationsalutationFormat = null, [WorkflowExpression] Func<string> bodyprimarySalutationsalutationCustomName = null, [WorkflowExpression] Func<bool> bodyisMemorial = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/individuals";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Individual";
                bodypropCount++;
                if (bodytitle != null)
                {
                    body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                    bodypropCount++;
                }

                if (bodyfirstName != null)
                {
                    body["first"] = SourceExpressionConverter.ConvertToken(bodyfirstName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["last"] = SourceExpressionConverter.ConvertToken(bodylastName);
                if (bodysuffix != null)
                {
                    body["suffix"] = SourceExpressionConverter.ConvertToken(bodysuffix);
                    bodypropCount++;
                }

                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = SourceExpressionConverter.ConvertToken(bodyaddresstype);
                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresslines != null)
                {
                    addressObject["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = SourceExpressionConverter.ConvertToken(bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddressstart != null)
                {
                    addressObject["start"] = SourceExpressionConverter.ConvertToken(bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (bodyaddressend != null)
                {
                    addressObject["end"] = SourceExpressionConverter.ConvertToken(bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = SourceExpressionConverter.ConvertToken(bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = SourceExpressionConverter.ConvertToken(bodyphonenumber);
                if (bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = SourceExpressionConverter.ConvertToken(bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = SourceExpressionConverter.ConvertToken(bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = SourceExpressionConverter.ConvertToken(bodyemailaddress);
                if (bodyemailisPrimary != null)
                {
                    emailObject["primary"] = SourceExpressionConverter.ConvertToken(bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = SourceExpressionConverter.ConvertToken(bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceaddress);
                if (bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (bodypreferredName != null)
                {
                    body["preferred_name"] = SourceExpressionConverter.ConvertToken(bodypreferredName);
                    bodypropCount++;
                }

                if (bodymiddleName != null)
                {
                    body["middle"] = SourceExpressionConverter.ConvertToken(bodymiddleName);
                    bodypropCount++;
                }

                if (bodyformerName != null)
                {
                    body["former_name"] = SourceExpressionConverter.ConvertToken(bodyformerName);
                    bodypropCount++;
                }

                if (bodytitle2 != null)
                {
                    body["title_2"] = SourceExpressionConverter.ConvertToken(bodytitle2);
                    bodypropCount++;
                }

                if (bodysuffix2 != null)
                {
                    body["suffix_2"] = SourceExpressionConverter.ConvertToken(bodysuffix2);
                    bodypropCount++;
                }

                if (bodygender != null)
                {
                    body["gender"] = SourceExpressionConverter.ConvertToken(bodygender);
                    bodypropCount++;
                }

                if (bodymaritalStatus != null)
                {
                    body["marital_status"] = SourceExpressionConverter.ConvertToken(bodymaritalStatus);
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = SourceExpressionConverter.ConvertToken(bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (bodyisASolicitor != null)
                {
                    body["is_solicitor"] = SourceExpressionConverter.ConvertToken(bodyisASolicitor);
                    bodypropCount++;
                }

                if (bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = SourceExpressionConverter.ConvertToken(bodynoValidAddresses);
                    bodypropCount++;
                }

                var birthdateObject = new JObject();
                var birthdateObjectpropCount = 0;
                if (bodybirthdateday != null)
                {
                    birthdateObject["d"] = SourceExpressionConverter.ConvertToken(bodybirthdateday);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdatemonth != null)
                {
                    birthdateObject["m"] = SourceExpressionConverter.ConvertToken(bodybirthdatemonth);
                    birthdateObjectpropCount++;
                }

                if (bodybirthdateyear != null)
                {
                    birthdateObject["y"] = SourceExpressionConverter.ConvertToken(bodybirthdateyear);
                    birthdateObjectpropCount++;
                }

                if (birthdateObjectpropCount > 0)
                {
                    body["birthdate"] = birthdateObject;
                    bodypropCount++;
                }

                if (bodybirthplace != null)
                {
                    body["birthplace"] = SourceExpressionConverter.ConvertToken(bodybirthplace);
                    bodypropCount++;
                }

                if (bodyethnicity != null)
                {
                    body["ethnicity"] = SourceExpressionConverter.ConvertToken(bodyethnicity);
                    bodypropCount++;
                }

                if (bodytarget != null)
                {
                    body["target"] = SourceExpressionConverter.ConvertToken(bodytarget);
                    bodypropCount++;
                }

                if (bodyincome != null)
                {
                    body["income"] = SourceExpressionConverter.ConvertToken(bodyincome);
                    bodypropCount++;
                }

                if (bodyreceiptType != null)
                {
                    body["receipt_type"] = SourceExpressionConverter.Convert(bodyreceiptType);
                    bodypropCount++;
                }

                if (bodyreligion != null)
                {
                    body["religion"] = SourceExpressionConverter.ConvertToken(bodyreligion);
                    bodypropCount++;
                }

                var primaryAddresseeObject = new JObject();
                var primaryAddresseeObjectpropCount = 0;
                if (bodyprimaryAddresseecustomAddressee != null)
                {
                    primaryAddresseeObject["custom_format"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseecustomAddressee);
                    primaryAddresseeObjectpropCount++;
                }

                if (bodyprimaryAddresseeaddresseeFormat != null)
                {
                    primaryAddresseeObject["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseeaddresseeFormat);
                    primaryAddresseeObjectpropCount++;
                }

                if (bodyprimaryAddresseeaddresseeCustomName != null)
                {
                    primaryAddresseeObject["formatted_name"] = SourceExpressionConverter.ConvertToken(bodyprimaryAddresseeaddresseeCustomName);
                    primaryAddresseeObjectpropCount++;
                }

                if (primaryAddresseeObjectpropCount > 0)
                {
                    body["primary_addressee"] = primaryAddresseeObject;
                    bodypropCount++;
                }

                var primarySalutationObject = new JObject();
                var primarySalutationObjectpropCount = 0;
                if (bodyprimarySalutationcustomSalutation != null)
                {
                    primarySalutationObject["custom_format"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationcustomSalutation);
                    primarySalutationObjectpropCount++;
                }

                if (bodyprimarySalutationsalutationFormat != null)
                {
                    primarySalutationObject["configuration_id"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationsalutationFormat);
                    primarySalutationObjectpropCount++;
                }

                if (bodyprimarySalutationsalutationCustomName != null)
                {
                    primarySalutationObject["formatted_name"] = SourceExpressionConverter.ConvertToken(bodyprimarySalutationsalutationCustomName);
                    primarySalutationObjectpropCount++;
                }

                if (primarySalutationObjectpropCount > 0)
                {
                    body["primary_salutation"] = primarySalutationObject;
                    bodypropCount++;
                }

                if (bodyisMemorial != null)
                {
                    body["is_memorial"] = SourceExpressionConverter.ConvertToken(bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedIndividualRelationship> CreateIndividualRelationship([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyrelationId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisSpouse = null, [WorkflowExpression] Func<bool> bodyisConstituentHeadOfHousehold = null, [WorkflowExpression] Func<bool> bodyisSpouseHeadOfHousehold = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/individualrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = SourceExpressionConverter.ConvertToken(bodyrelationId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisSpouse != null)
                {
                    body["is_spouse"] = SourceExpressionConverter.ConvertToken(bodyisSpouse);
                    bodypropCount++;
                }

                if (bodyisConstituentHeadOfHousehold != null)
                {
                    body["is_constituent_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisConstituentHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodyisSpouseHeadOfHousehold != null)
                {
                    body["is_spouse_head_of_household"] = SourceExpressionConverter.ConvertToken(bodyisSpouseHeadOfHousehold);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedIndividualRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationConstituent> CreateOrganizationConstituent([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyaddresstype, [WorkflowExpression] Func<string> bodyphonetype, [WorkflowExpression] Func<string> bodyphonenumber, [WorkflowExpression] Func<string> bodyemailtype, [WorkflowExpression] Func<string> bodyemailaddress, [WorkflowExpression] Func<string> bodyonlinePresencetype, [WorkflowExpression] Func<string> bodyonlinePresenceaddress, [WorkflowExpression] Func<string> bodylookupId = null, [WorkflowExpression] Func<string> bodyaddresscountry = null, [WorkflowExpression] Func<string> bodyaddresslines = null, [WorkflowExpression] Func<string> bodyaddresscity = null, [WorkflowExpression] Func<string> bodyaddressstate = null, [WorkflowExpression] Func<string> bodyaddresspostalCode = null, [WorkflowExpression] Func<string> bodyaddresssuburb = null, [WorkflowExpression] Func<string> bodyaddresscounty = null, [WorkflowExpression] Func<string> bodyaddressstart = null, [WorkflowExpression] Func<string> bodyaddressend = null, [WorkflowExpression] Func<bool> bodyphoneisPrimary = null, [WorkflowExpression] Func<bool> bodyemailisPrimary = null, [WorkflowExpression] Func<bool> bodyonlinePresenceisPrimary = null, [WorkflowExpression] Func<bool> bodygivesAnonymously = null, [WorkflowExpression] Func<bool> bodyrequestsNoEmail = null, [WorkflowExpression] Func<bool> bodyisASolicitor = null, [WorkflowExpression] Func<bool> bodynoValidAddresses = null, [WorkflowExpression] Func<string> bodytarget = null, [WorkflowExpression] Func<string> bodyincome = null, [WorkflowExpression] Func<bodyreceiptTypeInput> bodyreceiptType = null, [WorkflowExpression] Func<string> bodyindustry = null, [WorkflowExpression] Func<int> bodynumberOfEmployees = null, [WorkflowExpression] Func<bool> bodymatchesGifts = null, [WorkflowExpression] Func<double> bodymatchingGiftFactor = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMinminMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftPerGiftMaxmaxMatchPerGift = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMinminMatchPerConstit = null, [WorkflowExpression] Func<double> bodymatchingGiftTotalMaxmaxMatchPerConstit = null, [WorkflowExpression] Func<string> bodymatchingGiftNotes = null, [WorkflowExpression] Func<bool> bodyisMemorial = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/organizations";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["type"] = "Organization";
                bodypropCount++;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodylookupId != null)
                {
                    body["lookup_id"] = SourceExpressionConverter.ConvertToken(bodylookupId);
                    bodypropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                addressObjectpropCount++;
                addressObject["type"] = SourceExpressionConverter.ConvertToken(bodyaddresstype);
                if (bodyaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyaddresscountry);
                    addressObjectpropCount++;
                }

                if (bodyaddresslines != null)
                {
                    addressObject["address_lines"] = SourceExpressionConverter.ConvertToken(bodyaddresslines);
                    addressObjectpropCount++;
                }

                if (bodyaddresscity != null)
                {
                    addressObject["city"] = SourceExpressionConverter.ConvertToken(bodyaddresscity);
                    addressObjectpropCount++;
                }

                if (bodyaddressstate != null)
                {
                    addressObject["state"] = SourceExpressionConverter.ConvertToken(bodyaddressstate);
                    addressObjectpropCount++;
                }

                if (bodyaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyaddresssuburb != null)
                {
                    addressObject["suburb"] = SourceExpressionConverter.ConvertToken(bodyaddresssuburb);
                    addressObjectpropCount++;
                }

                if (bodyaddresscounty != null)
                {
                    addressObject["county"] = SourceExpressionConverter.ConvertToken(bodyaddresscounty);
                    addressObjectpropCount++;
                }

                if (bodyaddressstart != null)
                {
                    addressObject["start"] = SourceExpressionConverter.ConvertToken(bodyaddressstart);
                    addressObjectpropCount++;
                }

                if (bodyaddressend != null)
                {
                    addressObject["end"] = SourceExpressionConverter.ConvertToken(bodyaddressend);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    body["address"] = addressObject;
                    bodypropCount++;
                }

                var phoneObject = new JObject();
                var phoneObjectpropCount = 0;
                phoneObjectpropCount++;
                phoneObject["type"] = SourceExpressionConverter.ConvertToken(bodyphonetype);
                phoneObjectpropCount++;
                phoneObject["number"] = SourceExpressionConverter.ConvertToken(bodyphonenumber);
                if (bodyphoneisPrimary != null)
                {
                    phoneObject["primary"] = SourceExpressionConverter.ConvertToken(bodyphoneisPrimary);
                    phoneObjectpropCount++;
                }

                if (phoneObjectpropCount > 0)
                {
                    body["phone"] = phoneObject;
                    bodypropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                emailObjectpropCount++;
                emailObject["type"] = SourceExpressionConverter.ConvertToken(bodyemailtype);
                emailObjectpropCount++;
                emailObject["address"] = SourceExpressionConverter.ConvertToken(bodyemailaddress);
                if (bodyemailisPrimary != null)
                {
                    emailObject["primary"] = SourceExpressionConverter.ConvertToken(bodyemailisPrimary);
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    body["email"] = emailObject;
                    bodypropCount++;
                }

                var onlinePresenceObject = new JObject();
                var onlinePresenceObjectpropCount = 0;
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["type"] = SourceExpressionConverter.ConvertToken(bodyonlinePresencetype);
                onlinePresenceObjectpropCount++;
                onlinePresenceObject["address"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceaddress);
                if (bodyonlinePresenceisPrimary != null)
                {
                    onlinePresenceObject["primary"] = SourceExpressionConverter.ConvertToken(bodyonlinePresenceisPrimary);
                    onlinePresenceObjectpropCount++;
                }

                if (onlinePresenceObjectpropCount > 0)
                {
                    body["online_presence"] = onlinePresenceObject;
                    bodypropCount++;
                }

                if (bodygivesAnonymously != null)
                {
                    body["gives_anonymously"] = SourceExpressionConverter.ConvertToken(bodygivesAnonymously);
                    bodypropCount++;
                }

                if (bodyrequestsNoEmail != null)
                {
                    body["requests_no_email"] = SourceExpressionConverter.ConvertToken(bodyrequestsNoEmail);
                    bodypropCount++;
                }

                if (bodyisASolicitor != null)
                {
                    body["is_solicitor"] = SourceExpressionConverter.ConvertToken(bodyisASolicitor);
                    bodypropCount++;
                }

                if (bodynoValidAddresses != null)
                {
                    body["no_valid_address"] = SourceExpressionConverter.ConvertToken(bodynoValidAddresses);
                    bodypropCount++;
                }

                if (bodytarget != null)
                {
                    body["target"] = SourceExpressionConverter.ConvertToken(bodytarget);
                    bodypropCount++;
                }

                if (bodyincome != null)
                {
                    body["income"] = SourceExpressionConverter.ConvertToken(bodyincome);
                    bodypropCount++;
                }

                if (bodyreceiptType != null)
                {
                    body["receipt_type"] = SourceExpressionConverter.Convert(bodyreceiptType);
                    bodypropCount++;
                }

                if (bodyindustry != null)
                {
                    body["industry"] = SourceExpressionConverter.ConvertToken(bodyindustry);
                    bodypropCount++;
                }

                if (bodynumberOfEmployees != null)
                {
                    body["num_employees"] = SourceExpressionConverter.ConvertToken(bodynumberOfEmployees);
                    bodypropCount++;
                }

                if (bodymatchesGifts != null)
                {
                    body["matches_gifts"] = SourceExpressionConverter.ConvertToken(bodymatchesGifts);
                    bodypropCount++;
                }

                if (bodymatchingGiftFactor != null)
                {
                    body["matching_gift_factor"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftFactor);
                    bodypropCount++;
                }

                var matchingGiftPerGiftMinObject = new JObject();
                var matchingGiftPerGiftMinObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMinminMatchPerGift != null)
                {
                    matchingGiftPerGiftMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMinminMatchPerGift);
                    matchingGiftPerGiftMinObjectpropCount++;
                }

                if (matchingGiftPerGiftMinObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_min"] = matchingGiftPerGiftMinObject;
                    bodypropCount++;
                }

                var matchingGiftPerGiftMaxObject = new JObject();
                var matchingGiftPerGiftMaxObjectpropCount = 0;
                if (bodymatchingGiftPerGiftMaxmaxMatchPerGift != null)
                {
                    matchingGiftPerGiftMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftPerGiftMaxmaxMatchPerGift);
                    matchingGiftPerGiftMaxObjectpropCount++;
                }

                if (matchingGiftPerGiftMaxObjectpropCount > 0)
                {
                    body["matching_gift_per_gift_max"] = matchingGiftPerGiftMaxObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMinObject = new JObject();
                var matchingGiftTotalMinObjectpropCount = 0;
                if (bodymatchingGiftTotalMinminMatchPerConstit != null)
                {
                    matchingGiftTotalMinObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMinminMatchPerConstit);
                    matchingGiftTotalMinObjectpropCount++;
                }

                if (matchingGiftTotalMinObjectpropCount > 0)
                {
                    body["matching_gift_total_min"] = matchingGiftTotalMinObject;
                    bodypropCount++;
                }

                var matchingGiftTotalMaxObject = new JObject();
                var matchingGiftTotalMaxObjectpropCount = 0;
                if (bodymatchingGiftTotalMaxmaxMatchPerConstit != null)
                {
                    matchingGiftTotalMaxObject["value"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftTotalMaxmaxMatchPerConstit);
                    matchingGiftTotalMaxObjectpropCount++;
                }

                if (matchingGiftTotalMaxObjectpropCount > 0)
                {
                    body["matching_gift_total_max"] = matchingGiftTotalMaxObject;
                    bodypropCount++;
                }

                if (bodymatchingGiftNotes != null)
                {
                    body["matching_gift_notes"] = SourceExpressionConverter.ConvertToken(bodymatchingGiftNotes);
                    bodypropCount++;
                }

                if (bodyisMemorial != null)
                {
                    body["is_memorial"] = SourceExpressionConverter.ConvertToken(bodyisMemorial);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationConstituent>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<ConstituentApiCreatedOrganizationRelationship> CreateOrganizationRelationship([WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<string> bodyrelationId, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyreciprocalType = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<bool> bodyisContact = null, [WorkflowExpression] Func<string> bodycontactType = null, [WorkflowExpression] Func<string> bodyposition = null, [WorkflowExpression] Func<bool> bodyisPrimaryBusiness = null, [WorkflowExpression] Func<string> bodynotes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/constituent/v1/virtual/organizationrelationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["relation_id"] = SourceExpressionConverter.ConvertToken(bodyrelationId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyreciprocalType != null)
                {
                    body["reciprocal_type"] = SourceExpressionConverter.ConvertToken(bodyreciprocalType);
                    bodypropCount++;
                }

                var startObject = new JObject();
                var startObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startObjectpropCount++;
                }

                if (startObjectpropCount > 0)
                {
                    body["start"] = startObject;
                    bodypropCount++;
                }

                var endObject = new JObject();
                var endObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endObjectpropCount++;
                }

                if (endObjectpropCount > 0)
                {
                    body["end"] = endObject;
                    bodypropCount++;
                }

                if (bodyisContact != null)
                {
                    body["is_organization_contact"] = SourceExpressionConverter.ConvertToken(bodyisContact);
                    bodypropCount++;
                }

                if (bodycontactType != null)
                {
                    body["organization_contact_type"] = SourceExpressionConverter.ConvertToken(bodycontactType);
                    bodypropCount++;
                }

                if (bodyposition != null)
                {
                    body["position"] = SourceExpressionConverter.ConvertToken(bodyposition);
                    bodypropCount++;
                }

                if (bodyisPrimaryBusiness != null)
                {
                    body["is_primary_business"] = SourceExpressionConverter.ConvertToken(bodyisPrimaryBusiness);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConstituentApiCreatedOrganizationRelationship>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiCreatedFundraiserAssignment> CreateFundraiserAssignment([WorkflowExpression] Func<string> bodyfundraiserId, [WorkflowExpression] Func<string> bodyconstituentId, [WorkflowExpression] Func<double> bodyamountamount, [WorkflowExpression] Func<string> bodytype = null, [WorkflowExpression] Func<string> bodyassignmentStarts = null, [WorkflowExpression] Func<string> bodyassignmentEnds = null, [WorkflowExpression] Func<string> bodycampaignId = null, [WorkflowExpression] Func<string> bodyfundId = null, [WorkflowExpression] Func<string> bodyappealId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fundraising/v1/fundraisers/assignments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["fundraiser_id"] = SourceExpressionConverter.ConvertToken(bodyfundraiserId);
                bodypropCount++;
                body["constituent_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                if (bodytype != null)
                {
                    body["type"] = SourceExpressionConverter.ConvertToken(bodytype);
                    bodypropCount++;
                }

                if (bodyassignmentStarts != null)
                {
                    body["start"] = SourceExpressionConverter.ConvertToken(bodyassignmentStarts);
                    bodypropCount++;
                }

                if (bodyassignmentEnds != null)
                {
                    body["end"] = SourceExpressionConverter.ConvertToken(bodyassignmentEnds);
                    bodypropCount++;
                }

                var amountObject = new JObject();
                var amountObjectpropCount = 0;
                amountObjectpropCount++;
                amountObject["value"] = SourceExpressionConverter.ConvertToken(bodyamountamount);
                if (amountObjectpropCount > 0)
                {
                    body["amount"] = amountObject;
                    bodypropCount++;
                }

                if (bodycampaignId != null)
                {
                    body["campaign_id"] = SourceExpressionConverter.ConvertToken(bodycampaignId);
                    bodypropCount++;
                }

                if (bodyfundId != null)
                {
                    body["fund_id"] = SourceExpressionConverter.ConvertToken(bodyfundId);
                    bodypropCount++;
                }

                if (bodyappealId != null)
                {
                    body["appeal_id"] = SourceExpressionConverter.ConvertToken(bodyappealId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiCreatedFundraiserAssignment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead> ListFundraiserAssignments([WorkflowExpression] Func<string> fundraiserId, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<int> offset = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/fundraising/v1/fundraisers/{0}/assignments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fundraiserId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (offset != null)
                    callPayload.Queries["offset"] = SourceExpressionConverter.ConvertO(offset);
                return callPayload;
            }

            return new ApiConnectionAction<FundraisingApiApiCollectionOfFundraiserAssignmentRead>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentIdMap> GetConstituentIdFromLookupId([WorkflowExpression] Func<string> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/constituentidmap/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiConstituentIdMap>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiConstituentSearchResultCollection> SearchConstituentEnhanced([WorkflowExpression] Func<string> firstName = null, [WorkflowExpression] Func<string> lastName = null, [WorkflowExpression] Func<string> lookupId = null, [WorkflowExpression] Func<string> email = null, [WorkflowExpression] Func<string> phoneNumber = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> addressLines = null, [WorkflowExpression] Func<string> city = null, [WorkflowExpression] Func<string> state = null, [WorkflowExpression] Func<string> postCode = null, [WorkflowExpression] Func<bool> includeAlias = null, [WorkflowExpression] Func<string> aliasType = null, [WorkflowExpression] Func<bool> includeMaidenName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/constituents/customsearch";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (firstName != null)
                    callPayload.Queries["first_name"] = SourceExpressionConverter.ConvertO(firstName);
                if (lastName != null)
                    callPayload.Queries["last_name"] = SourceExpressionConverter.ConvertO(lastName);
                if (lookupId != null)
                    callPayload.Queries["lookup_id"] = SourceExpressionConverter.ConvertO(lookupId);
                if (email != null)
                    callPayload.Queries["email"] = SourceExpressionConverter.ConvertO(email);
                if (phoneNumber != null)
                    callPayload.Queries["phone_number"] = SourceExpressionConverter.ConvertO(phoneNumber);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (addressLines != null)
                    callPayload.Queries["address_lines"] = SourceExpressionConverter.ConvertO(addressLines);
                if (city != null)
                    callPayload.Queries["city"] = SourceExpressionConverter.ConvertO(city);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.ConvertO(state);
                if (postCode != null)
                    callPayload.Queries["post_code"] = SourceExpressionConverter.ConvertO(postCode);
                if (includeAlias != null)
                    callPayload.Queries["include_alias"] = SourceExpressionConverter.ConvertO(includeAlias);
                if (aliasType != null)
                    callPayload.Queries["alias_type"] = SourceExpressionConverter.ConvertO(aliasType);
                if (includeMaidenName != null)
                    callPayload.Queries["include_maiden_name"] = SourceExpressionConverter.ConvertO(includeMaidenName);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiConstituentSearchResultCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedConstituentTribute> CreateConstituentTribute([WorkflowExpression] Func<int> bodyconstituentId, [WorkflowExpression] Func<int> bodytributeType, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<int> bodystartday = null, [WorkflowExpression] Func<int> bodystartmonth = null, [WorkflowExpression] Func<int> bodystartyear = null, [WorkflowExpression] Func<int> bodyendday = null, [WorkflowExpression] Func<int> bodyendmonth = null, [WorkflowExpression] Func<int> bodyendyear = null, [WorkflowExpression] Func<int> bodydefaultFundId = null, [WorkflowExpression] Func<string> bodynotes = null, [WorkflowExpression] Func<bool> bodyactive = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["constituent_record_id"] = SourceExpressionConverter.ConvertToken(bodyconstituentId);
                bodypropCount++;
                body["tribute_type_id"] = SourceExpressionConverter.ConvertToken(bodytributeType);
                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                var startDateObject = new JObject();
                var startDateObjectpropCount = 0;
                if (bodystartday != null)
                {
                    startDateObject["d"] = SourceExpressionConverter.ConvertToken(bodystartday);
                    startDateObjectpropCount++;
                }

                if (bodystartmonth != null)
                {
                    startDateObject["m"] = SourceExpressionConverter.ConvertToken(bodystartmonth);
                    startDateObjectpropCount++;
                }

                if (bodystartyear != null)
                {
                    startDateObject["y"] = SourceExpressionConverter.ConvertToken(bodystartyear);
                    startDateObjectpropCount++;
                }

                if (startDateObjectpropCount > 0)
                {
                    body["start_date"] = startDateObject;
                    bodypropCount++;
                }

                var endDateObject = new JObject();
                var endDateObjectpropCount = 0;
                if (bodyendday != null)
                {
                    endDateObject["d"] = SourceExpressionConverter.ConvertToken(bodyendday);
                    endDateObjectpropCount++;
                }

                if (bodyendmonth != null)
                {
                    endDateObject["m"] = SourceExpressionConverter.ConvertToken(bodyendmonth);
                    endDateObjectpropCount++;
                }

                if (bodyendyear != null)
                {
                    endDateObject["y"] = SourceExpressionConverter.ConvertToken(bodyendyear);
                    endDateObjectpropCount++;
                }

                if (endDateObjectpropCount > 0)
                {
                    body["end_date"] = endDateObject;
                    bodypropCount++;
                }

                if (bodydefaultFundId != null)
                {
                    body["default_fund_id"] = SourceExpressionConverter.ConvertToken(bodydefaultFundId);
                    bodypropCount++;
                }

                if (bodynotes != null)
                {
                    body["notes"] = SourceExpressionConverter.ConvertToken(bodynotes);
                    bodypropCount++;
                }

                if (bodyactive != null)
                {
                    body["is_active"] = SourceExpressionConverter.ConvertToken(bodyactive);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedConstituentTribute>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTribute> GetConstituentTribute([WorkflowExpression] Func<string> tributeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/tribute/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tributeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiTribute>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiCreatedTributeAcknowledgee> CreateTributeAcknowledgee([WorkflowExpression] Func<int> bodytributeId, [WorkflowExpression] Func<int> bodyrelationshipId = null, [WorkflowExpression] Func<int> bodyletterId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/nxt-data-integration/v1/re/tribute/acknowledgee";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tribute_id"] = SourceExpressionConverter.ConvertToken(bodytributeId);
                if (bodyrelationshipId != null)
                {
                    body["relationship_id"] = SourceExpressionConverter.ConvertToken(bodyrelationshipId);
                    bodypropCount++;
                }

                if (bodyletterId != null)
                {
                    body["letter_id"] = SourceExpressionConverter.ConvertToken(bodyletterId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiCreatedTributeAcknowledgee>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeCollection> ListConstituentTributes([WorkflowExpression] Func<int> constituentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/tribute/constituent/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(constituentId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiTributeCollection>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "blackbaudconstituent")]
        public IBodyWorkflowAction<NXTDataIntegrationApiTributeAcknowledgeeCollection> ListTributeAcknowledgees([WorkflowExpression] Func<int> tributeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/nxt-data-integration/v1/re/tribute/{0}/acknowledgees", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(tributeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<NXTDataIntegrationApiTributeAcknowledgeeCollection>(BuildSourceInput);
        }
    }

    public class BlackbaudconstituentTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommPrefApiCreatedConstituentConsent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodyresponseInput
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentConsentReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentConsentRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentConsentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("constituent_consent_response")]
        public CommPrefApiConstituentConsentReadResponseType Response { get; set; }

        [JsonProperty("consent_date")]
        public string Date { get; set; }

        [JsonProperty("consent_statement")]
        public string ConsentStatement { get; set; }

        [JsonProperty("privacy_notice")]
        public string PrivacyNotice { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("user_name")]
        public string AddedBy { get; set; }
    }

    public enum CommPrefApiConstituentConsentReadResponseType
    {
        OptIn,
        OptOut,
        NoResponse
    }

    public class CommPrefApiConstituentSolicitCodeReadCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public CommPrefApiConstituentSolicitCodeRead[] Value { get; set; }
    }

    public class CommPrefApiConstituentSolicitCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("solicit_code")]
        public string SolicitCode { get; set; }

        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        [JsonProperty("end_date")]
        public string EndDate { get; set; }
    }

    public class CommPrefApiCreatedConstituentSolicitCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAlias
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentCode
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentReadTypeType Type { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("suffix")]
        public string Suffix { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }

        [JsonProperty("email")]
        public ConstituentApiConstituentReadPrimaryEmailType PrimaryEmail { get; set; }

        [JsonProperty("phone")]
        public ConstituentApiConstituentReadPrimaryPhoneType PrimaryPhone { get; set; }

        [JsonProperty("online_presence")]
        public ConstituentApiConstituentReadPrimaryOnlinePresenceType PrimaryOnlinePresence { get; set; }

        [JsonProperty("address")]
        public ConstituentApiConstituentReadPreferredAddressType PreferredAddress { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("middle")]
        public string MiddleName { get; set; }

        [JsonProperty("former_name")]
        public string FormerName { get; set; }

        [JsonProperty("title_2")]
        public string Title2 { get; set; }

        [JsonProperty("suffix_2")]
        public string Suffix2 { get; set; }

        [JsonProperty("marital_status")]
        public string MaritalStaus { get; set; }

        [JsonProperty("gives_anonymously")]
        public bool GivesAnonymously { get; set; }

        [JsonProperty("requests_no_email")]
        public bool RequestsNoEmail { get; set; }

        [JsonProperty("is_solicitor")]
        public bool IsASolicitor { get; set; }

        [JsonProperty("no_valid_address")]
        public bool NoValidAddresses { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("birthdate")]
        public ConstituentApiConstituentReadBirthdateType Birthdate { get; set; }

        [JsonProperty("birthplace")]
        public string Birthplace { get; set; }

        [JsonProperty("ethnicity")]
        public string Ethnicity { get; set; }

        [JsonProperty("target")]
        public string Target { get; set; }

        [JsonProperty("income")]
        public string Income { get; set; }

        [JsonProperty("receipt_type")]
        public ConstituentApiConstituentReadReceiptTypeType ReceiptType { get; set; }

        [JsonProperty("religion")]
        public string Religion { get; set; }

        [JsonProperty("industry")]
        public string Industry { get; set; }

        [JsonProperty("num_employees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("matches_gifts")]
        public bool MatchesGifts { get; set; }

        [JsonProperty("matching_gift_factor")]
        public double MatchingGiftFactor { get; set; }

        [JsonProperty("matching_gift_per_gift_min")]
        public ConstituentApiConstituentReadMinMatchPerGiftType MinMatchPerGift { get; set; }

        [JsonProperty("matching_gift_per_gift_max")]
        public ConstituentApiConstituentReadMaxMatchPerGiftType MaxMatchPerGift { get; set; }

        [JsonProperty("matching_gift_total_min")]
        public ConstituentApiConstituentReadMinMatchPerConstitType MinMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_total_max")]
        public ConstituentApiConstituentReadMaxMatchPerConstitType MaxMatchPerConstit { get; set; }

        [JsonProperty("matching_gift_notes")]
        public string MatchingGiftNotes { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("deceased_date")]
        public ConstituentApiConstituentReadDeceasedDateType DeceasedDate { get; set; }

        [JsonProperty("fundraiser_status")]
        public ConstituentApiConstituentReadFundraiserStatusType FundraiserStatus { get; set; }

        [JsonProperty("is_memorial")]
        public bool IsMemorial { get; set; }

        [JsonProperty("spouse")]
        public ConstituentApiConstituentReadSpouseType Spouse { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentReadTypeType
    {
        Individual,
        Organization
    }

    public class ConstituentApiConstituentReadPrimaryEmailType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryPhoneType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPrimaryOnlinePresenceType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string Lines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string Formatted { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadPreferredAddressTypeSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentReadBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public enum ConstituentApiConstituentReadReceiptTypeType
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class ConstituentApiConstituentReadMinMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerGiftType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMinMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadMaxMatchPerConstitType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiConstituentReadDeceasedDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public enum ConstituentApiConstituentReadFundraiserStatusType
    {
        Active,
        Inactive,
        None
    }

    public class ConstituentApiConstituentReadSpouseType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("first")]
        public string FirstName { get; set; }

        [JsonProperty("last")]
        public string LastName { get; set; }

        [JsonProperty("is_head_of_household")]
        public bool IsHeadOfHousehold { get; set; }
    }

    public enum bodyreceiptTypeInput
    {
        [EnumMember(Value = "One receipt per gift")]
        OneReceiptPerGift,
        [EnumMember(Value = "Consolidated receipts")]
        ConsolidatedReceipts
    }

    public class ConstituentApiApiCollectionOfAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAddressRead[] Value { get; set; }
    }

    public class ConstituentApiAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address_lines")]
        public string AddressLines { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postal_code")]
        public string PostalCode { get; set; }

        [JsonProperty("suburb")]
        public string Suburb { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("formatted_address")]
        public string FormattedAddress { get; set; }

        [JsonProperty("information_source")]
        public string InformationSource { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("cart")]
        public string CART { get; set; }

        [JsonProperty("lot")]
        public string LOT { get; set; }

        [JsonProperty("dpc")]
        public string DPC { get; set; }

        [JsonProperty("start")]
        public string ValidFrom { get; set; }

        [JsonProperty("end")]
        public string ValidTo { get; set; }

        [JsonProperty("preferred")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("do_not_mail")]
        public bool DoNotMail { get; set; }

        [JsonProperty("seasonal_start")]
        public ConstituentApiAddressReadSeasonalStartType SeasonalStart { get; set; }

        [JsonProperty("seasonal_end")]
        public ConstituentApiAddressReadSeasonalEndType SeasonalEnd { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiAddressReadSeasonalEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfAliasRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiAliasRead[] Value { get; set; }
    }

    public class ConstituentApiAliasRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Alias { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentAttachmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentAttachmentRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentAttachmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentAttachmentReadTypeType Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("file_id")]
        public string FileID { get; set; }

        [JsonProperty("thumbnail_id")]
        public string ThumbnailID { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("file_size")]
        public int FileSize { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }
    }

    public enum ConstituentApiConstituentAttachmentReadTypeType
    {
        Link,
        Physical
    }

    public class ConstituentApiApiCollectionOfConstituentCodeRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCodeRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCodeRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("description")]
        public string ConstituentCode { get; set; }

        [JsonProperty("start")]
        public ConstituentApiConstituentCodeReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiConstituentCodeReadEndType End { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiConstituentCodeReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConstituentCodeReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfConstituentCustomFieldRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiConstituentCustomFieldRead[] Value { get; set; }
    }

    public class ConstituentApiConstituentCustomFieldRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("parent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("type")]
        public ConstituentApiConstituentCustomFieldReadTypeType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }

        [JsonProperty("text_value")]
        public string TextValue { get; set; }

        [JsonProperty("number_value")]
        public int NumberValue { get; set; }

        [JsonProperty("date_value")]
        public string DateValue { get; set; }

        [JsonProperty("currency_value")]
        public double CurrencyValue { get; set; }

        [JsonProperty("boolean_value")]
        public bool BooleanValue { get; set; }

        [JsonProperty("codetableentry_value")]
        public string TableEntryValue { get; set; }

        [JsonProperty("constituentid_value")]
        public string ConstituentIDValue { get; set; }

        [JsonProperty("fuzzydate_value")]
        public ConstituentApiConstituentCustomFieldReadFuzzyDateValueType FuzzyDateValue { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiConstituentCustomFieldReadTypeType
    {
        Text,
        Number,
        Date,
        Currency,
        Boolean,
        CodeTableEntry,
        ConstituentId,
        FuzzyDate
    }

    public class ConstituentApiConstituentCustomFieldReadFuzzyDateValueType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEducationRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEducationRead[] Value { get; set; }
    }

    public class ConstituentApiEducationRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("class_of")]
        public string ClassOf { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("date_entered")]
        public ConstituentApiEducationReadDateEnteredType DateEntered { get; set; }

        [JsonProperty("date_left")]
        public ConstituentApiEducationReadDateLeftType DateLeft { get; set; }

        [JsonProperty("date_graduated")]
        public ConstituentApiEducationReadDateGraduatedType DateGraduated { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("gpa")]
        public double GPA { get; set; }

        [JsonProperty("majors")]
        public string[] Majors { get; set; }

        [JsonProperty("minors")]
        public string[] Minors { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryEducation { get; set; }

        [JsonProperty("campus")]
        public string Campus { get; set; }

        [JsonProperty("social_organization")]
        public string SocialOrganization { get; set; }

        [JsonProperty("known_name")]
        public string KnownName { get; set; }

        [JsonProperty("class_of_degree")]
        public string ClassOfDegree { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("faculty")]
        public string Faculty { get; set; }

        [JsonProperty("registration_number")]
        public string RegistrationNumber { get; set; }

        [JsonProperty("subject_of_study")]
        public string SubjectOfStudy { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiEducationReadDateEnteredType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateLeftType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiEducationReadDateGraduatedType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfEmailAddressRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiEmailAddressRead[] Value { get; set; }
    }

    public class ConstituentApiEmailAddressRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string EmailType { get; set; }

        [JsonProperty("address")]
        public string EmailAddress { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_email")]
        public bool DoNotEmail { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("fundraiser_id")]
        public string FundraiserID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("amount")]
        public ConstituentApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }

        [JsonProperty("start")]
        public string StartDate { get; set; }

        [JsonProperty("end")]
        public string EndDate { get; set; }
    }

    public class ConstituentApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiApiCollectionOfMembershipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiMembershipRead[] Value { get; set; }
    }

    public class ConstituentApiMembershipRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("program")]
        public string Program { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("subcategory")]
        public string Subcategory { get; set; }

        [JsonProperty("standing")]
        public ConstituentApiMembershipReadStandingType Standing { get; set; }

        [JsonProperty("expires")]
        public string Expires { get; set; }

        [JsonProperty("joined")]
        public string Joined { get; set; }

        [JsonProperty("dues")]
        public ConstituentApiMembershipReadDuesType Dues { get; set; }

        [JsonProperty("members")]
        public ConstituentApiMembershipMemberRead[] Members { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public enum ConstituentApiMembershipReadStandingType
    {
        New,
        Active,
        Lapsed,
        Dropped
    }

    public class ConstituentApiMembershipReadDuesType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class ConstituentApiMembershipMemberRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("primary")]
        public bool IsPrimaryMember { get; set; }
    }

    public class ConstituentApiNameFormatSummaryRead
    {
        [JsonProperty("primary_addressee")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeType PrimaryAddressee { get; set; }

        [JsonProperty("primary_salutation")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationType PrimarySalutation { get; set; }

        [JsonProperty("additional_name_formats")]
        public ConstituentApiNameFormatRead[] AdditionalNameFormats { get; set; }
    }

    public class ConstituentApiNameFormatSummaryReadPrimaryAddresseeType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public enum ConstituentApiNameFormatSummaryReadPrimaryAddresseeTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatSummaryReadPrimarySalutationType
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("primary_type")]
        public ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public enum ConstituentApiNameFormatSummaryReadPrimarySalutationTypeTypeType
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiNameFormatRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("custom_format")]
        public bool CustomFormat { get; set; }

        [JsonProperty("configuration_id")]
        public string ConfigurationID { get; set; }

        [JsonProperty("formatted_name")]
        public string FormattedName { get; set; }
    }

    public class ConstituentApiApiCollectionOfNoteRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiNoteRead[] Value { get; set; }
    }

    public class ConstituentApiNoteRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("date")]
        public ConstituentApiNoteReadDateType Date { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("text")]
        public string Note { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiNoteReadDateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiApiCollectionOfOnlinePresenceRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiOnlinePresenceRead[] Value { get; set; }
    }

    public class ConstituentApiOnlinePresenceRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("address")]
        public string Link { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiApiCollectionOfPhoneRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiPhoneRead[] Value { get; set; }
    }

    public class ConstituentApiPhoneRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("primary")]
        public bool Primary { get; set; }

        [JsonProperty("do_not_call")]
        public bool DoNotCall { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiProfilePictureRead
    {
        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("thumbnail_url")]
        public string ThumbnailURL { get; set; }
    }

    public class ConstituentApiApiCollectionOfRelationshipRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiRelationshipRead[] Value { get; set; }
    }

    public class ConstituentApiRelationshipRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("relation_id")]
        public string RelationID { get; set; }

        [JsonProperty("reciprocal_relationship_id")]
        public string ReciprocalRelationshipID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("reciprocal_type")]
        public string ReciprocalType { get; set; }

        [JsonProperty("start")]
        public ConstituentApiRelationshipReadStartType Start { get; set; }

        [JsonProperty("end")]
        public ConstituentApiRelationshipReadEndType End { get; set; }

        [JsonProperty("is_spouse")]
        public bool IsSpouse { get; set; }

        [JsonProperty("is_constituent_head_of_household")]
        public bool IsConstituentHeadOfHousehold { get; set; }

        [JsonProperty("is_spouse_head_of_household")]
        public bool IsSpouseHeadOfHousehold { get; set; }

        [JsonProperty("comment")]
        public string Notes { get; set; }

        [JsonProperty("is_organization_contact")]
        public bool IsContact { get; set; }

        [JsonProperty("is_primary_business")]
        public bool IsPrimaryBusiness { get; set; }

        [JsonProperty("organization_contact_type")]
        public string ContactType { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class ConstituentApiRelationshipReadStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiRelationshipReadEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class ConstituentApiConvertedConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentAttachment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public enum bodytypeInput
    {
        Addressee,
        Salutation
    }

    public class ConstituentApiCreatedConstituentCustomField
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiDuplicateSearchResultCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiDuplicateSearchResult[] Value { get; set; }
    }

    public class ConstituentApiDuplicateSearchResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("formatted_address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupID { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }
    }

    public class ConstituentApiApiCollectionOfSearchResultRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public ConstituentApiSearchResultRead[] Value { get; set; }
    }

    public class ConstituentApiSearchResultRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("deceased")]
        public bool Deceased { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fundraiser_status")]
        public string FundraiserStatus { get; set; }

        [JsonProperty("inactive")]
        public bool Inactive { get; set; }

        [JsonProperty("lookup_id")]
        public string LookupID { get; set; }
    }

    public enum searchFieldInput
    {
        [EnumMember(Value = "lookup_id")]
        LookupId,
        [EnumMember(Value = "email_address")]
        EmailAddress
    }

    public class ConstituentApiCreatedConstituentEducation
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentEmailAddress
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedNameFormat
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentNote
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentOnlinePresence
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedConstituentPhone
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedIndividualRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationConstituent
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class ConstituentApiCreatedOrganizationRelationship
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiCreatedFundraiserAssignment
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class FundraisingApiApiCollectionOfFundraiserAssignmentRead
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public FundraisingApiFundraiserAssignmentRead[] Value { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentRead
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("constituent_id")]
        public string ConstituentID { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("start")]
        public string AssignmentStarts { get; set; }

        [JsonProperty("end")]
        public string AssignmentEnds { get; set; }

        [JsonProperty("amount")]
        public FundraisingApiFundraiserAssignmentReadAmountType Amount { get; set; }

        [JsonProperty("campaign_id")]
        public string CampaignID { get; set; }

        [JsonProperty("fund_id")]
        public string FundID { get; set; }

        [JsonProperty("appeal_id")]
        public string AppealID { get; set; }
    }

    public class FundraisingApiFundraiserAssignmentReadAmountType
    {
        [JsonProperty("value")]
        public double Value { get; set; }
    }

    public class NXTDataIntegrationApiConstituentIdMap
    {
        [JsonProperty("system_record_id")]
        public int ID { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultCollection
    {
        [JsonProperty("results")]
        public NXTDataIntegrationApiConstituentSearchResult[] Results { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResult
    {
        [JsonProperty("record_id")]
        public int ID { get; set; }

        [JsonProperty("constituent_id")]
        public string LookupID { get; set; }

        [JsonProperty("key_indicator")]
        public string KeyIndicator { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("middle_name")]
        public string MiddleName { get; set; }

        [JsonProperty("preferred_name")]
        public string PreferredName { get; set; }

        [JsonProperty("maiden_name")]
        public string FormerName { get; set; }

        [JsonProperty("title1")]
        public string Title1 { get; set; }

        [JsonProperty("suffix1")]
        public string Suffix1 { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birth_date")]
        public NXTDataIntegrationApiConstituentSearchResultBirthdateType Birthdate { get; set; }

        [JsonProperty("spouse_first_name")]
        public string SpouseFirstName { get; set; }

        [JsonProperty("spouse_last_name")]
        public string SpouseLastName { get; set; }

        [JsonProperty("org_name")]
        public string OrganizationName { get; set; }

        [JsonProperty("address_block")]
        public string AddressBlock { get; set; }

        [JsonProperty("address_city_state")]
        public string CityAndState { get; set; }

        [JsonProperty("address_post_code")]
        public string PostalCode { get; set; }

        [JsonProperty("primary_email")]
        public string PrimaryEmailAddress { get; set; }

        [JsonProperty("primary_phone")]
        public string PrimaryPhoneNumber { get; set; }

        [JsonProperty("matched_alias")]
        public string MatchedAlias { get; set; }

        [JsonProperty("matched_email")]
        public string MatchedEmail { get; set; }

        [JsonProperty("matched_phone")]
        public string MatchedPhone { get; set; }

        [JsonProperty("is_constituent")]
        public bool IsAConstituent { get; set; }

        [JsonProperty("is_deceased")]
        public bool IsDeceased { get; set; }

        [JsonProperty("is_inactive")]
        public bool IsInactive { get; set; }
    }

    public class NXTDataIntegrationApiConstituentSearchResultBirthdateType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedConstituentTribute
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiTribute
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("constituent_record_id")]
        public int ConstituentID { get; set; }

        [JsonProperty("tribute_type_name")]
        public string TributeType { get; set; }

        [JsonProperty("tribute_type_id")]
        public int TributeTypeID { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_date")]
        public NXTDataIntegrationApiTributeStartType Start { get; set; }

        [JsonProperty("end_date")]
        public NXTDataIntegrationApiTributeEndType End { get; set; }

        [JsonProperty("default_fund_id")]
        public int DefaultFundID { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("is_active")]
        public bool Active { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }

        [JsonProperty("date_added")]
        public string DateAdded { get; set; }

        [JsonProperty("date_modified")]
        public string DateModified { get; set; }
    }

    public class NXTDataIntegrationApiTributeStartType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiTributeEndType
    {
        [JsonProperty("d")]
        public int Day { get; set; }

        [JsonProperty("m")]
        public int Month { get; set; }

        [JsonProperty("y")]
        public int Year { get; set; }
    }

    public class NXTDataIntegrationApiCreatedTributeAcknowledgee
    {
        [JsonProperty("id")]
        public string ID { get; set; }
    }

    public class NXTDataIntegrationApiTributeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTribute[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgeeCollection
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("value")]
        public NXTDataIntegrationApiTributeAcknowledgee[] Value { get; set; }
    }

    public class NXTDataIntegrationApiTributeAcknowledgee
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("tribute_id")]
        public int TributeID { get; set; }

        [JsonProperty("relationships_id")]
        public int RelationshipID { get; set; }

        [JsonProperty("letter")]
        public int LetterID { get; set; }

        [JsonProperty("sequence")]
        public int Sequence { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Blackbaudconstituent;

    public partial class WorkflowManagedActions
    {
        public BlackbaudconstituentActions Blackbaudconstituent(string connectionId) => new BlackbaudconstituentActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public BlackbaudconstituentTriggers Blackbaudconstituent(string connectionId) => new BlackbaudconstituentTriggers(connectionId);
    }
}