//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jasperip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JasperipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<CommandPostResponse> Command([WorkflowExpression] Func<string> bodyinputscommand = null, [WorkflowExpression] Func<string> bodyinputscontext = null, [WorkflowExpression] Func<int> bodyoptionsoutputCount = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null, [WorkflowExpression] Func<bodyoptionscompletionTypeInput> bodyoptionscompletionType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                    inputsObject["command"] = SourceExpressionConverter.ConvertToken(bodyinputscommand);
                    inputsObjectpropCount++;
                }

                if (bodyinputscontext != null)
                {
                    inputsObject["context"] = SourceExpressionConverter.ConvertToken(bodyinputscontext);
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
                        optionsObject["outputCount"] = SourceExpressionConverter.ConvertToken(bodyoptionsoutputCount);
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
                        optionsObject["inputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsinputLanguage);
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
                        optionsObject["outputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsoutputLanguage);
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
                        optionsObject["languageFormality"] = SourceExpressionConverter.Convert(bodyoptionslanguageFormality);
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
                        optionsObject["completionType"] = SourceExpressionConverter.Convert(bodyoptionscompletionType);
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
                return callPayload;
            }

            return new ApiConnectionAction<CommandPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KeepWritingPostResponse> KeepWriting([WorkflowExpression] Func<bodyinputstypeInput> bodyinputstype = null, [WorkflowExpression] Func<string> bodyinputsvalue = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        inputsObject["type"] = SourceExpressionConverter.Convert(bodyinputstype);
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
                    inputsObject["value"] = SourceExpressionConverter.ConvertToken(bodyinputsvalue);
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
                        optionsObject["inputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsinputLanguage);
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
                        optionsObject["outputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsoutputLanguage);
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
                        optionsObject["languageFormality"] = SourceExpressionConverter.Convert(bodyoptionslanguageFormality);
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
                return callPayload;
            }

            return new ApiConnectionAction<KeepWritingPostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatesGetResponse> TemplatesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/templates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplatesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplateGetResponse> TemplateGet([WorkflowExpression] Func<string> templateId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TemplateGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TemplatePostResponse> Template([WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<int> bodyoptionsoutputCount = null, [WorkflowExpression] Func<bodyoptionsinputLanguageInput> bodyoptionsinputLanguage = null, [WorkflowExpression] Func<bodyoptionsoutputLanguageInput> bodyoptionsoutputLanguage = null, [WorkflowExpression] Func<bodyoptionslanguageFormalityInput> bodyoptionslanguageFormality = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/templates/{0}/run", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
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
                    optionsObject["outputCount"] = SourceExpressionConverter.ConvertToken(bodyoptionsoutputCount);
                    optionsObjectpropCount++;
                }

                if (bodyoptionsinputLanguage != null)
                {
                    if (bodyoptionsinputLanguage != null)
                    {
                        optionsObject["inputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsinputLanguage);
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
                        optionsObject["outputLanguage"] = SourceExpressionConverter.Convert(bodyoptionsoutputLanguage);
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
                        optionsObject["languageFormality"] = SourceExpressionConverter.Convert(bodyoptionslanguageFormality);
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
                return callPayload;
            }

            return new ApiConnectionAction<TemplatePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgesGetResponse> KnowledgesGet([WorkflowExpression] Func<int> page = null, [WorkflowExpression] Func<int> size = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/knowledge";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (page != null)
                    callPayload.Queries["page"] = SourceExpressionConverter.ConvertO(page);
                if (size != null)
                    callPayload.Queries["size"] = SourceExpressionConverter.ConvertO(size);
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgesGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePostResponse> Knowledge([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyFile, [WorkflowExpression] Func<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        settingsObject["appVisibility"] = SourceExpressionConverter.Convert(bodysettingsappVisibility);
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
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeGetResponse> KnowledgeGet([WorkflowExpression] Func<string> knowledgeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgeGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgeDeleteResponse> KnowledgeDelete([WorkflowExpression] Func<string> knowledgeId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgeDeleteResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<KnowledgePatchResponse> KnowledgePatch([WorkflowExpression] Func<string> knowledgeId, [WorkflowExpression] Func<string> bodysettingsappVisibility = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyFile = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/knowledge/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(knowledgeId, 1));
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
                    settingsObject["appVisibility"] = SourceExpressionConverter.ConvertToken(bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyFile != null)
                {
                    body["file"] = SourceExpressionConverter.ConvertToken(bodyFile);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<KnowledgePatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonesGetResponseItem[]> TonesGet()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/tones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TonesGetResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePostResponse> Tone([WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<string> bodyvalue, [WorkflowExpression] Func<bodysettingsappVisibilityInput> bodysettingsappVisibility = null)
        {
            ApiConnectionActionInput BuildSourceInput()
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
                        settingsObject["appVisibility"] = SourceExpressionConverter.Convert(bodysettingsappVisibility);
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
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                bodypropCount++;
                body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TonePostResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneGetResponse> ToneGet([WorkflowExpression] Func<string> toneId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(toneId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ToneGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<TonePatchResponse> TonePatch([WorkflowExpression] Func<string> toneId, [WorkflowExpression] Func<string> bodysettingsappVisibility = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(toneId, 1));
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
                    settingsObject["appVisibility"] = SourceExpressionConverter.ConvertToken(bodysettingsappVisibility);
                    settingsObjectpropCount++;
                }

                if (settingsObjectpropCount > 0)
                {
                    body["settings"] = settingsObject;
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TonePatchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jasperip")]
        public IBodyWorkflowAction<ToneDeleteResponse> ToneDelete([WorkflowExpression] Func<string> toneId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/tones/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(toneId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ToneDeleteResponse>(BuildSourceInput);
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

    public enum bodyoptionsinputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    public enum bodyoptionsoutputLanguageInput
    {
        English,
        French,
        Italian,
        Spanish,
        Portuguese,
        German
    }

    public enum bodyoptionslanguageFormalityInput
    {
        [EnumMember(Value = "default")]
        Default,
        [EnumMember(Value = "more")]
        More,
        [EnumMember(Value = "less")]
        Less
    }

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