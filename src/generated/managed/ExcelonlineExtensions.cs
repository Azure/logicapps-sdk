//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Excelonline
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExcelonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<TableMetadata, ApiConnectionActionConfiguration> CreateTable(Expression<Func<string>> @file, Expression<Func<string>> tabletableRange, Expression<Func<string>> tabletableName = null, Expression<Func<string>> tablecolumnsNames = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_tabletableRange = WorkflowExpression.Compile(tabletableRange, nameof(tabletableRange), required: true);
            var __workflow_tabletableName = WorkflowExpression.Compile(tabletableName, nameof(tabletableName), required: false);
            var __workflow_tablecolumnsNames = WorkflowExpression.Compile(tablecolumnsNames, nameof(tablecolumnsNames), required: false);
            return new DeferredBodyAction<TableMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                var table = new JObject();
                var tablepropCount = 0;
                if (__workflow_tabletableName != null)
                {
                    table["TableName"] = ExpressionConverter.ConvertO(__workflow_tabletableName);
                    tablepropCount++;
                }

                tablepropCount++;
                table["Range"] = ExpressionConverter.ConvertO(__workflow_tabletableRange);
                if (__workflow_tablecolumnsNames != null)
                {
                    table["ColumnsNames"] = ExpressionConverter.ConvertO(__workflow_tablecolumnsNames);
                    tablepropCount++;
                }

                if (tablepropCount > 0)
                {
                    callPayload.Body = table;
                }

                return new ApiConnectionAction<TableMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IWorkflowAction<ApiConnectionActionConfiguration> CreateIdColumn(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<string>> idColumn = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables/{2}/createIdColumn", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = Convert.ToString("__PowerAppsId__");
                if (__workflow_idColumn != null)
                    callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                callPayload.Queries["populateColumn"] = Convert.ToString(false);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<ItemsList, ApiConnectionActionConfiguration> GetItems(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<ItemsList, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables/{2}/items", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (__workflow_filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(__workflow_filter);
                if (__workflow_orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(__workflow_orderby);
                if (__workflow_top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(__workflow_top);
                if (__workflow_skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(__workflow_skip);
                if (__workflow_select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(__workflow_select);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> GetItem(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IWorkflowAction<ApiConnectionActionConfiguration> DeleteItem(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> PatchItem(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id, Expression<Func<itemInput>> item = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1), __workflow_id.WithUrlEncoding(2)));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<GetAllWorksheetsResponse, ApiConnectionActionConfiguration> GetAllWorksheets(Expression<Func<string>> @file)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<GetAllWorksheetsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                return new ApiConnectionAction<GetAllWorksheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<WorksheetMetadata, ApiConnectionActionConfiguration> CreateWorksheet(Expression<Func<string>> @file, Expression<Func<string>> bodyname = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<WorksheetMetadata, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(__workflow_bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<WorksheetMetadata>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<GetTablesResponse, ApiConnectionActionConfiguration> GetTables(Expression<Func<string>> @file)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            return new DeferredBodyAction<GetTablesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/tables", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item, ApiConnectionActionConfiguration> AddRow(Expression<Func<string>> @file, Expression<Func<string>> table, Expression<Func<itemInput>> item = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_file = WorkflowExpression.Compile(@file, nameof(@file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/codeless/v1.2/drives/{0}/items/{1}/workbook/tables/{2}/rows", WorkflowExpression.Literal("me").WithUrlEncoding(1), __workflow_file.WithUrlEncoding(1), __workflow_table.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }
    }

    public class ExcelonlineTriggers([ConnectionName] string connectionId)
    {
    }

    public class TableMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("x-ms-permission")]
        public string XMsPermission { get; set; }

        [JsonProperty("x-ms-capabilities")]
        public TableCapabilitiesMetadata XMsCapabilities { get; set; }

        [JsonProperty("schema")]
        public JToken Schema { get; set; }

        [JsonProperty("referencedEntities")]
        public JToken ReferencedEntities { get; set; }

        [JsonProperty("webUrl")]
        public string WebUrl { get; set; }
    }

    public class TableCapabilitiesMetadata
    {
        [JsonProperty("sortRestrictions")]
        public TableSortRestrictionsMetadata SortRestrictions { get; set; }

        [JsonProperty("filterRestrictions")]
        public TableFilterRestrictionsMetadata FilterRestrictions { get; set; }

        [JsonProperty("selectRestrictions")]
        public TableSelectRestrictionsMetadata SelectRestrictions { get; set; }

        [JsonProperty("isOnlyServerPagable")]
        public bool IsOnlyServerPagable { get; set; }

        [JsonProperty("filterFunctionSupport")]
        public TableCapabilitiesMetadataFilterFunctionSupportTypeItem[] FilterFunctionSupport { get; set; }

        [JsonProperty("serverPagingOptions")]
        public TableCapabilitiesMetadataServerPagingOptionsTypeItem[] ServerPagingOptions { get; set; }
    }

    public class TableSortRestrictionsMetadata
    {
        [JsonProperty("sortable")]
        public bool Sortable { get; set; }

        [JsonProperty("unsortableProperties")]
        public string[] UnsortableProperties { get; set; }

        [JsonProperty("ascendingOnlyProperties")]
        public string[] AscendingOnlyProperties { get; set; }
    }

    public class TableFilterRestrictionsMetadata
    {
        [JsonProperty("filterable")]
        public bool Filterable { get; set; }

        [JsonProperty("nonFilterableProperties")]
        public string[] NonFilterableProperties { get; set; }

        [JsonProperty("requiredProperties")]
        public string[] RequiredProperties { get; set; }
    }

    public class TableSelectRestrictionsMetadata
    {
        [JsonProperty("selectable")]
        public bool Selectable { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableCapabilitiesMetadataFilterFunctionSupportTypeItem
    {
        [EnumMember(Value = "eq")]
        Eq,
        [EnumMember(Value = "ne")]
        Ne,
        [EnumMember(Value = "gt")]
        Gt,
        [EnumMember(Value = "ge")]
        Ge,
        [EnumMember(Value = "lt")]
        Lt,
        [EnumMember(Value = "le")]
        Le,
        [EnumMember(Value = "and")]
        And,
        [EnumMember(Value = "or")]
        Or,
        [EnumMember(Value = "contains")]
        Contains,
        [EnumMember(Value = "startswith")]
        Startswith,
        [EnumMember(Value = "endswith")]
        Endswith,
        [EnumMember(Value = "length")]
        Length,
        [EnumMember(Value = "indexof")]
        Indexof,
        [EnumMember(Value = "replace")]
        Replace,
        [EnumMember(Value = "substring")]
        Substring,
        [EnumMember(Value = "substringof")]
        Substringof,
        [EnumMember(Value = "tolower")]
        Tolower,
        [EnumMember(Value = "toupper")]
        Toupper,
        [EnumMember(Value = "trim")]
        Trim,
        [EnumMember(Value = "concat")]
        Concat,
        [EnumMember(Value = "year")]
        Year,
        [EnumMember(Value = "month")]
        Month,
        [EnumMember(Value = "day")]
        Day,
        [EnumMember(Value = "hour")]
        Hour,
        [EnumMember(Value = "minute")]
        Minute,
        [EnumMember(Value = "second")]
        Second,
        [EnumMember(Value = "date")]
        Date,
        [EnumMember(Value = "time")]
        Time,
        [EnumMember(Value = "now")]
        Now,
        [EnumMember(Value = "totaloffsetminutes")]
        Totaloffsetminutes,
        [EnumMember(Value = "totalseconds")]
        Totalseconds,
        [EnumMember(Value = "floor")]
        Floor,
        [EnumMember(Value = "ceiling")]
        Ceiling,
        [EnumMember(Value = "round")]
        Round,
        [EnumMember(Value = "not")]
        Not,
        [EnumMember(Value = "negate")]
        Negate,
        [EnumMember(Value = "add")]
        Add,
        [EnumMember(Value = "sub")]
        Sub,
        [EnumMember(Value = "mul")]
        Mul,
        [EnumMember(Value = "div")]
        Div,
        [EnumMember(Value = "mod")]
        Mod,
        [EnumMember(Value = "sum")]
        Sum,
        [EnumMember(Value = "min")]
        Min,
        [EnumMember(Value = "max")]
        Max,
        [EnumMember(Value = "average")]
        Average,
        [EnumMember(Value = "countdistinct")]
        Countdistinct,
        [EnumMember(Value = "null")]
        Null
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum TableCapabilitiesMetadataServerPagingOptionsTypeItem
    {
        [EnumMember(Value = "top")]
        Top,
        [EnumMember(Value = "skiptoken")]
        Skiptoken
    }

    public class ItemsList
    {
        [JsonProperty("value")]
        public Item[] Value { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dateTimeFormatInput
    {
        [EnumMember(Value = "Serial Number")]
        SerialNumber,
        [EnumMember(Value = "ISO 8601")]
        ISO8601
    }

    public class itemInput
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class GetAllWorksheetsResponse
    {
        [JsonProperty("value")]
        public WorksheetMetadata[] Value { get; set; }
    }

    public class WorksheetMetadata
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }
    }

    public class GetTablesResponse
    {
        [JsonProperty("value")]
        public GetTablesResponseValueTypeItem[] Value { get; set; }
    }

    public class GetTablesResponseValueTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("showBandedColumns")]
        public bool ShowBandedColumns { get; set; }

        [JsonProperty("highlightFirstColumn")]
        public bool HighlightFirstColumn { get; set; }

        [JsonProperty("highlightLastColumn")]
        public bool HighlightLastColumn { get; set; }

        [JsonProperty("showBandedRows")]
        public bool ShowBandedRows { get; set; }

        [JsonProperty("showFilterButton")]
        public bool ShowFilterButton { get; set; }

        [JsonProperty("showHeaders")]
        public bool ShowHeaders { get; set; }

        [JsonProperty("showTotals")]
        public bool ShowTotals { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Excelonline;

    public partial class WorkflowManagedActions
    {
        public ExcelonlineActions Excelonline(string connectionId) => new ExcelonlineActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExcelonlineTriggers Excelonline(string connectionId) => new ExcelonlineTriggers(connectionId);
    }
}