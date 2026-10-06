//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzereu
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurvalyzereuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateAndInviteMembersResponse> CreateAndInviteMembers([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<bool> bodyasyncProcess = null, [WorkflowExpression] Func<string> bodyinterviewExpiryDate = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/CreateAndInviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = SourceExpressionConverter.ConvertToken(bodysamplingProjectId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                if (bodychannel != null)
                {
                    body["channel"] = SourceExpressionConverter.Convert(bodychannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = SourceExpressionConverter.ConvertToken(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = SourceExpressionConverter.ConvertToken(bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = SourceExpressionConverter.ConvertToken(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyasyncProcess != null)
                {
                    body["asyncProcess"] = SourceExpressionConverter.ConvertToken(bodyasyncProcess);
                    bodypropCount++;
                }

                if (bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = SourceExpressionConverter.ConvertToken(bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = SourceExpressionConverter.ConvertToken(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateAndInviteMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateArtifactResponse> CreateArtifact([WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodypath = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/CreateArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateArtifactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateMembersResponse> CreateMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<string> bodytenant = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/CreateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                bodypropCount++;
                body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreatePanelResponse> CreatePanel([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodypanelTypeInput> bodypanelType = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/CreatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                if (bodypanelType != null)
                {
                    body["panelType"] = SourceExpressionConverter.Convert(bodypanelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreatePanelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateSurveyResponse> CreateSurvey([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowMultipleParticipation, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowNavigateBack, [WorkflowExpression] Func<bool> bodysurveyDefinitionrandomizeSections, [WorkflowExpression] Func<string> bodysurveyDefinitiondefaultLanguage, [WorkflowExpression] Func<string[]> bodysurveyDefinitionlanguages, [WorkflowExpression] Func<Section[]> bodysurveyDefinitionsections, [WorkflowExpression] Func<CustomVariable[]> bodysurveyDefinitioncustomVariables, [WorkflowExpression] Func<TranslationElement[]> bodysurveyDefinitionsurveyEndText, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowSaveProgress = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableAutoScroll = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableCodeAccess = null, [WorkflowExpression] Func<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, [WorkflowExpression] Func<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, [WorkflowExpression] Func<int[]> bodysurveyDefinitionassociatedPanels = null, [WorkflowExpression] Func<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenablePanelSync = null, [WorkflowExpression] Func<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, [WorkflowExpression] Func<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, [WorkflowExpression] Func<string> bodysurveyDefinitionendDate = null, [WorkflowExpression] Func<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, [WorkflowExpression] Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, [WorkflowExpression] Func<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, [WorkflowExpression] Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/CreateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                bodypropCount++;
                body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowNavigateBack);
                if (bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionrandomizeSections);
                if (bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = SourceExpressionConverter.Convert(bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = SourceExpressionConverter.Convert(bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = SourceExpressionConverter.Convert(bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitiondefaultLanguage);
                if (bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionsurveyEndText);
                var defaultTextOverridesObject = new JObject();
                var defaultTextOverridesObjectpropCount = 0;
                if (defaultTextOverridesObjectpropCount > 0)
                {
                    surveyDefinitionObject["defaultTextOverrides"] = defaultTextOverridesObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (surveyDefinitionObjectpropCount > 0)
                {
                    body["surveyDefinition"] = surveyDefinitionObject;
                    bodypropCount++;
                }

                var surveyConfigurationObject = new JObject();
                var surveyConfigurationObjectpropCount = 0;
                var designConfigurationObject = new JObject();
                var designConfigurationObjectpropCount = 0;
                if (bodysurveyConfigurationdesignConfigurationsurveyDesignLayout != null)
                {
                    designConfigurationObject["surveyDesignLayout"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = SourceExpressionConverter.Convert(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationdesignConfigurationtextBlocks);
                    designConfigurationObjectpropCount++;
                }

                if (designConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["designConfiguration"] = designConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                var anonymizingConfigurationObject = new JObject();
                var anonymizingConfigurationObjectpropCount = 0;
                if (bodysurveyConfigurationanonymizingConfigurationanonymizingMode != null)
                {
                    anonymizingConfigurationObject["anonymizingMode"] = SourceExpressionConverter.Convert(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogReferer);
                if (anonymizingConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["anonymizingConfiguration"] = anonymizingConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                if (surveyConfigurationObjectpropCount > 0)
                {
                    body["surveyConfiguration"] = surveyConfigurationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateSurveyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateWebHookResponse> CreateWebHook([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null, [WorkflowExpression] Func<string> bodysecurityToken = null, [WorkflowExpression] Func<string> bodywebHookUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/WebHook/v3/CreateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = SourceExpressionConverter.Convert(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = SourceExpressionConverter.ConvertToken(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodysecurityToken != null)
                {
                    body["securityToken"] = SourceExpressionConverter.ConvertToken(bodysecurityToken);
                    bodypropCount++;
                }

                if (bodywebHookUrl != null)
                {
                    body["webHookUrl"] = SourceExpressionConverter.ConvertToken(bodywebHookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateWebHookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteArtifactResponse> DeleteArtifact([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodyfilename = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/DeleteArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodyfilename != null)
                {
                    body["filename"] = SourceExpressionConverter.ConvertToken(bodyfilename);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteArtifactResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteDistributorResponse> DeleteDistributor([WorkflowExpression] Func<int> bodydistributorId, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteDistributor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = SourceExpressionConverter.ConvertToken(bodydistributorId);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = SourceExpressionConverter.ConvertToken(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteDistributorResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteInterviewResponse> DeleteInterview([WorkflowExpression] Func<string> bodyinterviewId = null, [WorkflowExpression] Func<int> bodysurveyId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Interview/v3/DeleteInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinterviewId != null)
                {
                    body["interviewId"] = SourceExpressionConverter.ConvertToken(bodyinterviewId);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteInterviewResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteMembersResponse> DeleteMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int[]> bodypanelMembersIds, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/DeleteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                bodypropCount++;
                body["panelMembersIds"] = SourceExpressionConverter.ConvertToken(bodypanelMembersIds);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = SourceExpressionConverter.ConvertToken(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeletePanelResponse> DeletePanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/DeletePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = SourceExpressionConverter.ConvertToken(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeletePanelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteSamplingProjectResponse> DeleteSamplingProject([WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = SourceExpressionConverter.ConvertToken(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = SourceExpressionConverter.ConvertToken(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteSamplingProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteSurveyResponse> DeleteSurvey([WorkflowExpression] Func<int> bodysurveyId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/DeleteSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteSurveyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteWebHookResponse> DeleteWebHook([WorkflowExpression] Func<string> bodywebHookId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/WebHook/v3/DeleteWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodywebHookId != null)
                {
                    body["webHookId"] = SourceExpressionConverter.ConvertToken(bodywebHookId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DeleteWebHookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DownloadAnswersResponse> DownloadInterviewPdf([WorkflowExpression] Func<string> tenant, [WorkflowExpression] Func<int> surveyId, [WorkflowExpression] Func<string> interviewId, [WorkflowExpression] Func<bool> showPartialCompleted = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string> timeZone = null, [WorkflowExpression] Func<bool> bodyisCancellationRequested = null, [WorkflowExpression] Func<bool> bodycanBeCanceled = null, [WorkflowExpression] Func<bool> bodywaitHandlesafeWaitHandleisInvalid = null, [WorkflowExpression] Func<bool> bodywaitHandlesafeWaitHandleisClosed = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Interview/v3/DownloadAnswers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenant"] = SourceExpressionConverter.ConvertO(tenant);
                callPayload.Queries["surveyId"] = SourceExpressionConverter.ConvertO(surveyId);
                callPayload.Queries["interviewId"] = SourceExpressionConverter.ConvertO(interviewId);
                if (showPartialCompleted != null)
                    callPayload.Queries["showPartialCompleted"] = SourceExpressionConverter.ConvertO(showPartialCompleted);
                if (locale != null)
                    callPayload.Queries["locale"] = SourceExpressionConverter.ConvertO(locale);
                if (timeZone != null)
                    callPayload.Queries["timeZone"] = SourceExpressionConverter.ConvertO(timeZone);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisCancellationRequested != null)
                {
                    body["isCancellationRequested"] = SourceExpressionConverter.ConvertToken(bodyisCancellationRequested);
                    bodypropCount++;
                }

                if (bodycanBeCanceled != null)
                {
                    body["canBeCanceled"] = SourceExpressionConverter.ConvertToken(bodycanBeCanceled);
                    bodypropCount++;
                }

                var waitHandleObject = new JObject();
                var waitHandleObjectpropCount = 0;
                var safeWaitHandleObject = new JObject();
                var safeWaitHandleObjectpropCount = 0;
                if (bodywaitHandlesafeWaitHandleisInvalid != null)
                {
                    safeWaitHandleObject["isInvalid"] = SourceExpressionConverter.ConvertToken(bodywaitHandlesafeWaitHandleisInvalid);
                    safeWaitHandleObjectpropCount++;
                }

                if (bodywaitHandlesafeWaitHandleisClosed != null)
                {
                    safeWaitHandleObject["isClosed"] = SourceExpressionConverter.ConvertToken(bodywaitHandlesafeWaitHandleisClosed);
                    safeWaitHandleObjectpropCount++;
                }

                if (safeWaitHandleObjectpropCount > 0)
                {
                    waitHandleObject["safeWaitHandle"] = safeWaitHandleObject;
                    waitHandleObjectpropCount++;
                }

                if (waitHandleObjectpropCount > 0)
                {
                    body["waitHandle"] = waitHandleObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DownloadAnswersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ExecuteSendMailResponse> ExecuteSendMail([WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<int> bodymessageTemplateId = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodytoName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteSendMail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessageTemplateId != null)
                {
                    body["messageTemplateId"] = SourceExpressionConverter.ConvertToken(bodymessageTemplateId);
                    bodypropCount++;
                }

                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = SourceExpressionConverter.ConvertToken(bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                if (bodysubject != null)
                {
                    body["subject"] = SourceExpressionConverter.ConvertToken(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                if (bodyfromName != null)
                {
                    body["fromName"] = SourceExpressionConverter.ConvertToken(bodyfromName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = SourceExpressionConverter.ConvertToken(bodyto);
                if (bodytoName != null)
                {
                    body["toName"] = SourceExpressionConverter.ConvertToken(bodytoName);
                    bodypropCount++;
                }

                if (bodyreplyTo != null)
                {
                    body["replyTo"] = SourceExpressionConverter.ConvertToken(bodyreplyTo);
                    bodypropCount++;
                }

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = SourceExpressionConverter.ConvertToken(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExecuteSendMailResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ExecuteWorkflowTransitionResponse> ExecuteWorkflowTransition([WorkflowExpression] Func<string> bodytargetState, [WorkflowExpression] Func<bodyworkflowInput> bodyworkflow = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<int> bodydistributorId = null, [WorkflowExpression] Func<int> bodyreminderId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteWorkflowTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkflow != null)
                {
                    body["workflow"] = SourceExpressionConverter.Convert(bodyworkflow);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = SourceExpressionConverter.ConvertToken(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodydistributorId != null)
                {
                    body["distributorId"] = SourceExpressionConverter.ConvertToken(bodydistributorId);
                    bodypropCount++;
                }

                if (bodyreminderId != null)
                {
                    body["reminderId"] = SourceExpressionConverter.ConvertToken(bodyreminderId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["targetState"] = SourceExpressionConverter.ConvertToken(bodytargetState);
                var dynamicParametersObject = new JObject();
                var dynamicParametersObjectpropCount = 0;
                if (dynamicParametersObjectpropCount > 0)
                {
                    body["dynamicParameters"] = dynamicParametersObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExecuteWorkflowTransitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<InviteMembersResponse> InviteMembers([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<int[]> bodymemberIds = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<bool> bodyasyncProcess = null, [WorkflowExpression] Func<string> bodyinterviewExpiryDate = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/InviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = SourceExpressionConverter.ConvertToken(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodymemberIds != null)
                {
                    body["memberIds"] = SourceExpressionConverter.ConvertToken(bodymemberIds);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = SourceExpressionConverter.ConvertToken(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = SourceExpressionConverter.ConvertToken(bodytextBlocks);
                    bodypropCount++;
                }

                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = SourceExpressionConverter.ConvertToken(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = SourceExpressionConverter.Convert(bodychannel);
                    bodypropCount++;
                }

                if (bodyasyncProcess != null)
                {
                    body["asyncProcess"] = SourceExpressionConverter.ConvertToken(bodyasyncProcess);
                    bodypropCount++;
                }

                if (bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = SourceExpressionConverter.ConvertToken(bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = SourceExpressionConverter.ConvertToken(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InviteMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadArtifactListRequest> ReadArtifactList([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/ReadArtifactList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = SourceExpressionConverter.ConvertToken(bodypath);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadArtifactListRequest>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadBounceListResponseV3> ReadBounceList([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int[]> bodydistributors = null, [WorkflowExpression] Func<bodyinvitationTypeInput> bodyinvitationType = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadBounceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                if (bodypanelId != null)
                {
                    body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                    bodypropCount++;
                }

                if (bodydistributors != null)
                {
                    body["distributors"] = SourceExpressionConverter.ConvertToken(bodydistributors);
                    bodypropCount++;
                }

                if (bodyinvitationType != null)
                {
                    body["invitationType"] = SourceExpressionConverter.Convert(bodyinvitationType);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadBounceListResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadCreditBalanceResponse> ReadCreditBalance()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadCreditBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadCreditBalanceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadDistributorListResponse> ReadDistributorList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadDistributorList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypanelId != null)
                {
                    body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadDistributorListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadIncentiveListResponse> ReadIncentiveList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadIncentiveListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadIncentiveTransactionListResponse> ReadIncentiveTransactionList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveTransactionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadIncentiveTransactionListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewDataResponse> ReadInterview([WorkflowExpression] Func<string> bodytenant, [WorkflowExpression] Func<string> bodyinterviewId, [WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<bool> bodyloadSurveyDefinition = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                bodypropCount++;
                body["interviewId"] = SourceExpressionConverter.ConvertToken(bodyinterviewId);
                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                if (bodyloadSurveyDefinition != null)
                {
                    body["loadSurveyDefinition"] = SourceExpressionConverter.ConvertToken(bodyloadSurveyDefinition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadInterviewDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewListCompactResponseV3> ReadInterviewListCompact([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<bool> bodyloadCodePlan = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewListCompact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = SourceExpressionConverter.ConvertToken(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = SourceExpressionConverter.ConvertToken(bodyloadCodePlan);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadInterviewListCompactResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewListResponseV3> ReadInterviewList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<bool> bodyloadCodePlan = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = SourceExpressionConverter.ConvertToken(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = SourceExpressionConverter.ConvertToken(bodyloadCodePlan);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadInterviewListResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadMemberListResponse> ReadMemberList([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<bool> bodyinterviewsRequired, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadMemberList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                bodypropCount++;
                body["interviewsRequired"] = SourceExpressionConverter.ConvertToken(bodyinterviewsRequired);
                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = SourceExpressionConverter.ConvertToken(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadMemberListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadMessageTemplateListResponse> ReadMessageTemplateList([WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadMessageTemplateList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = SourceExpressionConverter.ConvertToken(bodylanguage);
                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadMessageTemplateListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadOptOutListResponseV3> ReadOptOutList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypanelId != null)
                {
                    body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadOptOutListResponseV3>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadPanelDefinitionResponse> ReadPanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<string> bodytenant = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadPanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadPanelDefinitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSamplingProjectResponse> ReadSamplingProject([WorkflowExpression] Func<int> bodysamplingProjectId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = SourceExpressionConverter.ConvertToken(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadSamplingProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyLinksResponse> ReadSurveyLinks([WorkflowExpression] Func<int> bodysurveyId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyLinks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadSurveyLinksResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyListResponse> ReadSurveyList([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadSurveyListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyResponse> ReadSurvey([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<string> bodytenant = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadSurveyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWebHookListResponse> ReadWebHookList([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/WebHook/v3/ReadWebHookList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = SourceExpressionConverter.Convert(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = SourceExpressionConverter.ConvertToken(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadWebHookListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWorkflowTransitionsResponse> ReadWorkflowTransitions([WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bodyworkflowInput> bodyworkflow = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Common/v3/ReadWorkflowTransitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkflow != null)
                {
                    body["workflow"] = SourceExpressionConverter.Convert(bodyworkflow);
                    bodypropCount++;
                }

                bodypropCount++;
                body["currentState"] = SourceExpressionConverter.ConvertToken(bodycurrentState);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadWorkflowTransitionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWorkspaceListResponse> ReadWorkspaceList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadWorkspaceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = SourceExpressionConverter.ConvertToken(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = SourceExpressionConverter.ConvertToken(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = SourceExpressionConverter.ConvertToken(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = SourceExpressionConverter.Convert(bodypagingorderDirection);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    body["paging"] = pagingObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ReadWorkspaceListResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<RedeemIncentiveCodeResponse> RedeemIncentiveCode([WorkflowExpression] Func<int> bodyincentiveId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Incentive/v3/RedeemIncentiveCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["incentiveId"] = SourceExpressionConverter.ConvertToken(bodyincentiveId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RedeemIncentiveCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<RemindMembersResponse> RemindMembers([WorkflowExpression] Func<int> bodydistributorId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/RemindMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = SourceExpressionConverter.ConvertToken(bodydistributorId);
                bodypropCount++;
                body["messageTemplateId"] = SourceExpressionConverter.ConvertToken(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = SourceExpressionConverter.ConvertToken(bodytextBlocks);
                    bodypropCount++;
                }

                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = SourceExpressionConverter.ConvertToken(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = SourceExpressionConverter.Convert(bodychannel);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = SourceExpressionConverter.ConvertToken(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = SourceExpressionConverter.ConvertToken(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RemindMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ResetInterviewResponse> ResetInterview([WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string> bodyinterviewId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/ResetInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyinterviewId != null)
                {
                    body["interviewId"] = SourceExpressionConverter.ConvertToken(bodyinterviewId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ResetInterviewResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateMembersResponse> UpdateMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<string> bodytenant = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                bodypropCount++;
                body["members"] = SourceExpressionConverter.ConvertToken(bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateMembersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<WritePanelResponse> UpdatePanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<PanelMemberField[]> bodyaddedFields = null, [WorkflowExpression] Func<int[]> bodyremovedFields = null, [WorkflowExpression] Func<PanelMemberField[]> bodyrenamedFields = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = SourceExpressionConverter.ConvertToken(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                if (bodyaddedFields != null)
                {
                    body["addedFields"] = SourceExpressionConverter.ConvertToken(bodyaddedFields);
                    bodypropCount++;
                }

                if (bodyremovedFields != null)
                {
                    body["removedFields"] = SourceExpressionConverter.ConvertToken(bodyremovedFields);
                    bodypropCount++;
                }

                if (bodyrenamedFields != null)
                {
                    body["renamedFields"] = SourceExpressionConverter.ConvertToken(bodyrenamedFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WritePanelResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateSurveyResponse> UpdateSurvey([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowMultipleParticipation, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowNavigateBack, [WorkflowExpression] Func<bool> bodysurveyDefinitionrandomizeSections, [WorkflowExpression] Func<string> bodysurveyDefinitiondefaultLanguage, [WorkflowExpression] Func<string[]> bodysurveyDefinitionlanguages, [WorkflowExpression] Func<Section[]> bodysurveyDefinitionsections, [WorkflowExpression] Func<CustomVariable[]> bodysurveyDefinitioncustomVariables, [WorkflowExpression] Func<TranslationElement[]> bodysurveyDefinitionsurveyEndText, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, [WorkflowExpression] Func<string> bodysurveyName = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowSaveProgress = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableAutoScroll = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableCodeAccess = null, [WorkflowExpression] Func<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, [WorkflowExpression] Func<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, [WorkflowExpression] Func<int[]> bodysurveyDefinitionassociatedPanels = null, [WorkflowExpression] Func<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenablePanelSync = null, [WorkflowExpression] Func<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, [WorkflowExpression] Func<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, [WorkflowExpression] Func<string> bodysurveyDefinitionendDate = null, [WorkflowExpression] Func<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, [WorkflowExpression] Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, [WorkflowExpression] Func<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, [WorkflowExpression] Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Survey/v3/UpdateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = SourceExpressionConverter.ConvertToken(bodysurveyId);
                if (bodysurveyName != null)
                {
                    body["surveyName"] = SourceExpressionConverter.ConvertToken(bodysurveyName);
                    bodypropCount++;
                }

                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowNavigateBack);
                if (bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionrandomizeSections);
                if (bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = SourceExpressionConverter.Convert(bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = SourceExpressionConverter.Convert(bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = SourceExpressionConverter.Convert(bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitiondefaultLanguage);
                if (bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = SourceExpressionConverter.ConvertToken(bodysurveyDefinitionsurveyEndText);
                var defaultTextOverridesObject = new JObject();
                var defaultTextOverridesObjectpropCount = 0;
                if (defaultTextOverridesObjectpropCount > 0)
                {
                    surveyDefinitionObject["defaultTextOverrides"] = defaultTextOverridesObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (surveyDefinitionObjectpropCount > 0)
                {
                    body["surveyDefinition"] = surveyDefinitionObject;
                    bodypropCount++;
                }

                var surveyConfigurationObject = new JObject();
                var surveyConfigurationObjectpropCount = 0;
                var designConfigurationObject = new JObject();
                var designConfigurationObjectpropCount = 0;
                if (bodysurveyConfigurationdesignConfigurationsurveyDesignLayout != null)
                {
                    designConfigurationObject["surveyDesignLayout"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = SourceExpressionConverter.Convert(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationdesignConfigurationtextBlocks);
                    designConfigurationObjectpropCount++;
                }

                if (designConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["designConfiguration"] = designConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                var anonymizingConfigurationObject = new JObject();
                var anonymizingConfigurationObjectpropCount = 0;
                if (bodysurveyConfigurationanonymizingConfigurationanonymizingMode != null)
                {
                    anonymizingConfigurationObject["anonymizingMode"] = SourceExpressionConverter.Convert(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = SourceExpressionConverter.ConvertToken(bodysurveyConfigurationanonymizingConfigurationlogReferer);
                if (anonymizingConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["anonymizingConfiguration"] = anonymizingConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                if (surveyConfigurationObjectpropCount > 0)
                {
                    body["surveyConfiguration"] = surveyConfigurationObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateSurveyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateWebHookResponse> UpdateWebHook([WorkflowExpression] Func<string> bodywebHookId = null, [WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null, [WorkflowExpression] Func<string> bodysecurityToken = null, [WorkflowExpression] Func<string> bodywebHookUrl = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/WebHook/v3/UpdateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodywebHookId != null)
                {
                    body["webHookId"] = SourceExpressionConverter.ConvertToken(bodywebHookId);
                    bodypropCount++;
                }

                if (bodyeventType != null)
                {
                    body["eventType"] = SourceExpressionConverter.Convert(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = SourceExpressionConverter.ConvertToken(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodysecurityToken != null)
                {
                    body["securityToken"] = SourceExpressionConverter.ConvertToken(bodysecurityToken);
                    bodypropCount++;
                }

                if (bodywebHookUrl != null)
                {
                    body["webHookUrl"] = SourceExpressionConverter.ConvertToken(bodywebHookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateWebHookResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<WriteOptOutListResponse> WriteOptOutList([WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int> bodydistributorId = null, [WorkflowExpression] Func<EmailItem[]> bodyemails = null, [WorkflowExpression] Func<CellPhoneItem[]> bodycellPhones = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/publicapi/Distribute/v3/WriteOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = SourceExpressionConverter.ConvertToken(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypanelId != null)
                {
                    body["panelId"] = SourceExpressionConverter.ConvertToken(bodypanelId);
                    bodypropCount++;
                }

                if (bodydistributorId != null)
                {
                    body["distributorId"] = SourceExpressionConverter.ConvertToken(bodydistributorId);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = SourceExpressionConverter.ConvertToken(bodyemails);
                    bodypropCount++;
                }

                if (bodycellPhones != null)
                {
                    body["cellPhones"] = SourceExpressionConverter.ConvertToken(bodycellPhones);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WriteOptOutListResponse>(BuildSourceInput);
        }
    }

    public class SurvalyzereuTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateAndInviteMembersResponse
    {
        [JsonProperty("samplingProjectId")]
        public int SamplingProjectId { get; set; }

        [JsonProperty("distributorId")]
        public int DistributorId { get; set; }

        [JsonProperty("validationIssues")]
        public WritePanelMemberIssue[] ValidationIssues { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WritePanelMemberIssue
    {
        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }
    }

    public class Member
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("interviews")]
        public Interview[] Interviews { get; set; }
    }

    public class Interview
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("surveyId")]
        public int SurveyId { get; set; }

        [JsonProperty("surveyVersionId")]
        public int SurveyVersionId { get; set; }

        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("surveyState")]
        public string SurveyState { get; set; }

        [JsonProperty("answersLink")]
        public string AnswersLink { get; set; }

        [JsonProperty("interviewLink")]
        public string InterviewLink { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("samplingProjectId")]
        public int SamplingProjectId { get; set; }

        [JsonProperty("distributorId")]
        public int DistributorId { get; set; }
    }

    public enum bodychannelInput
    {
        Invalid,
        Email,
        Sms,
        LinkList,
        ApiEndpoint,
        WhatsApp
    }

    public class TextBlock
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public TranslationElement[] Text { get; set; }
    }

    public class TranslationElement
    {
        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateArtifactResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class CreateMembersResponse
    {
        [JsonProperty("membersIds")]
        public int[] MembersIds { get; set; }

        [JsonProperty("validationIssues")]
        public WritePanelMemberIssue[] ValidationIssues { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class CreatePanelResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("isExtendedPanel")]
        public bool IsExtendedPanel { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("isLock")]
        public bool IsLock { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public enum bodypanelTypeInput
    {
        Basic,
        Extended,
        Meta
    }

    public class CreateSurveyResponse
    {
        [JsonProperty("surveyId")]
        public int SurveyId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class Section
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("randomizePages")]
        public bool RandomizePages { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("elements")]
        public SurveyElement[] Elements { get; set; }

        [JsonProperty("condition")]
        public ConditionDefinition Condition { get; set; }
    }

    public class SurveyElement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("elementType")]
        public ElementType ElementType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("text")]
        public TranslationElement[] Text { get; set; }

        [JsonProperty("hintText")]
        public TranslationElement[] HintText { get; set; }

        [JsonProperty("hasHintText")]
        public bool HasHintText { get; set; }

        [JsonProperty("hasNotAvailableChoice")]
        public bool HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public TranslationElement[] NotAvailableChoiceText { get; set; }

        [JsonProperty("forceResponse")]
        public bool ForceResponse { get; set; }

        [JsonProperty("choices")]
        public Choice[] Choices { get; set; }

        [JsonProperty("randomizeChoices")]
        public bool RandomizeChoices { get; set; }

        [JsonProperty("columnType")]
        public ColumnType ColumnType { get; set; }

        [JsonProperty("prompt")]
        public TranslationElement[] Prompt { get; set; }

        [JsonProperty("minValue")]
        public int MinValue { get; set; }

        [JsonProperty("maxValue")]
        public int MaxValue { get; set; }

        [JsonProperty("showCenterLabel")]
        public bool ShowCenterLabel { get; set; }

        [JsonProperty("leftLabel")]
        public TranslationElement[] LeftLabel { get; set; }

        [JsonProperty("centerLabel")]
        public TranslationElement[] CenterLabel { get; set; }

        [JsonProperty("rightLabel")]
        public TranslationElement[] RightLabel { get; set; }

        [JsonProperty("showValue")]
        public bool ShowValue { get; set; }

        [JsonProperty("maxDecimals")]
        public int MaxDecimals { get; set; }

        [JsonProperty("textFieldSize")]
        public TextFieldSize TextFieldSize { get; set; }

        [JsonProperty("autocomplete")]
        public bool Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public TranslationElement[] AutocompleteText { get; set; }

        [JsonProperty("contentValidation")]
        public ContentValidation ContentValidation { get; set; }

        [JsonProperty("hasPlaceholder")]
        public bool HasPlaceholder { get; set; }

        [JsonProperty("placeholder")]
        public TranslationElement[] Placeholder { get; set; }

        [JsonProperty("isPassword")]
        public bool IsPassword { get; set; }

        [JsonProperty("minMaxValidation")]
        public bool MinMaxValidation { get; set; }

        [JsonProperty("minimumCheckedChoices")]
        public int MinimumCheckedChoices { get; set; }

        [JsonProperty("maximumCheckedChoices")]
        public int MaximumCheckedChoices { get; set; }

        [JsonProperty("columnGroups")]
        public ColumnGroup[] ColumnGroups { get; set; }

        [JsonProperty("randomizeRows")]
        public bool RandomizeRows { get; set; }

        [JsonProperty("rows")]
        public MinMaxChoice[] Rows { get; set; }

        [JsonProperty("numberOfRanks")]
        public int NumberOfRanks { get; set; }

        [JsonProperty("likeText")]
        public TranslationElement[] LikeText { get; set; }

        [JsonProperty("dislikeText")]
        public TranslationElement[] DislikeText { get; set; }

        [JsonProperty("hasStartText")]
        public bool HasStartText { get; set; }

        [JsonProperty("startText")]
        public TranslationElement[] StartText { get; set; }

        [JsonProperty("enableMeasurement")]
        public bool EnableMeasurement { get; set; }

        [JsonProperty("showButtons")]
        public bool ShowButtons { get; set; }

        [JsonProperty("likeKey")]
        public string LikeKey { get; set; }

        [JsonProperty("dislikeKey")]
        public string DislikeKey { get; set; }

        [JsonProperty("interviewState")]
        public string InterviewState { get; set; }

        [JsonProperty("action")]
        public ActionElement Action { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("subject")]
        public TranslationElement[] Subject { get; set; }

        [JsonProperty("message")]
        public TranslationElement[] Message { get; set; }

        [JsonProperty("valueAssignmentType")]
        public ValueAssignmentType ValueAssignmentType { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("functionTerm")]
        public TranslationElement[] FunctionTerm { get; set; }

        [JsonProperty("executionBehavior")]
        public ExecutionBehavior ExecutionBehavior { get; set; }

        [JsonProperty("apiCallMethod")]
        public ApiCallMethod ApiCallMethod { get; set; }

        [JsonProperty("url")]
        public TranslationElement[] Url { get; set; }

        [JsonProperty("headers")]
        public string Headers { get; set; }

        [JsonProperty("body")]
        public TranslationElement[] Body { get; set; }

        [JsonProperty("externalUri")]
        public string ExternalUri { get; set; }

        [JsonProperty("scriptType")]
        public ScriptType ScriptType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("hasRatingLabels")]
        public bool HasRatingLabels { get; set; }

        [JsonProperty("leftRatingLabel")]
        public TranslationElement[] LeftRatingLabel { get; set; }

        [JsonProperty("rightRatingLabel")]
        public TranslationElement[] RightRatingLabel { get; set; }

        [JsonProperty("condition")]
        public ConditionDefinition Condition { get; set; }

        [JsonProperty("evaluateAsJson")]
        public bool EvaluateAsJson { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }

        [JsonProperty("arrangementMode")]
        public ArrangementMode ArrangementMode { get; set; }

        [JsonProperty("enableAnimation")]
        public bool EnableAnimation { get; set; }

        [JsonProperty("useSmiley")]
        public bool UseSmiley { get; set; }

        [JsonProperty("hasPrompt")]
        public bool HasPrompt { get; set; }
    }

    public enum ElementType
    {
        Invalid,
        SingleChoice,
        MultipleChoice,
        Dropdown,
        Slider,
        OpenQuestion,
        Date,
        Email,
        TextBlock,
        PageBreak,
        Matrix,
        SemanticDifferential,
        RankOrder,
        ImplicitAssociation,
        Validation,
        UrlForwarding,
        SendEmail,
        ValueAssignment,
        ApiCall,
        Script,
        QuotaCheck,
        StarScale,
        Nps
    }

    public class Choice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("text")]
        public TranslationElement[] Text { get; set; }

        [JsonProperty("allowTextEntry")]
        public bool AllowTextEntry { get; set; }

        [JsonProperty("forceInput")]
        public bool ForceInput { get; set; }

        [JsonProperty("autocomplete")]
        public bool Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public TranslationElement[] AutocompleteText { get; set; }

        [JsonProperty("exclusive")]
        public bool Exclusive { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("contentValidation")]
        public ContentValidation ContentValidation { get; set; }

        [JsonProperty("condition")]
        public ConditionDefinition Condition { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }
    }

    public class ContentValidation
    {
        [JsonProperty("validationType")]
        public ContentValidationType ValidationType { get; set; }

        [JsonProperty("earliestDate")]
        public string EarliestDate { get; set; }

        [JsonProperty("latestDate")]
        public string LatestDate { get; set; }

        [JsonProperty("minValue")]
        public double MinValue { get; set; }

        [JsonProperty("maxValue")]
        public double MaxValue { get; set; }

        [JsonProperty("decimalPlaces")]
        public int DecimalPlaces { get; set; }

        [JsonProperty("disableThousandSeparator")]
        public bool DisableThousandSeparator { get; set; }
    }

    public enum ContentValidationType
    {
        Invalid,
        None,
        Number,
        Email,
        Date,
        List,
        Real
    }

    public class ConditionDefinition
    {
        [JsonProperty("conditionAction")]
        public ConditionAction ConditionAction { get; set; }

        [JsonProperty("elements")]
        public Condition[] Elements { get; set; }
    }

    public enum ConditionAction
    {
        Invalid,
        Passes,
        Fails
    }

    public class Condition
    {
        [JsonProperty("conjunction")]
        public Conjunction Conjunction { get; set; }

        [JsonProperty("conditionType")]
        public ConditionType ConditionType { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("conditionOperator")]
        public ConditionOperator ConditionOperator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("variableType")]
        public VariableType VariableType { get; set; }

        [JsonProperty("jsonValue")]
        public bool JsonValue { get; set; }

        [JsonProperty("jsonPath")]
        public string JsonPath { get; set; }
    }

    public enum Conjunction
    {
        Invalid,
        And,
        Or
    }

    public enum ConditionType
    {
        Invalid,
        Question,
        Panel,
        Device,
        UrlVariable,
        Calculation,
        Language,
        CustomVariable,
        Counters,
        RemoteList,
        RemoteIntegerRange,
        RemoteString,
        RemoteInteger,
        SQL
    }

    public enum ConditionOperator
    {
        Invalid,
        IsLessThan,
        IsLessThanOrEqualTo,
        IsGreaterThan,
        IsGreaterThanOrEqualTo,
        IsEqualTo,
        IsNotEqualTo,
        IsEmpty,
        IsNotEmpty,
        Contains,
        DoesNotContain,
        MatchRegex,
        DoesNotMatchRegex,
        AnyIsEqual,
        AnyIsNotEqual,
        AnyIsEmpty,
        AnyIsNotEmpty,
        AnyMatchRegex,
        AnyDoesNotMatchRegex
    }

    public enum VariableType
    {
        Invalid,
        Number,
        Real,
        String,
        Date,
        JsonList,
        Json,
        MathJs,
        Matrix
    }

    public enum ColumnType
    {
        Invalid,
        Single,
        Multiple
    }

    public enum TextFieldSize
    {
        Invalid,
        Small,
        Medium,
        Large
    }

    public class ColumnGroup
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public TranslationElement[] Text { get; set; }

        [JsonProperty("hasNotAvailableChoice")]
        public bool HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public TranslationElement[] NotAvailableChoiceText { get; set; }

        [JsonProperty("randomizeColumns")]
        public bool RandomizeColumns { get; set; }

        [JsonProperty("prompt")]
        public TranslationElement[] Prompt { get; set; }

        [JsonProperty("choiceType")]
        public ChoiceType ChoiceType { get; set; }

        [JsonProperty("choices")]
        public Choice[] Choices { get; set; }

        [JsonProperty("condition")]
        public ConditionDefinition Condition { get; set; }
    }

    public enum ChoiceType
    {
        Invalid,
        Single,
        Multiple,
        Dropdown,
        Text,
        StarScale
    }

    public class MinMaxChoice
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("leftText")]
        public TranslationElement[] LeftText { get; set; }

        [JsonProperty("rightText")]
        public TranslationElement[] RightText { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("condition")]
        public ConditionDefinition Condition { get; set; }
    }

    public class ActionElement
    {
        [JsonProperty("actionType")]
        public ActionType ActionType { get; set; }

        [JsonProperty("endOfSurveyText")]
        public TranslationElement[] EndOfSurveyText { get; set; }

        [JsonProperty("forwardUrl")]
        public TranslationElement[] ForwardUrl { get; set; }
    }

    public enum ActionType
    {
        Invalid,
        ShowEndOfSurveyText,
        ForwardToUrl
    }

    public enum ValueAssignmentType
    {
        Invalid,
        Custom,
        Panel,
        Survey,
        Credit
    }

    public enum ExecutionBehavior
    {
        Invalid,
        AnyTime,
        FirstTime,
        EachTime,
        SurveyLoad
    }

    public enum ApiCallMethod
    {
        Invalid,
        Get,
        Post
    }

    public enum ScriptType
    {
        Invalid,
        JavaScript,
        Css
    }

    public enum ArrangementMode
    {
        Invalid,
        Cubic,
        Circular
    }

    public class CustomVariable
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("variableType")]
        public VariableType VariableType { get; set; }
    }

    public enum bodysurveyDefinitiondataAccessControlaccessTypeInput
    {
        Private,
        Conditional,
        Public
    }

    public enum bodysurveyDefinitioncodeAccessModeInput
    {
        None,
        StrongUsernamePassword,
        StrongAccessCode,
        WeakUsernamePassword,
        WeakAccessCode
    }

    public enum bodysurveyDefinitionpanelSyncBehaviourInput
    {
        Invalid,
        Default,
        SignUp
    }

    public class PanelSyncElement
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("panelField")]
        public string PanelField { get; set; }
    }

    public enum bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput
    {
        M,
        S,
        L,
        Xl
    }

    public enum bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput
    {
        Invalid,
        Personalized,
        Anonymous
    }

    public class CreateWebHookResponse
    {
        [JsonProperty("webHookId")]
        public string WebHookId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public enum bodyeventTypeInput
    {
        Invalid,
        InterviewComplete,
        ApprovalRequest
    }

    public class DeleteArtifactResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteDistributorResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteInterviewResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteMembersResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeletePanelResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteSamplingProjectResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteSurveyResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DeleteWebHookResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DownloadAnswersResponse
    {
        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ExecuteSendMailResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ExecuteWorkflowTransitionResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public enum bodyworkflowInput
    {
        Invalid,
        SurveyDesign,
        LocalSamplingProject,
        Distribution,
        Reminder,
        ClientSamplingProject,
        LegacySamplingProject,
        SmartSamplingProject,
        DynataSamplingProject
    }

    public class InviteMembersResponse
    {
        [JsonProperty("samplingProjectId")]
        public int SamplingProjectId { get; set; }

        [JsonProperty("distributorId")]
        public int DistributorId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadArtifactListRequest
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("workspaceId")]
        public int WorkspaceId { get; set; }
    }

    public class ReadBounceListResponseV3
    {
        [JsonProperty("bounces")]
        public BounceElement[] Bounces { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class BounceElement
    {
        [JsonProperty("distributorId")]
        public int DistributorId { get; set; }

        [JsonProperty("interviewId")]
        public string InterviewId { get; set; }

        [JsonProperty("panelId")]
        public int PanelId { get; set; }

        [JsonProperty("panelMemberId")]
        public int PanelMemberId { get; set; }

        [JsonProperty("bounceType")]
        public BounceType BounceType { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public int Phone { get; set; }

        [JsonProperty("invitationType")]
        public InvitationType InvitationType { get; set; }
    }

    public enum BounceType
    {
        Invalid,
        Hard,
        Soft,
        Spam
    }

    public enum InvitationType
    {
        Invalid,
        Invitation,
        Reminder
    }

    public enum bodyinvitationTypeInput
    {
        Invalid,
        Invitation,
        Reminder
    }

    public enum bodypagingorderDirectionInput
    {
        Invalid,
        Ascending,
        Descending
    }

    public class ReadCreditBalanceResponse
    {
        [JsonProperty("balance")]
        public int Balance { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadDistributorListResponse
    {
        [JsonProperty("distributors")]
        public DistributorElement[] Distributors { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class DistributorElement
    {
        [JsonProperty("distributorId")]
        public int DistributorId { get; set; }

        [JsonProperty("distributionChannel")]
        public DistributionChannel DistributionChannel { get; set; }

        [JsonProperty("surveyId")]
        public int SurveyId { get; set; }

        [JsonProperty("samplingProjectId")]
        public int SamplingProjectId { get; set; }

        [JsonProperty("surveyVersion")]
        public int SurveyVersion { get; set; }

        [JsonProperty("panelId")]
        public int PanelId { get; set; }

        [JsonProperty("scheduledDistribution")]
        public string ScheduledDistribution { get; set; }

        [JsonProperty("executedDistribution")]
        public string ExecutedDistribution { get; set; }

        [JsonProperty("distributionState")]
        public string DistributionState { get; set; }

        [JsonProperty("conditions")]
        public ConditionDefinition[] Conditions { get; set; }
    }

    public enum DistributionChannel
    {
        Invalid,
        Email,
        Sms,
        LinkList,
        ApiEndpoint,
        WhatsApp
    }

    public class ReadIncentiveListResponse
    {
        [JsonProperty("panelIncentives")]
        public PanelIncentive[] PanelIncentives { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class PanelIncentive
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("priceInCredits")]
        public int PriceInCredits { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availableVouchersCount")]
        public int AvailableVouchersCount { get; set; }
    }

    public class ReadIncentiveTransactionListResponse
    {
        [JsonProperty("incentiveTransactions")]
        public SurveyCreditLog[] IncentiveTransactions { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyCreditLog
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("oldValue")]
        public string OldValue { get; set; }

        [JsonProperty("newValue")]
        public string NewValue { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("modifiedBy")]
        public string ModifiedBy { get; set; }

        [JsonProperty("responseId")]
        public string ResponseId { get; set; }

        [JsonProperty("interviewLink")]
        public string InterviewLink { get; set; }
    }

    public class ReadInterviewDataResponse
    {
        [JsonProperty("responseData")]
        public JToken ResponseData { get; set; }

        [JsonProperty("surveyDefinition")]
        public SurveyDefinition SurveyDefinition { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyDefinition
    {
        [JsonProperty("allowMultipleParticipation")]
        public bool AllowMultipleParticipation { get; set; }

        [JsonProperty("allowNavigateBack")]
        public bool AllowNavigateBack { get; set; }

        [JsonProperty("allowSaveProgress")]
        public bool AllowSaveProgress { get; set; }

        [JsonProperty("randomizeSections")]
        public bool RandomizeSections { get; set; }

        [JsonProperty("enableAutoScroll")]
        public bool EnableAutoScroll { get; set; }

        [JsonProperty("enableCodeAccess")]
        public bool EnableCodeAccess { get; set; }

        [JsonProperty("dataAccessControl")]
        public DataAccessControl DataAccessControl { get; set; }

        [JsonProperty("associatedPanels")]
        public int[] AssociatedPanels { get; set; }

        [JsonProperty("codeAccessMode")]
        public CodeAccessMode CodeAccessMode { get; set; }

        [JsonProperty("enablePanelSync")]
        public bool EnablePanelSync { get; set; }

        [JsonProperty("panelSyncBehaviour")]
        public PanelSyncBehaviour PanelSyncBehaviour { get; set; }

        [JsonProperty("panelSyncs")]
        public PanelSyncElement[] PanelSyncs { get; set; }

        [JsonProperty("defaultLanguage")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("sections")]
        public Section[] Sections { get; set; }

        [JsonProperty("customVariables")]
        public CustomVariable[] CustomVariables { get; set; }

        [JsonProperty("surveyEndText")]
        public TranslationElement[] SurveyEndText { get; set; }

        [JsonProperty("defaultTextOverrides")]
        public JToken DefaultTextOverrides { get; set; }
    }

    public class DataAccessControl
    {
        [JsonProperty("accessType")]
        public AccessType AccessType { get; set; }

        [JsonProperty("conditions")]
        public Condition[] Conditions { get; set; }
    }

    public enum AccessType
    {
        Private,
        Conditional,
        Public
    }

    public enum CodeAccessMode
    {
        None,
        StrongUsernamePassword,
        StrongAccessCode,
        WeakUsernamePassword,
        WeakAccessCode
    }

    public enum PanelSyncBehaviour
    {
        Invalid,
        Default,
        SignUp
    }

    public class ReadInterviewListCompactResponseV3
    {
        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("surveyDefaultLanguage")]
        public string SurveyDefaultLanguage { get; set; }

        [JsonProperty("surveyLanguages")]
        public string[] SurveyLanguages { get; set; }

        [JsonProperty("interviews")]
        public JToken[] Interviews { get; set; }

        [JsonProperty("codePlan")]
        public SurveyMetadataItem[] CodePlan { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyMetadataItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("dataType")]
        public string DataType { get; set; }

        [JsonProperty("questionCode")]
        public string QuestionCode { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("question")]
        public string Question { get; set; }

        [JsonProperty("row")]
        public string Row { get; set; }

        [JsonProperty("choice")]
        public string Choice { get; set; }

        [JsonProperty("values")]
        public RowItem[] Values { get; set; }

        [JsonProperty("sectionName")]
        public string SectionName { get; set; }
    }

    public class RowItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class ReadInterviewListResponseV3
    {
        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("surveyDefaultLanguage")]
        public string SurveyDefaultLanguage { get; set; }

        [JsonProperty("surveyLanguages")]
        public string[] SurveyLanguages { get; set; }

        [JsonProperty("codePlan")]
        public SurveyMetadataItem[] CodePlan { get; set; }

        [JsonProperty("interviews")]
        public Row[] Interviews { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class Row
    {
        [JsonProperty("columns")]
        public ColItem[] Columns { get; set; }
    }

    public class ColItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class ReadMemberListResponse
    {
        [JsonProperty("members")]
        public Member[] Members { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadMessageTemplateListResponse
    {
        [JsonProperty("messageTemplates")]
        public MessageTemplateItem[] MessageTemplates { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class MessageTemplateItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("defaultLocale")]
        public string DefaultLocale { get; set; }

        [JsonProperty("locales")]
        public string[] Locales { get; set; }
    }

    public class ReadOptOutListResponseV3
    {
        [JsonProperty("optOutItems")]
        public OptOutItem[] OptOutItems { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class OptOutItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public int Phone { get; set; }

        [JsonProperty("optOutAt")]
        public string OptOutAt { get; set; }

        [JsonProperty("optOutBy")]
        public string OptOutBy { get; set; }
    }

    public class ReadPanelDefinitionResponse
    {
        [JsonProperty("panel")]
        public PanelDefinition Panel { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class PanelDefinition
    {
        [JsonProperty("groups")]
        public VariableGroupElement[] Groups { get; set; }

        [JsonProperty("dataAccessControl")]
        public DataAccessControl DataAccessControl { get; set; }
    }

    public class VariableGroupElement
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("fields")]
        public PanelFieldItem[] Fields { get; set; }
    }

    public class PanelFieldItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("isSystem")]
        public bool IsSystem { get; set; }

        [JsonProperty("mandatory")]
        public bool Mandatory { get; set; }

        [JsonProperty("anonymize")]
        public bool Anonymize { get; set; }

        [JsonProperty("validationExpression")]
        public string ValidationExpression { get; set; }

        [JsonProperty("validationErrorMessageId")]
        public string ValidationErrorMessageId { get; set; }

        [JsonProperty("panelFieldType")]
        public VariableType PanelFieldType { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ReadSamplingProjectResponse
    {
        [JsonProperty("samplingProject")]
        public SamplingProjectElement SamplingProject { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SamplingProjectElement
    {
        [JsonProperty("samplingProjectId")]
        public int SamplingProjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("workspaceId")]
        public int WorkspaceId { get; set; }

        [JsonProperty("surveyId")]
        public int SurveyId { get; set; }

        [JsonProperty("surveyVersion")]
        public int SurveyVersion { get; set; }

        [JsonProperty("panelId")]
        public int PanelId { get; set; }

        [JsonProperty("samplingProviderId")]
        public int SamplingProviderId { get; set; }

        [JsonProperty("projectState")]
        public string ProjectState { get; set; }

        [JsonProperty("scheduledDistribution")]
        public string ScheduledDistribution { get; set; }

        [JsonProperty("executedDistribution")]
        public string ExecutedDistribution { get; set; }

        [JsonProperty("conditions")]
        public ConditionDefinition[] Conditions { get; set; }
    }

    public class ReadSurveyLinksResponse
    {
        [JsonProperty("anonymousList")]
        public SurveyLink[] AnonymousList { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyLink
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isCustom")]
        public bool IsCustom { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public class ReadSurveyListResponse
    {
        [JsonProperty("surveys")]
        public SurveyListItem[] Surveys { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyListItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("isEndDateEnabled")]
        public bool IsEndDateEnabled { get; set; }

        [JsonProperty("status")]
        public SurveyStatus Status { get; set; }

        [JsonProperty("archiveDate")]
        public string ArchiveDate { get; set; }

        [JsonProperty("statusOn")]
        public bool StatusOn { get; set; }

        [JsonProperty("answers")]
        public int Answers { get; set; }
    }

    public enum SurveyStatus
    {
        Invalid,
        Inactive,
        Active,
        Revision,
        Closed
    }

    public class ReadSurveyResponse
    {
        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("surveyVersion")]
        public int SurveyVersion { get; set; }

        [JsonProperty("surveyState")]
        public string SurveyState { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("survey")]
        public SurveyDefinition Survey { get; set; }

        [JsonProperty("surveyConfiguration")]
        public SurveyConfiguration SurveyConfiguration { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class SurveyConfiguration
    {
        [JsonProperty("designConfiguration")]
        public DesignConfiguration DesignConfiguration { get; set; }

        [JsonProperty("anonymizingConfiguration")]
        public AnonymizingConfiguration AnonymizingConfiguration { get; set; }
    }

    public class DesignConfiguration
    {
        [JsonProperty("surveyDesignLayout")]
        public int SurveyDesignLayout { get; set; }

        [JsonProperty("matrixSubQuestionSize")]
        public MatrixSubQuestionSize MatrixSubQuestionSize { get; set; }

        [JsonProperty("textBlocks")]
        public TextBlock[] TextBlocks { get; set; }
    }

    public enum MatrixSubQuestionSize
    {
        M,
        S,
        L,
        Xl
    }

    public class AnonymizingConfiguration
    {
        [JsonProperty("anonymizingMode")]
        public AnonymizingMode AnonymizingMode { get; set; }

        [JsonProperty("logIp")]
        public bool LogIp { get; set; }

        [JsonProperty("logUserAgent")]
        public bool LogUserAgent { get; set; }

        [JsonProperty("logReferer")]
        public bool LogReferer { get; set; }
    }

    public enum AnonymizingMode
    {
        Invalid,
        Personalized,
        Anonymous
    }

    public class ReadWebHookListResponse
    {
        [JsonProperty("webHooks")]
        public WebHookElement[] WebHooks { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WebHookElement
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("eventType")]
        public EventType EventType { get; set; }

        [JsonProperty("entityIdentifier")]
        public string EntityIdentifier { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }
    }

    public enum EventType
    {
        Invalid,
        InterviewComplete,
        ApprovalRequest
    }

    public class ReadWorkflowTransitionsResponse
    {
        [JsonProperty("transitions")]
        public WorkflowTransition[] Transitions { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WorkflowTransition
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("newState")]
        public string NewState { get; set; }

        [JsonProperty("condition")]
        public string Condition { get; set; }
    }

    public class ReadWorkspaceListResponse
    {
        [JsonProperty("workspaces")]
        public WorkspaceDto[] Workspaces { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WorkspaceDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("numberOfSurveys")]
        public int NumberOfSurveys { get; set; }
    }

    public class RedeemIncentiveCodeResponse
    {
        [JsonProperty("voucherCode")]
        public string VoucherCode { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class RemindMembersResponse
    {
        [JsonProperty("reminderId")]
        public int ReminderId { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ResetInterviewResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class UpdateMembersResponse
    {
        [JsonProperty("validationIssues")]
        public WritePanelMemberIssue[] ValidationIssues { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WritePanelResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class PanelMemberField
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PanelMemberFieldType Type { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public enum PanelMemberFieldType
    {
        Number,
        Real,
        String,
        DateTime,
        Time,
        Money,
        [EnumMember(Value = "Guid")]
        Id,
        Boolean,
        Date,
        Json
    }

    public class UpdateSurveyResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class UpdateWebHookResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class WriteOptOutListResponse
    {
        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class EmailItem
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("optOutOperation")]
        public OptOutOperation OptOutOperation { get; set; }
    }

    public enum OptOutOperation
    {
        Add,
        Delete
    }

    public class CellPhoneItem
    {
        [JsonProperty("cellPhone")]
        public int CellPhone { get; set; }

        [JsonProperty("optOutOperation")]
        public OptOutOperation OptOutOperation { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzereu;

    public partial class WorkflowManagedActions
    {
        public SurvalyzereuActions Survalyzereu(string connectionId) => new SurvalyzereuActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SurvalyzereuTriggers Survalyzereu(string connectionId) => new SurvalyzereuTriggers(connectionId);
    }
}