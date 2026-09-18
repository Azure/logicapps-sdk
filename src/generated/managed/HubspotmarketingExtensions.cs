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
        public IWorkflowAction FormsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/marketing/v3/forms/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(20);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsCreate([WorkflowExpression] Func<string> dataformType = null, [WorkflowExpression] Func<string> dataname = null, [WorkflowExpression] Func<string> datacreatedAt = null, [WorkflowExpression] Func<string> dataupdatedAt = null, [WorkflowExpression] Func<bool> dataarchived = null, [WorkflowExpression] Func<string> dataarchivedAt = null, [WorkflowExpression] Func<datafieldGroupsInputItem[]> datafieldGroups = null, [WorkflowExpression] Func<string> dataconfigurationlanguage = null, [WorkflowExpression] Func<bool> dataconfigurationcloneable = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActiontype = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActionvalue = null, [WorkflowExpression] Func<bool> dataconfigurationeditable = null, [WorkflowExpression] Func<bool> dataconfigurationarchivable = null, [WorkflowExpression] Func<bool> dataconfigurationrecaptchaEnabled = null, [WorkflowExpression] Func<bool> dataconfigurationnotifyContactOwner = null, [WorkflowExpression] Func<string[]> dataconfigurationnotifyRecipients = null, [WorkflowExpression] Func<bool> dataconfigurationcreateNewContactForNewEmail = null, [WorkflowExpression] Func<bool> dataconfigurationprePopulateKnownValues = null, [WorkflowExpression] Func<bool> dataconfigurationallowLinkToResetKnownValues = null, [WorkflowExpression] Func<bool> datadisplayOptionsrenderRawHtml = null, [WorkflowExpression] Func<string> datadisplayOptionstheme = null, [WorkflowExpression] Func<string> datadisplayOptionssubmitButtonText = null, [WorkflowExpression] Func<string> datadisplayOptionsstylefontFamily = null, [WorkflowExpression] Func<string> datadisplayOptionsstylebackgroundWidth = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitAlignment = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitFontColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitSize = null, [WorkflowExpression] Func<string> datadisplayOptionscssClass = null)
        {
            SourceExpression.Validate(dataformType, nameof(dataformType), required: false);
            SourceExpression.Validate(dataname, nameof(dataname), required: false);
            SourceExpression.Validate(datacreatedAt, nameof(datacreatedAt), required: false);
            SourceExpression.Validate(dataupdatedAt, nameof(dataupdatedAt), required: false);
            SourceExpression.Validate(dataarchived, nameof(dataarchived), required: false);
            SourceExpression.Validate(dataarchivedAt, nameof(dataarchivedAt), required: false);
            SourceExpression.Validate(datafieldGroups, nameof(datafieldGroups), required: false);
            SourceExpression.Validate(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            SourceExpression.Validate(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            SourceExpression.Validate(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            SourceExpression.Validate(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            SourceExpression.Validate(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            SourceExpression.Validate(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            SourceExpression.Validate(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            SourceExpression.Validate(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            SourceExpression.Validate(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            SourceExpression.Validate(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            SourceExpression.Validate(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            SourceExpression.Validate(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            SourceExpression.Validate(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            SourceExpression.Validate(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            SourceExpression.Validate(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            SourceExpression.Validate(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            SourceExpression.Validate(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            SourceExpression.Validate(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            ApiConnectionActionInput BuildSourceInput()
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
                        data["formType"] = SourceExpressionConverter.ConvertToken(dataformType);
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
                    data["name"] = SourceExpressionConverter.ConvertToken(dataname);
                    datapropCount++;
                }

                if (datacreatedAt != null)
                {
                    data["createdAt"] = SourceExpressionConverter.ConvertToken(datacreatedAt);
                    datapropCount++;
                }

                if (dataupdatedAt != null)
                {
                    data["updatedAt"] = SourceExpressionConverter.ConvertToken(dataupdatedAt);
                    datapropCount++;
                }

                if (dataarchived != null)
                {
                    if (dataarchived != null)
                    {
                        data["archived"] = SourceExpressionConverter.ConvertToken(dataarchived);
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
                    data["archivedAt"] = SourceExpressionConverter.ConvertToken(dataarchivedAt);
                    datapropCount++;
                }

                if (datafieldGroups != null)
                {
                    data["fieldGroups"] = SourceExpressionConverter.ConvertToken(datafieldGroups);
                    datapropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (dataconfigurationlanguage != null)
                {
                    configurationObject["language"] = SourceExpressionConverter.ConvertToken(dataconfigurationlanguage);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationcloneable != null)
                {
                    configurationObject["cloneable"] = SourceExpressionConverter.ConvertToken(dataconfigurationcloneable);
                    configurationObjectpropCount++;
                }

                var postSubmitActionObject = new JObject();
                var postSubmitActionObjectpropCount = 0;
                if (dataconfigurationpostSubmitActiontype != null)
                {
                    postSubmitActionObject["type"] = SourceExpressionConverter.ConvertToken(dataconfigurationpostSubmitActiontype);
                    postSubmitActionObjectpropCount++;
                }

                if (dataconfigurationpostSubmitActionvalue != null)
                {
                    postSubmitActionObject["value"] = SourceExpressionConverter.ConvertToken(dataconfigurationpostSubmitActionvalue);
                    postSubmitActionObjectpropCount++;
                }

                if (postSubmitActionObjectpropCount > 0)
                {
                    configurationObject["postSubmitAction"] = postSubmitActionObject;
                    configurationObjectpropCount++;
                }

                if (dataconfigurationeditable != null)
                {
                    configurationObject["editable"] = SourceExpressionConverter.ConvertToken(dataconfigurationeditable);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationarchivable != null)
                {
                    configurationObject["archivable"] = SourceExpressionConverter.ConvertToken(dataconfigurationarchivable);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationrecaptchaEnabled != null)
                {
                    configurationObject["recaptchaEnabled"] = SourceExpressionConverter.ConvertToken(dataconfigurationrecaptchaEnabled);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationnotifyContactOwner != null)
                {
                    configurationObject["notifyContactOwner"] = SourceExpressionConverter.ConvertToken(dataconfigurationnotifyContactOwner);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationnotifyRecipients != null)
                {
                    configurationObject["notifyRecipients"] = SourceExpressionConverter.ConvertToken(dataconfigurationnotifyRecipients);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationcreateNewContactForNewEmail != null)
                {
                    configurationObject["createNewContactForNewEmail"] = SourceExpressionConverter.ConvertToken(dataconfigurationcreateNewContactForNewEmail);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationprePopulateKnownValues != null)
                {
                    configurationObject["prePopulateKnownValues"] = SourceExpressionConverter.ConvertToken(dataconfigurationprePopulateKnownValues);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationallowLinkToResetKnownValues != null)
                {
                    configurationObject["allowLinkToResetKnownValues"] = SourceExpressionConverter.ConvertToken(dataconfigurationallowLinkToResetKnownValues);
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
                    displayOptionsObject["renderRawHtml"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsrenderRawHtml);
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionstheme != null)
                {
                    displayOptionsObject["theme"] = SourceExpressionConverter.ConvertToken(datadisplayOptionstheme);
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionssubmitButtonText != null)
                {
                    displayOptionsObject["submitButtonText"] = SourceExpressionConverter.ConvertToken(datadisplayOptionssubmitButtonText);
                    displayOptionsObjectpropCount++;
                }

                var styleObject = new JObject();
                var styleObjectpropCount = 0;
                if (datadisplayOptionsstylefontFamily != null)
                {
                    styleObject["fontFamily"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylefontFamily);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylebackgroundWidth != null)
                {
                    styleObject["backgroundWidth"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylebackgroundWidth);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelabelTextColor != null)
                {
                    styleObject["labelTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelabelTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelabelTextSize != null)
                {
                    styleObject["labelTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelabelTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylehelpTextColor != null)
                {
                    styleObject["helpTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylehelpTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylehelpTextSize != null)
                {
                    styleObject["helpTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylehelpTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelegalConsentTextColor != null)
                {
                    styleObject["legalConsentTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelegalConsentTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelegalConsentTextSize != null)
                {
                    styleObject["legalConsentTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelegalConsentTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitColor != null)
                {
                    styleObject["submitColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitAlignment != null)
                {
                    styleObject["submitAlignment"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitAlignment);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitFontColor != null)
                {
                    styleObject["submitFontColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitFontColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitSize != null)
                {
                    styleObject["submitSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitSize);
                    styleObjectpropCount++;
                }

                if (styleObjectpropCount > 0)
                {
                    displayOptionsObject["style"] = styleObject;
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionscssClass != null)
                {
                    displayOptionsObject["cssClass"] = SourceExpressionConverter.ConvertToken(datadisplayOptionscssClass);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsRead([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<bool> archived = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(archived, nameof(archived), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["archived"] = Convert.ToString(false);
                if (archived != null)
                    callPayload.Queries["archived"] = SourceExpressionConverter.ConvertO(archived);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsArchive([WorkflowExpression] Func<string> formId)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction FormsUpdate([WorkflowExpression] Func<string> formId, [WorkflowExpression] Func<string> dataformType, [WorkflowExpression] Func<string> dataid, [WorkflowExpression] Func<string> datacreatedAt, [WorkflowExpression] Func<string> dataupdatedAt, [WorkflowExpression] Func<bool> dataarchived, [WorkflowExpression] Func<string> dataname = null, [WorkflowExpression] Func<string> dataarchivedAt = null, [WorkflowExpression] Func<datafieldGroupsInputItem[]> datafieldGroups = null, [WorkflowExpression] Func<string> dataconfigurationlanguage = null, [WorkflowExpression] Func<bool> dataconfigurationcloneable = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActiontype = null, [WorkflowExpression] Func<string> dataconfigurationpostSubmitActionvalue = null, [WorkflowExpression] Func<bool> dataconfigurationeditable = null, [WorkflowExpression] Func<bool> dataconfigurationarchivable = null, [WorkflowExpression] Func<bool> dataconfigurationrecaptchaEnabled = null, [WorkflowExpression] Func<bool> dataconfigurationnotifyContactOwner = null, [WorkflowExpression] Func<string[]> dataconfigurationnotifyRecipients = null, [WorkflowExpression] Func<bool> dataconfigurationcreateNewContactForNewEmail = null, [WorkflowExpression] Func<bool> dataconfigurationprePopulateKnownValues = null, [WorkflowExpression] Func<bool> dataconfigurationallowLinkToResetKnownValues = null, [WorkflowExpression] Func<bool> datadisplayOptionsrenderRawHtml = null, [WorkflowExpression] Func<string> datadisplayOptionstheme = null, [WorkflowExpression] Func<string> datadisplayOptionssubmitButtonText = null, [WorkflowExpression] Func<string> datadisplayOptionsstylefontFamily = null, [WorkflowExpression] Func<string> datadisplayOptionsstylebackgroundWidth = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelabelTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylehelpTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylelegalConsentTextSize = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitAlignment = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitFontColor = null, [WorkflowExpression] Func<string> datadisplayOptionsstylesubmitSize = null, [WorkflowExpression] Func<string> datadisplayOptionscssClass = null)
        {
            SourceExpression.Validate(formId, nameof(formId), required: true);
            SourceExpression.Validate(dataformType, nameof(dataformType), required: true);
            SourceExpression.Validate(dataid, nameof(dataid), required: true);
            SourceExpression.Validate(datacreatedAt, nameof(datacreatedAt), required: true);
            SourceExpression.Validate(dataupdatedAt, nameof(dataupdatedAt), required: true);
            SourceExpression.Validate(dataarchived, nameof(dataarchived), required: true);
            SourceExpression.Validate(dataname, nameof(dataname), required: false);
            SourceExpression.Validate(dataarchivedAt, nameof(dataarchivedAt), required: false);
            SourceExpression.Validate(datafieldGroups, nameof(datafieldGroups), required: false);
            SourceExpression.Validate(dataconfigurationlanguage, nameof(dataconfigurationlanguage), required: false);
            SourceExpression.Validate(dataconfigurationcloneable, nameof(dataconfigurationcloneable), required: false);
            SourceExpression.Validate(dataconfigurationpostSubmitActiontype, nameof(dataconfigurationpostSubmitActiontype), required: false);
            SourceExpression.Validate(dataconfigurationpostSubmitActionvalue, nameof(dataconfigurationpostSubmitActionvalue), required: false);
            SourceExpression.Validate(dataconfigurationeditable, nameof(dataconfigurationeditable), required: false);
            SourceExpression.Validate(dataconfigurationarchivable, nameof(dataconfigurationarchivable), required: false);
            SourceExpression.Validate(dataconfigurationrecaptchaEnabled, nameof(dataconfigurationrecaptchaEnabled), required: false);
            SourceExpression.Validate(dataconfigurationnotifyContactOwner, nameof(dataconfigurationnotifyContactOwner), required: false);
            SourceExpression.Validate(dataconfigurationnotifyRecipients, nameof(dataconfigurationnotifyRecipients), required: false);
            SourceExpression.Validate(dataconfigurationcreateNewContactForNewEmail, nameof(dataconfigurationcreateNewContactForNewEmail), required: false);
            SourceExpression.Validate(dataconfigurationprePopulateKnownValues, nameof(dataconfigurationprePopulateKnownValues), required: false);
            SourceExpression.Validate(dataconfigurationallowLinkToResetKnownValues, nameof(dataconfigurationallowLinkToResetKnownValues), required: false);
            SourceExpression.Validate(datadisplayOptionsrenderRawHtml, nameof(datadisplayOptionsrenderRawHtml), required: false);
            SourceExpression.Validate(datadisplayOptionstheme, nameof(datadisplayOptionstheme), required: false);
            SourceExpression.Validate(datadisplayOptionssubmitButtonText, nameof(datadisplayOptionssubmitButtonText), required: false);
            SourceExpression.Validate(datadisplayOptionsstylefontFamily, nameof(datadisplayOptionsstylefontFamily), required: false);
            SourceExpression.Validate(datadisplayOptionsstylebackgroundWidth, nameof(datadisplayOptionsstylebackgroundWidth), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelabelTextColor, nameof(datadisplayOptionsstylelabelTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelabelTextSize, nameof(datadisplayOptionsstylelabelTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylehelpTextColor, nameof(datadisplayOptionsstylehelpTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylehelpTextSize, nameof(datadisplayOptionsstylehelpTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelegalConsentTextColor, nameof(datadisplayOptionsstylelegalConsentTextColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylelegalConsentTextSize, nameof(datadisplayOptionsstylelegalConsentTextSize), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitColor, nameof(datadisplayOptionsstylesubmitColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitAlignment, nameof(datadisplayOptionsstylesubmitAlignment), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitFontColor, nameof(datadisplayOptionsstylesubmitFontColor), required: false);
            SourceExpression.Validate(datadisplayOptionsstylesubmitSize, nameof(datadisplayOptionsstylesubmitSize), required: false);
            SourceExpression.Validate(datadisplayOptionscssClass, nameof(datadisplayOptionscssClass), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/forms/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(formId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["formType"] = SourceExpressionConverter.ConvertToken(dataformType);
                datapropCount++;
                data["id"] = SourceExpressionConverter.ConvertToken(dataid);
                if (dataname != null)
                {
                    data["name"] = SourceExpressionConverter.ConvertToken(dataname);
                    datapropCount++;
                }

                datapropCount++;
                data["createdAt"] = SourceExpressionConverter.ConvertToken(datacreatedAt);
                datapropCount++;
                data["updatedAt"] = SourceExpressionConverter.ConvertToken(dataupdatedAt);
                datapropCount++;
                data["archived"] = SourceExpressionConverter.ConvertToken(dataarchived);
                if (dataarchivedAt != null)
                {
                    data["archivedAt"] = SourceExpressionConverter.ConvertToken(dataarchivedAt);
                    datapropCount++;
                }

                if (datafieldGroups != null)
                {
                    data["fieldGroups"] = SourceExpressionConverter.ConvertToken(datafieldGroups);
                    datapropCount++;
                }

                var configurationObject = new JObject();
                var configurationObjectpropCount = 0;
                if (dataconfigurationlanguage != null)
                {
                    configurationObject["language"] = SourceExpressionConverter.ConvertToken(dataconfigurationlanguage);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationcloneable != null)
                {
                    configurationObject["cloneable"] = SourceExpressionConverter.ConvertToken(dataconfigurationcloneable);
                    configurationObjectpropCount++;
                }

                var postSubmitActionObject = new JObject();
                var postSubmitActionObjectpropCount = 0;
                if (dataconfigurationpostSubmitActiontype != null)
                {
                    postSubmitActionObject["type"] = SourceExpressionConverter.ConvertToken(dataconfigurationpostSubmitActiontype);
                    postSubmitActionObjectpropCount++;
                }

                if (dataconfigurationpostSubmitActionvalue != null)
                {
                    postSubmitActionObject["value"] = SourceExpressionConverter.ConvertToken(dataconfigurationpostSubmitActionvalue);
                    postSubmitActionObjectpropCount++;
                }

                if (postSubmitActionObjectpropCount > 0)
                {
                    configurationObject["postSubmitAction"] = postSubmitActionObject;
                    configurationObjectpropCount++;
                }

                if (dataconfigurationeditable != null)
                {
                    configurationObject["editable"] = SourceExpressionConverter.ConvertToken(dataconfigurationeditable);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationarchivable != null)
                {
                    configurationObject["archivable"] = SourceExpressionConverter.ConvertToken(dataconfigurationarchivable);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationrecaptchaEnabled != null)
                {
                    configurationObject["recaptchaEnabled"] = SourceExpressionConverter.ConvertToken(dataconfigurationrecaptchaEnabled);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationnotifyContactOwner != null)
                {
                    configurationObject["notifyContactOwner"] = SourceExpressionConverter.ConvertToken(dataconfigurationnotifyContactOwner);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationnotifyRecipients != null)
                {
                    configurationObject["notifyRecipients"] = SourceExpressionConverter.ConvertToken(dataconfigurationnotifyRecipients);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationcreateNewContactForNewEmail != null)
                {
                    configurationObject["createNewContactForNewEmail"] = SourceExpressionConverter.ConvertToken(dataconfigurationcreateNewContactForNewEmail);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationprePopulateKnownValues != null)
                {
                    configurationObject["prePopulateKnownValues"] = SourceExpressionConverter.ConvertToken(dataconfigurationprePopulateKnownValues);
                    configurationObjectpropCount++;
                }

                if (dataconfigurationallowLinkToResetKnownValues != null)
                {
                    configurationObject["allowLinkToResetKnownValues"] = SourceExpressionConverter.ConvertToken(dataconfigurationallowLinkToResetKnownValues);
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
                    displayOptionsObject["renderRawHtml"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsrenderRawHtml);
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionstheme != null)
                {
                    displayOptionsObject["theme"] = SourceExpressionConverter.ConvertToken(datadisplayOptionstheme);
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionssubmitButtonText != null)
                {
                    displayOptionsObject["submitButtonText"] = SourceExpressionConverter.ConvertToken(datadisplayOptionssubmitButtonText);
                    displayOptionsObjectpropCount++;
                }

                var styleObject = new JObject();
                var styleObjectpropCount = 0;
                if (datadisplayOptionsstylefontFamily != null)
                {
                    styleObject["fontFamily"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylefontFamily);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylebackgroundWidth != null)
                {
                    styleObject["backgroundWidth"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylebackgroundWidth);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelabelTextColor != null)
                {
                    styleObject["labelTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelabelTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelabelTextSize != null)
                {
                    styleObject["labelTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelabelTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylehelpTextColor != null)
                {
                    styleObject["helpTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylehelpTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylehelpTextSize != null)
                {
                    styleObject["helpTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylehelpTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelegalConsentTextColor != null)
                {
                    styleObject["legalConsentTextColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelegalConsentTextColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylelegalConsentTextSize != null)
                {
                    styleObject["legalConsentTextSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylelegalConsentTextSize);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitColor != null)
                {
                    styleObject["submitColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitAlignment != null)
                {
                    styleObject["submitAlignment"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitAlignment);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitFontColor != null)
                {
                    styleObject["submitFontColor"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitFontColor);
                    styleObjectpropCount++;
                }

                if (datadisplayOptionsstylesubmitSize != null)
                {
                    styleObject["submitSize"] = SourceExpressionConverter.ConvertToken(datadisplayOptionsstylesubmitSize);
                    styleObjectpropCount++;
                }

                if (styleObjectpropCount > 0)
                {
                    displayOptionsObject["style"] = styleObject;
                    displayOptionsObjectpropCount++;
                }

                if (datadisplayOptionscssClass != null)
                {
                    displayOptionsObject["cssClass"] = SourceExpressionConverter.ConvertToken(datadisplayOptionscssClass);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventRead([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> externalAccountId)
        {
            SourceExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            SourceExpression.Validate(externalAccountId, nameof(externalAccountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalEventId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = SourceExpressionConverter.ConvertO(externalAccountId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsArchive([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> externalAccountId)
        {
            SourceExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            SourceExpression.Validate(externalAccountId, nameof(externalAccountId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalEventId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalAccountId"] = SourceExpressionConverter.ConvertO(externalAccountId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEventsUpdateCreateOrUpdate([WorkflowExpression] Func<string> externalEventId, [WorkflowExpression] Func<string> dataeventName, [WorkflowExpression] Func<string> dataeventOrganizer, [WorkflowExpression] Func<string> dataexternalAccountId, [WorkflowExpression] Func<string> dataexternalEventId, [WorkflowExpression] Func<dataeventTypeInput> dataeventType = null, [WorkflowExpression] Func<string> datastartDateTime = null, [WorkflowExpression] Func<string> dataendDateTime = null, [WorkflowExpression] Func<string> dataeventDescription = null, [WorkflowExpression] Func<string> dataeventUrl = null, [WorkflowExpression] Func<bool> dataeventCancelled = null, [WorkflowExpression] Func<datacustomPropertiesInputItem[]> datacustomProperties = null)
        {
            SourceExpression.Validate(externalEventId, nameof(externalEventId), required: true);
            SourceExpression.Validate(dataeventName, nameof(dataeventName), required: true);
            SourceExpression.Validate(dataeventOrganizer, nameof(dataeventOrganizer), required: true);
            SourceExpression.Validate(dataexternalAccountId, nameof(dataexternalAccountId), required: true);
            SourceExpression.Validate(dataexternalEventId, nameof(dataexternalEventId), required: true);
            SourceExpression.Validate(dataeventType, nameof(dataeventType), required: false);
            SourceExpression.Validate(datastartDateTime, nameof(datastartDateTime), required: false);
            SourceExpression.Validate(dataendDateTime, nameof(dataendDateTime), required: false);
            SourceExpression.Validate(dataeventDescription, nameof(dataeventDescription), required: false);
            SourceExpression.Validate(dataeventUrl, nameof(dataeventUrl), required: false);
            SourceExpression.Validate(dataeventCancelled, nameof(dataeventCancelled), required: false);
            SourceExpression.Validate(datacustomProperties, nameof(datacustomProperties), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing/v3/marketing-events-beta/events/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalEventId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var data = new JObject();
                var datapropCount = 0;
                datapropCount++;
                data["eventName"] = SourceExpressionConverter.ConvertToken(dataeventName);
                if (dataeventType != null)
                {
                    data["eventType"] = SourceExpressionConverter.Convert(dataeventType);
                    datapropCount++;
                }

                if (datastartDateTime != null)
                {
                    data["startDateTime"] = SourceExpressionConverter.ConvertToken(datastartDateTime);
                    datapropCount++;
                }

                if (dataendDateTime != null)
                {
                    data["endDateTime"] = SourceExpressionConverter.ConvertToken(dataendDateTime);
                    datapropCount++;
                }

                datapropCount++;
                data["eventOrganizer"] = SourceExpressionConverter.ConvertToken(dataeventOrganizer);
                if (dataeventDescription != null)
                {
                    data["eventDescription"] = SourceExpressionConverter.ConvertToken(dataeventDescription);
                    datapropCount++;
                }

                if (dataeventUrl != null)
                {
                    data["eventUrl"] = SourceExpressionConverter.ConvertToken(dataeventUrl);
                    datapropCount++;
                }

                if (dataeventCancelled != null)
                {
                    data["eventCancelled"] = SourceExpressionConverter.ConvertToken(dataeventCancelled);
                    datapropCount++;
                }

                if (datacustomProperties != null)
                {
                    data["customProperties"] = SourceExpressionConverter.ConvertToken(datacustomProperties);
                    datapropCount++;
                }

                datapropCount++;
                data["externalAccountId"] = SourceExpressionConverter.ConvertToken(dataexternalAccountId);
                datapropCount++;
                data["externalEventId"] = SourceExpressionConverter.ConvertToken(dataexternalEventId);
                if (datapropCount > 0)
                {
                    callPayload.Body = data;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsList([WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> orderBy = null)
        {
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(orderBy, nameof(orderBy), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/marketing-emails/v1/emails";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["limit"] = Convert.ToString(10);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["orderBy"] = Convert.ToString("created");
                if (orderBy != null)
                    callPayload.Queries["orderBy"] = SourceExpressionConverter.ConvertO(orderBy);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsRead([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsArchive([WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsUpdate([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodysubject = null)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            SourceExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/marketing-emails/v1/emails/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyfromName != null)
                {
                    body["fromName"] = SourceExpressionConverter.ConvertToken(bodyfromName);
                    bodypropCount++;
                }

                if (bodyreplyTo != null)
                {
                    body["replyTo"] = SourceExpressionConverter.ConvertToken(bodyreplyTo);
                    bodypropCount++;
                }

                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCampaignRead([WorkflowExpression] Func<string> campaignId)
        {
            SourceExpression.Validate(campaignId, nameof(campaignId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/email/public/v1/campaigns/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(campaignId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "hubspotmarketing")]
        public IWorkflowAction MarketingEmailsCreate([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodysubject = null)
        {
            SourceExpression.Validate(bodyname, nameof(bodyname), required: true);
            SourceExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/marketing-emails/v1/emails/";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
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