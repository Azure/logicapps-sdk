//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JasperipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<CommandPostResponse> Command(Expression<Func<string>> bodyinputscommand = null, Expression<Func<string>> bodyinputscontext = null, Expression<Func<int>> bodyoptionsoutputCount = null, Expression<Func<bodyoptionsinputLanguageInput>> bodyoptionsinputLanguage = null, Expression<Func<bodyoptionsoutputLanguageInput>> bodyoptionsoutputLanguage = null, Expression<Func<bodyoptionslanguageFormalityInput>> bodyoptionslanguageFormality = null, Expression<Func<bodyoptionscompletionTypeInput>> bodyoptionscompletionType = null)
        {
            var __workflow_bodyinputscommand = WorkflowExpression.Compile(bodyinputscommand, nameof(bodyinputscommand), required: false);
            var __workflow_bodyinputscontext = WorkflowExpression.Compile(bodyinputscontext, nameof(bodyinputscontext), required: false);
            var __workflow_bodyoptionsoutputCount = WorkflowExpression.Compile(bodyoptionsoutputCount, nameof(bodyoptionsoutputCount), required: false);
            var __workflow_bodyoptionsinputLanguage = WorkflowExpression.Compile(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            var __workflow_bodyoptionsoutputLanguage = WorkflowExpression.Compile(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            var __workflow_bodyoptionslanguageFormality = WorkflowExpression.Compile(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            var __workflow_bodyoptionscompletionType = WorkflowExpression.Compile(bodyoptionscompletionType, nameof(bodyoptionscompletionType), required: false);
            return new DeferredBodyAction<CommandPostResponse>(() =>
            {
                var apiCallPath = "/v1/command";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (__workflow_bodyinputscommand != null)
                {
                    inputsObject["command"] = ExpressionConverter.ConvertO(__workflow_bodyinputscommand);
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputscontext != null)
                {
                    inputsObject["context"] = ExpressionConverter.ConvertO(__workflow_bodyinputscontext);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsoutputCount != null)
                {
                    if (__workflow_bodyoptionsoutputCount != null)
                    {
                        optionsObject["outputCount"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsoutputCount);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputCount"] = 3;
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsinputLanguage != null)
                {
                    if (__workflow_bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsoutputLanguage != null)
                {
                    if (__workflow_bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionslanguageFormality != null)
                {
                    if (__workflow_bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(__workflow_bodyoptionslanguageFormality);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["languageFormality"] = "default";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionscompletionType != null)
                {
                    if (__workflow_bodyoptionscompletionType != null)
                    {
                        optionsObject["completionType"] = ExpressionConverter.ConvertO(__workflow_bodyoptionscompletionType);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["completionType"] = "performance";
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    body["options"] = optionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommandPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KeepWritingPostResponse> KeepWriting(Expression<Func<bodyinputstypeInput>> bodyinputstype = null, Expression<Func<string>> bodyinputsvalue = null, Expression<Func<bodyoptionsinputLanguageInput>> bodyoptionsinputLanguage = null, Expression<Func<bodyoptionsoutputLanguageInput>> bodyoptionsoutputLanguage = null, Expression<Func<bodyoptionslanguageFormalityInput>> bodyoptionslanguageFormality = null)
        {
            var __workflow_bodyinputstype = WorkflowExpression.Compile(bodyinputstype, nameof(bodyinputstype), required: false);
            var __workflow_bodyinputsvalue = WorkflowExpression.Compile(bodyinputsvalue, nameof(bodyinputsvalue), required: false);
            var __workflow_bodyoptionsinputLanguage = WorkflowExpression.Compile(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            var __workflow_bodyoptionsoutputLanguage = WorkflowExpression.Compile(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            var __workflow_bodyoptionslanguageFormality = WorkflowExpression.Compile(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            return new DeferredBodyAction<KeepWritingPostResponse>(() =>
            {
                var apiCallPath = "/v1/keep-writing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (__workflow_bodyinputstype != null)
                {
                    if (__workflow_bodyinputstype != null)
                    {
                        inputsObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyinputstype);
                        inputsObjectpropCount++;
                    }

                    inputsObjectpropCount++;
                }
                else
                {
                    inputsObject["type"] = "text";
                    inputsObjectpropCount++;
                }

                if (__workflow_bodyinputsvalue != null)
                {
                    inputsObject["value"] = ExpressionConverter.ConvertO(__workflow_bodyinputsvalue);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsinputLanguage != null)
                {
                    if (__workflow_bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsoutputLanguage != null)
                {
                    if (__workflow_bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionslanguageFormality != null)
                {
                    if (__workflow_bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(__workflow_bodyoptionslanguageFormality);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["languageFormality"] = "default";
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    body["options"] = optionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KeepWritingPostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatesGetResponse> TemplatesGet()
        {
            var apiCallPath = "/v1/templates";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TemplatesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet(Expression<Func<string>> templateId)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatePostResponse> Template(Expression<Func<string>> templateId, Expression<Func<int>> bodyoptionsoutputCount = null, Expression<Func<bodyoptionsinputLanguageInput>> bodyoptionsinputLanguage = null, Expression<Func<bodyoptionsoutputLanguageInput>> bodyoptionsoutputLanguage = null, Expression<Func<bodyoptionslanguageFormalityInput>> bodyoptionslanguageFormality = null)
        {
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_bodyoptionsoutputCount = WorkflowExpression.Compile(bodyoptionsoutputCount, nameof(bodyoptionsoutputCount), required: false);
            var __workflow_bodyoptionsinputLanguage = WorkflowExpression.Compile(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            var __workflow_bodyoptionsoutputLanguage = WorkflowExpression.Compile(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            var __workflow_bodyoptionslanguageFormality = WorkflowExpression.Compile(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            return new DeferredBodyAction<TemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/templates/{0}/run", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (__workflow_bodyoptionsoutputCount != null)
                {
                    optionsObject["outputCount"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsoutputCount);
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsinputLanguage != null)
                {
                    if (__workflow_bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionsoutputLanguage != null)
                {
                    if (__workflow_bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(__workflow_bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (__workflow_bodyoptionslanguageFormality != null)
                {
                    if (__workflow_bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(__workflow_bodyoptionslanguageFormality);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["languageFormality"] = "default";
                    optionsObjectpropCount++;
                }

                if (optionsObjectpropCount > 0)
                {
                    body["options"] = optionsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TemplatePostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgesGetResponse> KnowledgesGet(Expression<Func<int>> page = null, Expression<Func<int>> size = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_size = WorkflowExpression.Compile(size, nameof(size), required: false);
            return new DeferredBodyAction<KnowledgesGetResponse>(() =>
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                if (__workflow_size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(__workflow_size);
                return new ApiConnectionAction<KnowledgesGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePostResponse> Knowledge(Expression<Func<string>> bodyname, Expression<Func<string>> bodyfile, Expression<Func<bodysettingsappVisibilityInput>> bodysettingsappVisibility = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: true);
            var __workflow_bodysettingsappVisibility = WorkflowExpression.Compile(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            return new DeferredBodyAction<KnowledgePostResponse>(() =>
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsappVisibility != null)
                {
                    if (__workflow_bodysettingsappVisibility != null)
                    {
                        settingsObject["appVisibility"] = ExpressionConverter.ConvertO(__workflow_bodysettingsappVisibility);
                        settingsObjectpropCount++;
                    }

                    settingsObjectpropCount++;
                }
                else
                {
                    settingsObject["appVisibility"] = "visible";
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KnowledgePostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeGetResponse> KnowledgeGet(Expression<Func<string>> knowledgeId)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeDeleteResponse> KnowledgeDelete(Expression<Func<string>> knowledgeId)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeDeleteResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePatchResponse> KnowledgePatch(Expression<Func<string>> knowledgeId, Expression<Func<string>> bodysettingsappVisibility = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyfile = null)
        {
            var __workflow_knowledgeId = WorkflowExpression.Compile(knowledgeId, nameof(knowledgeId), required: true);
            var __workflow_bodysettingsappVisibility = WorkflowExpression.Compile(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyfile = WorkflowExpression.Compile(bodyfile, nameof(bodyfile), required: false);
            return new DeferredBodyAction<KnowledgePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/knowledge/{0}", __workflow_knowledgeId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsappVisibility != null)
                {
                    settingsObject["appVisibility"] = ExpressionConverter.ConvertO(__workflow_bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(__workflow_bodyfile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KnowledgePatchResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonesGetResponseItem[]> TonesGet()
        {
            var apiCallPath = "/v1/tones";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TonesGetResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePostResponse> Tone(Expression<Func<string>> bodyname, Expression<Func<string>> bodyvalue, Expression<Func<bodysettingsappVisibilityInput>> bodysettingsappVisibility = null)
        {
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: true);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: true);
            var __workflow_bodysettingsappVisibility = WorkflowExpression.Compile(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            return new DeferredBodyAction<TonePostResponse>(() =>
            {
                var apiCallPath = "/v1/tones";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsappVisibility != null)
                {
                    if (__workflow_bodysettingsappVisibility != null)
                    {
                        settingsObject["appVisibility"] = ExpressionConverter.ConvertO(__workflow_bodysettingsappVisibility);
                        settingsObjectpropCount++;
                    }

                    settingsObjectpropCount++;
                }
                else
                {
                    settingsObject["appVisibility"] = "visible";
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TonePostResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneGetResponse> ToneGet(Expression<Func<string>> toneId)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneGetResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePatchResponse> TonePatch(Expression<Func<string>> toneId, Expression<Func<string>> bodysettingsappVisibility = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyvalue = null)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            var __workflow_bodysettingsappVisibility = WorkflowExpression.Compile(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredBodyAction<TonePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var metadataObject = new JObject();
                var metadataObjectpropCount = 0;
                if (metadataObjectpropCount > 0)
                {
                    body["metadata"] = metadataObject;
                    bodypropCount++;
                }

                var settingsObject = new JObject();
                var settingsObjectpropCount = 0;
                if (__workflow_bodysettingsappVisibility != null)
                {
                    settingsObject["appVisibility"] = ExpressionConverter.ConvertO(__workflow_bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TonePatchResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneDeleteResponse> ToneDelete(Expression<Func<string>> toneId)
        {
            var __workflow_toneId = WorkflowExpression.Compile(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v1/tones/{0}", __workflow_toneId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneDeleteResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class JasperipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CommandPostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public CommandPostResponseDataTypeItem[] Data { get; set; }
    }

    public class CommandPostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionsinputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionsoutputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionslanguageFormalityInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "less")]
        Less
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyoptionscompletionTypeInput
    {
        [EnumMember(Value = "performance")]
        Performance,
        [EnumMember(Value = "quality")]
        Quality
    }

    public class KeepWritingPostResponse
    {
        [JsonProperty("data")]
        public KeepWritingPostResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class KeepWritingPostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinputstypeInput
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "id")]
        Id
    }

    public class TemplatesGetResponse
    {
        [JsonProperty("data")]
        public TemplatesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class TemplatesGetResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputSchema")]
        public TemplatesGetResponseDataTypeItemInputSchemaTypeItem[] InputSchema { get; set; }
    }

    public class TemplatesGetResponseDataTypeItemInputSchemaTypeItem
    {
        [JsonProperty("inputKey")]
        public string InputKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("tooltip")]
        public string Tooltip { get; set; }
    }

    public class TemplateGetResponse
    {
        [JsonProperty("data")]
        public TemplateGetResponseDataType Data { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }
    }

    public class TemplateGetResponseDataType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("inputSchema")]
        public TemplateGetResponseDataTypeInputSchemaTypeItem[] InputSchema { get; set; }
    }

    public class TemplateGetResponseDataTypeInputSchemaTypeItem
    {
        [JsonProperty("inputKey")]
        public string InputKey { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("required")]
        public bool Required { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("maxLength")]
        public int MaxLength { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }
    }

    public class TemplatePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TemplatePostResponseDataTypeItem[] Data { get; set; }
    }

    public class TemplatePostResponseDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class KnowledgesGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgesGetResponseDataTypeItem[] Data { get; set; }

        [JsonProperty("pagination")]
        public KnowledgesGetResponsePaginationType Pagination { get; set; }
    }

    public class KnowledgesGetResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgesGetResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgesGetResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgesGetResponsePaginationType
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

    public class KnowledgePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgePostResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgePostResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePostResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgePostResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysettingsappVisibilityInput
    {
        [EnumMember(Value = "visible")]
        Visible,
        [EnumMember(Value = "hidden")]
        Hidden
    }

    public class KnowledgeGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgeGetResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public KnowledgeGetResponseDataTypeItemMetadataType Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgeGetResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItemMetadataType
    {
        [JsonProperty("customerId")]
        public string CustomerId { get; set; }
    }

    public class KnowledgeGetResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class KnowledgeDeleteResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }

    public class KnowledgePatchResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public KnowledgePatchResponseDataTypeItem[] Data { get; set; }
    }

    public class KnowledgePatchResponseDataTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public KnowledgePatchResponseDataTypeItemSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("processingState")]
        public string ProcessingState { get; set; }
    }

    public class KnowledgePatchResponseDataTypeItemSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonesGetResponseItem
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonesGetResponseItemDataType Data { get; set; }

        [JsonProperty("pagination")]
        public TonesGetResponseItemPaginationType Pagination { get; set; }
    }

    public class TonesGetResponseItemDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonesGetResponseItemDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonesGetResponseItemDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonesGetResponseItemPaginationType
    {
        [JsonProperty("totalRecords")]
        public int TotalRecords { get; set; }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("prev")]
        public string Prev { get; set; }
    }

    public class TonePostResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonePostResponseDataType Data { get; set; }
    }

    public class TonePostResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePostResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonePostResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class ToneGetResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public ToneGetResponseDataType Data { get; set; }
    }

    public class ToneGetResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public ToneGetResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class ToneGetResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class TonePatchResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("data")]
        public TonePatchResponseDataType Data { get; set; }
    }

    public class TonePatchResponseDataType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }

        [JsonProperty("settings")]
        public TonePatchResponseDataTypeSettingsType Settings { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
    }

    public class TonePatchResponseDataTypeSettingsType
    {
        [JsonProperty("appVisibility")]
        public string AppVisibility { get; set; }
    }

    public class ToneDeleteResponse
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("deleted")]
        public bool Deleted { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip;

    public partial class WorkflowManagedActions
    {
        public JasperipActions Jasperip(string connectionId) => new JasperipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JasperipTriggers Jasperip(string connectionId) => new JasperipTriggers(connectionId);
    }
}
