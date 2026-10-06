//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Courierip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CourieripActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessageSend))]
        public IBodyWorkflowAction<MessageSendPostResponse> MessageSend([WorkflowExpression] Func<string> idempotency, [WorkflowExpression] Func<string> bodymessagecontenttitle = null, [WorkflowExpression] Func<string> bodymessagecontentbody = null, [WorkflowExpression] Func<string> bodymessagetouserId = null, [WorkflowExpression] Func<string> bodymessagetolistId = null, [WorkflowExpression] Func<string> bodymessagetoaudienceId = null, [WorkflowExpression] Func<string> bodymessagetoemail = null, [WorkflowExpression] Func<string> bodymessagetophoneNumber = null, [WorkflowExpression] Func<string> bodymessagetolocale = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageSendPostResponse> __BuildMessageSend(WorkflowExpression<string> idempotency, WorkflowExpression<string> bodymessagecontenttitle = null, WorkflowExpression<string> bodymessagecontentbody = null, WorkflowExpression<string> bodymessagetouserId = null, WorkflowExpression<string> bodymessagetolistId = null, WorkflowExpression<string> bodymessagetoaudienceId = null, WorkflowExpression<string> bodymessagetoemail = null, WorkflowExpression<string> bodymessagetophoneNumber = null, WorkflowExpression<string> bodymessagetolocale = null)
        {
            WorkflowExpression.Validate(idempotency, nameof(idempotency), required: true);
            WorkflowExpression.Validate(bodymessagecontenttitle, nameof(bodymessagecontenttitle), required: false);
            WorkflowExpression.Validate(bodymessagecontentbody, nameof(bodymessagecontentbody), required: false);
            WorkflowExpression.Validate(bodymessagetouserId, nameof(bodymessagetouserId), required: false);
            WorkflowExpression.Validate(bodymessagetolistId, nameof(bodymessagetolistId), required: false);
            WorkflowExpression.Validate(bodymessagetoaudienceId, nameof(bodymessagetoaudienceId), required: false);
            WorkflowExpression.Validate(bodymessagetoemail, nameof(bodymessagetoemail), required: false);
            WorkflowExpression.Validate(bodymessagetophoneNumber, nameof(bodymessagetophoneNumber), required: false);
            WorkflowExpression.Validate(bodymessagetolocale, nameof(bodymessagetolocale), required: false);
            return new DeferredBodyAction<MessageSendPostResponse>(() =>
            {
                var apiCallPath = "/send";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["idempotency"] = ExpressionConverter.Convert(idempotency);
                var body = new JObject();
                var bodypropCount = 0;
                var messageObject = new JObject();
                var messageObjectpropCount = 0;
                var contentObject = new JObject();
                var contentObjectpropCount = 0;
                if (bodymessagecontenttitle != null)
                {
                    contentObject["title"] = ExpressionConverter.ConvertO(bodymessagecontenttitle);
                    contentObjectpropCount++;
                }

                if (bodymessagecontentbody != null)
                {
                    contentObject["body"] = ExpressionConverter.ConvertO(bodymessagecontentbody);
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
                    toObject["user_id"] = ExpressionConverter.ConvertO(bodymessagetouserId);
                    toObjectpropCount++;
                }

                if (bodymessagetolistId != null)
                {
                    toObject["list_id"] = ExpressionConverter.ConvertO(bodymessagetolistId);
                    toObjectpropCount++;
                }

                if (bodymessagetoaudienceId != null)
                {
                    toObject["audience_id"] = ExpressionConverter.ConvertO(bodymessagetoaudienceId);
                    toObjectpropCount++;
                }

                if (bodymessagetoemail != null)
                {
                    toObject["email"] = ExpressionConverter.ConvertO(bodymessagetoemail);
                    toObjectpropCount++;
                }

                if (bodymessagetophoneNumber != null)
                {
                    toObject["phone_number"] = ExpressionConverter.ConvertO(bodymessagetophoneNumber);
                    toObjectpropCount++;
                }

                if (bodymessagetolocale != null)
                {
                    toObject["locale"] = ExpressionConverter.ConvertO(bodymessagetolocale);
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
        [WorkflowExpressionFactory(nameof(__BuildAudienceGet))]
        public IBodyWorkflowAction<AudienceGetResponse> AudienceGet([WorkflowExpression] Func<string> audienceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudienceGetResponse> __BuildAudienceGet(WorkflowExpression<string> audienceId)
        {
            WorkflowExpression.Validate(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<AudienceGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AudienceGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAudienceDelete))]
        public IBodyWorkflowAction<string> AudienceDelete([WorkflowExpression] Func<string> audienceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildAudienceDelete(WorkflowExpression<string> audienceId)
        {
            WorkflowExpression.Validate(audienceId, nameof(audienceId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAudiencePut))]
        public IBodyWorkflowAction<AudiencePutResponse> AudiencePut([WorkflowExpression] Func<string> audienceId, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyfilterpath = null, [WorkflowExpression] Func<string> bodyfilterOperator = null, [WorkflowExpression] Func<string> bodyfiltervalue = null, [WorkflowExpression] Func<bodyfilterfiltersInputItem[]> bodyfilterfilters = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudiencePutResponse> __BuildAudiencePut(WorkflowExpression<string> audienceId, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyfilterpath = null, WorkflowExpression<string> bodyfilterOperator = null, WorkflowExpression<string> bodyfiltervalue = null, WorkflowExpression<bodyfilterfiltersInputItem[]> bodyfilterfilters = null)
        {
            WorkflowExpression.Validate(audienceId, nameof(audienceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyfilterpath, nameof(bodyfilterpath), required: false);
            WorkflowExpression.Validate(bodyfilterOperator, nameof(bodyfilterOperator), required: false);
            WorkflowExpression.Validate(bodyfiltervalue, nameof(bodyfiltervalue), required: false);
            WorkflowExpression.Validate(bodyfilterfilters, nameof(bodyfilterfilters), required: false);
            return new DeferredBodyAction<AudiencePutResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}", ExpressionConverter.ConvertWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                var filterObject = new JObject();
                var filterObjectpropCount = 0;
                if (bodyfilterpath != null)
                {
                    filterObject["path"] = ExpressionConverter.ConvertO(bodyfilterpath);
                    filterObjectpropCount++;
                }

                if (bodyfilterOperator != null)
                {
                    filterObject["operator"] = ExpressionConverter.ConvertO(bodyfilterOperator);
                    filterObjectpropCount++;
                }

                if (bodyfiltervalue != null)
                {
                    filterObject["value"] = ExpressionConverter.ConvertO(bodyfiltervalue);
                    filterObjectpropCount++;
                }

                if (bodyfilterfilters != null)
                {
                    filterObject["filters"] = ExpressionConverter.ConvertO(bodyfilterfilters);
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
        [WorkflowExpressionFactory(nameof(__BuildAudienceMembersGet))]
        public IBodyWorkflowAction<AudienceMembersGetResponse> AudienceMembersGet([WorkflowExpression] Func<string> audienceId, [WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudienceMembersGetResponse> __BuildAudienceMembersGet(WorkflowExpression<string> audienceId, WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(audienceId, nameof(audienceId), required: true);
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudienceMembersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audiences/{0}/members", ExpressionConverter.ConvertWithUrlEncoding(audienceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<AudienceMembersGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAudiencesGet))]
        public IBodyWorkflowAction<AudiencesGetResponse> AudiencesGet([WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AudiencesGetResponse> __BuildAudiencesGet(WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AudiencesGetResponse>(() =>
            {
                var apiCallPath = "/audiences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<AudiencesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAuditEventsGet))]
        public IBodyWorkflowAction<AuditEventsGetResponse> AuditEventsGet([WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuditEventsGetResponse> __BuildAuditEventsGet(WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<AuditEventsGetResponse>(() =>
            {
                var apiCallPath = "/audit-events";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<AuditEventsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAuditEventGet))]
        public IBodyWorkflowAction<AuditEventGetResponse> AuditEventGet([WorkflowExpression] Func<string> auditEventId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AuditEventGetResponse> __BuildAuditEventGet(WorkflowExpression<string> auditEventId)
        {
            WorkflowExpression.Validate(auditEventId, nameof(auditEventId), required: true);
            return new DeferredBodyAction<AuditEventGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/audit-events/{0}", ExpressionConverter.ConvertWithUrlEncoding(auditEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<AuditEventGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildAutomationTemplated))]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse> AutomationTemplated([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> bodybrand = null, [WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyrecipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse> __BuildAutomationTemplated(WorkflowExpression<string> templateId, WorkflowExpression<string> bodybrand = null, WorkflowExpression<string> bodytemplate = null, WorkflowExpression<string> bodyrecipient = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(bodybrand, nameof(bodybrand), required: false);
            WorkflowExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            WorkflowExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationTemplatedPostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/automations/{0}/invoke", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybrand != null)
                {
                    body["brand"] = ExpressionConverter.ConvertO(bodybrand);
                    bodypropCount++;
                }

                if (bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                    bodypropCount++;
                }

                if (bodyrecipient != null)
                {
                    body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
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
        [WorkflowExpressionFactory(nameof(__BuildAutomationAdHoc))]
        public IBodyWorkflowAction<AutomationAdHocPostResponse> AutomationAdHoc([WorkflowExpression] Func<JToken[]> bodyautomationsteps = null, [WorkflowExpression] Func<string> bodyautomationcancelationToken = null, [WorkflowExpression] Func<string> bodybrand = null, [WorkflowExpression] Func<string> bodytemplate = null, [WorkflowExpression] Func<string> bodyrecipient = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AutomationAdHocPostResponse> __BuildAutomationAdHoc(WorkflowExpression<JToken[]> bodyautomationsteps = null, WorkflowExpression<string> bodyautomationcancelationToken = null, WorkflowExpression<string> bodybrand = null, WorkflowExpression<string> bodytemplate = null, WorkflowExpression<string> bodyrecipient = null)
        {
            WorkflowExpression.Validate(bodyautomationsteps, nameof(bodyautomationsteps), required: false);
            WorkflowExpression.Validate(bodyautomationcancelationToken, nameof(bodyautomationcancelationToken), required: false);
            WorkflowExpression.Validate(bodybrand, nameof(bodybrand), required: false);
            WorkflowExpression.Validate(bodytemplate, nameof(bodytemplate), required: false);
            WorkflowExpression.Validate(bodyrecipient, nameof(bodyrecipient), required: false);
            return new DeferredBodyAction<AutomationAdHocPostResponse>(() =>
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
                    automationObject["steps"] = ExpressionConverter.ConvertO(bodyautomationsteps);
                    automationObjectpropCount++;
                }

                if (bodyautomationcancelationToken != null)
                {
                    automationObject["cancelation_token"] = ExpressionConverter.ConvertO(bodyautomationcancelationToken);
                    automationObjectpropCount++;
                }

                if (automationObjectpropCount > 0)
                {
                    body["automation"] = automationObject;
                    bodypropCount++;
                }

                if (bodybrand != null)
                {
                    body["brand"] = ExpressionConverter.ConvertO(bodybrand);
                    bodypropCount++;
                }

                if (bodytemplate != null)
                {
                    body["template"] = ExpressionConverter.ConvertO(bodytemplate);
                    bodypropCount++;
                }

                if (bodyrecipient != null)
                {
                    body["recipient"] = ExpressionConverter.ConvertO(bodyrecipient);
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
        [WorkflowExpressionFactory(nameof(__BuildBrandsGet))]
        public IBodyWorkflowAction<BrandsGetResponse> BrandsGet([WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrandsGetResponse> __BuildBrandsGet(WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<BrandsGetResponse>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<BrandsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildBrand))]
        public IBodyWorkflowAction<string> Brand([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodysettingscolorsprimary = null, [WorkflowExpression] Func<string> bodysettingscolorssecondary = null, [WorkflowExpression] Func<string> bodysettingscolorstertiary = null, [WorkflowExpression] Func<string> bodysettingsemailheaderbarColor = null, [WorkflowExpression] Func<string> bodysettingsemailheaderlogohref = null, [WorkflowExpression] Func<string> bodysettingsemailheaderlogoimage = null, [WorkflowExpression] Func<string> bodysettingsemailfootermarkdown = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialfacebookurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialinstagramurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersociallinkedinurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialmediumurl = null, [WorkflowExpression] Func<string> bodysettingsemailfootersocialtwitterurl = null, [WorkflowExpression] Func<bool> bodysettingsinappdisableMessageIcon = null, [WorkflowExpression] Func<string> bodysettingsinappplacement = null, [WorkflowExpression] Func<string[]> bodysnippetsitems = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildBrand(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyid = null, WorkflowExpression<string> bodysettingscolorsprimary = null, WorkflowExpression<string> bodysettingscolorssecondary = null, WorkflowExpression<string> bodysettingscolorstertiary = null, WorkflowExpression<string> bodysettingsemailheaderbarColor = null, WorkflowExpression<string> bodysettingsemailheaderlogohref = null, WorkflowExpression<string> bodysettingsemailheaderlogoimage = null, WorkflowExpression<string> bodysettingsemailfootermarkdown = null, WorkflowExpression<string> bodysettingsemailfootersocialfacebookurl = null, WorkflowExpression<string> bodysettingsemailfootersocialinstagramurl = null, WorkflowExpression<string> bodysettingsemailfootersociallinkedinurl = null, WorkflowExpression<string> bodysettingsemailfootersocialmediumurl = null, WorkflowExpression<string> bodysettingsemailfootersocialtwitterurl = null, WorkflowExpression<bool> bodysettingsinappdisableMessageIcon = null, WorkflowExpression<string> bodysettingsinappplacement = null, WorkflowExpression<string[]> bodysnippetsitems = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowExpression.Validate(bodysettingscolorsprimary, nameof(bodysettingscolorsprimary), required: false);
            WorkflowExpression.Validate(bodysettingscolorssecondary, nameof(bodysettingscolorssecondary), required: false);
            WorkflowExpression.Validate(bodysettingscolorstertiary, nameof(bodysettingscolorstertiary), required: false);
            WorkflowExpression.Validate(bodysettingsemailheaderbarColor, nameof(bodysettingsemailheaderbarColor), required: false);
            WorkflowExpression.Validate(bodysettingsemailheaderlogohref, nameof(bodysettingsemailheaderlogohref), required: false);
            WorkflowExpression.Validate(bodysettingsemailheaderlogoimage, nameof(bodysettingsemailheaderlogoimage), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootermarkdown, nameof(bodysettingsemailfootermarkdown), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootersocialfacebookurl, nameof(bodysettingsemailfootersocialfacebookurl), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootersocialinstagramurl, nameof(bodysettingsemailfootersocialinstagramurl), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootersociallinkedinurl, nameof(bodysettingsemailfootersociallinkedinurl), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootersocialmediumurl, nameof(bodysettingsemailfootersocialmediumurl), required: false);
            WorkflowExpression.Validate(bodysettingsemailfootersocialtwitterurl, nameof(bodysettingsemailfootersocialtwitterurl), required: false);
            WorkflowExpression.Validate(bodysettingsinappdisableMessageIcon, nameof(bodysettingsinappdisableMessageIcon), required: false);
            WorkflowExpression.Validate(bodysettingsinappplacement, nameof(bodysettingsinappplacement), required: false);
            WorkflowExpression.Validate(bodysnippetsitems, nameof(bodysnippetsitems), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/brands";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                var colorsObject = new JObject();
                var colorsObjectpropCount = 0;
                if (bodysettingscolorsprimary != null)
                {
                    colorsObject["primary"] = ExpressionConverter.ConvertO(bodysettingscolorsprimary);
                    colorsObjectpropCount++;
                }

                if (bodysettingscolorssecondary != null)
                {
                    colorsObject["secondary"] = ExpressionConverter.ConvertO(bodysettingscolorssecondary);
                    colorsObjectpropCount++;
                }

                if (bodysettingscolorstertiary != null)
                {
                    colorsObject["tertiary"] = ExpressionConverter.ConvertO(bodysettingscolorstertiary);
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
                    headerObject["barColor"] = ExpressionConverter.ConvertO(bodysettingsemailheaderbarColor);
                    headerObjectpropCount++;
                }

                var logoObject = new JObject();
                var logoObjectpropCount = 0;
                if (bodysettingsemailheaderlogohref != null)
                {
                    logoObject["href"] = ExpressionConverter.ConvertO(bodysettingsemailheaderlogohref);
                    logoObjectpropCount++;
                }

                if (bodysettingsemailheaderlogoimage != null)
                {
                    logoObject["image"] = ExpressionConverter.ConvertO(bodysettingsemailheaderlogoimage);
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
                    footerObject["markdown"] = ExpressionConverter.ConvertO(bodysettingsemailfootermarkdown);
                    footerObjectpropCount++;
                }

                var socialObject = new JObject();
                var socialObjectpropCount = 0;
                var facebookObject = new JObject();
                var facebookObjectpropCount = 0;
                if (bodysettingsemailfootersocialfacebookurl != null)
                {
                    facebookObject["url"] = ExpressionConverter.ConvertO(bodysettingsemailfootersocialfacebookurl);
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
                    instagramObject["url"] = ExpressionConverter.ConvertO(bodysettingsemailfootersocialinstagramurl);
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
                    linkedinObject["url"] = ExpressionConverter.ConvertO(bodysettingsemailfootersociallinkedinurl);
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
                    mediumObject["url"] = ExpressionConverter.ConvertO(bodysettingsemailfootersocialmediumurl);
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
                    twitterObject["url"] = ExpressionConverter.ConvertO(bodysettingsemailfootersocialtwitterurl);
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
                    inappObject["disableMessageIcon"] = ExpressionConverter.ConvertO(bodysettingsinappdisableMessageIcon);
                    inappObjectpropCount++;
                }

                if (bodysettingsinappplacement != null)
                {
                    inappObject["placement"] = ExpressionConverter.ConvertO(bodysettingsinappplacement);
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
                    snippetsObject["items"] = ExpressionConverter.ConvertO(bodysnippetsitems);
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
        [WorkflowExpressionFactory(nameof(__BuildBrandGet))]
        public IBodyWorkflowAction<BrandGetResponse> BrandGet([WorkflowExpression] Func<string> brandId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BrandGetResponse> __BuildBrandGet(WorkflowExpression<string> brandId)
        {
            WorkflowExpression.Validate(brandId, nameof(brandId), required: true);
            return new DeferredBodyAction<BrandGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/brands/{0}", ExpressionConverter.ConvertWithUrlEncoding(brandId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BrandGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildBulkJob))]
        public IBodyWorkflowAction<BulkJobPostResponse> BulkJob([WorkflowExpression] Func<string> bodymessageEvent = null, [WorkflowExpression] Func<string> bodymessagebrand = null, [WorkflowExpression] Func<string> bodymessagetemplate = null, [WorkflowExpression] Func<string> bodymessagebrandId = null, [WorkflowExpression] Func<string> bodymessageroutingmethod = null, [WorkflowExpression] Func<string[]> bodymessageroutingchannels = null, [WorkflowExpression] Func<string> bodymessagemetadataEvent = null, [WorkflowExpression] Func<string[]> bodymessagemetadatatags = null, [WorkflowExpression] Func<string> bodymessagemetadatatraceId = null, [WorkflowExpression] Func<string> bodymessagemetadatautmcampaign = null, [WorkflowExpression] Func<string> bodymessagemetadatautmcontent = null, [WorkflowExpression] Func<string> bodymessagemetadatautmmedium = null, [WorkflowExpression] Func<string> bodymessagemetadatautmsource = null, [WorkflowExpression] Func<string> bodymessagemetadatautmterm = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BulkJobPostResponse> __BuildBulkJob(WorkflowExpression<string> bodymessageEvent = null, WorkflowExpression<string> bodymessagebrand = null, WorkflowExpression<string> bodymessagetemplate = null, WorkflowExpression<string> bodymessagebrandId = null, WorkflowExpression<string> bodymessageroutingmethod = null, WorkflowExpression<string[]> bodymessageroutingchannels = null, WorkflowExpression<string> bodymessagemetadataEvent = null, WorkflowExpression<string[]> bodymessagemetadatatags = null, WorkflowExpression<string> bodymessagemetadatatraceId = null, WorkflowExpression<string> bodymessagemetadatautmcampaign = null, WorkflowExpression<string> bodymessagemetadatautmcontent = null, WorkflowExpression<string> bodymessagemetadatautmmedium = null, WorkflowExpression<string> bodymessagemetadatautmsource = null, WorkflowExpression<string> bodymessagemetadatautmterm = null)
        {
            WorkflowExpression.Validate(bodymessageEvent, nameof(bodymessageEvent), required: false);
            WorkflowExpression.Validate(bodymessagebrand, nameof(bodymessagebrand), required: false);
            WorkflowExpression.Validate(bodymessagetemplate, nameof(bodymessagetemplate), required: false);
            WorkflowExpression.Validate(bodymessagebrandId, nameof(bodymessagebrandId), required: false);
            WorkflowExpression.Validate(bodymessageroutingmethod, nameof(bodymessageroutingmethod), required: false);
            WorkflowExpression.Validate(bodymessageroutingchannels, nameof(bodymessageroutingchannels), required: false);
            WorkflowExpression.Validate(bodymessagemetadataEvent, nameof(bodymessagemetadataEvent), required: false);
            WorkflowExpression.Validate(bodymessagemetadatatags, nameof(bodymessagemetadatatags), required: false);
            WorkflowExpression.Validate(bodymessagemetadatatraceId, nameof(bodymessagemetadatatraceId), required: false);
            WorkflowExpression.Validate(bodymessagemetadatautmcampaign, nameof(bodymessagemetadatautmcampaign), required: false);
            WorkflowExpression.Validate(bodymessagemetadatautmcontent, nameof(bodymessagemetadatautmcontent), required: false);
            WorkflowExpression.Validate(bodymessagemetadatautmmedium, nameof(bodymessagemetadatautmmedium), required: false);
            WorkflowExpression.Validate(bodymessagemetadatautmsource, nameof(bodymessagemetadatautmsource), required: false);
            WorkflowExpression.Validate(bodymessagemetadatautmterm, nameof(bodymessagemetadatautmterm), required: false);
            return new DeferredBodyAction<BulkJobPostResponse>(() =>
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
                    messageObject["event"] = ExpressionConverter.ConvertO(bodymessageEvent);
                    messageObjectpropCount++;
                }

                if (bodymessagebrand != null)
                {
                    messageObject["brand"] = ExpressionConverter.ConvertO(bodymessagebrand);
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
                    messageObject["template"] = ExpressionConverter.ConvertO(bodymessagetemplate);
                    messageObjectpropCount++;
                }

                if (bodymessagebrandId != null)
                {
                    messageObject["brand_id"] = ExpressionConverter.ConvertO(bodymessagebrandId);
                    messageObjectpropCount++;
                }

                var routingObject = new JObject();
                var routingObjectpropCount = 0;
                if (bodymessageroutingmethod != null)
                {
                    routingObject["method"] = ExpressionConverter.ConvertO(bodymessageroutingmethod);
                    routingObjectpropCount++;
                }

                if (bodymessageroutingchannels != null)
                {
                    routingObject["channels"] = ExpressionConverter.ConvertO(bodymessageroutingchannels);
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
                    metadataObject["event"] = ExpressionConverter.ConvertO(bodymessagemetadataEvent);
                    metadataObjectpropCount++;
                }

                if (bodymessagemetadatatags != null)
                {
                    metadataObject["tags"] = ExpressionConverter.ConvertO(bodymessagemetadatatags);
                    metadataObjectpropCount++;
                }

                if (bodymessagemetadatatraceId != null)
                {
                    metadataObject["trace_id"] = ExpressionConverter.ConvertO(bodymessagemetadatatraceId);
                    metadataObjectpropCount++;
                }

                var utmObject = new JObject();
                var utmObjectpropCount = 0;
                if (bodymessagemetadatautmcampaign != null)
                {
                    utmObject["campaign"] = ExpressionConverter.ConvertO(bodymessagemetadatautmcampaign);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmcontent != null)
                {
                    utmObject["content"] = ExpressionConverter.ConvertO(bodymessagemetadatautmcontent);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmmedium != null)
                {
                    utmObject["medium"] = ExpressionConverter.ConvertO(bodymessagemetadatautmmedium);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmsource != null)
                {
                    utmObject["source"] = ExpressionConverter.ConvertO(bodymessagemetadatautmsource);
                    utmObjectpropCount++;
                }

                if (bodymessagemetadatautmterm != null)
                {
                    utmObject["term"] = ExpressionConverter.ConvertO(bodymessagemetadatautmterm);
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
        [WorkflowExpressionFactory(nameof(__BuildBulkJobGet))]
        public IBodyWorkflowAction<BulkJobGetResponse> BulkJobGet([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BulkJobGetResponse> __BuildBulkJobGet(WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<BulkJobGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildBulkJobUsers))]
        public IBodyWorkflowAction<string> BulkJobUsers([WorkflowExpression] Func<string> jobId, [WorkflowExpression] Func<bodyusersInputItem[]> bodyusers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildBulkJobUsers(WorkflowExpression<string> jobId, WorkflowExpression<bodyusersInputItem[]> bodyusers = null)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            WorkflowExpression.Validate(bodyusers, nameof(bodyusers), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyusers != null)
                {
                    body["users"] = ExpressionConverter.ConvertO(bodyusers);
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
        [WorkflowExpressionFactory(nameof(__BuildBulkJobRun))]
        public IBodyWorkflowAction<JToken> BulkJobRun([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildBulkJobRun(WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildBulkJobUsersGet))]
        public IBodyWorkflowAction<BulkJobUsersGetResponse> BulkJobUsersGet([WorkflowExpression] Func<string> jobId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<BulkJobUsersGetResponse> __BuildBulkJobUsersGet(WorkflowExpression<string> jobId)
        {
            WorkflowExpression.Validate(jobId, nameof(jobId), required: true);
            return new DeferredBodyAction<BulkJobUsersGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/bulk/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(jobId, 1));
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
        [WorkflowExpressionFactory(nameof(__BuildListGet))]
        public IBodyWorkflowAction<ListGetResponse> ListGet([WorkflowExpression] Func<string> listId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListGetResponse> __BuildListGet(WorkflowExpression<string> listId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyAction<ListGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ListGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildListDelete))]
        public IBodyWorkflowAction<string> ListDelete([WorkflowExpression] Func<string> listId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildListDelete(WorkflowExpression<string> listId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildListPut))]
        public IBodyWorkflowAction<string> ListPut([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildListPut(WorkflowExpression<string> listId, WorkflowExpression<string> bodyname = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
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
        [WorkflowExpressionFactory(nameof(__BuildListRestorePut))]
        public IBodyWorkflowAction<string> ListRestorePut([WorkflowExpression] Func<string> listId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildListRestorePut(WorkflowExpression<string> listId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/restore", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildListSubscriptionsGet))]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse> ListSubscriptionsGet([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse> __BuildListSubscriptionsGet(WorkflowExpression<string> listId, WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<ListSubscriptionsGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<ListSubscriptionsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildListSubscribers))]
        public IBodyWorkflowAction<string> ListSubscribers([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<bodyrecipientsInputItem[]> bodyrecipients = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildListSubscribers(WorkflowExpression<string> listId, WorkflowExpression<bodyrecipientsInputItem[]> bodyrecipients = null)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(bodyrecipients, nameof(bodyrecipients), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", ExpressionConverter.ConvertWithUrlEncoding(listId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyrecipients != null)
                {
                    body["recipients"] = ExpressionConverter.ConvertO(bodyrecipients);
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
        [WorkflowExpressionFactory(nameof(__BuildListSubscribeDelete))]
        public IBodyWorkflowAction<string> ListSubscribeDelete([WorkflowExpression] Func<string> listId, [WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildListSubscribeDelete(WorkflowExpression<string> listId, WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(listId, nameof(listId), required: true);
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions/{1}", ExpressionConverter.ConvertWithUrlEncoding(listId, 1), ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessagesGet))]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet([WorkflowExpression] Func<bool> archived = null, [WorkflowExpression] Func<string> cursor = null, [WorkflowExpression] Func<string> @event = null, [WorkflowExpression] Func<string> list = null, [WorkflowExpression] Func<string> messageId = null, [WorkflowExpression] Func<string> notification = null, [WorkflowExpression] Func<string> recipient = null, [WorkflowExpression] Func<string> status = null, [WorkflowExpression] Func<string> tags = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessagesGetResponse> __BuildMessagesGet(WorkflowExpression<bool> archived = null, WorkflowExpression<string> cursor = null, WorkflowExpression<string> @event = null, WorkflowExpression<string> list = null, WorkflowExpression<string> messageId = null, WorkflowExpression<string> notification = null, WorkflowExpression<string> recipient = null, WorkflowExpression<string> status = null, WorkflowExpression<string> tags = null)
        {
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            WorkflowExpression.Validate(@event, nameof(@event), required: false);
            WorkflowExpression.Validate(list, nameof(list), required: false);
            WorkflowExpression.Validate(messageId, nameof(messageId), required: false);
            WorkflowExpression.Validate(notification, nameof(notification), required: false);
            WorkflowExpression.Validate(recipient, nameof(recipient), required: false);
            WorkflowExpression.Validate(status, nameof(status), required: false);
            WorkflowExpression.Validate(tags, nameof(tags), required: false);
            return new DeferredBodyAction<MessagesGetResponse>(() =>
            {
                var apiCallPath = "/messages";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                if (@event != null)
                    callPayload.Queries["event"] = ExpressionConverter.Convert(@event);
                if (list != null)
                    callPayload.Queries["list"] = ExpressionConverter.Convert(list);
                if (messageId != null)
                    callPayload.Queries["messageId"] = ExpressionConverter.Convert(messageId);
                if (notification != null)
                    callPayload.Queries["notification"] = ExpressionConverter.Convert(notification);
                if (recipient != null)
                    callPayload.Queries["recipient"] = ExpressionConverter.Convert(recipient);
                if (status != null)
                    callPayload.Queries["status"] = ExpressionConverter.Convert(status);
                if (tags != null)
                    callPayload.Queries["tags"] = ExpressionConverter.Convert(tags);
                return new ApiConnectionAction<MessagesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessageGet))]
        public IBodyWorkflowAction<MessageGetResponse> MessageGet([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageGetResponse> __BuildMessageGet(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessageHistoryGet))]
        public IBodyWorkflowAction<MessageHistoryGetResponse> MessageHistoryGet([WorkflowExpression] Func<string> messageId, [WorkflowExpression] Func<string> type = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageHistoryGetResponse> __BuildMessageHistoryGet(WorkflowExpression<string> messageId, WorkflowExpression<string> type = null)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            WorkflowExpression.Validate(type, nameof(type), required: false);
            return new DeferredBodyAction<MessageHistoryGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}/history", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (type != null)
                    callPayload.Queries["type"] = ExpressionConverter.Convert(type);
                return new ApiConnectionAction<MessageHistoryGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessageContentGet))]
        public IBodyWorkflowAction<MessageContentGetResponse> MessageContentGet([WorkflowExpression] Func<string> messageId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<MessageContentGetResponse> __BuildMessageContentGet(WorkflowExpression<string> messageId)
        {
            WorkflowExpression.Validate(messageId, nameof(messageId), required: true);
            return new DeferredBodyAction<MessageContentGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/messages/{0}/output", ExpressionConverter.ConvertWithUrlEncoding(messageId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<MessageContentGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildMessagePut))]
        public IBodyWorkflowAction<string> MessagePut([WorkflowExpression] Func<string> requestId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildMessagePut(WorkflowExpression<string> requestId)
        {
            WorkflowExpression.Validate(requestId, nameof(requestId), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/requests/{0}/archive", ExpressionConverter.ConvertWithUrlEncoding(requestId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildNotificationsGet))]
        public IBodyWorkflowAction<NotificationsGetResponse> NotificationsGet([WorkflowExpression] Func<string> cursor = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NotificationsGetResponse> __BuildNotificationsGet(WorkflowExpression<string> cursor = null)
        {
            WorkflowExpression.Validate(cursor, nameof(cursor), required: false);
            return new DeferredBodyAction<NotificationsGetResponse>(() =>
            {
                var apiCallPath = "/notifications";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (cursor != null)
                    callPayload.Queries["cursor"] = ExpressionConverter.Convert(cursor);
                return new ApiConnectionAction<NotificationsGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildProfileGet))]
        public IBodyWorkflowAction<ProfileGetResponse> ProfileGet([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProfileGetResponse> __BuildProfileGet(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildProfileDelete))]
        public IBodyWorkflowAction<ProfileDeleteResponse> ProfileDelete([WorkflowExpression] Func<string> recipientId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProfileDeleteResponse> __BuildProfileDelete(WorkflowExpression<string> recipientId)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            return new DeferredBodyAction<ProfileDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ProfileDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [WorkflowExpressionFactory(nameof(__BuildProfile))]
        public IBodyWorkflowAction<string> Profile([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<string> bodyprofileemail = null, [WorkflowExpression] Func<string> bodyprofilephoneNumber = null, [WorkflowExpression] Func<string> bodyprofileaddressformatted = null, [WorkflowExpression] Func<string> bodyprofileaddressstreetAddress = null, [WorkflowExpression] Func<string> bodyprofileaddresslocality = null, [WorkflowExpression] Func<string> bodyprofileaddressregion = null, [WorkflowExpression] Func<string> bodyprofileaddresspostalCode = null, [WorkflowExpression] Func<string> bodyprofileaddresscountry = null, [WorkflowExpression] Func<string> bodyprofilebirthdate = null, [WorkflowExpression] Func<bool> bodyprofileemailVerified = null, [WorkflowExpression] Func<bool> bodyprofilephoneNumberVerified = null, [WorkflowExpression] Func<string> bodyprofilegivenName = null, [WorkflowExpression] Func<string> bodyprofilemiddleName = null, [WorkflowExpression] Func<string> bodyprofilefamilyName = null, [WorkflowExpression] Func<string> bodyprofilepreferredName = null, [WorkflowExpression] Func<string> bodyprofilegender = null, [WorkflowExpression] Func<string> bodyprofilelocale = null, [WorkflowExpression] Func<string> bodyprofilepicture = null, [WorkflowExpression] Func<string> bodyprofileprofile = null, [WorkflowExpression] Func<string> bodyprofilesub = null, [WorkflowExpression] Func<string> bodyprofileupdatedAt = null, [WorkflowExpression] Func<string> bodyprofilewebsite = null, [WorkflowExpression] Func<string> bodyprofilezoneinfo = null, [WorkflowExpression] Func<string> bodyprofileairshipaudiencenamedUser = null, [WorkflowExpression] Func<string[]> bodyprofileairshipdeviceTypes = null, [WorkflowExpression] Func<string> bodyprofileairshipapn = null, [WorkflowExpression] Func<string> bodyprofileairshiptargetArn = null, [WorkflowExpression] Func<string> bodyprofileairshipdiscordchannelId = null, [WorkflowExpression] Func<string> bodyprofileairshipdiscorduserId = null, [WorkflowExpression] Func<string> bodyprofileairshipexpotoken = null, [WorkflowExpression] Func<string[]> bodyprofileairshipexpotokens = null, [WorkflowExpression] Func<string> bodyprofileairshipfacebookPSID = null, [WorkflowExpression] Func<string> bodyprofileairshipfirebaseToken = null, [WorkflowExpression] Func<string> bodyprofileairshipintercomfrom = null, [WorkflowExpression] Func<string> bodyprofileairshipintercomtoid = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsuserId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsconversationId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamstenantId = null, [WorkflowExpression] Func<string> bodyprofileairshipmsTeamsserviceUrl = null, [WorkflowExpression] Func<string> bodyprofileairshiponeSignalPlayerID = null, [WorkflowExpression] Func<string> bodyprofileairshipslackaccessToken = null, [WorkflowExpression] Func<string> bodyprofileairshipslackchannel = null, [WorkflowExpression] Func<string> bodyprofileairshipslackemail = null, [WorkflowExpression] Func<string> bodyprofileairshipslackuserId = null, [WorkflowExpression] Func<string> bodyprofileairshipslackincomingWebhookurl = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookurl = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookmethod = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationmode = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationusername = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationpassword = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookauthenticationtoken = null, [WorkflowExpression] Func<string> bodyprofileairshipwebhookprofile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildProfile(WorkflowExpression<string> recipientId, WorkflowExpression<string> bodyprofileemail = null, WorkflowExpression<string> bodyprofilephoneNumber = null, WorkflowExpression<string> bodyprofileaddressformatted = null, WorkflowExpression<string> bodyprofileaddressstreetAddress = null, WorkflowExpression<string> bodyprofileaddresslocality = null, WorkflowExpression<string> bodyprofileaddressregion = null, WorkflowExpression<string> bodyprofileaddresspostalCode = null, WorkflowExpression<string> bodyprofileaddresscountry = null, WorkflowExpression<string> bodyprofilebirthdate = null, WorkflowExpression<bool> bodyprofileemailVerified = null, WorkflowExpression<bool> bodyprofilephoneNumberVerified = null, WorkflowExpression<string> bodyprofilegivenName = null, WorkflowExpression<string> bodyprofilemiddleName = null, WorkflowExpression<string> bodyprofilefamilyName = null, WorkflowExpression<string> bodyprofilepreferredName = null, WorkflowExpression<string> bodyprofilegender = null, WorkflowExpression<string> bodyprofilelocale = null, WorkflowExpression<string> bodyprofilepicture = null, WorkflowExpression<string> bodyprofileprofile = null, WorkflowExpression<string> bodyprofilesub = null, WorkflowExpression<string> bodyprofileupdatedAt = null, WorkflowExpression<string> bodyprofilewebsite = null, WorkflowExpression<string> bodyprofilezoneinfo = null, WorkflowExpression<string> bodyprofileairshipaudiencenamedUser = null, WorkflowExpression<string[]> bodyprofileairshipdeviceTypes = null, WorkflowExpression<string> bodyprofileairshipapn = null, WorkflowExpression<string> bodyprofileairshiptargetArn = null, WorkflowExpression<string> bodyprofileairshipdiscordchannelId = null, WorkflowExpression<string> bodyprofileairshipdiscorduserId = null, WorkflowExpression<string> bodyprofileairshipexpotoken = null, WorkflowExpression<string[]> bodyprofileairshipexpotokens = null, WorkflowExpression<string> bodyprofileairshipfacebookPSID = null, WorkflowExpression<string> bodyprofileairshipfirebaseToken = null, WorkflowExpression<string> bodyprofileairshipintercomfrom = null, WorkflowExpression<string> bodyprofileairshipintercomtoid = null, WorkflowExpression<string> bodyprofileairshipmsTeamsuserId = null, WorkflowExpression<string> bodyprofileairshipmsTeamsconversationId = null, WorkflowExpression<string> bodyprofileairshipmsTeamstenantId = null, WorkflowExpression<string> bodyprofileairshipmsTeamsserviceUrl = null, WorkflowExpression<string> bodyprofileairshiponeSignalPlayerID = null, WorkflowExpression<string> bodyprofileairshipslackaccessToken = null, WorkflowExpression<string> bodyprofileairshipslackchannel = null, WorkflowExpression<string> bodyprofileairshipslackemail = null, WorkflowExpression<string> bodyprofileairshipslackuserId = null, WorkflowExpression<string> bodyprofileairshipslackincomingWebhookurl = null, WorkflowExpression<string> bodyprofileairshipwebhookurl = null, WorkflowExpression<string> bodyprofileairshipwebhookmethod = null, WorkflowExpression<string> bodyprofileairshipwebhookauthenticationmode = null, WorkflowExpression<string> bodyprofileairshipwebhookauthenticationusername = null, WorkflowExpression<string> bodyprofileairshipwebhookauthenticationpassword = null, WorkflowExpression<string> bodyprofileairshipwebhookauthenticationtoken = null, WorkflowExpression<string> bodyprofileairshipwebhookprofile = null)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowExpression.Validate(bodyprofileemail, nameof(bodyprofileemail), required: false);
            WorkflowExpression.Validate(bodyprofilephoneNumber, nameof(bodyprofilephoneNumber), required: false);
            WorkflowExpression.Validate(bodyprofileaddressformatted, nameof(bodyprofileaddressformatted), required: false);
            WorkflowExpression.Validate(bodyprofileaddressstreetAddress, nameof(bodyprofileaddressstreetAddress), required: false);
            WorkflowExpression.Validate(bodyprofileaddresslocality, nameof(bodyprofileaddresslocality), required: false);
            WorkflowExpression.Validate(bodyprofileaddressregion, nameof(bodyprofileaddressregion), required: false);
            WorkflowExpression.Validate(bodyprofileaddresspostalCode, nameof(bodyprofileaddresspostalCode), required: false);
            WorkflowExpression.Validate(bodyprofileaddresscountry, nameof(bodyprofileaddresscountry), required: false);
            WorkflowExpression.Validate(bodyprofilebirthdate, nameof(bodyprofilebirthdate), required: false);
            WorkflowExpression.Validate(bodyprofileemailVerified, nameof(bodyprofileemailVerified), required: false);
            WorkflowExpression.Validate(bodyprofilephoneNumberVerified, nameof(bodyprofilephoneNumberVerified), required: false);
            WorkflowExpression.Validate(bodyprofilegivenName, nameof(bodyprofilegivenName), required: false);
            WorkflowExpression.Validate(bodyprofilemiddleName, nameof(bodyprofilemiddleName), required: false);
            WorkflowExpression.Validate(bodyprofilefamilyName, nameof(bodyprofilefamilyName), required: false);
            WorkflowExpression.Validate(bodyprofilepreferredName, nameof(bodyprofilepreferredName), required: false);
            WorkflowExpression.Validate(bodyprofilegender, nameof(bodyprofilegender), required: false);
            WorkflowExpression.Validate(bodyprofilelocale, nameof(bodyprofilelocale), required: false);
            WorkflowExpression.Validate(bodyprofilepicture, nameof(bodyprofilepicture), required: false);
            WorkflowExpression.Validate(bodyprofileprofile, nameof(bodyprofileprofile), required: false);
            WorkflowExpression.Validate(bodyprofilesub, nameof(bodyprofilesub), required: false);
            WorkflowExpression.Validate(bodyprofileupdatedAt, nameof(bodyprofileupdatedAt), required: false);
            WorkflowExpression.Validate(bodyprofilewebsite, nameof(bodyprofilewebsite), required: false);
            WorkflowExpression.Validate(bodyprofilezoneinfo, nameof(bodyprofilezoneinfo), required: false);
            WorkflowExpression.Validate(bodyprofileairshipaudiencenamedUser, nameof(bodyprofileairshipaudiencenamedUser), required: false);
            WorkflowExpression.Validate(bodyprofileairshipdeviceTypes, nameof(bodyprofileairshipdeviceTypes), required: false);
            WorkflowExpression.Validate(bodyprofileairshipapn, nameof(bodyprofileairshipapn), required: false);
            WorkflowExpression.Validate(bodyprofileairshiptargetArn, nameof(bodyprofileairshiptargetArn), required: false);
            WorkflowExpression.Validate(bodyprofileairshipdiscordchannelId, nameof(bodyprofileairshipdiscordchannelId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipdiscorduserId, nameof(bodyprofileairshipdiscorduserId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipexpotoken, nameof(bodyprofileairshipexpotoken), required: false);
            WorkflowExpression.Validate(bodyprofileairshipexpotokens, nameof(bodyprofileairshipexpotokens), required: false);
            WorkflowExpression.Validate(bodyprofileairshipfacebookPSID, nameof(bodyprofileairshipfacebookPSID), required: false);
            WorkflowExpression.Validate(bodyprofileairshipfirebaseToken, nameof(bodyprofileairshipfirebaseToken), required: false);
            WorkflowExpression.Validate(bodyprofileairshipintercomfrom, nameof(bodyprofileairshipintercomfrom), required: false);
            WorkflowExpression.Validate(bodyprofileairshipintercomtoid, nameof(bodyprofileairshipintercomtoid), required: false);
            WorkflowExpression.Validate(bodyprofileairshipmsTeamsuserId, nameof(bodyprofileairshipmsTeamsuserId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipmsTeamsconversationId, nameof(bodyprofileairshipmsTeamsconversationId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipmsTeamstenantId, nameof(bodyprofileairshipmsTeamstenantId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipmsTeamsserviceUrl, nameof(bodyprofileairshipmsTeamsserviceUrl), required: false);
            WorkflowExpression.Validate(bodyprofileairshiponeSignalPlayerID, nameof(bodyprofileairshiponeSignalPlayerID), required: false);
            WorkflowExpression.Validate(bodyprofileairshipslackaccessToken, nameof(bodyprofileairshipslackaccessToken), required: false);
            WorkflowExpression.Validate(bodyprofileairshipslackchannel, nameof(bodyprofileairshipslackchannel), required: false);
            WorkflowExpression.Validate(bodyprofileairshipslackemail, nameof(bodyprofileairshipslackemail), required: false);
            WorkflowExpression.Validate(bodyprofileairshipslackuserId, nameof(bodyprofileairshipslackuserId), required: false);
            WorkflowExpression.Validate(bodyprofileairshipslackincomingWebhookurl, nameof(bodyprofileairshipslackincomingWebhookurl), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookurl, nameof(bodyprofileairshipwebhookurl), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookmethod, nameof(bodyprofileairshipwebhookmethod), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookauthenticationmode, nameof(bodyprofileairshipwebhookauthenticationmode), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookauthenticationusername, nameof(bodyprofileairshipwebhookauthenticationusername), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookauthenticationpassword, nameof(bodyprofileairshipwebhookauthenticationpassword), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookauthenticationtoken, nameof(bodyprofileairshipwebhookauthenticationtoken), required: false);
            WorkflowExpression.Validate(bodyprofileairshipwebhookprofile, nameof(bodyprofileairshipwebhookprofile), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var profileObject = new JObject();
                var profileObjectpropCount = 0;
                if (bodyprofileemail != null)
                {
                    profileObject["email"] = ExpressionConverter.ConvertO(bodyprofileemail);
                    profileObjectpropCount++;
                }

                if (bodyprofilephoneNumber != null)
                {
                    profileObject["phone_number"] = ExpressionConverter.ConvertO(bodyprofilephoneNumber);
                    profileObjectpropCount++;
                }

                var addressObject = new JObject();
                var addressObjectpropCount = 0;
                if (bodyprofileaddressformatted != null)
                {
                    addressObject["formatted"] = ExpressionConverter.ConvertO(bodyprofileaddressformatted);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddressstreetAddress != null)
                {
                    addressObject["street_address"] = ExpressionConverter.ConvertO(bodyprofileaddressstreetAddress);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresslocality != null)
                {
                    addressObject["locality"] = ExpressionConverter.ConvertO(bodyprofileaddresslocality);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddressregion != null)
                {
                    addressObject["region"] = ExpressionConverter.ConvertO(bodyprofileaddressregion);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresspostalCode != null)
                {
                    addressObject["postal_code"] = ExpressionConverter.ConvertO(bodyprofileaddresspostalCode);
                    addressObjectpropCount++;
                }

                if (bodyprofileaddresscountry != null)
                {
                    addressObject["country"] = ExpressionConverter.ConvertO(bodyprofileaddresscountry);
                    addressObjectpropCount++;
                }

                if (addressObjectpropCount > 0)
                {
                    profileObject["address"] = addressObject;
                    profileObjectpropCount++;
                }

                if (bodyprofilebirthdate != null)
                {
                    profileObject["birthdate"] = ExpressionConverter.ConvertO(bodyprofilebirthdate);
                    profileObjectpropCount++;
                }

                if (bodyprofileemailVerified != null)
                {
                    profileObject["email_verified"] = ExpressionConverter.ConvertO(bodyprofileemailVerified);
                    profileObjectpropCount++;
                }

                if (bodyprofilephoneNumberVerified != null)
                {
                    profileObject["phone_number_verified"] = ExpressionConverter.ConvertO(bodyprofilephoneNumberVerified);
                    profileObjectpropCount++;
                }

                if (bodyprofilegivenName != null)
                {
                    profileObject["given_name"] = ExpressionConverter.ConvertO(bodyprofilegivenName);
                    profileObjectpropCount++;
                }

                if (bodyprofilemiddleName != null)
                {
                    profileObject["middle_name"] = ExpressionConverter.ConvertO(bodyprofilemiddleName);
                    profileObjectpropCount++;
                }

                if (bodyprofilefamilyName != null)
                {
                    profileObject["family_name"] = ExpressionConverter.ConvertO(bodyprofilefamilyName);
                    profileObjectpropCount++;
                }

                if (bodyprofilepreferredName != null)
                {
                    profileObject["preferred_name"] = ExpressionConverter.ConvertO(bodyprofilepreferredName);
                    profileObjectpropCount++;
                }

                if (bodyprofilegender != null)
                {
                    profileObject["gender"] = ExpressionConverter.ConvertO(bodyprofilegender);
                    profileObjectpropCount++;
                }

                if (bodyprofilelocale != null)
                {
                    profileObject["locale"] = ExpressionConverter.ConvertO(bodyprofilelocale);
                    profileObjectpropCount++;
                }

                if (bodyprofilepicture != null)
                {
                    profileObject["picture"] = ExpressionConverter.ConvertO(bodyprofilepicture);
                    profileObjectpropCount++;
                }

                if (bodyprofileprofile != null)
                {
                    profileObject["profile"] = ExpressionConverter.ConvertO(bodyprofileprofile);
                    profileObjectpropCount++;
                }

                if (bodyprofilesub != null)
                {
                    profileObject["sub"] = ExpressionConverter.ConvertO(bodyprofilesub);
                    profileObjectpropCount++;
                }

                if (bodyprofileupdatedAt != null)
                {
                    profileObject["updated_at"] = ExpressionConverter.ConvertO(bodyprofileupdatedAt);
                    profileObjectpropCount++;
                }

                if (bodyprofilewebsite != null)
                {
                    profileObject["website"] = ExpressionConverter.ConvertO(bodyprofilewebsite);
                    profileObjectpropCount++;
                }

                if (bodyprofilezoneinfo != null)
                {
                    profileObject["zoneinfo"] = ExpressionConverter.ConvertO(bodyprofilezoneinfo);
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
                    audienceObject["named_user"] = ExpressionConverter.ConvertO(bodyprofileairshipaudiencenamedUser);
                    audienceObjectpropCount++;
                }

                if (audienceObjectpropCount > 0)
                {
                    airshipObject["audience"] = audienceObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipdeviceTypes != null)
                {
                    airshipObject["device_types"] = ExpressionConverter.ConvertO(bodyprofileairshipdeviceTypes);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipapn != null)
                {
                    airshipObject["apn"] = ExpressionConverter.ConvertO(bodyprofileairshipapn);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshiptargetArn != null)
                {
                    airshipObject["target_arn"] = ExpressionConverter.ConvertO(bodyprofileairshiptargetArn);
                    airshipObjectpropCount++;
                }

                var discordObject = new JObject();
                var discordObjectpropCount = 0;
                if (bodyprofileairshipdiscordchannelId != null)
                {
                    discordObject["channel_id"] = ExpressionConverter.ConvertO(bodyprofileairshipdiscordchannelId);
                    discordObjectpropCount++;
                }

                if (bodyprofileairshipdiscorduserId != null)
                {
                    discordObject["user_id"] = ExpressionConverter.ConvertO(bodyprofileairshipdiscorduserId);
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
                    expoObject["token"] = ExpressionConverter.ConvertO(bodyprofileairshipexpotoken);
                    expoObjectpropCount++;
                }

                if (bodyprofileairshipexpotokens != null)
                {
                    expoObject["tokens"] = ExpressionConverter.ConvertO(bodyprofileairshipexpotokens);
                    expoObjectpropCount++;
                }

                if (expoObjectpropCount > 0)
                {
                    airshipObject["expo"] = expoObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipfacebookPSID != null)
                {
                    airshipObject["facebookPSID"] = ExpressionConverter.ConvertO(bodyprofileairshipfacebookPSID);
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshipfirebaseToken != null)
                {
                    airshipObject["firebaseToken"] = ExpressionConverter.ConvertO(bodyprofileairshipfirebaseToken);
                    airshipObjectpropCount++;
                }

                var intercomObject = new JObject();
                var intercomObjectpropCount = 0;
                if (bodyprofileairshipintercomfrom != null)
                {
                    intercomObject["from"] = ExpressionConverter.ConvertO(bodyprofileairshipintercomfrom);
                    intercomObjectpropCount++;
                }

                var toObject = new JObject();
                var toObjectpropCount = 0;
                if (bodyprofileairshipintercomtoid != null)
                {
                    toObject["id"] = ExpressionConverter.ConvertO(bodyprofileairshipintercomtoid);
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
                    msTeamsObject["user_id"] = ExpressionConverter.ConvertO(bodyprofileairshipmsTeamsuserId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamsconversationId != null)
                {
                    msTeamsObject["conversation_id"] = ExpressionConverter.ConvertO(bodyprofileairshipmsTeamsconversationId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamstenantId != null)
                {
                    msTeamsObject["tenant_id"] = ExpressionConverter.ConvertO(bodyprofileairshipmsTeamstenantId);
                    msTeamsObjectpropCount++;
                }

                if (bodyprofileairshipmsTeamsserviceUrl != null)
                {
                    msTeamsObject["service_url"] = ExpressionConverter.ConvertO(bodyprofileairshipmsTeamsserviceUrl);
                    msTeamsObjectpropCount++;
                }

                if (msTeamsObjectpropCount > 0)
                {
                    airshipObject["ms_teams"] = msTeamsObject;
                    airshipObjectpropCount++;
                }

                if (bodyprofileairshiponeSignalPlayerID != null)
                {
                    airshipObject["oneSignalPlayerID"] = ExpressionConverter.ConvertO(bodyprofileairshiponeSignalPlayerID);
                    airshipObjectpropCount++;
                }

                var slackObject = new JObject();
                var slackObjectpropCount = 0;
                if (bodyprofileairshipslackaccessToken != null)
                {
                    slackObject["access_token"] = ExpressionConverter.ConvertO(bodyprofileairshipslackaccessToken);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackchannel != null)
                {
                    slackObject["channel"] = ExpressionConverter.ConvertO(bodyprofileairshipslackchannel);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackemail != null)
                {
                    slackObject["email"] = ExpressionConverter.ConvertO(bodyprofileairshipslackemail);
                    slackObjectpropCount++;
                }

                if (bodyprofileairshipslackuserId != null)
                {
                    slackObject["user_id"] = ExpressionConverter.ConvertO(bodyprofileairshipslackuserId);
                    slackObjectpropCount++;
                }

                var incomingWebhookObject = new JObject();
                var incomingWebhookObjectpropCount = 0;
                if (bodyprofileairshipslackincomingWebhookurl != null)
                {
                    incomingWebhookObject["url"] = ExpressionConverter.ConvertO(bodyprofileairshipslackincomingWebhookurl);
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
                    webhookObject["url"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookurl);
                    webhookObjectpropCount++;
                }

                if (bodyprofileairshipwebhookmethod != null)
                {
                    webhookObject["method"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookmethod);
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
                    authenticationObject["mode"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookauthenticationmode);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationusername != null)
                {
                    authenticationObject["username"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookauthenticationusername);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationpassword != null)
                {
                    authenticationObject["password"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookauthenticationpassword);
                    authenticationObjectpropCount++;
                }

                if (bodyprofileairshipwebhookauthenticationtoken != null)
                {
                    authenticationObject["token"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookauthenticationtoken);
                    authenticationObjectpropCount++;
                }

                if (authenticationObjectpropCount > 0)
                {
                    webhookObject["authentication"] = authenticationObject;
                    webhookObjectpropCount++;
                }

                if (bodyprofileairshipwebhookprofile != null)
                {
                    webhookObject["profile"] = ExpressionConverter.ConvertO(bodyprofileairshipwebhookprofile);
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
        [WorkflowExpressionFactory(nameof(__BuildProfilePatch))]
        public IBodyWorkflowAction<ProfilePatchResponse> ProfilePatch([WorkflowExpression] Func<string> recipientId, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ProfilePatchResponse> __BuildProfilePatch(WorkflowExpression<string> recipientId, WorkflowExpression<bodyInputItem[]> body = null)
        {
            WorkflowExpression.Validate(recipientId, nameof(recipientId), required: true);
            WorkflowExpression.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<ProfilePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}", ExpressionConverter.ConvertWithUrlEncoding(recipientId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(body);
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