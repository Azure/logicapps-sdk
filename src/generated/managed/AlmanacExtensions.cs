//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Almanac
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlmanacActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<User[], ApiConnectionActionConfiguration> GetGroupsGroupIdUsers(Expression<Func<int>> groupId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_groupId = WorkflowExpression.Compile(groupId, nameof(groupId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<User[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/groups/{0}/users", __workflow_groupId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<User[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Group[], ApiConnectionActionConfiguration> GetGroups(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<Group[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/groups";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<Group[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<User[], ApiConnectionActionConfiguration> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<User[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/users";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<User[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeletePropertiesId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/properties/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Property[], ApiConnectionActionConfiguration> GetProperties(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<Property[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/properties";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<Property[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteHandbooksHandbookIdItemsId(Expression<Func<string>> id, Expression<Func<int>> handbookId)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_handbookId = WorkflowExpression.Compile(handbookId, nameof(handbookId), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/handbooks/{0}/items/{1}", __workflow_handbookId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<HandbookItem[], ApiConnectionActionConfiguration> GetHandbooksHandbookIdItems(Expression<Func<int>> handbookId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_handbookId = WorkflowExpression.Compile(handbookId, nameof(handbookId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<HandbookItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/handbooks/{0}/items", __workflow_handbookId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<HandbookItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Handbook[], ApiConnectionActionConfiguration> GetHandbooks(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<Handbook[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/handbooks";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<Handbook[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder, ApiConnectionActionConfiguration> GetFoldersId(Expression<Func<string>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Folder, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/folders/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Folder>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder[], ApiConnectionActionConfiguration> GetFolders(Expression<Func<int>> page = null, Expression<Func<int>> items = null, Expression<Func<string>> parentFolderId = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            var __workflow_parentFolderId = WorkflowExpression.Compile(parentFolderId, nameof(parentFolderId), required: false);
            return new DeferredBodyAction<Folder[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/folders";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                if (__workflow_parentFolderId != null)
                    callPayload.Queries["parent_folder_id"] = ExpressionConverter.Convert(__workflow_parentFolderId);
                return new ApiConnectionAction<Folder[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocsDocIdAccessesId(Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docs/{0}/accesses/{1}", __workflow_docId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocAccess[], ApiConnectionActionConfiguration> GetDocsDocIdAccesses(Expression<Func<int>> docId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<DocAccess[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docs/{0}/accesses", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<DocAccess[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteDocsDocIdPropertiesId(Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docs/{0}/properties/{1}", __workflow_docId.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocProperty[], ApiConnectionActionConfiguration> GetDocsDocIdProperties(Expression<Func<int>> docId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var __workflow_docId = WorkflowExpression.Compile(docId, nameof(docId), required: true);
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            return new DeferredBodyAction<DocProperty[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docs/{0}/properties", __workflow_docId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                return new ApiConnectionAction<DocProperty[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc, ApiConnectionActionConfiguration> GetDocsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Doc, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/docs/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Doc>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc[], ApiConnectionActionConfiguration> GetDocs(Expression<Func<int>> page = null, Expression<Func<int>> items = null, Expression<Func<string>> folderId = null)
        {
            var __workflow_page = WorkflowExpression.Compile(page, nameof(page), required: false);
            var __workflow_items = WorkflowExpression.Compile(items, nameof(items), required: false);
            var __workflow_folderId = WorkflowExpression.Compile(folderId, nameof(folderId), required: false);
            return new DeferredBodyAction<Doc[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/docs";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["page"] = Convert.ToString(1);
                if (__workflow_page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(__workflow_page);
                callPayload.Queries["items"] = Convert.ToString(20);
                if (__workflow_items != null)
                    callPayload.Queries["items"] = ExpressionConverter.Convert(__workflow_items);
                if (__workflow_folderId != null)
                    callPayload.Queries["folder_id"] = ExpressionConverter.Convert(__workflow_folderId);
                return new ApiConnectionAction<Doc[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Import, ApiConnectionActionConfiguration> GetImportsId(Expression<Func<int>> id)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredBodyAction<Import, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/imports/{0}", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<Import>(callPayload);
            });
        }
    }

    public class AlmanacTriggers([ConnectionName] string connectionId)
    {
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }

    public class Group
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("accessibility")]
        public GroupAccessibilityType Accessibility { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum GroupAccessibilityType
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "closed")]
        Closed,
        [EnumMember(Value = "private")]
        Private
    }

    public class Property
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public PropertyTypeType Type { get; set; }

        [JsonProperty("default_for_articles")]
        public bool DefaultForArticles { get; set; }

        [JsonProperty("meta")]
        public PropertyMeta Meta { get; set; }

        [JsonProperty("property_values")]
        public PropertyValue[] PropertyValues { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyTypeType
    {
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "single_select")]
        SingleSelect,
        [EnumMember(Value = "multi_select")]
        MultiSelect,
        [EnumMember(Value = "checkbox")]
        Checkbox,
        [EnumMember(Value = "document")]
        Document,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "person")]
        Person,
        [EnumMember(Value = "number")]
        Number,
        [EnumMember(Value = "link")]
        Link
    }

    public class PropertyMeta
    {
        [JsonProperty("number_format")]
        public PropertyMetaNumberFormatType NumberFormat { get; set; }

        [JsonProperty("date_format")]
        public PropertyMetaDateFormatType DateFormat { get; set; }

        [JsonProperty("allow_mentioning_multiple_people")]
        public bool AllowMentioningMultiplePeople { get; set; }

        [JsonProperty("notify_person")]
        public bool NotifyPerson { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyMetaNumberFormatType
    {
        [EnumMember(Value = "integer")]
        Integer,
        [EnumMember(Value = "decimal1")]
        Decimal1,
        [EnumMember(Value = "decimal2")]
        Decimal2,
        [EnumMember(Value = "decimal3")]
        Decimal3
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyMetaDateFormatType
    {
        [EnumMember(Value = "all_numeral")]
        AllNumeral,
        [EnumMember(Value = "all_numeral_short")]
        AllNumeralShort,
        [EnumMember(Value = "month_name")]
        MonthName,
        [EnumMember(Value = "month_name_short")]
        MonthNameShort,
        [EnumMember(Value = "month_and_day_name")]
        MonthAndDayName,
        [EnumMember(Value = "month_and_day_name_short")]
        MonthAndDayNameShort,
        [EnumMember(Value = "day_of_month")]
        DayOfMonth
    }

    public class PropertyValue
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("property_id")]
        public int PropertyId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("meta")]
        public PropertyValueMeta Meta { get; set; }
    }

    public class PropertyValueMeta
    {
        [JsonProperty("color")]
        public PropertyValueMetaColorType Color { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PropertyValueMetaColorType
    {
        [EnumMember(Value = "#9CCAFF")]
        _9CCAFF,
        [EnumMember(Value = "#DAE6FF")]
        DAE6FF,
        [EnumMember(Value = "#84E3F8")]
        _84E3F8,
        [EnumMember(Value = "#CDF0FF")]
        CDF0FF,
        [EnumMember(Value = "#75E5A2")]
        _75E5A2,
        [EnumMember(Value = "#D6FFE6")]
        D6FFE6,
        [EnumMember(Value = "#B1BECD")]
        B1BECD,
        [EnumMember(Value = "#E5ECF3")]
        E5ECF3,
        [EnumMember(Value = "#FFA95A")]
        FFA95A,
        [EnumMember(Value = "#FFD6B8")]
        FFD6B8,
        [EnumMember(Value = "#FF99EF")]
        FF99EF,
        [EnumMember(Value = "#FFD6F9")]
        FFD6F9,
        [EnumMember(Value = "#C698FF")]
        C698FF,
        [EnumMember(Value = "#EBDCFF")]
        EBDCFF,
        [EnumMember(Value = "#FF9F9F")]
        FF9F9F,
        [EnumMember(Value = "#FFCBCB")]
        FFCBCB,
        [EnumMember(Value = "#8EF0E4")]
        _8EF0E4,
        [EnumMember(Value = "#D0F8F3")]
        D0F8F3,
        [EnumMember(Value = "#FFD74A")]
        FFD74A,
        [EnumMember(Value = "#FFEFC5")]
        FFEFC5,
        [EnumMember(Value = "#283144")]
        _283144,
        [EnumMember(Value = "#717E97")]
        _717E97,
        [EnumMember(Value = "#0026AD")]
        _0026AD,
        [EnumMember(Value = "#273BF1")]
        _273BF1,
        [EnumMember(Value = "#00659E")]
        _00659E,
        [EnumMember(Value = "#00BAE2")]
        _00BAE2,
        [EnumMember(Value = "#028C3A")]
        _028C3A,
        [EnumMember(Value = "#07BA4F")]
        _07BA4F,
        [EnumMember(Value = "#BB4300")]
        BB4300,
        [EnumMember(Value = "#FA7514")]
        FA7514,
        [EnumMember(Value = "#870061")]
        _870061,
        [EnumMember(Value = "#E43CD5")]
        E43CD5,
        [EnumMember(Value = "#5500BF")]
        _5500BF,
        [EnumMember(Value = "#8626FF")]
        _8626FF,
        [EnumMember(Value = "#870F0F")]
        _870F0F,
        [EnumMember(Value = "#E53535")]
        E53535,
        [EnumMember(Value = "#008575")]
        _008575,
        [EnumMember(Value = "#00BF9D")]
        _00BF9D,
        [EnumMember(Value = "#9C5400")]
        _9C5400,
        [EnumMember(Value = "#F3A100")]
        F3A100
    }

    public class HandbookItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("handbook_id")]
        public int HandbookId { get; set; }

        [JsonProperty("type")]
        public HandbookItemTypeType Type { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("parent_item_id")]
        public int ParentItemId { get; set; }

        [JsonProperty("doc_id")]
        public int DocId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum HandbookItemTypeType
    {
        [EnumMember(Value = "nested_handbook")]
        NestedHandbook,
        [EnumMember(Value = "section")]
        Section,
        [EnumMember(Value = "link")]
        Link,
        [EnumMember(Value = "doc")]
        Doc
    }

    public class Handbook
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Folder
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("parent_folder_id")]
        public int ParentFolderId { get; set; }
    }

    public class DocAccess
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("doc_id")]
        public int DocId { get; set; }

        [JsonProperty("permission")]
        public DocAccessPermissionType Permission { get; set; }

        [JsonProperty("accessor_type")]
        public DocAccessAccessorTypeType AccessorType { get; set; }

        [JsonProperty("accessor_id")]
        public int AccessorId { get; set; }

        [JsonProperty("inherited")]
        public bool Inherited { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocAccessPermissionType
    {
        [EnumMember(Value = "read")]
        Read,
        [EnumMember(Value = "comment")]
        Comment,
        [EnumMember(Value = "edit")]
        Edit,
        [EnumMember(Value = "owner")]
        Owner
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DocAccessAccessorTypeType
    {
        User,
        Group,
        Workspace
    }

    public class DocProperty
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("property")]
        public Property Property { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class Doc
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("workspace_id")]
        public int WorkspaceId { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }
    }

    public class Import
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("status")]
        public ImportStatusType Status { get; set; }

        [JsonProperty("doc")]
        public Doc Doc { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ImportStatusType
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "processing")]
        Processing,
        [EnumMember(Value = "partially_successful")]
        PartiallySuccessful,
        [EnumMember(Value = "successful")]
        Successful,
        [EnumMember(Value = "failed")]
        Failed,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "deleted")]
        Deleted
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Almanac;

    public partial class WorkflowManagedActions
    {
        public AlmanacActions Almanac(string connectionId) => new AlmanacActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AlmanacTriggers Almanac(string connectionId) => new AlmanacTriggers(connectionId);
    }
}