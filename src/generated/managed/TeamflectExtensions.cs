//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamflect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamflectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyfeedbackProvider, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate)
        {
            var __workflow_bodyfeedbackSubject = WorkflowExpression.Compile(bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            var __workflow_bodyfeedbackProvider = WorkflowExpression.Compile(bodyfeedbackProvider, nameof(bodyfeedbackProvider), required: true);
            var __workflow_bodyrequestNote = WorkflowExpression.Compile(bodyrequestNote, nameof(bodyrequestNote), required: true);
            var __workflow_bodytemplateTitle = WorkflowExpression.Compile(bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            var __workflow_bodydueDays = WorkflowExpression.Compile(bodydueDays, nameof(bodydueDays), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: true);
            return new DeferredBodyAction<Feedback>(() =>
            {
                var apiCallPath = "/feedback/sendFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = ExpressionConverter.ConvertO(__workflow_bodyfeedbackSubject);
                bodypropCount++;
                body["feedbackRequestReceiverUPNorId"] = ExpressionConverter.ConvertO(__workflow_bodyfeedbackProvider);
                bodypropCount++;
                body["feedbackNote"] = ExpressionConverter.ConvertO(__workflow_bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = ExpressionConverter.ConvertO(__workflow_bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = ExpressionConverter.ConvertO(__workflow_bodydueDays);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Feedback>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendExternalFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyexternalEmail, Expression<Func<string>> bodyproviderName, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate, Expression<Func<bool>> bodyisAnonymous)
        {
            var __workflow_bodyfeedbackSubject = WorkflowExpression.Compile(bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            var __workflow_bodyexternalEmail = WorkflowExpression.Compile(bodyexternalEmail, nameof(bodyexternalEmail), required: true);
            var __workflow_bodyproviderName = WorkflowExpression.Compile(bodyproviderName, nameof(bodyproviderName), required: true);
            var __workflow_bodyrequestNote = WorkflowExpression.Compile(bodyrequestNote, nameof(bodyrequestNote), required: true);
            var __workflow_bodytemplateTitle = WorkflowExpression.Compile(bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            var __workflow_bodydueDays = WorkflowExpression.Compile(bodydueDays, nameof(bodydueDays), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyisAnonymous = WorkflowExpression.Compile(bodyisAnonymous, nameof(bodyisAnonymous), required: true);
            return new DeferredBodyAction<Feedback>(() =>
            {
                var apiCallPath = "/feedback/sendExternalFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = ExpressionConverter.ConvertO(__workflow_bodyfeedbackSubject);
                bodypropCount++;
                body["externalEmail"] = ExpressionConverter.ConvertO(__workflow_bodyexternalEmail);
                bodypropCount++;
                body["onBehalfName"] = ExpressionConverter.ConvertO(__workflow_bodyproviderName);
                bodypropCount++;
                body["feedbackNote"] = ExpressionConverter.ConvertO(__workflow_bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = ExpressionConverter.ConvertO(__workflow_bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = ExpressionConverter.ConvertO(__workflow_bodydueDays);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                bodypropCount++;
                body["isAnonymous"] = ExpressionConverter.ConvertO(__workflow_bodyisAnonymous);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Feedback>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> GetGoal(Expression<Func<string>> goalId)
        {
            var __workflow_goalId = WorkflowExpression.Compile(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/getGoal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["goalId"] = ExpressionConverter.Convert(__workflow_goalId);
                return new ApiConnectionAction<Goal>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal[]> GetGoals(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<string>> selectedLabels = null, Expression<Func<string>> limit = null, Expression<Func<string>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_userOID = WorkflowExpression.Compile(userOID, nameof(userOID), required: false);
            var __workflow_userUPN = WorkflowExpression.Compile(userUPN, nameof(userUPN), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_selectedLabels = WorkflowExpression.Compile(selectedLabels, nameof(selectedLabels), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<Goal[]>(() =>
            {
                var apiCallPath = "/goal/getGoals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userOID != null)
                    callPayload.Queries["userOID"] = ExpressionConverter.Convert(__workflow_userOID);
                if (__workflow_userUPN != null)
                    callPayload.Queries["userUPN"] = ExpressionConverter.Convert(__workflow_userUPN);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_selectedLabels != null)
                    callPayload.Queries["selectedLabels"] = ExpressionConverter.Convert(__workflow_selectedLabels);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<Goal[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> UpdateGoal(Expression<Func<string>> bodygoalID, Expression<Func<string>> bodynewProgressValue, Expression<Func<bodyupdaterTypeInput>> bodyupdaterType, Expression<Func<string>> bodysystemName, Expression<Func<string>> bodyupdateComment = null, Expression<Func<string>> bodynewStatus = null)
        {
            var __workflow_bodygoalID = WorkflowExpression.Compile(bodygoalID, nameof(bodygoalID), required: true);
            var __workflow_bodynewProgressValue = WorkflowExpression.Compile(bodynewProgressValue, nameof(bodynewProgressValue), required: true);
            var __workflow_bodyupdaterType = WorkflowExpression.Compile(bodyupdaterType, nameof(bodyupdaterType), required: true);
            var __workflow_bodysystemName = WorkflowExpression.Compile(bodysystemName, nameof(bodysystemName), required: true);
            var __workflow_bodyupdateComment = WorkflowExpression.Compile(bodyupdateComment, nameof(bodyupdateComment), required: false);
            var __workflow_bodynewStatus = WorkflowExpression.Compile(bodynewStatus, nameof(bodynewStatus), required: false);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/updateProgress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["goalId"] = ExpressionConverter.ConvertO(__workflow_bodygoalID);
                bodypropCount++;
                body["newValue"] = ExpressionConverter.ConvertO(__workflow_bodynewProgressValue);
                if (__workflow_bodyupdateComment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(__workflow_bodyupdateComment);
                    bodypropCount++;
                }

                if (__workflow_bodynewStatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(__workflow_bodynewStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["goalUpdater"] = ExpressionConverter.ConvertO(__workflow_bodyupdaterType);
                bodypropCount++;
                body["goalUpdaterSystemName"] = ExpressionConverter.ConvertO(__workflow_bodysystemName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> CreateGoal(Expression<Func<string>> bodygoalTitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydueDate, Expression<Func<string>> bodygoalType, Expression<Func<object>> bodygoalOwner, Expression<Func<string>> bodygoalCreator, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyprogressFormat, Expression<Func<string>> bodycurrencyCode, Expression<Func<double>> bodyinitialValue, Expression<Func<double>> bodytargetValue, Expression<Func<string>> bodyparentGoalID, Expression<Func<bool>> bodynotifyOwner)
        {
            var __workflow_bodygoalTitle = WorkflowExpression.Compile(bodygoalTitle, nameof(bodygoalTitle), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodystartDate = WorkflowExpression.Compile(bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodydueDate = WorkflowExpression.Compile(bodydueDate, nameof(bodydueDate), required: true);
            var __workflow_bodygoalType = WorkflowExpression.Compile(bodygoalType, nameof(bodygoalType), required: true);
            var __workflow_bodygoalOwner = WorkflowExpression.Compile(bodygoalOwner, nameof(bodygoalOwner), required: true);
            var __workflow_bodygoalCreator = WorkflowExpression.Compile(bodygoalCreator, nameof(bodygoalCreator), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyprogressFormat = WorkflowExpression.Compile(bodyprogressFormat, nameof(bodyprogressFormat), required: true);
            var __workflow_bodycurrencyCode = WorkflowExpression.Compile(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyinitialValue = WorkflowExpression.Compile(bodyinitialValue, nameof(bodyinitialValue), required: true);
            var __workflow_bodytargetValue = WorkflowExpression.Compile(bodytargetValue, nameof(bodytargetValue), required: true);
            var __workflow_bodyparentGoalID = WorkflowExpression.Compile(bodyparentGoalID, nameof(bodyparentGoalID), required: true);
            var __workflow_bodynotifyOwner = WorkflowExpression.Compile(bodynotifyOwner, nameof(bodynotifyOwner), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/createNewGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodygoalTitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(__workflow_bodystartDate);
                bodypropCount++;
                body["dueDate"] = ExpressionConverter.ConvertO(__workflow_bodydueDate);
                bodypropCount++;
                body["goalType"] = ExpressionConverter.ConvertO(__workflow_bodygoalType);
                bodypropCount++;
                body["goalOwnerUPNorId"] = ExpressionConverter.ConvertO(__workflow_bodygoalOwner);
                bodypropCount++;
                body["goalCreatorUPNorId"] = ExpressionConverter.ConvertO(__workflow_bodygoalCreator);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                bodypropCount++;
                body["progressFormatType"] = ExpressionConverter.ConvertO(__workflow_bodyprogressFormat);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(__workflow_bodycurrencyCode);
                bodypropCount++;
                body["initialValue"] = ExpressionConverter.ConvertO(__workflow_bodyinitialValue);
                bodypropCount++;
                body["targetValue"] = ExpressionConverter.ConvertO(__workflow_bodytargetValue);
                bodypropCount++;
                body["parentGoalId"] = ExpressionConverter.ConvertO(__workflow_bodyparentGoalID);
                bodypropCount++;
                body["sendNotificationToOwner"] = ExpressionConverter.ConvertO(__workflow_bodynotifyOwner);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> AddCommentGoal(Expression<Func<string>> commentidOfTheGoal, Expression<Func<string>> commentobjectIdOrUserPrincipalNameOfTheCommenter, Expression<Func<string>> commentcommentItself)
        {
            var __workflow_commentidOfTheGoal = WorkflowExpression.Compile(commentidOfTheGoal, nameof(commentidOfTheGoal), required: true);
            var __workflow_commentobjectIdOrUserPrincipalNameOfTheCommenter = WorkflowExpression.Compile(commentobjectIdOrUserPrincipalNameOfTheCommenter, nameof(commentobjectIdOrUserPrincipalNameOfTheCommenter), required: true);
            var __workflow_commentcommentItself = WorkflowExpression.Compile(commentcommentItself, nameof(commentcommentItself), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/commentGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["goalId"] = ExpressionConverter.ConvertO(__workflow_commentidOfTheGoal);
                commentpropCount++;
                comment["commenterIdOrUPN"] = ExpressionConverter.ConvertO(__workflow_commentobjectIdOrUserPrincipalNameOfTheCommenter);
                commentpropCount++;
                comment["commentText"] = ExpressionConverter.ConvertO(__workflow_commentcommentItself);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse> GetRecognition(Expression<Func<string>> recognitionId)
        {
            var __workflow_recognitionId = WorkflowExpression.Compile(recognitionId, nameof(recognitionId), required: true);
            return new DeferredBodyAction<RecognitionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/recognition/{0}", __workflow_recognitionId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecognitionResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse[]> GetRecognitions(Expression<Func<string[]>> bodyrecipientsToSearch, Expression<Func<string>> bodyrecognitionTitle, Expression<Func<string>> bodyupdateDate, Expression<Func<string>> bodycreationDate)
        {
            var __workflow_bodyrecipientsToSearch = WorkflowExpression.Compile(bodyrecipientsToSearch, nameof(bodyrecipientsToSearch), required: true);
            var __workflow_bodyrecognitionTitle = WorkflowExpression.Compile(bodyrecognitionTitle, nameof(bodyrecognitionTitle), required: true);
            var __workflow_bodyupdateDate = WorkflowExpression.Compile(bodyupdateDate, nameof(bodyupdateDate), required: true);
            var __workflow_bodycreationDate = WorkflowExpression.Compile(bodycreationDate, nameof(bodycreationDate), required: true);
            return new DeferredBodyAction<RecognitionResponse[]>(() =>
            {
                var apiCallPath = "/recognition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = ExpressionConverter.ConvertO(__workflow_bodyrecipientsToSearch);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionTitle);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(__workflow_bodyupdateDate);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(__workflow_bodycreationDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RecognitionResponse[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionCreateResponse> CreateRecognition(Expression<Func<string>> bodyrecognitionSender, Expression<Func<string[]>> bodyrecognitionRecipients, Expression<Func<string>> bodybadgeTitle, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyrecognitionMessage)
        {
            var __workflow_bodyrecognitionSender = WorkflowExpression.Compile(bodyrecognitionSender, nameof(bodyrecognitionSender), required: true);
            var __workflow_bodyrecognitionRecipients = WorkflowExpression.Compile(bodyrecognitionRecipients, nameof(bodyrecognitionRecipients), required: true);
            var __workflow_bodybadgeTitle = WorkflowExpression.Compile(bodybadgeTitle, nameof(bodybadgeTitle), required: true);
            var __workflow_bodyisPrivate = WorkflowExpression.Compile(bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyrecognitionMessage = WorkflowExpression.Compile(bodyrecognitionMessage, nameof(bodyrecognitionMessage), required: true);
            return new DeferredBodyAction<RecognitionCreateResponse>(() =>
            {
                var apiCallPath = "/recognition/createNewRecognitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["senderIdOrUPN"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionSender);
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionRecipients);
                bodypropCount++;
                body["badgeTitle"] = ExpressionConverter.ConvertO(__workflow_bodybadgeTitle);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(__workflow_bodyisPrivate);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodyrecognitionMessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RecognitionCreateResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/task/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject[]> GetTasks(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<double>> limit = null, Expression<Func<double>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_userOID = WorkflowExpression.Compile(userOID, nameof(userOID), required: false);
            var __workflow_userUPN = WorkflowExpression.Compile(userUPN, nameof(userUPN), required: false);
            var __workflow_search = WorkflowExpression.Compile(search, nameof(search), required: false);
            var __workflow_limit = WorkflowExpression.Compile(limit, nameof(limit), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_startDate = WorkflowExpression.Compile(startDate, nameof(startDate), required: false);
            var __workflow_endDate = WorkflowExpression.Compile(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<TaskObject[]>(() =>
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_userOID != null)
                    callPayload.Queries["userOID"] = ExpressionConverter.Convert(__workflow_userOID);
                if (__workflow_userUPN != null)
                    callPayload.Queries["userUPN"] = ExpressionConverter.Convert(__workflow_userUPN);
                if (__workflow_search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(__workflow_search);
                if (__workflow_limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(__workflow_limit);
                if (__workflow_skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(__workflow_startDate);
                if (__workflow_endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(__workflow_endDate);
                return new ApiConnectionAction<TaskObject[]>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<User> GetUser(Expression<Func<string>> userMail)
        {
            var __workflow_userMail = WorkflowExpression.Compile(userMail, nameof(userMail), required: true);
            return new DeferredBodyAction<User>(() =>
            {
                var apiCallPath = "/user/getUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userMail"] = ExpressionConverter.Convert(__workflow_userMail);
                return new ApiConnectionAction<User>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IWorkflowAction UpdateUser(Expression<Func<string>> bodyuserEmail = null, Expression<Func<bodyuserAttributesInputItem[]>> bodyuserAttributes = null)
        {
            var __workflow_bodyuserEmail = WorkflowExpression.Compile(bodyuserEmail, nameof(bodyuserEmail), required: false);
            var __workflow_bodyuserAttributes = WorkflowExpression.Compile(bodyuserAttributes, nameof(bodyuserAttributes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/user/updateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyuserEmail != null)
                {
                    body["userMail"] = ExpressionConverter.ConvertO(__workflow_bodyuserEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyuserAttributes != null)
                {
                    body["userAttributes"] = ExpressionConverter.ConvertO(__workflow_bodyuserAttributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class TeamflectTriggers([ConnectionName] string connectionId)
    {
    }

    public class Feedback
    {
        [JsonProperty("id")]
        public string FeedbackID { get; set; }

        [JsonProperty("createdAt")]
        public string CreationDate { get; set; }

        [JsonProperty("createdBy")]
        public FeedbackCreatedByType CreatedBy { get; set; }

        [JsonProperty("feedbackAboutUser")]
        public FeedbackFeedbackSubjectType FeedbackSubject { get; set; }

        [JsonProperty("feedbackRequestRecipient")]
        public FeedbackFeedbackRequestRecipientType FeedbackRequestRecipient { get; set; }

        [JsonProperty("note")]
        public string Note { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }
    }

    public class FeedbackCreatedByType
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class FeedbackFeedbackSubjectType
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class FeedbackFeedbackRequestRecipientType
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class Goal
    {
        [JsonProperty("createdBy")]
        public GoalCreatedByType CreatedBy { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("owners")]
        public GoalOwnersTypeItem[] Owners { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("goalType")]
        public string GoalType { get; set; }

        [JsonProperty("isPrivate")]
        public bool IsPrivate { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("relatedGroups")]
        public JToken[] RelatedGroups { get; set; }

        [JsonProperty("labels")]
        public GoalLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("parentGoal")]
        public GoalParentGoalType ParentGoal { get; set; }

        [JsonProperty("progress")]
        public GoalProgressType Progress { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("outcome")]
        public string Outcome { get; set; }
    }

    public class GoalCreatedByType
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class GoalOwnersTypeItem
    {
        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }
    }

    public class GoalLabelsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class GoalParentGoalType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GoalProgressType
    {
        [JsonProperty("formatType")]
        public string FormatType { get; set; }

        [JsonProperty("initialValue")]
        public double InitialValue { get; set; }

        [JsonProperty("targetValue")]
        public double TargetValue { get; set; }

        [JsonProperty("currentValue")]
        public double CurrentValue { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyupdaterTypeInput
    {
        Owner,
        System
    }

    public class RecognitionResponse
    {
        [JsonProperty("recipients")]
        public RecognitionResponseRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("badge")]
        public RecognitionResponseBadgeType Badge { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public RecognitionResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("likes")]
        public JToken[] Likes { get; set; }
    }

    public class RecognitionResponseRecipientsTypeItem
    {
        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }
    }

    public class RecognitionResponseBadgeType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("bgImage")]
        public string BgImage { get; set; }

        [JsonProperty("updatedBy")]
        public RecognitionResponseBadgeTypeUpdatedByType UpdatedBy { get; set; }
    }

    public class RecognitionResponseBadgeTypeUpdatedByType
    {
        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }
    }

    public class RecognitionResponseCommentsTypeItem
    {
        [JsonProperty("user")]
        public RecognitionResponseCommentsTypeItemUserType User { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class RecognitionResponseCommentsTypeItemUserType
    {
        [JsonProperty("businessPhones")]
        public string[] BusinessPhones { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class RecognitionCreateResponse
    {
        [JsonProperty("successfullyTransactions")]
        public RecognitionCreateResponseSuccessfullyTransactionsTypeItem[] SuccessfullyTransactions { get; set; }

        [JsonProperty("failedTransactions")]
        public string[] FailedTransactions { get; set; }
    }

    public class RecognitionCreateResponseSuccessfullyTransactionsTypeItem
    {
        [JsonProperty("transactionId")]
        public string TransactionId { get; set; }

        [JsonProperty("recipients")]
        public RecognitionCreateResponseSuccessfullyTransactionsTypeItemRecipientsTypeItem[] Recipients { get; set; }

        [JsonProperty("badge")]
        public RecognitionCreateResponseSuccessfullyTransactionsTypeItemBadgeType Badge { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("comments")]
        public JToken[] Comments { get; set; }

        [JsonProperty("likes")]
        public JToken[] Likes { get; set; }
    }

    public class RecognitionCreateResponseSuccessfullyTransactionsTypeItemRecipientsTypeItem
    {
        [JsonProperty("mail")]
        public string Mail { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }
    }

    public class RecognitionCreateResponseSuccessfullyTransactionsTypeItemBadgeType
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("bgImage")]
        public string BgImage { get; set; }

        [JsonProperty("rank")]
        public double Rank { get; set; }
    }

    public class TaskObject
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("assignedTo")]
        public TaskObjectAssignedToTypeItem[] AssignedTo { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }

        [JsonProperty("labels")]
        public string[] Labels { get; set; }

        [JsonProperty("descriptionAttachments")]
        public JToken[] DescriptionAttachments { get; set; }
    }

    public class TaskObjectAssignedToTypeItem
    {
        [JsonProperty("user")]
        public TaskObjectAssignedToTypeItemUserType User { get; set; }

        [JsonProperty("individualComments")]
        public JToken[] IndividualComments { get; set; }
    }

    public class TaskObjectAssignedToTypeItemUserType
    {
        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class User
    {
        [JsonProperty("userPrincipalName")]
        public string UserPrincipalName { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("lastLoginDate")]
        public string LastLoginDate { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("employeeHireDate")]
        public string EmployeeHireDate { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("hasManager")]
        public bool HasManager { get; set; }

        [JsonProperty("isManager")]
        public bool IsManager { get; set; }

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("officeLocation")]
        public string OfficeLocation { get; set; }

        [JsonProperty("preferredLanguage")]
        public string PreferredLanguage { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("attachments")]
        public JToken[] Attachments { get; set; }
    }

    public class bodyuserAttributesInputItem
    {
        [JsonProperty("label")]
        public string AttributeLabel { get; set; }

        [JsonProperty("value")]
        public string AttributeValue { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Teamflect;

    public partial class WorkflowManagedActions
    {
        public TeamflectActions Teamflect(string connectionId) => new TeamflectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TeamflectTriggers Teamflect(string connectionId) => new TeamflectTriggers(connectionId);
    }
}
