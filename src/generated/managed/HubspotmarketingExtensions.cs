//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotmarketingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = "/marketing/v3/forms/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(20);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsCreate(Expression<Func<string>> dataformType = null, Expression<Func<string>> dataname = null, Expression<Func<string>> datacreatedAt = null, Expression<Func<string>> dataupdatedAt = null, Expression<Func<bool>> dataarchived = null, Expression<Func<string>> dataarchivedAt = null, Expression<Func<datafieldGroupsInputItem[]>> datafieldGroups = null, Expression<Func<string>> dataconfigurationlanguage = null, Expression<Func<bool>> dataconfigurationcloneable = null, Expression<Func<string>> dataconfigurationpostSubmitActiontype = null, Expression<Func<string>> dataconfigurationpostSubmitActionvalue = null, Expression<Func<bool>> dataconfigurationeditable = null, Expression<Func<bool>> dataconfigurationarchivable = null, Expression<Func<bool>> dataconfigurationrecaptchaEnabled = null, Expression<Func<bool>> dataconfigurationnotifyContactOwner = null, Expression<Func<string[]>> dataconfigurationnotifyRecipients = null, Expression<Func<bool>> dataconfigurationcreateNewContactForNewEmail = null, Expression<Func<bool>> dataconfigurationprePopulateKnownValues = null, Expression<Func<bool>> dataconfigurationallowLinkToResetKnownValues = null, Expression<Func<bool>> datadisplayOptionsrenderRawHtml = null, Expression<Func<string>> datadisplayOptionstheme = null, Expression<Func<string>> datadisplayOptionssubmitButtonText = null, Expression<Func<string>> datadisplayOptionsstylefontFamily = null, Expression<Func<string>> datadisplayOptionsstylebackgroundWidth = null, Expression<Func<string>> datadisplayOptionsstylelabelTextColor = null, Expression<Func<string>> datadisplayOptionsstylelabelTextSize = null, Expression<Func<string>> datadisplayOptionsstylehelpTextColor = null, Expression<Func<string>> datadisplayOptionsstylehelpTextSize = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextColor = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextSize = null, Expression<Func<string>> datadisplayOptionsstylesubmitColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitAlignment = null, Expression<Func<string>> datadisplayOptionsstylesubmitFontColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitSize = null, Expression<Func<string>> datadisplayOptionscssClass = null)
        {
            var apiCallPath = "/marketing/v3/forms/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            if (dataformType != null)
            {
                data["formType"] = ExpressionConverter.ConvertO(dataformType);
                datapropCount++;
            }

            if (dataname != null)
            {
                data["name"] = ExpressionConverter.ConvertO(dataname);
                datapropCount++;
            }

            if (datacreatedAt != null)
            {
                data["createdAt"] = ExpressionConverter.ConvertO(datacreatedAt);
                datapropCount++;
            }

            if (dataupdatedAt != null)
            {
                data["updatedAt"] = ExpressionConverter.ConvertO(dataupdatedAt);
                datapropCount++;
            }

            if (dataarchived != null)
            {
                data["archived"] = ExpressionConverter.ConvertO(dataarchived);
                datapropCount++;
            }

            if (dataarchivedAt != null)
            {
                data["archivedAt"] = ExpressionConverter.ConvertO(dataarchivedAt);
                datapropCount++;
            }

            if (datafieldGroups != null)
            {
                data["fieldGroups"] = ExpressionConverter.ConvertO(datafieldGroups);
                datapropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (dataconfigurationlanguage != null)
            {
                configurationObject["language"] = ExpressionConverter.ConvertO(dataconfigurationlanguage);
                configurationObjectpropCount++;
            }

            if (dataconfigurationcloneable != null)
            {
                configurationObject["cloneable"] = ExpressionConverter.ConvertO(dataconfigurationcloneable);
                configurationObjectpropCount++;
            }

            var postSubmitActionObject = new JObject();
            var postSubmitActionObjectpropCount = 0;
            if (dataconfigurationpostSubmitActiontype != null)
            {
                postSubmitActionObject["type"] = ExpressionConverter.ConvertO(dataconfigurationpostSubmitActiontype);
                postSubmitActionObjectpropCount++;
            }

            if (dataconfigurationpostSubmitActionvalue != null)
            {
                postSubmitActionObject["value"] = ExpressionConverter.ConvertO(dataconfigurationpostSubmitActionvalue);
                postSubmitActionObjectpropCount++;
            }

            if (postSubmitActionObjectpropCount > 0)
            {
                configurationObject["postSubmitAction"] = postSubmitActionObject;
                configurationObjectpropCount++;
            }

            if (dataconfigurationeditable != null)
            {
                configurationObject["editable"] = ExpressionConverter.ConvertO(dataconfigurationeditable);
                configurationObjectpropCount++;
            }

            if (dataconfigurationarchivable != null)
            {
                configurationObject["archivable"] = ExpressionConverter.ConvertO(dataconfigurationarchivable);
                configurationObjectpropCount++;
            }

            if (dataconfigurationrecaptchaEnabled != null)
            {
                configurationObject["recaptchaEnabled"] = ExpressionConverter.ConvertO(dataconfigurationrecaptchaEnabled);
                configurationObjectpropCount++;
            }

            if (dataconfigurationnotifyContactOwner != null)
            {
                configurationObject["notifyContactOwner"] = ExpressionConverter.ConvertO(dataconfigurationnotifyContactOwner);
                configurationObjectpropCount++;
            }

            if (dataconfigurationnotifyRecipients != null)
            {
                configurationObject["notifyRecipients"] = ExpressionConverter.ConvertO(dataconfigurationnotifyRecipients);
                configurationObjectpropCount++;
            }

            if (dataconfigurationcreateNewContactForNewEmail != null)
            {
                configurationObject["createNewContactForNewEmail"] = ExpressionConverter.ConvertO(dataconfigurationcreateNewContactForNewEmail);
                configurationObjectpropCount++;
            }

            if (dataconfigurationprePopulateKnownValues != null)
            {
                configurationObject["prePopulateKnownValues"] = ExpressionConverter.ConvertO(dataconfigurationprePopulateKnownValues);
                configurationObjectpropCount++;
            }

            if (dataconfigurationallowLinkToResetKnownValues != null)
            {
                configurationObject["allowLinkToResetKnownValues"] = ExpressionConverter.ConvertO(dataconfigurationallowLinkToResetKnownValues);
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                data["configuration"] = configurationObject;
                datapropCount++;
            }

            var displayOptionsObject = new JObject();
            var displayOptionsObjectpropCount = 0;
            if (datadisplayOptionsrenderRawHtml != null)
            {
                displayOptionsObject["renderRawHtml"] = ExpressionConverter.ConvertO(datadisplayOptionsrenderRawHtml);
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionstheme != null)
            {
                displayOptionsObject["theme"] = ExpressionConverter.ConvertO(datadisplayOptionstheme);
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionssubmitButtonText != null)
            {
                displayOptionsObject["submitButtonText"] = ExpressionConverter.ConvertO(datadisplayOptionssubmitButtonText);
                displayOptionsObjectpropCount++;
            }

            var styleObject = new JObject();
            var styleObjectpropCount = 0;
            if (datadisplayOptionsstylefontFamily != null)
            {
                styleObject["fontFamily"] = ExpressionConverter.ConvertO(datadisplayOptionsstylefontFamily);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylebackgroundWidth != null)
            {
                styleObject["backgroundWidth"] = ExpressionConverter.ConvertO(datadisplayOptionsstylebackgroundWidth);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelabelTextColor != null)
            {
                styleObject["labelTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelabelTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelabelTextSize != null)
            {
                styleObject["labelTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelabelTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylehelpTextColor != null)
            {
                styleObject["helpTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylehelpTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylehelpTextSize != null)
            {
                styleObject["helpTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylehelpTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelegalConsentTextColor != null)
            {
                styleObject["legalConsentTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelegalConsentTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelegalConsentTextSize != null)
            {
                styleObject["legalConsentTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelegalConsentTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitColor != null)
            {
                styleObject["submitColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitAlignment != null)
            {
                styleObject["submitAlignment"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitAlignment);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitFontColor != null)
            {
                styleObject["submitFontColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitFontColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitSize != null)
            {
                styleObject["submitSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitSize);
                styleObjectpropCount++;
            }

            if (styleObjectpropCount > 0)
            {
                displayOptionsObject["style"] = styleObject;
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionscssClass != null)
            {
                displayOptionsObject["cssClass"] = ExpressionConverter.ConvertO(datadisplayOptionscssClass);
                displayOptionsObjectpropCount++;
            }

            if (displayOptionsObjectpropCount > 0)
            {
                data["displayOptions"] = displayOptionsObject;
                datapropCount++;
            }

            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsRead(Expression<Func<string>> formId, Expression<Func<bool>> archived = null)
        {
            var apiCallPath = String.Format("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["archived"] = Convert.ToString(false);
            if (archived != null)
                callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsArchive(Expression<Func<string>> formId)
        {
            var apiCallPath = String.Format("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsUpdate(Expression<Func<string>> formId, Expression<Func<string>> dataformType, Expression<Func<string>> dataid, Expression<Func<string>> datacreatedAt, Expression<Func<string>> dataupdatedAt, Expression<Func<bool>> dataarchived, Expression<Func<string>> dataname = null, Expression<Func<string>> dataarchivedAt = null, Expression<Func<datafieldGroupsInputItem[]>> datafieldGroups = null, Expression<Func<string>> dataconfigurationlanguage = null, Expression<Func<bool>> dataconfigurationcloneable = null, Expression<Func<string>> dataconfigurationpostSubmitActiontype = null, Expression<Func<string>> dataconfigurationpostSubmitActionvalue = null, Expression<Func<bool>> dataconfigurationeditable = null, Expression<Func<bool>> dataconfigurationarchivable = null, Expression<Func<bool>> dataconfigurationrecaptchaEnabled = null, Expression<Func<bool>> dataconfigurationnotifyContactOwner = null, Expression<Func<string[]>> dataconfigurationnotifyRecipients = null, Expression<Func<bool>> dataconfigurationcreateNewContactForNewEmail = null, Expression<Func<bool>> dataconfigurationprePopulateKnownValues = null, Expression<Func<bool>> dataconfigurationallowLinkToResetKnownValues = null, Expression<Func<bool>> datadisplayOptionsrenderRawHtml = null, Expression<Func<string>> datadisplayOptionstheme = null, Expression<Func<string>> datadisplayOptionssubmitButtonText = null, Expression<Func<string>> datadisplayOptionsstylefontFamily = null, Expression<Func<string>> datadisplayOptionsstylebackgroundWidth = null, Expression<Func<string>> datadisplayOptionsstylelabelTextColor = null, Expression<Func<string>> datadisplayOptionsstylelabelTextSize = null, Expression<Func<string>> datadisplayOptionsstylehelpTextColor = null, Expression<Func<string>> datadisplayOptionsstylehelpTextSize = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextColor = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextSize = null, Expression<Func<string>> datadisplayOptionsstylesubmitColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitAlignment = null, Expression<Func<string>> datadisplayOptionsstylesubmitFontColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitSize = null, Expression<Func<string>> datadisplayOptionscssClass = null)
        {
            var apiCallPath = String.Format("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            datapropCount++;
            data["formType"] = ExpressionConverter.ConvertO(dataformType);
            datapropCount++;
            data["id"] = ExpressionConverter.ConvertO(dataid);
            if (dataname != null)
            {
                data["name"] = ExpressionConverter.ConvertO(dataname);
                datapropCount++;
            }

            datapropCount++;
            data["createdAt"] = ExpressionConverter.ConvertO(datacreatedAt);
            datapropCount++;
            data["updatedAt"] = ExpressionConverter.ConvertO(dataupdatedAt);
            datapropCount++;
            data["archived"] = ExpressionConverter.ConvertO(dataarchived);
            if (dataarchivedAt != null)
            {
                data["archivedAt"] = ExpressionConverter.ConvertO(dataarchivedAt);
                datapropCount++;
            }

            if (datafieldGroups != null)
            {
                data["fieldGroups"] = ExpressionConverter.ConvertO(datafieldGroups);
                datapropCount++;
            }

            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            if (dataconfigurationlanguage != null)
            {
                configurationObject["language"] = ExpressionConverter.ConvertO(dataconfigurationlanguage);
                configurationObjectpropCount++;
            }

            if (dataconfigurationcloneable != null)
            {
                configurationObject["cloneable"] = ExpressionConverter.ConvertO(dataconfigurationcloneable);
                configurationObjectpropCount++;
            }

            var postSubmitActionObject = new JObject();
            var postSubmitActionObjectpropCount = 0;
            if (dataconfigurationpostSubmitActiontype != null)
            {
                postSubmitActionObject["type"] = ExpressionConverter.ConvertO(dataconfigurationpostSubmitActiontype);
                postSubmitActionObjectpropCount++;
            }

            if (dataconfigurationpostSubmitActionvalue != null)
            {
                postSubmitActionObject["value"] = ExpressionConverter.ConvertO(dataconfigurationpostSubmitActionvalue);
                postSubmitActionObjectpropCount++;
            }

            if (postSubmitActionObjectpropCount > 0)
            {
                configurationObject["postSubmitAction"] = postSubmitActionObject;
                configurationObjectpropCount++;
            }

            if (dataconfigurationeditable != null)
            {
                configurationObject["editable"] = ExpressionConverter.ConvertO(dataconfigurationeditable);
                configurationObjectpropCount++;
            }

            if (dataconfigurationarchivable != null)
            {
                configurationObject["archivable"] = ExpressionConverter.ConvertO(dataconfigurationarchivable);
                configurationObjectpropCount++;
            }

            if (dataconfigurationrecaptchaEnabled != null)
            {
                configurationObject["recaptchaEnabled"] = ExpressionConverter.ConvertO(dataconfigurationrecaptchaEnabled);
                configurationObjectpropCount++;
            }

            if (dataconfigurationnotifyContactOwner != null)
            {
                configurationObject["notifyContactOwner"] = ExpressionConverter.ConvertO(dataconfigurationnotifyContactOwner);
                configurationObjectpropCount++;
            }

            if (dataconfigurationnotifyRecipients != null)
            {
                configurationObject["notifyRecipients"] = ExpressionConverter.ConvertO(dataconfigurationnotifyRecipients);
                configurationObjectpropCount++;
            }

            if (dataconfigurationcreateNewContactForNewEmail != null)
            {
                configurationObject["createNewContactForNewEmail"] = ExpressionConverter.ConvertO(dataconfigurationcreateNewContactForNewEmail);
                configurationObjectpropCount++;
            }

            if (dataconfigurationprePopulateKnownValues != null)
            {
                configurationObject["prePopulateKnownValues"] = ExpressionConverter.ConvertO(dataconfigurationprePopulateKnownValues);
                configurationObjectpropCount++;
            }

            if (dataconfigurationallowLinkToResetKnownValues != null)
            {
                configurationObject["allowLinkToResetKnownValues"] = ExpressionConverter.ConvertO(dataconfigurationallowLinkToResetKnownValues);
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                data["configuration"] = configurationObject;
                datapropCount++;
            }

            var displayOptionsObject = new JObject();
            var displayOptionsObjectpropCount = 0;
            if (datadisplayOptionsrenderRawHtml != null)
            {
                displayOptionsObject["renderRawHtml"] = ExpressionConverter.ConvertO(datadisplayOptionsrenderRawHtml);
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionstheme != null)
            {
                displayOptionsObject["theme"] = ExpressionConverter.ConvertO(datadisplayOptionstheme);
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionssubmitButtonText != null)
            {
                displayOptionsObject["submitButtonText"] = ExpressionConverter.ConvertO(datadisplayOptionssubmitButtonText);
                displayOptionsObjectpropCount++;
            }

            var styleObject = new JObject();
            var styleObjectpropCount = 0;
            if (datadisplayOptionsstylefontFamily != null)
            {
                styleObject["fontFamily"] = ExpressionConverter.ConvertO(datadisplayOptionsstylefontFamily);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylebackgroundWidth != null)
            {
                styleObject["backgroundWidth"] = ExpressionConverter.ConvertO(datadisplayOptionsstylebackgroundWidth);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelabelTextColor != null)
            {
                styleObject["labelTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelabelTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelabelTextSize != null)
            {
                styleObject["labelTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelabelTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylehelpTextColor != null)
            {
                styleObject["helpTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylehelpTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylehelpTextSize != null)
            {
                styleObject["helpTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylehelpTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelegalConsentTextColor != null)
            {
                styleObject["legalConsentTextColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelegalConsentTextColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylelegalConsentTextSize != null)
            {
                styleObject["legalConsentTextSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylelegalConsentTextSize);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitColor != null)
            {
                styleObject["submitColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitAlignment != null)
            {
                styleObject["submitAlignment"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitAlignment);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitFontColor != null)
            {
                styleObject["submitFontColor"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitFontColor);
                styleObjectpropCount++;
            }

            if (datadisplayOptionsstylesubmitSize != null)
            {
                styleObject["submitSize"] = ExpressionConverter.ConvertO(datadisplayOptionsstylesubmitSize);
                styleObjectpropCount++;
            }

            if (styleObjectpropCount > 0)
            {
                displayOptionsObject["style"] = styleObject;
                displayOptionsObjectpropCount++;
            }

            if (datadisplayOptionscssClass != null)
            {
                displayOptionsObject["cssClass"] = ExpressionConverter.ConvertO(datadisplayOptionscssClass);
                displayOptionsObjectpropCount++;
            }

            if (displayOptionsObjectpropCount > 0)
            {
                data["displayOptions"] = displayOptionsObject;
                datapropCount++;
            }

            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventRead(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var apiCallPath = String.Format("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(externalAccountId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsArchive(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var apiCallPath = String.Format("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(externalAccountId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsUpdateCreateOrUpdate(Expression<Func<string>> externalEventId, Expression<Func<string>> dataeventName, Expression<Func<string>> dataeventOrganizer, Expression<Func<string>> dataexternalAccountId, Expression<Func<string>> dataexternalEventId, Expression<Func<dataeventTypeInput>> dataeventType = null, Expression<Func<string>> datastartDateTime = null, Expression<Func<string>> dataendDateTime = null, Expression<Func<string>> dataeventDescription = null, Expression<Func<string>> dataeventUrl = null, Expression<Func<bool>> dataeventCancelled = null, Expression<Func<datacustomPropertiesInputItem[]>> datacustomProperties = null)
        {
            var apiCallPath = String.Format("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var data = new JObject();
            var datapropCount = 0;
            datapropCount++;
            data["eventName"] = ExpressionConverter.ConvertO(dataeventName);
            if (dataeventType != null)
            {
                data["eventType"] = ExpressionConverter.ConvertO(dataeventType);
                datapropCount++;
            }

            if (datastartDateTime != null)
            {
                data["startDateTime"] = ExpressionConverter.ConvertO(datastartDateTime);
                datapropCount++;
            }

            if (dataendDateTime != null)
            {
                data["endDateTime"] = ExpressionConverter.ConvertO(dataendDateTime);
                datapropCount++;
            }

            datapropCount++;
            data["eventOrganizer"] = ExpressionConverter.ConvertO(dataeventOrganizer);
            if (dataeventDescription != null)
            {
                data["eventDescription"] = ExpressionConverter.ConvertO(dataeventDescription);
                datapropCount++;
            }

            if (dataeventUrl != null)
            {
                data["eventUrl"] = ExpressionConverter.ConvertO(dataeventUrl);
                datapropCount++;
            }

            if (dataeventCancelled != null)
            {
                data["eventCancelled"] = ExpressionConverter.ConvertO(dataeventCancelled);
                datapropCount++;
            }

            if (datacustomProperties != null)
            {
                data["customProperties"] = ExpressionConverter.ConvertO(datacustomProperties);
                datapropCount++;
            }

            datapropCount++;
            data["externalAccountId"] = ExpressionConverter.ConvertO(dataexternalAccountId);
            datapropCount++;
            data["externalEventId"] = ExpressionConverter.ConvertO(dataexternalEventId);
            if (datapropCount > 0)
            {
                callPayload.Body = data;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsList(Expression<Func<int>> limit = null, Expression<Func<string>> orderBy = null)
        {
            var apiCallPath = "/marketing-emails/v1/emails";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["limit"] = Convert.ToString(10);
            if (limit != null)
                callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
            callPayload.Queries["orderBy"] = Convert.ToString("created");
            if (orderBy != null)
                callPayload.Queries["orderBy"] = ExpressionConverter.Convert(orderBy);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsRead(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsArchive(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodysubject = null)
        {
            var apiCallPath = String.Format("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyfromName != null)
            {
                body["fromName"] = ExpressionConverter.ConvertO(bodyfromName);
                bodypropCount++;
            }

            if (bodyreplyTo != null)
            {
                body["replyTo"] = ExpressionConverter.ConvertO(bodyreplyTo);
                bodypropCount++;
            }

            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCampaignRead(Expression<Func<string>> campaignId)
        {
            var apiCallPath = String.Format("/email/public/v1/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodysubject = null)
        {
            var apiCallPath = "/marketing-emails/v1/emails/";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["name"] = ExpressionConverter.ConvertO(bodyname);
            if (bodysubject != null)
            {
                body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class HubspotmarketingTriggers([ConnectionName] string connectionId)
    {
    }

    public class datafieldGroupsInputItem
    {
        [JsonProperty("groupType")]
        public string GroupType { get; set; }

        [JsonProperty("richTextType")]
        public string RichTextType { get; set; }

        [JsonProperty("richText")]
        public string RichText { get; set; }

        [JsonProperty("fields")]
        public datafieldGroupsInputItemFieldsTypeItem[] Fields { get; set; }
    }

    public class datafieldGroupsInputItemFieldsTypeItem
    {
        [JsonProperty("fieldType")]
        public string FieldType { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        [JsonProperty("dependentFields")]
        public datafieldGroupsInputItemFieldsTypeItemDependentFieldsTypeItem[] DependentFields { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("validation")]
        public datafieldGroupsInputItemFieldsTypeItemValidationType Validation { get; set; }

        [JsonProperty("useCountryCodeSelect")]
        public bool UseCountryCodeSelect { get; set; }

        [JsonProperty("defaultValues")]
        public string[] DefaultValues { get; set; }

        [JsonProperty("options")]
        public datafieldGroupsInputItemFieldsTypeItemOptionsTypeItem[] Options { get; set; }

        [JsonProperty("allowMultipleFiles")]
        public bool AllowMultipleFiles { get; set; }
    }

    public class datafieldGroupsInputItemFieldsTypeItemDependentFieldsTypeItem
    {
        [JsonProperty("dependentCondition")]
        public datafieldGroupsInputItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType DependentCondition { get; set; }
    }

    public class datafieldGroupsInputItemFieldsTypeItemDependentFieldsTypeItemDependentConditionType
    {
        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("rangeStart")]
        public string RangeStart { get; set; }

        [JsonProperty("rangeEnd")]
        public string RangeEnd { get; set; }
    }

    public class datafieldGroupsInputItemFieldsTypeItemValidationType
    {
        [JsonProperty("blockedEmailDomains")]
        public string[] BlockedEmailDomains { get; set; }

        [JsonProperty("useDefaultBlockList")]
        public bool UseDefaultBlockList { get; set; }

        [JsonProperty("minAllowedDigits")]
        public int MinAllowedDigits { get; set; }

        [JsonProperty("maxAllowedDigits")]
        public int MaxAllowedDigits { get; set; }
    }

    public class datafieldGroupsInputItemFieldsTypeItemOptionsTypeItem
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("displayOrder")]
        public int DisplayOrder { get; set; }
    }

    public enum dataeventTypeInput
    {
        WEBINAR,
        CONFERENCE,
        WORKSHOP
    }

    public class datacustomPropertiesInputItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("timestamp")]
        public int Timestamp { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        [JsonProperty("sourceLabel")]
        public string SourceLabel { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("selectedByUser")]
        public bool SelectedByUser { get; set; }

        [JsonProperty("selectedByUserTimestamp")]
        public int SelectedByUserTimestamp { get; set; }

        [JsonProperty("sourceVid")]
        public int[] SourceVid { get; set; }

        [JsonProperty("sourceMetadata")]
        public string SourceMetadata { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk.Connectors
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing;

    public partial class WorkflowManagedActions
    {
        public HubspotmarketingActions Hubspotmarketing(string connectionId) => new HubspotmarketingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public HubspotmarketingTriggers Hubspotmarketing(string connectionId) => new HubspotmarketingTriggers(connectionId);
    }
}