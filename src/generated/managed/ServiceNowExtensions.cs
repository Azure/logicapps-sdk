//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.ServiceNow
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ServiceNowActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction GetAttachmentMetdata([WorkflowExpression] Func<string> sysparmLimit = null, [WorkflowExpression] Func<string> sysparmOffset = null, [WorkflowExpression] Func<string> sysparmQuery = null)
        {
            SourceExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            SourceExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            SourceExpression.Validate(sysparmQuery, nameof(sysparmQuery), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/now/v1/attachment";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_limit"] = Convert.ToString("1000");
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = SourceExpressionConverter.ConvertO(sysparmLimit);
                callPayload.Queries["sysparm_offset"] = Convert.ToString("0");
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = SourceExpressionConverter.ConvertO(sysparmOffset);
                if (sysparmQuery != null)
                    callPayload.Queries["sysparm_query"] = SourceExpressionConverter.ConvertO(sysparmQuery);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachmentFile([WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> tableSysId, [WorkflowExpression] Func<string> fileName, [WorkflowExpression] Func<string> file = null)
        {
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(tableSysId, nameof(tableSysId), required: true);
            SourceExpression.Validate(fileName, nameof(fileName), required: true);
            SourceExpression.Validate(file, nameof(file), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/now/v1/attachment/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["table_name"] = SourceExpressionConverter.ConvertO(tableName);
                callPayload.Queries["table_sys_id"] = SourceExpressionConverter.ConvertO(tableSysId);
                callPayload.Queries["file_name"] = SourceExpressionConverter.ConvertO(fileName);
                callPayload.Body = SourceExpressionConverter.ConvertToken(file);
                return callPayload;
            }

            return new ApiConnectionAction<UploadAttachmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachment([WorkflowExpression] Func<object> attachmentContent, [WorkflowExpression] Func<string> tableName, [WorkflowExpression] Func<string> tableSysId)
        {
            SourceExpression.Validate(attachmentContent, nameof(attachmentContent), required: true);
            SourceExpression.Validate(tableName, nameof(tableName), required: true);
            SourceExpression.Validate(tableSysId, nameof(tableSysId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/now/v1/attachment/upload";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UploadAttachmentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction RetrieveAttachmentMetadata([WorkflowExpression] Func<string> sysId)
        {
            SourceExpression.Validate(sysId, nameof(sysId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction DeleteAttachment([WorkflowExpression] Func<string> sysId)
        {
            SourceExpression.Validate(sysId, nameof(sysId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction RetrieveAttachmentContent([WorkflowExpression] Func<string> sysId)
        {
            SourceExpression.Validate(sysId, nameof(sysId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}/file", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetRecordsResponse> GetRecords([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmQuery = null, [WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<int> sysparmOffset = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            SourceExpression.Validate(tableType, nameof(tableType), required: true);
            SourceExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            SourceExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            SourceExpression.Validate(sysparmQuery, nameof(sysparmQuery), required: false);
            SourceExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            SourceExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            SourceExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = SourceExpressionConverter.ConvertO(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = SourceExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
                if (sysparmQuery != null)
                    callPayload.Queries["sysparm_query"] = SourceExpressionConverter.ConvertO(sysparmQuery);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = SourceExpressionConverter.ConvertO(sysparmLimit);
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = SourceExpressionConverter.ConvertO(sysparmOffset);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = SourceExpressionConverter.ConvertO(sysparmFields);
                return callPayload;
            }

            return new ApiConnectionAction<GetRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> CreateRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<object> body = null, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            SourceExpression.Validate(tableType, nameof(tableType), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            SourceExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            SourceExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = SourceExpressionConverter.ConvertO(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = SourceExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = SourceExpressionConverter.ConvertO(sysparmFields);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SingleRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> GetRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            SourceExpression.Validate(tableType, nameof(tableType), required: true);
            SourceExpression.Validate(sysid, nameof(sysid), required: true);
            SourceExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            SourceExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            SourceExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = SourceExpressionConverter.ConvertO(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = SourceExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = SourceExpressionConverter.ConvertO(sysparmFields);
                return callPayload;
            }

            return new ApiConnectionAction<SingleRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> UpdateRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid, [WorkflowExpression] Func<object> body = null, [WorkflowExpression] Func<bool> sysparmDisplayValue = null, [WorkflowExpression] Func<bool> sysparmExcludeReferenceLink = null, [WorkflowExpression] Func<string> sysparmFields = null)
        {
            SourceExpression.Validate(tableType, nameof(tableType), required: true);
            SourceExpression.Validate(sysid, nameof(sysid), required: true);
            SourceExpression.Validate(body, nameof(body), required: false);
            SourceExpression.Validate(sysparmDisplayValue, nameof(sysparmDisplayValue), required: false);
            SourceExpression.Validate(sysparmExcludeReferenceLink, nameof(sysparmExcludeReferenceLink), required: false);
            SourceExpression.Validate(sysparmFields, nameof(sysparmFields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
                if (sysparmDisplayValue != null)
                    callPayload.Queries["sysparm_display_value"] = SourceExpressionConverter.ConvertO(sysparmDisplayValue);
                callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
                if (sysparmExcludeReferenceLink != null)
                    callPayload.Queries["sysparm_exclude_reference_link"] = SourceExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
                if (sysparmFields != null)
                    callPayload.Queries["sysparm_fields"] = SourceExpressionConverter.ConvertO(sysparmFields);
                callPayload.Body = SourceExpressionConverter.ConvertToken(body);
                return callPayload;
            }

            return new ApiConnectionAction<SingleRecordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction DeleteRecord([WorkflowExpression] Func<string> tableType, [WorkflowExpression] Func<string> sysid)
        {
            SourceExpression.Validate(tableType, nameof(tableType), required: true);
            SourceExpression.Validate(sysid, nameof(sysid), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetTypesResponse> GetRecordTypes()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/now/doc/table/schema";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTypesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogsResponse> GetCatalogs([WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<string> sysparmText = null)
        {
            SourceExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            SourceExpression.Validate(sysparmText, nameof(sysparmText), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sn_sc/servicecatalog/catalogs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = SourceExpressionConverter.ConvertO(sysparmLimit);
                if (sysparmText != null)
                    callPayload.Queries["sysparm_text"] = SourceExpressionConverter.ConvertO(sysparmText);
                return callPayload;
            }

            return new ApiConnectionAction<GetCatalogsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogCategoriesResponse> GetCatalogCategories([WorkflowExpression] Func<string> catalogId, [WorkflowExpression] Func<int> sysparmLimit = null, [WorkflowExpression] Func<int> sysparmOffset = null)
        {
            SourceExpression.Validate(catalogId, nameof(catalogId), required: true);
            SourceExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: false);
            SourceExpression.Validate(sysparmOffset, nameof(sysparmOffset), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/catalogs/{0}/categories", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmLimit != null)
                    callPayload.Queries["sysparm_limit"] = SourceExpressionConverter.ConvertO(sysparmLimit);
                if (sysparmOffset != null)
                    callPayload.Queries["sysparm_offset"] = SourceExpressionConverter.ConvertO(sysparmOffset);
                return callPayload;
            }

            return new ApiConnectionAction<GetCatalogCategoriesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogItemsResponse> GetCatalogItems([WorkflowExpression] Func<int> sysparmLimit, [WorkflowExpression] Func<string> sysparmCategory = null, [WorkflowExpression] Func<string> sysparmText = null, [WorkflowExpression] Func<string> sysparmCatalog = null)
        {
            SourceExpression.Validate(sysparmLimit, nameof(sysparmLimit), required: true);
            SourceExpression.Validate(sysparmCategory, nameof(sysparmCategory), required: false);
            SourceExpression.Validate(sysparmText, nameof(sysparmText), required: false);
            SourceExpression.Validate(sysparmCatalog, nameof(sysparmCatalog), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sn_sc/servicecatalog/items";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (sysparmCategory != null)
                    callPayload.Queries["sysparm_category"] = SourceExpressionConverter.ConvertO(sysparmCategory);
                callPayload.Queries["sysparm_limit"] = SourceExpressionConverter.ConvertO(sysparmLimit);
                if (sysparmText != null)
                    callPayload.Queries["sysparm_text"] = SourceExpressionConverter.ConvertO(sysparmText);
                if (sysparmCatalog != null)
                    callPayload.Queries["sysparm_catalog"] = SourceExpressionConverter.ConvertO(sysparmCatalog);
                return callPayload;
            }

            return new ApiConnectionAction<GetCatalogItemsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogItemResponse> GetCatalogItem([WorkflowExpression] Func<string> sysId)
        {
            SourceExpression.Validate(sysId, nameof(sysId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetCatalogItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<OrderItemResponse> OrderItem([WorkflowExpression] Func<string> sysId, [WorkflowExpression] Func<int> bodysysparmQuantity, [WorkflowExpression] Func<string> bodysysparmRequestedFor = null, [WorkflowExpression] Func<object> bodyvariables = null)
        {
            SourceExpression.Validate(sysId, nameof(sysId), required: true);
            SourceExpression.Validate(bodysysparmQuantity, nameof(bodysysparmQuantity), required: true);
            SourceExpression.Validate(bodysysparmRequestedFor, nameof(bodysysparmRequestedFor), required: false);
            SourceExpression.Validate(bodyvariables, nameof(bodyvariables), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}/order_now", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["sysparm_quantity"] = SourceExpressionConverter.ConvertToken(bodysysparmQuantity);
                if (bodysysparmRequestedFor != null)
                {
                    body["sysparm_requested_for"] = SourceExpressionConverter.ConvertToken(bodysysparmRequestedFor);
                    bodypropCount++;
                }

                if (bodyvariables != null)
                {
                    body["variables"] = SourceExpressionConverter.ConvertToken(bodyvariables);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<OrderItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetArticlesResponse> GetKnowledgeArticles([WorkflowExpression] Func<string> query, [WorkflowExpression] Func<string> fields = null, [WorkflowExpression] Func<int> limit = null, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> kb = null)
        {
            SourceExpression.Validate(query, nameof(query), required: true);
            SourceExpression.Validate(fields, nameof(fields), required: false);
            SourceExpression.Validate(limit, nameof(limit), required: false);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(kb, nameof(kb), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/sn_km_api/knowledge/articles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (fields != null)
                    callPayload.Queries["fields"] = SourceExpressionConverter.ConvertO(fields);
                if (limit != null)
                    callPayload.Queries["limit"] = SourceExpressionConverter.ConvertO(limit);
                callPayload.Queries["query"] = SourceExpressionConverter.ConvertO(query);
                if (filter != null)
                    callPayload.Queries["filter"] = SourceExpressionConverter.ConvertO(filter);
                if (kb != null)
                    callPayload.Queries["kb"] = SourceExpressionConverter.ConvertO(kb);
                return callPayload;
            }

            return new ApiConnectionAction<GetArticlesResponse>(BuildSourceInput);
        }
    }

    public class ServiceNowTriggers([ConnectionName] string connectionId)
    {
    }

    public class UploadAttachmentResponse
    {
        [JsonProperty("result")]
        public UploadAttachmentResponseResultType Result { get; set; }
    }

    public class UploadAttachmentResponseResultType
    {
        [JsonProperty("average_image_color")]
        public string AverageImageColor { get; set; }

        [JsonProperty("compressed")]
        public UploadAttachmentResponseResultTypeCompressedType Compressed { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("created_by_name")]
        public string CreatedByName { get; set; }

        [JsonProperty("download_link")]
        public string DownloadLink { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("image_height")]
        public string ImageHeight { get; set; }

        [JsonProperty("image_width")]
        public string ImageWidth { get; set; }

        [JsonProperty("size_bytes")]
        public string SizeBytes { get; set; }

        [JsonProperty("size_compressed")]
        public string SizeCompressed { get; set; }

        [JsonProperty("sys_created_by")]
        public string SysCreatedBy { get; set; }

        [JsonProperty("sys_created_on")]
        public string SysCreatedOn { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("sys_mod_count")]
        public string SysModCount { get; set; }

        [JsonProperty("sys_tags")]
        public string SysTags { get; set; }

        [JsonProperty("sys_updated_by")]
        public string SysUpdatedBy { get; set; }

        [JsonProperty("sys_updated_on")]
        public string SysUpdatedOn { get; set; }

        [JsonProperty("table_name")]
        public string TableName { get; set; }

        [JsonProperty("table_sys_id")]
        public string TableSysId { get; set; }

        [JsonProperty("updated_by_name")]
        public string UpdatedByName { get; set; }
    }

    public enum UploadAttachmentResponseResultTypeCompressedType
    {
        [EnumMember(Value = "true")]
        True,
        [EnumMember(Value = "false")]
        False
    }

    public class GetRecordsResponse
    {
        [JsonProperty("result")]
        public JToken[] Result { get; set; }
    }

    public class SingleRecordResponse
    {
        [JsonProperty("result")]
        public JToken Result { get; set; }
    }

    public class GetTypesResponse
    {
        [JsonProperty("result")]
        public GetTypesResponseResultTypeItem[] Result { get; set; }
    }

    public class GetTypesResponseResultTypeItem
    {
        [JsonProperty("label")]
        public string DisplayName { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class GetCatalogsResponse
    {
        [JsonProperty("result")]
        public GetCatalogsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogsResponseResultTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("has_categories")]
        public bool HasCategories { get; set; }

        [JsonProperty("has_items")]
        public bool HasItems { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("desktop_image")]
        public string DesktopImage { get; set; }
    }

    public class GetCatalogCategoriesResponse
    {
        [JsonProperty("result")]
        public GetCatalogCategoriesResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogCategoriesResponseResultTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("full_description")]
        public string FullDescription { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("header_icon")]
        public string HeaderIcon { get; set; }

        [JsonProperty("homepage_image")]
        public string HomepageImage { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("subcategories")]
        public GetCatalogCategoriesResponseResultTypeItemSubcategoriesTypeItem[] Subcategories { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }
    }

    public class GetCatalogCategoriesResponseResultTypeItemSubcategoriesTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemsResponse
    {
        [JsonProperty("result")]
        public GetCatalogItemsResponseResultTypeItem[] Result { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItem
    {
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("kb_article")]
        public string KbArticle { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("mandatory_attachment")]
        public bool MandatoryAttachment { get; set; }

        [JsonProperty("request_method")]
        public string RequestMethod { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visible_standalone")]
        public bool VisibleStandalone { get; set; }

        [JsonProperty("local_currency")]
        public string LocalCurrency { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("recurring_frequency")]
        public string RecurringFrequency { get; set; }

        [JsonProperty("price_currency")]
        public string PriceCurrency { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("make_item_non_conversational")]
        public bool MakeItemNonConversational { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("show_price")]
        public bool ShowPrice { get; set; }

        [JsonProperty("recurring_price")]
        public string RecurringPrice { get; set; }

        [JsonProperty("show_quantity")]
        public bool ShowQuantity { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("recurring_price_currency")]
        public string RecurringPriceCurrency { get; set; }

        [JsonProperty("localized_price")]
        public string LocalizedPrice { get; set; }

        [JsonProperty("catalogs")]
        public GetCatalogItemsResponseResultTypeItemCatalogsTypeItem[] Catalogs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("localized_recurring_price")]
        public string LocalizedRecurringPrice { get; set; }

        [JsonProperty("show_wishlist")]
        public bool ShowWishlist { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemsResponseResultTypeItemCategoryType Category { get; set; }

        [JsonProperty("turn_off_nowassist_conversation")]
        public bool TurnOffNowassistConversation { get; set; }

        [JsonProperty("show_delivery_time")]
        public bool ShowDeliveryTime { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItemCatalogsTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemsResponseResultTypeItemCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponse
    {
        [JsonProperty("result")]
        public GetCatalogItemResponseResultType Result { get; set; }
    }

    public class GetCatalogItemResponseResultType
    {
        [JsonProperty("short_description")]
        public string ShortDescription { get; set; }

        [JsonProperty("kb_article")]
        public string KbArticle { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("availability")]
        public string Availability { get; set; }

        [JsonProperty("mandatory_attachment")]
        public bool MandatoryAttachment { get; set; }

        [JsonProperty("request_method")]
        public string RequestMethod { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("visible_standalone")]
        public bool VisibleStandalone { get; set; }

        [JsonProperty("sys_class_name")]
        public string SysClassName { get; set; }

        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("order")]
        public int Order { get; set; }

        [JsonProperty("make_item_non_conversational")]
        public bool MakeItemNonConversational { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("show_price")]
        public bool ShowPrice { get; set; }

        [JsonProperty("show_quantity")]
        public bool ShowQuantity { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("catalogs")]
        public GetCatalogItemResponseResultTypeCatalogsTypeItem[] Catalogs { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("show_wishlist")]
        public bool ShowWishlist { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemResponseResultTypeCategoryType Category { get; set; }

        [JsonProperty("turn_off_nowassist_conversation")]
        public bool TurnOffNowassistConversation { get; set; }

        [JsonProperty("show_delivery_time")]
        public bool ShowDeliveryTime { get; set; }

        [JsonProperty("categories")]
        public GetCatalogItemResponseResultTypeCategoriesTypeItem[] Categories { get; set; }

        [JsonProperty("variables")]
        public JToken[] Variables { get; set; }

        [JsonProperty("ui_policy")]
        public JToken[] UiPolicy { get; set; }

        [JsonProperty("client_script")]
        public GetCatalogItemResponseResultTypeClientScriptType ClientScript { get; set; }

        [JsonProperty("data_lookup")]
        public JToken[] DataLookup { get; set; }

        [JsonProperty("variablesSchema")]
        public JToken VariablesSchema { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCatalogsTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoriesTypeItem
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("category")]
        public GetCatalogItemResponseResultTypeCategoriesTypeItemCategoryType Category { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeCategoriesTypeItemCategoryType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetCatalogItemResponseResultTypeClientScriptType
    {
        [JsonProperty("onChange")]
        public JToken[] OnChange { get; set; }

        [JsonProperty("onSubmit")]
        public JToken[] OnSubmit { get; set; }

        [JsonProperty("onLoad")]
        public JToken[] OnLoad { get; set; }
    }

    public class OrderItemResponse
    {
        [JsonProperty("result")]
        public OrderItemResponseResultType Result { get; set; }
    }

    public class OrderItemResponseResultType
    {
        [JsonProperty("sys_id")]
        public string SysId { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("request_number")]
        public string RequestNumber { get; set; }

        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        [JsonProperty("table")]
        public string Table { get; set; }
    }

    public class GetArticlesResponse
    {
        [JsonProperty("meta")]
        public GetArticlesResponseMetaType Meta { get; set; }

        [JsonProperty("articles")]
        public GetArticlesResponseArticlesTypeItem[] Articles { get; set; }
    }

    public class GetArticlesResponseMetaType
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("end")]
        public int End { get; set; }

        [JsonProperty("fields")]
        public string Fields { get; set; }

        [JsonProperty("filter")]
        public string Filter { get; set; }

        [JsonProperty("ts_query_id")]
        public string Kb { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("query")]
        public string Query { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("status")]
        public GetArticlesResponseMetaTypeStatusType Status { get; set; }
    }

    public class GetArticlesResponseMetaTypeStatusType
    {
        [JsonProperty("code")]
        public string Status { get; set; }
    }

    public class GetArticlesResponseArticlesTypeItem
    {
        [JsonProperty("fields")]
        public GetArticlesResponseArticlesTypeItemFieldsType Fields { get; set; }
        public string Link { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("rank")]
        public double Rank { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("snippet")]
        public string Snippet { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }

    public class GetArticlesResponseArticlesTypeItemFieldsType
    {
        [JsonProperty("display_value")]
        public string DisplayValue { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.ServiceNow;

    public partial class WorkflowManagedActions
    {
        public ServiceNowActions ServiceNow(string connectionId) => new ServiceNowActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ServiceNowTriggers ServiceNow(string connectionId) => new ServiceNowTriggers(connectionId);
    }
}