//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class InfoshareActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogonResponse> Logon([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyusername, [WorkflowExpression] Func<string> bodypassword, [WorkflowExpression] Func<string> bodytenantname = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Logon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["Username"] = SourceExpressionConverter.ConvertToken(bodyusername);
                bodypropCount++;
                body["Password"] = SourceExpressionConverter.ConvertToken(bodypassword);
                if (bodytenantname != null)
                {
                    body["Tenantname"] = SourceExpressionConverter.ConvertToken(bodytenantname);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LogonResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseTaskAndAssignToUsersResponse> CloseTaskAndAssignToUsers([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId, [WorkflowExpression] Func<string> bodyassignUserLoginNames, [WorkflowExpression] Func<string> bodytaskId = null, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CloseTaskAndAssignToUsers";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["ProcessId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodytaskId != null)
                {
                    body["TaskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                bodypropCount++;
                body["AssignUserLoginNames"] = SourceExpressionConverter.ConvertToken(bodyassignUserLoginNames);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseTaskAndAssignToUsersResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogoffResponse> Logoff([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/Logoff";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LogoffResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetDocumentPropertiesResponseItem[]> GetDocumentProperties([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyculture = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/GetDocumentProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["DocumentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyculture != null)
                {
                    body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentPropertiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetProcessPropertiesResponseItem[]> GetProcessProperties([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId, [WorkflowExpression] Func<string> bodyculture = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/GetProcessProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["ProcessId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodyculture != null)
                {
                    body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetProcessPropertiesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<JToken> GetFileContent([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodyversionId = null, [WorkflowExpression] Func<string> bodydocumentDataId = null, [WorkflowExpression] Func<string> bodyrenditionId = null, [WorkflowExpression] Func<bool> bodyignoreHashValidation = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/GetFileContent";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["DocumentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyversionId != null)
                {
                    body["VersionId"] = SourceExpressionConverter.ConvertToken(bodyversionId);
                    bodypropCount++;
                }

                if (bodydocumentDataId != null)
                {
                    body["DocumentDataId"] = SourceExpressionConverter.ConvertToken(bodydocumentDataId);
                    bodypropCount++;
                }

                if (bodyrenditionId != null)
                {
                    body["RenditionId"] = SourceExpressionConverter.ConvertToken(bodyrenditionId);
                    bodypropCount++;
                }

                if (bodyignoreHashValidation != null)
                {
                    if (bodyignoreHashValidation != null)
                    {
                        body["IgnoreHashValidation"] = SourceExpressionConverter.ConvertToken(bodyignoreHashValidation);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["IgnoreHashValidation"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseProcessResponse> CloseProcess([WorkflowExpression] Func<string> archiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId, [WorkflowExpression] Func<string> bodycomment = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Process/CloseProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = SourceExpressionConverter.ConvertO(archiveUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["connectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["processId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseProcessResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<LogonWithHashedPasswordResponse> LogonWithHashedPassword([WorkflowExpression] Func<string> archiveUrl, [WorkflowExpression] Func<string> bodyuserName, [WorkflowExpression] Func<string> bodypasswordHashed, [WorkflowExpression] Func<string> bodytenantName = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Authentication/Logon";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = SourceExpressionConverter.ConvertO(archiveUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["userName"] = SourceExpressionConverter.ConvertToken(bodyuserName);
                bodypropCount++;
                body["passwordHashed"] = SourceExpressionConverter.ConvertToken(bodypasswordHashed);
                if (bodytenantName != null)
                {
                    body["tenantName"] = SourceExpressionConverter.ConvertToken(bodytenantName);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<LogonWithHashedPasswordResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CloseTaskResponse> CloseTask([WorkflowExpression] Func<string> archiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId, [WorkflowExpression] Func<bool> bodyassignUsers, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodytaskId = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Process/CloseTask";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = SourceExpressionConverter.ConvertO(archiveUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["connectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["processId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodycomment != null)
                {
                    body["comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodytaskId != null)
                {
                    body["taskId"] = SourceExpressionConverter.ConvertToken(bodytaskId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["assignUsers"] = SourceExpressionConverter.ConvertToken(bodyassignUsers);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CloseTaskResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetDocumentResponse> GetDocument([WorkflowExpression] Func<string> archiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Document/GetDocument";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = SourceExpressionConverter.ConvertO(archiveUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["connectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["documentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetDocumentResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetProcessResponse> GetProcess([WorkflowExpression] Func<string> archiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/Process/GetProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ArchiveUrl"] = SourceExpressionConverter.ConvertO(archiveUrl);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["connectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["processId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetProcessResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<JToken> GetFileContentConverted([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodytargetFormat, [WorkflowExpression] Func<string> bodyversionId = null, [WorkflowExpression] Func<string> bodydocumentDataId = null, [WorkflowExpression] Func<string> bodyrenditionId = null, [WorkflowExpression] Func<bool> bodyaddAnnotatins = null, [WorkflowExpression] Func<bool> bodyaddOverlay = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/GetFileContentConverted";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["DocumentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyversionId != null)
                {
                    body["VersionId"] = SourceExpressionConverter.ConvertToken(bodyversionId);
                    bodypropCount++;
                }

                if (bodydocumentDataId != null)
                {
                    body["DocumentDataId"] = SourceExpressionConverter.ConvertToken(bodydocumentDataId);
                    bodypropCount++;
                }

                if (bodyrenditionId != null)
                {
                    body["RenditionId"] = SourceExpressionConverter.ConvertToken(bodyrenditionId);
                    bodypropCount++;
                }

                bodypropCount++;
                body["TargetFormat"] = SourceExpressionConverter.ConvertToken(bodytargetFormat);
                if (bodyaddAnnotatins != null)
                {
                    if (bodyaddAnnotatins != null)
                    {
                        body["AddAnnotatins"] = SourceExpressionConverter.ConvertToken(bodyaddAnnotatins);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["AddAnnotatins"] = true;
                    bodypropCount++;
                }

                if (bodyaddOverlay != null)
                {
                    if (bodyaddOverlay != null)
                    {
                        body["AddOverlay"] = SourceExpressionConverter.ConvertToken(bodyaddOverlay);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["AddOverlay"] = true;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CreateProcessResponse> CreateProcess([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessTemplateName, [WorkflowExpression] Func<string> bodyprocessProperties = null, [WorkflowExpression] Func<string> bodycustomProperties = null, [WorkflowExpression] Func<string> bodydocumentIds = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyculture = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateProcess";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                if (bodyprocessProperties != null)
                {
                    body["ProcessProperties"] = SourceExpressionConverter.ConvertToken(bodyprocessProperties);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["CustomProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodydocumentIds != null)
                {
                    body["DocumentIds"] = SourceExpressionConverter.ConvertToken(bodydocumentIds);
                    bodypropCount++;
                }

                bodypropCount++;
                body["ProcessTemplateName"] = SourceExpressionConverter.ConvertToken(bodyprocessTemplateName);
                if (bodydueDate != null)
                {
                    body["DueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    body["Priority"] = SourceExpressionConverter.Convert(bodypriority);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateProcessResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableGetRecordsResponse> UserTableGetRecords([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyuserTable, [WorkflowExpression] Func<string> bodywhereClause = null, [WorkflowExpression] Func<string> bodyorderByClause = null, [WorkflowExpression] Func<bool> bodyaddColumnHeaders = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UserTableGetRecords";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["UserTable"] = SourceExpressionConverter.ConvertToken(bodyuserTable);
                if (bodywhereClause != null)
                {
                    body["WhereClause"] = SourceExpressionConverter.ConvertToken(bodywhereClause);
                    bodypropCount++;
                }

                if (bodyorderByClause != null)
                {
                    body["OrderByClause"] = SourceExpressionConverter.ConvertToken(bodyorderByClause);
                    bodypropCount++;
                }

                if (bodyaddColumnHeaders != null)
                {
                    body["AddColumnHeaders"] = SourceExpressionConverter.ConvertToken(bodyaddColumnHeaders);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTableGetRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableImportDataResponse> UserTableImportData([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyuserTable, [WorkflowExpression] Func<string> bodyvalues, [WorkflowExpression] Func<bool> bodydeleteAllValues = null, [WorkflowExpression] Func<bool> bodyfirstRowContainsColumnHeaders = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UserTableImportData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["UserTable"] = SourceExpressionConverter.ConvertToken(bodyuserTable);
                bodypropCount++;
                body["Values"] = SourceExpressionConverter.ConvertToken(bodyvalues);
                if (bodydeleteAllValues != null)
                {
                    if (bodydeleteAllValues != null)
                    {
                        body["DeleteAllValues"] = SourceExpressionConverter.ConvertToken(bodydeleteAllValues);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["DeleteAllValues"] = false;
                    bodypropCount++;
                }

                if (bodyfirstRowContainsColumnHeaders != null)
                {
                    if (bodyfirstRowContainsColumnHeaders != null)
                    {
                        body["FirstRowContainsColumnHeaders"] = SourceExpressionConverter.ConvertToken(bodyfirstRowContainsColumnHeaders);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["FirstRowContainsColumnHeaders"] = false;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTableImportDataResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableCreateTableResponse> UserTableCreateTable([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyuserTable, [WorkflowExpression] Func<string> bodycolumnHeaders)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UserTableCreateTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["UserTable"] = SourceExpressionConverter.ConvertToken(bodyuserTable);
                bodypropCount++;
                body["ColumnHeaders"] = SourceExpressionConverter.ConvertToken(bodycolumnHeaders);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTableCreateTableResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableDeleteRecordsResponse> UserTableDeleteRecords([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyuserTable, [WorkflowExpression] Func<string> bodywhereClause = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UserTableDeleteRecords";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["UserTable"] = SourceExpressionConverter.ConvertToken(bodyuserTable);
                if (bodywhereClause != null)
                {
                    body["WhereClause"] = SourceExpressionConverter.ConvertToken(bodywhereClause);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTableDeleteRecordsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<MergePDFDocumentsToVersionResponse> MergePDFDocumentsToVersion([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodydocumentIdToAppend, [WorkflowExpression] Func<bool> bodyforceUndoCheckout = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/MergePDFDocumentsToVersion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["DocumentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                bodypropCount++;
                body["DocumentIdToAppend"] = SourceExpressionConverter.ConvertToken(bodydocumentIdToAppend);
                if (bodyforceUndoCheckout != null)
                {
                    body["ForceUndoCheckout"] = SourceExpressionConverter.ConvertToken(bodyforceUndoCheckout);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<MergePDFDocumentsToVersionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<ProcessSearchResponse> ProcessSearch([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyconditions = null, [WorkflowExpression] Func<string> bodyresultProperties = null, [WorkflowExpression] Func<string> bodymaxSerchResults = null, [WorkflowExpression] Func<string> bodyculture = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ProcessSearch";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                if (bodyconditions != null)
                {
                    body["Conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                if (bodyresultProperties != null)
                {
                    body["ResultProperties"] = SourceExpressionConverter.ConvertToken(bodyresultProperties);
                    bodypropCount++;
                }

                if (bodymaxSerchResults != null)
                {
                    body["MaxSerchResults"] = SourceExpressionConverter.ConvertToken(bodymaxSerchResults);
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    if (bodyculture != null)
                    {
                        body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Culture"] = "de";
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProcessSearchResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UserTableUpdateRowResponse> UserTableUpdateRow([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyuserTable, [WorkflowExpression] Func<string> bodyrowData)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UserTableUpdateRow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["UserTable"] = SourceExpressionConverter.ConvertToken(bodyuserTable);
                bodypropCount++;
                body["RowData"] = SourceExpressionConverter.ConvertToken(bodyrowData);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UserTableUpdateRowResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<GetSelectionResponse> GetSelection([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyselectionId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/GetSelection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["SelectionId"] = SourceExpressionConverter.ConvertToken(bodyselectionId);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GetSelectionResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<CreateDocumentV2Response> CreateDocument([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentTitle, [WorkflowExpression] Func<string> bodyfileContent, [WorkflowExpression] Func<string> bodyimportTemplate = null, [WorkflowExpression] Func<string> bodydocumentProperties = null, [WorkflowExpression] Func<string> bodyblog = null, [WorkflowExpression] Func<string> bodyculture = null, [WorkflowExpression] Func<string> bodyinfoStore = null, [WorkflowExpression] Func<string> bodylifeCycle = null, [WorkflowExpression] Func<string> bodyprotectionDomain = null, [WorkflowExpression] Func<bodyuploadMethodInput> bodyuploadMethod = null, [WorkflowExpression] Func<string> bodyoriginalFileFormat = null, [WorkflowExpression] Func<int> bodychunkSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/CreateDocumentV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["DocumentTitle"] = SourceExpressionConverter.ConvertToken(bodydocumentTitle);
                if (bodyimportTemplate != null)
                {
                    body["ImportTemplate"] = SourceExpressionConverter.ConvertToken(bodyimportTemplate);
                    bodypropCount++;
                }

                if (bodydocumentProperties != null)
                {
                    body["DocumentProperties"] = SourceExpressionConverter.ConvertToken(bodydocumentProperties);
                    bodypropCount++;
                }

                if (bodyblog != null)
                {
                    body["Blog"] = SourceExpressionConverter.ConvertToken(bodyblog);
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    if (bodyculture != null)
                    {
                        body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Culture"] = "de";
                    bodypropCount++;
                }

                if (bodyinfoStore != null)
                {
                    body["InfoStore"] = SourceExpressionConverter.ConvertToken(bodyinfoStore);
                    bodypropCount++;
                }

                if (bodylifeCycle != null)
                {
                    body["LifeCycle"] = SourceExpressionConverter.ConvertToken(bodylifeCycle);
                    bodypropCount++;
                }

                if (bodyprotectionDomain != null)
                {
                    body["ProtectionDomain"] = SourceExpressionConverter.ConvertToken(bodyprotectionDomain);
                    bodypropCount++;
                }

                if (bodyuploadMethod != null)
                {
                    if (bodyuploadMethod != null)
                    {
                        body["UploadMethod"] = SourceExpressionConverter.Convert(bodyuploadMethod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["UploadMethod"] = "UploadFileBytesLarge";
                    bodypropCount++;
                }

                if (bodyoriginalFileFormat != null)
                {
                    body["OriginalFileFormat"] = SourceExpressionConverter.ConvertToken(bodyoriginalFileFormat);
                    bodypropCount++;
                }

                if (bodychunkSize != null)
                {
                    if (bodychunkSize != null)
                    {
                        body["ChunkSize"] = SourceExpressionConverter.ConvertToken(bodychunkSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ChunkSize"] = 262144;
                    bodypropCount++;
                }

                bodypropCount++;
                body["FileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateDocumentV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<DocumentSearchV2Response> DocumentSearch([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyconditions = null, [WorkflowExpression] Func<string> bodymaxSerchResults = null, [WorkflowExpression] Func<string> bodyresultProperties = null, [WorkflowExpression] Func<string> bodyculture = null, [WorkflowExpression] Func<string> bodystores = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/DocumentSearchV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                if (bodyconditions != null)
                {
                    body["Conditions"] = SourceExpressionConverter.ConvertToken(bodyconditions);
                    bodypropCount++;
                }

                if (bodymaxSerchResults != null)
                {
                    body["MaxSerchResults"] = SourceExpressionConverter.ConvertToken(bodymaxSerchResults);
                    bodypropCount++;
                }

                if (bodyresultProperties != null)
                {
                    body["ResultProperties"] = SourceExpressionConverter.ConvertToken(bodyresultProperties);
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    if (bodyculture != null)
                    {
                        body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Culture"] = "de";
                    bodypropCount++;
                }

                if (bodystores != null)
                {
                    body["Stores"] = SourceExpressionConverter.ConvertToken(bodystores);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<DocumentSearchV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UpdateDocumentV2Response> UpdateDocument([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodydocumentId, [WorkflowExpression] Func<string> bodydocumentTitle = null, [WorkflowExpression] Func<string> bodydocumentProperties = null, [WorkflowExpression] Func<string> bodyremoveDocumentProperties = null, [WorkflowExpression] Func<string> bodyculture = null, [WorkflowExpression] Func<string> bodyprotectionDomain = null, [WorkflowExpression] Func<string> bodyblog = null, [WorkflowExpression] Func<bodyuploadMethodInput> bodyuploadMethod = null, [WorkflowExpression] Func<string> bodyfileContent = null, [WorkflowExpression] Func<bool> bodyforceUndoCheckout = null, [WorkflowExpression] Func<int> bodychunkSize = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UpdateDocumentV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                if (bodydocumentTitle != null)
                {
                    body["DocumentTitle"] = SourceExpressionConverter.ConvertToken(bodydocumentTitle);
                    bodypropCount++;
                }

                if (bodydocumentProperties != null)
                {
                    body["DocumentProperties"] = SourceExpressionConverter.ConvertToken(bodydocumentProperties);
                    bodypropCount++;
                }

                if (bodyremoveDocumentProperties != null)
                {
                    body["RemoveDocumentProperties"] = SourceExpressionConverter.ConvertToken(bodyremoveDocumentProperties);
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    if (bodyculture != null)
                    {
                        body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Culture"] = "de";
                    bodypropCount++;
                }

                bodypropCount++;
                body["DocumentId"] = SourceExpressionConverter.ConvertToken(bodydocumentId);
                if (bodyprotectionDomain != null)
                {
                    body["ProtectionDomain"] = SourceExpressionConverter.ConvertToken(bodyprotectionDomain);
                    bodypropCount++;
                }

                if (bodyblog != null)
                {
                    body["Blog"] = SourceExpressionConverter.ConvertToken(bodyblog);
                    bodypropCount++;
                }

                if (bodyuploadMethod != null)
                {
                    if (bodyuploadMethod != null)
                    {
                        body["UploadMethod"] = SourceExpressionConverter.Convert(bodyuploadMethod);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["UploadMethod"] = "UploadFileBytesLarge";
                    bodypropCount++;
                }

                if (bodyfileContent != null)
                {
                    body["FileContent"] = SourceExpressionConverter.ConvertToken(bodyfileContent);
                    bodypropCount++;
                }

                if (bodyforceUndoCheckout != null)
                {
                    body["ForceUndoCheckout"] = SourceExpressionConverter.ConvertToken(bodyforceUndoCheckout);
                    bodypropCount++;
                }

                if (bodychunkSize != null)
                {
                    if (bodychunkSize != null)
                    {
                        body["ChunkSize"] = SourceExpressionConverter.ConvertToken(bodychunkSize);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ChunkSize"] = 262144;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateDocumentV2Response>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "infoshare")]
        public IBodyWorkflowAction<UpdateProcessV2Response> UpdateProcess([WorkflowExpression] Func<string> bodyarchiveUrl, [WorkflowExpression] Func<string> bodyconnectionId, [WorkflowExpression] Func<string> bodyprocessId, [WorkflowExpression] Func<string> bodyprocessProperties = null, [WorkflowExpression] Func<string> bodyremoveProcessProperties = null, [WorkflowExpression] Func<string> bodycustomProperties = null, [WorkflowExpression] Func<string> bodycomment = null, [WorkflowExpression] Func<string> bodyassignUserLoginNames = null, [WorkflowExpression] Func<string> bodyaddDocumentIds = null, [WorkflowExpression] Func<string> bodyremoveDocumentIds = null, [WorkflowExpression] Func<string> bodydueDate = null, [WorkflowExpression] Func<bodypriorityInput> bodypriority = null, [WorkflowExpression] Func<string> bodyculture = null, [WorkflowExpression] Func<bool> bodyforceUndoCheckout = null, [WorkflowExpression] Func<string> bodyprotectionDomain = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/UpdateProcessV2";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ArchiveUrl"] = SourceExpressionConverter.ConvertToken(bodyarchiveUrl);
                bodypropCount++;
                body["ConnectionId"] = SourceExpressionConverter.ConvertToken(bodyconnectionId);
                bodypropCount++;
                body["ProcessId"] = SourceExpressionConverter.ConvertToken(bodyprocessId);
                if (bodyprocessProperties != null)
                {
                    body["ProcessProperties"] = SourceExpressionConverter.ConvertToken(bodyprocessProperties);
                    bodypropCount++;
                }

                if (bodyremoveProcessProperties != null)
                {
                    body["RemoveProcessProperties"] = SourceExpressionConverter.ConvertToken(bodyremoveProcessProperties);
                    bodypropCount++;
                }

                if (bodycustomProperties != null)
                {
                    body["CustomProperties"] = SourceExpressionConverter.ConvertToken(bodycustomProperties);
                    bodypropCount++;
                }

                if (bodycomment != null)
                {
                    body["Comment"] = SourceExpressionConverter.ConvertToken(bodycomment);
                    bodypropCount++;
                }

                if (bodyassignUserLoginNames != null)
                {
                    body["AssignUserLoginNames"] = SourceExpressionConverter.ConvertToken(bodyassignUserLoginNames);
                    bodypropCount++;
                }

                if (bodyaddDocumentIds != null)
                {
                    body["AddDocumentIds"] = SourceExpressionConverter.ConvertToken(bodyaddDocumentIds);
                    bodypropCount++;
                }

                if (bodyremoveDocumentIds != null)
                {
                    body["RemoveDocumentIds"] = SourceExpressionConverter.ConvertToken(bodyremoveDocumentIds);
                    bodypropCount++;
                }

                if (bodydueDate != null)
                {
                    body["DueDate"] = SourceExpressionConverter.ConvertToken(bodydueDate);
                    bodypropCount++;
                }

                if (bodypriority != null)
                {
                    if (bodypriority != null)
                    {
                        body["Priority"] = SourceExpressionConverter.Convert(bodypriority);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Priority"] = "Normal";
                    bodypropCount++;
                }

                if (bodyculture != null)
                {
                    if (bodyculture != null)
                    {
                        body["Culture"] = SourceExpressionConverter.ConvertToken(bodyculture);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["Culture"] = "de";
                    bodypropCount++;
                }

                if (bodyforceUndoCheckout != null)
                {
                    if (bodyforceUndoCheckout != null)
                    {
                        body["ForceUndoCheckout"] = SourceExpressionConverter.ConvertToken(bodyforceUndoCheckout);
                        bodypropCount++;
                    }

                    bodypropCount++;
                }
                else
                {
                    body["ForceUndoCheckout"] = true;
                    bodypropCount++;
                }

                if (bodyprotectionDomain != null)
                {
                    body["ProtectionDomain"] = SourceExpressionConverter.ConvertToken(bodyprotectionDomain);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<UpdateProcessV2Response>(BuildSourceInput);
        }
    }

    public class InfoshareTriggers([ConnectionName] string connectionId)
    {
    }

    public class LogonResponse
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("connectionTimeoutSeconds")]
        public int ConnectionTimeoutSeconds { get; set; }

        [JsonProperty("isApplicationLicence")]
        public string IsApplicationLicence { get; set; }

        [JsonProperty("isConcurrentLicence")]
        public string IsConcurrentLicence { get; set; }

        [JsonProperty("isNamedLicence")]
        public string IsNamedLicence { get; set; }

        [JsonProperty("isVerificationCodeNeeded")]
        public string IsVerificationCodeNeeded { get; set; }

        [JsonProperty("possibleTwoWayAuthenticationType")]
        public string PossibleTwoWayAuthenticationType { get; set; }

        [JsonProperty("twoWayAuthenticationTargetMail")]
        public string TwoWayAuthenticationTargetMail { get; set; }
    }

    public class CloseTaskAndAssignToUsersResponse
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public CloseTaskAndAssignToUsersResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string[] IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CloseTaskAndAssignToUsersResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class LogoffResponse
    {
        public string LogoffResult { get; set; }
    }

    public class GetDocumentPropertiesResponseItem
    {
        [JsonProperty("globalValues")]
        public GetDocumentPropertiesResponseItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class GetDocumentPropertiesResponseItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public GetDocumentPropertiesResponseItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetDocumentPropertiesResponseItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class GetProcessPropertiesResponseItem
    {
        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class CloseProcessResponse
    {
        public CloseProcessResponseCloseProcessResultType CloseProcessResult { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultType
    {
        public string[] AccessRightsEnumList { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItem[] CompletedTasks { get; set; }
        public string CreatedDate { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCurrentTaskType CurrentTask { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public string[] DocumentIds { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public CloseProcessResponseCloseProcessResultTypeNameType Name { get; set; }
        public JToken[] PluginStream { get; set; }
        public string PriorityEnum { get; set; }
        public string ProcessTemplateId { get; set; }
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public int SessionCount { get; set; }
        public string StatusEnum { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItem
    {
        public string Action { get; set; }
        public JToken[] AssignedUserIds { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItemCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public JToken[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCompletedTasksTypeItemCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCurrentTaskType
    {
        public string Action { get; set; }
        public string[] AssignedUserIds { get; set; }
        public CloseProcessResponseCloseProcessResultTypeCurrentTaskTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public string[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCurrentTaskTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeCustomPropertiesTypeItem
    {
        public string CustomPropertyTypeEnum { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeNameType
    {
        public CloseProcessResponseCloseProcessResultTypeNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypeNameTypeValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItem
    {
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CloseProcessResponseCloseProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class LogonWithHashedPasswordResponse
    {
        public LogonWithHashedPasswordResponseLogonResultType LogonResult { get; set; }
    }

    public class LogonWithHashedPasswordResponseLogonResultType
    {
        public string ConnectionId { get; set; }
        public int ConnectionTimeoutSeconds { get; set; }
        public bool IsApplicationLicence { get; set; }
        public bool IsConcurrentLicence { get; set; }
        public bool IsNamedLicence { get; set; }
        public bool IsVerificationCodeNeeded { get; set; }
        public string JWTToken { get; set; }
        public string PossibleTwoWayAuthenticationType { get; set; }
        public string TwoWayAuthenticationTargetMail { get; set; }
    }

    public class CloseTaskResponse
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public CloseTaskResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedUserIds")]
        public string CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CloseTaskResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class GetDocumentResponse
    {
        public GetDocumentResponseGetDocumentResultType GetDocumentResult { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultType
    {
        public GetDocumentResponseGetDocumentResultTypeAbonnementsTypeItem[] Abonnements { get; set; }
        public string[] AccessRightsEnumList { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerType AnnotationManager { get; set; }
        public GetDocumentResponseGetDocumentResultTypeBlogsTypeItem[] Blogs { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItem[] DocumentData { get; set; }
        public bool HasOverlay { get; set; }
        public string Id { get; set; }
        public string ImportTemplateId { get; set; }
        public string InfoStoreId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeLifeCycleManagerType LifeCycleManager { get; set; }
        public int MainFileLength { get; set; }
        public string Name { get; set; }
        public int PageCount { get; set; }
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeRemindersTypeItem[] Reminders { get; set; }
        public int SessionCount { get; set; }
        public string SigningProfileId { get; set; }
        public string VersionId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAbonnementsTypeItem
    {
        public bool OnContentChange { get; set; }
        public bool OnDelete { get; set; }
        public bool OnMetadataChange { get; set; }
        public string UserId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerType
    {
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItem[] PostItAnnotations { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeRectangleAnnotationsTypeItem[] RectangleAnnotations { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItem[] TextAnnotations { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItem
    {
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType FontInfo { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public string Text { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType
    {
        public bool IsItalic { get; set; }
        public bool IsStrikeOut { get; set; }
        public bool IsUnderline { get; set; }
        public string Name { get; set; }
        public int Pitch { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeRectangleAnnotationsTypeItem
    {
        public int Color { get; set; }
        public string ColorHexCode { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public int Height { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public bool Transparent { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItem
    {
        public int BackgroundColor { get; set; }
        public string BackgroundColorHexCode { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType FontInfo { get; set; }
        public int ForegroundColor { get; set; }
        public string ForegroundColorHexCode { get; set; }
        public int Height { get; set; }
        public string Id { get; set; }
        public string ModifiedDate { get; set; }
        public int PageNumber { get; set; }
        public int Rotation { get; set; }
        public string SecurityLevelEnum { get; set; }
        public bool Selectable { get; set; }
        public string Text { get; set; }
        public bool Transparent { get; set; }
        public int Width { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType
    {
        public bool IsItalic { get; set; }
        public bool IsStrikeOut { get; set; }
        public bool IsUnderline { get; set; }
        public string Name { get; set; }
        public int Pitch { get; set; }
        public int Size { get; set; }
        public int Weight { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeBlogsTypeItem
    {
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItem
    {
        public JToken[] ContentProtections { get; set; }
        public string Extension { get; set; }
        public GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }
        public int[] HashValue { get; set; }
        public string Id { get; set; }
        public int PageCount { get; set; }
        public int Size { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        public string BlobPath { get; set; }
        public string BlobStoreId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeLifeCycleManagerType
    {
        public string CheckOutLifeCycleStateId { get; set; }
        public string LifeCycleEndDate { get; set; }
        public string LifeCycleStartDate { get; set; }
        public string LifeCycleStateId { get; set; }
        public string NextAutomaticLifeCycleStateId { get; set; }
        public string[] NextLifeCycleStates { get; set; }
        public GetDocumentResponseGetDocumentResultTypeLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
        public string LifeCycleId { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        public bool DeleteAfterExpiration { get; set; }
        public string Id { get; set; }
        public bool ProtectAnnotationChange { get; set; }
        public bool ProtectCheckOut { get; set; }
        public bool ProtectContentChange { get; set; }
        public bool ProtectDelete { get; set; }
        public bool ProtectPropertyChange { get; set; }
        public bool ProtectProtectionDomainChange { get; set; }
        public int ProtectionDurationTicks { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItem
    {
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class GetDocumentResponseGetDocumentResultTypeRemindersTypeItem
    {
        public string Description { get; set; }
        public int Interval { get; set; }
        public string ProcessTemplateId { get; set; }
        public string ReminderDate { get; set; }
        public string ReminderId { get; set; }
        public JToken[] SubjectIds { get; set; }
        public bool UseUserFromProcessTemplate { get; set; }
    }

    public class GetProcessResponse
    {
        public GetProcessResponseGetProcessResultType GetProcessResult { get; set; }
    }

    public class GetProcessResponseGetProcessResultType
    {
        public string[] AccessRightsEnumList { get; set; }
        public string CheckOutStateEnum { get; set; }
        public string CheckOutUserId { get; set; }
        public GetProcessResponseGetProcessResultTypeCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public GetProcessResponseGetProcessResultTypeCompletedTasksTypeItem[] CompletedTasks { get; set; }
        public string CreatedDate { get; set; }
        public GetProcessResponseGetProcessResultTypeCurrentTaskType CurrentTask { get; set; }
        public GetProcessResponseGetProcessResultTypeCustomPropertiesTypeItem[] CustomProperties { get; set; }
        public string[] DocumentIds { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public GetProcessResponseGetProcessResultTypeNameType Name { get; set; }
        public JToken[] PluginStream { get; set; }
        public string PriorityEnum { get; set; }
        public string ProcessTemplateId { get; set; }
        public GetProcessResponseGetProcessResultTypePropertiesTypeItem[] Properties { get; set; }
        public string ProtectionDomainId { get; set; }
        public int SessionCount { get; set; }
        public string StatusEnum { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCompletedTasksTypeItem
    {
        public string Action { get; set; }
        public JToken[] AssignedUserIds { get; set; }
        public GetProcessResponseGetProcessResultTypeCompletedTasksTypeItemCommentsTypeItem[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public JToken[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCompletedTasksTypeItemCommentsTypeItem
    {
        public string Date { get; set; }
        public string Id { get; set; }
        public string Text { get; set; }
        public string UserId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCurrentTaskType
    {
        public string Action { get; set; }
        public string[] AssignedUserIds { get; set; }
        public string[] Comments { get; set; }
        public string CompletedDate { get; set; }
        public string[] CompletedUserIds { get; set; }
        public string CreatedDate { get; set; }
        public string CreatorId { get; set; }
        public string Description { get; set; }
        public string DueDate { get; set; }
        public string Id { get; set; }
        public string[] IntendedUserIds { get; set; }
        public string ReminderDate { get; set; }
        public bool RequiresAllRecipients { get; set; }
        public bool ShowCloseTaskDialog { get; set; }
        public string StatusEnum { get; set; }
        public string TaskTemplateId { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeCustomPropertiesTypeItem
    {
        public string CustomPropertyTypeEnum { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeNameType
    {
        public GetProcessResponseGetProcessResultTypeNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypeNameTypeValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItem
    {
        public GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }
        public string PropertyTypeId { get; set; }
        public string[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItem
    {
        public GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class GetProcessResponseGetProcessResultTypePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        public string Culture { get; set; }
        public string Text { get; set; }
    }

    public class CreateProcessResponse
    {
        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("comments")]
        public CreateProcessResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedTasks")]
        public string[] CompletedTasks { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("currentTask")]
        public CreateProcessResponseCurrentTaskType CurrentTask { get; set; }

        [JsonProperty("customProperties")]
        public CreateProcessResponseCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public CreateProcessResponseNameType Name { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("pluginStream")]
        public string PluginStream { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("properties")]
        public CreateProcessResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }
    }

    public class CreateProcessResponseCommentsTypeItem
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class CreateProcessResponseCurrentTaskType
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("comments")]
        public string[] Comments { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("intendedUserIds")]
        public string[] IntendedUserIds { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }
    }

    public class CreateProcessResponseCustomPropertiesTypeItem
    {
        [JsonProperty("customPropertyTypeEnum")]
        public string CustomPropertyTypeEnum { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public class CreateProcessResponseNameType
    {
        [JsonProperty("values")]
        public CreateProcessResponseNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class CreateProcessResponseNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItem
    {
        [JsonProperty("globalValues")]
        public CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CreateProcessResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public enum bodypriorityInput
    {
        Low,
        Normal,
        High
    }

    public class UserTableGetRecordsResponse
    {
        public string[][] UserTableGetRecordsResult { get; set; }
    }

    public class UserTableImportDataResponse
    {
        [JsonProperty("userTable")]
        public string UserTable { get; set; }

        [JsonProperty("insertedRows")]
        public int InsertedRows { get; set; }
    }

    public class UserTableCreateTableResponse
    {
        [JsonProperty("userTable")]
        public string UserTable { get; set; }
    }

    public class UserTableDeleteRecordsResponse
    {
        [JsonProperty("userTableDeleteRecordsResult")]
        public int UserTableDeleteRecordsResult { get; set; }
    }

    public class MergePDFDocumentsToVersionResponse
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("currentVersionId")]
        public string CurrentVersionId { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("properties")]
        public MergePDFDocumentsToVersionResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("blogs")]
        public MergePDFDocumentsToVersionResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("reminders")]
        public JToken[] Reminders { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("abonnements")]
        public JToken[] Abonnements { get; set; }

        [JsonProperty("annotationManager")]
        public MergePDFDocumentsToVersionResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("documentData")]
        public MergePDFDocumentsToVersionResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public MergePDFDocumentsToVersionResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }
    }

    public class MergePDFDocumentsToVersionResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public MergePDFDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class MergePDFDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public MergePDFDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class MergePDFDocumentsToVersionResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseAnnotationManagerType
    {
        [JsonProperty("textAnnotations")]
        public JToken[] TextAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public JToken[] RectangleAnnotations { get; set; }

        [JsonProperty("postItAnnotations")]
        public JToken[] PostItAnnotations { get; set; }

        [JsonProperty("stampAnnotations")]
        public JToken[] StampAnnotations { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public MergePDFDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("files")]
        public MergePDFDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }

        [JsonProperty("pageCount")]
        public string PageCount { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("hashValue")]
        public int[] HashValue { get; set; }

        [JsonProperty("contentProtections")]
        public JToken[] ContentProtections { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        [JsonProperty("blobStoreId")]
        public string BlobStoreId { get; set; }

        [JsonProperty("blobPath")]
        public string BlobPath { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseLifeCycleManagerType
    {
        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public JToken[] NextLifeCycleStates { get; set; }

        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public MergePDFDocumentsToVersionResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
    }

    public class MergePDFDocumentsToVersionResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }
    }

    public class ProcessSearchResponse
    {
        [JsonProperty("processes")]
        public ProcessSearchResponseProcessesTypeItem[] Processes { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("resumePoint")]
        public string ResumePoint { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItem
    {
        [JsonProperty("name")]
        public ProcessSearchResponseProcessesTypeItemNameType Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("properties")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemNameType
    {
        [JsonProperty("values")]
        public ProcessSearchResponseProcessesTypeItemNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class ProcessSearchResponseProcessesTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UserTableUpdateRowResponse
    {
        [JsonProperty("userTableUpdateRowResult")]
        public int UserTableUpdateRowResult { get; set; }
    }

    public class GetSelectionResponse
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("parentObjectId")]
        public GetSelectionResponseParentObjectIdType ParentObjectId { get; set; }

        [JsonProperty("objectIds")]
        public GetSelectionResponseObjectIdsTypeItem[] ObjectIds { get; set; }

        [JsonProperty("allObjectIds")]
        public GetSelectionResponseAllObjectIdsTypeItem[] AllObjectIds { get; set; }
    }

    public class GetSelectionResponseParentObjectIdType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class GetSelectionResponseObjectIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class GetSelectionResponseAllObjectIdsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("objectId")]
        public string ObjectId { get; set; }

        [JsonProperty("objectTypeEnum")]
        public string ObjectTypeEnum { get; set; }
    }

    public class CreateDocumentV2Response
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("currentVersionId")]
        public string CurrentVersionId { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("properties")]
        public CreateDocumentV2ResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("blogs")]
        public CreateDocumentV2ResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("reminders")]
        public JToken[] Reminders { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("abonnements")]
        public JToken[] Abonnements { get; set; }

        [JsonProperty("annotationManager")]
        public CreateDocumentV2ResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("documentData")]
        public CreateDocumentV2ResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public CreateDocumentV2ResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }
    }

    public class CreateDocumentV2ResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public CreateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class CreateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public CreateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class CreateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class CreateDocumentV2ResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }

    public class CreateDocumentV2ResponseAnnotationManagerType
    {
        [JsonProperty("textAnnotations")]
        public JToken[] TextAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public JToken[] RectangleAnnotations { get; set; }

        [JsonProperty("postItAnnotations")]
        public JToken[] PostItAnnotations { get; set; }

        [JsonProperty("stampAnnotations")]
        public JToken[] StampAnnotations { get; set; }
    }

    public class CreateDocumentV2ResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public CreateDocumentV2ResponseDocumentDataTypeItemRenditionsTypeItem[] Renditions { get; set; }
    }

    public class CreateDocumentV2ResponseDocumentDataTypeItemRenditionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("files")]
        public CreateDocumentV2ResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem[] Files { get; set; }

        [JsonProperty("pageCount")]
        public string PageCount { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("hashValue")]
        public int[] HashValue { get; set; }

        [JsonProperty("contentProtections")]
        public JToken[] ContentProtections { get; set; }
    }

    public class CreateDocumentV2ResponseDocumentDataTypeItemRenditionsTypeItemFilesTypeItem
    {
        [JsonProperty("blobStoreId")]
        public string BlobStoreId { get; set; }

        [JsonProperty("blobPath")]
        public string BlobPath { get; set; }
    }

    public class CreateDocumentV2ResponseLifeCycleManagerType
    {
        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public JToken[] NextLifeCycleStates { get; set; }

        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public CreateDocumentV2ResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }
    }

    public class CreateDocumentV2ResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }
    }

    public enum bodyuploadMethodInput
    {
        UploadFileBytesLarge,
        UploadStreamChunks,
        UploadStreamDirect,
        UploadFileBase64
    }

    public class DocumentSearchV2Response
    {
        [JsonProperty("documents")]
        public DocumentSearchV2ResponseDocumentsTypeItem[] Documents { get; set; }

        [JsonProperty("hasMore")]
        public bool HasMore { get; set; }

        [JsonProperty("resumePoint")]
        public string ResumePoint { get; set; }
    }

    public class DocumentSearchV2ResponseDocumentsTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("folderElementId")]
        public string FolderElementId { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("hasSignature")]
        public bool HasSignature { get; set; }

        [JsonProperty("hasBlog")]
        public bool HasBlog { get; set; }

        [JsonProperty("hasAnnotation")]
        public bool HasAnnotation { get; set; }

        [JsonProperty("hasLinks")]
        public bool HasLinks { get; set; }

        [JsonProperty("properties")]
        public DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("hasTempAccess")]
        public bool HasTempAccess { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }

        [JsonProperty("hasReminders")]
        public bool HasReminders { get; set; }

        [JsonProperty("hasAbonnement")]
        public bool HasAbonnement { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }
    }

    public class DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class DocumentSearchV2ResponseDocumentsTypeItemPropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateDocumentV2Response
    {
        [JsonProperty("abonnements")]
        public UpdateDocumentV2ResponseAbonnementsTypeItem[] Abonnements { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("annotationManager")]
        public UpdateDocumentV2ResponseAnnotationManagerType AnnotationManager { get; set; }

        [JsonProperty("blogs")]
        public UpdateDocumentV2ResponseBlogsTypeItem[] Blogs { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("documentData")]
        public UpdateDocumentV2ResponseDocumentDataTypeItem[] DocumentData { get; set; }

        [JsonProperty("hasOverlay")]
        public bool HasOverlay { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("importTemplateId")]
        public string ImportTemplateId { get; set; }

        [JsonProperty("infoStoreId")]
        public string InfoStoreId { get; set; }

        [JsonProperty("lifeCycleManager")]
        public UpdateDocumentV2ResponseLifeCycleManagerType LifeCycleManager { get; set; }

        [JsonProperty("mainFileLength")]
        public int MainFileLength { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pageCount")]
        public int PageCount { get; set; }

        [JsonProperty("properties")]
        public UpdateDocumentV2ResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("reminders")]
        public UpdateDocumentV2ResponseRemindersTypeItem[] Reminders { get; set; }

        [JsonProperty("signingProfileId")]
        public string SigningProfileId { get; set; }

        [JsonProperty("versionId")]
        public string VersionId { get; set; }
    }

    public class UpdateDocumentV2ResponseAbonnementsTypeItem
    {
        [JsonProperty("onContentChange")]
        public bool OnContentChange { get; set; }

        [JsonProperty("onDelete")]
        public bool OnDelete { get; set; }

        [JsonProperty("onMetadataChange")]
        public bool OnMetadataChange { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerType
    {
        [JsonProperty("postItAnnotations")]
        public UpdateDocumentV2ResponseAnnotationManagerTypePostItAnnotationsTypeItem[] PostItAnnotations { get; set; }

        [JsonProperty("rectangleAnnotations")]
        public UpdateDocumentV2ResponseAnnotationManagerTypeRectangleAnnotationsTypeItem[] RectangleAnnotations { get; set; }

        [JsonProperty("textAnnotations")]
        public UpdateDocumentV2ResponseAnnotationManagerTypeTextAnnotationsTypeItem[] TextAnnotations { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerTypePostItAnnotationsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("fontInfo")]
        public UpdateDocumentV2ResponseAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType FontInfo { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerTypePostItAnnotationsTypeItemFontInfoType
    {
        [JsonProperty("isItalic")]
        public bool IsItalic { get; set; }

        [JsonProperty("isStrikeOut")]
        public bool IsStrikeOut { get; set; }

        [JsonProperty("isUnderline")]
        public bool IsUnderline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pitch")]
        public int Pitch { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerTypeRectangleAnnotationsTypeItem
    {
        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("colorHexCode")]
        public string ColorHexCode { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("transparent")]
        public bool Transparent { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerTypeTextAnnotationsTypeItem
    {
        [JsonProperty("backgroundColor")]
        public int BackgroundColor { get; set; }

        [JsonProperty("backgroundColorHexCode")]
        public string BackgroundColorHexCode { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("fontInfo")]
        public UpdateDocumentV2ResponseAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType FontInfo { get; set; }

        [JsonProperty("foregroundColor")]
        public int ForegroundColor { get; set; }

        [JsonProperty("foregroundColorHexCode")]
        public string ForegroundColorHexCode { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("modifiedDate")]
        public string ModifiedDate { get; set; }

        [JsonProperty("pageNumber")]
        public int PageNumber { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }

        [JsonProperty("securityLevelEnum")]
        public string SecurityLevelEnum { get; set; }

        [JsonProperty("selectable")]
        public bool Selectable { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("transparent")]
        public bool Transparent { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }
    }

    public class UpdateDocumentV2ResponseAnnotationManagerTypeTextAnnotationsTypeItemFontInfoType
    {
        [JsonProperty("isItalic")]
        public bool IsItalic { get; set; }

        [JsonProperty("isStrikeOut")]
        public bool IsStrikeOut { get; set; }

        [JsonProperty("isUnderline")]
        public bool IsUnderline { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pitch")]
        public int Pitch { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }
    }

    public class UpdateDocumentV2ResponseBlogsTypeItem
    {
        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateDocumentV2ResponseDocumentDataTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("renditions")]
        public JToken[] Renditions { get; set; }
    }

    public class UpdateDocumentV2ResponseLifeCycleManagerType
    {
        [JsonProperty("checkOutLifeCycleStateId")]
        public string CheckOutLifeCycleStateId { get; set; }

        [JsonProperty("lifeCycleEndDate")]
        public string LifeCycleEndDate { get; set; }

        [JsonProperty("lifeCycleStartDate")]
        public string LifeCycleStartDate { get; set; }

        [JsonProperty("lifeCycleStateId")]
        public string LifeCycleStateId { get; set; }

        [JsonProperty("nextAutomaticLifeCycleStateId")]
        public string NextAutomaticLifeCycleStateId { get; set; }

        [JsonProperty("nextLifeCycleStates")]
        public string[] NextLifeCycleStates { get; set; }

        [JsonProperty("lifeCycleProtections")]
        public UpdateDocumentV2ResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem[] LifeCycleProtections { get; set; }

        [JsonProperty("lifeCycleId")]
        public string LifeCycleId { get; set; }
    }

    public class UpdateDocumentV2ResponseLifeCycleManagerTypeLifeCycleProtectionsTypeItem
    {
        [JsonProperty("deleteAfterExpiration")]
        public bool DeleteAfterExpiration { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectAnnotationChange")]
        public bool ProtectAnnotationChange { get; set; }

        [JsonProperty("protectCheckOut")]
        public bool ProtectCheckOut { get; set; }

        [JsonProperty("protectContentChange")]
        public bool ProtectContentChange { get; set; }

        [JsonProperty("protectDelete")]
        public bool ProtectDelete { get; set; }

        [JsonProperty("protectPropertyChange")]
        public bool ProtectPropertyChange { get; set; }

        [JsonProperty("protectProtectionDomainChange")]
        public bool ProtectProtectionDomainChange { get; set; }

        [JsonProperty("protectionDurationTicks")]
        public int ProtectionDurationTicks { get; set; }
    }

    public class UpdateDocumentV2ResponsePropertiesTypeItem
    {
        [JsonProperty("globalValues")]
        public UpdateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }

        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }
    }

    public class UpdateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public UpdateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class UpdateDocumentV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateDocumentV2ResponseRemindersTypeItem
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("interval")]
        public int Interval { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("reminderId")]
        public string ReminderId { get; set; }

        [JsonProperty("subjectIds")]
        public JToken[] SubjectIds { get; set; }

        [JsonProperty("useUserFromProcessTemplate")]
        public bool UseUserFromProcessTemplate { get; set; }
    }

    public class UpdateProcessV2Response
    {
        [JsonProperty("name")]
        public UpdateProcessV2ResponseNameType Name { get; set; }

        [JsonProperty("description")]
        public UpdateProcessV2ResponseDescriptionType Description { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("protectionDomainId")]
        public string ProtectionDomainId { get; set; }

        [JsonProperty("processTemplateId")]
        public string ProcessTemplateId { get; set; }

        [JsonProperty("properties")]
        public UpdateProcessV2ResponsePropertiesTypeItem[] Properties { get; set; }

        [JsonProperty("priorityEnum")]
        public string PriorityEnum { get; set; }

        [JsonProperty("pluginStream")]
        public string PluginStream { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("comments")]
        public UpdateProcessV2ResponseCommentsTypeItem[] Comments { get; set; }

        [JsonProperty("accessRightsEnumList")]
        public string[] AccessRightsEnumList { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("customProperties")]
        public UpdateProcessV2ResponseCustomPropertiesTypeItem[] CustomProperties { get; set; }

        [JsonProperty("currentTask")]
        public UpdateProcessV2ResponseCurrentTaskType CurrentTask { get; set; }

        [JsonProperty("completedTasks")]
        public UpdateProcessV2ResponseCompletedTasksTypeItem[] CompletedTasks { get; set; }

        [JsonProperty("documentIds")]
        public string[] DocumentIds { get; set; }

        [JsonProperty("checkOutStateEnum")]
        public string CheckOutStateEnum { get; set; }

        [JsonProperty("checkOutUserId")]
        public string CheckOutUserId { get; set; }

        [JsonProperty("sessionCount")]
        public int SessionCount { get; set; }
    }

    public class UpdateProcessV2ResponseNameType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseNameTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseNameTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseDescriptionType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseDescriptionTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseDescriptionTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponsePropertiesTypeItem
    {
        [JsonProperty("propertyTypeId")]
        public string PropertyTypeId { get; set; }

        [JsonProperty("values")]
        public string[] Values { get; set; }

        [JsonProperty("globalValues")]
        public UpdateProcessV2ResponsePropertiesTypeItemGlobalValuesTypeItem[] GlobalValues { get; set; }

        [JsonProperty("propertyTypeName")]
        public string PropertyTypeName { get; set; }

        [JsonProperty("propertyName")]
        public string PropertyName { get; set; }
    }

    public class UpdateProcessV2ResponsePropertiesTypeItemGlobalValuesTypeItem
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponsePropertiesTypeItemGlobalValuesTypeItemValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseCommentsTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseCustomPropertiesTypeItem
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("customPropertyTypeEnum")]
        public string CustomPropertyTypeEnum { get; set; }
    }

    public class UpdateProcessV2ResponseCurrentTaskType
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }

        [JsonProperty("comments")]
        public JToken[] Comments { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("intendedUserIds")]
        public JToken[] IntendedUserIds { get; set; }

        [JsonProperty("nameGlobal")]
        public UpdateProcessV2ResponseCurrentTaskTypeNameGlobalType NameGlobal { get; set; }

        [JsonProperty("descriptionGlobal")]
        public UpdateProcessV2ResponseCurrentTaskTypeDescriptionGlobalType DescriptionGlobal { get; set; }

        [JsonProperty("assignedUserCCIds")]
        public JToken[] AssignedUserCCIds { get; set; }

        [JsonProperty("deputyRepresentations")]
        public JToken[] DeputyRepresentations { get; set; }

        [JsonProperty("taskActionEnum")]
        public string TaskActionEnum { get; set; }
    }

    public class UpdateProcessV2ResponseCurrentTaskTypeNameGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseCurrentTaskTypeNameGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseCurrentTaskTypeNameGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseCurrentTaskTypeDescriptionGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseCurrentTaskTypeDescriptionGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseCurrentTaskTypeDescriptionGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseCompletedTasksTypeItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("creatorId")]
        public string CreatorId { get; set; }

        [JsonProperty("dueDate")]
        public string DueDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("completedDate")]
        public string CompletedDate { get; set; }

        [JsonProperty("taskTemplateId")]
        public string TaskTemplateId { get; set; }

        [JsonProperty("comments")]
        public JToken[] Comments { get; set; }

        [JsonProperty("reminderDate")]
        public string ReminderDate { get; set; }

        [JsonProperty("statusEnum")]
        public string StatusEnum { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("requiresAllRecipients")]
        public bool RequiresAllRecipients { get; set; }

        [JsonProperty("assignedUserIds")]
        public string[] AssignedUserIds { get; set; }

        [JsonProperty("completedUserIds")]
        public string[] CompletedUserIds { get; set; }

        [JsonProperty("showCloseTaskDialog")]
        public bool ShowCloseTaskDialog { get; set; }

        [JsonProperty("intendedUserIds")]
        public JToken[] IntendedUserIds { get; set; }

        [JsonProperty("nameGlobal")]
        public UpdateProcessV2ResponseCompletedTasksTypeItemNameGlobalType NameGlobal { get; set; }

        [JsonProperty("descriptionGlobal")]
        public UpdateProcessV2ResponseCompletedTasksTypeItemDescriptionGlobalType DescriptionGlobal { get; set; }

        [JsonProperty("assignedUserCCIds")]
        public JToken[] AssignedUserCCIds { get; set; }

        [JsonProperty("deputyRepresentations")]
        public JToken[] DeputyRepresentations { get; set; }

        [JsonProperty("taskActionEnum")]
        public string TaskActionEnum { get; set; }
    }

    public class UpdateProcessV2ResponseCompletedTasksTypeItemNameGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseCompletedTasksTypeItemNameGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseCompletedTasksTypeItemNameGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public class UpdateProcessV2ResponseCompletedTasksTypeItemDescriptionGlobalType
    {
        [JsonProperty("values")]
        public UpdateProcessV2ResponseCompletedTasksTypeItemDescriptionGlobalTypeValuesTypeItem[] Values { get; set; }
    }

    public class UpdateProcessV2ResponseCompletedTasksTypeItemDescriptionGlobalTypeValuesTypeItem
    {
        [JsonProperty("culture")]
        public string Culture { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Infoshare;

    public partial class WorkflowManagedActions
    {
        public InfoshareActions Infoshare(string connectionId) => new InfoshareActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public InfoshareTriggers Infoshare(string connectionId) => new InfoshareTriggers(connectionId);
    }
}