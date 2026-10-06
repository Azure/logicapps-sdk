//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Teamflect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TeamflectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendFeedbackRequest([WorkflowExpression] Func<string> bodyfeedbackSubject, [WorkflowExpression] Func<string> bodyfeedbackProvider, [WorkflowExpression] Func<string> bodyrequestNote, [WorkflowExpression] Func<string> bodytemplateTitle, [WorkflowExpression] Func<double> bodydueDays, [WorkflowExpression] Func<bool> bodyisPrivate)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/feedback/sendFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = SourceExpressionConverter.ConvertToken(bodyfeedbackSubject);
                bodypropCount++;
                body["feedbackRequestReceiverUPNorId"] = SourceExpressionConverter.ConvertToken(bodyfeedbackProvider);
                bodypropCount++;
                body["feedbackNote"] = SourceExpressionConverter.ConvertToken(bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = SourceExpressionConverter.ConvertToken(bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = SourceExpressionConverter.ConvertToken(bodydueDays);
                bodypropCount++;
                body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Feedback>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendExternalFeedbackRequest([WorkflowExpression] Func<string> bodyfeedbackSubject, [WorkflowExpression] Func<string> bodyexternalEmail, [WorkflowExpression] Func<string> bodyproviderName, [WorkflowExpression] Func<string> bodyrequestNote, [WorkflowExpression] Func<string> bodytemplateTitle, [WorkflowExpression] Func<double> bodydueDays, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<bool> bodyisAnonymous)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/feedback/sendExternalFeedbackRequest";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["feedbackAboutUPNorId"] = SourceExpressionConverter.ConvertToken(bodyfeedbackSubject);
                bodypropCount++;
                body["externalEmail"] = SourceExpressionConverter.ConvertToken(bodyexternalEmail);
                bodypropCount++;
                body["onBehalfName"] = SourceExpressionConverter.ConvertToken(bodyproviderName);
                bodypropCount++;
                body["feedbackNote"] = SourceExpressionConverter.ConvertToken(bodyrequestNote);
                bodypropCount++;
                body["templateTitle"] = SourceExpressionConverter.ConvertToken(bodytemplateTitle);
                bodypropCount++;
                body["dueDateInDays"] = SourceExpressionConverter.ConvertToken(bodydueDays);
                bodypropCount++;
                body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
                body["isAnonymous"] = SourceExpressionConverter.ConvertToken(bodyisAnonymous);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Feedback>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> GetGoal([WorkflowExpression] Func<string> goalId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goal/getGoal";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["goalId"] = SourceExpressionConverter.ConvertO(goalId);
                return callPayload;
            }

            return new ApiConnectionAction<Goal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal[]> GetGoals([WorkflowExpression] Func<string> userOId = null, [WorkflowExpression] Func<string> userUPN = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<string> selectedLabels = null, [WorkflowExpression] Func<string> limit = null, [WorkflowExpression] Func<string> skip = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goal/getGoals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userOId != null)
                    callPayload.Queries["userOID"] = SourceExpressionConverter.ConvertO(userOId);
                if (userUPN != null)
                    callPayload.Queries["userUPN"] = SourceExpressionConverter.ConvertO(userUPN);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (selectedLabels != null)
                    callPayload.Queries["selectedLabels"] = SourceExpressionConverter.ConvertO(selectedLabels);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<Goal[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> UpdateGoal([WorkflowExpression] Func<string> bodygoalId, [WorkflowExpression] Func<string> bodynewProgressValue, [WorkflowExpression] Func<bodyupdaterTypeInput> bodyupdaterType, [WorkflowExpression] Func<string> bodysystemName, [WorkflowExpression] Func<string> bodyupdateComment = null, [WorkflowExpression] Func<string> bodynewStatus = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goal/updateProgress";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["goalId"] = SourceExpressionConverter.ConvertToken(bodygoalId);
                bodypropCount++;
                body["newValue"] = SourceExpressionConverter.ConvertToken(bodynewProgressValue);
                if (bodyupdateComment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodyupdateComment);
                    bodypropCount++;
                }

                if (bodynewStatus != null)
                {
                    body["status"] = SourceExpressionConverter.ConvertToken(bodynewStatus);
                    bodypropCount++;
                }

                bodypropCount++;
                body["goalUpdater"] = SourceExpressionConverter.Convert(bodyupdaterType);
                bodypropCount++;
                body["goalUpdaterSystemName"] = SourceExpressionConverter.ConvertToken(bodysystemName);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Goal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> CreateGoal([WorkflowExpression] Func<string> bodygoalTitle, [WorkflowExpression] Func<string> bodydescription, [WorkflowExpression] Func<string> bodystartDate, [WorkflowExpression] Func<string> bodydueDate, [WorkflowExpression] Func<string> bodygoalType, [WorkflowExpression] Func<object> bodygoalOwner, [WorkflowExpression] Func<string> bodygoalCreator, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodyprogressFormat, [WorkflowExpression] Func<string> bodycurrencyCode, [WorkflowExpression] Func<double> bodyinitialValue, [WorkflowExpression] Func<double> bodytargetValue, [WorkflowExpression] Func<string> bodyparentGoalId, [WorkflowExpression] Func<bool> bodynotifyOwner)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goal/createNewGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodygoalTitle);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
                body["startDate"] = SourceExpressionConverter.ConvertToken(bodystartDate);
                bodypropCount++;
                body["dueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                bodypropCount++;
                body["goalType"] = SourceExpressionConverter.ConvertToken(bodygoalType);
                bodypropCount++;
                body["goalOwnerUPNorId"] = SourceExpressionConverter.ConvertToken(bodygoalOwner);
                bodypropCount++;
                body["goalCreatorUPNorId"] = SourceExpressionConverter.ConvertToken(bodygoalCreator);
                bodypropCount++;
                body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
                body["progressFormatType"] = SourceExpressionConverter.ConvertToken(bodyprogressFormat);
                bodypropCount++;
                body["currencyCode"] = SourceExpressionConverter.ConvertToken(bodycurrencyCode);
                bodypropCount++;
                body["initialValue"] = SourceExpressionConverter.ConvertToken(bodyinitialValue);
                bodypropCount++;
                body["targetValue"] = SourceExpressionConverter.ConvertToken(bodytargetValue);
                bodypropCount++;
                body["parentGoalId"] = SourceExpressionConverter.ConvertToken(bodyparentGoalId);
                bodypropCount++;
                body["sendNotificationToOwner"] = SourceExpressionConverter.ConvertToken(bodynotifyOwner);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Goal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> AddCommentGoal([WorkflowExpression] Func<string> commentidOfTheGoal, [WorkflowExpression] Func<string> commentobjectIdOrUserPrincipalNameOfTheCommenter, [WorkflowExpression] Func<string> commentcommentItself)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/goal/commentGoal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var comment = new JObject();
                var commentpropCount = 0;
                commentpropCount++;
                comment["goalId"] = SourceExpressionConverter.ConvertToken(commentidOfTheGoal);
                commentpropCount++;
                comment["commenterIdOrUPN"] = SourceExpressionConverter.ConvertToken(commentobjectIdOrUserPrincipalNameOfTheCommenter);
                commentpropCount++;
                comment["commentText"] = SourceExpressionConverter.ConvertToken(commentcommentItself);
                if (commentpropCount > 0)
                {
                    callPayload.Body = comment;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Goal>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse> GetRecognition([WorkflowExpression] Func<string> recognitionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/recognition/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recognitionId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<RecognitionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse[]> GetRecognitions([WorkflowExpression] Func<string[]> bodyrecipientsToSearch, [WorkflowExpression] Func<string> bodyrecognitionTitle, [WorkflowExpression] Func<string> bodyupdateDate, [WorkflowExpression] Func<string> bodycreationDate)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/recognition";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = SourceExpressionConverter.ConvertToken(bodyrecipientsToSearch);
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodyrecognitionTitle);
                bodypropCount++;
                body["updated"] = SourceExpressionConverter.ConvertToken(bodyupdateDate);
                bodypropCount++;
                body["created"] = SourceExpressionConverter.ConvertToken(bodycreationDate);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RecognitionResponse[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionCreateResponse> CreateRecognition([WorkflowExpression] Func<string> bodyrecognitionSender, [WorkflowExpression] Func<string[]> bodyrecognitionRecipients, [WorkflowExpression] Func<string> bodybadgeTitle, [WorkflowExpression] Func<bool> bodyisPrivate, [WorkflowExpression] Func<string> bodyrecognitionMessage)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/recognition/createNewRecognitions";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["senderIdOrUPN"] = SourceExpressionConverter.ConvertToken(bodyrecognitionSender);
                bodypropCount++;
                body["recipientsIdsOrUPNS"] = SourceExpressionConverter.ConvertToken(bodyrecognitionRecipients);
                bodypropCount++;
                body["badgeTitle"] = SourceExpressionConverter.ConvertToken(bodybadgeTitle);
                bodypropCount++;
                body["isPrivate"] = SourceExpressionConverter.ConvertToken(bodyisPrivate);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodyrecognitionMessage);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<RecognitionCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject> GetTask([WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject[]> GetTasks([WorkflowExpression] Func<string> userOId = null, [WorkflowExpression] Func<string> userUPN = null, [WorkflowExpression] Func<string> search = null, [WorkflowExpression] Func<double> limit = null, [WorkflowExpression] Func<double> skip = null, [WorkflowExpression] Func<string> startDate = null, [WorkflowExpression] Func<string> endDate = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/task";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (userOId != null)
                    callPayload.Queries["userOID"] = SourceExpressionConverter.ConvertO(userOId);
                if (userUPN != null)
                    callPayload.Queries["userUPN"] = SourceExpressionConverter.ConvertO(userUPN);
                if (search != null)
                    callPayload.Queries["search"] = SourceExpressionConverter.ConvertO(search);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                if (skip != null)
                    callPayload.Queries["skip"] = SourceExpressionConverter.ConvertO(skip);
                if (startDate != null)
                    callPayload.Queries["startDate"] = SourceExpressionConverter.ConvertO(startDate);
                if (endDate != null)
                    callPayload.Queries["endDate"] = SourceExpressionConverter.ConvertO(endDate);
                return callPayload;
            }

            return new ApiConnectionAction<TaskObject[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<User> GetUser([WorkflowExpression] Func<string> userMail)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/getUser";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["userMail"] = SourceExpressionConverter.ConvertO(userMail);
                return callPayload;
            }

            return new ApiConnectionAction<User>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IWorkflowAction UpdateUser([WorkflowExpression] Func<string> bodyuserEmail = null, [WorkflowExpression] Func<bodyuserAttributesInputItem[]> bodyuserAttributes = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/updateUser";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyuserEmail != null)
                {
                    body["userMail"] = SourceExpressionConverter.ConvertToken(bodyuserEmail);
                    bodypropCount++;
                }

                if (bodyuserAttributes != null)
                {
                    body["userAttributes"] = SourceExpressionConverter.ConvertToken(bodyuserAttributes);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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