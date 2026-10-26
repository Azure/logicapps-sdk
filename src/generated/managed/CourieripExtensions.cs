//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courierip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourieripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageSendPostResponse, ApiConnectionActionConfiguration> MessageSend(Expression<Func<string>> idempotency, Expression<Func<string>> bodymessagecontenttitle = null, Expression<Func<string>> bodymessagecontentbody = null, Expression<Func<string>> bodymessagetouserId = null, Expression<Func<string>> bodymessagetolistId = null, Expression<Func<string>> bodymessagetoaudienceId = null, Expression<Func<string>> bodymessagetoemail = null, Expression<Func<string>> bodymessagetophoneNumber = null, Expression<Func<string>> bodymessagetolocale = null)
        {
            var __workflow_idempotency = WorkflowExpression.Compile(idempotency, nameof(idempotency), required: true);
            var __workflow_bodymessagecontenttitle = WorkflowExpression.Compile(bodymessagecontenttitle, nameof(bodymessagecontenttitle), required: false);
            var __workflow_bodymessagecontentbody = WorkflowExpression.Compile(bodymessagecontentbody, nameof(bodymessagecontentbody), required: false);
            var __workflow_bodymessagetouserId = WorkflowExpression.Compile(bodymessagetouserId, nameof(bodymessagetouserId), required: false);
            var __workflow_bodymessagetolistId = WorkflowExpression.Compile(bodymessagetolistId, nameof(bodymessagetolistId), required: false);
            var __workflow_bodymessagetoaudienceId = WorkflowExpression.Compile(bodymessagetoaudienceId, nameof(bodymessagetoaudienceId), required: false);
            var __workflow_bodymessagetoemail = WorkflowExpression.Compile(bodymessagetoemail, nameof(bodymessagetoemail), required: false);
            var __workflow_bodymessagetophoneNumber = WorkflowExpression.Compile(bodymessagetophoneNumber, nameof(bodymessagetophoneNumber), required: false);
            var __workflow_bodymessagetolocale = WorkflowExpression.Compile(bodymessagetolocale, nameof(bodymessagetolocale), required: false);
            return new DeferredBodyAction<MessageSendPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idempotency"] = ExpressionConverter.Convert(__workflow_idempotency);
                var body = new JObject();
                var bodypropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (__workflow_bodymessagecontenttitle != null)
                {
                    contentObject["title"] = ExpressionConverter.ConvertO(__workflow_bodymessagecontenttitle);
                    contentObjectpropCount++;
                }

                if (__workflow_bodymessagecontentbody != null)
                {
                    contentObject["body"] = ExpressionConverter.ConvertO(__workflow_bodymessagecontentbody);
                    contentObjectpropCount++;
                }

                if (contentObjectpropCount > 0)
                {
                    messageObject["content"] = contentObject;
                    messageObjectpropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (__workflow_bodymessagetouserId != null)
                {
                    toObject["user_id"] = ExpressionConverter.ConvertO(__workflow_bodymessagetouserId);
                    toObjectpropCount++;
                }

                if (__workflow_bodymessagetolistId != null)
                {
                    toObject["list_id"] = ExpressionConverter.ConvertO(__workflow_bodymessagetolistId);
                    toObjectpropCount++;
                }

                if (__workflow_bodymessagetoaudienceId != null)
                {
                    toObject["audience_id"] = ExpressionConverter.ConvertO(__workflow_bodymessagetoaudienceId);
                    toObjectpropCount++;
                }

                if (__workflow_bodymessagetoemail != null)
                {
                    toObject["email"] = ExpressionConverter.ConvertO(__workflow_bodymessagetoemail);
                    toObjectpropCount++;
                }

                if (__workflow_bodymessagetophoneNumber != null)
                {
                    toObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodymessagetophoneNumber);
                    toObjectpropCount++;
                }

                if (__workflow_bodymessagetolocale != null)
                {
                    toObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodymessagetolocale);
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

                return new ApiConnectionAction<MessageSendPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceGetResponse, ApiConnectionActionConfiguration> AudienceGet(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<AudienceGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AudienceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> AudienceDelete(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencePutResponse, ApiConnectionActionConfiguration> AudiencePut(Expression<Func<string>> audienceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfilterpath = null, Expression<Func<string>> bodyfilterOperator = null, Expression<Func<string>> bodyfiltervalue = null, Expression<Func<bodyfilterfiltersInputItem[]>> bodyfilterfilters = null)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfilterpath = WorkflowExpression.Compile(bodyfilterpath, nameof(bodyfilterpath), required: false);
            var __workflow_bodyfilterOperator = WorkflowExpression.Compile(bodyfilterOperator, nameof(bodyfilterOperator), required: false);
            var __workflow_bodyfiltervalue = WorkflowExpression.Compile(bodyfiltervalue, nameof(bodyfiltervalue), required: false);
            var __workflow_bodyfilterfilters = WorkflowExpression.Compile(bodyfilterfilters, nameof(bodyfilterfilters), required: false);
            return new DeferredBodyAction<AudiencePutResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (__workflow_bodyfilterpath != null)
                {
                    filterObject["path"] = ExpressionConverter.ConvertO(__workflow_bodyfilterpath);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterOperator != null)
                {
                    filterObject["operator"] = ExpressionConverter.ConvertO(__workflow_bodyfilterOperator);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfiltervalue != null)
                {
                    filterObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyfiltervalue);
                    filterObjectpropCount++;
                }

                if (__workflow_bodyfilterfilters != null)
                {
                    filterObject["filters"] = ExpressionConverter.ConvertO(__workflow_bodyfilterfilters);
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

                return new ApiConnectionAction<AudiencePutResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceMembersGetResponse, ApiConnectionActionConfiguration> AudienceMembersGet(Expression<Func<string>> audienceId, Expression<Func<string>> cursor = null)
        {
            var __workflow_audienceId = WorkflowExpression.Compile(audienceId, nameof(audienceId), required: true);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudienceMembersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audiences/{0}/members", __workflow_audienceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AudienceMembersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencesGetResponse, ApiConnectionActionConfiguration> AudiencesGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudiencesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AudiencesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventsGetResponse, ApiConnectionActionConfiguration> AuditEventsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AuditEventsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/audit-events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AuditEventsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventGetResponse, ApiConnectionActionConfiguration> AuditEventGet(Expression<Func<string>> auditEventId)
        {
            var __workflow_auditEventId = WorkflowExpression.Compile(auditEventId, nameof(auditEventId), required: true);
            return new DeferredBodyAction<AuditEventGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/audit-events/{0}", __workflow_auditEventId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AuditEventGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse, ApiConnectionActionConfiguration> AutomationTemplated(Expression<Func<string>> templateId, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_bodybrand = WorkflowExpression.Compile(bodybrand, nameof(bodybrand), required: false);
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodyrecipient = WorkflowExpression.Compile(bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationTemplatedPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/automations/{0}/invoke", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybrand != null)
                {
                    body["brand"] = ExpressionConverter.ConvertO(__workflow_bodybrand);
                    bodypropCount++;
                }

                if (__workflow_bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipient != null)
                {
                    body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipient);
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

                return new ApiConnectionAction<AutomationTemplatedPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationAdHocPostResponse, ApiConnectionActionConfiguration> AutomationAdHoc(Expression<Func<JToken[]>> bodyautomationsteps = null, Expression<Func<string>> bodyautomationcancelationToken = null, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
        {
            var __workflow_bodyautomationsteps = WorkflowExpression.Compile(bodyautomationsteps, nameof(bodyautomationsteps), required: false);
            var __workflow_bodyautomationcancelationToken = WorkflowExpression.Compile(bodyautomationcancelationToken, nameof(bodyautomationcancelationToken), required: false);
            var __workflow_bodybrand = WorkflowExpression.Compile(bodybrand, nameof(bodybrand), required: false);
            var __workflow_bodytemplate = WorkflowExpression.Compile(bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodyrecipient = WorkflowExpression.Compile(bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationAdHocPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/automations/invoke";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var automationObject = new JObject();
                var automationObjectpropCount = 0;
                if (__workflow_bodyautomationsteps != null)
                {
                    automationObject["steps"] = ExpressionConverter.ConvertO(__workflow_bodyautomationsteps);
                    automationObjectpropCount++;
                }

                if (__workflow_bodyautomationcancelationToken != null)
                {
                    automationObject["cancelation_token"] = ExpressionConverter.ConvertO(__workflow_bodyautomationcancelationToken);
                    automationObjectpropCount++;
                }

                if (automationObjectpropCount > 0)
                {
                    body["automation"] = automationObject;
                    bodypropCount++;
                }

                if (__workflow_bodybrand != null)
                {
                    body["brand"] = ExpressionConverter.ConvertO(__workflow_bodybrand);
                    bodypropCount++;
                }

                if (__workflow_bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(__workflow_bodytemplate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecipient != null)
                {
                    body["recipient"] = ExpressionConverter.ConvertO(__workflow_bodyrecipient);
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

                return new ApiConnectionAction<AutomationAdHocPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandsGetResponse, ApiConnectionActionConfiguration> BrandsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<BrandsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<BrandsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Brand(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodysettingscolorsprimary = null, Expression<Func<string>> bodysettingscolorssecondary = null, Expression<Func<string>> bodysettingscolorstertiary = null, Expression<Func<string>> bodysettingsemailheaderbarColor = null, Expression<Func<string>> bodysettingsemailheaderlogohref = null, Expression<Func<string>> bodysettingsemailheaderlogoimage = null, Expression<Func<string>> bodysettingsemailfootermarkdown = null, Expression<Func<string>> bodysettingsemailfootersocialfacebookurl = null, Expression<Func<string>> bodysettingsemailfootersocialinstagramurl = null, Expression<Func<string>> bodysettingsemailfootersociallinkedinurl = null, Expression<Func<string>> bodysettingsemailfootersocialmediumurl = null, Expression<Func<string>> bodysettingsemailfootersocialtwitterurl = null, Expression<Func<bool>> bodysettingsinappdisableMessageIcon = null, Expression<Func<string>> bodysettingsinappplacement = null, Expression<Func<string[]>> bodysnippetsitems = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodysettingscolorsprimary = WorkflowExpression.Compile(bodysettingscolorsprimary, nameof(bodysettingscolorsprimary), required: false);
            var __workflow_bodysettingscolorssecondary = WorkflowExpression.Compile(bodysettingscolorssecondary, nameof(bodysettingscolorssecondary), required: false);
            var __workflow_bodysettingscolorstertiary = WorkflowExpression.Compile(bodysettingscolorstertiary, nameof(bodysettingscolorstertiary), required: false);
            var __workflow_bodysettingsemailheaderbarColor = WorkflowExpression.Compile(bodysettingsemailheaderbarColor, nameof(bodysettingsemailheaderbarColor), required: false);
            var __workflow_bodysettingsemailheaderlogohref = WorkflowExpression.Compile(bodysettingsemailheaderlogohref, nameof(bodysettingsemailheaderlogohref), required: false);
            var __workflow_bodysettingsemailheaderlogoimage = WorkflowExpression.Compile(bodysettingsemailheaderlogoimage, nameof(bodysettingsemailheaderlogoimage), required: false);
            var __workflow_bodysettingsemailfootermarkdown = WorkflowExpression.Compile(bodysettingsemailfootermarkdown, nameof(bodysettingsemailfootermarkdown), required: false);
            var __workflow_bodysettingsemailfootersocialfacebookurl = WorkflowExpression.Compile(bodysettingsemailfootersocialfacebookurl, nameof(bodysettingsemailfootersocialfacebookurl), required: false);
            var __workflow_bodysettingsemailfootersocialinstagramurl = WorkflowExpression.Compile(bodysettingsemailfootersocialinstagramurl, nameof(bodysettingsemailfootersocialinstagramurl), required: false);
            var __workflow_bodysettingsemailfootersociallinkedinurl = WorkflowExpression.Compile(bodysettingsemailfootersociallinkedinurl, nameof(bodysettingsemailfootersociallinkedinurl), required: false);
            var __workflow_bodysettingsemailfootersocialmediumurl = WorkflowExpression.Compile(bodysettingsemailfootersocialmediumurl, nameof(bodysettingsemailfootersocialmediumurl), required: false);
            var __workflow_bodysettingsemailfootersocialtwitterurl = WorkflowExpression.Compile(bodysettingsemailfootersocialtwitterurl, nameof(bodysettingsemailfootersocialtwitterurl), required: false);
            var __workflow_bodysettingsinappdisableMessageIcon = WorkflowExpression.Compile(bodysettingsinappdisableMessageIcon, nameof(bodysettingsinappdisableMessageIcon), required: false);
            var __workflow_bodysettingsinappplacement = WorkflowExpression.Compile(bodysettingsinappplacement, nameof(bodysettingsinappplacement), required: false);
            var __workflow_bodysnippetsitems = WorkflowExpression.Compile(bodysnippetsitems, nameof(bodysnippetsitems), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                var colorsObject = new JObject();
                var colorsObjectpropCount = 0;
                if (__workflow_bodysettingscolorsprimary != null)
                {
                    colorsObject["primary"] = ExpressionConverter.ConvertO(__workflow_bodysettingscolorsprimary);
                    colorsObjectpropCount++;
                }

                if (__workflow_bodysettingscolorssecondary != null)
                {
                    colorsObject["secondary"] = ExpressionConverter.ConvertO(__workflow_bodysettingscolorssecondary);
                    colorsObjectpropCount++;
                }

                if (__workflow_bodysettingscolorstertiary != null)
                {
                    colorsObject["tertiary"] = ExpressionConverter.ConvertO(__workflow_bodysettingscolorstertiary);
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
                if (__workflow_bodysettingsemailheaderbarColor != null)
                {
                    headerObject["barColor"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailheaderbarColor);
                    headerObjectpropCount++;
                }

                var logoObject = new JObject();
                var logoObjectpropCount = 0;
                if (__workflow_bodysettingsemailheaderlogohref != null)
                {
                    logoObject["href"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailheaderlogohref);
                    logoObjectpropCount++;
                }

                if (__workflow_bodysettingsemailheaderlogoimage != null)
                {
                    logoObject["image"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailheaderlogoimage);
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
                if (__workflow_bodysettingsemailfootermarkdown != null)
                {
                    footerObject["markdown"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootermarkdown);
                    footerObjectpropCount++;
                }

                var socialObject = new JObject();
                var socialObjectpropCount = 0;
                var facebookObject = new JObject();
                var facebookObjectpropCount = 0;
                if (__workflow_bodysettingsemailfootersocialfacebookurl != null)
                {
                    facebookObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootersocialfacebookurl);
                    facebookObjectpropCount++;
                }

                if (facebookObjectpropCount > 0)
                {
                    socialObject["facebook"] = facebookObject;
                    socialObjectpropCount++;
                }

                var instagramObject = new JObject();
                var instagramObjectpropCount = 0;
                if (__workflow_bodysettingsemailfootersocialinstagramurl != null)
                {
                    instagramObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootersocialinstagramurl);
                    instagramObjectpropCount++;
                }

                if (instagramObjectpropCount > 0)
                {
                    socialObject["instagram"] = instagramObject;
                    socialObjectpropCount++;
                }

                var linkedinObject = new JObject();
                var linkedinObjectpropCount = 0;
                if (__workflow_bodysettingsemailfootersociallinkedinurl != null)
                {
                    linkedinObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootersociallinkedinurl);
                    linkedinObjectpropCount++;
                }

                if (linkedinObjectpropCount > 0)
                {
                    socialObject["linkedin"] = linkedinObject;
                    socialObjectpropCount++;
                }

                var mediumObject = new JObject();
                var mediumObjectpropCount = 0;
                if (__workflow_bodysettingsemailfootersocialmediumurl != null)
                {
                    mediumObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootersocialmediumurl);
                    mediumObjectpropCount++;
                }

                if (mediumObjectpropCount > 0)
                {
                    socialObject["medium"] = mediumObject;
                    socialObjectpropCount++;
                }

                var twitterObject = new JObject();
                var twitterObjectpropCount = 0;
                if (__workflow_bodysettingsemailfootersocialtwitterurl != null)
                {
                    twitterObject["url"] = ExpressionConverter.ConvertO(__workflow_bodysettingsemailfootersocialtwitterurl);
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
                if (__workflow_bodysettingsinappdisableMessageIcon != null)
                {
                    inappObject["disableMessageIcon"] = ExpressionConverter.ConvertO(__workflow_bodysettingsinappdisableMessageIcon);
                    inappObjectpropCount++;
                }

                if (__workflow_bodysettingsinappplacement != null)
                {
                    inappObject["placement"] = ExpressionConverter.ConvertO(__workflow_bodysettingsinappplacement);
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
                if (__workflow_bodysnippetsitems != null)
                {
                    snippetsObject["items"] = ExpressionConverter.ConvertO(__workflow_bodysnippetsitems);
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

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandGetResponse, ApiConnectionActionConfiguration> BrandGet(Expression<Func<string>> brandId)
        {
            var __workflow_brandId = WorkflowExpression.Compile(brandId, nameof(brandId), required: true);
            return new DeferredBodyAction<BrandGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/brands/{0}", __workflow_brandId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BrandGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobPostResponse, ApiConnectionActionConfiguration> BulkJob(Expression<Func<string>> bodymessageEvent = null, Expression<Func<string>> bodymessagebrand = null, Expression<Func<string>> bodymessagetemplate = null, Expression<Func<string>> bodymessagebrandId = null, Expression<Func<string>> bodymessageroutingmethod = null, Expression<Func<string[]>> bodymessageroutingchannels = null, Expression<Func<string>> bodymessagemetadataEvent = null, Expression<Func<string[]>> bodymessagemetadatatags = null, Expression<Func<string>> bodymessagemetadatatraceId = null, Expression<Func<string>> bodymessagemetadatautmcampaign = null, Expression<Func<string>> bodymessagemetadatautmcontent = null, Expression<Func<string>> bodymessagemetadatautmmedium = null, Expression<Func<string>> bodymessagemetadatautmsource = null, Expression<Func<string>> bodymessagemetadatautmterm = null)
        {
            var __workflow_bodymessageEvent = WorkflowExpression.Compile(bodymessageEvent, nameof(bodymessageEvent), required: false);
            var __workflow_bodymessagebrand = WorkflowExpression.Compile(bodymessagebrand, nameof(bodymessagebrand), required: false);
            var __workflow_bodymessagetemplate = WorkflowExpression.Compile(bodymessagetemplate, nameof(bodymessagetemplate), required: false);
            var __workflow_bodymessagebrandId = WorkflowExpression.Compile(bodymessagebrandId, nameof(bodymessagebrandId), required: false);
            var __workflow_bodymessageroutingmethod = WorkflowExpression.Compile(bodymessageroutingmethod, nameof(bodymessageroutingmethod), required: false);
            var __workflow_bodymessageroutingchannels = WorkflowExpression.Compile(bodymessageroutingchannels, nameof(bodymessageroutingchannels), required: false);
            var __workflow_bodymessagemetadataEvent = WorkflowExpression.Compile(bodymessagemetadataEvent, nameof(bodymessagemetadataEvent), required: false);
            var __workflow_bodymessagemetadatatags = WorkflowExpression.Compile(bodymessagemetadatatags, nameof(bodymessagemetadatatags), required: false);
            var __workflow_bodymessagemetadatatraceId = WorkflowExpression.Compile(bodymessagemetadatatraceId, nameof(bodymessagemetadatatraceId), required: false);
            var __workflow_bodymessagemetadatautmcampaign = WorkflowExpression.Compile(bodymessagemetadatautmcampaign, nameof(bodymessagemetadatautmcampaign), required: false);
            var __workflow_bodymessagemetadatautmcontent = WorkflowExpression.Compile(bodymessagemetadatautmcontent, nameof(bodymessagemetadatautmcontent), required: false);
            var __workflow_bodymessagemetadatautmmedium = WorkflowExpression.Compile(bodymessagemetadatautmmedium, nameof(bodymessagemetadatautmmedium), required: false);
            var __workflow_bodymessagemetadatautmsource = WorkflowExpression.Compile(bodymessagemetadatautmsource, nameof(bodymessagemetadatautmsource), required: false);
            var __workflow_bodymessagemetadatautmterm = WorkflowExpression.Compile(bodymessagemetadatautmterm, nameof(bodymessagemetadatautmterm), required: false);
            return new DeferredBodyAction<BulkJobPostResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/bulk";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                if (__workflow_bodymessageEvent != null)
                {
                    messageObject["event"] = ExpressionConverter.ConvertO(__workflow_bodymessageEvent);
                    messageObjectpropCount++;
                }

                if (__workflow_bodymessagebrand != null)
                {
                    messageObject["brand"] = ExpressionConverter.ConvertO(__workflow_bodymessagebrand);
                    messageObjectpropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    messageObject["data"] = dataObject;
                    messageObjectpropCount++;
                }

                var @overrideObject = new JObject();
                var @overrideObjectpropCount = 0;
                if (@overrideObjectpropCount > 0)
                {
                    messageObject["override"] = @overrideObject;
                    messageObjectpropCount++;
                }

                if (__workflow_bodymessagetemplate != null)
                {
                    messageObject["template"] = ExpressionConverter.ConvertO(__workflow_bodymessagetemplate);
                    messageObjectpropCount++;
                }

                if (__workflow_bodymessagebrandId != null)
                {
                    messageObject["brand_id"] = ExpressionConverter.ConvertO(__workflow_bodymessagebrandId);
                    messageObjectpropCount++;
                }

                var routingObject = new JObject();
                var routingObjectpropCount = 0;
                if (__workflow_bodymessageroutingmethod != null)
                {
                    routingObject["method"] = ExpressionConverter.ConvertO(__workflow_bodymessageroutingmethod);
                    routingObjectpropCount++;
                }

                if (__workflow_bodymessageroutingchannels != null)
                {
                    routingObject["channels"] = ExpressionConverter.ConvertO(__workflow_bodymessageroutingchannels);
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
                if (__workflow_bodymessagemetadataEvent != null)
                {
                    metadataObject["event"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadataEvent);
                    metadataObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatatags != null)
                {
                    metadataObject["tags"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatatags);
                    metadataObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatatraceId != null)
                {
                    metadataObject["trace_id"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatatraceId);
                    metadataObjectpropCount++;
                }

                var utmObject = new JObject();
                var utmObjectpropCount = 0;
                if (__workflow_bodymessagemetadatautmcampaign != null)
                {
                    utmObject["campaign"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatautmcampaign);
                    utmObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatautmcontent != null)
                {
                    utmObject["content"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatautmcontent);
                    utmObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatautmmedium != null)
                {
                    utmObject["medium"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatautmmedium);
                    utmObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatautmsource != null)
                {
                    utmObject["source"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatautmsource);
                    utmObjectpropCount++;
                }

                if (__workflow_bodymessagemetadatautmterm != null)
                {
                    utmObject["term"] = ExpressionConverter.ConvertO(__workflow_bodymessagemetadatautmterm);
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

                return new ApiConnectionAction<BulkJobPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobGetResponse, ApiConnectionActionConfiguration> BulkJobGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> BulkJobUsers(Expression<Func<string>> jobId, Expression<Func<bodyusersInputItem[]>> bodyusers = null)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            var __workflow_bodyusers = WorkflowExpression.Compile(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(__workflow_bodyusers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> BulkJobRun(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}/run", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobUsersGetResponse, ApiConnectionActionConfiguration> BulkJobUsersGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = WorkflowExpression.Compile(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobUsersGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/bulk/{0}/users", __workflow_jobId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobUsersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListsGetResponse, ApiConnectionActionConfiguration> ListsGet()
        {
            return new DeferredBodyAction<ListsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/lists";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListGetResponse, ApiConnectionActionConfiguration> ListGet(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<ListGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListDelete(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListPut(Expression<Func<string>> listId, Expression<Func<string>> bodyname = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
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

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListRestorePut(Expression<Func<string>> listId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/restore", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse, ApiConnectionActionConfiguration> ListSubscriptionsGet(Expression<Func<string>> listId, Expression<Func<string>> cursor = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<ListSubscriptionsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<ListSubscriptionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListSubscribers(Expression<Func<string>> listId, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients = null)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_bodyrecipients = WorkflowExpression.Compile(bodyrecipients, nameof(bodyrecipients), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions", __workflow_listId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyrecipients != null)
                {
                    body["recipients"] = ExpressionConverter.ConvertO(__workflow_bodyrecipients);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> ListSubscribeDelete(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = WorkflowExpression.Compile(listId, nameof(listId), required: true);
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/lists/{0}/subscriptions/{1}", __workflow_listId.WithUrlEncoding(1), __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessagesGetResponse, ApiConnectionActionConfiguration> MessagesGet(Expression<Func<bool>> archived = null, Expression<Func<string>> cursor = null, Expression<Func<string>> @event = null, Expression<Func<string>> list = null, Expression<Func<string>> messageId = null, Expression<Func<string>> notification = null, Expression<Func<string>> recipient = null, Expression<Func<string>> status = null, Expression<Func<string>> tags = null)
        {
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            var __workflow_event = WorkflowExpression.Compile(@event, nameof(@event), required: false);
            var __workflow_list = WorkflowExpression.Compile(list, nameof(list), required: false);
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: false);
            var __workflow_notification = WorkflowExpression.Compile(notification, nameof(notification), required: false);
            var __workflow_recipient = WorkflowExpression.Compile(recipient, nameof(recipient), required: false);
            var __workflow_status = WorkflowExpression.Compile(status, nameof(status), required: false);
            var __workflow_tags = WorkflowExpression.Compile(tags, nameof(tags), required: false);
            return new DeferredBodyAction<MessagesGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                if (__workflow_event != null)
                    callPayload.Queries["event"] = ExpressionConverter.Convert(__workflow_event);
                if (__workflow_list != null)
                    callPayload.Queries["list"] = ExpressionConverter.Convert(__workflow_list);
                if (__workflow_messageId != null)
                    callPayload.Queries["messageId"] = ExpressionConverter.Convert(__workflow_messageId);
                if (__workflow_notification != null)
                    callPayload.Queries["notification"] = ExpressionConverter.Convert(__workflow_notification);
                if (__workflow_recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(__workflow_recipient);
                if (__workflow_status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(__workflow_status);
                if (__workflow_tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(__workflow_tags);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageGetResponse, ApiConnectionActionConfiguration> MessageGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageHistoryGetResponse, ApiConnectionActionConfiguration> MessageHistoryGet(Expression<Func<string>> messageId, Expression<Func<string>> type = null)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            var __workflow_type = WorkflowExpression.Compile(type, nameof(type), required: false);
            return new DeferredBodyAction<MessageHistoryGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}/history", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<MessageHistoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageContentGetResponse, ApiConnectionActionConfiguration> MessageContentGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = WorkflowExpression.Compile(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageContentGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/messages/{0}/output", __workflow_messageId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageContentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> MessagePut(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = WorkflowExpression.Compile(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/requests/{0}/archive", __workflow_requestId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<NotificationsGetResponse, ApiConnectionActionConfiguration> NotificationsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = WorkflowExpression.Compile(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<NotificationsGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<NotificationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileGetResponse, ApiConnectionActionConfiguration> ProfileGet(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileDeleteResponse, ApiConnectionActionConfiguration> ProfileDelete(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileDeleteResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> Profile(Expression<Func<string>> recipientId, Expression<Func<string>> bodyprofileemail = null, Expression<Func<string>> bodyprofilephoneNumber = null, Expression<Func<string>> bodyprofileaddressformatted = null, Expression<Func<string>> bodyprofileaddressstreetAddress = null, Expression<Func<string>> bodyprofileaddresslocality = null, Expression<Func<string>> bodyprofileaddressregion = null, Expression<Func<string>> bodyprofileaddresspostalCode = null, Expression<Func<string>> bodyprofileaddresscountry = null, Expression<Func<string>> bodyprofilebirthdate = null, Expression<Func<bool>> bodyprofileemailVerified = null, Expression<Func<bool>> bodyprofilephoneNumberVerified = null, Expression<Func<string>> bodyprofilegivenName = null, Expression<Func<string>> bodyprofilemiddleName = null, Expression<Func<string>> bodyprofilefamilyName = null, Expression<Func<string>> bodyprofilepreferredName = null, Expression<Func<string>> bodyprofilegender = null, Expression<Func<string>> bodyprofilelocale = null, Expression<Func<string>> bodyprofilepicture = null, Expression<Func<string>> bodyprofileprofile = null, Expression<Func<string>> bodyprofilesub = null, Expression<Func<string>> bodyprofileupdatedAt = null, Expression<Func<string>> bodyprofilewebsite = null, Expression<Func<string>> bodyprofilezoneinfo = null, Expression<Func<string>> bodyprofileairshipaudiencenamedUser = null, Expression<Func<string[]>> bodyprofileairshipdeviceTypes = null, Expression<Func<string>> bodyprofileairshipapn = null, Expression<Func<string>> bodyprofileairshiptargetArn = null, Expression<Func<string>> bodyprofileairshipdiscordchannelId = null, Expression<Func<string>> bodyprofileairshipdiscorduserId = null, Expression<Func<string>> bodyprofileairshipexpotoken = null, Expression<Func<string[]>> bodyprofileairshipexpotokens = null, Expression<Func<string>> bodyprofileairshipfacebookPSId = null, Expression<Func<string>> bodyprofileairshipfirebaseToken = null, Expression<Func<string>> bodyprofileairshipintercomfrom = null, Expression<Func<string>> bodyprofileairshipintercomtoid = null, Expression<Func<string>> bodyprofileairshipmsTeamsuserId = null, Expression<Func<string>> bodyprofileairshipmsTeamsconversationId = null, Expression<Func<string>> bodyprofileairshipmsTeamstenantId = null, Expression<Func<string>> bodyprofileairshipmsTeamsserviceUrl = null, Expression<Func<string>> bodyprofileairshiponeSignalPlayerId = null, Expression<Func<string>> bodyprofileairshipslackaccessToken = null, Expression<Func<string>> bodyprofileairshipslackchannel = null, Expression<Func<string>> bodyprofileairshipslackemail = null, Expression<Func<string>> bodyprofileairshipslackuserId = null, Expression<Func<string>> bodyprofileairshipslackincomingWebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookmethod = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationmode = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationusername = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationpassword = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationtoken = null, Expression<Func<string>> bodyprofileairshipwebhookprofile = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_bodyprofileemail = WorkflowExpression.Compile(bodyprofileemail, nameof(bodyprofileemail), required: false);
            var __workflow_bodyprofilephoneNumber = WorkflowExpression.Compile(bodyprofilephoneNumber, nameof(bodyprofilephoneNumber), required: false);
            var __workflow_bodyprofileaddressformatted = WorkflowExpression.Compile(bodyprofileaddressformatted, nameof(bodyprofileaddressformatted), required: false);
            var __workflow_bodyprofileaddressstreetAddress = WorkflowExpression.Compile(bodyprofileaddressstreetAddress, nameof(bodyprofileaddressstreetAddress), required: false);
            var __workflow_bodyprofileaddresslocality = WorkflowExpression.Compile(bodyprofileaddresslocality, nameof(bodyprofileaddresslocality), required: false);
            var __workflow_bodyprofileaddressregion = WorkflowExpression.Compile(bodyprofileaddressregion, nameof(bodyprofileaddressregion), required: false);
            var __workflow_bodyprofileaddresspostalCode = WorkflowExpression.Compile(bodyprofileaddresspostalCode, nameof(bodyprofileaddresspostalCode), required: false);
            var __workflow_bodyprofileaddresscountry = WorkflowExpression.Compile(bodyprofileaddresscountry, nameof(bodyprofileaddresscountry), required: false);
            var __workflow_bodyprofilebirthdate = WorkflowExpression.Compile(bodyprofilebirthdate, nameof(bodyprofilebirthdate), required: false);
            var __workflow_bodyprofileemailVerified = WorkflowExpression.Compile(bodyprofileemailVerified, nameof(bodyprofileemailVerified), required: false);
            var __workflow_bodyprofilephoneNumberVerified = WorkflowExpression.Compile(bodyprofilephoneNumberVerified, nameof(bodyprofilephoneNumberVerified), required: false);
            var __workflow_bodyprofilegivenName = WorkflowExpression.Compile(bodyprofilegivenName, nameof(bodyprofilegivenName), required: false);
            var __workflow_bodyprofilemiddleName = WorkflowExpression.Compile(bodyprofilemiddleName, nameof(bodyprofilemiddleName), required: false);
            var __workflow_bodyprofilefamilyName = WorkflowExpression.Compile(bodyprofilefamilyName, nameof(bodyprofilefamilyName), required: false);
            var __workflow_bodyprofilepreferredName = WorkflowExpression.Compile(bodyprofilepreferredName, nameof(bodyprofilepreferredName), required: false);
            var __workflow_bodyprofilegender = WorkflowExpression.Compile(bodyprofilegender, nameof(bodyprofilegender), required: false);
            var __workflow_bodyprofilelocale = WorkflowExpression.Compile(bodyprofilelocale, nameof(bodyprofilelocale), required: false);
            var __workflow_bodyprofilepicture = WorkflowExpression.Compile(bodyprofilepicture, nameof(bodyprofilepicture), required: false);
            var __workflow_bodyprofileprofile = WorkflowExpression.Compile(bodyprofileprofile, nameof(bodyprofileprofile), required: false);
            var __workflow_bodyprofilesub = WorkflowExpression.Compile(bodyprofilesub, nameof(bodyprofilesub), required: false);
            var __workflow_bodyprofileupdatedAt = WorkflowExpression.Compile(bodyprofileupdatedAt, nameof(bodyprofileupdatedAt), required: false);
            var __workflow_bodyprofilewebsite = WorkflowExpression.Compile(bodyprofilewebsite, nameof(bodyprofilewebsite), required: false);
            var __workflow_bodyprofilezoneinfo = WorkflowExpression.Compile(bodyprofilezoneinfo, nameof(bodyprofilezoneinfo), required: false);
            var __workflow_bodyprofileairshipaudiencenamedUser = WorkflowExpression.Compile(bodyprofileairshipaudiencenamedUser, nameof(bodyprofileairshipaudiencenamedUser), required: false);
            var __workflow_bodyprofileairshipdeviceTypes = WorkflowExpression.Compile(bodyprofileairshipdeviceTypes, nameof(bodyprofileairshipdeviceTypes), required: false);
            var __workflow_bodyprofileairshipapn = WorkflowExpression.Compile(bodyprofileairshipapn, nameof(bodyprofileairshipapn), required: false);
            var __workflow_bodyprofileairshiptargetArn = WorkflowExpression.Compile(bodyprofileairshiptargetArn, nameof(bodyprofileairshiptargetArn), required: false);
            var __workflow_bodyprofileairshipdiscordchannelId = WorkflowExpression.Compile(bodyprofileairshipdiscordchannelId, nameof(bodyprofileairshipdiscordchannelId), required: false);
            var __workflow_bodyprofileairshipdiscorduserId = WorkflowExpression.Compile(bodyprofileairshipdiscorduserId, nameof(bodyprofileairshipdiscorduserId), required: false);
            var __workflow_bodyprofileairshipexpotoken = WorkflowExpression.Compile(bodyprofileairshipexpotoken, nameof(bodyprofileairshipexpotoken), required: false);
            var __workflow_bodyprofileairshipexpotokens = WorkflowExpression.Compile(bodyprofileairshipexpotokens, nameof(bodyprofileairshipexpotokens), required: false);
            var __workflow_bodyprofileairshipfacebookPSId = WorkflowExpression.Compile(bodyprofileairshipfacebookPSId, nameof(bodyprofileairshipfacebookPSId), required: false);
            var __workflow_bodyprofileairshipfirebaseToken = WorkflowExpression.Compile(bodyprofileairshipfirebaseToken, nameof(bodyprofileairshipfirebaseToken), required: false);
            var __workflow_bodyprofileairshipintercomfrom = WorkflowExpression.Compile(bodyprofileairshipintercomfrom, nameof(bodyprofileairshipintercomfrom), required: false);
            var __workflow_bodyprofileairshipintercomtoid = WorkflowExpression.Compile(bodyprofileairshipintercomtoid, nameof(bodyprofileairshipintercomtoid), required: false);
            var __workflow_bodyprofileairshipmsTeamsuserId = WorkflowExpression.Compile(bodyprofileairshipmsTeamsuserId, nameof(bodyprofileairshipmsTeamsuserId), required: false);
            var __workflow_bodyprofileairshipmsTeamsconversationId = WorkflowExpression.Compile(bodyprofileairshipmsTeamsconversationId, nameof(bodyprofileairshipmsTeamsconversationId), required: false);
            var __workflow_bodyprofileairshipmsTeamstenantId = WorkflowExpression.Compile(bodyprofileairshipmsTeamstenantId, nameof(bodyprofileairshipmsTeamstenantId), required: false);
            var __workflow_bodyprofileairshipmsTeamsserviceUrl = WorkflowExpression.Compile(bodyprofileairshipmsTeamsserviceUrl, nameof(bodyprofileairshipmsTeamsserviceUrl), required: false);
            var __workflow_bodyprofileairshiponeSignalPlayerId = WorkflowExpression.Compile(bodyprofileairshiponeSignalPlayerId, nameof(bodyprofileairshiponeSignalPlayerId), required: false);
            var __workflow_bodyprofileairshipslackaccessToken = WorkflowExpression.Compile(bodyprofileairshipslackaccessToken, nameof(bodyprofileairshipslackaccessToken), required: false);
            var __workflow_bodyprofileairshipslackchannel = WorkflowExpression.Compile(bodyprofileairshipslackchannel, nameof(bodyprofileairshipslackchannel), required: false);
            var __workflow_bodyprofileairshipslackemail = WorkflowExpression.Compile(bodyprofileairshipslackemail, nameof(bodyprofileairshipslackemail), required: false);
            var __workflow_bodyprofileairshipslackuserId = WorkflowExpression.Compile(bodyprofileairshipslackuserId, nameof(bodyprofileairshipslackuserId), required: false);
            var __workflow_bodyprofileairshipslackincomingWebhookurl = WorkflowExpression.Compile(bodyprofileairshipslackincomingWebhookurl, nameof(bodyprofileairshipslackincomingWebhookurl), required: false);
            var __workflow_bodyprofileairshipwebhookurl = WorkflowExpression.Compile(bodyprofileairshipwebhookurl, nameof(bodyprofileairshipwebhookurl), required: false);
            var __workflow_bodyprofileairshipwebhookmethod = WorkflowExpression.Compile(bodyprofileairshipwebhookmethod, nameof(bodyprofileairshipwebhookmethod), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationmode = WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationmode, nameof(bodyprofileairshipwebhookauthenticationmode), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationusername = WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationusername, nameof(bodyprofileairshipwebhookauthenticationusername), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationpassword = WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationpassword, nameof(bodyprofileairshipwebhookauthenticationpassword), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationtoken = WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationtoken, nameof(bodyprofileairshipwebhookauthenticationtoken), required: false);
            var __workflow_bodyprofileairshipwebhookprofile = WorkflowExpression.Compile(bodyprofileairshipwebhookprofile, nameof(bodyprofileairshipwebhookprofile), required: false);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (__workflow_bodyprofileemail != null)
                {
                    profileObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyprofileemail);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilephoneNumber != null)
                {
                    profileObject["phone_number"] = ExpressionConverter.ConvertO(__workflow_bodyprofilephoneNumber);
                    profileObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (__workflow_bodyprofileaddressformatted != null)
                {
                    addressObject["formatted"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddressformatted);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyprofileaddressstreetAddress != null)
                {
                    addressObject["street_address"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddressstreetAddress);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyprofileaddresslocality != null)
                {
                    addressObject["locality"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddresslocality);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyprofileaddressregion != null)
                {
                    addressObject["region"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddressregion);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyprofileaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (__workflow_bodyprofileaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(__workflow_bodyprofileaddresscountry);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    profileObject["address"] = addressObject;
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilebirthdate != null)
                {
                    profileObject["birthdate"] = ExpressionConverter.ConvertO(__workflow_bodyprofilebirthdate);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofileemailVerified != null)
                {
                    profileObject["email_verified"] = ExpressionConverter.ConvertO(__workflow_bodyprofileemailVerified);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilephoneNumberVerified != null)
                {
                    profileObject["phone_number_verified"] = ExpressionConverter.ConvertO(__workflow_bodyprofilephoneNumberVerified);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilegivenName != null)
                {
                    profileObject["given_name"] = ExpressionConverter.ConvertO(__workflow_bodyprofilegivenName);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilemiddleName != null)
                {
                    profileObject["middle_name"] = ExpressionConverter.ConvertO(__workflow_bodyprofilemiddleName);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilefamilyName != null)
                {
                    profileObject["family_name"] = ExpressionConverter.ConvertO(__workflow_bodyprofilefamilyName);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilepreferredName != null)
                {
                    profileObject["preferred_name"] = ExpressionConverter.ConvertO(__workflow_bodyprofilepreferredName);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilegender != null)
                {
                    profileObject["gender"] = ExpressionConverter.ConvertO(__workflow_bodyprofilegender);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilelocale != null)
                {
                    profileObject["locale"] = ExpressionConverter.ConvertO(__workflow_bodyprofilelocale);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilepicture != null)
                {
                    profileObject["picture"] = ExpressionConverter.ConvertO(__workflow_bodyprofilepicture);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofileprofile != null)
                {
                    profileObject["profile"] = ExpressionConverter.ConvertO(__workflow_bodyprofileprofile);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilesub != null)
                {
                    profileObject["sub"] = ExpressionConverter.ConvertO(__workflow_bodyprofilesub);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofileupdatedAt != null)
                {
                    profileObject["updated_at"] = ExpressionConverter.ConvertO(__workflow_bodyprofileupdatedAt);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilewebsite != null)
                {
                    profileObject["website"] = ExpressionConverter.ConvertO(__workflow_bodyprofilewebsite);
                    profileObjectpropCount++;
                }

                if (__workflow_bodyprofilezoneinfo != null)
                {
                    profileObject["zoneinfo"] = ExpressionConverter.ConvertO(__workflow_bodyprofilezoneinfo);
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
                if (__workflow_bodyprofileairshipaudiencenamedUser != null)
                {
                    audienceObject["named_user"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipaudiencenamedUser);
                    audienceObjectpropCount++;
                }

                if (audienceObjectpropCount > 0)
                {
                    airshipObject["audience"] = audienceObject;
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipdeviceTypes != null)
                {
                    airshipObject["device_types"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipdeviceTypes);
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipapn != null)
                {
                    airshipObject["apn"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipapn);
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshiptargetArn != null)
                {
                    airshipObject["target_arn"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshiptargetArn);
                    airshipObjectpropCount++;
                }

                var discordObject = new JObject();
                var discordObjectpropCount = 0;
                if (__workflow_bodyprofileairshipdiscordchannelId != null)
                {
                    discordObject["channel_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipdiscordchannelId);
                    discordObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipdiscorduserId != null)
                {
                    discordObject["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipdiscorduserId);
                    discordObjectpropCount++;
                }

                if (discordObjectpropCount > 0)
                {
                    airshipObject["discord"] = discordObject;
                    airshipObjectpropCount++;
                }

                var expoObject = new JObject();
                var expoObjectpropCount = 0;
                if (__workflow_bodyprofileairshipexpotoken != null)
                {
                    expoObject["token"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipexpotoken);
                    expoObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipexpotokens != null)
                {
                    expoObject["tokens"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipexpotokens);
                    expoObjectpropCount++;
                }

                if (expoObjectpropCount > 0)
                {
                    airshipObject["expo"] = expoObject;
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipfacebookPSId != null)
                {
                    airshipObject["facebookPSID"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipfacebookPSId);
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipfirebaseToken != null)
                {
                    airshipObject["firebaseToken"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipfirebaseToken);
                    airshipObjectpropCount++;
                }

                var intercomObject = new JObject();
                var intercomObjectpropCount = 0;
                if (__workflow_bodyprofileairshipintercomfrom != null)
                {
                    intercomObject["from"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipintercomfrom);
                    intercomObjectpropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (__workflow_bodyprofileairshipintercomtoid != null)
                {
                    toObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipintercomtoid);
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
                if (__workflow_bodyprofileairshipmsTeamsuserId != null)
                {
                    msTeamsObject["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipmsTeamsuserId);
                    msTeamsObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipmsTeamsconversationId != null)
                {
                    msTeamsObject["conversation_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipmsTeamsconversationId);
                    msTeamsObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipmsTeamstenantId != null)
                {
                    msTeamsObject["tenant_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipmsTeamstenantId);
                    msTeamsObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipmsTeamsserviceUrl != null)
                {
                    msTeamsObject["service_url"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipmsTeamsserviceUrl);
                    msTeamsObjectpropCount++;
                }

                if (msTeamsObjectpropCount > 0)
                {
                    airshipObject["ms_teams"] = msTeamsObject;
                    airshipObjectpropCount++;
                }

                if (__workflow_bodyprofileairshiponeSignalPlayerId != null)
                {
                    airshipObject["oneSignalPlayerID"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshiponeSignalPlayerId);
                    airshipObjectpropCount++;
                }

                var slackObject = new JObject();
                var slackObjectpropCount = 0;
                if (__workflow_bodyprofileairshipslackaccessToken != null)
                {
                    slackObject["access_token"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipslackaccessToken);
                    slackObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipslackchannel != null)
                {
                    slackObject["channel"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipslackchannel);
                    slackObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipslackemail != null)
                {
                    slackObject["email"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipslackemail);
                    slackObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipslackuserId != null)
                {
                    slackObject["user_id"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipslackuserId);
                    slackObjectpropCount++;
                }

                var incomingWebhookObject = new JObject();
                var incomingWebhookObjectpropCount = 0;
                if (__workflow_bodyprofileairshipslackincomingWebhookurl != null)
                {
                    incomingWebhookObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipslackincomingWebhookurl);
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
                if (__workflow_bodyprofileairshipwebhookurl != null)
                {
                    webhookObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookurl);
                    webhookObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipwebhookmethod != null)
                {
                    webhookObject["method"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookmethod);
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
                if (__workflow_bodyprofileairshipwebhookauthenticationmode != null)
                {
                    authenticationObject["mode"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookauthenticationmode);
                    authenticationObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipwebhookauthenticationusername != null)
                {
                    authenticationObject["username"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookauthenticationusername);
                    authenticationObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipwebhookauthenticationpassword != null)
                {
                    authenticationObject["password"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookauthenticationpassword);
                    authenticationObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipwebhookauthenticationtoken != null)
                {
                    authenticationObject["token"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookauthenticationtoken);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    webhookObject["authentication"] = authenticationObject;
                    webhookObjectpropCount++;
                }

                if (__workflow_bodyprofileairshipwebhookprofile != null)
                {
                    webhookObject["profile"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipwebhookprofile);
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

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfilePatchResponse, ApiConnectionActionConfiguration> ProfilePatch(Expression<Func<string>> recipientId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_recipientId = WorkflowExpression.Compile(recipientId, nameof(recipientId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ProfilePatchResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}", __workflow_recipientId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ProfilePatchResponse>(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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