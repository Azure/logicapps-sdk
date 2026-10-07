//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smapone
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmaponeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<UserInfoModel> GETAccount()
        {
            var apiCallPath = "/intern/Account";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<UserInfoModel>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<AccountStatistics> GETAccountStats()
        {
            var apiCallPath = "/intern/Account/Stats";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<AccountStatistics>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataSourceListModel[]> GETDataSources()
        {
            var apiCallPath = "/intern/DataSource";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<DataSourceListModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETDataSource))]
        public IBodyWorkflowAction<DataSourceModel> GETDataSource([WorkflowExpression] Func<string> dataSourceId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataSourceModel> __BuildGETDataSource(WorkflowExpression<string> dataSourceId)
        {
            WorkflowExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            return new DeferredBodyAction<DataSourceModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataSourceModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETDataSourceDefinitionValues))]
        public IBodyWorkflowAction<JToken[]> GETDataSourceDefinitionValues([WorkflowExpression] Func<string> dataSourceId, [WorkflowExpression] Func<string> dataSourceVersion)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken[]> __BuildGETDataSourceDefinitionValues(WorkflowExpression<string> dataSourceId, WorkflowExpression<string> dataSourceVersion)
        {
            WorkflowExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            WorkflowExpression.Validate(dataSourceVersion, nameof(dataSourceVersion), required: true);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataSourceVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildPUTDataSourceDefinitionValues))]
        public IBodyWorkflowAction<DataSourceVersionModel> PUTDataSourceDefinitionValues([WorkflowExpression] Func<string> dataSourceId, [WorkflowExpression] Func<string> dataSourceVersion, [WorkflowExpression] Func<JToken[]> values = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataSourceVersionModel> __BuildPUTDataSourceDefinitionValues(WorkflowExpression<string> dataSourceId, WorkflowExpression<string> dataSourceVersion, WorkflowExpression<JToken[]> values = null)
        {
            WorkflowExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            WorkflowExpression.Validate(dataSourceVersion, nameof(dataSourceVersion), required: true);
            WorkflowExpression.Validate(values, nameof(values), required: false);
            return new DeferredBodyAction<DataSourceVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", ExpressionConverter.ConvertWithUrlEncoding(dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(dataSourceVersion, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(values);
                return new ApiConnectionAction<DataSourceVersionModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapModel[]> GETSmaps()
        {
            var apiCallPath = "/v1/Smaps";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SmapModel[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmap))]
        public IBodyWorkflowAction<SmapModel> GETSmap([WorkflowExpression] Func<string> smapId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SmapModel> __BuildGETSmap(WorkflowExpression<string> smapId)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            return new DeferredBodyAction<SmapModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapDataFormat))]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapDataFormat([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataRecordApi[]> __BuildGETSmapDataFormat(WorkflowExpression<string> smapId, WorkflowExpression<formatInput> format, WorkflowExpression<bool> markAsExported = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<DataRecordApi[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.{1}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<DataRecordApi[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapDataReport))]
        public IBodyWorkflowAction<string> GETSmapDataReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGETSmapDataReport(WorkflowExpression<string> smapId, WorkflowExpression<bool> markAsExported = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.pdf", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionData))]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapVersionData([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataRecordApi[]> __BuildGETSmapVersionData(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<bool> markAsExported = null, WorkflowExpression<formatInput> format = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<DataRecordApi[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<DataRecordApi[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildDELETESmapVersionData))]
        public IWorkflowAction DELETESmapVersionData([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDELETESmapVersionData(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildPOSTSmapsDataVersion))]
        public IBodyWorkflowAction<DataRecordApi> POSTSmapsDataVersion([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> tasktitle, [WorkflowExpression] Func<string> taskuserEmail = null, [WorkflowExpression] Func<string> taskcomment = null, [WorkflowExpression] Func<bool> taskhasPriority = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataRecordApi> __BuildPOSTSmapsDataVersion(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> tasktitle, WorkflowExpression<string> taskuserEmail = null, WorkflowExpression<string> taskcomment = null, WorkflowExpression<bool> taskhasPriority = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(tasktitle, nameof(tasktitle), required: true);
            WorkflowExpression.Validate(taskuserEmail, nameof(taskuserEmail), required: false);
            WorkflowExpression.Validate(taskcomment, nameof(taskcomment), required: false);
            WorkflowExpression.Validate(taskhasPriority, nameof(taskhasPriority), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (taskuserEmail != null)
                {
                    task["userEmail"] = ExpressionConverter.ConvertO(taskuserEmail);
                    taskpropCount++;
                }

                taskpropCount++;
                task["title"] = ExpressionConverter.ConvertO(tasktitle);
                if (taskcomment != null)
                {
                    task["comment"] = ExpressionConverter.ConvertO(taskcomment);
                    taskpropCount++;
                }

                if (taskhasPriority != null)
                {
                    task["hasPriority"] = ExpressionConverter.ConvertO(taskhasPriority);
                    taskpropCount++;
                }

                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    task["data"] = dataObject;
                    taskpropCount++;
                }

                if (taskpropCount > 0)
                {
                    callPayload.Body = task;
                }

                return new ApiConnectionAction<DataRecordApi>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionDataReport))]
        public IBodyWorkflowAction<string> GETSmapVersionDataReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGETSmapVersionDataReport(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<bool> markAsExported = null, WorkflowExpression<stateInput> state = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            WorkflowExpression.Validate(state, nameof(state), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data.pdf", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(state);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionRecordReport))]
        public IBodyWorkflowAction<string> GETSmapVersionRecordReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<bool> useDefault = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildGETSmapVersionRecordReport(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> recordId, WorkflowExpression<formatInput> format, WorkflowExpression<bool> markAsExported = null, WorkflowExpression<bool> useDefault = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: true);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            WorkflowExpression.Validate(useDefault, nameof(useDefault), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}.{3}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1), ExpressionConverter.ConvertWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                callPayload.Queries["useDefault"] = Convert.ToString(false);
                if (useDefault != null)
                    callPayload.Queries["useDefault"] = ExpressionConverter.Convert(useDefault);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionRecordFormat))]
        public IBodyWorkflowAction<DataRecordApi> GETSmapVersionRecordFormat([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> markAsExported = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataRecordApi> __BuildGETSmapVersionRecordFormat(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> recordId, WorkflowExpression<formatInput> format = null, WorkflowExpression<bool> markAsExported = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(format, nameof(format), required: false);
            WorkflowExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(format);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(markAsExported);
                return new ApiConnectionAction<DataRecordApi>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildDELETESmapVersionDataRecord))]
        public IWorkflowAction DELETESmapVersionDataRecord([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildDELETESmapVersionDataRecord(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> recordId)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionRecordFiles))]
        public IBodyWorkflowAction<SingleFileValue[]> GETSmapVersionRecordFiles([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SingleFileValue[]> __BuildGETSmapVersionRecordFiles(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> recordId)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<SingleFileValue[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleFileValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionRecordFile))]
        public IWorkflowAction GETSmapVersionRecordFile([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildGETSmapVersionRecordFile(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> recordId, WorkflowExpression<string> fileId)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(recordId, nameof(recordId), required: true);
            WorkflowExpression.Validate(fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files/{3}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(recordId, 1), ExpressionConverter.ConvertWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildPUTSmapVersionTaskState))]
        public IBodyWorkflowAction<DataRecordApi> PUTSmapVersionTaskState([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<stateactionInput> stateaction = null, [WorkflowExpression] Func<string> stateuserEmail = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DataRecordApi> __BuildPUTSmapVersionTaskState(WorkflowExpression<string> smapId, WorkflowExpression<string> version, WorkflowExpression<string> taskId, WorkflowExpression<stateactionInput> stateaction = null, WorkflowExpression<string> stateuserEmail = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            WorkflowExpression.Validate(taskId, nameof(taskId), required: true);
            WorkflowExpression.Validate(stateaction, nameof(stateaction), required: false);
            WorkflowExpression.Validate(stateuserEmail, nameof(stateuserEmail), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Tasks/{2}/State", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1), ExpressionConverter.ConvertWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var state = new JObject();
                var statepropCount = 0;
                if (stateaction != null)
                {
                    state["action"] = ExpressionConverter.ConvertO(stateaction);
                    statepropCount++;
                }

                if (stateuserEmail != null)
                {
                    state["userEmail"] = ExpressionConverter.ConvertO(stateuserEmail);
                    statepropCount++;
                }

                if (statepropCount > 0)
                {
                    callPayload.Body = state;
                }

                return new ApiConnectionAction<DataRecordApi>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildPUTSmapVersionsCurrentDataSourcesUpdate))]
        public IBodyWorkflowAction<SmapVersionModel> PUTSmapVersionsCurrentDataSourcesUpdate([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<bool> updateEditVersion = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SmapVersionModel> __BuildPUTSmapVersionsCurrentDataSourcesUpdate(WorkflowExpression<string> smapId, WorkflowExpression<bool> updateEditVersion = null)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(updateEditVersion, nameof(updateEditVersion), required: false);
            return new DeferredBodyAction<SmapVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/Current/DataSources/Update", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateEditVersion"] = Convert.ToString(false);
                if (updateEditVersion != null)
                    callPayload.Queries["updateEditVersion"] = ExpressionConverter.Convert(updateEditVersion);
                return new ApiConnectionAction<SmapVersionModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersions))]
        public IBodyWorkflowAction<SmapVersionModel[]> GETSmapVersions([WorkflowExpression] Func<string> smapId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SmapVersionModel[]> __BuildGETSmapVersions(WorkflowExpression<string> smapId)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            return new DeferredBodyAction<SmapVersionModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapVersionModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersion))]
        public IBodyWorkflowAction<SmapVersionModel> GETSmapVersion([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SmapVersionModel> __BuildGETSmapVersion(WorkflowExpression<string> smapId, WorkflowExpression<string> version)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            return new DeferredBodyAction<SmapVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapVersionModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [WorkflowExpressionFactory(nameof(__BuildGETSmapVersionSchema))]
        public IBodyWorkflowAction<JToken> GETSmapVersionSchema([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<JToken> __BuildGETSmapVersionSchema(WorkflowExpression<string> smapId, WorkflowExpression<string> version)
        {
            WorkflowExpression.Validate(smapId, nameof(smapId), required: true);
            WorkflowExpression.Validate(version, nameof(version), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Schema", ExpressionConverter.ConvertWithUrlEncoding(smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken>(callPayload);
            });
        }
    }

    public class SmaponeTriggers([ConnectionName] string connectionId)
    {
    }

    public class UserInfoModel
    {
        [JsonProperty("accountIsActivated")]
        public bool AccountIsActivated { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("companyName")]
        public string CompanyName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("originalMail")]
        public string OriginalMail { get; set; }

        [JsonProperty("contract")]
        public string Contract { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("smapLimit")]
        public int SmapLimit { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("source")]
        public UserInfoModelSourceType Source { get; set; }

        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }

        [JsonProperty("userLimit")]
        public int UserLimit { get; set; }

        [JsonProperty("publishedSmaps")]
        public int PublishedSmaps { get; set; }

        [JsonProperty("availableFeatures")]
        public UserInfoModelAvailableFeaturesTypeItem[] AvailableFeatures { get; set; }

        [JsonProperty("settings")]
        public JToken Settings { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserInfoModelSourceType
    {
        SmapOne,
        Telekom,
        Apple,
        Stripe
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum UserInfoModelAvailableFeaturesTypeItem
    {
        CustomReportTemplates,
        ReportMasterTemplate,
        GroupLicenses,
        AppDataLink,
        RecordBulkDownload,
        DataNotifications,
        DataNotificationCopy,
        RestAPI,
        MasterImpersonification,
        SubscriptionRoles,
        DataNotificationCopyV2,
        CreateTasks,
        CompanyTemplates,
        SmapVersionDeletion,
        PdfSigning,
        PublicDataFilesAccess,
        DataGridV2,
        ExcelExportV2,
        MarkAsExported,
        SendHiddenPushMessagesToIOS,
        AllowWebPurchase,
        None
    }

    public class AccountStatistics
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("subscriptionType")]
        public AccountStatisticsSubscriptionTypeType SubscriptionType { get; set; }

        [JsonProperty("subscriptionTypeChanged")]
        public string SubscriptionTypeChanged { get; set; }

        [JsonProperty("subscriptionTypeTitle")]
        public string SubscriptionTypeTitle { get; set; }

        [JsonProperty("subscriptionTypeValue")]
        public int SubscriptionTypeValue { get; set; }

        [JsonProperty("isMasterSubscription")]
        public bool IsMasterSubscription { get; set; }

        [JsonProperty("smapLimit")]
        public int SmapLimit { get; set; }

        [JsonProperty("groupCount")]
        public int GroupCount { get; set; }

        [JsonProperty("trialDurationInDays")]
        public int TrialDurationInDays { get; set; }

        [JsonProperty("daysLeftForTrial")]
        public int DaysLeftForTrial { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("userLimit")]
        public int UserLimit { get; set; }

        [JsonProperty("daysSinceCreation")]
        public int DaysSinceCreation { get; set; }

        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("langCode")]
        public string LangCode { get; set; }

        [JsonProperty("isInternal")]
        public bool IsInternal { get; set; }

        [JsonProperty("systemVersion")]
        public string SystemVersion { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("isChildSubscription")]
        public bool IsChildSubscription { get; set; }

        [JsonProperty("isImpersonating")]
        public bool IsImpersonating { get; set; }

        [JsonProperty("dataCount")]
        public int DataCount { get; set; }

        [JsonProperty("smapCount")]
        public int SmapCount { get; set; }

        [JsonProperty("publishedSmapCount")]
        public int PublishedSmapCount { get; set; }

        [JsonProperty("notPublishedSmapCount")]
        public int NotPublishedSmapCount { get; set; }

        [JsonProperty("distributedSmapCount")]
        public int DistributedSmapCount { get; set; }

        [JsonProperty("installedSmapsCount")]
        public int InstalledSmapsCount { get; set; }

        [JsonProperty("groupLicenseCount")]
        public int GroupLicenseCount { get; set; }

        [JsonProperty("lastSmapId")]
        public string LastSmapId { get; set; }

        [JsonProperty("previewSmapCount")]
        public int PreviewSmapCount { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccountStatisticsSubscriptionTypeType
    {
        None,
        Guest,
        Free,
        Smart,
        AppPlan,
        Business,
        Enterprise,
        Freemium,
        Unlimited
    }

    public class DataSourceListModel
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("latestVersion")]
        public string LatestVersion { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class DataSourceModel
    {
        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("latestVersion")]
        public string LatestVersion { get; set; }

        [JsonProperty("usedInSmaps")]
        public DataSourceSmapModel[] UsedInSmaps { get; set; }
    }

    public class DataSourceSmapModel
    {
        [JsonProperty("smapName")]
        public string SmapName { get; set; }

        [JsonProperty("smapId")]
        public string SmapId { get; set; }
    }

    public class DataSourceVersionModel
    {
        [JsonProperty("definition")]
        public AbstractDataSourceDefinition Definition { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class AbstractDataSourceDefinition
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type")]
        public AbstractDataSourceDefinitionTypeType Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("dataSourceId")]
        public string DataSourceId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AbstractDataSourceDefinitionTypeType
    {
        StaticTable
    }

    public class SmapModel
    {
        [JsonProperty("groupLicenseCount")]
        public int GroupLicenseCount { get; set; }

        [JsonProperty("changeType")]
        public SmapModelChangeTypeType ChangeType { get; set; }

        [JsonProperty("userLicenseCount")]
        public int UserLicenseCount { get; set; }

        [JsonProperty("lastChanged")]
        public string LastChanged { get; set; }

        [JsonProperty("isUpToDate")]
        public bool IsUpToDate { get; set; }

        [JsonProperty("installationsCount")]
        public int InstallationsCount { get; set; }

        [JsonProperty("lastPublishedVersion")]
        public SmapVersionModel LastPublishedVersion { get; set; }

        [JsonProperty("totalDataCount")]
        public int TotalDataCount { get; set; }

        [JsonProperty("totalOpenTasksCount")]
        public int TotalOpenTasksCount { get; set; }

        [JsonProperty("tasksActivated")]
        public bool TasksActivated { get; set; }

        [JsonProperty("isCompanyTemplate")]
        public bool IsCompanyTemplate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("smapId")]
        public string SmapId { get; set; }

        [JsonProperty("logoId")]
        public string LogoId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SmapModelChangeTypeType
    {
        None,
        Minor,
        Major,
        Incomplete,
        PreviewPossible
    }

    public class SmapVersionModel
    {
        [JsonProperty("lastChanged")]
        public string LastChanged { get; set; }

        [JsonProperty("lastRecordReceived")]
        public string LastRecordReceived { get; set; }

        [JsonProperty("dataCount")]
        public int DataCount { get; set; }

        [JsonProperty("smapVersionId")]
        public string SmapVersionId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public class DataRecordApi
    {
        [JsonProperty("schemaVersion")]
        public DataRecordApiSchemaVersionType SchemaVersion { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("recordType")]
        public DataRecordApiRecordTypeType RecordType { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("smapId")]
        public string SmapId { get; set; }

        [JsonProperty("smapVersionId")]
        public string SmapVersionId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("tokenId")]
        public string TokenId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userEmail")]
        public string UserEmail { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("sendDate")]
        public string SendDate { get; set; }

        [JsonProperty("clientCreatedDate")]
        public string ClientCreatedDate { get; set; }

        [JsonProperty("receivedDate")]
        public string ReceivedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("deletedDate")]
        public string DeletedDate { get; set; }

        [JsonProperty("lastExportDate")]
        public string LastExportDate { get; set; }

        [JsonProperty("toCompleteOn")]
        public string ToCompleteOn { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("data")]
        public JToken Data { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataRecordApiSchemaVersionType
    {
        [EnumMember(Value = "1")]
        _1
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum DataRecordApiRecordTypeType
    {
        [EnumMember(Value = "Task")]
        TaskObject,
        Record
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum formatInput
    {
        Json,
        Xml
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum stateInput
    {
        New,
        Exported,
        Incomplete
    }

    public class SingleFileValue
    {
        [JsonProperty("fileId")]
        public string FileId { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("checkSum")]
        public string CheckSum { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("meta")]
        public FileMetaData Meta { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class FileMetaData
    {
        [JsonProperty("audioDuration")]
        public string AudioDuration { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum stateactionInput
    {
        Assign,
        Remove
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Smapone;

    public partial class WorkflowManagedActions
    {
        public SmaponeActions Smapone(string connectionId) => new SmaponeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SmaponeTriggers Smapone(string connectionId) => new SmaponeTriggers(connectionId);
    }
}