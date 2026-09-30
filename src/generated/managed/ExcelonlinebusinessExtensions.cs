//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Excelonlinebusiness
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExcelonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<TableMetadata> CreateTable([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> tabletableRange, [WorkflowExpression] Func<string> tabletableName = null, [WorkflowExpression] Func<string> tablecolumnsNames = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(tabletableRange, nameof(tabletableRange), required: true);
            SourceExpression.Validate(tabletableName, nameof(tabletableName), required: false);
            SourceExpression.Validate(tablecolumnsNames, nameof(tablecolumnsNames), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IWorkflowAction CreateIdColumn([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/createIdColumn", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["idColumn"] = Convert.ToString("__PowerAppsId__");
                if (idColumn != null)
                    callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                callPayload.Queries["populateColumn"] = Convert.ToString(false);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(filter, nameof(filter), required: false);
            SourceExpression.Validate(orderby, nameof(orderby), required: false);
            SourceExpression.Validate(top, nameof(top), required: false);
            SourceExpression.Validate(skip, nameof(skip), required: false);
            SourceExpression.Validate(select, nameof(select), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
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
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<ItemsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<CommentsList> GetComments([WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> source = null)
        {
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(source, nameof(source), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                return callPayload;
            }

            return new ApiConnectionAction<CommentsList>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Comment> GetComment([WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> commentid, [WorkflowExpression] Func<string> source = null)
        {
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(commentid, nameof(commentid), required: true);
            SourceExpression.Validate(source, nameof(source), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(commentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (source != null)
                    callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                return callPayload;
            }

            return new ApiConnectionAction<Comment>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<GetItemResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(idColumn, nameof(idColumn), required: true);
            SourceExpression.Validate(id, nameof(id), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["idColumn"] = SourceExpressionConverter.ConvertO(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetAllWorksheetsResponse> GetAllWorksheets([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<GetAllWorksheetsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<WorksheetMetadata> CreateWorksheet([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> bodyname = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(bodyname, nameof(bodyname), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
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

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<GetTablesResponse> GetTables([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            SourceExpression.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/tables", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = SourceExpressionConverter.ConvertO(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = SourceExpressionConverter.ConvertO(fetchSensitivityLabelMetadata);
                return callPayload;
            }

            return new ApiConnectionAction<GetTablesResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<Item> AddRow([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(table, nameof(table), required: true);
            SourceExpression.Validate(item, nameof(item), required: false);
            SourceExpression.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/codeless/v1.2/drives/{0}/items/{1}/workbook/tables/{2}/rows", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = SourceExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = SourceExpressionConverter.ConvertToken(item);
                return callPayload;
            }

            return new ApiConnectionAction<Item>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        public IBodyWorkflowAction<JToken> RunScriptProd([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> @file, [WorkflowExpression] Func<string> scriptSource, [WorkflowExpression] Func<string> scriptDrive, [WorkflowExpression] Func<string> scriptId, [WorkflowExpression] Func<object> scriptParameters = null)
        {
            SourceExpression.Validate(source, nameof(source), required: true);
            SourceExpression.Validate(drive, nameof(drive), required: true);
            SourceExpression.Validate(@file, nameof(@file), required: true);
            SourceExpression.Validate(scriptSource, nameof(scriptSource), required: true);
            SourceExpression.Validate(scriptDrive, nameof(scriptDrive), required: true);
            SourceExpression.Validate(scriptId, nameof(scriptId), required: true);
            SourceExpression.Validate(scriptParameters, nameof(scriptParameters), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v2/officescripting/api/unattended/run/{0}/{1}/{2}/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(drive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(@file, 2), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scriptDrive, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(scriptId, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = SourceExpressionConverter.ConvertO(source);
                callPayload.Queries["scriptSource"] = SourceExpressionConverter.ConvertO(scriptSource);
                callPayload.Body = SourceExpressionConverter.ConvertToken(scriptParameters);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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