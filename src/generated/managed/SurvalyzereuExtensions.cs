//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Survalyzereu
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SurvalyzereuActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateAndInviteMembersResponse, ApiConnectionActionConfiguration> CreateAndInviteMembers(Expression<Func<CreateAndInviteMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateAndInviteMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/CreateAndInviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateAndInviteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateArtifactResponse, ApiConnectionActionConfiguration> CreateArtifact(Expression<Func<CreateArtifactBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateArtifactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/CreateArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateArtifactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateMembersResponse, ApiConnectionActionConfiguration> CreateMembers(Expression<Func<CreateMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreatePanelResponse, ApiConnectionActionConfiguration> CreatePanel(Expression<Func<CreatePanelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreatePanelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/CreatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreatePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateSurveyResponse, ApiConnectionActionConfiguration> CreateSurvey(Expression<Func<CreateSurveyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<CreateSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/CreateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<CreateWebHookResponse, ApiConnectionActionConfiguration> CreateWebHook(Expression<Func<CreateWebHookBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<CreateWebHookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/CreateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<CreateWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteArtifactResponse, ApiConnectionActionConfiguration> DeleteArtifact(Expression<Func<DeleteArtifactBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteArtifactResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/DeleteArtifact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteArtifactResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteDistributorResponse, ApiConnectionActionConfiguration> DeleteDistributor(Expression<Func<DeleteDistributorBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteDistributorResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteDistributor";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteDistributorResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteInterviewResponse, ApiConnectionActionConfiguration> DeleteInterview(Expression<Func<DeleteInterviewBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteInterviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/DeleteInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteInterviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteMembersResponse, ApiConnectionActionConfiguration> DeleteMembers(Expression<Func<DeleteMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeleteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeletePanelResponse, ApiConnectionActionConfiguration> DeletePanel(Expression<Func<DeletePanelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeletePanelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/DeletePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeletePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteSamplingProjectResponse, ApiConnectionActionConfiguration> DeleteSamplingProject(Expression<Func<DeleteSamplingProjectBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteSamplingProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/DeleteSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteSamplingProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteSurveyResponse, ApiConnectionActionConfiguration> DeleteSurvey(Expression<Func<DeleteSurveyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<DeleteSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/DeleteSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DeleteWebHookResponse, ApiConnectionActionConfiguration> DeleteWebHook(Expression<Func<DeleteWebHookBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DeleteWebHookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/DeleteWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DeleteWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<DownloadAnswersResponse, ApiConnectionActionConfiguration> DownloadInterviewPdf(Expression<Func<string>> tenant, Expression<Func<int>> surveyId, Expression<Func<string>> interviewId, Expression<Func<bool>> showPartialCompleted = null, Expression<Func<string>> locale = null, Expression<Func<string>> timeZone = null, Expression<Func<DownloadInterviewPdfBodyInput>> body = null)
        {
            var __workflow_tenant = WorkflowExpression.Compile(tenant, nameof(tenant), required: true);
            var __workflow_surveyId = WorkflowExpression.Compile(surveyId, nameof(surveyId), required: true);
            var __workflow_interviewId = WorkflowExpression.Compile(interviewId, nameof(interviewId), required: true);
            var __workflow_showPartialCompleted = WorkflowExpression.Compile(showPartialCompleted, nameof(showPartialCompleted), required: false);
            var __workflow_locale = WorkflowExpression.Compile(locale, nameof(locale), required: false);
            var __workflow_timeZone = WorkflowExpression.Compile(timeZone, nameof(timeZone), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<DownloadAnswersResponse, ApiConnectionActionConfiguration>(() =>
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
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<DownloadAnswersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ExecuteSendMailResponse, ApiConnectionActionConfiguration> ExecuteSendMail(Expression<Func<ExecuteSendMailBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExecuteSendMailResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteSendMail";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExecuteSendMailResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ExecuteWorkflowTransitionResponse, ApiConnectionActionConfiguration> ExecuteWorkflowTransition(Expression<Func<ExecuteWorkflowTransitionBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ExecuteWorkflowTransitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ExecuteWorkflowTransition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ExecuteWorkflowTransitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<InviteMembersResponse, ApiConnectionActionConfiguration> InviteMembers(Expression<Func<InviteMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<InviteMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/InviteMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<InviteMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadArtifactListRequest, ApiConnectionActionConfiguration> ReadArtifactList(Expression<Func<CreateArtifactBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadArtifactListRequest, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadArtifactList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadArtifactListRequest>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadBounceListResponseV3, ApiConnectionActionConfiguration> ReadBounceList(Expression<Func<ReadBounceListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadBounceListResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadBounceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadBounceListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadCreditBalanceResponse, ApiConnectionActionConfiguration> ReadCreditBalance(Expression<Func<object>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadCreditBalanceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadCreditBalance";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadCreditBalanceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadDistributorListResponse, ApiConnectionActionConfiguration> ReadDistributorList(Expression<Func<ReadDistributorListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadDistributorListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadDistributorList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadDistributorListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadIncentiveListResponse, ApiConnectionActionConfiguration> ReadIncentiveList(Expression<Func<ReadIncentiveListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadIncentiveListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadIncentiveListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadIncentiveTransactionListResponse, ApiConnectionActionConfiguration> ReadIncentiveTransactionList(Expression<Func<ReadIncentiveListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadIncentiveTransactionListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/ReadIncentiveTransactionList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadIncentiveTransactionListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewDataResponse, ApiConnectionActionConfiguration> ReadInterview(Expression<Func<ReadInterviewBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadInterviewDataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadInterviewDataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewListCompactResponseV3, ApiConnectionActionConfiguration> ReadInterviewListCompact(Expression<Func<ReadInterviewListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadInterviewListCompactResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewListCompact";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadInterviewListCompactResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadInterviewListResponseV3, ApiConnectionActionConfiguration> ReadInterviewList(Expression<Func<ReadInterviewListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadInterviewListResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Interview/v3/ReadInterviewList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadInterviewListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadMemberListResponse, ApiConnectionActionConfiguration> ReadMemberList(Expression<Func<ReadMemberListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadMemberListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadMemberList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadMemberListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadMessageTemplateListResponse, ApiConnectionActionConfiguration> ReadMessageTemplateList(Expression<Func<ReadMessageTemplateListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadMessageTemplateListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadMessageTemplateList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadMessageTemplateListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadOptOutListResponseV3, ApiConnectionActionConfiguration> ReadOptOutList(Expression<Func<ReadOptOutListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadOptOutListResponseV3, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadOptOutListResponseV3>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadPanelDefinitionResponse, ApiConnectionActionConfiguration> ReadPanel(Expression<Func<ReadPanelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadPanelDefinitionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ReadPanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadPanelDefinitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSamplingProjectResponse, ApiConnectionActionConfiguration> ReadSamplingProject(Expression<Func<ReadSamplingProjectBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadSamplingProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/ReadSamplingProject";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadSamplingProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyLinksResponse, ApiConnectionActionConfiguration> ReadSurveyLinks(Expression<Func<ReadSurveyLinksBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadSurveyLinksResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyLinks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadSurveyLinksResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyListResponse, ApiConnectionActionConfiguration> ReadSurveyList(Expression<Func<ReadSurveyListBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadSurveyListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurveyList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadSurveyListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadSurveyResponse, ApiConnectionActionConfiguration> ReadSurvey(Expression<Func<ReadSurveyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWebHookListResponse, ApiConnectionActionConfiguration> ReadWebHookList(Expression<Func<ReadWebHookListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadWebHookListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/ReadWebHookList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadWebHookListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWorkflowTransitionsResponse, ApiConnectionActionConfiguration> ReadWorkflowTransitions(Expression<Func<ReadWorkflowTransitionsBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<ReadWorkflowTransitionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Common/v3/ReadWorkflowTransitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadWorkflowTransitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ReadWorkspaceListResponse, ApiConnectionActionConfiguration> ReadWorkspaceList(Expression<Func<ReadIncentiveListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ReadWorkspaceListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/ReadWorkspaceList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ReadWorkspaceListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<RedeemIncentiveCodeResponse, ApiConnectionActionConfiguration> RedeemIncentiveCode(Expression<Func<RedeemIncentiveCodeBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RedeemIncentiveCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Incentive/v3/RedeemIncentiveCode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RedeemIncentiveCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<RemindMembersResponse, ApiConnectionActionConfiguration> RemindMembers(Expression<Func<RemindMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<RemindMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/RemindMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<RemindMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<ResetInterviewResponse, ApiConnectionActionConfiguration> ResetInterview(Expression<Func<DeleteInterviewBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<ResetInterviewResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/ResetInterview";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<ResetInterviewResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateMembersResponse, ApiConnectionActionConfiguration> UpdateMembers(Expression<Func<CreateMembersBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateMembersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdateMembers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateMembersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<WritePanelResponse, ApiConnectionActionConfiguration> UpdatePanel(Expression<Func<UpdatePanelBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<WritePanelResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Panel/v3/UpdatePanel";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WritePanelResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateSurveyResponse, ApiConnectionActionConfiguration> UpdateSurvey(Expression<Func<UpdateSurveyBodyInput>> body)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredBodyAction<UpdateSurveyResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Survey/v3/UpdateSurvey";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateSurveyResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<UpdateWebHookResponse, ApiConnectionActionConfiguration> UpdateWebHook(Expression<Func<UpdateWebHookBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UpdateWebHookResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/WebHook/v3/UpdateWebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UpdateWebHookResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "survalyzereu")]
        public IBodyWorkflowAction<WriteOptOutListResponse, ApiConnectionActionConfiguration> WriteOptOutList(Expression<Func<WriteOptOutListBodyInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<WriteOptOutListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/publicapi/Distribute/v3/WriteOptOutList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<WriteOptOutListResponse>(callPayload);
            });
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

    public class CreateAndInviteMembersBodyInput
    {
        public CreateAndInviteMembersBodyInput(int surveyId, int panelId, CreateAndInviteMembersDistributionChannel channel, int messageTemplateId, CreateAndInviteMembersMember[] members)
        {
            this.SurveyId = surveyId;
            this.PanelId = panelId;
            this.Channel = channel;
            this.MessageTemplateId = messageTemplateId;
            this.Members = members;
        }

        [JsonProperty("samplingProjectId")]
        public int? SamplingProjectId { get; set; }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("channel", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersDistributionChannel Channel { get; set; }

        [JsonProperty("messageTemplateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MessageTemplateId { get; set; }

        [JsonProperty("textBlocks")]
        public CreateAndInviteMembersTextBlock[] TextBlocks { get; set; }

        [JsonProperty("members", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersMember[] Members { get; set; }

        [JsonProperty("scheduleDateTime")]
        public string ScheduleDateTime { get; set; }

        [JsonProperty("asyncProcess")]
        public bool? AsyncProcess { get; set; }

        [JsonProperty("interviewExpiryDate")]
        public string InterviewExpiryDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToName")]
        public string ReplyToName { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateAndInviteMembersDistributionChannel
    {
        Invalid,
        Email,
        Sms,
        LinkList,
        ApiEndpoint,
        WhatsApp
    }

    public class CreateAndInviteMembersTextBlock
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public CreateAndInviteMembersTranslationElement[] Text { get; set; }
    }

    public class CreateAndInviteMembersTranslationElement
    {
        public CreateAndInviteMembersTranslationElement(string languageCode)
        {
            this.LanguageCode = languageCode;
        }

        [JsonProperty("languageCode", DefaultValueHandling = DefaultValueHandling.Include)]
        public string LanguageCode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateAndInviteMembersMember
    {
        public CreateAndInviteMembersMember(JToken fields)
        {
            this.Fields = fields;
        }

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("fields", DefaultValueHandling = DefaultValueHandling.Include)]
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
        public CreateAndInviteMembersInterview[] Interviews { get; set; }
    }

    public class CreateAndInviteMembersInterview
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }

        [JsonProperty("surveyVersionId")]
        public int? SurveyVersionId { get; set; }

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
        public int? SamplingProjectId { get; set; }

        [JsonProperty("distributorId")]
        public int? DistributorId { get; set; }
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

    public class CreateArtifactBodyInput
    {
        [JsonProperty("workspaceId")]
        public int? WorkspaceId { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
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

    public class CreateMembersBodyInput
    {
        public CreateMembersBodyInput(int panelId, CreateAndInviteMembersMember[] members)
        {
            this.PanelId = panelId;
            this.Members = members;
        }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("members", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersMember[] Members { get; set; }
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

    public class CreatePanelBodyInput
    {
        public CreatePanelBodyInput(int workspaceId, string name, PanelModelType panelType)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name;
            this.PanelType = panelType;
        }

        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkspaceId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("panelType", DefaultValueHandling = DefaultValueHandling.Include)]
        public PanelModelType PanelType { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PanelModelType
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

    public class CreateSurveyBodyInput
    {
        public CreateSurveyBodyInput(int workspaceId, string name, CreateSurveySurveyDefinition surveyDefinition)
        {
            this.WorkspaceId = workspaceId;
            this.Name = name;
            this.SurveyDefinition = surveyDefinition;
        }

        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkspaceId { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("surveyDefinition", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveySurveyDefinition SurveyDefinition { get; set; }

        [JsonProperty("surveyConfiguration")]
        public CreateSurveySurveyConfiguration SurveyConfiguration { get; set; }
    }

    public class CreateSurveySurveyDefinition
    {
        public CreateSurveySurveyDefinition(bool allowMultipleParticipation, bool allowNavigateBack, bool randomizeSections, CreateSurveyCodeAccessMode codeAccessMode, string defaultLanguage, string[] languages, CreateSurveySection[] sections, CreateSurveyCustomVariable[] customVariables, CreateAndInviteMembersTranslationElement[] surveyEndText)
        {
            this.AllowMultipleParticipation = allowMultipleParticipation;
            this.AllowNavigateBack = allowNavigateBack;
            this.RandomizeSections = randomizeSections;
            this.CodeAccessMode = codeAccessMode;
            this.DefaultLanguage = defaultLanguage;
            this.Languages = languages;
            this.Sections = sections;
            this.CustomVariables = customVariables;
            this.SurveyEndText = surveyEndText;
        }

        [JsonProperty("allowMultipleParticipation", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowMultipleParticipation { get; set; }

        [JsonProperty("allowNavigateBack", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowNavigateBack { get; set; }

        [JsonProperty("allowSaveProgress")]
        public bool? AllowSaveProgress { get; set; }

        [JsonProperty("randomizeSections", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RandomizeSections { get; set; }

        [JsonProperty("enableAutoScroll")]
        public bool? EnableAutoScroll { get; set; }

        [JsonProperty("enableCodeAccess")]
        public bool? EnableCodeAccess { get; set; }

        [JsonProperty("dataAccessControl")]
        public CreateSurveyDataAccessControl DataAccessControl { get; set; }

        [JsonProperty("associatedPanels")]
        public int[] AssociatedPanels { get; set; }

        [JsonProperty("codeAccessMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyCodeAccessMode CodeAccessMode { get; set; }

        [JsonProperty("enablePanelSync")]
        public bool? EnablePanelSync { get; set; }

        [JsonProperty("panelSyncBehaviour")]
        public CreateSurveyPanelSyncBehaviour? PanelSyncBehaviour { get; set; }

        [JsonProperty("panelSyncs")]
        public CreateSurveyPanelSyncElement[] PanelSyncs { get; set; }

        [JsonProperty("defaultLanguage", DefaultValueHandling = DefaultValueHandling.Include)]
        public string DefaultLanguage { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("languages", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] Languages { get; set; }

        [JsonProperty("sections", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveySection[] Sections { get; set; }

        [JsonProperty("customVariables", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyCustomVariable[] CustomVariables { get; set; }

        [JsonProperty("surveyEndText", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersTranslationElement[] SurveyEndText { get; set; }

        [JsonProperty("defaultTextOverrides")]
        public JToken DefaultTextOverrides { get; set; }
    }

    public class CreateSurveyDataAccessControl
    {
        [JsonProperty("accessType")]
        public CreateSurveyAccessType? AccessType { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyAccessType
    {
        Private,
        Conditional,
        Public
    }

    public class CreateSurveyCondition
    {
        public CreateSurveyCondition(CreateSurveyConjunction conjunction, CreateSurveyConditionType conditionType, string identifier, CreateSurveyConditionOperator conditionOperator, string value)
        {
            this.Conjunction = conjunction;
            this.ConditionType = conditionType;
            this.Identifier = identifier;
            this.ConditionOperator = conditionOperator;
            this.Value = value;
        }

        [JsonProperty("conjunction", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyConjunction Conjunction { get; set; }

        [JsonProperty("conditionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyConditionType ConditionType { get; set; }

        [JsonProperty("identifier", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Identifier { get; set; }

        [JsonProperty("conditionOperator", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyConditionOperator ConditionOperator { get; set; }

        [JsonProperty("value", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Value { get; set; }

        [JsonProperty("variableType")]
        public CreateSurveyVariableType? VariableType { get; set; }

        [JsonProperty("jsonValue")]
        public bool? JsonValue { get; set; }

        [JsonProperty("jsonPath")]
        public string JsonPath { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyConjunction
    {
        Invalid,
        And,
        Or
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyConditionType
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
        [EnumMember(Value = "SQL")]
        Sql
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyConditionOperator
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
    public enum CreateSurveyVariableType
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
    public enum CreateSurveyCodeAccessMode
    {
        None,
        [EnumMember(Value = "StrongUsernamePassword")]
        StrongUserNamePassword,
        StrongAccessCode,
        [EnumMember(Value = "WeakUsernamePassword")]
        WeakUserNamePassword,
        WeakAccessCode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyPanelSyncBehaviour
    {
        Invalid,
        Default,
        SignUp
    }

    public class CreateSurveyPanelSyncElement
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("panelField")]
        public string PanelField { get; set; }
    }

    public class CreateSurveySection
    {
        public CreateSurveySection(int id, string name, bool randomizePages, bool excludeFromRandomization, CreateSurveySurveyElement[] elements)
        {
            this.Id = id;
            this.Name = name;
            this.RandomizePages = randomizePages;
            this.ExcludeFromRandomization = excludeFromRandomization;
            this.Elements = elements;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Name { get; set; }

        [JsonProperty("randomizePages", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RandomizePages { get; set; }

        [JsonProperty("excludeFromRandomization", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("elements", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveySurveyElement[] Elements { get; set; }

        [JsonProperty("condition")]
        public CreateSurveyConditionDefinition Condition { get; set; }
    }

    public class CreateSurveySurveyElement
    {
        public CreateSurveySurveyElement(int id, CreateSurveyElementType elementType)
        {
            this.Id = id;
            this.ElementType = elementType;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("elementType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyElementType ElementType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool? CodeManuallyChanged { get; set; }

        [JsonProperty("text")]
        public CreateAndInviteMembersTranslationElement[] Text { get; set; }

        [JsonProperty("hintText")]
        public CreateAndInviteMembersTranslationElement[] HintText { get; set; }

        [JsonProperty("hasHintText")]
        public bool? HasHintText { get; set; }

        [JsonProperty("hasNotAvailableChoice")]
        public bool? HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public CreateAndInviteMembersTranslationElement[] NotAvailableChoiceText { get; set; }

        [JsonProperty("forceResponse")]
        public bool? ForceResponse { get; set; }

        [JsonProperty("choices")]
        public CreateSurveyChoice[] Choices { get; set; }

        [JsonProperty("randomizeChoices")]
        public bool? RandomizeChoices { get; set; }

        [JsonProperty("columnType")]
        public CreateSurveyColumnType? ColumnType { get; set; }

        [JsonProperty("prompt")]
        public CreateAndInviteMembersTranslationElement[] Prompt { get; set; }

        [JsonProperty("minValue")]
        public int? MinValue { get; set; }

        [JsonProperty("maxValue")]
        public int? MaxValue { get; set; }

        [JsonProperty("showCenterLabel")]
        public bool? ShowCenterLabel { get; set; }

        [JsonProperty("leftLabel")]
        public CreateAndInviteMembersTranslationElement[] LeftLabel { get; set; }

        [JsonProperty("centerLabel")]
        public CreateAndInviteMembersTranslationElement[] CenterLabel { get; set; }

        [JsonProperty("rightLabel")]
        public CreateAndInviteMembersTranslationElement[] RightLabel { get; set; }

        [JsonProperty("showValue")]
        public bool? ShowValue { get; set; }

        [JsonProperty("maxDecimals")]
        public int? MaxDecimals { get; set; }

        [JsonProperty("textFieldSize")]
        public CreateSurveyTextFieldSize? TextFieldSize { get; set; }

        [JsonProperty("autocomplete")]
        public bool? Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public CreateAndInviteMembersTranslationElement[] AutocompleteText { get; set; }

        [JsonProperty("contentValidation")]
        public CreateSurveyContentValidation ContentValidation { get; set; }

        [JsonProperty("hasPlaceholder")]
        public bool? HasPlaceholder { get; set; }

        [JsonProperty("placeholder")]
        public CreateAndInviteMembersTranslationElement[] Placeholder { get; set; }

        [JsonProperty("isPassword")]
        public bool? IsPassword { get; set; }

        [JsonProperty("minMaxValidation")]
        public bool? MinMaxValidation { get; set; }

        [JsonProperty("minimumCheckedChoices")]
        public int? MinimumCheckedChoices { get; set; }

        [JsonProperty("maximumCheckedChoices")]
        public int? MaximumCheckedChoices { get; set; }

        [JsonProperty("columnGroups")]
        public CreateSurveyColumnGroup[] ColumnGroups { get; set; }

        [JsonProperty("randomizeRows")]
        public bool? RandomizeRows { get; set; }

        [JsonProperty("rows")]
        public CreateSurveyMinMaxChoice[] Rows { get; set; }

        [JsonProperty("numberOfRanks")]
        public int? NumberOfRanks { get; set; }

        [JsonProperty("likeText")]
        public CreateAndInviteMembersTranslationElement[] LikeText { get; set; }

        [JsonProperty("dislikeText")]
        public CreateAndInviteMembersTranslationElement[] DislikeText { get; set; }

        [JsonProperty("hasStartText")]
        public bool? HasStartText { get; set; }

        [JsonProperty("startText")]
        public CreateAndInviteMembersTranslationElement[] StartText { get; set; }

        [JsonProperty("enableMeasurement")]
        public bool? EnableMeasurement { get; set; }

        [JsonProperty("showButtons")]
        public bool? ShowButtons { get; set; }

        [JsonProperty("likeKey")]
        public string LikeKey { get; set; }

        [JsonProperty("dislikeKey")]
        public string DislikeKey { get; set; }

        [JsonProperty("interviewState")]
        public string InterviewState { get; set; }

        [JsonProperty("action")]
        public CreateSurveyActionElement Action { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("subject")]
        public CreateAndInviteMembersTranslationElement[] Subject { get; set; }

        [JsonProperty("message")]
        public CreateAndInviteMembersTranslationElement[] Message { get; set; }

        [JsonProperty("valueAssignmentType")]
        public CreateSurveyValueAssignmentType? ValueAssignmentType { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("functionTerm")]
        public CreateAndInviteMembersTranslationElement[] FunctionTerm { get; set; }

        [JsonProperty("executionBehavior")]
        public CreateSurveyExecutionBehavior? ExecutionBehavior { get; set; }

        [JsonProperty("apiCallMethod")]
        public CreateSurveyApiCallMethod? ApiCallMethod { get; set; }

        [JsonProperty("url")]
        public CreateAndInviteMembersTranslationElement[] Url { get; set; }

        [JsonProperty("headers")]
        public string Headers { get; set; }

        [JsonProperty("body")]
        public CreateAndInviteMembersTranslationElement[] Body { get; set; }

        [JsonProperty("externalUri")]
        public string ExternalUri { get; set; }

        [JsonProperty("scriptType")]
        public CreateSurveyScriptType? ScriptType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("hasRatingLabels")]
        public bool? HasRatingLabels { get; set; }

        [JsonProperty("leftRatingLabel")]
        public CreateAndInviteMembersTranslationElement[] LeftRatingLabel { get; set; }

        [JsonProperty("rightRatingLabel")]
        public CreateAndInviteMembersTranslationElement[] RightRatingLabel { get; set; }

        [JsonProperty("condition")]
        public CreateSurveyConditionDefinition Condition { get; set; }

        [JsonProperty("evaluateAsJson")]
        public bool? EvaluateAsJson { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }

        [JsonProperty("arrangementMode")]
        public CreateSurveyArrangementMode? ArrangementMode { get; set; }

        [JsonProperty("enableAnimation")]
        public bool? EnableAnimation { get; set; }

        [JsonProperty("useSmiley")]
        public bool? UseSmiley { get; set; }

        [JsonProperty("hasPrompt")]
        public bool? HasPrompt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyElementType
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

    public class CreateSurveyChoice
    {
        public CreateSurveyChoice(int id, string code, CreateAndInviteMembersTranslationElement[] text, bool allowTextEntry, bool forceInput, bool autocomplete, bool exclusive)
        {
            this.Id = id;
            this.Code = code;
            this.Text = text;
            this.AllowTextEntry = allowTextEntry;
            this.ForceInput = forceInput;
            this.Autocomplete = autocomplete;
            this.Exclusive = exclusive;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool? CodeManuallyChanged { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersTranslationElement[] Text { get; set; }

        [JsonProperty("allowTextEntry", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool AllowTextEntry { get; set; }

        [JsonProperty("forceInput", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ForceInput { get; set; }

        [JsonProperty("autocomplete", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public CreateAndInviteMembersTranslationElement[] AutocompleteText { get; set; }

        [JsonProperty("exclusive", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool Exclusive { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool? ExcludeFromRandomization { get; set; }

        [JsonProperty("contentValidation")]
        public CreateSurveyContentValidation ContentValidation { get; set; }

        [JsonProperty("condition")]
        public CreateSurveyConditionDefinition Condition { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }
    }

    public class CreateSurveyContentValidation
    {
        public CreateSurveyContentValidation(CreateSurveyContentValidationType validationType)
        {
            this.ValidationType = validationType;
        }

        [JsonProperty("validationType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyContentValidationType ValidationType { get; set; }

        [JsonProperty("earliestDate")]
        public string EarliestDate { get; set; }

        [JsonProperty("latestDate")]
        public string LatestDate { get; set; }

        [JsonProperty("minValue")]
        public double? MinValue { get; set; }

        [JsonProperty("maxValue")]
        public double? MaxValue { get; set; }

        [JsonProperty("decimalPlaces")]
        public int? DecimalPlaces { get; set; }

        [JsonProperty("disableThousandSeparator")]
        public bool? DisableThousandSeparator { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyContentValidationType
    {
        Invalid,
        None,
        Number,
        Email,
        Date,
        List,
        Real
    }

    public class CreateSurveyConditionDefinition
    {
        public CreateSurveyConditionDefinition(CreateSurveyConditionAction conditionAction, CreateSurveyCondition[] elements)
        {
            this.ConditionAction = conditionAction;
            this.Elements = elements;
        }

        [JsonProperty("conditionAction", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyConditionAction ConditionAction { get; set; }

        [JsonProperty("elements", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyCondition[] Elements { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyConditionAction
    {
        Invalid,
        Passes,
        Fails
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyColumnType
    {
        Invalid,
        Single,
        Multiple
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyTextFieldSize
    {
        Invalid,
        Small,
        Medium,
        Large
    }

    public class CreateSurveyColumnGroup
    {
        public CreateSurveyColumnGroup(int id, CreateAndInviteMembersTranslationElement[] text, bool hasNotAvailableChoice, bool randomizeColumns, CreateSurveyChoiceType choiceType, CreateSurveyChoice[] choices)
        {
            this.Id = id;
            this.Text = text;
            this.HasNotAvailableChoice = hasNotAvailableChoice;
            this.RandomizeColumns = randomizeColumns;
            this.ChoiceType = choiceType;
            this.Choices = choices;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersTranslationElement[] Text { get; set; }

        [JsonProperty("hasNotAvailableChoice", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public CreateAndInviteMembersTranslationElement[] NotAvailableChoiceText { get; set; }

        [JsonProperty("randomizeColumns", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool RandomizeColumns { get; set; }

        [JsonProperty("prompt")]
        public CreateAndInviteMembersTranslationElement[] Prompt { get; set; }

        [JsonProperty("choiceType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyChoiceType ChoiceType { get; set; }

        [JsonProperty("choices", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyChoice[] Choices { get; set; }

        [JsonProperty("condition")]
        public CreateSurveyConditionDefinition Condition { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyChoiceType
    {
        Invalid,
        Single,
        Multiple,
        Dropdown,
        Text,
        StarScale
    }

    public class CreateSurveyMinMaxChoice
    {
        public CreateSurveyMinMaxChoice(int id, string code, CreateAndInviteMembersTranslationElement[] leftText, CreateAndInviteMembersTranslationElement[] rightText, bool excludeFromRandomization)
        {
            this.Id = id;
            this.Code = code;
            this.LeftText = leftText;
            this.RightText = rightText;
            this.ExcludeFromRandomization = excludeFromRandomization;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool? CodeManuallyChanged { get; set; }

        [JsonProperty("leftText", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersTranslationElement[] LeftText { get; set; }

        [JsonProperty("rightText", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateAndInviteMembersTranslationElement[] RightText { get; set; }

        [JsonProperty("excludeFromRandomization", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("condition")]
        public CreateSurveyConditionDefinition Condition { get; set; }
    }

    public class CreateSurveyActionElement
    {
        public CreateSurveyActionElement(CreateSurveyActionType actionType)
        {
            this.ActionType = actionType;
        }

        [JsonProperty("actionType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyActionType ActionType { get; set; }

        [JsonProperty("endOfSurveyText")]
        public CreateAndInviteMembersTranslationElement[] EndOfSurveyText { get; set; }

        [JsonProperty("forwardUrl")]
        public CreateAndInviteMembersTranslationElement[] ForwardUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyActionType
    {
        Invalid,
        ShowEndOfSurveyText,
        ForwardToUrl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyValueAssignmentType
    {
        Invalid,
        Custom,
        Panel,
        Survey,
        Credit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyExecutionBehavior
    {
        Invalid,
        AnyTime,
        FirstTime,
        EachTime,
        SurveyLoad
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyApiCallMethod
    {
        Invalid,
        Get,
        Post
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyScriptType
    {
        Invalid,
        JavaScript,
        Css
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyArrangementMode
    {
        Invalid,
        Cubic,
        Circular
    }

    public class CreateSurveyCustomVariable
    {
        public CreateSurveyCustomVariable(int id, string variableName, CreateSurveyVariableType variableType)
        {
            this.Id = id;
            this.VariableName = variableName;
            this.VariableType = variableType;
        }

        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Id { get; set; }

        [JsonProperty("variableName", DefaultValueHandling = DefaultValueHandling.Include)]
        public string VariableName { get; set; }

        [JsonProperty("variableType", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyVariableType VariableType { get; set; }
    }

    public class CreateSurveySurveyConfiguration
    {
        [JsonProperty("designConfiguration")]
        public CreateSurveyDesignConfiguration DesignConfiguration { get; set; }

        [JsonProperty("anonymizingConfiguration")]
        public CreateSurveyAnonymizingConfiguration AnonymizingConfiguration { get; set; }
    }

    public class CreateSurveyDesignConfiguration
    {
        [JsonProperty("surveyDesignLayout")]
        public int? SurveyDesignLayout { get; set; }

        [JsonProperty("matrixSubQuestionSize")]
        public CreateSurveyMatrixSubQuestionSize? MatrixSubQuestionSize { get; set; }

        [JsonProperty("textBlocks")]
        public CreateAndInviteMembersTextBlock[] TextBlocks { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyMatrixSubQuestionSize
    {
        M,
        S,
        L,
        Xl
    }

    public class CreateSurveyAnonymizingConfiguration
    {
        public CreateSurveyAnonymizingConfiguration(CreateSurveyAnonymizingMode anonymizingMode, bool logIp, bool logUserAgent, bool logReferer)
        {
            this.AnonymizingMode = anonymizingMode;
            this.LogIp = logIp;
            this.LogUserAgent = logUserAgent;
            this.LogReferer = logReferer;
        }

        [JsonProperty("anonymizingMode", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveyAnonymizingMode AnonymizingMode { get; set; }

        [JsonProperty("logIp", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool LogIp { get; set; }

        [JsonProperty("logUserAgent", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool LogUserAgent { get; set; }

        [JsonProperty("logReferer", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool LogReferer { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateSurveyAnonymizingMode
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

    public class CreateWebHookBodyInput
    {
        [JsonProperty("eventType")]
        public CreateWebHookEventType? EventType { get; set; }

        [JsonProperty("entityIdentifier")]
        public string EntityIdentifier { get; set; }

        [JsonProperty("securityToken")]
        public string SecurityToken { get; set; }

        [JsonProperty("webHookUrl")]
        public string WebHookUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum CreateWebHookEventType
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

    public class DeleteArtifactBodyInput
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("filename")]
        public string FileName { get; set; }

        [JsonProperty("workspaceId")]
        public int? WorkspaceId { get; set; }
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

    public class DeleteDistributorBodyInput
    {
        public DeleteDistributorBodyInput(int distributorId)
        {
            this.DistributorId = distributorId;
        }

        [JsonProperty("distributorId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DistributorId { get; set; }

        [JsonProperty("keepInterviews")]
        public bool? KeepInterviews { get; set; }
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

    public class DeleteInterviewBodyInput
    {
        [JsonProperty("interviewId")]
        public string InterviewId { get; set; }

        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }
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

    public class DeleteMembersBodyInput
    {
        public DeleteMembersBodyInput(int panelId, int[] panelMembersIds)
        {
            this.PanelId = panelId;
            this.PanelMembersIds = panelMembersIds;
        }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("panelMembersIds", DefaultValueHandling = DefaultValueHandling.Include)]
        public int[] PanelMembersIds { get; set; }

        [JsonProperty("keepInterviews")]
        public bool? KeepInterviews { get; set; }
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

    public class DeletePanelBodyInput
    {
        public DeletePanelBodyInput(int panelId)
        {
            this.PanelId = panelId;
        }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("keepInterviews")]
        public bool? KeepInterviews { get; set; }
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

    public class DeleteSamplingProjectBodyInput
    {
        [JsonProperty("samplingProjectId")]
        public int? SamplingProjectId { get; set; }

        [JsonProperty("keepInterviews")]
        public bool? KeepInterviews { get; set; }
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

    public class DeleteSurveyBodyInput
    {
        public DeleteSurveyBodyInput(int surveyId)
        {
            this.SurveyId = surveyId;
        }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }
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

    public class DeleteWebHookBodyInput
    {
        [JsonProperty("webHookId")]
        public string WebHookId { get; set; }
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

    public class DownloadInterviewPdfBodyInput
    {
        [JsonProperty("isCancellationRequested")]
        public bool? IsCancellationRequested { get; set; }

        [JsonProperty("canBeCanceled")]
        public bool? CanBeCanceled { get; set; }

        [JsonProperty("waitHandle")]
        public WaitHandle WaitHandle { get; set; }
    }

    public class WaitHandle
    {
        [JsonProperty("safeWaitHandle")]
        public SafeWaitHandle SafeWaitHandle { get; set; }
    }

    public class SafeWaitHandle
    {
        [JsonProperty("isInvalid")]
        public bool? IsInvalid { get; set; }

        [JsonProperty("isClosed")]
        public bool? IsClosed { get; set; }
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

    public class ExecuteSendMailBodyInput
    {
        public ExecuteSendMailBodyInput(string language, string from, string to)
        {
            this.Language = language;
            this.From = from;
            this.To = to;
        }

        [JsonProperty("messageTemplateId")]
        public int? MessageTemplateId { get; set; }

        [JsonProperty("textBlocks")]
        public CreateAndInviteMembersTextBlock[] TextBlocks { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("from", DefaultValueHandling = DefaultValueHandling.Include)]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("to", DefaultValueHandling = DefaultValueHandling.Include)]
        public string To { get; set; }

        [JsonProperty("toName")]
        public string ToName { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToName")]
        public string ReplyToName { get; set; }
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

    public class ExecuteWorkflowTransitionBodyInput
    {
        public ExecuteWorkflowTransitionBodyInput(WorkflowType workflow, string targetState)
        {
            this.Workflow = workflow;
            this.TargetState = targetState;
        }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkflowType Workflow { get; set; }

        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }

        [JsonProperty("samplingProjectId")]
        public int? SamplingProjectId { get; set; }

        [JsonProperty("distributorId")]
        public int? DistributorId { get; set; }

        [JsonProperty("reminderId")]
        public int? ReminderId { get; set; }

        [JsonProperty("targetState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TargetState { get; set; }

        [JsonProperty("dynamicParameters")]
        public JToken DynamicParameters { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum WorkflowType
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

    public class InviteMembersBodyInput
    {
        public InviteMembersBodyInput(int surveyId, int panelId, int messageTemplateId)
        {
            this.SurveyId = surveyId;
            this.PanelId = panelId;
            this.MessageTemplateId = messageTemplateId;
        }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("samplingProjectId")]
        public int? SamplingProjectId { get; set; }

        [JsonProperty("memberIds")]
        public int[] MemberIds { get; set; }

        [JsonProperty("messageTemplateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MessageTemplateId { get; set; }

        [JsonProperty("textBlocks")]
        public CreateAndInviteMembersTextBlock[] TextBlocks { get; set; }

        [JsonProperty("scheduleDateTime")]
        public string ScheduleDateTime { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("channel")]
        public CreateAndInviteMembersDistributionChannel? Channel { get; set; }

        [JsonProperty("asyncProcess")]
        public bool? AsyncProcess { get; set; }

        [JsonProperty("interviewExpiryDate")]
        public string InterviewExpiryDate { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToName")]
        public string ReplyToName { get; set; }
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
        public ReadBounceListInvitationTypeResponse InvitationType { get; set; }
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
    public enum ReadBounceListInvitationTypeResponse
    {
        Invalid,
        Invitation,
        Reminder
    }

    public class ReadBounceListBodyInput
    {
        public ReadBounceListBodyInput(int surveyId)
        {
            this.SurveyId = surveyId;
        }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }

        [JsonProperty("panelId")]
        public int? PanelId { get; set; }

        [JsonProperty("distributors")]
        public int[] Distributors { get; set; }

        [JsonProperty("invitationType")]
        public ReadBounceListInvitationType? InvitationType { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadBounceListInvitationType
    {
        Invalid,
        Invitation,
        Reminder
    }

    public class Paging
    {
        public Paging(int pageSize, int page)
        {
            this.PageSize = pageSize;
            this.Page = page;
        }

        [JsonProperty("pageSize", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PageSize { get; set; }

        [JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Include)]
        public int Page { get; set; }

        [JsonProperty("orderField")]
        public string OrderField { get; set; }

        [JsonProperty("orderDirection")]
        public OrderDirection? OrderDirection { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OrderDirection
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
        public ReadDistributorListDistributionChannelResponse DistributionChannel { get; set; }

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
        public ReadDistributorListConditionDefinitionResponse[] Conditions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadDistributorListDistributionChannelResponse
    {
        Invalid,
        Email,
        Sms,
        LinkList,
        ApiEndpoint,
        WhatsApp
    }

    public class ReadDistributorListConditionDefinitionResponse
    {
        [JsonProperty("conditionAction")]
        public ReadDistributorListConditionActionResponse ConditionAction { get; set; }

        [JsonProperty("elements")]
        public ReadDistributorListConditionResponse[] Elements { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadDistributorListConditionActionResponse
    {
        Invalid,
        Passes,
        Fails
    }

    public class ReadDistributorListConditionResponse
    {
        [JsonProperty("conjunction")]
        public ReadDistributorListConjunctionResponse Conjunction { get; set; }

        [JsonProperty("conditionType")]
        public ReadDistributorListConditionTypeResponse ConditionType { get; set; }

        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("conditionOperator")]
        public ReadDistributorListConditionOperatorResponse ConditionOperator { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("variableType")]
        public ReadDistributorListVariableTypeResponse VariableType { get; set; }

        [JsonProperty("jsonValue")]
        public bool JsonValue { get; set; }

        [JsonProperty("jsonPath")]
        public string JsonPath { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadDistributorListConjunctionResponse
    {
        Invalid,
        And,
        Or
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadDistributorListConditionTypeResponse
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
        [EnumMember(Value = "SQL")]
        Sql
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadDistributorListConditionOperatorResponse
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
    public enum ReadDistributorListVariableTypeResponse
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

    public class ReadDistributorListBodyInput
    {
        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }

        [JsonProperty("panelId")]
        public int? PanelId { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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

    public class ReadIncentiveListBodyInput
    {
        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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
        public ReadInterviewSurveyDefinitionResponse SurveyDefinition { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadInterviewSurveyDefinitionResponse
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
        public ReadInterviewDataAccessControlResponse DataAccessControl { get; set; }

        [JsonProperty("associatedPanels")]
        public int[] AssociatedPanels { get; set; }

        [JsonProperty("codeAccessMode")]
        public ReadInterviewCodeAccessModeResponse CodeAccessMode { get; set; }

        [JsonProperty("enablePanelSync")]
        public bool EnablePanelSync { get; set; }

        [JsonProperty("panelSyncBehaviour")]
        public ReadInterviewPanelSyncBehaviourResponse PanelSyncBehaviour { get; set; }

        [JsonProperty("panelSyncs")]
        public ReadInterviewPanelSyncElementResponse[] PanelSyncs { get; set; }

        [JsonProperty("defaultLanguage")]
        public string DefaultLanguage { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("languages")]
        public string[] Languages { get; set; }

        [JsonProperty("sections")]
        public ReadInterviewSectionResponse[] Sections { get; set; }

        [JsonProperty("customVariables")]
        public ReadInterviewCustomVariableResponse[] CustomVariables { get; set; }

        [JsonProperty("surveyEndText")]
        public ReadInterviewTranslationElementResponse[] SurveyEndText { get; set; }

        [JsonProperty("defaultTextOverrides")]
        public JToken DefaultTextOverrides { get; set; }
    }

    public class ReadInterviewDataAccessControlResponse
    {
        [JsonProperty("accessType")]
        public ReadInterviewAccessTypeResponse AccessType { get; set; }

        [JsonProperty("conditions")]
        public ReadDistributorListConditionResponse[] Conditions { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewAccessTypeResponse
    {
        Private,
        Conditional,
        Public
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewCodeAccessModeResponse
    {
        None,
        [EnumMember(Value = "StrongUsernamePassword")]
        StrongUserNamePassword,
        StrongAccessCode,
        [EnumMember(Value = "WeakUsernamePassword")]
        WeakUserNamePassword,
        WeakAccessCode
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewPanelSyncBehaviourResponse
    {
        Invalid,
        Default,
        SignUp
    }

    public class ReadInterviewPanelSyncElementResponse
    {
        [JsonProperty("identifier")]
        public string Identifier { get; set; }

        [JsonProperty("panelField")]
        public string PanelField { get; set; }
    }

    public class ReadInterviewSectionResponse
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
        public ReadInterviewSurveyElementResponse[] Elements { get; set; }

        [JsonProperty("condition")]
        public ReadDistributorListConditionDefinitionResponse Condition { get; set; }
    }

    public class ReadInterviewSurveyElementResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("elementType")]
        public ReadInterviewElementTypeResponse ElementType { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("text")]
        public ReadInterviewTranslationElementResponse[] Text { get; set; }

        [JsonProperty("hintText")]
        public ReadInterviewTranslationElementResponse[] HintText { get; set; }

        [JsonProperty("hasHintText")]
        public bool HasHintText { get; set; }

        [JsonProperty("hasNotAvailableChoice")]
        public bool HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public ReadInterviewTranslationElementResponse[] NotAvailableChoiceText { get; set; }

        [JsonProperty("forceResponse")]
        public bool ForceResponse { get; set; }

        [JsonProperty("choices")]
        public ReadInterviewChoiceResponse[] Choices { get; set; }

        [JsonProperty("randomizeChoices")]
        public bool RandomizeChoices { get; set; }

        [JsonProperty("columnType")]
        public ReadInterviewColumnTypeResponse ColumnType { get; set; }

        [JsonProperty("prompt")]
        public ReadInterviewTranslationElementResponse[] Prompt { get; set; }

        [JsonProperty("minValue")]
        public int MinValue { get; set; }

        [JsonProperty("maxValue")]
        public int MaxValue { get; set; }

        [JsonProperty("showCenterLabel")]
        public bool ShowCenterLabel { get; set; }

        [JsonProperty("leftLabel")]
        public ReadInterviewTranslationElementResponse[] LeftLabel { get; set; }

        [JsonProperty("centerLabel")]
        public ReadInterviewTranslationElementResponse[] CenterLabel { get; set; }

        [JsonProperty("rightLabel")]
        public ReadInterviewTranslationElementResponse[] RightLabel { get; set; }

        [JsonProperty("showValue")]
        public bool ShowValue { get; set; }

        [JsonProperty("maxDecimals")]
        public int MaxDecimals { get; set; }

        [JsonProperty("textFieldSize")]
        public ReadInterviewTextFieldSizeResponse TextFieldSize { get; set; }

        [JsonProperty("autocomplete")]
        public bool Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public ReadInterviewTranslationElementResponse[] AutocompleteText { get; set; }

        [JsonProperty("contentValidation")]
        public ReadInterviewContentValidationResponse ContentValidation { get; set; }

        [JsonProperty("hasPlaceholder")]
        public bool HasPlaceholder { get; set; }

        [JsonProperty("placeholder")]
        public ReadInterviewTranslationElementResponse[] Placeholder { get; set; }

        [JsonProperty("isPassword")]
        public bool IsPassword { get; set; }

        [JsonProperty("minMaxValidation")]
        public bool MinMaxValidation { get; set; }

        [JsonProperty("minimumCheckedChoices")]
        public int MinimumCheckedChoices { get; set; }

        [JsonProperty("maximumCheckedChoices")]
        public int MaximumCheckedChoices { get; set; }

        [JsonProperty("columnGroups")]
        public ReadInterviewColumnGroupResponse[] ColumnGroups { get; set; }

        [JsonProperty("randomizeRows")]
        public bool RandomizeRows { get; set; }

        [JsonProperty("rows")]
        public ReadInterviewMinMaxChoiceResponse[] Rows { get; set; }

        [JsonProperty("numberOfRanks")]
        public int NumberOfRanks { get; set; }

        [JsonProperty("likeText")]
        public ReadInterviewTranslationElementResponse[] LikeText { get; set; }

        [JsonProperty("dislikeText")]
        public ReadInterviewTranslationElementResponse[] DislikeText { get; set; }

        [JsonProperty("hasStartText")]
        public bool HasStartText { get; set; }

        [JsonProperty("startText")]
        public ReadInterviewTranslationElementResponse[] StartText { get; set; }

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
        public ReadInterviewActionElementResponse Action { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("subject")]
        public ReadInterviewTranslationElementResponse[] Subject { get; set; }

        [JsonProperty("message")]
        public ReadInterviewTranslationElementResponse[] Message { get; set; }

        [JsonProperty("valueAssignmentType")]
        public ReadInterviewValueAssignmentTypeResponse ValueAssignmentType { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("functionTerm")]
        public ReadInterviewTranslationElementResponse[] FunctionTerm { get; set; }

        [JsonProperty("executionBehavior")]
        public ReadInterviewExecutionBehaviorResponse ExecutionBehavior { get; set; }

        [JsonProperty("apiCallMethod")]
        public ReadInterviewApiCallMethodResponse ApiCallMethod { get; set; }

        [JsonProperty("url")]
        public ReadInterviewTranslationElementResponse[] Url { get; set; }

        [JsonProperty("headers")]
        public string Headers { get; set; }

        [JsonProperty("body")]
        public ReadInterviewTranslationElementResponse[] Body { get; set; }

        [JsonProperty("externalUri")]
        public string ExternalUri { get; set; }

        [JsonProperty("scriptType")]
        public ReadInterviewScriptTypeResponse ScriptType { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("hasRatingLabels")]
        public bool HasRatingLabels { get; set; }

        [JsonProperty("leftRatingLabel")]
        public ReadInterviewTranslationElementResponse[] LeftRatingLabel { get; set; }

        [JsonProperty("rightRatingLabel")]
        public ReadInterviewTranslationElementResponse[] RightRatingLabel { get; set; }

        [JsonProperty("condition")]
        public ReadDistributorListConditionDefinitionResponse Condition { get; set; }

        [JsonProperty("evaluateAsJson")]
        public bool EvaluateAsJson { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }

        [JsonProperty("arrangementMode")]
        public ReadInterviewArrangementModeResponse ArrangementMode { get; set; }

        [JsonProperty("enableAnimation")]
        public bool EnableAnimation { get; set; }

        [JsonProperty("useSmiley")]
        public bool UseSmiley { get; set; }

        [JsonProperty("hasPrompt")]
        public bool HasPrompt { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewElementTypeResponse
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

    public class ReadInterviewTranslationElementResponse
    {
        [JsonProperty("languageCode")]
        public string LanguageCode { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ReadInterviewChoiceResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("text")]
        public ReadInterviewTranslationElementResponse[] Text { get; set; }

        [JsonProperty("allowTextEntry")]
        public bool AllowTextEntry { get; set; }

        [JsonProperty("forceInput")]
        public bool ForceInput { get; set; }

        [JsonProperty("autocomplete")]
        public bool Autocomplete { get; set; }

        [JsonProperty("autocompleteText")]
        public ReadInterviewTranslationElementResponse[] AutocompleteText { get; set; }

        [JsonProperty("exclusive")]
        public bool Exclusive { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("contentValidation")]
        public ReadInterviewContentValidationResponse ContentValidation { get; set; }

        [JsonProperty("condition")]
        public ReadDistributorListConditionDefinitionResponse Condition { get; set; }

        [JsonProperty("autocompleteListVariable")]
        public string AutocompleteListVariable { get; set; }
    }

    public class ReadInterviewContentValidationResponse
    {
        [JsonProperty("validationType")]
        public ReadInterviewContentValidationTypeResponse ValidationType { get; set; }

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
    public enum ReadInterviewContentValidationTypeResponse
    {
        Invalid,
        None,
        Number,
        Email,
        Date,
        List,
        Real
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewColumnTypeResponse
    {
        Invalid,
        Single,
        Multiple
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewTextFieldSizeResponse
    {
        Invalid,
        Small,
        Medium,
        Large
    }

    public class ReadInterviewColumnGroupResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public ReadInterviewTranslationElementResponse[] Text { get; set; }

        [JsonProperty("hasNotAvailableChoice")]
        public bool HasNotAvailableChoice { get; set; }

        [JsonProperty("notAvailableChoiceText")]
        public ReadInterviewTranslationElementResponse[] NotAvailableChoiceText { get; set; }

        [JsonProperty("randomizeColumns")]
        public bool RandomizeColumns { get; set; }

        [JsonProperty("prompt")]
        public ReadInterviewTranslationElementResponse[] Prompt { get; set; }

        [JsonProperty("choiceType")]
        public ReadInterviewChoiceTypeResponse ChoiceType { get; set; }

        [JsonProperty("choices")]
        public ReadInterviewChoiceResponse[] Choices { get; set; }

        [JsonProperty("condition")]
        public ReadDistributorListConditionDefinitionResponse Condition { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewChoiceTypeResponse
    {
        Invalid,
        Single,
        Multiple,
        Dropdown,
        Text,
        StarScale
    }

    public class ReadInterviewMinMaxChoiceResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("codeManuallyChanged")]
        public bool CodeManuallyChanged { get; set; }

        [JsonProperty("leftText")]
        public ReadInterviewTranslationElementResponse[] LeftText { get; set; }

        [JsonProperty("rightText")]
        public ReadInterviewTranslationElementResponse[] RightText { get; set; }

        [JsonProperty("excludeFromRandomization")]
        public bool ExcludeFromRandomization { get; set; }

        [JsonProperty("condition")]
        public ReadDistributorListConditionDefinitionResponse Condition { get; set; }
    }

    public class ReadInterviewActionElementResponse
    {
        [JsonProperty("actionType")]
        public ReadInterviewActionTypeResponse ActionType { get; set; }

        [JsonProperty("endOfSurveyText")]
        public ReadInterviewTranslationElementResponse[] EndOfSurveyText { get; set; }

        [JsonProperty("forwardUrl")]
        public ReadInterviewTranslationElementResponse[] ForwardUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewActionTypeResponse
    {
        Invalid,
        ShowEndOfSurveyText,
        ForwardToUrl
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewValueAssignmentTypeResponse
    {
        Invalid,
        Custom,
        Panel,
        Survey,
        Credit
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewExecutionBehaviorResponse
    {
        Invalid,
        AnyTime,
        FirstTime,
        EachTime,
        SurveyLoad
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewApiCallMethodResponse
    {
        Invalid,
        Get,
        Post
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewScriptTypeResponse
    {
        Invalid,
        JavaScript,
        Css
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadInterviewArrangementModeResponse
    {
        Invalid,
        Cubic,
        Circular
    }

    public class ReadInterviewCustomVariableResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("variableName")]
        public string VariableName { get; set; }

        [JsonProperty("variableType")]
        public ReadDistributorListVariableTypeResponse VariableType { get; set; }
    }

    public class ReadInterviewBodyInput
    {
        public ReadInterviewBodyInput(string tenant, string interviewId, int surveyId)
        {
            this.Tenant = tenant;
            this.InterviewId = interviewId;
            this.SurveyId = surveyId;
        }

        [JsonProperty("tenant", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Tenant { get; set; }

        [JsonProperty("interviewId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string InterviewId { get; set; }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }

        [JsonProperty("loadSurveyDefinition")]
        public bool? LoadSurveyDefinition { get; set; }
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

    public class ReadInterviewListBodyInput
    {
        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }

        [JsonProperty("fieldsToDownload")]
        public string[] FieldsToDownload { get; set; }

        [JsonProperty("loadCodePlan")]
        public bool? LoadCodePlan { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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
        public ReadMemberListMemberResponse[] Members { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadMemberListMemberResponse
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
        public ReadMemberListInterviewResponse[] Interviews { get; set; }
    }

    public class ReadMemberListInterviewResponse
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

    public class ReadMemberListBodyInput
    {
        public ReadMemberListBodyInput(int panelId, bool interviewsRequired)
        {
            this.PanelId = panelId;
            this.InterviewsRequired = interviewsRequired;
        }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("interviewsRequired", DefaultValueHandling = DefaultValueHandling.Include)]
        public bool InterviewsRequired { get; set; }

        [JsonProperty("fieldsToDownload")]
        public string[] FieldsToDownload { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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

    public class ReadMessageTemplateListBodyInput
    {
        public ReadMessageTemplateListBodyInput(string language)
        {
            this.Language = language;
        }

        [JsonProperty("workspaceId")]
        public int? WorkspaceId { get; set; }

        [JsonProperty("language", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Language { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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

    public class ReadOptOutListBodyInput
    {
        [JsonProperty("panelId")]
        public int? PanelId { get; set; }

        [JsonProperty("workspaceId")]
        public int? WorkspaceId { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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
        public ReadInterviewDataAccessControlResponse DataAccessControl { get; set; }
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
        public ReadDistributorListVariableTypeResponse PanelFieldType { get; set; }

        [JsonProperty("metadata")]
        public JToken Metadata { get; set; }
    }

    public class ReadPanelBodyInput
    {
        public ReadPanelBodyInput(int panelId)
        {
            this.PanelId = panelId;
        }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }
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
        public ReadDistributorListConditionDefinitionResponse[] Conditions { get; set; }
    }

    public class ReadSamplingProjectBodyInput
    {
        [JsonProperty("samplingProjectId")]
        public int? SamplingProjectId { get; set; }
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

    public class ReadSurveyLinksBodyInput
    {
        [JsonProperty("surveyId")]
        public int? SurveyId { get; set; }
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

    public class ReadSurveyListBodyInput
    {
        public ReadSurveyListBodyInput(int workspaceId)
        {
            this.WorkspaceId = workspaceId;
        }

        [JsonProperty("workspaceId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int WorkspaceId { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
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
        public ReadInterviewSurveyDefinitionResponse Survey { get; set; }

        [JsonProperty("surveyConfiguration")]
        public ReadSurveySurveyConfigurationResponse SurveyConfiguration { get; set; }

        [JsonProperty("isSuccess")]
        public bool IsSuccess { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("errorCode")]
        public string ErrorCode { get; set; }
    }

    public class ReadSurveySurveyConfigurationResponse
    {
        [JsonProperty("designConfiguration")]
        public ReadSurveyDesignConfigurationResponse DesignConfiguration { get; set; }

        [JsonProperty("anonymizingConfiguration")]
        public ReadSurveyAnonymizingConfigurationResponse AnonymizingConfiguration { get; set; }
    }

    public class ReadSurveyDesignConfigurationResponse
    {
        [JsonProperty("surveyDesignLayout")]
        public int SurveyDesignLayout { get; set; }

        [JsonProperty("matrixSubQuestionSize")]
        public ReadSurveyMatrixSubQuestionSizeResponse MatrixSubQuestionSize { get; set; }

        [JsonProperty("textBlocks")]
        public ReadSurveyTextBlockResponse[] TextBlocks { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadSurveyMatrixSubQuestionSizeResponse
    {
        M,
        S,
        L,
        Xl
    }

    public class ReadSurveyTextBlockResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("text")]
        public ReadInterviewTranslationElementResponse[] Text { get; set; }
    }

    public class ReadSurveyAnonymizingConfigurationResponse
    {
        [JsonProperty("anonymizingMode")]
        public ReadSurveyAnonymizingModeResponse AnonymizingMode { get; set; }

        [JsonProperty("logIp")]
        public bool LogIp { get; set; }

        [JsonProperty("logUserAgent")]
        public bool LogUserAgent { get; set; }

        [JsonProperty("logReferer")]
        public bool LogReferer { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ReadSurveyAnonymizingModeResponse
    {
        Invalid,
        Personalized,
        Anonymous
    }

    public class ReadSurveyBodyInput
    {
        public ReadSurveyBodyInput(int surveyId)
        {
            this.SurveyId = surveyId;
        }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }
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
        public ReadWebHookListEventTypeResponse EventType { get; set; }

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
    public enum ReadWebHookListEventTypeResponse
    {
        Invalid,
        InterviewComplete,
        ApprovalRequest
    }

    public class ReadWebHookListBodyInput
    {
        [JsonProperty("eventType")]
        public CreateWebHookEventType? EventType { get; set; }

        [JsonProperty("entityIdentifier")]
        public string EntityIdentifier { get; set; }
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

    public class ReadWorkflowTransitionsBodyInput
    {
        public ReadWorkflowTransitionsBodyInput(WorkflowType workflow, string currentState)
        {
            this.Workflow = workflow;
            this.CurrentState = currentState;
        }

        [JsonProperty("workflow", DefaultValueHandling = DefaultValueHandling.Include)]
        public WorkflowType Workflow { get; set; }

        [JsonProperty("currentState", DefaultValueHandling = DefaultValueHandling.Include)]
        public string CurrentState { get; set; }
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

    public class RedeemIncentiveCodeBodyInput
    {
        public RedeemIncentiveCodeBodyInput(int incentiveId)
        {
            this.IncentiveId = incentiveId;
        }

        [JsonProperty("incentiveId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int IncentiveId { get; set; }
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

    public class RemindMembersBodyInput
    {
        public RemindMembersBodyInput(int distributorId, int messageTemplateId)
        {
            this.DistributorId = distributorId;
            this.MessageTemplateId = messageTemplateId;
        }

        [JsonProperty("distributorId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int DistributorId { get; set; }

        [JsonProperty("messageTemplateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int MessageTemplateId { get; set; }

        [JsonProperty("textBlocks")]
        public CreateAndInviteMembersTextBlock[] TextBlocks { get; set; }

        [JsonProperty("scheduleDateTime")]
        public string ScheduleDateTime { get; set; }

        [JsonProperty("conditions")]
        public CreateSurveyCondition[] Conditions { get; set; }

        [JsonProperty("channel")]
        public CreateAndInviteMembersDistributionChannel? Channel { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("replyTo")]
        public string ReplyTo { get; set; }

        [JsonProperty("replyToName")]
        public string ReplyToName { get; set; }
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

    public class UpdatePanelBodyInput
    {
        public UpdatePanelBodyInput(int panelId)
        {
            this.PanelId = panelId;
        }

        [JsonProperty("tenant")]
        public string Tenant { get; set; }

        [JsonProperty("panelId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int PanelId { get; set; }

        [JsonProperty("addedFields")]
        public PanelMemberField[] AddedFields { get; set; }

        [JsonProperty("removedFields")]
        public int[] RemovedFields { get; set; }

        [JsonProperty("renamedFields")]
        public PanelMemberField[] RenamedFields { get; set; }
    }

    public class PanelMemberField
    {
        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PanelMemberFieldType? Type { get; set; }

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
        Guid,
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

    public class UpdateSurveyBodyInput
    {
        public UpdateSurveyBodyInput(int surveyId, CreateSurveySurveyDefinition surveyDefinition)
        {
            this.SurveyId = surveyId;
            this.SurveyDefinition = surveyDefinition;
        }

        [JsonProperty("surveyId", DefaultValueHandling = DefaultValueHandling.Include)]
        public int SurveyId { get; set; }

        [JsonProperty("surveyName")]
        public string SurveyName { get; set; }

        [JsonProperty("surveyDefinition", DefaultValueHandling = DefaultValueHandling.Include)]
        public CreateSurveySurveyDefinition SurveyDefinition { get; set; }

        [JsonProperty("surveyConfiguration")]
        public CreateSurveySurveyConfiguration SurveyConfiguration { get; set; }
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

    public class UpdateWebHookBodyInput
    {
        [JsonProperty("webHookId")]
        public string WebHookId { get; set; }

        [JsonProperty("eventType")]
        public CreateWebHookEventType? EventType { get; set; }

        [JsonProperty("entityIdentifier")]
        public string EntityIdentifier { get; set; }

        [JsonProperty("securityToken")]
        public string SecurityToken { get; set; }

        [JsonProperty("webHookUrl")]
        public string WebHookUrl { get; set; }
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

    public class WriteOptOutListBodyInput
    {
        [JsonProperty("workspaceId")]
        public int? WorkspaceId { get; set; }

        [JsonProperty("panelId")]
        public int? PanelId { get; set; }

        [JsonProperty("distributorId")]
        public int? DistributorId { get; set; }

        [JsonProperty("emails")]
        public EmailItem[] Emails { get; set; }

        [JsonProperty("cellPhones")]
        public CellPhoneItem[] CellPhones { get; set; }
    }

    public class EmailItem
    {
        public EmailItem(string email, OptOutOperation optOutOperation)
        {
            this.Email = email;
            this.OptOutOperation = optOutOperation;
        }

        [JsonProperty("email", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Email { get; set; }

        [JsonProperty("optOutOperation", DefaultValueHandling = DefaultValueHandling.Include)]
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
        public CellPhoneItem(int cellPhone, OptOutOperation optOutOperation)
        {
            this.CellPhone = cellPhone;
            this.OptOutOperation = optOutOperation;
        }

        [JsonProperty("cellPhone", DefaultValueHandling = DefaultValueHandling.Include)]
        public int CellPhone { get; set; }

        [JsonProperty("optOutOperation", DefaultValueHandling = DefaultValueHandling.Include)]
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