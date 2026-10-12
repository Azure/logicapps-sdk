//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Hubspotmarketing
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class HubspotmarketingActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildFormsList))]
        public IWorkflowAction FormsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFormsList(WorkflowExpression<int> limit = null, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildFormsCreate))]
        public IWorkflowAction FormsCreate([WorkflowExpression] Func<string> dataformType = null, [WorkflowExpression] Func<string> dataname = null, [WorkflowExpression] Func<string> datacreatedAt = null, [WorkflowExpression] Func<string> dataupdatedAt = null, [WorkflowExpression] Func<bool> dataarchived = null, [WorkflowExpression] Func<string> dataarchivedAt = null, [WorkflowExpression] Func<datafieldGroupsInputItem[]> datafieldGroups = null, [WorkflowExpression] Func<string> dataconfigurationlanguage = null, [WorkflowExpression] Func<bool> dataconfigurationcloneable = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActiontype = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActionvalue = null, [WorkflowExpression] Func<bool> dataconfigurationeditable = null, [WorkflowExpression] Func<bool> dataconfigurationarchivable = null, [WorkflowExpression] Func<bool> dataconfigurationrecaptchaEnabled = null, [WorkflowExpression] Func<bool> dataconfigurationnotifyContactOwner = null, [WorkflowExpression] Func<string[]> dataconfigurationnotifyRecipients = null, [WorkflowExpression] Func<bool> dataconfigurationcreateNewContactForNewEmail = null, [WorkflowExpression] Func<bool> dataconfigurationprePopulateKnownValues = null, [WorkflowExpression] Func<bool> dataconfigurationallowLinkToResetKnownValues = null, [WorkflowExpression] Func<bool> datadisplayOptionsrenderRawHtml = null, [WorkflowExpression] Func<string> datadisplayOptionstheme = null, [WorkflowExpression] Func<string> datadisplayOptionssubmitButtonText = null, [WorkflowExpression] Func<string> datadisplayOptionsstylefontFamily = null, [WorkflowExpression] Func<string> datadisplayOptionsstylebackgroundWidth = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitAlignment = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitFontColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitSize = null, [WorkflowExpression] Func<string> datadisplayOptionscssClass = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFormsCreate(WorkflowExpression<string> dataformType = null, WorkflowExpression<string> dataname = null, WorkflowExpression<string> datacreatedAt = null, WorkflowExpression<string> dataupdatedAt = null, WorkflowExpression<bool> dataarchived = null, WorkflowExpression<string> dataarchivedAt = null, WorkflowExpression<datafieldGroupsInputItem[]> datafieldGroups = null, WorkflowExpression<string> dataconfigurationlanguage = null, WorkflowExpression<bool> dataconfigurationcloneable = null, WorkflowExpression<string> dataconfigurationpostSubmitActiontype = null, WorkflowExpression<string> dataconfigurationpostSubmitActionvalue = null, WorkflowExpression<bool> dataconfigurationeditable = null, WorkflowExpression<bool> dataconfigurationarchivable = null, WorkflowExpression<bool> dataconfigurationrecaptchaEnabled = null, WorkflowExpression<bool> dataconfigurationnotifyContactOwner = null, WorkflowExpression<string[]> dataconfigurationnotifyRecipients = null, WorkflowExpression<bool> dataconfigurationcreateNewContactForNewEmail = null, WorkflowExpression<bool> dataconfigurationprePopulateKnownValues = null, WorkflowExpression<bool> dataconfigurationallowLinkToResetKnownValues = null, WorkflowExpression<bool> datadisplayOptionsrenderRawHtml = null, WorkflowExpression<string> datadisplayOptionstheme = null, WorkflowExpression<string> datadisplayOptionssubmitButtonText = null, WorkflowExpression<string> datadisplayOptionsstylefontFamily = null, WorkflowExpression<string> datadisplayOptionsstylebackgroundWidth = null, WorkflowExpression<string> datadisplayOptionsstylelabelTextColor = null, WorkflowExpression<string> datadisplayOptionsstylelabelTextSize = null, WorkflowExpression<string> datadisplayOptionsstylehelpTextColor = null, WorkflowExpression<string> datadisplayOptionsstylehelpTextSize = null, WorkflowExpression<string> datadisplayOptionsstylelegalConsentTextColor = null, WorkflowExpression<string> datadisplayOptionsstylelegalConsentTextSize = null, WorkflowExpression<string> datadisplayOptionsstylesubmitColor = null, WorkflowExpression<string> datadisplayOptionsstylesubmitAlignment = null, WorkflowExpression<string> datadisplayOptionsstylesubmitFontColor = null, WorkflowExpression<string> datadisplayOptionsstylesubmitSize = null, WorkflowExpression<string> datadisplayOptionscssClass = null)
        {
            WorkflowExpression.Validate(dataformType, nameof(dataformType), required: false);
            WorkflowExpression.Validate(dataname, nameof(dataname), required: false);
            WorkflowExpression.Validate(datacreatedAt, nameof(datacreatedAt), required: false);
            WorkflowExpression.Validate(dataupdatedAt, nameof(dataupdatedAt), required: false);
            WorkflowExpression.Validate(dataarchived, nameof(dataarchived), required: false);
            WorkflowExpression.Validate(dataarchivedAt, nameof(dataarchivedAt), required: false);
            WorkflowExpression.Validate(datafieldGroups, nameof(datafieldGroups), required: false);
            WorkflowExpression.Validate(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            WorkflowExpression.Validate(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            WorkflowExpression.Validate(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            WorkflowExpression.Validate(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            WorkflowExpression.Validate(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            WorkflowExpression.Validate(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            WorkflowExpression.Validate(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            WorkflowExpression.Validate(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            WorkflowExpression.Validate(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            WorkflowExpression.Validate(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            WorkflowExpression.Validate(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            WorkflowExpression.Validate(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            WorkflowExpression.Validate(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            WorkflowExpression.Validate(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            WorkflowExpression.Validate(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                if (dataformType != null)
                {
                    if (dataformType != null)
                    {
                        data["formType"] = ExpressionConverter.ConvertO(dataformType);
                        datapropCount++;
                    }

                    datapropCount++;
                }
                else
                {
                    data["formType"] = "hubspot";
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
                    if (dataarchived != null)
                    {
                        data["archived"] = ExpressionConverter.ConvertO(dataarchived);
                        datapropCount++;
                    }

                    datapropCount++;
                }
                else
                {
                    data["archived"] = false;
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildFormsRead))]
        public IWorkflowAction FormsRead([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<bool> archived = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFormsRead(WorkflowExpression<string> formId, WorkflowExpression<bool> archived = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(archived, nameof(archived), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = ExpressionConverter.Convert(archived);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildFormsArchive))]
        public IWorkflowAction FormsArchive([WorkflowExpression] Func<string> formId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFormsArchive(WorkflowExpression<string> formId)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildFormsUpdate))]
        public IWorkflowAction FormsUpdate([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> dataformType, [WorkflowExpression] Func<string> dataid, [WorkflowExpression] Func<string> datacreatedAt, [WorkflowExpression] Func<string> dataupdatedAt, [WorkflowExpression] Func<bool> dataarchived, [WorkflowExpression] Func<string> dataname = null, [WorkflowExpression] Func<string> dataarchivedAt = null, [WorkflowExpression] Func<datafieldGroupsInputItem[]> datafieldGroups = null, [WorkflowExpression] Func<string> dataconfigurationlanguage = null, [WorkflowExpression] Func<bool> dataconfigurationcloneable = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActiontype = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActionvalue = null, [WorkflowExpression] Func<bool> dataconfigurationeditable = null, [WorkflowExpression] Func<bool> dataconfigurationarchivable = null, [WorkflowExpression] Func<bool> dataconfigurationrecaptchaEnabled = null, [WorkflowExpression] Func<bool> dataconfigurationnotifyContactOwner = null, [WorkflowExpression] Func<string[]> dataconfigurationnotifyRecipients = null, [WorkflowExpression] Func<bool> dataconfigurationcreateNewContactForNewEmail = null, [WorkflowExpression] Func<bool> dataconfigurationprePopulateKnownValues = null, [WorkflowExpression] Func<bool> dataconfigurationallowLinkToResetKnownValues = null, [WorkflowExpression] Func<bool> datadisplayOptionsrenderRawHtml = null, [WorkflowExpression] Func<string> datadisplayOptionstheme = null, [WorkflowExpression] Func<string> datadisplayOptionssubmitButtonText = null, [WorkflowExpression] Func<string> datadisplayOptionsstylefontFamily = null, [WorkflowExpression] Func<string> datadisplayOptionsstylebackgroundWidth = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitAlignment = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitFontColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitSize = null, [WorkflowExpression] Func<string> datadisplayOptionscssClass = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildFormsUpdate(WorkflowExpression<string> formId, WorkflowExpression<string> dataformType, WorkflowExpression<string> dataid, WorkflowExpression<string> datacreatedAt, WorkflowExpression<string> dataupdatedAt, WorkflowExpression<bool> dataarchived, WorkflowExpression<string> dataname = null, WorkflowExpression<string> dataarchivedAt = null, WorkflowExpression<datafieldGroupsInputItem[]> datafieldGroups = null, WorkflowExpression<string> dataconfigurationlanguage = null, WorkflowExpression<bool> dataconfigurationcloneable = null, WorkflowExpression<string> dataconfigurationpostSubmitActiontype = null, WorkflowExpression<string> dataconfigurationpostSubmitActionvalue = null, WorkflowExpression<bool> dataconfigurationeditable = null, WorkflowExpression<bool> dataconfigurationarchivable = null, WorkflowExpression<bool> dataconfigurationrecaptchaEnabled = null, WorkflowExpression<bool> dataconfigurationnotifyContactOwner = null, WorkflowExpression<string[]> dataconfigurationnotifyRecipients = null, WorkflowExpression<bool> dataconfigurationcreateNewContactForNewEmail = null, WorkflowExpression<bool> dataconfigurationprePopulateKnownValues = null, WorkflowExpression<bool> dataconfigurationallowLinkToResetKnownValues = null, WorkflowExpression<bool> datadisplayOptionsrenderRawHtml = null, WorkflowExpression<string> datadisplayOptionstheme = null, WorkflowExpression<string> datadisplayOptionssubmitButtonText = null, WorkflowExpression<string> datadisplayOptionsstylefontFamily = null, WorkflowExpression<string> datadisplayOptionsstylebackgroundWidth = null, WorkflowExpression<string> datadisplayOptionsstylelabelTextColor = null, WorkflowExpression<string> datadisplayOptionsstylelabelTextSize = null, WorkflowExpression<string> datadisplayOptionsstylehelpTextColor = null, WorkflowExpression<string> datadisplayOptionsstylehelpTextSize = null, WorkflowExpression<string> datadisplayOptionsstylelegalConsentTextColor = null, WorkflowExpression<string> datadisplayOptionsstylelegalConsentTextSize = null, WorkflowExpression<string> datadisplayOptionsstylesubmitColor = null, WorkflowExpression<string> datadisplayOptionsstylesubmitAlignment = null, WorkflowExpression<string> datadisplayOptionsstylesubmitFontColor = null, WorkflowExpression<string> datadisplayOptionsstylesubmitSize = null, WorkflowExpression<string> datadisplayOptionscssClass = null)
        {
            WorkflowExpression.Validate(formId, nameof(formId), required: true);
            WorkflowExpression.Validate(dataformType, nameof(dataformType), required: true);
            WorkflowExpression.Validate(dataid, nameof(dataid), required: true);
            WorkflowExpression.Validate(datacreatedAt, nameof(datacreatedAt), required: true);
            WorkflowExpression.Validate(dataupdatedAt, nameof(dataupdatedAt), required: true);
            WorkflowExpression.Validate(dataarchived, nameof(dataarchived), required: true);
            WorkflowExpression.Validate(dataname, nameof(dataname), required: false);
            WorkflowExpression.Validate(dataarchivedAt, nameof(dataarchivedAt), required: false);
            WorkflowExpression.Validate(datafieldGroups, nameof(datafieldGroups), required: false);
            WorkflowExpression.Validate(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            WorkflowExpression.Validate(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            WorkflowExpression.Validate(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            WorkflowExpression.Validate(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            WorkflowExpression.Validate(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            WorkflowExpression.Validate(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            WorkflowExpression.Validate(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            WorkflowExpression.Validate(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            WorkflowExpression.Validate(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            WorkflowExpression.Validate(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            WorkflowExpression.Validate(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            WorkflowExpression.Validate(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            WorkflowExpression.Validate(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            WorkflowExpression.Validate(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            WorkflowExpression.Validate(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            WorkflowExpression.Validate(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            WorkflowExpression.Validate(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", ExpressionConverter.ConvertWithUrlEncoding(formId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEventRead))]
        public IWorkflowAction MarketingEventRead([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> externalAccountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEventRead(WorkflowExpression<string> externalEventId, WorkflowExpression<string> externalAccountId)
        {
            WorkflowExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            WorkflowExpression.Validate(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEventsArchive))]
        public IWorkflowAction MarketingEventsArchive([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> externalAccountId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEventsArchive(WorkflowExpression<string> externalEventId, WorkflowExpression<string> externalAccountId)
        {
            WorkflowExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            WorkflowExpression.Validate(externalAccountId, nameof(externalAccountId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = ExpressionConverter.Convert(externalAccountId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEventsUpdateCreateOrUpdate))]
        public IWorkflowAction MarketingEventsUpdateCreateOrUpdate([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> dataeventName, [WorkflowExpression] Func<string> dataeventOrganizer, [WorkflowExpression] Func<string> dataexternalAccountId, [WorkflowExpression] Func<string> dataexternalEventId, [WorkflowExpression] Func<dataeventTypeInput> dataeventType = null, [WorkflowExpression] Func<string> datastartDateTime = null, [WorkflowExpression] Func<string> dataendDateTime = null, [WorkflowExpression] Func<string> dataeventDescription = null, [WorkflowExpression] Func<string> dataeventUrl = null, [WorkflowExpression] Func<bool> dataeventCancelled = null, [WorkflowExpression] Func<datacustomPropertiesInputItem[]> datacustomProperties = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEventsUpdateCreateOrUpdate(WorkflowExpression<string> externalEventId, WorkflowExpression<string> dataeventName, WorkflowExpression<string> dataeventOrganizer, WorkflowExpression<string> dataexternalAccountId, WorkflowExpression<string> dataexternalEventId, WorkflowExpression<dataeventTypeInput> dataeventType = null, WorkflowExpression<string> datastartDateTime = null, WorkflowExpression<string> dataendDateTime = null, WorkflowExpression<string> dataeventDescription = null, WorkflowExpression<string> dataeventUrl = null, WorkflowExpression<bool> dataeventCancelled = null, WorkflowExpression<datacustomPropertiesInputItem[]> datacustomProperties = null)
        {
            WorkflowExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            WorkflowExpression.Validate(dataeventName, nameof(dataeventName), required: true);
            WorkflowExpression.Validate(dataeventOrganizer, nameof(dataeventOrganizer), required: true);
            WorkflowExpression.Validate(dataexternalAccountId, nameof(dataexternalAccountId), required: true);
            WorkflowExpression.Validate(dataexternalEventId, nameof(dataexternalEventId), required: true);
            WorkflowExpression.Validate(dataeventType, nameof(dataeventType), required: false);
            WorkflowExpression.Validate(datastartDateTime, nameof(datastartDateTime), required: false);
            WorkflowExpression.Validate(dataendDateTime, nameof(dataendDateTime), required: false);
            WorkflowExpression.Validate(dataeventDescription, nameof(dataeventDescription), required: false);
            WorkflowExpression.Validate(dataeventUrl, nameof(dataeventUrl), required: false);
            WorkflowExpression.Validate(dataeventCancelled, nameof(dataeventCancelled), required: false);
            WorkflowExpression.Validate(datacustomProperties, nameof(datacustomProperties), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalEventId, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsList))]
        public IWorkflowAction MarketingEmailsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsList(WorkflowExpression<int> limit = null, WorkflowExpression<string> orderBy = null)
        {
            WorkflowExpression.Validate(limit, nameof(limit), required: false);
            WorkflowExpression.Validate(orderBy, nameof(orderBy), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsRead))]
        public IWorkflowAction MarketingEmailsRead([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsRead(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsArchive))]
        public IWorkflowAction MarketingEmailsArchive([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsArchive(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsUpdate))]
        public IWorkflowAction MarketingEmailsUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodysubject = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsUpdate(WorkflowExpression<string> id, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<string> bodyreplyTo = null, WorkflowExpression<string> bodysubject = null)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsCampaignRead))]
        public IWorkflowAction MarketingEmailsCampaignRead([WorkflowExpression] Func<string> campaignId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsCampaignRead(WorkflowExpression<string> campaignId)
        {
            WorkflowExpression.Validate(campaignId, nameof(campaignId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/email/public/v1/campaigns/{0}", ExpressionConverter.ConvertWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        [WorkflowExpressionFactory(nameof(__BuildMarketingEmailsCreate))]
        public IWorkflowAction MarketingEmailsCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodysubject = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildMarketingEmailsCreate(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodysubject = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            return new DeferredWorkflowAction(() =>
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