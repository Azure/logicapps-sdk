//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Smapone
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SmaponeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<UserInfoModel> GETAccount()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intern/Account";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<UserInfoModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<AccountStatistics> GETAccountStats()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intern/Account/Stats";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<AccountStatistics>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataSourceListModel[]> GETDataSources()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/intern/DataSource";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DataSourceListModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataSourceModel> GETDataSource([WorkflowExpression] Func<string> dataSourceId)
        {
            SourceExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataSourceId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<DataSourceModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<JToken[]> GETDataSourceDefinitionValues([WorkflowExpression] Func<string> dataSourceId, [WorkflowExpression] Func<string> dataSourceVersion)
        {
            SourceExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            SourceExpression.Validate(dataSourceVersion, nameof(dataSourceVersion), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataSourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataSourceVersion, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataSourceVersionModel> PUTDataSourceDefinitionValues([WorkflowExpression] Func<string> dataSourceId, [WorkflowExpression] Func<string> dataSourceVersion, [WorkflowExpression] Func<JToken[]> values = null)
        {
            SourceExpression.Validate(dataSourceId, nameof(dataSourceId), required: true);
            SourceExpression.Validate(dataSourceVersion, nameof(dataSourceVersion), required: true);
            SourceExpression.Validate(values, nameof(values), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/DataSource/{0}/Versions/{1}/Definition/Values", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataSourceId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(dataSourceVersion, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = SourceExpressionConverter.ConvertToken(values);
                return callPayload;
            }

            return new ApiConnectionAction<DataSourceVersionModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapModel[]> GETSmaps()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/v1/Smaps";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmapModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapModel> GETSmap([WorkflowExpression] Func<string> smapId)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmapModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapDataFormat([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<DataRecordApi[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<string> GETSmapDataReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Data.pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi[]> GETSmapVersionData([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<DataRecordApi[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction DELETESmapVersionData([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<stateInput> state = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(state, nameof(state), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> POSTSmapsDataVersion([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> tasktitle, [WorkflowExpression] Func<string> taskuserEmail = null, [WorkflowExpression] Func<string> taskcomment = null, [WorkflowExpression] Func<bool> taskhasPriority = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(tasktitle, nameof(tasktitle), required: true);
            SourceExpression.Validate(taskuserEmail, nameof(taskuserEmail), required: false);
            SourceExpression.Validate(taskcomment, nameof(taskcomment), required: false);
            SourceExpression.Validate(taskhasPriority, nameof(taskhasPriority), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Data", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var task = new JObject();
                var taskpropCount = 0;
                if (taskuserEmail != null)
                {
                    task["userEmail"] = SourceExpressionConverter.ConvertToken(taskuserEmail);
                    taskpropCount++;
                }

                taskpropCount++;
                task["title"] = SourceExpressionConverter.ConvertToken(tasktitle);
                if (taskcomment != null)
                {
                    task["comment"] = SourceExpressionConverter.ConvertToken(taskcomment);
                    taskpropCount++;
                }

                if (taskhasPriority != null)
                {
                    task["hasPriority"] = SourceExpressionConverter.ConvertToken(taskhasPriority);
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
                return callPayload;
            }

            return new ApiConnectionAction<DataRecordApi>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<string> GETSmapVersionDataReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<stateInput> state = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            SourceExpression.Validate(state, nameof(state), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data.pdf", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                if (state != null)
                    callPayload.Queries["state"] = SourceExpressionConverter.Convert(state);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<string> GETSmapVersionRecordReport([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<formatInput> format, [WorkflowExpression] Func<bool> markAsExported = null, [WorkflowExpression] Func<bool> useDefault = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(format, nameof(format), required: true);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            SourceExpression.Validate(useDefault, nameof(useDefault), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}.{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(format, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                callPayload.Queries["useDefault"] = Convert.ToString(false);
                if (useDefault != null)
                    callPayload.Queries["useDefault"] = SourceExpressionConverter.ConvertO(useDefault);
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> GETSmapVersionRecordFormat([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<formatInput> format = null, [WorkflowExpression] Func<bool> markAsExported = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(format, nameof(format), required: false);
            SourceExpression.Validate(markAsExported, nameof(markAsExported), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["format"] = Convert.ToString("Json");
                if (format != null)
                    callPayload.Queries["format"] = SourceExpressionConverter.Convert(format);
                callPayload.Queries["markAsExported"] = Convert.ToString(false);
                if (markAsExported != null)
                    callPayload.Queries["markAsExported"] = SourceExpressionConverter.ConvertO(markAsExported);
                return callPayload;
            }

            return new ApiConnectionAction<DataRecordApi>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction DELETESmapVersionDataRecord([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "delete";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SingleFileValue[]> GETSmapVersionRecordFiles([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SingleFileValue[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IWorkflowAction GETSmapVersionRecordFile([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> recordId, [WorkflowExpression] Func<string> fileId)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(recordId, nameof(recordId), required: true);
            SourceExpression.Validate(fileId, nameof(fileId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions/{1}/Data/{2}/Files/{3}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(recordId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(fileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<DataRecordApi> PUTSmapVersionTaskState([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version, [WorkflowExpression] Func<string> taskId, [WorkflowExpression] Func<stateactionInput> stateaction = null, [WorkflowExpression] Func<string> stateuserEmail = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            SourceExpression.Validate(taskId, nameof(taskId), required: true);
            SourceExpression.Validate(stateaction, nameof(stateaction), required: false);
            SourceExpression.Validate(stateuserEmail, nameof(stateuserEmail), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Tasks/{2}/State", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(taskId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var state = new JObject();
                var statepropCount = 0;
                if (stateaction != null)
                {
                    state["action"] = SourceExpressionConverter.Convert(stateaction);
                    statepropCount++;
                }

                if (stateuserEmail != null)
                {
                    state["userEmail"] = SourceExpressionConverter.ConvertToken(stateuserEmail);
                    statepropCount++;
                }

                if (statepropCount > 0)
                {
                    callPayload.Body = state;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DataRecordApi>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapVersionModel> PUTSmapVersionsCurrentDataSourcesUpdate([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<bool> updateEditVersion = null)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(updateEditVersion, nameof(updateEditVersion), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/Current/DataSources/Update", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "put";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["updateEditVersion"] = Convert.ToString(false);
                if (updateEditVersion != null)
                    callPayload.Queries["updateEditVersion"] = SourceExpressionConverter.ConvertO(updateEditVersion);
                return callPayload;
            }

            return new ApiConnectionAction<SmapVersionModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapVersionModel[]> GETSmapVersions([WorkflowExpression] Func<string> smapId)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/v1/Smaps/{0}/Versions", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmapVersionModel[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<SmapVersionModel> GETSmapVersion([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<SmapVersionModel>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "smapone")]
        public IBodyWorkflowAction<JToken> GETSmapVersionSchema([WorkflowExpression] Func<string> smapId, [WorkflowExpression] Func<string> version)
        {
            SourceExpression.Validate(smapId, nameof(smapId), required: true);
            SourceExpression.Validate(version, nameof(version), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/intern/Smaps/{0}/Versions/{1}/Schema", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(smapId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(version, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
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

    public enum UserInfoModelSourceType
    {
        SmapOne,
        Telekom,
        Apple,
        Stripe
    }

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

    public enum DataRecordApiSchemaVersionType
    {
        _1 = 1
    }

    public enum DataRecordApiRecordTypeType
    {
        [EnumMember(Value = "Task")]
        TaskObject,
        Record
    }

    public enum formatInput
    {
        Json,
        Xml
    }

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