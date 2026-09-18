//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courierip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourieripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageSendPostResponse> MessageSend([WorkflowExpression] Func<string> idempotency, [WorkflowExpression] Func<string> bodymessagecontenttitle = null, [WorkflowExpression] Func<string> bodymessagecontentbody = null, [WorkflowExpression] Func<string> bodymessagetouserId = null, [WorkflowExpression] Func<string> bodymessagetolistId = null, [WorkflowExpression] Func<string> bodymessagetoaudienceId = null, [WorkflowExpression] Func<string> bodymessagetoemail = null, [WorkflowExpression] Func<string> bodymessagetophoneNumber = null, [WorkflowExpression] Func<string> bodymessagetolocale = null)
        {
            SourceExpression.Validate(idempotency, nameof(idempotency), required: true);
            SourceExpression.Validate(bodymessagecontenttitle, nameof(bodymessagecontenttitle), required: false);
            SourceExpression.Validate(bodymessagecontentbody, nameof(bodymessagecontentbody), required: false);
            SourceExpression.Validate(bodymessagetouserId, nameof(bodymessagetouserId), required: false);
            SourceExpression.Validate(bodymessagetolistId, nameof(bodymessagetolistId), required: false);
            SourceExpression.Validate(bodymessagetoaudienceId, nameof(bodymessagetoaudienceId), required: false);
            SourceExpression.Validate(bodymessagetoemail, nameof(bodymessagetoemail), required: false);
            SourceExpression.Validate(bodymessagetophoneNumber, nameof(bodymessagetophoneNumber), required: false);
            SourceExpression.Validate(bodymessagetolocale, nameof(bodymessagetolocale), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idempotency"] = SourceExpressionConverter.ConvertO(idempotency);
                var body = new JObject();
                var bodypropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodymessagecontenttitle != null)
                {
                    contentObject["title"] = SourceExpressionConverter.ConvertToken(bodymessagecontenttitle);
                    contentObjectpropCount++;
                }

                if (bodymessagecontentbody != null)
                {
                    contentObject["body"] = SourceExpressionConverter.ConvertToken(bodymessagecontentbody);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    messageObject["content"] = contentObject;
                    messageObjectpropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (bodymessagetouserId != null)
                {
                    toObject["user_id"] = SourceExpressionConverter.ConvertToken(bodymessagetouserId);
                    toObjectpropCount++;
                }

                if (bodymessagetolistId != null)
                {
                    toObject["list_id"] = SourceExpressionConverter.ConvertToken(bodymessagetolistId);
                    toObjectpropCount++;
                }

                if (bodymessagetoaudienceId != null)
                {
                    toObject["audience_id"] = SourceExpressionConverter.ConvertToken(bodymessagetoaudienceId);
                    toObjectpropCount++;
                }

                if (bodymessagetoemail != null)
                {
                    toObject["email"] = SourceExpressionConverter.ConvertToken(bodymessagetoemail);
                    toObjectpropCount++;
                }

                if (bodymessagetophoneNumber != null)
                {
                    toObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodymessagetophoneNumber);
                    toObjectpropCount++;
                }

                if (bodymessagetolocale != null)
                {
                    toObject["locale"] = SourceExpressionConverter.ConvertToken(bodymessagetolocale);
                    toObjectpropCount++;
                }

                var preferencesObject = new JObject();
                var preferencesObjectpropCount = 0;
                if (preferencesObjectpropCount > 0)
                {
                    toObject["preferences"] = preferencesObject;
                    toObjectpropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    toObject["data"] = dataObject;
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    messageObject["to"] = toObject;
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    body["message"] = messageObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MessageSendPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceGetResponse> AudienceGet([WorkflowExpression] Func<string> audienceId)
        {
            SourceExpression.Validate(audienceId, nameof(audienceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audiences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AudienceGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> AudienceDelete([WorkflowExpression] Func<string> audienceId)
        {
            SourceExpression.Validate(audienceId, nameof(audienceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audiences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencePutResponse> AudiencePut([WorkflowExpression] Func<string> audienceId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyfilterpath = null, [WorkflowExpression] Func<string> bodyfilterOperator = null, [WorkflowExpression] Func<string> bodyfiltervalue = null, [WorkflowExpression] Func<bodyfilterfiltersInputItem[]> bodyfilterfilters = null)
        {
            SourceExpression.Validate(audienceId, nameof(audienceId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodyfilterpath, nameof(bodyfilterpath), required: false);
            SourceExpression.Validate(bodyfilterOperator, nameof(bodyfilterOperator), required: false);
            SourceExpression.Validate(bodyfiltervalue, nameof(bodyfiltervalue), required: false);
            SourceExpression.Validate(bodyfilterfilters, nameof(bodyfilterfilters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audiences/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterpath != null)
                {
                    filterObject["path"] = SourceExpressionConverter.ConvertToken(bodyfilterpath);
                    filterObjectpropCount++;
                }

                if (bodyfilterOperator != null)
                {
                    filterObject["operator"] = SourceExpressionConverter.ConvertToken(bodyfilterOperator);
                    filterObjectpropCount++;
                }

                if (bodyfiltervalue != null)
                {
                    filterObject["value"] = SourceExpressionConverter.ConvertToken(bodyfiltervalue);
                    filterObjectpropCount++;
                }

                if (bodyfilterfilters != null)
                {
                    filterObject["filters"] = SourceExpressionConverter.ConvertToken(bodyfilterfilters);
                    filterObjectpropCount++;
                }

                if (filterObjectpropCount > 0)
                {
                    body["filter"] = filterObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AudiencePutResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceMembersGetResponse> AudienceMembersGet([WorkflowExpression] Func<string> audienceId, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(audienceId, nameof(audienceId), required: true);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audiences/{0}/members", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<AudienceMembersGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencesGetResponse> AudiencesGet([WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<AudiencesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventsGetResponse> AuditEventsGet([WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/audit-events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<AuditEventsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventGetResponse> AuditEventGet([WorkflowExpression] Func<string> auditEventId)
        {
            SourceExpression.Validate(auditEventId, nameof(auditEventId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/audit-events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AuditEventGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse> AutomationTemplated([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodybrand = null, [WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyrecipient = null)
        {
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(bodybrand, nameof(bodybrand), required: false);
            SourceExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            SourceExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/automations/{0}/invoke", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybrand != null)
                {
                    body["brand"] = SourceExpressionConverter.ConvertToken(bodybrand);
                    bodypropCount++;
                }

                if (bodytemplate != null)
                {
                    body["template"] = SourceExpressionConverter.ConvertToken(bodytemplate);
                    bodypropCount++;
                }

                if (bodyrecipient != null)
                {
                    body["recipient"] = SourceExpressionConverter.ConvertToken(bodyrecipient);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (profileObjectpropCount > 0)
                {
                    body["profile"] = profileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AutomationTemplatedPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationAdHocPostResponse> AutomationAdHoc([WorkflowExpression] Func<JToken[]> bodyautomationsteps = null, [WorkflowExpression] Func<string> bodyautomationcancelationToken = null, [WorkflowExpression] Func<string> bodybrand = null, [WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyrecipient = null)
        {
            SourceExpression.Validate(bodyautomationsteps, nameof(bodyautomationsteps), required: false);
            SourceExpression.Validate(bodyautomationcancelationToken, nameof(bodyautomationcancelationToken), required: false);
            SourceExpression.Validate(bodybrand, nameof(bodybrand), required: false);
            SourceExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            SourceExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/automations/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var automationObject = new JObject();
                var automationObjectpropCount = 0;
                if (bodyautomationsteps != null)
                {
                    automationObject["steps"] = SourceExpressionConverter.ConvertToken(bodyautomationsteps);
                    automationObjectpropCount++;
                }

                if (bodyautomationcancelationToken != null)
                {
                    automationObject["cancelation_token"] = SourceExpressionConverter.ConvertToken(bodyautomationcancelationToken);
                    automationObjectpropCount++;
                }

                if (automationObjectpropCount > 0)
                {
                    body["automation"] = automationObject;
                    bodypropCount++;
                }

                if (bodybrand != null)
                {
                    body["brand"] = SourceExpressionConverter.ConvertToken(bodybrand);
                    bodypropCount++;
                }

                if (bodytemplate != null)
                {
                    body["template"] = SourceExpressionConverter.ConvertToken(bodytemplate);
                    bodypropCount++;
                }

                if (bodyrecipient != null)
                {
                    body["recipient"] = SourceExpressionConverter.ConvertToken(bodyrecipient);
                    bodypropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    body["data"] = dataObject;
                    bodypropCount++;
                }

                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (profileObjectpropCount > 0)
                {
                    body["profile"] = profileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AutomationAdHocPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandsGetResponse> BrandsGet([WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<BrandsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> Brand([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodysettingscolorsprimary = null, [WorkflowExpression] Func<string> bodysettingscolorssecondary = null, [WorkflowExpression] Func<string> bodysettingscolorstertiary = null, [WorkflowExpression] Func<string> bodysettingsemailheaderbarColor = null, [WorkflowExpression] Func<string> bodysettingsemailheaderlogohref = null, [WorkflowExpression] Func<string> bodysettingsemailheaderlogoimage = null, [WorkflowExpression] Func<string> bodysettingsemailfootermarkdown = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialfacebookurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialinstagramurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersociallinkedinurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialmediumurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialtwitterurl = null, [WorkflowExpression] Func<bool> bodysettingsinappdisableMessageIcon = null, [WorkflowExpression] Func<string> bodysettingsinappplacement = null, [WorkflowExpression] Func<string[]> bodysnippetsitems = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodysettingscolorsprimary, nameof(bodysettingscolorsprimary), required: false);
            SourceExpression.Validate(bodysettingscolorssecondary, nameof(bodysettingscolorssecondary), required: false);
            SourceExpression.Validate(bodysettingscolorstertiary, nameof(bodysettingscolorstertiary), required: false);
            SourceExpression.Validate(bodysettingsemailheaderbarColor, nameof(bodysettingsemailheaderbarColor), required: false);
            SourceExpression.Validate(bodysettingsemailheaderlogohref, nameof(bodysettingsemailheaderlogohref), required: false);
            SourceExpression.Validate(bodysettingsemailheaderlogoimage, nameof(bodysettingsemailheaderlogoimage), required: false);
            SourceExpression.Validate(bodysettingsemailfootermarkdown, nameof(bodysettingsemailfootermarkdown), required: false);
            SourceExpression.Validate(bodysettingsemailfootersocialfacebookurl, nameof(bodysettingsemailfootersocialfacebookurl), required: false);
            SourceExpression.Validate(bodysettingsemailfootersocialinstagramurl, nameof(bodysettingsemailfootersocialinstagramurl), required: false);
            SourceExpression.Validate(bodysettingsemailfootersociallinkedinurl, nameof(bodysettingsemailfootersociallinkedinurl), required: false);
            SourceExpression.Validate(bodysettingsemailfootersocialmediumurl, nameof(bodysettingsemailfootersocialmediumurl), required: false);
            SourceExpression.Validate(bodysettingsemailfootersocialtwitterurl, nameof(bodysettingsemailfootersocialtwitterurl), required: false);
            SourceExpression.Validate(bodysettingsinappdisableMessageIcon, nameof(bodysettingsinappdisableMessageIcon), required: false);
            SourceExpression.Validate(bodysettingsinappplacement, nameof(bodysettingsinappplacement), required: false);
            SourceExpression.Validate(bodysnippetsitems, nameof(bodysnippetsitems), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                var colorsObject = new JObject();
                var colorsObjectpropCount = 0;
                if (bodysettingscolorsprimary != null)
                {
                    colorsObject["primary"] = SourceExpressionConverter.ConvertToken(bodysettingscolorsprimary);
                    colorsObjectpropCount++;
                }

                if (bodysettingscolorssecondary != null)
                {
                    colorsObject["secondary"] = SourceExpressionConverter.ConvertToken(bodysettingscolorssecondary);
                    colorsObjectpropCount++;
                }

                if (bodysettingscolorstertiary != null)
                {
                    colorsObject["tertiary"] = SourceExpressionConverter.ConvertToken(bodysettingscolorstertiary);
                    colorsObjectpropCount++;
                }

                if (colorsObjectpropCount > 0)
                {
                    settingsObject["colors"] = colorsObject;
                    settingsObjectpropCount++;
                }

                var emailObject = new JObject();
                var emailObjectpropCount = 0;
                var headerObject = new JObject();
                var headerObjectpropCount = 0;
                if (bodysettingsemailheaderbarColor != null)
                {
                    headerObject["barColor"] = SourceExpressionConverter.ConvertToken(bodysettingsemailheaderbarColor);
                    headerObjectpropCount++;
                }

                var logoObject = new JObject();
                var logoObjectpropCount = 0;
                if (bodysettingsemailheaderlogohref != null)
                {
                    logoObject["href"] = SourceExpressionConverter.ConvertToken(bodysettingsemailheaderlogohref);
                    logoObjectpropCount++;
                }

                if (bodysettingsemailheaderlogoimage != null)
                {
                    logoObject["image"] = SourceExpressionConverter.ConvertToken(bodysettingsemailheaderlogoimage);
                    logoObjectpropCount++;
                }

                if (logoObjectpropCount > 0)
                {
                    headerObject["logo"] = logoObject;
                    headerObjectpropCount++;
                }

                if (headerObjectpropCount > 0)
                {
                    emailObject["header"] = headerObject;
                    emailObjectpropCount++;
                }

                var footerObject = new JObject();
                var footerObjectpropCount = 0;
                if (bodysettingsemailfootermarkdown != null)
                {
                    footerObject["markdown"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootermarkdown);
                    footerObjectpropCount++;
                }

                var socialObject = new JObject();
                var socialObjectpropCount = 0;
                var facebookObject = new JObject();
                var facebookObjectpropCount = 0;
                if (bodysettingsemailfootersocialfacebookurl != null)
                {
                    facebookObject["url"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootersocialfacebookurl);
                    facebookObjectpropCount++;
                }

                if (facebookObjectpropCount > 0)
                {
                    socialObject["facebook"] = facebookObject;
                    socialObjectpropCount++;
                }

                var instagramObject = new JObject();
                var instagramObjectpropCount = 0;
                if (bodysettingsemailfootersocialinstagramurl != null)
                {
                    instagramObject["url"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootersocialinstagramurl);
                    instagramObjectpropCount++;
                }

                if (instagramObjectpropCount > 0)
                {
                    socialObject["instagram"] = instagramObject;
                    socialObjectpropCount++;
                }

                var linkedinObject = new JObject();
                var linkedinObjectpropCount = 0;
                if (bodysettingsemailfootersociallinkedinurl != null)
                {
                    linkedinObject["url"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootersociallinkedinurl);
                    linkedinObjectpropCount++;
                }

                if (linkedinObjectpropCount > 0)
                {
                    socialObject["linkedin"] = linkedinObject;
                    socialObjectpropCount++;
                }

                var mediumObject = new JObject();
                var mediumObjectpropCount = 0;
                if (bodysettingsemailfootersocialmediumurl != null)
                {
                    mediumObject["url"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootersocialmediumurl);
                    mediumObjectpropCount++;
                }

                if (mediumObjectpropCount > 0)
                {
                    socialObject["medium"] = mediumObject;
                    socialObjectpropCount++;
                }

                var twitterObject = new JObject();
                var twitterObjectpropCount = 0;
                if (bodysettingsemailfootersocialtwitterurl != null)
                {
                    twitterObject["url"] = SourceExpressionConverter.ConvertToken(bodysettingsemailfootersocialtwitterurl);
                    twitterObjectpropCount++;
                }

                if (twitterObjectpropCount > 0)
                {
                    socialObject["twitter"] = twitterObject;
                    socialObjectpropCount++;
                }

                if (socialObjectpropCount > 0)
                {
                    footerObject["social"] = socialObject;
                    footerObjectpropCount++;
                }

                if (footerObjectpropCount > 0)
                {
                    emailObject["footer"] = footerObject;
                    emailObjectpropCount++;
                }

                if (emailObjectpropCount > 0)
                {
                    settingsObject["email"] = emailObject;
                    settingsObjectpropCount++;
                }

                var inappObject = new JObject();
                var inappObjectpropCount = 0;
                if (bodysettingsinappdisableMessageIcon != null)
                {
                    inappObject["disableMessageIcon"] = SourceExpressionConverter.ConvertToken(bodysettingsinappdisableMessageIcon);
                    inappObjectpropCount++;
                }

                if (bodysettingsinappplacement != null)
                {
                    inappObject["placement"] = SourceExpressionConverter.ConvertToken(bodysettingsinappplacement);
                    inappObjectpropCount++;
                }

                var preferencesObject = new JObject();
                var preferencesObjectpropCount = 0;
                if (preferencesObjectpropCount > 0)
                {
                    inappObject["preferences"] = preferencesObject;
                    inappObjectpropCount++;
                }

                if (inappObjectpropCount > 0)
                {
                    settingsObject["inapp"] = inappObject;
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                var snippetsObject = new JObject();
                var snippetsObjectpropCount = 0;
                if (bodysnippetsitems != null)
                {
                    snippetsObject["items"] = SourceExpressionConverter.ConvertToken(bodysnippetsitems);
                    snippetsObjectpropCount++;
                }

                if (snippetsObjectpropCount > 0)
                {
                    body["snippets"] = snippetsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandGetResponse> BrandGet([WorkflowExpression] Func<string> brandId)
        {
            SourceExpression.Validate(brandId, nameof(brandId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/brands/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(brandId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BrandGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobPostResponse> BulkJob([WorkflowExpression] Func<string> bodymessageEvent = null, [WorkflowExpression] Func<string> bodymessagebrand = null, [WorkflowExpression] Func<string> bodymessagetemplate = null, [WorkflowExpression] Func<string> bodymessagebrandId = null, [WorkflowExpression] Func<string> bodymessageroutingmethod = null, [WorkflowExpression] Func<string[]> bodymessageroutingchannels = null, [WorkflowExpression] Func<string> bodymessagemetadataEvent = null, [WorkflowExpression] Func<string[]> bodymessagemetadatatags = null, [WorkflowExpression] Func<string> bodymessagemetadatatraceId = null, [WorkflowExpression] Func<string> bodymessagemetadatautmcampaign = null, [WorkflowExpression] Func<string> bodymessagemetadatautmcontent = null, [WorkflowExpression] Func<string> bodymessagemetadatautmmedium = null, [WorkflowExpression] Func<string> bodymessagemetadatautmsource = null, [WorkflowExpression] Func<string> bodymessagemetadatautmterm = null)
        {
            SourceExpression.Validate(bodymessageEvent, nameof(bodymessageEvent), required: false);
            SourceExpression.Validate(bodymessagebrand, nameof(bodymessagebrand), required: false);
            SourceExpression.Validate(bodymessagetemplate, nameof(bodymessagetemplate), required: false);
            SourceExpression.Validate(bodymessagebrandId, nameof(bodymessagebrandId), required: false);
            SourceExpression.Validate(bodymessageroutingmethod, nameof(bodymessageroutingmethod), required: false);
            SourceExpression.Validate(bodymessageroutingchannels, nameof(bodymessageroutingchannels), required: false);
            SourceExpression.Validate(bodymessagemetadataEvent, nameof(bodymessagemetadataEvent), required: false);
            SourceExpression.Validate(bodymessagemetadatatags, nameof(bodymessagemetadatatags), required: false);
            SourceExpression.Validate(bodymessagemetadatatraceId, nameof(bodymessagemetadatatraceId), required: false);
            SourceExpression.Validate(bodymessagemetadatautmcampaign, nameof(bodymessagemetadatautmcampaign), required: false);
            SourceExpression.Validate(bodymessagemetadatautmcontent, nameof(bodymessagemetadatautmcontent), required: false);
            SourceExpression.Validate(bodymessagemetadatautmmedium, nameof(bodymessagemetadatautmmedium), required: false);
            SourceExpression.Validate(bodymessagemetadatautmsource, nameof(bodymessagemetadatautmsource), required: false);
            SourceExpression.Validate(bodymessagemetadatautmterm, nameof(bodymessagemetadatautmterm), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                if (bodymessageEvent != null)
                {
                    messageObject["event"] = SourceExpressionConverter.ConvertToken(bodymessageEvent);
                    messageObjectpropCount++;
                }

                if (bodymessagebrand != null)
                {
                    messageObject["brand"] = SourceExpressionConverter.ConvertToken(bodymessagebrand);
                    messageObjectpropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    messageObject["data"] = dataObject;
                    messageObjectpropCount++;
                }

                var overrideObject = new JObject();
                var overrideObjectpropCount = 0;
                if (overrideObjectpropCount > 0)
                {
                    messageObject["override"] = overrideObject;
                    messageObjectpropCount++;
                }

                if (bodymessagetemplate != null)
                {
                    messageObject["template"] = SourceExpressionConverter.ConvertToken(bodymessagetemplate);
                    messageObjectpropCount++;
                }

                if (bodymessagebrandId != null)
                {
                    messageObject["brand_id"] = SourceExpressionConverter.ConvertToken(bodymessagebrandId);
                    messageObjectpropCount++;
                }

                var routingObject = new JObject();
                var routingObjectpropCount = 0;
                if (bodymessageroutingmethod != null)
                {
                    routingObject["method"] = SourceExpressionConverter.ConvertToken(bodymessageroutingmethod);
                    routingObjectpropCount++;
                }

                if (bodymessageroutingchannels != null)
                {
                    routingObject["channels"] = SourceExpressionConverter.ConvertToken(bodymessageroutingchannels);
                    routingObjectpropCount++;
                }

                if (routingObjectpropCount > 0)
                {
                    messageObject["routing"] = routingObject;
                    messageObjectpropCount++;
                }

                var channelsObject = new JObject();
                var channelsObjectpropCount = 0;
                if (channelsObjectpropCount > 0)
                {
                    messageObject["channels"] = channelsObject;
                    messageObjectpropCount++;
                }

                var providersObject = new JObject();
                var providersObjectpropCount = 0;
                if (providersObjectpropCount > 0)
                {
                    messageObject["providers"] = providersObject;
                    messageObjectpropCount++;
                }

                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (bodymessagemetadataEvent != null)
                {
                    metadataObject["event"] = SourceExpressionConverter.ConvertToken(bodymessagemetadataEvent);
                    metadataObjectpropCount++;
                }

                if (bodymessagemetadatatags != null)
                {
                    metadataObject["tags"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatatags);
                    metadataObjectpropCount++;
                }

                if (bodymessagemetadatatraceId != null)
                {
                    metadataObject["trace_id"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatatraceId);
                    metadataObjectpropCount++;
                }

                var utmObject = new JObject();
                var utmObjectpropCount = 0;
                if (bodymessagemetadatautmcampaign != null)
                {
                    utmObject["campaign"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatautmcampaign);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmcontent != null)
                {
                    utmObject["content"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatautmcontent);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmmedium != null)
                {
                    utmObject["medium"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatautmmedium);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmsource != null)
                {
                    utmObject["source"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatautmsource);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmterm != null)
                {
                    utmObject["term"] = SourceExpressionConverter.ConvertToken(bodymessagemetadatautmterm);
                    utmObjectpropCount++;
                }

                if (utmObjectpropCount > 0)
                {
                    metadataObject["utm"] = utmObject;
                    metadataObjectpropCount++;
                }

                if (metadataObjectpropCount > 0)
                {
                    messageObject["metadata"] = metadataObject;
                    messageObjectpropCount++;
                }

                if (messageObjectpropCount > 0)
                {
                    body["message"] = messageObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<BulkJobPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobGetResponse> BulkJobGet([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bulk/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BulkJobGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> BulkJobUsers([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<bodyusersInputItem[]> bodyusers = null)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            SourceExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bulk/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyusers != null)
                {
                    body["users"] = SourceExpressionConverter.ConvertToken(bodyusers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<JToken> BulkJobRun([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bulk/{0}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobUsersGetResponse> BulkJobUsersGet([WorkflowExpression] Func<string> jobId)
        {
            SourceExpression.Validate(jobId, nameof(jobId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/bulk/{0}/users", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<BulkJobUsersGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListsGetResponse> ListsGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListGetResponse> ListGet([WorkflowExpression] Func<string> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListDelete([WorkflowExpression] Func<string> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListPut([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                var preferencesObject = new JObject();
                var preferencesObjectpropCount = 0;
                var notificationsObject = new JObject();
                var notificationsObjectpropCount = 0;
                if (notificationsObjectpropCount > 0)
                {
                    preferencesObject["notifications"] = notificationsObject;
                    preferencesObjectpropCount++;
                }

                var categoriesObject = new JObject();
                var categoriesObjectpropCount = 0;
                if (categoriesObjectpropCount > 0)
                {
                    preferencesObject["categories"] = categoriesObject;
                    preferencesObjectpropCount++;
                }

                if (preferencesObjectpropCount > 0)
                {
                    body["preferences"] = preferencesObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListRestorePut([WorkflowExpression] Func<string> listId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/restore", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse> ListSubscriptionsGet([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<ListSubscriptionsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListSubscribers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrecipients != null)
                {
                    body["recipients"] = SourceExpressionConverter.ConvertToken(bodyrecipients);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListSubscribeDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(listId, nameof(listId), required: true);
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet([WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> @event = null, [WorkflowExpression] Func<string> list = null, [WorkflowExpression] Func<string> messageId = null, [WorkflowExpression] Func<string> notification = null, [WorkflowExpression] Func<string> recipient = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> tags = null)
        {
            SourceExpression.Validate(archived, nameof(archived), required: false);
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            SourceExpression.Validate(@event, nameof(@event), required: false);
            SourceExpression.Validate(list, nameof(list), required: false);
            SourceExpression.Validate(messageId, nameof(messageId), required: false);
            SourceExpression.Validate(notification, nameof(notification), required: false);
            SourceExpression.Validate(recipient, nameof(recipient), required: false);
            SourceExpression.Validate(status, nameof(status), required: false);
            SourceExpression.Validate(tags, nameof(tags), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                if (@event != null)
                    callPayload.Queries["event"] = SourceExpressionConverter.ConvertO(@event);
                if (list != null)
                    callPayload.Queries["list"] = SourceExpressionConverter.ConvertO(list);
                if (messageId != null)
                    callPayload.Queries["messageId"] = SourceExpressionConverter.ConvertO(messageId);
                if (notification != null)
                    callPayload.Queries["notification"] = SourceExpressionConverter.ConvertO(notification);
                if (recipient != null)
                    callPayload.Queries["recipient"] = SourceExpressionConverter.ConvertO(recipient);
                if (status != null)
                    callPayload.Queries["status"] = SourceExpressionConverter.ConvertO(status);
                if (tags != null)
                    callPayload.Queries["tags"] = SourceExpressionConverter.ConvertO(tags);
                return callPayload;
            }

            return new ApiConnectionAction<MessagesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageGetResponse> MessageGet([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/messages/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageHistoryGetResponse> MessageHistoryGet([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> type = null)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            SourceExpression.Validate(type, nameof(type), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/messages/{0}/history", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = SourceExpressionConverter.ConvertO(type);
                return callPayload;
            }

            return new ApiConnectionAction<MessageHistoryGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageContentGetResponse> MessageContentGet([WorkflowExpression] Func<string> messageId)
        {
            SourceExpression.Validate(messageId, nameof(messageId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/messages/{0}/output", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<MessageContentGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> MessagePut([WorkflowExpression] Func<string> requestId)
        {
            SourceExpression.Validate(requestId, nameof(requestId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/requests/{0}/archive", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<NotificationsGetResponse> NotificationsGet([WorkflowExpression] Func<string> cursor = null)
        {
            SourceExpression.Validate(cursor, nameof(cursor), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = SourceExpressionConverter.ConvertO(cursor);
                return callPayload;
            }

            return new ApiConnectionAction<NotificationsGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileGetResponse> ProfileGet([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProfileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileDeleteResponse> ProfileDelete([WorkflowExpression] Func<string> recipientId)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ProfileDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> Profile([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyprofileemail = null, [WorkflowExpression] Func<string> bodyprofilephoneNumber = null, [WorkflowExpression] Func<string> bodyprofileaddressformatted = null, [WorkflowExpression] Func<string> bodyprofileaddressstreetAddress = null, [WorkflowExpression] Func<string> bodyprofileaddresslocality = null, [WorkflowExpression] Func<string> bodyprofileaddressregion = null, [WorkflowExpression] Func<string> bodyprofileaddresspostalCode = null, [WorkflowExpression] Func<string> bodyprofileaddresscountry = null, [WorkflowExpression] Func<string> bodyprofilebirthdate = null, [WorkflowExpression] Func<bool> bodyprofileemailVerified = null, [WorkflowExpression] Func<bool> bodyprofilephoneNumberVerified = null, [WorkflowExpression] Func<string> bodyprofilegivenName = null, [WorkflowExpression] Func<string> bodyprofilemiddleName = null, [WorkflowExpression] Func<string> bodyprofilefamilyName = null, [WorkflowExpression] Func<string> bodyprofilepreferredName = null, [WorkflowExpression] Func<string> bodyprofilegender = null, [WorkflowExpression] Func<string> bodyprofilelocale = null, [WorkflowExpression] Func<string> bodyprofilepicture = null, [WorkflowExpression] Func<string> bodyprofileprofile = null, [WorkflowExpression] Func<string> bodyprofilesub = null, [WorkflowExpression] Func<string> bodyprofileupdatedAt = null, [WorkflowExpression] Func<string> bodyprofilewebsite = null, [WorkflowExpression] Func<string> bodyprofilezoneinfo = null, [WorkflowExpression] Func<string> bodyprofileairshipaudiencenamedUser = null, [WorkflowExpression] Func<string[]> bodyprofileairshipdeviceTypes = null, [WorkflowExpression] Func<string> bodyprofileairshipapn = null, [WorkflowExpression] Func<string> bodyprofileairshiptargetArn = null, [WorkflowExpression] Func<string> bodyprofileairshipdiscordchannelId = null, [WorkflowExpression] Func<string> bodyprofileairshipdiscorduserId = null, [WorkflowExpression] Func<string> bodyprofileairshipexpotoken = null, [WorkflowExpression] Func<string[]> bodyprofileairshipexpotokens = null, [WorkflowExpression] Func<string> bodyprofileairshipfacebookPSID = null, [WorkflowExpression] Func<string> bodyprofileairshipfirebaseToken = null, [WorkflowExpression] Func<string> bodyprofileairshipintercomfrom = null, [WorkflowExpression] Func<string> bodyprofileairshipintercomtoid = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsuserId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsconversationId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamstenantId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsserviceUrl = null, [WorkflowExpression] Func<string> bodyprofileairshiponeSignalPlayerID = null, [WorkflowExpression] Func<string> bodyprofileairshipslackaccessToken = null, [WorkflowExpression] Func<string> bodyprofileairshipslackchannel = null, [WorkflowExpression] Func<string> bodyprofileairshipslackemail = null, [WorkflowExpression] Func<string> bodyprofileairshipslackuserId = null, [WorkflowExpression] Func<string> bodyprofileairshipslackincomingWebhookurl = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookurl = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookmethod = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationmode = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationusername = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationpassword = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationtoken = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookprofile = null)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(bodyprofileemail, nameof(bodyprofileemail), required: false);
            SourceExpression.Validate(bodyprofilephoneNumber, nameof(bodyprofilephoneNumber), required: false);
            SourceExpression.Validate(bodyprofileaddressformatted, nameof(bodyprofileaddressformatted), required: false);
            SourceExpression.Validate(bodyprofileaddressstreetAddress, nameof(bodyprofileaddressstreetAddress), required: false);
            SourceExpression.Validate(bodyprofileaddresslocality, nameof(bodyprofileaddresslocality), required: false);
            SourceExpression.Validate(bodyprofileaddressregion, nameof(bodyprofileaddressregion), required: false);
            SourceExpression.Validate(bodyprofileaddresspostalCode, nameof(bodyprofileaddresspostalCode), required: false);
            SourceExpression.Validate(bodyprofileaddresscountry, nameof(bodyprofileaddresscountry), required: false);
            SourceExpression.Validate(bodyprofilebirthdate, nameof(bodyprofilebirthdate), required: false);
            SourceExpression.Validate(bodyprofileemailVerified, nameof(bodyprofileemailVerified), required: false);
            SourceExpression.Validate(bodyprofilephoneNumberVerified, nameof(bodyprofilephoneNumberVerified), required: false);
            SourceExpression.Validate(bodyprofilegivenName, nameof(bodyprofilegivenName), required: false);
            SourceExpression.Validate(bodyprofilemiddleName, nameof(bodyprofilemiddleName), required: false);
            SourceExpression.Validate(bodyprofilefamilyName, nameof(bodyprofilefamilyName), required: false);
            SourceExpression.Validate(bodyprofilepreferredName, nameof(bodyprofilepreferredName), required: false);
            SourceExpression.Validate(bodyprofilegender, nameof(bodyprofilegender), required: false);
            SourceExpression.Validate(bodyprofilelocale, nameof(bodyprofilelocale), required: false);
            SourceExpression.Validate(bodyprofilepicture, nameof(bodyprofilepicture), required: false);
            SourceExpression.Validate(bodyprofileprofile, nameof(bodyprofileprofile), required: false);
            SourceExpression.Validate(bodyprofilesub, nameof(bodyprofilesub), required: false);
            SourceExpression.Validate(bodyprofileupdatedAt, nameof(bodyprofileupdatedAt), required: false);
            SourceExpression.Validate(bodyprofilewebsite, nameof(bodyprofilewebsite), required: false);
            SourceExpression.Validate(bodyprofilezoneinfo, nameof(bodyprofilezoneinfo), required: false);
            SourceExpression.Validate(bodyprofileairshipaudiencenamedUser, nameof(bodyprofileairshipaudiencenamedUser), required: false);
            SourceExpression.Validate(bodyprofileairshipdeviceTypes, nameof(bodyprofileairshipdeviceTypes), required: false);
            SourceExpression.Validate(bodyprofileairshipapn, nameof(bodyprofileairshipapn), required: false);
            SourceExpression.Validate(bodyprofileairshiptargetArn, nameof(bodyprofileairshiptargetArn), required: false);
            SourceExpression.Validate(bodyprofileairshipdiscordchannelId, nameof(bodyprofileairshipdiscordchannelId), required: false);
            SourceExpression.Validate(bodyprofileairshipdiscorduserId, nameof(bodyprofileairshipdiscorduserId), required: false);
            SourceExpression.Validate(bodyprofileairshipexpotoken, nameof(bodyprofileairshipexpotoken), required: false);
            SourceExpression.Validate(bodyprofileairshipexpotokens, nameof(bodyprofileairshipexpotokens), required: false);
            SourceExpression.Validate(bodyprofileairshipfacebookPSID, nameof(bodyprofileairshipfacebookPSID), required: false);
            SourceExpression.Validate(bodyprofileairshipfirebaseToken, nameof(bodyprofileairshipfirebaseToken), required: false);
            SourceExpression.Validate(bodyprofileairshipintercomfrom, nameof(bodyprofileairshipintercomfrom), required: false);
            SourceExpression.Validate(bodyprofileairshipintercomtoid, nameof(bodyprofileairshipintercomtoid), required: false);
            SourceExpression.Validate(bodyprofileairshipmsTeamsuserId, nameof(bodyprofileairshipmsTeamsuserId), required: false);
            SourceExpression.Validate(bodyprofileairshipmsTeamsconversationId, nameof(bodyprofileairshipmsTeamsconversationId), required: false);
            SourceExpression.Validate(bodyprofileairshipmsTeamstenantId, nameof(bodyprofileairshipmsTeamstenantId), required: false);
            SourceExpression.Validate(bodyprofileairshipmsTeamsserviceUrl, nameof(bodyprofileairshipmsTeamsserviceUrl), required: false);
            SourceExpression.Validate(bodyprofileairshiponeSignalPlayerID, nameof(bodyprofileairshiponeSignalPlayerID), required: false);
            SourceExpression.Validate(bodyprofileairshipslackaccessToken, nameof(bodyprofileairshipslackaccessToken), required: false);
            SourceExpression.Validate(bodyprofileairshipslackchannel, nameof(bodyprofileairshipslackchannel), required: false);
            SourceExpression.Validate(bodyprofileairshipslackemail, nameof(bodyprofileairshipslackemail), required: false);
            SourceExpression.Validate(bodyprofileairshipslackuserId, nameof(bodyprofileairshipslackuserId), required: false);
            SourceExpression.Validate(bodyprofileairshipslackincomingWebhookurl, nameof(bodyprofileairshipslackincomingWebhookurl), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookurl, nameof(bodyprofileairshipwebhookurl), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookmethod, nameof(bodyprofileairshipwebhookmethod), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookauthenticationmode, nameof(bodyprofileairshipwebhookauthenticationmode), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookauthenticationusername, nameof(bodyprofileairshipwebhookauthenticationusername), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookauthenticationpassword, nameof(bodyprofileairshipwebhookauthenticationpassword), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookauthenticationtoken, nameof(bodyprofileairshipwebhookauthenticationtoken), required: false);
            SourceExpression.Validate(bodyprofileairshipwebhookprofile, nameof(bodyprofileairshipwebhookprofile), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (bodyprofileemail != null)
                {
                    profileObject["email"] = SourceExpressionConverter.ConvertToken(bodyprofileemail);
                    profileObjectpropCount++;
                }

                if (bodyprofilephoneNumber != null)
                {
                    profileObject["phone_number"] = SourceExpressionConverter.ConvertToken(bodyprofilephoneNumber);
                    profileObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyprofileaddressformatted != null)
                {
                    addressObject["formatted"] = SourceExpressionConverter.ConvertToken(bodyprofileaddressformatted);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddressstreetAddress != null)
                {
                    addressObject["street_address"] = SourceExpressionConverter.ConvertToken(bodyprofileaddressstreetAddress);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresslocality != null)
                {
                    addressObject["locality"] = SourceExpressionConverter.ConvertToken(bodyprofileaddresslocality);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddressregion != null)
                {
                    addressObject["region"] = SourceExpressionConverter.ConvertToken(bodyprofileaddressregion);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresspostalCode != null)
                {
                    addressObject["postal_code"] = SourceExpressionConverter.ConvertToken(bodyprofileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresscountry != null)
                {
                    addressObject["country"] = SourceExpressionConverter.ConvertToken(bodyprofileaddresscountry);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    profileObject["address"] = addressObject;
                    profileObjectpropCount++;
                }

                if (bodyprofilebirthdate != null)
                {
                    profileObject["birthdate"] = SourceExpressionConverter.ConvertToken(bodyprofilebirthdate);
                    profileObjectpropCount++;
                }

                if (bodyprofileemailVerified != null)
                {
                    profileObject["email_verified"] = SourceExpressionConverter.ConvertToken(bodyprofileemailVerified);
                    profileObjectpropCount++;
                }

                if (bodyprofilephoneNumberVerified != null)
                {
                    profileObject["phone_number_verified"] = SourceExpressionConverter.ConvertToken(bodyprofilephoneNumberVerified);
                    profileObjectpropCount++;
                }

                if (bodyprofilegivenName != null)
                {
                    profileObject["given_name"] = SourceExpressionConverter.ConvertToken(bodyprofilegivenName);
                    profileObjectpropCount++;
                }

                if (bodyprofilemiddleName != null)
                {
                    profileObject["middle_name"] = SourceExpressionConverter.ConvertToken(bodyprofilemiddleName);
                    profileObjectpropCount++;
                }

                if (bodyprofilefamilyName != null)
                {
                    profileObject["family_name"] = SourceExpressionConverter.ConvertToken(bodyprofilefamilyName);
                    profileObjectpropCount++;
                }

                if (bodyprofilepreferredName != null)
                {
                    profileObject["preferred_name"] = SourceExpressionConverter.ConvertToken(bodyprofilepreferredName);
                    profileObjectpropCount++;
                }

                if (bodyprofilegender != null)
                {
                    profileObject["gender"] = SourceExpressionConverter.ConvertToken(bodyprofilegender);
                    profileObjectpropCount++;
                }

                if (bodyprofilelocale != null)
                {
                    profileObject["locale"] = SourceExpressionConverter.ConvertToken(bodyprofilelocale);
                    profileObjectpropCount++;
                }

                if (bodyprofilepicture != null)
                {
                    profileObject["picture"] = SourceExpressionConverter.ConvertToken(bodyprofilepicture);
                    profileObjectpropCount++;
                }

                if (bodyprofileprofile != null)
                {
                    profileObject["profile"] = SourceExpressionConverter.ConvertToken(bodyprofileprofile);
                    profileObjectpropCount++;
                }

                if (bodyprofilesub != null)
                {
                    profileObject["sub"] = SourceExpressionConverter.ConvertToken(bodyprofilesub);
                    profileObjectpropCount++;
                }

                if (bodyprofileupdatedAt != null)
                {
                    profileObject["updated_at"] = SourceExpressionConverter.ConvertToken(bodyprofileupdatedAt);
                    profileObjectpropCount++;
                }

                if (bodyprofilewebsite != null)
                {
                    profileObject["website"] = SourceExpressionConverter.ConvertToken(bodyprofilewebsite);
                    profileObjectpropCount++;
                }

                if (bodyprofilezoneinfo != null)
                {
                    profileObject["zoneinfo"] = SourceExpressionConverter.ConvertToken(bodyprofilezoneinfo);
                    profileObjectpropCount++;
                }

                var customObject = new JObject();
                var customObjectpropCount = 0;
                if (customObjectpropCount > 0)
                {
                    profileObject["custom"] = customObject;
                    profileObjectpropCount++;
                }

                var airshipObject = new JObject();
                var airshipObjectpropCount = 0;
                var audienceObject = new JObject();
                var audienceObjectpropCount = 0;
                if (bodyprofileairshipaudiencenamedUser != null)
                {
                    audienceObject["named_user"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipaudiencenamedUser);
                    audienceObjectpropCount++;
                }

                if (audienceObjectpropCount > 0)
                {
                    airshipObject["audience"] = audienceObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipdeviceTypes != null)
                {
                    airshipObject["device_types"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipdeviceTypes);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipapn != null)
                {
                    airshipObject["apn"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipapn);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshiptargetArn != null)
                {
                    airshipObject["target_arn"] = SourceExpressionConverter.ConvertToken(bodyprofileairshiptargetArn);
                    airshipObjectpropCount++;
                }

                var discordObject = new JObject();
                var discordObjectpropCount = 0;
                if (bodyprofileairshipdiscordchannelId != null)
                {
                    discordObject["channel_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipdiscordchannelId);
                    discordObjectpropCount++;
                }

                if (bodyprofileairshipdiscorduserId != null)
                {
                    discordObject["user_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipdiscorduserId);
                    discordObjectpropCount++;
                }

                if (discordObjectpropCount > 0)
                {
                    airshipObject["discord"] = discordObject;
                    airshipObjectpropCount++;
                }

                var expoObject = new JObject();
                var expoObjectpropCount = 0;
                if (bodyprofileairshipexpotoken != null)
                {
                    expoObject["token"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipexpotoken);
                    expoObjectpropCount++;
                }

                if (bodyprofileairshipexpotokens != null)
                {
                    expoObject["tokens"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipexpotokens);
                    expoObjectpropCount++;
                }

                if (expoObjectpropCount > 0)
                {
                    airshipObject["expo"] = expoObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipfacebookPSID != null)
                {
                    airshipObject["facebookPSID"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipfacebookPSID);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipfirebaseToken != null)
                {
                    airshipObject["firebaseToken"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipfirebaseToken);
                    airshipObjectpropCount++;
                }

                var intercomObject = new JObject();
                var intercomObjectpropCount = 0;
                if (bodyprofileairshipintercomfrom != null)
                {
                    intercomObject["from"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipintercomfrom);
                    intercomObjectpropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (bodyprofileairshipintercomtoid != null)
                {
                    toObject["id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipintercomtoid);
                    toObjectpropCount++;
                }

                if (toObjectpropCount > 0)
                {
                    intercomObject["to"] = toObject;
                    intercomObjectpropCount++;
                }

                if (intercomObjectpropCount > 0)
                {
                    airshipObject["intercom"] = intercomObject;
                    airshipObjectpropCount++;
                }

                var msTeamsObject = new JObject();
                var msTeamsObjectpropCount = 0;
                if (bodyprofileairshipmsTeamsuserId != null)
                {
                    msTeamsObject["user_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsuserId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamsconversationId != null)
                {
                    msTeamsObject["conversation_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsconversationId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamstenantId != null)
                {
                    msTeamsObject["tenant_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipmsTeamstenantId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamsserviceUrl != null)
                {
                    msTeamsObject["service_url"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsserviceUrl);
                    msTeamsObjectpropCount++;
                }

                if (msTeamsObjectpropCount > 0)
                {
                    airshipObject["ms_teams"] = msTeamsObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshiponeSignalPlayerID != null)
                {
                    airshipObject["oneSignalPlayerID"] = SourceExpressionConverter.ConvertToken(bodyprofileairshiponeSignalPlayerID);
                    airshipObjectpropCount++;
                }

                var slackObject = new JObject();
                var slackObjectpropCount = 0;
                if (bodyprofileairshipslackaccessToken != null)
                {
                    slackObject["access_token"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipslackaccessToken);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackchannel != null)
                {
                    slackObject["channel"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipslackchannel);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackemail != null)
                {
                    slackObject["email"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipslackemail);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackuserId != null)
                {
                    slackObject["user_id"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipslackuserId);
                    slackObjectpropCount++;
                }

                var incomingWebhookObject = new JObject();
                var incomingWebhookObjectpropCount = 0;
                if (bodyprofileairshipslackincomingWebhookurl != null)
                {
                    incomingWebhookObject["url"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipslackincomingWebhookurl);
                    incomingWebhookObjectpropCount++;
                }

                if (incomingWebhookObjectpropCount > 0)
                {
                    slackObject["incoming_webhook"] = incomingWebhookObject;
                    slackObjectpropCount++;
                }

                if (slackObjectpropCount > 0)
                {
                    airshipObject["slack"] = slackObject;
                    airshipObjectpropCount++;
                }

                var webhookObject = new JObject();
                var webhookObjectpropCount = 0;
                if (bodyprofileairshipwebhookurl != null)
                {
                    webhookObject["url"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookurl);
                    webhookObjectpropCount++;
                }

                if (bodyprofileairshipwebhookmethod != null)
                {
                    webhookObject["method"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookmethod);
                    webhookObjectpropCount++;
                }

                var headersObject = new JObject();
                var headersObjectpropCount = 0;
                if (headersObjectpropCount > 0)
                {
                    webhookObject["headers"] = headersObject;
                    webhookObjectpropCount++;
                }

                var authenticationObject = new JObject();
                var authenticationObjectpropCount = 0;
                if (bodyprofileairshipwebhookauthenticationmode != null)
                {
                    authenticationObject["mode"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationmode);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationusername != null)
                {
                    authenticationObject["username"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationusername);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationpassword != null)
                {
                    authenticationObject["password"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationpassword);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationtoken != null)
                {
                    authenticationObject["token"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationtoken);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    webhookObject["authentication"] = authenticationObject;
                    webhookObjectpropCount++;
                }

                if (bodyprofileairshipwebhookprofile != null)
                {
                    webhookObject["profile"] = SourceExpressionConverter.ConvertToken(bodyprofileairshipwebhookprofile);
                    webhookObjectpropCount++;
                }

                if (webhookObjectpropCount > 0)
                {
                    airshipObject["webhook"] = webhookObject;
                    airshipObjectpropCount++;
                }

                if (airshipObjectpropCount > 0)
                {
                    profileObject["airship"] = airshipObject;
                    profileObjectpropCount++;
                }

                if (profileObjectpropCount > 0)
                {
                    body["profile"] = profileObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfilePatchResponse> ProfilePatch([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(recipientId, nameof(recipientId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<ProfilePatchResponse>(BuildSourceInput);
        }
    }

    public class CourieripTriggers([ConnectionName] string connectionId)
    {
    }

    public class MessageSendPostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public class AudienceGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudienceGetResponseFilterType Filter { get; set; }
    }

    public class AudienceGetResponseFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class AudiencePutResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudiencePutResponseFilterType Filter { get; set; }
    }

    public class AudiencePutResponseFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("filters")]
        public AudiencePutResponseFilterTypeFiltersTypeItem[] Filters { get; set; }
    }

    public class AudiencePutResponseFilterTypeFiltersTypeItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyfilterfiltersInputItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AudienceMembersGetResponse
    {
        [JsonProperty("items")]
        public AudienceMembersGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public AudienceMembersGetResponsePagingType Paging { get; set; }
    }

    public class AudienceMembersGetResponseItemsTypeItem
    {
        [JsonProperty("member_id")]
        public string MemberId { get; set; }

        [JsonProperty("added_at")]
        public string AddedAt { get; set; }

        [JsonProperty("audience_id")]
        public string AudienceId { get; set; }

        [JsonProperty("audience_version")]
        public int AudienceVersion { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class AudienceMembersGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AudiencesGetResponse
    {
        [JsonProperty("items")]
        public AudiencesGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public AudiencesGetResponsePagingType Paging { get; set; }
    }

    public class AudiencesGetResponseItemsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("filter")]
        public AudiencesGetResponseItemsTypeItemFilterType Filter { get; set; }
    }

    public class AudiencesGetResponseItemsTypeItemFilterType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class AudiencesGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AuditEventsGetResponse
    {
        [JsonProperty("paging")]
        public AuditEventsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public AuditEventsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class AuditEventsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItem
    {
        [JsonProperty("auditEventId")]
        public string AuditEventId { get; set; }

        [JsonProperty("actor")]
        public AuditEventsGetResponseResultsTypeItemActorType Actor { get; set; }

        [JsonProperty("target")]
        public AuditEventsGetResponseResultsTypeItemTargetType Target { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItemActorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventsGetResponseResultsTypeItemTargetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventGetResponse
    {
        [JsonProperty("auditEventId")]
        public string AuditEventId { get; set; }

        [JsonProperty("actor")]
        public AuditEventGetResponseActorType Actor { get; set; }

        [JsonProperty("target")]
        public AuditEventGetResponseTargetType Target { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class AuditEventGetResponseActorType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AuditEventGetResponseTargetType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }

    public class AutomationTemplatedPostResponse
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }
    }

    public class AutomationAdHocPostResponse
    {
        [JsonProperty("runId")]
        public string RunId { get; set; }
    }

    public class BrandsGetResponse
    {
        [JsonProperty("paging")]
        public BrandsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public BrandsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class BrandsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class BrandsGetResponseResultsTypeItem
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public int Published { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("settings")]
        public BrandsGetResponseResultsTypeItemSettingsType Settings { get; set; }

        [JsonProperty("snippets")]
        public BrandsGetResponseResultsTypeItemSnippetsType Snippets { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsType
    {
        [JsonProperty("colors")]
        public BrandsGetResponseResultsTypeItemSettingsTypeColorsType Colors { get; set; }

        [JsonProperty("email")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailType Email { get; set; }

        [JsonProperty("inapp")]
        public BrandsGetResponseResultsTypeItemSettingsTypeInappType Inapp { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeColorsType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public string Tertiary { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailType
    {
        [JsonProperty("header")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderType Header { get; set; }

        [JsonProperty("footer")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterType Footer { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderType
    {
        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("logo")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderTypeLogoType Logo { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeHeaderTypeLogoType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterType
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("social")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialType Social { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialType
    {
        [JsonProperty("facebook")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType Facebook { get; set; }

        [JsonProperty("instagram")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType Instagram { get; set; }

        [JsonProperty("linkedin")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType Linkedin { get; set; }

        [JsonProperty("medium")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeMediumType Medium { get; set; }

        [JsonProperty("twitter")]
        public BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType Twitter { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeMediumType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSettingsTypeInappType
    {
        [JsonProperty("disableMessageIcon")]
        public bool DisableMessageIcon { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }
    }

    public class BrandsGetResponseResultsTypeItemSnippetsType
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class BrandGetResponse
    {
        [JsonProperty("created")]
        public int Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public int Published { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("settings")]
        public BrandGetResponseSettingsType Settings { get; set; }

        [JsonProperty("snippets")]
        public BrandGetResponseSnippetsType Snippets { get; set; }
    }

    public class BrandGetResponseSettingsType
    {
        [JsonProperty("colors")]
        public BrandGetResponseSettingsTypeColorsType Colors { get; set; }

        [JsonProperty("email")]
        public BrandGetResponseSettingsTypeEmailType Email { get; set; }

        [JsonProperty("inapp")]
        public BrandGetResponseSettingsTypeInappType Inapp { get; set; }
    }

    public class BrandGetResponseSettingsTypeColorsType
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public string Tertiary { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailType
    {
        [JsonProperty("header")]
        public BrandGetResponseSettingsTypeEmailTypeHeaderType Header { get; set; }

        [JsonProperty("footer")]
        public BrandGetResponseSettingsTypeEmailTypeFooterType Footer { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeHeaderType
    {
        [JsonProperty("barColor")]
        public string BarColor { get; set; }

        [JsonProperty("logo")]
        public BrandGetResponseSettingsTypeEmailTypeHeaderTypeLogoType Logo { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeHeaderTypeLogoType
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterType
    {
        [JsonProperty("markdown")]
        public string Markdown { get; set; }

        [JsonProperty("social")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialType Social { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialType
    {
        [JsonProperty("facebook")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType Facebook { get; set; }

        [JsonProperty("instagram")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType Instagram { get; set; }

        [JsonProperty("linkedin")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType Linkedin { get; set; }

        [JsonProperty("medium")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeMediumType Medium { get; set; }

        [JsonProperty("twitter")]
        public BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType Twitter { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeFacebookType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeInstagramType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeLinkedinType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeMediumType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeEmailTypeFooterTypeSocialTypeTwitterType
    {
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class BrandGetResponseSettingsTypeInappType
    {
        [JsonProperty("disableMessageIcon")]
        public bool DisableMessageIcon { get; set; }

        [JsonProperty("placement")]
        public string Placement { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }
    }

    public class BrandGetResponseSnippetsType
    {
        [JsonProperty("items")]
        public string[] Items { get; set; }
    }

    public class BulkJobPostResponse
    {
        [JsonProperty("jobId")]
        public string JobId { get; set; }
    }

    public class BulkJobGetResponse
    {
        [JsonProperty("job")]
        public BulkJobGetResponseJobType Job { get; set; }
    }

    public class BulkJobGetResponseJobType
    {
        [JsonProperty("definition")]
        public BulkJobGetResponseJobTypeDefinitionType Definition { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("failures")]
        public int Failures { get; set; }

        [JsonProperty("received")]
        public int Received { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class BulkJobGetResponseJobTypeDefinitionType
    {
        [JsonProperty("event")]
        public string Event { get; set; }
    }

    public class bodyusersInputItem
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("preferences")]
        public JToken Preferences { get; set; }

        [JsonProperty("profile")]
        public JToken Profile { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }

        [JsonProperty("to")]
        public JToken To { get; set; }
    }

    public class BulkJobUsersGetResponse
    {
        [JsonProperty("items")]
        public BulkJobUsersGetResponseItemsTypeItem[] Items { get; set; }

        [JsonProperty("paging")]
        public BulkJobUsersGetResponsePagingType Paging { get; set; }
    }

    public class BulkJobUsersGetResponseItemsTypeItem
    {
        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }
    }

    public class BulkJobUsersGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListsGetResponse
    {
        [JsonProperty("paging")]
        public ListsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public ListsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class ListsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListsGetResponseResultsTypeItem
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("preferences")]
        public ListsGetResponseResultsTypeItemPreferencesType Preferences { get; set; }
    }

    public class ListsGetResponseResultsTypeItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListGetResponse
    {
        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("preferences")]
        public ListGetResponsePreferencesType Preferences { get; set; }
    }

    public class ListGetResponsePreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ListSubscriptionsGetResponse
    {
        [JsonProperty("paging")]
        public ListSubscriptionsGetResponsePagingType Paging { get; set; }

        [JsonProperty("items")]
        public ListSubscriptionsGetResponseItemsTypeItem[] Items { get; set; }
    }

    public class ListSubscriptionsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class ListSubscriptionsGetResponseItemsTypeItem
    {
        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("preferences")]
        public ListSubscriptionsGetResponseItemsTypeItemPreferencesType Preferences { get; set; }
    }

    public class ListSubscriptionsGetResponseItemsTypeItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class bodyrecipientsInputItem
    {
        [JsonProperty("recipientId")]
        public string RecipientId { get; set; }

        [JsonProperty("preferences")]
        public bodyrecipientsInputItemPreferencesType Preferences { get; set; }
    }

    public class bodyrecipientsInputItemPreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class MessagesGetResponse
    {
        [JsonProperty("paging")]
        public MessagesGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public MessagesGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessagesGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class MessagesGetResponseResultsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class MessageGetResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("enqueued")]
        public int Enqueued { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("providers")]
        public MessageGetResponseProvidersTypeItem[] Providers { get; set; }
    }

    public class MessageGetResponseProvidersTypeItem
    {
        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("delivered")]
        public int Delivered { get; set; }

        [JsonProperty("clicked")]
        public int Clicked { get; set; }

        [JsonProperty("opened")]
        public int Opened { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class MessageHistoryGetResponse
    {
        [JsonProperty("results")]
        public MessageHistoryGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItem
    {
        [JsonProperty("data")]
        public MessageHistoryGetResponseResultsTypeItemDataType Data { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("recipient")]
        public string Recipient { get; set; }

        [JsonProperty("ts")]
        public int Ts { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("event_id")]
        public string EventId { get; set; }

        [JsonProperty("notification_id")]
        public string NotificationId { get; set; }

        [JsonProperty("channel")]
        public MessageHistoryGetResponseResultsTypeItemChannelType Channel { get; set; }

        [JsonProperty("integration")]
        public MessageHistoryGetResponseResultsTypeItemIntegrationType Integration { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemChannelType
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MessageHistoryGetResponseResultsTypeItemIntegrationType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
    }

    public class MessageContentGetResponse
    {
        [JsonProperty("results")]
        public MessageContentGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItem
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("channel_id")]
        public string ChannelId { get; set; }

        [JsonProperty("content")]
        public MessageContentGetResponseResultsTypeItemContentType Content { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItemContentType
    {
        [JsonProperty("html")]
        public string Html { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("blocks")]
        public MessageContentGetResponseResultsTypeItemContentTypeBlocksTypeItem[] Blocks { get; set; }
    }

    public class MessageContentGetResponseResultsTypeItemContentTypeBlocksTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class NotificationsGetResponse
    {
        [JsonProperty("paging")]
        public NotificationsGetResponsePagingType Paging { get; set; }

        [JsonProperty("results")]
        public NotificationsGetResponseResultsTypeItem[] Results { get; set; }
    }

    public class NotificationsGetResponsePagingType
    {
        [JsonProperty("cursor")]
        public string Cursor { get; set; }

        [JsonProperty("more")]
        public bool More { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItem
    {
        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tags")]
        public NotificationsGetResponseResultsTypeItemTagsType Tags { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public int UpdatedAt { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItemTagsType
    {
        [JsonProperty("data")]
        public NotificationsGetResponseResultsTypeItemTagsTypeDataTypeItem[] Data { get; set; }
    }

    public class NotificationsGetResponseResultsTypeItemTagsTypeDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ProfileGetResponse
    {
        [JsonProperty("profile")]
        public ProfileGetResponseProfileType Profile { get; set; }

        [JsonProperty("preferences")]
        public ProfileGetResponsePreferencesType Preferences { get; set; }
    }

    public class ProfileGetResponseProfileType
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
    }

    public class ProfileGetResponsePreferencesType
    {
        [JsonProperty("notifications")]
        public JToken Notifications { get; set; }

        [JsonProperty("categories")]
        public JToken Categories { get; set; }
    }

    public class ProfileDeleteResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class ProfilePatchResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("op")]
        public bodyInputItemOpType Op { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public enum bodyInputItemOpType
    {
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "remove")]
        Remove,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "move")]
        Move,
        [EnumMember(Value = "copy")]
        Copy,
        [EnumMember(Value = "test")]
        Test
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Courierip;

    public partial class WorkflowManagedActions
    {
        public CourieripActions Courierip(string connectionId) => new CourieripActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CourieripTriggers Courierip(string connectionId) => new CourieripTriggers(connectionId);
    }
}