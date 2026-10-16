//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotmarketingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsList(Expression<Func<int>> limit = null, Expression<Func<bool>> archived = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsCreate(Expression<Func<string>> dataformType = null, Expression<Func<string>> dataname = null, Expression<Func<string>> datacreatedAt = null, Expression<Func<string>> dataupdatedAt = null, Expression<Func<bool>> dataarchived = null, Expression<Func<string>> dataarchivedAt = null, Expression<Func<datafieldGroupsInputItem[]>> datafieldGroups = null, Expression<Func<string>> dataconfigurationlanguage = null, Expression<Func<bool>> dataconfigurationcloneable = null, Expression<Func<string>> dataconfigurationpostSubmitActiontype = null, Expression<Func<string>> dataconfigurationpostSubmitActionvalue = null, Expression<Func<bool>> dataconfigurationeditable = null, Expression<Func<bool>> dataconfigurationarchivable = null, Expression<Func<bool>> dataconfigurationrecaptchaEnabled = null, Expression<Func<bool>> dataconfigurationnotifyContactOwner = null, Expression<Func<string[]>> dataconfigurationnotifyRecipients = null, Expression<Func<bool>> dataconfigurationcreateNewContactForNewEmail = null, Expression<Func<bool>> dataconfigurationprePopulateKnownValues = null, Expression<Func<bool>> dataconfigurationallowLinkToResetKnownValues = null, Expression<Func<bool>> datadisplayOptionsrenderRawHtml = null, Expression<Func<string>> datadisplayOptionstheme = null, Expression<Func<string>> datadisplayOptionssubmitButtonText = null, Expression<Func<string>> datadisplayOptionsstylefontFamily = null, Expression<Func<string>> datadisplayOptionsstylebackgroundWidth = null, Expression<Func<string>> datadisplayOptionsstylelabelTextColor = null, Expression<Func<string>> datadisplayOptionsstylelabelTextSize = null, Expression<Func<string>> datadisplayOptionsstylehelpTextColor = null, Expression<Func<string>> datadisplayOptionsstylehelpTextSize = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextColor = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextSize = null, Expression<Func<string>> datadisplayOptionsstylesubmitColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitAlignment = null, Expression<Func<string>> datadisplayOptionsstylesubmitFontColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitSize = null, Expression<Func<string>> datadisplayOptionscssClass = null)
        {
            var __workflow_dataformType = WorkflowExpression.Compile(dataformType, nameof(dataformType), required: false);
            var __workflow_dataname = WorkflowExpression.Compile(dataname, nameof(dataname), required: false);
            var __workflow_datacreatedAt = WorkflowExpression.Compile(datacreatedAt, nameof(datacreatedAt), required: false);
            var __workflow_dataupdatedAt = WorkflowExpression.Compile(dataupdatedAt, nameof(dataupdatedAt), required: false);
            var __workflow_dataarchived = WorkflowExpression.Compile(dataarchived, nameof(dataarchived), required: false);
            var __workflow_dataarchivedAt = WorkflowExpression.Compile(dataarchivedAt, nameof(dataarchivedAt), required: false);
            var __workflow_datafieldGroups = WorkflowExpression.Compile(datafieldGroups, nameof(datafieldGroups), required: false);
            var __workflow_dataconfigurationlanguage = WorkflowExpression.Compile(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            var __workflow_dataconfigurationcloneable = WorkflowExpression.Compile(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            var __workflow_dataconfigurationpostSubmitActiontype = WorkflowExpression.Compile(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            var __workflow_dataconfigurationpostSubmitActionvalue = WorkflowExpression.Compile(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            var __workflow_dataconfigurationeditable = WorkflowExpression.Compile(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            var __workflow_dataconfigurationarchivable = WorkflowExpression.Compile(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            var __workflow_dataconfigurationrecaptchaEnabled = WorkflowExpression.Compile(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            var __workflow_dataconfigurationnotifyContactOwner = WorkflowExpression.Compile(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            var __workflow_dataconfigurationnotifyRecipients = WorkflowExpression.Compile(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            var __workflow_dataconfigurationcreateNewContactForNewEmail = WorkflowExpression.Compile(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            var __workflow_dataconfigurationprePopulateKnownValues = WorkflowExpression.Compile(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            var __workflow_dataconfigurationallowLinkToResetKnownValues = WorkflowExpression.Compile(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            var __workflow_datadisplayOptionsrenderRawHtml = WorkflowExpression.Compile(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            var __workflow_datadisplayOptionstheme = WorkflowExpression.Compile(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            var __workflow_datadisplayOptionssubmitButtonText = WorkflowExpression.Compile(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            var __workflow_datadisplayOptionsstylefontFamily = WorkflowExpression.Compile(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            var __workflow_datadisplayOptionsstylebackgroundWidth = WorkflowExpression.Compile(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            var __workflow_datadisplayOptionsstylelabelTextColor = WorkflowExpression.Compile(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            var __workflow_datadisplayOptionsstylelabelTextSize = WorkflowExpression.Compile(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            var __workflow_datadisplayOptionsstylehelpTextColor = WorkflowExpression.Compile(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            var __workflow_datadisplayOptionsstylehelpTextSize = WorkflowExpression.Compile(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            var __workflow_datadisplayOptionsstylelegalConsentTextColor = WorkflowExpression.Compile(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            var __workflow_datadisplayOptionsstylelegalConsentTextSize = WorkflowExpression.Compile(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            var __workflow_datadisplayOptionsstylesubmitColor = WorkflowExpression.Compile(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            var __workflow_datadisplayOptionsstylesubmitAlignment = WorkflowExpression.Compile(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            var __workflow_datadisplayOptionsstylesubmitFontColor = WorkflowExpression.Compile(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            var __workflow_datadisplayOptionsstylesubmitSize = WorkflowExpression.Compile(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            var __workflow_datadisplayOptionscssClass = WorkflowExpression.Compile(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                if (__workflow_dataformType != null)
                {
                    if (__workflow_dataformType != null)
                    {
                        data["formType"] = ExpressionConverter.ConvertO(__workflow_dataformType);
                        datapropCount++;
                    }

                    datapropCount++;
                }
                else
                {
                    data["formType"] = "hubspot";
                    datapropCount++;
                }

                if (__workflow_dataname != null)
                {
                    data["name"] = ExpressionConverter.ConvertO(__workflow_dataname);
                    datapropCount++;
                }

                if (__workflow_datacreatedAt != null)
                {
                    data["createdAt"] = ExpressionConverter.ConvertO(__workflow_datacreatedAt);
                    datapropCount++;
                }

                if (__workflow_dataupdatedAt != null)
                {
                    data["updatedAt"] = ExpressionConverter.ConvertO(__workflow_dataupdatedAt);
                    datapropCount++;
                }

                if (__workflow_dataarchived != null)
                {
                    if (__workflow_dataarchived != null)
                    {
                        data["archived"] = ExpressionConverter.ConvertO(__workflow_dataarchived);
                        datapropCount++;
                    }

                    datapropCount++;
                }
                else
                {
                    data["archived"] = false;
                    datapropCount++;
                }

                if (__workflow_dataarchivedAt != null)
                {
                    data["archivedAt"] = ExpressionConverter.ConvertO(__workflow_dataarchivedAt);
                    datapropCount++;
                }

                if (__workflow_datafieldGroups != null)
                {
                    data["fieldGroups"] = ExpressionConverter.ConvertO(__workflow_datafieldGroups);
                    datapropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_dataconfigurationlanguage != null)
                {
                    configurationObject["language"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationlanguage);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationcloneable != null)
                {
                    configurationObject["cloneable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationcloneable);
                    configurationObjectpropCount++;
                }

                var postSubmitActionObject = new JObject();
                var postSubmitActionObjectpropCount = 0;
                if (__workflow_dataconfigurationpostSubmitActiontype != null)
                {
                    postSubmitActionObject["type"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationpostSubmitActiontype);
                    postSubmitActionObjectpropCount++;
                }

                if (__workflow_dataconfigurationpostSubmitActionvalue != null)
                {
                    postSubmitActionObject["value"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationpostSubmitActionvalue);
                    postSubmitActionObjectpropCount++;
                }

                if (postSubmitActionObjectpropCount > 0)
                {
                    configurationObject["postSubmitAction"] = postSubmitActionObject;
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationeditable != null)
                {
                    configurationObject["editable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationeditable);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationarchivable != null)
                {
                    configurationObject["archivable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationarchivable);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationrecaptchaEnabled != null)
                {
                    configurationObject["recaptchaEnabled"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationrecaptchaEnabled);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationnotifyContactOwner != null)
                {
                    configurationObject["notifyContactOwner"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationnotifyContactOwner);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationnotifyRecipients != null)
                {
                    configurationObject["notifyRecipients"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationnotifyRecipients);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationcreateNewContactForNewEmail != null)
                {
                    configurationObject["createNewContactForNewEmail"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationcreateNewContactForNewEmail);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationprePopulateKnownValues != null)
                {
                    configurationObject["prePopulateKnownValues"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationprePopulateKnownValues);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationallowLinkToResetKnownValues != null)
                {
                    configurationObject["allowLinkToResetKnownValues"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationallowLinkToResetKnownValues);
                    configurationObjectpropCount++;
                }

                if (configurationObjectpropCount > 0)
                {
                    data["configuration"] = configurationObject;
                    datapropCount++;
                }

                var displayOptionsObject = new JObject();
                var displayOptionsObjectpropCount = 0;
                if (__workflow_datadisplayOptionsrenderRawHtml != null)
                {
                    displayOptionsObject["renderRawHtml"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsrenderRawHtml);
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionstheme != null)
                {
                    displayOptionsObject["theme"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionstheme);
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionssubmitButtonText != null)
                {
                    displayOptionsObject["submitButtonText"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionssubmitButtonText);
                    displayOptionsObjectpropCount++;
                }

                var styleObject = new JObject();
                var styleObjectpropCount = 0;
                if (__workflow_datadisplayOptionsstylefontFamily != null)
                {
                    styleObject["fontFamily"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylefontFamily);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylebackgroundWidth != null)
                {
                    styleObject["backgroundWidth"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylebackgroundWidth);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelabelTextColor != null)
                {
                    styleObject["labelTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelabelTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelabelTextSize != null)
                {
                    styleObject["labelTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelabelTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylehelpTextColor != null)
                {
                    styleObject["helpTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylehelpTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylehelpTextSize != null)
                {
                    styleObject["helpTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylehelpTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelegalConsentTextColor != null)
                {
                    styleObject["legalConsentTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelegalConsentTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelegalConsentTextSize != null)
                {
                    styleObject["legalConsentTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelegalConsentTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitColor != null)
                {
                    styleObject["submitColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitAlignment != null)
                {
                    styleObject["submitAlignment"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitAlignment);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitFontColor != null)
                {
                    styleObject["submitFontColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitFontColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitSize != null)
                {
                    styleObject["submitSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitSize);
                    styleObjectpropCount++;
                }

                if (styleObjectpropCount > 0)
                {
                    displayOptionsObject["style"] = styleObject;
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionscssClass != null)
                {
                    displayOptionsObject["cssClass"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionscssClass);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsRead(Expression<Func<string>> formId, Expression<Func<bool>> archived = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_archived = WorkflowExpression.Compile(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (__workflow_archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(__workflow_archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsArchive(Expression<Func<string>> formId)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsUpdate(Expression<Func<string>> formId, Expression<Func<string>> dataformType, Expression<Func<string>> dataid, Expression<Func<string>> datacreatedAt, Expression<Func<string>> dataupdatedAt, Expression<Func<bool>> dataarchived, Expression<Func<string>> dataname = null, Expression<Func<string>> dataarchivedAt = null, Expression<Func<datafieldGroupsInputItem[]>> datafieldGroups = null, Expression<Func<string>> dataconfigurationlanguage = null, Expression<Func<bool>> dataconfigurationcloneable = null, Expression<Func<string>> dataconfigurationpostSubmitActiontype = null, Expression<Func<string>> dataconfigurationpostSubmitActionvalue = null, Expression<Func<bool>> dataconfigurationeditable = null, Expression<Func<bool>> dataconfigurationarchivable = null, Expression<Func<bool>> dataconfigurationrecaptchaEnabled = null, Expression<Func<bool>> dataconfigurationnotifyContactOwner = null, Expression<Func<string[]>> dataconfigurationnotifyRecipients = null, Expression<Func<bool>> dataconfigurationcreateNewContactForNewEmail = null, Expression<Func<bool>> dataconfigurationprePopulateKnownValues = null, Expression<Func<bool>> dataconfigurationallowLinkToResetKnownValues = null, Expression<Func<bool>> datadisplayOptionsrenderRawHtml = null, Expression<Func<string>> datadisplayOptionstheme = null, Expression<Func<string>> datadisplayOptionssubmitButtonText = null, Expression<Func<string>> datadisplayOptionsstylefontFamily = null, Expression<Func<string>> datadisplayOptionsstylebackgroundWidth = null, Expression<Func<string>> datadisplayOptionsstylelabelTextColor = null, Expression<Func<string>> datadisplayOptionsstylelabelTextSize = null, Expression<Func<string>> datadisplayOptionsstylehelpTextColor = null, Expression<Func<string>> datadisplayOptionsstylehelpTextSize = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextColor = null, Expression<Func<string>> datadisplayOptionsstylelegalConsentTextSize = null, Expression<Func<string>> datadisplayOptionsstylesubmitColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitAlignment = null, Expression<Func<string>> datadisplayOptionsstylesubmitFontColor = null, Expression<Func<string>> datadisplayOptionsstylesubmitSize = null, Expression<Func<string>> datadisplayOptionscssClass = null)
        {
            var __workflow_formId = WorkflowExpression.Compile(formId, nameof(formId), required: true);
            var __workflow_dataformType = WorkflowExpression.Compile(dataformType, nameof(dataformType), required: true);
            var __workflow_dataid = WorkflowExpression.Compile(dataid, nameof(dataid), required: true);
            var __workflow_datacreatedAt = WorkflowExpression.Compile(datacreatedAt, nameof(datacreatedAt), required: true);
            var __workflow_dataupdatedAt = WorkflowExpression.Compile(dataupdatedAt, nameof(dataupdatedAt), required: true);
            var __workflow_dataarchived = WorkflowExpression.Compile(dataarchived, nameof(dataarchived), required: true);
            var __workflow_dataname = WorkflowExpression.Compile(dataname, nameof(dataname), required: false);
            var __workflow_dataarchivedAt = WorkflowExpression.Compile(dataarchivedAt, nameof(dataarchivedAt), required: false);
            var __workflow_datafieldGroups = WorkflowExpression.Compile(datafieldGroups, nameof(datafieldGroups), required: false);
            var __workflow_dataconfigurationlanguage = WorkflowExpression.Compile(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            var __workflow_dataconfigurationcloneable = WorkflowExpression.Compile(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            var __workflow_dataconfigurationpostSubmitActiontype = WorkflowExpression.Compile(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            var __workflow_dataconfigurationpostSubmitActionvalue = WorkflowExpression.Compile(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            var __workflow_dataconfigurationeditable = WorkflowExpression.Compile(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            var __workflow_dataconfigurationarchivable = WorkflowExpression.Compile(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            var __workflow_dataconfigurationrecaptchaEnabled = WorkflowExpression.Compile(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            var __workflow_dataconfigurationnotifyContactOwner = WorkflowExpression.Compile(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            var __workflow_dataconfigurationnotifyRecipients = WorkflowExpression.Compile(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            var __workflow_dataconfigurationcreateNewContactForNewEmail = WorkflowExpression.Compile(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            var __workflow_dataconfigurationprePopulateKnownValues = WorkflowExpression.Compile(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            var __workflow_dataconfigurationallowLinkToResetKnownValues = WorkflowExpression.Compile(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            var __workflow_datadisplayOptionsrenderRawHtml = WorkflowExpression.Compile(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            var __workflow_datadisplayOptionstheme = WorkflowExpression.Compile(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            var __workflow_datadisplayOptionssubmitButtonText = WorkflowExpression.Compile(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            var __workflow_datadisplayOptionsstylefontFamily = WorkflowExpression.Compile(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            var __workflow_datadisplayOptionsstylebackgroundWidth = WorkflowExpression.Compile(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            var __workflow_datadisplayOptionsstylelabelTextColor = WorkflowExpression.Compile(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            var __workflow_datadisplayOptionsstylelabelTextSize = WorkflowExpression.Compile(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            var __workflow_datadisplayOptionsstylehelpTextColor = WorkflowExpression.Compile(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            var __workflow_datadisplayOptionsstylehelpTextSize = WorkflowExpression.Compile(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            var __workflow_datadisplayOptionsstylelegalConsentTextColor = WorkflowExpression.Compile(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            var __workflow_datadisplayOptionsstylelegalConsentTextSize = WorkflowExpression.Compile(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            var __workflow_datadisplayOptionsstylesubmitColor = WorkflowExpression.Compile(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            var __workflow_datadisplayOptionsstylesubmitAlignment = WorkflowExpression.Compile(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            var __workflow_datadisplayOptionsstylesubmitFontColor = WorkflowExpression.Compile(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            var __workflow_datadisplayOptionsstylesubmitSize = WorkflowExpression.Compile(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            var __workflow_datadisplayOptionscssClass = WorkflowExpression.Compile(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_formId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["formType"] = ExpressionConverter.ConvertO(__workflow_dataformType);
                datapropCount++;
                data["id"] = ExpressionConverter.ConvertO(__workflow_dataid);
                if (__workflow_dataname != null)
                {
                    data["name"] = ExpressionConverter.ConvertO(__workflow_dataname);
                    datapropCount++;
                }

                datapropCount++;
                data["createdAt"] = ExpressionConverter.ConvertO(__workflow_datacreatedAt);
                datapropCount++;
                data["updatedAt"] = ExpressionConverter.ConvertO(__workflow_dataupdatedAt);
                datapropCount++;
                data["archived"] = ExpressionConverter.ConvertO(__workflow_dataarchived);
                if (__workflow_dataarchivedAt != null)
                {
                    data["archivedAt"] = ExpressionConverter.ConvertO(__workflow_dataarchivedAt);
                    datapropCount++;
                }

                if (__workflow_datafieldGroups != null)
                {
                    data["fieldGroups"] = ExpressionConverter.ConvertO(__workflow_datafieldGroups);
                    datapropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (__workflow_dataconfigurationlanguage != null)
                {
                    configurationObject["language"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationlanguage);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationcloneable != null)
                {
                    configurationObject["cloneable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationcloneable);
                    configurationObjectpropCount++;
                }

                var postSubmitActionObject = new JObject();
                var postSubmitActionObjectpropCount = 0;
                if (__workflow_dataconfigurationpostSubmitActiontype != null)
                {
                    postSubmitActionObject["type"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationpostSubmitActiontype);
                    postSubmitActionObjectpropCount++;
                }

                if (__workflow_dataconfigurationpostSubmitActionvalue != null)
                {
                    postSubmitActionObject["value"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationpostSubmitActionvalue);
                    postSubmitActionObjectpropCount++;
                }

                if (postSubmitActionObjectpropCount > 0)
                {
                    configurationObject["postSubmitAction"] = postSubmitActionObject;
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationeditable != null)
                {
                    configurationObject["editable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationeditable);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationarchivable != null)
                {
                    configurationObject["archivable"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationarchivable);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationrecaptchaEnabled != null)
                {
                    configurationObject["recaptchaEnabled"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationrecaptchaEnabled);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationnotifyContactOwner != null)
                {
                    configurationObject["notifyContactOwner"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationnotifyContactOwner);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationnotifyRecipients != null)
                {
                    configurationObject["notifyRecipients"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationnotifyRecipients);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationcreateNewContactForNewEmail != null)
                {
                    configurationObject["createNewContactForNewEmail"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationcreateNewContactForNewEmail);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationprePopulateKnownValues != null)
                {
                    configurationObject["prePopulateKnownValues"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationprePopulateKnownValues);
                    configurationObjectpropCount++;
                }

                if (__workflow_dataconfigurationallowLinkToResetKnownValues != null)
                {
                    configurationObject["allowLinkToResetKnownValues"] = ExpressionConverter.ConvertO(__workflow_dataconfigurationallowLinkToResetKnownValues);
                    configurationObjectpropCount++;
                }

                if (configurationObjectpropCount > 0)
                {
                    data["configuration"] = configurationObject;
                    datapropCount++;
                }

                var displayOptionsObject = new JObject();
                var displayOptionsObjectpropCount = 0;
                if (__workflow_datadisplayOptionsrenderRawHtml != null)
                {
                    displayOptionsObject["renderRawHtml"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsrenderRawHtml);
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionstheme != null)
                {
                    displayOptionsObject["theme"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionstheme);
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionssubmitButtonText != null)
                {
                    displayOptionsObject["submitButtonText"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionssubmitButtonText);
                    displayOptionsObjectpropCount++;
                }

                var styleObject = new JObject();
                var styleObjectpropCount = 0;
                if (__workflow_datadisplayOptionsstylefontFamily != null)
                {
                    styleObject["fontFamily"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylefontFamily);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylebackgroundWidth != null)
                {
                    styleObject["backgroundWidth"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylebackgroundWidth);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelabelTextColor != null)
                {
                    styleObject["labelTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelabelTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelabelTextSize != null)
                {
                    styleObject["labelTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelabelTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylehelpTextColor != null)
                {
                    styleObject["helpTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylehelpTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylehelpTextSize != null)
                {
                    styleObject["helpTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylehelpTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelegalConsentTextColor != null)
                {
                    styleObject["legalConsentTextColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelegalConsentTextColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylelegalConsentTextSize != null)
                {
                    styleObject["legalConsentTextSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylelegalConsentTextSize);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitColor != null)
                {
                    styleObject["submitColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitAlignment != null)
                {
                    styleObject["submitAlignment"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitAlignment);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitFontColor != null)
                {
                    styleObject["submitFontColor"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitFontColor);
                    styleObjectpropCount++;
                }

                if (__workflow_datadisplayOptionsstylesubmitSize != null)
                {
                    styleObject["submitSize"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionsstylesubmitSize);
                    styleObjectpropCount++;
                }

                if (styleObjectpropCount > 0)
                {
                    displayOptionsObject["style"] = styleObject;
                    displayOptionsObjectpropCount++;
                }

                if (__workflow_datadisplayOptionscssClass != null)
                {
                    displayOptionsObject["cssClass"] = ExpressionConverter.ConvertO(__workflow_datadisplayOptionscssClass);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventRead(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_externalAccountId = WorkflowExpression.Compile(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(__workflow_externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsArchive(Expression<Func<string>> externalEventId, Expression<Func<string>> externalAccountId)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_externalAccountId = WorkflowExpression.Compile(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalEventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(__workflow_externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsUpdateCreateOrUpdate(Expression<Func<string>> externalEventId, Expression<Func<string>> dataeventName, Expression<Func<string>> dataeventOrganizer, Expression<Func<string>> dataexternalAccountId, Expression<Func<string>> dataexternalEventId, Expression<Func<dataeventTypeInput>> dataeventType = null, Expression<Func<string>> datastartDateTime = null, Expression<Func<string>> dataendDateTime = null, Expression<Func<string>> dataeventDescription = null, Expression<Func<string>> dataeventUrl = null, Expression<Func<bool>> dataeventCancelled = null, Expression<Func<datacustomPropertiesInputItem[]>> datacustomProperties = null)
        {
            var __workflow_externalEventId = WorkflowExpression.Compile(externalEventId, nameof(externalEventId), required: true);
            var __workflow_dataeventName = WorkflowExpression.Compile(dataeventName, nameof(dataeventName), required: true);
            var __workflow_dataeventOrganizer = WorkflowExpression.Compile(dataeventOrganizer, nameof(dataeventOrganizer), required: true);
            var __workflow_dataexternalAccountId = WorkflowExpression.Compile(dataexternalAccountId, nameof(dataexternalAccountId), required: true);
            var __workflow_dataexternalEventId = WorkflowExpression.Compile(dataexternalEventId, nameof(dataexternalEventId), required: true);
            var __workflow_dataeventType = WorkflowExpression.Compile(dataeventType, nameof(dataeventType), required: false);
            var __workflow_datastartDateTime = WorkflowExpression.Compile(datastartDateTime, nameof(datastartDateTime), required: false);
            var __workflow_dataendDateTime = WorkflowExpression.Compile(dataendDateTime, nameof(dataendDateTime), required: false);
            var __workflow_dataeventDescription = WorkflowExpression.Compile(dataeventDescription, nameof(dataeventDescription), required: false);
            var __workflow_dataeventUrl = WorkflowExpression.Compile(dataeventUrl, nameof(dataeventUrl), required: false);
            var __workflow_dataeventCancelled = WorkflowExpression.Compile(dataeventCancelled, nameof(dataeventCancelled), required: false);
            var __workflow_datacustomProperties = WorkflowExpression.Compile(datacustomProperties, nameof(datacustomProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_externalEventId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["eventName"] = ExpressionConverter.ConvertO(__workflow_dataeventName);
                if (__workflow_dataeventType != null)
                {
                    data["eventType"] = ExpressionConverter.ConvertO(__workflow_dataeventType);
                    datapropCount++;
                }

                if (__workflow_datastartDateTime != null)
                {
                    data["startDateTime"] = ExpressionConverter.ConvertO(__workflow_datastartDateTime);
                    datapropCount++;
                }

                if (__workflow_dataendDateTime != null)
                {
                    data["endDateTime"] = ExpressionConverter.ConvertO(__workflow_dataendDateTime);
                    datapropCount++;
                }

                datapropCount++;
                data["eventOrganizer"] = ExpressionConverter.ConvertO(__workflow_dataeventOrganizer);
                if (__workflow_dataeventDescription != null)
                {
                    data["eventDescription"] = ExpressionConverter.ConvertO(__workflow_dataeventDescription);
                    datapropCount++;
                }

                if (__workflow_dataeventUrl != null)
                {
                    data["eventUrl"] = ExpressionConverter.ConvertO(__workflow_dataeventUrl);
                    datapropCount++;
                }

                if (__workflow_dataeventCancelled != null)
                {
                    data["eventCancelled"] = ExpressionConverter.ConvertO(__workflow_dataeventCancelled);
                    datapropCount++;
                }

                if (__workflow_datacustomProperties != null)
                {
                    data["customProperties"] = ExpressionConverter.ConvertO(__workflow_datacustomProperties);
                    datapropCount++;
                }

                datapropCount++;
                data["externalAccountId"] = ExpressionConverter.ConvertO(__workflow_dataexternalAccountId);
                datapropCount++;
                data["externalEventId"] = ExpressionConverter.ConvertO(__workflow_dataexternalEventId);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsList(Expression<Func<int>> limit = null, Expression<Func<string>> orderBy = null)
        {
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_orderBy = WorkflowExpression.Compile(orderBy, nameof(orderBy), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/marketing-emails/v1/emails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                callPayload.Queries["orderBy"] = Convert.ToString("created");
                if (__workflow_orderBy != null)
                    callPayload.Queries["orderBy"] = ExpressionConverter.Convert(__workflow_orderBy);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsRead(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsArchive(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsUpdate(Expression<Func<string>> id, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodysubject = null)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyfromName = WorkflowExpression.Compile(bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodyreplyTo = WorkflowExpression.Compile(bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyfromName != null)
                {
                    body["fromName"] = ExpressionConverter.ConvertO(__workflow_bodyfromName);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyTo != null)
                {
                    body["replyTo"] = ExpressionConverter.ConvertO(__workflow_bodyreplyTo);
                    bodypropCount++;
                }

                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCampaignRead(Expression<Func<string>> campaignId)
        {
            var __workflow_campaignId = WorkflowExpression.Compile(campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/email/public/v1/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCreate(Expression<Func<string>> bodyname, Expression<Func<string>> bodysubject = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodysubject = WorkflowExpression.Compile(bodysubject, nameof(bodysubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/marketing-emails/v1/emails/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

namespace Microsoft.Azure.Workflows.Sdk
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
