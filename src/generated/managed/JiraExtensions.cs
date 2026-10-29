//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Jira
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class JiraActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<SitesItem[], ApiConnectionActionConfiguration> ListResources()
        {
            return new DeferredBodyAction<SitesItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/oauth/token/accessible-resources";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SitesItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponse, ApiConnectionActionConfiguration> ListIssues(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> jql = null, Expression<Func<string>> fields = null, Expression<Func<string>> nextPageToken = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: false);
            var __workflow_fields = WorkflowExpression.Compile(fields, nameof(fields), required: false);
            var __workflow_nextPageToken = WorkflowExpression.Compile(nextPageToken, nameof(nextPageToken), required: false);
            return new DeferredBodyAction<ListIssuesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/2/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_jql != null)
                    callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                callPayload.Queries["expand"] = Convert.ToString("*");
                callPayload.Queries["fields"] = Convert.ToString("*all");
                if (__workflow_fields != null)
                    callPayload.Queries["fields"] = ExpressionConverter.Convert(__workflow_fields);
                if (__workflow_nextPageToken != null)
                    callPayload.Queries["nextPageToken"] = ExpressionConverter.Convert(__workflow_nextPageToken);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListIssuesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListIssuesResponseDatacenter, ApiConnectionActionConfiguration> ListIssuesDatacenter(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListIssuesResponseDatacenter, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListIssuesResponseDatacenter>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListTransitionsResponse, ApiConnectionActionConfiguration> ListTransitions(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            return new DeferredBodyAction<ListTransitionsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/3/issue/{0}/transitions", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListTransitionsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateTransition(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<string>> bodyfieldsassigneename = null, Expression<Func<string>> bodyfieldsresolutionname = null, Expression<Func<string>> bodyhistoryMetadataactivityDescription = null, Expression<Func<string>> bodyhistoryMetadataactoravatarUrl = null, Expression<Func<string>> bodyhistoryMetadataactordisplayName = null, Expression<Func<string>> bodyhistoryMetadataactorid = null, Expression<Func<string>> bodyhistoryMetadataactortype = null, Expression<Func<string>> bodyhistoryMetadataactorurl = null, Expression<Func<string>> bodyhistoryMetadatacauseid = null, Expression<Func<string>> bodyhistoryMetadatacausetype = null, Expression<Func<string>> bodyhistoryMetadatadescription = null, Expression<Func<string>> bodyhistoryMetadataextraDataiteration = null, Expression<Func<string>> bodyhistoryMetadataextraDatastep = null, Expression<Func<string>> bodyhistoryMetadatageneratorid = null, Expression<Func<string>> bodyhistoryMetadatageneratortype = null, Expression<Func<string>> bodyhistoryMetadatatype = null, Expression<Func<string>> bodytransitionid = null, Expression<Func<bodyupdatecommentInputItem[]>> bodyupdatecomment = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            var __workflow_bodyfieldsassigneename = WorkflowExpression.Compile(bodyfieldsassigneename, nameof(bodyfieldsassigneename), required: false);
            var __workflow_bodyfieldsresolutionname = WorkflowExpression.Compile(bodyfieldsresolutionname, nameof(bodyfieldsresolutionname), required: false);
            var __workflow_bodyhistoryMetadataactivityDescription = WorkflowExpression.Compile(bodyhistoryMetadataactivityDescription, nameof(bodyhistoryMetadataactivityDescription), required: false);
            var __workflow_bodyhistoryMetadataactoravatarUrl = WorkflowExpression.Compile(bodyhistoryMetadataactoravatarUrl, nameof(bodyhistoryMetadataactoravatarUrl), required: false);
            var __workflow_bodyhistoryMetadataactordisplayName = WorkflowExpression.Compile(bodyhistoryMetadataactordisplayName, nameof(bodyhistoryMetadataactordisplayName), required: false);
            var __workflow_bodyhistoryMetadataactorid = WorkflowExpression.Compile(bodyhistoryMetadataactorid, nameof(bodyhistoryMetadataactorid), required: false);
            var __workflow_bodyhistoryMetadataactortype = WorkflowExpression.Compile(bodyhistoryMetadataactortype, nameof(bodyhistoryMetadataactortype), required: false);
            var __workflow_bodyhistoryMetadataactorurl = WorkflowExpression.Compile(bodyhistoryMetadataactorurl, nameof(bodyhistoryMetadataactorurl), required: false);
            var __workflow_bodyhistoryMetadatacauseid = WorkflowExpression.Compile(bodyhistoryMetadatacauseid, nameof(bodyhistoryMetadatacauseid), required: false);
            var __workflow_bodyhistoryMetadatacausetype = WorkflowExpression.Compile(bodyhistoryMetadatacausetype, nameof(bodyhistoryMetadatacausetype), required: false);
            var __workflow_bodyhistoryMetadatadescription = WorkflowExpression.Compile(bodyhistoryMetadatadescription, nameof(bodyhistoryMetadatadescription), required: false);
            var __workflow_bodyhistoryMetadataextraDataiteration = WorkflowExpression.Compile(bodyhistoryMetadataextraDataiteration, nameof(bodyhistoryMetadataextraDataiteration), required: false);
            var __workflow_bodyhistoryMetadataextraDatastep = WorkflowExpression.Compile(bodyhistoryMetadataextraDatastep, nameof(bodyhistoryMetadataextraDatastep), required: false);
            var __workflow_bodyhistoryMetadatageneratorid = WorkflowExpression.Compile(bodyhistoryMetadatageneratorid, nameof(bodyhistoryMetadatageneratorid), required: false);
            var __workflow_bodyhistoryMetadatageneratortype = WorkflowExpression.Compile(bodyhistoryMetadatageneratortype, nameof(bodyhistoryMetadatageneratortype), required: false);
            var __workflow_bodyhistoryMetadatatype = WorkflowExpression.Compile(bodyhistoryMetadatatype, nameof(bodyhistoryMetadatatype), required: false);
            var __workflow_bodytransitionid = WorkflowExpression.Compile(bodytransitionid, nameof(bodytransitionid), required: false);
            var __workflow_bodyupdatecomment = WorkflowExpression.Compile(bodyupdatecomment, nameof(bodyupdatecomment), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/3/issue/{0}/transitions", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                var assigneeObject = new JObject();
                var assigneeObjectpropCount = 0;
                if (__workflow_bodyfieldsassigneename != null)
                {
                    assigneeObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsassigneename);
                    assigneeObjectpropCount++;
                }

                if (assigneeObjectpropCount > 0)
                {
                    fieldsObject["assignee"] = assigneeObject;
                    fieldsObjectpropCount++;
                }

                var resolutionObject = new JObject();
                var resolutionObjectpropCount = 0;
                if (__workflow_bodyfieldsresolutionname != null)
                {
                    resolutionObject["name"] = ExpressionConverter.ConvertO(__workflow_bodyfieldsresolutionname);
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
                if (__workflow_bodyhistoryMetadataactivityDescription != null)
                {
                    historyMetadataObject["activityDescription"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactivityDescription);
                    historyMetadataObjectpropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadataactoravatarUrl != null)
                {
                    actorObject["avatarUrl"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoravatarUrl);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactordisplayName != null)
                {
                    actorObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactordisplayName);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactorid != null)
                {
                    actorObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactorid);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactortype != null)
                {
                    actorObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactortype);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactorurl != null)
                {
                    actorObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactorurl);
                    actorObjectpropCount++;
                }

                if (actorObjectpropCount > 0)
                {
                    historyMetadataObject["actor"] = actorObject;
                    historyMetadataObjectpropCount++;
                }

                var causeObject = new JObject();
                var causeObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadatacauseid != null)
                {
                    causeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacauseid);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausetype != null)
                {
                    causeObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausetype);
                    causeObjectpropCount++;
                }

                if (causeObjectpropCount > 0)
                {
                    historyMetadataObject["cause"] = causeObject;
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatadescription != null)
                {
                    historyMetadataObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatadescription);
                    historyMetadataObjectpropCount++;
                }

                var extraDataObject = new JObject();
                var extraDataObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadataextraDataiteration != null)
                {
                    extraDataObject["Iteration"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataextraDataiteration);
                    extraDataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataextraDatastep != null)
                {
                    extraDataObject["Step"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataextraDatastep);
                    extraDataObjectpropCount++;
                }

                if (extraDataObjectpropCount > 0)
                {
                    historyMetadataObject["extraData"] = extraDataObject;
                    historyMetadataObjectpropCount++;
                }

                var generatorObject = new JObject();
                var generatorObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadatageneratorid != null)
                {
                    generatorObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorid);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratortype != null)
                {
                    generatorObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratortype);
                    generatorObjectpropCount++;
                }

                if (generatorObjectpropCount > 0)
                {
                    historyMetadataObject["generator"] = generatorObject;
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatatype != null)
                {
                    historyMetadataObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatatype);
                    historyMetadataObjectpropCount++;
                }

                if (historyMetadataObjectpropCount > 0)
                {
                    body["historyMetadata"] = historyMetadataObject;
                    bodypropCount++;
                }

                var transitionObject = new JObject();
                var transitionObjectpropCount = 0;
                if (__workflow_bodytransitionid != null)
                {
                    transitionObject["id"] = ExpressionConverter.ConvertO(__workflow_bodytransitionid);
                    transitionObjectpropCount++;
                }

                if (transitionObjectpropCount > 0)
                {
                    body["transition"] = transitionObject;
                    bodypropCount++;
                }

                var updateObject = new JObject();
                var updateObjectpropCount = 0;
                if (__workflow_bodyupdatecomment != null)
                {
                    updateObject["comment"] = ExpressionConverter.ConvertO(__workflow_bodyupdatecomment);
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetCurrentUser(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> expand = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/3/myself";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<MCPQueryResponse, ApiConnectionActionConfiguration> McpJiraIssueManagement(Expression<Func<string>> queryRequestjsonrpc = null, Expression<Func<string>> queryRequestid = null, Expression<Func<string>> queryRequestmethod = null, Expression<Func<string>> sessionId = null)
        {
            var __workflow_queryRequestjsonrpc = WorkflowExpression.Compile(queryRequestjsonrpc, nameof(queryRequestjsonrpc), required: false);
            var __workflow_queryRequestid = WorkflowExpression.Compile(queryRequestid, nameof(queryRequestid), required: false);
            var __workflow_queryRequestmethod = WorkflowExpression.Compile(queryRequestmethod, nameof(queryRequestmethod), required: false);
            var __workflow_sessionId = WorkflowExpression.Compile(sessionId, nameof(sessionId), required: false);
            return new DeferredBodyAction<MCPQueryResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/mcp/JiraIssueManagement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_sessionId != null)
                    callPayload.Queries["sessionId"] = ExpressionConverter.Convert(__workflow_sessionId);
                var queryRequest = new JObject();
                var queryRequestpropCount = 0;
                if (__workflow_queryRequestjsonrpc != null)
                {
                    queryRequest["jsonrpc"] = ExpressionConverter.ConvertO(__workflow_queryRequestjsonrpc);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestid != null)
                {
                    queryRequest["id"] = ExpressionConverter.ConvertO(__workflow_queryRequestid);
                    queryRequestpropCount++;
                }

                if (__workflow_queryRequestmethod != null)
                {
                    queryRequest["method"] = ExpressionConverter.ConvertO(__workflow_queryRequestmethod);
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

                return new ApiConnectionAction<MCPQueryResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CommentResponse, ApiConnectionActionConfiguration> AddComment(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey, Expression<Func<string>> bodycomment)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueKey = WorkflowExpression.Compile(issueKey, nameof(issueKey), required: true);
            var __workflow_bodycomment = WorkflowExpression.Compile(bodycomment, nameof(bodycomment), required: true);
            return new DeferredBodyAction<CommentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issue/{0}/comment", __workflow_issueKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["body"] = ExpressionConverter.ConvertO(__workflow_bodycomment);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CommentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateIssueResponse, ApiConnectionActionConfiguration> CreateIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey, Expression<Func<string>> issueTypeIds, Expression<Func<object>> item = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_issueTypeIds = WorkflowExpression.Compile(issueTypeIds, nameof(issueTypeIds), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            return new DeferredBodyAction<CreateIssueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v3/issue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                callPayload.Queries["issueTypeIds"] = ExpressionConverter.Convert(__workflow_issueTypeIds);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<CreateIssueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<CreateProjectResponse, ApiConnectionActionConfiguration> CreateProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectprojectKey, Expression<Func<string>> projectname, Expression<Func<projecttypeInput>> projecttype, Expression<Func<string>> projectleadId, Expression<Func<string>> projectdescription = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectprojectKey = WorkflowExpression.Compile(projectprojectKey, nameof(projectprojectKey), required: true);
            var __workflow_projectname = WorkflowExpression.Compile(projectname, nameof(projectname), required: true);
            var __workflow_projecttype = WorkflowExpression.Compile(projecttype, nameof(projecttype), required: true);
            var __workflow_projectleadId = WorkflowExpression.Compile(projectleadId, nameof(projectleadId), required: true);
            var __workflow_projectdescription = WorkflowExpression.Compile(projectdescription, nameof(projectdescription), required: false);
            return new DeferredBodyAction<CreateProjectResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/project";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var project = new JObject();
                var projectpropCount = 0;
                projectpropCount++;
                project["key"] = ExpressionConverter.ConvertO(__workflow_projectprojectKey);
                projectpropCount++;
                project["name"] = ExpressionConverter.ConvertO(__workflow_projectname);
                projectpropCount++;
                project["projectTypeKey"] = ExpressionConverter.ConvertO(__workflow_projecttype);
                projectpropCount++;
                project["leadAccountId"] = ExpressionConverter.ConvertO(__workflow_projectleadId);
                if (__workflow_projectdescription != null)
                {
                    project["description"] = ExpressionConverter.ConvertO(__workflow_projectdescription);
                    projectpropCount++;
                }

                if (projectpropCount > 0)
                {
                    callPayload.Body = project;
                }

                return new ApiConnectionAction<CreateProjectResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateProjectCategory(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodydescription = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<bool>> enableUndo = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectIdOrKey = WorkflowExpression.Compile(projectIdOrKey, nameof(projectIdOrKey), required: true);
            var __workflow_enableUndo = WorkflowExpression.Compile(enableUndo, nameof(enableUndo), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/project/{0}", __workflow_projectIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["enableUndo"] = Convert.ToString(false);
                if (__workflow_enableUndo != null)
                    callPayload.Queries["enableUndo"] = ExpressionConverter.Convert(__workflow_enableUndo);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<JToken, ApiConnectionActionConfiguration> EditIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueIdOrKey, Expression<Func<bool>> notifyUsers = null, Expression<Func<bool>> overrideScreenSecurity = null, Expression<Func<bool>> overrideEditableFlag = null, Expression<Func<string>> bodytransitiontransitionId = null, Expression<Func<string>> bodytransitiontransitionLooped = null, Expression<Func<string>> bodyhistoryMetadatametadataType = null, Expression<Func<string>> bodyhistoryMetadatametadataDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataActivityDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescription = null, Expression<Func<string>> bodyhistoryMetadatametadataEmailDescriptionKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorId = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayName = null, Expression<Func<string>> bodyhistoryMetadataactoractorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadataactoractorType = null, Expression<Func<string>> bodyhistoryMetadataactoractorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadataactoractorUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorId = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayName = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorType = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatageneratorgeneratorUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseId = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayName = null, Expression<Func<string>> bodyhistoryMetadatacausecauseDisplayNameKey = null, Expression<Func<string>> bodyhistoryMetadatacausecauseType = null, Expression<Func<string>> bodyhistoryMetadatacausecauseAvatarUrl = null, Expression<Func<string>> bodyhistoryMetadatacausecauseUrl = null, Expression<Func<string>> bodyhistoryMetadataextraData = null, Expression<Func<bodypropertiesInputItem[]>> bodyproperties = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueIdOrKey = WorkflowExpression.Compile(issueIdOrKey, nameof(issueIdOrKey), required: true);
            var __workflow_notifyUsers = WorkflowExpression.Compile(notifyUsers, nameof(notifyUsers), required: false);
            var __workflow_overrideScreenSecurity = WorkflowExpression.Compile(overrideScreenSecurity, nameof(overrideScreenSecurity), required: false);
            var __workflow_overrideEditableFlag = WorkflowExpression.Compile(overrideEditableFlag, nameof(overrideEditableFlag), required: false);
            var __workflow_bodytransitiontransitionId = WorkflowExpression.Compile(bodytransitiontransitionId, nameof(bodytransitiontransitionId), required: false);
            var __workflow_bodytransitiontransitionLooped = WorkflowExpression.Compile(bodytransitiontransitionLooped, nameof(bodytransitiontransitionLooped), required: false);
            var __workflow_bodyhistoryMetadatametadataType = WorkflowExpression.Compile(bodyhistoryMetadatametadataType, nameof(bodyhistoryMetadatametadataType), required: false);
            var __workflow_bodyhistoryMetadatametadataDescription = WorkflowExpression.Compile(bodyhistoryMetadatametadataDescription, nameof(bodyhistoryMetadatametadataDescription), required: false);
            var __workflow_bodyhistoryMetadatametadataDescriptionKey = WorkflowExpression.Compile(bodyhistoryMetadatametadataDescriptionKey, nameof(bodyhistoryMetadatametadataDescriptionKey), required: false);
            var __workflow_bodyhistoryMetadatametadataActivityDescription = WorkflowExpression.Compile(bodyhistoryMetadatametadataActivityDescription, nameof(bodyhistoryMetadatametadataActivityDescription), required: false);
            var __workflow_bodyhistoryMetadatametadataActivityDescriptionKey = WorkflowExpression.Compile(bodyhistoryMetadatametadataActivityDescriptionKey, nameof(bodyhistoryMetadatametadataActivityDescriptionKey), required: false);
            var __workflow_bodyhistoryMetadatametadataEmailDescription = WorkflowExpression.Compile(bodyhistoryMetadatametadataEmailDescription, nameof(bodyhistoryMetadatametadataEmailDescription), required: false);
            var __workflow_bodyhistoryMetadatametadataEmailDescriptionKey = WorkflowExpression.Compile(bodyhistoryMetadatametadataEmailDescriptionKey, nameof(bodyhistoryMetadatametadataEmailDescriptionKey), required: false);
            var __workflow_bodyhistoryMetadataactoractorId = WorkflowExpression.Compile(bodyhistoryMetadataactoractorId, nameof(bodyhistoryMetadataactoractorId), required: false);
            var __workflow_bodyhistoryMetadataactoractorDisplayName = WorkflowExpression.Compile(bodyhistoryMetadataactoractorDisplayName, nameof(bodyhistoryMetadataactoractorDisplayName), required: false);
            var __workflow_bodyhistoryMetadataactoractorDisplayNameKey = WorkflowExpression.Compile(bodyhistoryMetadataactoractorDisplayNameKey, nameof(bodyhistoryMetadataactoractorDisplayNameKey), required: false);
            var __workflow_bodyhistoryMetadataactoractorType = WorkflowExpression.Compile(bodyhistoryMetadataactoractorType, nameof(bodyhistoryMetadataactoractorType), required: false);
            var __workflow_bodyhistoryMetadataactoractorAvatarUrl = WorkflowExpression.Compile(bodyhistoryMetadataactoractorAvatarUrl, nameof(bodyhistoryMetadataactoractorAvatarUrl), required: false);
            var __workflow_bodyhistoryMetadataactoractorUrl = WorkflowExpression.Compile(bodyhistoryMetadataactoractorUrl, nameof(bodyhistoryMetadataactoractorUrl), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorId = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorId, nameof(bodyhistoryMetadatageneratorgeneratorId), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorDisplayName = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorDisplayName, nameof(bodyhistoryMetadatageneratorgeneratorDisplayName), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorDisplayNameKey = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorDisplayNameKey, nameof(bodyhistoryMetadatageneratorgeneratorDisplayNameKey), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorType = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorType, nameof(bodyhistoryMetadatageneratorgeneratorType), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorAvatarUrl = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorAvatarUrl, nameof(bodyhistoryMetadatageneratorgeneratorAvatarUrl), required: false);
            var __workflow_bodyhistoryMetadatageneratorgeneratorUrl = WorkflowExpression.Compile(bodyhistoryMetadatageneratorgeneratorUrl, nameof(bodyhistoryMetadatageneratorgeneratorUrl), required: false);
            var __workflow_bodyhistoryMetadatacausecauseId = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseId, nameof(bodyhistoryMetadatacausecauseId), required: false);
            var __workflow_bodyhistoryMetadatacausecauseDisplayName = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseDisplayName, nameof(bodyhistoryMetadatacausecauseDisplayName), required: false);
            var __workflow_bodyhistoryMetadatacausecauseDisplayNameKey = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseDisplayNameKey, nameof(bodyhistoryMetadatacausecauseDisplayNameKey), required: false);
            var __workflow_bodyhistoryMetadatacausecauseType = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseType, nameof(bodyhistoryMetadatacausecauseType), required: false);
            var __workflow_bodyhistoryMetadatacausecauseAvatarUrl = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseAvatarUrl, nameof(bodyhistoryMetadatacausecauseAvatarUrl), required: false);
            var __workflow_bodyhistoryMetadatacausecauseUrl = WorkflowExpression.Compile(bodyhistoryMetadatacausecauseUrl, nameof(bodyhistoryMetadatacausecauseUrl), required: false);
            var __workflow_bodyhistoryMetadataextraData = WorkflowExpression.Compile(bodyhistoryMetadataextraData, nameof(bodyhistoryMetadataextraData), required: false);
            var __workflow_bodyproperties = WorkflowExpression.Compile(bodyproperties, nameof(bodyproperties), required: false);
            return new DeferredBodyAction<JToken, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/3/issue/{0}", __workflow_issueIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_notifyUsers != null)
                    callPayload.Queries["notifyUsers"] = ExpressionConverter.Convert(__workflow_notifyUsers);
                if (__workflow_overrideScreenSecurity != null)
                    callPayload.Queries["overrideScreenSecurity"] = ExpressionConverter.Convert(__workflow_overrideScreenSecurity);
                if (__workflow_overrideEditableFlag != null)
                    callPayload.Queries["overrideEditableFlag"] = ExpressionConverter.Convert(__workflow_overrideEditableFlag);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                var transitionObject = new JObject();
                var transitionObjectpropCount = 0;
                if (__workflow_bodytransitiontransitionId != null)
                {
                    transitionObject["id"] = ExpressionConverter.ConvertO(__workflow_bodytransitiontransitionId);
                    transitionObjectpropCount++;
                }

                if (__workflow_bodytransitiontransitionLooped != null)
                {
                    transitionObject["looped"] = ExpressionConverter.ConvertO(__workflow_bodytransitiontransitionLooped);
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
                if (__workflow_bodyhistoryMetadatametadataType != null)
                {
                    historyMetadataObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataType);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataDescription != null)
                {
                    historyMetadataObject["description"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataDescription);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataDescriptionKey != null)
                {
                    historyMetadataObject["descriptionKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataActivityDescription != null)
                {
                    historyMetadataObject["activityDescription"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataActivityDescription);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataActivityDescriptionKey != null)
                {
                    historyMetadataObject["activityDescriptionKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataActivityDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataEmailDescription != null)
                {
                    historyMetadataObject["emailDescription"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataEmailDescription);
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatametadataEmailDescriptionKey != null)
                {
                    historyMetadataObject["emailDescriptionKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatametadataEmailDescriptionKey);
                    historyMetadataObjectpropCount++;
                }

                var actorObject = new JObject();
                var actorObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadataactoractorId != null)
                {
                    actorObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorId);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactoractorDisplayName != null)
                {
                    actorObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorDisplayName);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactoractorDisplayNameKey != null)
                {
                    actorObject["displayNameKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorDisplayNameKey);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactoractorType != null)
                {
                    actorObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorType);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactoractorAvatarUrl != null)
                {
                    actorObject["avatarUrl"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorAvatarUrl);
                    actorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataactoractorUrl != null)
                {
                    actorObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataactoractorUrl);
                    actorObjectpropCount++;
                }

                if (actorObjectpropCount > 0)
                {
                    historyMetadataObject["actor"] = actorObject;
                    historyMetadataObjectpropCount++;
                }

                var generatorObject = new JObject();
                var generatorObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadatageneratorgeneratorId != null)
                {
                    generatorObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorId);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratorgeneratorDisplayName != null)
                {
                    generatorObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorDisplayName);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratorgeneratorDisplayNameKey != null)
                {
                    generatorObject["displayNameKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorDisplayNameKey);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratorgeneratorType != null)
                {
                    generatorObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorType);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratorgeneratorAvatarUrl != null)
                {
                    generatorObject["avatarUrl"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorAvatarUrl);
                    generatorObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatageneratorgeneratorUrl != null)
                {
                    generatorObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatageneratorgeneratorUrl);
                    generatorObjectpropCount++;
                }

                if (generatorObjectpropCount > 0)
                {
                    historyMetadataObject["generator"] = generatorObject;
                    historyMetadataObjectpropCount++;
                }

                var causeObject = new JObject();
                var causeObjectpropCount = 0;
                if (__workflow_bodyhistoryMetadatacausecauseId != null)
                {
                    causeObject["id"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseId);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausecauseDisplayName != null)
                {
                    causeObject["displayName"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseDisplayName);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausecauseDisplayNameKey != null)
                {
                    causeObject["displayNameKey"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseDisplayNameKey);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausecauseType != null)
                {
                    causeObject["type"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseType);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausecauseAvatarUrl != null)
                {
                    causeObject["avatarUrl"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseAvatarUrl);
                    causeObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadatacausecauseUrl != null)
                {
                    causeObject["url"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadatacausecauseUrl);
                    causeObjectpropCount++;
                }

                if (causeObjectpropCount > 0)
                {
                    historyMetadataObject["cause"] = causeObject;
                    historyMetadataObjectpropCount++;
                }

                if (__workflow_bodyhistoryMetadataextraData != null)
                {
                    historyMetadataObject["extraData"] = ExpressionConverter.ConvertO(__workflow_bodyhistoryMetadataextraData);
                    historyMetadataObjectpropCount++;
                }

                if (historyMetadataObjectpropCount > 0)
                {
                    body["historyMetadata"] = historyMetadataObject;
                    bodypropCount++;
                }

                if (__workflow_bodyproperties != null)
                {
                    body["properties"] = ExpressionConverter.ConvertO(__workflow_bodyproperties);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<GetAllProjectCategoriesV2ResponseItem[], ApiConnectionActionConfiguration> GetAllProjectCategories(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<GetAllProjectCategoriesV2ResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/projectCategory";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<GetAllProjectCategoriesV2ResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<FullIssue, ApiConnectionActionConfiguration> GetIssue(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> issueKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_issueKey = WorkflowExpression.Compile(issueKey, nameof(issueKey), required: true);
            return new DeferredBodyAction<FullIssue, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/issue/{0}", __workflow_issueKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<FullIssue>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetTask(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> taskId)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_taskId = WorkflowExpression.Compile(taskId, nameof(taskId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/task/{0}", __workflow_taskId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetUser(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> accountId, Expression<Func<string>> expand = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_accountId = WorkflowExpression.Compile(accountId, nameof(accountId), required: true);
            var __workflow_expand = WorkflowExpression.Compile(expand, nameof(expand), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/user";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["accountId"] = ExpressionConverter.Convert(__workflow_accountId);
                if (__workflow_expand != null)
                    callPayload.Queries["expand"] = ExpressionConverter.Convert(__workflow_expand);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListFiltersResponse, ApiConnectionActionConfiguration> ListFilters(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListFiltersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/filter/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListFiltersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<ListProjectsResponseV2, ApiConnectionActionConfiguration> ListProjects(Expression<Func<string>> xRequestJirainstance)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            return new DeferredBodyAction<ListProjectsResponseV2, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/project/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<ListProjectsResponseV2>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IBodyWorkflowAction<UserListItem[], ApiConnectionActionConfiguration> ListProjectUsers(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectKey)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            return new DeferredBodyAction<UserListItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/v2/user/permission/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction<UserListItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveProjectCategory(Expression<Func<string>> xRequestJirainstance, Expression<Func<int>> id)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/projectCategory/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "jira")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateProject(Expression<Func<string>> xRequestJirainstance, Expression<Func<string>> projectIdOrKey, Expression<Func<string>> bodykey = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodyprojectTypeKey = null, Expression<Func<string>> bodyprojectTemplateKey = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodylead = null, Expression<Func<string>> bodyleadAccountId = null, Expression<Func<string>> bodyurl = null, Expression<Func<string>> bodyassigneeType = null, Expression<Func<string>> bodyavatarId = null, Expression<Func<string>> bodyissueSecurityScheme = null, Expression<Func<string>> bodypermissionScheme = null, Expression<Func<string>> bodynotificationScheme = null, Expression<Func<string>> bodycategoryId = null)
        {
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: true);
            var __workflow_projectIdOrKey = WorkflowExpression.Compile(projectIdOrKey, nameof(projectIdOrKey), required: true);
            var __workflow_bodykey = WorkflowExpression.Compile(bodykey, nameof(bodykey), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodyprojectTypeKey = WorkflowExpression.Compile(bodyprojectTypeKey, nameof(bodyprojectTypeKey), required: false);
            var __workflow_bodyprojectTemplateKey = WorkflowExpression.Compile(bodyprojectTemplateKey, nameof(bodyprojectTemplateKey), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodylead = WorkflowExpression.Compile(bodylead, nameof(bodylead), required: false);
            var __workflow_bodyleadAccountId = WorkflowExpression.Compile(bodyleadAccountId, nameof(bodyleadAccountId), required: false);
            var __workflow_bodyurl = WorkflowExpression.Compile(bodyurl, nameof(bodyurl), required: false);
            var __workflow_bodyassigneeType = WorkflowExpression.Compile(bodyassigneeType, nameof(bodyassigneeType), required: false);
            var __workflow_bodyavatarId = WorkflowExpression.Compile(bodyavatarId, nameof(bodyavatarId), required: false);
            var __workflow_bodyissueSecurityScheme = WorkflowExpression.Compile(bodyissueSecurityScheme, nameof(bodyissueSecurityScheme), required: false);
            var __workflow_bodypermissionScheme = WorkflowExpression.Compile(bodypermissionScheme, nameof(bodypermissionScheme), required: false);
            var __workflow_bodynotificationScheme = WorkflowExpression.Compile(bodynotificationScheme, nameof(bodynotificationScheme), required: false);
            var __workflow_bodycategoryId = WorkflowExpression.Compile(bodycategoryId, nameof(bodycategoryId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/v2/project/{0}", __workflow_projectIdOrKey.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodykey != null)
                {
                    body["key"] = ExpressionConverter.ConvertO(__workflow_bodykey);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectTypeKey != null)
                {
                    body["projectTypeKey"] = ExpressionConverter.ConvertO(__workflow_bodyprojectTypeKey);
                    bodypropCount++;
                }

                if (__workflow_bodyprojectTemplateKey != null)
                {
                    body["projectTemplateKey"] = ExpressionConverter.ConvertO(__workflow_bodyprojectTemplateKey);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodylead != null)
                {
                    body["lead"] = ExpressionConverter.ConvertO(__workflow_bodylead);
                    bodypropCount++;
                }

                if (__workflow_bodyleadAccountId != null)
                {
                    body["leadAccountId"] = ExpressionConverter.ConvertO(__workflow_bodyleadAccountId);
                    bodypropCount++;
                }

                if (__workflow_bodyurl != null)
                {
                    body["url"] = ExpressionConverter.ConvertO(__workflow_bodyurl);
                    bodypropCount++;
                }

                if (__workflow_bodyassigneeType != null)
                {
                    body["assigneeType"] = ExpressionConverter.ConvertO(__workflow_bodyassigneeType);
                    bodypropCount++;
                }

                if (__workflow_bodyavatarId != null)
                {
                    body["avatarId"] = ExpressionConverter.ConvertO(__workflow_bodyavatarId);
                    bodypropCount++;
                }

                if (__workflow_bodyissueSecurityScheme != null)
                {
                    body["issueSecurityScheme"] = ExpressionConverter.ConvertO(__workflow_bodyissueSecurityScheme);
                    bodypropCount++;
                }

                if (__workflow_bodypermissionScheme != null)
                {
                    body["permissionScheme"] = ExpressionConverter.ConvertO(__workflow_bodypermissionScheme);
                    bodypropCount++;
                }

                if (__workflow_bodynotificationScheme != null)
                {
                    body["notificationScheme"] = ExpressionConverter.ConvertO(__workflow_bodynotificationScheme);
                    bodypropCount++;
                }

                if (__workflow_bodycategoryId != null)
                {
                    body["categoryId"] = ExpressionConverter.ConvertO(__workflow_bodycategoryId);
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

    public class JiraTriggers([ConnectionName] string connectionId)
    {
        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnCloseIssueDatacenter(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueJQLDatacenter(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/datacenter/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnCloseIssue(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/close_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssue(Expression<Func<string>> projectKey, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_projectKey = WorkflowExpression.Compile(projectKey, nameof(projectKey), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_issue_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["projectKey"] = ExpressionConverter.Convert(__workflow_projectKey);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
        }

        public IBodyWorkflowTrigger<FullIssue[], ApiConnectionTriggerConfiguration> OnNewIssueJQL(Expression<Func<string>> jql, Expression<Func<string>> xRequestJirainstance = null, FlowRecurrence recurrence = null)
        {
            var __workflow_jql = WorkflowExpression.Compile(jql, nameof(jql), required: true);
            var __workflow_xRequestJirainstance = WorkflowExpression.Compile(xRequestJirainstance, nameof(xRequestJirainstance), required: false);
            return new DeferredBodyTrigger<FullIssue[], ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/v2/new_issue_jql_trigger/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_xRequestJirainstance != null)
                    callPayload.Queries["X-Request-Jirainstance"] = ExpressionConverter.Convert(__workflow_xRequestJirainstance);
                callPayload.Queries["jql"] = ExpressionConverter.Convert(__workflow_jql);
                return new ApiConnectionTrigger<FullIssue[]>(callPayload, recurrence: recurrence);
            });
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

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
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
        public string IdOfTheIssueResolution { get; set; }

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