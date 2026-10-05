//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Raptordocmanagement
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RaptordocmanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserToken))]
        public IBodyWorkflowAction<string> GetUserToken([WorkflowExpression] Func<string> externalSystemID, [WorkflowExpression] Func<string> secret, [WorkflowExpression] Func<string> externalUserName)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGetUserToken(WorkflowValue<string> externalSystemID, WorkflowValue<string> secret, WorkflowValue<string> externalUserName)
        {
            WorkflowValue.Validate(externalSystemID, nameof(externalSystemID), required: true);
            WorkflowValue.Validate(secret, nameof(secret), required: true);
            WorkflowValue.Validate(externalUserName, nameof(externalUserName), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/User/getusertoken";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalSystemID"] = ExpressionConverter.Convert(externalSystemID);
                callPayload.Queries["secret"] = ExpressionConverter.Convert(secret);
                callPayload.Queries["externalUserName"] = ExpressionConverter.Convert(externalUserName);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildDownloadDocument))]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildDownloadDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/content", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildRemoveTagFromDocument))]
        public IWorkflowAction RemoveTagFromDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildRemoveTagFromDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> documentId, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/tag/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildTagDocument))]
        public IWorkflowAction TagDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<bool> reTag = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTagDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> documentId, WorkflowValue<string> tagId, WorkflowValue<bool> reTag = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            WorkflowValue.Validate(reTag, nameof(reTag), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/tag/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reTag != null)
                    callPayload.Queries["reTag"] = ExpressionConverter.Convert(reTag);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildAddFieldToDocument))]
        public IWorkflowAction AddFieldToDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> method = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddFieldToDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> documentId, WorkflowValue<string> method = null, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyvalue = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(method, nameof(method), required: false);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/field", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
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
        [WorkflowExpressionFactory(nameof(__BuildUpdateFieldOnDocument))]
        public IWorkflowAction UpdateFieldOnDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildUpdateFieldOnDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> documentId, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodyvalue = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodyvalue, nameof(bodyvalue), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/field", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = ExpressionConverter.ConvertO(bodyvalue);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTemplateToDocument))]
        public IWorkflowAction AddTemplateToDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTemplateToDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> templateId, WorkflowValue<string[]> body = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/multidoc/template/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildQueryDocuments))]
        public IBodyWorkflowAction<QueryDocumentsResponse> QueryDocuments([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string[]> bodyobligatoryTags = null, [WorkflowExpression] Func<string[]> bodytagsInHierarchy = null, [WorkflowExpression] Func<string[]> bodyexcludeTagsInHierarchy = null, [WorkflowExpression] Func<bool> bodyincludeTotalCount = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bodyorderByInput> bodyorderBy = null, [WorkflowExpression] Func<bool> bodyorderAscending = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryDocumentsResponse> __BuildQueryDocuments(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string[]> bodyobligatoryTags = null, WorkflowValue<string[]> bodytagsInHierarchy = null, WorkflowValue<string[]> bodyexcludeTagsInHierarchy = null, WorkflowValue<bool> bodyincludeTotalCount = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodycontainsName = null, WorkflowValue<bodyorderByInput> bodyorderBy = null, WorkflowValue<bool> bodyorderAscending = null, WorkflowValue<string> bodycontinuationToken = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodyobligatoryTags, nameof(bodyobligatoryTags), required: false);
            WorkflowValue.Validate(bodytagsInHierarchy, nameof(bodytagsInHierarchy), required: false);
            WorkflowValue.Validate(bodyexcludeTagsInHierarchy, nameof(bodyexcludeTagsInHierarchy), required: false);
            WorkflowValue.Validate(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            WorkflowValue.Validate(bodyorderBy, nameof(bodyorderBy), required: false);
            WorkflowValue.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            WorkflowValue.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            return new DeferredBodyAction<QueryDocumentsResponse>(() =>
            {
                var apiCallPath = "/meta/document/QueryDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobligatoryTags != null)
                {
                    body["obligatoryTags"] = ExpressionConverter.ConvertO(bodyobligatoryTags);
                    bodypropCount++;
                }

                if (bodytagsInHierarchy != null)
                {
                    body["tagsInHierarchy"] = ExpressionConverter.ConvertO(bodytagsInHierarchy);
                    bodypropCount++;
                }

                var fieldQueryExpressionObject = new JObject();
                var fieldQueryExpressionObjectpropCount = 0;
                if (fieldQueryExpressionObjectpropCount > 0)
                {
                    body["fieldQueryExpression"] = fieldQueryExpressionObject;
                    bodypropCount++;
                }

                if (bodyexcludeTagsInHierarchy != null)
                {
                    body["excludeTagsInHierarchy"] = ExpressionConverter.ConvertO(bodyexcludeTagsInHierarchy);
                    bodypropCount++;
                }

                if (bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = ExpressionConverter.ConvertO(bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderBy != null)
                {
                    body["orderBy"] = ExpressionConverter.ConvertO(bodyorderBy);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodycontinuationToken != null)
                {
                    body["continuationToken"] = ExpressionConverter.ConvertO(bodycontinuationToken);
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
        [WorkflowExpressionFactory(nameof(__BuildGetTagByTagId))]
        public IBodyWorkflowAction<GetTagByTagIdResponse> GetTagByTagId([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> tagId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagByTagIdResponse> __BuildGetTagByTagId(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> tagId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(tagId, nameof(tagId), required: true);
            return new DeferredBodyAction<GetTagByTagIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/taxonomy/tags/{0}", ExpressionConverter.ConvertWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetTagByTagIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetTagByCode))]
        public IBodyWorkflowAction<GetTagByCodeResponse> GetTagByCode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTagByCodeResponse> __BuildGetTagByCode(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> code)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<GetTagByCodeResponse>(() =>
            {
                var apiCallPath = "/taxonomy/tags/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetTagByCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetMultipleTags))]
        public IBodyWorkflowAction<GetMultipleTagsResponseItem[]> GetMultipleTags([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string[]> bodyids = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMultipleTagsResponseItem[]> __BuildGetMultipleTags(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string[]> bodyids = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodyids, nameof(bodyids), required: false);
            return new DeferredBodyAction<GetMultipleTagsResponseItem[]>(() =>
            {
                var apiCallPath = "/taxonomy/tags/selection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyids != null)
                {
                    body["ids"] = ExpressionConverter.ConvertO(bodyids);
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
        [WorkflowExpressionFactory(nameof(__BuildQueryTags))]
        public IBodyWorkflowAction<QueryTagsResponse> QueryTags([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodyparentTagId = null, [WorkflowExpression] Func<string> bodydirectParentTagId = null, [WorkflowExpression] Func<bool> bodyhasNoParentTag = null, [WorkflowExpression] Func<bool> bodyincludeTotalCount = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryTagsResponse> __BuildQueryTags(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> bodyparentTagId = null, WorkflowValue<string> bodydirectParentTagId = null, WorkflowValue<bool> bodyhasNoParentTag = null, WorkflowValue<bool> bodyincludeTotalCount = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodycontainsName = null, WorkflowValue<bool> bodyorderAscending = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            WorkflowValue.Validate(bodydirectParentTagId, nameof(bodydirectParentTagId), required: false);
            WorkflowValue.Validate(bodyhasNoParentTag, nameof(bodyhasNoParentTag), required: false);
            WorkflowValue.Validate(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            WorkflowValue.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            return new DeferredBodyAction<QueryTagsResponse>(() =>
            {
                var apiCallPath = "/taxonomy/tags/querytags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(bodyparentTagId);
                    bodypropCount++;
                }

                if (bodydirectParentTagId != null)
                {
                    body["directParentTagId"] = ExpressionConverter.ConvertO(bodydirectParentTagId);
                    bodypropCount++;
                }

                if (bodyhasNoParentTag != null)
                {
                    body["hasNoParentTag"] = ExpressionConverter.ConvertO(bodyhasNoParentTag);
                    bodypropCount++;
                }

                if (bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = ExpressionConverter.ConvertO(bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(bodyorderAscending);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateField))]
        public IBodyWorkflowAction<CreateFieldResponse> CreateField([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> method = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytenantId = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<int> bodyfieldType = null, [WorkflowExpression] Func<bool> bodyisRequired = null, [WorkflowExpression] Func<bool> bodyisReadOnly = null, [WorkflowExpression] Func<string> bodydefaultValue = null, [WorkflowExpression] Func<bodylabelsInputItem[]> bodylabels = null, [WorkflowExpression] Func<string> bodyvalidatingRegExp = null, [WorkflowExpression] Func<bodyvalidationMessageInputItem[]> bodyvalidationMessage = null, [WorkflowExpression] Func<int> bodyrowAmount = null, [WorkflowExpression] Func<string> bodyparentTagId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CreateFieldResponse> __BuildCreateField(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> method = null, WorkflowValue<string> bodyid = null, WorkflowValue<string> bodytenantId = null, WorkflowValue<string> bodycode = null, WorkflowValue<int> bodyfieldType = null, WorkflowValue<bool> bodyisRequired = null, WorkflowValue<bool> bodyisReadOnly = null, WorkflowValue<string> bodydefaultValue = null, WorkflowValue<bodylabelsInputItem[]> bodylabels = null, WorkflowValue<string> bodyvalidatingRegExp = null, WorkflowValue<bodyvalidationMessageInputItem[]> bodyvalidationMessage = null, WorkflowValue<int> bodyrowAmount = null, WorkflowValue<string> bodyparentTagId = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(method, nameof(method), required: false);
            WorkflowValue.Validate(bodyid, nameof(bodyid), required: false);
            WorkflowValue.Validate(bodytenantId, nameof(bodytenantId), required: false);
            WorkflowValue.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowValue.Validate(bodyfieldType, nameof(bodyfieldType), required: false);
            WorkflowValue.Validate(bodyisRequired, nameof(bodyisRequired), required: false);
            WorkflowValue.Validate(bodyisReadOnly, nameof(bodyisReadOnly), required: false);
            WorkflowValue.Validate(bodydefaultValue, nameof(bodydefaultValue), required: false);
            WorkflowValue.Validate(bodylabels, nameof(bodylabels), required: false);
            WorkflowValue.Validate(bodyvalidatingRegExp, nameof(bodyvalidatingRegExp), required: false);
            WorkflowValue.Validate(bodyvalidationMessage, nameof(bodyvalidationMessage), required: false);
            WorkflowValue.Validate(bodyrowAmount, nameof(bodyrowAmount), required: false);
            WorkflowValue.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            return new DeferredBodyAction<CreateFieldResponse>(() =>
            {
                var apiCallPath = "/taxonomy/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (method != null)
                    callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = ExpressionConverter.ConvertO(bodyid);
                    bodypropCount++;
                }

                if (bodytenantId != null)
                {
                    body["tenantId"] = ExpressionConverter.ConvertO(bodytenantId);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(bodycode);
                    bodypropCount++;
                }

                if (bodyfieldType != null)
                {
                    body["fieldType"] = ExpressionConverter.ConvertO(bodyfieldType);
                    bodypropCount++;
                }

                if (bodyisRequired != null)
                {
                    body["isRequired"] = ExpressionConverter.ConvertO(bodyisRequired);
                    bodypropCount++;
                }

                if (bodyisReadOnly != null)
                {
                    body["isReadOnly"] = ExpressionConverter.ConvertO(bodyisReadOnly);
                    bodypropCount++;
                }

                if (bodydefaultValue != null)
                {
                    body["defaultValue"] = ExpressionConverter.ConvertO(bodydefaultValue);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(bodylabels);
                    bodypropCount++;
                }

                if (bodyvalidatingRegExp != null)
                {
                    body["validatingRegExp"] = ExpressionConverter.ConvertO(bodyvalidatingRegExp);
                    bodypropCount++;
                }

                if (bodyvalidationMessage != null)
                {
                    body["validationMessage"] = ExpressionConverter.ConvertO(bodyvalidationMessage);
                    bodypropCount++;
                }

                if (bodyrowAmount != null)
                {
                    body["rowAmount"] = ExpressionConverter.ConvertO(bodyrowAmount);
                    bodypropCount++;
                }

                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(bodyparentTagId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetFieldById))]
        public IBodyWorkflowAction<GetFieldByIdResponse> GetFieldById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fieldId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFieldByIdResponse> __BuildGetFieldById(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> fieldId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(fieldId, nameof(fieldId), required: true);
            return new DeferredBodyAction<GetFieldByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/taxonomy/fields/{0}", ExpressionConverter.ConvertWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetFieldByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetFieldByCode))]
        public IBodyWorkflowAction<GetFieldByCodeResponse> GetFieldByCode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFieldByCodeResponse> __BuildGetFieldByCode(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> code)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<GetFieldByCodeResponse>(() =>
            {
                var apiCallPath = "/taxonomy/fields/field";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetFieldByCodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetTemplateFields))]
        public IBodyWorkflowAction<GetTemplateFieldsResponseItem[]> GetTemplateFields([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTemplateFieldsResponseItem[]> __BuildGetTemplateFields(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<GetTemplateFieldsResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/taxonomy/templates/{0}/fields", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetTemplateFieldsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetTemplatebyid))]
        public IBodyWorkflowAction<GetTemplatebyidResponse> GetTemplatebyid([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTemplatebyidResponse> __BuildGetTemplatebyid(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> templateId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            return new DeferredBodyAction<GetTemplatebyidResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/taxonomy/templates/{0}", ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetTemplatebyidResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetTemplatebycode))]
        public IBodyWorkflowAction<GetTemplatebycodeResponse> GetTemplatebycode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTemplatebycodeResponse> __BuildGetTemplatebycode(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> code)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<GetTemplatebycodeResponse>(() =>
            {
                var apiCallPath = "/taxonomy/templates/template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = ExpressionConverter.Convert(code);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetTemplatebycodeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetUserById))]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> userId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetUserByIdResponse> __BuildGetUserById(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> userId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(userId, nameof(userId), required: true);
            return new DeferredBodyAction<GetUserByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/{0}", ExpressionConverter.ConvertWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetUserByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildQueryUsers))]
        public IBodyWorkflowAction<QueryUsersResponse> QueryUsers([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<bool> bodyexcludeActiveUsers = null, [WorkflowExpression] Func<bool> bodyexcludeInactiveUsers = null, [WorkflowExpression] Func<bool> bodyexcludeNormalUsers = null, [WorkflowExpression] Func<bool> bodyexcludeSystemUsers = null, [WorkflowExpression] Func<string> bodycontainsEmail = null, [WorkflowExpression] Func<string[]> bodyroleIds = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryUsersResponse> __BuildQueryUsers(WorkflowValue<string> exaAuthPlugin, WorkflowValue<bool> bodyexcludeActiveUsers = null, WorkflowValue<bool> bodyexcludeInactiveUsers = null, WorkflowValue<bool> bodyexcludeNormalUsers = null, WorkflowValue<bool> bodyexcludeSystemUsers = null, WorkflowValue<string> bodycontainsEmail = null, WorkflowValue<string[]> bodyroleIds = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodycontainsName = null, WorkflowValue<bool> bodyorderAscending = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodyexcludeActiveUsers, nameof(bodyexcludeActiveUsers), required: false);
            WorkflowValue.Validate(bodyexcludeInactiveUsers, nameof(bodyexcludeInactiveUsers), required: false);
            WorkflowValue.Validate(bodyexcludeNormalUsers, nameof(bodyexcludeNormalUsers), required: false);
            WorkflowValue.Validate(bodyexcludeSystemUsers, nameof(bodyexcludeSystemUsers), required: false);
            WorkflowValue.Validate(bodycontainsEmail, nameof(bodycontainsEmail), required: false);
            WorkflowValue.Validate(bodyroleIds, nameof(bodyroleIds), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            WorkflowValue.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            return new DeferredBodyAction<QueryUsersResponse>(() =>
            {
                var apiCallPath = "/user/queryusers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexcludeActiveUsers != null)
                {
                    body["excludeActiveUsers"] = ExpressionConverter.ConvertO(bodyexcludeActiveUsers);
                    bodypropCount++;
                }

                if (bodyexcludeInactiveUsers != null)
                {
                    body["excludeInactiveUsers"] = ExpressionConverter.ConvertO(bodyexcludeInactiveUsers);
                    bodypropCount++;
                }

                if (bodyexcludeNormalUsers != null)
                {
                    body["excludeNormalUsers"] = ExpressionConverter.ConvertO(bodyexcludeNormalUsers);
                    bodypropCount++;
                }

                if (bodyexcludeSystemUsers != null)
                {
                    body["excludeSystemUsers"] = ExpressionConverter.ConvertO(bodyexcludeSystemUsers);
                    bodypropCount++;
                }

                if (bodycontainsEmail != null)
                {
                    body["containsEmail"] = ExpressionConverter.ConvertO(bodycontainsEmail);
                    bodypropCount++;
                }

                if (bodyroleIds != null)
                {
                    body["roleIds"] = ExpressionConverter.ConvertO(bodyroleIds);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(bodyorderAscending);
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
        [WorkflowExpressionFactory(nameof(__BuildGetExternalSystemById))]
        public IBodyWorkflowAction<GetExternalSystemByIdResponse> GetExternalSystemById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> externalSystemId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetExternalSystemByIdResponse> __BuildGetExternalSystemById(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> externalSystemId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(externalSystemId, nameof(externalSystemId), required: true);
            return new DeferredBodyAction<GetExternalSystemByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/user/systems/{0}", ExpressionConverter.ConvertWithUrlEncoding(externalSystemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetExternalSystemByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildResolveContext))]
        public IBodyWorkflowAction<ResolveContextResponse> ResolveContext([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyentityName = null, [WorkflowExpression] Func<string> bodylegalEntity = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ResolveContextResponse> __BuildResolveContext(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> bodysource = null, WorkflowValue<string> bodyentityName = null, WorkflowValue<string> bodylegalEntity = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodysource, nameof(bodysource), required: false);
            WorkflowValue.Validate(bodyentityName, nameof(bodyentityName), required: false);
            WorkflowValue.Validate(bodylegalEntity, nameof(bodylegalEntity), required: false);
            return new DeferredBodyAction<ResolveContextResponse>(() =>
            {
                var apiCallPath = "/integration/resolvecontext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysource != null)
                {
                    body["source"] = ExpressionConverter.ConvertO(bodysource);
                    bodypropCount++;
                }

                if (bodyentityName != null)
                {
                    body["entityName"] = ExpressionConverter.ConvertO(bodyentityName);
                    bodypropCount++;
                }

                if (bodylegalEntity != null)
                {
                    body["legalEntity"] = ExpressionConverter.ConvertO(bodylegalEntity);
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
        [WorkflowExpressionFactory(nameof(__BuildAdvancedSearchQueryDocuments))]
        public IBodyWorkflowAction<AdvancedSearchQueryDocumentsResponse> AdvancedSearchQueryDocuments([WorkflowExpression] Func<string> exaAuthPlugin)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<AdvancedSearchQueryDocumentsResponse> __BuildAdvancedSearchQueryDocuments(WorkflowValue<string> exaAuthPlugin)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            return new DeferredBodyAction<AdvancedSearchQueryDocumentsResponse>(() =>
            {
                var apiCallPath = "/meta/document/query/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
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
        [WorkflowExpressionFactory(nameof(__BuildInsertExternalFile))]
        public IBodyWorkflowAction<InsertExternalFileResponse> InsertExternalFile([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> filename, [WorkflowExpression] Func<string> bodybody = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<InsertExternalFileResponse> __BuildInsertExternalFile(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> filename, WorkflowValue<string> bodybody = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(filename, nameof(filename), required: true);
            WorkflowValue.Validate(bodybody, nameof(bodybody), required: false);
            return new DeferredBodyAction<InsertExternalFileResponse>(() =>
            {
                var apiCallPath = "/meta/document/insertexternalfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = ExpressionConverter.Convert(filename);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybody != null)
                {
                    body["body"] = ExpressionConverter.ConvertO(bodybody);
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
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentMetadata))]
        public IBodyWorkflowAction<GetDocumentMetadataResponse> GetDocumentMetadata([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentMetadataResponse> __BuildGetDocumentMetadata(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetDocumentMetadataResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetDocumentMetadataResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteDocument))]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildAddSiteToStorageProvider))]
        public IWorkflowAction AddSiteToStorageProvider([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddSiteToStorageProvider(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> id, WorkflowValue<bodyInputItem[]> body = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/config/{0}/sites/add", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetDocumentMetadataByFileReference))]
        public IBodyWorkflowAction<GetDocumentMetadataByFileReferenceResponse> GetDocumentMetadataByFileReference([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDocumentMetadataByFileReferenceResponse> __BuildGetDocumentMetadataByFileReference(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> fileReferenceId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            return new DeferredBodyAction<GetDocumentMetadataByFileReferenceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}/meta/document", ExpressionConverter.ConvertWithUrlEncoding(fileReferenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetDocumentMetadataByFileReferenceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGetStorageProviderById))]
        public IBodyWorkflowAction<GetStorageProviderByIdResponse> GetStorageProviderById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStorageProviderByIdResponse> __BuildGetStorageProviderById(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<GetStorageProviderByIdResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/config/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<GetStorageProviderByIdResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildUploadDocument))]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<UploadDocumentResponse> __BuildUploadDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> name, WorkflowValue<contentTypeInput> contentType, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(name, nameof(name), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<UploadDocumentResponse>(() =>
            {
                var apiCallPath = "/meta/document/content";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = ExpressionConverter.Convert(name);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<UploadDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildSetPrimaryStorageProvider))]
        public IBodyWorkflowAction<SetPrimaryStorageProviderResponse> SetPrimaryStorageProvider([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId, [WorkflowExpression] Func<string> storageProviderId, [WorkflowExpression] Func<bool> removeRaptorStorage = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetPrimaryStorageProviderResponse> __BuildSetPrimaryStorageProvider(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> fileReferenceId, WorkflowValue<string> storageProviderId, WorkflowValue<bool> removeRaptorStorage = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            WorkflowValue.Validate(storageProviderId, nameof(storageProviderId), required: true);
            WorkflowValue.Validate(removeRaptorStorage, nameof(removeRaptorStorage), required: false);
            return new DeferredBodyAction<SetPrimaryStorageProviderResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/Files/{0}/primarystorageprovider/{1}", ExpressionConverter.ConvertWithUrlEncoding(fileReferenceId, 1), ExpressionConverter.ConvertWithUrlEncoding(storageProviderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (removeRaptorStorage != null)
                    callPayload.Queries["removeRaptorStorage"] = ExpressionConverter.Convert(removeRaptorStorage);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<SetPrimaryStorageProviderResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildSetExternalSource))]
        public IBodyWorkflowAction<SetExternalSourceResponse> SetExternalSource([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetExternalSourceResponse> __BuildSetExternalSource(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> fileReferenceId, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredBodyAction<SetExternalSourceResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/files/{0}/externalsource", ExpressionConverter.ConvertWithUrlEncoding(fileReferenceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction<SetExternalSourceResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildGenerateSiteSubscriptions))]
        public IWorkflowAction GenerateSiteSubscriptions([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> storageProviderId, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> body = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGenerateSiteSubscriptions(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> storageProviderId, WorkflowValue<string> contentType = null, WorkflowValue<string> body = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(storageProviderId, nameof(storageProviderId), required: true);
            WorkflowValue.Validate(contentType, nameof(contentType), required: false);
            WorkflowValue.Validate(body, nameof(body), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/subscriptions/{0}/generate", ExpressionConverter.ConvertWithUrlEncoding(storageProviderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = ExpressionConverter.Convert(contentType);
                callPayload.Body = ExpressionConverter.ConvertO(body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildQueryTemplates))]
        public IBodyWorkflowAction<QueryTemplatesResponse> QueryTemplates([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<int> bodylanguageCode = null, [WorkflowExpression] Func<string[]> bodycontextTags = null, [WorkflowExpression] Func<int> bodyorderBy = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<QueryTemplatesResponse> __BuildQueryTemplates(WorkflowValue<string> exaAuthPlugin, WorkflowValue<int> bodylanguageCode = null, WorkflowValue<string[]> bodycontextTags = null, WorkflowValue<int> bodyorderBy = null, WorkflowValue<string> bodyname = null, WorkflowValue<string> bodycontainsName = null, WorkflowValue<bool> bodyorderAscending = null, WorkflowValue<string> bodycontinuationToken = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            WorkflowValue.Validate(bodycontextTags, nameof(bodycontextTags), required: false);
            WorkflowValue.Validate(bodyorderBy, nameof(bodyorderBy), required: false);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            WorkflowValue.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            WorkflowValue.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            WorkflowValue.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            return new DeferredBodyAction<QueryTemplatesResponse>(() =>
            {
                var apiCallPath = "/taxonomy/templates/querytemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguageCode != null)
                {
                    body["languageCode"] = ExpressionConverter.ConvertO(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodycontextTags != null)
                {
                    body["contextTags"] = ExpressionConverter.ConvertO(bodycontextTags);
                    bodypropCount++;
                }

                if (bodyorderBy != null)
                {
                    body["orderBy"] = ExpressionConverter.ConvertO(bodyorderBy);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = ExpressionConverter.ConvertO(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = ExpressionConverter.ConvertO(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodycontinuationToken != null)
                {
                    body["continuationToken"] = ExpressionConverter.ConvertO(bodycontinuationToken);
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
        [WorkflowExpressionFactory(nameof(__BuildFindDocument))]
        public IBodyWorkflowAction<FindDocumentResponse> FindDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> azureDirectoryId, [WorkflowExpression] Func<string> driveId, [WorkflowExpression] Func<string> driveItemId)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<FindDocumentResponse> __BuildFindDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> azureDirectoryId, WorkflowValue<string> driveId, WorkflowValue<string> driveItemId)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(azureDirectoryId, nameof(azureDirectoryId), required: true);
            WorkflowValue.Validate(driveId, nameof(driveId), required: true);
            WorkflowValue.Validate(driveItemId, nameof(driveItemId), required: true);
            return new DeferredBodyAction<FindDocumentResponse>(() =>
            {
                var apiCallPath = "/storageproviders/sharepoint/file/find-document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["azureDirectoryId"] = ExpressionConverter.Convert(azureDirectoryId);
                callPayload.Queries["driveId"] = ExpressionConverter.Convert(driveId);
                callPayload.Queries["driveItemId"] = ExpressionConverter.Convert(driveItemId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                return new ApiConnectionAction<FindDocumentResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        [WorkflowExpressionFactory(nameof(__BuildDetachDocument))]
        public IWorkflowAction DetachDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodyazureDirectoryId = null, [WorkflowExpression] Func<string> bodydriveId = null, [WorkflowExpression] Func<string> bodydriveItemId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDetachDocument(WorkflowValue<string> exaAuthPlugin, WorkflowValue<string> bodyazureDirectoryId = null, WorkflowValue<string> bodydriveId = null, WorkflowValue<string> bodydriveItemId = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(bodyazureDirectoryId, nameof(bodyazureDirectoryId), required: false);
            WorkflowValue.Validate(bodydriveId, nameof(bodydriveId), required: false);
            WorkflowValue.Validate(bodydriveItemId, nameof(bodydriveItemId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/storageproviders/sharepoint/file/detach";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyazureDirectoryId != null)
                {
                    body["azureDirectoryId"] = ExpressionConverter.ConvertO(bodyazureDirectoryId);
                    bodypropCount++;
                }

                if (bodydriveId != null)
                {
                    body["driveId"] = ExpressionConverter.ConvertO(bodydriveId);
                    bodypropCount++;
                }

                if (bodydriveItemId != null)
                {
                    body["driveItemId"] = ExpressionConverter.ConvertO(bodydriveItemId);
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
        [WorkflowExpressionFactory(nameof(__BuildGetOrCreateTag))]
        public IWorkflowAction GetOrCreateTag([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<bodylabelsInputItem2[]> bodylabels = null, [WorkflowExpression] Func<string> bodyparentTagId = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGetOrCreateTag(WorkflowValue<string> exaAuthPlugin, WorkflowValue<methodInput> method, WorkflowValue<string> bodycode = null, WorkflowValue<bodylabelsInputItem2[]> bodylabels = null, WorkflowValue<string> bodyparentTagId = null)
        {
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            WorkflowValue.Validate(method, nameof(method), required: true);
            WorkflowValue.Validate(bodycode, nameof(bodycode), required: false);
            WorkflowValue.Validate(bodylabels, nameof(bodylabels), required: false);
            WorkflowValue.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/taxonomy/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = ExpressionConverter.Convert(method);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = ExpressionConverter.ConvertO(bodycode);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = ExpressionConverter.ConvertO(bodylabels);
                    bodypropCount++;
                }

                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = ExpressionConverter.ConvertO(bodyparentTagId);
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
        [WorkflowExpressionFactory(nameof(__BuildAddTemplateToDocumentSingle))]
        public IWorkflowAction AddTemplateToDocumentSingle([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> exaAuthPlugin)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildAddTemplateToDocumentSingle(WorkflowValue<string> documentId, WorkflowValue<string> templateId, WorkflowValue<string> exaAuthPlugin)
        {
            WorkflowValue.Validate(documentId, nameof(documentId), required: true);
            WorkflowValue.Validate(templateId, nameof(templateId), required: true);
            WorkflowValue.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/template/{1}", ExpressionConverter.ConvertWithUrlEncoding(documentId, 1), ExpressionConverter.ConvertWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = ExpressionConverter.Convert(exaAuthPlugin);
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
