//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Almanac
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AlmanacActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<User[]> GetGroupsGroupIdUsers(Expression<Func<int>> groupId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = String.Format("/groups/{0}/users", ExpressionConverter.ConvertWithUrlEncoding(groupId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<User[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Group[]> GetGroups(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = "/groups";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<Group[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<User[]> GetUsers(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = "/users";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<User[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction DeletePropertiesId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/properties/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Property[]> GetProperties(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = "/properties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<Property[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Property> PostProperties(Expression<Func<string>> propertyName, Expression<Func<propertyTypeInput>> propertyType, Expression<Func<string[]>> propertyPropertyValuesValue, Expression<Func<bool>> propertyDefaultForArticles = null, Expression<Func<propertyMetaDateFormatInput>> propertyMetaDateFormat = null, Expression<Func<propertyMetaNumberFormatInput>> propertyMetaNumberFormat = null, Expression<Func<bool>> propertyMetaAllowMentioningMultiplePeople = null, Expression<Func<bool>> propertyMetaNotifyPerson = null, Expression<Func<propertyPropertyValuesMetaColorInputItem[]>> propertyPropertyValuesMetaColor = null)
        {
            var apiCallPath = "/properties";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Property>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction DeleteHandbooksHandbookIdItemsId(Expression<Func<string>> id, Expression<Func<int>> handbookId)
        {
            var apiCallPath = String.Format("/handbooks/{0}/items/{1}", ExpressionConverter.ConvertWithUrlEncoding(handbookId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<HandbookItem[]> GetHandbooksHandbookIdItems(Expression<Func<int>> handbookId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = String.Format("/handbooks/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(handbookId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<HandbookItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<HandbookItem> PostHandbooksHandbookIdItems(Expression<Func<handbookItemTypeInput>> handbookItemType, Expression<Func<int>> handbookItemDocId, Expression<Func<string>> handbookItemTitle, Expression<Func<string>> handbookItemUrl, Expression<Func<int>> handbookId, Expression<Func<int>> handbookItemPosition = null, Expression<Func<int>> handbookItemParentItemId = null)
        {
            var apiCallPath = String.Format("/handbooks/{0}/items", ExpressionConverter.ConvertWithUrlEncoding(handbookId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<HandbookItem>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Handbook[]> GetHandbooks(Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = "/handbooks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<Handbook[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction PostFilesMove(Expression<Func<int[]>> folderIds = null, Expression<Func<int[]>> docIds = null, Expression<Func<int>> destinationFolderId = null, Expression<Func<int>> destinationWorkspaceId = null)
        {
            var apiCallPath = "/files/move";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder> GetFoldersId(Expression<Func<string>> id)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder> PutFoldersId(Expression<Func<string>> folderTitle, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder> PatchFoldersId(Expression<Func<string>> folderTitle, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/folders/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder[]> GetFolders(Expression<Func<int>> page = null, Expression<Func<int>> items = null, Expression<Func<string>> parentFolderId = null)
        {
            var apiCallPath = "/folders";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            if (parentFolderId != null)
                callPayload.Queries["parent_folder_id"] = ExpressionConverter.Convert(parentFolderId);
            return new ApiConnectionAction<Folder[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Folder> PostFolders(Expression<Func<string>> folderTitle, Expression<Func<int>> folderParentFolderId = null)
        {
            var apiCallPath = "/folders";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Folder>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction DeleteDocsDocIdAccessesId(Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}/accesses/{1}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocAccess> PutDocsDocIdAccessesId(Expression<Func<accessPermissionInput>> accessPermission, Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}/accesses/{1}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocAccess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocAccess> PatchDocsDocIdAccessesId(Expression<Func<accessPermissionInput>> accessPermission, Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}/accesses/{1}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocAccess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocAccess[]> GetDocsDocIdAccesses(Expression<Func<int>> docId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = String.Format("/docs/{0}/accesses", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<DocAccess[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocAccess> PostDocsDocIdAccesses(Expression<Func<accessPermissionInput>> accessPermission, Expression<Func<accessAccessorTypeInput>> accessAccessorType, Expression<Func<int>> accessAccessorId, Expression<Func<int>> docId)
        {
            var apiCallPath = String.Format("/docs/{0}/accesses", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocAccess>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IWorkflowAction DeleteDocsDocIdPropertiesId(Expression<Func<int>> docId, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}/properties/{1}", ExpressionConverter.ConvertWithUrlEncoding(docId, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocProperty[]> GetDocsDocIdProperties(Expression<Func<int>> docId, Expression<Func<int>> page = null, Expression<Func<int>> items = null)
        {
            var apiCallPath = String.Format("/docs/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            return new ApiConnectionAction<DocProperty[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<DocProperty> PostDocsDocIdProperties(Expression<Func<int>> propertyId, Expression<Func<int>> docId, Expression<Func<string>> value = null)
        {
            var apiCallPath = String.Format("/docs/{0}/properties", ExpressionConverter.ConvertWithUrlEncoding(docId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DocProperty>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc> GetDocsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Doc>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc> PutDocsId(Expression<Func<string>> docTitle, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "put";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Doc>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc> PatchDocsId(Expression<Func<string>> docTitle, Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/docs/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "patch";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Doc>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Doc[]> GetDocs(Expression<Func<int>> page = null, Expression<Func<int>> items = null, Expression<Func<string>> folderId = null)
        {
            var apiCallPath = "/docs";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["page"] = Convert.ToString(1);
            if (page != null)
                callPayload.Queries["page"] = ExpressionConverter.Convert(page);
            callPayload.Queries["items"] = Convert.ToString(20);
            if (items != null)
                callPayload.Queries["items"] = ExpressionConverter.Convert(items);
            if (folderId != null)
                callPayload.Queries["folder_id"] = ExpressionConverter.Convert(folderId);
            return new ApiConnectionAction<Doc[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Import> PostImports(Expression<Func<object>> importFile, Expression<Func<importSourceInput>> importSource)
        {
            var apiCallPath = "/imports";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Import>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "almanac")]
        public IBodyWorkflowAction<Import> GetImportsId(Expression<Func<int>> id)
        {
            var apiCallPath = String.Format("/imports/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<Import>(callPayload);
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

    public enum propertyTypeInput
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

    public enum propertyMetaDateFormatInput
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

    public enum propertyMetaNumberFormatInput
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

    public enum propertyPropertyValuesMetaColorInputItem
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

    public enum handbookItemTypeInput
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

    public enum DocAccessAccessorTypeType
    {
        User,
        Group,
        Workspace
    }

    public enum accessPermissionInput
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

    public enum accessAccessorTypeInput
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

    public enum importSourceInput
    {
        [EnumMember(Value = "md")]
        Md,
        [EnumMember(Value = "docx")]
        Docx,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "notion")]
        Notion,
        [EnumMember(Value = "confluence")]
        Confluence
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