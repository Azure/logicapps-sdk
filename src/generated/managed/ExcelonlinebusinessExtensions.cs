//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Excelonlinebusiness
{
        using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ExcelonlinebusinessActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildRunScriptProd))]
        public IBodyWorkflowAction<JToken> RunScriptProd([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> scriptId, [WorkflowExpression] Func<object> scriptParameters = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildRunScriptProd(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> scriptId, WorkflowValue<object> scriptParameters = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(scriptId, nameof(scriptId), required: true);
            WorkflowValue.Validate(scriptParameters, nameof(scriptParameters), required: false);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/officescripting/api/unattended/run/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["scriptId"] = ExpressionConverter.Convert(scriptId);
                callPayload.Body = ExpressionConverter.ConvertO(scriptParameters);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateTable))]
        public IBodyWorkflowAction<TableMetadata> CreateTable([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> tabletableRange, [WorkflowExpression] Func<string> tabletableName = null, [WorkflowExpression] Func<string> tablecolumnsNames = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TableMetadata> __BuildCreateTable(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> tabletableRange, WorkflowValue<string> tabletableName = null, WorkflowValue<string> tablecolumnsNames = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(tabletableRange, nameof(tabletableRange), required: true);
            WorkflowValue.Validate(tabletableName, nameof(tabletableName), required: false);
            WorkflowValue.Validate(tablecolumnsNames, nameof(tablecolumnsNames), required: false);
            return new DeferredBodyAction<TableMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                var table = new JObject();
                var tablepropCount = 0;
                if (tabletableName != null)
                {
                    table["TableName"] = ExpressionConverter.ConvertO(tabletableName);
                    tablepropCount++;
                }

                tablepropCount++;
                table["Range"] = ExpressionConverter.ConvertO(tabletableRange);
                if (tablecolumnsNames != null)
                {
                    table["ColumnsNames"] = ExpressionConverter.ConvertO(tablecolumnsNames);
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
        [WorkflowExpressionFactory(nameof(__BuildCreateIdColumn))]
        public IWorkflowAction CreateIdColumn([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildCreateIdColumn(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<string> idColumn = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(idColumn, nameof(idColumn), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/createIdColumn", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["idColumn"] = Convert.ToString("__PowerAppsId__");
                if (idColumn != null)
                    callPayload.Queries["idColumn"] = ExpressionConverter.Convert(idColumn);
                callPayload.Queries["populateColumn"] = Convert.ToString(false);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetItems))]
        public IBodyWorkflowAction<ItemsList> GetItems([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> filter = null, [WorkflowExpression] Func<string> orderby = null, [WorkflowExpression] Func<int> top = null, [WorkflowExpression] Func<int> skip = null, [WorkflowExpression] Func<string> select = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ItemsList> __BuildGetItems(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<string> filter = null, WorkflowValue<string> orderby = null, WorkflowValue<int> top = null, WorkflowValue<int> skip = null, WorkflowValue<string> select = null, WorkflowValue<dateTimeFormatInput> dateTimeFormat = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(filter, nameof(filter), required: false);
            WorkflowValue.Validate(orderby, nameof(orderby), required: false);
            WorkflowValue.Validate(top, nameof(top), required: false);
            WorkflowValue.Validate(skip, nameof(skip), required: false);
            WorkflowValue.Validate(select, nameof(select), required: false);
            WorkflowValue.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<ItemsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (filter != null)
                    callPayload.Queries["$filter"] = ExpressionConverter.Convert(filter);
                if (orderby != null)
                    callPayload.Queries["$orderby"] = ExpressionConverter.Convert(orderby);
                if (top != null)
                    callPayload.Queries["$top"] = ExpressionConverter.Convert(top);
                if (skip != null)
                    callPayload.Queries["$skip"] = ExpressionConverter.Convert(skip);
                if (select != null)
                    callPayload.Queries["$select"] = ExpressionConverter.Convert(select);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<ItemsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetComments))]
        public IBodyWorkflowAction<CommentsList> GetComments([WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CommentsList> __BuildGetComments(WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> source = null)
        {
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<CommentsList>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<CommentsList>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetComment))]
        public IBodyWorkflowAction<Comment> GetComment([WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> commentid, [WorkflowExpression] Func<string> source = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Comment> __BuildGetComment(WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> commentid, WorkflowValue<string> source = null)
        {
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(commentid, nameof(commentid), required: true);
            WorkflowValue.Validate(source, nameof(source), required: false);
            return new DeferredBodyAction<Comment>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/items/{1}/workbook/comments/{2}", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(commentid, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = Convert.ToString("me");
                if (source != null)
                    callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                return new ApiConnectionAction<Comment>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetItem))]
        public IBodyWorkflowAction<GetItemResponse> GetItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetItemResponse> __BuildGetItem(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<string> idColumn, WorkflowValue<string> id, WorkflowValue<dateTimeFormatInput> dateTimeFormat = null, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(idColumn, nameof(idColumn), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetItemResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetItemResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildDeleteItem))]
        public IWorkflowAction DeleteItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDeleteItem(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<string> idColumn, WorkflowValue<string> id)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(idColumn, nameof(idColumn), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(idColumn);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildPatchItem))]
        public IBodyWorkflowAction<Item> PatchItem([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<string> idColumn, [WorkflowExpression] Func<string> id, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildPatchItem(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<string> idColumn, WorkflowValue<string> id, WorkflowValue<itemInput> item = null, WorkflowValue<dateTimeFormatInput> dateTimeFormat = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(idColumn, nameof(idColumn), required: true);
            WorkflowValue.Validate(id, nameof(id), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/drives/{0}/files/{1}/tables/{2}/items/{3}", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1), ExpressionConverter.ConvertWithUrlEncoding(id, 2));
                var apiCallHttpMethod = "patch";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                callPayload.Queries["idColumn"] = ExpressionConverter.Convert(idColumn);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(item);
                return new ApiConnectionAction<Item>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildGetAllWorksheets))]
        public IBodyWorkflowAction<GetAllWorksheetsResponse> GetAllWorksheets([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAllWorksheetsResponse> __BuildGetAllWorksheets(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetAllWorksheetsResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetAllWorksheetsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildCreateWorksheet))]
        public IBodyWorkflowAction<WorksheetMetadata> CreateWorksheet([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> bodyname = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<WorksheetMetadata> __BuildCreateWorksheet(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> bodyname = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(bodyname, nameof(bodyname), required: false);
            return new DeferredBodyAction<WorksheetMetadata>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/worksheets", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyname != null)
                {
                    body["name"] = ExpressionConverter.ConvertO(bodyname);
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
        [WorkflowExpressionFactory(nameof(__BuildGetTables))]
        public IBodyWorkflowAction<GetTablesResponse> GetTables([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<bool> extractSensitivityLabel = null, [WorkflowExpression] Func<bool> fetchSensitivityLabelMetadata = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTablesResponse> __BuildGetTables(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<bool> extractSensitivityLabel = null, WorkflowValue<bool> fetchSensitivityLabelMetadata = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(extractSensitivityLabel, nameof(extractSensitivityLabel), required: false);
            WorkflowValue.Validate(fetchSensitivityLabelMetadata, nameof(fetchSensitivityLabelMetadata), required: false);
            return new DeferredBodyAction<GetTablesResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.0/drives/{0}/items/{1}/workbook/tables", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (extractSensitivityLabel != null)
                    callPayload.Queries["extractSensitivityLabel"] = ExpressionConverter.Convert(extractSensitivityLabel);
                if (fetchSensitivityLabelMetadata != null)
                    callPayload.Queries["fetchSensitivityLabelMetadata"] = ExpressionConverter.Convert(fetchSensitivityLabelMetadata);
                return new ApiConnectionAction<GetTablesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "excelonlinebusiness")]
        [WorkflowExpressionFactory(nameof(__BuildAddRow))]
        public IBodyWorkflowAction<Item> AddRow([WorkflowExpression] Func<string> source, [WorkflowExpression] Func<string> drive, [WorkflowExpression] Func<string> file, [WorkflowExpression] Func<string> table, [WorkflowExpression] Func<itemInput> item = null, [WorkflowExpression] Func<dateTimeFormatInput> dateTimeFormat = null)
        {
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Item> __BuildAddRow(WorkflowValue<string> source, WorkflowValue<string> drive, WorkflowValue<string> file, WorkflowValue<string> table, WorkflowValue<itemInput> item = null, WorkflowValue<dateTimeFormatInput> dateTimeFormat = null)
        {
            WorkflowValue.Validate(source, nameof(source), required: true);
            WorkflowValue.Validate(drive, nameof(drive), required: true);
            WorkflowValue.Validate(file, nameof(file), required: true);
            WorkflowValue.Validate(table, nameof(table), required: true);
            WorkflowValue.Validate(item, nameof(item), required: false);
            WorkflowValue.Validate(dateTimeFormat, nameof(dateTimeFormat), required: false);
            return new DeferredBodyAction<Item>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/codeless/v1.2/drives/{0}/items/{1}/workbook/tables/{2}/rows", ExpressionConverter.ConvertWithUrlEncoding(drive, 1), ExpressionConverter.ConvertWithUrlEncoding(file, 2), ExpressionConverter.ConvertWithUrlEncoding(table, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["source"] = ExpressionConverter.Convert(source);
                if (dateTimeFormat != null)
                    callPayload.Queries["dateTimeFormat"] = ExpressionConverter.Convert(dateTimeFormat);
                callPayload.Body = ExpressionConverter.ConvertO(item);
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
