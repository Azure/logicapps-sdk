//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamflect
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamflectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildSendFeedbackRequest))]
        public IBodyWorkflowAction<Feedback> SendFeedbackRequest([WorkflowExpression] Func<string> bodyfeedbackSubject, [WorkflowExpression] Func<string> bodyfeedbackProvider, [WorkflowExpression] Func<string> bodyrequestNote, [WorkflowExpression] Func<string> bodytemplateTitle, [WorkflowExpression] Func<double> bodydueDays, [WorkflowExpression] Func<bool> bodyisPrivate)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Feedback> __BuildSendFeedbackRequest(WorkflowValue<string> bodyfeedbackSubject, WorkflowValue<string> bodyfeedbackProvider, WorkflowValue<string> bodyrequestNote, WorkflowValue<string> bodytemplateTitle, WorkflowValue<double> bodydueDays, WorkflowValue<bool> bodyisPrivate)
        {
            WorkflowValue.Validate(bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            WorkflowValue.Validate(bodyfeedbackProvider, nameof(bodyfeedbackProvider), required: true);
            WorkflowValue.Validate(bodyrequestNote, nameof(bodyrequestNote), required: true);
            WorkflowValue.Validate(bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            WorkflowValue.Validate(bodydueDays, nameof(bodydueDays), required: true);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            return new DeferredBodyAction<Feedback>(() =>
            {
                var apiCallPath = "/feedback/sendFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = ExpressionConverter.ConvertO(bodyfeedbackSubject);
                bodypropCount++;
                body["feedbackRequestReceiverUPNorId"] = ExpressionConverter.ConvertO(bodyfeedbackProvider);
                bodypropCount++;
                body["feedbackNote"] = ExpressionConverter.ConvertO(bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = ExpressionConverter.ConvertO(bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = ExpressionConverter.ConvertO(bodydueDays);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Feedback>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildSendExternalFeedbackRequest))]
        public IBodyWorkflowAction<Feedback> SendExternalFeedbackRequest([WorkflowExpression] Func<string> bodyfeedbackSubject, [WorkflowExpression] Func<string> bodyexternalEmail, [WorkflowExpression] Func<string> bodyproviderName, [WorkflowExpression] Func<string> bodyrequestNote, [WorkflowExpression] Func<string> bodytemplateTitle, [WorkflowExpression] Func<double> bodydueDays, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<bool> bodyisAnonymous)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Feedback> __BuildSendExternalFeedbackRequest(WorkflowValue<string> bodyfeedbackSubject, WorkflowValue<string> bodyexternalEmail, WorkflowValue<string> bodyproviderName, WorkflowValue<string> bodyrequestNote, WorkflowValue<string> bodytemplateTitle, WorkflowValue<double> bodydueDays, WorkflowValue<bool> bodyisPrivate, WorkflowValue<bool> bodyisAnonymous)
        {
            WorkflowValue.Validate(bodyfeedbackSubject, nameof(bodyfeedbackSubject), required: true);
            WorkflowValue.Validate(bodyexternalEmail, nameof(bodyexternalEmail), required: true);
            WorkflowValue.Validate(bodyproviderName, nameof(bodyproviderName), required: true);
            WorkflowValue.Validate(bodyrequestNote, nameof(bodyrequestNote), required: true);
            WorkflowValue.Validate(bodytemplateTitle, nameof(bodytemplateTitle), required: true);
            WorkflowValue.Validate(bodydueDays, nameof(bodydueDays), required: true);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            WorkflowValue.Validate(bodyisAnonymous, nameof(bodyisAnonymous), required: true);
            return new DeferredBodyAction<Feedback>(() =>
            {
                var apiCallPath = "/feedback/sendExternalFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = ExpressionConverter.ConvertO(bodyfeedbackSubject);
                bodypropCount++;
                body["externalEmail"] = ExpressionConverter.ConvertO(bodyexternalEmail);
                bodypropCount++;
                body["onBehalfName"] = ExpressionConverter.ConvertO(bodyproviderName);
                bodypropCount++;
                body["feedbackNote"] = ExpressionConverter.ConvertO(bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = ExpressionConverter.ConvertO(bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = ExpressionConverter.ConvertO(bodydueDays);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
                body["isAnonymous"] = ExpressionConverter.ConvertO(bodyisAnonymous);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Feedback>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetGoal))]
        public IBodyWorkflowAction<Goal> GetGoal([WorkflowExpression] Func<string> goalId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Goal> __BuildGetGoal(WorkflowValue<string> goalId)
        {
            WorkflowValue.Validate(goalId, nameof(goalId), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/getGoal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["goalId"] = ExpressionConverter.Convert(goalId);
                return new ApiConnectionAction<Goal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetGoals))]
        public IBodyWorkflowAction<Goal[]> GetGoals([WorkflowExpression] Func<string> userOID = null, [WorkflowExpression] Func<string> userUPN = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> selectedLabels = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Goal[]> __BuildGetGoals(WorkflowValue<string> userOID = null, WorkflowValue<string> userUPN = null, WorkflowValue<string> search = null, WorkflowValue<string> selectedLabels = null, WorkflowValue<string> limit = null, WorkflowValue<string> skip = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null)
        {
            WorkflowValue.Validate(userOID, nameof(userOID), required: false);
            WorkflowValue.Validate(userUPN, nameof(userUPN), required: false);
            WorkflowValue.Validate(search, nameof(search), required: false);
            WorkflowValue.Validate(selectedLabels, nameof(selectedLabels), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<Goal[]>(() =>
            {
                var apiCallPath = "/goal/getGoals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userOID != null)
                    callPayload.Queries["userOID"] = ExpressionConverter.Convert(userOID);
                if (userUPN != null)
                    callPayload.Queries["userUPN"] = ExpressionConverter.Convert(userUPN);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (selectedLabels != null)
                    callPayload.Queries["selectedLabels"] = ExpressionConverter.Convert(selectedLabels);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                return new ApiConnectionAction<Goal[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateGoal))]
        public IBodyWorkflowAction<Goal> UpdateGoal([WorkflowExpression] Func<string> bodygoalID, [WorkflowExpression] Func<string> bodynewProgressValue, [WorkflowExpression] Func<bodyupdaterTypeInput> bodyupdaterType, [WorkflowExpression] Func<string> bodysystemName, [WorkflowExpression] Func<string> bodyupdateComment = null, [WorkflowExpression] Func<string> bodynewStatus = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Goal> __BuildUpdateGoal(WorkflowValue<string> bodygoalID, WorkflowValue<string> bodynewProgressValue, WorkflowValue<bodyupdaterTypeInput> bodyupdaterType, WorkflowValue<string> bodysystemName, WorkflowValue<string> bodyupdateComment = null, WorkflowValue<string> bodynewStatus = null)
        {
            WorkflowValue.Validate(bodygoalID, nameof(bodygoalID), required: true);
            WorkflowValue.Validate(bodynewProgressValue, nameof(bodynewProgressValue), required: true);
            WorkflowValue.Validate(bodyupdaterType, nameof(bodyupdaterType), required: true);
            WorkflowValue.Validate(bodysystemName, nameof(bodysystemName), required: true);
            WorkflowValue.Validate(bodyupdateComment, nameof(bodyupdateComment), required: false);
            WorkflowValue.Validate(bodynewStatus, nameof(bodynewStatus), required: false);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/updateProgress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["goalId"] = ExpressionConverter.ConvertO(bodygoalID);
                bodypropCount++;
                body["newValue"] = ExpressionConverter.ConvertO(bodynewProgressValue);
                if (bodyupdateComment != null)
                {
                    body["comment"] = ExpressionConverter.ConvertO(bodyupdateComment);
                    bodypropCount++;
                }

                if (bodynewStatus != null)
                {
                    body["status"] = ExpressionConverter.ConvertO(bodynewStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["goalUpdater"] = ExpressionConverter.ConvertO(bodyupdaterType);
                bodypropCount++;
                body["goalUpdaterSystemName"] = ExpressionConverter.ConvertO(bodysystemName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildCreateGoal))]
        public IBodyWorkflowAction<Goal> CreateGoal([WorkflowExpression] Func<string> bodygoalTitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodydueDate, [WorkflowExpression] Func<string> bodygoalType, [WorkflowExpression] Func<object> bodygoalOwner, [WorkflowExpression] Func<string> bodygoalCreator, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodyprogressFormat, [WorkflowExpression] Func<string> bodycurrencyCode, [WorkflowExpression] Func<double> bodyinitialValue, [WorkflowExpression] Func<double> bodytargetValue, [WorkflowExpression] Func<string> bodyparentGoalID, [WorkflowExpression] Func<bool> bodynotifyOwner)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Goal> __BuildCreateGoal(WorkflowValue<string> bodygoalTitle, WorkflowValue<string> bodydescription, WorkflowValue<string> bodystartDate, WorkflowValue<string> bodydueDate, WorkflowValue<string> bodygoalType, WorkflowValue<object> bodygoalOwner, WorkflowValue<string> bodygoalCreator, WorkflowValue<bool> bodyisPrivate, WorkflowValue<string> bodyprogressFormat, WorkflowValue<string> bodycurrencyCode, WorkflowValue<double> bodyinitialValue, WorkflowValue<double> bodytargetValue, WorkflowValue<string> bodyparentGoalID, WorkflowValue<bool> bodynotifyOwner)
        {
            WorkflowValue.Validate(bodygoalTitle, nameof(bodygoalTitle), required: true);
            WorkflowValue.Validate(bodydescription, nameof(bodydescription), required: true);
            WorkflowValue.Validate(bodystartDate, nameof(bodystartDate), required: true);
            WorkflowValue.Validate(bodydueDate, nameof(bodydueDate), required: true);
            WorkflowValue.Validate(bodygoalType, nameof(bodygoalType), required: true);
            WorkflowValue.Validate(bodygoalOwner, nameof(bodygoalOwner), required: true);
            WorkflowValue.Validate(bodygoalCreator, nameof(bodygoalCreator), required: true);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            WorkflowValue.Validate(bodyprogressFormat, nameof(bodyprogressFormat), required: true);
            WorkflowValue.Validate(bodycurrencyCode, nameof(bodycurrencyCode), required: true);
            WorkflowValue.Validate(bodyinitialValue, nameof(bodyinitialValue), required: true);
            WorkflowValue.Validate(bodytargetValue, nameof(bodytargetValue), required: true);
            WorkflowValue.Validate(bodyparentGoalID, nameof(bodyparentGoalID), required: true);
            WorkflowValue.Validate(bodynotifyOwner, nameof(bodynotifyOwner), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/createNewGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodygoalTitle);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
                body["startDate"] = ExpressionConverter.ConvertO(bodystartDate);
                bodypropCount++;
                body["dueDate"] = ExpressionConverter.ConvertO(bodydueDate);
                bodypropCount++;
                body["goalType"] = ExpressionConverter.ConvertO(bodygoalType);
                bodypropCount++;
                body["goalOwnerUPNorId"] = ExpressionConverter.ConvertO(bodygoalOwner);
                bodypropCount++;
                body["goalCreatorUPNorId"] = ExpressionConverter.ConvertO(bodygoalCreator);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
                body["progressFormatType"] = ExpressionConverter.ConvertO(bodyprogressFormat);
                bodypropCount++;
                body["currencyCode"] = ExpressionConverter.ConvertO(bodycurrencyCode);
                bodypropCount++;
                body["initialValue"] = ExpressionConverter.ConvertO(bodyinitialValue);
                bodypropCount++;
                body["targetValue"] = ExpressionConverter.ConvertO(bodytargetValue);
                bodypropCount++;
                body["parentGoalId"] = ExpressionConverter.ConvertO(bodyparentGoalID);
                bodypropCount++;
                body["sendNotificationToOwner"] = ExpressionConverter.ConvertO(bodynotifyOwner);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildAddCommentGoal))]
        public IBodyWorkflowAction<Goal> AddCommentGoal([WorkflowExpression] Func<string> commentidOfTheGoal, [WorkflowExpression] Func<string> commentobjectIdOrUserPrincipalNameOfTheCommenter, [WorkflowExpression] Func<string> commentcommentItself)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Goal> __BuildAddCommentGoal(WorkflowValue<string> commentidOfTheGoal, WorkflowValue<string> commentobjectIdOrUserPrincipalNameOfTheCommenter, WorkflowValue<string> commentcommentItself)
        {
            WorkflowValue.Validate(commentidOfTheGoal, nameof(commentidOfTheGoal), required: true);
            WorkflowValue.Validate(commentobjectIdOrUserPrincipalNameOfTheCommenter, nameof(commentobjectIdOrUserPrincipalNameOfTheCommenter), required: true);
            WorkflowValue.Validate(commentcommentItself, nameof(commentcommentItself), required: true);
            return new DeferredBodyAction<Goal>(() =>
            {
                var apiCallPath = "/goal/commentGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["goalId"] = ExpressionConverter.ConvertO(commentidOfTheGoal);
                commentpropCount++;
                comment["commenterIdOrUPN"] = ExpressionConverter.ConvertO(commentobjectIdOrUserPrincipalNameOfTheCommenter);
                commentpropCount++;
                comment["commentText"] = ExpressionConverter.ConvertO(commentcommentItself);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }

                return new ApiConnectionAction<Goal>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecognition))]
        public IBodyWorkflowAction<RecognitionResponse> GetRecognition([WorkflowExpression] Func<string> recognitionId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecognitionResponse> __BuildGetRecognition(WorkflowValue<string> recognitionId)
        {
            WorkflowValue.Validate(recognitionId, nameof(recognitionId), required: true);
            return new DeferredBodyAction<RecognitionResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/recognition/{0}", ExpressionConverter.ConvertWithUrlEncoding(recognitionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RecognitionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetRecognitions))]
        public IBodyWorkflowAction<RecognitionResponse[]> GetRecognitions([WorkflowExpression] Func<string[]> bodyrecipientsToSearch, [WorkflowExpression] Func<string> bodyrecognitionTitle, [WorkflowExpression] Func<string> bodyupdateDate, [WorkflowExpression] Func<string> bodycreationDate)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecognitionResponse[]> __BuildGetRecognitions(WorkflowValue<string[]> bodyrecipientsToSearch, WorkflowValue<string> bodyrecognitionTitle, WorkflowValue<string> bodyupdateDate, WorkflowValue<string> bodycreationDate)
        {
            WorkflowValue.Validate(bodyrecipientsToSearch, nameof(bodyrecipientsToSearch), required: true);
            WorkflowValue.Validate(bodyrecognitionTitle, nameof(bodyrecognitionTitle), required: true);
            WorkflowValue.Validate(bodyupdateDate, nameof(bodyupdateDate), required: true);
            WorkflowValue.Validate(bodycreationDate, nameof(bodycreationDate), required: true);
            return new DeferredBodyAction<RecognitionResponse[]>(() =>
            {
                var apiCallPath = "/recognition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = ExpressionConverter.ConvertO(bodyrecipientsToSearch);
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodyrecognitionTitle);
                bodypropCount++;
                body["updated"] = ExpressionConverter.ConvertO(bodyupdateDate);
                bodypropCount++;
                body["created"] = ExpressionConverter.ConvertO(bodycreationDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RecognitionResponse[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildCreateRecognition))]
        public IBodyWorkflowAction<RecognitionCreateResponse> CreateRecognition([WorkflowExpression] Func<string> bodyrecognitionSender, [WorkflowExpression] Func<string[]> bodyrecognitionRecipients, [WorkflowExpression] Func<string> bodybadgeTitle, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodyrecognitionMessage)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RecognitionCreateResponse> __BuildCreateRecognition(WorkflowValue<string> bodyrecognitionSender, WorkflowValue<string[]> bodyrecognitionRecipients, WorkflowValue<string> bodybadgeTitle, WorkflowValue<bool> bodyisPrivate, WorkflowValue<string> bodyrecognitionMessage)
        {
            WorkflowValue.Validate(bodyrecognitionSender, nameof(bodyrecognitionSender), required: true);
            WorkflowValue.Validate(bodyrecognitionRecipients, nameof(bodyrecognitionRecipients), required: true);
            WorkflowValue.Validate(bodybadgeTitle, nameof(bodybadgeTitle), required: true);
            WorkflowValue.Validate(bodyisPrivate, nameof(bodyisPrivate), required: true);
            WorkflowValue.Validate(bodyrecognitionMessage, nameof(bodyrecognitionMessage), required: true);
            return new DeferredBodyAction<RecognitionCreateResponse>(() =>
            {
                var apiCallPath = "/recognition/createNewRecognitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["senderIdOrUPN"] = ExpressionConverter.ConvertO(bodyrecognitionSender);
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = ExpressionConverter.ConvertO(bodyrecognitionRecipients);
                bodypropCount++;
                body["badgeTitle"] = ExpressionConverter.ConvertO(bodybadgeTitle);
                bodypropCount++;
                body["isPrivate"] = ExpressionConverter.ConvertO(bodyisPrivate);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(bodyrecognitionMessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<RecognitionCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetTask))]
        public IBodyWorkflowAction<TaskObject> GetTask([WorkflowExpression] Func<string> taskId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject> __BuildGetTask(WorkflowValue<string> taskId)
        {
            WorkflowValue.Validate(taskId, nameof(taskId), required: true);
            return new DeferredBodyAction<TaskObject>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<TaskObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetTasks))]
        public IBodyWorkflowAction<TaskObject[]> GetTasks([WorkflowExpression] Func<string> userOID = null, [WorkflowExpression] Func<string> userUPN = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TaskObject[]> __BuildGetTasks(WorkflowValue<string> userOID = null, WorkflowValue<string> userUPN = null, WorkflowValue<string> search = null, WorkflowValue<double> limit = null, WorkflowValue<double> skip = null, WorkflowValue<string> startDate = null, WorkflowValue<string> endDate = null)
        {
            WorkflowValue.Validate(userOID, nameof(userOID), required: false);
            WorkflowValue.Validate(userUPN, nameof(userUPN), required: false);
            WorkflowValue.Validate(search, nameof(search), required: false);
            WorkflowValue.Validate(limit, nameof(limit), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(startDate, nameof(startDate), required: false);
            WorkflowValue.Validate(endDate, nameof(endDate), required: false);
            return new DeferredBodyAction<TaskObject[]>(() =>
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userOID != null)
                    callPayload.Queries["userOID"] = ExpressionConverter.Convert(userOID);
                if (userUPN != null)
                    callPayload.Queries["userUPN"] = ExpressionConverter.Convert(userUPN);
                if (search != null)
                    callPayload.Queries["search"] = ExpressionConverter.Convert(search);
                if (limit != null)
                    callPayload.Queries["limit"] = ExpressionConverter.Convert(limit);
                if (skip != null)
                    callPayload.Queries["skip"] = ExpressionConverter.Convert(skip);
                if (startDate != null)
                    callPayload.Queries["startDate"] = ExpressionConverter.Convert(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = ExpressionConverter.Convert(endDate);
                return new ApiConnectionAction<TaskObject[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildGetUser))]
        public IBodyWorkflowAction<User> GetUser([WorkflowExpression] Func<string> userMail)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<User> __BuildGetUser(WorkflowValue<string> userMail)
        {
            WorkflowValue.Validate(userMail, nameof(userMail), required: true);
            return new DeferredBodyAction<User>(() =>
            {
                var apiCallPath = "/user/getUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userMail"] = ExpressionConverter.Convert(userMail);
                return new ApiConnectionAction<User>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        [WorkflowExpressionFactory(nameof(__BuildUpdateUser))]
        public IWorkflowAction UpdateUser([WorkflowExpression] Func<string> bodyuserEmail = null, [WorkflowExpression] Func<bodyuserAttributesInputItem[]> bodyuserAttributes = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateUser(WorkflowValue<string> bodyuserEmail = null, WorkflowValue<bodyuserAttributesInputItem[]> bodyuserAttributes = null)
        {
            WorkflowValue.Validate(bodyuserEmail, nameof(bodyuserEmail), required: false);
            WorkflowValue.Validate(bodyuserAttributes, nameof(bodyuserAttributes), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/user/updateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserEmail != null)
                {
                    body["userMail"] = ExpressionConverter.ConvertO(bodyuserEmail);
                    bodypropCount++;
                }

                if (bodyuserAttributes != null)
                {
                    body["userAttributes"] = ExpressionConverter.ConvertO(bodyuserAttributes);
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
