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
        public IWorkflowAction GetAttachmentMetdata(Expression<Func<string>> sysparmLimit = null, Expression<Func<string>> sysparmOffset = null, Expression<Func<string>> sysparmQuery = null)
        {
            var apiCallPath = "/api/now/v1/attachment";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sysparm_limit"] = Convert.ToString("1000");
            if (sysparmLimit != null)
                callPayload.Queries["sysparm_limit"] = CSharpExpressionConverter.ConvertO(sysparmLimit);
            callPayload.Queries["sysparm_offset"] = Convert.ToString("0");
            if (sysparmOffset != null)
                callPayload.Queries["sysparm_offset"] = CSharpExpressionConverter.ConvertO(sysparmOffset);
            if (sysparmQuery != null)
                callPayload.Queries["sysparm_query"] = CSharpExpressionConverter.ConvertO(sysparmQuery);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachmentFile(Expression<Func<string>> tableName, Expression<Func<string>> tableSysId, Expression<Func<string>> fileName, Expression<Func<string>> file = null)
        {
            var apiCallPath = "/api/now/v1/attachment/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["table_name"] = CSharpExpressionConverter.ConvertO(tableName);
            callPayload.Queries["table_sys_id"] = CSharpExpressionConverter.ConvertO(tableSysId);
            callPayload.Queries["file_name"] = CSharpExpressionConverter.ConvertO(fileName);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(file);
            return new ApiConnectionAction<UploadAttachmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<UploadAttachmentResponse> UploadAttachment(Expression<Func<object>> attachmentContent, Expression<Func<string>> tableName, Expression<Func<string>> tableSysId)
        {
            var apiCallPath = "/api/now/v1/attachment/upload";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UploadAttachmentResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction RetrieveAttachmentMetadata(Expression<Func<string>> sysId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction DeleteAttachment(Expression<Func<string>> sysId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction RetrieveAttachmentContent(Expression<Func<string>> sysId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v1/attachment/{0}/file", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetRecordsResponse> GetRecords(Expression<Func<string>> tableType, Expression<Func<bool>> sysparmDisplayValue = null, Expression<Func<bool>> sysparmExcludeReferenceLink = null, Expression<Func<string>> sysparmQuery = null, Expression<Func<int>> sysparmLimit = null, Expression<Func<int>> sysparmOffset = null, Expression<Func<string>> sysparmFields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
            if (sysparmDisplayValue != null)
                callPayload.Queries["sysparm_display_value"] = CSharpExpressionConverter.ConvertO(sysparmDisplayValue);
            callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
            if (sysparmExcludeReferenceLink != null)
                callPayload.Queries["sysparm_exclude_reference_link"] = CSharpExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
            if (sysparmQuery != null)
                callPayload.Queries["sysparm_query"] = CSharpExpressionConverter.ConvertO(sysparmQuery);
            if (sysparmLimit != null)
                callPayload.Queries["sysparm_limit"] = CSharpExpressionConverter.ConvertO(sysparmLimit);
            if (sysparmOffset != null)
                callPayload.Queries["sysparm_offset"] = CSharpExpressionConverter.ConvertO(sysparmOffset);
            if (sysparmFields != null)
                callPayload.Queries["sysparm_fields"] = CSharpExpressionConverter.ConvertO(sysparmFields);
            return new ApiConnectionAction<GetRecordsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> CreateRecord(Expression<Func<string>> tableType, Expression<Func<object>> body = null, Expression<Func<bool>> sysparmDisplayValue = null, Expression<Func<bool>> sysparmExcludeReferenceLink = null, Expression<Func<string>> sysparmFields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
            if (sysparmDisplayValue != null)
                callPayload.Queries["sysparm_display_value"] = CSharpExpressionConverter.ConvertO(sysparmDisplayValue);
            callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
            if (sysparmExcludeReferenceLink != null)
                callPayload.Queries["sysparm_exclude_reference_link"] = CSharpExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
            if (sysparmFields != null)
                callPayload.Queries["sysparm_fields"] = CSharpExpressionConverter.ConvertO(sysparmFields);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<SingleRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> GetRecord(Expression<Func<string>> tableType, Expression<Func<string>> sysid, Expression<Func<bool>> sysparmDisplayValue = null, Expression<Func<bool>> sysparmExcludeReferenceLink = null, Expression<Func<string>> sysparmFields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
            if (sysparmDisplayValue != null)
                callPayload.Queries["sysparm_display_value"] = CSharpExpressionConverter.ConvertO(sysparmDisplayValue);
            callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
            if (sysparmExcludeReferenceLink != null)
                callPayload.Queries["sysparm_exclude_reference_link"] = CSharpExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
            if (sysparmFields != null)
                callPayload.Queries["sysparm_fields"] = CSharpExpressionConverter.ConvertO(sysparmFields);
            return new ApiConnectionAction<SingleRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<SingleRecordResponse> UpdateRecord(Expression<Func<string>> tableType, Expression<Func<string>> sysid, Expression<Func<object>> body = null, Expression<Func<bool>> sysparmDisplayValue = null, Expression<Func<bool>> sysparmExcludeReferenceLink = null, Expression<Func<string>> sysparmFields = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["sysparm_display_value"] = Convert.ToString(false);
            if (sysparmDisplayValue != null)
                callPayload.Queries["sysparm_display_value"] = CSharpExpressionConverter.ConvertO(sysparmDisplayValue);
            callPayload.Queries["sysparm_exclude_reference_link"] = Convert.ToString(true);
            if (sysparmExcludeReferenceLink != null)
                callPayload.Queries["sysparm_exclude_reference_link"] = CSharpExpressionConverter.ConvertO(sysparmExcludeReferenceLink);
            if (sysparmFields != null)
                callPayload.Queries["sysparm_fields"] = CSharpExpressionConverter.ConvertO(sysparmFields);
            callPayload.Body = CSharpExpressionConverter.ConvertToken(body);
            return new ApiConnectionAction<SingleRecordResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IWorkflowAction DeleteRecord(Expression<Func<string>> tableType, Expression<Func<string>> sysid)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/now/v2/table/{0}/{1}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(tableType, 1), CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetTypesResponse> GetRecordTypes()
        {
            var apiCallPath = "/api/now/doc/table/schema";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTypesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogsResponse> GetCatalogs(Expression<Func<int>> sysparmLimit = null, Expression<Func<string>> sysparmText = null)
        {
            var apiCallPath = "/api/sn_sc/servicecatalog/catalogs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sysparmLimit != null)
                callPayload.Queries["sysparm_limit"] = CSharpExpressionConverter.ConvertO(sysparmLimit);
            if (sysparmText != null)
                callPayload.Queries["sysparm_text"] = CSharpExpressionConverter.ConvertO(sysparmText);
            return new ApiConnectionAction<GetCatalogsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogCategoriesResponse> GetCatalogCategories(Expression<Func<string>> catalogId, Expression<Func<int>> sysparmLimit = null, Expression<Func<int>> sysparmOffset = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/catalogs/{0}/categories", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(catalogId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sysparmLimit != null)
                callPayload.Queries["sysparm_limit"] = CSharpExpressionConverter.ConvertO(sysparmLimit);
            if (sysparmOffset != null)
                callPayload.Queries["sysparm_offset"] = CSharpExpressionConverter.ConvertO(sysparmOffset);
            return new ApiConnectionAction<GetCatalogCategoriesResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogItemsResponse> GetCatalogItems(Expression<Func<int>> sysparmLimit, Expression<Func<string>> sysparmCategory = null, Expression<Func<string>> sysparmText = null, Expression<Func<string>> sysparmCatalog = null)
        {
            var apiCallPath = "/api/sn_sc/servicecatalog/items";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (sysparmCategory != null)
                callPayload.Queries["sysparm_category"] = CSharpExpressionConverter.ConvertO(sysparmCategory);
            callPayload.Queries["sysparm_limit"] = CSharpExpressionConverter.ConvertO(sysparmLimit);
            if (sysparmText != null)
                callPayload.Queries["sysparm_text"] = CSharpExpressionConverter.ConvertO(sysparmText);
            if (sysparmCatalog != null)
                callPayload.Queries["sysparm_catalog"] = CSharpExpressionConverter.ConvertO(sysparmCatalog);
            return new ApiConnectionAction<GetCatalogItemsResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetCatalogItemResponse> GetCatalogItem(Expression<Func<string>> sysId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetCatalogItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<OrderItemResponse> OrderItem(Expression<Func<string>> sysId, Expression<Func<int>> bodysysparmQuantity, Expression<Func<string>> bodysysparmRequestedFor = null, Expression<Func<object>> bodyvariables = null)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/api/sn_sc/servicecatalog/items/{0}/order_now", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(sysId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["sysparm_quantity"] = CSharpExpressionConverter.ConvertToken(bodysysparmQuantity);
            if (bodysysparmRequestedFor != null)
            {
                body["sysparm_requested_for"] = CSharpExpressionConverter.ConvertToken(bodysysparmRequestedFor);
                bodypropCount++;
            }

            if (bodyvariables != null)
            {
                body["variables"] = CSharpExpressionConverter.ConvertToken(bodyvariables);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<OrderItemResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "service-now")]
        public IBodyWorkflowAction<GetArticlesResponse> GetKnowledgeArticles(Expression<Func<string>> query, Expression<Func<string>> fields = null, Expression<Func<int>> limit = null, Expression<Func<string>> filter = null, Expression<Func<string>> kb = null)
        {
            var apiCallPath = "/api/sn_km_api/knowledge/articles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (fields != null)
                callPayload.Queries["fields"] = CSharpExpressionConverter.ConvertO(fields);
            if (limit != null)
                callPayload.Queries["limit"] = CSharpExpressionConverter.ConvertO(limit);
            callPayload.Queries["query"] = CSharpExpressionConverter.ConvertO(query);
            if (filter != null)
                callPayload.Queries["filter"] = CSharpExpressionConverter.ConvertO(filter);
            if (kb != null)
                callPayload.Queries["kb"] = CSharpExpressionConverter.ConvertO(kb);
            return new ApiConnectionAction<GetArticlesResponse>(callPayload);
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