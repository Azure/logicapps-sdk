//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smapone
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

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
        public IBodyWorkflowAction<DataSourceModel> GETDataSource(Expression<Func<string>> dataSourceId)
        {
            var __workflow_dataSourceId = dataSourceId == null ? null : WorkflowExpression.Compile(dataSourceId);
            WorkflowExpression.Validate(__workflow_dataSourceId, nameof(dataSourceId), required: true);
            return new DeferredBodyAction<DataSourceModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataSourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DataSourceModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<JToken[]> GETDataSourceDefinitionValues(Expression<Func<string>> dataSourceId, Expression<Func<string>> dataSourceVersion)
        {
            var __workflow_dataSourceId = dataSourceId == null ? null : WorkflowExpression.Compile(dataSourceId);
            WorkflowExpression.Validate(__workflow_dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_dataSourceVersion = dataSourceVersion == null ? null : WorkflowExpression.Compile(dataSourceVersion);
            WorkflowExpression.Validate(__workflow_dataSourceVersion, nameof(dataSourceVersion), required: true);
            return new DeferredBodyAction<JToken[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataSourceVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<JToken[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataSourceVersionModel> PUTDataSourceDefinitionValues(Expression<Func<string>> dataSourceId, Expression<Func<string>> dataSourceVersion, Expression<Func<JToken[]>> values = null)
        {
            var __workflow_dataSourceId = dataSourceId == null ? null : WorkflowExpression.Compile(dataSourceId);
            WorkflowExpression.Validate(__workflow_dataSourceId, nameof(dataSourceId), required: true);
            var __workflow_dataSourceVersion = dataSourceVersion == null ? null : WorkflowExpression.Compile(dataSourceVersion);
            WorkflowExpression.Validate(__workflow_dataSourceVersion, nameof(dataSourceVersion), required: true);
            var __workflow_values = values == null ? null : WorkflowExpression.Compile(values);
            WorkflowExpression.Validate(__workflow_values, nameof(values), required: false);
            return new DeferredBodyAction<DataSourceVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataSourceId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_dataSourceVersion, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_values);
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
        public IBodyWorkflowAction<SmapModel> GETSmap(Expression<Func<string>> smapId)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            return new DeferredBodyAction<SmapModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapDataFormat(Expression<Func<string>> smapId, Expression<Func<formatInput>> format, Expression<Func<bool>> markAsExported = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: true);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<DataRecordApi[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<DataRecordApi[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<string> GETSmapDataReport(Expression<Func<string>> smapId, Expression<Func<bool>> markAsExported = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.pdf", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapVersionData(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<bool>> markAsExported = null, Expression<Func<formatInput>> format = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<DataRecordApi[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<DataRecordApi[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction DELETESmapVersionData(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<stateInput>> state = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> POSTSmapsDataVersion(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> tasktitle, Expression<Func<string>> taskuserEmail = null, Expression<Func<string>> taskcomment = null, Expression<Func<bool>> taskhasPriority = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_tasktitle = tasktitle == null ? null : WorkflowExpression.Compile(tasktitle);
            WorkflowExpression.Validate(__workflow_tasktitle, nameof(tasktitle), required: true);
            var __workflow_taskuserEmail = taskuserEmail == null ? null : WorkflowExpression.Compile(taskuserEmail);
            WorkflowExpression.Validate(__workflow_taskuserEmail, nameof(taskuserEmail), required: false);
            var __workflow_taskcomment = taskcomment == null ? null : WorkflowExpression.Compile(taskcomment);
            WorkflowExpression.Validate(__workflow_taskcomment, nameof(taskcomment), required: false);
            var __workflow_taskhasPriority = taskhasPriority == null ? null : WorkflowExpression.Compile(taskhasPriority);
            WorkflowExpression.Validate(__workflow_taskhasPriority, nameof(taskhasPriority), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Data", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (__workflow_taskuserEmail != null)
                {
                    task["userEmail"] = ExpressionConverter.ConvertO(__workflow_taskuserEmail);
                    taskpropCount++;
                }

                taskpropCount++;
                task["title"] = ExpressionConverter.ConvertO(__workflow_tasktitle);
                if (__workflow_taskcomment != null)
                {
                    task["comment"] = ExpressionConverter.ConvertO(__workflow_taskcomment);
                    taskpropCount++;
                }

                if (__workflow_taskhasPriority != null)
                {
                    task["hasPriority"] = ExpressionConverter.ConvertO(__workflow_taskhasPriority);
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
        public IBodyWorkflowAction<string> GETSmapVersionDataReport(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<bool>> markAsExported = null, Expression<Func<stateInput>> state = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            var __workflow_state = state == null ? null : WorkflowExpression.Compile(state);
            WorkflowExpression.Validate(__workflow_state, nameof(state), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data.pdf", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                if (__workflow_state != null)
                    callPayload.Queries["state"] = ExpressionConverter.Convert(__workflow_state);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<string> GETSmapVersionRecordReport(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> recordId, Expression<Func<formatInput>> format, Expression<Func<bool>> markAsExported = null, Expression<Func<bool>> useDefault = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: true);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            var __workflow_useDefault = useDefault == null ? null : WorkflowExpression.Compile(useDefault);
            WorkflowExpression.Validate(__workflow_useDefault, nameof(useDefault), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}.{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                callPayload.Queries["useDefault"] = Convert.ToString(false);
                if (__workflow_useDefault != null)
                    callPayload.Queries["useDefault"] = ExpressionConverter.Convert(__workflow_useDefault);
                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> GETSmapVersionRecordFormat(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> recordId, Expression<Func<formatInput>> format = null, Expression<Func<bool>> markAsExported = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_format = format == null ? null : WorkflowExpression.Compile(format);
            WorkflowExpression.Validate(__workflow_format, nameof(format), required: false);
            var __workflow_markAsExported = markAsExported == null ? null : WorkflowExpression.Compile(markAsExported);
            WorkflowExpression.Validate(__workflow_markAsExported, nameof(markAsExported), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (__workflow_format != null)
                    callPayload.Queries["format"] = ExpressionConverter.Convert(__workflow_format);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (__workflow_markAsExported != null)
                    callPayload.Queries["markAsExported"] = ExpressionConverter.Convert(__workflow_markAsExported);
                return new ApiConnectionAction<DataRecordApi>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction DELETESmapVersionDataRecord(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> recordId)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SingleFileValue[]> GETSmapVersionRecordFiles(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> recordId)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            return new DeferredBodyAction<SingleFileValue[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SingleFileValue[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction GETSmapVersionRecordFile(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> recordId, Expression<Func<string>> fileId)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_recordId = recordId == null ? null : WorkflowExpression.Compile(recordId);
            WorkflowExpression.Validate(__workflow_recordId, nameof(recordId), required: true);
            var __workflow_fileId = fileId == null ? null : WorkflowExpression.Compile(fileId);
            WorkflowExpression.Validate(__workflow_fileId, nameof(fileId), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files/{3}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_recordId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> PUTSmapVersionTaskState(Expression<Func<string>> smapId, Expression<Func<string>> version, Expression<Func<string>> taskId, Expression<Func<stateactionInput>> stateaction = null, Expression<Func<string>> stateuserEmail = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            var __workflow_taskId = taskId == null ? null : WorkflowExpression.Compile(taskId);
            WorkflowExpression.Validate(__workflow_taskId, nameof(taskId), required: true);
            var __workflow_stateaction = stateaction == null ? null : WorkflowExpression.Compile(stateaction);
            WorkflowExpression.Validate(__workflow_stateaction, nameof(stateaction), required: false);
            var __workflow_stateuserEmail = stateuserEmail == null ? null : WorkflowExpression.Compile(stateuserEmail);
            WorkflowExpression.Validate(__workflow_stateuserEmail, nameof(stateuserEmail), required: false);
            return new DeferredBodyAction<DataRecordApi>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Tasks/{2}/State", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var state = new JObject();
                var statepropCount = 0;
                if (__workflow_stateaction != null)
                {
                    state["action"] = ExpressionConverter.ConvertO(__workflow_stateaction);
                    statepropCount++;
                }

                if (__workflow_stateuserEmail != null)
                {
                    state["userEmail"] = ExpressionConverter.ConvertO(__workflow_stateuserEmail);
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
        public IBodyWorkflowAction<SmapVersionModel> PUTSmapVersionsCurrentDataSourcesUpdate(Expression<Func<string>> smapId, Expression<Func<bool>> updateEditVersion = null)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_updateEditVersion = updateEditVersion == null ? null : WorkflowExpression.Compile(updateEditVersion);
            WorkflowExpression.Validate(__workflow_updateEditVersion, nameof(updateEditVersion), required: false);
            return new DeferredBodyAction<SmapVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/Current/DataSources/Update", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateEditVersion"] = Convert.ToString(false);
                if (__workflow_updateEditVersion != null)
                    callPayload.Queries["updateEditVersion"] = ExpressionConverter.Convert(__workflow_updateEditVersion);
                return new ApiConnectionAction<SmapVersionModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapVersionModel[]> GETSmapVersions(Expression<Func<string>> smapId)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            return new DeferredBodyAction<SmapVersionModel[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapVersionModel[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapVersionModel> GETSmapVersion(Expression<Func<string>> smapId, Expression<Func<string>> version)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<SmapVersionModel>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SmapVersionModel>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<JToken> GETSmapVersionSchema(Expression<Func<string>> smapId, Expression<Func<string>> version)
        {
            var __workflow_smapId = smapId == null ? null : WorkflowExpression.Compile(smapId);
            WorkflowExpression.Validate(__workflow_smapId, nameof(smapId), required: true);
            var __workflow_version = version == null ? null : WorkflowExpression.Compile(version);
            WorkflowExpression.Validate(__workflow_version, nameof(version), required: true);
            return new DeferredBodyAction<JToken>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Schema", ExpressionConverter.ConvertWithUrlEncoding(__workflow_smapId, 1), ExpressionConverter.ConvertWithUrlEncoding(__workflow_version, 1));
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
