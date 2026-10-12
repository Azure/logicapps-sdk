//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Orbusinfinity
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OrbusinfinityActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildRelationshipsGet))]
        public IBodyWorkflowAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelRelationship> RelationshipsGet([WorkflowExpression] Func<bool> includeIntersectional = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelRelationship> __BuildRelationshipsGet(WorkflowExpression<bool> includeIntersectional = null, WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<bool> count = null)
        {
            WorkflowExpression.Validate(includeIntersectional, nameof(includeIntersectional), required: false);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelRelationship>(() =>
            {
                var apiCallPath = "/odata/Relationships";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["includeIntersectional"] = Convert.ToString(false);
                if (includeIntersectional != null)
                    callPayload.Queries["includeIntersectional"] = ExpressionConverter.Convert(includeIntersectional);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
                return new ApiConnectionAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelRelationship>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildRelationships))]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseCreateRelationshipResponseLevel0> Relationships([WorkflowExpression] Func<string> bodyrelationshipTypeId, [WorkflowExpression] Func<string> bodyleadModelItemId, [WorkflowExpression] Func<string> bodymemberModelItemId, [WorkflowExpression] Func<string> bodymodelId, [WorkflowExpression] Func<string> bodyrelationshipTypePairId = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseCreateRelationshipResponseLevel0> __BuildRelationships(WorkflowExpression<string> bodyrelationshipTypeId, WorkflowExpression<string> bodyleadModelItemId, WorkflowExpression<string> bodymemberModelItemId, WorkflowExpression<string> bodymodelId, WorkflowExpression<string> bodyrelationshipTypePairId = null)
        {
            WorkflowExpression.Validate(bodyrelationshipTypeId, nameof(bodyrelationshipTypeId), required: true);
            WorkflowExpression.Validate(bodyleadModelItemId, nameof(bodyleadModelItemId), required: true);
            WorkflowExpression.Validate(bodymemberModelItemId, nameof(bodymemberModelItemId), required: true);
            WorkflowExpression.Validate(bodymodelId, nameof(bodymodelId), required: true);
            WorkflowExpression.Validate(bodyrelationshipTypePairId, nameof(bodyrelationshipTypePairId), required: false);
            return new DeferredBodyAction<OfficeArchitectContractsRelationshipResponseCreateRelationshipResponseLevel0>(() =>
            {
                var apiCallPath = "/odata/Relationships";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["relationshipTypeId"] = ExpressionConverter.ConvertO(bodyrelationshipTypeId);
                if (bodyrelationshipTypePairId != null)
                {
                    body["relationshipTypePairId"] = ExpressionConverter.ConvertO(bodyrelationshipTypePairId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["leadModelItemId"] = ExpressionConverter.ConvertO(bodyleadModelItemId);
                bodypropCount++;
                body["memberModelItemId"] = ExpressionConverter.ConvertO(bodymemberModelItemId);
                var attributeValuesFlatObject = new JObject();
                var attributeValuesFlatObjectpropCount = 0;
                if (attributeValuesFlatObjectpropCount > 0)
                {
                    body["attributeValuesFlat"] = attributeValuesFlatObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["modelId"] = ExpressionConverter.ConvertO(bodymodelId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OfficeArchitectContractsRelationshipResponseCreateRelationshipResponseLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildRelationshipsGetSingle))]
        public IBodyWorkflowAction<OfficeArchitectContractsODataModelRelationshipLevel0> RelationshipsGetSingle([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsODataModelRelationshipLevel0> __BuildRelationshipsGetSingle(WorkflowExpression<string> key, WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<OfficeArchitectContractsODataModelRelationshipLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Relationships({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                return new ApiConnectionAction<OfficeArchitectContractsODataModelRelationshipLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildRelationshipsDelete))]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseDeleteRelationshipResponseLevel0> RelationshipsDelete([WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseDeleteRelationshipResponseLevel0> __BuildRelationshipsDelete(WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<OfficeArchitectContractsRelationshipResponseDeleteRelationshipResponseLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Relationships({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfficeArchitectContractsRelationshipResponseDeleteRelationshipResponseLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildRelationshipsPatch))]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseUpdateRelationshipResponseLevel0> RelationshipsPatch([WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsRelationshipResponseUpdateRelationshipResponseLevel0> __BuildRelationshipsPatch(WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<OfficeArchitectContractsRelationshipResponseUpdateRelationshipResponseLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Relationships({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var attributeValuesFlatObject = new JObject();
                var attributeValuesFlatObjectpropCount = 0;
                if (attributeValuesFlatObjectpropCount > 0)
                {
                    body["attributeValuesFlat"] = attributeValuesFlatObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OfficeArchitectContractsRelationshipResponseUpdateRelationshipResponseLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildObjectsGet))]
        public IBodyWorkflowAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelObject> ObjectsGet([WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<bool> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelObject> __BuildObjectsGet(WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null, WorkflowExpression<string> filter = null, WorkflowExpression<string> orderby = null, WorkflowExpression<int> top = null, WorkflowExpression<int> skip = null, WorkflowExpression<bool> count = null)
        {
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            WorkflowExpression.Validate(filter, nameof(filter), required: false);
            WorkflowExpression.Validate(orderby, nameof(orderby), required: false);
            WorkflowExpression.Validate(top, nameof(top), required: false);
            WorkflowExpression.Validate(skip, nameof(skip), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelObject>(() =>
            {
                var apiCallPath = "/odata/Objects";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (count != null)
                    callPayload.Queries["$count"] = ExpressionConverter.Convert(count);
                return new ApiConnectionAction<OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelObject>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildObjects))]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseCreateObjectResponseLevel0> Objects([WorkflowExpression] Func<string> bodyobjectTypeId, [WorkflowExpression] Func<string> bodymodelId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseCreateObjectResponseLevel0> __BuildObjects(WorkflowExpression<string> bodyobjectTypeId, WorkflowExpression<string> bodymodelId)
        {
            WorkflowExpression.Validate(bodyobjectTypeId, nameof(bodyobjectTypeId), required: true);
            WorkflowExpression.Validate(bodymodelId, nameof(bodymodelId), required: true);
            return new DeferredBodyAction<OfficeArchitectContractsObjectResponseCreateObjectResponseLevel0>(() =>
            {
                var apiCallPath = "/odata/Objects";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["objectTypeId"] = ExpressionConverter.ConvertO(bodyobjectTypeId);
                var attributeValuesFlatObject = new JObject();
                var attributeValuesFlatObjectpropCount = 0;
                if (attributeValuesFlatObjectpropCount > 0)
                {
                    body["attributeValuesFlat"] = attributeValuesFlatObject;
                    bodypropCount++;
                }

                bodypropCount++;
                body["modelId"] = ExpressionConverter.ConvertO(bodymodelId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OfficeArchitectContractsObjectResponseCreateObjectResponseLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildObjectsGetSingle))]
        public IBodyWorkflowAction<OfficeArchitectContractsODataModelObjectLevel0> ObjectsGetSingle([WorkflowExpression] Func<string> key, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<string> expand = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsODataModelObjectLevel0> __BuildObjectsGetSingle(WorkflowExpression<string> key, WorkflowExpression<string> select = null, WorkflowExpression<string> expand = null)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            WorkflowExpression.Validate(select, nameof(select), required: false);
            WorkflowExpression.Validate(expand, nameof(expand), required: false);
            return new DeferredBodyAction<OfficeArchitectContractsODataModelObjectLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Objects({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (expand != null)
                    callPayload.Queries["$expand"] = ExpressionConverter.Convert(expand);
                return new ApiConnectionAction<OfficeArchitectContractsODataModelObjectLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildObjectsDelete))]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseDeleteObjectResponseLevel0> ObjectsDelete([WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseDeleteObjectResponseLevel0> __BuildObjectsDelete(WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<OfficeArchitectContractsObjectResponseDeleteObjectResponseLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Objects({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<OfficeArchitectContractsObjectResponseDeleteObjectResponseLevel0>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "orbusinfinity")]
        [WorkflowExpressionFactory(nameof(__BuildObjectsPatch))]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseUpdateObjectResponseLevel0> ObjectsPatch([WorkflowExpression] Func<string> key)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<OfficeArchitectContractsObjectResponseUpdateObjectResponseLevel0> __BuildObjectsPatch(WorkflowExpression<string> key)
        {
            WorkflowExpression.Validate(key, nameof(key), required: true);
            return new DeferredBodyAction<OfficeArchitectContractsObjectResponseUpdateObjectResponseLevel0>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/odata/Objects({0})", ExpressionConverter.ConvertWithUrlEncoding(key, 1));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                var attributeValuesFlatObject = new JObject();
                var attributeValuesFlatObjectpropCount = 0;
                if (attributeValuesFlatObjectpropCount > 0)
                {
                    body["attributeValuesFlat"] = attributeValuesFlatObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<OfficeArchitectContractsObjectResponseUpdateObjectResponseLevel0>(callPayload);
            });
        }
    }

    public class OrbusinfinityTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildPostWebhooks))]
        public IBodyWorkflowTrigger<OfficeArchitectContractsNotificationResponseSaveWebhookResponseLevel0> PostWebhooks([WorkflowExpression] Func<string> bodyeventType,[WorkflowExpression] Func<string> bodysecret = null,[WorkflowExpression] Func<string> bodyexpirationDate = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowTrigger<OfficeArchitectContractsNotificationResponseSaveWebhookResponseLevel0> __BuildPostWebhooks(WorkflowExpression<string> bodyeventType,WorkflowExpression<string> bodysecret = null,WorkflowExpression<string> bodyexpirationDate = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyeventType, nameof(bodyeventType), required: true);
            WorkflowExpression.Validate(bodysecret, nameof(bodysecret), required: false);
            WorkflowExpression.Validate(bodyexpirationDate, nameof(bodyexpirationDate), required: false);
            return new DeferredBodyTrigger<OfficeArchitectContractsNotificationResponseSaveWebhookResponseLevel0>(() =>
            {
                var apiCallPath = "/odata/Webhooks";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysecret != null)
                {
                    body["secret"] = ExpressionConverter.ConvertO(bodysecret);
                    bodypropCount++;
                }

                bodypropCount++;
                body["eventType"] = ExpressionConverter.ConvertO(bodyeventType);
                body["url"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodyexpirationDate != null)
                {
                    body["expirationDate"] = ExpressionConverter.ConvertO(bodyexpirationDate);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger<OfficeArchitectContractsNotificationResponseSaveWebhookResponseLevel0>(callPayload, recurrence: recurrence);
            });
        }
    }

    public class OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelRelationship
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OfficeArchitectContractsODataModelRelationshipLevel0[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelationshipLevel0
    {
        [JsonProperty("leadObject")]
        public OfficeArchitectContractsODataModelObjectLevel1 LeadObject { get; set; }

        [JsonProperty("leadRelationship")]
        public OfficeArchitectContractsODataModelRelationshipLevel1 LeadRelationship { get; set; }

        [JsonProperty("memberObject")]
        public OfficeArchitectContractsODataModelObjectLevel1 MemberObject { get; set; }

        [JsonProperty("relationshipType")]
        public OfficeArchitectContractsODataMetamodelRelationshipTypeLevel1 RelationshipType { get; set; }

        [JsonProperty("detail")]
        public OfficeArchitectContractsODataModelRelationshipDetailLevel1 Detail { get; set; }

        [JsonProperty("approvalDetails")]
        public OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel1 ApprovalDetails { get; set; }

        [JsonProperty("model")]
        public OfficeArchitectContractsODataModelModelLevel1 Model { get; set; }

        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel1 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel1 LastModifiedBy { get; set; }

        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("leadRelationshipId")]
        public string LeadRelationshipId { get; set; }

        [JsonProperty("leadObjectId")]
        public string LeadObjectId { get; set; }

        [JsonProperty("memberObjectId")]
        public string MemberObjectId { get; set; }

        [JsonProperty("relationshipTypePairId")]
        public string RelationshipTypePairId { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("attributeValuesFlat")]
        public JToken AttributeValuesFlat { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("attributeValues")]
        public OfficeArchitectContractsODataModelAttributeValueAttributeValueLevel2[] AttributeValues { get; set; }
    }

    public class OfficeArchitectContractsODataModelObjectLevel1
    {
        [JsonProperty("objectType")]
        public OfficeArchitectContractsODataMetamodelObjectTypeLevel2 ObjectType { get; set; }

        [JsonProperty("lockedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LockedBy { get; set; }

        [JsonProperty("detail")]
        public OfficeArchitectContractsODataModelObjectDetailLevel2 Detail { get; set; }

        [JsonProperty("approvalDetails")]
        public OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel2 ApprovalDetails { get; set; }

        [JsonProperty("model")]
        public OfficeArchitectContractsODataModelModelLevel2 Model { get; set; }

        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LastModifiedBy { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("lockedOn")]
        public string LockedOn { get; set; }

        [JsonProperty("lockedById")]
        public string LockedById { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("relatedObjects")]
        public OfficeArchitectContractsODataModelRelatedObjectLevel2[] RelatedObjects { get; set; }

        [JsonProperty("attributeValuesFlat")]
        public JToken AttributeValuesFlat { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("attributeValues")]
        public OfficeArchitectContractsODataModelAttributeValueAttributeValueLevel2[] AttributeValues { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelObjectTypeLevel2
    {
        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("parentObjectTypeId")]
        public string ParentObjectTypeId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class OfficeArchitectContractsODataPermissionAuditUserLevel2
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }
    }

    public class OfficeArchitectContractsODataModelObjectDetailLevel2
    {
        [JsonProperty("originalObjectId")]
        public string OriginalObjectId { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }
    }

    public class OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel2
    {
        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("isPendingReview")]
        public bool IsPendingReview { get; set; }

        [JsonProperty("requestedBy")]
        public string RequestedBy { get; set; }

        [JsonProperty("requestedOn")]
        public string RequestedOn { get; set; }

        [JsonProperty("requestedOnVersionNumber")]
        public int RequestedOnVersionNumber { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        [JsonProperty("completedOnVersionNumber")]
        public int CompletedOnVersionNumber { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class OfficeArchitectContractsODataModelModelLevel2
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelatedObjectLevel2
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("isLead")]
        public bool IsLead { get; set; }

        [JsonProperty("relatedObjectId")]
        public string RelatedObjectId { get; set; }
    }

    public class OfficeArchitectContractsODataModelAttributeValueAttributeValueLevel2
    {
        [JsonProperty("value")]
        public double Value { get; set; }

        [JsonProperty("stringValue")]
        public string StringValue { get; set; }

        [JsonProperty("attributeValueId")]
        public int AttributeValueId { get; set; }

        [JsonProperty("attributeCategoryId")]
        public int AttributeCategoryId { get; set; }

        [JsonProperty("attributeId")]
        public string AttributeId { get; set; }

        [JsonProperty("modelItemId")]
        public string ModelItemId { get; set; }

        [JsonProperty("attributeName")]
        public string AttributeName { get; set; }

        [JsonProperty("attributeAlias")]
        public string AttributeAlias { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelationshipLevel1
    {
        [JsonProperty("leadObject")]
        public OfficeArchitectContractsODataModelObjectLevel2 LeadObject { get; set; }

        [JsonProperty("leadRelationship")]
        public OfficeArchitectContractsODataModelRelationshipLevel2 LeadRelationship { get; set; }

        [JsonProperty("memberObject")]
        public OfficeArchitectContractsODataModelObjectLevel2 MemberObject { get; set; }

        [JsonProperty("relationshipType")]
        public OfficeArchitectContractsODataMetamodelRelationshipTypeLevel2 RelationshipType { get; set; }

        [JsonProperty("detail")]
        public OfficeArchitectContractsODataModelRelationshipDetailLevel2 Detail { get; set; }

        [JsonProperty("approvalDetails")]
        public OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel2 ApprovalDetails { get; set; }

        [JsonProperty("model")]
        public OfficeArchitectContractsODataModelModelLevel2 Model { get; set; }

        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LastModifiedBy { get; set; }

        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("leadRelationshipId")]
        public string LeadRelationshipId { get; set; }

        [JsonProperty("leadObjectId")]
        public string LeadObjectId { get; set; }

        [JsonProperty("memberObjectId")]
        public string MemberObjectId { get; set; }

        [JsonProperty("relationshipTypePairId")]
        public string RelationshipTypePairId { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("attributeValuesFlat")]
        public JToken AttributeValuesFlat { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("attributeValues")]
        public OfficeArchitectContractsODataModelAttributeValueAttributeValueLevel2[] AttributeValues { get; set; }
    }

    public class OfficeArchitectContractsODataModelObjectLevel2
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("lockedOn")]
        public string LockedOn { get; set; }

        [JsonProperty("lockedById")]
        public string LockedById { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelationshipLevel2
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("leadRelationshipId")]
        public string LeadRelationshipId { get; set; }

        [JsonProperty("leadObjectId")]
        public string LeadObjectId { get; set; }

        [JsonProperty("memberObjectId")]
        public string MemberObjectId { get; set; }

        [JsonProperty("relationshipTypePairId")]
        public string RelationshipTypePairId { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelRelationshipTypeLevel2
    {
        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("leadToMemberDirection")]
        public string LeadToMemberDirection { get; set; }

        [JsonProperty("memberToLeadDirection")]
        public string MemberToLeadDirection { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelationshipDetailLevel2
    {
        [JsonProperty("originalRelationshipId")]
        public string OriginalRelationshipId { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelRelationshipTypeLevel1
    {
        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LastModifiedBy { get; set; }

        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("leadToMemberDirection")]
        public string LeadToMemberDirection { get; set; }

        [JsonProperty("memberToLeadDirection")]
        public string MemberToLeadDirection { get; set; }

        [JsonProperty("representation")]
        public OfficeArchitectContractsMetamodelDocumentTypeRepresentationSituation Representation { get; set; }

        [JsonProperty("direction")]
        public OfficeArchitectContractsMetamodelMetamodelItemRelationshipTypeUsage Direction { get; set; }

        [JsonProperty("color")]
        public OfficeArchitectContractsMetamodelMetamodelItemSystemColors Color { get; set; }

        [JsonProperty("relationshipTypePairs")]
        public OfficeArchitectContractsODataMetamodelRelationshipTypePairLevel2[] RelationshipTypePairs { get; set; }

        [JsonProperty("solutions")]
        public OfficeArchitectContractsODataMetamodelMetamodelItemSolutionLevel2[] Solutions { get; set; }

        [JsonProperty("attributeAssignments")]
        public OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentLevel2[] AttributeAssignments { get; set; }

        [JsonProperty("attributeAssignmentGroups")]
        public OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentGroupLevel2[] AttributeAssignmentGroups { get; set; }

        [JsonProperty("defaultApprovers")]
        public OfficeArchitectContractsODataMetamodelMetamodelItemDefaultApproverLevel2[] DefaultApprovers { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMetamodelDocumentTypeRepresentationSituation
    {
        None,
        Connected,
        Containment,
        Overlap
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMetamodelMetamodelItemRelationshipTypeUsage
    {
        Directionless,
        Sequential,
        Hierarchical,
        Intersectional
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMetamodelMetamodelItemSystemColors
    {
        Default,
        Lochmara,
        Indigo,
        Malibu,
        MineShaft,
        DoveGray,
        PottersClay,
        Kabul,
        Thatch,
        PersianGreen,
        Visio,
        Word,
        Excel,
        Powerpoint,
        TropicalRainForest,
        MonteCarlo,
        FruitSalad,
        Parsley,
        MossGreen,
        California,
        Clementine,
        Chardonnay,
        Pomegranate,
        TallPoppy,
        Sunglo,
        SilverChalice,
        DefaultVis,
        LightIndigo,
        LightMalibu,
        DarkMalibu
    }

    public class OfficeArchitectContractsODataMetamodelRelationshipTypePairLevel2
    {
        [JsonProperty("relationshipTypePairId")]
        public string RelationshipTypePairId { get; set; }

        [JsonProperty("relationshipTypeId")]
        public string RelationshipTypeId { get; set; }

        [JsonProperty("leadObjectTypeId")]
        public string LeadObjectTypeId { get; set; }

        [JsonProperty("memberObjectTypeId")]
        public string MemberObjectTypeId { get; set; }

        [JsonProperty("leadRelationshipTypeId")]
        public string LeadRelationshipTypeId { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelMetamodelItemSolutionLevel2
    {
        [JsonProperty("solutionId")]
        public string SolutionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentLevel2
    {
        [JsonProperty("attributeAssignmentId")]
        public string AttributeAssignmentId { get; set; }

        [JsonProperty("attributeId")]
        public string AttributeId { get; set; }

        [JsonProperty("attributeCategoryId")]
        public int AttributeCategoryId { get; set; }

        [JsonProperty("metamodelItemId")]
        public string MetamodelItemId { get; set; }

        [JsonProperty("attributeAssignmentGroupId")]
        public string AttributeAssignmentGroupId { get; set; }

        [JsonProperty("isIdentifier")]
        public bool IsIdentifier { get; set; }

        [JsonProperty("isInherited")]
        public bool IsInherited { get; set; }

        [JsonProperty("isDisplay")]
        public bool IsDisplay { get; set; }

        [JsonProperty("isImportant")]
        public bool IsImportant { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("stringDefaultValue")]
        public string StringDefaultValue { get; set; }

        [JsonProperty("isProtected")]
        public bool IsProtected { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentGroupLevel2
    {
        [JsonProperty("attributeAssignmentGroupId")]
        public string AttributeAssignmentGroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelMetamodelItemDefaultApproverLevel2
    {
        [JsonProperty("metamodelItemDefaultApproverId")]
        public string MetamodelItemDefaultApproverId { get; set; }

        [JsonProperty("personId")]
        public string PersonId { get; set; }

        [JsonProperty("personName")]
        public string PersonName { get; set; }
    }

    public class OfficeArchitectContractsODataModelRelationshipDetailLevel1
    {
        [JsonProperty("originalRelationshipId")]
        public string OriginalRelationshipId { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }

        [JsonProperty("status")]
        public OfficeArchitectContractsModelItemModelItemStatus Status { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsModelItemModelItemStatus
    {
        Original,
        Reuse,
        Variant
    }

    public class OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel1
    {
        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("isPendingReview")]
        public bool IsPendingReview { get; set; }

        [JsonProperty("requestedBy")]
        public string RequestedBy { get; set; }

        [JsonProperty("requestedOn")]
        public string RequestedOn { get; set; }

        [JsonProperty("requestedOnVersionNumber")]
        public int RequestedOnVersionNumber { get; set; }

        [JsonProperty("completedBy")]
        public string CompletedBy { get; set; }

        [JsonProperty("completedOn")]
        public string CompletedOn { get; set; }

        [JsonProperty("completedOnVersionNumber")]
        public int CompletedOnVersionNumber { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class OfficeArchitectContractsODataModelModelLevel1
    {
        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LastModifiedBy { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("color")]
        public OfficeArchitectContractsMetamodelMetamodelItemSystemColors Color { get; set; }

        [JsonProperty("isHidden")]
        public bool IsHidden { get; set; }

        [JsonProperty("solutions")]
        public OfficeArchitectContractsODataModelModelSolutionLevel2[] Solutions { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfficeArchitectContractsODataModelModelSolutionLevel2
    {
        [JsonProperty("solutionId")]
        public string SolutionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfficeArchitectContractsODataPermissionAuditUserLevel1
    {
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("emailAddress")]
        public string EmailAddress { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }
    }

    public class OfficeArchitectContractsRelationshipResponseCreateRelationshipResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipCreatedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipCreatedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionRelationshipRelationshipCreatedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionRelationshipRelationshipCreatedLevel2
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }

        [JsonProperty("leadObjectId")]
        public string LeadObjectId { get; set; }

        [JsonProperty("leadRelationshipId")]
        public string LeadRelationshipId { get; set; }

        [JsonProperty("memberObjectId")]
        public string MemberObjectId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMessageMessageCategory
    {
        Error,
        Warning,
        Information
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMessageMessageCode
    {
        AttributeAssignmentDoesNotExist,
        DocumentTypeMustBelongToAModellingSolution,
        DocumentTypeHasDocuments,
        CustomDocumentTypeHasDocuments,
        DuplicateDocumentTypeInModellingSolution,
        DuplicateObjectTypeInModellingSolution,
        InvalidDocumentTypeCategory,
        DocumentTypeCategoryMismatch,
        CustomDocumentTypeNotSupported,
        CustomDocumentTypeMustHaveAtLeastOneFileExtension,
        DocumentTypeFileExtensionNotSupportedForCustomCategory,
        IdentifyingAttributeAssignmentWithInstancesExists,
        DocumentTypeDoesNotExist,
        DocumentTypeNameIsInvalid,
        DocumentTypeFilenameInvalid,
        DocumentTypePrimaryTemplateAlreadyExists,
        DocumentTypeDoesNotSupportAncillaryTemplateFiles,
        MissingDocumentTypeTemplateFile,
        MissingDocumentTypePrimaryTemplateFile,
        MultipleDocumentTypePrimaryTemplateFiles,
        DocumentTypeFileExtensionNotSupportedForCategory,
        TemplateFilenamesMustBeUnique,
        ContentTypeSaveOperationFailed,
        InvalidDocumentTypeRelationshipType,
        MetamodelItemMustBelongToAModellingSolution,
        ParentObjectTypeDoesNotExist,
        ObjectTypeHasCircularReference,
        ObjectsTypeHasNotChanged,
        ModelDoesNotExist,
        MetamodelItemIsNotUniqueToModellingSolution,
        MetamodelItemNotInModel,
        MetamodelItemIsSystemLocked,
        MetamodelItemIsHidden,
        MetamodelItemIsAlreadyVisible,
        MetamodelItemIsNotApprovable,
        MetamodelItemHasNotRequiredCategory,
        MetamodelItemHasNotAttributeAssignment,
        MetamodelItemHasNotCommonSolutionsWithIdentifyingAttribute,
        AttributesDeleted,
        ObjectTypesDeleted,
        RelationshipTypesDeleted,
        DependentModelItemsExist,
        ModelItemsDoesNotHaveComponents,
        ModelItemIsNotComponentOfDocumentType,
        RelationshipPairMembersAreNotComponentsOfDocument,
        MultipleDuplicateMetamodelItems,
        EntityIsAlreadyProtected,
        EntityIsAlreadyUnprotected,
        AttributeDoesNotExist,
        AttributeDoesNotExistByName,
        AttributeDoesNotExistByKey,
        AttributeNotAssignedToMetamodelItem,
        AttributeIsNotIdentifyingAttribute,
        AttributeNotInModelModellingSolution,
        AttributeAssignmentCannotBeEdited,
        IdentifyingAttributeAssignmentExists,
        InheritedAttributeAssignmentExists,
        MultipleDuplicateAttributes,
        AttributeCategoryMismatch,
        AttributeDateTimeDateOnly,
        AttributeDateTimeMaximumIsNotDateOnly,
        AttributeDateTimeMinimumIsNotDateOnly,
        AttributeValueHyperlinkNotUri,
        AttributeValuesCommitted,
        AttributeHyperlinkDisplayValueProvided,
        AttributeHyperlinkUriNotProvided,
        AttributeMultipleValuesProvided,
        AttributeHyperlinkValueTooLong,
        AttributeHyperlinkDisplayValueTooLong,
        AttributePersonOrGroupIsGroup,
        AttributeValuePersonOrGroupNotInGroup,
        AttributeNumberMaximumValueExceedsLimits,
        AttributeNumberMinimumValueExceedsLimits,
        AttributeMinimumNumberPrecisionIsNotEqualToPrecisionValue,
        AttributeMaximumNumberPrecisionIsNotEqualToPrecisionValue,
        AttributeCurrencyMaximumValueExceedsLimits,
        AttributeCurrencyMinimumValueExceedsLimits,
        AttributeCurrencyMaximumValueInvalidPrecision,
        AttributeCurrencyMinimumValueInvalidPrecision,
        AttributeTextMinimumValueExceedsLimits,
        AttributeTextMaximumValueExceedsLimits,
        AttributeDoesNotExists,
        AttributeWithNameAlreadyExists,
        InvalidIsoCurrencySymbol,
        AttributeNumberPrecisionIsOutOfRange,
        AttributeMinimumValueIsGreaterThanMaximumValue,
        AttributeCurrencyMinimumValueIsGreaterThanMaximumValue,
        AttributeDateTimeMinimumValueIsGreaterThanMaximumValue,
        AttributeNumberMinimumValueIsGreaterThanMaximumValue,
        AttributeTextMinimumLengthValueIsGreaterThanMaximumLengthValue,
        UnableToAssignReadOnlyAttributes,
        UnableToAssignHiddenAttributes,
        UnableToDeleteSystemAttributeAssignment,
        MappedImportWorksheetSettingsDoesNotExist,
        MappedImportWorksheetSettingsDoesNotBelongToUser,
        ModelDoesNotHaveSubsetOfModellingSolutions,
        ModelNameNotUnique,
        ModelNameValueNotProvided,
        ModelIsDeactivated,
        ModelIsActivated,
        ModelsDeactivated,
        ModelsActivated,
        ModellingSolutionsAreNotUnique,
        IdentifyingAttributeCannotBeImportant,
        MultipleIdentifyingAttributeAssignments,
        AttributesAreAlreadyAssigned,
        MetamodelItemHasInstances,
        IdentifyingAttributeModellingSolutionsAreNotValid,
        ObjectTypeIsParentOrChild,
        UnableToAssignSystemAttributes,
        AttributeIsNotAssignedToMetamodelItem,
        ExternalDocumentDoesNotExist,
        DocumentDoesNotExist,
        AttributeChoiceDuplicates,
        AttributeChoiceDoesNotExists,
        AttributeChoiceIsNotPresent,
        AttributeChoiceValueIsNotPresent,
        AttributeChoiceValueIsNotUnique,
        IdentifyingAttributeDoesNotShareAllMetamodelItemsSolutions,
        AttributeIsIdentifyingAttribute,
        ModelItemIsSoftDeleted,
        ModelItemIsNotSoftDeleted,
        ModellingSolutionDoesNotExist,
        ModelItemReuseDeletionRequired,
        ObjectIsReuse,
        ObjectIsVariant,
        ObjectIsReused,
        RelationshipDeletionRequired,
        FeedbackDeletionRequired,
        ViewModellingSolutionIdsNotAllowedOnCollectionView,
        ViewMustBelongToAModellingSolution,
        AdHocViewsCannotContainRuntimeParameters,
        ViewDimensionsRequired,
        TraceabilityViewFilterSetMustContainFilters,
        TraceabilityViewFilterCannotHaveMoreColumns,
        ViewDimensionRequireGroups,
        ViewFilterGroupRequireViewFilters,
        ViewFilterGroupHasIncorrectPositions,
        InvalidViewDimensionCategories,
        ViewFilterCategoryNotAllowedInCollectionView,
        ViewFilterHasTooManyIdentifyingParameters,
        ViewFilterIsMissingIdentifyingParameters,
        ViewFilterHasTooManyRuntimeParameters,
        ViewFilterIsMissingRuntimeParameter,
        ViewFilterParameterValuesNotProvided,
        ViewFilterParameterValuesProvidedForRuntimeParameter,
        ViewFilterParameterValuesProvidedForNullOperatorParameter,
        ViewFilterParameterOperatorNotSupported,
        ViewFilterParameterCategoryNotSupported,
        ViewFilterParameterValueTextIsTooLong,
        MetamodelItemCategoryNotSupported,
        ViewModelIdParameterMustBeRuntime,
        ViewGenerationStorageExpiredOrEmpty,
        ViewGenerationStorageNotAvailableForSavedParameters,
        ViewDimensionDoesNotExist,
        ViewFilterParameterRuntimeMissing,
        ViewFilterParameterRuntimeNotNeeded,
        ModelNotAvailableToAnyViewModellingSolutions,
        ModelNotAvailableToAllViewModellingSolutions,
        ImportantAttributeValueNotProvided,
        DisplayAttributeValueNotProvided,
        UniqueAttributeValueNotUnique,
        AttributeValueNumberOutOfRange,
        AttributeValueNumberOutOfRangeLowerOnly,
        AttributeValueNumberOutOfRangeUpperOnly,
        AttributeValueCurrencyOutOfRange,
        AttributeValueCurrencyOutOfRangeLowerOnly,
        AttributeValueCurrencyOutOfRangeUpperOnly,
        AttributeValueTextOutOfRange,
        AttributeValueTextOutOfRangeLowerOnly,
        AttributeValueTextOutOfRangeUpperOnly,
        AttributeValueDateTimeOutOfRange,
        AttributeValueDateTimeDateOnly,
        AttributeValueDateTimeOutOfRangeLowerOnly,
        AttributeValueDateTimeOutOfRangeUpperOnly,
        AttributeValueTextPlainTextMissing,
        AttributeValueCurrencyInvalidPrecision,
        AttributeValueNumberInvalidPrecision,
        AttributeValueChoiceDuplicateExistingChoice,
        AttributeValueNotChoice,
        AttributeValueChoiceInvalidParent,
        AttributeValueChoiceMultipleValuesProvided,
        AttributeValueHyperlinkMultipleValuesProvided,
        AttributeValuePersonOrGroupMultipleValuesProvided,
        AttributeValueBothPersonAndGroupHaveValue,
        MultipleDuplicateAttributeValues,
        AttributePersonOrGroupInvalid,
        UnableToDeleteGlobalAttribute,
        UnableToUpdateGlobalAttribute,
        UnableToDeleteSystemAttribute,
        UnableToUpdateSystemAttribute,
        UnableToUpdateNameOrSolutionForGlobalAttribute,
        UnableToUpdateConfigurationForGlobalAttribute,
        UnableToUpdateConfigurationForAssignedAttribute,
        ProtectedAttributeConfigurationHasChanged,
        ProtectedMetamodelItemHasChanged,
        ProtectedObjectTypeHasChanged,
        ProtectedRelationshipTypeHasChanged,
        ModelItemDoesNotExist,
        MetamodelItemDoesNotExist,
        ModelItemIsAlike,
        ModelItemIsLocked,
        ModelItemIsUnlocked,
        ModelItemIsNotObject,
        ModelItemIsNotRelationship,
        ModelItemIsNotApprovable,
        ModelItemIsNotPendingReview,
        ModelItemIsAlreadyPendingReview,
        ModelItemVersionIsNotLast,
        ModelItemsTypeNotEquals,
        ModelItemsEquals,
        ModelItemIsDeactivated,
        ModelItemsActivatedDeactivated,
        ModelItemsDeactivated,
        ModelItemsActivated,
        UserIsNotInApproversList,
        IdentifyingAttributeValueNotProvided,
        ObjectIsAlike,
        RelationshipIsAlike,
        LeadObjectDoesNotExist,
        LeadRelationshipDoesNotExist,
        MemberObjectDoesNotExist,
        NoValidRelationshipTypeExists,
        RelationshipTypePairDoesNotExist,
        ProtectedSolutionDoesNotContainLeadAndMember,
        RelationshipTypePairIsNotAssignedToRelationshipType,
        RelationshipTypePairIsDeactivated,
        RelationshipTypePairIsNotValid,
        UpdateSelfReferencePairInCaseOfHierarchicalDirectionDoesNotExist,
        DeleteSelfReferencePairInCaseOfHierarchicalDirectionDoesNotExist,
        DuplicateRelationshipTypePair,
        ObjectCapacityIsApproaching,
        ObjectCapacityIsAvailable,
        PermissionDeniedFeature,
        PermissionDeniedModel,
        PermissionDeniedModelItem,
        PermissionDeniedLeadModelItem,
        PermissionDeniedMemberModelItem,
        PermissionDeniedModelModelItem,
        PermissionDeniedModelMetamodelItem,
        PermissionDeniedDataImport,
        PersonNotInAnyRole,
        DependentModelItemsCannotBeUnlocked,
        PermissionDeniedModelAdministration,
        GroupDoesNotExist,
        PersonDoesNotExist,
        DuplicateGroupSpecified,
        DuplicatePersonSpecified,
        DuplicateMetamodelItemInModellingSolution,
        SolutionIsAssignedToModels,
        SolutionDoesNotExist,
        SolutionAlreadyExists,
        WebhookDoesNotExist,
        WebhookWithSameDataAlreadyExists,
        WebhookEventTypeIsNotValid,
        WebhookUrlIsNotValid,
        WebhookExpirationDateIsNotValid,
        WebhookUrlCannotBeAuthenticated,
        DocumentFilePathIsInaccessible,
        LicenseKeyIsNotValid,
        LicenseNotValid,
        SecretHasTooManyCharacters,
        NotificationDoesNotExist,
        NotificationDoesNotBelongToUser,
        DocumentIsCounterpartLinked,
        ModelItemIsCounterpartLinked,
        ObjectCounterpartLinked,
        DocumentLinkDoesNotExist,
        DocumentComponentDoesNotExist,
        ComponentDoesNotExist,
        SingleRepresentationSituationDoesNotExists,
        ComponentRepresentationSituationNotValid,
        MetamodelEntityIsProtected,
        MetamodelEntityIsNotProtected,
        AttributeAssignmentOfChildObjectTypeCannotBeProtected,
        SolutionWithProtectedAttributeAssignmentsCannotBeUnprotected,
        ObjectCapacityIsExceeded,
        MetamodelItemApproversEntriesExceedMaximumLimit,
        DuplicatedDocumentTypeLinkSpecified,
        ClientForVisioDocumentTypeIsInvalid,
        DocumentUrlIsInvalid,
        DocumentPageIsOutOfRange,
        DocumentExportFormatIsInvalid,
        DataFileIsInvalid,
        ImportFileDoesNotExist,
        ImportFileCanNotBeOpened,
        ImportFileRequiredWorksheetMissing,
        ImportFileWorksheetFromMappingsMissing,
        ImportFileXmlSchemaIsInvalid,
        ImportFailedUnknownError,
        ImportIsInvalid,
        MetamodelItemIsAlreadyHidden,
        RelationshipTypePairIsAlreadyHidden,
        RelationshipTypePairIsAlreadyActive,
        AttributeAssignmentsDeleted,
        AttributeAssignmentsCommited,
        DocumentsDeleted,
        SharePointSiteSet,
        DocumentsRegistered,
        DocumentTypeCreated,
        DocumentTypeDeleted,
        DocumentTypeUpdated,
        DocumentTypeTemplateFilesSaved,
        DocumentTypeMetamodelItemsSaved,
        AttributeAssigmentsSaved,
        AttributeCreated,
        AttributeUpdated,
        ModelItemsReused,
        ModelItemsDeleted,
        ObjectCreated,
        ObjectUpdated,
        ObjectsCreated,
        ObjectsUpdated,
        ObjectSkipped,
        ObjectsCopied,
        ObjectDeleted,
        ObjectsDeleted,
        ObjectsMerged,
        ObjectReclassified,
        ObjectsReclassified,
        ObjectsRelationshipsMerged,
        RelationshipCreated,
        RelationshipsCreated,
        RelationshipsCopied,
        RelationshipUpdated,
        RelationshipsUpdated,
        RelationshipDeleted,
        RelationshipsDeleted,
        RelationshipSkipped,
        RelationshipTypeDoesNotExist,
        RelationshipTypePairsDeleted,
        RelationshipsMerged,
        LeadToMemberDirectionEmpty,
        MemberToLeadDirectionEmpty,
        RepresentationSituationIsNotValid,
        IntersectionalRelationshipRepresentationIsNotValid,
        IntersectionalRelationshipTypeWithSamePairAlreadyExists,
        IntersectionalRelationshipTypeCannotHavePairsWithAnyLeadOrMember,
        RelationshipTypeHasNoPairs,
        DuplicateRelationshipTypeInModellingSolution,
        DocumentManagementSystemRetrieved,
        ObjectTypeCreated,
        SolutionCreated,
        SolutionDeleted,
        WebhookSaved,
        WebhookDeleted,
        MappedImportWorksheetSettingsCreated,
        MappedImportWorksheetSettingsUpdated,
        ModelCopied,
        ModelItemsCopied,
        ModelItemLocked,
        ModelItemUnlocked,
        ModelItemApprovalRequested,
        ModelItemApprovalRequestCompleted,
        ModelItemsNotApprovable,
        ModelCreated,
        ModelUpdated,
        NotificationCreated,
        NotificationDataHasIncorrectType,
        NotificationEndDatePrecedesStartDate,
        BothNotificationProgressCountsAndPercentAreSet,
        NotificationsDeleted,
        NotificationsPurged,
        NotificationsRead,
        NotificationsReadAll,
        NotificationsUpdated,
        RelationshipTypeUpdated,
        RelationshipTypeCreated,
        RelationshipTypesCreated,
        RelationshipTypePairUpdated,
        RelationshipTypePairsCreated,
        DocumentCreated,
        DocumentUpdated,
        DocumentCounterpartAssigned,
        DocumentCounterpartUnassigned,
        DocumentCounterpartsDeleted,
        DocumentCounterpartsCreated,
        DocumentCounterpartsUpdated,
        DocumentCounterpartsReassigned,
        DocumentFilePathIsInvalid,
        DocumentModelRootPathIsNotValid,
        DocumentFilePathIsTooLong,
        DocumentFilenameRequiresFileExtension,
        DocumentFilenameContainsInvalidCharacters,
        DocumentFileExtensionNotSupportedForCategory,
        DocumentFileExtensionNotSupportedForCustomCategory,
        DocumentFileExtensionNotSupportedForFileTypeFilter,
        DocumentAlreadyExists,
        DocumentHasCounterparts,
        DocumentTypeLinksDeleted,
        DocumentTypeLinkDoesNotExist,
        DocumentTypeLinkIsInherited,
        InheritedDocumentLinkAlreadyExists,
        DocumentTypeLinkAlreadyExists,
        MetamodelItemIsNotAnObjectType,
        MetamodelItemIsNotARelationshipType,
        DocumentTypeLinkCreated,
        DocumentTypeLinksCreated,
        ObjectTypeUpdated,
        RequestCannotBeProcessed,
        LeadObjectTypeDoesNotExist,
        MemberObjectTypeDoesNotExist,
        DocumentComponentUpdated,
        DocumentComponentsUpdated,
        DocumentComponentDeleted,
        DocumentComponentCreated,
        DocumentComponentsCreated,
        DocumentTypeComponentsUpdated,
        DocumentTypeComponentAlreadyExists,
        DocumentTypeComponentDoesNotExist,
        MetamodelItemHasDocumentComponents,
        DocumentTypeCategoryIsNotVisioType,
        DocumentTypeCategoryIsVisioType,
        DocumentTypeComponentsCreated,
        DocumentTypeComponentsDeleted,
        DocumentTypeRelationshipTypeEndpointsDoNotExist,
        DocumentTypeTemplateUpdated,
        MetamodelEntitiesLocked,
        MetamodelEntityIsLocked,
        MetamodelEntitiesUnlocked,
        RecycleBinPurged,
        EntitiesProtectionStateApplied,
        MetamodelItemApprovalInformationHasChanged,
        DocumentHasDifferentDocumentType,
        ExternalDocumentDoesNotHaveExternalDocumentId,
        LeadRelationshipTypeDoesNotExist,
        IntersectionalRelationshipTypeUsageCannotBeUpdated,
        RelationshipTypeUsageCannotBeUpdated,
        RelationshipTypeUsageIsNotValid,
        MetamodelItemDeactivated,
        MetamodelItemsDeactivated,
        DescriptionIsInvalid,
        RelationshipTypePairActivated,
        RelationshipTypePairsActivated,
        RelationshipTypePairDeactivated,
        RelationshipTypePairsDeactivated,
        MetamodelItemActivated,
        MetamodelItemsActivated,
        FailedToSaveRelationshipTypeConnectedToDetails,
        MemberModelItemIsNotObject,
        LeadModelItemIsNotObject,
        LeadModelItemIsNotRelationship,
        WorkspaceCreated,
        WorkspacesCreated,
        WorkspaceCapacityIsExceeded,
        WorkspaceNameIsNotUnique,
        WorkspaceUpdated,
        WorkspacesUpdated,
        WorkspaceDoesNotExist,
        CommandsValidated,
        WorkspaceDeleted,
        WorkspacesDeleted,
        MetamodelItemNotInWorkspace,
        WorkspaceObjectCreated,
        ObjectIsNotAvailableInWorkspace,
        PermissionDeniedDeleteWorkspace,
        LicenseTypesRecalculated,
        PricingTierIsNotValid,
        PermissionDenied,
        InternalServerError,
        BadRequest,
        NotFound,
        Forbidden,
        RequestAccepted,
        OverrideAll
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsResponseOperationType
    {
        Create,
        Update,
        Delete
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsResponseEntityType
    {
        None,
        Solution,
        ObjectType,
        RelationshipType,
        RelationshipTypePair,
        Attribute,
        AttributeAssignment,
        DocumentType,
        DocumentTypeLink,
        DocumentTypeComponent,
        Model,
        [EnumMember(Value = "Object")]
        ObjectEntity,
        Relationship,
        Document,
        DocumentComponent,
        Workspace,
        Role
    }

    public class OfficeArchitectContractsMessageMessageLevel1
    {
        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("messageDefinition")]
        public JToken MessageDefinition { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsRelationshipResponseDeleteRelationshipResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipDeletedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipDeletedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionRelationshipRelationshipDeletedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionRelationshipRelationshipDeletedLevel2
    {
        [JsonProperty("deletedRelationshipId")]
        public string DeletedRelationshipId { get; set; }
    }

    public class OfficeArchitectContractsRelationshipResponseUpdateRelationshipResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipUpdatedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionRelationshipRelationshipUpdatedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionRelationshipRelationshipUpdatedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionRelationshipRelationshipUpdatedLevel2
    {
        [JsonProperty("relationshipId")]
        public string RelationshipId { get; set; }
    }

    public class OfficeArchitectContractsSwaggerResponseODataPageResponseOfOfficeArchitectContractsODataModelObject
    {
        [JsonProperty("@odata.context")]
        public string Context { get; set; }

        [JsonProperty("value")]
        public OfficeArchitectContractsODataModelObjectLevel0[] Value { get; set; }

        [JsonProperty("@odata.nextLink")]
        public string NextLink { get; set; }

        [JsonProperty("@odata.count")]
        public int Count { get; set; }
    }

    public class OfficeArchitectContractsODataModelObjectLevel0
    {
        [JsonProperty("objectType")]
        public OfficeArchitectContractsODataMetamodelObjectTypeLevel1 ObjectType { get; set; }

        [JsonProperty("lockedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel1 LockedBy { get; set; }

        [JsonProperty("detail")]
        public OfficeArchitectContractsODataModelObjectDetailLevel1 Detail { get; set; }

        [JsonProperty("approvalDetails")]
        public OfficeArchitectContractsODataModelModelItemApprovalDetailsLevel1 ApprovalDetails { get; set; }

        [JsonProperty("model")]
        public OfficeArchitectContractsODataModelModelLevel1 Model { get; set; }

        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel1 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel1 LastModifiedBy { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("lockedOn")]
        public string LockedOn { get; set; }

        [JsonProperty("lockedById")]
        public string LockedById { get; set; }

        [JsonProperty("isApproved")]
        public bool IsApproved { get; set; }

        [JsonProperty("relatedObjects")]
        public OfficeArchitectContractsODataModelRelatedObjectLevel2[] RelatedObjects { get; set; }

        [JsonProperty("attributeValuesFlat")]
        public JToken AttributeValuesFlat { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("lastModifiedDate")]
        public string LastModifiedDate { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("attributeValues")]
        public OfficeArchitectContractsODataModelAttributeValueAttributeValueLevel2[] AttributeValues { get; set; }
    }

    public class OfficeArchitectContractsODataMetamodelObjectTypeLevel1
    {
        [JsonProperty("createdBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 CreatedBy { get; set; }

        [JsonProperty("lastModifiedBy")]
        public OfficeArchitectContractsODataPermissionAuditUserLevel2 LastModifiedBy { get; set; }

        [JsonProperty("parentObjectType")]
        public OfficeArchitectContractsODataMetamodelObjectTypeLevel2 ParentObjectType { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }

        [JsonProperty("parentObjectTypeId")]
        public string ParentObjectTypeId { get; set; }

        [JsonProperty("dateCreated")]
        public string DateCreated { get; set; }

        [JsonProperty("createdById")]
        public string CreatedById { get; set; }

        [JsonProperty("dateLastModified")]
        public string DateLastModified { get; set; }

        [JsonProperty("lastModifiedById")]
        public string LastModifiedById { get; set; }

        [JsonProperty("activeState")]
        public bool ActiveState { get; set; }

        [JsonProperty("isApprovable")]
        public bool IsApprovable { get; set; }

        [JsonProperty("color")]
        public OfficeArchitectContractsMetamodelMetamodelItemSystemColors Color { get; set; }

        [JsonProperty("icon")]
        public OfficeArchitectContractsMetamodelMetamodelItemTitleIcons Icon { get; set; }

        [JsonProperty("solutions")]
        public OfficeArchitectContractsODataMetamodelMetamodelItemSolutionLevel2[] Solutions { get; set; }

        [JsonProperty("attributeAssignments")]
        public OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentLevel2[] AttributeAssignments { get; set; }

        [JsonProperty("attributeAssignmentGroups")]
        public OfficeArchitectContractsODataMetamodelAttributeAttributeAssignmentGroupLevel2[] AttributeAssignmentGroups { get; set; }

        [JsonProperty("childObjectTypes")]
        public OfficeArchitectContractsODataMetamodelObjectTypeLevel2[] ChildObjectTypes { get; set; }

        [JsonProperty("defaultApprovers")]
        public OfficeArchitectContractsODataMetamodelMetamodelItemDefaultApproverLevel2[] DefaultApprovers { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum OfficeArchitectContractsMetamodelMetamodelItemTitleIcons
    {
        None,
        Actor,
        Control,
        OrgUnit,
        Contract,
        Function,
        Process,
        Goal,
        Constraint,
        Requirement,
        Principle,
        Model,
        Visio,
        Visiodoc,
        Powerpoint,
        Powerpointdoc,
        Excel,
        Exceldoc,
        Word,
        Worddoc,
        WorkPackage,
        Listview,
        Hierarchyview,
        Matrixview,
        Collectionview,
        Relationship,
        Solution,
        Repository,
        Site,
        Folder,
        Library,
        Defaultdoc,
        Measure,
        PhysicalDataComponent,
        PhysicalTechnologyComponent,
        Driver,
        Location,
        Product,
        PlatformService,
        Event,
        PhysicalApplicationComponent,
        ServiceQuality,
        Capability,
        LogicalApplicationComponent,
        LogicalTechnologyComponent,
        DataEntity,
        Gap,
        Cog,
        CogOutline,
        Favourites,
        InformationSystemService,
        Assumption,
        BusinessService,
        Objective,
        Role,
        LogicalDataComponent,
        Default,
        Text,
        Choice,
        Number,
        Currency,
        DateTime,
        TrueFalse,
        PersonOrGroup,
        Hyperlink,
        UniqueIdentifier,
        Listviewtiles,
        Listviewcards,
        Listviewvisualization,
        ArchimateResource,
        ArchimateLocation,
        ArchimateTechnologyFunction,
        ArchimateTechnologyProcess,
        ArchimatePathway,
        ArchimatePath,
        ArchimateCommunicationNetwork,
        ArchimateEquipment,
        ArchimateFacility,
        ArchimateMaterial,
        ArchimateSystemSoftware,
        ArchimateTechnologyCollaboration,
        ArchimateBusinessRole,
        ArchimateBusinessActor,
        ArchimateApplicationInterface,
        ArchimateCollaboration,
        ArchimateDevice,
        ArchimateArtifact,
        ArchimateTechnologyService,
        ArchimateTechnologyEvent,
        ArchimateTechnologyInteraction,
        ArchimateNode,
        ArchimateTechnologyInterface,
        ArchimateBusinessInteraction,
        ArchimateApplicationEvent,
        ArchimateBusinessProcess,
        ArchimateBusinessFunction,
        ArchimateBusinessService,
        ArchimateProduct,
        ArchimateContract,
        ArchimateRepresentation,
        ArchimateBusinessObject,
        ArchimateValue,
        ArchimateMeaning,
        ArchimateOutcome,
        ArchimateDriver,
        ArchimateCapability,
        ArchimateCourseOfAction,
        ArchimatePlateau,
        ArchimateGap,
        ArchimateWorkPackage,
        ArchimateImplementationEvent,
        ArchimateStakeholder,
        ArchimateAssessment,
        ArchimateGoal,
        ArchimatePrinciple,
        ArchimateConstaint,
        ArchimateRequirement,
        ArchimateApplicationFunction,
        ArchimateBusinessEvent,
        ArchimateBusinessInterface,
        ArchimateBusinessCollaboration,
        ArchimateDataObject,
        ArchimateApplicationService,
        ArchimateApplicationProcess,
        ArchimateApplicationInteraction,
        User,
        UserGroup,
        Xml,
        UserAlternate,
        UserGroupAlternate,
        RecycleBin
    }

    public class OfficeArchitectContractsODataModelObjectDetailLevel1
    {
        [JsonProperty("originalObjectId")]
        public string OriginalObjectId { get; set; }

        [JsonProperty("currentVersionNumber")]
        public int CurrentVersionNumber { get; set; }

        [JsonProperty("status")]
        public OfficeArchitectContractsModelItemModelItemStatus Status { get; set; }
    }

    public class OfficeArchitectContractsObjectResponseCreateObjectResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectCreatedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectCreatedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionObjectObjectCreatedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionObjectObjectCreatedLevel2
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("modelId")]
        public string ModelId { get; set; }

        [JsonProperty("objectTypeId")]
        public string ObjectTypeId { get; set; }
    }

    public class OfficeArchitectContractsObjectResponseDeleteObjectResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectDeletedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectDeletedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionObjectObjectDeletedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionObjectObjectDeletedLevel2
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectName")]
        public string ObjectName { get; set; }
    }

    public class OfficeArchitectContractsObjectResponseUpdateObjectResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectUpdatedLevel1 SuccessMessage { get; set; }

        [JsonProperty("operationType")]
        public OfficeArchitectContractsResponseOperationType OperationType { get; set; }

        [JsonProperty("entityTypes")]
        public OfficeArchitectContractsResponseEntityType EntityTypes { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionObjectObjectUpdatedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionObjectObjectUpdatedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionObjectObjectUpdatedLevel2
    {
        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class OfficeArchitectContractsNotificationResponseSaveWebhookResponseLevel0
    {
        [JsonProperty("successMessage")]
        public OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionNotificationWebhookSavedLevel1 SuccessMessage { get; set; }

        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("messages")]
        public OfficeArchitectContractsMessageMessageLevel1[] Messages { get; set; }
    }

    public class OfficeArchitectContractsMessageOperationOperationMessageOfOfficeArchitectContractsMessageDefinitionNotificationWebhookSavedLevel1
    {
        [JsonProperty("messageDefinition")]
        public OfficeArchitectContractsMessageDefinitionNotificationWebhookSavedLevel2 MessageDefinition { get; set; }

        [JsonProperty("messageCategory")]
        public OfficeArchitectContractsMessageMessageCategory MessageCategory { get; set; }

        [JsonProperty("messageCode")]
        public OfficeArchitectContractsMessageMessageCode MessageCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }

    public class OfficeArchitectContractsMessageDefinitionNotificationWebhookSavedLevel2
    {
        [JsonProperty("webhookId")]
        public int WebhookId { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Orbusinfinity;

    public partial class WorkflowManagedActions
    {
        public OrbusinfinityActions Orbusinfinity(string connectionId) => new OrbusinfinityActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OrbusinfinityTriggers Orbusinfinity(string connectionId) => new OrbusinfinityTriggers(connectionId);
    }
}