//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzerswiss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurvalyzerswissActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreateAndInviteMembers))]
        public IBodyWorkflowAction<CreateAndInviteMembersResponse> CreateAndInviteMembers([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<bool> bodyasyncProcess = null, [WorkflowExpression] Func<string> bodyinterviewExpiryDate = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateAndInviteMembersResponse> __BuildCreateAndInviteMembers(WorkflowExpression<int> bodysurveyId, WorkflowExpression<int> bodypanelId, WorkflowExpression<int> bodymessageTemplateId, WorkflowExpression<Member[]> bodymembers, WorkflowExpression<int> bodysamplingProjectId = null, WorkflowExpression<bodychannelInput> bodychannel = null, WorkflowExpression<TextBlock[]> bodytextBlocks = null, WorkflowExpression<string> bodyscheduleDateTime = null, WorkflowExpression<bool> bodyasyncProcess = null, WorkflowExpression<string> bodyinterviewExpiryDate = null, WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<string> bodyreplyTo = null, WorkflowExpression<string> bodyreplyToName = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: true);
            WorkflowExpression.Validate(bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            WorkflowExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            WorkflowExpression.Validate(bodytextBlocks, nameof(bodytextBlocks), required: false);
            WorkflowExpression.Validate(bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            WorkflowExpression.Validate(bodyasyncProcess, nameof(bodyasyncProcess), required: false);
            WorkflowExpression.Validate(bodyinterviewExpiryDate, nameof(bodyinterviewExpiryDate), required: false);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            WorkflowExpression.Validate(bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<CreateAndInviteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/CreateAndInviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(bodysamplingProjectId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                if (bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(bodychannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyasyncProcess != null)
                {
                    body["asyncProcess"] = ExpressionConverter.ConvertO(bodyasyncProcess);
                    bodypropCount++;
                }

                if (bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = ExpressionConverter.ConvertO(bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateAndInviteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreateArtifact))]
        public IBodyWorkflowAction<CreateArtifactResponse> CreateArtifact([WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<string> bodypath = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateArtifactResponse> __BuildCreateArtifact(WorkflowExpression<int> bodyworkspaceId = null, WorkflowExpression<string> bodypath = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: false);
            return new DeferredBodyAction<CreateArtifactResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/CreateArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(bodypath);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateArtifactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreateMembers))]
        public IBodyWorkflowAction<CreateMembersResponse> CreateMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<string> bodytenant = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateMembersResponse> __BuildCreateMembers(WorkflowExpression<int> bodypanelId, WorkflowExpression<Member[]> bodymembers, WorkflowExpression<string> bodytenant = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<CreateMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreatePanel))]
        public IBodyWorkflowAction<CreatePanelResponse> CreatePanel([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bodypanelTypeInput> bodypanelType = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreatePanelResponse> __BuildCreatePanel(WorkflowExpression<int> bodyworkspaceId, WorkflowExpression<string> bodyname, WorkflowExpression<bodypanelTypeInput> bodypanelType = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodypanelType, nameof(bodypanelType), required: false);
            return new DeferredBodyAction<CreatePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                if (bodypanelType != null)
                {
                    body["panelType"] = ExpressionConverter.ConvertO(bodypanelType);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreatePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreateSurvey))]
        public IBodyWorkflowAction<CreateSurveyResponse> CreateSurvey([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<string> bodyname, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowMultipleParticipation, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowNavigateBack, [WorkflowExpression] Func<bool> bodysurveyDefinitionrandomizeSections, [WorkflowExpression] Func<string> bodysurveyDefinitiondefaultLanguage, [WorkflowExpression] Func<string[]> bodysurveyDefinitionlanguages, [WorkflowExpression] Func<Section[]> bodysurveyDefinitionsections, [WorkflowExpression] Func<CustomVariable[]> bodysurveyDefinitioncustomVariables, [WorkflowExpression] Func<TranslationElement[]> bodysurveyDefinitionsurveyEndText, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowSaveProgress = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableAutoScroll = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableCodeAccess = null, [WorkflowExpression] Func<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, [WorkflowExpression] Func<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, [WorkflowExpression] Func<int[]> bodysurveyDefinitionassociatedPanels = null, [WorkflowExpression] Func<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenablePanelSync = null, [WorkflowExpression] Func<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, [WorkflowExpression] Func<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, [WorkflowExpression] Func<string> bodysurveyDefinitionendDate = null, [WorkflowExpression] Func<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, [WorkflowExpression] Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, [WorkflowExpression] Func<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, [WorkflowExpression] Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateSurveyResponse> __BuildCreateSurvey(WorkflowExpression<int> bodyworkspaceId, WorkflowExpression<string> bodyname, WorkflowExpression<bool> bodysurveyDefinitionallowMultipleParticipation, WorkflowExpression<bool> bodysurveyDefinitionallowNavigateBack, WorkflowExpression<bool> bodysurveyDefinitionrandomizeSections, WorkflowExpression<string> bodysurveyDefinitiondefaultLanguage, WorkflowExpression<string[]> bodysurveyDefinitionlanguages, WorkflowExpression<Section[]> bodysurveyDefinitionsections, WorkflowExpression<CustomVariable[]> bodysurveyDefinitioncustomVariables, WorkflowExpression<TranslationElement[]> bodysurveyDefinitionsurveyEndText, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, WorkflowExpression<bool> bodysurveyDefinitionallowSaveProgress = null, WorkflowExpression<bool> bodysurveyDefinitionenableAutoScroll = null, WorkflowExpression<bool> bodysurveyDefinitionenableCodeAccess = null, WorkflowExpression<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, WorkflowExpression<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, WorkflowExpression<int[]> bodysurveyDefinitionassociatedPanels = null, WorkflowExpression<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, WorkflowExpression<bool> bodysurveyDefinitionenablePanelSync = null, WorkflowExpression<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, WorkflowExpression<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, WorkflowExpression<string> bodysurveyDefinitionendDate = null, WorkflowExpression<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, WorkflowExpression<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, WorkflowExpression<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, WorkflowExpression<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodyname, nameof(bodyname), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionallowMultipleParticipation, nameof(bodysurveyDefinitionallowMultipleParticipation), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionallowNavigateBack, nameof(bodysurveyDefinitionallowNavigateBack), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionrandomizeSections, nameof(bodysurveyDefinitionrandomizeSections), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitiondefaultLanguage, nameof(bodysurveyDefinitiondefaultLanguage), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionlanguages, nameof(bodysurveyDefinitionlanguages), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionsections, nameof(bodysurveyDefinitionsections), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitioncustomVariables, nameof(bodysurveyDefinitioncustomVariables), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionsurveyEndText, nameof(bodysurveyDefinitionsurveyEndText), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogIp, nameof(bodysurveyConfigurationanonymizingConfigurationlogIp), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogUserAgent, nameof(bodysurveyConfigurationanonymizingConfigurationlogUserAgent), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogReferer, nameof(bodysurveyConfigurationanonymizingConfigurationlogReferer), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionallowSaveProgress, nameof(bodysurveyDefinitionallowSaveProgress), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenableAutoScroll, nameof(bodysurveyDefinitionenableAutoScroll), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenableCodeAccess, nameof(bodysurveyDefinitionenableCodeAccess), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitiondataAccessControlaccessType, nameof(bodysurveyDefinitiondataAccessControlaccessType), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitiondataAccessControlconditions, nameof(bodysurveyDefinitiondataAccessControlconditions), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionassociatedPanels, nameof(bodysurveyDefinitionassociatedPanels), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitioncodeAccessMode, nameof(bodysurveyDefinitioncodeAccessMode), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenablePanelSync, nameof(bodysurveyDefinitionenablePanelSync), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionpanelSyncBehaviour, nameof(bodysurveyDefinitionpanelSyncBehaviour), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionpanelSyncs, nameof(bodysurveyDefinitionpanelSyncs), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionendDate, nameof(bodysurveyDefinitionendDate), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout, nameof(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize, nameof(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationtextBlocks, nameof(bodysurveyConfigurationdesignConfigurationtextBlocks), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationanonymizingMode, nameof(bodysurveyConfigurationanonymizingConfigurationanonymizingMode), required: false);
            return new DeferredBodyAction<CreateSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/CreateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowNavigateBack);
                if (bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = ExpressionConverter.ConvertO(bodysurveyDefinitionrandomizeSections);
                if (bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = ExpressionConverter.ConvertO(bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = ExpressionConverter.ConvertO(bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = ExpressionConverter.ConvertO(bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = ExpressionConverter.ConvertO(bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondefaultLanguage);
                if (bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = ExpressionConverter.ConvertO(bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = ExpressionConverter.ConvertO(bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = ExpressionConverter.ConvertO(bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = ExpressionConverter.ConvertO(bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = ExpressionConverter.ConvertO(bodysurveyDefinitionsurveyEndText);
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
                    designConfigurationObject["surveyDesignLayout"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationtextBlocks);
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
                    anonymizingConfigurationObject["anonymizingMode"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogReferer);
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

                return new ApiConnectionAction<CreateSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWebHook))]
        public IBodyWorkflowAction<CreateWebHookResponse> CreateWebHook([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null, [WorkflowExpression] Func<string> bodysecurityToken = null, [WorkflowExpression] Func<string> bodywebHookUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateWebHookResponse> __BuildCreateWebHook(WorkflowExpression<bodyeventTypeInput> bodyeventType = null, WorkflowExpression<string> bodyentityIdentifier = null, WorkflowExpression<string> bodysecurityToken = null, WorkflowExpression<string> bodywebHookUrl = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: false);
            WorkflowExpression.Validate(bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            WorkflowExpression.Validate(bodysecurityToken, nameof(bodysecurityToken), required: false);
            WorkflowExpression.Validate(bodywebHookUrl, nameof(bodywebHookUrl), required: false);
            return new DeferredBodyAction<CreateWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/CreateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodysecurityToken != null)
                {
                    body["securityToken"] = ExpressionConverter.ConvertO(bodysecurityToken);
                    bodypropCount++;
                }

                if (bodywebHookUrl != null)
                {
                    body["webHookUrl"] = ExpressionConverter.ConvertO(bodywebHookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteArtifact))]
        public IBodyWorkflowAction<DeleteArtifactResponse> DeleteArtifact([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<string> bodyfilename = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteArtifactResponse> __BuildDeleteArtifact(WorkflowExpression<string> bodypath = null, WorkflowExpression<string> bodyfilename = null, WorkflowExpression<int> bodyworkspaceId = null)
        {
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowExpression.Validate(bodyfilename, nameof(bodyfilename), required: false);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<DeleteArtifactResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/DeleteArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(bodypath);
                    bodypropCount++;
                }

                if (bodyfilename != null)
                {
                    body["filename"] = ExpressionConverter.ConvertO(bodyfilename);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteArtifactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDistributor))]
        public IBodyWorkflowAction<DeleteDistributorResponse> DeleteDistributor([WorkflowExpression] Func<int> bodydistributorId, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteDistributorResponse> __BuildDeleteDistributor(WorkflowExpression<int> bodydistributorId, WorkflowExpression<bool> bodykeepInterviews = null)
        {
            WorkflowExpression.Validate(bodydistributorId, nameof(bodydistributorId), required: true);
            WorkflowExpression.Validate(bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteDistributorResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteDistributor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = ExpressionConverter.ConvertO(bodydistributorId);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteDistributorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteInterview))]
        public IBodyWorkflowAction<DeleteInterviewResponse> DeleteInterview([WorkflowExpression] Func<string> bodyinterviewId = null, [WorkflowExpression] Func<int> bodysurveyId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteInterviewResponse> __BuildDeleteInterview(WorkflowExpression<string> bodyinterviewId = null, WorkflowExpression<int> bodysurveyId = null)
        {
            WorkflowExpression.Validate(bodyinterviewId, nameof(bodyinterviewId), required: false);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            return new DeferredBodyAction<DeleteInterviewResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/DeleteInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyinterviewId != null)
                {
                    body["interviewId"] = ExpressionConverter.ConvertO(bodyinterviewId);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteInterviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteMembers))]
        public IBodyWorkflowAction<DeleteMembersResponse> DeleteMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int[]> bodypanelMembersIds, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteMembersResponse> __BuildDeleteMembers(WorkflowExpression<int> bodypanelId, WorkflowExpression<int[]> bodypanelMembersIds, WorkflowExpression<bool> bodykeepInterviews = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodypanelMembersIds, nameof(bodypanelMembersIds), required: true);
            WorkflowExpression.Validate(bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeleteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                bodypropCount++;
                body["panelMembersIds"] = ExpressionConverter.ConvertO(bodypanelMembersIds);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeletePanel))]
        public IBodyWorkflowAction<DeletePanelResponse> DeletePanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeletePanelResponse> __BuildDeletePanel(WorkflowExpression<int> bodypanelId, WorkflowExpression<bool> bodykeepInterviews = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeletePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeletePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeletePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSamplingProject))]
        public IBodyWorkflowAction<DeleteSamplingProjectResponse> DeleteSamplingProject([WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<bool> bodykeepInterviews = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteSamplingProjectResponse> __BuildDeleteSamplingProject(WorkflowExpression<int> bodysamplingProjectId = null, WorkflowExpression<bool> bodykeepInterviews = null)
        {
            WorkflowExpression.Validate(bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            WorkflowExpression.Validate(bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteSamplingProjectResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(bodykeepInterviews);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteSamplingProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteSurvey))]
        public IBodyWorkflowAction<DeleteSurveyResponse> DeleteSurvey([WorkflowExpression] Func<int> bodysurveyId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteSurveyResponse> __BuildDeleteSurvey(WorkflowExpression<int> bodysurveyId)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            return new DeferredBodyAction<DeleteSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/DeleteSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteWebHook))]
        public IBodyWorkflowAction<DeleteWebHookResponse> DeleteWebHook([WorkflowExpression] Func<string> bodywebHookId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DeleteWebHookResponse> __BuildDeleteWebHook(WorkflowExpression<string> bodywebHookId = null)
        {
            WorkflowExpression.Validate(bodywebHookId, nameof(bodywebHookId), required: false);
            return new DeferredBodyAction<DeleteWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/DeleteWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodywebHookId != null)
                {
                    body["webHookId"] = ExpressionConverter.ConvertO(bodywebHookId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadInterviewPdf))]
        public IBodyWorkflowAction<DownloadAnswersResponse> DownloadInterviewPdf([WorkflowExpression] Func<string> tenant, [WorkflowExpression] Func<int> surveyId, [WorkflowExpression] Func<string> interviewId, [WorkflowExpression] Func<bool> showPartialCompleted = null, [WorkflowExpression] Func<string> locale = null, [WorkflowExpression] Func<string> timeZone = null, [WorkflowExpression] Func<bool> bodyisCancellationRequested = null, [WorkflowExpression] Func<bool> bodycanBeCanceled = null, [WorkflowExpression] Func<bool> bodywaitHandlesafeWaitHandleisInvalid = null, [WorkflowExpression] Func<bool> bodywaitHandlesafeWaitHandleisClosed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DownloadAnswersResponse> __BuildDownloadInterviewPdf(WorkflowExpression<string> tenant, WorkflowExpression<int> surveyId, WorkflowExpression<string> interviewId, WorkflowExpression<bool> showPartialCompleted = null, WorkflowExpression<string> locale = null, WorkflowExpression<string> timeZone = null, WorkflowExpression<bool> bodyisCancellationRequested = null, WorkflowExpression<bool> bodycanBeCanceled = null, WorkflowExpression<bool> bodywaitHandlesafeWaitHandleisInvalid = null, WorkflowExpression<bool> bodywaitHandlesafeWaitHandleisClosed = null)
        {
            WorkflowExpression.Validate(tenant, nameof(tenant), required: true);
            WorkflowExpression.Validate(surveyId, nameof(surveyId), required: true);
            WorkflowExpression.Validate(interviewId, nameof(interviewId), required: true);
            WorkflowExpression.Validate(showPartialCompleted, nameof(showPartialCompleted), required: false);
            WorkflowExpression.Validate(locale, nameof(locale), required: false);
            WorkflowExpression.Validate(timeZone, nameof(timeZone), required: false);
            WorkflowExpression.Validate(bodyisCancellationRequested, nameof(bodyisCancellationRequested), required: false);
            WorkflowExpression.Validate(bodycanBeCanceled, nameof(bodycanBeCanceled), required: false);
            WorkflowExpression.Validate(bodywaitHandlesafeWaitHandleisInvalid, nameof(bodywaitHandlesafeWaitHandleisInvalid), required: false);
            WorkflowExpression.Validate(bodywaitHandlesafeWaitHandleisClosed, nameof(bodywaitHandlesafeWaitHandleisClosed), required: false);
            return new DeferredBodyAction<DownloadAnswersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/DownloadAnswers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenant"] = ExpressionConverter.Convert(tenant);
                callPayload.Queries["surveyId"] = ExpressionConverter.Convert(surveyId);
                callPayload.Queries["interviewId"] = ExpressionConverter.Convert(interviewId);
                if (showPartialCompleted != null)
                    callPayload.Queries["showPartialCompleted"] = ExpressionConverter.Convert(showPartialCompleted);
                if (locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(locale);
                if (timeZone != null)
                    callPayload.Queries["timeZone"] = ExpressionConverter.Convert(timeZone);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyisCancellationRequested != null)
                {
                    body["isCancellationRequested"] = ExpressionConverter.ConvertO(bodyisCancellationRequested);
                    bodypropCount++;
                }

                if (bodycanBeCanceled != null)
                {
                    body["canBeCanceled"] = ExpressionConverter.ConvertO(bodycanBeCanceled);
                    bodypropCount++;
                }

                var waitHandleObject = new JObject();
                var waitHandleObjectpropCount = 0;
                var safeWaitHandleObject = new JObject();
                var safeWaitHandleObjectpropCount = 0;
                if (bodywaitHandlesafeWaitHandleisInvalid != null)
                {
                    safeWaitHandleObject["isInvalid"] = ExpressionConverter.ConvertO(bodywaitHandlesafeWaitHandleisInvalid);
                    safeWaitHandleObjectpropCount++;
                }

                if (bodywaitHandlesafeWaitHandleisClosed != null)
                {
                    safeWaitHandleObject["isClosed"] = ExpressionConverter.ConvertO(bodywaitHandlesafeWaitHandleisClosed);
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

                return new ApiConnectionAction<DownloadAnswersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteSendMail))]
        public IBodyWorkflowAction<ExecuteSendMailResponse> ExecuteSendMail([WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<string> bodyfrom, [WorkflowExpression] Func<string> bodyto, [WorkflowExpression] Func<int> bodymessageTemplateId = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodysubject = null, [WorkflowExpression] Func<string> bodybody = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodytoName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteSendMailResponse> __BuildExecuteSendMail(WorkflowExpression<string> bodylanguage, WorkflowExpression<string> bodyfrom, WorkflowExpression<string> bodyto, WorkflowExpression<int> bodymessageTemplateId = null, WorkflowExpression<TextBlock[]> bodytextBlocks = null, WorkflowExpression<string> bodysubject = null, WorkflowExpression<string> bodybody = null, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<string> bodytoName = null, WorkflowExpression<string> bodyreplyTo = null, WorkflowExpression<string> bodyreplyToName = null)
        {
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: true);
            WorkflowExpression.Validate(bodyto, nameof(bodyto), required: true);
            WorkflowExpression.Validate(bodymessageTemplateId, nameof(bodymessageTemplateId), required: false);
            WorkflowExpression.Validate(bodytextBlocks, nameof(bodytextBlocks), required: false);
            WorkflowExpression.Validate(bodysubject, nameof(bodysubject), required: false);
            WorkflowExpression.Validate(bodybody, nameof(bodybody), required: false);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodytoName, nameof(bodytoName), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            WorkflowExpression.Validate(bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<ExecuteSendMailResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteSendMail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodymessageTemplateId != null)
                {
                    body["messageTemplateId"] = ExpressionConverter.ConvertO(bodymessageTemplateId);
                    bodypropCount++;
                }

                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                if (bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(bodysubject);
                    bodypropCount++;
                }

                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                if (bodyfromName != null)
                {
                    body["fromName"] = ExpressionConverter.ConvertO(bodyfromName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(bodyto);
                if (bodytoName != null)
                {
                    body["toName"] = ExpressionConverter.ConvertO(bodytoName);
                    bodypropCount++;
                }

                if (bodyreplyTo != null)
                {
                    body["replyTo"] = ExpressionConverter.ConvertO(bodyreplyTo);
                    bodypropCount++;
                }

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ExecuteSendMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildExecuteWorkflowTransition))]
        public IBodyWorkflowAction<ExecuteWorkflowTransitionResponse> ExecuteWorkflowTransition([WorkflowExpression] Func<string> bodytargetState, [WorkflowExpression] Func<bodyworkflowInput> bodyworkflow = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<int> bodydistributorId = null, [WorkflowExpression] Func<int> bodyreminderId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ExecuteWorkflowTransitionResponse> __BuildExecuteWorkflowTransition(WorkflowExpression<string> bodytargetState, WorkflowExpression<bodyworkflowInput> bodyworkflow = null, WorkflowExpression<int> bodysurveyId = null, WorkflowExpression<int> bodysamplingProjectId = null, WorkflowExpression<int> bodydistributorId = null, WorkflowExpression<int> bodyreminderId = null)
        {
            WorkflowExpression.Validate(bodytargetState, nameof(bodytargetState), required: true);
            WorkflowExpression.Validate(bodyworkflow, nameof(bodyworkflow), required: false);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            WorkflowExpression.Validate(bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            WorkflowExpression.Validate(bodydistributorId, nameof(bodydistributorId), required: false);
            WorkflowExpression.Validate(bodyreminderId, nameof(bodyreminderId), required: false);
            return new DeferredBodyAction<ExecuteWorkflowTransitionResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteWorkflowTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkflow != null)
                {
                    body["workflow"] = ExpressionConverter.ConvertO(bodyworkflow);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodydistributorId != null)
                {
                    body["distributorId"] = ExpressionConverter.ConvertO(bodydistributorId);
                    bodypropCount++;
                }

                if (bodyreminderId != null)
                {
                    body["reminderId"] = ExpressionConverter.ConvertO(bodyreminderId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["targetState"] = ExpressionConverter.ConvertO(bodytargetState);
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

                return new ApiConnectionAction<ExecuteWorkflowTransitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildInviteMembers))]
        public IBodyWorkflowAction<InviteMembersResponse> InviteMembers([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<int> bodysamplingProjectId = null, [WorkflowExpression] Func<int[]> bodymemberIds = null, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<bool> bodyasyncProcess = null, [WorkflowExpression] Func<string> bodyinterviewExpiryDate = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InviteMembersResponse> __BuildInviteMembers(WorkflowExpression<int> bodysurveyId, WorkflowExpression<int> bodypanelId, WorkflowExpression<int> bodymessageTemplateId, WorkflowExpression<int> bodysamplingProjectId = null, WorkflowExpression<int[]> bodymemberIds = null, WorkflowExpression<TextBlock[]> bodytextBlocks = null, WorkflowExpression<string> bodyscheduleDateTime = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<bodychannelInput> bodychannel = null, WorkflowExpression<bool> bodyasyncProcess = null, WorkflowExpression<string> bodyinterviewExpiryDate = null, WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<string> bodyreplyTo = null, WorkflowExpression<string> bodyreplyToName = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            WorkflowExpression.Validate(bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            WorkflowExpression.Validate(bodymemberIds, nameof(bodymemberIds), required: false);
            WorkflowExpression.Validate(bodytextBlocks, nameof(bodytextBlocks), required: false);
            WorkflowExpression.Validate(bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            WorkflowExpression.Validate(bodyasyncProcess, nameof(bodyasyncProcess), required: false);
            WorkflowExpression.Validate(bodyinterviewExpiryDate, nameof(bodyinterviewExpiryDate), required: false);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            WorkflowExpression.Validate(bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<InviteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/InviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodymemberIds != null)
                {
                    body["memberIds"] = ExpressionConverter.ConvertO(bodymemberIds);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(bodytextBlocks);
                    bodypropCount++;
                }

                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(bodychannel);
                    bodypropCount++;
                }

                if (bodyasyncProcess != null)
                {
                    body["asyncProcess"] = ExpressionConverter.ConvertO(bodyasyncProcess);
                    bodypropCount++;
                }

                if (bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = ExpressionConverter.ConvertO(bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InviteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadArtifactList))]
        public IBodyWorkflowAction<ReadArtifactListRequest> ReadArtifactList([WorkflowExpression] Func<string> bodypath = null, [WorkflowExpression] Func<int> bodyworkspaceId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadArtifactListRequest> __BuildReadArtifactList(WorkflowExpression<string> bodypath = null, WorkflowExpression<int> bodyworkspaceId = null)
        {
            WorkflowExpression.Validate(bodypath, nameof(bodypath), required: false);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<ReadArtifactListRequest>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadArtifactList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(bodypath);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadArtifactListRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadBounceList))]
        public IBodyWorkflowAction<ReadBounceListResponseV3> ReadBounceList([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int[]> bodydistributors = null, [WorkflowExpression] Func<bodyinvitationTypeInput> bodyinvitationType = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadBounceListResponseV3> __BuildReadBounceList(WorkflowExpression<int> bodysurveyId, WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<int> bodypanelId = null, WorkflowExpression<int[]> bodydistributors = null, WorkflowExpression<bodyinvitationTypeInput> bodyinvitationType = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: false);
            WorkflowExpression.Validate(bodydistributors, nameof(bodydistributors), required: false);
            WorkflowExpression.Validate(bodyinvitationType, nameof(bodyinvitationType), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadBounceListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadBounceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                if (bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                    bodypropCount++;
                }

                if (bodydistributors != null)
                {
                    body["distributors"] = ExpressionConverter.ConvertO(bodydistributors);
                    bodypropCount++;
                }

                if (bodyinvitationType != null)
                {
                    body["invitationType"] = ExpressionConverter.ConvertO(bodyinvitationType);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadBounceListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<ReadCreditBalanceResponse> ReadCreditBalance()
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

            return new ApiConnectionAction<ReadCreditBalanceResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadDistributorList))]
        public IBodyWorkflowAction<ReadDistributorListResponse> ReadDistributorList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadDistributorListResponse> __BuildReadDistributorList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<int> bodysurveyId = null, WorkflowExpression<int> bodypanelId = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadDistributorListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadDistributorList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadDistributorListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadIncentiveList))]
        public IBodyWorkflowAction<ReadIncentiveListResponse> ReadIncentiveList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadIncentiveListResponse> __BuildReadIncentiveList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadIncentiveListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadIncentiveListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadIncentiveTransactionList))]
        public IBodyWorkflowAction<ReadIncentiveTransactionListResponse> ReadIncentiveTransactionList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadIncentiveTransactionListResponse> __BuildReadIncentiveTransactionList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadIncentiveTransactionListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveTransactionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadIncentiveTransactionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadInterview))]
        public IBodyWorkflowAction<ReadInterviewDataResponse> ReadInterview([WorkflowExpression] Func<string> bodytenant, [WorkflowExpression] Func<string> bodyinterviewId, [WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<bool> bodyloadSurveyDefinition = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadInterviewDataResponse> __BuildReadInterview(WorkflowExpression<string> bodytenant, WorkflowExpression<string> bodyinterviewId, WorkflowExpression<int> bodysurveyId, WorkflowExpression<bool> bodyloadSurveyDefinition = null)
        {
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: true);
            WorkflowExpression.Validate(bodyinterviewId, nameof(bodyinterviewId), required: true);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodyloadSurveyDefinition, nameof(bodyloadSurveyDefinition), required: false);
            return new DeferredBodyAction<ReadInterviewDataResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                bodypropCount++;
                body["interviewId"] = ExpressionConverter.ConvertO(bodyinterviewId);
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                if (bodyloadSurveyDefinition != null)
                {
                    body["loadSurveyDefinition"] = ExpressionConverter.ConvertO(bodyloadSurveyDefinition);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadInterviewDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadInterviewListCompact))]
        public IBodyWorkflowAction<ReadInterviewListCompactResponseV3> ReadInterviewListCompact([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<bool> bodyloadCodePlan = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadInterviewListCompactResponseV3> __BuildReadInterviewListCompact(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<string> bodytenant = null, WorkflowExpression<int> bodysurveyId = null, WorkflowExpression<string[]> bodyfieldsToDownload = null, WorkflowExpression<bool> bodyloadCodePlan = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            WorkflowExpression.Validate(bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            WorkflowExpression.Validate(bodyloadCodePlan, nameof(bodyloadCodePlan), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadInterviewListCompactResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewListCompact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = ExpressionConverter.ConvertO(bodyloadCodePlan);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadInterviewListCompactResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadInterviewList))]
        public IBodyWorkflowAction<ReadInterviewListResponseV3> ReadInterviewList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<bool> bodyloadCodePlan = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadInterviewListResponseV3> __BuildReadInterviewList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<string> bodytenant = null, WorkflowExpression<int> bodysurveyId = null, WorkflowExpression<string[]> bodyfieldsToDownload = null, WorkflowExpression<bool> bodyloadCodePlan = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            WorkflowExpression.Validate(bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            WorkflowExpression.Validate(bodyloadCodePlan, nameof(bodyloadCodePlan), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadInterviewListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = ExpressionConverter.ConvertO(bodyloadCodePlan);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadInterviewListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadMemberList))]
        public IBodyWorkflowAction<ReadMemberListResponse> ReadMemberList([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<bool> bodyinterviewsRequired, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<string[]> bodyfieldsToDownload = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadMemberListResponse> __BuildReadMemberList(WorkflowExpression<int> bodypanelId, WorkflowExpression<bool> bodyinterviewsRequired, WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<string> bodytenant = null, WorkflowExpression<string[]> bodyfieldsToDownload = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodyinterviewsRequired, nameof(bodyinterviewsRequired), required: true);
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            WorkflowExpression.Validate(bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadMemberListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadMemberList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                bodypropCount++;
                body["interviewsRequired"] = ExpressionConverter.ConvertO(bodyinterviewsRequired);
                if (bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadMemberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadMessageTemplateList))]
        public IBodyWorkflowAction<ReadMessageTemplateListResponse> ReadMessageTemplateList([WorkflowExpression] Func<string> bodylanguage, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadMessageTemplateListResponse> __BuildReadMessageTemplateList(WorkflowExpression<string> bodylanguage, WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<int> bodyworkspaceId = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodylanguage, nameof(bodylanguage), required: true);
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadMessageTemplateListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadMessageTemplateList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(bodylanguage);
                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadMessageTemplateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadOptOutList))]
        public IBodyWorkflowAction<ReadOptOutListResponseV3> ReadOptOutList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadOptOutListResponseV3> __BuildReadOptOutList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<int> bodypanelId = null, WorkflowExpression<int> bodyworkspaceId = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: false);
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadOptOutListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                    bodypropCount++;
                }

                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadOptOutListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadPanel))]
        public IBodyWorkflowAction<ReadPanelDefinitionResponse> ReadPanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<string> bodytenant = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadPanelDefinitionResponse> __BuildReadPanel(WorkflowExpression<int> bodypanelId, WorkflowExpression<string> bodytenant = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<ReadPanelDefinitionResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadPanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadPanelDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadSamplingProject))]
        public IBodyWorkflowAction<ReadSamplingProjectResponse> ReadSamplingProject([WorkflowExpression] Func<int> bodysamplingProjectId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadSamplingProjectResponse> __BuildReadSamplingProject(WorkflowExpression<int> bodysamplingProjectId = null)
        {
            WorkflowExpression.Validate(bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            return new DeferredBodyAction<ReadSamplingProjectResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(bodysamplingProjectId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadSamplingProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadSurveyLinks))]
        public IBodyWorkflowAction<ReadSurveyLinksResponse> ReadSurveyLinks([WorkflowExpression] Func<int> bodysurveyId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadSurveyLinksResponse> __BuildReadSurveyLinks(WorkflowExpression<int> bodysurveyId = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            return new DeferredBodyAction<ReadSurveyLinksResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyLinks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadSurveyLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadSurveyList))]
        public IBodyWorkflowAction<ReadSurveyListResponse> ReadSurveyList([WorkflowExpression] Func<int> bodyworkspaceId, [WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadSurveyListResponse> __BuildReadSurveyList(WorkflowExpression<int> bodyworkspaceId, WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadSurveyListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadSurveyListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadSurvey))]
        public IBodyWorkflowAction<ReadSurveyResponse> ReadSurvey([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<string> bodytenant = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadSurveyResponse> __BuildReadSurvey(WorkflowExpression<int> bodysurveyId, WorkflowExpression<string> bodytenant = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<ReadSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadWebHookList))]
        public IBodyWorkflowAction<ReadWebHookListResponse> ReadWebHookList([WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadWebHookListResponse> __BuildReadWebHookList(WorkflowExpression<bodyeventTypeInput> bodyeventType = null, WorkflowExpression<string> bodyentityIdentifier = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: false);
            WorkflowExpression.Validate(bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            return new DeferredBodyAction<ReadWebHookListResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/ReadWebHookList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadWebHookListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadWorkflowTransitions))]
        public IBodyWorkflowAction<ReadWorkflowTransitionsResponse> ReadWorkflowTransitions([WorkflowExpression] Func<string> bodycurrentState, [WorkflowExpression] Func<bodyworkflowInput> bodyworkflow = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadWorkflowTransitionsResponse> __BuildReadWorkflowTransitions(WorkflowExpression<string> bodycurrentState, WorkflowExpression<bodyworkflowInput> bodyworkflow = null)
        {
            WorkflowExpression.Validate(bodycurrentState, nameof(bodycurrentState), required: true);
            WorkflowExpression.Validate(bodyworkflow, nameof(bodyworkflow), required: false);
            return new DeferredBodyAction<ReadWorkflowTransitionsResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadWorkflowTransitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkflow != null)
                {
                    body["workflow"] = ExpressionConverter.ConvertO(bodyworkflow);
                    bodypropCount++;
                }

                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(bodycurrentState);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadWorkflowTransitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildReadWorkspaceList))]
        public IBodyWorkflowAction<ReadWorkspaceListResponse> ReadWorkspaceList([WorkflowExpression] Func<int> bodypagingpageSize, [WorkflowExpression] Func<int> bodypagingpage, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<string> bodypagingorderField = null, [WorkflowExpression] Func<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReadWorkspaceListResponse> __BuildReadWorkspaceList(WorkflowExpression<int> bodypagingpageSize, WorkflowExpression<int> bodypagingpage, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<string> bodypagingorderField = null, WorkflowExpression<bodypagingorderDirectionInput> bodypagingorderDirection = null)
        {
            WorkflowExpression.Validate(bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            WorkflowExpression.Validate(bodypagingpage, nameof(bodypagingpage), required: true);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodypagingorderField, nameof(bodypagingorderField), required: false);
            WorkflowExpression.Validate(bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadWorkspaceListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadWorkspaceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(bodypagingpage);
                if (bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(bodypagingorderDirection);
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

                return new ApiConnectionAction<ReadWorkspaceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildRedeemIncentiveCode))]
        public IBodyWorkflowAction<RedeemIncentiveCodeResponse> RedeemIncentiveCode([WorkflowExpression] Func<int> bodyincentiveId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RedeemIncentiveCodeResponse> __BuildRedeemIncentiveCode(WorkflowExpression<int> bodyincentiveId)
        {
            WorkflowExpression.Validate(bodyincentiveId, nameof(bodyincentiveId), required: true);
            return new DeferredBodyAction<RedeemIncentiveCodeResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/RedeemIncentiveCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["incentiveId"] = ExpressionConverter.ConvertO(bodyincentiveId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RedeemIncentiveCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildRemindMembers))]
        public IBodyWorkflowAction<RemindMembersResponse> RemindMembers([WorkflowExpression] Func<int> bodydistributorId, [WorkflowExpression] Func<int> bodymessageTemplateId, [WorkflowExpression] Func<TextBlock[]> bodytextBlocks = null, [WorkflowExpression] Func<string> bodyscheduleDateTime = null, [WorkflowExpression] Func<Condition[]> bodyconditions = null, [WorkflowExpression] Func<bodychannelInput> bodychannel = null, [WorkflowExpression] Func<string> bodyfrom = null, [WorkflowExpression] Func<string> bodyfromName = null, [WorkflowExpression] Func<string> bodyreplyTo = null, [WorkflowExpression] Func<string> bodyreplyToName = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RemindMembersResponse> __BuildRemindMembers(WorkflowExpression<int> bodydistributorId, WorkflowExpression<int> bodymessageTemplateId, WorkflowExpression<TextBlock[]> bodytextBlocks = null, WorkflowExpression<string> bodyscheduleDateTime = null, WorkflowExpression<Condition[]> bodyconditions = null, WorkflowExpression<bodychannelInput> bodychannel = null, WorkflowExpression<string> bodyfrom = null, WorkflowExpression<string> bodyfromName = null, WorkflowExpression<string> bodyreplyTo = null, WorkflowExpression<string> bodyreplyToName = null)
        {
            WorkflowExpression.Validate(bodydistributorId, nameof(bodydistributorId), required: true);
            WorkflowExpression.Validate(bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            WorkflowExpression.Validate(bodytextBlocks, nameof(bodytextBlocks), required: false);
            WorkflowExpression.Validate(bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            WorkflowExpression.Validate(bodyconditions, nameof(bodyconditions), required: false);
            WorkflowExpression.Validate(bodychannel, nameof(bodychannel), required: false);
            WorkflowExpression.Validate(bodyfrom, nameof(bodyfrom), required: false);
            WorkflowExpression.Validate(bodyfromName, nameof(bodyfromName), required: false);
            WorkflowExpression.Validate(bodyreplyTo, nameof(bodyreplyTo), required: false);
            WorkflowExpression.Validate(bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<RemindMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/RemindMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = ExpressionConverter.ConvertO(bodydistributorId);
                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(bodymessageTemplateId);
                if (bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(bodytextBlocks);
                    bodypropCount++;
                }

                if (bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(bodyconditions);
                    bodypropCount++;
                }

                if (bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(bodychannel);
                    bodypropCount++;
                }

                if (bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(bodyfrom);
                    bodypropCount++;
                }

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

                if (bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(bodyreplyToName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RemindMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildResetInterview))]
        public IBodyWorkflowAction<ResetInterviewResponse> ResetInterview([WorkflowExpression] Func<int> bodysurveyId = null, [WorkflowExpression] Func<string> bodyinterviewId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResetInterviewResponse> __BuildResetInterview(WorkflowExpression<int> bodysurveyId = null, WorkflowExpression<string> bodyinterviewId = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: false);
            WorkflowExpression.Validate(bodyinterviewId, nameof(bodyinterviewId), required: false);
            return new DeferredBodyAction<ResetInterviewResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ResetInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                    bodypropCount++;
                }

                if (bodyinterviewId != null)
                {
                    body["interviewId"] = ExpressionConverter.ConvertO(bodyinterviewId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResetInterviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateMembers))]
        public IBodyWorkflowAction<UpdateMembersResponse> UpdateMembers([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<Member[]> bodymembers, [WorkflowExpression] Func<string> bodytenant = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateMembersResponse> __BuildUpdateMembers(WorkflowExpression<int> bodypanelId, WorkflowExpression<Member[]> bodymembers, WorkflowExpression<string> bodytenant = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodymembers, nameof(bodymembers), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<UpdateMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildUpdatePanel))]
        public IBodyWorkflowAction<WritePanelResponse> UpdatePanel([WorkflowExpression] Func<int> bodypanelId, [WorkflowExpression] Func<string> bodytenant = null, [WorkflowExpression] Func<PanelMemberField[]> bodyaddedFields = null, [WorkflowExpression] Func<int[]> bodyremovedFields = null, [WorkflowExpression] Func<PanelMemberField[]> bodyrenamedFields = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WritePanelResponse> __BuildUpdatePanel(WorkflowExpression<int> bodypanelId, WorkflowExpression<string> bodytenant = null, WorkflowExpression<PanelMemberField[]> bodyaddedFields = null, WorkflowExpression<int[]> bodyremovedFields = null, WorkflowExpression<PanelMemberField[]> bodyrenamedFields = null)
        {
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: true);
            WorkflowExpression.Validate(bodytenant, nameof(bodytenant), required: false);
            WorkflowExpression.Validate(bodyaddedFields, nameof(bodyaddedFields), required: false);
            WorkflowExpression.Validate(bodyremovedFields, nameof(bodyremovedFields), required: false);
            WorkflowExpression.Validate(bodyrenamedFields, nameof(bodyrenamedFields), required: false);
            return new DeferredBodyAction<WritePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                if (bodyaddedFields != null)
                {
                    body["addedFields"] = ExpressionConverter.ConvertO(bodyaddedFields);
                    bodypropCount++;
                }

                if (bodyremovedFields != null)
                {
                    body["removedFields"] = ExpressionConverter.ConvertO(bodyremovedFields);
                    bodypropCount++;
                }

                if (bodyrenamedFields != null)
                {
                    body["renamedFields"] = ExpressionConverter.ConvertO(bodyrenamedFields);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WritePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateSurvey))]
        public IBodyWorkflowAction<UpdateSurveyResponse> UpdateSurvey([WorkflowExpression] Func<int> bodysurveyId, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowMultipleParticipation, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowNavigateBack, [WorkflowExpression] Func<bool> bodysurveyDefinitionrandomizeSections, [WorkflowExpression] Func<string> bodysurveyDefinitiondefaultLanguage, [WorkflowExpression] Func<string[]> bodysurveyDefinitionlanguages, [WorkflowExpression] Func<Section[]> bodysurveyDefinitionsections, [WorkflowExpression] Func<CustomVariable[]> bodysurveyDefinitioncustomVariables, [WorkflowExpression] Func<TranslationElement[]> bodysurveyDefinitionsurveyEndText, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, [WorkflowExpression] Func<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, [WorkflowExpression] Func<string> bodysurveyName = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionallowSaveProgress = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableAutoScroll = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenableCodeAccess = null, [WorkflowExpression] Func<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, [WorkflowExpression] Func<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, [WorkflowExpression] Func<int[]> bodysurveyDefinitionassociatedPanels = null, [WorkflowExpression] Func<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, [WorkflowExpression] Func<bool> bodysurveyDefinitionenablePanelSync = null, [WorkflowExpression] Func<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, [WorkflowExpression] Func<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, [WorkflowExpression] Func<string> bodysurveyDefinitionendDate = null, [WorkflowExpression] Func<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, [WorkflowExpression] Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, [WorkflowExpression] Func<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, [WorkflowExpression] Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateSurveyResponse> __BuildUpdateSurvey(WorkflowExpression<int> bodysurveyId, WorkflowExpression<bool> bodysurveyDefinitionallowMultipleParticipation, WorkflowExpression<bool> bodysurveyDefinitionallowNavigateBack, WorkflowExpression<bool> bodysurveyDefinitionrandomizeSections, WorkflowExpression<string> bodysurveyDefinitiondefaultLanguage, WorkflowExpression<string[]> bodysurveyDefinitionlanguages, WorkflowExpression<Section[]> bodysurveyDefinitionsections, WorkflowExpression<CustomVariable[]> bodysurveyDefinitioncustomVariables, WorkflowExpression<TranslationElement[]> bodysurveyDefinitionsurveyEndText, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogIp, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, WorkflowExpression<bool> bodysurveyConfigurationanonymizingConfigurationlogReferer, WorkflowExpression<string> bodysurveyName = null, WorkflowExpression<bool> bodysurveyDefinitionallowSaveProgress = null, WorkflowExpression<bool> bodysurveyDefinitionenableAutoScroll = null, WorkflowExpression<bool> bodysurveyDefinitionenableCodeAccess = null, WorkflowExpression<bodysurveyDefinitiondataAccessControlaccessTypeInput> bodysurveyDefinitiondataAccessControlaccessType = null, WorkflowExpression<Condition[]> bodysurveyDefinitiondataAccessControlconditions = null, WorkflowExpression<int[]> bodysurveyDefinitionassociatedPanels = null, WorkflowExpression<bodysurveyDefinitioncodeAccessModeInput> bodysurveyDefinitioncodeAccessMode = null, WorkflowExpression<bool> bodysurveyDefinitionenablePanelSync = null, WorkflowExpression<bodysurveyDefinitionpanelSyncBehaviourInput> bodysurveyDefinitionpanelSyncBehaviour = null, WorkflowExpression<PanelSyncElement[]> bodysurveyDefinitionpanelSyncs = null, WorkflowExpression<string> bodysurveyDefinitionendDate = null, WorkflowExpression<int> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, WorkflowExpression<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, WorkflowExpression<TextBlock[]> bodysurveyConfigurationdesignConfigurationtextBlocks = null, WorkflowExpression<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            WorkflowExpression.Validate(bodysurveyId, nameof(bodysurveyId), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionallowMultipleParticipation, nameof(bodysurveyDefinitionallowMultipleParticipation), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionallowNavigateBack, nameof(bodysurveyDefinitionallowNavigateBack), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionrandomizeSections, nameof(bodysurveyDefinitionrandomizeSections), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitiondefaultLanguage, nameof(bodysurveyDefinitiondefaultLanguage), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionlanguages, nameof(bodysurveyDefinitionlanguages), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionsections, nameof(bodysurveyDefinitionsections), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitioncustomVariables, nameof(bodysurveyDefinitioncustomVariables), required: true);
            WorkflowExpression.Validate(bodysurveyDefinitionsurveyEndText, nameof(bodysurveyDefinitionsurveyEndText), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogIp, nameof(bodysurveyConfigurationanonymizingConfigurationlogIp), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogUserAgent, nameof(bodysurveyConfigurationanonymizingConfigurationlogUserAgent), required: true);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationlogReferer, nameof(bodysurveyConfigurationanonymizingConfigurationlogReferer), required: true);
            WorkflowExpression.Validate(bodysurveyName, nameof(bodysurveyName), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionallowSaveProgress, nameof(bodysurveyDefinitionallowSaveProgress), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenableAutoScroll, nameof(bodysurveyDefinitionenableAutoScroll), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenableCodeAccess, nameof(bodysurveyDefinitionenableCodeAccess), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitiondataAccessControlaccessType, nameof(bodysurveyDefinitiondataAccessControlaccessType), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitiondataAccessControlconditions, nameof(bodysurveyDefinitiondataAccessControlconditions), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionassociatedPanels, nameof(bodysurveyDefinitionassociatedPanels), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitioncodeAccessMode, nameof(bodysurveyDefinitioncodeAccessMode), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionenablePanelSync, nameof(bodysurveyDefinitionenablePanelSync), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionpanelSyncBehaviour, nameof(bodysurveyDefinitionpanelSyncBehaviour), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionpanelSyncs, nameof(bodysurveyDefinitionpanelSyncs), required: false);
            WorkflowExpression.Validate(bodysurveyDefinitionendDate, nameof(bodysurveyDefinitionendDate), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout, nameof(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize, nameof(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationdesignConfigurationtextBlocks, nameof(bodysurveyConfigurationdesignConfigurationtextBlocks), required: false);
            WorkflowExpression.Validate(bodysurveyConfigurationanonymizingConfigurationanonymizingMode, nameof(bodysurveyConfigurationanonymizingConfigurationanonymizingMode), required: false);
            return new DeferredBodyAction<UpdateSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/UpdateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(bodysurveyId);
                if (bodysurveyName != null)
                {
                    body["surveyName"] = ExpressionConverter.ConvertO(bodysurveyName);
                    bodypropCount++;
                }

                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowNavigateBack);
                if (bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = ExpressionConverter.ConvertO(bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = ExpressionConverter.ConvertO(bodysurveyDefinitionrandomizeSections);
                if (bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = ExpressionConverter.ConvertO(bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = ExpressionConverter.ConvertO(bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = ExpressionConverter.ConvertO(bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = ExpressionConverter.ConvertO(bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = ExpressionConverter.ConvertO(bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = ExpressionConverter.ConvertO(bodysurveyDefinitiondefaultLanguage);
                if (bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = ExpressionConverter.ConvertO(bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = ExpressionConverter.ConvertO(bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = ExpressionConverter.ConvertO(bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = ExpressionConverter.ConvertO(bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = ExpressionConverter.ConvertO(bodysurveyDefinitionsurveyEndText);
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
                    designConfigurationObject["surveyDesignLayout"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = ExpressionConverter.ConvertO(bodysurveyConfigurationdesignConfigurationtextBlocks);
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
                    anonymizingConfigurationObject["anonymizingMode"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = ExpressionConverter.ConvertO(bodysurveyConfigurationanonymizingConfigurationlogReferer);
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

                return new ApiConnectionAction<UpdateSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateWebHook))]
        public IBodyWorkflowAction<UpdateWebHookResponse> UpdateWebHook([WorkflowExpression] Func<string> bodywebHookId = null, [WorkflowExpression] Func<bodyeventTypeInput> bodyeventType = null, [WorkflowExpression] Func<string> bodyentityIdentifier = null, [WorkflowExpression] Func<string> bodysecurityToken = null, [WorkflowExpression] Func<string> bodywebHookUrl = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UpdateWebHookResponse> __BuildUpdateWebHook(WorkflowExpression<string> bodywebHookId = null, WorkflowExpression<bodyeventTypeInput> bodyeventType = null, WorkflowExpression<string> bodyentityIdentifier = null, WorkflowExpression<string> bodysecurityToken = null, WorkflowExpression<string> bodywebHookUrl = null)
        {
            WorkflowExpression.Validate(bodywebHookId, nameof(bodywebHookId), required: false);
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: false);
            WorkflowExpression.Validate(bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            WorkflowExpression.Validate(bodysecurityToken, nameof(bodysecurityToken), required: false);
            WorkflowExpression.Validate(bodywebHookUrl, nameof(bodywebHookUrl), required: false);
            return new DeferredBodyAction<UpdateWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/UpdateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodywebHookId != null)
                {
                    body["webHookId"] = ExpressionConverter.ConvertO(bodywebHookId);
                    bodypropCount++;
                }

                if (bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                    bodypropCount++;
                }

                if (bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(bodyentityIdentifier);
                    bodypropCount++;
                }

                if (bodysecurityToken != null)
                {
                    body["securityToken"] = ExpressionConverter.ConvertO(bodysecurityToken);
                    bodypropCount++;
                }

                if (bodywebHookUrl != null)
                {
                    body["webHookUrl"] = ExpressionConverter.ConvertO(bodywebHookUrl);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [WorkflowExpressionFactory(nameof(__BuildWriteOptOutList))]
        public IBodyWorkflowAction<WriteOptOutListResponse> WriteOptOutList([WorkflowExpression] Func<int> bodyworkspaceId = null, [WorkflowExpression] Func<int> bodypanelId = null, [WorkflowExpression] Func<int> bodydistributorId = null, [WorkflowExpression] Func<EmailItem[]> bodyemails = null, [WorkflowExpression] Func<CellPhoneItem[]> bodycellPhones = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WriteOptOutListResponse> __BuildWriteOptOutList(WorkflowExpression<int> bodyworkspaceId = null, WorkflowExpression<int> bodypanelId = null, WorkflowExpression<int> bodydistributorId = null, WorkflowExpression<EmailItem[]> bodyemails = null, WorkflowExpression<CellPhoneItem[]> bodycellPhones = null)
        {
            WorkflowExpression.Validate(bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            WorkflowExpression.Validate(bodypanelId, nameof(bodypanelId), required: false);
            WorkflowExpression.Validate(bodydistributorId, nameof(bodydistributorId), required: false);
            WorkflowExpression.Validate(bodyemails, nameof(bodyemails), required: false);
            WorkflowExpression.Validate(bodycellPhones, nameof(bodycellPhones), required: false);
            return new DeferredBodyAction<WriteOptOutListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/WriteOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(bodyworkspaceId);
                    bodypropCount++;
                }

                if (bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(bodypanelId);
                    bodypropCount++;
                }

                if (bodydistributorId != null)
                {
                    body["distributorId"] = ExpressionConverter.ConvertO(bodydistributorId);
                    bodypropCount++;
                }

                if (bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(bodyemails);
                    bodypropCount++;
                }

                if (bodycellPhones != null)
                {
                    body["cellPhones"] = ExpressionConverter.ConvertO(bodycellPhones);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WriteOptOutListResponse>(callPayload);
            });
        }
    }

    public class SurvalyzerswissTriggers([ConnectionName] string connectionId)
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum Conjunction
    {
        Invalid,
        And,
        Or
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ColumnType
    {
        Invalid,
        Single,
        Multiple
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ActionType
    {
        Invalid,
        ShowEndOfSurveyText,
        ForwardToUrl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ValueAssignmentType
    {
        Invalid,
        Custom,
        Panel,
        Survey,
        Credit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ExecutionBehavior
    {
        Invalid,
        AnyTime,
        FirstTime,
        EachTime,
        SurveyLoad
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ApiCallMethod
    {
        Invalid,
        Get,
        Post
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ScriptType
    {
        Invalid,
        JavaScript,
        Css
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysurveyDefinitiondataAccessControlaccessTypeInput
    {
        Private,
        Conditional,
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysurveyDefinitioncodeAccessModeInput
    {
        None,
        StrongUsernamePassword,
        StrongAccessCode,
        WeakUsernamePassword,
        WeakAccessCode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput
    {
        M,
        S,
        L,
        Xl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum BounceType
    {
        Invalid,
        Hard,
        Soft,
        Spam
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum InvitationType
    {
        Invalid,
        Invitation,
        Reminder
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyinvitationTypeInput
    {
        Invalid,
        Invitation,
        Reminder
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccessType
    {
        Private,
        Conditional,
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CodeAccessMode
    {
        None,
        StrongUsernamePassword,
        StrongAccessCode,
        WeakUsernamePassword,
        WeakAccessCode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzerswiss;

    public partial class WorkflowManagedActions
    {
        public SurvalyzerswissActions Survalyzerswiss(string connectionId) => new SurvalyzerswissActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SurvalyzerswissTriggers Survalyzerswiss(string connectionId) => new SurvalyzerswissTriggers(connectionId);
    }
}