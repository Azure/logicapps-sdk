//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamflect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class TeamflectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyfeedbackProvider, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate)
        {
            var __workflow_bodyfeedbackSubject = bodyfeedbackSubject == null ? null : WorkflowExpression.Compile(bodyfeedbackSubject);
            WorkflowExpression.Validate(__workflow_bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            var __workflow_bodyfeedbackProvider = bodyfeedbackProvider == null ? null : WorkflowExpression.Compile(bodyfeedbackProvider);
            WorkflowExpression.Validate(__workflow_bodyfeedbackProvider, nameof(bodyfeedbackProvider), required: true);
            var __workflow_bodyrequestNote = bodyrequestNote == null ? null : WorkflowExpression.Compile(bodyrequestNote);
            WorkflowExpression.Validate(__workflow_bodyrequestNote, nameof(bodyrequestNote), required: true);
            var __workflow_bodytemplateTitle = bodytemplateTitle == null ? null : WorkflowExpression.Compile(bodytemplateTitle);
            WorkflowExpression.Validate(__workflow_bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            var __workflow_bodydueDays = bodydueDays == null ? null : WorkflowExpression.Compile(bodydueDays);
            WorkflowExpression.Validate(__workflow_bodydueDays, nameof(bodydueDays), required: true);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendExternalFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyexternalEmail, Expression<Func<string>> bodyproviderName, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate, Expression<Func<bool>> bodyisAnonymous)
        {
            var __workflow_bodyfeedbackSubject = bodyfeedbackSubject == null ? null : WorkflowExpression.Compile(bodyfeedbackSubject);
            WorkflowExpression.Validate(__workflow_bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            var __workflow_bodyexternalEmail = bodyexternalEmail == null ? null : WorkflowExpression.Compile(bodyexternalEmail);
            WorkflowExpression.Validate(__workflow_bodyexternalEmail, nameof(bodyexternalEmail), required: true);
            var __workflow_bodyproviderName = bodyproviderName == null ? null : WorkflowExpression.Compile(bodyproviderName);
            WorkflowExpression.Validate(__workflow_bodyproviderName, nameof(bodyproviderName), required: true);
            var __workflow_bodyrequestNote = bodyrequestNote == null ? null : WorkflowExpression.Compile(bodyrequestNote);
            WorkflowExpression.Validate(__workflow_bodyrequestNote, nameof(bodyrequestNote), required: true);
            var __workflow_bodytemplateTitle = bodytemplateTitle == null ? null : WorkflowExpression.Compile(bodytemplateTitle);
            WorkflowExpression.Validate(__workflow_bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            var __workflow_bodydueDays = bodydueDays == null ? null : WorkflowExpression.Compile(bodydueDays);
            WorkflowExpression.Validate(__workflow_bodydueDays, nameof(bodydueDays), required: true);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyisAnonymous = bodyisAnonymous == null ? null : WorkflowExpression.Compile(bodyisAnonymous);
            WorkflowExpression.Validate(__workflow_bodyisAnonymous, nameof(bodyisAnonymous), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> GetGoal(Expression<Func<string>> goalId)
        {
            var __workflow_goalId = goalId == null ? null : WorkflowExpression.Compile(goalId);
            WorkflowExpression.Validate(__workflow_goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/getGoal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["goalId"] = ExpressionConverter.Convert(__workflow_goalId);
                return new ApiConnectionAction<Goal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal[]> GetGoals(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<string>> selectedLabels = null, Expression<Func<string>> limit = null, Expression<Func<string>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_userOID = userOID == null ? null : WorkflowExpression.Compile(userOID);
            WorkflowExpression.Validate(__workflow_userOID, nameof(userOID), required: false);
            var __workflow_userUPN = userUPN == null ? null : WorkflowExpression.Compile(userUPN);
            WorkflowExpression.Validate(__workflow_userUPN, nameof(userUPN), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_selectedLabels = selectedLabels == null ? null : WorkflowExpression.Compile(selectedLabels);
            WorkflowExpression.Validate(__workflow_selectedLabels, nameof(selectedLabels), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> UpdateGoal(Expression<Func<string>> bodygoalID, Expression<Func<string>> bodynewProgressValue, Expression<Func<bodyupdaterTypeInput>> bodyupdaterType, Expression<Func<string>> bodysystemName, Expression<Func<string>> bodyupdateComment = null, Expression<Func<string>> bodynewStatus = null)
        {
            var __workflow_bodygoalID = bodygoalID == null ? null : WorkflowExpression.Compile(bodygoalID);
            WorkflowExpression.Validate(__workflow_bodygoalID, nameof(bodygoalID), required: true);
            var __workflow_bodynewProgressValue = bodynewProgressValue == null ? null : WorkflowExpression.Compile(bodynewProgressValue);
            WorkflowExpression.Validate(__workflow_bodynewProgressValue, nameof(bodynewProgressValue), required: true);
            var __workflow_bodyupdaterType = bodyupdaterType == null ? null : WorkflowExpression.Compile(bodyupdaterType);
            WorkflowExpression.Validate(__workflow_bodyupdaterType, nameof(bodyupdaterType), required: true);
            var __workflow_bodysystemName = bodysystemName == null ? null : WorkflowExpression.Compile(bodysystemName);
            WorkflowExpression.Validate(__workflow_bodysystemName, nameof(bodysystemName), required: true);
            var __workflow_bodyupdateComment = bodyupdateComment == null ? null : WorkflowExpression.Compile(bodyupdateComment);
            WorkflowExpression.Validate(__workflow_bodyupdateComment, nameof(bodyupdateComment), required: false);
            var __workflow_bodynewStatus = bodynewStatus == null ? null : WorkflowExpression.Compile(bodynewStatus);
            WorkflowExpression.Validate(__workflow_bodynewStatus, nameof(bodynewStatus), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> CreateGoal(Expression<Func<string>> bodygoalTitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydueDate, Expression<Func<string>> bodygoalType, Expression<Func<object>> bodygoalOwner, Expression<Func<string>> bodygoalCreator, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyprogressFormat, Expression<Func<string>> bodycurrencyCode, Expression<Func<double>> bodyinitialValue, Expression<Func<double>> bodytargetValue, Expression<Func<string>> bodyparentGoalID, Expression<Func<bool>> bodynotifyOwner)
        {
            var __workflow_bodygoalTitle = bodygoalTitle == null ? null : WorkflowExpression.Compile(bodygoalTitle);
            WorkflowExpression.Validate(__workflow_bodygoalTitle, nameof(bodygoalTitle), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            var __workflow_bodystartDate = bodystartDate == null ? null : WorkflowExpression.Compile(bodystartDate);
            WorkflowExpression.Validate(__workflow_bodystartDate, nameof(bodystartDate), required: true);
            var __workflow_bodydueDate = bodydueDate == null ? null : WorkflowExpression.Compile(bodydueDate);
            WorkflowExpression.Validate(__workflow_bodydueDate, nameof(bodydueDate), required: true);
            var __workflow_bodygoalType = bodygoalType == null ? null : WorkflowExpression.Compile(bodygoalType);
            WorkflowExpression.Validate(__workflow_bodygoalType, nameof(bodygoalType), required: true);
            var __workflow_bodygoalOwner = bodygoalOwner == null ? null : WorkflowExpression.Compile(bodygoalOwner);
            WorkflowExpression.Validate(__workflow_bodygoalOwner, nameof(bodygoalOwner), required: true);
            var __workflow_bodygoalCreator = bodygoalCreator == null ? null : WorkflowExpression.Compile(bodygoalCreator);
            WorkflowExpression.Validate(__workflow_bodygoalCreator, nameof(bodygoalCreator), required: true);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyprogressFormat = bodyprogressFormat == null ? null : WorkflowExpression.Compile(bodyprogressFormat);
            WorkflowExpression.Validate(__workflow_bodyprogressFormat, nameof(bodyprogressFormat), required: true);
            var __workflow_bodycurrencyCode = bodycurrencyCode == null ? null : WorkflowExpression.Compile(bodycurrencyCode);
            WorkflowExpression.Validate(__workflow_bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            var __workflow_bodyinitialValue = bodyinitialValue == null ? null : WorkflowExpression.Compile(bodyinitialValue);
            WorkflowExpression.Validate(__workflow_bodyinitialValue, nameof(bodyinitialValue), required: true);
            var __workflow_bodytargetValue = bodytargetValue == null ? null : WorkflowExpression.Compile(bodytargetValue);
            WorkflowExpression.Validate(__workflow_bodytargetValue, nameof(bodytargetValue), required: true);
            var __workflow_bodyparentGoalID = bodyparentGoalID == null ? null : WorkflowExpression.Compile(bodyparentGoalID);
            WorkflowExpression.Validate(__workflow_bodyparentGoalID, nameof(bodyparentGoalID), required: true);
            var __workflow_bodynotifyOwner = bodynotifyOwner == null ? null : WorkflowExpression.Compile(bodynotifyOwner);
            WorkflowExpression.Validate(__workflow_bodynotifyOwner, nameof(bodynotifyOwner), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> AddCommentGoal(Expression<Func<string>> commentidOfTheGoal, Expression<Func<string>> commentobjectIdOrUserPrincipalNameOfTheCommenter, Expression<Func<string>> commentcommentItself)
        {
            var __workflow_commentidOfTheGoal = commentidOfTheGoal == null ? null : WorkflowExpression.Compile(commentidOfTheGoal);
            WorkflowExpression.Validate(__workflow_commentidOfTheGoal, nameof(commentidOfTheGoal), required: true);
            var __workflow_commentobjectIdOrUserPrincipalNameOfTheCommenter = commentobjectIdOrUserPrincipalNameOfTheCommenter == null ? null : WorkflowExpression.Compile(commentobjectIdOrUserPrincipalNameOfTheCommenter);
            WorkflowExpression.Validate(__workflow_commentobjectIdOrUserPrincipalNameOfTheCommenter, nameof(commentobjectIdOrUserPrincipalNameOfTheCommenter), required: true);
            var __workflow_commentcommentItself = commentcommentItself == null ? null : WorkflowExpression.Compile(commentcommentItself);
            WorkflowExpression.Validate(__workflow_commentcommentItself, nameof(commentcommentItself), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse> GetRecognition(Expression<Func<string>> recognitionId)
        {
            var __workflow_recognitionId = recognitionId == null ? null : WorkflowExpression.Compile(recognitionId);
            WorkflowExpression.Validate(__workflow_recognitionId, nameof(recognitionId), required: true);
            return new DeferredBodyAction<RecognitionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recognition/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_recognitionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecognitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse[]> GetRecognitions(Expression<Func<string[]>> bodyrecipientsToSearch, Expression<Func<string>> bodyrecognitionTitle, Expression<Func<string>> bodyupdateDate, Expression<Func<string>> bodycreationDate)
        {
            var __workflow_bodyrecipientsToSearch = bodyrecipientsToSearch == null ? null : WorkflowExpression.Compile(bodyrecipientsToSearch);
            WorkflowExpression.Validate(__workflow_bodyrecipientsToSearch, nameof(bodyrecipientsToSearch), required: true);
            var __workflow_bodyrecognitionTitle = bodyrecognitionTitle == null ? null : WorkflowExpression.Compile(bodyrecognitionTitle);
            WorkflowExpression.Validate(__workflow_bodyrecognitionTitle, nameof(bodyrecognitionTitle), required: true);
            var __workflow_bodyupdateDate = bodyupdateDate == null ? null : WorkflowExpression.Compile(bodyupdateDate);
            WorkflowExpression.Validate(__workflow_bodyupdateDate, nameof(bodyupdateDate), required: true);
            var __workflow_bodycreationDate = bodycreationDate == null ? null : WorkflowExpression.Compile(bodycreationDate);
            WorkflowExpression.Validate(__workflow_bodycreationDate, nameof(bodycreationDate), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionCreateResponse> CreateRecognition(Expression<Func<string>> bodyrecognitionSender, Expression<Func<string[]>> bodyrecognitionRecipients, Expression<Func<string>> bodybadgeTitle, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyrecognitionMessage)
        {
            var __workflow_bodyrecognitionSender = bodyrecognitionSender == null ? null : WorkflowExpression.Compile(bodyrecognitionSender);
            WorkflowExpression.Validate(__workflow_bodyrecognitionSender, nameof(bodyrecognitionSender), required: true);
            var __workflow_bodyrecognitionRecipients = bodyrecognitionRecipients == null ? null : WorkflowExpression.Compile(bodyrecognitionRecipients);
            WorkflowExpression.Validate(__workflow_bodyrecognitionRecipients, nameof(bodyrecognitionRecipients), required: true);
            var __workflow_bodybadgeTitle = bodybadgeTitle == null ? null : WorkflowExpression.Compile(bodybadgeTitle);
            WorkflowExpression.Validate(__workflow_bodybadgeTitle, nameof(bodybadgeTitle), required: true);
            var __workflow_bodyisPrivate = bodyisPrivate == null ? null : WorkflowExpression.Compile(bodyisPrivate);
            WorkflowExpression.Validate(__workflow_bodyisPrivate, nameof(bodyisPrivate), required: true);
            var __workflow_bodyrecognitionMessage = bodyrecognitionMessage == null ? null : WorkflowExpression.Compile(bodyrecognitionMessage);
            WorkflowExpression.Validate(__workflow_bodyrecognitionMessage, nameof(bodyrecognitionMessage), required: true);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject> GetTask(Expression<Func<string>> taskId)
        {
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/task/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject[]> GetTasks(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<double>> limit = null, Expression<Func<double>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var __workflow_userOID = userOID == null ? null : WorkflowExpression.Compile(userOID);
            WorkflowExpression.Validate(__workflow_userOID, nameof(userOID), required: false);
            var __workflow_userUPN = userUPN == null ? null : WorkflowExpression.Compile(userUPN);
            WorkflowExpression.Validate(__workflow_userUPN, nameof(userUPN), required: false);
            var __workflow_search = search == null ? null : WorkflowExpression.Compile(search);
            WorkflowExpression.Validate(__workflow_search, nameof(search), required: false);
            var __workflow_limit = limit == null ? null : WorkflowExpression.Compile(limit);
            WorkflowExpression.Validate(__workflow_limit, nameof(limit), required: false);
            var __workflow_skip = skip == null ? null : WorkflowExpression.Compile(skip);
            WorkflowExpression.Validate(__workflow_skip, nameof(skip), required: false);
            var __workflow_startDate = startDate == null ? null : WorkflowExpression.Compile(startDate);
            WorkflowExpression.Validate(__workflow_startDate, nameof(startDate), required: false);
            var __workflow_endDate = endDate == null ? null : WorkflowExpression.Compile(endDate);
            WorkflowExpression.Validate(__workflow_endDate, nameof(endDate), required: false);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<User> GetUser(Expression<Func<string>> userMail)
        {
            var __workflow_userMail = userMail == null ? null : WorkflowExpression.Compile(userMail);
            WorkflowExpression.Validate(__workflow_userMail, nameof(userMail), required: true);
            return new DeferredBodyAction<User>(() =>
            {
                var apiCallPath = "/user/getUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userMail"] = ExpressionConverter.Convert(__workflow_userMail);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IWorkflowAction UpdateUser(Expression<Func<string>> bodyuserEmail = null, Expression<Func<bodyuserAttributesInputItem[]>> bodyuserAttributes = null)
        {
            var __workflow_bodyuserEmail = bodyuserEmail == null ? null : WorkflowExpression.Compile(bodyuserEmail);
            WorkflowExpression.Validate(__workflow_bodyuserEmail, nameof(bodyuserEmail), required: false);
            var __workflow_bodyuserAttributes = bodyuserAttributes == null ? null : WorkflowExpression.Compile(bodyuserAttributes);
            WorkflowExpression.Validate(__workflow_bodyuserAttributes, nameof(bodyuserAttributes), required: false);
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
            });
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
