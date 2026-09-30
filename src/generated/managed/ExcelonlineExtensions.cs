//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Excelonline
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExcelonlineActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<TableMetadata> CreateTable([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> tabletableRange, [WorkflowExpression] Func<string> tabletableName = null, [WorkflowExpression] Func<string> tablecolumnsNames = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(tabletableRange, nameof(tabletableRange), required: true);
            SourceExpression.Validate(tabletableName, nameof(tabletableName), required: false);
            SourceExpression.Validate(tablecolumnsNames, nameof(tablecolumnsNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                var table = new JObject();
                var tablepropCount = 0;
                if (tabletableName != null)
                {
                    table["TableName"] = SourceExpressionConverter.ConvertToken(tabletableName);
                    tablepropCount++;
                }

                tablepropCount++;
                table["Range"] = SourceExpressionConverter.ConvertToken(tabletableRange);
                if (tablecolumnsNames != null)
                {
                    table["ColumnsNames"] = SourceExpressionConverter.ConvertToken(tablecolumnsNames);
                    tablepropCount++;
                }

                if (tablepropCount > 0)
                {
                    callPayload.Body = table;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TableMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IWorkflowAction CreateIdColumn([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/createIdColumn", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = Convert.ToString("__PowerAppsId__");
                if (idColumn != null)
                    callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                callPayload.Queries["populateColumn"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (filter != null)
                    callPayload.Queries["$filter"] = SourceExpressionConverter.ConvertO(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = SourceExpressionConverter.ConvertO(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = SourceExpressionConverter.ConvertO(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = SourceExpressionConverter.ConvertO(skip);
                if (select != null)
                    callPayload.Queries["$select"] = SourceExpressionConverter.ConvertO(select);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item> GetItem([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<GetAllWorksheetsResponse> GetAllWorksheets([WorkflowExpression] Func<string> @file)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                return callPayload;
            }

            return new ApiConnectionAction<GetAllWorksheetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<WorksheetMetadata> CreateWorksheet([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = SourceExpressionConverter.ConvertToken(bodyname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<WorksheetMetadata>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<GetTablesResponse> GetTables([WorkflowExpression] Func<string> @file)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                return callPayload;
            }

            return new ApiConnectionAction<GetTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonline")]
        public IBodyWorkflowAction<Item> AddRow([WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.2/drives/{0}/items/{1}/workbook/tables/{2}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(SourceExpression.Literal(1, "me"), 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
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