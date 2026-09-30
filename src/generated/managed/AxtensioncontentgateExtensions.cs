//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Axtensioncontentgate
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AxtensioncontentgateActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityRequirementsResponseItem[]> ListContentEntityRequirements([WorkflowExpression] Func<string> providerReferenceId, [WorkflowExpression] Func<string> externalType, [WorkflowExpression] Func<string> externalId)
        {
            SourceExpression.Validate(providerReferenceId, nameof(providerReferenceId), required: true);
            SourceExpression.Validate(externalType, nameof(externalType), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/businessentities/{0}/{1}/{2}/Requirements", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerReferenceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContentEntityRequirementsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IWorkflowAction CreateContentEntityRequirements([WorkflowExpression] Func<string> providerReferenceId, [WorkflowExpression] Func<string> externalType, [WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<int> bodycontentEntityTemplateId = null, [WorkflowExpression] Func<int> bodycontentEntityTemplateGroupId = null)
        {
            SourceExpression.Validate(providerReferenceId, nameof(providerReferenceId), required: true);
            SourceExpression.Validate(externalType, nameof(externalType), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            SourceExpression.Validate(bodycontentEntityTemplateId, nameof(bodycontentEntityTemplateId), required: false);
            SourceExpression.Validate(bodycontentEntityTemplateGroupId, nameof(bodycontentEntityTemplateGroupId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/businessentities/{0}/{1}/{2}/Requirements", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerReferenceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodycontentEntityTemplateId != null)
                {
                    body["ContentEntityTemplateId"] = SourceExpressionConverter.ConvertToken(bodycontentEntityTemplateId);
                    bodypropCount++;
                }

                if (bodycontentEntityTemplateGroupId != null)
                {
                    body["ContentEntityTemplateGroupId"] = SourceExpressionConverter.ConvertToken(bodycontentEntityTemplateGroupId);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityTypesResponseItem[]> ListBusinessEntityTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/businessentitymodel";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListBusinessEntityTypesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListViewsResponseItem[]> ListViews([WorkflowExpression] Func<string> businessEntityType)
        {
            SourceExpression.Validate(businessEntityType, nameof(businessEntityType), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/BusinessEntityModel/{0}/views", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(businessEntityType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListViewsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListBusinessEntityConnectorsResponseItem[]> ListBusinessEntityConnectors()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/BusinessEntityProviders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeLinked"] = Convert.ToString(true);
                return callPayload;
            }

            return new ApiConnectionAction<ListBusinessEntityConnectorsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<GetSharedContentLinkResponse> GetSharedContentLink([WorkflowExpression] Func<string> contentEntityId)
        {
            SourceExpression.Validate(contentEntityId, nameof(contentEntityId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/content/{0}/sharedContent", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(contentEntityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetSharedContentLinkResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentCategoriesResponseItem[]> ListContentCategories()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ContentCategories";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContentCategoriesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityUserPropertiesResponseItem[]> ListContentEntityUserProperties([WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}/properties", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContentEntityUserPropertiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<string> UpdateContentEntityUserProperty([WorkflowExpression] Func<int> contentEntityId, [WorkflowExpression] Func<int> propertyId, [WorkflowExpression] Func<object> body = null)
        {
            SourceExpression.Validate(contentEntityId, nameof(contentEntityId), required: true);
            SourceExpression.Validate(propertyId, nameof(propertyId), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}/properties/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contentEntityId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(propertyId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplatesResponseItem[]> ListContentEntityTemplates()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/contententitytemplates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContentEntityTemplatesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListContentEntityTemplateGroupsResponseItem[]> ListContentEntityTemplateGroups()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/contententitytemplategroups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListContentEntityTemplateGroupsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExecuteQueryResponse> ExecuteQuery([WorkflowExpression] Func<string> providerReferenceId, [WorkflowExpression] Func<string> externalType, [WorkflowExpression] Func<string> externalId, [WorkflowExpression] Func<int> view = null)
        {
            SourceExpression.Validate(providerReferenceId, nameof(providerReferenceId), required: true);
            SourceExpression.Validate(externalType, nameof(externalType), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            SourceExpression.Validate(view, nameof(view), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/query/{0}/{1}/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerReferenceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (view != null)
                    callPayload.Queries["view"] = SourceExpressionConverter.ConvertO(view);
                return callPayload;
            }

            return new ApiConnectionAction<ExecuteQueryResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ListStorageConnectorsResponseItem[]> ListStorageConnectors()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/StorageProviders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ListStorageConnectorsResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<SearchContentEntitiesResponse> SearchContentEntities([WorkflowExpression] Func<int[]> searchRequesttemplates = null, [WorkflowExpression] Func<int[]> searchRequeststorageProviders = null, [WorkflowExpression] Func<int[]> searchRequestbusinessEntities = null, [WorkflowExpression] Func<int[]> searchRequestbusinessEntityTypes = null, [WorkflowExpression] Func<searchRequestpropertiesInputItem[]> searchRequestproperties = null, [WorkflowExpression] Func<int> searchRequestpagingpage = null, [WorkflowExpression] Func<int> searchRequestpagingpageSize = null, [WorkflowExpression] Func<string> searchRequestpagingsortBy = null, [WorkflowExpression] Func<string> searchRequestpagingsortOrder = null)
        {
            SourceExpression.Validate(searchRequesttemplates, nameof(searchRequesttemplates), required: false);
            SourceExpression.Validate(searchRequeststorageProviders, nameof(searchRequeststorageProviders), required: false);
            SourceExpression.Validate(searchRequestbusinessEntities, nameof(searchRequestbusinessEntities), required: false);
            SourceExpression.Validate(searchRequestbusinessEntityTypes, nameof(searchRequestbusinessEntityTypes), required: false);
            SourceExpression.Validate(searchRequestproperties, nameof(searchRequestproperties), required: false);
            SourceExpression.Validate(searchRequestpagingpage, nameof(searchRequestpagingpage), required: false);
            SourceExpression.Validate(searchRequestpagingpageSize, nameof(searchRequestpagingpageSize), required: false);
            SourceExpression.Validate(searchRequestpagingsortBy, nameof(searchRequestpagingsortBy), required: false);
            SourceExpression.Validate(searchRequestpagingsortOrder, nameof(searchRequestpagingsortOrder), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/contententities/search";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var searchRequest = new JObject();
                var searchRequestpropCount = 0;
                if (searchRequesttemplates != null)
                {
                    searchRequest["Templates"] = SourceExpressionConverter.ConvertToken(searchRequesttemplates);
                    searchRequestpropCount++;
                }

                if (searchRequeststorageProviders != null)
                {
                    searchRequest["StorageProviders"] = SourceExpressionConverter.ConvertToken(searchRequeststorageProviders);
                    searchRequestpropCount++;
                }

                if (searchRequestbusinessEntities != null)
                {
                    searchRequest["BusinessEntities"] = SourceExpressionConverter.ConvertToken(searchRequestbusinessEntities);
                    searchRequestpropCount++;
                }

                if (searchRequestbusinessEntityTypes != null)
                {
                    searchRequest["BusinessEntityTypes"] = SourceExpressionConverter.ConvertToken(searchRequestbusinessEntityTypes);
                    searchRequestpropCount++;
                }

                if (searchRequestproperties != null)
                {
                    searchRequest["Properties"] = SourceExpressionConverter.ConvertToken(searchRequestproperties);
                    searchRequestpropCount++;
                }

                var pagingObject = new JObject();
                var pagingObjectpropCount = 0;
                if (searchRequestpagingpage != null)
                {
                    pagingObject["Page"] = SourceExpressionConverter.ConvertToken(searchRequestpagingpage);
                    pagingObjectpropCount++;
                }

                if (searchRequestpagingpageSize != null)
                {
                    pagingObject["PageSize"] = SourceExpressionConverter.ConvertToken(searchRequestpagingpageSize);
                    pagingObjectpropCount++;
                }

                if (searchRequestpagingsortBy != null)
                {
                    pagingObject["SortBy"] = SourceExpressionConverter.ConvertToken(searchRequestpagingsortBy);
                    pagingObjectpropCount++;
                }

                if (searchRequestpagingsortOrder != null)
                {
                    pagingObject["SortOrder"] = SourceExpressionConverter.ConvertToken(searchRequestpagingsortOrder);
                    pagingObjectpropCount++;
                }

                if (pagingObjectpropCount > 0)
                {
                    searchRequest["Paging"] = pagingObject;
                    searchRequestpropCount++;
                }

                if (searchRequestpropCount > 0)
                {
                    callPayload.Body = searchRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<SearchContentEntitiesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<QueryResultContentEntityItem> GetContentEntity([WorkflowExpression] Func<int> id)
        {
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<QueryResultContentEntityItem>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse> AddBusinessEntityReference([WorkflowExpression] Func<int> contentEntityId, [WorkflowExpression] Func<int> bodybusinessEntityId = null, [WorkflowExpression] Func<string> bodyproviderReferenceId = null, [WorkflowExpression] Func<string> bodyexternalType = null, [WorkflowExpression] Func<string> bodyexternalId = null)
        {
            SourceExpression.Validate(contentEntityId, nameof(contentEntityId), required: true);
            SourceExpression.Validate(bodybusinessEntityId, nameof(bodybusinessEntityId), required: false);
            SourceExpression.Validate(bodyproviderReferenceId, nameof(bodyproviderReferenceId), required: false);
            SourceExpression.Validate(bodyexternalType, nameof(bodyexternalType), required: false);
            SourceExpression.Validate(bodyexternalId, nameof(bodyexternalId), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}/references", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contentEntityId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodybusinessEntityId != null)
                {
                    body["businessEntityId"] = SourceExpressionConverter.ConvertToken(bodybusinessEntityId);
                    bodypropCount++;
                }

                if (bodyproviderReferenceId != null)
                {
                    body["providerReferenceId"] = SourceExpressionConverter.ConvertToken(bodyproviderReferenceId);
                    bodypropCount++;
                }

                if (bodyexternalType != null)
                {
                    body["externalType"] = SourceExpressionConverter.ConvertToken(bodyexternalType);
                    bodypropCount++;
                }

                if (bodyexternalId != null)
                {
                    body["externalId"] = SourceExpressionConverter.ConvertToken(bodyexternalId);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ExceptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse> RemoveBusinessEntityReferenceById([WorkflowExpression] Func<int> contentEntityId, [WorkflowExpression] Func<int> referenceId)
        {
            SourceExpression.Validate(contentEntityId, nameof(contentEntityId), required: true);
            SourceExpression.Validate(referenceId, nameof(referenceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}/references/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contentEntityId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(referenceId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExceptionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "axtensioncontentgate")]
        public IBodyWorkflowAction<ExceptionResponse> RemoveBusinessEntityReferenceByExternalId([WorkflowExpression] Func<int> contentEntityId, [WorkflowExpression] Func<string> providerReference, [WorkflowExpression] Func<string> externalType, [WorkflowExpression] Func<string> externalId)
        {
            SourceExpression.Validate(contentEntityId, nameof(contentEntityId), required: true);
            SourceExpression.Validate(providerReference, nameof(providerReference), required: true);
            SourceExpression.Validate(externalType, nameof(externalType), required: true);
            SourceExpression.Validate(externalId, nameof(externalId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/contententities/{0}/references/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncodingWithInt(contentEntityId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(providerReference, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(externalId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ExceptionResponse>(BuildSourceInput);
        }
    }

    public class AxtensioncontentgateTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger WhenContentAdded([WorkflowExpression] Func<string[]> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodycontentCategories, nameof(bodycontentCategories), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentcreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Created";
                bodypropCount++;
                if (bodycontentCategories != null)
                {
                    body["contentCategories"] = SourceExpressionConverter.ConvertToken(bodycontentCategories);
                    bodypropCount++;
                }

                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "Content";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentUpdated([WorkflowExpression] Func<string[]> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodycontentCategories, nameof(bodycontentCategories), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Updated";
                bodypropCount++;
                if (bodycontentCategories != null)
                {
                    body["contentCategories"] = SourceExpressionConverter.ConvertToken(bodycontentCategories);
                    bodypropCount++;
                }

                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "Content";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentDeleted([WorkflowExpression] Func<string[]> bodycontentCategories = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodycontentCategories, nameof(bodycontentCategories), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentdeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Deleted";
                bodypropCount++;
                if (bodycontentCategories != null)
                {
                    body["contentCategories"] = SourceExpressionConverter.ConvertToken(bodycontentCategories);
                    bodypropCount++;
                }

                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "Content";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementAdded(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentrequirementcreated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Created";
                bodypropCount++;
                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "ContentRequirement";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementUpdated(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentrequirementupdated";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Updated";
                bodypropCount++;
                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "ContentRequirement";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenContentRequirementDeleted(string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/contentrequirementdeleted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Deleted";
                bodypropCount++;
                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "ContentRequirement";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger WhenTemplateNotificationTriggered([WorkflowExpression] Func<int> bodytemplateId = null, [WorkflowExpression] Func<int[]> bodynotificationIds = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: false);
            SourceExpression.Validate(bodynotificationIds, nameof(bodynotificationIds), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/subscriptions/templatenotificationtriggered";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Headers["X-Subscription-Client"] = Convert.ToString("PowerAutomate");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodytemplateId != null)
                {
                    body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                    bodypropCount++;
                }

                if (bodynotificationIds != null)
                {
                    body["notificationIds"] = SourceExpressionConverter.ConvertToken(bodynotificationIds);
                    bodypropCount++;
                }

                body["name"] = "Power Automate Trigger";
                bodypropCount++;
                body["changeType"] = "Triggered";
                bodypropCount++;
                body["latestSupportedTlsVersion"] = "v1_2";
                bodypropCount++;
                body["notificationContentType"] = "application/json";
                bodypropCount++;
                body["notificationUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                body["resource"] = "TemplateNotification";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class ListContentEntityRequirementsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("contentEntityTemplateId")]
        public int ContentEntityTemplateId { get; set; }

        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }
    }

    public class ListBusinessEntityTypesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("title")]
        public ListBusinessEntityTypesResponseItemTitleType Title { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class ListBusinessEntityTypesResponseItemTitleType
    {
        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("fields")]
        public string[] Fields { get; set; }
    }

    public class ListViewsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListBusinessEntityConnectorsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class GetSharedContentLinkResponse
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ListContentCategoriesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class ListContentEntityUserPropertiesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }

        [JsonProperty("value")]
        public JToken Value { get; set; }
    }

    public class ListContentEntityTemplatesResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }
    }

    public class ListContentEntityTemplateGroupsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("apiName")]
        public string ApiName { get; set; }
    }

    public class ExecuteQueryResponse
    {
        [JsonProperty("info")]
        public ExecuteQueryResponseInfoType Info { get; set; }

        [JsonProperty("data")]
        public QueryResultData Data { get; set; }

        [JsonProperty("projection")]
        public ExecuteQueryResponseProjectionType Projection { get; set; }
    }

    public class ExecuteQueryResponseInfoType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class QueryResultData
    {
        [JsonProperty("context")]
        public QueryResultDataContextType Context { get; set; }

        [JsonProperty("businessEntities")]
        public QueryResultDataBusinessEntitiesTypeItem[] BusinessEntities { get; set; }

        [JsonProperty("contentEntities")]
        public QueryResultContentEntityItem[] ContentEntities { get; set; }
    }

    public class QueryResultDataContextType
    {
        [JsonProperty("businessEntityTypeId")]
        public int BusinessEntityTypeId { get; set; }

        [JsonProperty("businessEntityTypeLabel")]
        public string BusinessEntityTypeLabel { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("fields")]
        public QueryResultDataContextTypeFieldsTypeItem[] Fields { get; set; }

        [JsonProperty("links")]
        public QueryResultDataContextTypeLinksTypeItem[] Links { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class QueryResultDataContextTypeFieldsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class QueryResultDataContextTypeLinksTypeItem
    {
        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("directLink")]
        public string DirectLink { get; set; }
    }

    public class QueryResultDataBusinessEntitiesTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("commonId")]
        public JToken[] CommonId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("typeId")]
        public int TypeId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }

        [JsonProperty("references")]
        public QueryResultDataBusinessEntitiesTypeItemReferencesTypeItem[] References { get; set; }

        [JsonProperty("retrievalPath")]
        public JToken[] RetrievalPath { get; set; }

        [JsonProperty("contentIds")]
        public int[] ContentIds { get; set; }
    }

    public class QueryResultDataBusinessEntitiesTypeItemReferencesTypeItem
    {
        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }
    }

    public class QueryResultContentEntityItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fileSize")]
        public int FileSize { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("fileTypeDisplayName")]
        public string FileTypeDisplayName { get; set; }

        [JsonProperty("fileUrl")]
        public string FileUrl { get; set; }

        [JsonProperty("fileVersion")]
        public string FileVersion { get; set; }

        [JsonProperty("categoryId")]
        public int CategoryId { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("storageProviderId")]
        public int StorageProviderId { get; set; }

        [JsonProperty("storageProviderName")]
        public string StorageProviderName { get; set; }

        [JsonProperty("storageProviderReferenceId")]
        public string StorageProviderReferenceId { get; set; }

        [JsonProperty("userProperties")]
        public JToken UserProperties { get; set; }

        [JsonProperty("createdOn")]
        public string CreatedOn { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("changedOn")]
        public string ChangedOn { get; set; }

        [JsonProperty("changedBy")]
        public string ChangedBy { get; set; }

        [JsonProperty("permissions")]
        public QueryResultContentEntityItemPermissionsType Permissions { get; set; }

        [JsonProperty("templatePermissions")]
        public QueryResultContentEntityItemTemplatePermissionsType TemplatePermissions { get; set; }

        [JsonProperty("numberOfPages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("requirementId")]
        public int RequirementId { get; set; }

        [JsonProperty("templateId")]
        public int TemplateId { get; set; }

        [JsonProperty("templateName")]
        public string TemplateName { get; set; }

        [JsonProperty("detailsUrl")]
        public string DetailsUrl { get; set; }

        [JsonProperty("downloadUrl")]
        public string DownloadUrl { get; set; }

        [JsonProperty("activeContentRequestId")]
        public int ActiveContentRequestId { get; set; }

        [JsonProperty("request")]
        public QueryResultContentEntityItemRequestType Request { get; set; }

        [JsonProperty("openIn")]
        public QueryResultContentEntityItemOpenInType OpenIn { get; set; }

        [JsonProperty("providerIdentifiers")]
        public QueryResultContentEntityItemProviderIdentifiersTypeItem[] ProviderIdentifiers { get; set; }
    }

    public class QueryResultContentEntityItemPermissionsType
    {
        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("create")]
        public bool Create { get; set; }

        [JsonProperty("update")]
        public bool Update { get; set; }

        [JsonProperty("updateContent")]
        public bool UpdateContent { get; set; }

        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("download")]
        public bool Download { get; set; }
    }

    public class QueryResultContentEntityItemTemplatePermissionsType
    {
        [JsonProperty("delete")]
        public bool Delete { get; set; }

        [JsonProperty("fulfill")]
        public bool Fulfill { get; set; }

        [JsonProperty("request")]
        public bool Request { get; set; }

        [JsonProperty("requestExternal")]
        public bool RequestExternal { get; set; }
    }

    public class QueryResultContentEntityItemRequestType
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("reviewAllowed")]
        public bool ReviewAllowed { get; set; }

        [JsonProperty("fulfillmentAllowed")]
        public bool FulfillmentAllowed { get; set; }

        [JsonProperty("declineAllowed")]
        public bool DeclineAllowed { get; set; }
    }

    public class QueryResultContentEntityItemOpenInType
    {
        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }

        [JsonProperty("editorApps")]
        public QueryResultContentEntityItemOpenInTypeEditorAppsTypeItem[] EditorApps { get; set; }
    }

    public class QueryResultContentEntityItemOpenInTypeEditorAppsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("launchUrl")]
        public string LaunchUrl { get; set; }
    }

    public class QueryResultContentEntityItemProviderIdentifiersTypeItem
    {
        [JsonProperty("businessEntityId")]
        public int BusinessEntityId { get; set; }

        [JsonProperty("externalId")]
        public string ExternalId { get; set; }

        [JsonProperty("externalType")]
        public string ExternalType { get; set; }

        [JsonProperty("providerReferenceId")]
        public string ProviderReferenceId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("subtitle")]
        public string Subtitle { get; set; }
    }

    public class ExecuteQueryResponseProjectionType
    {
        [JsonProperty("fields")]
        public ExecuteQueryResponseProjectionTypeFieldsTypeItem[] Fields { get; set; }
    }

    public class ExecuteQueryResponseProjectionTypeFieldsTypeItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("fieldType")]
        public int FieldType { get; set; }

        [JsonProperty("referenceTypeId")]
        public int ReferenceTypeId { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class ListStorageConnectorsResponseItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("referenceId")]
        public string ReferenceId { get; set; }
    }

    public class SearchContentEntitiesResponse
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("items")]
        public QueryResultContentEntityItem[] Items { get; set; }
    }

    public class searchRequestpropertiesInputItem
    {
        public string Property { get; set; }
        public string Operator { get; set; }
        public bool Negate { get; set; }
        public JToken Value { get; set; }
    }

    public class ExceptionResponse
    {
        [JsonProperty("error")]
        public ExceptionResponseErrorType Error { get; set; }
    }

    public class ExceptionResponseErrorType
    {
        [JsonProperty("status")]
        public double Status { get; set; }

        [JsonProperty("errorId")]
        public string ErrorId { get; set; }

        [JsonProperty("correlationId")]
        public string CorrelationId { get; set; }

        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userTitle")]
        public string UserTitle { get; set; }

        [JsonProperty("userMessage")]
        public string UserMessage { get; set; }

        [JsonProperty("contextInfo")]
        public JToken ContextInfo { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Axtensioncontentgate;

    public partial class WorkflowManagedActions
    {
        public AxtensioncontentgateActions Axtensioncontentgate(string connectionId) => new AxtensioncontentgateActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AxtensioncontentgateTriggers Axtensioncontentgate(string connectionId) => new AxtensioncontentgateTriggers(connectionId);
    }
}