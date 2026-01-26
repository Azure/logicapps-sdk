//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jira
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JiraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<JToken> EditIssue(Expression<Func<string>> issueIdOrKey, Expression<Func<bool>> notifyUsers = null, Expression<Func<bool>> overrideScreenSecurity = null, Expression<Func<bool>> overrideEditableFlag = null, Expression<Func<string>> bodytransitiontransitionID = null, Expression<Func<string>> bodytransitiontransitionLooped = null, Expression<Func<string>> bodyhistoryMetadatametadataType = null, Expression<Func<string>> bodyhistoryMetadatametadataDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorID = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayName = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorType = null, Expression<Func<string>> bodyhistoryMetadataactoractorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadataactoractorUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorId = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayName = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorType = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseId = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayName = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatacausecauseType = null, Expression<Func<string>> bodyhistoryMetadatacausecauseAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseUrl = null, Expression<Func<string>> bodyhistoryMetadataextraData = null, Expression<Func<bodypropertiesInputItem[]>> bodyproperties = null)
        {
            var apiCallPath = String.Format("/3/issue/{0}", ExpressionConverter.ConvertWithUrlEncoding(issueIdOrKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (notifyUsers != null)
                callPayload.Queries["notifyUsers"] = ExpressionConverter.Convert(notifyUsers);
            if (overrideScreenSecurity != null)
                callPayload.Queries["overrideScreenSecurity"] = ExpressionConverter.Convert(overrideScreenSecurity);
            if (overrideEditableFlag != null)
                callPayload.Queries["overrideEditableFlag"] = ExpressionConverter.Convert(overrideEditableFlag);
            var body = new JObject();
            var bodypropCount = 0;
            var transitionObject = new JObject();
            var transitionObjectpropCount = 0;
            if (bodytransitiontransitionID != null)
            {
                transitionObject["id"] = ExpressionConverter.ConvertO(bodytransitiontransitionID);
                transitionObjectpropCount++;
            }

            if (bodytransitiontransitionLooped != null)
            {
                transitionObject["looped"] = ExpressionConverter.ConvertO(bodytransitiontransitionLooped);
                transitionObjectpropCount++;
            }

            if (transitionObjectpropCount > 0)
            {
                body["transition"] = transitionObject;
                bodypropCount++;
            }

            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
            if (fieldsObjectpropCount > 0)
            {
                body["fields"] = fieldsObject;
                bodypropCount++;
            }

            var updateObject = new JObject();
            var updateObjectpropCount = 0;
            if (updateObjectpropCount > 0)
            {
                body["update"] = updateObject;
                bodypropCount++;
            }

            var historyMetadataObject = new JObject();
            var historyMetadataObjectpropCount = 0;
            if (bodyhistoryMetadatametadataType != null)
            {
                historyMetadataObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataType);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataDescription != null)
            {
                historyMetadataObject["description"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataDescriptionKey != null)
            {
                historyMetadataObject["descriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataActivityDescription != null)
            {
                historyMetadataObject["activityDescription"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataActivityDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataActivityDescriptionKey != null)
            {
                historyMetadataObject["activityDescriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataActivityDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataEmailDescription != null)
            {
                historyMetadataObject["emailDescription"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataEmailDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataEmailDescriptionKey != null)
            {
                historyMetadataObject["emailDescriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataEmailDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            var actorObject = new JObject();
            var actorObjectpropCount = 0;
            if (bodyhistoryMetadataactoractorID != null)
            {
                actorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorID);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorDisplayName != null)
            {
                actorObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorDisplayName);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorDisplayNameKey != null)
            {
                actorObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorDisplayNameKey);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorType != null)
            {
                actorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorType);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorAvatarUrl != null)
            {
                actorObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorAvatarUrl);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorUrl != null)
            {
                actorObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorUrl);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                historyMetadataObject["actor"] = actorObject;
                historyMetadataObjectpropCount++;
            }

            var generatorObject = new JObject();
            var generatorObjectpropCount = 0;
            if (bodyhistoryMetadatageneratorgeneratorId != null)
            {
                generatorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorId);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorDisplayName != null)
            {
                generatorObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorDisplayName);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorDisplayNameKey != null)
            {
                generatorObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorDisplayNameKey);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorType != null)
            {
                generatorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorType);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorAvatarUrl != null)
            {
                generatorObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorAvatarUrl);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorUrl != null)
            {
                generatorObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorUrl);
                generatorObjectpropCount++;
            }

            if (generatorObjectpropCount > 0)
            {
                historyMetadataObject["generator"] = generatorObject;
                historyMetadataObjectpropCount++;
            }

            var causeObject = new JObject();
            var causeObjectpropCount = 0;
            if (bodyhistoryMetadatacausecauseId != null)
            {
                causeObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseId);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseDisplayName != null)
            {
                causeObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseDisplayName);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseDisplayNameKey != null)
            {
                causeObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseDisplayNameKey);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseType != null)
            {
                causeObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseType);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseAvatarUrl != null)
            {
                causeObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseAvatarUrl);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseUrl != null)
            {
                causeObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseUrl);
                causeObjectpropCount++;
            }

            if (causeObjectpropCount > 0)
            {
                historyMetadataObject["cause"] = causeObject;
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadataextraData != null)
            {
                historyMetadataObject["extraData"] = ExpressionConverter.ConvertO(bodyhistoryMetadataextraData);
                historyMetadataObjectpropCount++;
            }

            if (historyMetadataObjectpropCount > 0)
            {
                body["historyMetadata"] = historyMetadataObject;
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<JToken> EditIssueV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<bool>> notifyUsers = null, Expression<Func<bool>> overrideScreenSecurity = null, Expression<Func<bool>> overrideEditableFlag = null, Expression<Func<string>> bodytransitiontransitionID = null, Expression<Func<string>> bodytransitiontransitionLooped = null, Expression<Func<string>> bodyhistoryMetadatametadataType = null, Expression<Func<string>> bodyhistoryMetadatametadataDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorID = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayName = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorType = null, Expression<Func<string>> bodyhistoryMetadataactoractorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadataactoractorUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorId = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayName = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorType = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseId = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayName = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatacausecauseType = null, Expression<Func<string>> bodyhistoryMetadatacausecauseAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseUrl = null, Expression<Func<string>> bodyhistoryMetadataextraData = null, Expression<Func<bodypropertiesInputItem[]>> bodyproperties = null)
        {
            var apiCallPath = String.Format("/v2/3/issue/{0}", ExpressionConverter.ConvertWithUrlEncoding(issueIdOrKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (notifyUsers != null)
                callPayload.Queries["notifyUsers"] = ExpressionConverter.Convert(notifyUsers);
            if (overrideScreenSecurity != null)
                callPayload.Queries["overrideScreenSecurity"] = ExpressionConverter.Convert(overrideScreenSecurity);
            if (overrideEditableFlag != null)
                callPayload.Queries["overrideEditableFlag"] = ExpressionConverter.Convert(overrideEditableFlag);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var body = new JObject();
            var bodypropCount = 0;
            var transitionObject = new JObject();
            var transitionObjectpropCount = 0;
            if (bodytransitiontransitionID != null)
            {
                transitionObject["id"] = ExpressionConverter.ConvertO(bodytransitiontransitionID);
                transitionObjectpropCount++;
            }

            if (bodytransitiontransitionLooped != null)
            {
                transitionObject["looped"] = ExpressionConverter.ConvertO(bodytransitiontransitionLooped);
                transitionObjectpropCount++;
            }

            if (transitionObjectpropCount > 0)
            {
                body["transition"] = transitionObject;
                bodypropCount++;
            }

            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
            if (fieldsObjectpropCount > 0)
            {
                body["fields"] = fieldsObject;
                bodypropCount++;
            }

            var updateObject = new JObject();
            var updateObjectpropCount = 0;
            if (updateObjectpropCount > 0)
            {
                body["update"] = updateObject;
                bodypropCount++;
            }

            var historyMetadataObject = new JObject();
            var historyMetadataObjectpropCount = 0;
            if (bodyhistoryMetadatametadataType != null)
            {
                historyMetadataObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataType);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataDescription != null)
            {
                historyMetadataObject["description"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataDescriptionKey != null)
            {
                historyMetadataObject["descriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataActivityDescription != null)
            {
                historyMetadataObject["activityDescription"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataActivityDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataActivityDescriptionKey != null)
            {
                historyMetadataObject["activityDescriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataActivityDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataEmailDescription != null)
            {
                historyMetadataObject["emailDescription"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataEmailDescription);
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatametadataEmailDescriptionKey != null)
            {
                historyMetadataObject["emailDescriptionKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatametadataEmailDescriptionKey);
                historyMetadataObjectpropCount++;
            }

            var actorObject = new JObject();
            var actorObjectpropCount = 0;
            if (bodyhistoryMetadataactoractorID != null)
            {
                actorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorID);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorDisplayName != null)
            {
                actorObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorDisplayName);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorDisplayNameKey != null)
            {
                actorObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorDisplayNameKey);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorType != null)
            {
                actorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorType);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorAvatarUrl != null)
            {
                actorObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorAvatarUrl);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactoractorUrl != null)
            {
                actorObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoractorUrl);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                historyMetadataObject["actor"] = actorObject;
                historyMetadataObjectpropCount++;
            }

            var generatorObject = new JObject();
            var generatorObjectpropCount = 0;
            if (bodyhistoryMetadatageneratorgeneratorId != null)
            {
                generatorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorId);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorDisplayName != null)
            {
                generatorObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorDisplayName);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorDisplayNameKey != null)
            {
                generatorObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorDisplayNameKey);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorType != null)
            {
                generatorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorType);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorAvatarUrl != null)
            {
                generatorObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorAvatarUrl);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratorgeneratorUrl != null)
            {
                generatorObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorgeneratorUrl);
                generatorObjectpropCount++;
            }

            if (generatorObjectpropCount > 0)
            {
                historyMetadataObject["generator"] = generatorObject;
                historyMetadataObjectpropCount++;
            }

            var causeObject = new JObject();
            var causeObjectpropCount = 0;
            if (bodyhistoryMetadatacausecauseId != null)
            {
                causeObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseId);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseDisplayName != null)
            {
                causeObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseDisplayName);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseDisplayNameKey != null)
            {
                causeObject["displayNameKey"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseDisplayNameKey);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseType != null)
            {
                causeObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseType);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseAvatarUrl != null)
            {
                causeObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseAvatarUrl);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausecauseUrl != null)
            {
                causeObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausecauseUrl);
                causeObjectpropCount++;
            }

            if (causeObjectpropCount > 0)
            {
                historyMetadataObject["cause"] = causeObject;
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadataextraData != null)
            {
                historyMetadataObject["extraData"] = ExpressionConverter.ConvertO(bodyhistoryMetadataextraData);
                historyMetadataObjectpropCount++;
            }

            if (historyMetadataObjectpropCount > 0)
            {
                body["historyMetadata"] = historyMetadataObject;
                bodypropCount++;
            }

            if (bodyproperties != null)
            {
                body["properties"] = ExpressionConverter.ConvertO(bodyproperties);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction DeleteProject(Expression<Func<string>> projectIdOrKey, Expression<Func<bool>> enableUndo = null)
        {
            var apiCallPath = String.Format("/3/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectIdOrKey, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["enableUndo"] = Convert.ToString(false);
            if (enableUndo != null)
                callPayload.Queries["enableUndo"] = ExpressionConverter.Convert(enableUndo);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction UpdateProject(Expression<Func<string>> projectIdOrKey, Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectTypeKey = null, Expression<Func<string>> bodyprojectTemplateKey = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylead = null, Expression<Func<string>> bodyleadAccountId = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyassigneeType = null, Expression<Func<string>> bodyavatarId = null, Expression<Func<string>> bodyissueSecurityScheme = null, Expression<Func<string>> bodypermissionScheme = null, Expression<Func<string>> bodynotificationScheme = null, Expression<Func<string>> bodycategoryId = null)
        {
            var apiCallPath = String.Format("/3/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectIdOrKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyprojectTypeKey != null)
            {
                body["projectTypeKey"] = ExpressionConverter.ConvertO(bodyprojectTypeKey);
                bodypropCount++;
            }

            if (bodyprojectTemplateKey != null)
            {
                body["projectTemplateKey"] = ExpressionConverter.ConvertO(bodyprojectTemplateKey);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodylead != null)
            {
                body["lead"] = ExpressionConverter.ConvertO(bodylead);
                bodypropCount++;
            }

            if (bodyleadAccountId != null)
            {
                body["leadAccountId"] = ExpressionConverter.ConvertO(bodyleadAccountId);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyassigneeType != null)
            {
                body["assigneeType"] = ExpressionConverter.ConvertO(bodyassigneeType);
                bodypropCount++;
            }

            if (bodyavatarId != null)
            {
                body["avatarId"] = ExpressionConverter.ConvertO(bodyavatarId);
                bodypropCount++;
            }

            if (bodyissueSecurityScheme != null)
            {
                body["issueSecurityScheme"] = ExpressionConverter.ConvertO(bodyissueSecurityScheme);
                bodypropCount++;
            }

            if (bodypermissionScheme != null)
            {
                body["permissionScheme"] = ExpressionConverter.ConvertO(bodypermissionScheme);
                bodypropCount++;
            }

            if (bodynotificationScheme != null)
            {
                body["notificationScheme"] = ExpressionConverter.ConvertO(bodynotificationScheme);
                bodypropCount++;
            }

            if (bodycategoryId != null)
            {
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction DeleteProjectV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<bool>> enableUndo = null)
        {
            var apiCallPath = String.Format("/v2/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectIdOrKey, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["enableUndo"] = Convert.ToString(false);
            if (enableUndo != null)
                callPayload.Queries["enableUndo"] = ExpressionConverter.Convert(enableUndo);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction UpdateProjectV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectTypeKey = null, Expression<Func<string>> bodyprojectTemplateKey = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylead = null, Expression<Func<string>> bodyleadAccountId = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyassigneeType = null, Expression<Func<string>> bodyavatarId = null, Expression<Func<string>> bodyissueSecurityScheme = null, Expression<Func<string>> bodypermissionScheme = null, Expression<Func<string>> bodynotificationScheme = null, Expression<Func<string>> bodycategoryId = null)
        {
            var apiCallPath = String.Format("/v2/project/{0}", ExpressionConverter.ConvertWithUrlEncoding(projectIdOrKey, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodykey != null)
            {
                body["key"] = ExpressionConverter.ConvertO(bodykey);
                bodypropCount++;
            }

            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodyprojectTypeKey != null)
            {
                body["projectTypeKey"] = ExpressionConverter.ConvertO(bodyprojectTypeKey);
                bodypropCount++;
            }

            if (bodyprojectTemplateKey != null)
            {
                body["projectTemplateKey"] = ExpressionConverter.ConvertO(bodyprojectTemplateKey);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodylead != null)
            {
                body["lead"] = ExpressionConverter.ConvertO(bodylead);
                bodypropCount++;
            }

            if (bodyleadAccountId != null)
            {
                body["leadAccountId"] = ExpressionConverter.ConvertO(bodyleadAccountId);
                bodypropCount++;
            }

            if (bodyurl != null)
            {
                body["url"] = ExpressionConverter.ConvertO(bodyurl);
                bodypropCount++;
            }

            if (bodyassigneeType != null)
            {
                body["assigneeType"] = ExpressionConverter.ConvertO(bodyassigneeType);
                bodypropCount++;
            }

            if (bodyavatarId != null)
            {
                body["avatarId"] = ExpressionConverter.ConvertO(bodyavatarId);
                bodypropCount++;
            }

            if (bodyissueSecurityScheme != null)
            {
                body["issueSecurityScheme"] = ExpressionConverter.ConvertO(bodyissueSecurityScheme);
                bodypropCount++;
            }

            if (bodypermissionScheme != null)
            {
                body["permissionScheme"] = ExpressionConverter.ConvertO(bodypermissionScheme);
                bodypropCount++;
            }

            if (bodynotificationScheme != null)
            {
                body["notificationScheme"] = ExpressionConverter.ConvertO(bodynotificationScheme);
                bodypropCount++;
            }

            if (bodycategoryId != null)
            {
                body["categoryId"] = ExpressionConverter.ConvertO(bodycategoryId);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<GetAllProjectCategoriesResponseItem[]> GetAllProjectCategories()
        {
            var apiCallPath = "/3/projectCategory";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetAllProjectCategoriesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction CreateProjectCategory(Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = "/3/projectCategory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<GetAllProjectCategoriesV2ResponseItem[]> GetAllProjectCategoriesV2(Expression<Func<string>> xRequestJirainstance)
        {
            var apiCallPath = "/v2/projectCategory";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<GetAllProjectCategoriesV2ResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction CreateProjectCategoryV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var apiCallPath = "/v2/projectCategory";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyname != null)
            {
                body["name"] = ExpressionConverter.ConvertO(bodyname);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = ExpressionConverter.ConvertO(bodydescription);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction RemoveProjectCategory(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/3/projectCategory/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction RemoveProjectCategoryV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/v2/projectCategory/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetTask(Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/3/task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetTaskV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> taskId)
        {
            var apiCallPath = String.Format("/v2/task/{0}", ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetUser(Expression<Func<string>> accountId, Expression<Func<string>> expand = null)
        {
            var apiCallPath = "/3/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accountId"] = ExpressionConverter.Convert(accountId);
            if (expand != null)
                callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetUserV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> accountId, Expression<Func<string>> expand = null)
        {
            var apiCallPath = "/v2/user";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["accountId"] = ExpressionConverter.Convert(accountId);
            if (expand != null)
                callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateIssueResponse> CreateIssueV3(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey, Expression<Func<string>> issueTypeIds, Expression<Func<object>> item = null)
        {
            var apiCallPath = "/v3/issue";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            callPayload.Queries["issueTypeIds"] = ExpressionConverter.Convert(issueTypeIds);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Body = ExpressionConverter.ConvertO(item);
            return new ApiConnectionAction<CreateIssueResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<FullIssue> GetIssue(Expression<Func<string>> issueKey)
        {
            var apiCallPath = String.Format("/issue/{0}", ExpressionConverter.ConvertWithUrlEncoding(issueKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<FullIssue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<FullIssue> GetIssueV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey)
        {
            var apiCallPath = String.Format("/v2/issue/{0}", ExpressionConverter.ConvertWithUrlEncoding(issueKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<FullIssue>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CommentResponse> AddComment(Expression<Func<string>> issueKey, Expression<Func<string>> bodycomment)
        {
            var apiCallPath = String.Format("/issue/{0}/comment", ExpressionConverter.ConvertWithUrlEncoding(issueKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodycomment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CommentResponse> AddCommentV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey, Expression<Func<string>> bodycomment)
        {
            var apiCallPath = String.Format("/v2/issue/{0}/comment", ExpressionConverter.ConvertWithUrlEncoding(issueKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["body"] = ExpressionConverter.ConvertO(bodycomment);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<CommentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject(Expression<Func<string>> projectprojectKey, Expression<Func<string>> projectname, Expression<Func<projecttypeInput>> projecttype, Expression<Func<string>> projectleadId, Expression<Func<string>> projectdescription = null)
        {
            var apiCallPath = "/project";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var project = new JObject();
            var projectpropCount = 0;
            projectpropCount++;
            project["key"] = ExpressionConverter.ConvertO(projectprojectKey);
            projectpropCount++;
            project["name"] = ExpressionConverter.ConvertO(projectname);
            projectpropCount++;
            project["projectTypeKey"] = ExpressionConverter.ConvertO(projecttype);
            projectpropCount++;
            project["leadAccountId"] = ExpressionConverter.ConvertO(projectleadId);
            if (projectdescription != null)
            {
                project["description"] = ExpressionConverter.ConvertO(projectdescription);
                projectpropCount++;
            }

            if (projectpropCount > 0)
            {
                callPayload.Body = project;
            }

            return new ApiConnectionAction<CreateProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProjectV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectprojectKey, Expression<Func<string>> projectname, Expression<Func<projecttypeInput>> projecttype, Expression<Func<string>> projectleadId, Expression<Func<string>> projectdescription = null)
        {
            var apiCallPath = "/v2/project";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var project = new JObject();
            var projectpropCount = 0;
            projectpropCount++;
            project["key"] = ExpressionConverter.ConvertO(projectprojectKey);
            projectpropCount++;
            project["name"] = ExpressionConverter.ConvertO(projectname);
            projectpropCount++;
            project["projectTypeKey"] = ExpressionConverter.ConvertO(projecttype);
            projectpropCount++;
            project["leadAccountId"] = ExpressionConverter.ConvertO(projectleadId);
            if (projectdescription != null)
            {
                project["description"] = ExpressionConverter.ConvertO(projectdescription);
                projectpropCount++;
            }

            if (projectpropCount > 0)
            {
                callPayload.Body = project;
            }

            return new ApiConnectionAction<CreateProjectResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListProjectsResponseV2> ListProjectsV2()
        {
            var apiCallPath = "/project/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListProjectsResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListProjectsResponseV2> ListProjectsV3(Expression<Func<string>> xRequestJirainstance)
        {
            var apiCallPath = "/v2/project/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<ListProjectsResponseV2>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<UserListItem[]> ListProjectUsers(Expression<Func<string>> projectKey)
        {
            var apiCallPath = "/user/permission/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionAction<UserListItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<UserListItem[]> ListProjectUsersV2(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey)
        {
            var apiCallPath = "/v2/user/permission/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<UserListItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListFiltersResponse> ListFilters()
        {
            var apiCallPath = "/2/filter/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ListFiltersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListFiltersResponse> ListFiltersV2(Expression<Func<string>> xRequestJirainstance)
        {
            var apiCallPath = "/v2/filter/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<ListFiltersResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<SitesItem[]> ListResources()
        {
            var apiCallPath = "/oauth/token/accessible-resources";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SitesItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponse> ListIssues(Expression<Func<string>> xRequestJirainstance)
        {
            var apiCallPath = "/2/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["jql"] = Convert.ToString("created >= -3650d");
            callPayload.Queries["expand"] = Convert.ToString("*");
            callPayload.Queries["fields"] = Convert.ToString("*all");
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<ListIssuesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponseDatacenter> ListIssuesDatacenter(Expression<Func<string>> xRequestJirainstance)
        {
            var apiCallPath = "/datacenter/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<ListIssuesResponseDatacenter>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListTransitionsResponse> ListTransitions(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey)
        {
            var apiCallPath = String.Format("/3/issue/{0}/transitions", ExpressionConverter.ConvertWithUrlEncoding(issueIdOrKey, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction<ListTransitionsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction UpdateTransition(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<string>> bodyfieldsassigneename = null, Expression<Func<string>> bodyfieldsresolutionname = null, Expression<Func<string>> bodyhistoryMetadataactivityDescription = null, Expression<Func<string>> bodyhistoryMetadataactoravatarUrl = null, Expression<Func<string>> bodyhistoryMetadataactordisplayName = null, Expression<Func<string>> bodyhistoryMetadataactorid = null, Expression<Func<string>> bodyhistoryMetadataactortype = null, Expression<Func<string>> bodyhistoryMetadataactorurl = null, Expression<Func<string>> bodyhistoryMetadatacauseid = null, Expression<Func<string>> bodyhistoryMetadatacausetype = null, Expression<Func<string>> bodyhistoryMetadatadescription = null, Expression<Func<string>> bodyhistoryMetadataextraDataIteration = null, Expression<Func<string>> bodyhistoryMetadataextraDataStep = null, Expression<Func<string>> bodyhistoryMetadatageneratorid = null, Expression<Func<string>> bodyhistoryMetadatageneratortype = null, Expression<Func<string>> bodyhistoryMetadatatype = null, Expression<Func<string>> bodytransitionid = null, Expression<Func<bodyupdatecommentInputItem[]>> bodyupdatecomment = null)
        {
            var apiCallPath = String.Format("/3/issue/{0}/transitions", ExpressionConverter.ConvertWithUrlEncoding(issueIdOrKey, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            var body = new JObject();
            var bodypropCount = 0;
            var fieldsObject = new JObject();
            var fieldsObjectpropCount = 0;
            var assigneeObject = new JObject();
            var assigneeObjectpropCount = 0;
            if (bodyfieldsassigneename != null)
            {
                assigneeObject["name"] = ExpressionConverter.ConvertO(bodyfieldsassigneename);
                assigneeObjectpropCount++;
            }

            if (assigneeObjectpropCount > 0)
            {
                fieldsObject["assignee"] = assigneeObject;
                fieldsObjectpropCount++;
            }

            var resolutionObject = new JObject();
            var resolutionObjectpropCount = 0;
            if (bodyfieldsresolutionname != null)
            {
                resolutionObject["name"] = ExpressionConverter.ConvertO(bodyfieldsresolutionname);
                resolutionObjectpropCount++;
            }

            if (resolutionObjectpropCount > 0)
            {
                fieldsObject["resolution"] = resolutionObject;
                fieldsObjectpropCount++;
            }

            if (fieldsObjectpropCount > 0)
            {
                body["fields"] = fieldsObject;
                bodypropCount++;
            }

            var historyMetadataObject = new JObject();
            var historyMetadataObjectpropCount = 0;
            if (bodyhistoryMetadataactivityDescription != null)
            {
                historyMetadataObject["activityDescription"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactivityDescription);
                historyMetadataObjectpropCount++;
            }

            var actorObject = new JObject();
            var actorObjectpropCount = 0;
            if (bodyhistoryMetadataactoravatarUrl != null)
            {
                actorObject["avatarUrl"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactoravatarUrl);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactordisplayName != null)
            {
                actorObject["displayName"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactordisplayName);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactorid != null)
            {
                actorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactorid);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactortype != null)
            {
                actorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactortype);
                actorObjectpropCount++;
            }

            if (bodyhistoryMetadataactorurl != null)
            {
                actorObject["url"] = ExpressionConverter.ConvertO(bodyhistoryMetadataactorurl);
                actorObjectpropCount++;
            }

            if (actorObjectpropCount > 0)
            {
                historyMetadataObject["actor"] = actorObject;
                historyMetadataObjectpropCount++;
            }

            var causeObject = new JObject();
            var causeObjectpropCount = 0;
            if (bodyhistoryMetadatacauseid != null)
            {
                causeObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacauseid);
                causeObjectpropCount++;
            }

            if (bodyhistoryMetadatacausetype != null)
            {
                causeObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatacausetype);
                causeObjectpropCount++;
            }

            if (causeObjectpropCount > 0)
            {
                historyMetadataObject["cause"] = causeObject;
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatadescription != null)
            {
                historyMetadataObject["description"] = ExpressionConverter.ConvertO(bodyhistoryMetadatadescription);
                historyMetadataObjectpropCount++;
            }

            var extraDataObject = new JObject();
            var extraDataObjectpropCount = 0;
            if (bodyhistoryMetadataextraDataIteration != null)
            {
                extraDataObject["Iteration"] = ExpressionConverter.ConvertO(bodyhistoryMetadataextraDataIteration);
                extraDataObjectpropCount++;
            }

            if (bodyhistoryMetadataextraDataStep != null)
            {
                extraDataObject["Step"] = ExpressionConverter.ConvertO(bodyhistoryMetadataextraDataStep);
                extraDataObjectpropCount++;
            }

            if (extraDataObjectpropCount > 0)
            {
                historyMetadataObject["extraData"] = extraDataObject;
                historyMetadataObjectpropCount++;
            }

            var generatorObject = new JObject();
            var generatorObjectpropCount = 0;
            if (bodyhistoryMetadatageneratorid != null)
            {
                generatorObject["id"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratorid);
                generatorObjectpropCount++;
            }

            if (bodyhistoryMetadatageneratortype != null)
            {
                generatorObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatageneratortype);
                generatorObjectpropCount++;
            }

            if (generatorObjectpropCount > 0)
            {
                historyMetadataObject["generator"] = generatorObject;
                historyMetadataObjectpropCount++;
            }

            if (bodyhistoryMetadatatype != null)
            {
                historyMetadataObject["type"] = ExpressionConverter.ConvertO(bodyhistoryMetadatatype);
                historyMetadataObjectpropCount++;
            }

            if (historyMetadataObjectpropCount > 0)
            {
                body["historyMetadata"] = historyMetadataObject;
                bodypropCount++;
            }

            var transitionObject = new JObject();
            var transitionObjectpropCount = 0;
            if (bodytransitionid != null)
            {
                transitionObject["id"] = ExpressionConverter.ConvertO(bodytransitionid);
                transitionObjectpropCount++;
            }

            if (transitionObjectpropCount > 0)
            {
                body["transition"] = transitionObject;
                bodypropCount++;
            }

            var updateObject = new JObject();
            var updateObjectpropCount = 0;
            if (bodyupdatecomment != null)
            {
                updateObject["comment"] = ExpressionConverter.ConvertO(bodyupdatecomment);
                updateObjectpropCount++;
            }

            if (updateObjectpropCount > 0)
            {
                body["update"] = updateObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetCurrentUser(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> expand = null)
        {
            var apiCallPath = "/3/myself";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (expand != null)
                callPayload.Queries["expand"] = ExpressionConverter.Convert(expand);
            callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<MCPQueryResponse> McpJiraIssueManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var apiCallPath = "/mcp/JiraIssueManagement";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sessionId != null)
                callPayload.Queries["sessionId"] = ExpressionConverter.Convert(sessionId);
            var queryRequest = new JObject();
            var queryRequestpropCount = 0;
            if (queryRequestjsonrpc != null)
            {
                queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(queryRequestjsonrpc);
                queryRequestpropCount++;
            }

            if (queryRequestid != null)
            {
                queryRequest["id"] = ExpressionConverter.ConvertO(queryRequestid);
                queryRequestpropCount++;
            }

            if (queryRequestmethod != null)
            {
                queryRequest["method"] = ExpressionConverter.ConvertO(queryRequestmethod);
                queryRequestpropCount++;
            }

            var paramsObject = new JObject();
            var paramsObjectpropCount = 0;
            if (paramsObjectpropCount > 0)
            {
                queryRequest["params"] = paramsObject;
                queryRequestpropCount++;
            }

            var resultObject = new JObject();
            var resultObjectpropCount = 0;
            if (resultObjectpropCount > 0)
            {
                queryRequest["result"] = resultObject;
                queryRequestpropCount++;
            }

            var errorObject = new JObject();
            var errorObjectpropCount = 0;
            if (errorObjectpropCount > 0)
            {
                queryRequest["error"] = errorObject;
                queryRequestpropCount++;
            }

            if (queryRequestpropCount > 0)
            {
                callPayload.Body = queryRequest;
            }

            return new ApiConnectionAction<MCPQueryResponse>(callPayload);
        }
    }

    public class JiraTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssue(Expression<Func<string>> projectKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueV2(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/new_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datacenter/new_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnCloseIssue(Expression<Func<string>> projectKey, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/close_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnCloseIssueV2(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/close_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnCloseIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datacenter/close_issue_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["projectKey"] = ExpressionConverter.Convert(projectKey);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueJQL(Expression<Func<string>> jql, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/new_issue_jql_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["jql"] = ExpressionConverter.Convert(jql);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueJQLV2(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/v2/new_issue_jql_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["jql"] = ExpressionConverter.Convert(jql);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueJQLDatacenter(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/datacenter/new_issue_jql_trigger/search";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (xRequestJirainstance != null)
                callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(xRequestJirainstance);
            callPayload.Queries["jql"] = ExpressionConverter.Convert(jql);
            return new ApiConnectionTrigger<FullIssue[]>(callPayload, triggerName, recurrence);
        }
    }

    public class bodypropertiesInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class GetAllProjectCategoriesResponseItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetAllProjectCategoriesV2ResponseItem
    {
        [JsonProperty("self")]
        public string Self { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class CreateIssueResponse
    {
        [JsonProperty("id")]
        public string IssueId { get; set; }

        [JsonProperty("key")]
        public string IssueKey { get; set; }
    }

    public class FullIssue
    {
        [JsonProperty("id")]
        public string IssueId { get; set; }

        [JsonProperty("key")]
        public string IssueKey { get; set; }

        [JsonProperty("self")]
        public string IssueURL { get; set; }

        [JsonProperty("fields")]
        public FullIssueFieldsType Fields { get; set; }
    }

    public class FullIssueFieldsType
    {
        [JsonProperty("issuetype")]
        public FullIssueFieldsTypeIssuetypeType Issuetype { get; set; }

        [JsonProperty("timespent")]
        public int TimeSpent { get; set; }

        [JsonProperty("project")]
        public FullIssueFieldsTypeProjectType Project { get; set; }

        [JsonProperty("aggregatetimespent")]
        public int AggregateTimeSpent { get; set; }

        [JsonProperty("resolution")]
        public FullIssueFieldsTypeResolutionType Resolution { get; set; }

        [JsonProperty("resolutiondate")]
        public string ResolutionDate { get; set; }

        [JsonProperty("workratio")]
        public int WorkRatio { get; set; }

        [JsonProperty("created")]
        public string CreatedDate { get; set; }

        [JsonProperty("priority")]
        public FullIssueFieldsTypePriorityType Priority { get; set; }

        [JsonProperty("timeestimate")]
        public int TimeEstimate { get; set; }

        [JsonProperty("aggregatetimeestimate")]
        public int AggregateTimeEstimate { get; set; }

        [JsonProperty("assignee")]
        public FullIssueFieldsTypeAssigneeType Assignee { get; set; }

        [JsonProperty("updated")]
        public string UpdatedDateTime { get; set; }

        [JsonProperty("status")]
        public FullIssueFieldsTypeStatusType Status { get; set; }

        [JsonProperty("timeoriginalestimate")]
        public int OriginalTimeEstimate { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("components")]
        public FullIssueFieldsTypeComponentsTypeItem[] Components { get; set; }

        [JsonProperty("creator")]
        public FullIssueFieldsTypeCreatorType Creator { get; set; }

        [JsonProperty("reporter")]
        public FullIssueFieldsTypeReporterType Reporter { get; set; }

        [JsonProperty("aggregateprogress")]
        public FullIssueFieldsTypeAggregateprogressType Aggregateprogress { get; set; }

        [JsonProperty("duedate")]
        public string DueDateTime { get; set; }

        [JsonProperty("progress")]
        public FullIssueFieldsTypeProgressType Progress { get; set; }

        [JsonProperty("customfield_10119")]
        public JToken EpicNameCustomfield10011 { get; set; }
    }

    public class FullIssueFieldsTypeIssuetypeType
    {
        [JsonProperty("id")]
        public string IssueTypeId { get; set; }

        [JsonProperty("description")]
        public string IssueTypeDescription { get; set; }

        [JsonProperty("iconUrl")]
        public string IssueTypeIconURL { get; set; }

        [JsonProperty("name")]
        public string IssueTypeName { get; set; }
    }

    public class FullIssueFieldsTypeProjectType
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }
    }

    public class FullIssueFieldsTypeResolutionType
    {
        [JsonProperty("self")]
        public string URLOfTheIssueResolution { get; set; }

        [JsonProperty("id")]
        public string IDOfTheIssueResolution { get; set; }

        [JsonProperty("description")]
        public string DescriptionOfTheIssueResolution { get; set; }

        [JsonProperty("name")]
        public string NameFoTheIssueResolution { get; set; }
    }

    public class FullIssueFieldsTypePriorityType
    {
        [JsonProperty("iconUrl")]
        public string PriorityIconURL { get; set; }

        [JsonProperty("name")]
        public string PriorityName { get; set; }

        [JsonProperty("id")]
        public string PriorityId { get; set; }
    }

    public class FullIssueFieldsTypeAssigneeType
    {
        [JsonProperty("accountId")]
        public string AssigneeId { get; set; }

        [JsonProperty("key")]
        public string AssigneeKey { get; set; }

        [JsonProperty("emailAddress")]
        public string AssigneeEmail { get; set; }

        [JsonProperty("displayName")]
        public string AssigneeDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeStatusType
    {
        [JsonProperty("description")]
        public string StatusDescription { get; set; }

        [JsonProperty("iconUrl")]
        public string StatusIconURL { get; set; }

        [JsonProperty("name")]
        public string StatusName { get; set; }

        [JsonProperty("id")]
        public string StatusId { get; set; }

        [JsonProperty("statusCategory")]
        public FullIssueFieldsTypeStatusTypeStatusCategoryType StatusCategory { get; set; }
    }

    public class FullIssueFieldsTypeStatusTypeStatusCategoryType
    {
        [JsonProperty("id")]
        public int StatusCategoryId { get; set; }

        [JsonProperty("key")]
        public string StatusCategoryKey { get; set; }

        [JsonProperty("colorName")]
        public string StatusCategoryColorName { get; set; }

        [JsonProperty("name")]
        public string StatusCategoryName { get; set; }
    }

    public class FullIssueFieldsTypeComponentsTypeItem
    {
        [JsonProperty("id")]
        public string ComponentId { get; set; }

        [JsonProperty("name")]
        public string ComponentName { get; set; }
    }

    public class FullIssueFieldsTypeCreatorType
    {
        [JsonProperty("accountId")]
        public string CreatorId { get; set; }

        [JsonProperty("key")]
        public string CreatorKey { get; set; }

        [JsonProperty("emailAddress")]
        public string CreatorEmail { get; set; }

        [JsonProperty("displayName")]
        public string CreatorDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeReporterType
    {
        [JsonProperty("accountId")]
        public string ReporterId { get; set; }

        [JsonProperty("key")]
        public string ReporterKey { get; set; }

        [JsonProperty("emailAddress")]
        public string ReporterEmail { get; set; }

        [JsonProperty("displayName")]
        public string ReporterDisplayName { get; set; }
    }

    public class FullIssueFieldsTypeAggregateprogressType
    {
        [JsonProperty("progress")]
        public int AggregateProgressCompleted { get; set; }

        [JsonProperty("total")]
        public int AggregateEstimatedEffort { get; set; }

        [JsonProperty("percent")]
        public int AggregateProgressPercent { get; set; }
    }

    public class FullIssueFieldsTypeProgressType
    {
        [JsonProperty("progress")]
        public int ProgressCompleted { get; set; }

        [JsonProperty("total")]
        public int EstimatedEffort { get; set; }

        [JsonProperty("percent")]
        public int ProgressPercent { get; set; }
    }

    public class CommentResponse
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("body")]
        public string CommentBody { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }
    }

    public class CreateProjectResponse
    {
        [JsonProperty("id")]
        public int ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }
    }

    public enum projecttypeInput
    {
        [EnumMember(Value = "Software - Scrum software development")]
        SoftwareScrumSoftwareDevelopment,
        [EnumMember(Value = "Software - Kanban software development")]
        SoftwareKanbanSoftwareDevelopment,
        [EnumMember(Value = "Software - Basic software development")]
        SoftwareBasicSoftwareDevelopment,
        [EnumMember(Value = "Business - Project management")]
        BusinessProjectManagement,
        [EnumMember(Value = "Business - Task management")]
        BusinessTaskManagement,
        [EnumMember(Value = "Business - Process management")]
        BusinessProcessManagement
    }

    public class ListProjectsResponseV2
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("values")]
        public ProjectArrayItem[] Values { get; set; }
    }

    public class ProjectArrayItem
    {
        [JsonProperty("id")]
        public string ProjectId { get; set; }

        [JsonProperty("key")]
        public string ProjectKey { get; set; }

        [JsonProperty("name")]
        public string ProjectName { get; set; }

        [JsonProperty("projectTypeKey")]
        public string ProjectTypeKey { get; set; }
    }

    public class UserListItem
    {
        [JsonProperty("accountId")]
        public string Id { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }

    public class ListFiltersResponse
    {
        [JsonProperty("nextPage")]
        public string NextPage { get; set; }

        [JsonProperty("values")]
        public FilterArrayItem[] Values { get; set; }
    }

    public class FilterArrayItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("jql")]
        public string JQL { get; set; }
    }

    public class SitesItem
    {
        [JsonProperty("id")]
        public string CloudId { get; set; }

        [JsonProperty("name")]
        public string SiteName { get; set; }

        [JsonProperty("url")]
        public string SiteURL { get; set; }
    }

    public class ListIssuesResponse
    {
        [JsonProperty("maxResults")]
        public int MaximumNumberOfItems { get; set; }

        [JsonProperty("issues")]
        public JToken[] Issues { get; set; }
    }

    public class ListIssuesResponseDatacenter
    {
        [JsonProperty("startAt")]
        public int StartingRecordNumber { get; set; }

        [JsonProperty("maxResults")]
        public int MaximumNumberOfItems { get; set; }

        [JsonProperty("issues")]
        public JToken[] Issues { get; set; }
    }

    public class ListTransitionsResponse
    {
        [JsonProperty("transitions")]
        public Transition[] Transitions { get; set; }
    }

    public class Transition
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("to")]
        public TransitionStatus To { get; set; }

        [JsonProperty("fields")]
        public JToken Fields { get; set; }
    }

    public class TransitionStatus
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class bodyupdatecommentInputItem
    {
        [JsonProperty("add")]
        public bodyupdatecommentInputItemAddType Add { get; set; }
    }

    public class bodyupdatecommentInputItemAddType
    {
        [JsonProperty("body")]
        public string Body { get; set; }
    }

    public class MCPQueryResponse
    {
        [JsonProperty("jsonrpc")]
        public string Jsonrpc { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("params")]
        public JToken Params { get; set; }

        [JsonProperty("result")]
        public JToken Result { get; set; }

        [JsonProperty("error")]
        public JToken Error { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Jira;

    public partial class WorkflowManagedActions
    {
        public JiraActions Jira(string connectionId) => new JiraActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public JiraTriggers Jira(string connectionId) => new JiraTriggers(connectionId);
    }
}