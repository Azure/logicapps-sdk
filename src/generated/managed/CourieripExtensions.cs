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
        public IBodyWorkflowAction<MessageSendPostResponse> MessageSend(Expression<Func<string>> idempotency, Expression<Func<string>> bodymessagecontenttitle = null, Expression<Func<string>> bodymessagecontentbody = null, Expression<Func<string>> bodymessagetouserId = null, Expression<Func<string>> bodymessagetolistId = null, Expression<Func<string>> bodymessagetoaudienceId = null, Expression<Func<string>> bodymessagetoemail = null, Expression<Func<string>> bodymessagetophoneNumber = null, Expression<Func<string>> bodymessagetolocale = null)
        {
            var apiCallPath = "/send";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["idempotency"] = CSharpExpressionConverter.ConvertO(idempotency);
            var body = new JObject();
            var bodypropCount = 0;
            var messageObject = new JObject();
            var messageObjectpropCount = 0;
            var contentObject = new JObject();
            var contentObjectpropCount = 0;
            if (bodymessagecontenttitle != null)
            {
                contentObject["title"] = CSharpExpressionConverter.ConvertToken(bodymessagecontenttitle);
                contentObjectpropCount++;
            }

            if (bodymessagecontentbody != null)
            {
                contentObject["body"] = CSharpExpressionConverter.ConvertToken(bodymessagecontentbody);
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
                toObject["user_id"] = CSharpExpressionConverter.ConvertToken(bodymessagetouserId);
                toObjectpropCount++;
            }

            if (bodymessagetolistId != null)
            {
                toObject["list_id"] = CSharpExpressionConverter.ConvertToken(bodymessagetolistId);
                toObjectpropCount++;
            }

            if (bodymessagetoaudienceId != null)
            {
                toObject["audience_id"] = CSharpExpressionConverter.ConvertToken(bodymessagetoaudienceId);
                toObjectpropCount++;
            }

            if (bodymessagetoemail != null)
            {
                toObject["email"] = CSharpExpressionConverter.ConvertToken(bodymessagetoemail);
                toObjectpropCount++;
            }

            if (bodymessagetophoneNumber != null)
            {
                toObject["phone_number"] = CSharpExpressionConverter.ConvertToken(bodymessagetophoneNumber);
                toObjectpropCount++;
            }

            if (bodymessagetolocale != null)
            {
                toObject["locale"] = CSharpExpressionConverter.ConvertToken(bodymessagetolocale);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceGetResponse> AudienceGet(Expression<Func<string>> audienceId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/audiences/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AudienceGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> AudienceDelete(Expression<Func<string>> audienceId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/audiences/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencePutResponse> AudiencePut(Expression<Func<string>> audienceId, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfilterpath = null, Expression<Func<string>> bodyfilterOperator = null, Expression<Func<string>> bodyfiltervalue = null, Expression<Func<bodyfilterfiltersInputItem[]>> bodyfilterfilters = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/audiences/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
            }

            var filterObject = new JObject();
            var filterObjectpropCount = 0;
            if (bodyfilterpath != null)
            {
                filterObject["path"] = CSharpExpressionConverter.ConvertToken(bodyfilterpath);
                filterObjectpropCount++;
            }

            if (bodyfilterOperator != null)
            {
                filterObject["operator"] = CSharpExpressionConverter.ConvertToken(bodyfilterOperator);
                filterObjectpropCount++;
            }

            if (bodyfiltervalue != null)
            {
                filterObject["value"] = CSharpExpressionConverter.ConvertToken(bodyfiltervalue);
                filterObjectpropCount++;
            }

            if (bodyfilterfilters != null)
            {
                filterObject["filters"] = CSharpExpressionConverter.ConvertToken(bodyfilterfilters);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudienceMembersGetResponse> AudienceMembersGet(Expression<Func<string>> audienceId, Expression<Func<string>> cursor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/audiences/{0}/members", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(audienceId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<AudienceMembersGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AudiencesGetResponse> AudiencesGet(Expression<Func<string>> cursor = null)
        {
            var apiCallPath = "/audiences";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<AudiencesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventsGetResponse> AuditEventsGet(Expression<Func<string>> cursor = null)
        {
            var apiCallPath = "/audit-events";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<AuditEventsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AuditEventGetResponse> AuditEventGet(Expression<Func<string>> auditEventId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/audit-events/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(auditEventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AuditEventGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationTemplatedPostResponse> AutomationTemplated(Expression<Func<string>> templateId, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/automations/{0}/invoke", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodybrand != null)
            {
                body["brand"] = CSharpExpressionConverter.ConvertToken(bodybrand);
                bodypropCount++;
            }

            if (bodytemplate != null)
            {
                body["template"] = CSharpExpressionConverter.ConvertToken(bodytemplate);
                bodypropCount++;
            }

            if (bodyrecipient != null)
            {
                body["recipient"] = CSharpExpressionConverter.ConvertToken(bodyrecipient);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<AutomationAdHocPostResponse> AutomationAdHoc(Expression<Func<JToken[]>> bodyautomationsteps = null, Expression<Func<string>> bodyautomationcancelationToken = null, Expression<Func<string>> bodybrand = null, Expression<Func<string>> bodytemplate = null, Expression<Func<string>> bodyrecipient = null)
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
                automationObject["steps"] = CSharpExpressionConverter.ConvertToken(bodyautomationsteps);
                automationObjectpropCount++;
            }

            if (bodyautomationcancelationToken != null)
            {
                automationObject["cancelation_token"] = CSharpExpressionConverter.ConvertToken(bodyautomationcancelationToken);
                automationObjectpropCount++;
            }

            if (automationObjectpropCount > 0)
            {
                body["automation"] = automationObject;
                bodypropCount++;
            }

            if (bodybrand != null)
            {
                body["brand"] = CSharpExpressionConverter.ConvertToken(bodybrand);
                bodypropCount++;
            }

            if (bodytemplate != null)
            {
                body["template"] = CSharpExpressionConverter.ConvertToken(bodytemplate);
                bodypropCount++;
            }

            if (bodyrecipient != null)
            {
                body["recipient"] = CSharpExpressionConverter.ConvertToken(bodyrecipient);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandsGetResponse> BrandsGet(Expression<Func<string>> cursor = null)
        {
            var apiCallPath = "/brands";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<BrandsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> Brand(Expression<Func<string>> bodyname, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodysettingscolorsprimary = null, Expression<Func<string>> bodysettingscolorssecondary = null, Expression<Func<string>> bodysettingscolorstertiary = null, Expression<Func<string>> bodysettingsemailheaderbarColor = null, Expression<Func<string>> bodysettingsemailheaderlogohref = null, Expression<Func<string>> bodysettingsemailheaderlogoimage = null, Expression<Func<string>> bodysettingsemailfootermarkdown = null, Expression<Func<string>> bodysettingsemailfootersocialfacebookurl = null, Expression<Func<string>> bodysettingsemailfootersocialinstagramurl = null, Expression<Func<string>> bodysettingsemailfootersociallinkedinurl = null, Expression<Func<string>> bodysettingsemailfootersocialmediumurl = null, Expression<Func<string>> bodysettingsemailfootersocialtwitterurl = null, Expression<Func<bool>> bodysettingsinappdisableMessageIcon = null, Expression<Func<string>> bodysettingsinappplacement = null, Expression<Func<string[]>> bodysnippetsitems = null)
        {
            var apiCallPath = "/brands";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyid != null)
            {
                body["id"] = CSharpExpressionConverter.ConvertToken(bodyid);
                bodypropCount++;
            }

            bodypropCount++;
            body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
            var settingsObject = new JObject();
            var settingsObjectpropCount = 0;
            var colorsObject = new JObject();
            var colorsObjectpropCount = 0;
            if (bodysettingscolorsprimary != null)
            {
                colorsObject["primary"] = CSharpExpressionConverter.ConvertToken(bodysettingscolorsprimary);
                colorsObjectpropCount++;
            }

            if (bodysettingscolorssecondary != null)
            {
                colorsObject["secondary"] = CSharpExpressionConverter.ConvertToken(bodysettingscolorssecondary);
                colorsObjectpropCount++;
            }

            if (bodysettingscolorstertiary != null)
            {
                colorsObject["tertiary"] = CSharpExpressionConverter.ConvertToken(bodysettingscolorstertiary);
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
                headerObject["barColor"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailheaderbarColor);
                headerObjectpropCount++;
            }

            var logoObject = new JObject();
            var logoObjectpropCount = 0;
            if (bodysettingsemailheaderlogohref != null)
            {
                logoObject["href"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailheaderlogohref);
                logoObjectpropCount++;
            }

            if (bodysettingsemailheaderlogoimage != null)
            {
                logoObject["image"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailheaderlogoimage);
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
                footerObject["markdown"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootermarkdown);
                footerObjectpropCount++;
            }

            var socialObject = new JObject();
            var socialObjectpropCount = 0;
            var facebookObject = new JObject();
            var facebookObjectpropCount = 0;
            if (bodysettingsemailfootersocialfacebookurl != null)
            {
                facebookObject["url"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootersocialfacebookurl);
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
                instagramObject["url"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootersocialinstagramurl);
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
                linkedinObject["url"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootersociallinkedinurl);
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
                mediumObject["url"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootersocialmediumurl);
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
                twitterObject["url"] = CSharpExpressionConverter.ConvertToken(bodysettingsemailfootersocialtwitterurl);
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
                inappObject["disableMessageIcon"] = CSharpExpressionConverter.ConvertToken(bodysettingsinappdisableMessageIcon);
                inappObjectpropCount++;
            }

            if (bodysettingsinappplacement != null)
            {
                inappObject["placement"] = CSharpExpressionConverter.ConvertToken(bodysettingsinappplacement);
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
                snippetsObject["items"] = CSharpExpressionConverter.ConvertToken(bodysnippetsitems);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BrandGetResponse> BrandGet(Expression<Func<string>> brandId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/brands/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(brandId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BrandGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobPostResponse> BulkJob(Expression<Func<string>> bodymessageEvent = null, Expression<Func<string>> bodymessagebrand = null, Expression<Func<string>> bodymessagetemplate = null, Expression<Func<string>> bodymessagebrandId = null, Expression<Func<string>> bodymessageroutingmethod = null, Expression<Func<string[]>> bodymessageroutingchannels = null, Expression<Func<string>> bodymessagemetadataEvent = null, Expression<Func<string[]>> bodymessagemetadatatags = null, Expression<Func<string>> bodymessagemetadatatraceId = null, Expression<Func<string>> bodymessagemetadatautmcampaign = null, Expression<Func<string>> bodymessagemetadatautmcontent = null, Expression<Func<string>> bodymessagemetadatautmmedium = null, Expression<Func<string>> bodymessagemetadatautmsource = null, Expression<Func<string>> bodymessagemetadatautmterm = null)
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
                messageObject["event"] = CSharpExpressionConverter.ConvertToken(bodymessageEvent);
                messageObjectpropCount++;
            }

            if (bodymessagebrand != null)
            {
                messageObject["brand"] = CSharpExpressionConverter.ConvertToken(bodymessagebrand);
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
                messageObject["template"] = CSharpExpressionConverter.ConvertToken(bodymessagetemplate);
                messageObjectpropCount++;
            }

            if (bodymessagebrandId != null)
            {
                messageObject["brand_id"] = CSharpExpressionConverter.ConvertToken(bodymessagebrandId);
                messageObjectpropCount++;
            }

            var routingObject = new JObject();
            var routingObjectpropCount = 0;
            if (bodymessageroutingmethod != null)
            {
                routingObject["method"] = CSharpExpressionConverter.ConvertToken(bodymessageroutingmethod);
                routingObjectpropCount++;
            }

            if (bodymessageroutingchannels != null)
            {
                routingObject["channels"] = CSharpExpressionConverter.ConvertToken(bodymessageroutingchannels);
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
                metadataObject["event"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadataEvent);
                metadataObjectpropCount++;
            }

            if (bodymessagemetadatatags != null)
            {
                metadataObject["tags"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatatags);
                metadataObjectpropCount++;
            }

            if (bodymessagemetadatatraceId != null)
            {
                metadataObject["trace_id"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatatraceId);
                metadataObjectpropCount++;
            }

            var utmObject = new JObject();
            var utmObjectpropCount = 0;
            if (bodymessagemetadatautmcampaign != null)
            {
                utmObject["campaign"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatautmcampaign);
                utmObjectpropCount++;
            }

            if (bodymessagemetadatautmcontent != null)
            {
                utmObject["content"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatautmcontent);
                utmObjectpropCount++;
            }

            if (bodymessagemetadatautmmedium != null)
            {
                utmObject["medium"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatautmmedium);
                utmObjectpropCount++;
            }

            if (bodymessagemetadatautmsource != null)
            {
                utmObject["source"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatautmsource);
                utmObjectpropCount++;
            }

            if (bodymessagemetadatautmterm != null)
            {
                utmObject["term"] = CSharpExpressionConverter.ConvertToken(bodymessagemetadatautmterm);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobGetResponse> BulkJobGet(Expression<Func<string>> jobId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/bulk/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BulkJobGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> BulkJobUsers(Expression<Func<string>> jobId, Expression<Func<bodyusersInputItem[]>> bodyusers = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/bulk/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyusers != null)
            {
                body["users"] = CSharpExpressionConverter.ConvertToken(bodyusers);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<JToken> BulkJobRun(Expression<Func<string>> jobId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/bulk/{0}/run", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<BulkJobUsersGetResponse> BulkJobUsersGet(Expression<Func<string>> jobId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/bulk/{0}/users", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(jobId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<BulkJobUsersGetResponse>(callPayload);
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
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListDelete(Expression<Func<string>> listId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListPut(Expression<Func<string>> listId, Expression<Func<string>> bodyname = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = CSharpExpressionConverter.ConvertToken(bodyname);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListRestorePut(Expression<Func<string>> listId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/restore", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ListSubscriptionsGetResponse> ListSubscriptionsGet(Expression<Func<string>> listId, Expression<Func<string>> cursor = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<ListSubscriptionsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListSubscribers(Expression<Func<string>> listId, Expression<Func<bodyrecipientsInputItem[]>> bodyrecipients = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyrecipients != null)
            {
                body["recipients"] = CSharpExpressionConverter.ConvertToken(bodyrecipients);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> ListSubscribeDelete(Expression<Func<string>> listId, Expression<Func<string>> recipientId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/lists/{0}/subscriptions/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(listId, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessagesGetResponse> MessagesGet(Expression<Func<bool>> archived = null, Expression<Func<string>> cursor = null, Expression<Func<string>> @event = null, Expression<Func<string>> list = null, Expression<Func<string>> messageId = null, Expression<Func<string>> notification = null, Expression<Func<string>> recipient = null, Expression<Func<string>> status = null, Expression<Func<string>> tags = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (archived != null)
                callPayload.Queries["archived"] = CSharpExpressionConverter.ConvertO(archived);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            if (@event != null)
                callPayload.Queries["event"] = CSharpExpressionConverter.ConvertO(@event);
            if (list != null)
                callPayload.Queries["list"] = CSharpExpressionConverter.ConvertO(list);
            if (messageId != null)
                callPayload.Queries["messageId"] = CSharpExpressionConverter.ConvertO(messageId);
            if (notification != null)
                callPayload.Queries["notification"] = CSharpExpressionConverter.ConvertO(notification);
            if (recipient != null)
                callPayload.Queries["recipient"] = CSharpExpressionConverter.ConvertO(recipient);
            if (status != null)
                callPayload.Queries["status"] = CSharpExpressionConverter.ConvertO(status);
            if (tags != null)
                callPayload.Queries["tags"] = CSharpExpressionConverter.ConvertO(tags);
            return new ApiConnectionAction<MessagesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageGetResponse> MessageGet(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/messages/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageHistoryGetResponse> MessageHistoryGet(Expression<Func<string>> messageId, Expression<Func<string>> type = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/messages/{0}/history", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (type != null)
                callPayload.Queries["type"] = CSharpExpressionConverter.ConvertO(type);
            return new ApiConnectionAction<MessageHistoryGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<MessageContentGetResponse> MessageContentGet(Expression<Func<string>> messageId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/messages/{0}/output", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(messageId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<MessageContentGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> MessagePut(Expression<Func<string>> requestId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/requests/{0}/archive", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(requestId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<string>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<NotificationsGetResponse> NotificationsGet(Expression<Func<string>> cursor = null)
        {
            var apiCallPath = "/notifications";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (cursor != null)
                callPayload.Queries["cursor"] = CSharpExpressionConverter.ConvertO(cursor);
            return new ApiConnectionAction<NotificationsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileGetResponse> ProfileGet(Expression<Func<string>> recipientId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProfileGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfileDeleteResponse> ProfileDelete(Expression<Func<string>> recipientId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ProfileDeleteResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<string> Profile(Expression<Func<string>> recipientId, Expression<Func<string>> bodyprofileemail = null, Expression<Func<string>> bodyprofilephoneNumber = null, Expression<Func<string>> bodyprofileaddressformatted = null, Expression<Func<string>> bodyprofileaddressstreetAddress = null, Expression<Func<string>> bodyprofileaddresslocality = null, Expression<Func<string>> bodyprofileaddressregion = null, Expression<Func<string>> bodyprofileaddresspostalCode = null, Expression<Func<string>> bodyprofileaddresscountry = null, Expression<Func<string>> bodyprofilebirthdate = null, Expression<Func<bool>> bodyprofileemailVerified = null, Expression<Func<bool>> bodyprofilephoneNumberVerified = null, Expression<Func<string>> bodyprofilegivenName = null, Expression<Func<string>> bodyprofilemiddleName = null, Expression<Func<string>> bodyprofilefamilyName = null, Expression<Func<string>> bodyprofilepreferredName = null, Expression<Func<string>> bodyprofilegender = null, Expression<Func<string>> bodyprofilelocale = null, Expression<Func<string>> bodyprofilepicture = null, Expression<Func<string>> bodyprofileprofile = null, Expression<Func<string>> bodyprofilesub = null, Expression<Func<string>> bodyprofileupdatedAt = null, Expression<Func<string>> bodyprofilewebsite = null, Expression<Func<string>> bodyprofilezoneinfo = null, Expression<Func<string>> bodyprofileairshipaudiencenamedUser = null, Expression<Func<string[]>> bodyprofileairshipdeviceTypes = null, Expression<Func<string>> bodyprofileairshipapn = null, Expression<Func<string>> bodyprofileairshiptargetArn = null, Expression<Func<string>> bodyprofileairshipdiscordchannelId = null, Expression<Func<string>> bodyprofileairshipdiscorduserId = null, Expression<Func<string>> bodyprofileairshipexpotoken = null, Expression<Func<string[]>> bodyprofileairshipexpotokens = null, Expression<Func<string>> bodyprofileairshipfacebookPSID = null, Expression<Func<string>> bodyprofileairshipfirebaseToken = null, Expression<Func<string>> bodyprofileairshipintercomfrom = null, Expression<Func<string>> bodyprofileairshipintercomtoid = null, Expression<Func<string>> bodyprofileairshipmsTeamsuserId = null, Expression<Func<string>> bodyprofileairshipmsTeamsconversationId = null, Expression<Func<string>> bodyprofileairshipmsTeamstenantId = null, Expression<Func<string>> bodyprofileairshipmsTeamsserviceUrl = null, Expression<Func<string>> bodyprofileairshiponeSignalPlayerID = null, Expression<Func<string>> bodyprofileairshipslackaccessToken = null, Expression<Func<string>> bodyprofileairshipslackchannel = null, Expression<Func<string>> bodyprofileairshipslackemail = null, Expression<Func<string>> bodyprofileairshipslackuserId = null, Expression<Func<string>> bodyprofileairshipslackincomingWebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookurl = null, Expression<Func<string>> bodyprofileairshipwebhookmethod = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationmode = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationusername = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationpassword = null, Expression<Func<string>> bodyprofileairshipwebhookauthenticationtoken = null, Expression<Func<string>> bodyprofileairshipwebhookprofile = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            var profileObject = new JObject();
            var profileObjectpropCount = 0;
            if (bodyprofileemail != null)
            {
                profileObject["email"] = CSharpExpressionConverter.ConvertToken(bodyprofileemail);
                profileObjectpropCount++;
            }

            if (bodyprofilephoneNumber != null)
            {
                profileObject["phone_number"] = CSharpExpressionConverter.ConvertToken(bodyprofilephoneNumber);
                profileObjectpropCount++;
            }

            var addressObject = new JObject();
            var addressObjectpropCount = 0;
            if (bodyprofileaddressformatted != null)
            {
                addressObject["formatted"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddressformatted);
                addressObjectpropCount++;
            }

            if (bodyprofileaddressstreetAddress != null)
            {
                addressObject["street_address"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddressstreetAddress);
                addressObjectpropCount++;
            }

            if (bodyprofileaddresslocality != null)
            {
                addressObject["locality"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddresslocality);
                addressObjectpropCount++;
            }

            if (bodyprofileaddressregion != null)
            {
                addressObject["region"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddressregion);
                addressObjectpropCount++;
            }

            if (bodyprofileaddresspostalCode != null)
            {
                addressObject["postal_code"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddresspostalCode);
                addressObjectpropCount++;
            }

            if (bodyprofileaddresscountry != null)
            {
                addressObject["country"] = CSharpExpressionConverter.ConvertToken(bodyprofileaddresscountry);
                addressObjectpropCount++;
            }

            if (addressObjectpropCount > 0)
            {
                profileObject["address"] = addressObject;
                profileObjectpropCount++;
            }

            if (bodyprofilebirthdate != null)
            {
                profileObject["birthdate"] = CSharpExpressionConverter.ConvertToken(bodyprofilebirthdate);
                profileObjectpropCount++;
            }

            if (bodyprofileemailVerified != null)
            {
                profileObject["email_verified"] = CSharpExpressionConverter.ConvertToken(bodyprofileemailVerified);
                profileObjectpropCount++;
            }

            if (bodyprofilephoneNumberVerified != null)
            {
                profileObject["phone_number_verified"] = CSharpExpressionConverter.ConvertToken(bodyprofilephoneNumberVerified);
                profileObjectpropCount++;
            }

            if (bodyprofilegivenName != null)
            {
                profileObject["given_name"] = CSharpExpressionConverter.ConvertToken(bodyprofilegivenName);
                profileObjectpropCount++;
            }

            if (bodyprofilemiddleName != null)
            {
                profileObject["middle_name"] = CSharpExpressionConverter.ConvertToken(bodyprofilemiddleName);
                profileObjectpropCount++;
            }

            if (bodyprofilefamilyName != null)
            {
                profileObject["family_name"] = CSharpExpressionConverter.ConvertToken(bodyprofilefamilyName);
                profileObjectpropCount++;
            }

            if (bodyprofilepreferredName != null)
            {
                profileObject["preferred_name"] = CSharpExpressionConverter.ConvertToken(bodyprofilepreferredName);
                profileObjectpropCount++;
            }

            if (bodyprofilegender != null)
            {
                profileObject["gender"] = CSharpExpressionConverter.ConvertToken(bodyprofilegender);
                profileObjectpropCount++;
            }

            if (bodyprofilelocale != null)
            {
                profileObject["locale"] = CSharpExpressionConverter.ConvertToken(bodyprofilelocale);
                profileObjectpropCount++;
            }

            if (bodyprofilepicture != null)
            {
                profileObject["picture"] = CSharpExpressionConverter.ConvertToken(bodyprofilepicture);
                profileObjectpropCount++;
            }

            if (bodyprofileprofile != null)
            {
                profileObject["profile"] = CSharpExpressionConverter.ConvertToken(bodyprofileprofile);
                profileObjectpropCount++;
            }

            if (bodyprofilesub != null)
            {
                profileObject["sub"] = CSharpExpressionConverter.ConvertToken(bodyprofilesub);
                profileObjectpropCount++;
            }

            if (bodyprofileupdatedAt != null)
            {
                profileObject["updated_at"] = CSharpExpressionConverter.ConvertToken(bodyprofileupdatedAt);
                profileObjectpropCount++;
            }

            if (bodyprofilewebsite != null)
            {
                profileObject["website"] = CSharpExpressionConverter.ConvertToken(bodyprofilewebsite);
                profileObjectpropCount++;
            }

            if (bodyprofilezoneinfo != null)
            {
                profileObject["zoneinfo"] = CSharpExpressionConverter.ConvertToken(bodyprofilezoneinfo);
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
                audienceObject["named_user"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipaudiencenamedUser);
                audienceObjectpropCount++;
            }

            if (audienceObjectpropCount > 0)
            {
                airshipObject["audience"] = audienceObject;
                airshipObjectpropCount++;
            }

            if (bodyprofileairshipdeviceTypes != null)
            {
                airshipObject["device_types"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipdeviceTypes);
                airshipObjectpropCount++;
            }

            if (bodyprofileairshipapn != null)
            {
                airshipObject["apn"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipapn);
                airshipObjectpropCount++;
            }

            if (bodyprofileairshiptargetArn != null)
            {
                airshipObject["target_arn"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshiptargetArn);
                airshipObjectpropCount++;
            }

            var discordObject = new JObject();
            var discordObjectpropCount = 0;
            if (bodyprofileairshipdiscordchannelId != null)
            {
                discordObject["channel_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipdiscordchannelId);
                discordObjectpropCount++;
            }

            if (bodyprofileairshipdiscorduserId != null)
            {
                discordObject["user_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipdiscorduserId);
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
                expoObject["token"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipexpotoken);
                expoObjectpropCount++;
            }

            if (bodyprofileairshipexpotokens != null)
            {
                expoObject["tokens"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipexpotokens);
                expoObjectpropCount++;
            }

            if (expoObjectpropCount > 0)
            {
                airshipObject["expo"] = expoObject;
                airshipObjectpropCount++;
            }

            if (bodyprofileairshipfacebookPSID != null)
            {
                airshipObject["facebookPSID"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipfacebookPSID);
                airshipObjectpropCount++;
            }

            if (bodyprofileairshipfirebaseToken != null)
            {
                airshipObject["firebaseToken"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipfirebaseToken);
                airshipObjectpropCount++;
            }

            var intercomObject = new JObject();
            var intercomObjectpropCount = 0;
            if (bodyprofileairshipintercomfrom != null)
            {
                intercomObject["from"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipintercomfrom);
                intercomObjectpropCount++;
            }

            var toObject = new JObject();
            var toObjectpropCount = 0;
            if (bodyprofileairshipintercomtoid != null)
            {
                toObject["id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipintercomtoid);
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
                msTeamsObject["user_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsuserId);
                msTeamsObjectpropCount++;
            }

            if (bodyprofileairshipmsTeamsconversationId != null)
            {
                msTeamsObject["conversation_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsconversationId);
                msTeamsObjectpropCount++;
            }

            if (bodyprofileairshipmsTeamstenantId != null)
            {
                msTeamsObject["tenant_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipmsTeamstenantId);
                msTeamsObjectpropCount++;
            }

            if (bodyprofileairshipmsTeamsserviceUrl != null)
            {
                msTeamsObject["service_url"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipmsTeamsserviceUrl);
                msTeamsObjectpropCount++;
            }

            if (msTeamsObjectpropCount > 0)
            {
                airshipObject["ms_teams"] = msTeamsObject;
                airshipObjectpropCount++;
            }

            if (bodyprofileairshiponeSignalPlayerID != null)
            {
                airshipObject["oneSignalPlayerID"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshiponeSignalPlayerID);
                airshipObjectpropCount++;
            }

            var slackObject = new JObject();
            var slackObjectpropCount = 0;
            if (bodyprofileairshipslackaccessToken != null)
            {
                slackObject["access_token"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipslackaccessToken);
                slackObjectpropCount++;
            }

            if (bodyprofileairshipslackchannel != null)
            {
                slackObject["channel"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipslackchannel);
                slackObjectpropCount++;
            }

            if (bodyprofileairshipslackemail != null)
            {
                slackObject["email"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipslackemail);
                slackObjectpropCount++;
            }

            if (bodyprofileairshipslackuserId != null)
            {
                slackObject["user_id"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipslackuserId);
                slackObjectpropCount++;
            }

            var incomingWebhookObject = new JObject();
            var incomingWebhookObjectpropCount = 0;
            if (bodyprofileairshipslackincomingWebhookurl != null)
            {
                incomingWebhookObject["url"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipslackincomingWebhookurl);
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
                webhookObject["url"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookurl);
                webhookObjectpropCount++;
            }

            if (bodyprofileairshipwebhookmethod != null)
            {
                webhookObject["method"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookmethod);
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
                authenticationObject["mode"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationmode);
                authenticationObjectpropCount++;
            }

            if (bodyprofileairshipwebhookauthenticationusername != null)
            {
                authenticationObject["username"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationusername);
                authenticationObjectpropCount++;
            }

            if (bodyprofileairshipwebhookauthenticationpassword != null)
            {
                authenticationObject["password"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationpassword);
                authenticationObjectpropCount++;
            }

            if (bodyprofileairshipwebhookauthenticationtoken != null)
            {
                authenticationObject["token"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookauthenticationtoken);
                authenticationObjectpropCount++;
            }

            if (authenticationObjectpropCount > 0)
            {
                webhookObject["authentication"] = authenticationObject;
                webhookObjectpropCount++;
            }

            if (bodyprofileairshipwebhookprofile != null)
            {
                webhookObject["profile"] = CSharpExpressionConverter.ConvertToken(bodyprofileairshipwebhookprofile);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "courierip")]
        public IBodyWorkflowAction<ProfilePatchResponse> ProfilePatch(Expression<Func<string>> recipientId, Expression<Func<bodyInputItem[]>> body = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recipientId, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<ProfilePatchResponse>(callPayload);
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