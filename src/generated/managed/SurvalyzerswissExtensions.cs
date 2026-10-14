//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzerswiss
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class SurvalyzerswissActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<CreateAndInviteMembersResponse> CreateAndInviteMembers(Expression<Func<int>> bodysurveyId, Expression<Func<int>> bodypanelId, Expression<Func<int>> bodymessageTemplateId, Expression<Func<Member[]>> bodymembers, Expression<Func<int>> bodysamplingProjectId = null, Expression<Func<bodychannelInput>> bodychannel = null, Expression<Func<TextBlock[]>> bodytextBlocks = null, Expression<Func<string>> bodyscheduleDateTime = null, Expression<Func<bool>> bodyasyncProcess = null, Expression<Func<string>> bodyinterviewExpiryDate = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodyreplyToName = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodymessageTemplateId = bodymessageTemplateId == null ? null : WorkflowExpression.Compile(bodymessageTemplateId);
            WorkflowExpression.Validate(__workflow_bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: true);
            var __workflow_bodysamplingProjectId = bodysamplingProjectId == null ? null : WorkflowExpression.Compile(bodysamplingProjectId);
            WorkflowExpression.Validate(__workflow_bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            var __workflow_bodychannel = bodychannel == null ? null : WorkflowExpression.Compile(bodychannel);
            WorkflowExpression.Validate(__workflow_bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodytextBlocks = bodytextBlocks == null ? null : WorkflowExpression.Compile(bodytextBlocks);
            WorkflowExpression.Validate(__workflow_bodytextBlocks, nameof(bodytextBlocks), required: false);
            var __workflow_bodyscheduleDateTime = bodyscheduleDateTime == null ? null : WorkflowExpression.Compile(bodyscheduleDateTime);
            WorkflowExpression.Validate(__workflow_bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            var __workflow_bodyasyncProcess = bodyasyncProcess == null ? null : WorkflowExpression.Compile(bodyasyncProcess);
            WorkflowExpression.Validate(__workflow_bodyasyncProcess, nameof(bodyasyncProcess), required: false);
            var __workflow_bodyinterviewExpiryDate = bodyinterviewExpiryDate == null ? null : WorkflowExpression.Compile(bodyinterviewExpiryDate);
            WorkflowExpression.Validate(__workflow_bodyinterviewExpiryDate, nameof(bodyinterviewExpiryDate), required: false);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyfromName = bodyfromName == null ? null : WorkflowExpression.Compile(bodyfromName);
            WorkflowExpression.Validate(__workflow_bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodyreplyToName = bodyreplyToName == null ? null : WorkflowExpression.Compile(bodyreplyToName);
            WorkflowExpression.Validate(__workflow_bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<CreateAndInviteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/CreateAndInviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(__workflow_bodysamplingProjectId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                if (__workflow_bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodymessageTemplateId);
                if (__workflow_bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                if (__workflow_bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyasyncProcess != null)
                {
                    body["asyncProcess"] = ExpressionConverter.ConvertO(__workflow_bodyasyncProcess);
                    bodypropCount++;
                }

                if (__workflow_bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

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

                if (__workflow_bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToName);
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
        public IBodyWorkflowAction<CreateArtifactResponse> CreateArtifact(Expression<Func<int>> bodyworkspaceId = null, Expression<Func<string>> bodypath = null)
        {
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodypath = bodypath == null ? null : WorkflowExpression.Compile(bodypath);
            WorkflowExpression.Validate(__workflow_bodypath, nameof(bodypath), required: false);
            return new DeferredBodyAction<CreateArtifactResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/CreateArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
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
        public IBodyWorkflowAction<CreateMembersResponse> CreateMembers(Expression<Func<int>> bodypanelId, Expression<Func<Member[]>> bodymembers, Expression<Func<string>> bodytenant = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<CreateMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<CreatePanelResponse> CreatePanel(Expression<Func<int>> bodyworkspaceId, Expression<Func<string>> bodyname, Expression<Func<bodypanelTypeInput>> bodypanelType = null)
        {
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodypanelType = bodypanelType == null ? null : WorkflowExpression.Compile(bodypanelType);
            WorkflowExpression.Validate(__workflow_bodypanelType, nameof(bodypanelType), required: false);
            return new DeferredBodyAction<CreatePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                if (__workflow_bodypanelType != null)
                {
                    body["panelType"] = ExpressionConverter.ConvertO(__workflow_bodypanelType);
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
        public IBodyWorkflowAction<CreateSurveyResponse> CreateSurvey(Expression<Func<int>> bodyworkspaceId, Expression<Func<string>> bodyname, Expression<Func<bool>> bodysurveyDefinitionallowMultipleParticipation, Expression<Func<bool>> bodysurveyDefinitionallowNavigateBack, Expression<Func<bool>> bodysurveyDefinitionrandomizeSections, Expression<Func<string>> bodysurveyDefinitiondefaultLanguage, Expression<Func<string[]>> bodysurveyDefinitionlanguages, Expression<Func<Section[]>> bodysurveyDefinitionsections, Expression<Func<CustomVariable[]>> bodysurveyDefinitioncustomVariables, Expression<Func<TranslationElement[]>> bodysurveyDefinitionsurveyEndText, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogIp, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogReferer, Expression<Func<bool>> bodysurveyDefinitionallowSaveProgress = null, Expression<Func<bool>> bodysurveyDefinitionenableAutoScroll = null, Expression<Func<bool>> bodysurveyDefinitionenableCodeAccess = null, Expression<Func<bodysurveyDefinitiondataAccessControlaccessTypeInput>> bodysurveyDefinitiondataAccessControlaccessType = null, Expression<Func<Condition[]>> bodysurveyDefinitiondataAccessControlconditions = null, Expression<Func<int[]>> bodysurveyDefinitionassociatedPanels = null, Expression<Func<bodysurveyDefinitioncodeAccessModeInput>> bodysurveyDefinitioncodeAccessMode = null, Expression<Func<bool>> bodysurveyDefinitionenablePanelSync = null, Expression<Func<bodysurveyDefinitionpanelSyncBehaviourInput>> bodysurveyDefinitionpanelSyncBehaviour = null, Expression<Func<PanelSyncElement[]>> bodysurveyDefinitionpanelSyncs = null, Expression<Func<string>> bodysurveyDefinitionendDate = null, Expression<Func<int>> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, Expression<Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput>> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, Expression<Func<TextBlock[]>> bodysurveyConfigurationdesignConfigurationtextBlocks = null, Expression<Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput>> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodyname = bodyname == null ? null : WorkflowExpression.Compile(bodyname);
            WorkflowExpression.Validate(__workflow_bodyname, nameof(bodyname), required: true);
            var __workflow_bodysurveyDefinitionallowMultipleParticipation = bodysurveyDefinitionallowMultipleParticipation == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowMultipleParticipation);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowMultipleParticipation, nameof(bodysurveyDefinitionallowMultipleParticipation), required: true);
            var __workflow_bodysurveyDefinitionallowNavigateBack = bodysurveyDefinitionallowNavigateBack == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowNavigateBack);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowNavigateBack, nameof(bodysurveyDefinitionallowNavigateBack), required: true);
            var __workflow_bodysurveyDefinitionrandomizeSections = bodysurveyDefinitionrandomizeSections == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionrandomizeSections);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionrandomizeSections, nameof(bodysurveyDefinitionrandomizeSections), required: true);
            var __workflow_bodysurveyDefinitiondefaultLanguage = bodysurveyDefinitiondefaultLanguage == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondefaultLanguage);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondefaultLanguage, nameof(bodysurveyDefinitiondefaultLanguage), required: true);
            var __workflow_bodysurveyDefinitionlanguages = bodysurveyDefinitionlanguages == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionlanguages);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionlanguages, nameof(bodysurveyDefinitionlanguages), required: true);
            var __workflow_bodysurveyDefinitionsections = bodysurveyDefinitionsections == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionsections);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionsections, nameof(bodysurveyDefinitionsections), required: true);
            var __workflow_bodysurveyDefinitioncustomVariables = bodysurveyDefinitioncustomVariables == null ? null : WorkflowExpression.Compile(bodysurveyDefinitioncustomVariables);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitioncustomVariables, nameof(bodysurveyDefinitioncustomVariables), required: true);
            var __workflow_bodysurveyDefinitionsurveyEndText = bodysurveyDefinitionsurveyEndText == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionsurveyEndText);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionsurveyEndText, nameof(bodysurveyDefinitionsurveyEndText), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogIp = bodysurveyConfigurationanonymizingConfigurationlogIp == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogIp);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogIp, nameof(bodysurveyConfigurationanonymizingConfigurationlogIp), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent = bodysurveyConfigurationanonymizingConfigurationlogUserAgent == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent, nameof(bodysurveyConfigurationanonymizingConfigurationlogUserAgent), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer = bodysurveyConfigurationanonymizingConfigurationlogReferer == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogReferer);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer, nameof(bodysurveyConfigurationanonymizingConfigurationlogReferer), required: true);
            var __workflow_bodysurveyDefinitionallowSaveProgress = bodysurveyDefinitionallowSaveProgress == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowSaveProgress);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowSaveProgress, nameof(bodysurveyDefinitionallowSaveProgress), required: false);
            var __workflow_bodysurveyDefinitionenableAutoScroll = bodysurveyDefinitionenableAutoScroll == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenableAutoScroll);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenableAutoScroll, nameof(bodysurveyDefinitionenableAutoScroll), required: false);
            var __workflow_bodysurveyDefinitionenableCodeAccess = bodysurveyDefinitionenableCodeAccess == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenableCodeAccess);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenableCodeAccess, nameof(bodysurveyDefinitionenableCodeAccess), required: false);
            var __workflow_bodysurveyDefinitiondataAccessControlaccessType = bodysurveyDefinitiondataAccessControlaccessType == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondataAccessControlaccessType);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondataAccessControlaccessType, nameof(bodysurveyDefinitiondataAccessControlaccessType), required: false);
            var __workflow_bodysurveyDefinitiondataAccessControlconditions = bodysurveyDefinitiondataAccessControlconditions == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondataAccessControlconditions);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondataAccessControlconditions, nameof(bodysurveyDefinitiondataAccessControlconditions), required: false);
            var __workflow_bodysurveyDefinitionassociatedPanels = bodysurveyDefinitionassociatedPanels == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionassociatedPanels);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionassociatedPanels, nameof(bodysurveyDefinitionassociatedPanels), required: false);
            var __workflow_bodysurveyDefinitioncodeAccessMode = bodysurveyDefinitioncodeAccessMode == null ? null : WorkflowExpression.Compile(bodysurveyDefinitioncodeAccessMode);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitioncodeAccessMode, nameof(bodysurveyDefinitioncodeAccessMode), required: false);
            var __workflow_bodysurveyDefinitionenablePanelSync = bodysurveyDefinitionenablePanelSync == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenablePanelSync);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenablePanelSync, nameof(bodysurveyDefinitionenablePanelSync), required: false);
            var __workflow_bodysurveyDefinitionpanelSyncBehaviour = bodysurveyDefinitionpanelSyncBehaviour == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionpanelSyncBehaviour);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionpanelSyncBehaviour, nameof(bodysurveyDefinitionpanelSyncBehaviour), required: false);
            var __workflow_bodysurveyDefinitionpanelSyncs = bodysurveyDefinitionpanelSyncs == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionpanelSyncs);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionpanelSyncs, nameof(bodysurveyDefinitionpanelSyncs), required: false);
            var __workflow_bodysurveyDefinitionendDate = bodysurveyDefinitionendDate == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionendDate);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionendDate, nameof(bodysurveyDefinitionendDate), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = bodysurveyConfigurationdesignConfigurationsurveyDesignLayout == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout, nameof(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize, nameof(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationtextBlocks = bodysurveyConfigurationdesignConfigurationtextBlocks == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationtextBlocks);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks, nameof(bodysurveyConfigurationdesignConfigurationtextBlocks), required: false);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode = bodysurveyConfigurationanonymizingConfigurationanonymizingMode == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode, nameof(bodysurveyConfigurationanonymizingConfigurationanonymizingMode), required: false);
            return new DeferredBodyAction<CreateSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/CreateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                bodypropCount++;
                body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowNavigateBack);
                if (__workflow_bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionrandomizeSections);
                if (__workflow_bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (__workflow_bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondefaultLanguage);
                if (__workflow_bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionsurveyEndText);
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
                if (__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout != null)
                {
                    designConfigurationObject["surveyDesignLayout"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks);
                    designConfigurationObjectpropCount++;
                }

                if (designConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["designConfiguration"] = designConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                var anonymizingConfigurationObject = new JObject();
                var anonymizingConfigurationObjectpropCount = 0;
                if (__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode != null)
                {
                    anonymizingConfigurationObject["anonymizingMode"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer);
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
        public IBodyWorkflowAction<CreateWebHookResponse> CreateWebHook(Expression<Func<bodyeventTypeInput>> bodyeventType = null, Expression<Func<string>> bodyentityIdentifier = null, Expression<Func<string>> bodysecurityToken = null, Expression<Func<string>> bodywebHookUrl = null)
        {
            var __workflow_bodyeventType = bodyeventType == null ? null : WorkflowExpression.Compile(bodyeventType);
            WorkflowExpression.Validate(__workflow_bodyeventType, nameof(bodyeventType), required: false);
            var __workflow_bodyentityIdentifier = bodyentityIdentifier == null ? null : WorkflowExpression.Compile(bodyentityIdentifier);
            WorkflowExpression.Validate(__workflow_bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            var __workflow_bodysecurityToken = bodysecurityToken == null ? null : WorkflowExpression.Compile(bodysecurityToken);
            WorkflowExpression.Validate(__workflow_bodysecurityToken, nameof(bodysecurityToken), required: false);
            var __workflow_bodywebHookUrl = bodywebHookUrl == null ? null : WorkflowExpression.Compile(bodywebHookUrl);
            WorkflowExpression.Validate(__workflow_bodywebHookUrl, nameof(bodywebHookUrl), required: false);
            return new DeferredBodyAction<CreateWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/CreateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                if (__workflow_bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(__workflow_bodyentityIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityToken != null)
                {
                    body["securityToken"] = ExpressionConverter.ConvertO(__workflow_bodysecurityToken);
                    bodypropCount++;
                }

                if (__workflow_bodywebHookUrl != null)
                {
                    body["webHookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebHookUrl);
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
        public IBodyWorkflowAction<DeleteArtifactResponse> DeleteArtifact(Expression<Func<string>> bodypath = null, Expression<Func<string>> bodyfilename = null, Expression<Func<int>> bodyworkspaceId = null)
        {
            var __workflow_bodypath = bodypath == null ? null : WorkflowExpression.Compile(bodypath);
            WorkflowExpression.Validate(__workflow_bodypath, nameof(bodypath), required: false);
            var __workflow_bodyfilename = bodyfilename == null ? null : WorkflowExpression.Compile(bodyfilename);
            WorkflowExpression.Validate(__workflow_bodyfilename, nameof(bodyfilename), required: false);
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<DeleteArtifactResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/DeleteArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                    bodypropCount++;
                }

                if (__workflow_bodyfilename != null)
                {
                    body["filename"] = ExpressionConverter.ConvertO(__workflow_bodyfilename);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
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
        public IBodyWorkflowAction<DeleteDistributorResponse> DeleteDistributor(Expression<Func<int>> bodydistributorId, Expression<Func<bool>> bodykeepInterviews = null)
        {
            var __workflow_bodydistributorId = bodydistributorId == null ? null : WorkflowExpression.Compile(bodydistributorId);
            WorkflowExpression.Validate(__workflow_bodydistributorId, nameof(bodydistributorId), required: true);
            var __workflow_bodykeepInterviews = bodykeepInterviews == null ? null : WorkflowExpression.Compile(bodykeepInterviews);
            WorkflowExpression.Validate(__workflow_bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteDistributorResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteDistributor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = ExpressionConverter.ConvertO(__workflow_bodydistributorId);
                if (__workflow_bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(__workflow_bodykeepInterviews);
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
        public IBodyWorkflowAction<DeleteInterviewResponse> DeleteInterview(Expression<Func<string>> bodyinterviewId = null, Expression<Func<int>> bodysurveyId = null)
        {
            var __workflow_bodyinterviewId = bodyinterviewId == null ? null : WorkflowExpression.Compile(bodyinterviewId);
            WorkflowExpression.Validate(__workflow_bodyinterviewId, nameof(bodyinterviewId), required: false);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            return new DeferredBodyAction<DeleteInterviewResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/DeleteInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyinterviewId != null)
                {
                    body["interviewId"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewId);
                    bodypropCount++;
                }

                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
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
        public IBodyWorkflowAction<DeleteMembersResponse> DeleteMembers(Expression<Func<int>> bodypanelId, Expression<Func<int[]>> bodypanelMembersIds, Expression<Func<bool>> bodykeepInterviews = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodypanelMembersIds = bodypanelMembersIds == null ? null : WorkflowExpression.Compile(bodypanelMembersIds);
            WorkflowExpression.Validate(__workflow_bodypanelMembersIds, nameof(bodypanelMembersIds), required: true);
            var __workflow_bodykeepInterviews = bodykeepInterviews == null ? null : WorkflowExpression.Compile(bodykeepInterviews);
            WorkflowExpression.Validate(__workflow_bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeleteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                bodypropCount++;
                body["panelMembersIds"] = ExpressionConverter.ConvertO(__workflow_bodypanelMembersIds);
                if (__workflow_bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(__workflow_bodykeepInterviews);
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
        public IBodyWorkflowAction<DeletePanelResponse> DeletePanel(Expression<Func<int>> bodypanelId, Expression<Func<bool>> bodykeepInterviews = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodykeepInterviews = bodykeepInterviews == null ? null : WorkflowExpression.Compile(bodykeepInterviews);
            WorkflowExpression.Validate(__workflow_bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeletePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeletePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                if (__workflow_bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(__workflow_bodykeepInterviews);
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
        public IBodyWorkflowAction<DeleteSamplingProjectResponse> DeleteSamplingProject(Expression<Func<int>> bodysamplingProjectId = null, Expression<Func<bool>> bodykeepInterviews = null)
        {
            var __workflow_bodysamplingProjectId = bodysamplingProjectId == null ? null : WorkflowExpression.Compile(bodysamplingProjectId);
            WorkflowExpression.Validate(__workflow_bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            var __workflow_bodykeepInterviews = bodykeepInterviews == null ? null : WorkflowExpression.Compile(bodykeepInterviews);
            WorkflowExpression.Validate(__workflow_bodykeepInterviews, nameof(bodykeepInterviews), required: false);
            return new DeferredBodyAction<DeleteSamplingProjectResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(__workflow_bodysamplingProjectId);
                    bodypropCount++;
                }

                if (__workflow_bodykeepInterviews != null)
                {
                    body["keepInterviews"] = ExpressionConverter.ConvertO(__workflow_bodykeepInterviews);
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
        public IBodyWorkflowAction<DeleteSurveyResponse> DeleteSurvey(Expression<Func<int>> bodysurveyId)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            return new DeferredBodyAction<DeleteSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/DeleteSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<DeleteSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<DeleteWebHookResponse> DeleteWebHook(Expression<Func<string>> bodywebHookId = null)
        {
            var __workflow_bodywebHookId = bodywebHookId == null ? null : WorkflowExpression.Compile(bodywebHookId);
            WorkflowExpression.Validate(__workflow_bodywebHookId, nameof(bodywebHookId), required: false);
            return new DeferredBodyAction<DeleteWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/DeleteWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodywebHookId != null)
                {
                    body["webHookId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookId);
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
        public IBodyWorkflowAction<DownloadAnswersResponse> DownloadInterviewPdf(Expression<Func<string>> tenant, Expression<Func<int>> surveyId, Expression<Func<string>> interviewId, Expression<Func<bool>> showPartialCompleted = null, Expression<Func<string>> locale = null, Expression<Func<string>> timeZone = null, Expression<Func<bool>> bodyisCancellationRequested = null, Expression<Func<bool>> bodycanBeCanceled = null, Expression<Func<bool>> bodywaitHandlesafeWaitHandleisInvalid = null, Expression<Func<bool>> bodywaitHandlesafeWaitHandleisClosed = null)
        {
            var __workflow_tenant = tenant == null ? null : WorkflowExpression.Compile(tenant);
            WorkflowExpression.Validate(__workflow_tenant, nameof(tenant), required: true);
            var __workflow_surveyId = surveyId == null ? null : WorkflowExpression.Compile(surveyId);
            WorkflowExpression.Validate(__workflow_surveyId, nameof(surveyId), required: true);
            var __workflow_interviewId = interviewId == null ? null : WorkflowExpression.Compile(interviewId);
            WorkflowExpression.Validate(__workflow_interviewId, nameof(interviewId), required: true);
            var __workflow_showPartialCompleted = showPartialCompleted == null ? null : WorkflowExpression.Compile(showPartialCompleted);
            WorkflowExpression.Validate(__workflow_showPartialCompleted, nameof(showPartialCompleted), required: false);
            var __workflow_locale = locale == null ? null : WorkflowExpression.Compile(locale);
            WorkflowExpression.Validate(__workflow_locale, nameof(locale), required: false);
            var __workflow_timeZone = timeZone == null ? null : WorkflowExpression.Compile(timeZone);
            WorkflowExpression.Validate(__workflow_timeZone, nameof(timeZone), required: false);
            var __workflow_bodyisCancellationRequested = bodyisCancellationRequested == null ? null : WorkflowExpression.Compile(bodyisCancellationRequested);
            WorkflowExpression.Validate(__workflow_bodyisCancellationRequested, nameof(bodyisCancellationRequested), required: false);
            var __workflow_bodycanBeCanceled = bodycanBeCanceled == null ? null : WorkflowExpression.Compile(bodycanBeCanceled);
            WorkflowExpression.Validate(__workflow_bodycanBeCanceled, nameof(bodycanBeCanceled), required: false);
            var __workflow_bodywaitHandlesafeWaitHandleisInvalid = bodywaitHandlesafeWaitHandleisInvalid == null ? null : WorkflowExpression.Compile(bodywaitHandlesafeWaitHandleisInvalid);
            WorkflowExpression.Validate(__workflow_bodywaitHandlesafeWaitHandleisInvalid, nameof(bodywaitHandlesafeWaitHandleisInvalid), required: false);
            var __workflow_bodywaitHandlesafeWaitHandleisClosed = bodywaitHandlesafeWaitHandleisClosed == null ? null : WorkflowExpression.Compile(bodywaitHandlesafeWaitHandleisClosed);
            WorkflowExpression.Validate(__workflow_bodywaitHandlesafeWaitHandleisClosed, nameof(bodywaitHandlesafeWaitHandleisClosed), required: false);
            return new DeferredBodyAction<DownloadAnswersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/DownloadAnswers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["tenant"] = ExpressionConverter.Convert(__workflow_tenant);
                callPayload.Queries["surveyId"] = ExpressionConverter.Convert(__workflow_surveyId);
                callPayload.Queries["interviewId"] = ExpressionConverter.Convert(__workflow_interviewId);
                if (__workflow_showPartialCompleted != null)
                    callPayload.Queries["showPartialCompleted"] = ExpressionConverter.Convert(__workflow_showPartialCompleted);
                if (__workflow_locale != null)
                    callPayload.Queries["locale"] = ExpressionConverter.Convert(__workflow_locale);
                if (__workflow_timeZone != null)
                    callPayload.Queries["timeZone"] = ExpressionConverter.Convert(__workflow_timeZone);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyisCancellationRequested != null)
                {
                    body["isCancellationRequested"] = ExpressionConverter.ConvertO(__workflow_bodyisCancellationRequested);
                    bodypropCount++;
                }

                if (__workflow_bodycanBeCanceled != null)
                {
                    body["canBeCanceled"] = ExpressionConverter.ConvertO(__workflow_bodycanBeCanceled);
                    bodypropCount++;
                }

                var waitHandleObject = new JObject();
                var waitHandleObjectpropCount = 0;
                var safeWaitHandleObject = new JObject();
                var safeWaitHandleObjectpropCount = 0;
                if (__workflow_bodywaitHandlesafeWaitHandleisInvalid != null)
                {
                    safeWaitHandleObject["isInvalid"] = ExpressionConverter.ConvertO(__workflow_bodywaitHandlesafeWaitHandleisInvalid);
                    safeWaitHandleObjectpropCount++;
                }

                if (__workflow_bodywaitHandlesafeWaitHandleisClosed != null)
                {
                    safeWaitHandleObject["isClosed"] = ExpressionConverter.ConvertO(__workflow_bodywaitHandlesafeWaitHandleisClosed);
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
        public IBodyWorkflowAction<ExecuteSendMailResponse> ExecuteSendMail(Expression<Func<string>> bodylanguage, Expression<Func<string>> bodyfrom, Expression<Func<string>> bodyto, Expression<Func<int>> bodymessageTemplateId = null, Expression<Func<TextBlock[]>> bodytextBlocks = null, Expression<Func<string>> bodysubject = null, Expression<Func<string>> bodybody = null, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodytoName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodyreplyToName = null)
        {
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: true);
            var __workflow_bodyto = bodyto == null ? null : WorkflowExpression.Compile(bodyto);
            WorkflowExpression.Validate(__workflow_bodyto, nameof(bodyto), required: true);
            var __workflow_bodymessageTemplateId = bodymessageTemplateId == null ? null : WorkflowExpression.Compile(bodymessageTemplateId);
            WorkflowExpression.Validate(__workflow_bodymessageTemplateId, nameof(bodymessageTemplateId), required: false);
            var __workflow_bodytextBlocks = bodytextBlocks == null ? null : WorkflowExpression.Compile(bodytextBlocks);
            WorkflowExpression.Validate(__workflow_bodytextBlocks, nameof(bodytextBlocks), required: false);
            var __workflow_bodysubject = bodysubject == null ? null : WorkflowExpression.Compile(bodysubject);
            WorkflowExpression.Validate(__workflow_bodysubject, nameof(bodysubject), required: false);
            var __workflow_bodybody = bodybody == null ? null : WorkflowExpression.Compile(bodybody);
            WorkflowExpression.Validate(__workflow_bodybody, nameof(bodybody), required: false);
            var __workflow_bodyfromName = bodyfromName == null ? null : WorkflowExpression.Compile(bodyfromName);
            WorkflowExpression.Validate(__workflow_bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodytoName = bodytoName == null ? null : WorkflowExpression.Compile(bodytoName);
            WorkflowExpression.Validate(__workflow_bodytoName, nameof(bodytoName), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodyreplyToName = bodyreplyToName == null ? null : WorkflowExpression.Compile(bodyreplyToName);
            WorkflowExpression.Validate(__workflow_bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<ExecuteSendMailResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteSendMail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodymessageTemplateId != null)
                {
                    body["messageTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodymessageTemplateId);
                    bodypropCount++;
                }

                if (__workflow_bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodytextBlocks);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                if (__workflow_bodysubject != null)
                {
                    body["subject"] = ExpressionConverter.ConvertO(__workflow_bodysubject);
                    bodypropCount++;
                }

                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                bodypropCount++;
                body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                if (__workflow_bodyfromName != null)
                {
                    body["fromName"] = ExpressionConverter.ConvertO(__workflow_bodyfromName);
                    bodypropCount++;
                }

                bodypropCount++;
                body["to"] = ExpressionConverter.ConvertO(__workflow_bodyto);
                if (__workflow_bodytoName != null)
                {
                    body["toName"] = ExpressionConverter.ConvertO(__workflow_bodytoName);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyTo != null)
                {
                    body["replyTo"] = ExpressionConverter.ConvertO(__workflow_bodyreplyTo);
                    bodypropCount++;
                }

                if (__workflow_bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToName);
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
        public IBodyWorkflowAction<ExecuteWorkflowTransitionResponse> ExecuteWorkflowTransition(Expression<Func<string>> bodytargetState, Expression<Func<bodyworkflowInput>> bodyworkflow = null, Expression<Func<int>> bodysurveyId = null, Expression<Func<int>> bodysamplingProjectId = null, Expression<Func<int>> bodydistributorId = null, Expression<Func<int>> bodyreminderId = null)
        {
            var __workflow_bodytargetState = bodytargetState == null ? null : WorkflowExpression.Compile(bodytargetState);
            WorkflowExpression.Validate(__workflow_bodytargetState, nameof(bodytargetState), required: true);
            var __workflow_bodyworkflow = bodyworkflow == null ? null : WorkflowExpression.Compile(bodyworkflow);
            WorkflowExpression.Validate(__workflow_bodyworkflow, nameof(bodyworkflow), required: false);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            var __workflow_bodysamplingProjectId = bodysamplingProjectId == null ? null : WorkflowExpression.Compile(bodysamplingProjectId);
            WorkflowExpression.Validate(__workflow_bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            var __workflow_bodydistributorId = bodydistributorId == null ? null : WorkflowExpression.Compile(bodydistributorId);
            WorkflowExpression.Validate(__workflow_bodydistributorId, nameof(bodydistributorId), required: false);
            var __workflow_bodyreminderId = bodyreminderId == null ? null : WorkflowExpression.Compile(bodyreminderId);
            WorkflowExpression.Validate(__workflow_bodyreminderId, nameof(bodyreminderId), required: false);
            return new DeferredBodyAction<ExecuteWorkflowTransitionResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteWorkflowTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkflow != null)
                {
                    body["workflow"] = ExpressionConverter.ConvertO(__workflow_bodyworkflow);
                    bodypropCount++;
                }

                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                    bodypropCount++;
                }

                if (__workflow_bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(__workflow_bodysamplingProjectId);
                    bodypropCount++;
                }

                if (__workflow_bodydistributorId != null)
                {
                    body["distributorId"] = ExpressionConverter.ConvertO(__workflow_bodydistributorId);
                    bodypropCount++;
                }

                if (__workflow_bodyreminderId != null)
                {
                    body["reminderId"] = ExpressionConverter.ConvertO(__workflow_bodyreminderId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["targetState"] = ExpressionConverter.ConvertO(__workflow_bodytargetState);
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
        public IBodyWorkflowAction<InviteMembersResponse> InviteMembers(Expression<Func<int>> bodysurveyId, Expression<Func<int>> bodypanelId, Expression<Func<int>> bodymessageTemplateId, Expression<Func<int>> bodysamplingProjectId = null, Expression<Func<int[]>> bodymemberIds = null, Expression<Func<TextBlock[]>> bodytextBlocks = null, Expression<Func<string>> bodyscheduleDateTime = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<bodychannelInput>> bodychannel = null, Expression<Func<bool>> bodyasyncProcess = null, Expression<Func<string>> bodyinterviewExpiryDate = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodyreplyToName = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodymessageTemplateId = bodymessageTemplateId == null ? null : WorkflowExpression.Compile(bodymessageTemplateId);
            WorkflowExpression.Validate(__workflow_bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            var __workflow_bodysamplingProjectId = bodysamplingProjectId == null ? null : WorkflowExpression.Compile(bodysamplingProjectId);
            WorkflowExpression.Validate(__workflow_bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            var __workflow_bodymemberIds = bodymemberIds == null ? null : WorkflowExpression.Compile(bodymemberIds);
            WorkflowExpression.Validate(__workflow_bodymemberIds, nameof(bodymemberIds), required: false);
            var __workflow_bodytextBlocks = bodytextBlocks == null ? null : WorkflowExpression.Compile(bodytextBlocks);
            WorkflowExpression.Validate(__workflow_bodytextBlocks, nameof(bodytextBlocks), required: false);
            var __workflow_bodyscheduleDateTime = bodyscheduleDateTime == null ? null : WorkflowExpression.Compile(bodyscheduleDateTime);
            WorkflowExpression.Validate(__workflow_bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodychannel = bodychannel == null ? null : WorkflowExpression.Compile(bodychannel);
            WorkflowExpression.Validate(__workflow_bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodyasyncProcess = bodyasyncProcess == null ? null : WorkflowExpression.Compile(bodyasyncProcess);
            WorkflowExpression.Validate(__workflow_bodyasyncProcess, nameof(bodyasyncProcess), required: false);
            var __workflow_bodyinterviewExpiryDate = bodyinterviewExpiryDate == null ? null : WorkflowExpression.Compile(bodyinterviewExpiryDate);
            WorkflowExpression.Validate(__workflow_bodyinterviewExpiryDate, nameof(bodyinterviewExpiryDate), required: false);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyfromName = bodyfromName == null ? null : WorkflowExpression.Compile(bodyfromName);
            WorkflowExpression.Validate(__workflow_bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodyreplyToName = bodyreplyToName == null ? null : WorkflowExpression.Compile(bodyreplyToName);
            WorkflowExpression.Validate(__workflow_bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<InviteMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/InviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                if (__workflow_bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(__workflow_bodysamplingProjectId);
                    bodypropCount++;
                }

                if (__workflow_bodymemberIds != null)
                {
                    body["memberIds"] = ExpressionConverter.ConvertO(__workflow_bodymemberIds);
                    bodypropCount++;
                }

                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodymessageTemplateId);
                if (__workflow_bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodytextBlocks);
                    bodypropCount++;
                }

                if (__workflow_bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                if (__workflow_bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                    bodypropCount++;
                }

                if (__workflow_bodyasyncProcess != null)
                {
                    body["asyncProcess"] = ExpressionConverter.ConvertO(__workflow_bodyasyncProcess);
                    bodypropCount++;
                }

                if (__workflow_bodyinterviewExpiryDate != null)
                {
                    body["interviewExpiryDate"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewExpiryDate);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

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

                if (__workflow_bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToName);
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
        public IBodyWorkflowAction<ReadArtifactListRequest> ReadArtifactList(Expression<Func<string>> bodypath = null, Expression<Func<int>> bodyworkspaceId = null)
        {
            var __workflow_bodypath = bodypath == null ? null : WorkflowExpression.Compile(bodypath);
            WorkflowExpression.Validate(__workflow_bodypath, nameof(bodypath), required: false);
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            return new DeferredBodyAction<ReadArtifactListRequest>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadArtifactList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypath != null)
                {
                    body["path"] = ExpressionConverter.ConvertO(__workflow_bodypath);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
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
        public IBodyWorkflowAction<ReadBounceListResponseV3> ReadBounceList(Expression<Func<int>> bodysurveyId, Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<int>> bodypanelId = null, Expression<Func<int[]>> bodydistributors = null, Expression<Func<bodyinvitationTypeInput>> bodyinvitationType = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: false);
            var __workflow_bodydistributors = bodydistributors == null ? null : WorkflowExpression.Compile(bodydistributors);
            WorkflowExpression.Validate(__workflow_bodydistributors, nameof(bodydistributors), required: false);
            var __workflow_bodyinvitationType = bodyinvitationType == null ? null : WorkflowExpression.Compile(bodyinvitationType);
            WorkflowExpression.Validate(__workflow_bodyinvitationType, nameof(bodyinvitationType), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadBounceListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadBounceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                if (__workflow_bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                    bodypropCount++;
                }

                if (__workflow_bodydistributors != null)
                {
                    body["distributors"] = ExpressionConverter.ConvertO(__workflow_bodydistributors);
                    bodypropCount++;
                }

                if (__workflow_bodyinvitationType != null)
                {
                    body["invitationType"] = ExpressionConverter.ConvertO(__workflow_bodyinvitationType);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadDistributorListResponse> ReadDistributorList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<int>> bodysurveyId = null, Expression<Func<int>> bodypanelId = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadDistributorListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadDistributorList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                    bodypropCount++;
                }

                if (__workflow_bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadIncentiveListResponse> ReadIncentiveList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadIncentiveListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadIncentiveTransactionListResponse> ReadIncentiveTransactionList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadIncentiveTransactionListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveTransactionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadInterviewDataResponse> ReadInterview(Expression<Func<string>> bodytenant, Expression<Func<string>> bodyinterviewId, Expression<Func<int>> bodysurveyId, Expression<Func<bool>> bodyloadSurveyDefinition = null)
        {
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: true);
            var __workflow_bodyinterviewId = bodyinterviewId == null ? null : WorkflowExpression.Compile(bodyinterviewId);
            WorkflowExpression.Validate(__workflow_bodyinterviewId, nameof(bodyinterviewId), required: true);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodyloadSurveyDefinition = bodyloadSurveyDefinition == null ? null : WorkflowExpression.Compile(bodyloadSurveyDefinition);
            WorkflowExpression.Validate(__workflow_bodyloadSurveyDefinition, nameof(bodyloadSurveyDefinition), required: false);
            return new DeferredBodyAction<ReadInterviewDataResponse>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                bodypropCount++;
                body["interviewId"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewId);
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                if (__workflow_bodyloadSurveyDefinition != null)
                {
                    body["loadSurveyDefinition"] = ExpressionConverter.ConvertO(__workflow_bodyloadSurveyDefinition);
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
        public IBodyWorkflowAction<ReadInterviewListCompactResponseV3> ReadInterviewListCompact(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<string>> bodytenant = null, Expression<Func<int>> bodysurveyId = null, Expression<Func<string[]>> bodyfieldsToDownload = null, Expression<Func<bool>> bodyloadCodePlan = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            var __workflow_bodyfieldsToDownload = bodyfieldsToDownload == null ? null : WorkflowExpression.Compile(bodyfieldsToDownload);
            WorkflowExpression.Validate(__workflow_bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            var __workflow_bodyloadCodePlan = bodyloadCodePlan == null ? null : WorkflowExpression.Compile(bodyloadCodePlan);
            WorkflowExpression.Validate(__workflow_bodyloadCodePlan, nameof(bodyloadCodePlan), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadInterviewListCompactResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewListCompact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (__workflow_bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = ExpressionConverter.ConvertO(__workflow_bodyloadCodePlan);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadInterviewListResponseV3> ReadInterviewList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<string>> bodytenant = null, Expression<Func<int>> bodysurveyId = null, Expression<Func<string[]>> bodyfieldsToDownload = null, Expression<Func<bool>> bodyloadCodePlan = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            var __workflow_bodyfieldsToDownload = bodyfieldsToDownload == null ? null : WorkflowExpression.Compile(bodyfieldsToDownload);
            WorkflowExpression.Validate(__workflow_bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            var __workflow_bodyloadCodePlan = bodyloadCodePlan == null ? null : WorkflowExpression.Compile(bodyloadCodePlan);
            WorkflowExpression.Validate(__workflow_bodyloadCodePlan, nameof(bodyloadCodePlan), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadInterviewListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (__workflow_bodyloadCodePlan != null)
                {
                    body["loadCodePlan"] = ExpressionConverter.ConvertO(__workflow_bodyloadCodePlan);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadMemberListResponse> ReadMemberList(Expression<Func<int>> bodypanelId, Expression<Func<bool>> bodyinterviewsRequired, Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<string>> bodytenant = null, Expression<Func<string[]>> bodyfieldsToDownload = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodyinterviewsRequired = bodyinterviewsRequired == null ? null : WorkflowExpression.Compile(bodyinterviewsRequired);
            WorkflowExpression.Validate(__workflow_bodyinterviewsRequired, nameof(bodyinterviewsRequired), required: true);
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            var __workflow_bodyfieldsToDownload = bodyfieldsToDownload == null ? null : WorkflowExpression.Compile(bodyfieldsToDownload);
            WorkflowExpression.Validate(__workflow_bodyfieldsToDownload, nameof(bodyfieldsToDownload), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadMemberListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadMemberList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                bodypropCount++;
                body["interviewsRequired"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewsRequired);
                if (__workflow_bodyfieldsToDownload != null)
                {
                    body["fieldsToDownload"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsToDownload);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadMessageTemplateListResponse> ReadMessageTemplateList(Expression<Func<string>> bodylanguage, Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<int>> bodyworkspaceId = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodylanguage = bodylanguage == null ? null : WorkflowExpression.Compile(bodylanguage);
            WorkflowExpression.Validate(__workflow_bodylanguage, nameof(bodylanguage), required: true);
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadMessageTemplateListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadMessageTemplateList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["language"] = ExpressionConverter.ConvertO(__workflow_bodylanguage);
                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadOptOutListResponseV3> ReadOptOutList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<int>> bodypanelId = null, Expression<Func<int>> bodyworkspaceId = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: false);
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadOptOutListResponseV3>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                    bodypropCount++;
                }

                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadPanelDefinitionResponse> ReadPanel(Expression<Func<int>> bodypanelId, Expression<Func<string>> bodytenant = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<ReadPanelDefinitionResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadPanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadPanelDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<ReadSamplingProjectResponse> ReadSamplingProject(Expression<Func<int>> bodysamplingProjectId = null)
        {
            var __workflow_bodysamplingProjectId = bodysamplingProjectId == null ? null : WorkflowExpression.Compile(bodysamplingProjectId);
            WorkflowExpression.Validate(__workflow_bodysamplingProjectId, nameof(bodysamplingProjectId), required: false);
            return new DeferredBodyAction<ReadSamplingProjectResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysamplingProjectId != null)
                {
                    body["samplingProjectId"] = ExpressionConverter.ConvertO(__workflow_bodysamplingProjectId);
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
        public IBodyWorkflowAction<ReadSurveyLinksResponse> ReadSurveyLinks(Expression<Func<int>> bodysurveyId = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            return new DeferredBodyAction<ReadSurveyLinksResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyLinks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
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
        public IBodyWorkflowAction<ReadSurveyListResponse> ReadSurveyList(Expression<Func<int>> bodyworkspaceId, Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: true);
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadSurveyListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<ReadSurveyResponse> ReadSurvey(Expression<Func<int>> bodysurveyId, Expression<Func<string>> bodytenant = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<ReadSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<ReadWebHookListResponse> ReadWebHookList(Expression<Func<bodyeventTypeInput>> bodyeventType = null, Expression<Func<string>> bodyentityIdentifier = null)
        {
            var __workflow_bodyeventType = bodyeventType == null ? null : WorkflowExpression.Compile(bodyeventType);
            WorkflowExpression.Validate(__workflow_bodyeventType, nameof(bodyeventType), required: false);
            var __workflow_bodyentityIdentifier = bodyentityIdentifier == null ? null : WorkflowExpression.Compile(bodyentityIdentifier);
            WorkflowExpression.Validate(__workflow_bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            return new DeferredBodyAction<ReadWebHookListResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/ReadWebHookList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                if (__workflow_bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(__workflow_bodyentityIdentifier);
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
        public IBodyWorkflowAction<ReadWorkflowTransitionsResponse> ReadWorkflowTransitions(Expression<Func<string>> bodycurrentState, Expression<Func<bodyworkflowInput>> bodyworkflow = null)
        {
            var __workflow_bodycurrentState = bodycurrentState == null ? null : WorkflowExpression.Compile(bodycurrentState);
            WorkflowExpression.Validate(__workflow_bodycurrentState, nameof(bodycurrentState), required: true);
            var __workflow_bodyworkflow = bodyworkflow == null ? null : WorkflowExpression.Compile(bodyworkflow);
            WorkflowExpression.Validate(__workflow_bodyworkflow, nameof(bodyworkflow), required: false);
            return new DeferredBodyAction<ReadWorkflowTransitionsResponse>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadWorkflowTransitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkflow != null)
                {
                    body["workflow"] = ExpressionConverter.ConvertO(__workflow_bodyworkflow);
                    bodypropCount++;
                }

                bodypropCount++;
                body["currentState"] = ExpressionConverter.ConvertO(__workflow_bodycurrentState);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ReadWorkflowTransitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<ReadWorkspaceListResponse> ReadWorkspaceList(Expression<Func<int>> bodypagingpageSize, Expression<Func<int>> bodypagingpage, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<string>> bodypagingorderField = null, Expression<Func<bodypagingorderDirectionInput>> bodypagingorderDirection = null)
        {
            var __workflow_bodypagingpageSize = bodypagingpageSize == null ? null : WorkflowExpression.Compile(bodypagingpageSize);
            WorkflowExpression.Validate(__workflow_bodypagingpageSize, nameof(bodypagingpageSize), required: true);
            var __workflow_bodypagingpage = bodypagingpage == null ? null : WorkflowExpression.Compile(bodypagingpage);
            WorkflowExpression.Validate(__workflow_bodypagingpage, nameof(bodypagingpage), required: true);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodypagingorderField = bodypagingorderField == null ? null : WorkflowExpression.Compile(bodypagingorderField);
            WorkflowExpression.Validate(__workflow_bodypagingorderField, nameof(bodypagingorderField), required: false);
            var __workflow_bodypagingorderDirection = bodypagingorderDirection == null ? null : WorkflowExpression.Compile(bodypagingorderDirection);
            WorkflowExpression.Validate(__workflow_bodypagingorderDirection, nameof(bodypagingorderDirection), required: false);
            return new DeferredBodyAction<ReadWorkspaceListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadWorkspaceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                pagingObjectpropCount++;
                pagingObject["pageSize"] = ExpressionConverter.ConvertO(__workflow_bodypagingpageSize);
                pagingObjectpropCount++;
                pagingObject["page"] = ExpressionConverter.ConvertO(__workflow_bodypagingpage);
                if (__workflow_bodypagingorderField != null)
                {
                    pagingObject["orderField"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderField);
                    pagingObjectpropCount++;
                }

                if (__workflow_bodypagingorderDirection != null)
                {
                    pagingObject["orderDirection"] = ExpressionConverter.ConvertO(__workflow_bodypagingorderDirection);
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
        public IBodyWorkflowAction<RedeemIncentiveCodeResponse> RedeemIncentiveCode(Expression<Func<int>> bodyincentiveId)
        {
            var __workflow_bodyincentiveId = bodyincentiveId == null ? null : WorkflowExpression.Compile(bodyincentiveId);
            WorkflowExpression.Validate(__workflow_bodyincentiveId, nameof(bodyincentiveId), required: true);
            return new DeferredBodyAction<RedeemIncentiveCodeResponse>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/RedeemIncentiveCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["incentiveId"] = ExpressionConverter.ConvertO(__workflow_bodyincentiveId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RedeemIncentiveCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<RemindMembersResponse> RemindMembers(Expression<Func<int>> bodydistributorId, Expression<Func<int>> bodymessageTemplateId, Expression<Func<TextBlock[]>> bodytextBlocks = null, Expression<Func<string>> bodyscheduleDateTime = null, Expression<Func<Condition[]>> bodyconditions = null, Expression<Func<bodychannelInput>> bodychannel = null, Expression<Func<string>> bodyfrom = null, Expression<Func<string>> bodyfromName = null, Expression<Func<string>> bodyreplyTo = null, Expression<Func<string>> bodyreplyToName = null)
        {
            var __workflow_bodydistributorId = bodydistributorId == null ? null : WorkflowExpression.Compile(bodydistributorId);
            WorkflowExpression.Validate(__workflow_bodydistributorId, nameof(bodydistributorId), required: true);
            var __workflow_bodymessageTemplateId = bodymessageTemplateId == null ? null : WorkflowExpression.Compile(bodymessageTemplateId);
            WorkflowExpression.Validate(__workflow_bodymessageTemplateId, nameof(bodymessageTemplateId), required: true);
            var __workflow_bodytextBlocks = bodytextBlocks == null ? null : WorkflowExpression.Compile(bodytextBlocks);
            WorkflowExpression.Validate(__workflow_bodytextBlocks, nameof(bodytextBlocks), required: false);
            var __workflow_bodyscheduleDateTime = bodyscheduleDateTime == null ? null : WorkflowExpression.Compile(bodyscheduleDateTime);
            WorkflowExpression.Validate(__workflow_bodyscheduleDateTime, nameof(bodyscheduleDateTime), required: false);
            var __workflow_bodyconditions = bodyconditions == null ? null : WorkflowExpression.Compile(bodyconditions);
            WorkflowExpression.Validate(__workflow_bodyconditions, nameof(bodyconditions), required: false);
            var __workflow_bodychannel = bodychannel == null ? null : WorkflowExpression.Compile(bodychannel);
            WorkflowExpression.Validate(__workflow_bodychannel, nameof(bodychannel), required: false);
            var __workflow_bodyfrom = bodyfrom == null ? null : WorkflowExpression.Compile(bodyfrom);
            WorkflowExpression.Validate(__workflow_bodyfrom, nameof(bodyfrom), required: false);
            var __workflow_bodyfromName = bodyfromName == null ? null : WorkflowExpression.Compile(bodyfromName);
            WorkflowExpression.Validate(__workflow_bodyfromName, nameof(bodyfromName), required: false);
            var __workflow_bodyreplyTo = bodyreplyTo == null ? null : WorkflowExpression.Compile(bodyreplyTo);
            WorkflowExpression.Validate(__workflow_bodyreplyTo, nameof(bodyreplyTo), required: false);
            var __workflow_bodyreplyToName = bodyreplyToName == null ? null : WorkflowExpression.Compile(bodyreplyToName);
            WorkflowExpression.Validate(__workflow_bodyreplyToName, nameof(bodyreplyToName), required: false);
            return new DeferredBodyAction<RemindMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/RemindMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["distributorId"] = ExpressionConverter.ConvertO(__workflow_bodydistributorId);
                bodypropCount++;
                body["messageTemplateId"] = ExpressionConverter.ConvertO(__workflow_bodymessageTemplateId);
                if (__workflow_bodytextBlocks != null)
                {
                    body["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodytextBlocks);
                    bodypropCount++;
                }

                if (__workflow_bodyscheduleDateTime != null)
                {
                    body["scheduleDateTime"] = ExpressionConverter.ConvertO(__workflow_bodyscheduleDateTime);
                    bodypropCount++;
                }

                if (__workflow_bodyconditions != null)
                {
                    body["conditions"] = ExpressionConverter.ConvertO(__workflow_bodyconditions);
                    bodypropCount++;
                }

                if (__workflow_bodychannel != null)
                {
                    body["channel"] = ExpressionConverter.ConvertO(__workflow_bodychannel);
                    bodypropCount++;
                }

                if (__workflow_bodyfrom != null)
                {
                    body["from"] = ExpressionConverter.ConvertO(__workflow_bodyfrom);
                    bodypropCount++;
                }

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

                if (__workflow_bodyreplyToName != null)
                {
                    body["replyToName"] = ExpressionConverter.ConvertO(__workflow_bodyreplyToName);
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
        public IBodyWorkflowAction<ResetInterviewResponse> ResetInterview(Expression<Func<int>> bodysurveyId = null, Expression<Func<string>> bodyinterviewId = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: false);
            var __workflow_bodyinterviewId = bodyinterviewId == null ? null : WorkflowExpression.Compile(bodyinterviewId);
            WorkflowExpression.Validate(__workflow_bodyinterviewId, nameof(bodyinterviewId), required: false);
            return new DeferredBodyAction<ResetInterviewResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ResetInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysurveyId != null)
                {
                    body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                    bodypropCount++;
                }

                if (__workflow_bodyinterviewId != null)
                {
                    body["interviewId"] = ExpressionConverter.ConvertO(__workflow_bodyinterviewId);
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
        public IBodyWorkflowAction<UpdateMembersResponse> UpdateMembers(Expression<Func<int>> bodypanelId, Expression<Func<Member[]>> bodymembers, Expression<Func<string>> bodytenant = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodymembers = bodymembers == null ? null : WorkflowExpression.Compile(bodymembers);
            WorkflowExpression.Validate(__workflow_bodymembers, nameof(bodymembers), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            return new DeferredBodyAction<UpdateMembersResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                bodypropCount++;
                body["members"] = ExpressionConverter.ConvertO(__workflow_bodymembers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<UpdateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzerswiss")]
        public IBodyWorkflowAction<WritePanelResponse> UpdatePanel(Expression<Func<int>> bodypanelId, Expression<Func<string>> bodytenant = null, Expression<Func<PanelMemberField[]>> bodyaddedFields = null, Expression<Func<int[]>> bodyremovedFields = null, Expression<Func<PanelMemberField[]>> bodyrenamedFields = null)
        {
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: true);
            var __workflow_bodytenant = bodytenant == null ? null : WorkflowExpression.Compile(bodytenant);
            WorkflowExpression.Validate(__workflow_bodytenant, nameof(bodytenant), required: false);
            var __workflow_bodyaddedFields = bodyaddedFields == null ? null : WorkflowExpression.Compile(bodyaddedFields);
            WorkflowExpression.Validate(__workflow_bodyaddedFields, nameof(bodyaddedFields), required: false);
            var __workflow_bodyremovedFields = bodyremovedFields == null ? null : WorkflowExpression.Compile(bodyremovedFields);
            WorkflowExpression.Validate(__workflow_bodyremovedFields, nameof(bodyremovedFields), required: false);
            var __workflow_bodyrenamedFields = bodyrenamedFields == null ? null : WorkflowExpression.Compile(bodyrenamedFields);
            WorkflowExpression.Validate(__workflow_bodyrenamedFields, nameof(bodyrenamedFields), required: false);
            return new DeferredBodyAction<WritePanelResponse>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodytenant != null)
                {
                    body["tenant"] = ExpressionConverter.ConvertO(__workflow_bodytenant);
                    bodypropCount++;
                }

                bodypropCount++;
                body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                if (__workflow_bodyaddedFields != null)
                {
                    body["addedFields"] = ExpressionConverter.ConvertO(__workflow_bodyaddedFields);
                    bodypropCount++;
                }

                if (__workflow_bodyremovedFields != null)
                {
                    body["removedFields"] = ExpressionConverter.ConvertO(__workflow_bodyremovedFields);
                    bodypropCount++;
                }

                if (__workflow_bodyrenamedFields != null)
                {
                    body["renamedFields"] = ExpressionConverter.ConvertO(__workflow_bodyrenamedFields);
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
        public IBodyWorkflowAction<UpdateSurveyResponse> UpdateSurvey(Expression<Func<int>> bodysurveyId, Expression<Func<bool>> bodysurveyDefinitionallowMultipleParticipation, Expression<Func<bool>> bodysurveyDefinitionallowNavigateBack, Expression<Func<bool>> bodysurveyDefinitionrandomizeSections, Expression<Func<string>> bodysurveyDefinitiondefaultLanguage, Expression<Func<string[]>> bodysurveyDefinitionlanguages, Expression<Func<Section[]>> bodysurveyDefinitionsections, Expression<Func<CustomVariable[]>> bodysurveyDefinitioncustomVariables, Expression<Func<TranslationElement[]>> bodysurveyDefinitionsurveyEndText, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogIp, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogUserAgent, Expression<Func<bool>> bodysurveyConfigurationanonymizingConfigurationlogReferer, Expression<Func<string>> bodysurveyName = null, Expression<Func<bool>> bodysurveyDefinitionallowSaveProgress = null, Expression<Func<bool>> bodysurveyDefinitionenableAutoScroll = null, Expression<Func<bool>> bodysurveyDefinitionenableCodeAccess = null, Expression<Func<bodysurveyDefinitiondataAccessControlaccessTypeInput>> bodysurveyDefinitiondataAccessControlaccessType = null, Expression<Func<Condition[]>> bodysurveyDefinitiondataAccessControlconditions = null, Expression<Func<int[]>> bodysurveyDefinitionassociatedPanels = null, Expression<Func<bodysurveyDefinitioncodeAccessModeInput>> bodysurveyDefinitioncodeAccessMode = null, Expression<Func<bool>> bodysurveyDefinitionenablePanelSync = null, Expression<Func<bodysurveyDefinitionpanelSyncBehaviourInput>> bodysurveyDefinitionpanelSyncBehaviour = null, Expression<Func<PanelSyncElement[]>> bodysurveyDefinitionpanelSyncs = null, Expression<Func<string>> bodysurveyDefinitionendDate = null, Expression<Func<int>> bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = null, Expression<Func<bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSizeInput>> bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = null, Expression<Func<TextBlock[]>> bodysurveyConfigurationdesignConfigurationtextBlocks = null, Expression<Func<bodysurveyConfigurationanonymizingConfigurationanonymizingModeInput>> bodysurveyConfigurationanonymizingConfigurationanonymizingMode = null)
        {
            var __workflow_bodysurveyId = bodysurveyId == null ? null : WorkflowExpression.Compile(bodysurveyId);
            WorkflowExpression.Validate(__workflow_bodysurveyId, nameof(bodysurveyId), required: true);
            var __workflow_bodysurveyDefinitionallowMultipleParticipation = bodysurveyDefinitionallowMultipleParticipation == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowMultipleParticipation);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowMultipleParticipation, nameof(bodysurveyDefinitionallowMultipleParticipation), required: true);
            var __workflow_bodysurveyDefinitionallowNavigateBack = bodysurveyDefinitionallowNavigateBack == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowNavigateBack);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowNavigateBack, nameof(bodysurveyDefinitionallowNavigateBack), required: true);
            var __workflow_bodysurveyDefinitionrandomizeSections = bodysurveyDefinitionrandomizeSections == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionrandomizeSections);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionrandomizeSections, nameof(bodysurveyDefinitionrandomizeSections), required: true);
            var __workflow_bodysurveyDefinitiondefaultLanguage = bodysurveyDefinitiondefaultLanguage == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondefaultLanguage);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondefaultLanguage, nameof(bodysurveyDefinitiondefaultLanguage), required: true);
            var __workflow_bodysurveyDefinitionlanguages = bodysurveyDefinitionlanguages == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionlanguages);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionlanguages, nameof(bodysurveyDefinitionlanguages), required: true);
            var __workflow_bodysurveyDefinitionsections = bodysurveyDefinitionsections == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionsections);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionsections, nameof(bodysurveyDefinitionsections), required: true);
            var __workflow_bodysurveyDefinitioncustomVariables = bodysurveyDefinitioncustomVariables == null ? null : WorkflowExpression.Compile(bodysurveyDefinitioncustomVariables);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitioncustomVariables, nameof(bodysurveyDefinitioncustomVariables), required: true);
            var __workflow_bodysurveyDefinitionsurveyEndText = bodysurveyDefinitionsurveyEndText == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionsurveyEndText);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionsurveyEndText, nameof(bodysurveyDefinitionsurveyEndText), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogIp = bodysurveyConfigurationanonymizingConfigurationlogIp == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogIp);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogIp, nameof(bodysurveyConfigurationanonymizingConfigurationlogIp), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent = bodysurveyConfigurationanonymizingConfigurationlogUserAgent == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent, nameof(bodysurveyConfigurationanonymizingConfigurationlogUserAgent), required: true);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer = bodysurveyConfigurationanonymizingConfigurationlogReferer == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationlogReferer);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer, nameof(bodysurveyConfigurationanonymizingConfigurationlogReferer), required: true);
            var __workflow_bodysurveyName = bodysurveyName == null ? null : WorkflowExpression.Compile(bodysurveyName);
            WorkflowExpression.Validate(__workflow_bodysurveyName, nameof(bodysurveyName), required: false);
            var __workflow_bodysurveyDefinitionallowSaveProgress = bodysurveyDefinitionallowSaveProgress == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionallowSaveProgress);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionallowSaveProgress, nameof(bodysurveyDefinitionallowSaveProgress), required: false);
            var __workflow_bodysurveyDefinitionenableAutoScroll = bodysurveyDefinitionenableAutoScroll == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenableAutoScroll);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenableAutoScroll, nameof(bodysurveyDefinitionenableAutoScroll), required: false);
            var __workflow_bodysurveyDefinitionenableCodeAccess = bodysurveyDefinitionenableCodeAccess == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenableCodeAccess);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenableCodeAccess, nameof(bodysurveyDefinitionenableCodeAccess), required: false);
            var __workflow_bodysurveyDefinitiondataAccessControlaccessType = bodysurveyDefinitiondataAccessControlaccessType == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondataAccessControlaccessType);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondataAccessControlaccessType, nameof(bodysurveyDefinitiondataAccessControlaccessType), required: false);
            var __workflow_bodysurveyDefinitiondataAccessControlconditions = bodysurveyDefinitiondataAccessControlconditions == null ? null : WorkflowExpression.Compile(bodysurveyDefinitiondataAccessControlconditions);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitiondataAccessControlconditions, nameof(bodysurveyDefinitiondataAccessControlconditions), required: false);
            var __workflow_bodysurveyDefinitionassociatedPanels = bodysurveyDefinitionassociatedPanels == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionassociatedPanels);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionassociatedPanels, nameof(bodysurveyDefinitionassociatedPanels), required: false);
            var __workflow_bodysurveyDefinitioncodeAccessMode = bodysurveyDefinitioncodeAccessMode == null ? null : WorkflowExpression.Compile(bodysurveyDefinitioncodeAccessMode);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitioncodeAccessMode, nameof(bodysurveyDefinitioncodeAccessMode), required: false);
            var __workflow_bodysurveyDefinitionenablePanelSync = bodysurveyDefinitionenablePanelSync == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionenablePanelSync);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionenablePanelSync, nameof(bodysurveyDefinitionenablePanelSync), required: false);
            var __workflow_bodysurveyDefinitionpanelSyncBehaviour = bodysurveyDefinitionpanelSyncBehaviour == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionpanelSyncBehaviour);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionpanelSyncBehaviour, nameof(bodysurveyDefinitionpanelSyncBehaviour), required: false);
            var __workflow_bodysurveyDefinitionpanelSyncs = bodysurveyDefinitionpanelSyncs == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionpanelSyncs);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionpanelSyncs, nameof(bodysurveyDefinitionpanelSyncs), required: false);
            var __workflow_bodysurveyDefinitionendDate = bodysurveyDefinitionendDate == null ? null : WorkflowExpression.Compile(bodysurveyDefinitionendDate);
            WorkflowExpression.Validate(__workflow_bodysurveyDefinitionendDate, nameof(bodysurveyDefinitionendDate), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout = bodysurveyConfigurationdesignConfigurationsurveyDesignLayout == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout, nameof(bodysurveyConfigurationdesignConfigurationsurveyDesignLayout), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize = bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize, nameof(bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize), required: false);
            var __workflow_bodysurveyConfigurationdesignConfigurationtextBlocks = bodysurveyConfigurationdesignConfigurationtextBlocks == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationdesignConfigurationtextBlocks);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks, nameof(bodysurveyConfigurationdesignConfigurationtextBlocks), required: false);
            var __workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode = bodysurveyConfigurationanonymizingConfigurationanonymizingMode == null ? null : WorkflowExpression.Compile(bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
            WorkflowExpression.Validate(__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode, nameof(bodysurveyConfigurationanonymizingConfigurationanonymizingMode), required: false);
            return new DeferredBodyAction<UpdateSurveyResponse>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/UpdateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["surveyId"] = ExpressionConverter.ConvertO(__workflow_bodysurveyId);
                if (__workflow_bodysurveyName != null)
                {
                    body["surveyName"] = ExpressionConverter.ConvertO(__workflow_bodysurveyName);
                    bodypropCount++;
                }

                var surveyDefinitionObject = new JObject();
                var surveyDefinitionObjectpropCount = 0;
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowMultipleParticipation"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowMultipleParticipation);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["allowNavigateBack"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowNavigateBack);
                if (__workflow_bodysurveyDefinitionallowSaveProgress != null)
                {
                    surveyDefinitionObject["allowSaveProgress"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionallowSaveProgress);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["randomizeSections"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionrandomizeSections);
                if (__workflow_bodysurveyDefinitionenableAutoScroll != null)
                {
                    surveyDefinitionObject["enableAutoScroll"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenableAutoScroll);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionenableCodeAccess != null)
                {
                    surveyDefinitionObject["enableCodeAccess"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenableCodeAccess);
                    surveyDefinitionObjectpropCount++;
                }

                var dataAccessControlObject = new JObject();
                var dataAccessControlObjectpropCount = 0;
                if (__workflow_bodysurveyDefinitiondataAccessControlaccessType != null)
                {
                    dataAccessControlObject["accessType"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondataAccessControlaccessType);
                    dataAccessControlObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitiondataAccessControlconditions != null)
                {
                    dataAccessControlObject["conditions"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondataAccessControlconditions);
                    dataAccessControlObjectpropCount++;
                }

                if (dataAccessControlObjectpropCount > 0)
                {
                    surveyDefinitionObject["dataAccessControl"] = dataAccessControlObject;
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionassociatedPanels != null)
                {
                    surveyDefinitionObject["associatedPanels"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionassociatedPanels);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitioncodeAccessMode != null)
                {
                    surveyDefinitionObject["codeAccessMode"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitioncodeAccessMode);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionenablePanelSync != null)
                {
                    surveyDefinitionObject["enablePanelSync"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionenablePanelSync);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionpanelSyncBehaviour != null)
                {
                    surveyDefinitionObject["panelSyncBehaviour"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionpanelSyncBehaviour);
                    surveyDefinitionObjectpropCount++;
                }

                if (__workflow_bodysurveyDefinitionpanelSyncs != null)
                {
                    surveyDefinitionObject["panelSyncs"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionpanelSyncs);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["defaultLanguage"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitiondefaultLanguage);
                if (__workflow_bodysurveyDefinitionendDate != null)
                {
                    surveyDefinitionObject["endDate"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionendDate);
                    surveyDefinitionObjectpropCount++;
                }

                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["languages"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionlanguages);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["sections"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionsections);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["customVariables"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitioncustomVariables);
                surveyDefinitionObjectpropCount++;
                surveyDefinitionObject["surveyEndText"] = ExpressionConverter.ConvertO(__workflow_bodysurveyDefinitionsurveyEndText);
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
                if (__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout != null)
                {
                    designConfigurationObject["surveyDesignLayout"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationsurveyDesignLayout);
                    designConfigurationObjectpropCount++;
                }

                if (__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize != null)
                {
                    designConfigurationObject["matrixSubQuestionSize"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationmatrixSubQuestionSize);
                    designConfigurationObjectpropCount++;
                }

                if (__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks != null)
                {
                    designConfigurationObject["textBlocks"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationdesignConfigurationtextBlocks);
                    designConfigurationObjectpropCount++;
                }

                if (designConfigurationObjectpropCount > 0)
                {
                    surveyConfigurationObject["designConfiguration"] = designConfigurationObject;
                    surveyConfigurationObjectpropCount++;
                }

                var anonymizingConfigurationObject = new JObject();
                var anonymizingConfigurationObjectpropCount = 0;
                if (__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode != null)
                {
                    anonymizingConfigurationObject["anonymizingMode"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationanonymizingMode);
                    anonymizingConfigurationObjectpropCount++;
                }

                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logIp"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogIp);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logUserAgent"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogUserAgent);
                anonymizingConfigurationObjectpropCount++;
                anonymizingConfigurationObject["logReferer"] = ExpressionConverter.ConvertO(__workflow_bodysurveyConfigurationanonymizingConfigurationlogReferer);
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
        public IBodyWorkflowAction<UpdateWebHookResponse> UpdateWebHook(Expression<Func<string>> bodywebHookId = null, Expression<Func<bodyeventTypeInput>> bodyeventType = null, Expression<Func<string>> bodyentityIdentifier = null, Expression<Func<string>> bodysecurityToken = null, Expression<Func<string>> bodywebHookUrl = null)
        {
            var __workflow_bodywebHookId = bodywebHookId == null ? null : WorkflowExpression.Compile(bodywebHookId);
            WorkflowExpression.Validate(__workflow_bodywebHookId, nameof(bodywebHookId), required: false);
            var __workflow_bodyeventType = bodyeventType == null ? null : WorkflowExpression.Compile(bodyeventType);
            WorkflowExpression.Validate(__workflow_bodyeventType, nameof(bodyeventType), required: false);
            var __workflow_bodyentityIdentifier = bodyentityIdentifier == null ? null : WorkflowExpression.Compile(bodyentityIdentifier);
            WorkflowExpression.Validate(__workflow_bodyentityIdentifier, nameof(bodyentityIdentifier), required: false);
            var __workflow_bodysecurityToken = bodysecurityToken == null ? null : WorkflowExpression.Compile(bodysecurityToken);
            WorkflowExpression.Validate(__workflow_bodysecurityToken, nameof(bodysecurityToken), required: false);
            var __workflow_bodywebHookUrl = bodywebHookUrl == null ? null : WorkflowExpression.Compile(bodywebHookUrl);
            WorkflowExpression.Validate(__workflow_bodywebHookUrl, nameof(bodywebHookUrl), required: false);
            return new DeferredBodyAction<UpdateWebHookResponse>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/UpdateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodywebHookId != null)
                {
                    body["webHookId"] = ExpressionConverter.ConvertO(__workflow_bodywebHookId);
                    bodypropCount++;
                }

                if (__workflow_bodyeventType != null)
                {
                    body["eventType"] = ExpressionConverter.ConvertO(__workflow_bodyeventType);
                    bodypropCount++;
                }

                if (__workflow_bodyentityIdentifier != null)
                {
                    body["entityIdentifier"] = ExpressionConverter.ConvertO(__workflow_bodyentityIdentifier);
                    bodypropCount++;
                }

                if (__workflow_bodysecurityToken != null)
                {
                    body["securityToken"] = ExpressionConverter.ConvertO(__workflow_bodysecurityToken);
                    bodypropCount++;
                }

                if (__workflow_bodywebHookUrl != null)
                {
                    body["webHookUrl"] = ExpressionConverter.ConvertO(__workflow_bodywebHookUrl);
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
        public IBodyWorkflowAction<WriteOptOutListResponse> WriteOptOutList(Expression<Func<int>> bodyworkspaceId = null, Expression<Func<int>> bodypanelId = null, Expression<Func<int>> bodydistributorId = null, Expression<Func<EmailItem[]>> bodyemails = null, Expression<Func<CellPhoneItem[]>> bodycellPhones = null)
        {
            var __workflow_bodyworkspaceId = bodyworkspaceId == null ? null : WorkflowExpression.Compile(bodyworkspaceId);
            WorkflowExpression.Validate(__workflow_bodyworkspaceId, nameof(bodyworkspaceId), required: false);
            var __workflow_bodypanelId = bodypanelId == null ? null : WorkflowExpression.Compile(bodypanelId);
            WorkflowExpression.Validate(__workflow_bodypanelId, nameof(bodypanelId), required: false);
            var __workflow_bodydistributorId = bodydistributorId == null ? null : WorkflowExpression.Compile(bodydistributorId);
            WorkflowExpression.Validate(__workflow_bodydistributorId, nameof(bodydistributorId), required: false);
            var __workflow_bodyemails = bodyemails == null ? null : WorkflowExpression.Compile(bodyemails);
            WorkflowExpression.Validate(__workflow_bodyemails, nameof(bodyemails), required: false);
            var __workflow_bodycellPhones = bodycellPhones == null ? null : WorkflowExpression.Compile(bodycellPhones);
            WorkflowExpression.Validate(__workflow_bodycellPhones, nameof(bodycellPhones), required: false);
            return new DeferredBodyAction<WriteOptOutListResponse>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/WriteOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyworkspaceId != null)
                {
                    body["workspaceId"] = ExpressionConverter.ConvertO(__workflow_bodyworkspaceId);
                    bodypropCount++;
                }

                if (__workflow_bodypanelId != null)
                {
                    body["panelId"] = ExpressionConverter.ConvertO(__workflow_bodypanelId);
                    bodypropCount++;
                }

                if (__workflow_bodydistributorId != null)
                {
                    body["distributorId"] = ExpressionConverter.ConvertO(__workflow_bodydistributorId);
                    bodypropCount++;
                }

                if (__workflow_bodyemails != null)
                {
                    body["emails"] = ExpressionConverter.ConvertO(__workflow_bodyemails);
                    bodypropCount++;
                }

                if (__workflow_bodycellPhones != null)
                {
                    body["cellPhones"] = ExpressionConverter.ConvertO(__workflow_bodycellPhones);
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
