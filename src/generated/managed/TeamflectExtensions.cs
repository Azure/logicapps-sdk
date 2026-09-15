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
        public IBodyWorkflowAction<Feedback> SendFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyfeedbackProvider, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate)
        {
            var apiCallPath = "/feedback/sendFeedbackRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["feedbackAboutUPNorId"] = CSharpExpressionConverter.ConvertToken(bodyfeedbackSubject);
            bodypropCount++;
            body["feedbackRequestReceiverUPNorId"] = CSharpExpressionConverter.ConvertToken(bodyfeedbackProvider);
            bodypropCount++;
            body["feedbackNote"] = CSharpExpressionConverter.ConvertToken(bodyrequestNote);
            bodypropCount++;
            body["templateTitle"] = CSharpExpressionConverter.ConvertToken(bodytemplateTitle);
            bodypropCount++;
            body["dueDateInDays"] = CSharpExpressionConverter.ConvertToken(bodydueDays);
            bodypropCount++;
            body["isPrivate"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Feedback>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Feedback> SendExternalFeedbackRequest(Expression<Func<string>> bodyfeedbackSubject, Expression<Func<string>> bodyexternalEmail, Expression<Func<string>> bodyproviderName, Expression<Func<string>> bodyrequestNote, Expression<Func<string>> bodytemplateTitle, Expression<Func<double>> bodydueDays, Expression<Func<bool>> bodyisPrivate, Expression<Func<bool>> bodyisAnonymous)
        {
            var apiCallPath = "/feedback/sendExternalFeedbackRequest";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["feedbackAboutUPNorId"] = CSharpExpressionConverter.ConvertToken(bodyfeedbackSubject);
            bodypropCount++;
            body["externalEmail"] = CSharpExpressionConverter.ConvertToken(bodyexternalEmail);
            bodypropCount++;
            body["onBehalfName"] = CSharpExpressionConverter.ConvertToken(bodyproviderName);
            bodypropCount++;
            body["feedbackNote"] = CSharpExpressionConverter.ConvertToken(bodyrequestNote);
            bodypropCount++;
            body["templateTitle"] = CSharpExpressionConverter.ConvertToken(bodytemplateTitle);
            bodypropCount++;
            body["dueDateInDays"] = CSharpExpressionConverter.ConvertToken(bodydueDays);
            bodypropCount++;
            body["isPrivate"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
            bodypropCount++;
            body["isAnonymous"] = CSharpExpressionConverter.ConvertToken(bodyisAnonymous);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Feedback>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> GetGoal(Expression<Func<string>> goalId)
        {
            var apiCallPath = "/goal/getGoal";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["goalId"] = CSharpExpressionConverter.ConvertO(goalId);
            return new ApiConnectionAction<Goal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal[]> GetGoals(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<string>> selectedLabels = null, Expression<Func<string>> limit = null, Expression<Func<string>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/goal/getGoals";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userOID != null)
                callPayload.Queries["userOID"] = CSharpExpressionConverter.ConvertO(userOID);
            if (userUPN != null)
                callPayload.Queries["userUPN"] = CSharpExpressionConverter.ConvertO(userUPN);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (selectedLabels != null)
                callPayload.Queries["selectedLabels"] = CSharpExpressionConverter.ConvertO(selectedLabels);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            return new ApiConnectionAction<Goal[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> UpdateGoal(Expression<Func<string>> bodygoalID, Expression<Func<string>> bodynewProgressValue, Expression<Func<bodyupdaterTypeInput>> bodyupdaterType, Expression<Func<string>> bodysystemName, Expression<Func<string>> bodyupdateComment = null, Expression<Func<string>> bodynewStatus = null)
        {
            var apiCallPath = "/goal/updateProgress";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["goalId"] = CSharpExpressionConverter.ConvertToken(bodygoalID);
            bodypropCount++;
            body["newValue"] = CSharpExpressionConverter.ConvertToken(bodynewProgressValue);
            if (bodyupdateComment != null)
            {
                body["comment"] = CSharpExpressionConverter.ConvertToken(bodyupdateComment);
                bodypropCount++;
            }

            if (bodynewStatus != null)
            {
                body["status"] = CSharpExpressionConverter.ConvertToken(bodynewStatus);
                bodypropCount++;
            }

            bodypropCount++;
            body["goalUpdater"] = CSharpExpressionConverter.Convert(bodyupdaterType);
            bodypropCount++;
            body["goalUpdaterSystemName"] = CSharpExpressionConverter.ConvertToken(bodysystemName);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Goal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> CreateGoal(Expression<Func<string>> bodygoalTitle, Expression<Func<string>> bodydescription, Expression<Func<string>> bodystartDate, Expression<Func<string>> bodydueDate, Expression<Func<string>> bodygoalType, Expression<Func<object>> bodygoalOwner, Expression<Func<string>> bodygoalCreator, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyprogressFormat, Expression<Func<string>> bodycurrencyCode, Expression<Func<double>> bodyinitialValue, Expression<Func<double>> bodytargetValue, Expression<Func<string>> bodyparentGoalID, Expression<Func<bool>> bodynotifyOwner)
        {
            var apiCallPath = "/goal/createNewGoal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodygoalTitle);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            bodypropCount++;
            body["startDate"] = CSharpExpressionConverter.ConvertToken(bodystartDate);
            bodypropCount++;
            body["dueDate"] = CSharpExpressionConverter.ConvertToken(bodydueDate);
            bodypropCount++;
            body["goalType"] = CSharpExpressionConverter.ConvertToken(bodygoalType);
            bodypropCount++;
            body["goalOwnerUPNorId"] = CSharpExpressionConverter.ConvertToken(bodygoalOwner);
            bodypropCount++;
            body["goalCreatorUPNorId"] = CSharpExpressionConverter.ConvertToken(bodygoalCreator);
            bodypropCount++;
            body["isPrivate"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
            bodypropCount++;
            body["progressFormatType"] = CSharpExpressionConverter.ConvertToken(bodyprogressFormat);
            bodypropCount++;
            body["currencyCode"] = CSharpExpressionConverter.ConvertToken(bodycurrencyCode);
            bodypropCount++;
            body["initialValue"] = CSharpExpressionConverter.ConvertToken(bodyinitialValue);
            bodypropCount++;
            body["targetValue"] = CSharpExpressionConverter.ConvertToken(bodytargetValue);
            bodypropCount++;
            body["parentGoalId"] = CSharpExpressionConverter.ConvertToken(bodyparentGoalID);
            bodypropCount++;
            body["sendNotificationToOwner"] = CSharpExpressionConverter.ConvertToken(bodynotifyOwner);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Goal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<Goal> AddCommentGoal(Expression<Func<string>> commentidOfTheGoal, Expression<Func<string>> commentobjectIdOrUserPrincipalNameOfTheCommenter, Expression<Func<string>> commentcommentItself)
        {
            var apiCallPath = "/goal/commentGoal";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var comment = new JObject();
            var commentpropCount = 0;
            commentpropCount++;
            comment["goalId"] = CSharpExpressionConverter.ConvertToken(commentidOfTheGoal);
            commentpropCount++;
            comment["commenterIdOrUPN"] = CSharpExpressionConverter.ConvertToken(commentobjectIdOrUserPrincipalNameOfTheCommenter);
            commentpropCount++;
            comment["commentText"] = CSharpExpressionConverter.ConvertToken(commentcommentItself);
            if (commentpropCount > 0)
            {
                callPayload.Body = comment;
            }

            return new ApiConnectionAction<Goal>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse> GetRecognition(Expression<Func<string>> recognitionId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/recognition/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(recognitionId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<RecognitionResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionResponse[]> GetRecognitions(Expression<Func<string[]>> bodyrecipientsToSearch, Expression<Func<string>> bodyrecognitionTitle, Expression<Func<string>> bodyupdateDate, Expression<Func<string>> bodycreationDate)
        {
            var apiCallPath = "/recognition";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["recipientsIdsOrUPNS"] = CSharpExpressionConverter.ConvertToken(bodyrecipientsToSearch);
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodyrecognitionTitle);
            bodypropCount++;
            body["updated"] = CSharpExpressionConverter.ConvertToken(bodyupdateDate);
            bodypropCount++;
            body["created"] = CSharpExpressionConverter.ConvertToken(bodycreationDate);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RecognitionResponse[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<RecognitionCreateResponse> CreateRecognition(Expression<Func<string>> bodyrecognitionSender, Expression<Func<string[]>> bodyrecognitionRecipients, Expression<Func<string>> bodybadgeTitle, Expression<Func<bool>> bodyisPrivate, Expression<Func<string>> bodyrecognitionMessage)
        {
            var apiCallPath = "/recognition/createNewRecognitions";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["senderIdOrUPN"] = CSharpExpressionConverter.ConvertToken(bodyrecognitionSender);
            bodypropCount++;
            body["recipientsIdsOrUPNS"] = CSharpExpressionConverter.ConvertToken(bodyrecognitionRecipients);
            bodypropCount++;
            body["badgeTitle"] = CSharpExpressionConverter.ConvertToken(bodybadgeTitle);
            bodypropCount++;
            body["isPrivate"] = CSharpExpressionConverter.ConvertToken(bodyisPrivate);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodyrecognitionMessage);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<RecognitionCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject> GetTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/task/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<TaskObject>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<TaskObject[]> GetTasks(Expression<Func<string>> userOID = null, Expression<Func<string>> userUPN = null, Expression<Func<string>> search = null, Expression<Func<double>> limit = null, Expression<Func<double>> skip = null, Expression<Func<string>> startDate = null, Expression<Func<string>> endDate = null)
        {
            var apiCallPath = "/task";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (userOID != null)
                callPayload.Queries["userOID"] = CSharpExpressionConverter.ConvertO(userOID);
            if (userUPN != null)
                callPayload.Queries["userUPN"] = CSharpExpressionConverter.ConvertO(userUPN);
            if (search != null)
                callPayload.Queries["search"] = CSharpExpressionConverter.ConvertO(search);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            if (skip != null)
                callPayload.Queries["skip"] = CSharpExpressionConverter.ConvertO(skip);
            if (startDate != null)
                callPayload.Queries["startDate"] = CSharpExpressionConverter.ConvertO(startDate);
            if (endDate != null)
                callPayload.Queries["endDate"] = CSharpExpressionConverter.ConvertO(endDate);
            return new ApiConnectionAction<TaskObject[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IBodyWorkflowAction<User> GetUser(Expression<Func<string>> userMail)
        {
            var apiCallPath = "/user/getUser";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["userMail"] = CSharpExpressionConverter.ConvertO(userMail);
            return new ApiConnectionAction<User>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "teamflect")]
        public IWorkflowAction UpdateUser(Expression<Func<string>> bodyuserEmail = null, Expression<Func<bodyuserAttributesInputItem[]>> bodyuserAttributes = null)
        {
            var apiCallPath = "/user/updateUser";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyuserEmail != null)
            {
                body["userMail"] = CSharpExpressionConverter.ConvertToken(bodyuserEmail);
                bodypropCount++;
            }

            if (bodyuserAttributes != null)
            {
                body["userAttributes"] = CSharpExpressionConverter.ConvertToken(bodyuserAttributes);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
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