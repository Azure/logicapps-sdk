//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Excelonlinebusiness
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ExcelonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<JToken> RunScriptProd(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> scriptId, Expression<Func<object>> scriptParameters = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_scriptId = WorkflowExpression.Compile(scriptId, nameof(scriptId), required: true);
            var __workflow_scriptParameters = WorkflowExpression.Compile(scriptParameters, nameof(scriptParameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/officescripting/api/unattended/run/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["scriptId"] = ExpressionConverter.Convert(__workflow_scriptId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_scriptParameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<TableMetadata> CreateTable(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> tabletableRange, Expression<Func<string>> tabletableName = null, Expression<Func<string>> tablecolumnsNames = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_tabletableRange = WorkflowExpression.Compile(tabletableRange, nameof(tabletableRange), required: true);
            var __workflow_tabletableName = WorkflowExpression.Compile(tabletableName, nameof(tabletableName), required: false);
            var __workflow_tablecolumnsNames = WorkflowExpression.Compile(tablecolumnsNames, nameof(tablecolumnsNames), required: false);
            return new DeferredBodyAction<TableMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IWorkflowAction CreateIdColumn(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<string>> idColumn = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/createIdColumn", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["idColumn"] = Convert.ToString("__PowerAppsId__");
                if (__workflow_idColumn != null)
                    callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                callPayload.Queries["populateColumn"] = Convert.ToString(false);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<ItemsList> GetItems(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<string>> filter = null, Expression<Func<string>> orderby = null, Expression<Func<int>> top = null, Expression<Func<int>> skip = null, Expression<Func<string>> select = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_filter = WorkflowExpression.Compile(filter, nameof(filter), required: false);
            var __workflow_orderby = WorkflowExpression.Compile(orderby, nameof(orderby), required: false);
            var __workflow_top = WorkflowExpression.Compile(top, nameof(top), required: false);
            var __workflow_skip = WorkflowExpression.Compile(skip, nameof(skip), required: false);
            var __workflow_select = WorkflowExpression.Compile(select, nameof(select), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
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
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<CommentsList> GetComments(Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> source = null)
        {
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<CommentsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<CommentsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Comment> GetComment(Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> commentid, Expression<Func<string>> source = null)
        {
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_commentid = WorkflowExpression.Compile(commentid, nameof(commentid), required: true);
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: false);
            return new DeferredBodyAction<Comment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_commentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (__workflow_source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetItemResponse> GetItem(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IWorkflowAction DeleteItem(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Item> PatchItem(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<string>> idColumn, Expression<Func<string>> id, Expression<Func<itemInput>> item = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_idColumn = WorkflowExpression.Compile(idColumn, nameof(idColumn), required: true);
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(__workflow_idColumn);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetAllWorksheetsResponse> GetAllWorksheets(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetAllWorksheetsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetAllWorksheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<WorksheetMetadata> CreateWorksheet(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> bodyname = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_bodyname = WorkflowExpression.Compile(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<WorksheetMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetTablesResponse> GetTables(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<bool>> extractSensitivityLabel = null, Expression<Func<bool>> fetchSensitivityLabelMetadata = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_extractSensitivityLabel = WorkflowExpression.Compile(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            var __workflow_fetchSensitivityLabelMetadata = WorkflowExpression.Compile(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetTablesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/tables", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(__workflow_extractSensitivityLabel);
                if (__workflow_fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(__workflow_fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Item> AddRow(Expression<Func<string>> source, Expression<Func<string>> drive, Expression<Func<string>> file, Expression<Func<string>> table, Expression<Func<itemInput>> item = null, Expression<Func<dateTimeFormatInput>> dateTimeFormat = null)
        {
            var __workflow_source = WorkflowExpression.Compile(source, nameof(source), required: true);
            var __workflow_drive = WorkflowExpression.Compile(drive, nameof(drive), required: true);
            var __workflow_file = WorkflowExpression.Compile(file, nameof(file), required: true);
            var __workflow_table = WorkflowExpression.Compile(table, nameof(table), required: true);
            var __workflow_item = WorkflowExpression.Compile(item, nameof(item), required: false);
            var __workflow_dateTimeFormat = WorkflowExpression.Compile(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.2/drives/{0}/items/{1}/workbook/tables/{2}/rows", ExpressionConverter.ConvertWithUrlEncoding(__workflow_drive, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_file, 2), ExpressionConverter.ConvertWithUrlEncoding(__workflow_table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(__workflow_source);
                if (__workflow_dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(__workflow_dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }
    }

    public class ExcelonlinebusinessTriggers([ConnectionName] string connectionId)
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

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
    }

    public class Item
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }
    }

    public class SensitivityLabelMetadata
    {
        [JsonProperty("sensitivityLabelId")]
        public string SensitivityLabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("displayName")]
        public string SensitivityLabelDisplayNameInfo { get; set; }

        [JsonProperty("tooltip")]
        public string TooltipInfo { get; set; }

        [JsonProperty("priority")]
        public int PriorityOfSensitivityLabel { get; set; }

        [JsonProperty("color")]
        public string ColorToBeDisplayedForSensitivityLabel { get; set; }

        [JsonProperty("isEncrypted")]
        public bool IsEncryptedStatusOfSensitivityLabel { get; set; }

        [JsonProperty("isEnabled")]
        public bool WhetherSensitivityLabelIsEnabled { get; set; }

        [JsonProperty("isParent")]
        public bool WhetherSensitivityLabelIsParent { get; set; }

        [JsonProperty("parentSensitivityLabelId")]
        public string ParentSensitivityLabelId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dateTimeFormatInput
    {
        [EnumMember(Value = "Serial Number")]
        SerialNumber,
        [EnumMember(Value = "ISO 8601")]
        ISO8601
    }

    public class CommentsList
    {
        [JsonProperty("value")]
        public Comment[] Value { get; set; }
    }

    public class Comment
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }
    }

    public class GetItemResponse
    {
        [JsonProperty("dynamicProperties")]
        public JToken DynamicProperties { get; set; }

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
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

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
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

        [JsonProperty("sensitivityLabelInfo")]
        public SensitivityLabelMetadata[] SensitivityLabelInfo { get; set; }
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
    using Microsoft.Azure.Workflows.Sdk.Connectors.Excelonlinebusiness;

    public partial class WorkflowManagedActions
    {
        public ExcelonlinebusinessActions Excelonlinebusiness(string connectionId) => new ExcelonlinebusinessActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ExcelonlinebusinessTriggers Excelonlinebusiness(string connectionId) => new ExcelonlinebusinessTriggers(connectionId);
    }
}
