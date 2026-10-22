//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Raptordocmanagement
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RaptordocmanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> GetUserToken(Expression<Func<string>> externalSystemID, Expression<Func<string>> secret, Expression<Func<string>> externalUserName)
        {
            var __workflow_externalSystemID = WorkflowExpression.Compile(externalSystemID, nameof(externalSystemID), required: true);
            var __workflow_secret = WorkflowExpression.Compile(secret, nameof(secret), required: true);
            var __workflow_externalUserName = WorkflowExpression.Compile(externalUserName, nameof(externalUserName), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/User/getusertoken";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalSystemID"] = ExpressionConverter.Convert(__workflow_externalSystemID);
                callPayload.Queries["secret"] = ExpressionConverter.Convert(__workflow_secret);
                callPayload.Queries["externalUserName"] = ExpressionConverter.Convert(__workflow_externalUserName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<string, ApiConnectionActionConfiguration> DownloadDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> id)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<string, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/content", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> RemoveTagFromDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> documentId, Expression<Func<string>> tagId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/tag/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TagDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> documentId, Expression<Func<string>> tagId, Expression<Func<bool>> reTag = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            var __workflow_reTag = WorkflowExpression.Compile(reTag, nameof(reTag), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/tag/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_reTag != null)
                    callPayload.Queries["reTag"] = ExpressionConverter.Convert(__workflow_reTag);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddFieldToDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> documentId, Expression<Func<string>> method = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyvalue = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/field", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UpdateFieldOnDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> documentId, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodyvalue = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodyvalue = WorkflowExpression.Compile(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/field", __workflow_documentId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(__workflow_bodyvalue);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTemplateToDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> templateId, Expression<Func<string[]>> body = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/multidoc/template/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryDocumentsResponse, ApiConnectionActionConfiguration> QueryDocuments(Expression<Func<string>> exaAuthPlugin, Expression<Func<string[]>> bodyobligatoryTags = null, Expression<Func<string[]>> bodytagsInHierarchy = null, Expression<Func<string[]>> bodyexcludeTagsInHierarchy = null, Expression<Func<bool>> bodyincludeTotalCount = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycontainsName = null, Expression<Func<bodyorderByInput>> bodyorderBy = null, Expression<Func<bool>> bodyorderAscending = null, Expression<Func<string>> bodycontinuationToken = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodyobligatoryTags = WorkflowExpression.Compile(bodyobligatoryTags, nameof(bodyobligatoryTags), required: false);
            var __workflow_bodytagsInHierarchy = WorkflowExpression.Compile(bodytagsInHierarchy, nameof(bodytagsInHierarchy), required: false);
            var __workflow_bodyexcludeTagsInHierarchy = WorkflowExpression.Compile(bodyexcludeTagsInHierarchy, nameof(bodyexcludeTagsInHierarchy), required: false);
            var __workflow_bodyincludeTotalCount = WorkflowExpression.Compile(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycontainsName = WorkflowExpression.Compile(bodycontainsName, nameof(bodycontainsName), required: false);
            var __workflow_bodyorderBy = WorkflowExpression.Compile(bodyorderBy, nameof(bodyorderBy), required: false);
            var __workflow_bodyorderAscending = WorkflowExpression.Compile(bodyorderAscending, nameof(bodyorderAscending), required: false);
            var __workflow_bodycontinuationToken = WorkflowExpression.Compile(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            return new DeferredBodyAction<QueryDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/document/QueryDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyobligatoryTags != null)
                {
                    body["obligatoryTags"] = ExpressionConverter.ConvertO(__workflow_bodyobligatoryTags);
                    bodypropCount++;
                }

                if (__workflow_bodytagsInHierarchy != null)
                {
                    body["tagsInHierarchy"] = ExpressionConverter.ConvertO(__workflow_bodytagsInHierarchy);
                    bodypropCount++;
                }

                var fieldQueryExpressionObject = new JObject();
                var fieldQueryExpressionObjectpropCount = 0;
                if (fieldQueryExpressionObjectpropCount > 0)
                {
                    body["fieldQueryExpression"] = fieldQueryExpressionObject;
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeTagsInHierarchy != null)
                {
                    body["excludeTagsInHierarchy"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeTagsInHierarchy);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = ExpressionConverter.ConvertO(__workflow_bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(__workflow_bodycontainsName);
                    bodypropCount++;
                }

                if (__workflow_bodyorderBy != null)
                {
                    body["orderBy"] = ExpressionConverter.ConvertO(__workflow_bodyorderBy);
                    bodypropCount++;
                }

                if (__workflow_bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(__workflow_bodyorderAscending);
                    bodypropCount++;
                }

                if (__workflow_bodycontinuationToken != null)
                {
                    body["continuationToken"] = ExpressionConverter.ConvertO(__workflow_bodycontinuationToken);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTagByTagIdResponse, ApiConnectionActionConfiguration> GetTagByTagId(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> tagId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_tagId = WorkflowExpression.Compile(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagByTagIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/taxonomy/tags/{0}", __workflow_tagId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetTagByTagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTagByCodeResponse, ApiConnectionActionConfiguration> GetTagByCode(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> code)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            return new DeferredBodyAction<GetTagByCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/tags/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetTagByCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetMultipleTagsResponseItem[], ApiConnectionActionConfiguration> GetMultipleTags(Expression<Func<string>> exaAuthPlugin, Expression<Func<string[]>> bodyids = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodyids = WorkflowExpression.Compile(bodyids, nameof(bodyids), required: false);
            return new DeferredBodyAction<GetMultipleTagsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/tags/selection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyids != null)
                {
                    body["ids"] = ExpressionConverter.ConvertO(__workflow_bodyids);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<GetMultipleTagsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryTagsResponse, ApiConnectionActionConfiguration> QueryTags(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> bodyparentTagId = null, Expression<Func<string>> bodydirectParentTagId = null, Expression<Func<bool>> bodyhasNoParentTag = null, Expression<Func<bool>> bodyincludeTotalCount = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycontainsName = null, Expression<Func<bool>> bodyorderAscending = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodyparentTagId = WorkflowExpression.Compile(bodyparentTagId, nameof(bodyparentTagId), required: false);
            var __workflow_bodydirectParentTagId = WorkflowExpression.Compile(bodydirectParentTagId, nameof(bodydirectParentTagId), required: false);
            var __workflow_bodyhasNoParentTag = WorkflowExpression.Compile(bodyhasNoParentTag, nameof(bodyhasNoParentTag), required: false);
            var __workflow_bodyincludeTotalCount = WorkflowExpression.Compile(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycontainsName = WorkflowExpression.Compile(bodycontainsName, nameof(bodycontainsName), required: false);
            var __workflow_bodyorderAscending = WorkflowExpression.Compile(bodyorderAscending, nameof(bodyorderAscending), required: false);
            return new DeferredBodyAction<QueryTagsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/tags/querytags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(__workflow_bodyparentTagId);
                    bodypropCount++;
                }

                if (__workflow_bodydirectParentTagId != null)
                {
                    body["directParentTagId"] = ExpressionConverter.ConvertO(__workflow_bodydirectParentTagId);
                    bodypropCount++;
                }

                if (__workflow_bodyhasNoParentTag != null)
                {
                    body["hasNoParentTag"] = ExpressionConverter.ConvertO(__workflow_bodyhasNoParentTag);
                    bodypropCount++;
                }

                if (__workflow_bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = ExpressionConverter.ConvertO(__workflow_bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(__workflow_bodycontainsName);
                    bodypropCount++;
                }

                if (__workflow_bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(__workflow_bodyorderAscending);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryTagsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<CreateFieldResponse, ApiConnectionActionConfiguration> CreateField(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> method = null, Expression<Func<string>> bodyid = null, Expression<Func<string>> bodytenantId = null, Expression<Func<string>> bodycode = null, Expression<Func<int>> bodyfieldType = null, Expression<Func<bool>> bodyisRequired = null, Expression<Func<bool>> bodyisReadOnly = null, Expression<Func<string>> bodydefaultValue = null, Expression<Func<bodylabelsInputItem[]>> bodylabels = null, Expression<Func<string>> bodyvalidatingRegExp = null, Expression<Func<bodyvalidationMessageInputItem[]>> bodyvalidationMessage = null, Expression<Func<int>> bodyrowAmount = null, Expression<Func<string>> bodyparentTagId = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: false);
            var __workflow_bodyid = WorkflowExpression.Compile(bodyid, nameof(bodyid), required: false);
            var __workflow_bodytenantId = WorkflowExpression.Compile(bodytenantId, nameof(bodytenantId), required: false);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodyfieldType = WorkflowExpression.Compile(bodyfieldType, nameof(bodyfieldType), required: false);
            var __workflow_bodyisRequired = WorkflowExpression.Compile(bodyisRequired, nameof(bodyisRequired), required: false);
            var __workflow_bodyisReadOnly = WorkflowExpression.Compile(bodyisReadOnly, nameof(bodyisReadOnly), required: false);
            var __workflow_bodydefaultValue = WorkflowExpression.Compile(bodydefaultValue, nameof(bodydefaultValue), required: false);
            var __workflow_bodylabels = WorkflowExpression.Compile(bodylabels, nameof(bodylabels), required: false);
            var __workflow_bodyvalidatingRegExp = WorkflowExpression.Compile(bodyvalidatingRegExp, nameof(bodyvalidatingRegExp), required: false);
            var __workflow_bodyvalidationMessage = WorkflowExpression.Compile(bodyvalidationMessage, nameof(bodyvalidationMessage), required: false);
            var __workflow_bodyrowAmount = WorkflowExpression.Compile(bodyrowAmount, nameof(bodyrowAmount), required: false);
            var __workflow_bodyparentTagId = WorkflowExpression.Compile(bodyparentTagId, nameof(bodyparentTagId), required: false);
            return new DeferredBodyAction<CreateFieldResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(__workflow_bodyid);
                    bodypropCount++;
                }

                if (__workflow_bodytenantId != null)
                {
                    body["tenantId"] = ExpressionConverter.ConvertO(__workflow_bodytenantId);
                    bodypropCount++;
                }

                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodyfieldType != null)
                {
                    body["fieldType"] = ExpressionConverter.ConvertO(__workflow_bodyfieldType);
                    bodypropCount++;
                }

                if (__workflow_bodyisRequired != null)
                {
                    body["isRequired"] = ExpressionConverter.ConvertO(__workflow_bodyisRequired);
                    bodypropCount++;
                }

                if (__workflow_bodyisReadOnly != null)
                {
                    body["isReadOnly"] = ExpressionConverter.ConvertO(__workflow_bodyisReadOnly);
                    bodypropCount++;
                }

                if (__workflow_bodydefaultValue != null)
                {
                    body["defaultValue"] = ExpressionConverter.ConvertO(__workflow_bodydefaultValue);
                    bodypropCount++;
                }

                if (__workflow_bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(__workflow_bodylabels);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidatingRegExp != null)
                {
                    body["validatingRegExp"] = ExpressionConverter.ConvertO(__workflow_bodyvalidatingRegExp);
                    bodypropCount++;
                }

                if (__workflow_bodyvalidationMessage != null)
                {
                    body["validationMessage"] = ExpressionConverter.ConvertO(__workflow_bodyvalidationMessage);
                    bodypropCount++;
                }

                if (__workflow_bodyrowAmount != null)
                {
                    body["rowAmount"] = ExpressionConverter.ConvertO(__workflow_bodyrowAmount);
                    bodypropCount++;
                }

                if (__workflow_bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(__workflow_bodyparentTagId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CreateFieldResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetFieldByIdResponse, ApiConnectionActionConfiguration> GetFieldById(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> fieldId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_fieldId = WorkflowExpression.Compile(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<GetFieldByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/taxonomy/fields/{0}", __workflow_fieldId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetFieldByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetFieldByCodeResponse, ApiConnectionActionConfiguration> GetFieldByCode(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> code)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            return new DeferredBodyAction<GetFieldByCodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/fields/field";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetFieldByCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplateFieldsResponseItem[], ApiConnectionActionConfiguration> GetTemplateFields(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> templateId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<GetTemplateFieldsResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/taxonomy/templates/{0}/fields", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetTemplateFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplatebyidResponse, ApiConnectionActionConfiguration> GetTemplatebyid(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> templateId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<GetTemplatebyidResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/taxonomy/templates/{0}", __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetTemplatebyidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplatebycodeResponse, ApiConnectionActionConfiguration> GetTemplatebycode(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> code)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_code = WorkflowExpression.Compile(code, nameof(code), required: true);
            return new DeferredBodyAction<GetTemplatebycodeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/templates/template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(__workflow_code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetTemplatebycodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetUserByIdResponse, ApiConnectionActionConfiguration> GetUserById(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> userId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_userId = WorkflowExpression.Compile(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/{0}", __workflow_userId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryUsersResponse, ApiConnectionActionConfiguration> QueryUsers(Expression<Func<string>> exaAuthPlugin, Expression<Func<bool>> bodyexcludeActiveUsers = null, Expression<Func<bool>> bodyexcludeInactiveUsers = null, Expression<Func<bool>> bodyexcludeNormalUsers = null, Expression<Func<bool>> bodyexcludeSystemUsers = null, Expression<Func<string>> bodycontainsEmail = null, Expression<Func<string[]>> bodyroleIds = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycontainsName = null, Expression<Func<bool>> bodyorderAscending = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodyexcludeActiveUsers = WorkflowExpression.Compile(bodyexcludeActiveUsers, nameof(bodyexcludeActiveUsers), required: false);
            var __workflow_bodyexcludeInactiveUsers = WorkflowExpression.Compile(bodyexcludeInactiveUsers, nameof(bodyexcludeInactiveUsers), required: false);
            var __workflow_bodyexcludeNormalUsers = WorkflowExpression.Compile(bodyexcludeNormalUsers, nameof(bodyexcludeNormalUsers), required: false);
            var __workflow_bodyexcludeSystemUsers = WorkflowExpression.Compile(bodyexcludeSystemUsers, nameof(bodyexcludeSystemUsers), required: false);
            var __workflow_bodycontainsEmail = WorkflowExpression.Compile(bodycontainsEmail, nameof(bodycontainsEmail), required: false);
            var __workflow_bodyroleIds = WorkflowExpression.Compile(bodyroleIds, nameof(bodyroleIds), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycontainsName = WorkflowExpression.Compile(bodycontainsName, nameof(bodycontainsName), required: false);
            var __workflow_bodyorderAscending = WorkflowExpression.Compile(bodyorderAscending, nameof(bodyorderAscending), required: false);
            return new DeferredBodyAction<QueryUsersResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/user/queryusers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyexcludeActiveUsers != null)
                {
                    body["excludeActiveUsers"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeActiveUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeInactiveUsers != null)
                {
                    body["excludeInactiveUsers"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeInactiveUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeNormalUsers != null)
                {
                    body["excludeNormalUsers"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeNormalUsers);
                    bodypropCount++;
                }

                if (__workflow_bodyexcludeSystemUsers != null)
                {
                    body["excludeSystemUsers"] = ExpressionConverter.ConvertO(__workflow_bodyexcludeSystemUsers);
                    bodypropCount++;
                }

                if (__workflow_bodycontainsEmail != null)
                {
                    body["containsEmail"] = ExpressionConverter.ConvertO(__workflow_bodycontainsEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyroleIds != null)
                {
                    body["roleIds"] = ExpressionConverter.ConvertO(__workflow_bodyroleIds);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(__workflow_bodycontainsName);
                    bodypropCount++;
                }

                if (__workflow_bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(__workflow_bodyorderAscending);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryUsersResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetExternalSystemByIdResponse, ApiConnectionActionConfiguration> GetExternalSystemById(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> externalSystemId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_externalSystemId = WorkflowExpression.Compile(externalSystemId, nameof(externalSystemId), required: true);
            return new DeferredBodyAction<GetExternalSystemByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/user/systems/{0}", __workflow_externalSystemId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetExternalSystemByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<ResolveContextResponse, ApiConnectionActionConfiguration> ResolveContext(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> bodysource = null, Expression<Func<string>> bodyentityName = null, Expression<Func<string>> bodylegalEntity = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodysource = WorkflowExpression.Compile(bodysource, nameof(bodysource), required: false);
            var __workflow_bodyentityName = WorkflowExpression.Compile(bodyentityName, nameof(bodyentityName), required: false);
            var __workflow_bodylegalEntity = WorkflowExpression.Compile(bodylegalEntity, nameof(bodylegalEntity), required: false);
            return new DeferredBodyAction<ResolveContextResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/integration/resolvecontext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(__workflow_bodysource);
                    bodypropCount++;
                }

                if (__workflow_bodyentityName != null)
                {
                    body["entityName"] = ExpressionConverter.ConvertO(__workflow_bodyentityName);
                    bodypropCount++;
                }

                if (__workflow_bodylegalEntity != null)
                {
                    body["legalEntity"] = ExpressionConverter.ConvertO(__workflow_bodylegalEntity);
                    bodypropCount++;
                }

                var fieldsObject = new JObject();
                var fieldsObjectpropCount = 0;
                if (fieldsObjectpropCount > 0)
                {
                    body["fields"] = fieldsObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<ResolveContextResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<AdvancedSearchQueryDocumentsResponse, ApiConnectionActionConfiguration> AdvancedSearchQueryDocuments(Expression<Func<string>> exaAuthPlugin)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            return new DeferredBodyAction<AdvancedSearchQueryDocumentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/document/query/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<AdvancedSearchQueryDocumentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<InsertExternalFileResponse, ApiConnectionActionConfiguration> InsertExternalFile(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> filename, Expression<Func<string>> bodybody = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_filename = WorkflowExpression.Compile(filename, nameof(filename), required: true);
            var __workflow_bodybody = WorkflowExpression.Compile(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<InsertExternalFileResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/document/insertexternalfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(__workflow_filename);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(__workflow_bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<InsertExternalFileResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetDocumentMetadataResponse, ApiConnectionActionConfiguration> GetDocumentMetadata(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> id)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentMetadataResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetDocumentMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> id)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddSiteToStorageProvider(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> id, Expression<Func<bodyInputItem[]>> body = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/storageproviders/sharepoint/config/{0}/sites/add", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetDocumentMetadataByFileReferenceResponse, ApiConnectionActionConfiguration> GetDocumentMetadataByFileReference(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> fileReferenceId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_fileReferenceId = WorkflowExpression.Compile(fileReferenceId, nameof(fileReferenceId), required: true);
            return new DeferredBodyAction<GetDocumentMetadataByFileReferenceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}/meta/document", __workflow_fileReferenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetDocumentMetadataByFileReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetStorageProviderByIdResponse, ApiConnectionActionConfiguration> GetStorageProviderById(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> id)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<GetStorageProviderByIdResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/storageproviders/sharepoint/config/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<GetStorageProviderByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<UploadDocumentResponse, ApiConnectionActionConfiguration> UploadDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> name, Expression<Func<contentTypeInput>> contentType, Expression<Func<string>> body = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_name = WorkflowExpression.Compile(name, nameof(name), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/meta/document/content";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(__workflow_name);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<SetPrimaryStorageProviderResponse, ApiConnectionActionConfiguration> SetPrimaryStorageProvider(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> fileReferenceId, Expression<Func<string>> storageProviderId, Expression<Func<bool>> removeRaptorStorage = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_fileReferenceId = WorkflowExpression.Compile(fileReferenceId, nameof(fileReferenceId), required: true);
            var __workflow_storageProviderId = WorkflowExpression.Compile(storageProviderId, nameof(storageProviderId), required: true);
            var __workflow_removeRaptorStorage = WorkflowExpression.Compile(removeRaptorStorage, nameof(removeRaptorStorage), required: false);
            return new DeferredBodyAction<SetPrimaryStorageProviderResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/Files/{0}/primarystorageprovider/{1}", __workflow_fileReferenceId.WithUrlEncoding(1), __workflow_storageProviderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_removeRaptorStorage != null)
                    callPayload.Queries["removeRaptorStorage"] = ExpressionConverter.Convert(__workflow_removeRaptorStorage);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<SetPrimaryStorageProviderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<SetExternalSourceResponse, ApiConnectionActionConfiguration> SetExternalSource(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> fileReferenceId, Expression<Func<string>> body = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_fileReferenceId = WorkflowExpression.Compile(fileReferenceId, nameof(fileReferenceId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<SetExternalSourceResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/files/{0}/externalsource", __workflow_fileReferenceId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<SetExternalSourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GenerateSiteSubscriptions(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> storageProviderId, Expression<Func<string>> contentType = null, Expression<Func<string>> body = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_storageProviderId = WorkflowExpression.Compile(storageProviderId, nameof(storageProviderId), required: true);
            var __workflow_contentType = WorkflowExpression.Compile(contentType, nameof(contentType), required: false);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/storageproviders/sharepoint/subscriptions/{0}/generate", __workflow_storageProviderId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                if (__workflow_contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(__workflow_contentType);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryTemplatesResponse, ApiConnectionActionConfiguration> QueryTemplates(Expression<Func<string>> exaAuthPlugin, Expression<Func<int>> bodylanguageCode = null, Expression<Func<string[]>> bodycontextTags = null, Expression<Func<int>> bodyorderBy = null, Expression<Func<string>> bodyname = null, Expression<Func<string>> bodycontainsName = null, Expression<Func<bool>> bodyorderAscending = null, Expression<Func<string>> bodycontinuationToken = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodylanguageCode = WorkflowExpression.Compile(bodylanguageCode, nameof(bodylanguageCode), required: false);
            var __workflow_bodycontextTags = WorkflowExpression.Compile(bodycontextTags, nameof(bodycontextTags), required: false);
            var __workflow_bodyorderBy = WorkflowExpression.Compile(bodyorderBy, nameof(bodyorderBy), required: false);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            var __workflow_bodycontainsName = WorkflowExpression.Compile(bodycontainsName, nameof(bodycontainsName), required: false);
            var __workflow_bodyorderAscending = WorkflowExpression.Compile(bodyorderAscending, nameof(bodyorderAscending), required: false);
            var __workflow_bodycontinuationToken = WorkflowExpression.Compile(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            return new DeferredBodyAction<QueryTemplatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/templates/querytemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodylanguageCode != null)
                {
                    body["languageCode"] = ExpressionConverter.ConvertO(__workflow_bodylanguageCode);
                    bodypropCount++;
                }

                if (__workflow_bodycontextTags != null)
                {
                    body["contextTags"] = ExpressionConverter.ConvertO(__workflow_bodycontextTags);
                    bodypropCount++;
                }

                if (__workflow_bodyorderBy != null)
                {
                    body["orderBy"] = ExpressionConverter.ConvertO(__workflow_bodyorderBy);
                    bodypropCount++;
                }

                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (__workflow_bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(__workflow_bodycontainsName);
                    bodypropCount++;
                }

                if (__workflow_bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(__workflow_bodyorderAscending);
                    bodypropCount++;
                }

                if (__workflow_bodycontinuationToken != null)
                {
                    body["continuationToken"] = ExpressionConverter.ConvertO(__workflow_bodycontinuationToken);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<QueryTemplatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<FindDocumentResponse, ApiConnectionActionConfiguration> FindDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> azureDirectoryId, Expression<Func<string>> driveId, Expression<Func<string>> driveItemId)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_azureDirectoryId = WorkflowExpression.Compile(azureDirectoryId, nameof(azureDirectoryId), required: true);
            var __workflow_driveId = WorkflowExpression.Compile(driveId, nameof(driveId), required: true);
            var __workflow_driveItemId = WorkflowExpression.Compile(driveItemId, nameof(driveItemId), required: true);
            return new DeferredBodyAction<FindDocumentResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storageproviders/sharepoint/file/find-document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["azureDirectoryId"] = ExpressionConverter.Convert(__workflow_azureDirectoryId);
                callPayload.Queries["driveId"] = ExpressionConverter.Convert(__workflow_driveId);
                callPayload.Queries["driveItemId"] = ExpressionConverter.Convert(__workflow_driveItemId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction<FindDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DetachDocument(Expression<Func<string>> exaAuthPlugin, Expression<Func<string>> bodyazureDirectoryId = null, Expression<Func<string>> bodydriveId = null, Expression<Func<string>> bodydriveItemId = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_bodyazureDirectoryId = WorkflowExpression.Compile(bodyazureDirectoryId, nameof(bodyazureDirectoryId), required: false);
            var __workflow_bodydriveId = WorkflowExpression.Compile(bodydriveId, nameof(bodydriveId), required: false);
            var __workflow_bodydriveItemId = WorkflowExpression.Compile(bodydriveItemId, nameof(bodydriveItemId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/storageproviders/sharepoint/file/detach";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyazureDirectoryId != null)
                {
                    body["azureDirectoryId"] = ExpressionConverter.ConvertO(__workflow_bodyazureDirectoryId);
                    bodypropCount++;
                }

                if (__workflow_bodydriveId != null)
                {
                    body["driveId"] = ExpressionConverter.ConvertO(__workflow_bodydriveId);
                    bodypropCount++;
                }

                if (__workflow_bodydriveItemId != null)
                {
                    body["driveItemId"] = ExpressionConverter.ConvertO(__workflow_bodydriveItemId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> GetOrCreateTag(Expression<Func<string>> exaAuthPlugin, Expression<Func<methodInput>> method, Expression<Func<string>> bodycode = null, Expression<Func<bodylabelsInputItem2[]>> bodylabels = null, Expression<Func<string>> bodyparentTagId = null)
        {
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            var __workflow_method = WorkflowExpression.Compile(method, nameof(method), required: true);
            var __workflow_bodycode = WorkflowExpression.Compile(bodycode, nameof(bodycode), required: false);
            var __workflow_bodylabels = WorkflowExpression.Compile(bodylabels, nameof(bodylabels), required: false);
            var __workflow_bodyparentTagId = WorkflowExpression.Compile(bodyparentTagId, nameof(bodyparentTagId), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/taxonomy/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(__workflow_method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(__workflow_bodycode);
                    bodypropCount++;
                }

                if (__workflow_bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(__workflow_bodylabels);
                    bodypropCount++;
                }

                if (__workflow_bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(__workflow_bodyparentTagId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction<ApiConnectionActionConfiguration> AddTemplateToDocumentSingle(Expression<Func<string>> documentId, Expression<Func<string>> templateId, Expression<Func<string>> exaAuthPlugin)
        {
            var __workflow_documentId = WorkflowExpression.Compile(documentId, nameof(documentId), required: true);
            var __workflow_templateId = WorkflowExpression.Compile(templateId, nameof(templateId), required: true);
            var __workflow_exaAuthPlugin = WorkflowExpression.Compile(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/meta/document/{0}/template/{1}", __workflow_documentId.WithUrlEncoding(1), __workflow_templateId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(__workflow_exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class RaptordocmanagementTriggers([ConnectionName] string connectionId)
    {
    }

    public class QueryDocumentsResponse
    {
        [JsonProperty("result")]
        public QueryDocumentsResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public class QueryDocumentsResponseResultTypeItem
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("explicitTags")]
        public string[] ExplicitTags { get; set; }

        [JsonProperty("fields")]
        public QueryDocumentsResponseResultTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public QueryDocumentsResponseResultTypeItemFileReferenceType FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class QueryDocumentsResponseResultTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QueryDocumentsResponseResultTypeItemFileReferenceType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyorderByInput
    {
        [EnumMember(Value = "0")]
        _0,
        [EnumMember(Value = "1")]
        _1,
        [EnumMember(Value = "2")]
        _2,
        [EnumMember(Value = "3")]
        _3
    }

    public class GetTagByTagIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }

        [JsonProperty("parentHierarchy")]
        public string[] ParentHierarchy { get; set; }

        [JsonProperty("labels")]
        public GetTagByTagIdResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("tagRelations")]
        public string[] TagRelations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("syncDetails")]
        public GetTagByTagIdResponseSyncDetailsType SyncDetails { get; set; }

        [JsonProperty("excludeFromSearch")]
        public bool ExcludeFromSearch { get; set; }
    }

    public class GetTagByTagIdResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTagByTagIdResponseSyncDetailsType
    {
        [JsonProperty("externalEntityName")]
        public string ExternalEntityName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("primaryIdFields")]
        public string[] PrimaryIdFields { get; set; }

        [JsonProperty("primaryIdFormat")]
        public string PrimaryIdFormat { get; set; }

        [JsonProperty("primaryIdFieldValues")]
        public string[] PrimaryIdFieldValues { get; set; }

        [JsonProperty("lastSyncedOn")]
        public string LastSyncedOn { get; set; }
    }

    public class GetTagByCodeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }

        [JsonProperty("parentHierarchy")]
        public string[] ParentHierarchy { get; set; }

        [JsonProperty("labels")]
        public GetTagByCodeResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("tagRelations")]
        public string[] TagRelations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("syncDetails")]
        public GetTagByCodeResponseSyncDetailsType SyncDetails { get; set; }

        [JsonProperty("excludeFromSearch")]
        public bool ExcludeFromSearch { get; set; }
    }

    public class GetTagByCodeResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTagByCodeResponseSyncDetailsType
    {
        [JsonProperty("externalEntityName")]
        public string ExternalEntityName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("primaryIdFields")]
        public string[] PrimaryIdFields { get; set; }

        [JsonProperty("primaryIdFormat")]
        public string PrimaryIdFormat { get; set; }

        [JsonProperty("primaryIdFieldValues")]
        public string[] PrimaryIdFieldValues { get; set; }

        [JsonProperty("lastSyncedOn")]
        public string LastSyncedOn { get; set; }
    }

    public class GetMultipleTagsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }

        [JsonProperty("parentHierarchy")]
        public string[] ParentHierarchy { get; set; }

        [JsonProperty("labels")]
        public GetMultipleTagsResponseItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("tagRelations")]
        public string[] TagRelations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("syncDetails")]
        public GetMultipleTagsResponseItemSyncDetailsType SyncDetails { get; set; }

        [JsonProperty("excludeFromSearch")]
        public bool ExcludeFromSearch { get; set; }
    }

    public class GetMultipleTagsResponseItemLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetMultipleTagsResponseItemSyncDetailsType
    {
        [JsonProperty("externalEntityName")]
        public string ExternalEntityName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("primaryIdFields")]
        public string[] PrimaryIdFields { get; set; }

        [JsonProperty("primaryIdFormat")]
        public string PrimaryIdFormat { get; set; }

        [JsonProperty("primaryIdFieldValues")]
        public string[] PrimaryIdFieldValues { get; set; }

        [JsonProperty("lastSyncedOn")]
        public string LastSyncedOn { get; set; }
    }

    public class QueryTagsResponse
    {
        [JsonProperty("result")]
        public QueryTagsResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class QueryTagsResponseResultTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }

        [JsonProperty("parentHierarchy")]
        public string[] ParentHierarchy { get; set; }

        [JsonProperty("labels")]
        public QueryTagsResponseResultTypeItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("tagRelations")]
        public string[] TagRelations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("syncDetails")]
        public QueryTagsResponseResultTypeItemSyncDetailsType SyncDetails { get; set; }

        [JsonProperty("excludeFromSearch")]
        public bool ExcludeFromSearch { get; set; }
    }

    public class QueryTagsResponseResultTypeItemLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QueryTagsResponseResultTypeItemSyncDetailsType
    {
        [JsonProperty("externalEntityName")]
        public string ExternalEntityName { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("primaryIdFields")]
        public string[] PrimaryIdFields { get; set; }

        [JsonProperty("primaryIdFormat")]
        public string PrimaryIdFormat { get; set; }

        [JsonProperty("primaryIdFieldValues")]
        public string[] PrimaryIdFieldValues { get; set; }

        [JsonProperty("lastSyncedOn")]
        public string LastSyncedOn { get; set; }
    }

    public class CreateFieldResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("labels")]
        public CreateFieldResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("validatingRegExp")]
        public string ValidatingRegExp { get; set; }

        [JsonProperty("validationMessage")]
        public CreateFieldResponseValidationMessageTypeItem[] ValidationMessage { get; set; }

        [JsonProperty("rowAmount")]
        public int RowAmount { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }
    }

    public class CreateFieldResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateFieldResponseValidationMessageTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodylabelsInputItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class bodyvalidationMessageInputItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFieldByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("labels")]
        public GetFieldByIdResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("validatingRegExp")]
        public string ValidatingRegExp { get; set; }

        [JsonProperty("validationMessage")]
        public GetFieldByIdResponseValidationMessageTypeItem[] ValidationMessage { get; set; }

        [JsonProperty("rowAmount")]
        public int RowAmount { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }
    }

    public class GetFieldByIdResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFieldByIdResponseValidationMessageTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFieldByCodeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("labels")]
        public GetFieldByCodeResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("validatingRegExp")]
        public string ValidatingRegExp { get; set; }

        [JsonProperty("validationMessage")]
        public GetFieldByCodeResponseValidationMessageTypeItem[] ValidationMessage { get; set; }

        [JsonProperty("rowAmount")]
        public int RowAmount { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }
    }

    public class GetFieldByCodeResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetFieldByCodeResponseValidationMessageTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplateFieldsResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("isReadOnly")]
        public bool IsReadOnly { get; set; }

        [JsonProperty("defaultValue")]
        public string DefaultValue { get; set; }

        [JsonProperty("labels")]
        public GetTemplateFieldsResponseItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("validatingRegExp")]
        public string ValidatingRegExp { get; set; }

        [JsonProperty("validationMessage")]
        public GetTemplateFieldsResponseItemValidationMessageTypeItem[] ValidationMessage { get; set; }

        [JsonProperty("rowAmount")]
        public int RowAmount { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }
    }

    public class GetTemplateFieldsResponseItemLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplateFieldsResponseItemValidationMessageTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplatebyidResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("labels")]
        public GetTemplatebyidResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("children")]
        public GetTemplatebyidResponseChildrenTypeItem[] Children { get; set; }

        [JsonProperty("relatedTags")]
        public string[] RelatedTags { get; set; }

        [JsonProperty("contextTags")]
        public string[] ContextTags { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }

    public class GetTemplatebyidResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplatebyidResponseChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("template")]
        public GetTemplatebyidResponseChildrenTypeItemTemplateType Template { get; set; }
    }

    public class GetTemplatebyidResponseChildrenTypeItemTemplateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("labels")]
        public GetTemplatebyidResponseChildrenTypeItemTemplateTypeLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("children")]
        public GetTemplatebyidResponseChildrenTypeItemTemplateTypeChildrenTypeItem[] Children { get; set; }

        [JsonProperty("relatedTags")]
        public string[] RelatedTags { get; set; }

        [JsonProperty("contextTags")]
        public string[] ContextTags { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }

    public class GetTemplatebyidResponseChildrenTypeItemTemplateTypeLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplatebyidResponseChildrenTypeItemTemplateTypeChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("masterTemplateId")]
        public string MasterTemplateId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }

    public class GetTemplatebycodeResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("labels")]
        public GetTemplatebycodeResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("children")]
        public GetTemplatebycodeResponseChildrenTypeItem[] Children { get; set; }

        [JsonProperty("relatedTags")]
        public string[] RelatedTags { get; set; }

        [JsonProperty("contextTags")]
        public string[] ContextTags { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }

    public class GetTemplatebycodeResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplatebycodeResponseChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("masterTemplateId")]
        public string MasterTemplateId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("template")]
        public GetTemplatebycodeResponseChildrenTypeItemTemplateType Template { get; set; }
    }

    public class GetTemplatebycodeResponseChildrenTypeItemTemplateType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("labels")]
        public GetTemplatebycodeResponseChildrenTypeItemTemplateTypeLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("children")]
        public GetTemplatebycodeResponseChildrenTypeItemTemplateTypeChildrenTypeItem[] Children { get; set; }

        [JsonProperty("relatedTags")]
        public string[] RelatedTags { get; set; }

        [JsonProperty("contextTags")]
        public string[] ContextTags { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }

    public class GetTemplatebycodeResponseChildrenTypeItemTemplateTypeLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetTemplatebycodeResponseChildrenTypeItemTemplateTypeChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("masterTemplateId")]
        public string MasterTemplateId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }

    public class GetUserByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("primaryEmail")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("isSystemUser")]
        public bool IsSystemUser { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }
    }

    public class QueryUsersResponse
    {
        [JsonProperty("result")]
        public QueryUsersResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }

    public class QueryUsersResponseResultTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("primaryEmail")]
        public string PrimaryEmail { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("surname")]
        public string Surname { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("isSystemUser")]
        public bool IsSystemUser { get; set; }

        [JsonProperty("manager")]
        public string Manager { get; set; }
    }

    public class GetExternalSystemByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("hasUserUI")]
        public bool HasUserUI { get; set; }
    }

    public class ResolveContextResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("parentTagId")]
        public string ParentTagId { get; set; }

        [JsonProperty("parentHierarchy")]
        public string[] ParentHierarchy { get; set; }

        [JsonProperty("labels")]
        public ResolveContextResponseLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("tagRelations")]
        public string[] TagRelations { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class ResolveContextResponseLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class AdvancedSearchQueryDocumentsResponse
    {
        [JsonProperty("result")]
        public AdvancedSearchQueryDocumentsResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }
    }

    public class AdvancedSearchQueryDocumentsResponseResultTypeItem
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("explicitTags")]
        public string[] ExplicitTags { get; set; }

        [JsonProperty("fields")]
        public AdvancedSearchQueryDocumentsResponseResultTypeItemFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public AdvancedSearchQueryDocumentsResponseResultTypeItemFileReferenceType FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class AdvancedSearchQueryDocumentsResponseResultTypeItemFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("numberValue")]
        public int NumberValue { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("users")]
        public JToken[] Users { get; set; }
    }

    public class AdvancedSearchQueryDocumentsResponseResultTypeItemFileReferenceType
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    public class InsertExternalFileResponse
    {
        [JsonProperty("tags")]
        public JToken[] Tags { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public string FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class GetDocumentMetadataResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("explicitTags")]
        public string[] ExplicitTags { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public GetDocumentMetadataResponseFileReferenceType FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class GetDocumentMetadataResponseFileReferenceType
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    public class bodyInputItem
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("tagContext")]
        public string[] TagContext { get; set; }
    }

    public class GetDocumentMetadataByFileReferenceResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("explicitTags")]
        public string[] ExplicitTags { get; set; }

        [JsonProperty("fields")]
        public JToken[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public string FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class GetStorageProviderByIdResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("baseUri")]
        public string BaseUri { get; set; }

        [JsonProperty("siteConfigurations")]
        public GetStorageProviderByIdResponseSiteConfigurationsTypeItem[] SiteConfigurations { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("directoryId")]
        public string DirectoryId { get; set; }

        [JsonProperty("lastSubscriptionExpiryCheck")]
        public string LastSubscriptionExpiryCheck { get; set; }
    }

    public class GetStorageProviderByIdResponseSiteConfigurationsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("tagContext")]
        public string[] TagContext { get; set; }
    }

    public class UploadDocumentResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("fields")]
        public UploadDocumentResponseFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class UploadDocumentResponseFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum contentTypeInput
    {
        [EnumMember(Value = "application/octet-stream")]
        ApplicationOctetStream
    }

    public class SetPrimaryStorageProviderResponse
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("primaryStorageProvider")]
        public string PrimaryStorageProvider { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    public class SetExternalSourceResponse
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("primaryStorageProvider")]
        public string PrimaryStorageProvider { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    public class QueryTemplatesResponse
    {
        [JsonProperty("result")]
        public QueryTemplatesResponseResultTypeItem[] Result { get; set; }

        [JsonProperty("continuationToken")]
        public string ContinuationToken { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("queryInfo")]
        public JToken QueryInfo { get; set; }
    }

    public class QueryTemplatesResponseResultTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("labels")]
        public QueryTemplatesResponseResultTypeItemLabelsTypeItem[] Labels { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }

        [JsonProperty("children")]
        public QueryTemplatesResponseResultTypeItemChildrenTypeItem[] Children { get; set; }

        [JsonProperty("relatedTags")]
        public string[] RelatedTags { get; set; }

        [JsonProperty("contextTags")]
        public string[] ContextTags { get; set; }

        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }

        [JsonProperty("additionalProp1")]
        public string AdditionalProp1 { get; set; }

        [JsonProperty("additionalProp2")]
        public string AdditionalProp2 { get; set; }

        [JsonProperty("additionalProp3")]
        public string AdditionalProp3 { get; set; }
    }

    public class QueryTemplatesResponseResultTypeItemLabelsTypeItem
    {
        [JsonProperty("languageId")]
        public int LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QueryTemplatesResponseResultTypeItemChildrenTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("tenantId")]
        public string TenantId { get; set; }

        [JsonProperty("masterTemplateId")]
        public string MasterTemplateId { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }
    }

    public class FindDocumentResponse
    {
        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("fields")]
        public FindDocumentResponseFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("templateId")]
        public string TemplateId { get; set; }

        [JsonProperty("validationStatus")]
        public int ValidationStatus { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fileReferenceId")]
        public string FileReferenceId { get; set; }

        [JsonProperty("fileReference")]
        public FindDocumentResponseFileReferenceType FileReference { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uploadTimestamp")]
        public string UploadTimestamp { get; set; }
    }

    public class FindDocumentResponseFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("numberValue")]
        public string NumberValue { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("users")]
        public JToken[] Users { get; set; }
    }

    public class FindDocumentResponseFileReferenceType
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ext")]
        public string Ext { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("uploaderId")]
        public string UploaderId { get; set; }

        [JsonProperty("uploader")]
        public string Uploader { get; set; }

        [JsonProperty("created")]
        public string Created { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("version")]
        public int Version { get; set; }

        [JsonProperty("externalSourceUrl")]
        public string ExternalSourceUrl { get; set; }

        [JsonProperty("streamAvailable")]
        public bool StreamAvailable { get; set; }

        [JsonProperty("primaryStorageProvider")]
        public string PrimaryStorageProvider { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum methodInput
    {
        [EnumMember(Value = "get-or-create")]
        GetOrCreate,
        [EnumMember(Value = "create-or-update")]
        CreateOrUpdate,
        [EnumMember(Value = "create-new")]
        CreateNew
    }

    public class bodylabelsInputItem2
    {
        [JsonProperty("languageId")]
        public bodylabelsInputItemLanguageIdType LanguageId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodylabelsInputItemLanguageIdType
    {
        [EnumMember(Value = "1031")]
        _1031,
        [EnumMember(Value = "1033")]
        _1033,
        [EnumMember(Value = "1036")]
        _1036,
        [EnumMember(Value = "2067")]
        _2067
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Raptordocmanagement;

    public partial class WorkflowManagedActions
    {
        public RaptordocmanagementActions Raptordocmanagement(string connectionId) => new RaptordocmanagementActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public RaptordocmanagementTriggers Raptordocmanagement(string connectionId) => new RaptordocmanagementTriggers(connectionId);
    }
}
