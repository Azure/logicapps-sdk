//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courierip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CourieripActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageSendPostResponse> MessageSend(Expression<Func<string>> idempotency, Expression<Func<string>> bodymessagecontenttitle = null, Expression<Func<string>> bodymessagecontentbody = null, Expression<Func<string>> bodymessagetouserId = null, Expression<Func<string>> bodymessagetolistId = null, Expression<Func<string>> bodymessagetoaudienceId = null, Expression<Func<string>> bodymessagetoemail = null, Expression<Func<string>> bodymessagetophoneNumber = null, Expression<Func<string>> bodymessagetolocale = null)
        {
            var __workflow_idempotency = idempotency == null ? null : WorkflowExpression.Compile(idempotency);
            WorkflowExpression.Validate(__workflow_idempotency, nameof(idempotency), required: true);
            var __workflow_bodymessagecontenttitle = bodymessagecontenttitle == null ? null : WorkflowExpression.Compile(bodymessagecontenttitle);
            WorkflowExpression.Validate(__workflow_bodymessagecontenttitle, nameof(bodymessagecontenttitle), required: false);
            var __workflow_bodymessagecontentbody = bodymessagecontentbody == null ? null : WorkflowExpression.Compile(bodymessagecontentbody);
            WorkflowExpression.Validate(__workflow_bodymessagecontentbody, nameof(bodymessagecontentbody), required: false);
            var __workflow_bodymessagetouserId = bodymessagetouserId == null ? null : WorkflowExpression.Compile(bodymessagetouserId);
            WorkflowExpression.Validate(__workflow_bodymessagetouserId, nameof(bodymessagetouserId), required: false);
            var __workflow_bodymessagetolistId = bodymessagetolistId == null ? null : WorkflowExpression.Compile(bodymessagetolistId);
            WorkflowExpression.Validate(__workflow_bodymessagetolistId, nameof(bodymessagetolistId), required: false);
            var __workflow_bodymessagetoaudienceId = bodymessagetoaudienceId == null ? null : WorkflowExpression.Compile(bodymessagetoaudienceId);
            WorkflowExpression.Validate(__workflow_bodymessagetoaudienceId, nameof(bodymessagetoaudienceId), required: false);
            var __workflow_bodymessagetoemail = bodymessagetoemail == null ? null : WorkflowExpression.Compile(bodymessagetoemail);
            WorkflowExpression.Validate(__workflow_bodymessagetoemail, nameof(bodymessagetoemail), required: false);
            var __workflow_bodymessagetophoneNumber = bodymessagetophoneNumber == null ? null : WorkflowExpression.Compile(bodymessagetophoneNumber);
            WorkflowExpression.Validate(__workflow_bodymessagetophoneNumber, nameof(bodymessagetophoneNumber), required: false);
            var __workflow_bodymessagetolocale = bodymessagetolocale == null ? null : WorkflowExpression.Compile(bodymessagetolocale);
            WorkflowExpression.Validate(__workflow_bodymessagetolocale, nameof(bodymessagetolocale), required: false);
            return new DeferredBodyAction<MessageSendPostResponse>(() =>
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
        public IBodyWorkflowAction<AudienceGetResponse> AudienceGet(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = audienceId == null ? null : WorkflowExpression.Compile(audienceId);
            WorkflowExpression.Validate(__workflow_audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<AudienceGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AudienceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> AudienceDelete(Expression<Func<string>> audienceId)
        {
            var __workflow_audienceId = audienceId == null ? null : WorkflowExpression.Compile(audienceId);
            WorkflowExpression.Validate(__workflow_audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_audienceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencePutResponse> AudiencePut(Expression<Func<string>> audienceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfilterpath = null, Expression<Func<string>> bodyfilterOperator = null, Expression<Func<string>> bodyfiltervalue = null, Expression<Func<bodyfilterfiltersInputItem[]>> bodyfilterfilters = null)
        {
            var __workflow_audienceId = audienceId == null ? null : WorkflowExpression.Compile(audienceId);
            WorkflowExpression.Validate(__workflow_audienceId, nameof(audienceId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfilterpath = bodyfilterpath == null ? null : WorkflowExpression.Compile(bodyfilterpath);
            WorkflowExpression.Validate(__workflow_bodyfilterpath, nameof(bodyfilterpath), required: false);
            var __workflow_bodyfilterOperator = bodyfilterOperator == null ? null : WorkflowExpression.Compile(bodyfilterOperator);
            WorkflowExpression.Validate(__workflow_bodyfilterOperator, nameof(bodyfilterOperator), required: false);
            var __workflow_bodyfiltervalue = bodyfiltervalue == null ? null : WorkflowExpression.Compile(bodyfiltervalue);
            WorkflowExpression.Validate(__workflow_bodyfiltervalue, nameof(bodyfiltervalue), required: false);
            var __workflow_bodyfilterfilters = bodyfilterfilters == null ? null : WorkflowExpression.Compile(bodyfilterfilters);
            WorkflowExpression.Validate(__workflow_bodyfilterfilters, nameof(bodyfilterfilters), required: false);
            return new DeferredBodyAction<AudiencePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_audienceId, 1));
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
        public IBodyWorkflowAction<AudienceMembersGetResponse> AudienceMembersGet(Expression<Func<string>> audienceId, Expression<Func<string>> cursor = null)
        {
            var __workflow_audienceId = audienceId == null ? null : WorkflowExpression.Compile(audienceId);
            WorkflowExpression.Validate(__workflow_audienceId, nameof(audienceId), required: true);
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudienceMembersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(__workflow_audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<AudienceMembersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencesGetResponse> AudiencesGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudiencesGetResponse>(() =>
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
        public IBodyWorkflowAction<AuditEventsGetResponse> AuditEventsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AuditEventsGetResponse>(() =>
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
        public IBodyWorkflowAction<AuditEventGetResponse> AuditEventGet(Expression<Func<string>> auditEventId)
        {
            var __workflow_auditEventId = auditEventId == null ? null : WorkflowExpression.Compile(auditEventId);
            WorkflowExpression.Validate(__workflow_auditEventId, nameof(auditEventId), required: true);
            return new DeferredBodyAction<AuditEventGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audit-events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_auditEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AuditEventGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse> AutomationTemplated(Expression<Func<string>> templateId, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
        {
            var __workflow_templateId = templateId == null ? null : WorkflowExpression.Compile(templateId);
            WorkflowExpression.Validate(__workflow_templateId, nameof(templateId), required: true);
            var __workflow_bodybrand = bodybrand == null ? null : WorkflowExpression.Compile(bodybrand);
            WorkflowExpression.Validate(__workflow_bodybrand, nameof(bodybrand), required: false);
            var __workflow_bodytemplate = bodytemplate == null ? null : WorkflowExpression.Compile(bodytemplate);
            WorkflowExpression.Validate(__workflow_bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodyrecipient = bodyrecipient == null ? null : WorkflowExpression.Compile(bodyrecipient);
            WorkflowExpression.Validate(__workflow_bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationTemplatedPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/automations/{0}/invoke", ExpressionConverter.ConvertWithUrlEncoding(__workflow_templateId, 1));
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
        public IBodyWorkflowAction<AutomationAdHocPostResponse> AutomationAdHoc(Expression<Func<JToken[]>> bodyautomationsteps = null, Expression<Func<string>> bodyautomationcancelationToken = null, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
        {
            var __workflow_bodyautomationsteps = bodyautomationsteps == null ? null : WorkflowExpression.Compile(bodyautomationsteps);
            WorkflowExpression.Validate(__workflow_bodyautomationsteps, nameof(bodyautomationsteps), required: false);
            var __workflow_bodyautomationcancelationToken = bodyautomationcancelationToken == null ? null : WorkflowExpression.Compile(bodyautomationcancelationToken);
            WorkflowExpression.Validate(__workflow_bodyautomationcancelationToken, nameof(bodyautomationcancelationToken), required: false);
            var __workflow_bodybrand = bodybrand == null ? null : WorkflowExpression.Compile(bodybrand);
            WorkflowExpression.Validate(__workflow_bodybrand, nameof(bodybrand), required: false);
            var __workflow_bodytemplate = bodytemplate == null ? null : WorkflowExpression.Compile(bodytemplate);
            WorkflowExpression.Validate(__workflow_bodytemplate, nameof(bodytemplate), required: false);
            var __workflow_bodyrecipient = bodyrecipient == null ? null : WorkflowExpression.Compile(bodyrecipient);
            WorkflowExpression.Validate(__workflow_bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationAdHocPostResponse>(() =>
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
        public IBodyWorkflowAction<BrandsGetResponse> BrandsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<BrandsGetResponse>(() =>
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
        public IBodyWorkflowAction<string> Brand(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodysettingscolorsprimary = null, Expression<Func<string>> bodysettingscolorssecondary = null, Expression<Func<string>> bodysettingscolorstertiary = null, Expression<Func<string>> bodysettingsemailheaderbarColor = null, Expression<Func<string>> bodysettingsemailheaderlogohref = null, Expression<Func<string>> bodysettingsemailheaderlogoimage = null, Expression<Func<string>> bodysettingsemailfootermarkdown = null, Expression<Func<string>> bodysettingsemailfootersocialfacebookurl = null, Expression<Func<string>> bodysettingsemailfootersocialinstagramurl = null, Expression<Func<string>> bodysettingsemailfootersociallinkedinurl = null, Expression<Func<string>> bodysettingsemailfootersocialmediumurl = null, Expression<Func<string>> bodysettingsemailfootersocialtwitterurl = null, Expression<Func<bool>> bodysettingsinappdisableMessageIcon = null, Expression<Func<string>> bodysettingsinappplacement = null, Expression<Func<string[]>> bodysnippetsitems = null)
        {
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodyid = bodyid == null ? null : WorkflowExpression.Compile(bodyid);
            WorkflowExpression.Validate(__workflow_bodyid, nameof(bodyid), required: false);
            var __workflow_bodysettingscolorsprimary = bodysettingscolorsprimary == null ? null : WorkflowExpression.Compile(bodysettingscolorsprimary);
            WorkflowExpression.Validate(__workflow_bodysettingscolorsprimary, nameof(bodysettingscolorsprimary), required: false);
            var __workflow_bodysettingscolorssecondary = bodysettingscolorssecondary == null ? null : WorkflowExpression.Compile(bodysettingscolorssecondary);
            WorkflowExpression.Validate(__workflow_bodysettingscolorssecondary, nameof(bodysettingscolorssecondary), required: false);
            var __workflow_bodysettingscolorstertiary = bodysettingscolorstertiary == null ? null : WorkflowExpression.Compile(bodysettingscolorstertiary);
            WorkflowExpression.Validate(__workflow_bodysettingscolorstertiary, nameof(bodysettingscolorstertiary), required: false);
            var __workflow_bodysettingsemailheaderbarColor = bodysettingsemailheaderbarColor == null ? null : WorkflowExpression.Compile(bodysettingsemailheaderbarColor);
            WorkflowExpression.Validate(__workflow_bodysettingsemailheaderbarColor, nameof(bodysettingsemailheaderbarColor), required: false);
            var __workflow_bodysettingsemailheaderlogohref = bodysettingsemailheaderlogohref == null ? null : WorkflowExpression.Compile(bodysettingsemailheaderlogohref);
            WorkflowExpression.Validate(__workflow_bodysettingsemailheaderlogohref, nameof(bodysettingsemailheaderlogohref), required: false);
            var __workflow_bodysettingsemailheaderlogoimage = bodysettingsemailheaderlogoimage == null ? null : WorkflowExpression.Compile(bodysettingsemailheaderlogoimage);
            WorkflowExpression.Validate(__workflow_bodysettingsemailheaderlogoimage, nameof(bodysettingsemailheaderlogoimage), required: false);
            var __workflow_bodysettingsemailfootermarkdown = bodysettingsemailfootermarkdown == null ? null : WorkflowExpression.Compile(bodysettingsemailfootermarkdown);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootermarkdown, nameof(bodysettingsemailfootermarkdown), required: false);
            var __workflow_bodysettingsemailfootersocialfacebookurl = bodysettingsemailfootersocialfacebookurl == null ? null : WorkflowExpression.Compile(bodysettingsemailfootersocialfacebookurl);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootersocialfacebookurl, nameof(bodysettingsemailfootersocialfacebookurl), required: false);
            var __workflow_bodysettingsemailfootersocialinstagramurl = bodysettingsemailfootersocialinstagramurl == null ? null : WorkflowExpression.Compile(bodysettingsemailfootersocialinstagramurl);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootersocialinstagramurl, nameof(bodysettingsemailfootersocialinstagramurl), required: false);
            var __workflow_bodysettingsemailfootersociallinkedinurl = bodysettingsemailfootersociallinkedinurl == null ? null : WorkflowExpression.Compile(bodysettingsemailfootersociallinkedinurl);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootersociallinkedinurl, nameof(bodysettingsemailfootersociallinkedinurl), required: false);
            var __workflow_bodysettingsemailfootersocialmediumurl = bodysettingsemailfootersocialmediumurl == null ? null : WorkflowExpression.Compile(bodysettingsemailfootersocialmediumurl);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootersocialmediumurl, nameof(bodysettingsemailfootersocialmediumurl), required: false);
            var __workflow_bodysettingsemailfootersocialtwitterurl = bodysettingsemailfootersocialtwitterurl == null ? null : WorkflowExpression.Compile(bodysettingsemailfootersocialtwitterurl);
            WorkflowExpression.Validate(__workflow_bodysettingsemailfootersocialtwitterurl, nameof(bodysettingsemailfootersocialtwitterurl), required: false);
            var __workflow_bodysettingsinappdisableMessageIcon = bodysettingsinappdisableMessageIcon == null ? null : WorkflowExpression.Compile(bodysettingsinappdisableMessageIcon);
            WorkflowExpression.Validate(__workflow_bodysettingsinappdisableMessageIcon, nameof(bodysettingsinappdisableMessageIcon), required: false);
            var __workflow_bodysettingsinappplacement = bodysettingsinappplacement == null ? null : WorkflowExpression.Compile(bodysettingsinappplacement);
            WorkflowExpression.Validate(__workflow_bodysettingsinappplacement, nameof(bodysettingsinappplacement), required: false);
            var __workflow_bodysnippetsitems = bodysnippetsitems == null ? null : WorkflowExpression.Compile(bodysnippetsitems);
            WorkflowExpression.Validate(__workflow_bodysnippetsitems, nameof(bodysnippetsitems), required: false);
            return new DeferredBodyAction<string>(() =>
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
        public IBodyWorkflowAction<BrandGetResponse> BrandGet(Expression<Func<string>> brandId)
        {
            var __workflow_brandId = brandId == null ? null : WorkflowExpression.Compile(brandId);
            WorkflowExpression.Validate(__workflow_brandId, nameof(brandId), required: true);
            return new DeferredBodyAction<BrandGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/brands/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_brandId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BrandGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobPostResponse> BulkJob(Expression<Func<string>> bodymessageEvent = null, Expression<Func<string>> bodymessagebrand = null, Expression<Func<string>> bodymessagetemplate = null, Expression<Func<string>> bodymessagebrandId = null, Expression<Func<string>> bodymessageroutingmethod = null, Expression<Func<string[]>> bodymessageroutingchannels = null, Expression<Func<string>> bodymessagemetadataEvent = null, Expression<Func<string[]>> bodymessagemetadatatags = null, Expression<Func<string>> bodymessagemetadatatraceId = null, Expression<Func<string>> bodymessagemetadatautmcampaign = null, Expression<Func<string>> bodymessagemetadatautmcontent = null, Expression<Func<string>> bodymessagemetadatautmmedium = null, Expression<Func<string>> bodymessagemetadatautmsource = null, Expression<Func<string>> bodymessagemetadatautmterm = null)
        {
            var __workflow_bodymessageEvent = bodymessageEvent == null ? null : WorkflowExpression.Compile(bodymessageEvent);
            WorkflowExpression.Validate(__workflow_bodymessageEvent, nameof(bodymessageEvent), required: false);
            var __workflow_bodymessagebrand = bodymessagebrand == null ? null : WorkflowExpression.Compile(bodymessagebrand);
            WorkflowExpression.Validate(__workflow_bodymessagebrand, nameof(bodymessagebrand), required: false);
            var __workflow_bodymessagetemplate = bodymessagetemplate == null ? null : WorkflowExpression.Compile(bodymessagetemplate);
            WorkflowExpression.Validate(__workflow_bodymessagetemplate, nameof(bodymessagetemplate), required: false);
            var __workflow_bodymessagebrandId = bodymessagebrandId == null ? null : WorkflowExpression.Compile(bodymessagebrandId);
            WorkflowExpression.Validate(__workflow_bodymessagebrandId, nameof(bodymessagebrandId), required: false);
            var __workflow_bodymessageroutingmethod = bodymessageroutingmethod == null ? null : WorkflowExpression.Compile(bodymessageroutingmethod);
            WorkflowExpression.Validate(__workflow_bodymessageroutingmethod, nameof(bodymessageroutingmethod), required: false);
            var __workflow_bodymessageroutingchannels = bodymessageroutingchannels == null ? null : WorkflowExpression.Compile(bodymessageroutingchannels);
            WorkflowExpression.Validate(__workflow_bodymessageroutingchannels, nameof(bodymessageroutingchannels), required: false);
            var __workflow_bodymessagemetadataEvent = bodymessagemetadataEvent == null ? null : WorkflowExpression.Compile(bodymessagemetadataEvent);
            WorkflowExpression.Validate(__workflow_bodymessagemetadataEvent, nameof(bodymessagemetadataEvent), required: false);
            var __workflow_bodymessagemetadatatags = bodymessagemetadatatags == null ? null : WorkflowExpression.Compile(bodymessagemetadatatags);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatatags, nameof(bodymessagemetadatatags), required: false);
            var __workflow_bodymessagemetadatatraceId = bodymessagemetadatatraceId == null ? null : WorkflowExpression.Compile(bodymessagemetadatatraceId);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatatraceId, nameof(bodymessagemetadatatraceId), required: false);
            var __workflow_bodymessagemetadatautmcampaign = bodymessagemetadatautmcampaign == null ? null : WorkflowExpression.Compile(bodymessagemetadatautmcampaign);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatautmcampaign, nameof(bodymessagemetadatautmcampaign), required: false);
            var __workflow_bodymessagemetadatautmcontent = bodymessagemetadatautmcontent == null ? null : WorkflowExpression.Compile(bodymessagemetadatautmcontent);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatautmcontent, nameof(bodymessagemetadatautmcontent), required: false);
            var __workflow_bodymessagemetadatautmmedium = bodymessagemetadatautmmedium == null ? null : WorkflowExpression.Compile(bodymessagemetadatautmmedium);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatautmmedium, nameof(bodymessagemetadatautmmedium), required: false);
            var __workflow_bodymessagemetadatautmsource = bodymessagemetadatautmsource == null ? null : WorkflowExpression.Compile(bodymessagemetadatautmsource);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatautmsource, nameof(bodymessagemetadatautmsource), required: false);
            var __workflow_bodymessagemetadatautmterm = bodymessagemetadatautmterm == null ? null : WorkflowExpression.Compile(bodymessagemetadatautmterm);
            WorkflowExpression.Validate(__workflow_bodymessagemetadatautmterm, nameof(bodymessagemetadatautmterm), required: false);
            return new DeferredBodyAction<BulkJobPostResponse>(() =>
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

                var overrideObject = new JObject();
                var overrideObjectpropCount = 0;
                if (overrideObjectpropCount > 0)
                {
                    messageObject["override"] = overrideObject;
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
        public IBodyWorkflowAction<BulkJobGetResponse> BulkJobGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> BulkJobUsers(Expression<Func<string>> jobId, Expression<Func<bodyusersInputItem[]>> bodyusers = null)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            var __workflow_bodyusers = bodyusers == null ? null : WorkflowExpression.Compile(bodyusers);
            WorkflowExpression.Validate(__workflow_bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
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
        public IBodyWorkflowAction<JToken> BulkJobRun(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobUsersGetResponse> BulkJobUsersGet(Expression<Func<string>> jobId)
        {
            var __workflow_jobId = jobId == null ? null : WorkflowExpression.Compile(jobId);
            WorkflowExpression.Validate(__workflow_jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobUsersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(__workflow_jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobUsersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListsGetResponse> ListsGet()
        {
            var apiCallPath = "/lists";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListGetResponse> ListGet(Expression<Func<string>> listId)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            return new DeferredBodyAction<ListGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListDelete(Expression<Func<string>> listId)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListPut(Expression<Func<string>> listId, Expression<Func<string>> bodyname = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
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
        public IBodyWorkflowAction<string> ListRestorePut(Expression<Func<string>> listId)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse> ListSubscriptionsGet(Expression<Func<string>> listId, Expression<Func<string>> cursor = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<ListSubscriptionsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(__workflow_cursor);
                return new ApiConnectionAction<ListSubscriptionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListSubscribers(Expression<Func<string>> listId, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients = null)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_bodyrecipients = bodyrecipients == null ? null : WorkflowExpression.Compile(bodyrecipients);
            WorkflowExpression.Validate(__workflow_bodyrecipients, nameof(bodyrecipients), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1));
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
        public IBodyWorkflowAction<string> ListSubscribeDelete(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var __workflow_listId = listId == null ? null : WorkflowExpression.Compile(listId);
            WorkflowExpression.Validate(__workflow_listId, nameof(listId), required: true);
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_listId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet(Expression<Func<bool>> archived = null, Expression<Func<string>> cursor = null, Expression<Func<string>> @event = null, Expression<Func<string>> list = null, Expression<Func<string>> messageId = null, Expression<Func<string>> notification = null, Expression<Func<string>> recipient = null, Expression<Func<string>> status = null, Expression<Func<string>> tags = null)
        {
            var __workflow_archived = archived == null ? null : WorkflowExpression.Compile(archived);
            WorkflowExpression.Validate(__workflow_archived, nameof(archived), required: false);
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            var __workflow_event = @event == null ? null : WorkflowExpression.Compile(@event);
            WorkflowExpression.Validate(__workflow_event, nameof(@event), required: false);
            var __workflow_list = list == null ? null : WorkflowExpression.Compile(list);
            WorkflowExpression.Validate(__workflow_list, nameof(list), required: false);
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: false);
            var __workflow_notification = notification == null ? null : WorkflowExpression.Compile(notification);
            WorkflowExpression.Validate(__workflow_notification, nameof(notification), required: false);
            var __workflow_recipient = recipient == null ? null : WorkflowExpression.Compile(recipient);
            WorkflowExpression.Validate(__workflow_recipient, nameof(recipient), required: false);
            var __workflow_status = status == null ? null : WorkflowExpression.Compile(status);
            WorkflowExpression.Validate(__workflow_status, nameof(status), required: false);
            var __workflow_tags = tags == null ? null : WorkflowExpression.Compile(tags);
            WorkflowExpression.Validate(__workflow_tags, nameof(tags), required: false);
            return new DeferredBodyAction<MessagesGetResponse>(() =>
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
        public IBodyWorkflowAction<MessageGetResponse> MessageGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageHistoryGetResponse> MessageHistoryGet(Expression<Func<string>> messageId, Expression<Func<string>> type = null)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            var __workflow_type = type == null ? null : WorkflowExpression.Compile(type);
            WorkflowExpression.Validate(__workflow_type, nameof(type), required: false);
            return new DeferredBodyAction<MessageHistoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(__workflow_type);
                return new ApiConnectionAction<MessageHistoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageContentGetResponse> MessageContentGet(Expression<Func<string>> messageId)
        {
            var __workflow_messageId = messageId == null ? null : WorkflowExpression.Compile(messageId);
            WorkflowExpression.Validate(__workflow_messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageContentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}/output", ExpressionConverter.ConvertWithUrlEncoding(__workflow_messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageContentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> MessagePut(Expression<Func<string>> requestId)
        {
            var __workflow_requestId = requestId == null ? null : WorkflowExpression.Compile(requestId);
            WorkflowExpression.Validate(__workflow_requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/archive", ExpressionConverter.ConvertWithUrlEncoding(__workflow_requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<NotificationsGetResponse> NotificationsGet(Expression<Func<string>> cursor = null)
        {
            var __workflow_cursor = cursor == null ? null : WorkflowExpression.Compile(cursor);
            WorkflowExpression.Validate(__workflow_cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<NotificationsGetResponse>(() =>
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
        public IBodyWorkflowAction<ProfileGetResponse> ProfileGet(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileDeleteResponse> ProfileDelete(Expression<Func<string>> recipientId)
        {
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> Profile(Expression<Func<string>> recipientId, Expression<Func<string>> bodyprofileemail = null, Expression<Func<string>> bodyprofilephoneNumber = null, Expression<Func<string>> bodyprofileaddressformatted = null, Expression<Func<string>> bodyprofileaddressstreetAddress = null, Expression<Func<string>> bodyprofileaddresslocality = null, Expression<Func<string>> bodyprofileaddressregion = null, Expression<Func<string>> bodyprofileaddresspostalCode = null, Expression<Func<string>> bodyprofileaddresscountry = null, Expression<Func<string>> bodyprofilebirthdate = null, Expression<Func<bool>> bodyprofileemailVerified = null, Expression<Func<bool>> bodyprofilephoneNumberVerified = null, Expression<Func<string>> bodyprofilegivenName = null, Expression<Func<string>> bodyprofilemiddleName = null, Expression<Func<string>> bodyprofilefamilyName = null, Expression<Func<string>> bodyprofilepreferredName = null, Expression<Func<string>> bodyprofilegender = null, Expression<Func<string>> bodyprofilelocale = null, Expression<Func<string>> bodyprofilepicture = null, Expression<Func<string>> bodyprofileprofile = null, Expression<Func<string>> bodyprofilesub = null, Expression<Func<string>> bodyprofileupdatedAt = null, Expression<Func<string>> bodyprofilewebsite = null, Expression<Func<string>> bodyprofilezoneinfo = null, Expression<Func<string>> bodyprofileairshipaudiencenamedUser = null, Expression<Func<string[]>> bodyprofileairshipdeviceTypes = null, Expression<Func<string>> bodyprofileairshipapn = null, Expression<Func<string>> bodyprofileairshiptargetArn = null, Expression<Func<string>> bodyprofileairshipdiscordchannelId = null, Expression<Func<string>> bodyprofileairshipdiscorduserId = null, Expression<Func<string>> bodyprofileairshipexpotoken = null, Expression<Func<string[]>> bodyprofileairshipexpotokens = null, Expression<Func<string>> bodyprofileairshipfacebookPSID = null, Expression<Func<string>> bodyprofileairshipfirebaseToken = null, Expression<Func<string>> bodyprofileairshipintercomfrom = null, Expression<Func<string>> bodyprofileairshipintercomtoid = null, Expression<Func<string>> bodyprofileairshipmsTeamsuserId = null, Expression<Func<string>> bodyprofileairshipmsTeamsconversationId = null, Expression<Func<string>> bodyprofileairshipmsTeamstenantId = null, Expression<Func<string>> bodyprofileairshipmsTeamsserviceUrl = null, Expression<Func<string>> bodyprofileairshiponeSignalPlayerID = null, Expression<Func<string>> bodyprofileairshipslackaccessToken = null, Expression<Func<string>> bodyprofileairshipslackchannel = null, Expression<Func<string>> bodyprofileairshipslackemail = null, Expression<Func<string>> bodyprofileairshipslackuserId = null, Expression<Func<string>> bodyprofileairshipslackincomingWebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookmethod = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationmode = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationusername = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationpassword = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationtoken = null, Expression<Func<string>> bodyprofileairshipwebhookprofile = null)
        {
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            var __workflow_bodyprofileemail = bodyprofileemail == null ? null : WorkflowExpression.Compile(bodyprofileemail);
            WorkflowExpression.Validate(__workflow_bodyprofileemail, nameof(bodyprofileemail), required: false);
            var __workflow_bodyprofilephoneNumber = bodyprofilephoneNumber == null ? null : WorkflowExpression.Compile(bodyprofilephoneNumber);
            WorkflowExpression.Validate(__workflow_bodyprofilephoneNumber, nameof(bodyprofilephoneNumber), required: false);
            var __workflow_bodyprofileaddressformatted = bodyprofileaddressformatted == null ? null : WorkflowExpression.Compile(bodyprofileaddressformatted);
            WorkflowExpression.Validate(__workflow_bodyprofileaddressformatted, nameof(bodyprofileaddressformatted), required: false);
            var __workflow_bodyprofileaddressstreetAddress = bodyprofileaddressstreetAddress == null ? null : WorkflowExpression.Compile(bodyprofileaddressstreetAddress);
            WorkflowExpression.Validate(__workflow_bodyprofileaddressstreetAddress, nameof(bodyprofileaddressstreetAddress), required: false);
            var __workflow_bodyprofileaddresslocality = bodyprofileaddresslocality == null ? null : WorkflowExpression.Compile(bodyprofileaddresslocality);
            WorkflowExpression.Validate(__workflow_bodyprofileaddresslocality, nameof(bodyprofileaddresslocality), required: false);
            var __workflow_bodyprofileaddressregion = bodyprofileaddressregion == null ? null : WorkflowExpression.Compile(bodyprofileaddressregion);
            WorkflowExpression.Validate(__workflow_bodyprofileaddressregion, nameof(bodyprofileaddressregion), required: false);
            var __workflow_bodyprofileaddresspostalCode = bodyprofileaddresspostalCode == null ? null : WorkflowExpression.Compile(bodyprofileaddresspostalCode);
            WorkflowExpression.Validate(__workflow_bodyprofileaddresspostalCode, nameof(bodyprofileaddresspostalCode), required: false);
            var __workflow_bodyprofileaddresscountry = bodyprofileaddresscountry == null ? null : WorkflowExpression.Compile(bodyprofileaddresscountry);
            WorkflowExpression.Validate(__workflow_bodyprofileaddresscountry, nameof(bodyprofileaddresscountry), required: false);
            var __workflow_bodyprofilebirthdate = bodyprofilebirthdate == null ? null : WorkflowExpression.Compile(bodyprofilebirthdate);
            WorkflowExpression.Validate(__workflow_bodyprofilebirthdate, nameof(bodyprofilebirthdate), required: false);
            var __workflow_bodyprofileemailVerified = bodyprofileemailVerified == null ? null : WorkflowExpression.Compile(bodyprofileemailVerified);
            WorkflowExpression.Validate(__workflow_bodyprofileemailVerified, nameof(bodyprofileemailVerified), required: false);
            var __workflow_bodyprofilephoneNumberVerified = bodyprofilephoneNumberVerified == null ? null : WorkflowExpression.Compile(bodyprofilephoneNumberVerified);
            WorkflowExpression.Validate(__workflow_bodyprofilephoneNumberVerified, nameof(bodyprofilephoneNumberVerified), required: false);
            var __workflow_bodyprofilegivenName = bodyprofilegivenName == null ? null : WorkflowExpression.Compile(bodyprofilegivenName);
            WorkflowExpression.Validate(__workflow_bodyprofilegivenName, nameof(bodyprofilegivenName), required: false);
            var __workflow_bodyprofilemiddleName = bodyprofilemiddleName == null ? null : WorkflowExpression.Compile(bodyprofilemiddleName);
            WorkflowExpression.Validate(__workflow_bodyprofilemiddleName, nameof(bodyprofilemiddleName), required: false);
            var __workflow_bodyprofilefamilyName = bodyprofilefamilyName == null ? null : WorkflowExpression.Compile(bodyprofilefamilyName);
            WorkflowExpression.Validate(__workflow_bodyprofilefamilyName, nameof(bodyprofilefamilyName), required: false);
            var __workflow_bodyprofilepreferredName = bodyprofilepreferredName == null ? null : WorkflowExpression.Compile(bodyprofilepreferredName);
            WorkflowExpression.Validate(__workflow_bodyprofilepreferredName, nameof(bodyprofilepreferredName), required: false);
            var __workflow_bodyprofilegender = bodyprofilegender == null ? null : WorkflowExpression.Compile(bodyprofilegender);
            WorkflowExpression.Validate(__workflow_bodyprofilegender, nameof(bodyprofilegender), required: false);
            var __workflow_bodyprofilelocale = bodyprofilelocale == null ? null : WorkflowExpression.Compile(bodyprofilelocale);
            WorkflowExpression.Validate(__workflow_bodyprofilelocale, nameof(bodyprofilelocale), required: false);
            var __workflow_bodyprofilepicture = bodyprofilepicture == null ? null : WorkflowExpression.Compile(bodyprofilepicture);
            WorkflowExpression.Validate(__workflow_bodyprofilepicture, nameof(bodyprofilepicture), required: false);
            var __workflow_bodyprofileprofile = bodyprofileprofile == null ? null : WorkflowExpression.Compile(bodyprofileprofile);
            WorkflowExpression.Validate(__workflow_bodyprofileprofile, nameof(bodyprofileprofile), required: false);
            var __workflow_bodyprofilesub = bodyprofilesub == null ? null : WorkflowExpression.Compile(bodyprofilesub);
            WorkflowExpression.Validate(__workflow_bodyprofilesub, nameof(bodyprofilesub), required: false);
            var __workflow_bodyprofileupdatedAt = bodyprofileupdatedAt == null ? null : WorkflowExpression.Compile(bodyprofileupdatedAt);
            WorkflowExpression.Validate(__workflow_bodyprofileupdatedAt, nameof(bodyprofileupdatedAt), required: false);
            var __workflow_bodyprofilewebsite = bodyprofilewebsite == null ? null : WorkflowExpression.Compile(bodyprofilewebsite);
            WorkflowExpression.Validate(__workflow_bodyprofilewebsite, nameof(bodyprofilewebsite), required: false);
            var __workflow_bodyprofilezoneinfo = bodyprofilezoneinfo == null ? null : WorkflowExpression.Compile(bodyprofilezoneinfo);
            WorkflowExpression.Validate(__workflow_bodyprofilezoneinfo, nameof(bodyprofilezoneinfo), required: false);
            var __workflow_bodyprofileairshipaudiencenamedUser = bodyprofileairshipaudiencenamedUser == null ? null : WorkflowExpression.Compile(bodyprofileairshipaudiencenamedUser);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipaudiencenamedUser, nameof(bodyprofileairshipaudiencenamedUser), required: false);
            var __workflow_bodyprofileairshipdeviceTypes = bodyprofileairshipdeviceTypes == null ? null : WorkflowExpression.Compile(bodyprofileairshipdeviceTypes);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipdeviceTypes, nameof(bodyprofileairshipdeviceTypes), required: false);
            var __workflow_bodyprofileairshipapn = bodyprofileairshipapn == null ? null : WorkflowExpression.Compile(bodyprofileairshipapn);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipapn, nameof(bodyprofileairshipapn), required: false);
            var __workflow_bodyprofileairshiptargetArn = bodyprofileairshiptargetArn == null ? null : WorkflowExpression.Compile(bodyprofileairshiptargetArn);
            WorkflowExpression.Validate(__workflow_bodyprofileairshiptargetArn, nameof(bodyprofileairshiptargetArn), required: false);
            var __workflow_bodyprofileairshipdiscordchannelId = bodyprofileairshipdiscordchannelId == null ? null : WorkflowExpression.Compile(bodyprofileairshipdiscordchannelId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipdiscordchannelId, nameof(bodyprofileairshipdiscordchannelId), required: false);
            var __workflow_bodyprofileairshipdiscorduserId = bodyprofileairshipdiscorduserId == null ? null : WorkflowExpression.Compile(bodyprofileairshipdiscorduserId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipdiscorduserId, nameof(bodyprofileairshipdiscorduserId), required: false);
            var __workflow_bodyprofileairshipexpotoken = bodyprofileairshipexpotoken == null ? null : WorkflowExpression.Compile(bodyprofileairshipexpotoken);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipexpotoken, nameof(bodyprofileairshipexpotoken), required: false);
            var __workflow_bodyprofileairshipexpotokens = bodyprofileairshipexpotokens == null ? null : WorkflowExpression.Compile(bodyprofileairshipexpotokens);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipexpotokens, nameof(bodyprofileairshipexpotokens), required: false);
            var __workflow_bodyprofileairshipfacebookPSID = bodyprofileairshipfacebookPSID == null ? null : WorkflowExpression.Compile(bodyprofileairshipfacebookPSID);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipfacebookPSID, nameof(bodyprofileairshipfacebookPSID), required: false);
            var __workflow_bodyprofileairshipfirebaseToken = bodyprofileairshipfirebaseToken == null ? null : WorkflowExpression.Compile(bodyprofileairshipfirebaseToken);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipfirebaseToken, nameof(bodyprofileairshipfirebaseToken), required: false);
            var __workflow_bodyprofileairshipintercomfrom = bodyprofileairshipintercomfrom == null ? null : WorkflowExpression.Compile(bodyprofileairshipintercomfrom);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipintercomfrom, nameof(bodyprofileairshipintercomfrom), required: false);
            var __workflow_bodyprofileairshipintercomtoid = bodyprofileairshipintercomtoid == null ? null : WorkflowExpression.Compile(bodyprofileairshipintercomtoid);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipintercomtoid, nameof(bodyprofileairshipintercomtoid), required: false);
            var __workflow_bodyprofileairshipmsTeamsuserId = bodyprofileairshipmsTeamsuserId == null ? null : WorkflowExpression.Compile(bodyprofileairshipmsTeamsuserId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipmsTeamsuserId, nameof(bodyprofileairshipmsTeamsuserId), required: false);
            var __workflow_bodyprofileairshipmsTeamsconversationId = bodyprofileairshipmsTeamsconversationId == null ? null : WorkflowExpression.Compile(bodyprofileairshipmsTeamsconversationId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipmsTeamsconversationId, nameof(bodyprofileairshipmsTeamsconversationId), required: false);
            var __workflow_bodyprofileairshipmsTeamstenantId = bodyprofileairshipmsTeamstenantId == null ? null : WorkflowExpression.Compile(bodyprofileairshipmsTeamstenantId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipmsTeamstenantId, nameof(bodyprofileairshipmsTeamstenantId), required: false);
            var __workflow_bodyprofileairshipmsTeamsserviceUrl = bodyprofileairshipmsTeamsserviceUrl == null ? null : WorkflowExpression.Compile(bodyprofileairshipmsTeamsserviceUrl);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipmsTeamsserviceUrl, nameof(bodyprofileairshipmsTeamsserviceUrl), required: false);
            var __workflow_bodyprofileairshiponeSignalPlayerID = bodyprofileairshiponeSignalPlayerID == null ? null : WorkflowExpression.Compile(bodyprofileairshiponeSignalPlayerID);
            WorkflowExpression.Validate(__workflow_bodyprofileairshiponeSignalPlayerID, nameof(bodyprofileairshiponeSignalPlayerID), required: false);
            var __workflow_bodyprofileairshipslackaccessToken = bodyprofileairshipslackaccessToken == null ? null : WorkflowExpression.Compile(bodyprofileairshipslackaccessToken);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipslackaccessToken, nameof(bodyprofileairshipslackaccessToken), required: false);
            var __workflow_bodyprofileairshipslackchannel = bodyprofileairshipslackchannel == null ? null : WorkflowExpression.Compile(bodyprofileairshipslackchannel);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipslackchannel, nameof(bodyprofileairshipslackchannel), required: false);
            var __workflow_bodyprofileairshipslackemail = bodyprofileairshipslackemail == null ? null : WorkflowExpression.Compile(bodyprofileairshipslackemail);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipslackemail, nameof(bodyprofileairshipslackemail), required: false);
            var __workflow_bodyprofileairshipslackuserId = bodyprofileairshipslackuserId == null ? null : WorkflowExpression.Compile(bodyprofileairshipslackuserId);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipslackuserId, nameof(bodyprofileairshipslackuserId), required: false);
            var __workflow_bodyprofileairshipslackincomingWebhookurl = bodyprofileairshipslackincomingWebhookurl == null ? null : WorkflowExpression.Compile(bodyprofileairshipslackincomingWebhookurl);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipslackincomingWebhookurl, nameof(bodyprofileairshipslackincomingWebhookurl), required: false);
            var __workflow_bodyprofileairshipwebhookurl = bodyprofileairshipwebhookurl == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookurl);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookurl, nameof(bodyprofileairshipwebhookurl), required: false);
            var __workflow_bodyprofileairshipwebhookmethod = bodyprofileairshipwebhookmethod == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookmethod);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookmethod, nameof(bodyprofileairshipwebhookmethod), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationmode = bodyprofileairshipwebhookauthenticationmode == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationmode);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookauthenticationmode, nameof(bodyprofileairshipwebhookauthenticationmode), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationusername = bodyprofileairshipwebhookauthenticationusername == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationusername);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookauthenticationusername, nameof(bodyprofileairshipwebhookauthenticationusername), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationpassword = bodyprofileairshipwebhookauthenticationpassword == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationpassword);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookauthenticationpassword, nameof(bodyprofileairshipwebhookauthenticationpassword), required: false);
            var __workflow_bodyprofileairshipwebhookauthenticationtoken = bodyprofileairshipwebhookauthenticationtoken == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookauthenticationtoken);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookauthenticationtoken, nameof(bodyprofileairshipwebhookauthenticationtoken), required: false);
            var __workflow_bodyprofileairshipwebhookprofile = bodyprofileairshipwebhookprofile == null ? null : WorkflowExpression.Compile(bodyprofileairshipwebhookprofile);
            WorkflowExpression.Validate(__workflow_bodyprofileairshipwebhookprofile, nameof(bodyprofileairshipwebhookprofile), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
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

                if (__workflow_bodyprofileairshipfacebookPSID != null)
                {
                    airshipObject["facebookPSID"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshipfacebookPSID);
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

                if (__workflow_bodyprofileairshiponeSignalPlayerID != null)
                {
                    airshipObject["oneSignalPlayerID"] = ExpressionConverter.ConvertO(__workflow_bodyprofileairshiponeSignalPlayerID);
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
        public IBodyWorkflowAction<ProfilePatchResponse> ProfilePatch(Expression<Func<string>> recipientId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_recipientId = recipientId == null ? null : WorkflowExpression.Compile(recipientId);
            WorkflowExpression.Validate(__workflow_recipientId, nameof(recipientId), required: true);
            var __workflow_body = body == null ? null : WorkflowExpression.Compile(body);
            WorkflowExpression.Validate(__workflow_body, nameof(body), required: false);
            return new DeferredBodyAction<ProfilePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recipientId, 1));
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
