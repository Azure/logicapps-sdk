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
        public IBodyWorkflowAction<SitesItem[]> ListResources()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/oauth/token/accessible-resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SitesItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponse> ListIssues([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> jql = null, [WorkflowExpression] Func<string> nextPageToken = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/2/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (jql != null)
                    callPayload.Queries["jql"] = SourceExpressionConverter.ConvertO(jql);
                callPayload.Queries["expand"] = Convert.ToString("*");
                callPayload.Queries["fields"] = Convert.ToString("*all");
                if (nextPageToken != null)
                    callPayload.Queries["nextPageToken"] = SourceExpressionConverter.ConvertO(nextPageToken);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<ListIssuesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponseDatacenter> ListIssuesDatacenter([WorkflowExpression] Func<string> xRequestJirainstance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datacenter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<ListIssuesResponseDatacenter>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListTransitionsResponse> ListTransitions([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> issueIdOrKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/3/issue/{0}/transitions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueIdOrKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<ListTransitionsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction UpdateTransition([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> issueIdOrKey, [WorkflowExpression] Func<string> bodyfieldsassigneename = null, [WorkflowExpression] Func<string> bodyfieldsresolutionname = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactivityDescription = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoravatarUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactordisplayName = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactorid = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactortype = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactorurl = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacauseid = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausetype = null, [WorkflowExpression] Func<string> bodyhistoryMetadatadescription = null, [WorkflowExpression] Func<string> bodyhistoryMetadataextraDataiteration = null, [WorkflowExpression] Func<string> bodyhistoryMetadataextraDatastep = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorid = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratortype = null, [WorkflowExpression] Func<string> bodyhistoryMetadatatype = null, [WorkflowExpression] Func<string> bodytransitionid = null, [WorkflowExpression] Func<bodyupdatecommentInputItem[]> bodyupdatecomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/3/issue/{0}/transitions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueIdOrKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                if (bodyfieldsassigneename != null)
                {
                    assigneeObject["name"] = SourceExpressionConverter.ConvertToken(bodyfieldsassigneename);
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
                    resolutionObject["name"] = SourceExpressionConverter.ConvertToken(bodyfieldsresolutionname);
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
                    historyMetadataObject["activityDescription"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactivityDescription);
                    historyMetadataObjectpropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (bodyhistoryMetadataactoravatarUrl != null)
                {
                    actorObject["avatarUrl"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoravatarUrl);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactordisplayName != null)
                {
                    actorObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactordisplayName);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactorid != null)
                {
                    actorObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactorid);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactortype != null)
                {
                    actorObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactortype);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactorurl != null)
                {
                    actorObject["url"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactorurl);
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
                    causeObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacauseid);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausetype != null)
                {
                    causeObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausetype);
                    causeObjectpropCount++;
                }

                if (causeObjectpropCount > 0)
                {
                    historyMetadataObject["cause"] = causeObject;
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatadescription != null)
                {
                    historyMetadataObject["description"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatadescription);
                    historyMetadataObjectpropCount++;
                }

                var extraDataObject = new JObject();
                var extraDataObjectpropCount = 0;
                if (bodyhistoryMetadataextraDataiteration != null)
                {
                    extraDataObject["Iteration"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataextraDataiteration);
                    extraDataObjectpropCount++;
                }

                if (bodyhistoryMetadataextraDatastep != null)
                {
                    extraDataObject["Step"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataextraDatastep);
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
                    generatorObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorid);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratortype != null)
                {
                    generatorObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratortype);
                    generatorObjectpropCount++;
                }

                if (generatorObjectpropCount > 0)
                {
                    historyMetadataObject["generator"] = generatorObject;
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatatype != null)
                {
                    historyMetadataObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatatype);
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
                    transitionObject["id"] = SourceExpressionConverter.ConvertToken(bodytransitionid);
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
                    updateObject["comment"] = SourceExpressionConverter.ConvertToken(bodyupdatecomment);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetCurrentUser([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/3/myself";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<MCPQueryResponse> McpJiraIssueManagement([WorkflowExpression] Func<string> queryRequestjsonrpc = null, [WorkflowExpression] Func<string> queryRequestid = null, [WorkflowExpression] Func<string> queryRequestmethod = null, [WorkflowExpression] Func<string> sessionId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/mcp/JiraIssueManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sessionId != null)
                    callPayload.Queries["sessionId"] = SourceExpressionConverter.ConvertO(sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = SourceExpressionConverter.ConvertToken(queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (queryRequestid != null)
                {
                    queryRequest["id"] = SourceExpressionConverter.ConvertToken(queryRequestid);
                    queryRequestpropCount++;
                }

                if (queryRequestmethod != null)
                {
                    queryRequest["method"] = SourceExpressionConverter.ConvertToken(queryRequestmethod);
                    queryRequestpropCount++;
                }

                var @paramsObject = new JObject();
                var @paramsObjectpropCount = 0;
                if (@paramsObjectpropCount > 0)
                {
                    queryRequest["params"] = @paramsObject;
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
                return callPayload;
            }

            return new ApiConnectionAction<MCPQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CommentResponse> AddComment([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> issueKey, [WorkflowExpression] Func<string> bodycomment)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/issue/{0}/comment", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueKey, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = SourceExpressionConverter.ConvertToken(bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CommentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateIssueResponse> CreateIssue([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> projectKey, [WorkflowExpression] Func<string> issueTypeIds, [WorkflowExpression] Func<object> item = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v3/issue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                callPayload.Queries["issueTypeIds"] = SourceExpressionConverter.ConvertO(issueTypeIds);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<CreateIssueResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateProjectResponse> CreateProject([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> projectprojectKey, [WorkflowExpression] Func<string> projectname, [WorkflowExpression] Func<projecttypeInput> projecttype, [WorkflowExpression] Func<string> projectleadId, [WorkflowExpression] Func<string> projectdescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var project = new JObject();
                var projectpropCount = 0;
                projectpropCount++;
                project["key"] = SourceExpressionConverter.ConvertToken(projectprojectKey);
                projectpropCount++;
                project["name"] = SourceExpressionConverter.ConvertToken(projectname);
                projectpropCount++;
                project["projectTypeKey"] = SourceExpressionConverter.Convert(projecttype);
                projectpropCount++;
                project["leadAccountId"] = SourceExpressionConverter.ConvertToken(projectleadId);
                if (projectdescription != null)
                {
                    project["description"] = SourceExpressionConverter.ConvertToken(projectdescription);
                    projectpropCount++;
                }

                if (projectpropCount > 0)
                {
                    callPayload.Body = project;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProjectResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction CreateProjectCategory([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodydescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction DeleteProject([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> projectIdOrKey, [WorkflowExpression] Func<bool> enableUndo = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectIdOrKey, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["enableUndo"] = Convert.ToString(false);
                if (enableUndo != null)
                    callPayload.Queries["enableUndo"] = SourceExpressionConverter.ConvertO(enableUndo);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<JToken> EditIssue([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> issueIdOrKey, [WorkflowExpression] Func<bool> notifyUsers = null, [WorkflowExpression] Func<bool> overrideScreenSecurity = null, [WorkflowExpression] Func<bool> overrideEditableFlag = null, [WorkflowExpression] Func<string> bodytransitiontransitionId = null, [WorkflowExpression] Func<string> bodytransitiontransitionLooped = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataType = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataDescription = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataDescriptionKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataActivityDescription = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataActivityDescriptionKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataEmailDescription = null, [WorkflowExpression] Func<string> bodyhistoryMetadatametadataEmailDescriptionKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorId = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorDisplayName = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorDisplayNameKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorType = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorAvatarUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadataactoractorUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorId = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorDisplayName = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorDisplayNameKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorType = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorAvatarUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadatageneratorgeneratorUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseId = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseDisplayName = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseDisplayNameKey = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseType = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseAvatarUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadatacausecauseUrl = null, [WorkflowExpression] Func<string> bodyhistoryMetadataextraData = null, [WorkflowExpression] Func<bodypropertiesInputItem[]> bodyproperties = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/3/issue/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueIdOrKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (notifyUsers != null)
                    callPayload.Queries["notifyUsers"] = SourceExpressionConverter.ConvertO(notifyUsers);
                if (overrideScreenSecurity != null)
                    callPayload.Queries["overrideScreenSecurity"] = SourceExpressionConverter.ConvertO(overrideScreenSecurity);
                if (overrideEditableFlag != null)
                    callPayload.Queries["overrideEditableFlag"] = SourceExpressionConverter.ConvertO(overrideEditableFlag);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                var transitionObject = new JObject();
                var transitionObjectpropCount = 0;
                if (bodytransitiontransitionId != null)
                {
                    transitionObject["id"] = SourceExpressionConverter.ConvertToken(bodytransitiontransitionId);
                    transitionObjectpropCount++;
                }

                if (bodytransitiontransitionLooped != null)
                {
                    transitionObject["looped"] = SourceExpressionConverter.ConvertToken(bodytransitiontransitionLooped);
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
                    historyMetadataObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataType);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataDescription != null)
                {
                    historyMetadataObject["description"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataDescription);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataDescriptionKey != null)
                {
                    historyMetadataObject["descriptionKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataActivityDescription != null)
                {
                    historyMetadataObject["activityDescription"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataActivityDescription);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataActivityDescriptionKey != null)
                {
                    historyMetadataObject["activityDescriptionKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataActivityDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataEmailDescription != null)
                {
                    historyMetadataObject["emailDescription"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataEmailDescription);
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadatametadataEmailDescriptionKey != null)
                {
                    historyMetadataObject["emailDescriptionKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatametadataEmailDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (bodyhistoryMetadataactoractorId != null)
                {
                    actorObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorId);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactoractorDisplayName != null)
                {
                    actorObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorDisplayName);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactoractorDisplayNameKey != null)
                {
                    actorObject["displayNameKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorDisplayNameKey);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactoractorType != null)
                {
                    actorObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorType);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactoractorAvatarUrl != null)
                {
                    actorObject["avatarUrl"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorAvatarUrl);
                    actorObjectpropCount++;
                }

                if (bodyhistoryMetadataactoractorUrl != null)
                {
                    actorObject["url"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataactoractorUrl);
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
                    generatorObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorId);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratorgeneratorDisplayName != null)
                {
                    generatorObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorDisplayName);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratorgeneratorDisplayNameKey != null)
                {
                    generatorObject["displayNameKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorDisplayNameKey);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratorgeneratorType != null)
                {
                    generatorObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorType);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratorgeneratorAvatarUrl != null)
                {
                    generatorObject["avatarUrl"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorAvatarUrl);
                    generatorObjectpropCount++;
                }

                if (bodyhistoryMetadatageneratorgeneratorUrl != null)
                {
                    generatorObject["url"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatageneratorgeneratorUrl);
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
                    causeObject["id"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseId);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausecauseDisplayName != null)
                {
                    causeObject["displayName"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseDisplayName);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausecauseDisplayNameKey != null)
                {
                    causeObject["displayNameKey"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseDisplayNameKey);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausecauseType != null)
                {
                    causeObject["type"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseType);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausecauseAvatarUrl != null)
                {
                    causeObject["avatarUrl"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseAvatarUrl);
                    causeObjectpropCount++;
                }

                if (bodyhistoryMetadatacausecauseUrl != null)
                {
                    causeObject["url"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadatacausecauseUrl);
                    causeObjectpropCount++;
                }

                if (causeObjectpropCount > 0)
                {
                    historyMetadataObject["cause"] = causeObject;
                    historyMetadataObjectpropCount++;
                }

                if (bodyhistoryMetadataextraData != null)
                {
                    historyMetadataObject["extraData"] = SourceExpressionConverter.ConvertToken(bodyhistoryMetadataextraData);
                    historyMetadataObjectpropCount++;
                }

                if (historyMetadataObjectpropCount > 0)
                {
                    body["historyMetadata"] = historyMetadataObject;
                    bodypropCount++;
                }

                if (bodyproperties != null)
                {
                    body["properties"] = SourceExpressionConverter.ConvertToken(bodyproperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<GetAllProjectCategoriesV2ResponseItem[]> GetAllProjectCategories([WorkflowExpression] Func<string> xRequestJirainstance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllProjectCategoriesV2ResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<FullIssue> GetIssue([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> issueKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/issue/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(issueKey, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<FullIssue>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetTask([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> taskId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/task/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction GetUser([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> accountId, [WorkflowExpression] Func<string> expand = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accountId"] = SourceExpressionConverter.ConvertO(accountId);
                if (expand != null)
                    callPayload.Queries["expand"] = SourceExpressionConverter.ConvertO(expand);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListFiltersResponse> ListFilters([WorkflowExpression] Func<string> xRequestJirainstance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/filter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<ListFiltersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListProjectsResponseV2> ListProjects([WorkflowExpression] Func<string> xRequestJirainstance)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/project/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<ListProjectsResponseV2>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<UserListItem[]> ListProjectUsers([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> projectKey)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/user/permission/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction<UserListItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction RemoveProjectCategory([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<int> id)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/projectCategory/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction UpdateProject([WorkflowExpression] Func<string> xRequestJirainstance, [WorkflowExpression] Func<string> projectIdOrKey, [WorkflowExpression] Func<string> bodykey = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodyprojectTypeKey = null, [WorkflowExpression] Func<string> bodyprojectTemplateKey = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodylead = null, [WorkflowExpression] Func<string> bodyleadAccountId = null, [WorkflowExpression] Func<string> bodyurl = null, [WorkflowExpression] Func<string> bodyassigneeType = null, [WorkflowExpression] Func<string> bodyavatarId = null, [WorkflowExpression] Func<string> bodyissueSecurityScheme = null, [WorkflowExpression] Func<string> bodypermissionScheme = null, [WorkflowExpression] Func<string> bodynotificationScheme = null, [WorkflowExpression] Func<string> bodycategoryId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/project/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(projectIdOrKey, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodykey != null)
                {
                    body["key"] = SourceExpressionConverter.ConvertToken(bodykey);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodyprojectTypeKey != null)
                {
                    body["projectTypeKey"] = SourceExpressionConverter.ConvertToken(bodyprojectTypeKey);
                    bodypropCount++;
                }

                if (bodyprojectTemplateKey != null)
                {
                    body["projectTemplateKey"] = SourceExpressionConverter.ConvertToken(bodyprojectTemplateKey);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodylead != null)
                {
                    body["lead"] = SourceExpressionConverter.ConvertToken(bodylead);
                    bodypropCount++;
                }

                if (bodyleadAccountId != null)
                {
                    body["leadAccountId"] = SourceExpressionConverter.ConvertToken(bodyleadAccountId);
                    bodypropCount++;
                }

                if (bodyurl != null)
                {
                    body["url"] = SourceExpressionConverter.ConvertToken(bodyurl);
                    bodypropCount++;
                }

                if (bodyassigneeType != null)
                {
                    body["assigneeType"] = SourceExpressionConverter.ConvertToken(bodyassigneeType);
                    bodypropCount++;
                }

                if (bodyavatarId != null)
                {
                    body["avatarId"] = SourceExpressionConverter.ConvertToken(bodyavatarId);
                    bodypropCount++;
                }

                if (bodyissueSecurityScheme != null)
                {
                    body["issueSecurityScheme"] = SourceExpressionConverter.ConvertToken(bodyissueSecurityScheme);
                    bodypropCount++;
                }

                if (bodypermissionScheme != null)
                {
                    body["permissionScheme"] = SourceExpressionConverter.ConvertToken(bodypermissionScheme);
                    bodypropCount++;
                }

                if (bodynotificationScheme != null)
                {
                    body["notificationScheme"] = SourceExpressionConverter.ConvertToken(bodynotificationScheme);
                    bodypropCount++;
                }

                if (bodycategoryId != null)
                {
                    body["categoryId"] = SourceExpressionConverter.ConvertToken(bodycategoryId);
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

    public class JiraTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueDatacenter([WorkflowExpression] Func<string> projectKey, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datacenter/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnCloseIssueDatacenter([WorkflowExpression] Func<string> projectKey, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datacenter/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueJQLDatacenter([WorkflowExpression] Func<string> jql, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/datacenter/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["jql"] = SourceExpressionConverter.ConvertO(jql);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnCloseIssue([WorkflowExpression] Func<string> projectKey, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssue([WorkflowExpression] Func<string> projectKey, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["projectKey"] = SourceExpressionConverter.ConvertO(projectKey);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }

        public IBodyWorkflowTrigger<FullIssue[]> OnNewIssueJQL([WorkflowExpression] Func<string> jql, [WorkflowExpression] Func<string> xRequestJirainstance = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v2/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = SourceExpressionConverter.ConvertO(xRequestJirainstance);
                callPayload.Queries["jql"] = SourceExpressionConverter.ConvertO(jql);
                return callPayload;
            }

            return new ApiConnectionTrigger<FullIssue[]>(BuildSourceInput, triggerName, recurrence);
        }
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
        [JsonProperty("nextPageToken")]
        public string NextPageToken { get; set; }

        [JsonProperty("isLast")]
        public bool IsLastPage { get; set; }

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

    public class CommentResponse
    {
        [JsonProperty("id")]
        public string CommentId { get; set; }

        [JsonProperty("body")]
        public string CommentBody { get; set; }

        [JsonProperty("created")]
        public string CreatedDateTime { get; set; }
    }

    public class CreateIssueResponse
    {
        [JsonProperty("id")]
        public string IssueId { get; set; }

        [JsonProperty("key")]
        public string IssueKey { get; set; }
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

    public class bodypropertiesInputItem
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
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