//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JasperipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildCommand))]
        public IBodyWorkflowAction<CommandPostResponse> Command([WorkflowExpression] Func<string> bodyinputscommand = null, [WorkflowExpression] Func<string> bodyinputscontext = null, [WorkflowExpression] Func<int> bodyoptionsoutputCount = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null, [WorkflowExpression] Func<bodyoptionscompletionTypeInput> bodyoptionscompletionType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommandPostResponse> __BuildCommand(WorkflowExpression<string> bodyinputscommand = null, WorkflowExpression<string> bodyinputscontext = null, WorkflowExpression<int> bodyoptionsoutputCount = null, WorkflowExpression<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, WorkflowExpression<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, WorkflowExpression<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null, WorkflowExpression<bodyoptionscompletionTypeInput> bodyoptionscompletionType = null)
        {
            WorkflowExpression.Validate(bodyinputscommand, nameof(bodyinputscommand), required: false);
            WorkflowExpression.Validate(bodyinputscontext, nameof(bodyinputscontext), required: false);
            WorkflowExpression.Validate(bodyoptionsoutputCount, nameof(bodyoptionsoutputCount), required: false);
            WorkflowExpression.Validate(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            WorkflowExpression.Validate(bodyoptionscompletionType, nameof(bodyoptionscompletionType), required: false);
            return new DeferredBodyAction<CommandPostResponse>(() =>
            {
                var apiCallPath = "/v1/command";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (bodyinputscommand != null)
                {
                    inputsObject["command"] = ExpressionConverter.ConvertO(bodyinputscommand);
                    inputsObjectpropCount++;
                }

                if (bodyinputscontext != null)
                {
                    inputsObject["context"] = ExpressionConverter.ConvertO(bodyinputscontext);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsoutputCount != null)
                {
                    if (bodyoptionsoutputCount != null)
                    {
                        optionsObject["outputCount"] = ExpressionConverter.ConvertO(bodyoptionsoutputCount);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputCount"] = 3;
                    optionsObjectpropCount++;
                }

                if (bodyoptionsinputLanguage != null)
                {
                    if (bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionsoutputLanguage != null)
                {
                    if (bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionslanguageFormality != null)
                {
                    if (bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(bodyoptionslanguageFormality);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["languageFormality"] = "default";
                    optionsObjectpropCount++;
                }

                if (bodyoptionscompletionType != null)
                {
                    if (bodyoptionscompletionType != null)
                    {
                        optionsObject["completionType"] = ExpressionConverter.ConvertO(bodyoptionscompletionType);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKeepWriting))]
        public IBodyWorkflowAction<KeepWritingPostResponse> KeepWriting([WorkflowExpression] Func<bodyinputstypeInput> bodyinputstype = null, [WorkflowExpression] Func<string> bodyinputsvalue = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KeepWritingPostResponse> __BuildKeepWriting(WorkflowExpression<bodyinputstypeInput> bodyinputstype = null, WorkflowExpression<string> bodyinputsvalue = null, WorkflowExpression<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, WorkflowExpression<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, WorkflowExpression<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            WorkflowExpression.Validate(bodyinputstype, nameof(bodyinputstype), required: false);
            WorkflowExpression.Validate(bodyinputsvalue, nameof(bodyinputsvalue), required: false);
            WorkflowExpression.Validate(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            return new DeferredBodyAction<KeepWritingPostResponse>(() =>
            {
                var apiCallPath = "/v1/keep-writing";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var inputsObject = new JObject();
                var inputsObjectpropCount = 0;
                if (bodyinputstype != null)
                {
                    if (bodyinputstype != null)
                    {
                        inputsObject["type"] = ExpressionConverter.ConvertO(bodyinputstype);
                        inputsObjectpropCount++;
                    }

                    inputsObjectpropCount++;
                }
                else
                {
                    inputsObject["type"] = "text";
                    inputsObjectpropCount++;
                }

                if (bodyinputsvalue != null)
                {
                    inputsObject["value"] = ExpressionConverter.ConvertO(bodyinputsvalue);
                    inputsObjectpropCount++;
                }

                if (inputsObjectpropCount > 0)
                {
                    body["inputs"] = inputsObject;
                    bodypropCount++;
                }

                var optionsObject = new JObject();
                var optionsObjectpropCount = 0;
                if (bodyoptionsinputLanguage != null)
                {
                    if (bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionsoutputLanguage != null)
                {
                    if (bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionslanguageFormality != null)
                {
                    if (bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(bodyoptionslanguageFormality);
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
            });
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
        [WorkflowExpressionFactory(nameof(__BuildTemplateGet))]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplateGetResponse> __BuildTemplateGet(WorkflowExpression<string> templateId)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<TemplateGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TemplateGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildTemplate))]
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<int> bodyoptionsoutputCount = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TemplatePostResponse> __BuildTemplate(WorkflowExpression<string> templateId, WorkflowExpression<int> bodyoptionsoutputCount = null, WorkflowExpression<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, WorkflowExpression<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, WorkflowExpression<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            WorkflowExpression.Validate(templateId, nameof(templateId), required: true);
            WorkflowExpression.Validate(bodyoptionsoutputCount, nameof(bodyoptionsoutputCount), required: false);
            WorkflowExpression.Validate(bodyoptionsinputLanguage, nameof(bodyoptionsinputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionsoutputLanguage, nameof(bodyoptionsoutputLanguage), required: false);
            WorkflowExpression.Validate(bodyoptionslanguageFormality, nameof(bodyoptionslanguageFormality), required: false);
            return new DeferredBodyAction<TemplatePostResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/templates/{0}/run", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
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
                if (bodyoptionsoutputCount != null)
                {
                    optionsObject["outputCount"] = ExpressionConverter.ConvertO(bodyoptionsoutputCount);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsinputLanguage != null)
                {
                    if (bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsinputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["inputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionsoutputLanguage != null)
                {
                    if (bodyoptionsoutputLanguage != null)
                    {
                        optionsObject["outputLanguage"] = ExpressionConverter.ConvertO(bodyoptionsoutputLanguage);
                        optionsObjectpropCount++;
                    }

                    optionsObjectpropCount++;
                }
                else
                {
                    optionsObject["outputLanguage"] = "English";
                    optionsObjectpropCount++;
                }

                if (bodyoptionslanguageFormality != null)
                {
                    if (bodyoptionslanguageFormality != null)
                    {
                        optionsObject["languageFormality"] = ExpressionConverter.ConvertO(bodyoptionslanguageFormality);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledgesGet))]
        public IBodyWorkflowAction<KnowledgesGetResponse> KnowledgesGet([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgesGetResponse> __BuildKnowledgesGet(WorkflowExpression<int> page = null, WorkflowExpression<int> size = null)
        {
            WorkflowExpression.Validate(page, nameof(page), required: false);
            WorkflowExpression.Validate(size, nameof(size), required: false);
            return new DeferredBodyAction<KnowledgesGetResponse>(() =>
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                if (size != null)
                    callPayload.Queries["size"] = ExpressionConverter.Convert(size);
                return new ApiConnectionAction<KnowledgesGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledge))]
        public IBodyWorkflowAction<KnowledgePostResponse> Knowledge([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyfile, [WorkflowExpression] Func<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgePostResponse> __BuildKnowledge(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyfile, WorkflowExpression<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: true);
            WorkflowExpression.Validate(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
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
                if (bodysettingsappVisibility != null)
                {
                    if (bodysettingsappVisibility != null)
                    {
                        settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["file"] = ExpressionConverter.ConvertO(bodyfile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KnowledgePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledgeGet))]
        public IBodyWorkflowAction<KnowledgeGetResponse> KnowledgeGet([WorkflowExpression] Func<string> knowledgeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgeGetResponse> __BuildKnowledgeGet(WorkflowExpression<string> knowledgeId)
        {
            WorkflowExpression.Validate(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledgeDelete))]
        public IBodyWorkflowAction<KnowledgeDeleteResponse> KnowledgeDelete([WorkflowExpression] Func<string> knowledgeId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgeDeleteResponse> __BuildKnowledgeDelete(WorkflowExpression<string> knowledgeId)
        {
            WorkflowExpression.Validate(knowledgeId, nameof(knowledgeId), required: true);
            return new DeferredBodyAction<KnowledgeDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<KnowledgeDeleteResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildKnowledgePatch))]
        public IBodyWorkflowAction<KnowledgePatchResponse> KnowledgePatch([WorkflowExpression] Func<string> knowledgeId, [WorkflowExpression] Func<string> bodysettingsappVisibility = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyfile = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<KnowledgePatchResponse> __BuildKnowledgePatch(WorkflowExpression<string> knowledgeId, WorkflowExpression<string> bodysettingsappVisibility = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyfile = null)
        {
            WorkflowExpression.Validate(knowledgeId, nameof(knowledgeId), required: true);
            WorkflowExpression.Validate(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyfile, nameof(bodyfile), required: false);
            return new DeferredBodyAction<KnowledgePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", ExpressionConverter.ConvertWithUrlEncoding(knowledgeId, 1));
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
                if (bodysettingsappVisibility != null)
                {
                    settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyfile != null)
                {
                    body["file"] = ExpressionConverter.ConvertO(bodyfile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<KnowledgePatchResponse>(callPayload);
            });
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
        [WorkflowExpressionFactory(nameof(__BuildTone))]
        public IBodyWorkflowAction<TonePostResponse> Tone([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TonePostResponse> __BuildTone(WorkflowExpression<string> bodyname, WorkflowExpression<string> bodyvalue, WorkflowExpression<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: true);
            WorkflowExpression.Validate(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
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
                if (bodysettingsappVisibility != null)
                {
                    if (bodysettingsappVisibility != null)
                    {
                        settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
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
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
                body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TonePostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildToneGet))]
        public IBodyWorkflowAction<ToneGetResponse> ToneGet([WorkflowExpression] Func<string> toneId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToneGetResponse> __BuildToneGet(WorkflowExpression<string> toneId)
        {
            WorkflowExpression.Validate(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildTonePatch))]
        public IBodyWorkflowAction<TonePatchResponse> TonePatch([WorkflowExpression] Func<string> toneId, [WorkflowExpression] Func<string> bodysettingsappVisibility = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TonePatchResponse> __BuildTonePatch(WorkflowExpression<string> toneId, WorkflowExpression<string> bodysettingsappVisibility = null, WorkflowExpression<string> bodyname = null, WorkflowExpression<string> bodyvalue = null)
        {
            WorkflowExpression.Validate(toneId, nameof(toneId), required: true);
            WorkflowExpression.Validate(bodysettingsappVisibility, nameof(bodysettingsappVisibility), required: false);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredBodyAction<TonePatchResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
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
                if (bodysettingsappVisibility != null)
                {
                    settingsObject["appVisibility"] = ExpressionConverter.ConvertO(bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<TonePatchResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [WorkflowExpressionFactory(nameof(__BuildToneDelete))]
        public IBodyWorkflowAction<ToneDeleteResponse> ToneDelete([WorkflowExpression] Func<string> toneId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ToneDeleteResponse> __BuildToneDelete(WorkflowExpression<string> toneId)
        {
            WorkflowExpression.Validate(toneId, nameof(toneId), required: true);
            return new DeferredBodyAction<ToneDeleteResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", ExpressionConverter.ConvertWithUrlEncoding(toneId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ToneDeleteResponse>(callPayload);
            });
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