//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Raptordocmanagement
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class RaptordocmanagementActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<string> GetUserToken([WorkflowExpression] Func<string> externalSystemId, [WorkflowExpression] Func<string> secret, [WorkflowExpression] Func<string> externalUserName)
        {
            SourceExpression.Validate(externalSystemId, nameof(externalSystemId), required: true);
            SourceExpression.Validate(secret, nameof(secret), required: true);
            SourceExpression.Validate(externalUserName, nameof(externalUserName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/User/getusertoken";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["externalSystemID"] = SourceExpressionConverter.ConvertO(externalSystemId);
                callPayload.Queries["secret"] = SourceExpressionConverter.ConvertO(secret);
                callPayload.Queries["externalUserName"] = SourceExpressionConverter.ConvertO(externalUserName);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<string> DownloadDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/content", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction RemoveTagFromDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/tag/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction TagDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> tagId, [WorkflowExpression] Func<bool> reTag = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            SourceExpression.Validate(reTag, nameof(reTag), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/tag/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (reTag != null)
                    callPayload.Queries["reTag"] = SourceExpressionConverter.ConvertO(reTag);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction AddFieldToDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> method = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(method, nameof(method), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/field", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (method != null)
                    callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction UpdateFieldOnDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodyvalue = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodyvalue, nameof(bodyvalue), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/field", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodyvalue != null)
                {
                    body["value"] = SourceExpressionConverter.ConvertToken(bodyvalue);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction AddTemplateToDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string[]> body = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/multidoc/template/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryDocumentsResponse> QueryDocuments([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string[]> bodyobligatoryTags = null, [WorkflowExpression] Func<string[]> bodytagsInHierarchy = null, [WorkflowExpression] Func<string[]> bodyexcludeTagsInHierarchy = null, [WorkflowExpression] Func<bool> bodyincludeTotalCount = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bodyorderByInput> bodyorderBy = null, [WorkflowExpression] Func<bool> bodyorderAscending = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodyobligatoryTags, nameof(bodyobligatoryTags), required: false);
            SourceExpression.Validate(bodytagsInHierarchy, nameof(bodytagsInHierarchy), required: false);
            SourceExpression.Validate(bodyexcludeTagsInHierarchy, nameof(bodyexcludeTagsInHierarchy), required: false);
            SourceExpression.Validate(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            SourceExpression.Validate(bodyorderBy, nameof(bodyorderBy), required: false);
            SourceExpression.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            SourceExpression.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meta/document/QueryDocuments";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyobligatoryTags != null)
                {
                    body["obligatoryTags"] = SourceExpressionConverter.ConvertToken(bodyobligatoryTags);
                    bodypropCount++;
                }

                if (bodytagsInHierarchy != null)
                {
                    body["tagsInHierarchy"] = SourceExpressionConverter.ConvertToken(bodytagsInHierarchy);
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
                    body["excludeTagsInHierarchy"] = SourceExpressionConverter.ConvertToken(bodyexcludeTagsInHierarchy);
                    bodypropCount++;
                }

                if (bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = SourceExpressionConverter.ConvertToken(bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = SourceExpressionConverter.ConvertToken(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderBy != null)
                {
                    body["orderBy"] = SourceExpressionConverter.Convert(bodyorderBy);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = SourceExpressionConverter.ConvertToken(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodycontinuationToken != null)
                {
                    body["continuationToken"] = SourceExpressionConverter.ConvertToken(bodycontinuationToken);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTagByTagIdResponse> GetTagByTagId([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> tagId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(tagId, nameof(tagId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/taxonomy/tags/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tagId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagByTagIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTagByCodeResponse> GetTagByCode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(code, nameof(code), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/tags/tag";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetTagByCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetMultipleTagsResponseItem[]> GetMultipleTags([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string[]> bodyids = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodyids, nameof(bodyids), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/tags/selection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyids != null)
                {
                    body["ids"] = SourceExpressionConverter.ConvertToken(bodyids);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetMultipleTagsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryTagsResponse> QueryTags([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodyparentTagId = null, [WorkflowExpression] Func<string> bodydirectParentTagId = null, [WorkflowExpression] Func<bool> bodyhasNoParentTag = null, [WorkflowExpression] Func<bool> bodyincludeTotalCount = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            SourceExpression.Validate(bodydirectParentTagId, nameof(bodydirectParentTagId), required: false);
            SourceExpression.Validate(bodyhasNoParentTag, nameof(bodyhasNoParentTag), required: false);
            SourceExpression.Validate(bodyincludeTotalCount, nameof(bodyincludeTotalCount), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            SourceExpression.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/tags/querytags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = SourceExpressionConverter.ConvertToken(bodyparentTagId);
                    bodypropCount++;
                }

                if (bodydirectParentTagId != null)
                {
                    body["directParentTagId"] = SourceExpressionConverter.ConvertToken(bodydirectParentTagId);
                    bodypropCount++;
                }

                if (bodyhasNoParentTag != null)
                {
                    body["hasNoParentTag"] = SourceExpressionConverter.ConvertToken(bodyhasNoParentTag);
                    bodypropCount++;
                }

                if (bodyincludeTotalCount != null)
                {
                    body["includeTotalCount"] = SourceExpressionConverter.ConvertToken(bodyincludeTotalCount);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = SourceExpressionConverter.ConvertToken(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = SourceExpressionConverter.ConvertToken(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryTagsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<CreateFieldResponse> CreateField([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> method = null, [WorkflowExpression] Func<string> bodyid = null, [WorkflowExpression] Func<string> bodytenantId = null, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<int> bodyfieldType = null, [WorkflowExpression] Func<bool> bodyisRequired = null, [WorkflowExpression] Func<bool> bodyisReadOnly = null, [WorkflowExpression] Func<string> bodydefaultValue = null, [WorkflowExpression] Func<bodylabelsInputItem[]> bodylabels = null, [WorkflowExpression] Func<string> bodyvalidatingRegExp = null, [WorkflowExpression] Func<bodyvalidationMessageInputItem[]> bodyvalidationMessage = null, [WorkflowExpression] Func<int> bodyrowAmount = null, [WorkflowExpression] Func<string> bodyparentTagId = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(method, nameof(method), required: false);
            SourceExpression.Validate(bodyid, nameof(bodyid), required: false);
            SourceExpression.Validate(bodytenantId, nameof(bodytenantId), required: false);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodyfieldType, nameof(bodyfieldType), required: false);
            SourceExpression.Validate(bodyisRequired, nameof(bodyisRequired), required: false);
            SourceExpression.Validate(bodyisReadOnly, nameof(bodyisReadOnly), required: false);
            SourceExpression.Validate(bodydefaultValue, nameof(bodydefaultValue), required: false);
            SourceExpression.Validate(bodylabels, nameof(bodylabels), required: false);
            SourceExpression.Validate(bodyvalidatingRegExp, nameof(bodyvalidatingRegExp), required: false);
            SourceExpression.Validate(bodyvalidationMessage, nameof(bodyvalidationMessage), required: false);
            SourceExpression.Validate(bodyrowAmount, nameof(bodyrowAmount), required: false);
            SourceExpression.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/fields";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (method != null)
                    callPayload.Queries["method"] = SourceExpressionConverter.ConvertO(method);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyid != null)
                {
                    body["id"] = SourceExpressionConverter.ConvertToken(bodyid);
                    bodypropCount++;
                }

                if (bodytenantId != null)
                {
                    body["tenantId"] = SourceExpressionConverter.ConvertToken(bodytenantId);
                    bodypropCount++;
                }

                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodyfieldType != null)
                {
                    body["fieldType"] = SourceExpressionConverter.ConvertToken(bodyfieldType);
                    bodypropCount++;
                }

                if (bodyisRequired != null)
                {
                    body["isRequired"] = SourceExpressionConverter.ConvertToken(bodyisRequired);
                    bodypropCount++;
                }

                if (bodyisReadOnly != null)
                {
                    body["isReadOnly"] = SourceExpressionConverter.ConvertToken(bodyisReadOnly);
                    bodypropCount++;
                }

                if (bodydefaultValue != null)
                {
                    body["defaultValue"] = SourceExpressionConverter.ConvertToken(bodydefaultValue);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = SourceExpressionConverter.ConvertToken(bodylabels);
                    bodypropCount++;
                }

                if (bodyvalidatingRegExp != null)
                {
                    body["validatingRegExp"] = SourceExpressionConverter.ConvertToken(bodyvalidatingRegExp);
                    bodypropCount++;
                }

                if (bodyvalidationMessage != null)
                {
                    body["validationMessage"] = SourceExpressionConverter.ConvertToken(bodyvalidationMessage);
                    bodypropCount++;
                }

                if (bodyrowAmount != null)
                {
                    body["rowAmount"] = SourceExpressionConverter.ConvertToken(bodyrowAmount);
                    bodypropCount++;
                }

                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = SourceExpressionConverter.ConvertToken(bodyparentTagId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateFieldResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetFieldByIdResponse> GetFieldById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fieldId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(fieldId, nameof(fieldId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/taxonomy/fields/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fieldId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetFieldByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetFieldByCodeResponse> GetFieldByCode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(code, nameof(code), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/fields/field";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetFieldByCodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplateFieldsResponseItem[]> GetTemplateFields([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/taxonomy/templates/{0}/fields", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplateFieldsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplatebyidResponse> GetTemplatebyid([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> templateId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/taxonomy/templates/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplatebyidResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetTemplatebycodeResponse> GetTemplatebycode([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> code)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(code, nameof(code), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/templates/template";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["code"] = SourceExpressionConverter.ConvertO(code);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplatebycodeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetUserByIdResponse> GetUserById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> userId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(userId, nameof(userId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(userId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetUserByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryUsersResponse> QueryUsers([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<bool> bodyexcludeActiveUsers = null, [WorkflowExpression] Func<bool> bodyexcludeInactiveUsers = null, [WorkflowExpression] Func<bool> bodyexcludeNormalUsers = null, [WorkflowExpression] Func<bool> bodyexcludeSystemUsers = null, [WorkflowExpression] Func<string> bodycontainsEmail = null, [WorkflowExpression] Func<string[]> bodyroleIds = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodyexcludeActiveUsers, nameof(bodyexcludeActiveUsers), required: false);
            SourceExpression.Validate(bodyexcludeInactiveUsers, nameof(bodyexcludeInactiveUsers), required: false);
            SourceExpression.Validate(bodyexcludeNormalUsers, nameof(bodyexcludeNormalUsers), required: false);
            SourceExpression.Validate(bodyexcludeSystemUsers, nameof(bodyexcludeSystemUsers), required: false);
            SourceExpression.Validate(bodycontainsEmail, nameof(bodycontainsEmail), required: false);
            SourceExpression.Validate(bodyroleIds, nameof(bodyroleIds), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            SourceExpression.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/user/queryusers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyexcludeActiveUsers != null)
                {
                    body["excludeActiveUsers"] = SourceExpressionConverter.ConvertToken(bodyexcludeActiveUsers);
                    bodypropCount++;
                }

                if (bodyexcludeInactiveUsers != null)
                {
                    body["excludeInactiveUsers"] = SourceExpressionConverter.ConvertToken(bodyexcludeInactiveUsers);
                    bodypropCount++;
                }

                if (bodyexcludeNormalUsers != null)
                {
                    body["excludeNormalUsers"] = SourceExpressionConverter.ConvertToken(bodyexcludeNormalUsers);
                    bodypropCount++;
                }

                if (bodyexcludeSystemUsers != null)
                {
                    body["excludeSystemUsers"] = SourceExpressionConverter.ConvertToken(bodyexcludeSystemUsers);
                    bodypropCount++;
                }

                if (bodycontainsEmail != null)
                {
                    body["containsEmail"] = SourceExpressionConverter.ConvertToken(bodycontainsEmail);
                    bodypropCount++;
                }

                if (bodyroleIds != null)
                {
                    body["roleIds"] = SourceExpressionConverter.ConvertToken(bodyroleIds);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = SourceExpressionConverter.ConvertToken(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = SourceExpressionConverter.ConvertToken(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetExternalSystemByIdResponse> GetExternalSystemById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> externalSystemId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(externalSystemId, nameof(externalSystemId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/user/systems/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalSystemId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetExternalSystemByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<ResolveContextResponse> ResolveContext([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodysource = null, [WorkflowExpression] Func<string> bodyentityName = null, [WorkflowExpression] Func<string> bodylegalEntity = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodysource, nameof(bodysource), required: false);
            SourceExpression.Validate(bodyentityName, nameof(bodyentityName), required: false);
            SourceExpression.Validate(bodylegalEntity, nameof(bodylegalEntity), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/integration/resolvecontext";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysource != null)
                {
                    body["source"] = SourceExpressionConverter.ConvertToken(bodysource);
                    bodypropCount++;
                }

                if (bodyentityName != null)
                {
                    body["entityName"] = SourceExpressionConverter.ConvertToken(bodyentityName);
                    bodypropCount++;
                }

                if (bodylegalEntity != null)
                {
                    body["legalEntity"] = SourceExpressionConverter.ConvertToken(bodylegalEntity);
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
                return callPayload;
            }

            return new ApiConnectionAction<ResolveContextResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<AdvancedSearchQueryDocumentsResponse> AdvancedSearchQueryDocuments([WorkflowExpression] Func<string> exaAuthPlugin)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meta/document/query/v2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AdvancedSearchQueryDocumentsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<InsertExternalFileResponse> InsertExternalFile([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> filename, [WorkflowExpression] Func<string> bodybody = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(filename, nameof(filename), required: true);
            SourceExpression.Validate(bodybody, nameof(bodybody), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meta/document/insertexternalfile";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["filename"] = SourceExpressionConverter.ConvertO(filename);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybody != null)
                {
                    body["body"] = SourceExpressionConverter.ConvertToken(bodybody);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<InsertExternalFileResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetDocumentMetadataResponse> GetDocumentMetadata([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentMetadataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction DeleteDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction AddSiteToStorageProvider([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<bodyInputItem[]> body = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/config/{0}/sites/add", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetDocumentMetadataByFileReferenceResponse> GetDocumentMetadataByFileReference([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}/meta/document", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileReferenceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentMetadataByFileReferenceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<GetStorageProviderByIdResponse> GetStorageProviderById([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/config/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<GetStorageProviderByIdResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<UploadDocumentResponse> UploadDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> name, [WorkflowExpression] Func<contentTypeInput> contentType, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(name, nameof(name), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/meta/document/content";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["name"] = SourceExpressionConverter.ConvertO(name);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                callPayload.Headers["Content-Type"] = SourceExpressionConverter.Convert(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<UploadDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<SetPrimaryStorageProviderResponse> SetPrimaryStorageProvider([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId, [WorkflowExpression] Func<string> storageProviderId, [WorkflowExpression] Func<bool> removeRaptorStorage = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            SourceExpression.Validate(storageProviderId, nameof(storageProviderId), required: true);
            SourceExpression.Validate(removeRaptorStorage, nameof(removeRaptorStorage), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/Files/{0}/primarystorageprovider/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileReferenceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageProviderId, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (removeRaptorStorage != null)
                    callPayload.Queries["removeRaptorStorage"] = SourceExpressionConverter.ConvertO(removeRaptorStorage);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<SetPrimaryStorageProviderResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<SetExternalSourceResponse> SetExternalSource([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> fileReferenceId, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(fileReferenceId, nameof(fileReferenceId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/files/{0}/externalsource", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileReferenceId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SetExternalSourceResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction GenerateSiteSubscriptions([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> storageProviderId, [WorkflowExpression] Func<string> contentType = null, [WorkflowExpression] Func<string> body = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(storageProviderId, nameof(storageProviderId), required: true);
            SourceExpression.Validate(contentType, nameof(contentType), required: false);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/storageproviders/sharepoint/subscriptions/{0}/generate", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(storageProviderId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                if (contentType != null)
                    callPayload.Headers["Content-Type"] = SourceExpressionConverter.ConvertO(contentType);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<QueryTemplatesResponse> QueryTemplates([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<int> bodylanguageCode = null, [WorkflowExpression] Func<string[]> bodycontextTags = null, [WorkflowExpression] Func<int> bodyorderBy = null, [WorkflowExpression] Func<string> bodyname = null, [WorkflowExpression] Func<string> bodycontainsName = null, [WorkflowExpression] Func<bool> bodyorderAscending = null, [WorkflowExpression] Func<string> bodycontinuationToken = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodylanguageCode, nameof(bodylanguageCode), required: false);
            SourceExpression.Validate(bodycontextTags, nameof(bodycontextTags), required: false);
            SourceExpression.Validate(bodyorderBy, nameof(bodyorderBy), required: false);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            SourceExpression.Validate(bodycontainsName, nameof(bodycontainsName), required: false);
            SourceExpression.Validate(bodyorderAscending, nameof(bodyorderAscending), required: false);
            SourceExpression.Validate(bodycontinuationToken, nameof(bodycontinuationToken), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/templates/querytemplates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodylanguageCode != null)
                {
                    body["languageCode"] = SourceExpressionConverter.ConvertToken(bodylanguageCode);
                    bodypropCount++;
                }

                if (bodycontextTags != null)
                {
                    body["contextTags"] = SourceExpressionConverter.ConvertToken(bodycontextTags);
                    bodypropCount++;
                }

                if (bodyorderBy != null)
                {
                    body["orderBy"] = SourceExpressionConverter.ConvertToken(bodyorderBy);
                    bodypropCount++;
                }

                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodycontainsName != null)
                {
                    body["containsName"] = SourceExpressionConverter.ConvertToken(bodycontainsName);
                    bodypropCount++;
                }

                if (bodyorderAscending != null)
                {
                    body["orderAscending"] = SourceExpressionConverter.ConvertToken(bodyorderAscending);
                    bodypropCount++;
                }

                if (bodycontinuationToken != null)
                {
                    body["continuationToken"] = SourceExpressionConverter.ConvertToken(bodycontinuationToken);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<QueryTemplatesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IBodyWorkflowAction<FindDocumentResponse> FindDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> azureDirectoryId, [WorkflowExpression] Func<string> driveId, [WorkflowExpression] Func<string> driveItemId)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(azureDirectoryId, nameof(azureDirectoryId), required: true);
            SourceExpression.Validate(driveId, nameof(driveId), required: true);
            SourceExpression.Validate(driveItemId, nameof(driveItemId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storageproviders/sharepoint/file/find-document";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["azureDirectoryId"] = SourceExpressionConverter.ConvertO(azureDirectoryId);
                callPayload.Queries["driveId"] = SourceExpressionConverter.ConvertO(driveId);
                callPayload.Queries["driveItemId"] = SourceExpressionConverter.ConvertO(driveItemId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction<FindDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction DetachDocument([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<string> bodyazureDirectoryId = null, [WorkflowExpression] Func<string> bodydriveId = null, [WorkflowExpression] Func<string> bodydriveItemId = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(bodyazureDirectoryId, nameof(bodyazureDirectoryId), required: false);
            SourceExpression.Validate(bodydriveId, nameof(bodydriveId), required: false);
            SourceExpression.Validate(bodydriveItemId, nameof(bodydriveItemId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/storageproviders/sharepoint/file/detach";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyazureDirectoryId != null)
                {
                    body["azureDirectoryId"] = SourceExpressionConverter.ConvertToken(bodyazureDirectoryId);
                    bodypropCount++;
                }

                if (bodydriveId != null)
                {
                    body["driveId"] = SourceExpressionConverter.ConvertToken(bodydriveId);
                    bodypropCount++;
                }

                if (bodydriveItemId != null)
                {
                    body["driveItemId"] = SourceExpressionConverter.ConvertToken(bodydriveItemId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction GetOrCreateTag([WorkflowExpression] Func<string> exaAuthPlugin, [WorkflowExpression] Func<methodInput> method, [WorkflowExpression] Func<string> bodycode = null, [WorkflowExpression] Func<bodylabelsInputItem2[]> bodylabels = null, [WorkflowExpression] Func<string> bodyparentTagId = null)
        {
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            SourceExpression.Validate(method, nameof(method), required: true);
            SourceExpression.Validate(bodycode, nameof(bodycode), required: false);
            SourceExpression.Validate(bodylabels, nameof(bodylabels), required: false);
            SourceExpression.Validate(bodyparentTagId, nameof(bodyparentTagId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/taxonomy/tags";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["method"] = SourceExpressionConverter.Convert(method);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycode != null)
                {
                    body["code"] = SourceExpressionConverter.ConvertToken(bodycode);
                    bodypropCount++;
                }

                if (bodylabels != null)
                {
                    body["labels"] = SourceExpressionConverter.ConvertToken(bodylabels);
                    bodypropCount++;
                }

                if (bodyparentTagId != null)
                {
                    body["parentTagId"] = SourceExpressionConverter.ConvertToken(bodyparentTagId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "raptordocmanagement")]
        public IWorkflowAction AddTemplateToDocumentSingle([WorkflowExpression] Func<string> documentId, [WorkflowExpression] Func<string> templateId, [WorkflowExpression] Func<string> exaAuthPlugin)
        {
            SourceExpression.Validate(documentId, nameof(documentId), required: true);
            SourceExpression.Validate(templateId, nameof(templateId), required: true);
            SourceExpression.Validate(exaAuthPlugin, nameof(exaAuthPlugin), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/meta/document/{0}/template/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(documentId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(templateId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["exa-auth-plugin"] = SourceExpressionConverter.ConvertO(exaAuthPlugin);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
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
        _0 = 0,
        _1 = 1,
        _2 = 2,
        _3 = 3
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
        _1031 = 1031,
        _1033 = 1033,
        _1036 = 1036,
        _2067 = 2067
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