//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectuiActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration> UIADoesTopLevelWindowExist(Expression<Func<string>> uIADoesTopLevelWindowExistworkflow, Expression<Func<string>> uIADoesTopLevelWindowExistsearchClassName = null, Expression<Func<string>> uIADoesTopLevelWindowExistsearchWindowTitle = null, Expression<Func<int>> uIADoesTopLevelWindowExistsearchProcessId = null, Expression<Func<int>> uIADoesTopLevelWindowExistmatchIndex = null, Expression<Func<string>> uIADoesTopLevelWindowExistsearchFilter = null)
        {
            var __workflow_uIADoesTopLevelWindowExistworkflow = WorkflowExpression.Compile(uIADoesTopLevelWindowExistworkflow, nameof(uIADoesTopLevelWindowExistworkflow), required: true);
            var __workflow_uIADoesTopLevelWindowExistsearchClassName = WorkflowExpression.Compile(uIADoesTopLevelWindowExistsearchClassName, nameof(uIADoesTopLevelWindowExistsearchClassName), required: false);
            var __workflow_uIADoesTopLevelWindowExistsearchWindowTitle = WorkflowExpression.Compile(uIADoesTopLevelWindowExistsearchWindowTitle, nameof(uIADoesTopLevelWindowExistsearchWindowTitle), required: false);
            var __workflow_uIADoesTopLevelWindowExistsearchProcessId = WorkflowExpression.Compile(uIADoesTopLevelWindowExistsearchProcessId, nameof(uIADoesTopLevelWindowExistsearchProcessId), required: false);
            var __workflow_uIADoesTopLevelWindowExistmatchIndex = WorkflowExpression.Compile(uIADoesTopLevelWindowExistmatchIndex, nameof(uIADoesTopLevelWindowExistmatchIndex), required: false);
            var __workflow_uIADoesTopLevelWindowExistsearchFilter = WorkflowExpression.Compile(uIADoesTopLevelWindowExistsearchFilter, nameof(uIADoesTopLevelWindowExistsearchFilter), required: false);
            return new DeferredBodyAction<UIADoesTopLevelWindowExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesTopLevelWindowExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesTopLevelWindowExist = new JObject();
                var uIADoesTopLevelWindowExistpropCount = 0;
                if (__workflow_uIADoesTopLevelWindowExistsearchClassName != null)
                {
                    uIADoesTopLevelWindowExist["SearchClassName"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistsearchClassName);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (__workflow_uIADoesTopLevelWindowExistsearchWindowTitle != null)
                {
                    uIADoesTopLevelWindowExist["SearchWindowTitle"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistsearchWindowTitle);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (__workflow_uIADoesTopLevelWindowExistsearchProcessId != null)
                {
                    uIADoesTopLevelWindowExist["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistsearchProcessId);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (__workflow_uIADoesTopLevelWindowExistmatchIndex != null)
                {
                    if (__workflow_uIADoesTopLevelWindowExistmatchIndex != null)
                    {
                        uIADoesTopLevelWindowExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistmatchIndex);
                        uIADoesTopLevelWindowExistpropCount++;
                    }

                    uIADoesTopLevelWindowExistpropCount++;
                }
                else
                {
                    uIADoesTopLevelWindowExist["MatchIndex"] = 1;
                    uIADoesTopLevelWindowExistpropCount++;
                }

                if (__workflow_uIADoesTopLevelWindowExistsearchFilter != null)
                {
                    uIADoesTopLevelWindowExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistsearchFilter);
                    uIADoesTopLevelWindowExistpropCount++;
                }

                uIADoesTopLevelWindowExistpropCount++;
                uIADoesTopLevelWindowExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIADoesTopLevelWindowExistworkflow);
                if (uIADoesTopLevelWindowExistpropCount > 0)
                {
                    callPayload.Body = uIADoesTopLevelWindowExist;
                }

                return new ApiConnectionAction<UIADoesTopLevelWindowExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForTopLevelWindow(Expression<Func<string>> uIAGetHandleForTopLevelWindowworkflow, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchClassName = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchWindowTitle = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowsearchProcessId = null, Expression<Func<int>> uIAGetHandleForTopLevelWindowmatchIndex = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsearchFilter = null, Expression<Func<string>> uIAGetHandleForTopLevelWindowsortByColumn = null, Expression<Func<bool>> uIAGetHandleForTopLevelWindowmatchIndexAscending = null)
        {
            var __workflow_uIAGetHandleForTopLevelWindowworkflow = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowworkflow, nameof(uIAGetHandleForTopLevelWindowworkflow), required: true);
            var __workflow_uIAGetHandleForTopLevelWindowsearchClassName = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowsearchClassName, nameof(uIAGetHandleForTopLevelWindowsearchClassName), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowsearchWindowTitle = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowsearchWindowTitle, nameof(uIAGetHandleForTopLevelWindowsearchWindowTitle), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowsearchProcessId = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowsearchProcessId, nameof(uIAGetHandleForTopLevelWindowsearchProcessId), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowmatchIndex = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowmatchIndex, nameof(uIAGetHandleForTopLevelWindowmatchIndex), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowsearchFilter = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowsearchFilter, nameof(uIAGetHandleForTopLevelWindowsearchFilter), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowsortByColumn = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowsortByColumn, nameof(uIAGetHandleForTopLevelWindowsortByColumn), required: false);
            var __workflow_uIAGetHandleForTopLevelWindowmatchIndexAscending = WorkflowExpression.Compile(uIAGetHandleForTopLevelWindowmatchIndexAscending, nameof(uIAGetHandleForTopLevelWindowmatchIndexAscending), required: false);
            return new DeferredBodyAction<UIAGetHandleForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForTopLevelWindow = new JObject();
                var uIAGetHandleForTopLevelWindowpropCount = 0;
                if (__workflow_uIAGetHandleForTopLevelWindowsearchClassName != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowsearchClassName);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowsearchWindowTitle != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowsearchWindowTitle);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowsearchProcessId != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowsearchProcessId);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowmatchIndex != null)
                {
                    if (__workflow_uIAGetHandleForTopLevelWindowmatchIndex != null)
                    {
                        uIAGetHandleForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowmatchIndex);
                        uIAGetHandleForTopLevelWindowpropCount++;
                    }

                    uIAGetHandleForTopLevelWindowpropCount++;
                }
                else
                {
                    uIAGetHandleForTopLevelWindow["MatchIndex"] = 1;
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowsearchFilter != null)
                {
                    uIAGetHandleForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowsearchFilter);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowsortByColumn != null)
                {
                    uIAGetHandleForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowsortByColumn);
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetHandleForTopLevelWindowmatchIndexAscending != null)
                    {
                        uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowmatchIndexAscending);
                        uIAGetHandleForTopLevelWindowpropCount++;
                    }

                    uIAGetHandleForTopLevelWindowpropCount++;
                }
                else
                {
                    uIAGetHandleForTopLevelWindow["MatchIndexAscending"] = true;
                    uIAGetHandleForTopLevelWindowpropCount++;
                }

                uIAGetHandleForTopLevelWindowpropCount++;
                uIAGetHandleForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForTopLevelWindowworkflow);
                if (uIAGetHandleForTopLevelWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForTopLevelWindow;
                }

                return new ApiConnectionAction<UIAGetHandleForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration> UIAWaitForTopLevelWindow(Expression<Func<int>> uIAWaitForTopLevelWindowsecondsToWait, Expression<Func<string>> uIAWaitForTopLevelWindowworkflow, Expression<Func<string>> uIAWaitForTopLevelWindowsearchClassName = null, Expression<Func<string>> uIAWaitForTopLevelWindowsearchWindowTitle = null, Expression<Func<int>> uIAWaitForTopLevelWindowsearchProcessId = null, Expression<Func<int>> uIAWaitForTopLevelWindowmatchIndex = null, Expression<Func<string>> uIAWaitForTopLevelWindowsearchFilter = null, Expression<Func<string>> uIAWaitForTopLevelWindowsortByColumn = null, Expression<Func<bool>> uIAWaitForTopLevelWindowmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound = null)
        {
            var __workflow_uIAWaitForTopLevelWindowsecondsToWait = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsecondsToWait, nameof(uIAWaitForTopLevelWindowsecondsToWait), required: true);
            var __workflow_uIAWaitForTopLevelWindowworkflow = WorkflowExpression.Compile(uIAWaitForTopLevelWindowworkflow, nameof(uIAWaitForTopLevelWindowworkflow), required: true);
            var __workflow_uIAWaitForTopLevelWindowsearchClassName = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsearchClassName, nameof(uIAWaitForTopLevelWindowsearchClassName), required: false);
            var __workflow_uIAWaitForTopLevelWindowsearchWindowTitle = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsearchWindowTitle, nameof(uIAWaitForTopLevelWindowsearchWindowTitle), required: false);
            var __workflow_uIAWaitForTopLevelWindowsearchProcessId = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsearchProcessId, nameof(uIAWaitForTopLevelWindowsearchProcessId), required: false);
            var __workflow_uIAWaitForTopLevelWindowmatchIndex = WorkflowExpression.Compile(uIAWaitForTopLevelWindowmatchIndex, nameof(uIAWaitForTopLevelWindowmatchIndex), required: false);
            var __workflow_uIAWaitForTopLevelWindowsearchFilter = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsearchFilter, nameof(uIAWaitForTopLevelWindowsearchFilter), required: false);
            var __workflow_uIAWaitForTopLevelWindowsortByColumn = WorkflowExpression.Compile(uIAWaitForTopLevelWindowsortByColumn, nameof(uIAWaitForTopLevelWindowsortByColumn), required: false);
            var __workflow_uIAWaitForTopLevelWindowmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForTopLevelWindowmatchIndexAscending, nameof(uIAWaitForTopLevelWindowmatchIndexAscending), required: false);
            var __workflow_uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound = WorkflowExpression.Compile(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound, nameof(uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound), required: false);
            return new DeferredBodyAction<UIAWaitForTopLevelWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForTopLevelWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForTopLevelWindow = new JObject();
                var uIAWaitForTopLevelWindowpropCount = 0;
                if (__workflow_uIAWaitForTopLevelWindowsearchClassName != null)
                {
                    uIAWaitForTopLevelWindow["SearchClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsearchClassName);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowsearchWindowTitle != null)
                {
                    uIAWaitForTopLevelWindow["SearchWindowTitle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsearchWindowTitle);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
                uIAWaitForTopLevelWindow["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsecondsToWait);
                if (__workflow_uIAWaitForTopLevelWindowsearchProcessId != null)
                {
                    uIAWaitForTopLevelWindow["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsearchProcessId);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowmatchIndex != null)
                {
                    if (__workflow_uIAWaitForTopLevelWindowmatchIndex != null)
                    {
                        uIAWaitForTopLevelWindow["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowmatchIndex);
                        uIAWaitForTopLevelWindowpropCount++;
                    }

                    uIAWaitForTopLevelWindowpropCount++;
                }
                else
                {
                    uIAWaitForTopLevelWindow["MatchIndex"] = 1;
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowsearchFilter != null)
                {
                    uIAWaitForTopLevelWindow["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsearchFilter);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowsortByColumn != null)
                {
                    uIAWaitForTopLevelWindow["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowsortByColumn);
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForTopLevelWindowmatchIndexAscending != null)
                    {
                        uIAWaitForTopLevelWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowmatchIndexAscending);
                        uIAWaitForTopLevelWindowpropCount++;
                    }

                    uIAWaitForTopLevelWindowpropCount++;
                }
                else
                {
                    uIAWaitForTopLevelWindow["MatchIndexAscending"] = true;
                    uIAWaitForTopLevelWindowpropCount++;
                }

                if (__workflow_uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound != null)
                {
                    if (__workflow_uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound != null)
                    {
                        uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowraiseExceptionIfWindowNotFound);
                        uIAWaitForTopLevelWindowpropCount++;
                    }

                    uIAWaitForTopLevelWindowpropCount++;
                }
                else
                {
                    uIAWaitForTopLevelWindow["RaiseExceptionIfWindowNotFound"] = false;
                    uIAWaitForTopLevelWindowpropCount++;
                }

                uIAWaitForTopLevelWindowpropCount++;
                uIAWaitForTopLevelWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForTopLevelWindowworkflow);
                if (uIAWaitForTopLevelWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForTopLevelWindow;
                }

                return new ApiConnectionAction<UIAWaitForTopLevelWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesProcessHaveWindowResponse, ApiConnectionActionConfiguration> UIADoesProcessHaveWindow(Expression<Func<string>> uIADoesProcessHaveWindowsearchProcessName, Expression<Func<string>> uIADoesProcessHaveWindowworkflow)
        {
            var __workflow_uIADoesProcessHaveWindowsearchProcessName = WorkflowExpression.Compile(uIADoesProcessHaveWindowsearchProcessName, nameof(uIADoesProcessHaveWindowsearchProcessName), required: true);
            var __workflow_uIADoesProcessHaveWindowworkflow = WorkflowExpression.Compile(uIADoesProcessHaveWindowworkflow, nameof(uIADoesProcessHaveWindowworkflow), required: true);
            return new DeferredBodyAction<UIADoesProcessHaveWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesProcessHaveWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesProcessHaveWindow = new JObject();
                var uIADoesProcessHaveWindowpropCount = 0;
                uIADoesProcessHaveWindowpropCount++;
                uIADoesProcessHaveWindow["SearchProcessName"] = ExpressionConverter.ConvertO(__workflow_uIADoesProcessHaveWindowsearchProcessName);
                uIADoesProcessHaveWindowpropCount++;
                uIADoesProcessHaveWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIADoesProcessHaveWindowworkflow);
                if (uIADoesProcessHaveWindowpropCount > 0)
                {
                    callPayload.Body = uIADoesProcessHaveWindow;
                }

                return new ApiConnectionAction<UIADoesProcessHaveWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForProcessMainWindow(Expression<Func<string>> uIAGetHandleForProcessMainWindowsearchProcessName, Expression<Func<string>> uIAGetHandleForProcessMainWindowworkflow)
        {
            var __workflow_uIAGetHandleForProcessMainWindowsearchProcessName = WorkflowExpression.Compile(uIAGetHandleForProcessMainWindowsearchProcessName, nameof(uIAGetHandleForProcessMainWindowsearchProcessName), required: true);
            var __workflow_uIAGetHandleForProcessMainWindowworkflow = WorkflowExpression.Compile(uIAGetHandleForProcessMainWindowworkflow, nameof(uIAGetHandleForProcessMainWindowworkflow), required: true);
            return new DeferredBodyAction<UIAGetHandleForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForProcessMainWindow = new JObject();
                var uIAGetHandleForProcessMainWindowpropCount = 0;
                uIAGetHandleForProcessMainWindowpropCount++;
                uIAGetHandleForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessMainWindowsearchProcessName);
                uIAGetHandleForProcessMainWindowpropCount++;
                uIAGetHandleForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessMainWindowworkflow);
                if (uIAGetHandleForProcessMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForProcessMainWindow;
                }

                return new ApiConnectionAction<UIAGetHandleForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration> UIAWaitForProcessMainWindow(Expression<Func<string>> uIAWaitForProcessMainWindowsearchProcessName, Expression<Func<int>> uIAWaitForProcessMainWindowsecondsToWait, Expression<Func<string>> uIAWaitForProcessMainWindowworkflow)
        {
            var __workflow_uIAWaitForProcessMainWindowsearchProcessName = WorkflowExpression.Compile(uIAWaitForProcessMainWindowsearchProcessName, nameof(uIAWaitForProcessMainWindowsearchProcessName), required: true);
            var __workflow_uIAWaitForProcessMainWindowsecondsToWait = WorkflowExpression.Compile(uIAWaitForProcessMainWindowsecondsToWait, nameof(uIAWaitForProcessMainWindowsecondsToWait), required: true);
            var __workflow_uIAWaitForProcessMainWindowworkflow = WorkflowExpression.Compile(uIAWaitForProcessMainWindowworkflow, nameof(uIAWaitForProcessMainWindowworkflow), required: true);
            return new DeferredBodyAction<UIAWaitForProcessMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForProcessMainWindow = new JObject();
                var uIAWaitForProcessMainWindowpropCount = 0;
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["SearchProcessName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessMainWindowsearchProcessName);
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessMainWindowsecondsToWait);
                uIAWaitForProcessMainWindowpropCount++;
                uIAWaitForProcessMainWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessMainWindowworkflow);
                if (uIAWaitForProcessMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForProcessMainWindow;
                }

                return new ApiConnectionAction<UIAWaitForProcessMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UIAGetHandleForProcessIdMainWindow(Expression<Func<int>> uIAGetHandleForProcessIdMainWindowprocessId, Expression<Func<string>> uIAGetHandleForProcessIdMainWindowworkflow)
        {
            var __workflow_uIAGetHandleForProcessIdMainWindowprocessId = WorkflowExpression.Compile(uIAGetHandleForProcessIdMainWindowprocessId, nameof(uIAGetHandleForProcessIdMainWindowprocessId), required: true);
            var __workflow_uIAGetHandleForProcessIdMainWindowworkflow = WorkflowExpression.Compile(uIAGetHandleForProcessIdMainWindowworkflow, nameof(uIAGetHandleForProcessIdMainWindowworkflow), required: true);
            return new DeferredBodyAction<UIAGetHandleForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForProcessIdMainWindow = new JObject();
                var uIAGetHandleForProcessIdMainWindowpropCount = 0;
                uIAGetHandleForProcessIdMainWindowpropCount++;
                uIAGetHandleForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessIdMainWindowprocessId);
                uIAGetHandleForProcessIdMainWindowpropCount++;
                uIAGetHandleForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForProcessIdMainWindowworkflow);
                if (uIAGetHandleForProcessIdMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForProcessIdMainWindow;
                }

                return new ApiConnectionAction<UIAGetHandleForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration> UIAWaitForProcessIdMainWindow(Expression<Func<int>> uIAWaitForProcessIdMainWindowprocessId, Expression<Func<int>> uIAWaitForProcessIdMainWindowsecondsToWait, Expression<Func<string>> uIAWaitForProcessIdMainWindowworkflow)
        {
            var __workflow_uIAWaitForProcessIdMainWindowprocessId = WorkflowExpression.Compile(uIAWaitForProcessIdMainWindowprocessId, nameof(uIAWaitForProcessIdMainWindowprocessId), required: true);
            var __workflow_uIAWaitForProcessIdMainWindowsecondsToWait = WorkflowExpression.Compile(uIAWaitForProcessIdMainWindowsecondsToWait, nameof(uIAWaitForProcessIdMainWindowsecondsToWait), required: true);
            var __workflow_uIAWaitForProcessIdMainWindowworkflow = WorkflowExpression.Compile(uIAWaitForProcessIdMainWindowworkflow, nameof(uIAWaitForProcessIdMainWindowworkflow), required: true);
            return new DeferredBodyAction<UIAWaitForProcessIdMainWindowResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForProcessIdMainWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForProcessIdMainWindow = new JObject();
                var uIAWaitForProcessIdMainWindowpropCount = 0;
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["ProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessIdMainWindowprocessId);
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessIdMainWindowsecondsToWait);
                uIAWaitForProcessIdMainWindowpropCount++;
                uIAWaitForProcessIdMainWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForProcessIdMainWindowworkflow);
                if (uIAWaitForProcessIdMainWindowpropCount > 0)
                {
                    callPayload.Body = uIAWaitForProcessIdMainWindow;
                }

                return new ApiConnectionAction<UIAWaitForProcessIdMainWindowResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration> UIAGetHandleForFocussedElement(Expression<Func<string>> uIAGetHandleForFocussedElementworkflow)
        {
            var __workflow_uIAGetHandleForFocussedElementworkflow = WorkflowExpression.Compile(uIAGetHandleForFocussedElementworkflow, nameof(uIAGetHandleForFocussedElementworkflow), required: true);
            return new DeferredBodyAction<UIAGetHandleForFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForFocussedElement = new JObject();
                var uIAGetHandleForFocussedElementpropCount = 0;
                uIAGetHandleForFocussedElementpropCount++;
                uIAGetHandleForFocussedElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForFocussedElementworkflow);
                if (uIAGetHandleForFocussedElementpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForFocussedElement;
                }

                return new ApiConnectionAction<UIAGetHandleForFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration> UIAGetHandleForMainWindowOfFocussedElement(Expression<Func<string>> uIAGetHandleForMainWindowOfFocussedElementworkflow)
        {
            var __workflow_uIAGetHandleForMainWindowOfFocussedElementworkflow = WorkflowExpression.Compile(uIAGetHandleForMainWindowOfFocussedElementworkflow, nameof(uIAGetHandleForMainWindowOfFocussedElementworkflow), required: true);
            return new DeferredBodyAction<UIAGetHandleForMainWindowOfFocussedElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForMainWindowOfFocussedElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForMainWindowOfFocussedElement = new JObject();
                var uIAGetHandleForMainWindowOfFocussedElementpropCount = 0;
                uIAGetHandleForMainWindowOfFocussedElementpropCount++;
                uIAGetHandleForMainWindowOfFocussedElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForMainWindowOfFocussedElementworkflow);
                if (uIAGetHandleForMainWindowOfFocussedElementpropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForMainWindowOfFocussedElement;
                }

                return new ApiConnectionAction<UIAGetHandleForMainWindowOfFocussedElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetHandleForDesktopResponse, ApiConnectionActionConfiguration> UIAGetHandleForDesktop(Expression<Func<string>> uIAGetHandleForDesktopworkflow)
        {
            var __workflow_uIAGetHandleForDesktopworkflow = WorkflowExpression.Compile(uIAGetHandleForDesktopworkflow, nameof(uIAGetHandleForDesktopworkflow), required: true);
            return new DeferredBodyAction<UIAGetHandleForDesktopResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetHandleForDesktop";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetHandleForDesktop = new JObject();
                var uIAGetHandleForDesktoppropCount = 0;
                uIAGetHandleForDesktoppropCount++;
                uIAGetHandleForDesktop["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetHandleForDesktopworkflow);
                if (uIAGetHandleForDesktoppropCount > 0)
                {
                    callPayload.Body = uIAGetHandleForDesktop;
                }

                return new ApiConnectionAction<UIAGetHandleForDesktopResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetForegroundWindow(Expression<Func<int>> uIASetForegroundWindowwindowHandle, Expression<Func<string>> uIASetForegroundWindowworkflow, Expression<Func<bool>> uIASetForegroundWindowtoggleWindow = null, Expression<Func<bool>> uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent = null, Expression<Func<double>> uIASetForegroundWindowtoggleDelay = null)
        {
            var __workflow_uIASetForegroundWindowwindowHandle = WorkflowExpression.Compile(uIASetForegroundWindowwindowHandle, nameof(uIASetForegroundWindowwindowHandle), required: true);
            var __workflow_uIASetForegroundWindowworkflow = WorkflowExpression.Compile(uIASetForegroundWindowworkflow, nameof(uIASetForegroundWindowworkflow), required: true);
            var __workflow_uIASetForegroundWindowtoggleWindow = WorkflowExpression.Compile(uIASetForegroundWindowtoggleWindow, nameof(uIASetForegroundWindowtoggleWindow), required: false);
            var __workflow_uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent = WorkflowExpression.Compile(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent, nameof(uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent), required: false);
            var __workflow_uIASetForegroundWindowtoggleDelay = WorkflowExpression.Compile(uIASetForegroundWindowtoggleDelay, nameof(uIASetForegroundWindowtoggleDelay), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetForegroundWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetForegroundWindow = new JObject();
                var uIASetForegroundWindowpropCount = 0;
                uIASetForegroundWindowpropCount++;
                uIASetForegroundWindow["WindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindowwindowHandle);
                if (__workflow_uIASetForegroundWindowtoggleWindow != null)
                {
                    if (__workflow_uIASetForegroundWindowtoggleWindow != null)
                    {
                        uIASetForegroundWindow["ToggleWindow"] = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindowtoggleWindow);
                        uIASetForegroundWindowpropCount++;
                    }

                    uIASetForegroundWindowpropCount++;
                }
                else
                {
                    uIASetForegroundWindow["ToggleWindow"] = true;
                    uIASetForegroundWindowpropCount++;
                }

                if (__workflow_uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent != null)
                {
                    if (__workflow_uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent != null)
                    {
                        uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindowtoggleUsesGlobalLeftMouseClickAgent);
                        uIASetForegroundWindowpropCount++;
                    }

                    uIASetForegroundWindowpropCount++;
                }
                else
                {
                    uIASetForegroundWindow["ToggleUsesGlobalLeftMouseClickAgent"] = true;
                    uIASetForegroundWindowpropCount++;
                }

                if (__workflow_uIASetForegroundWindowtoggleDelay != null)
                {
                    if (__workflow_uIASetForegroundWindowtoggleDelay != null)
                    {
                        uIASetForegroundWindow["ToggleDelay"] = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindowtoggleDelay);
                        uIASetForegroundWindowpropCount++;
                    }

                    uIASetForegroundWindowpropCount++;
                }
                else
                {
                    uIASetForegroundWindow["ToggleDelay"] = 0.25;
                    uIASetForegroundWindowpropCount++;
                }

                uIASetForegroundWindowpropCount++;
                uIASetForegroundWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetForegroundWindowworkflow);
                if (uIASetForegroundWindowpropCount > 0)
                {
                    callPayload.Body = uIASetForegroundWindow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAMaximiseWindow(Expression<Func<int>> uIAMaximiseWindowwindowHandle, Expression<Func<string>> uIAMaximiseWindowworkflow)
        {
            var __workflow_uIAMaximiseWindowwindowHandle = WorkflowExpression.Compile(uIAMaximiseWindowwindowHandle, nameof(uIAMaximiseWindowwindowHandle), required: true);
            var __workflow_uIAMaximiseWindowworkflow = WorkflowExpression.Compile(uIAMaximiseWindowworkflow, nameof(uIAMaximiseWindowworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MaximiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMaximiseWindow = new JObject();
                var uIAMaximiseWindowpropCount = 0;
                uIAMaximiseWindowpropCount++;
                uIAMaximiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAMaximiseWindowwindowHandle);
                uIAMaximiseWindowpropCount++;
                uIAMaximiseWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAMaximiseWindowworkflow);
                if (uIAMaximiseWindowpropCount > 0)
                {
                    callPayload.Body = uIAMaximiseWindow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAMinimiseWindow(Expression<Func<int>> uIAMinimiseWindowwindowHandle, Expression<Func<string>> uIAMinimiseWindowworkflow)
        {
            var __workflow_uIAMinimiseWindowwindowHandle = WorkflowExpression.Compile(uIAMinimiseWindowwindowHandle, nameof(uIAMinimiseWindowwindowHandle), required: true);
            var __workflow_uIAMinimiseWindowworkflow = WorkflowExpression.Compile(uIAMinimiseWindowworkflow, nameof(uIAMinimiseWindowworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/MinimiseWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMinimiseWindow = new JObject();
                var uIAMinimiseWindowpropCount = 0;
                uIAMinimiseWindowpropCount++;
                uIAMinimiseWindow["WindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAMinimiseWindowwindowHandle);
                uIAMinimiseWindowpropCount++;
                uIAMinimiseWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAMinimiseWindowworkflow);
                if (uIAMinimiseWindowpropCount > 0)
                {
                    callPayload.Body = uIAMinimiseWindow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetWindowToNormal(Expression<Func<int>> uIASetWindowToNormalwindowHandle, Expression<Func<string>> uIASetWindowToNormalworkflow)
        {
            var __workflow_uIASetWindowToNormalwindowHandle = WorkflowExpression.Compile(uIASetWindowToNormalwindowHandle, nameof(uIASetWindowToNormalwindowHandle), required: true);
            var __workflow_uIASetWindowToNormalworkflow = WorkflowExpression.Compile(uIASetWindowToNormalworkflow, nameof(uIASetWindowToNormalworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetWindowToNormal";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetWindowToNormal = new JObject();
                var uIASetWindowToNormalpropCount = 0;
                uIASetWindowToNormalpropCount++;
                uIASetWindowToNormal["WindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASetWindowToNormalwindowHandle);
                uIASetWindowToNormalpropCount++;
                uIASetWindowToNormal["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetWindowToNormalworkflow);
                if (uIASetWindowToNormalpropCount > 0)
                {
                    callPayload.Body = uIASetWindowToNormal;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesElementExistResponse, ApiConnectionActionConfiguration> UIADoesElementExist(Expression<Func<int>> uIADoesElementExistparentWindowHandle, Expression<Func<string>> uIADoesElementExistworkflow, Expression<Func<string>> uIADoesElementExistsearchElementName = null, Expression<Func<string>> uIADoesElementExistsearchElementClassName = null, Expression<Func<string>> uIADoesElementExistsearchElementAutomationId = null, Expression<Func<string>> uIADoesElementExistsearchLocalizedControlType = null, Expression<Func<int>> uIADoesElementExistsearchProcessId = null, Expression<Func<bool>> uIADoesElementExistsearchSubTree = null, Expression<Func<bool>> uIADoesElementExistreturnElementHandle = null, Expression<Func<int>> uIADoesElementExistmatchIndex = null, Expression<Func<string>> uIADoesElementExistsearchFilter = null, Expression<Func<string>> uIADoesElementExistsortByColumn = null, Expression<Func<bool>> uIADoesElementExistmatchIndexAscending = null, Expression<Func<bool>> uIADoesElementExistincludeChildProcesses = null, Expression<Func<int>> uIADoesElementExistmaxElementsToSearch = null, Expression<Func<int>> uIADoesElementExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesElementExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIADoesElementExistparentWindowHandle = WorkflowExpression.Compile(uIADoesElementExistparentWindowHandle, nameof(uIADoesElementExistparentWindowHandle), required: true);
            var __workflow_uIADoesElementExistworkflow = WorkflowExpression.Compile(uIADoesElementExistworkflow, nameof(uIADoesElementExistworkflow), required: true);
            var __workflow_uIADoesElementExistsearchElementName = WorkflowExpression.Compile(uIADoesElementExistsearchElementName, nameof(uIADoesElementExistsearchElementName), required: false);
            var __workflow_uIADoesElementExistsearchElementClassName = WorkflowExpression.Compile(uIADoesElementExistsearchElementClassName, nameof(uIADoesElementExistsearchElementClassName), required: false);
            var __workflow_uIADoesElementExistsearchElementAutomationId = WorkflowExpression.Compile(uIADoesElementExistsearchElementAutomationId, nameof(uIADoesElementExistsearchElementAutomationId), required: false);
            var __workflow_uIADoesElementExistsearchLocalizedControlType = WorkflowExpression.Compile(uIADoesElementExistsearchLocalizedControlType, nameof(uIADoesElementExistsearchLocalizedControlType), required: false);
            var __workflow_uIADoesElementExistsearchProcessId = WorkflowExpression.Compile(uIADoesElementExistsearchProcessId, nameof(uIADoesElementExistsearchProcessId), required: false);
            var __workflow_uIADoesElementExistsearchSubTree = WorkflowExpression.Compile(uIADoesElementExistsearchSubTree, nameof(uIADoesElementExistsearchSubTree), required: false);
            var __workflow_uIADoesElementExistreturnElementHandle = WorkflowExpression.Compile(uIADoesElementExistreturnElementHandle, nameof(uIADoesElementExistreturnElementHandle), required: false);
            var __workflow_uIADoesElementExistmatchIndex = WorkflowExpression.Compile(uIADoesElementExistmatchIndex, nameof(uIADoesElementExistmatchIndex), required: false);
            var __workflow_uIADoesElementExistsearchFilter = WorkflowExpression.Compile(uIADoesElementExistsearchFilter, nameof(uIADoesElementExistsearchFilter), required: false);
            var __workflow_uIADoesElementExistsortByColumn = WorkflowExpression.Compile(uIADoesElementExistsortByColumn, nameof(uIADoesElementExistsortByColumn), required: false);
            var __workflow_uIADoesElementExistmatchIndexAscending = WorkflowExpression.Compile(uIADoesElementExistmatchIndexAscending, nameof(uIADoesElementExistmatchIndexAscending), required: false);
            var __workflow_uIADoesElementExistincludeChildProcesses = WorkflowExpression.Compile(uIADoesElementExistincludeChildProcesses, nameof(uIADoesElementExistincludeChildProcesses), required: false);
            var __workflow_uIADoesElementExistmaxElementsToSearch = WorkflowExpression.Compile(uIADoesElementExistmaxElementsToSearch, nameof(uIADoesElementExistmaxElementsToSearch), required: false);
            var __workflow_uIADoesElementExistmaxRelativeSearchDepth = WorkflowExpression.Compile(uIADoesElementExistmaxRelativeSearchDepth, nameof(uIADoesElementExistmaxRelativeSearchDepth), required: false);
            var __workflow_uIADoesElementExistmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIADoesElementExistmaxChildElementsToSearchPerNode, nameof(uIADoesElementExistmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIADoesElementExistelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIADoesElementExistelementLocalizedControlTypesNotToTraverse, nameof(uIADoesElementExistelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIADoesElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesElementExist = new JObject();
                var uIADoesElementExistpropCount = 0;
                uIADoesElementExistpropCount++;
                uIADoesElementExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistparentWindowHandle);
                if (__workflow_uIADoesElementExistsearchElementName != null)
                {
                    uIADoesElementExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchElementName);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchElementClassName != null)
                {
                    uIADoesElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchElementClassName);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchElementAutomationId != null)
                {
                    uIADoesElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchElementAutomationId);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchLocalizedControlType != null)
                {
                    uIADoesElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchLocalizedControlType);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchProcessId != null)
                {
                    uIADoesElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchProcessId);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchSubTree != null)
                {
                    if (__workflow_uIADoesElementExistsearchSubTree != null)
                    {
                        uIADoesElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchSubTree);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["SearchSubTree"] = true;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistreturnElementHandle != null)
                {
                    if (__workflow_uIADoesElementExistreturnElementHandle != null)
                    {
                        uIADoesElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistreturnElementHandle);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["ReturnElementHandle"] = true;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistmatchIndex != null)
                {
                    if (__workflow_uIADoesElementExistmatchIndex != null)
                    {
                        uIADoesElementExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistmatchIndex);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["MatchIndex"] = 1;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsearchFilter != null)
                {
                    uIADoesElementExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsearchFilter);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistsortByColumn != null)
                {
                    uIADoesElementExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistsortByColumn);
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistmatchIndexAscending != null)
                {
                    if (__workflow_uIADoesElementExistmatchIndexAscending != null)
                    {
                        uIADoesElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistmatchIndexAscending);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["MatchIndexAscending"] = true;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistincludeChildProcesses != null)
                {
                    if (__workflow_uIADoesElementExistincludeChildProcesses != null)
                    {
                        uIADoesElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistincludeChildProcesses);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["IncludeChildProcesses"] = false;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistmaxElementsToSearch != null)
                {
                    if (__workflow_uIADoesElementExistmaxElementsToSearch != null)
                    {
                        uIADoesElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistmaxElementsToSearch);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["MaxElementsToSearch"] = 0;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIADoesElementExistmaxRelativeSearchDepth != null)
                    {
                        uIADoesElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistmaxRelativeSearchDepth);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["MaxRelativeSearchDepth"] = 0;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIADoesElementExistmaxChildElementsToSearchPerNode != null)
                    {
                        uIADoesElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistmaxChildElementsToSearchPerNode);
                        uIADoesElementExistpropCount++;
                    }

                    uIADoesElementExistpropCount++;
                }
                else
                {
                    uIADoesElementExist["MaxChildElementsToSearchPerNode"] = 0;
                    uIADoesElementExistpropCount++;
                }

                if (__workflow_uIADoesElementExistelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIADoesElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistelementLocalizedControlTypesNotToTraverse);
                    uIADoesElementExistpropCount++;
                }

                uIADoesElementExistpropCount++;
                uIADoesElementExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIADoesElementExistworkflow);
                if (uIADoesElementExistpropCount > 0)
                {
                    callPayload.Body = uIADoesElementExist;
                }

                return new ApiConnectionAction<UIADoesElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIADoesDesktopElementExistResponse, ApiConnectionActionConfiguration> UIADoesDesktopElementExist(Expression<Func<string>> uIADoesDesktopElementExistworkflow, Expression<Func<string>> uIADoesDesktopElementExistsearchElementName = null, Expression<Func<string>> uIADoesDesktopElementExistsearchElementClassName = null, Expression<Func<string>> uIADoesDesktopElementExistsearchElementAutomationId = null, Expression<Func<string>> uIADoesDesktopElementExistsearchLocalizedControlType = null, Expression<Func<int>> uIADoesDesktopElementExistsearchProcessId = null, Expression<Func<bool>> uIADoesDesktopElementExistsearchSubTree = null, Expression<Func<bool>> uIADoesDesktopElementExistreturnElementHandle = null, Expression<Func<int>> uIADoesDesktopElementExistmatchIndex = null, Expression<Func<string>> uIADoesDesktopElementExistsearchFilter = null, Expression<Func<string>> uIADoesDesktopElementExistsortByColumn = null, Expression<Func<bool>> uIADoesDesktopElementExistmatchIndexAscending = null, Expression<Func<bool>> uIADoesDesktopElementExistincludeChildProcesses = null, Expression<Func<int>> uIADoesDesktopElementExistmaxElementsToSearch = null, Expression<Func<int>> uIADoesDesktopElementExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIADoesDesktopElementExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIADoesDesktopElementExistworkflow = WorkflowExpression.Compile(uIADoesDesktopElementExistworkflow, nameof(uIADoesDesktopElementExistworkflow), required: true);
            var __workflow_uIADoesDesktopElementExistsearchElementName = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchElementName, nameof(uIADoesDesktopElementExistsearchElementName), required: false);
            var __workflow_uIADoesDesktopElementExistsearchElementClassName = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchElementClassName, nameof(uIADoesDesktopElementExistsearchElementClassName), required: false);
            var __workflow_uIADoesDesktopElementExistsearchElementAutomationId = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchElementAutomationId, nameof(uIADoesDesktopElementExistsearchElementAutomationId), required: false);
            var __workflow_uIADoesDesktopElementExistsearchLocalizedControlType = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchLocalizedControlType, nameof(uIADoesDesktopElementExistsearchLocalizedControlType), required: false);
            var __workflow_uIADoesDesktopElementExistsearchProcessId = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchProcessId, nameof(uIADoesDesktopElementExistsearchProcessId), required: false);
            var __workflow_uIADoesDesktopElementExistsearchSubTree = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchSubTree, nameof(uIADoesDesktopElementExistsearchSubTree), required: false);
            var __workflow_uIADoesDesktopElementExistreturnElementHandle = WorkflowExpression.Compile(uIADoesDesktopElementExistreturnElementHandle, nameof(uIADoesDesktopElementExistreturnElementHandle), required: false);
            var __workflow_uIADoesDesktopElementExistmatchIndex = WorkflowExpression.Compile(uIADoesDesktopElementExistmatchIndex, nameof(uIADoesDesktopElementExistmatchIndex), required: false);
            var __workflow_uIADoesDesktopElementExistsearchFilter = WorkflowExpression.Compile(uIADoesDesktopElementExistsearchFilter, nameof(uIADoesDesktopElementExistsearchFilter), required: false);
            var __workflow_uIADoesDesktopElementExistsortByColumn = WorkflowExpression.Compile(uIADoesDesktopElementExistsortByColumn, nameof(uIADoesDesktopElementExistsortByColumn), required: false);
            var __workflow_uIADoesDesktopElementExistmatchIndexAscending = WorkflowExpression.Compile(uIADoesDesktopElementExistmatchIndexAscending, nameof(uIADoesDesktopElementExistmatchIndexAscending), required: false);
            var __workflow_uIADoesDesktopElementExistincludeChildProcesses = WorkflowExpression.Compile(uIADoesDesktopElementExistincludeChildProcesses, nameof(uIADoesDesktopElementExistincludeChildProcesses), required: false);
            var __workflow_uIADoesDesktopElementExistmaxElementsToSearch = WorkflowExpression.Compile(uIADoesDesktopElementExistmaxElementsToSearch, nameof(uIADoesDesktopElementExistmaxElementsToSearch), required: false);
            var __workflow_uIADoesDesktopElementExistmaxRelativeSearchDepth = WorkflowExpression.Compile(uIADoesDesktopElementExistmaxRelativeSearchDepth, nameof(uIADoesDesktopElementExistmaxRelativeSearchDepth), required: false);
            var __workflow_uIADoesDesktopElementExistmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode, nameof(uIADoesDesktopElementExistmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse, nameof(uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIADoesDesktopElementExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DoesDesktopElementExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADoesDesktopElementExist = new JObject();
                var uIADoesDesktopElementExistpropCount = 0;
                if (__workflow_uIADoesDesktopElementExistsearchElementName != null)
                {
                    uIADoesDesktopElementExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchElementName);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchElementClassName != null)
                {
                    uIADoesDesktopElementExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchElementClassName);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchElementAutomationId != null)
                {
                    uIADoesDesktopElementExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchElementAutomationId);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchLocalizedControlType != null)
                {
                    uIADoesDesktopElementExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchLocalizedControlType);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchProcessId != null)
                {
                    uIADoesDesktopElementExist["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchProcessId);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchSubTree != null)
                {
                    if (__workflow_uIADoesDesktopElementExistsearchSubTree != null)
                    {
                        uIADoesDesktopElementExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchSubTree);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["SearchSubTree"] = true;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistreturnElementHandle != null)
                {
                    if (__workflow_uIADoesDesktopElementExistreturnElementHandle != null)
                    {
                        uIADoesDesktopElementExist["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistreturnElementHandle);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["ReturnElementHandle"] = true;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistmatchIndex != null)
                {
                    if (__workflow_uIADoesDesktopElementExistmatchIndex != null)
                    {
                        uIADoesDesktopElementExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistmatchIndex);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["MatchIndex"] = 1;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsearchFilter != null)
                {
                    uIADoesDesktopElementExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsearchFilter);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistsortByColumn != null)
                {
                    uIADoesDesktopElementExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistsortByColumn);
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistmatchIndexAscending != null)
                {
                    if (__workflow_uIADoesDesktopElementExistmatchIndexAscending != null)
                    {
                        uIADoesDesktopElementExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistmatchIndexAscending);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["MatchIndexAscending"] = true;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistincludeChildProcesses != null)
                {
                    if (__workflow_uIADoesDesktopElementExistincludeChildProcesses != null)
                    {
                        uIADoesDesktopElementExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistincludeChildProcesses);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["IncludeChildProcesses"] = false;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistmaxElementsToSearch != null)
                {
                    if (__workflow_uIADoesDesktopElementExistmaxElementsToSearch != null)
                    {
                        uIADoesDesktopElementExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistmaxElementsToSearch);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["MaxElementsToSearch"] = 0;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIADoesDesktopElementExistmaxRelativeSearchDepth != null)
                    {
                        uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistmaxRelativeSearchDepth);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["MaxRelativeSearchDepth"] = 0;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIADoesDesktopElementExistmaxChildElementsToSearchPerNode != null)
                    {
                        uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistmaxChildElementsToSearchPerNode);
                        uIADoesDesktopElementExistpropCount++;
                    }

                    uIADoesDesktopElementExistpropCount++;
                }
                else
                {
                    uIADoesDesktopElementExist["MaxChildElementsToSearchPerNode"] = 0;
                    uIADoesDesktopElementExistpropCount++;
                }

                if (__workflow_uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIADoesDesktopElementExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistelementLocalizedControlTypesNotToTraverse);
                    uIADoesDesktopElementExistpropCount++;
                }

                uIADoesDesktopElementExistpropCount++;
                uIADoesDesktopElementExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIADoesDesktopElementExistworkflow);
                if (uIADoesDesktopElementExistpropCount > 0)
                {
                    callPayload.Body = uIADoesDesktopElementExist;
                }

                return new ApiConnectionAction<UIADoesDesktopElementExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementResponse, ApiConnectionActionConfiguration> UIAWaitForElement(Expression<Func<int>> uIAWaitForElementparentWindowHandle, Expression<Func<int>> uIAWaitForElementsecondsToWait, Expression<Func<string>> uIAWaitForElementworkflow, Expression<Func<string>> uIAWaitForElementsearchElementName = null, Expression<Func<string>> uIAWaitForElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementsearchProcessId = null, Expression<Func<bool>> uIAWaitForElementsearchSubTree = null, Expression<Func<bool>> uIAWaitForElementreturnElementHandle = null, Expression<Func<int>> uIAWaitForElementmatchIndex = null, Expression<Func<string>> uIAWaitForElementsearchFilter = null, Expression<Func<string>> uIAWaitForElementsortByColumn = null, Expression<Func<bool>> uIAWaitForElementmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementraiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAWaitForElementparentWindowHandle = WorkflowExpression.Compile(uIAWaitForElementparentWindowHandle, nameof(uIAWaitForElementparentWindowHandle), required: true);
            var __workflow_uIAWaitForElementsecondsToWait = WorkflowExpression.Compile(uIAWaitForElementsecondsToWait, nameof(uIAWaitForElementsecondsToWait), required: true);
            var __workflow_uIAWaitForElementworkflow = WorkflowExpression.Compile(uIAWaitForElementworkflow, nameof(uIAWaitForElementworkflow), required: true);
            var __workflow_uIAWaitForElementsearchElementName = WorkflowExpression.Compile(uIAWaitForElementsearchElementName, nameof(uIAWaitForElementsearchElementName), required: false);
            var __workflow_uIAWaitForElementsearchElementClassName = WorkflowExpression.Compile(uIAWaitForElementsearchElementClassName, nameof(uIAWaitForElementsearchElementClassName), required: false);
            var __workflow_uIAWaitForElementsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForElementsearchElementAutomationId, nameof(uIAWaitForElementsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForElementsearchLocalizedControlType, nameof(uIAWaitForElementsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForElementsearchProcessId = WorkflowExpression.Compile(uIAWaitForElementsearchProcessId, nameof(uIAWaitForElementsearchProcessId), required: false);
            var __workflow_uIAWaitForElementsearchSubTree = WorkflowExpression.Compile(uIAWaitForElementsearchSubTree, nameof(uIAWaitForElementsearchSubTree), required: false);
            var __workflow_uIAWaitForElementreturnElementHandle = WorkflowExpression.Compile(uIAWaitForElementreturnElementHandle, nameof(uIAWaitForElementreturnElementHandle), required: false);
            var __workflow_uIAWaitForElementmatchIndex = WorkflowExpression.Compile(uIAWaitForElementmatchIndex, nameof(uIAWaitForElementmatchIndex), required: false);
            var __workflow_uIAWaitForElementsearchFilter = WorkflowExpression.Compile(uIAWaitForElementsearchFilter, nameof(uIAWaitForElementsearchFilter), required: false);
            var __workflow_uIAWaitForElementsortByColumn = WorkflowExpression.Compile(uIAWaitForElementsortByColumn, nameof(uIAWaitForElementsortByColumn), required: false);
            var __workflow_uIAWaitForElementmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForElementmatchIndexAscending, nameof(uIAWaitForElementmatchIndexAscending), required: false);
            var __workflow_uIAWaitForElementincludeChildProcesses = WorkflowExpression.Compile(uIAWaitForElementincludeChildProcesses, nameof(uIAWaitForElementincludeChildProcesses), required: false);
            var __workflow_uIAWaitForElementraiseExceptionIfElementNotFound = WorkflowExpression.Compile(uIAWaitForElementraiseExceptionIfElementNotFound, nameof(uIAWaitForElementraiseExceptionIfElementNotFound), required: false);
            var __workflow_uIAWaitForElementmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForElementmaxElementsToSearch, nameof(uIAWaitForElementmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForElementmaxRelativeSearchDepth, nameof(uIAWaitForElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForElementmaxChildElementsToSearchPerNode, nameof(uIAWaitForElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForElementelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAWaitForElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForElement = new JObject();
                var uIAWaitForElementpropCount = 0;
                uIAWaitForElementpropCount++;
                uIAWaitForElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementparentWindowHandle);
                if (__workflow_uIAWaitForElementsearchElementName != null)
                {
                    uIAWaitForElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchElementName);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchElementClassName != null)
                {
                    uIAWaitForElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchElementClassName);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchElementAutomationId != null)
                {
                    uIAWaitForElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchElementAutomationId);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchLocalizedControlType != null)
                {
                    uIAWaitForElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchLocalizedControlType);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchProcessId != null)
                {
                    uIAWaitForElement["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchProcessId);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForElementsearchSubTree != null)
                    {
                        uIAWaitForElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchSubTree);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["SearchSubTree"] = true;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementreturnElementHandle != null)
                {
                    if (__workflow_uIAWaitForElementreturnElementHandle != null)
                    {
                        uIAWaitForElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementreturnElementHandle);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["ReturnElementHandle"] = true;
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
                uIAWaitForElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsecondsToWait);
                if (__workflow_uIAWaitForElementmatchIndex != null)
                {
                    if (__workflow_uIAWaitForElementmatchIndex != null)
                    {
                        uIAWaitForElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementmatchIndex);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["MatchIndex"] = 1;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsearchFilter != null)
                {
                    uIAWaitForElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsearchFilter);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementsortByColumn != null)
                {
                    uIAWaitForElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementsortByColumn);
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForElementmatchIndexAscending != null)
                    {
                        uIAWaitForElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementmatchIndexAscending);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["MatchIndexAscending"] = true;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementincludeChildProcesses != null)
                {
                    if (__workflow_uIAWaitForElementincludeChildProcesses != null)
                    {
                        uIAWaitForElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementincludeChildProcesses);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["IncludeChildProcesses"] = false;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_uIAWaitForElementraiseExceptionIfElementNotFound != null)
                    {
                        uIAWaitForElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementraiseExceptionIfElementNotFound);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["RaiseExceptionIfElementNotFound"] = false;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForElementmaxElementsToSearch != null)
                    {
                        uIAWaitForElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementmaxElementsToSearch);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["MaxElementsToSearch"] = 0;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForElementmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementmaxRelativeSearchDepth);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementmaxChildElementsToSearchPerNode);
                        uIAWaitForElementpropCount++;
                    }

                    uIAWaitForElementpropCount++;
                }
                else
                {
                    uIAWaitForElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForElementpropCount++;
                }

                if (__workflow_uIAWaitForElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForElementpropCount++;
                }

                uIAWaitForElementpropCount++;
                uIAWaitForElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementworkflow);
                if (uIAWaitForElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForElement;
                }

                return new ApiConnectionAction<UIAWaitForElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementResponse, ApiConnectionActionConfiguration> UIAWaitForDesktopElement(Expression<Func<int>> uIAWaitForDesktopElementsecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementworkflow, Expression<Func<string>> uIAWaitForDesktopElementsearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementsearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementsearchSubTree = null, Expression<Func<bool>> uIAWaitForDesktopElementreturnElementHandle = null, Expression<Func<int>> uIAWaitForDesktopElementmatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementsearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementsortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementraiseExceptionIfElementNotFound = null, Expression<Func<int>> uIAWaitForDesktopElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAWaitForDesktopElementsecondsToWait = WorkflowExpression.Compile(uIAWaitForDesktopElementsecondsToWait, nameof(uIAWaitForDesktopElementsecondsToWait), required: true);
            var __workflow_uIAWaitForDesktopElementworkflow = WorkflowExpression.Compile(uIAWaitForDesktopElementworkflow, nameof(uIAWaitForDesktopElementworkflow), required: true);
            var __workflow_uIAWaitForDesktopElementsearchElementName = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchElementName, nameof(uIAWaitForDesktopElementsearchElementName), required: false);
            var __workflow_uIAWaitForDesktopElementsearchElementClassName = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchElementClassName, nameof(uIAWaitForDesktopElementsearchElementClassName), required: false);
            var __workflow_uIAWaitForDesktopElementsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchElementAutomationId, nameof(uIAWaitForDesktopElementsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForDesktopElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchLocalizedControlType, nameof(uIAWaitForDesktopElementsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForDesktopElementsearchProcessId = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchProcessId, nameof(uIAWaitForDesktopElementsearchProcessId), required: false);
            var __workflow_uIAWaitForDesktopElementsearchSubTree = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchSubTree, nameof(uIAWaitForDesktopElementsearchSubTree), required: false);
            var __workflow_uIAWaitForDesktopElementreturnElementHandle = WorkflowExpression.Compile(uIAWaitForDesktopElementreturnElementHandle, nameof(uIAWaitForDesktopElementreturnElementHandle), required: false);
            var __workflow_uIAWaitForDesktopElementmatchIndex = WorkflowExpression.Compile(uIAWaitForDesktopElementmatchIndex, nameof(uIAWaitForDesktopElementmatchIndex), required: false);
            var __workflow_uIAWaitForDesktopElementsearchFilter = WorkflowExpression.Compile(uIAWaitForDesktopElementsearchFilter, nameof(uIAWaitForDesktopElementsearchFilter), required: false);
            var __workflow_uIAWaitForDesktopElementsortByColumn = WorkflowExpression.Compile(uIAWaitForDesktopElementsortByColumn, nameof(uIAWaitForDesktopElementsortByColumn), required: false);
            var __workflow_uIAWaitForDesktopElementmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForDesktopElementmatchIndexAscending, nameof(uIAWaitForDesktopElementmatchIndexAscending), required: false);
            var __workflow_uIAWaitForDesktopElementincludeChildProcesses = WorkflowExpression.Compile(uIAWaitForDesktopElementincludeChildProcesses, nameof(uIAWaitForDesktopElementincludeChildProcesses), required: false);
            var __workflow_uIAWaitForDesktopElementraiseExceptionIfElementNotFound = WorkflowExpression.Compile(uIAWaitForDesktopElementraiseExceptionIfElementNotFound, nameof(uIAWaitForDesktopElementraiseExceptionIfElementNotFound), required: false);
            var __workflow_uIAWaitForDesktopElementmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForDesktopElementmaxElementsToSearch, nameof(uIAWaitForDesktopElementmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForDesktopElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForDesktopElementmaxRelativeSearchDepth, nameof(uIAWaitForDesktopElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForDesktopElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode, nameof(uIAWaitForDesktopElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAWaitForDesktopElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/WaitForDesktopElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForDesktopElement = new JObject();
                var uIAWaitForDesktopElementpropCount = 0;
                if (__workflow_uIAWaitForDesktopElementsearchElementName != null)
                {
                    uIAWaitForDesktopElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchElementName);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchElementClassName != null)
                {
                    uIAWaitForDesktopElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchElementClassName);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchElementAutomationId != null)
                {
                    uIAWaitForDesktopElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchElementAutomationId);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchLocalizedControlType != null)
                {
                    uIAWaitForDesktopElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchLocalizedControlType);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchProcessId != null)
                {
                    if (__workflow_uIAWaitForDesktopElementsearchProcessId != null)
                    {
                        uIAWaitForDesktopElement["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchProcessId);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["SearchProcessId"] = 0;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForDesktopElementsearchSubTree != null)
                    {
                        uIAWaitForDesktopElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchSubTree);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["SearchSubTree"] = true;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementreturnElementHandle != null)
                {
                    if (__workflow_uIAWaitForDesktopElementreturnElementHandle != null)
                    {
                        uIAWaitForDesktopElement["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementreturnElementHandle);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["ReturnElementHandle"] = true;
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
                uIAWaitForDesktopElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsecondsToWait);
                if (__workflow_uIAWaitForDesktopElementmatchIndex != null)
                {
                    if (__workflow_uIAWaitForDesktopElementmatchIndex != null)
                    {
                        uIAWaitForDesktopElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementmatchIndex);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["MatchIndex"] = 1;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsearchFilter != null)
                {
                    uIAWaitForDesktopElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsearchFilter);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementsortByColumn != null)
                {
                    uIAWaitForDesktopElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementsortByColumn);
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForDesktopElementmatchIndexAscending != null)
                    {
                        uIAWaitForDesktopElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementmatchIndexAscending);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["MatchIndexAscending"] = true;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementincludeChildProcesses != null)
                {
                    if (__workflow_uIAWaitForDesktopElementincludeChildProcesses != null)
                    {
                        uIAWaitForDesktopElement["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementincludeChildProcesses);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["IncludeChildProcesses"] = false;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_uIAWaitForDesktopElementraiseExceptionIfElementNotFound != null)
                    {
                        uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementraiseExceptionIfElementNotFound);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["RaiseExceptionIfElementNotFound"] = false;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForDesktopElementmaxElementsToSearch != null)
                    {
                        uIAWaitForDesktopElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementmaxElementsToSearch);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["MaxElementsToSearch"] = 0;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForDesktopElementmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementmaxRelativeSearchDepth);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForDesktopElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementmaxChildElementsToSearchPerNode);
                        uIAWaitForDesktopElementpropCount++;
                    }

                    uIAWaitForDesktopElementpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForDesktopElementpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForDesktopElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForDesktopElementpropCount++;
                }

                uIAWaitForDesktopElementpropCount++;
                uIAWaitForDesktopElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementworkflow);
                if (uIAWaitForDesktopElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForDesktopElement;
                }

                return new ApiConnectionAction<UIAWaitForDesktopElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForElementToNotExistResponse, ApiConnectionActionConfiguration> UIAWaitForElementToNotExist(Expression<Func<int>> uIAWaitForElementToNotExistparentWindowHandle, Expression<Func<int>> uIAWaitForElementToNotExistsecondsToWait, Expression<Func<string>> uIAWaitForElementToNotExistworkflow, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementName = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementClassName = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForElementToNotExistsearchProcessId = null, Expression<Func<bool>> uIAWaitForElementToNotExistsearchSubTree = null, Expression<Func<int>> uIAWaitForElementToNotExistmatchIndex = null, Expression<Func<string>> uIAWaitForElementToNotExistsearchFilter = null, Expression<Func<string>> uIAWaitForElementToNotExistsortByColumn = null, Expression<Func<bool>> uIAWaitForElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAWaitForElementToNotExistparentWindowHandle = WorkflowExpression.Compile(uIAWaitForElementToNotExistparentWindowHandle, nameof(uIAWaitForElementToNotExistparentWindowHandle), required: true);
            var __workflow_uIAWaitForElementToNotExistsecondsToWait = WorkflowExpression.Compile(uIAWaitForElementToNotExistsecondsToWait, nameof(uIAWaitForElementToNotExistsecondsToWait), required: true);
            var __workflow_uIAWaitForElementToNotExistworkflow = WorkflowExpression.Compile(uIAWaitForElementToNotExistworkflow, nameof(uIAWaitForElementToNotExistworkflow), required: true);
            var __workflow_uIAWaitForElementToNotExistsearchElementName = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchElementName, nameof(uIAWaitForElementToNotExistsearchElementName), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchElementClassName = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchElementClassName, nameof(uIAWaitForElementToNotExistsearchElementClassName), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchElementAutomationId, nameof(uIAWaitForElementToNotExistsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchLocalizedControlType, nameof(uIAWaitForElementToNotExistsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchProcessId = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchProcessId, nameof(uIAWaitForElementToNotExistsearchProcessId), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchSubTree = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchSubTree, nameof(uIAWaitForElementToNotExistsearchSubTree), required: false);
            var __workflow_uIAWaitForElementToNotExistmatchIndex = WorkflowExpression.Compile(uIAWaitForElementToNotExistmatchIndex, nameof(uIAWaitForElementToNotExistmatchIndex), required: false);
            var __workflow_uIAWaitForElementToNotExistsearchFilter = WorkflowExpression.Compile(uIAWaitForElementToNotExistsearchFilter, nameof(uIAWaitForElementToNotExistsearchFilter), required: false);
            var __workflow_uIAWaitForElementToNotExistsortByColumn = WorkflowExpression.Compile(uIAWaitForElementToNotExistsortByColumn, nameof(uIAWaitForElementToNotExistsortByColumn), required: false);
            var __workflow_uIAWaitForElementToNotExistmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForElementToNotExistmatchIndexAscending, nameof(uIAWaitForElementToNotExistmatchIndexAscending), required: false);
            var __workflow_uIAWaitForElementToNotExistincludeChildProcesses = WorkflowExpression.Compile(uIAWaitForElementToNotExistincludeChildProcesses, nameof(uIAWaitForElementToNotExistincludeChildProcesses), required: false);
            var __workflow_uIAWaitForElementToNotExistraiseExceptionIfElementStillExists = WorkflowExpression.Compile(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists, nameof(uIAWaitForElementToNotExistraiseExceptionIfElementStillExists), required: false);
            var __workflow_uIAWaitForElementToNotExistmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForElementToNotExistmaxElementsToSearch, nameof(uIAWaitForElementToNotExistmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForElementToNotExistmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForElementToNotExistmaxRelativeSearchDepth, nameof(uIAWaitForElementToNotExistmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode, nameof(uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAWaitForElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForElementToNotExist = new JObject();
                var uIAWaitForElementToNotExistpropCount = 0;
                uIAWaitForElementToNotExistpropCount++;
                uIAWaitForElementToNotExist["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistparentWindowHandle);
                if (__workflow_uIAWaitForElementToNotExistsearchElementName != null)
                {
                    uIAWaitForElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchElementName);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchElementClassName != null)
                {
                    uIAWaitForElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchElementClassName);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchElementAutomationId != null)
                {
                    uIAWaitForElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchElementAutomationId);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchLocalizedControlType != null)
                {
                    uIAWaitForElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchLocalizedControlType);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchProcessId != null)
                {
                    uIAWaitForElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchProcessId);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistsearchSubTree != null)
                    {
                        uIAWaitForElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchSubTree);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["SearchSubTree"] = true;
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
                uIAWaitForElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsecondsToWait);
                if (__workflow_uIAWaitForElementToNotExistmatchIndex != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistmatchIndex != null)
                    {
                        uIAWaitForElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistmatchIndex);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["MatchIndex"] = 1;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsearchFilter != null)
                {
                    uIAWaitForElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsearchFilter);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistsortByColumn != null)
                {
                    uIAWaitForElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistsortByColumn);
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistmatchIndexAscending != null)
                    {
                        uIAWaitForElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistmatchIndexAscending);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["MatchIndexAscending"] = true;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistincludeChildProcesses != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistincludeChildProcesses != null)
                    {
                        uIAWaitForElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistincludeChildProcesses);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["IncludeChildProcesses"] = false;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistraiseExceptionIfElementStillExists);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistmaxElementsToSearch != null)
                    {
                        uIAWaitForElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistmaxElementsToSearch);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["MaxElementsToSearch"] = 0;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistmaxRelativeSearchDepth);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistmaxChildElementsToSearchPerNode);
                        uIAWaitForElementToNotExistpropCount++;
                    }

                    uIAWaitForElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForElementToNotExist["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForElementToNotExistpropCount++;
                }

                uIAWaitForElementToNotExistpropCount++;
                uIAWaitForElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForElementToNotExistworkflow);
                if (uIAWaitForElementToNotExistpropCount > 0)
                {
                    callPayload.Body = uIAWaitForElementToNotExist;
                }

                return new ApiConnectionAction<UIAWaitForElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration> UIAWaitForDesktopElementToNotExist(Expression<Func<int>> uIAWaitForDesktopElementToNotExistsecondsToWait, Expression<Func<string>> uIAWaitForDesktopElementToNotExistworkflow, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementClassName = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchLocalizedControlType = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistsearchProcessId = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistsearchSubTree = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmatchIndex = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsearchFilter = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistsortByColumn = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistmatchIndexAscending = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistincludeChildProcesses = null, Expression<Func<bool>> uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAWaitForDesktopElementToNotExistsecondsToWait = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsecondsToWait, nameof(uIAWaitForDesktopElementToNotExistsecondsToWait), required: true);
            var __workflow_uIAWaitForDesktopElementToNotExistworkflow = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistworkflow, nameof(uIAWaitForDesktopElementToNotExistworkflow), required: true);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchElementName = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchElementName, nameof(uIAWaitForDesktopElementToNotExistsearchElementName), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchElementClassName = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchElementClassName, nameof(uIAWaitForDesktopElementToNotExistsearchElementClassName), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchElementAutomationId, nameof(uIAWaitForDesktopElementToNotExistsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchLocalizedControlType, nameof(uIAWaitForDesktopElementToNotExistsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchProcessId = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchProcessId, nameof(uIAWaitForDesktopElementToNotExistsearchProcessId), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchSubTree = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchSubTree, nameof(uIAWaitForDesktopElementToNotExistsearchSubTree), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistmatchIndex = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistmatchIndex, nameof(uIAWaitForDesktopElementToNotExistmatchIndex), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsearchFilter = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsearchFilter, nameof(uIAWaitForDesktopElementToNotExistsearchFilter), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistsortByColumn = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistsortByColumn, nameof(uIAWaitForDesktopElementToNotExistsortByColumn), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistmatchIndexAscending, nameof(uIAWaitForDesktopElementToNotExistmatchIndexAscending), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistincludeChildProcesses = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistincludeChildProcesses, nameof(uIAWaitForDesktopElementToNotExistincludeChildProcesses), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists, nameof(uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistmaxElementsToSearch, nameof(uIAWaitForDesktopElementToNotExistmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth, nameof(uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode, nameof(uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAWaitForDesktopElementToNotExistResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForDesktopElementToNotExist";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForDesktopElementToNotExist = new JObject();
                var uIAWaitForDesktopElementToNotExistpropCount = 0;
                if (__workflow_uIAWaitForDesktopElementToNotExistsearchElementName != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchElementName);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchElementClassName != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchElementClassName);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchElementAutomationId != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchElementAutomationId);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchLocalizedControlType != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchLocalizedControlType);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchProcessId != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchProcessId);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistsearchSubTree != null)
                    {
                        uIAWaitForDesktopElementToNotExist["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchSubTree);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["SearchSubTree"] = true;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
                uIAWaitForDesktopElementToNotExist["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsecondsToWait);
                if (__workflow_uIAWaitForDesktopElementToNotExistmatchIndex != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistmatchIndex != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistmatchIndex);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndex"] = 1;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsearchFilter != null)
                {
                    uIAWaitForDesktopElementToNotExist["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsearchFilter);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistsortByColumn != null)
                {
                    uIAWaitForDesktopElementToNotExist["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistsortByColumn);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistmatchIndexAscending != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistmatchIndexAscending);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["MatchIndexAscending"] = true;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistincludeChildProcesses != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistincludeChildProcesses != null)
                    {
                        uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistincludeChildProcesses);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["IncludeChildProcesses"] = false;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists != null)
                    {
                        uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistraiseExceptionIfElementStillExists);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["RaiseExceptionIfElementStillExists"] = false;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistmaxElementsToSearch != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistmaxElementsToSearch);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["MaxElementsToSearch"] = 0;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistmaxRelativeSearchDepth);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistmaxChildElementsToSearchPerNode);
                        uIAWaitForDesktopElementToNotExistpropCount++;
                    }

                    uIAWaitForDesktopElementToNotExistpropCount++;
                }
                else
                {
                    uIAWaitForDesktopElementToNotExist["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                if (__workflow_uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForDesktopElementToNotExist["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForDesktopElementToNotExistpropCount++;
                }

                uIAWaitForDesktopElementToNotExistpropCount++;
                uIAWaitForDesktopElementToNotExist["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForDesktopElementToNotExistworkflow);
                if (uIAWaitForDesktopElementToNotExistpropCount > 0)
                {
                    callPayload.Body = uIAWaitForDesktopElementToNotExist;
                }

                return new ApiConnectionAction<UIAWaitForDesktopElementToNotExistResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAPressElement(Expression<Func<int>> uIAPressElementparentWindowHandle, Expression<Func<string>> uIAPressElementworkflow, Expression<Func<string>> uIAPressElementsearchElementName = null, Expression<Func<string>> uIAPressElementsearchElementClassName = null, Expression<Func<string>> uIAPressElementsearchElementAutomationId = null, Expression<Func<string>> uIAPressElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAPressElementsearchSubTree = null, Expression<Func<bool>> uIAPressElementwait = null, Expression<Func<bool>> uIAPressElementwin32ClickButton = null, Expression<Func<int>> uIAPressElementmatchIndex = null, Expression<Func<string>> uIAPressElementsearchFilter = null, Expression<Func<string>> uIAPressElementsortByColumn = null, Expression<Func<bool>> uIAPressElementmatchIndexAscending = null, Expression<Func<int>> uIAPressElementmaxElementsToSearch = null, Expression<Func<int>> uIAPressElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAPressElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAPressElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAPressElementtryInvokePattern = null, Expression<Func<bool>> uIAPressElementtryLegacyPattern = null)
        {
            var __workflow_uIAPressElementparentWindowHandle = WorkflowExpression.Compile(uIAPressElementparentWindowHandle, nameof(uIAPressElementparentWindowHandle), required: true);
            var __workflow_uIAPressElementworkflow = WorkflowExpression.Compile(uIAPressElementworkflow, nameof(uIAPressElementworkflow), required: true);
            var __workflow_uIAPressElementsearchElementName = WorkflowExpression.Compile(uIAPressElementsearchElementName, nameof(uIAPressElementsearchElementName), required: false);
            var __workflow_uIAPressElementsearchElementClassName = WorkflowExpression.Compile(uIAPressElementsearchElementClassName, nameof(uIAPressElementsearchElementClassName), required: false);
            var __workflow_uIAPressElementsearchElementAutomationId = WorkflowExpression.Compile(uIAPressElementsearchElementAutomationId, nameof(uIAPressElementsearchElementAutomationId), required: false);
            var __workflow_uIAPressElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAPressElementsearchLocalizedControlType, nameof(uIAPressElementsearchLocalizedControlType), required: false);
            var __workflow_uIAPressElementsearchSubTree = WorkflowExpression.Compile(uIAPressElementsearchSubTree, nameof(uIAPressElementsearchSubTree), required: false);
            var __workflow_uIAPressElementwait = WorkflowExpression.Compile(uIAPressElementwait, nameof(uIAPressElementwait), required: false);
            var __workflow_uIAPressElementwin32ClickButton = WorkflowExpression.Compile(uIAPressElementwin32ClickButton, nameof(uIAPressElementwin32ClickButton), required: false);
            var __workflow_uIAPressElementmatchIndex = WorkflowExpression.Compile(uIAPressElementmatchIndex, nameof(uIAPressElementmatchIndex), required: false);
            var __workflow_uIAPressElementsearchFilter = WorkflowExpression.Compile(uIAPressElementsearchFilter, nameof(uIAPressElementsearchFilter), required: false);
            var __workflow_uIAPressElementsortByColumn = WorkflowExpression.Compile(uIAPressElementsortByColumn, nameof(uIAPressElementsortByColumn), required: false);
            var __workflow_uIAPressElementmatchIndexAscending = WorkflowExpression.Compile(uIAPressElementmatchIndexAscending, nameof(uIAPressElementmatchIndexAscending), required: false);
            var __workflow_uIAPressElementmaxElementsToSearch = WorkflowExpression.Compile(uIAPressElementmaxElementsToSearch, nameof(uIAPressElementmaxElementsToSearch), required: false);
            var __workflow_uIAPressElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAPressElementmaxRelativeSearchDepth, nameof(uIAPressElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAPressElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAPressElementmaxChildElementsToSearchPerNode, nameof(uIAPressElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAPressElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAPressElementelementLocalizedControlTypesNotToTraverse, nameof(uIAPressElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAPressElementtryInvokePattern = WorkflowExpression.Compile(uIAPressElementtryInvokePattern, nameof(uIAPressElementtryInvokePattern), required: false);
            var __workflow_uIAPressElementtryLegacyPattern = WorkflowExpression.Compile(uIAPressElementtryLegacyPattern, nameof(uIAPressElementtryLegacyPattern), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/PressElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAPressElement = new JObject();
                var uIAPressElementpropCount = 0;
                uIAPressElementpropCount++;
                uIAPressElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementparentWindowHandle);
                if (__workflow_uIAPressElementsearchElementName != null)
                {
                    uIAPressElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchElementName);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsearchElementClassName != null)
                {
                    uIAPressElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchElementClassName);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsearchElementAutomationId != null)
                {
                    uIAPressElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchElementAutomationId);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsearchLocalizedControlType != null)
                {
                    uIAPressElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchLocalizedControlType);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsearchSubTree != null)
                {
                    if (__workflow_uIAPressElementsearchSubTree != null)
                    {
                        uIAPressElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchSubTree);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["SearchSubTree"] = true;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementwait != null)
                {
                    if (__workflow_uIAPressElementwait != null)
                    {
                        uIAPressElement["Wait"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementwait);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["Wait"] = false;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementwin32ClickButton != null)
                {
                    if (__workflow_uIAPressElementwin32ClickButton != null)
                    {
                        uIAPressElement["Win32ClickButton"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementwin32ClickButton);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["Win32ClickButton"] = false;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementmatchIndex != null)
                {
                    if (__workflow_uIAPressElementmatchIndex != null)
                    {
                        uIAPressElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementmatchIndex);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["MatchIndex"] = 1;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsearchFilter != null)
                {
                    uIAPressElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsearchFilter);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementsortByColumn != null)
                {
                    uIAPressElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementsortByColumn);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAPressElementmatchIndexAscending != null)
                    {
                        uIAPressElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementmatchIndexAscending);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["MatchIndexAscending"] = true;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAPressElementmaxElementsToSearch != null)
                    {
                        uIAPressElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementmaxElementsToSearch);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["MaxElementsToSearch"] = 0;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAPressElementmaxRelativeSearchDepth != null)
                    {
                        uIAPressElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementmaxRelativeSearchDepth);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["MaxRelativeSearchDepth"] = 0;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAPressElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAPressElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementmaxChildElementsToSearchPerNode);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAPressElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementelementLocalizedControlTypesNotToTraverse);
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementtryInvokePattern != null)
                {
                    if (__workflow_uIAPressElementtryInvokePattern != null)
                    {
                        uIAPressElement["TryInvokePattern"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementtryInvokePattern);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["TryInvokePattern"] = true;
                    uIAPressElementpropCount++;
                }

                if (__workflow_uIAPressElementtryLegacyPattern != null)
                {
                    if (__workflow_uIAPressElementtryLegacyPattern != null)
                    {
                        uIAPressElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementtryLegacyPattern);
                        uIAPressElementpropCount++;
                    }

                    uIAPressElementpropCount++;
                }
                else
                {
                    uIAPressElement["TryLegacyPattern"] = false;
                    uIAPressElementpropCount++;
                }

                uIAPressElementpropCount++;
                uIAPressElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAPressElementworkflow);
                if (uIAPressElementpropCount > 0)
                {
                    callPayload.Body = uIAPressElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalMouseClickOnElement(Expression<Func<int>> uIAGlobalMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalMouseClickOnElementoffsetRelativeToInput>> uIAGlobalMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalMouseClickOnElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementparentWindowHandle, nameof(uIAGlobalMouseClickOnElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalMouseClickOnElementworkflow = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementworkflow, nameof(uIAGlobalMouseClickOnElementworkflow), required: true);
            var __workflow_uIAGlobalMouseClickOnElementsearchElementName = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchElementName, nameof(uIAGlobalMouseClickOnElementsearchElementName), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchElementClassName, nameof(uIAGlobalMouseClickOnElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchElementAutomationId, nameof(uIAGlobalMouseClickOnElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchLocalizedControlType, nameof(uIAGlobalMouseClickOnElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchSubTree, nameof(uIAGlobalMouseClickOnElementsearchSubTree), required: false);
            var __workflow_uIAGlobalMouseClickOnElementfocusElementFirst = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementfocusElementFirst, nameof(uIAGlobalMouseClickOnElementfocusElementFirst), required: false);
            var __workflow_uIAGlobalMouseClickOnElementmatchIndex = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementmatchIndex, nameof(uIAGlobalMouseClickOnElementmatchIndex), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsearchFilter = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsearchFilter, nameof(uIAGlobalMouseClickOnElementsearchFilter), required: false);
            var __workflow_uIAGlobalMouseClickOnElementsortByColumn = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementsortByColumn, nameof(uIAGlobalMouseClickOnElementsortByColumn), required: false);
            var __workflow_uIAGlobalMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementmatchIndexAscending, nameof(uIAGlobalMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementclickOffsetX, nameof(uIAGlobalMouseClickOnElementclickOffsetX), required: false);
            var __workflow_uIAGlobalMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementclickOffsetY, nameof(uIAGlobalMouseClickOnElementclickOffsetY), required: false);
            var __workflow_uIAGlobalMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementoffsetRelativeTo, nameof(uIAGlobalMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_uIAGlobalMouseClickOnElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementmaxElementsToSearch, nameof(uIAGlobalMouseClickOnElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalMouseClickOnElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth, nameof(uIAGlobalMouseClickOnElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMouseClickOnElement = new JObject();
                var uIAGlobalMouseClickOnElementpropCount = 0;
                uIAGlobalMouseClickOnElementpropCount++;
                uIAGlobalMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementparentWindowHandle);
                if (__workflow_uIAGlobalMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchElementName);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchElementClassName);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchSubTree);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["SearchSubTree"] = true;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementfocusElementFirst != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementfocusElementFirst != null)
                    {
                        uIAGlobalMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementfocusElementFirst);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["FocusElementFirst"] = true;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementmatchIndex != null)
                    {
                        uIAGlobalMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementmatchIndex);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["MatchIndex"] = 1;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsearchFilter != null)
                {
                    uIAGlobalMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsearchFilter);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementsortByColumn);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementmatchIndexAscending);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["MatchIndexAscending"] = true;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementclickOffsetX != null)
                    {
                        uIAGlobalMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementclickOffsetX);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["ClickOffsetX"] = 0;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementclickOffsetY != null)
                    {
                        uIAGlobalMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementclickOffsetY);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["ClickOffsetY"] = 0;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementoffsetRelativeTo != null)
                {
                    uIAGlobalMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementmaxElementsToSearch);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["MaxElementsToSearch"] = 0;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementmaxRelativeSearchDepth);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementmaxChildElementsToSearchPerNode);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalMouseClickOnElementpropCount++;
                }

                uIAGlobalMouseClickOnElementpropCount++;
                uIAGlobalMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickOnElementworkflow);
                if (uIAGlobalMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalRightMouseClickOnElement(Expression<Func<int>> uIAGlobalRightMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalRightMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalRightMouseClickOnElementoffsetRelativeToInput>> uIAGlobalRightMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalRightMouseClickOnElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementparentWindowHandle, nameof(uIAGlobalRightMouseClickOnElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalRightMouseClickOnElementworkflow = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementworkflow, nameof(uIAGlobalRightMouseClickOnElementworkflow), required: true);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchElementName = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchElementName, nameof(uIAGlobalRightMouseClickOnElementsearchElementName), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchElementClassName, nameof(uIAGlobalRightMouseClickOnElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchElementAutomationId, nameof(uIAGlobalRightMouseClickOnElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchLocalizedControlType, nameof(uIAGlobalRightMouseClickOnElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchSubTree, nameof(uIAGlobalRightMouseClickOnElementsearchSubTree), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementfocusElementFirst = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementfocusElementFirst, nameof(uIAGlobalRightMouseClickOnElementfocusElementFirst), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementmatchIndex = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementmatchIndex, nameof(uIAGlobalRightMouseClickOnElementmatchIndex), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsearchFilter = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsearchFilter, nameof(uIAGlobalRightMouseClickOnElementsearchFilter), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementsortByColumn = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementsortByColumn, nameof(uIAGlobalRightMouseClickOnElementsortByColumn), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementmatchIndexAscending, nameof(uIAGlobalRightMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementclickOffsetX, nameof(uIAGlobalRightMouseClickOnElementclickOffsetX), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementclickOffsetY, nameof(uIAGlobalRightMouseClickOnElementclickOffsetY), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementoffsetRelativeTo, nameof(uIAGlobalRightMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementmaxElementsToSearch, nameof(uIAGlobalRightMouseClickOnElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth, nameof(uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalRightMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalRightMouseClickOnElement = new JObject();
                var uIAGlobalRightMouseClickOnElementpropCount = 0;
                uIAGlobalRightMouseClickOnElementpropCount++;
                uIAGlobalRightMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementparentWindowHandle);
                if (__workflow_uIAGlobalRightMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchElementName);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchElementClassName);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalRightMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchSubTree);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["SearchSubTree"] = true;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementfocusElementFirst != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementfocusElementFirst != null)
                    {
                        uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementfocusElementFirst);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["FocusElementFirst"] = true;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementmatchIndex != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementmatchIndex);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["MatchIndex"] = 1;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsearchFilter != null)
                {
                    uIAGlobalRightMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsearchFilter);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalRightMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementsortByColumn);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementmatchIndexAscending);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["MatchIndexAscending"] = true;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementclickOffsetX != null)
                    {
                        uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementclickOffsetX);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["ClickOffsetX"] = 0;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementclickOffsetY != null)
                    {
                        uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementclickOffsetY);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["ClickOffsetY"] = 0;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementoffsetRelativeTo != null)
                {
                    uIAGlobalRightMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementmaxElementsToSearch);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["MaxElementsToSearch"] = 0;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementmaxRelativeSearchDepth);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementmaxChildElementsToSearchPerNode);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalRightMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalRightMouseClickOnElementpropCount++;
                    }

                    uIAGlobalRightMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalRightMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalRightMouseClickOnElementpropCount++;
                }

                uIAGlobalRightMouseClickOnElementpropCount++;
                uIAGlobalRightMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalRightMouseClickOnElementworkflow);
                if (uIAGlobalRightMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalRightMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalMiddleMouseClickOnElement(Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementsearchSubTree = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput>> uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalMiddleMouseClickOnElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementparentWindowHandle, nameof(uIAGlobalMiddleMouseClickOnElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalMiddleMouseClickOnElementworkflow = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementworkflow, nameof(uIAGlobalMiddleMouseClickOnElementworkflow), required: true);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchElementName = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchElementName, nameof(uIAGlobalMiddleMouseClickOnElementsearchElementName), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchElementClassName, nameof(uIAGlobalMiddleMouseClickOnElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId, nameof(uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType, nameof(uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchSubTree, nameof(uIAGlobalMiddleMouseClickOnElementsearchSubTree), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementfocusElementFirst = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementfocusElementFirst, nameof(uIAGlobalMiddleMouseClickOnElementfocusElementFirst), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementmatchIndex = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementmatchIndex, nameof(uIAGlobalMiddleMouseClickOnElementmatchIndex), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsearchFilter = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsearchFilter, nameof(uIAGlobalMiddleMouseClickOnElementsearchFilter), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementsortByColumn = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementsortByColumn, nameof(uIAGlobalMiddleMouseClickOnElementsortByColumn), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending, nameof(uIAGlobalMiddleMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementclickOffsetX, nameof(uIAGlobalMiddleMouseClickOnElementclickOffsetX), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementclickOffsetY, nameof(uIAGlobalMiddleMouseClickOnElementclickOffsetY), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo, nameof(uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch, nameof(uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth, nameof(uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalMiddleMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMiddleMouseClickOnElement = new JObject();
                var uIAGlobalMiddleMouseClickOnElementpropCount = 0;
                uIAGlobalMiddleMouseClickOnElementpropCount++;
                uIAGlobalMiddleMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementparentWindowHandle);
                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementName);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementClassName);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchSubTree);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchSubTree"] = true;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementfocusElementFirst != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementfocusElementFirst != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementfocusElementFirst);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["FocusElementFirst"] = true;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndex != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndex);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["MatchIndex"] = 1;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsearchFilter != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsearchFilter);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementsortByColumn);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementmatchIndexAscending);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["MatchIndexAscending"] = true;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetX != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetX);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetX"] = 0;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetY != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementclickOffsetY);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["ClickOffsetY"] = 0;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementmaxElementsToSearch);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxElementsToSearch"] = 0;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementmaxRelativeSearchDepth);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementmaxChildElementsToSearchPerNode);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalMiddleMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalMiddleMouseClickOnElementpropCount++;
                    }

                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalMiddleMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalMiddleMouseClickOnElementpropCount++;
                }

                uIAGlobalMiddleMouseClickOnElementpropCount++;
                uIAGlobalMiddleMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMiddleMouseClickOnElementworkflow);
                if (uIAGlobalMiddleMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMiddleMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalDoubleLeftMouseClickOnElement(Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementworkflow, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmatchIndex = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsearchFilter = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementsortByColumn = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY = null, Expression<Func<uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput>> uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle, nameof(uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementworkflow = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementworkflow, nameof(uIAGlobalDoubleLeftMouseClickOnElementworkflow), required: true);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementName = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchElementName, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchElementName), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds, nameof(uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst, nameof(uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndex = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex, nameof(uIAGlobalDoubleLeftMouseClickOnElementmatchIndex), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchFilter = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsearchFilter, nameof(uIAGlobalDoubleLeftMouseClickOnElementsearchFilter), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementsortByColumn = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementsortByColumn, nameof(uIAGlobalDoubleLeftMouseClickOnElementsortByColumn), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending, nameof(uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX, nameof(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY, nameof(uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo, nameof(uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch, nameof(uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth, nameof(uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GlobalDoubleLeftMouseClickOnElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalDoubleLeftMouseClickOnElement = new JObject();
                var uIAGlobalDoubleLeftMouseClickOnElementpropCount = 0;
                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                uIAGlobalDoubleLeftMouseClickOnElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementparentWindowHandle);
                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementName != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementName);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementClassName);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchElementAutomationId);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchLocalizedControlType);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchSubTree);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchSubTree"] = true;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementdelayInMilliseconds);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["DelayInMilliseconds"] = 10;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementfocusElementFirst);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["FocusElementFirst"] = true;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndex != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndex);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndex"] = 1;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchFilter != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsearchFilter);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementsortByColumn != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementsortByColumn);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementmatchIndexAscending);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MatchIndexAscending"] = true;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetX);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetX"] = 0;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementclickOffsetY);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ClickOffsetY"] = 0;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeTo);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxElementsToSearch);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxElementsToSearch"] = 0;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxRelativeSearchDepth);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementmaxChildElementsToSearchPerNode);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                    }

                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }
                else
                {
                    uIAGlobalDoubleLeftMouseClickOnElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                }

                uIAGlobalDoubleLeftMouseClickOnElementpropCount++;
                uIAGlobalDoubleLeftMouseClickOnElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalDoubleLeftMouseClickOnElementworkflow);
                if (uIAGlobalDoubleLeftMouseClickOnElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalDoubleLeftMouseClickOnElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASelectElement(Expression<Func<int>> uIASelectElementparentWindowHandle, Expression<Func<string>> uIASelectElementworkflow, Expression<Func<string>> uIASelectElementsearchElementName = null, Expression<Func<string>> uIASelectElementsearchElementClassName = null, Expression<Func<string>> uIASelectElementsearchElementAutomationId = null, Expression<Func<string>> uIASelectElementsearchLocalizedControlType = null, Expression<Func<bool>> uIASelectElementsearchSubTree = null, Expression<Func<int>> uIASelectElementmatchIndex = null, Expression<Func<string>> uIASelectElementsearchFilter = null, Expression<Func<string>> uIASelectElementsortByColumn = null, Expression<Func<bool>> uIASelectElementmatchIndexAscending = null, Expression<Func<int>> uIASelectElementmaxElementsToSearch = null, Expression<Func<int>> uIASelectElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIASelectElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASelectElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIASelectElementparentWindowHandle = WorkflowExpression.Compile(uIASelectElementparentWindowHandle, nameof(uIASelectElementparentWindowHandle), required: true);
            var __workflow_uIASelectElementworkflow = WorkflowExpression.Compile(uIASelectElementworkflow, nameof(uIASelectElementworkflow), required: true);
            var __workflow_uIASelectElementsearchElementName = WorkflowExpression.Compile(uIASelectElementsearchElementName, nameof(uIASelectElementsearchElementName), required: false);
            var __workflow_uIASelectElementsearchElementClassName = WorkflowExpression.Compile(uIASelectElementsearchElementClassName, nameof(uIASelectElementsearchElementClassName), required: false);
            var __workflow_uIASelectElementsearchElementAutomationId = WorkflowExpression.Compile(uIASelectElementsearchElementAutomationId, nameof(uIASelectElementsearchElementAutomationId), required: false);
            var __workflow_uIASelectElementsearchLocalizedControlType = WorkflowExpression.Compile(uIASelectElementsearchLocalizedControlType, nameof(uIASelectElementsearchLocalizedControlType), required: false);
            var __workflow_uIASelectElementsearchSubTree = WorkflowExpression.Compile(uIASelectElementsearchSubTree, nameof(uIASelectElementsearchSubTree), required: false);
            var __workflow_uIASelectElementmatchIndex = WorkflowExpression.Compile(uIASelectElementmatchIndex, nameof(uIASelectElementmatchIndex), required: false);
            var __workflow_uIASelectElementsearchFilter = WorkflowExpression.Compile(uIASelectElementsearchFilter, nameof(uIASelectElementsearchFilter), required: false);
            var __workflow_uIASelectElementsortByColumn = WorkflowExpression.Compile(uIASelectElementsortByColumn, nameof(uIASelectElementsortByColumn), required: false);
            var __workflow_uIASelectElementmatchIndexAscending = WorkflowExpression.Compile(uIASelectElementmatchIndexAscending, nameof(uIASelectElementmatchIndexAscending), required: false);
            var __workflow_uIASelectElementmaxElementsToSearch = WorkflowExpression.Compile(uIASelectElementmaxElementsToSearch, nameof(uIASelectElementmaxElementsToSearch), required: false);
            var __workflow_uIASelectElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIASelectElementmaxRelativeSearchDepth, nameof(uIASelectElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIASelectElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIASelectElementmaxChildElementsToSearchPerNode, nameof(uIASelectElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIASelectElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIASelectElementelementLocalizedControlTypesNotToTraverse, nameof(uIASelectElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SelectElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASelectElement = new JObject();
                var uIASelectElementpropCount = 0;
                uIASelectElementpropCount++;
                uIASelectElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementparentWindowHandle);
                if (__workflow_uIASelectElementsearchElementName != null)
                {
                    uIASelectElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchElementName);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsearchElementClassName != null)
                {
                    uIASelectElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchElementClassName);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsearchElementAutomationId != null)
                {
                    uIASelectElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchElementAutomationId);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsearchLocalizedControlType != null)
                {
                    uIASelectElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchLocalizedControlType);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsearchSubTree != null)
                {
                    if (__workflow_uIASelectElementsearchSubTree != null)
                    {
                        uIASelectElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchSubTree);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["SearchSubTree"] = true;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementmatchIndex != null)
                {
                    if (__workflow_uIASelectElementmatchIndex != null)
                    {
                        uIASelectElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementmatchIndex);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["MatchIndex"] = 1;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsearchFilter != null)
                {
                    uIASelectElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsearchFilter);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementsortByColumn != null)
                {
                    uIASelectElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementsortByColumn);
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementmatchIndexAscending != null)
                {
                    if (__workflow_uIASelectElementmatchIndexAscending != null)
                    {
                        uIASelectElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementmatchIndexAscending);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["MatchIndexAscending"] = true;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIASelectElementmaxElementsToSearch != null)
                    {
                        uIASelectElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementmaxElementsToSearch);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["MaxElementsToSearch"] = 0;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIASelectElementmaxRelativeSearchDepth != null)
                    {
                        uIASelectElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementmaxRelativeSearchDepth);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["MaxRelativeSearchDepth"] = 0;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIASelectElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIASelectElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementmaxChildElementsToSearchPerNode);
                        uIASelectElementpropCount++;
                    }

                    uIASelectElementpropCount++;
                }
                else
                {
                    uIASelectElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIASelectElementpropCount++;
                }

                if (__workflow_uIASelectElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIASelectElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementelementLocalizedControlTypesNotToTraverse);
                    uIASelectElementpropCount++;
                }

                uIASelectElementpropCount++;
                uIASelectElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASelectElementworkflow);
                if (uIASelectElementpropCount > 0)
                {
                    callPayload.Body = uIASelectElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputPasswordIntoElement(Expression<Func<int>> uIAInputPasswordIntoElementparentWindowHandle, Expression<Func<string>> uIAInputPasswordIntoElementpasswordToInput, Expression<Func<string>> uIAInputPasswordIntoElementworkflow, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementName = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputPasswordIntoElementsearchSubTree = null, Expression<Func<int>> uIAInputPasswordIntoElementmatchIndex = null, Expression<Func<string>> uIAInputPasswordIntoElementsearchFilter = null, Expression<Func<string>> uIAInputPasswordIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputPasswordIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputPasswordIntoElementpasswordContainsStoredPassword = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputPasswordIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputPasswordIntoElementtryLegacyPattern = null)
        {
            var __workflow_uIAInputPasswordIntoElementparentWindowHandle = WorkflowExpression.Compile(uIAInputPasswordIntoElementparentWindowHandle, nameof(uIAInputPasswordIntoElementparentWindowHandle), required: true);
            var __workflow_uIAInputPasswordIntoElementpasswordToInput = WorkflowExpression.Compile(uIAInputPasswordIntoElementpasswordToInput, nameof(uIAInputPasswordIntoElementpasswordToInput), required: true);
            var __workflow_uIAInputPasswordIntoElementworkflow = WorkflowExpression.Compile(uIAInputPasswordIntoElementworkflow, nameof(uIAInputPasswordIntoElementworkflow), required: true);
            var __workflow_uIAInputPasswordIntoElementsearchElementName = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchElementName, nameof(uIAInputPasswordIntoElementsearchElementName), required: false);
            var __workflow_uIAInputPasswordIntoElementsearchElementClassName = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchElementClassName, nameof(uIAInputPasswordIntoElementsearchElementClassName), required: false);
            var __workflow_uIAInputPasswordIntoElementsearchElementAutomationId = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchElementAutomationId, nameof(uIAInputPasswordIntoElementsearchElementAutomationId), required: false);
            var __workflow_uIAInputPasswordIntoElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchLocalizedControlType, nameof(uIAInputPasswordIntoElementsearchLocalizedControlType), required: false);
            var __workflow_uIAInputPasswordIntoElementsearchSubTree = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchSubTree, nameof(uIAInputPasswordIntoElementsearchSubTree), required: false);
            var __workflow_uIAInputPasswordIntoElementmatchIndex = WorkflowExpression.Compile(uIAInputPasswordIntoElementmatchIndex, nameof(uIAInputPasswordIntoElementmatchIndex), required: false);
            var __workflow_uIAInputPasswordIntoElementsearchFilter = WorkflowExpression.Compile(uIAInputPasswordIntoElementsearchFilter, nameof(uIAInputPasswordIntoElementsearchFilter), required: false);
            var __workflow_uIAInputPasswordIntoElementsortByColumn = WorkflowExpression.Compile(uIAInputPasswordIntoElementsortByColumn, nameof(uIAInputPasswordIntoElementsortByColumn), required: false);
            var __workflow_uIAInputPasswordIntoElementmatchIndexAscending = WorkflowExpression.Compile(uIAInputPasswordIntoElementmatchIndexAscending, nameof(uIAInputPasswordIntoElementmatchIndexAscending), required: false);
            var __workflow_uIAInputPasswordIntoElementpasswordContainsStoredPassword = WorkflowExpression.Compile(uIAInputPasswordIntoElementpasswordContainsStoredPassword, nameof(uIAInputPasswordIntoElementpasswordContainsStoredPassword), required: false);
            var __workflow_uIAInputPasswordIntoElementmaxElementsToSearch = WorkflowExpression.Compile(uIAInputPasswordIntoElementmaxElementsToSearch, nameof(uIAInputPasswordIntoElementmaxElementsToSearch), required: false);
            var __workflow_uIAInputPasswordIntoElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAInputPasswordIntoElementmaxRelativeSearchDepth, nameof(uIAInputPasswordIntoElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode, nameof(uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse, nameof(uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAInputPasswordIntoElementtryValuePattern = WorkflowExpression.Compile(uIAInputPasswordIntoElementtryValuePattern, nameof(uIAInputPasswordIntoElementtryValuePattern), required: false);
            var __workflow_uIAInputPasswordIntoElementtryLegacyPattern = WorkflowExpression.Compile(uIAInputPasswordIntoElementtryLegacyPattern, nameof(uIAInputPasswordIntoElementtryLegacyPattern), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputPasswordIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputPasswordIntoElement = new JObject();
                var uIAInputPasswordIntoElementpropCount = 0;
                uIAInputPasswordIntoElementpropCount++;
                uIAInputPasswordIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementparentWindowHandle);
                if (__workflow_uIAInputPasswordIntoElementsearchElementName != null)
                {
                    uIAInputPasswordIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchElementName);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsearchElementClassName != null)
                {
                    uIAInputPasswordIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchElementClassName);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsearchElementAutomationId != null)
                {
                    uIAInputPasswordIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchElementAutomationId);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputPasswordIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchLocalizedControlType);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsearchSubTree != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementsearchSubTree != null)
                    {
                        uIAInputPasswordIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchSubTree);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["SearchSubTree"] = true;
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
                uIAInputPasswordIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementpasswordToInput);
                if (__workflow_uIAInputPasswordIntoElementmatchIndex != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementmatchIndex != null)
                    {
                        uIAInputPasswordIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementmatchIndex);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["MatchIndex"] = 1;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsearchFilter != null)
                {
                    uIAInputPasswordIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsearchFilter);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementsortByColumn != null)
                {
                    uIAInputPasswordIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementsortByColumn);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementmatchIndexAscending != null)
                    {
                        uIAInputPasswordIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementmatchIndexAscending);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["MatchIndexAscending"] = true;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementpasswordContainsStoredPassword != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementpasswordContainsStoredPassword != null)
                    {
                        uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementpasswordContainsStoredPassword);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["PasswordContainsStoredPassword"] = false;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementmaxElementsToSearch != null)
                    {
                        uIAInputPasswordIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementmaxElementsToSearch);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["MaxElementsToSearch"] = 0;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementmaxRelativeSearchDepth != null)
                    {
                        uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementmaxRelativeSearchDepth);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["MaxRelativeSearchDepth"] = 0;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementmaxChildElementsToSearchPerNode);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAInputPasswordIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementtryValuePattern != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementtryValuePattern != null)
                    {
                        uIAInputPasswordIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementtryValuePattern);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["TryValuePattern"] = true;
                    uIAInputPasswordIntoElementpropCount++;
                }

                if (__workflow_uIAInputPasswordIntoElementtryLegacyPattern != null)
                {
                    if (__workflow_uIAInputPasswordIntoElementtryLegacyPattern != null)
                    {
                        uIAInputPasswordIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementtryLegacyPattern);
                        uIAInputPasswordIntoElementpropCount++;
                    }

                    uIAInputPasswordIntoElementpropCount++;
                }
                else
                {
                    uIAInputPasswordIntoElement["TryLegacyPattern"] = false;
                    uIAInputPasswordIntoElementpropCount++;
                }

                uIAInputPasswordIntoElementpropCount++;
                uIAInputPasswordIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAInputPasswordIntoElementworkflow);
                if (uIAInputPasswordIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputPasswordIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputTextIntoElement(Expression<Func<int>> uIAInputTextIntoElementparentWindowHandle, Expression<Func<string>> uIAInputTextIntoElementworkflow, Expression<Func<string>> uIAInputTextIntoElementsearchElementName = null, Expression<Func<string>> uIAInputTextIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputTextIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputTextIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputTextIntoElementsearchSubTree = null, Expression<Func<string>> uIAInputTextIntoElementtextToInput = null, Expression<Func<int>> uIAInputTextIntoElementmatchIndex = null, Expression<Func<string>> uIAInputTextIntoElementsearchFilter = null, Expression<Func<string>> uIAInputTextIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputTextIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputTextIntoElementreplaceExistingValue = null, Expression<Func<int>> uIAInputTextIntoElementinsertPosition = null, Expression<Func<int>> uIAInputTextIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputTextIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputTextIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputTextIntoElementraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputTextIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputTextIntoElementtryLegacyPattern = null)
        {
            var __workflow_uIAInputTextIntoElementparentWindowHandle = WorkflowExpression.Compile(uIAInputTextIntoElementparentWindowHandle, nameof(uIAInputTextIntoElementparentWindowHandle), required: true);
            var __workflow_uIAInputTextIntoElementworkflow = WorkflowExpression.Compile(uIAInputTextIntoElementworkflow, nameof(uIAInputTextIntoElementworkflow), required: true);
            var __workflow_uIAInputTextIntoElementsearchElementName = WorkflowExpression.Compile(uIAInputTextIntoElementsearchElementName, nameof(uIAInputTextIntoElementsearchElementName), required: false);
            var __workflow_uIAInputTextIntoElementsearchElementClassName = WorkflowExpression.Compile(uIAInputTextIntoElementsearchElementClassName, nameof(uIAInputTextIntoElementsearchElementClassName), required: false);
            var __workflow_uIAInputTextIntoElementsearchElementAutomationId = WorkflowExpression.Compile(uIAInputTextIntoElementsearchElementAutomationId, nameof(uIAInputTextIntoElementsearchElementAutomationId), required: false);
            var __workflow_uIAInputTextIntoElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAInputTextIntoElementsearchLocalizedControlType, nameof(uIAInputTextIntoElementsearchLocalizedControlType), required: false);
            var __workflow_uIAInputTextIntoElementsearchSubTree = WorkflowExpression.Compile(uIAInputTextIntoElementsearchSubTree, nameof(uIAInputTextIntoElementsearchSubTree), required: false);
            var __workflow_uIAInputTextIntoElementtextToInput = WorkflowExpression.Compile(uIAInputTextIntoElementtextToInput, nameof(uIAInputTextIntoElementtextToInput), required: false);
            var __workflow_uIAInputTextIntoElementmatchIndex = WorkflowExpression.Compile(uIAInputTextIntoElementmatchIndex, nameof(uIAInputTextIntoElementmatchIndex), required: false);
            var __workflow_uIAInputTextIntoElementsearchFilter = WorkflowExpression.Compile(uIAInputTextIntoElementsearchFilter, nameof(uIAInputTextIntoElementsearchFilter), required: false);
            var __workflow_uIAInputTextIntoElementsortByColumn = WorkflowExpression.Compile(uIAInputTextIntoElementsortByColumn, nameof(uIAInputTextIntoElementsortByColumn), required: false);
            var __workflow_uIAInputTextIntoElementmatchIndexAscending = WorkflowExpression.Compile(uIAInputTextIntoElementmatchIndexAscending, nameof(uIAInputTextIntoElementmatchIndexAscending), required: false);
            var __workflow_uIAInputTextIntoElementreplaceExistingValue = WorkflowExpression.Compile(uIAInputTextIntoElementreplaceExistingValue, nameof(uIAInputTextIntoElementreplaceExistingValue), required: false);
            var __workflow_uIAInputTextIntoElementinsertPosition = WorkflowExpression.Compile(uIAInputTextIntoElementinsertPosition, nameof(uIAInputTextIntoElementinsertPosition), required: false);
            var __workflow_uIAInputTextIntoElementmaxElementsToSearch = WorkflowExpression.Compile(uIAInputTextIntoElementmaxElementsToSearch, nameof(uIAInputTextIntoElementmaxElementsToSearch), required: false);
            var __workflow_uIAInputTextIntoElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAInputTextIntoElementmaxRelativeSearchDepth, nameof(uIAInputTextIntoElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAInputTextIntoElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAInputTextIntoElementmaxChildElementsToSearchPerNode, nameof(uIAInputTextIntoElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse, nameof(uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAInputTextIntoElementraiseExceptionIfInputValidationFails = WorkflowExpression.Compile(uIAInputTextIntoElementraiseExceptionIfInputValidationFails, nameof(uIAInputTextIntoElementraiseExceptionIfInputValidationFails), required: false);
            var __workflow_uIAInputTextIntoElementtryValuePattern = WorkflowExpression.Compile(uIAInputTextIntoElementtryValuePattern, nameof(uIAInputTextIntoElementtryValuePattern), required: false);
            var __workflow_uIAInputTextIntoElementtryLegacyPattern = WorkflowExpression.Compile(uIAInputTextIntoElementtryLegacyPattern, nameof(uIAInputTextIntoElementtryLegacyPattern), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputTextIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputTextIntoElement = new JObject();
                var uIAInputTextIntoElementpropCount = 0;
                uIAInputTextIntoElementpropCount++;
                uIAInputTextIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementparentWindowHandle);
                if (__workflow_uIAInputTextIntoElementsearchElementName != null)
                {
                    uIAInputTextIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchElementName);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsearchElementClassName != null)
                {
                    uIAInputTextIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchElementClassName);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsearchElementAutomationId != null)
                {
                    uIAInputTextIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchElementAutomationId);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputTextIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchLocalizedControlType);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsearchSubTree != null)
                {
                    if (__workflow_uIAInputTextIntoElementsearchSubTree != null)
                    {
                        uIAInputTextIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchSubTree);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["SearchSubTree"] = true;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementtextToInput != null)
                {
                    uIAInputTextIntoElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementtextToInput);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementmatchIndex != null)
                {
                    if (__workflow_uIAInputTextIntoElementmatchIndex != null)
                    {
                        uIAInputTextIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementmatchIndex);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["MatchIndex"] = 1;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsearchFilter != null)
                {
                    uIAInputTextIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsearchFilter);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementsortByColumn != null)
                {
                    uIAInputTextIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementsortByColumn);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAInputTextIntoElementmatchIndexAscending != null)
                    {
                        uIAInputTextIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementmatchIndexAscending);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["MatchIndexAscending"] = true;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementreplaceExistingValue != null)
                {
                    if (__workflow_uIAInputTextIntoElementreplaceExistingValue != null)
                    {
                        uIAInputTextIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementreplaceExistingValue);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["ReplaceExistingValue"] = true;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementinsertPosition != null)
                {
                    if (__workflow_uIAInputTextIntoElementinsertPosition != null)
                    {
                        uIAInputTextIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementinsertPosition);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["InsertPosition"] = 0;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAInputTextIntoElementmaxElementsToSearch != null)
                    {
                        uIAInputTextIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementmaxElementsToSearch);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["MaxElementsToSearch"] = 0;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAInputTextIntoElementmaxRelativeSearchDepth != null)
                    {
                        uIAInputTextIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementmaxRelativeSearchDepth);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["MaxRelativeSearchDepth"] = 0;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAInputTextIntoElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementmaxChildElementsToSearchPerNode);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAInputTextIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    if (__workflow_uIAInputTextIntoElementraiseExceptionIfInputValidationFails != null)
                    {
                        uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementraiseExceptionIfInputValidationFails);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["RaiseExceptionIfInputValidationFails"] = false;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementtryValuePattern != null)
                {
                    if (__workflow_uIAInputTextIntoElementtryValuePattern != null)
                    {
                        uIAInputTextIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementtryValuePattern);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["TryValuePattern"] = true;
                    uIAInputTextIntoElementpropCount++;
                }

                if (__workflow_uIAInputTextIntoElementtryLegacyPattern != null)
                {
                    if (__workflow_uIAInputTextIntoElementtryLegacyPattern != null)
                    {
                        uIAInputTextIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementtryLegacyPattern);
                        uIAInputTextIntoElementpropCount++;
                    }

                    uIAInputTextIntoElementpropCount++;
                }
                else
                {
                    uIAInputTextIntoElement["TryLegacyPattern"] = false;
                    uIAInputTextIntoElementpropCount++;
                }

                uIAInputTextIntoElementpropCount++;
                uIAInputTextIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoElementworkflow);
                if (uIAInputTextIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputTextIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputTextIntoMultipleElements(Expression<Func<string>> uIAInputTextIntoMultipleElementsinputElementsJSON, Expression<Func<string>> uIAInputTextIntoMultipleElementsworkflow)
        {
            var __workflow_uIAInputTextIntoMultipleElementsinputElementsJSON = WorkflowExpression.Compile(uIAInputTextIntoMultipleElementsinputElementsJSON, nameof(uIAInputTextIntoMultipleElementsinputElementsJSON), required: true);
            var __workflow_uIAInputTextIntoMultipleElementsworkflow = WorkflowExpression.Compile(uIAInputTextIntoMultipleElementsworkflow, nameof(uIAInputTextIntoMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAInputTextIntoMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputTextIntoMultipleElements = new JObject();
                var uIAInputTextIntoMultipleElementspropCount = 0;
                uIAInputTextIntoMultipleElementspropCount++;
                uIAInputTextIntoMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoMultipleElementsinputElementsJSON);
                uIAInputTextIntoMultipleElementspropCount++;
                uIAInputTextIntoMultipleElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAInputTextIntoMultipleElementsworkflow);
                if (uIAInputTextIntoMultipleElementspropCount > 0)
                {
                    callPayload.Body = uIAInputTextIntoMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAInputReturnIntoElement(Expression<Func<int>> uIAInputReturnIntoElementparentWindowHandle, Expression<Func<string>> uIAInputReturnIntoElementworkflow, Expression<Func<string>> uIAInputReturnIntoElementsearchElementName = null, Expression<Func<string>> uIAInputReturnIntoElementsearchElementClassName = null, Expression<Func<string>> uIAInputReturnIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAInputReturnIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAInputReturnIntoElementsearchSubTree = null, Expression<Func<int>> uIAInputReturnIntoElementmatchIndex = null, Expression<Func<string>> uIAInputReturnIntoElementsearchFilter = null, Expression<Func<string>> uIAInputReturnIntoElementsortByColumn = null, Expression<Func<bool>> uIAInputReturnIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAInputReturnIntoElementreplaceExistingValue = null, Expression<Func<int>> uIAInputReturnIntoElementinsertPosition = null, Expression<Func<int>> uIAInputReturnIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAInputReturnIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAInputReturnIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAInputReturnIntoElementraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIAInputReturnIntoElementtryValuePattern = null, Expression<Func<bool>> uIAInputReturnIntoElementtryLegacyPattern = null)
        {
            var __workflow_uIAInputReturnIntoElementparentWindowHandle = WorkflowExpression.Compile(uIAInputReturnIntoElementparentWindowHandle, nameof(uIAInputReturnIntoElementparentWindowHandle), required: true);
            var __workflow_uIAInputReturnIntoElementworkflow = WorkflowExpression.Compile(uIAInputReturnIntoElementworkflow, nameof(uIAInputReturnIntoElementworkflow), required: true);
            var __workflow_uIAInputReturnIntoElementsearchElementName = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchElementName, nameof(uIAInputReturnIntoElementsearchElementName), required: false);
            var __workflow_uIAInputReturnIntoElementsearchElementClassName = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchElementClassName, nameof(uIAInputReturnIntoElementsearchElementClassName), required: false);
            var __workflow_uIAInputReturnIntoElementsearchElementAutomationId = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchElementAutomationId, nameof(uIAInputReturnIntoElementsearchElementAutomationId), required: false);
            var __workflow_uIAInputReturnIntoElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchLocalizedControlType, nameof(uIAInputReturnIntoElementsearchLocalizedControlType), required: false);
            var __workflow_uIAInputReturnIntoElementsearchSubTree = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchSubTree, nameof(uIAInputReturnIntoElementsearchSubTree), required: false);
            var __workflow_uIAInputReturnIntoElementmatchIndex = WorkflowExpression.Compile(uIAInputReturnIntoElementmatchIndex, nameof(uIAInputReturnIntoElementmatchIndex), required: false);
            var __workflow_uIAInputReturnIntoElementsearchFilter = WorkflowExpression.Compile(uIAInputReturnIntoElementsearchFilter, nameof(uIAInputReturnIntoElementsearchFilter), required: false);
            var __workflow_uIAInputReturnIntoElementsortByColumn = WorkflowExpression.Compile(uIAInputReturnIntoElementsortByColumn, nameof(uIAInputReturnIntoElementsortByColumn), required: false);
            var __workflow_uIAInputReturnIntoElementmatchIndexAscending = WorkflowExpression.Compile(uIAInputReturnIntoElementmatchIndexAscending, nameof(uIAInputReturnIntoElementmatchIndexAscending), required: false);
            var __workflow_uIAInputReturnIntoElementreplaceExistingValue = WorkflowExpression.Compile(uIAInputReturnIntoElementreplaceExistingValue, nameof(uIAInputReturnIntoElementreplaceExistingValue), required: false);
            var __workflow_uIAInputReturnIntoElementinsertPosition = WorkflowExpression.Compile(uIAInputReturnIntoElementinsertPosition, nameof(uIAInputReturnIntoElementinsertPosition), required: false);
            var __workflow_uIAInputReturnIntoElementmaxElementsToSearch = WorkflowExpression.Compile(uIAInputReturnIntoElementmaxElementsToSearch, nameof(uIAInputReturnIntoElementmaxElementsToSearch), required: false);
            var __workflow_uIAInputReturnIntoElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAInputReturnIntoElementmaxRelativeSearchDepth, nameof(uIAInputReturnIntoElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAInputReturnIntoElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode, nameof(uIAInputReturnIntoElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse, nameof(uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAInputReturnIntoElementraiseExceptionIfInputValidationFails = WorkflowExpression.Compile(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails, nameof(uIAInputReturnIntoElementraiseExceptionIfInputValidationFails), required: false);
            var __workflow_uIAInputReturnIntoElementtryValuePattern = WorkflowExpression.Compile(uIAInputReturnIntoElementtryValuePattern, nameof(uIAInputReturnIntoElementtryValuePattern), required: false);
            var __workflow_uIAInputReturnIntoElementtryLegacyPattern = WorkflowExpression.Compile(uIAInputReturnIntoElementtryLegacyPattern, nameof(uIAInputReturnIntoElementtryLegacyPattern), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/InputReturnIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAInputReturnIntoElement = new JObject();
                var uIAInputReturnIntoElementpropCount = 0;
                uIAInputReturnIntoElementpropCount++;
                uIAInputReturnIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementparentWindowHandle);
                if (__workflow_uIAInputReturnIntoElementsearchElementName != null)
                {
                    uIAInputReturnIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchElementName);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsearchElementClassName != null)
                {
                    uIAInputReturnIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchElementClassName);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsearchElementAutomationId != null)
                {
                    uIAInputReturnIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchElementAutomationId);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsearchLocalizedControlType != null)
                {
                    uIAInputReturnIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchLocalizedControlType);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsearchSubTree != null)
                {
                    if (__workflow_uIAInputReturnIntoElementsearchSubTree != null)
                    {
                        uIAInputReturnIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchSubTree);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["SearchSubTree"] = true;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementmatchIndex != null)
                {
                    if (__workflow_uIAInputReturnIntoElementmatchIndex != null)
                    {
                        uIAInputReturnIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementmatchIndex);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["MatchIndex"] = 1;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsearchFilter != null)
                {
                    uIAInputReturnIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsearchFilter);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementsortByColumn != null)
                {
                    uIAInputReturnIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementsortByColumn);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAInputReturnIntoElementmatchIndexAscending != null)
                    {
                        uIAInputReturnIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementmatchIndexAscending);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["MatchIndexAscending"] = true;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementreplaceExistingValue != null)
                {
                    if (__workflow_uIAInputReturnIntoElementreplaceExistingValue != null)
                    {
                        uIAInputReturnIntoElement["ReplaceExistingValue"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementreplaceExistingValue);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["ReplaceExistingValue"] = false;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementinsertPosition != null)
                {
                    uIAInputReturnIntoElement["InsertPosition"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementinsertPosition);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAInputReturnIntoElementmaxElementsToSearch != null)
                    {
                        uIAInputReturnIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementmaxElementsToSearch);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["MaxElementsToSearch"] = 0;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAInputReturnIntoElementmaxRelativeSearchDepth != null)
                    {
                        uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementmaxRelativeSearchDepth);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["MaxRelativeSearchDepth"] = 0;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAInputReturnIntoElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementmaxChildElementsToSearchPerNode);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAInputReturnIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                {
                    if (__workflow_uIAInputReturnIntoElementraiseExceptionIfInputValidationFails != null)
                    {
                        uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementraiseExceptionIfInputValidationFails);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["RaiseExceptionIfInputValidationFails"] = false;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementtryValuePattern != null)
                {
                    if (__workflow_uIAInputReturnIntoElementtryValuePattern != null)
                    {
                        uIAInputReturnIntoElement["TryValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementtryValuePattern);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["TryValuePattern"] = true;
                    uIAInputReturnIntoElementpropCount++;
                }

                if (__workflow_uIAInputReturnIntoElementtryLegacyPattern != null)
                {
                    if (__workflow_uIAInputReturnIntoElementtryLegacyPattern != null)
                    {
                        uIAInputReturnIntoElement["TryLegacyPattern"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementtryLegacyPattern);
                        uIAInputReturnIntoElementpropCount++;
                    }

                    uIAInputReturnIntoElementpropCount++;
                }
                else
                {
                    uIAInputReturnIntoElement["TryLegacyPattern"] = false;
                    uIAInputReturnIntoElementpropCount++;
                }

                uIAInputReturnIntoElementpropCount++;
                uIAInputReturnIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAInputReturnIntoElementworkflow);
                if (uIAInputReturnIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAInputReturnIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAFocusElement(Expression<Func<int>> uIAFocusElementparentWindowHandle, Expression<Func<string>> uIAFocusElementworkflow, Expression<Func<string>> uIAFocusElementsearchElementName = null, Expression<Func<string>> uIAFocusElementsearchElementClassName = null, Expression<Func<string>> uIAFocusElementsearchElementAutomationId = null, Expression<Func<string>> uIAFocusElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAFocusElementsearchSubTree = null, Expression<Func<int>> uIAFocusElementmatchIndex = null, Expression<Func<string>> uIAFocusElementsearchFilter = null, Expression<Func<string>> uIAFocusElementsortByColumn = null, Expression<Func<bool>> uIAFocusElementmatchIndexAscending = null, Expression<Func<int>> uIAFocusElementmaxElementsToSearch = null, Expression<Func<int>> uIAFocusElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAFocusElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAFocusElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAFocusElementparentWindowHandle = WorkflowExpression.Compile(uIAFocusElementparentWindowHandle, nameof(uIAFocusElementparentWindowHandle), required: true);
            var __workflow_uIAFocusElementworkflow = WorkflowExpression.Compile(uIAFocusElementworkflow, nameof(uIAFocusElementworkflow), required: true);
            var __workflow_uIAFocusElementsearchElementName = WorkflowExpression.Compile(uIAFocusElementsearchElementName, nameof(uIAFocusElementsearchElementName), required: false);
            var __workflow_uIAFocusElementsearchElementClassName = WorkflowExpression.Compile(uIAFocusElementsearchElementClassName, nameof(uIAFocusElementsearchElementClassName), required: false);
            var __workflow_uIAFocusElementsearchElementAutomationId = WorkflowExpression.Compile(uIAFocusElementsearchElementAutomationId, nameof(uIAFocusElementsearchElementAutomationId), required: false);
            var __workflow_uIAFocusElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAFocusElementsearchLocalizedControlType, nameof(uIAFocusElementsearchLocalizedControlType), required: false);
            var __workflow_uIAFocusElementsearchSubTree = WorkflowExpression.Compile(uIAFocusElementsearchSubTree, nameof(uIAFocusElementsearchSubTree), required: false);
            var __workflow_uIAFocusElementmatchIndex = WorkflowExpression.Compile(uIAFocusElementmatchIndex, nameof(uIAFocusElementmatchIndex), required: false);
            var __workflow_uIAFocusElementsearchFilter = WorkflowExpression.Compile(uIAFocusElementsearchFilter, nameof(uIAFocusElementsearchFilter), required: false);
            var __workflow_uIAFocusElementsortByColumn = WorkflowExpression.Compile(uIAFocusElementsortByColumn, nameof(uIAFocusElementsortByColumn), required: false);
            var __workflow_uIAFocusElementmatchIndexAscending = WorkflowExpression.Compile(uIAFocusElementmatchIndexAscending, nameof(uIAFocusElementmatchIndexAscending), required: false);
            var __workflow_uIAFocusElementmaxElementsToSearch = WorkflowExpression.Compile(uIAFocusElementmaxElementsToSearch, nameof(uIAFocusElementmaxElementsToSearch), required: false);
            var __workflow_uIAFocusElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAFocusElementmaxRelativeSearchDepth, nameof(uIAFocusElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAFocusElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAFocusElementmaxChildElementsToSearchPerNode, nameof(uIAFocusElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAFocusElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAFocusElementelementLocalizedControlTypesNotToTraverse, nameof(uIAFocusElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/FocusElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAFocusElement = new JObject();
                var uIAFocusElementpropCount = 0;
                uIAFocusElementpropCount++;
                uIAFocusElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementparentWindowHandle);
                if (__workflow_uIAFocusElementsearchElementName != null)
                {
                    uIAFocusElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchElementName);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsearchElementClassName != null)
                {
                    uIAFocusElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchElementClassName);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsearchElementAutomationId != null)
                {
                    uIAFocusElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchElementAutomationId);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsearchLocalizedControlType != null)
                {
                    uIAFocusElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchLocalizedControlType);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsearchSubTree != null)
                {
                    if (__workflow_uIAFocusElementsearchSubTree != null)
                    {
                        uIAFocusElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchSubTree);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["SearchSubTree"] = true;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementmatchIndex != null)
                {
                    if (__workflow_uIAFocusElementmatchIndex != null)
                    {
                        uIAFocusElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementmatchIndex);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["MatchIndex"] = 1;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsearchFilter != null)
                {
                    uIAFocusElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsearchFilter);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementsortByColumn != null)
                {
                    uIAFocusElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementsortByColumn);
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAFocusElementmatchIndexAscending != null)
                    {
                        uIAFocusElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementmatchIndexAscending);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["MatchIndexAscending"] = true;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAFocusElementmaxElementsToSearch != null)
                    {
                        uIAFocusElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementmaxElementsToSearch);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["MaxElementsToSearch"] = 0;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAFocusElementmaxRelativeSearchDepth != null)
                    {
                        uIAFocusElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementmaxRelativeSearchDepth);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["MaxRelativeSearchDepth"] = 0;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAFocusElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAFocusElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementmaxChildElementsToSearchPerNode);
                        uIAFocusElementpropCount++;
                    }

                    uIAFocusElementpropCount++;
                }
                else
                {
                    uIAFocusElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAFocusElementpropCount++;
                }

                if (__workflow_uIAFocusElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAFocusElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementelementLocalizedControlTypesNotToTraverse);
                    uIAFocusElementpropCount++;
                }

                uIAFocusElementpropCount++;
                uIAFocusElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAFocusElementworkflow);
                if (uIAFocusElementpropCount > 0)
                {
                    callPayload.Body = uIAFocusElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAToggleElement(Expression<Func<int>> uIAToggleElementparentWindowHandle, Expression<Func<string>> uIAToggleElementworkflow, Expression<Func<string>> uIAToggleElementsearchElementName = null, Expression<Func<string>> uIAToggleElementsearchElementClassName = null, Expression<Func<string>> uIAToggleElementsearchElementAutomationId = null, Expression<Func<string>> uIAToggleElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAToggleElementsearchSubTree = null, Expression<Func<int>> uIAToggleElementmatchIndex = null, Expression<Func<string>> uIAToggleElementsearchFilter = null, Expression<Func<string>> uIAToggleElementsortByColumn = null, Expression<Func<bool>> uIAToggleElementmatchIndexAscending = null, Expression<Func<int>> uIAToggleElementmaxElementsToSearch = null, Expression<Func<int>> uIAToggleElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAToggleElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAToggleElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAToggleElementparentWindowHandle = WorkflowExpression.Compile(uIAToggleElementparentWindowHandle, nameof(uIAToggleElementparentWindowHandle), required: true);
            var __workflow_uIAToggleElementworkflow = WorkflowExpression.Compile(uIAToggleElementworkflow, nameof(uIAToggleElementworkflow), required: true);
            var __workflow_uIAToggleElementsearchElementName = WorkflowExpression.Compile(uIAToggleElementsearchElementName, nameof(uIAToggleElementsearchElementName), required: false);
            var __workflow_uIAToggleElementsearchElementClassName = WorkflowExpression.Compile(uIAToggleElementsearchElementClassName, nameof(uIAToggleElementsearchElementClassName), required: false);
            var __workflow_uIAToggleElementsearchElementAutomationId = WorkflowExpression.Compile(uIAToggleElementsearchElementAutomationId, nameof(uIAToggleElementsearchElementAutomationId), required: false);
            var __workflow_uIAToggleElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAToggleElementsearchLocalizedControlType, nameof(uIAToggleElementsearchLocalizedControlType), required: false);
            var __workflow_uIAToggleElementsearchSubTree = WorkflowExpression.Compile(uIAToggleElementsearchSubTree, nameof(uIAToggleElementsearchSubTree), required: false);
            var __workflow_uIAToggleElementmatchIndex = WorkflowExpression.Compile(uIAToggleElementmatchIndex, nameof(uIAToggleElementmatchIndex), required: false);
            var __workflow_uIAToggleElementsearchFilter = WorkflowExpression.Compile(uIAToggleElementsearchFilter, nameof(uIAToggleElementsearchFilter), required: false);
            var __workflow_uIAToggleElementsortByColumn = WorkflowExpression.Compile(uIAToggleElementsortByColumn, nameof(uIAToggleElementsortByColumn), required: false);
            var __workflow_uIAToggleElementmatchIndexAscending = WorkflowExpression.Compile(uIAToggleElementmatchIndexAscending, nameof(uIAToggleElementmatchIndexAscending), required: false);
            var __workflow_uIAToggleElementmaxElementsToSearch = WorkflowExpression.Compile(uIAToggleElementmaxElementsToSearch, nameof(uIAToggleElementmaxElementsToSearch), required: false);
            var __workflow_uIAToggleElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAToggleElementmaxRelativeSearchDepth, nameof(uIAToggleElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAToggleElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAToggleElementmaxChildElementsToSearchPerNode, nameof(uIAToggleElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAToggleElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAToggleElementelementLocalizedControlTypesNotToTraverse, nameof(uIAToggleElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ToggleElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAToggleElement = new JObject();
                var uIAToggleElementpropCount = 0;
                uIAToggleElementpropCount++;
                uIAToggleElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementparentWindowHandle);
                if (__workflow_uIAToggleElementsearchElementName != null)
                {
                    uIAToggleElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchElementName);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsearchElementClassName != null)
                {
                    uIAToggleElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchElementClassName);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsearchElementAutomationId != null)
                {
                    uIAToggleElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchElementAutomationId);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsearchLocalizedControlType != null)
                {
                    uIAToggleElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchLocalizedControlType);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsearchSubTree != null)
                {
                    if (__workflow_uIAToggleElementsearchSubTree != null)
                    {
                        uIAToggleElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchSubTree);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["SearchSubTree"] = true;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementmatchIndex != null)
                {
                    if (__workflow_uIAToggleElementmatchIndex != null)
                    {
                        uIAToggleElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementmatchIndex);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["MatchIndex"] = 1;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsearchFilter != null)
                {
                    uIAToggleElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsearchFilter);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementsortByColumn != null)
                {
                    uIAToggleElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementsortByColumn);
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAToggleElementmatchIndexAscending != null)
                    {
                        uIAToggleElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementmatchIndexAscending);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["MatchIndexAscending"] = true;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAToggleElementmaxElementsToSearch != null)
                    {
                        uIAToggleElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementmaxElementsToSearch);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["MaxElementsToSearch"] = 0;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAToggleElementmaxRelativeSearchDepth != null)
                    {
                        uIAToggleElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementmaxRelativeSearchDepth);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["MaxRelativeSearchDepth"] = 0;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAToggleElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAToggleElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementmaxChildElementsToSearchPerNode);
                        uIAToggleElementpropCount++;
                    }

                    uIAToggleElementpropCount++;
                }
                else
                {
                    uIAToggleElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAToggleElementpropCount++;
                }

                if (__workflow_uIAToggleElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAToggleElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementelementLocalizedControlTypesNotToTraverse);
                    uIAToggleElementpropCount++;
                }

                uIAToggleElementpropCount++;
                uIAToggleElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAToggleElementworkflow);
                if (uIAToggleElementpropCount > 0)
                {
                    callPayload.Body = uIAToggleElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACheckElement(Expression<Func<int>> uIACheckElementparentWindowHandle, Expression<Func<string>> uIACheckElementworkflow, Expression<Func<string>> uIACheckElementsearchElementName = null, Expression<Func<string>> uIACheckElementsearchElementClassName = null, Expression<Func<string>> uIACheckElementsearchElementAutomationId = null, Expression<Func<string>> uIACheckElementsearchLocalizedControlType = null, Expression<Func<bool>> uIACheckElementsearchSubTree = null, Expression<Func<bool>> uIACheckElementcheckElement = null, Expression<Func<int>> uIACheckElementmatchIndex = null, Expression<Func<string>> uIACheckElementsearchFilter = null, Expression<Func<string>> uIACheckElementsortByColumn = null, Expression<Func<bool>> uIACheckElementmatchIndexAscending = null, Expression<Func<int>> uIACheckElementmaxElementsToSearch = null, Expression<Func<int>> uIACheckElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIACheckElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACheckElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIACheckElementparentWindowHandle = WorkflowExpression.Compile(uIACheckElementparentWindowHandle, nameof(uIACheckElementparentWindowHandle), required: true);
            var __workflow_uIACheckElementworkflow = WorkflowExpression.Compile(uIACheckElementworkflow, nameof(uIACheckElementworkflow), required: true);
            var __workflow_uIACheckElementsearchElementName = WorkflowExpression.Compile(uIACheckElementsearchElementName, nameof(uIACheckElementsearchElementName), required: false);
            var __workflow_uIACheckElementsearchElementClassName = WorkflowExpression.Compile(uIACheckElementsearchElementClassName, nameof(uIACheckElementsearchElementClassName), required: false);
            var __workflow_uIACheckElementsearchElementAutomationId = WorkflowExpression.Compile(uIACheckElementsearchElementAutomationId, nameof(uIACheckElementsearchElementAutomationId), required: false);
            var __workflow_uIACheckElementsearchLocalizedControlType = WorkflowExpression.Compile(uIACheckElementsearchLocalizedControlType, nameof(uIACheckElementsearchLocalizedControlType), required: false);
            var __workflow_uIACheckElementsearchSubTree = WorkflowExpression.Compile(uIACheckElementsearchSubTree, nameof(uIACheckElementsearchSubTree), required: false);
            var __workflow_uIACheckElementcheckElement = WorkflowExpression.Compile(uIACheckElementcheckElement, nameof(uIACheckElementcheckElement), required: false);
            var __workflow_uIACheckElementmatchIndex = WorkflowExpression.Compile(uIACheckElementmatchIndex, nameof(uIACheckElementmatchIndex), required: false);
            var __workflow_uIACheckElementsearchFilter = WorkflowExpression.Compile(uIACheckElementsearchFilter, nameof(uIACheckElementsearchFilter), required: false);
            var __workflow_uIACheckElementsortByColumn = WorkflowExpression.Compile(uIACheckElementsortByColumn, nameof(uIACheckElementsortByColumn), required: false);
            var __workflow_uIACheckElementmatchIndexAscending = WorkflowExpression.Compile(uIACheckElementmatchIndexAscending, nameof(uIACheckElementmatchIndexAscending), required: false);
            var __workflow_uIACheckElementmaxElementsToSearch = WorkflowExpression.Compile(uIACheckElementmaxElementsToSearch, nameof(uIACheckElementmaxElementsToSearch), required: false);
            var __workflow_uIACheckElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIACheckElementmaxRelativeSearchDepth, nameof(uIACheckElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIACheckElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIACheckElementmaxChildElementsToSearchPerNode, nameof(uIACheckElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIACheckElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIACheckElementelementLocalizedControlTypesNotToTraverse, nameof(uIACheckElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CheckElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACheckElement = new JObject();
                var uIACheckElementpropCount = 0;
                uIACheckElementpropCount++;
                uIACheckElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementparentWindowHandle);
                if (__workflow_uIACheckElementsearchElementName != null)
                {
                    uIACheckElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchElementName);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsearchElementClassName != null)
                {
                    uIACheckElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchElementClassName);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsearchElementAutomationId != null)
                {
                    uIACheckElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchElementAutomationId);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsearchLocalizedControlType != null)
                {
                    uIACheckElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchLocalizedControlType);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsearchSubTree != null)
                {
                    if (__workflow_uIACheckElementsearchSubTree != null)
                    {
                        uIACheckElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchSubTree);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["SearchSubTree"] = true;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementcheckElement != null)
                {
                    if (__workflow_uIACheckElementcheckElement != null)
                    {
                        uIACheckElement["CheckElement"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementcheckElement);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["CheckElement"] = true;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementmatchIndex != null)
                {
                    if (__workflow_uIACheckElementmatchIndex != null)
                    {
                        uIACheckElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementmatchIndex);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["MatchIndex"] = 1;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsearchFilter != null)
                {
                    uIACheckElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsearchFilter);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementsortByColumn != null)
                {
                    uIACheckElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementsortByColumn);
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementmatchIndexAscending != null)
                {
                    if (__workflow_uIACheckElementmatchIndexAscending != null)
                    {
                        uIACheckElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementmatchIndexAscending);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["MatchIndexAscending"] = true;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIACheckElementmaxElementsToSearch != null)
                    {
                        uIACheckElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementmaxElementsToSearch);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["MaxElementsToSearch"] = 0;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIACheckElementmaxRelativeSearchDepth != null)
                    {
                        uIACheckElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementmaxRelativeSearchDepth);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["MaxRelativeSearchDepth"] = 0;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIACheckElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIACheckElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementmaxChildElementsToSearchPerNode);
                        uIACheckElementpropCount++;
                    }

                    uIACheckElementpropCount++;
                }
                else
                {
                    uIACheckElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIACheckElementpropCount++;
                }

                if (__workflow_uIACheckElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIACheckElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementelementLocalizedControlTypesNotToTraverse);
                    uIACheckElementpropCount++;
                }

                uIACheckElementpropCount++;
                uIACheckElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIACheckElementworkflow);
                if (uIACheckElementpropCount > 0)
                {
                    callPayload.Body = uIACheckElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACheckMultipleElements(Expression<Func<string>> uIACheckMultipleElementsinputElementsJSON, Expression<Func<string>> uIACheckMultipleElementsworkflow)
        {
            var __workflow_uIACheckMultipleElementsinputElementsJSON = WorkflowExpression.Compile(uIACheckMultipleElementsinputElementsJSON, nameof(uIACheckMultipleElementsinputElementsJSON), required: true);
            var __workflow_uIACheckMultipleElementsworkflow = WorkflowExpression.Compile(uIACheckMultipleElementsworkflow, nameof(uIACheckMultipleElementsworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIACheckMultipleElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACheckMultipleElements = new JObject();
                var uIACheckMultipleElementspropCount = 0;
                uIACheckMultipleElementspropCount++;
                uIACheckMultipleElements["InputElementsJSON"] = ExpressionConverter.ConvertO(__workflow_uIACheckMultipleElementsinputElementsJSON);
                uIACheckMultipleElementspropCount++;
                uIACheckMultipleElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIACheckMultipleElementsworkflow);
                if (uIACheckMultipleElementspropCount > 0)
                {
                    callPayload.Body = uIACheckMultipleElements;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAIsElementCheckedResponse, ApiConnectionActionConfiguration> UIAIsElementChecked(Expression<Func<int>> uIAIsElementCheckedparentWindowHandle, Expression<Func<string>> uIAIsElementCheckedworkflow, Expression<Func<string>> uIAIsElementCheckedsearchElementName = null, Expression<Func<string>> uIAIsElementCheckedsearchElementClassName = null, Expression<Func<string>> uIAIsElementCheckedsearchElementAutomationId = null, Expression<Func<string>> uIAIsElementCheckedsearchLocalizedControlType = null, Expression<Func<bool>> uIAIsElementCheckedsearchSubTree = null, Expression<Func<int>> uIAIsElementCheckedmatchIndex = null, Expression<Func<string>> uIAIsElementCheckedsearchFilter = null, Expression<Func<string>> uIAIsElementCheckedsortByColumn = null, Expression<Func<bool>> uIAIsElementCheckedmatchIndexAscending = null, Expression<Func<int>> uIAIsElementCheckedmaxElementsToSearch = null, Expression<Func<int>> uIAIsElementCheckedmaxRelativeSearchDepth = null, Expression<Func<int>> uIAIsElementCheckedmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAIsElementCheckedparentWindowHandle = WorkflowExpression.Compile(uIAIsElementCheckedparentWindowHandle, nameof(uIAIsElementCheckedparentWindowHandle), required: true);
            var __workflow_uIAIsElementCheckedworkflow = WorkflowExpression.Compile(uIAIsElementCheckedworkflow, nameof(uIAIsElementCheckedworkflow), required: true);
            var __workflow_uIAIsElementCheckedsearchElementName = WorkflowExpression.Compile(uIAIsElementCheckedsearchElementName, nameof(uIAIsElementCheckedsearchElementName), required: false);
            var __workflow_uIAIsElementCheckedsearchElementClassName = WorkflowExpression.Compile(uIAIsElementCheckedsearchElementClassName, nameof(uIAIsElementCheckedsearchElementClassName), required: false);
            var __workflow_uIAIsElementCheckedsearchElementAutomationId = WorkflowExpression.Compile(uIAIsElementCheckedsearchElementAutomationId, nameof(uIAIsElementCheckedsearchElementAutomationId), required: false);
            var __workflow_uIAIsElementCheckedsearchLocalizedControlType = WorkflowExpression.Compile(uIAIsElementCheckedsearchLocalizedControlType, nameof(uIAIsElementCheckedsearchLocalizedControlType), required: false);
            var __workflow_uIAIsElementCheckedsearchSubTree = WorkflowExpression.Compile(uIAIsElementCheckedsearchSubTree, nameof(uIAIsElementCheckedsearchSubTree), required: false);
            var __workflow_uIAIsElementCheckedmatchIndex = WorkflowExpression.Compile(uIAIsElementCheckedmatchIndex, nameof(uIAIsElementCheckedmatchIndex), required: false);
            var __workflow_uIAIsElementCheckedsearchFilter = WorkflowExpression.Compile(uIAIsElementCheckedsearchFilter, nameof(uIAIsElementCheckedsearchFilter), required: false);
            var __workflow_uIAIsElementCheckedsortByColumn = WorkflowExpression.Compile(uIAIsElementCheckedsortByColumn, nameof(uIAIsElementCheckedsortByColumn), required: false);
            var __workflow_uIAIsElementCheckedmatchIndexAscending = WorkflowExpression.Compile(uIAIsElementCheckedmatchIndexAscending, nameof(uIAIsElementCheckedmatchIndexAscending), required: false);
            var __workflow_uIAIsElementCheckedmaxElementsToSearch = WorkflowExpression.Compile(uIAIsElementCheckedmaxElementsToSearch, nameof(uIAIsElementCheckedmaxElementsToSearch), required: false);
            var __workflow_uIAIsElementCheckedmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAIsElementCheckedmaxRelativeSearchDepth, nameof(uIAIsElementCheckedmaxRelativeSearchDepth), required: false);
            var __workflow_uIAIsElementCheckedmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAIsElementCheckedmaxChildElementsToSearchPerNode, nameof(uIAIsElementCheckedmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse, nameof(uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAIsElementCheckedResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAIsElementChecked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAIsElementChecked = new JObject();
                var uIAIsElementCheckedpropCount = 0;
                uIAIsElementCheckedpropCount++;
                uIAIsElementChecked["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedparentWindowHandle);
                if (__workflow_uIAIsElementCheckedsearchElementName != null)
                {
                    uIAIsElementChecked["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchElementName);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsearchElementClassName != null)
                {
                    uIAIsElementChecked["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchElementClassName);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsearchElementAutomationId != null)
                {
                    uIAIsElementChecked["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchElementAutomationId);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsearchLocalizedControlType != null)
                {
                    uIAIsElementChecked["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchLocalizedControlType);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsearchSubTree != null)
                {
                    if (__workflow_uIAIsElementCheckedsearchSubTree != null)
                    {
                        uIAIsElementChecked["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchSubTree);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["SearchSubTree"] = true;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedmatchIndex != null)
                {
                    if (__workflow_uIAIsElementCheckedmatchIndex != null)
                    {
                        uIAIsElementChecked["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedmatchIndex);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["MatchIndex"] = 1;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsearchFilter != null)
                {
                    uIAIsElementChecked["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsearchFilter);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedsortByColumn != null)
                {
                    uIAIsElementChecked["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedsortByColumn);
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedmatchIndexAscending != null)
                {
                    if (__workflow_uIAIsElementCheckedmatchIndexAscending != null)
                    {
                        uIAIsElementChecked["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedmatchIndexAscending);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["MatchIndexAscending"] = true;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedmaxElementsToSearch != null)
                {
                    if (__workflow_uIAIsElementCheckedmaxElementsToSearch != null)
                    {
                        uIAIsElementChecked["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedmaxElementsToSearch);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["MaxElementsToSearch"] = 0;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAIsElementCheckedmaxRelativeSearchDepth != null)
                    {
                        uIAIsElementChecked["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedmaxRelativeSearchDepth);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["MaxRelativeSearchDepth"] = 0;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAIsElementCheckedmaxChildElementsToSearchPerNode != null)
                    {
                        uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedmaxChildElementsToSearchPerNode);
                        uIAIsElementCheckedpropCount++;
                    }

                    uIAIsElementCheckedpropCount++;
                }
                else
                {
                    uIAIsElementChecked["MaxChildElementsToSearchPerNode"] = 0;
                    uIAIsElementCheckedpropCount++;
                }

                if (__workflow_uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAIsElementChecked["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedelementLocalizedControlTypesNotToTraverse);
                    uIAIsElementCheckedpropCount++;
                }

                uIAIsElementCheckedpropCount++;
                uIAIsElementChecked["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAIsElementCheckedworkflow);
                if (uIAIsElementCheckedpropCount > 0)
                {
                    callPayload.Body = uIAIsElementChecked;
                }

                return new ApiConnectionAction<UIAIsElementCheckedResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACloseElementWindow(Expression<Func<int>> uIACloseElementWindowparentWindowHandle, Expression<Func<string>> uIACloseElementWindowworkflow, Expression<Func<string>> uIACloseElementWindowsearchElementName = null, Expression<Func<string>> uIACloseElementWindowsearchElementClassName = null, Expression<Func<string>> uIACloseElementWindowsearchElementAutomationId = null, Expression<Func<string>> uIACloseElementWindowsearchLocalizedControlType = null, Expression<Func<bool>> uIACloseElementWindowsearchSubTree = null, Expression<Func<int>> uIACloseElementWindowmatchIndex = null, Expression<Func<string>> uIACloseElementWindowsearchFilter = null, Expression<Func<string>> uIACloseElementWindowsortByColumn = null, Expression<Func<bool>> uIACloseElementWindowmatchIndexAscending = null, Expression<Func<int>> uIACloseElementWindowmaxElementsToSearch = null, Expression<Func<int>> uIACloseElementWindowmaxRelativeSearchDepth = null, Expression<Func<int>> uIACloseElementWindowmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACloseElementWindowelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIACloseElementWindowparentWindowHandle = WorkflowExpression.Compile(uIACloseElementWindowparentWindowHandle, nameof(uIACloseElementWindowparentWindowHandle), required: true);
            var __workflow_uIACloseElementWindowworkflow = WorkflowExpression.Compile(uIACloseElementWindowworkflow, nameof(uIACloseElementWindowworkflow), required: true);
            var __workflow_uIACloseElementWindowsearchElementName = WorkflowExpression.Compile(uIACloseElementWindowsearchElementName, nameof(uIACloseElementWindowsearchElementName), required: false);
            var __workflow_uIACloseElementWindowsearchElementClassName = WorkflowExpression.Compile(uIACloseElementWindowsearchElementClassName, nameof(uIACloseElementWindowsearchElementClassName), required: false);
            var __workflow_uIACloseElementWindowsearchElementAutomationId = WorkflowExpression.Compile(uIACloseElementWindowsearchElementAutomationId, nameof(uIACloseElementWindowsearchElementAutomationId), required: false);
            var __workflow_uIACloseElementWindowsearchLocalizedControlType = WorkflowExpression.Compile(uIACloseElementWindowsearchLocalizedControlType, nameof(uIACloseElementWindowsearchLocalizedControlType), required: false);
            var __workflow_uIACloseElementWindowsearchSubTree = WorkflowExpression.Compile(uIACloseElementWindowsearchSubTree, nameof(uIACloseElementWindowsearchSubTree), required: false);
            var __workflow_uIACloseElementWindowmatchIndex = WorkflowExpression.Compile(uIACloseElementWindowmatchIndex, nameof(uIACloseElementWindowmatchIndex), required: false);
            var __workflow_uIACloseElementWindowsearchFilter = WorkflowExpression.Compile(uIACloseElementWindowsearchFilter, nameof(uIACloseElementWindowsearchFilter), required: false);
            var __workflow_uIACloseElementWindowsortByColumn = WorkflowExpression.Compile(uIACloseElementWindowsortByColumn, nameof(uIACloseElementWindowsortByColumn), required: false);
            var __workflow_uIACloseElementWindowmatchIndexAscending = WorkflowExpression.Compile(uIACloseElementWindowmatchIndexAscending, nameof(uIACloseElementWindowmatchIndexAscending), required: false);
            var __workflow_uIACloseElementWindowmaxElementsToSearch = WorkflowExpression.Compile(uIACloseElementWindowmaxElementsToSearch, nameof(uIACloseElementWindowmaxElementsToSearch), required: false);
            var __workflow_uIACloseElementWindowmaxRelativeSearchDepth = WorkflowExpression.Compile(uIACloseElementWindowmaxRelativeSearchDepth, nameof(uIACloseElementWindowmaxRelativeSearchDepth), required: false);
            var __workflow_uIACloseElementWindowmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIACloseElementWindowmaxChildElementsToSearchPerNode, nameof(uIACloseElementWindowmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIACloseElementWindowelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIACloseElementWindowelementLocalizedControlTypesNotToTraverse, nameof(uIACloseElementWindowelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CloseElementWindow";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACloseElementWindow = new JObject();
                var uIACloseElementWindowpropCount = 0;
                uIACloseElementWindowpropCount++;
                uIACloseElementWindow["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowparentWindowHandle);
                if (__workflow_uIACloseElementWindowsearchElementName != null)
                {
                    uIACloseElementWindow["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchElementName);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsearchElementClassName != null)
                {
                    uIACloseElementWindow["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchElementClassName);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsearchElementAutomationId != null)
                {
                    uIACloseElementWindow["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchElementAutomationId);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsearchLocalizedControlType != null)
                {
                    uIACloseElementWindow["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchLocalizedControlType);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsearchSubTree != null)
                {
                    if (__workflow_uIACloseElementWindowsearchSubTree != null)
                    {
                        uIACloseElementWindow["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchSubTree);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["SearchSubTree"] = true;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowmatchIndex != null)
                {
                    if (__workflow_uIACloseElementWindowmatchIndex != null)
                    {
                        uIACloseElementWindow["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowmatchIndex);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["MatchIndex"] = 1;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsearchFilter != null)
                {
                    uIACloseElementWindow["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsearchFilter);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowsortByColumn != null)
                {
                    uIACloseElementWindow["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowsortByColumn);
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowmatchIndexAscending != null)
                {
                    if (__workflow_uIACloseElementWindowmatchIndexAscending != null)
                    {
                        uIACloseElementWindow["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowmatchIndexAscending);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["MatchIndexAscending"] = true;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowmaxElementsToSearch != null)
                {
                    if (__workflow_uIACloseElementWindowmaxElementsToSearch != null)
                    {
                        uIACloseElementWindow["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowmaxElementsToSearch);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["MaxElementsToSearch"] = 0;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIACloseElementWindowmaxRelativeSearchDepth != null)
                    {
                        uIACloseElementWindow["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowmaxRelativeSearchDepth);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["MaxRelativeSearchDepth"] = 0;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIACloseElementWindowmaxChildElementsToSearchPerNode != null)
                    {
                        uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowmaxChildElementsToSearchPerNode);
                        uIACloseElementWindowpropCount++;
                    }

                    uIACloseElementWindowpropCount++;
                }
                else
                {
                    uIACloseElementWindow["MaxChildElementsToSearchPerNode"] = 0;
                    uIACloseElementWindowpropCount++;
                }

                if (__workflow_uIACloseElementWindowelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIACloseElementWindow["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowelementLocalizedControlTypesNotToTraverse);
                    uIACloseElementWindowpropCount++;
                }

                uIACloseElementWindowpropCount++;
                uIACloseElementWindow["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIACloseElementWindowworkflow);
                if (uIACloseElementWindowpropCount > 0)
                {
                    callPayload.Body = uIACloseElementWindow;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementTextValueResponse, ApiConnectionActionConfiguration> UIAGetElementTextValue(Expression<Func<int>> uIAGetElementTextValueparentWindowHandle, Expression<Func<string>> uIAGetElementTextValueworkflow, Expression<Func<string>> uIAGetElementTextValuesearchElementName = null, Expression<Func<string>> uIAGetElementTextValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementTextValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementTextValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementTextValuesearchSubTree = null, Expression<Func<int>> uIAGetElementTextValuematchIndex = null, Expression<Func<string>> uIAGetElementTextValuesearchFilter = null, Expression<Func<string>> uIAGetElementTextValuesortByColumn = null, Expression<Func<bool>> uIAGetElementTextValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementTextValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementTextValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementTextValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetElementTextValueparentWindowHandle = WorkflowExpression.Compile(uIAGetElementTextValueparentWindowHandle, nameof(uIAGetElementTextValueparentWindowHandle), required: true);
            var __workflow_uIAGetElementTextValueworkflow = WorkflowExpression.Compile(uIAGetElementTextValueworkflow, nameof(uIAGetElementTextValueworkflow), required: true);
            var __workflow_uIAGetElementTextValuesearchElementName = WorkflowExpression.Compile(uIAGetElementTextValuesearchElementName, nameof(uIAGetElementTextValuesearchElementName), required: false);
            var __workflow_uIAGetElementTextValuesearchElementClassName = WorkflowExpression.Compile(uIAGetElementTextValuesearchElementClassName, nameof(uIAGetElementTextValuesearchElementClassName), required: false);
            var __workflow_uIAGetElementTextValuesearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementTextValuesearchElementAutomationId, nameof(uIAGetElementTextValuesearchElementAutomationId), required: false);
            var __workflow_uIAGetElementTextValuesearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementTextValuesearchLocalizedControlType, nameof(uIAGetElementTextValuesearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementTextValuesearchSubTree = WorkflowExpression.Compile(uIAGetElementTextValuesearchSubTree, nameof(uIAGetElementTextValuesearchSubTree), required: false);
            var __workflow_uIAGetElementTextValuematchIndex = WorkflowExpression.Compile(uIAGetElementTextValuematchIndex, nameof(uIAGetElementTextValuematchIndex), required: false);
            var __workflow_uIAGetElementTextValuesearchFilter = WorkflowExpression.Compile(uIAGetElementTextValuesearchFilter, nameof(uIAGetElementTextValuesearchFilter), required: false);
            var __workflow_uIAGetElementTextValuesortByColumn = WorkflowExpression.Compile(uIAGetElementTextValuesortByColumn, nameof(uIAGetElementTextValuesortByColumn), required: false);
            var __workflow_uIAGetElementTextValuematchIndexAscending = WorkflowExpression.Compile(uIAGetElementTextValuematchIndexAscending, nameof(uIAGetElementTextValuematchIndexAscending), required: false);
            var __workflow_uIAGetElementTextValuemaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementTextValuemaxElementsToSearch, nameof(uIAGetElementTextValuemaxElementsToSearch), required: false);
            var __workflow_uIAGetElementTextValuemaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementTextValuemaxRelativeSearchDepth, nameof(uIAGetElementTextValuemaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementTextValuemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementTextValuemaxChildElementsToSearchPerNode, nameof(uIAGetElementTextValuemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetElementTextValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementTextValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementTextValue = new JObject();
                var uIAGetElementTextValuepropCount = 0;
                uIAGetElementTextValuepropCount++;
                uIAGetElementTextValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValueparentWindowHandle);
                if (__workflow_uIAGetElementTextValuesearchElementName != null)
                {
                    uIAGetElementTextValue["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchElementName);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesearchElementClassName != null)
                {
                    uIAGetElementTextValue["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchElementClassName);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesearchElementAutomationId != null)
                {
                    uIAGetElementTextValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchElementAutomationId);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesearchLocalizedControlType != null)
                {
                    uIAGetElementTextValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchLocalizedControlType);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesearchSubTree != null)
                {
                    if (__workflow_uIAGetElementTextValuesearchSubTree != null)
                    {
                        uIAGetElementTextValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchSubTree);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["SearchSubTree"] = true;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuematchIndex != null)
                {
                    if (__workflow_uIAGetElementTextValuematchIndex != null)
                    {
                        uIAGetElementTextValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuematchIndex);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["MatchIndex"] = 1;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesearchFilter != null)
                {
                    uIAGetElementTextValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesearchFilter);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuesortByColumn != null)
                {
                    uIAGetElementTextValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuesortByColumn);
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuematchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementTextValuematchIndexAscending != null)
                    {
                        uIAGetElementTextValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuematchIndexAscending);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["MatchIndexAscending"] = true;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuemaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementTextValuemaxElementsToSearch != null)
                    {
                        uIAGetElementTextValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuemaxElementsToSearch);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["MaxElementsToSearch"] = 0;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementTextValuemaxRelativeSearchDepth != null)
                    {
                        uIAGetElementTextValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuemaxRelativeSearchDepth);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValuemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementTextValuemaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValuemaxChildElementsToSearchPerNode);
                        uIAGetElementTextValuepropCount++;
                    }

                    uIAGetElementTextValuepropCount++;
                }
                else
                {
                    uIAGetElementTextValue["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementTextValuepropCount++;
                }

                if (__workflow_uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementTextValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementTextValuepropCount++;
                }

                uIAGetElementTextValuepropCount++;
                uIAGetElementTextValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementTextValueworkflow);
                if (uIAGetElementTextValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementTextValue;
                }

                return new ApiConnectionAction<UIAGetElementTextValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementValueResponse, ApiConnectionActionConfiguration> UIAGetElementValue(Expression<Func<int>> uIAGetElementValueparentWindowHandle, Expression<Func<string>> uIAGetElementValueworkflow, Expression<Func<string>> uIAGetElementValuesearchElementName = null, Expression<Func<string>> uIAGetElementValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementValuesearchSubTree = null, Expression<Func<int>> uIAGetElementValuematchIndex = null, Expression<Func<string>> uIAGetElementValuesearchFilter = null, Expression<Func<string>> uIAGetElementValuesortByColumn = null, Expression<Func<bool>> uIAGetElementValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetElementValueparentWindowHandle = WorkflowExpression.Compile(uIAGetElementValueparentWindowHandle, nameof(uIAGetElementValueparentWindowHandle), required: true);
            var __workflow_uIAGetElementValueworkflow = WorkflowExpression.Compile(uIAGetElementValueworkflow, nameof(uIAGetElementValueworkflow), required: true);
            var __workflow_uIAGetElementValuesearchElementName = WorkflowExpression.Compile(uIAGetElementValuesearchElementName, nameof(uIAGetElementValuesearchElementName), required: false);
            var __workflow_uIAGetElementValuesearchElementClassName = WorkflowExpression.Compile(uIAGetElementValuesearchElementClassName, nameof(uIAGetElementValuesearchElementClassName), required: false);
            var __workflow_uIAGetElementValuesearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementValuesearchElementAutomationId, nameof(uIAGetElementValuesearchElementAutomationId), required: false);
            var __workflow_uIAGetElementValuesearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementValuesearchLocalizedControlType, nameof(uIAGetElementValuesearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementValuesearchSubTree = WorkflowExpression.Compile(uIAGetElementValuesearchSubTree, nameof(uIAGetElementValuesearchSubTree), required: false);
            var __workflow_uIAGetElementValuematchIndex = WorkflowExpression.Compile(uIAGetElementValuematchIndex, nameof(uIAGetElementValuematchIndex), required: false);
            var __workflow_uIAGetElementValuesearchFilter = WorkflowExpression.Compile(uIAGetElementValuesearchFilter, nameof(uIAGetElementValuesearchFilter), required: false);
            var __workflow_uIAGetElementValuesortByColumn = WorkflowExpression.Compile(uIAGetElementValuesortByColumn, nameof(uIAGetElementValuesortByColumn), required: false);
            var __workflow_uIAGetElementValuematchIndexAscending = WorkflowExpression.Compile(uIAGetElementValuematchIndexAscending, nameof(uIAGetElementValuematchIndexAscending), required: false);
            var __workflow_uIAGetElementValuemaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementValuemaxElementsToSearch, nameof(uIAGetElementValuemaxElementsToSearch), required: false);
            var __workflow_uIAGetElementValuemaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementValuemaxRelativeSearchDepth, nameof(uIAGetElementValuemaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementValuemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementValuemaxChildElementsToSearchPerNode, nameof(uIAGetElementValuemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementValueelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementValueelementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementValueelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetElementValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementValue = new JObject();
                var uIAGetElementValuepropCount = 0;
                uIAGetElementValuepropCount++;
                uIAGetElementValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValueparentWindowHandle);
                if (__workflow_uIAGetElementValuesearchElementName != null)
                {
                    uIAGetElementValue["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchElementName);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesearchElementClassName != null)
                {
                    uIAGetElementValue["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchElementClassName);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesearchElementAutomationId != null)
                {
                    uIAGetElementValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchElementAutomationId);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesearchLocalizedControlType != null)
                {
                    uIAGetElementValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchLocalizedControlType);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesearchSubTree != null)
                {
                    if (__workflow_uIAGetElementValuesearchSubTree != null)
                    {
                        uIAGetElementValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchSubTree);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["SearchSubTree"] = true;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuematchIndex != null)
                {
                    if (__workflow_uIAGetElementValuematchIndex != null)
                    {
                        uIAGetElementValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuematchIndex);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["MatchIndex"] = 1;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesearchFilter != null)
                {
                    uIAGetElementValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesearchFilter);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuesortByColumn != null)
                {
                    uIAGetElementValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuesortByColumn);
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuematchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementValuematchIndexAscending != null)
                    {
                        uIAGetElementValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuematchIndexAscending);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["MatchIndexAscending"] = true;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuemaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementValuemaxElementsToSearch != null)
                    {
                        uIAGetElementValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuemaxElementsToSearch);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["MaxElementsToSearch"] = 0;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementValuemaxRelativeSearchDepth != null)
                    {
                        uIAGetElementValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuemaxRelativeSearchDepth);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValuemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementValuemaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValuemaxChildElementsToSearchPerNode);
                        uIAGetElementValuepropCount++;
                    }

                    uIAGetElementValuepropCount++;
                }
                else
                {
                    uIAGetElementValue["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementValuepropCount++;
                }

                if (__workflow_uIAGetElementValueelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementValuepropCount++;
                }

                uIAGetElementValuepropCount++;
                uIAGetElementValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementValueworkflow);
                if (uIAGetElementValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementValue;
                }

                return new ApiConnectionAction<UIAGetElementValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementLabelValueResponse, ApiConnectionActionConfiguration> UIAGetElementLabelValue(Expression<Func<int>> uIAGetElementLabelValueparentWindowHandle, Expression<Func<string>> uIAGetElementLabelValueworkflow, Expression<Func<string>> uIAGetElementLabelValuesearchElementName = null, Expression<Func<string>> uIAGetElementLabelValuesearchElementClassName = null, Expression<Func<string>> uIAGetElementLabelValuesearchElementAutomationId = null, Expression<Func<string>> uIAGetElementLabelValuesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementLabelValuesearchSubTree = null, Expression<Func<int>> uIAGetElementLabelValuematchIndex = null, Expression<Func<string>> uIAGetElementLabelValuesearchFilter = null, Expression<Func<string>> uIAGetElementLabelValuesortByColumn = null, Expression<Func<bool>> uIAGetElementLabelValuematchIndexAscending = null, Expression<Func<int>> uIAGetElementLabelValuemaxElementsToSearch = null, Expression<Func<int>> uIAGetElementLabelValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementLabelValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetElementLabelValueparentWindowHandle = WorkflowExpression.Compile(uIAGetElementLabelValueparentWindowHandle, nameof(uIAGetElementLabelValueparentWindowHandle), required: true);
            var __workflow_uIAGetElementLabelValueworkflow = WorkflowExpression.Compile(uIAGetElementLabelValueworkflow, nameof(uIAGetElementLabelValueworkflow), required: true);
            var __workflow_uIAGetElementLabelValuesearchElementName = WorkflowExpression.Compile(uIAGetElementLabelValuesearchElementName, nameof(uIAGetElementLabelValuesearchElementName), required: false);
            var __workflow_uIAGetElementLabelValuesearchElementClassName = WorkflowExpression.Compile(uIAGetElementLabelValuesearchElementClassName, nameof(uIAGetElementLabelValuesearchElementClassName), required: false);
            var __workflow_uIAGetElementLabelValuesearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementLabelValuesearchElementAutomationId, nameof(uIAGetElementLabelValuesearchElementAutomationId), required: false);
            var __workflow_uIAGetElementLabelValuesearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementLabelValuesearchLocalizedControlType, nameof(uIAGetElementLabelValuesearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementLabelValuesearchSubTree = WorkflowExpression.Compile(uIAGetElementLabelValuesearchSubTree, nameof(uIAGetElementLabelValuesearchSubTree), required: false);
            var __workflow_uIAGetElementLabelValuematchIndex = WorkflowExpression.Compile(uIAGetElementLabelValuematchIndex, nameof(uIAGetElementLabelValuematchIndex), required: false);
            var __workflow_uIAGetElementLabelValuesearchFilter = WorkflowExpression.Compile(uIAGetElementLabelValuesearchFilter, nameof(uIAGetElementLabelValuesearchFilter), required: false);
            var __workflow_uIAGetElementLabelValuesortByColumn = WorkflowExpression.Compile(uIAGetElementLabelValuesortByColumn, nameof(uIAGetElementLabelValuesortByColumn), required: false);
            var __workflow_uIAGetElementLabelValuematchIndexAscending = WorkflowExpression.Compile(uIAGetElementLabelValuematchIndexAscending, nameof(uIAGetElementLabelValuematchIndexAscending), required: false);
            var __workflow_uIAGetElementLabelValuemaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementLabelValuemaxElementsToSearch, nameof(uIAGetElementLabelValuemaxElementsToSearch), required: false);
            var __workflow_uIAGetElementLabelValuemaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementLabelValuemaxRelativeSearchDepth, nameof(uIAGetElementLabelValuemaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementLabelValuemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementLabelValuemaxChildElementsToSearchPerNode, nameof(uIAGetElementLabelValuemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetElementLabelValueResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementLabelValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementLabelValue = new JObject();
                var uIAGetElementLabelValuepropCount = 0;
                uIAGetElementLabelValuepropCount++;
                uIAGetElementLabelValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValueparentWindowHandle);
                if (__workflow_uIAGetElementLabelValuesearchElementName != null)
                {
                    uIAGetElementLabelValue["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchElementName);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesearchElementClassName != null)
                {
                    uIAGetElementLabelValue["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchElementClassName);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesearchElementAutomationId != null)
                {
                    uIAGetElementLabelValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchElementAutomationId);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesearchLocalizedControlType != null)
                {
                    uIAGetElementLabelValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchLocalizedControlType);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesearchSubTree != null)
                {
                    if (__workflow_uIAGetElementLabelValuesearchSubTree != null)
                    {
                        uIAGetElementLabelValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchSubTree);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["SearchSubTree"] = true;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuematchIndex != null)
                {
                    if (__workflow_uIAGetElementLabelValuematchIndex != null)
                    {
                        uIAGetElementLabelValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuematchIndex);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["MatchIndex"] = 1;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesearchFilter != null)
                {
                    uIAGetElementLabelValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesearchFilter);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuesortByColumn != null)
                {
                    uIAGetElementLabelValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuesortByColumn);
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuematchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementLabelValuematchIndexAscending != null)
                    {
                        uIAGetElementLabelValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuematchIndexAscending);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["MatchIndexAscending"] = true;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuemaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementLabelValuemaxElementsToSearch != null)
                    {
                        uIAGetElementLabelValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuemaxElementsToSearch);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["MaxElementsToSearch"] = 0;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementLabelValuemaxRelativeSearchDepth != null)
                    {
                        uIAGetElementLabelValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuemaxRelativeSearchDepth);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValuemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementLabelValuemaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValuemaxChildElementsToSearchPerNode);
                        uIAGetElementLabelValuepropCount++;
                    }

                    uIAGetElementLabelValuepropCount++;
                }
                else
                {
                    uIAGetElementLabelValue["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementLabelValuepropCount++;
                }

                if (__workflow_uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementLabelValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValueelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementLabelValuepropCount++;
                }

                uIAGetElementLabelValuepropCount++;
                uIAGetElementLabelValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementLabelValueworkflow);
                if (uIAGetElementLabelValuepropCount > 0)
                {
                    callPayload.Body = uIAGetElementLabelValue;
                }

                return new ApiConnectionAction<UIAGetElementLabelValueResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetElementProperties(Expression<Func<int>> uIAGetElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetElementPropertiesworkflow, Expression<Func<string>> uIAGetElementPropertiessearchElementName = null, Expression<Func<string>> uIAGetElementPropertiessearchElementClassName = null, Expression<Func<string>> uIAGetElementPropertiessearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPropertiessearchSubTree = null, Expression<Func<bool>> uIAGetElementPropertiesreturnElementHandle = null, Expression<Func<bool>> uIAGetElementPropertiesreturnElementValue = null, Expression<Func<int>> uIAGetElementPropertiesmatchIndex = null, Expression<Func<string>> uIAGetElementPropertiessearchFilter = null, Expression<Func<string>> uIAGetElementPropertiessortByColumn = null, Expression<Func<bool>> uIAGetElementPropertiesmatchIndexAscending = null, Expression<Func<int>> uIAGetElementPropertiesmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPropertiesmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPropertiesmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGetElementPropertiesparentWindowHandle = WorkflowExpression.Compile(uIAGetElementPropertiesparentWindowHandle, nameof(uIAGetElementPropertiesparentWindowHandle), required: true);
            var __workflow_uIAGetElementPropertiesworkflow = WorkflowExpression.Compile(uIAGetElementPropertiesworkflow, nameof(uIAGetElementPropertiesworkflow), required: true);
            var __workflow_uIAGetElementPropertiessearchElementName = WorkflowExpression.Compile(uIAGetElementPropertiessearchElementName, nameof(uIAGetElementPropertiessearchElementName), required: false);
            var __workflow_uIAGetElementPropertiessearchElementClassName = WorkflowExpression.Compile(uIAGetElementPropertiessearchElementClassName, nameof(uIAGetElementPropertiessearchElementClassName), required: false);
            var __workflow_uIAGetElementPropertiessearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementPropertiessearchElementAutomationId, nameof(uIAGetElementPropertiessearchElementAutomationId), required: false);
            var __workflow_uIAGetElementPropertiessearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementPropertiessearchLocalizedControlType, nameof(uIAGetElementPropertiessearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementPropertiessearchSubTree = WorkflowExpression.Compile(uIAGetElementPropertiessearchSubTree, nameof(uIAGetElementPropertiessearchSubTree), required: false);
            var __workflow_uIAGetElementPropertiesreturnElementHandle = WorkflowExpression.Compile(uIAGetElementPropertiesreturnElementHandle, nameof(uIAGetElementPropertiesreturnElementHandle), required: false);
            var __workflow_uIAGetElementPropertiesreturnElementValue = WorkflowExpression.Compile(uIAGetElementPropertiesreturnElementValue, nameof(uIAGetElementPropertiesreturnElementValue), required: false);
            var __workflow_uIAGetElementPropertiesmatchIndex = WorkflowExpression.Compile(uIAGetElementPropertiesmatchIndex, nameof(uIAGetElementPropertiesmatchIndex), required: false);
            var __workflow_uIAGetElementPropertiessearchFilter = WorkflowExpression.Compile(uIAGetElementPropertiessearchFilter, nameof(uIAGetElementPropertiessearchFilter), required: false);
            var __workflow_uIAGetElementPropertiessortByColumn = WorkflowExpression.Compile(uIAGetElementPropertiessortByColumn, nameof(uIAGetElementPropertiessortByColumn), required: false);
            var __workflow_uIAGetElementPropertiesmatchIndexAscending = WorkflowExpression.Compile(uIAGetElementPropertiesmatchIndexAscending, nameof(uIAGetElementPropertiesmatchIndexAscending), required: false);
            var __workflow_uIAGetElementPropertiesmaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementPropertiesmaxElementsToSearch, nameof(uIAGetElementPropertiesmaxElementsToSearch), required: false);
            var __workflow_uIAGetElementPropertiesmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementPropertiesmaxRelativeSearchDepth, nameof(uIAGetElementPropertiesmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementPropertiesmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementPropertiesmaxChildElementsToSearchPerNode, nameof(uIAGetElementPropertiesmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary, nameof(uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredBodyAction<UIAGetElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementProperties = new JObject();
                var uIAGetElementPropertiespropCount = 0;
                uIAGetElementPropertiespropCount++;
                uIAGetElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesparentWindowHandle);
                if (__workflow_uIAGetElementPropertiessearchElementName != null)
                {
                    uIAGetElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchElementName);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessearchElementClassName != null)
                {
                    uIAGetElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchElementClassName);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessearchElementAutomationId != null)
                {
                    uIAGetElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchElementAutomationId);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessearchLocalizedControlType != null)
                {
                    uIAGetElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchLocalizedControlType);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessearchSubTree != null)
                {
                    if (__workflow_uIAGetElementPropertiessearchSubTree != null)
                    {
                        uIAGetElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchSubTree);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["SearchSubTree"] = true;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesreturnElementHandle != null)
                {
                    if (__workflow_uIAGetElementPropertiesreturnElementHandle != null)
                    {
                        uIAGetElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesreturnElementHandle);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["ReturnElementHandle"] = true;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesreturnElementValue != null)
                {
                    if (__workflow_uIAGetElementPropertiesreturnElementValue != null)
                    {
                        uIAGetElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesreturnElementValue);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["ReturnElementValue"] = false;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesmatchIndex != null)
                {
                    if (__workflow_uIAGetElementPropertiesmatchIndex != null)
                    {
                        uIAGetElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesmatchIndex);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["MatchIndex"] = 1;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessearchFilter != null)
                {
                    uIAGetElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessearchFilter);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiessortByColumn != null)
                {
                    uIAGetElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiessortByColumn);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementPropertiesmatchIndexAscending != null)
                    {
                        uIAGetElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesmatchIndexAscending);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["MatchIndexAscending"] = true;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementPropertiesmaxElementsToSearch != null)
                    {
                        uIAGetElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesmaxElementsToSearch);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["MaxElementsToSearch"] = 0;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementPropertiesmaxRelativeSearchDepth != null)
                    {
                        uIAGetElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesmaxRelativeSearchDepth);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementPropertiesmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesmaxChildElementsToSearchPerNode);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertieselementLocalizedControlTypesNotToTraverse);
                    uIAGetElementPropertiespropCount++;
                }

                if (__workflow_uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesvalidateClickablePointWithinElementBoundary);
                        uIAGetElementPropertiespropCount++;
                    }

                    uIAGetElementPropertiespropCount++;
                }
                else
                {
                    uIAGetElementProperties["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGetElementPropertiespropCount++;
                }

                uIAGetElementPropertiespropCount++;
                uIAGetElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesworkflow);
                if (uIAGetElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetElementProperties;
                }

                return new ApiConnectionAction<UIAGetElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetMultipleElementProperties(Expression<Func<int>> uIAGetMultipleElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetMultipleElementPropertiesworkflow, Expression<Func<string>> uIAGetMultipleElementPropertiessearchElementLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementPropertiessearchDescendants = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesreturnElementHandle = null, Expression<Func<bool>> uIAGetMultipleElementPropertiesreturnElementValue = null, Expression<Func<int>> uIAGetMultipleElementPropertiesfirstItemToReturn = null, Expression<Func<int>> uIAGetMultipleElementPropertiesmaxItemsToReturn = null)
        {
            var __workflow_uIAGetMultipleElementPropertiesparentWindowHandle = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesparentWindowHandle, nameof(uIAGetMultipleElementPropertiesparentWindowHandle), required: true);
            var __workflow_uIAGetMultipleElementPropertiesworkflow = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesworkflow, nameof(uIAGetMultipleElementPropertiesworkflow), required: true);
            var __workflow_uIAGetMultipleElementPropertiessearchElementLocalizedControlType = WorkflowExpression.Compile(uIAGetMultipleElementPropertiessearchElementLocalizedControlType, nameof(uIAGetMultipleElementPropertiessearchElementLocalizedControlType), required: false);
            var __workflow_uIAGetMultipleElementPropertiessearchDescendants = WorkflowExpression.Compile(uIAGetMultipleElementPropertiessearchDescendants, nameof(uIAGetMultipleElementPropertiessearchDescendants), required: false);
            var __workflow_uIAGetMultipleElementPropertiesreturnElementHandle = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesreturnElementHandle, nameof(uIAGetMultipleElementPropertiesreturnElementHandle), required: false);
            var __workflow_uIAGetMultipleElementPropertiesreturnElementValue = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesreturnElementValue, nameof(uIAGetMultipleElementPropertiesreturnElementValue), required: false);
            var __workflow_uIAGetMultipleElementPropertiesfirstItemToReturn = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesfirstItemToReturn, nameof(uIAGetMultipleElementPropertiesfirstItemToReturn), required: false);
            var __workflow_uIAGetMultipleElementPropertiesmaxItemsToReturn = WorkflowExpression.Compile(uIAGetMultipleElementPropertiesmaxItemsToReturn, nameof(uIAGetMultipleElementPropertiesmaxItemsToReturn), required: false);
            return new DeferredBodyAction<UIAGetMultipleElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetMultipleElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleElementProperties = new JObject();
                var uIAGetMultipleElementPropertiespropCount = 0;
                uIAGetMultipleElementPropertiespropCount++;
                uIAGetMultipleElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesparentWindowHandle);
                if (__workflow_uIAGetMultipleElementPropertiessearchElementLocalizedControlType != null)
                {
                    uIAGetMultipleElementProperties["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiessearchElementLocalizedControlType);
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_uIAGetMultipleElementPropertiessearchDescendants != null)
                {
                    if (__workflow_uIAGetMultipleElementPropertiessearchDescendants != null)
                    {
                        uIAGetMultipleElementProperties["SearchDescendants"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiessearchDescendants);
                        uIAGetMultipleElementPropertiespropCount++;
                    }

                    uIAGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleElementProperties["SearchDescendants"] = false;
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_uIAGetMultipleElementPropertiesreturnElementHandle != null)
                {
                    if (__workflow_uIAGetMultipleElementPropertiesreturnElementHandle != null)
                    {
                        uIAGetMultipleElementProperties["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesreturnElementHandle);
                        uIAGetMultipleElementPropertiespropCount++;
                    }

                    uIAGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleElementProperties["ReturnElementHandle"] = true;
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_uIAGetMultipleElementPropertiesreturnElementValue != null)
                {
                    if (__workflow_uIAGetMultipleElementPropertiesreturnElementValue != null)
                    {
                        uIAGetMultipleElementProperties["ReturnElementValue"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesreturnElementValue);
                        uIAGetMultipleElementPropertiespropCount++;
                    }

                    uIAGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleElementProperties["ReturnElementValue"] = false;
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_uIAGetMultipleElementPropertiesfirstItemToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementPropertiesfirstItemToReturn != null)
                    {
                        uIAGetMultipleElementProperties["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesfirstItemToReturn);
                        uIAGetMultipleElementPropertiespropCount++;
                    }

                    uIAGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleElementProperties["FirstItemToReturn"] = 1;
                    uIAGetMultipleElementPropertiespropCount++;
                }

                if (__workflow_uIAGetMultipleElementPropertiesmaxItemsToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementPropertiesmaxItemsToReturn != null)
                    {
                        uIAGetMultipleElementProperties["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesmaxItemsToReturn);
                        uIAGetMultipleElementPropertiespropCount++;
                    }

                    uIAGetMultipleElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleElementProperties["MaxItemsToReturn"] = 0;
                    uIAGetMultipleElementPropertiespropCount++;
                }

                uIAGetMultipleElementPropertiespropCount++;
                uIAGetMultipleElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementPropertiesworkflow);
                if (uIAGetMultipleElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleElementProperties;
                }

                return new ApiConnectionAction<UIAGetMultipleElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDesktopElementsResponse, ApiConnectionActionConfiguration> UIAGetDesktopElements(Expression<Func<string>> uIAGetDesktopElementsworkflow, Expression<Func<string>> uIAGetDesktopElementssearchElementLocalizedControlType = null, Expression<Func<int>> uIAGetDesktopElementssearchProcessId = null, Expression<Func<bool>> uIAGetDesktopElementsreturnElementHandle = null, Expression<Func<int>> uIAGetDesktopElementsfirstItemToReturn = null, Expression<Func<int>> uIAGetDesktopElementsmaxItemsToReturn = null, Expression<Func<bool>> uIAGetDesktopElementsincludeChildProcesses = null)
        {
            var __workflow_uIAGetDesktopElementsworkflow = WorkflowExpression.Compile(uIAGetDesktopElementsworkflow, nameof(uIAGetDesktopElementsworkflow), required: true);
            var __workflow_uIAGetDesktopElementssearchElementLocalizedControlType = WorkflowExpression.Compile(uIAGetDesktopElementssearchElementLocalizedControlType, nameof(uIAGetDesktopElementssearchElementLocalizedControlType), required: false);
            var __workflow_uIAGetDesktopElementssearchProcessId = WorkflowExpression.Compile(uIAGetDesktopElementssearchProcessId, nameof(uIAGetDesktopElementssearchProcessId), required: false);
            var __workflow_uIAGetDesktopElementsreturnElementHandle = WorkflowExpression.Compile(uIAGetDesktopElementsreturnElementHandle, nameof(uIAGetDesktopElementsreturnElementHandle), required: false);
            var __workflow_uIAGetDesktopElementsfirstItemToReturn = WorkflowExpression.Compile(uIAGetDesktopElementsfirstItemToReturn, nameof(uIAGetDesktopElementsfirstItemToReturn), required: false);
            var __workflow_uIAGetDesktopElementsmaxItemsToReturn = WorkflowExpression.Compile(uIAGetDesktopElementsmaxItemsToReturn, nameof(uIAGetDesktopElementsmaxItemsToReturn), required: false);
            var __workflow_uIAGetDesktopElementsincludeChildProcesses = WorkflowExpression.Compile(uIAGetDesktopElementsincludeChildProcesses, nameof(uIAGetDesktopElementsincludeChildProcesses), required: false);
            return new DeferredBodyAction<UIAGetDesktopElementsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDesktopElements";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDesktopElements = new JObject();
                var uIAGetDesktopElementspropCount = 0;
                if (__workflow_uIAGetDesktopElementssearchElementLocalizedControlType != null)
                {
                    uIAGetDesktopElements["SearchElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementssearchElementLocalizedControlType);
                    uIAGetDesktopElementspropCount++;
                }

                if (__workflow_uIAGetDesktopElementssearchProcessId != null)
                {
                    if (__workflow_uIAGetDesktopElementssearchProcessId != null)
                    {
                        uIAGetDesktopElements["SearchProcessID"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementssearchProcessId);
                        uIAGetDesktopElementspropCount++;
                    }

                    uIAGetDesktopElementspropCount++;
                }
                else
                {
                    uIAGetDesktopElements["SearchProcessID"] = 0;
                    uIAGetDesktopElementspropCount++;
                }

                if (__workflow_uIAGetDesktopElementsreturnElementHandle != null)
                {
                    if (__workflow_uIAGetDesktopElementsreturnElementHandle != null)
                    {
                        uIAGetDesktopElements["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementsreturnElementHandle);
                        uIAGetDesktopElementspropCount++;
                    }

                    uIAGetDesktopElementspropCount++;
                }
                else
                {
                    uIAGetDesktopElements["ReturnElementHandle"] = true;
                    uIAGetDesktopElementspropCount++;
                }

                if (__workflow_uIAGetDesktopElementsfirstItemToReturn != null)
                {
                    if (__workflow_uIAGetDesktopElementsfirstItemToReturn != null)
                    {
                        uIAGetDesktopElements["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementsfirstItemToReturn);
                        uIAGetDesktopElementspropCount++;
                    }

                    uIAGetDesktopElementspropCount++;
                }
                else
                {
                    uIAGetDesktopElements["FirstItemToReturn"] = 1;
                    uIAGetDesktopElementspropCount++;
                }

                if (__workflow_uIAGetDesktopElementsmaxItemsToReturn != null)
                {
                    if (__workflow_uIAGetDesktopElementsmaxItemsToReturn != null)
                    {
                        uIAGetDesktopElements["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementsmaxItemsToReturn);
                        uIAGetDesktopElementspropCount++;
                    }

                    uIAGetDesktopElementspropCount++;
                }
                else
                {
                    uIAGetDesktopElements["MaxItemsToReturn"] = 0;
                    uIAGetDesktopElementspropCount++;
                }

                if (__workflow_uIAGetDesktopElementsincludeChildProcesses != null)
                {
                    if (__workflow_uIAGetDesktopElementsincludeChildProcesses != null)
                    {
                        uIAGetDesktopElements["IncludeChildProcesses"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementsincludeChildProcesses);
                        uIAGetDesktopElementspropCount++;
                    }

                    uIAGetDesktopElementspropCount++;
                }
                else
                {
                    uIAGetDesktopElements["IncludeChildProcesses"] = false;
                    uIAGetDesktopElementspropCount++;
                }

                uIAGetDesktopElementspropCount++;
                uIAGetDesktopElements["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetDesktopElementsworkflow);
                if (uIAGetDesktopElementspropCount > 0)
                {
                    callPayload.Body = uIAGetDesktopElements;
                }

                return new ApiConnectionAction<UIAGetDesktopElementsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAExpandElement(Expression<Func<int>> uIAExpandElementparentWindowHandle, Expression<Func<string>> uIAExpandElementworkflow, Expression<Func<string>> uIAExpandElementsearchElementName = null, Expression<Func<string>> uIAExpandElementsearchElementClassName = null, Expression<Func<string>> uIAExpandElementsearchElementAutomationId = null, Expression<Func<string>> uIAExpandElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAExpandElementsearchSubTree = null, Expression<Func<int>> uIAExpandElementmatchIndex = null, Expression<Func<string>> uIAExpandElementsearchFilter = null, Expression<Func<string>> uIAExpandElementsortByColumn = null, Expression<Func<bool>> uIAExpandElementmatchIndexAscending = null, Expression<Func<int>> uIAExpandElementmaxElementsToSearch = null, Expression<Func<int>> uIAExpandElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAExpandElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAExpandElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAExpandElementparentWindowHandle = WorkflowExpression.Compile(uIAExpandElementparentWindowHandle, nameof(uIAExpandElementparentWindowHandle), required: true);
            var __workflow_uIAExpandElementworkflow = WorkflowExpression.Compile(uIAExpandElementworkflow, nameof(uIAExpandElementworkflow), required: true);
            var __workflow_uIAExpandElementsearchElementName = WorkflowExpression.Compile(uIAExpandElementsearchElementName, nameof(uIAExpandElementsearchElementName), required: false);
            var __workflow_uIAExpandElementsearchElementClassName = WorkflowExpression.Compile(uIAExpandElementsearchElementClassName, nameof(uIAExpandElementsearchElementClassName), required: false);
            var __workflow_uIAExpandElementsearchElementAutomationId = WorkflowExpression.Compile(uIAExpandElementsearchElementAutomationId, nameof(uIAExpandElementsearchElementAutomationId), required: false);
            var __workflow_uIAExpandElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAExpandElementsearchLocalizedControlType, nameof(uIAExpandElementsearchLocalizedControlType), required: false);
            var __workflow_uIAExpandElementsearchSubTree = WorkflowExpression.Compile(uIAExpandElementsearchSubTree, nameof(uIAExpandElementsearchSubTree), required: false);
            var __workflow_uIAExpandElementmatchIndex = WorkflowExpression.Compile(uIAExpandElementmatchIndex, nameof(uIAExpandElementmatchIndex), required: false);
            var __workflow_uIAExpandElementsearchFilter = WorkflowExpression.Compile(uIAExpandElementsearchFilter, nameof(uIAExpandElementsearchFilter), required: false);
            var __workflow_uIAExpandElementsortByColumn = WorkflowExpression.Compile(uIAExpandElementsortByColumn, nameof(uIAExpandElementsortByColumn), required: false);
            var __workflow_uIAExpandElementmatchIndexAscending = WorkflowExpression.Compile(uIAExpandElementmatchIndexAscending, nameof(uIAExpandElementmatchIndexAscending), required: false);
            var __workflow_uIAExpandElementmaxElementsToSearch = WorkflowExpression.Compile(uIAExpandElementmaxElementsToSearch, nameof(uIAExpandElementmaxElementsToSearch), required: false);
            var __workflow_uIAExpandElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAExpandElementmaxRelativeSearchDepth, nameof(uIAExpandElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAExpandElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAExpandElementmaxChildElementsToSearchPerNode, nameof(uIAExpandElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAExpandElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAExpandElementelementLocalizedControlTypesNotToTraverse, nameof(uIAExpandElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ExpandElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAExpandElement = new JObject();
                var uIAExpandElementpropCount = 0;
                uIAExpandElementpropCount++;
                uIAExpandElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementparentWindowHandle);
                if (__workflow_uIAExpandElementsearchElementName != null)
                {
                    uIAExpandElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchElementName);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsearchElementClassName != null)
                {
                    uIAExpandElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchElementClassName);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsearchElementAutomationId != null)
                {
                    uIAExpandElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchElementAutomationId);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsearchLocalizedControlType != null)
                {
                    uIAExpandElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchLocalizedControlType);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsearchSubTree != null)
                {
                    if (__workflow_uIAExpandElementsearchSubTree != null)
                    {
                        uIAExpandElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchSubTree);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["SearchSubTree"] = true;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementmatchIndex != null)
                {
                    if (__workflow_uIAExpandElementmatchIndex != null)
                    {
                        uIAExpandElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementmatchIndex);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["MatchIndex"] = 1;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsearchFilter != null)
                {
                    uIAExpandElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsearchFilter);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementsortByColumn != null)
                {
                    uIAExpandElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementsortByColumn);
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAExpandElementmatchIndexAscending != null)
                    {
                        uIAExpandElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementmatchIndexAscending);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["MatchIndexAscending"] = true;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAExpandElementmaxElementsToSearch != null)
                    {
                        uIAExpandElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementmaxElementsToSearch);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["MaxElementsToSearch"] = 0;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAExpandElementmaxRelativeSearchDepth != null)
                    {
                        uIAExpandElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementmaxRelativeSearchDepth);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["MaxRelativeSearchDepth"] = 0;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAExpandElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAExpandElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementmaxChildElementsToSearchPerNode);
                        uIAExpandElementpropCount++;
                    }

                    uIAExpandElementpropCount++;
                }
                else
                {
                    uIAExpandElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAExpandElementpropCount++;
                }

                if (__workflow_uIAExpandElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAExpandElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementelementLocalizedControlTypesNotToTraverse);
                    uIAExpandElementpropCount++;
                }

                uIAExpandElementpropCount++;
                uIAExpandElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAExpandElementworkflow);
                if (uIAExpandElementpropCount > 0)
                {
                    callPayload.Body = uIAExpandElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIACollapseElement(Expression<Func<int>> uIACollapseElementparentWindowHandle, Expression<Func<string>> uIACollapseElementworkflow, Expression<Func<string>> uIACollapseElementsearchElementName = null, Expression<Func<string>> uIACollapseElementsearchElementClassName = null, Expression<Func<string>> uIACollapseElementsearchElementAutomationId = null, Expression<Func<string>> uIACollapseElementsearchLocalizedControlType = null, Expression<Func<bool>> uIACollapseElementsearchSubTree = null, Expression<Func<int>> uIACollapseElementmatchIndex = null, Expression<Func<string>> uIACollapseElementsearchFilter = null, Expression<Func<string>> uIACollapseElementsortByColumn = null, Expression<Func<bool>> uIACollapseElementmatchIndexAscending = null, Expression<Func<int>> uIACollapseElementmaxElementsToSearch = null, Expression<Func<int>> uIACollapseElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIACollapseElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIACollapseElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIACollapseElementparentWindowHandle = WorkflowExpression.Compile(uIACollapseElementparentWindowHandle, nameof(uIACollapseElementparentWindowHandle), required: true);
            var __workflow_uIACollapseElementworkflow = WorkflowExpression.Compile(uIACollapseElementworkflow, nameof(uIACollapseElementworkflow), required: true);
            var __workflow_uIACollapseElementsearchElementName = WorkflowExpression.Compile(uIACollapseElementsearchElementName, nameof(uIACollapseElementsearchElementName), required: false);
            var __workflow_uIACollapseElementsearchElementClassName = WorkflowExpression.Compile(uIACollapseElementsearchElementClassName, nameof(uIACollapseElementsearchElementClassName), required: false);
            var __workflow_uIACollapseElementsearchElementAutomationId = WorkflowExpression.Compile(uIACollapseElementsearchElementAutomationId, nameof(uIACollapseElementsearchElementAutomationId), required: false);
            var __workflow_uIACollapseElementsearchLocalizedControlType = WorkflowExpression.Compile(uIACollapseElementsearchLocalizedControlType, nameof(uIACollapseElementsearchLocalizedControlType), required: false);
            var __workflow_uIACollapseElementsearchSubTree = WorkflowExpression.Compile(uIACollapseElementsearchSubTree, nameof(uIACollapseElementsearchSubTree), required: false);
            var __workflow_uIACollapseElementmatchIndex = WorkflowExpression.Compile(uIACollapseElementmatchIndex, nameof(uIACollapseElementmatchIndex), required: false);
            var __workflow_uIACollapseElementsearchFilter = WorkflowExpression.Compile(uIACollapseElementsearchFilter, nameof(uIACollapseElementsearchFilter), required: false);
            var __workflow_uIACollapseElementsortByColumn = WorkflowExpression.Compile(uIACollapseElementsortByColumn, nameof(uIACollapseElementsortByColumn), required: false);
            var __workflow_uIACollapseElementmatchIndexAscending = WorkflowExpression.Compile(uIACollapseElementmatchIndexAscending, nameof(uIACollapseElementmatchIndexAscending), required: false);
            var __workflow_uIACollapseElementmaxElementsToSearch = WorkflowExpression.Compile(uIACollapseElementmaxElementsToSearch, nameof(uIACollapseElementmaxElementsToSearch), required: false);
            var __workflow_uIACollapseElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIACollapseElementmaxRelativeSearchDepth, nameof(uIACollapseElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIACollapseElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIACollapseElementmaxChildElementsToSearchPerNode, nameof(uIACollapseElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIACollapseElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIACollapseElementelementLocalizedControlTypesNotToTraverse, nameof(uIACollapseElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/CollapseElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIACollapseElement = new JObject();
                var uIACollapseElementpropCount = 0;
                uIACollapseElementpropCount++;
                uIACollapseElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementparentWindowHandle);
                if (__workflow_uIACollapseElementsearchElementName != null)
                {
                    uIACollapseElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchElementName);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsearchElementClassName != null)
                {
                    uIACollapseElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchElementClassName);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsearchElementAutomationId != null)
                {
                    uIACollapseElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchElementAutomationId);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsearchLocalizedControlType != null)
                {
                    uIACollapseElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchLocalizedControlType);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsearchSubTree != null)
                {
                    if (__workflow_uIACollapseElementsearchSubTree != null)
                    {
                        uIACollapseElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchSubTree);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["SearchSubTree"] = true;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementmatchIndex != null)
                {
                    if (__workflow_uIACollapseElementmatchIndex != null)
                    {
                        uIACollapseElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementmatchIndex);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["MatchIndex"] = 1;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsearchFilter != null)
                {
                    uIACollapseElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsearchFilter);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementsortByColumn != null)
                {
                    uIACollapseElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementsortByColumn);
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementmatchIndexAscending != null)
                {
                    if (__workflow_uIACollapseElementmatchIndexAscending != null)
                    {
                        uIACollapseElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementmatchIndexAscending);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["MatchIndexAscending"] = true;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIACollapseElementmaxElementsToSearch != null)
                    {
                        uIACollapseElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementmaxElementsToSearch);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["MaxElementsToSearch"] = 0;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIACollapseElementmaxRelativeSearchDepth != null)
                    {
                        uIACollapseElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementmaxRelativeSearchDepth);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["MaxRelativeSearchDepth"] = 0;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIACollapseElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIACollapseElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementmaxChildElementsToSearchPerNode);
                        uIACollapseElementpropCount++;
                    }

                    uIACollapseElementpropCount++;
                }
                else
                {
                    uIACollapseElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIACollapseElementpropCount++;
                }

                if (__workflow_uIACollapseElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIACollapseElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementelementLocalizedControlTypesNotToTraverse);
                    uIACollapseElementpropCount++;
                }

                uIACollapseElementpropCount++;
                uIACollapseElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIACollapseElementworkflow);
                if (uIACollapseElementpropCount > 0)
                {
                    callPayload.Body = uIACollapseElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIATakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration> UIATakeScreenShotOfElementLocation(Expression<Func<int>> uIATakeScreenShotOfElementLocationparentWindowHandle, Expression<Func<string>> uIATakeScreenShotOfElementLocationworkflow, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementClassName = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchElementAutomationId = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchLocalizedControlType = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationsearchSubTree = null, Expression<Func<uIATakeScreenShotOfElementLocationimageFormatInput>> uIATakeScreenShotOfElementLocationimageFormat = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmatchIndex = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsearchFilter = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationsortByColumn = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationmatchIndexAscending = null, Expression<Func<bool>> uIATakeScreenShotOfElementLocationhideAgent = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxElementsToSearch = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth = null, Expression<Func<int>> uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIATakeScreenShotOfElementLocationparentWindowHandle = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationparentWindowHandle, nameof(uIATakeScreenShotOfElementLocationparentWindowHandle), required: true);
            var __workflow_uIATakeScreenShotOfElementLocationworkflow = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationworkflow, nameof(uIATakeScreenShotOfElementLocationworkflow), required: true);
            var __workflow_uIATakeScreenShotOfElementLocationsearchElementName = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchElementName, nameof(uIATakeScreenShotOfElementLocationsearchElementName), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsearchElementClassName = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchElementClassName, nameof(uIATakeScreenShotOfElementLocationsearchElementClassName), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsearchElementAutomationId = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchElementAutomationId, nameof(uIATakeScreenShotOfElementLocationsearchElementAutomationId), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsearchLocalizedControlType = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchLocalizedControlType, nameof(uIATakeScreenShotOfElementLocationsearchLocalizedControlType), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsearchSubTree = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchSubTree, nameof(uIATakeScreenShotOfElementLocationsearchSubTree), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationimageFormat = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationimageFormat, nameof(uIATakeScreenShotOfElementLocationimageFormat), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationmatchIndex = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationmatchIndex, nameof(uIATakeScreenShotOfElementLocationmatchIndex), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsearchFilter = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsearchFilter, nameof(uIATakeScreenShotOfElementLocationsearchFilter), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationsortByColumn = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationsortByColumn, nameof(uIATakeScreenShotOfElementLocationsortByColumn), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationmatchIndexAscending = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationmatchIndexAscending, nameof(uIATakeScreenShotOfElementLocationmatchIndexAscending), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationhideAgent = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationhideAgent, nameof(uIATakeScreenShotOfElementLocationhideAgent), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationmaxElementsToSearch = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationmaxElementsToSearch, nameof(uIATakeScreenShotOfElementLocationmaxElementsToSearch), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth, nameof(uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode, nameof(uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse, nameof(uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIATakeScreenShotOfElementLocationResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/TakeScreenShotOfElementLocation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIATakeScreenShotOfElementLocation = new JObject();
                var uIATakeScreenShotOfElementLocationpropCount = 0;
                uIATakeScreenShotOfElementLocationpropCount++;
                uIATakeScreenShotOfElementLocation["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationparentWindowHandle);
                if (__workflow_uIATakeScreenShotOfElementLocationsearchElementName != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchElementName);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsearchElementClassName != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchElementClassName);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsearchElementAutomationId != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchElementAutomationId);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsearchLocalizedControlType != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchLocalizedControlType);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsearchSubTree != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationsearchSubTree != null)
                    {
                        uIATakeScreenShotOfElementLocation["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchSubTree);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["SearchSubTree"] = true;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationimageFormat != null)
                {
                    uIATakeScreenShotOfElementLocation["ImageFormat"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationimageFormat);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationmatchIndex != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationmatchIndex != null)
                    {
                        uIATakeScreenShotOfElementLocation["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationmatchIndex);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["MatchIndex"] = 1;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsearchFilter != null)
                {
                    uIATakeScreenShotOfElementLocation["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsearchFilter);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationsortByColumn != null)
                {
                    uIATakeScreenShotOfElementLocation["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationsortByColumn);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationmatchIndexAscending != null)
                    {
                        uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationmatchIndexAscending);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["MatchIndexAscending"] = true;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationhideAgent != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationhideAgent != null)
                    {
                        uIATakeScreenShotOfElementLocation["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationhideAgent);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["HideAgent"] = false;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationmaxElementsToSearch != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationmaxElementsToSearch != null)
                    {
                        uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationmaxElementsToSearch);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["MaxElementsToSearch"] = 0;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth != null)
                    {
                        uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationmaxRelativeSearchDepth);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["MaxRelativeSearchDepth"] = 0;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode != null)
                    {
                        uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationmaxChildElementsToSearchPerNode);
                        uIATakeScreenShotOfElementLocationpropCount++;
                    }

                    uIATakeScreenShotOfElementLocationpropCount++;
                }
                else
                {
                    uIATakeScreenShotOfElementLocation["MaxChildElementsToSearchPerNode"] = 0;
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                if (__workflow_uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIATakeScreenShotOfElementLocation["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationelementLocalizedControlTypesNotToTraverse);
                    uIATakeScreenShotOfElementLocationpropCount++;
                }

                uIATakeScreenShotOfElementLocationpropCount++;
                uIATakeScreenShotOfElementLocation["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIATakeScreenShotOfElementLocationworkflow);
                if (uIATakeScreenShotOfElementLocationpropCount > 0)
                {
                    callPayload.Body = uIATakeScreenShotOfElementLocation;
                }

                return new ApiConnectionAction<UIATakeScreenShotOfElementLocationResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIADrawRectangleAroundElement(Expression<Func<int>> uIADrawRectangleAroundElementparentWindowHandle, Expression<Func<string>> uIADrawRectangleAroundElementworkflow, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementName = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementClassName = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchElementAutomationId = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchLocalizedControlType = null, Expression<Func<bool>> uIADrawRectangleAroundElementsearchSubTree = null, Expression<Func<string>> uIADrawRectangleAroundElementpenColour = null, Expression<Func<int>> uIADrawRectangleAroundElementpenThicknessPixels = null, Expression<Func<int>> uIADrawRectangleAroundElementmatchIndex = null, Expression<Func<string>> uIADrawRectangleAroundElementsearchFilter = null, Expression<Func<string>> uIADrawRectangleAroundElementsortByColumn = null, Expression<Func<bool>> uIADrawRectangleAroundElementmatchIndexAscending = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxElementsToSearch = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIADrawRectangleAroundElementparentWindowHandle = WorkflowExpression.Compile(uIADrawRectangleAroundElementparentWindowHandle, nameof(uIADrawRectangleAroundElementparentWindowHandle), required: true);
            var __workflow_uIADrawRectangleAroundElementworkflow = WorkflowExpression.Compile(uIADrawRectangleAroundElementworkflow, nameof(uIADrawRectangleAroundElementworkflow), required: true);
            var __workflow_uIADrawRectangleAroundElementsearchElementName = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchElementName, nameof(uIADrawRectangleAroundElementsearchElementName), required: false);
            var __workflow_uIADrawRectangleAroundElementsearchElementClassName = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchElementClassName, nameof(uIADrawRectangleAroundElementsearchElementClassName), required: false);
            var __workflow_uIADrawRectangleAroundElementsearchElementAutomationId = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchElementAutomationId, nameof(uIADrawRectangleAroundElementsearchElementAutomationId), required: false);
            var __workflow_uIADrawRectangleAroundElementsearchLocalizedControlType = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchLocalizedControlType, nameof(uIADrawRectangleAroundElementsearchLocalizedControlType), required: false);
            var __workflow_uIADrawRectangleAroundElementsearchSubTree = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchSubTree, nameof(uIADrawRectangleAroundElementsearchSubTree), required: false);
            var __workflow_uIADrawRectangleAroundElementpenColour = WorkflowExpression.Compile(uIADrawRectangleAroundElementpenColour, nameof(uIADrawRectangleAroundElementpenColour), required: false);
            var __workflow_uIADrawRectangleAroundElementpenThicknessPixels = WorkflowExpression.Compile(uIADrawRectangleAroundElementpenThicknessPixels, nameof(uIADrawRectangleAroundElementpenThicknessPixels), required: false);
            var __workflow_uIADrawRectangleAroundElementmatchIndex = WorkflowExpression.Compile(uIADrawRectangleAroundElementmatchIndex, nameof(uIADrawRectangleAroundElementmatchIndex), required: false);
            var __workflow_uIADrawRectangleAroundElementsearchFilter = WorkflowExpression.Compile(uIADrawRectangleAroundElementsearchFilter, nameof(uIADrawRectangleAroundElementsearchFilter), required: false);
            var __workflow_uIADrawRectangleAroundElementsortByColumn = WorkflowExpression.Compile(uIADrawRectangleAroundElementsortByColumn, nameof(uIADrawRectangleAroundElementsortByColumn), required: false);
            var __workflow_uIADrawRectangleAroundElementmatchIndexAscending = WorkflowExpression.Compile(uIADrawRectangleAroundElementmatchIndexAscending, nameof(uIADrawRectangleAroundElementmatchIndexAscending), required: false);
            var __workflow_uIADrawRectangleAroundElementmaxElementsToSearch = WorkflowExpression.Compile(uIADrawRectangleAroundElementmaxElementsToSearch, nameof(uIADrawRectangleAroundElementmaxElementsToSearch), required: false);
            var __workflow_uIADrawRectangleAroundElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIADrawRectangleAroundElementmaxRelativeSearchDepth, nameof(uIADrawRectangleAroundElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode, nameof(uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse, nameof(uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/DrawRectangleAroundElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIADrawRectangleAroundElement = new JObject();
                var uIADrawRectangleAroundElementpropCount = 0;
                uIADrawRectangleAroundElementpropCount++;
                uIADrawRectangleAroundElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementparentWindowHandle);
                if (__workflow_uIADrawRectangleAroundElementsearchElementName != null)
                {
                    uIADrawRectangleAroundElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchElementName);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsearchElementClassName != null)
                {
                    uIADrawRectangleAroundElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchElementClassName);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsearchElementAutomationId != null)
                {
                    uIADrawRectangleAroundElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchElementAutomationId);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsearchLocalizedControlType != null)
                {
                    uIADrawRectangleAroundElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchLocalizedControlType);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsearchSubTree != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementsearchSubTree != null)
                    {
                        uIADrawRectangleAroundElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchSubTree);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["SearchSubTree"] = true;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementpenColour != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementpenColour != null)
                    {
                        uIADrawRectangleAroundElement["PenColour"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementpenColour);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["PenColour"] = "#800080";
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementpenThicknessPixels != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementpenThicknessPixels != null)
                    {
                        uIADrawRectangleAroundElement["PenThicknessPixels"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementpenThicknessPixels);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["PenThicknessPixels"] = 4;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementmatchIndex != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementmatchIndex != null)
                    {
                        uIADrawRectangleAroundElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementmatchIndex);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["MatchIndex"] = 1;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsearchFilter != null)
                {
                    uIADrawRectangleAroundElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsearchFilter);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementsortByColumn != null)
                {
                    uIADrawRectangleAroundElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementsortByColumn);
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementmatchIndexAscending != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementmatchIndexAscending != null)
                    {
                        uIADrawRectangleAroundElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementmatchIndexAscending);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["MatchIndexAscending"] = true;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementmaxElementsToSearch != null)
                    {
                        uIADrawRectangleAroundElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementmaxElementsToSearch);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["MaxElementsToSearch"] = 0;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementmaxRelativeSearchDepth != null)
                    {
                        uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementmaxRelativeSearchDepth);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["MaxRelativeSearchDepth"] = 0;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementmaxChildElementsToSearchPerNode);
                        uIADrawRectangleAroundElementpropCount++;
                    }

                    uIADrawRectangleAroundElementpropCount++;
                }
                else
                {
                    uIADrawRectangleAroundElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIADrawRectangleAroundElementpropCount++;
                }

                if (__workflow_uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIADrawRectangleAroundElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementelementLocalizedControlTypesNotToTraverse);
                    uIADrawRectangleAroundElementpropCount++;
                }

                uIADrawRectangleAroundElementpropCount++;
                uIADrawRectangleAroundElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIADrawRectangleAroundElementworkflow);
                if (uIADrawRectangleAroundElementpropCount > 0)
                {
                    callPayload.Body = uIADrawRectangleAroundElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetParentElementHandleResponse, ApiConnectionActionConfiguration> UIAGetParentElementHandle(Expression<Func<int>> uIAGetParentElementHandleelementHandle, Expression<Func<string>> uIAGetParentElementHandleworkflow)
        {
            var __workflow_uIAGetParentElementHandleelementHandle = WorkflowExpression.Compile(uIAGetParentElementHandleelementHandle, nameof(uIAGetParentElementHandleelementHandle), required: true);
            var __workflow_uIAGetParentElementHandleworkflow = WorkflowExpression.Compile(uIAGetParentElementHandleworkflow, nameof(uIAGetParentElementHandleworkflow), required: true);
            return new DeferredBodyAction<UIAGetParentElementHandleResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetParentElementHandle";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetParentElementHandle = new JObject();
                var uIAGetParentElementHandlepropCount = 0;
                uIAGetParentElementHandlepropCount++;
                uIAGetParentElementHandle["ElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetParentElementHandleelementHandle);
                uIAGetParentElementHandlepropCount++;
                uIAGetParentElementHandle["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetParentElementHandleworkflow);
                if (uIAGetParentElementHandlepropCount > 0)
                {
                    callPayload.Body = uIAGetParentElementHandle;
                }

                return new ApiConnectionAction<UIAGetParentElementHandleResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementContentsResponse, ApiConnectionActionConfiguration> UIAGetDataGridElementContents(Expression<Func<string>> uIAGetDataGridElementContentsworkflow, Expression<Func<int>> uIAGetDataGridElementContentsparentWindowHandle = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementName = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementContentssearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementContentssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementContentssearchSubTree = null, Expression<Func<bool>> uIAGetDataGridElementContentsonScreenColumnsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsonScreenRowsOnly = null, Expression<Func<bool>> uIAGetDataGridElementContentsreturnNullValuesAsBlank = null, Expression<Func<string>> uIAGetDataGridElementContentsalternativeHeaderRowName = null, Expression<Func<bool>> uIAGetDataGridElementContentsreturnRowUIAName = null, Expression<Func<string>> uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName = null, Expression<Func<int>> uIAGetDataGridElementContentsmatchIndex = null, Expression<Func<string>> uIAGetDataGridElementContentssearchFilter = null, Expression<Func<string>> uIAGetDataGridElementContentssortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementContentsmatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementContentsfirstItemToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxItemsToReturn = null, Expression<Func<int>> uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows = null, Expression<Func<bool>> uIAGetDataGridElementContentsreadTableAsThread = null, Expression<Func<int>> uIAGetDataGridElementContentsretrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetDataGridElementContentssecondsToWaitForThread = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows = null, Expression<Func<int>> uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle = null, Expression<Func<int>> uIAGetDataGridElementContentsminimumDataGridRowsForScrolling = null, Expression<Func<bool>> uIAGetDataGridElementContentsraiseExceptionIfCannotScroll = null, Expression<Func<string>> uIAGetDataGridElementContentsalternativeVerticalScrollbarName = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetDataGridElementContentsworkflow = WorkflowExpression.Compile(uIAGetDataGridElementContentsworkflow, nameof(uIAGetDataGridElementContentsworkflow), required: true);
            var __workflow_uIAGetDataGridElementContentsparentWindowHandle = WorkflowExpression.Compile(uIAGetDataGridElementContentsparentWindowHandle, nameof(uIAGetDataGridElementContentsparentWindowHandle), required: false);
            var __workflow_uIAGetDataGridElementContentssearchElementName = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchElementName, nameof(uIAGetDataGridElementContentssearchElementName), required: false);
            var __workflow_uIAGetDataGridElementContentssearchElementClassName = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchElementClassName, nameof(uIAGetDataGridElementContentssearchElementClassName), required: false);
            var __workflow_uIAGetDataGridElementContentssearchElementAutomationId = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchElementAutomationId, nameof(uIAGetDataGridElementContentssearchElementAutomationId), required: false);
            var __workflow_uIAGetDataGridElementContentssearchLocalizedControlType = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchLocalizedControlType, nameof(uIAGetDataGridElementContentssearchLocalizedControlType), required: false);
            var __workflow_uIAGetDataGridElementContentssearchSubTree = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchSubTree, nameof(uIAGetDataGridElementContentssearchSubTree), required: false);
            var __workflow_uIAGetDataGridElementContentsonScreenColumnsOnly = WorkflowExpression.Compile(uIAGetDataGridElementContentsonScreenColumnsOnly, nameof(uIAGetDataGridElementContentsonScreenColumnsOnly), required: false);
            var __workflow_uIAGetDataGridElementContentsonScreenRowsOnly = WorkflowExpression.Compile(uIAGetDataGridElementContentsonScreenRowsOnly, nameof(uIAGetDataGridElementContentsonScreenRowsOnly), required: false);
            var __workflow_uIAGetDataGridElementContentsreturnNullValuesAsBlank = WorkflowExpression.Compile(uIAGetDataGridElementContentsreturnNullValuesAsBlank, nameof(uIAGetDataGridElementContentsreturnNullValuesAsBlank), required: false);
            var __workflow_uIAGetDataGridElementContentsalternativeHeaderRowName = WorkflowExpression.Compile(uIAGetDataGridElementContentsalternativeHeaderRowName, nameof(uIAGetDataGridElementContentsalternativeHeaderRowName), required: false);
            var __workflow_uIAGetDataGridElementContentsreturnRowUIAName = WorkflowExpression.Compile(uIAGetDataGridElementContentsreturnRowUIAName, nameof(uIAGetDataGridElementContentsreturnRowUIAName), required: false);
            var __workflow_uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName = WorkflowExpression.Compile(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName, nameof(uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName), required: false);
            var __workflow_uIAGetDataGridElementContentsmatchIndex = WorkflowExpression.Compile(uIAGetDataGridElementContentsmatchIndex, nameof(uIAGetDataGridElementContentsmatchIndex), required: false);
            var __workflow_uIAGetDataGridElementContentssearchFilter = WorkflowExpression.Compile(uIAGetDataGridElementContentssearchFilter, nameof(uIAGetDataGridElementContentssearchFilter), required: false);
            var __workflow_uIAGetDataGridElementContentssortByColumn = WorkflowExpression.Compile(uIAGetDataGridElementContentssortByColumn, nameof(uIAGetDataGridElementContentssortByColumn), required: false);
            var __workflow_uIAGetDataGridElementContentsmatchIndexAscending = WorkflowExpression.Compile(uIAGetDataGridElementContentsmatchIndexAscending, nameof(uIAGetDataGridElementContentsmatchIndexAscending), required: false);
            var __workflow_uIAGetDataGridElementContentsfirstItemToReturn = WorkflowExpression.Compile(uIAGetDataGridElementContentsfirstItemToReturn, nameof(uIAGetDataGridElementContentsfirstItemToReturn), required: false);
            var __workflow_uIAGetDataGridElementContentsmaxItemsToReturn = WorkflowExpression.Compile(uIAGetDataGridElementContentsmaxItemsToReturn, nameof(uIAGetDataGridElementContentsmaxItemsToReturn), required: false);
            var __workflow_uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows = WorkflowExpression.Compile(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows, nameof(uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows), required: false);
            var __workflow_uIAGetDataGridElementContentsreadTableAsThread = WorkflowExpression.Compile(uIAGetDataGridElementContentsreadTableAsThread, nameof(uIAGetDataGridElementContentsreadTableAsThread), required: false);
            var __workflow_uIAGetDataGridElementContentsretrieveOutputDataFromThreadId = WorkflowExpression.Compile(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId, nameof(uIAGetDataGridElementContentsretrieveOutputDataFromThreadId), required: false);
            var __workflow_uIAGetDataGridElementContentssecondsToWaitForThread = WorkflowExpression.Compile(uIAGetDataGridElementContentssecondsToWaitForThread, nameof(uIAGetDataGridElementContentssecondsToWaitForThread), required: false);
            var __workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent = WorkflowExpression.Compile(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent, nameof(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent), required: false);
            var __workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows = WorkflowExpression.Compile(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows, nameof(uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows), required: false);
            var __workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle = WorkflowExpression.Compile(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle, nameof(uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle), required: false);
            var __workflow_uIAGetDataGridElementContentsminimumDataGridRowsForScrolling = WorkflowExpression.Compile(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling, nameof(uIAGetDataGridElementContentsminimumDataGridRowsForScrolling), required: false);
            var __workflow_uIAGetDataGridElementContentsraiseExceptionIfCannotScroll = WorkflowExpression.Compile(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll, nameof(uIAGetDataGridElementContentsraiseExceptionIfCannotScroll), required: false);
            var __workflow_uIAGetDataGridElementContentsalternativeVerticalScrollbarName = WorkflowExpression.Compile(uIAGetDataGridElementContentsalternativeVerticalScrollbarName, nameof(uIAGetDataGridElementContentsalternativeVerticalScrollbarName), required: false);
            var __workflow_uIAGetDataGridElementContentsmaxElementsToSearch = WorkflowExpression.Compile(uIAGetDataGridElementContentsmaxElementsToSearch, nameof(uIAGetDataGridElementContentsmaxElementsToSearch), required: false);
            var __workflow_uIAGetDataGridElementContentsmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetDataGridElementContentsmaxRelativeSearchDepth, nameof(uIAGetDataGridElementContentsmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode, nameof(uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse, nameof(uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetDataGridElementContentsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementContents";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDataGridElementContents = new JObject();
                var uIAGetDataGridElementContentspropCount = 0;
                if (__workflow_uIAGetDataGridElementContentsparentWindowHandle != null)
                {
                    uIAGetDataGridElementContents["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsparentWindowHandle);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchElementName != null)
                {
                    uIAGetDataGridElementContents["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchElementName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchElementClassName != null)
                {
                    uIAGetDataGridElementContents["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchElementClassName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchElementAutomationId != null)
                {
                    uIAGetDataGridElementContents["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchElementAutomationId);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchLocalizedControlType != null)
                {
                    uIAGetDataGridElementContents["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchLocalizedControlType);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchSubTree != null)
                {
                    if (__workflow_uIAGetDataGridElementContentssearchSubTree != null)
                    {
                        uIAGetDataGridElementContents["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchSubTree);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["SearchSubTree"] = true;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsonScreenColumnsOnly != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsonScreenColumnsOnly != null)
                    {
                        uIAGetDataGridElementContents["OnScreenColumnsOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsonScreenColumnsOnly);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["OnScreenColumnsOnly"] = true;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsonScreenRowsOnly != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsonScreenRowsOnly != null)
                    {
                        uIAGetDataGridElementContents["OnScreenRowsOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsonScreenRowsOnly);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["OnScreenRowsOnly"] = true;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsreturnNullValuesAsBlank != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsreturnNullValuesAsBlank != null)
                    {
                        uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsreturnNullValuesAsBlank);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ReturnNullValuesAsBlank"] = true;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsalternativeHeaderRowName != null)
                {
                    uIAGetDataGridElementContents["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsalternativeHeaderRowName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsreturnRowUIAName != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsreturnRowUIAName != null)
                    {
                        uIAGetDataGridElementContents["ReturnRowUIAName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsreturnRowUIAName);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ReturnRowUIAName"] = false;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName != null)
                {
                    uIAGetDataGridElementContents["NameOfColumnToStoreRowUIAName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsnameOfColumnToStoreRowUIAName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmatchIndex != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmatchIndex != null)
                    {
                        uIAGetDataGridElementContents["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmatchIndex);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MatchIndex"] = 1;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssearchFilter != null)
                {
                    uIAGetDataGridElementContents["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssearchFilter);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssortByColumn != null)
                {
                    uIAGetDataGridElementContents["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssortByColumn);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmatchIndexAscending != null)
                    {
                        uIAGetDataGridElementContents["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmatchIndexAscending);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MatchIndexAscending"] = true;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsfirstItemToReturn != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsfirstItemToReturn != null)
                    {
                        uIAGetDataGridElementContents["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsfirstItemToReturn);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["FirstItemToReturn"] = 1;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmaxItemsToReturn != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmaxItemsToReturn != null)
                    {
                        uIAGetDataGridElementContents["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmaxItemsToReturn);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MaxItemsToReturn"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows != null)
                    {
                        uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsscanFirstNRowsForEmptyRows);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ScanFirstNRowsForEmptyRows"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsreadTableAsThread != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsreadTableAsThread != null)
                    {
                        uIAGetDataGridElementContents["ReadTableAsThread"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsreadTableAsThread);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ReadTableAsThread"] = false;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsretrieveOutputDataFromThreadId != null)
                {
                    uIAGetDataGridElementContents["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsretrieveOutputDataFromThreadId);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentssecondsToWaitForThread != null)
                {
                    if (__workflow_uIAGetDataGridElementContentssecondsToWaitForThread != null)
                    {
                        uIAGetDataGridElementContents["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentssecondsToWaitForThread);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["SecondsToWaitForThread"] = 90;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent != null)
                    {
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNPercent);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNPercent"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows != null)
                    {
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyEveryNRows);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyEveryNRows"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle != null)
                    {
                        uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsscrollDataGridVerticallyElementHandle);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["ScrollDataGridVerticallyElementHandle"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsminimumDataGridRowsForScrolling != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsminimumDataGridRowsForScrolling != null)
                    {
                        uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsminimumDataGridRowsForScrolling);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MinimumDataGridRowsForScrolling"] = 200;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsraiseExceptionIfCannotScroll != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsraiseExceptionIfCannotScroll != null)
                    {
                        uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsraiseExceptionIfCannotScroll);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["RaiseExceptionIfCannotScroll"] = false;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsalternativeVerticalScrollbarName != null)
                {
                    uIAGetDataGridElementContents["AlternativeVerticalScrollbarName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsalternativeVerticalScrollbarName);
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmaxElementsToSearch != null)
                    {
                        uIAGetDataGridElementContents["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmaxElementsToSearch);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MaxElementsToSearch"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmaxRelativeSearchDepth != null)
                    {
                        uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmaxRelativeSearchDepth);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MaxRelativeSearchDepth"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsmaxChildElementsToSearchPerNode);
                        uIAGetDataGridElementContentspropCount++;
                    }

                    uIAGetDataGridElementContentspropCount++;
                }
                else
                {
                    uIAGetDataGridElementContents["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetDataGridElementContentspropCount++;
                }

                if (__workflow_uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetDataGridElementContents["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentselementLocalizedControlTypesNotToTraverse);
                    uIAGetDataGridElementContentspropCount++;
                }

                uIAGetDataGridElementContentspropCount++;
                uIAGetDataGridElementContents["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementContentsworkflow);
                if (uIAGetDataGridElementContentspropCount > 0)
                {
                    callPayload.Body = uIAGetDataGridElementContents;
                }

                return new ApiConnectionAction<UIAGetDataGridElementContentsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetDataGridElementProperties(Expression<Func<int>> uIAGetDataGridElementPropertiesparentWindowHandle, Expression<Func<string>> uIAGetDataGridElementPropertiesworkflow, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementName = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementClassName = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchElementAutomationId = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchLocalizedControlType = null, Expression<Func<bool>> uIAGetDataGridElementPropertiessearchSubTree = null, Expression<Func<string>> uIAGetDataGridElementPropertiesalternativeHeaderRowName = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmatchIndex = null, Expression<Func<string>> uIAGetDataGridElementPropertiessearchFilter = null, Expression<Func<string>> uIAGetDataGridElementPropertiessortByColumn = null, Expression<Func<bool>> uIAGetDataGridElementPropertiesmatchIndexAscending = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxElementsToSearch = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetDataGridElementPropertiesparentWindowHandle = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesparentWindowHandle, nameof(uIAGetDataGridElementPropertiesparentWindowHandle), required: true);
            var __workflow_uIAGetDataGridElementPropertiesworkflow = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesworkflow, nameof(uIAGetDataGridElementPropertiesworkflow), required: true);
            var __workflow_uIAGetDataGridElementPropertiessearchElementName = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchElementName, nameof(uIAGetDataGridElementPropertiessearchElementName), required: false);
            var __workflow_uIAGetDataGridElementPropertiessearchElementClassName = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchElementClassName, nameof(uIAGetDataGridElementPropertiessearchElementClassName), required: false);
            var __workflow_uIAGetDataGridElementPropertiessearchElementAutomationId = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchElementAutomationId, nameof(uIAGetDataGridElementPropertiessearchElementAutomationId), required: false);
            var __workflow_uIAGetDataGridElementPropertiessearchLocalizedControlType = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchLocalizedControlType, nameof(uIAGetDataGridElementPropertiessearchLocalizedControlType), required: false);
            var __workflow_uIAGetDataGridElementPropertiessearchSubTree = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchSubTree, nameof(uIAGetDataGridElementPropertiessearchSubTree), required: false);
            var __workflow_uIAGetDataGridElementPropertiesalternativeHeaderRowName = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesalternativeHeaderRowName, nameof(uIAGetDataGridElementPropertiesalternativeHeaderRowName), required: false);
            var __workflow_uIAGetDataGridElementPropertiesmatchIndex = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesmatchIndex, nameof(uIAGetDataGridElementPropertiesmatchIndex), required: false);
            var __workflow_uIAGetDataGridElementPropertiessearchFilter = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessearchFilter, nameof(uIAGetDataGridElementPropertiessearchFilter), required: false);
            var __workflow_uIAGetDataGridElementPropertiessortByColumn = WorkflowExpression.Compile(uIAGetDataGridElementPropertiessortByColumn, nameof(uIAGetDataGridElementPropertiessortByColumn), required: false);
            var __workflow_uIAGetDataGridElementPropertiesmatchIndexAscending = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesmatchIndexAscending, nameof(uIAGetDataGridElementPropertiesmatchIndexAscending), required: false);
            var __workflow_uIAGetDataGridElementPropertiesmaxElementsToSearch = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesmaxElementsToSearch, nameof(uIAGetDataGridElementPropertiesmaxElementsToSearch), required: false);
            var __workflow_uIAGetDataGridElementPropertiesmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth, nameof(uIAGetDataGridElementPropertiesmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode, nameof(uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse, nameof(uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetDataGridElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetDataGridElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetDataGridElementProperties = new JObject();
                var uIAGetDataGridElementPropertiespropCount = 0;
                uIAGetDataGridElementPropertiespropCount++;
                uIAGetDataGridElementProperties["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesparentWindowHandle);
                if (__workflow_uIAGetDataGridElementPropertiessearchElementName != null)
                {
                    uIAGetDataGridElementProperties["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchElementName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessearchElementClassName != null)
                {
                    uIAGetDataGridElementProperties["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchElementClassName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessearchElementAutomationId != null)
                {
                    uIAGetDataGridElementProperties["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchElementAutomationId);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessearchLocalizedControlType != null)
                {
                    uIAGetDataGridElementProperties["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchLocalizedControlType);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessearchSubTree != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiessearchSubTree != null)
                    {
                        uIAGetDataGridElementProperties["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchSubTree);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["SearchSubTree"] = true;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesalternativeHeaderRowName != null)
                {
                    uIAGetDataGridElementProperties["AlternativeHeaderRowName"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesalternativeHeaderRowName);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesmatchIndex != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiesmatchIndex != null)
                    {
                        uIAGetDataGridElementProperties["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesmatchIndex);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["MatchIndex"] = 1;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessearchFilter != null)
                {
                    uIAGetDataGridElementProperties["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessearchFilter);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiessortByColumn != null)
                {
                    uIAGetDataGridElementProperties["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiessortByColumn);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiesmatchIndexAscending != null)
                    {
                        uIAGetDataGridElementProperties["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesmatchIndexAscending);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["MatchIndexAscending"] = true;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiesmaxElementsToSearch != null)
                    {
                        uIAGetDataGridElementProperties["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesmaxElementsToSearch);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["MaxElementsToSearch"] = 0;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiesmaxRelativeSearchDepth != null)
                    {
                        uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesmaxRelativeSearchDepth);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["MaxRelativeSearchDepth"] = 0;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesmaxChildElementsToSearchPerNode);
                        uIAGetDataGridElementPropertiespropCount++;
                    }

                    uIAGetDataGridElementPropertiespropCount++;
                }
                else
                {
                    uIAGetDataGridElementProperties["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetDataGridElementPropertiespropCount++;
                }

                if (__workflow_uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetDataGridElementProperties["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertieselementLocalizedControlTypesNotToTraverse);
                    uIAGetDataGridElementPropertiespropCount++;
                }

                uIAGetDataGridElementPropertiespropCount++;
                uIAGetDataGridElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetDataGridElementPropertiesworkflow);
                if (uIAGetDataGridElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetDataGridElementProperties;
                }

                return new ApiConnectionAction<UIAGetDataGridElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetListElementItemsResponse, ApiConnectionActionConfiguration> UIAGetListElementItems(Expression<Func<int>> uIAGetListElementItemsparentWindowHandle, Expression<Func<string>> uIAGetListElementItemsworkflow, Expression<Func<string>> uIAGetListElementItemssearchElementName = null, Expression<Func<string>> uIAGetListElementItemssearchElementClassName = null, Expression<Func<string>> uIAGetListElementItemssearchElementAutomationId = null, Expression<Func<string>> uIAGetListElementItemssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetListElementItemssearchSubTree = null, Expression<Func<bool>> uIAGetListElementItemsexpandFirst = null, Expression<Func<bool>> uIAGetListElementItemscollapseAfter = null, Expression<Func<bool>> uIAGetListElementItemscheckForSelectedItems = null, Expression<Func<double>> uIAGetListElementItemssecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAGetListElementItemsmatchIndex = null, Expression<Func<string>> uIAGetListElementItemssearchFilter = null, Expression<Func<string>> uIAGetListElementItemssortByColumn = null, Expression<Func<bool>> uIAGetListElementItemsmatchIndexAscending = null, Expression<Func<int>> uIAGetListElementItemsmaxElementsToSearch = null, Expression<Func<int>> uIAGetListElementItemsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetListElementItemsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetListElementItemselementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetListElementItemsparentWindowHandle = WorkflowExpression.Compile(uIAGetListElementItemsparentWindowHandle, nameof(uIAGetListElementItemsparentWindowHandle), required: true);
            var __workflow_uIAGetListElementItemsworkflow = WorkflowExpression.Compile(uIAGetListElementItemsworkflow, nameof(uIAGetListElementItemsworkflow), required: true);
            var __workflow_uIAGetListElementItemssearchElementName = WorkflowExpression.Compile(uIAGetListElementItemssearchElementName, nameof(uIAGetListElementItemssearchElementName), required: false);
            var __workflow_uIAGetListElementItemssearchElementClassName = WorkflowExpression.Compile(uIAGetListElementItemssearchElementClassName, nameof(uIAGetListElementItemssearchElementClassName), required: false);
            var __workflow_uIAGetListElementItemssearchElementAutomationId = WorkflowExpression.Compile(uIAGetListElementItemssearchElementAutomationId, nameof(uIAGetListElementItemssearchElementAutomationId), required: false);
            var __workflow_uIAGetListElementItemssearchLocalizedControlType = WorkflowExpression.Compile(uIAGetListElementItemssearchLocalizedControlType, nameof(uIAGetListElementItemssearchLocalizedControlType), required: false);
            var __workflow_uIAGetListElementItemssearchSubTree = WorkflowExpression.Compile(uIAGetListElementItemssearchSubTree, nameof(uIAGetListElementItemssearchSubTree), required: false);
            var __workflow_uIAGetListElementItemsexpandFirst = WorkflowExpression.Compile(uIAGetListElementItemsexpandFirst, nameof(uIAGetListElementItemsexpandFirst), required: false);
            var __workflow_uIAGetListElementItemscollapseAfter = WorkflowExpression.Compile(uIAGetListElementItemscollapseAfter, nameof(uIAGetListElementItemscollapseAfter), required: false);
            var __workflow_uIAGetListElementItemscheckForSelectedItems = WorkflowExpression.Compile(uIAGetListElementItemscheckForSelectedItems, nameof(uIAGetListElementItemscheckForSelectedItems), required: false);
            var __workflow_uIAGetListElementItemssecondsBetweenExpandCollapse = WorkflowExpression.Compile(uIAGetListElementItemssecondsBetweenExpandCollapse, nameof(uIAGetListElementItemssecondsBetweenExpandCollapse), required: false);
            var __workflow_uIAGetListElementItemsmatchIndex = WorkflowExpression.Compile(uIAGetListElementItemsmatchIndex, nameof(uIAGetListElementItemsmatchIndex), required: false);
            var __workflow_uIAGetListElementItemssearchFilter = WorkflowExpression.Compile(uIAGetListElementItemssearchFilter, nameof(uIAGetListElementItemssearchFilter), required: false);
            var __workflow_uIAGetListElementItemssortByColumn = WorkflowExpression.Compile(uIAGetListElementItemssortByColumn, nameof(uIAGetListElementItemssortByColumn), required: false);
            var __workflow_uIAGetListElementItemsmatchIndexAscending = WorkflowExpression.Compile(uIAGetListElementItemsmatchIndexAscending, nameof(uIAGetListElementItemsmatchIndexAscending), required: false);
            var __workflow_uIAGetListElementItemsmaxElementsToSearch = WorkflowExpression.Compile(uIAGetListElementItemsmaxElementsToSearch, nameof(uIAGetListElementItemsmaxElementsToSearch), required: false);
            var __workflow_uIAGetListElementItemsmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetListElementItemsmaxRelativeSearchDepth, nameof(uIAGetListElementItemsmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetListElementItemsmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetListElementItemsmaxChildElementsToSearchPerNode, nameof(uIAGetListElementItemsmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetListElementItemselementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetListElementItemselementLocalizedControlTypesNotToTraverse, nameof(uIAGetListElementItemselementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetListElementItemsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetListElementItems";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetListElementItems = new JObject();
                var uIAGetListElementItemspropCount = 0;
                uIAGetListElementItemspropCount++;
                uIAGetListElementItems["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsparentWindowHandle);
                if (__workflow_uIAGetListElementItemssearchElementName != null)
                {
                    uIAGetListElementItems["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchElementName);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssearchElementClassName != null)
                {
                    uIAGetListElementItems["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchElementClassName);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssearchElementAutomationId != null)
                {
                    uIAGetListElementItems["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchElementAutomationId);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssearchLocalizedControlType != null)
                {
                    uIAGetListElementItems["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchLocalizedControlType);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssearchSubTree != null)
                {
                    if (__workflow_uIAGetListElementItemssearchSubTree != null)
                    {
                        uIAGetListElementItems["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchSubTree);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["SearchSubTree"] = true;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsexpandFirst != null)
                {
                    if (__workflow_uIAGetListElementItemsexpandFirst != null)
                    {
                        uIAGetListElementItems["ExpandFirst"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsexpandFirst);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["ExpandFirst"] = false;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemscollapseAfter != null)
                {
                    if (__workflow_uIAGetListElementItemscollapseAfter != null)
                    {
                        uIAGetListElementItems["CollapseAfter"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemscollapseAfter);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["CollapseAfter"] = false;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemscheckForSelectedItems != null)
                {
                    if (__workflow_uIAGetListElementItemscheckForSelectedItems != null)
                    {
                        uIAGetListElementItems["CheckForSelectedItems"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemscheckForSelectedItems);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["CheckForSelectedItems"] = true;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssecondsBetweenExpandCollapse != null)
                {
                    if (__workflow_uIAGetListElementItemssecondsBetweenExpandCollapse != null)
                    {
                        uIAGetListElementItems["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssecondsBetweenExpandCollapse);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["SecondsBetweenExpandCollapse"] = 0;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsmatchIndex != null)
                {
                    if (__workflow_uIAGetListElementItemsmatchIndex != null)
                    {
                        uIAGetListElementItems["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsmatchIndex);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["MatchIndex"] = 1;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssearchFilter != null)
                {
                    uIAGetListElementItems["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssearchFilter);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemssortByColumn != null)
                {
                    uIAGetListElementItems["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemssortByColumn);
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetListElementItemsmatchIndexAscending != null)
                    {
                        uIAGetListElementItems["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsmatchIndexAscending);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["MatchIndexAscending"] = true;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetListElementItemsmaxElementsToSearch != null)
                    {
                        uIAGetListElementItems["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsmaxElementsToSearch);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["MaxElementsToSearch"] = 0;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetListElementItemsmaxRelativeSearchDepth != null)
                    {
                        uIAGetListElementItems["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsmaxRelativeSearchDepth);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["MaxRelativeSearchDepth"] = 0;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemsmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetListElementItemsmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsmaxChildElementsToSearchPerNode);
                        uIAGetListElementItemspropCount++;
                    }

                    uIAGetListElementItemspropCount++;
                }
                else
                {
                    uIAGetListElementItems["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetListElementItemspropCount++;
                }

                if (__workflow_uIAGetListElementItemselementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetListElementItems["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemselementLocalizedControlTypesNotToTraverse);
                    uIAGetListElementItemspropCount++;
                }

                uIAGetListElementItemspropCount++;
                uIAGetListElementItems["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetListElementItemsworkflow);
                if (uIAGetListElementItemspropCount > 0)
                {
                    callPayload.Body = uIAGetListElementItems;
                }

                return new ApiConnectionAction<UIAGetListElementItemsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAClickListElementItemByName(Expression<Func<int>> uIAClickListElementItemByNameparentWindowHandle, Expression<Func<string>> uIAClickListElementItemByNameworkflow, Expression<Func<string>> uIAClickListElementItemByNamesearchElementName = null, Expression<Func<string>> uIAClickListElementItemByNamesearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByNamesearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByNamesearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByNamesearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByNameexpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByNamecollapseAfter = null, Expression<Func<string>> uIAClickListElementItemByNameitemName = null, Expression<Func<double>> uIAClickListElementItemByNamesecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByNamematchIndex = null, Expression<Func<string>> uIAClickListElementItemByNamesearchFilter = null, Expression<Func<string>> uIAClickListElementItemByNamesortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByNamematchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByNamemaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByNamemaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByNamemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAClickListElementItemByNameparentWindowHandle = WorkflowExpression.Compile(uIAClickListElementItemByNameparentWindowHandle, nameof(uIAClickListElementItemByNameparentWindowHandle), required: true);
            var __workflow_uIAClickListElementItemByNameworkflow = WorkflowExpression.Compile(uIAClickListElementItemByNameworkflow, nameof(uIAClickListElementItemByNameworkflow), required: true);
            var __workflow_uIAClickListElementItemByNamesearchElementName = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchElementName, nameof(uIAClickListElementItemByNamesearchElementName), required: false);
            var __workflow_uIAClickListElementItemByNamesearchElementClassName = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchElementClassName, nameof(uIAClickListElementItemByNamesearchElementClassName), required: false);
            var __workflow_uIAClickListElementItemByNamesearchElementAutomationId = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchElementAutomationId, nameof(uIAClickListElementItemByNamesearchElementAutomationId), required: false);
            var __workflow_uIAClickListElementItemByNamesearchLocalizedControlType = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchLocalizedControlType, nameof(uIAClickListElementItemByNamesearchLocalizedControlType), required: false);
            var __workflow_uIAClickListElementItemByNamesearchSubTree = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchSubTree, nameof(uIAClickListElementItemByNamesearchSubTree), required: false);
            var __workflow_uIAClickListElementItemByNameexpandFirst = WorkflowExpression.Compile(uIAClickListElementItemByNameexpandFirst, nameof(uIAClickListElementItemByNameexpandFirst), required: false);
            var __workflow_uIAClickListElementItemByNamecollapseAfter = WorkflowExpression.Compile(uIAClickListElementItemByNamecollapseAfter, nameof(uIAClickListElementItemByNamecollapseAfter), required: false);
            var __workflow_uIAClickListElementItemByNameitemName = WorkflowExpression.Compile(uIAClickListElementItemByNameitemName, nameof(uIAClickListElementItemByNameitemName), required: false);
            var __workflow_uIAClickListElementItemByNamesecondsBetweenExpandCollapse = WorkflowExpression.Compile(uIAClickListElementItemByNamesecondsBetweenExpandCollapse, nameof(uIAClickListElementItemByNamesecondsBetweenExpandCollapse), required: false);
            var __workflow_uIAClickListElementItemByNamematchIndex = WorkflowExpression.Compile(uIAClickListElementItemByNamematchIndex, nameof(uIAClickListElementItemByNamematchIndex), required: false);
            var __workflow_uIAClickListElementItemByNamesearchFilter = WorkflowExpression.Compile(uIAClickListElementItemByNamesearchFilter, nameof(uIAClickListElementItemByNamesearchFilter), required: false);
            var __workflow_uIAClickListElementItemByNamesortByColumn = WorkflowExpression.Compile(uIAClickListElementItemByNamesortByColumn, nameof(uIAClickListElementItemByNamesortByColumn), required: false);
            var __workflow_uIAClickListElementItemByNamematchIndexAscending = WorkflowExpression.Compile(uIAClickListElementItemByNamematchIndexAscending, nameof(uIAClickListElementItemByNamematchIndexAscending), required: false);
            var __workflow_uIAClickListElementItemByNamemaxElementsToSearch = WorkflowExpression.Compile(uIAClickListElementItemByNamemaxElementsToSearch, nameof(uIAClickListElementItemByNamemaxElementsToSearch), required: false);
            var __workflow_uIAClickListElementItemByNamemaxRelativeSearchDepth = WorkflowExpression.Compile(uIAClickListElementItemByNamemaxRelativeSearchDepth, nameof(uIAClickListElementItemByNamemaxRelativeSearchDepth), required: false);
            var __workflow_uIAClickListElementItemByNamemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode, nameof(uIAClickListElementItemByNamemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse, nameof(uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByName";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAClickListElementItemByName = new JObject();
                var uIAClickListElementItemByNamepropCount = 0;
                uIAClickListElementItemByNamepropCount++;
                uIAClickListElementItemByName["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNameparentWindowHandle);
                if (__workflow_uIAClickListElementItemByNamesearchElementName != null)
                {
                    uIAClickListElementItemByName["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchElementName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesearchElementClassName != null)
                {
                    uIAClickListElementItemByName["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchElementClassName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesearchElementAutomationId != null)
                {
                    uIAClickListElementItemByName["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchElementAutomationId);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesearchLocalizedControlType != null)
                {
                    uIAClickListElementItemByName["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchLocalizedControlType);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesearchSubTree != null)
                {
                    if (__workflow_uIAClickListElementItemByNamesearchSubTree != null)
                    {
                        uIAClickListElementItemByName["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchSubTree);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["SearchSubTree"] = true;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNameexpandFirst != null)
                {
                    if (__workflow_uIAClickListElementItemByNameexpandFirst != null)
                    {
                        uIAClickListElementItemByName["ExpandFirst"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNameexpandFirst);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["ExpandFirst"] = false;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamecollapseAfter != null)
                {
                    if (__workflow_uIAClickListElementItemByNamecollapseAfter != null)
                    {
                        uIAClickListElementItemByName["CollapseAfter"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamecollapseAfter);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["CollapseAfter"] = false;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNameitemName != null)
                {
                    uIAClickListElementItemByName["ItemName"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNameitemName);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesecondsBetweenExpandCollapse != null)
                {
                    uIAClickListElementItemByName["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesecondsBetweenExpandCollapse);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamematchIndex != null)
                {
                    if (__workflow_uIAClickListElementItemByNamematchIndex != null)
                    {
                        uIAClickListElementItemByName["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamematchIndex);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["MatchIndex"] = 1;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesearchFilter != null)
                {
                    uIAClickListElementItemByName["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesearchFilter);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamesortByColumn != null)
                {
                    uIAClickListElementItemByName["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamesortByColumn);
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamematchIndexAscending != null)
                {
                    if (__workflow_uIAClickListElementItemByNamematchIndexAscending != null)
                    {
                        uIAClickListElementItemByName["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamematchIndexAscending);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["MatchIndexAscending"] = true;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamemaxElementsToSearch != null)
                {
                    if (__workflow_uIAClickListElementItemByNamemaxElementsToSearch != null)
                    {
                        uIAClickListElementItemByName["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamemaxElementsToSearch);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["MaxElementsToSearch"] = 0;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAClickListElementItemByNamemaxRelativeSearchDepth != null)
                    {
                        uIAClickListElementItemByName["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamemaxRelativeSearchDepth);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["MaxRelativeSearchDepth"] = 0;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNamemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAClickListElementItemByNamemaxChildElementsToSearchPerNode != null)
                    {
                        uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNamemaxChildElementsToSearchPerNode);
                        uIAClickListElementItemByNamepropCount++;
                    }

                    uIAClickListElementItemByNamepropCount++;
                }
                else
                {
                    uIAClickListElementItemByName["MaxChildElementsToSearchPerNode"] = 0;
                    uIAClickListElementItemByNamepropCount++;
                }

                if (__workflow_uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAClickListElementItemByName["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNameelementLocalizedControlTypesNotToTraverse);
                    uIAClickListElementItemByNamepropCount++;
                }

                uIAClickListElementItemByNamepropCount++;
                uIAClickListElementItemByName["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByNameworkflow);
                if (uIAClickListElementItemByNamepropCount > 0)
                {
                    callPayload.Body = uIAClickListElementItemByName;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAClickListElementItemByIndex(Expression<Func<int>> uIAClickListElementItemByIndexparentWindowHandle, Expression<Func<string>> uIAClickListElementItemByIndexworkflow, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementName = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementClassName = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchElementAutomationId = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchLocalizedControlType = null, Expression<Func<bool>> uIAClickListElementItemByIndexsearchSubTree = null, Expression<Func<bool>> uIAClickListElementItemByIndexexpandFirst = null, Expression<Func<bool>> uIAClickListElementItemByIndexcollapseAfter = null, Expression<Func<int>> uIAClickListElementItemByIndexitemIndex = null, Expression<Func<double>> uIAClickListElementItemByIndexsecondsBetweenExpandCollapse = null, Expression<Func<int>> uIAClickListElementItemByIndexmatchIndex = null, Expression<Func<string>> uIAClickListElementItemByIndexsearchFilter = null, Expression<Func<string>> uIAClickListElementItemByIndexsortByColumn = null, Expression<Func<bool>> uIAClickListElementItemByIndexmatchIndexAscending = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxElementsToSearch = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxRelativeSearchDepth = null, Expression<Func<int>> uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAClickListElementItemByIndexparentWindowHandle = WorkflowExpression.Compile(uIAClickListElementItemByIndexparentWindowHandle, nameof(uIAClickListElementItemByIndexparentWindowHandle), required: true);
            var __workflow_uIAClickListElementItemByIndexworkflow = WorkflowExpression.Compile(uIAClickListElementItemByIndexworkflow, nameof(uIAClickListElementItemByIndexworkflow), required: true);
            var __workflow_uIAClickListElementItemByIndexsearchElementName = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchElementName, nameof(uIAClickListElementItemByIndexsearchElementName), required: false);
            var __workflow_uIAClickListElementItemByIndexsearchElementClassName = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchElementClassName, nameof(uIAClickListElementItemByIndexsearchElementClassName), required: false);
            var __workflow_uIAClickListElementItemByIndexsearchElementAutomationId = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchElementAutomationId, nameof(uIAClickListElementItemByIndexsearchElementAutomationId), required: false);
            var __workflow_uIAClickListElementItemByIndexsearchLocalizedControlType = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchLocalizedControlType, nameof(uIAClickListElementItemByIndexsearchLocalizedControlType), required: false);
            var __workflow_uIAClickListElementItemByIndexsearchSubTree = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchSubTree, nameof(uIAClickListElementItemByIndexsearchSubTree), required: false);
            var __workflow_uIAClickListElementItemByIndexexpandFirst = WorkflowExpression.Compile(uIAClickListElementItemByIndexexpandFirst, nameof(uIAClickListElementItemByIndexexpandFirst), required: false);
            var __workflow_uIAClickListElementItemByIndexcollapseAfter = WorkflowExpression.Compile(uIAClickListElementItemByIndexcollapseAfter, nameof(uIAClickListElementItemByIndexcollapseAfter), required: false);
            var __workflow_uIAClickListElementItemByIndexitemIndex = WorkflowExpression.Compile(uIAClickListElementItemByIndexitemIndex, nameof(uIAClickListElementItemByIndexitemIndex), required: false);
            var __workflow_uIAClickListElementItemByIndexsecondsBetweenExpandCollapse = WorkflowExpression.Compile(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse, nameof(uIAClickListElementItemByIndexsecondsBetweenExpandCollapse), required: false);
            var __workflow_uIAClickListElementItemByIndexmatchIndex = WorkflowExpression.Compile(uIAClickListElementItemByIndexmatchIndex, nameof(uIAClickListElementItemByIndexmatchIndex), required: false);
            var __workflow_uIAClickListElementItemByIndexsearchFilter = WorkflowExpression.Compile(uIAClickListElementItemByIndexsearchFilter, nameof(uIAClickListElementItemByIndexsearchFilter), required: false);
            var __workflow_uIAClickListElementItemByIndexsortByColumn = WorkflowExpression.Compile(uIAClickListElementItemByIndexsortByColumn, nameof(uIAClickListElementItemByIndexsortByColumn), required: false);
            var __workflow_uIAClickListElementItemByIndexmatchIndexAscending = WorkflowExpression.Compile(uIAClickListElementItemByIndexmatchIndexAscending, nameof(uIAClickListElementItemByIndexmatchIndexAscending), required: false);
            var __workflow_uIAClickListElementItemByIndexmaxElementsToSearch = WorkflowExpression.Compile(uIAClickListElementItemByIndexmaxElementsToSearch, nameof(uIAClickListElementItemByIndexmaxElementsToSearch), required: false);
            var __workflow_uIAClickListElementItemByIndexmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAClickListElementItemByIndexmaxRelativeSearchDepth, nameof(uIAClickListElementItemByIndexmaxRelativeSearchDepth), required: false);
            var __workflow_uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode, nameof(uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse, nameof(uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/ClickListElementItemByIndex";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAClickListElementItemByIndex = new JObject();
                var uIAClickListElementItemByIndexpropCount = 0;
                uIAClickListElementItemByIndexpropCount++;
                uIAClickListElementItemByIndex["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexparentWindowHandle);
                if (__workflow_uIAClickListElementItemByIndexsearchElementName != null)
                {
                    uIAClickListElementItemByIndex["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchElementName);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsearchElementClassName != null)
                {
                    uIAClickListElementItemByIndex["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchElementClassName);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsearchElementAutomationId != null)
                {
                    uIAClickListElementItemByIndex["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchElementAutomationId);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsearchLocalizedControlType != null)
                {
                    uIAClickListElementItemByIndex["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchLocalizedControlType);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsearchSubTree != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexsearchSubTree != null)
                    {
                        uIAClickListElementItemByIndex["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchSubTree);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["SearchSubTree"] = true;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexexpandFirst != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexexpandFirst != null)
                    {
                        uIAClickListElementItemByIndex["ExpandFirst"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexexpandFirst);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["ExpandFirst"] = false;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexcollapseAfter != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexcollapseAfter != null)
                    {
                        uIAClickListElementItemByIndex["CollapseAfter"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexcollapseAfter);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["CollapseAfter"] = false;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexitemIndex != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexitemIndex != null)
                    {
                        uIAClickListElementItemByIndex["ItemIndex"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexitemIndex);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["ItemIndex"] = 1;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsecondsBetweenExpandCollapse != null)
                {
                    uIAClickListElementItemByIndex["SecondsBetweenExpandCollapse"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsecondsBetweenExpandCollapse);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexmatchIndex != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexmatchIndex != null)
                    {
                        uIAClickListElementItemByIndex["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexmatchIndex);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["MatchIndex"] = 1;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsearchFilter != null)
                {
                    uIAClickListElementItemByIndex["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsearchFilter);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexsortByColumn != null)
                {
                    uIAClickListElementItemByIndex["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexsortByColumn);
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexmatchIndexAscending != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexmatchIndexAscending != null)
                    {
                        uIAClickListElementItemByIndex["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexmatchIndexAscending);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["MatchIndexAscending"] = true;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexmaxElementsToSearch != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexmaxElementsToSearch != null)
                    {
                        uIAClickListElementItemByIndex["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexmaxElementsToSearch);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["MaxElementsToSearch"] = 0;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexmaxRelativeSearchDepth != null)
                    {
                        uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexmaxRelativeSearchDepth);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["MaxRelativeSearchDepth"] = 0;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode != null)
                    {
                        uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexmaxChildElementsToSearchPerNode);
                        uIAClickListElementItemByIndexpropCount++;
                    }

                    uIAClickListElementItemByIndexpropCount++;
                }
                else
                {
                    uIAClickListElementItemByIndex["MaxChildElementsToSearchPerNode"] = 0;
                    uIAClickListElementItemByIndexpropCount++;
                }

                if (__workflow_uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAClickListElementItemByIndex["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexelementLocalizedControlTypesNotToTraverse);
                    uIAClickListElementItemByIndexpropCount++;
                }

                uIAClickListElementItemByIndexpropCount++;
                uIAClickListElementItemByIndex["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAClickListElementItemByIndexworkflow);
                if (uIAClickListElementItemByIndexpropCount > 0)
                {
                    callPayload.Body = uIAClickListElementItemByIndex;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetElementToNumericValue(Expression<Func<int>> uIASetElementToNumericValueparentWindowHandle, Expression<Func<int>> uIASetElementToNumericValuenewValue, Expression<Func<string>> uIASetElementToNumericValueworkflow, Expression<Func<string>> uIASetElementToNumericValuesearchElementName = null, Expression<Func<string>> uIASetElementToNumericValuesearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericValuesearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericValuesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericValuesearchSubTree = null, Expression<Func<int>> uIASetElementToNumericValuematchIndex = null, Expression<Func<string>> uIASetElementToNumericValuesearchFilter = null, Expression<Func<string>> uIASetElementToNumericValuesortByColumn = null, Expression<Func<bool>> uIASetElementToNumericValuematchIndexAscending = null, Expression<Func<int>> uIASetElementToNumericValuemaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIASetElementToNumericValueraiseExceptionIfInputValidationFails = null, Expression<Func<bool>> uIASetElementToNumericValuetryValuePattern = null, Expression<Func<bool>> uIASetElementToNumericValuetryLegacyPattern = null)
        {
            var __workflow_uIASetElementToNumericValueparentWindowHandle = WorkflowExpression.Compile(uIASetElementToNumericValueparentWindowHandle, nameof(uIASetElementToNumericValueparentWindowHandle), required: true);
            var __workflow_uIASetElementToNumericValuenewValue = WorkflowExpression.Compile(uIASetElementToNumericValuenewValue, nameof(uIASetElementToNumericValuenewValue), required: true);
            var __workflow_uIASetElementToNumericValueworkflow = WorkflowExpression.Compile(uIASetElementToNumericValueworkflow, nameof(uIASetElementToNumericValueworkflow), required: true);
            var __workflow_uIASetElementToNumericValuesearchElementName = WorkflowExpression.Compile(uIASetElementToNumericValuesearchElementName, nameof(uIASetElementToNumericValuesearchElementName), required: false);
            var __workflow_uIASetElementToNumericValuesearchElementClassName = WorkflowExpression.Compile(uIASetElementToNumericValuesearchElementClassName, nameof(uIASetElementToNumericValuesearchElementClassName), required: false);
            var __workflow_uIASetElementToNumericValuesearchElementAutomationId = WorkflowExpression.Compile(uIASetElementToNumericValuesearchElementAutomationId, nameof(uIASetElementToNumericValuesearchElementAutomationId), required: false);
            var __workflow_uIASetElementToNumericValuesearchLocalizedControlType = WorkflowExpression.Compile(uIASetElementToNumericValuesearchLocalizedControlType, nameof(uIASetElementToNumericValuesearchLocalizedControlType), required: false);
            var __workflow_uIASetElementToNumericValuesearchSubTree = WorkflowExpression.Compile(uIASetElementToNumericValuesearchSubTree, nameof(uIASetElementToNumericValuesearchSubTree), required: false);
            var __workflow_uIASetElementToNumericValuematchIndex = WorkflowExpression.Compile(uIASetElementToNumericValuematchIndex, nameof(uIASetElementToNumericValuematchIndex), required: false);
            var __workflow_uIASetElementToNumericValuesearchFilter = WorkflowExpression.Compile(uIASetElementToNumericValuesearchFilter, nameof(uIASetElementToNumericValuesearchFilter), required: false);
            var __workflow_uIASetElementToNumericValuesortByColumn = WorkflowExpression.Compile(uIASetElementToNumericValuesortByColumn, nameof(uIASetElementToNumericValuesortByColumn), required: false);
            var __workflow_uIASetElementToNumericValuematchIndexAscending = WorkflowExpression.Compile(uIASetElementToNumericValuematchIndexAscending, nameof(uIASetElementToNumericValuematchIndexAscending), required: false);
            var __workflow_uIASetElementToNumericValuemaxElementsToSearch = WorkflowExpression.Compile(uIASetElementToNumericValuemaxElementsToSearch, nameof(uIASetElementToNumericValuemaxElementsToSearch), required: false);
            var __workflow_uIASetElementToNumericValuemaxRelativeSearchDepth = WorkflowExpression.Compile(uIASetElementToNumericValuemaxRelativeSearchDepth, nameof(uIASetElementToNumericValuemaxRelativeSearchDepth), required: false);
            var __workflow_uIASetElementToNumericValuemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIASetElementToNumericValuemaxChildElementsToSearchPerNode, nameof(uIASetElementToNumericValuemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse, nameof(uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIASetElementToNumericValueraiseExceptionIfInputValidationFails = WorkflowExpression.Compile(uIASetElementToNumericValueraiseExceptionIfInputValidationFails, nameof(uIASetElementToNumericValueraiseExceptionIfInputValidationFails), required: false);
            var __workflow_uIASetElementToNumericValuetryValuePattern = WorkflowExpression.Compile(uIASetElementToNumericValuetryValuePattern, nameof(uIASetElementToNumericValuetryValuePattern), required: false);
            var __workflow_uIASetElementToNumericValuetryLegacyPattern = WorkflowExpression.Compile(uIASetElementToNumericValuetryLegacyPattern, nameof(uIASetElementToNumericValuetryLegacyPattern), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementToNumericValue = new JObject();
                var uIASetElementToNumericValuepropCount = 0;
                uIASetElementToNumericValuepropCount++;
                uIASetElementToNumericValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValueparentWindowHandle);
                if (__workflow_uIASetElementToNumericValuesearchElementName != null)
                {
                    uIASetElementToNumericValue["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchElementName);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesearchElementClassName != null)
                {
                    uIASetElementToNumericValue["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchElementClassName);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesearchElementAutomationId != null)
                {
                    uIASetElementToNumericValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchElementAutomationId);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesearchLocalizedControlType != null)
                {
                    uIASetElementToNumericValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchLocalizedControlType);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesearchSubTree != null)
                {
                    if (__workflow_uIASetElementToNumericValuesearchSubTree != null)
                    {
                        uIASetElementToNumericValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchSubTree);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["SearchSubTree"] = true;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuematchIndex != null)
                {
                    if (__workflow_uIASetElementToNumericValuematchIndex != null)
                    {
                        uIASetElementToNumericValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuematchIndex);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["MatchIndex"] = 1;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesearchFilter != null)
                {
                    uIASetElementToNumericValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesearchFilter);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuesortByColumn != null)
                {
                    uIASetElementToNumericValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuesortByColumn);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuematchIndexAscending != null)
                {
                    if (__workflow_uIASetElementToNumericValuematchIndexAscending != null)
                    {
                        uIASetElementToNumericValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuematchIndexAscending);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["MatchIndexAscending"] = true;
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
                uIASetElementToNumericValue["NewValue"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuenewValue);
                if (__workflow_uIASetElementToNumericValuemaxElementsToSearch != null)
                {
                    if (__workflow_uIASetElementToNumericValuemaxElementsToSearch != null)
                    {
                        uIASetElementToNumericValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuemaxElementsToSearch);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["MaxElementsToSearch"] = 0;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIASetElementToNumericValuemaxRelativeSearchDepth != null)
                    {
                        uIASetElementToNumericValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuemaxRelativeSearchDepth);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["MaxRelativeSearchDepth"] = 0;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIASetElementToNumericValuemaxChildElementsToSearchPerNode != null)
                    {
                        uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuemaxChildElementsToSearchPerNode);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["MaxChildElementsToSearchPerNode"] = 0;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIASetElementToNumericValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValueelementLocalizedControlTypesNotToTraverse);
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                {
                    if (__workflow_uIASetElementToNumericValueraiseExceptionIfInputValidationFails != null)
                    {
                        uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValueraiseExceptionIfInputValidationFails);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["RaiseExceptionIfInputValidationFails"] = false;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuetryValuePattern != null)
                {
                    if (__workflow_uIASetElementToNumericValuetryValuePattern != null)
                    {
                        uIASetElementToNumericValue["TryValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuetryValuePattern);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["TryValuePattern"] = true;
                    uIASetElementToNumericValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericValuetryLegacyPattern != null)
                {
                    if (__workflow_uIASetElementToNumericValuetryLegacyPattern != null)
                    {
                        uIASetElementToNumericValue["TryLegacyPattern"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValuetryLegacyPattern);
                        uIASetElementToNumericValuepropCount++;
                    }

                    uIASetElementToNumericValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericValue["TryLegacyPattern"] = false;
                    uIASetElementToNumericValuepropCount++;
                }

                uIASetElementToNumericValuepropCount++;
                uIASetElementToNumericValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericValueworkflow);
                if (uIASetElementToNumericValuepropCount > 0)
                {
                    callPayload.Body = uIASetElementToNumericValue;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetElementToNumericRangeValue(Expression<Func<int>> uIASetElementToNumericRangeValueparentWindowHandle, Expression<Func<double>> uIASetElementToNumericRangeValuenewValue, Expression<Func<string>> uIASetElementToNumericRangeValueworkflow, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementName = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementClassName = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchElementAutomationId = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementToNumericRangeValuesearchSubTree = null, Expression<Func<int>> uIASetElementToNumericRangeValuematchIndex = null, Expression<Func<string>> uIASetElementToNumericRangeValuesearchFilter = null, Expression<Func<string>> uIASetElementToNumericRangeValuesortByColumn = null, Expression<Func<bool>> uIASetElementToNumericRangeValuematchIndexAscending = null, Expression<Func<bool>> uIASetElementToNumericRangeValuenewValueIsPercentage = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxElementsToSearch = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIASetElementToNumericRangeValueparentWindowHandle = WorkflowExpression.Compile(uIASetElementToNumericRangeValueparentWindowHandle, nameof(uIASetElementToNumericRangeValueparentWindowHandle), required: true);
            var __workflow_uIASetElementToNumericRangeValuenewValue = WorkflowExpression.Compile(uIASetElementToNumericRangeValuenewValue, nameof(uIASetElementToNumericRangeValuenewValue), required: true);
            var __workflow_uIASetElementToNumericRangeValueworkflow = WorkflowExpression.Compile(uIASetElementToNumericRangeValueworkflow, nameof(uIASetElementToNumericRangeValueworkflow), required: true);
            var __workflow_uIASetElementToNumericRangeValuesearchElementName = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchElementName, nameof(uIASetElementToNumericRangeValuesearchElementName), required: false);
            var __workflow_uIASetElementToNumericRangeValuesearchElementClassName = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchElementClassName, nameof(uIASetElementToNumericRangeValuesearchElementClassName), required: false);
            var __workflow_uIASetElementToNumericRangeValuesearchElementAutomationId = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchElementAutomationId, nameof(uIASetElementToNumericRangeValuesearchElementAutomationId), required: false);
            var __workflow_uIASetElementToNumericRangeValuesearchLocalizedControlType = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchLocalizedControlType, nameof(uIASetElementToNumericRangeValuesearchLocalizedControlType), required: false);
            var __workflow_uIASetElementToNumericRangeValuesearchSubTree = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchSubTree, nameof(uIASetElementToNumericRangeValuesearchSubTree), required: false);
            var __workflow_uIASetElementToNumericRangeValuematchIndex = WorkflowExpression.Compile(uIASetElementToNumericRangeValuematchIndex, nameof(uIASetElementToNumericRangeValuematchIndex), required: false);
            var __workflow_uIASetElementToNumericRangeValuesearchFilter = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesearchFilter, nameof(uIASetElementToNumericRangeValuesearchFilter), required: false);
            var __workflow_uIASetElementToNumericRangeValuesortByColumn = WorkflowExpression.Compile(uIASetElementToNumericRangeValuesortByColumn, nameof(uIASetElementToNumericRangeValuesortByColumn), required: false);
            var __workflow_uIASetElementToNumericRangeValuematchIndexAscending = WorkflowExpression.Compile(uIASetElementToNumericRangeValuematchIndexAscending, nameof(uIASetElementToNumericRangeValuematchIndexAscending), required: false);
            var __workflow_uIASetElementToNumericRangeValuenewValueIsPercentage = WorkflowExpression.Compile(uIASetElementToNumericRangeValuenewValueIsPercentage, nameof(uIASetElementToNumericRangeValuenewValueIsPercentage), required: false);
            var __workflow_uIASetElementToNumericRangeValuemaxElementsToSearch = WorkflowExpression.Compile(uIASetElementToNumericRangeValuemaxElementsToSearch, nameof(uIASetElementToNumericRangeValuemaxElementsToSearch), required: false);
            var __workflow_uIASetElementToNumericRangeValuemaxRelativeSearchDepth = WorkflowExpression.Compile(uIASetElementToNumericRangeValuemaxRelativeSearchDepth, nameof(uIASetElementToNumericRangeValuemaxRelativeSearchDepth), required: false);
            var __workflow_uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode, nameof(uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse, nameof(uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementToNumericRangeValue";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementToNumericRangeValue = new JObject();
                var uIASetElementToNumericRangeValuepropCount = 0;
                uIASetElementToNumericRangeValuepropCount++;
                uIASetElementToNumericRangeValue["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValueparentWindowHandle);
                if (__workflow_uIASetElementToNumericRangeValuesearchElementName != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchElementName);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesearchElementClassName != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchElementClassName);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesearchElementAutomationId != null)
                {
                    uIASetElementToNumericRangeValue["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchElementAutomationId);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesearchLocalizedControlType != null)
                {
                    uIASetElementToNumericRangeValue["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchLocalizedControlType);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesearchSubTree != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuesearchSubTree != null)
                    {
                        uIASetElementToNumericRangeValue["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchSubTree);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["SearchSubTree"] = true;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuematchIndex != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuematchIndex != null)
                    {
                        uIASetElementToNumericRangeValue["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuematchIndex);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["MatchIndex"] = 1;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesearchFilter != null)
                {
                    uIASetElementToNumericRangeValue["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesearchFilter);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuesortByColumn != null)
                {
                    uIASetElementToNumericRangeValue["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuesortByColumn);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuematchIndexAscending != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuematchIndexAscending != null)
                    {
                        uIASetElementToNumericRangeValue["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuematchIndexAscending);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["MatchIndexAscending"] = true;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
                uIASetElementToNumericRangeValue["NewValue"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuenewValue);
                if (__workflow_uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuenewValueIsPercentage != null)
                    {
                        uIASetElementToNumericRangeValue["NewValueIsPercentage"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuenewValueIsPercentage);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["NewValueIsPercentage"] = false;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuemaxElementsToSearch != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuemaxElementsToSearch != null)
                    {
                        uIASetElementToNumericRangeValue["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuemaxElementsToSearch);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["MaxElementsToSearch"] = 0;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuemaxRelativeSearchDepth != null)
                    {
                        uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuemaxRelativeSearchDepth);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["MaxRelativeSearchDepth"] = 0;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode != null)
                    {
                        uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValuemaxChildElementsToSearchPerNode);
                        uIASetElementToNumericRangeValuepropCount++;
                    }

                    uIASetElementToNumericRangeValuepropCount++;
                }
                else
                {
                    uIASetElementToNumericRangeValue["MaxChildElementsToSearchPerNode"] = 0;
                    uIASetElementToNumericRangeValuepropCount++;
                }

                if (__workflow_uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIASetElementToNumericRangeValue["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValueelementLocalizedControlTypesNotToTraverse);
                    uIASetElementToNumericRangeValuepropCount++;
                }

                uIASetElementToNumericRangeValuepropCount++;
                uIASetElementToNumericRangeValue["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetElementToNumericRangeValueworkflow);
                if (uIASetElementToNumericRangeValuepropCount > 0)
                {
                    callPayload.Body = uIASetElementToNumericRangeValue;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAResetAllElementHandles(Expression<Func<string>> uIAResetAllElementHandlesworkflow)
        {
            var __workflow_uIAResetAllElementHandlesworkflow = WorkflowExpression.Compile(uIAResetAllElementHandlesworkflow, nameof(uIAResetAllElementHandlesworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResetAllElementHandles";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAResetAllElementHandles = new JObject();
                var uIAResetAllElementHandlespropCount = 0;
                uIAResetAllElementHandlespropCount++;
                uIAResetAllElementHandles["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAResetAllElementHandlesworkflow);
                if (uIAResetAllElementHandlespropCount > 0)
                {
                    callPayload.Body = uIAResetAllElementHandles;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalPasswordInputIntoElement(Expression<Func<int>> uIAGlobalPasswordInputIntoElementparentWindowHandle, Expression<Func<string>> uIAGlobalPasswordInputIntoElementpasswordToInput, Expression<Func<string>> uIAGlobalPasswordInputIntoElementworkflow, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementsearchSubTree = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmatchIndex = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsearchFilter = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementsortByColumn = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementfocusElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementsendKeyEvents = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementinterval = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementdontInterpretSymbols = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalPasswordInputIntoElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementparentWindowHandle, nameof(uIAGlobalPasswordInputIntoElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalPasswordInputIntoElementpasswordToInput = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementpasswordToInput, nameof(uIAGlobalPasswordInputIntoElementpasswordToInput), required: true);
            var __workflow_uIAGlobalPasswordInputIntoElementworkflow = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementworkflow, nameof(uIAGlobalPasswordInputIntoElementworkflow), required: true);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchElementName = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchElementName, nameof(uIAGlobalPasswordInputIntoElementsearchElementName), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchElementClassName, nameof(uIAGlobalPasswordInputIntoElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchElementAutomationId, nameof(uIAGlobalPasswordInputIntoElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchLocalizedControlType, nameof(uIAGlobalPasswordInputIntoElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchSubTree, nameof(uIAGlobalPasswordInputIntoElementsearchSubTree), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementmatchIndex = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementmatchIndex, nameof(uIAGlobalPasswordInputIntoElementmatchIndex), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsearchFilter = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsearchFilter, nameof(uIAGlobalPasswordInputIntoElementsearchFilter), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsortByColumn = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsortByColumn, nameof(uIAGlobalPasswordInputIntoElementsortByColumn), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementmatchIndexAscending, nameof(uIAGlobalPasswordInputIntoElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementfocusElement = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementfocusElement, nameof(uIAGlobalPasswordInputIntoElementfocusElement), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement, nameof(uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete, nameof(uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementsendKeyEvents = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementsendKeyEvents, nameof(uIAGlobalPasswordInputIntoElementsendKeyEvents), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementinterval = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementinterval, nameof(uIAGlobalPasswordInputIntoElementinterval), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementdontInterpretSymbols = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementdontInterpretSymbols, nameof(uIAGlobalPasswordInputIntoElementdontInterpretSymbols), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword, nameof(uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementmaxElementsToSearch, nameof(uIAGlobalPasswordInputIntoElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth, nameof(uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalPasswordInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalPasswordInputIntoElement = new JObject();
                var uIAGlobalPasswordInputIntoElementpropCount = 0;
                uIAGlobalPasswordInputIntoElementpropCount++;
                uIAGlobalPasswordInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementparentWindowHandle);
                if (__workflow_uIAGlobalPasswordInputIntoElementsearchElementName != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchElementName);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsearchElementClassName != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchElementClassName);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsearchElementAutomationId != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchElementAutomationId);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsearchLocalizedControlType != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchLocalizedControlType);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementsearchSubTree != null)
                    {
                        uIAGlobalPasswordInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchSubTree);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["SearchSubTree"] = true;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementmatchIndex != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementmatchIndex);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["MatchIndex"] = 1;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsearchFilter != null)
                {
                    uIAGlobalPasswordInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsearchFilter);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementsortByColumn != null)
                {
                    uIAGlobalPasswordInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsortByColumn);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementmatchIndexAscending != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementmatchIndexAscending);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["MatchIndexAscending"] = true;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementfocusElement != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementfocusElement != null)
                    {
                        uIAGlobalPasswordInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementfocusElement);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["FocusElement"] = true;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement != null)
                    {
                        uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementglobalMouseClickOnElement);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["GlobalMouseClickOnElement"] = true;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementreplaceExistingValueUsingCTRLADelete);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
                uIAGlobalPasswordInputIntoElement["PasswordToInput"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementpasswordToInput);
                if (__workflow_uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementsendKeyEvents != null)
                    {
                        uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementsendKeyEvents);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["SendKeyEvents"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementinterval != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementinterval != null)
                    {
                        uIAGlobalPasswordInputIntoElement["Interval"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementinterval);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["Interval"] = 10;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementdontInterpretSymbols != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementdontInterpretSymbols != null)
                    {
                        uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementdontInterpretSymbols);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["DontInterpretSymbols"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword != null)
                    {
                        uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementpasswordContainsStoredPassword);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["PasswordContainsStoredPassword"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementmaxElementsToSearch != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementmaxElementsToSearch);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["MaxElementsToSearch"] = 0;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementmaxRelativeSearchDepth);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementmaxChildElementsToSearchPerNode);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalPasswordInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalPasswordInputIntoElementpropCount++;
                    }

                    uIAGlobalPasswordInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalPasswordInputIntoElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalPasswordInputIntoElementpropCount++;
                }

                uIAGlobalPasswordInputIntoElementpropCount++;
                uIAGlobalPasswordInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalPasswordInputIntoElementworkflow);
                if (uIAGlobalPasswordInputIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalPasswordInputIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIAGlobalTextInputIntoElement(Expression<Func<int>> uIAGlobalTextInputIntoElementparentWindowHandle, Expression<Func<string>> uIAGlobalTextInputIntoElementworkflow, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementClassName = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementsearchSubTree = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmatchIndex = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsearchFilter = null, Expression<Func<string>> uIAGlobalTextInputIntoElementsortByColumn = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementmatchIndexAscending = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementfocusElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementglobalMouseClickOnElement = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete = null, Expression<Func<string>> uIAGlobalTextInputIntoElementtextToInput = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementsendKeyEvents = null, Expression<Func<int>> uIAGlobalTextInputIntoElementinterval = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementdontInterpretSymbols = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<bool>> uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary = null)
        {
            var __workflow_uIAGlobalTextInputIntoElementparentWindowHandle = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementparentWindowHandle, nameof(uIAGlobalTextInputIntoElementparentWindowHandle), required: true);
            var __workflow_uIAGlobalTextInputIntoElementworkflow = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementworkflow, nameof(uIAGlobalTextInputIntoElementworkflow), required: true);
            var __workflow_uIAGlobalTextInputIntoElementsearchElementName = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchElementName, nameof(uIAGlobalTextInputIntoElementsearchElementName), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsearchElementClassName = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchElementClassName, nameof(uIAGlobalTextInputIntoElementsearchElementClassName), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchElementAutomationId, nameof(uIAGlobalTextInputIntoElementsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchLocalizedControlType, nameof(uIAGlobalTextInputIntoElementsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsearchSubTree = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchSubTree, nameof(uIAGlobalTextInputIntoElementsearchSubTree), required: false);
            var __workflow_uIAGlobalTextInputIntoElementmatchIndex = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementmatchIndex, nameof(uIAGlobalTextInputIntoElementmatchIndex), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsearchFilter = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsearchFilter, nameof(uIAGlobalTextInputIntoElementsearchFilter), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsortByColumn = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsortByColumn, nameof(uIAGlobalTextInputIntoElementsortByColumn), required: false);
            var __workflow_uIAGlobalTextInputIntoElementmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementmatchIndexAscending, nameof(uIAGlobalTextInputIntoElementmatchIndexAscending), required: false);
            var __workflow_uIAGlobalTextInputIntoElementfocusElement = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementfocusElement, nameof(uIAGlobalTextInputIntoElementfocusElement), required: false);
            var __workflow_uIAGlobalTextInputIntoElementglobalMouseClickOnElement = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementglobalMouseClickOnElement, nameof(uIAGlobalTextInputIntoElementglobalMouseClickOnElement), required: false);
            var __workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete, nameof(uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete), required: false);
            var __workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete, nameof(uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete), required: false);
            var __workflow_uIAGlobalTextInputIntoElementtextToInput = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementtextToInput, nameof(uIAGlobalTextInputIntoElementtextToInput), required: false);
            var __workflow_uIAGlobalTextInputIntoElementsendKeyEvents = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementsendKeyEvents, nameof(uIAGlobalTextInputIntoElementsendKeyEvents), required: false);
            var __workflow_uIAGlobalTextInputIntoElementinterval = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementinterval, nameof(uIAGlobalTextInputIntoElementinterval), required: false);
            var __workflow_uIAGlobalTextInputIntoElementdontInterpretSymbols = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementdontInterpretSymbols, nameof(uIAGlobalTextInputIntoElementdontInterpretSymbols), required: false);
            var __workflow_uIAGlobalTextInputIntoElementmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementmaxElementsToSearch, nameof(uIAGlobalTextInputIntoElementmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalTextInputIntoElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth, nameof(uIAGlobalTextInputIntoElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode, nameof(uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary = WorkflowExpression.Compile(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary, nameof(uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalTextInputIntoElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalTextInputIntoElement = new JObject();
                var uIAGlobalTextInputIntoElementpropCount = 0;
                uIAGlobalTextInputIntoElementpropCount++;
                uIAGlobalTextInputIntoElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementparentWindowHandle);
                if (__workflow_uIAGlobalTextInputIntoElementsearchElementName != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchElementName);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsearchElementClassName != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchElementClassName);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsearchElementAutomationId != null)
                {
                    uIAGlobalTextInputIntoElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchElementAutomationId);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsearchLocalizedControlType != null)
                {
                    uIAGlobalTextInputIntoElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchLocalizedControlType);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementsearchSubTree != null)
                    {
                        uIAGlobalTextInputIntoElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchSubTree);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["SearchSubTree"] = true;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementmatchIndex != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementmatchIndex != null)
                    {
                        uIAGlobalTextInputIntoElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementmatchIndex);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["MatchIndex"] = 1;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsearchFilter != null)
                {
                    uIAGlobalTextInputIntoElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsearchFilter);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsortByColumn != null)
                {
                    uIAGlobalTextInputIntoElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsortByColumn);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementmatchIndexAscending != null)
                    {
                        uIAGlobalTextInputIntoElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementmatchIndexAscending);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["MatchIndexAscending"] = true;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementfocusElement != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementfocusElement != null)
                    {
                        uIAGlobalTextInputIntoElement["FocusElement"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementfocusElement);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["FocusElement"] = true;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementglobalMouseClickOnElement != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementglobalMouseClickOnElement != null)
                    {
                        uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementglobalMouseClickOnElement);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["GlobalMouseClickOnElement"] = true;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete != null)
                    {
                        uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingDoubleClickDelete);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingDoubleClickDelete"] = false;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete != null)
                    {
                        uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementreplaceExistingValueUsingCTRLADelete);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["ReplaceExistingValueUsingCTRLADelete"] = false;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementtextToInput != null)
                {
                    uIAGlobalTextInputIntoElement["TextToInput"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementtextToInput);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementsendKeyEvents != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementsendKeyEvents != null)
                    {
                        uIAGlobalTextInputIntoElement["SendKeyEvents"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementsendKeyEvents);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["SendKeyEvents"] = false;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementinterval != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementinterval != null)
                    {
                        uIAGlobalTextInputIntoElement["Interval"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementinterval);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["Interval"] = 10;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementdontInterpretSymbols != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementdontInterpretSymbols != null)
                    {
                        uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementdontInterpretSymbols);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["DontInterpretSymbols"] = false;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementmaxElementsToSearch != null)
                    {
                        uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementmaxElementsToSearch);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["MaxElementsToSearch"] = 0;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementmaxRelativeSearchDepth);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementmaxChildElementsToSearchPerNode);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalTextInputIntoElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                if (__workflow_uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                {
                    if (__workflow_uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary != null)
                    {
                        uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementvalidateClickablePointWithinElementBoundary);
                        uIAGlobalTextInputIntoElementpropCount++;
                    }

                    uIAGlobalTextInputIntoElementpropCount++;
                }
                else
                {
                    uIAGlobalTextInputIntoElement["ValidateClickablePointWithinElementBoundary"] = false;
                    uIAGlobalTextInputIntoElementpropCount++;
                }

                uIAGlobalTextInputIntoElementpropCount++;
                uIAGlobalTextInputIntoElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalTextInputIntoElementworkflow);
                if (uIAGlobalTextInputIntoElementpropCount > 0)
                {
                    callPayload.Body = uIAGlobalTextInputIntoElement;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration> UIAGetElementPropertiesAsList(Expression<Func<int>> uIAGetElementPropertiesAsListelementHandle, Expression<Func<string>> uIAGetElementPropertiesAsListworkflow)
        {
            var __workflow_uIAGetElementPropertiesAsListelementHandle = WorkflowExpression.Compile(uIAGetElementPropertiesAsListelementHandle, nameof(uIAGetElementPropertiesAsListelementHandle), required: true);
            var __workflow_uIAGetElementPropertiesAsListworkflow = WorkflowExpression.Compile(uIAGetElementPropertiesAsListworkflow, nameof(uIAGetElementPropertiesAsListworkflow), required: true);
            return new DeferredBodyAction<UIAGetElementPropertiesAsListResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPropertiesAsList";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementPropertiesAsList = new JObject();
                var uIAGetElementPropertiesAsListpropCount = 0;
                uIAGetElementPropertiesAsListpropCount++;
                uIAGetElementPropertiesAsList["ElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesAsListelementHandle);
                uIAGetElementPropertiesAsListpropCount++;
                uIAGetElementPropertiesAsList["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPropertiesAsListworkflow);
                if (uIAGetElementPropertiesAsListpropCount > 0)
                {
                    callPayload.Body = uIAGetElementPropertiesAsList;
                }

                return new ApiConnectionAction<UIAGetElementPropertiesAsListResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IWorkflowAction<ApiConnectionActionConfiguration> UIASetTransactionTimeout(Expression<Func<double>> uIASetTransactionTimeouttimeoutInSeconds, Expression<Func<string>> uIASetTransactionTimeoutworkflow)
        {
            var __workflow_uIASetTransactionTimeouttimeoutInSeconds = WorkflowExpression.Compile(uIASetTransactionTimeouttimeoutInSeconds, nameof(uIASetTransactionTimeouttimeoutInSeconds), required: true);
            var __workflow_uIASetTransactionTimeoutworkflow = WorkflowExpression.Compile(uIASetTransactionTimeoutworkflow, nameof(uIASetTransactionTimeoutworkflow), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetTransactionTimeout";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetTransactionTimeout = new JObject();
                var uIASetTransactionTimeoutpropCount = 0;
                uIASetTransactionTimeoutpropCount++;
                uIASetTransactionTimeout["TimeoutInSeconds"] = ExpressionConverter.ConvertO(__workflow_uIASetTransactionTimeouttimeoutInSeconds);
                uIASetTransactionTimeoutpropCount++;
                uIASetTransactionTimeout["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetTransactionTimeoutworkflow);
                if (uIASetTransactionTimeoutpropCount > 0)
                {
                    callPayload.Body = uIASetTransactionTimeout;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration> UIAGetElementAtCoordinates(Expression<Func<string>> uIAGetElementAtCoordinatesworkflow, Expression<Func<int>> uIAGetElementAtCoordinatesxCoord = null, Expression<Func<int>> uIAGetElementAtCoordinatesyCoord = null, Expression<Func<bool>> uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound = null)
        {
            var __workflow_uIAGetElementAtCoordinatesworkflow = WorkflowExpression.Compile(uIAGetElementAtCoordinatesworkflow, nameof(uIAGetElementAtCoordinatesworkflow), required: true);
            var __workflow_uIAGetElementAtCoordinatesxCoord = WorkflowExpression.Compile(uIAGetElementAtCoordinatesxCoord, nameof(uIAGetElementAtCoordinatesxCoord), required: false);
            var __workflow_uIAGetElementAtCoordinatesyCoord = WorkflowExpression.Compile(uIAGetElementAtCoordinatesyCoord, nameof(uIAGetElementAtCoordinatesyCoord), required: false);
            var __workflow_uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound = WorkflowExpression.Compile(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound, nameof(uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound), required: false);
            return new DeferredBodyAction<UIAGetElementAtCoordinatesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementAtCoordinates";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementAtCoordinates = new JObject();
                var uIAGetElementAtCoordinatespropCount = 0;
                if (__workflow_uIAGetElementAtCoordinatesxCoord != null)
                {
                    if (__workflow_uIAGetElementAtCoordinatesxCoord != null)
                    {
                        uIAGetElementAtCoordinates["XCoord"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementAtCoordinatesxCoord);
                        uIAGetElementAtCoordinatespropCount++;
                    }

                    uIAGetElementAtCoordinatespropCount++;
                }
                else
                {
                    uIAGetElementAtCoordinates["XCoord"] = 0;
                    uIAGetElementAtCoordinatespropCount++;
                }

                if (__workflow_uIAGetElementAtCoordinatesyCoord != null)
                {
                    if (__workflow_uIAGetElementAtCoordinatesyCoord != null)
                    {
                        uIAGetElementAtCoordinates["YCoord"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementAtCoordinatesyCoord);
                        uIAGetElementAtCoordinatespropCount++;
                    }

                    uIAGetElementAtCoordinatespropCount++;
                }
                else
                {
                    uIAGetElementAtCoordinates["YCoord"] = 0;
                    uIAGetElementAtCoordinatespropCount++;
                }

                if (__workflow_uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound != null)
                {
                    if (__workflow_uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound != null)
                    {
                        uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementAtCoordinatesraiseExceptionIfElementNotFound);
                        uIAGetElementAtCoordinatespropCount++;
                    }

                    uIAGetElementAtCoordinatespropCount++;
                }
                else
                {
                    uIAGetElementAtCoordinates["RaiseExceptionIfElementNotFound"] = false;
                    uIAGetElementAtCoordinatespropCount++;
                }

                uIAGetElementAtCoordinatespropCount++;
                uIAGetElementAtCoordinates["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementAtCoordinatesworkflow);
                if (uIAGetElementAtCoordinatespropCount > 0)
                {
                    callPayload.Body = uIAGetElementAtCoordinates;
                }

                return new ApiConnectionAction<UIAGetElementAtCoordinatesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration> UIAGetMultipleParentElementProperties(Expression<Func<int>> uIAGetMultipleParentElementPropertieselementHandle, Expression<Func<string>> uIAGetMultipleParentElementPropertiesworkflow, Expression<Func<int>> uIAGetMultipleParentElementPropertiesmaxParentsToProcess = null)
        {
            var __workflow_uIAGetMultipleParentElementPropertieselementHandle = WorkflowExpression.Compile(uIAGetMultipleParentElementPropertieselementHandle, nameof(uIAGetMultipleParentElementPropertieselementHandle), required: true);
            var __workflow_uIAGetMultipleParentElementPropertiesworkflow = WorkflowExpression.Compile(uIAGetMultipleParentElementPropertiesworkflow, nameof(uIAGetMultipleParentElementPropertiesworkflow), required: true);
            var __workflow_uIAGetMultipleParentElementPropertiesmaxParentsToProcess = WorkflowExpression.Compile(uIAGetMultipleParentElementPropertiesmaxParentsToProcess, nameof(uIAGetMultipleParentElementPropertiesmaxParentsToProcess), required: false);
            return new DeferredBodyAction<UIAGetMultipleParentElementPropertiesResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleParentElementProperties";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleParentElementProperties = new JObject();
                var uIAGetMultipleParentElementPropertiespropCount = 0;
                uIAGetMultipleParentElementPropertiespropCount++;
                uIAGetMultipleParentElementProperties["ElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleParentElementPropertieselementHandle);
                if (__workflow_uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                {
                    if (__workflow_uIAGetMultipleParentElementPropertiesmaxParentsToProcess != null)
                    {
                        uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleParentElementPropertiesmaxParentsToProcess);
                        uIAGetMultipleParentElementPropertiespropCount++;
                    }

                    uIAGetMultipleParentElementPropertiespropCount++;
                }
                else
                {
                    uIAGetMultipleParentElementProperties["MaxParentsToProcess"] = 50;
                    uIAGetMultipleParentElementPropertiespropCount++;
                }

                uIAGetMultipleParentElementPropertiespropCount++;
                uIAGetMultipleParentElementProperties["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleParentElementPropertiesworkflow);
                if (uIAGetMultipleParentElementPropertiespropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleParentElementProperties;
                }

                return new ApiConnectionAction<UIAGetMultipleParentElementPropertiesResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASearchForFirstParentElementResponse, ApiConnectionActionConfiguration> UIASearchForFirstParentElement(Expression<Func<int>> uIASearchForFirstParentElementelementHandle, Expression<Func<string>> uIASearchForFirstParentElementworkflow, Expression<Func<string>> uIASearchForFirstParentElementsearchParentLocalizedControlType = null, Expression<Func<int>> uIASearchForFirstParentElementsearchParentControlType = null, Expression<Func<int>> uIASearchForFirstParentElementmaxParentsToProcess = null, Expression<Func<bool>> uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound = null)
        {
            var __workflow_uIASearchForFirstParentElementelementHandle = WorkflowExpression.Compile(uIASearchForFirstParentElementelementHandle, nameof(uIASearchForFirstParentElementelementHandle), required: true);
            var __workflow_uIASearchForFirstParentElementworkflow = WorkflowExpression.Compile(uIASearchForFirstParentElementworkflow, nameof(uIASearchForFirstParentElementworkflow), required: true);
            var __workflow_uIASearchForFirstParentElementsearchParentLocalizedControlType = WorkflowExpression.Compile(uIASearchForFirstParentElementsearchParentLocalizedControlType, nameof(uIASearchForFirstParentElementsearchParentLocalizedControlType), required: false);
            var __workflow_uIASearchForFirstParentElementsearchParentControlType = WorkflowExpression.Compile(uIASearchForFirstParentElementsearchParentControlType, nameof(uIASearchForFirstParentElementsearchParentControlType), required: false);
            var __workflow_uIASearchForFirstParentElementmaxParentsToProcess = WorkflowExpression.Compile(uIASearchForFirstParentElementmaxParentsToProcess, nameof(uIASearchForFirstParentElementmaxParentsToProcess), required: false);
            var __workflow_uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound = WorkflowExpression.Compile(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound, nameof(uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound), required: false);
            return new DeferredBodyAction<UIASearchForFirstParentElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASearchForFirstParentElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASearchForFirstParentElement = new JObject();
                var uIASearchForFirstParentElementpropCount = 0;
                uIASearchForFirstParentElementpropCount++;
                uIASearchForFirstParentElement["ElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementelementHandle);
                if (__workflow_uIASearchForFirstParentElementsearchParentLocalizedControlType != null)
                {
                    uIASearchForFirstParentElement["SearchParentLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementsearchParentLocalizedControlType);
                    uIASearchForFirstParentElementpropCount++;
                }

                if (__workflow_uIASearchForFirstParentElementsearchParentControlType != null)
                {
                    uIASearchForFirstParentElement["SearchParentControlType"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementsearchParentControlType);
                    uIASearchForFirstParentElementpropCount++;
                }

                if (__workflow_uIASearchForFirstParentElementmaxParentsToProcess != null)
                {
                    if (__workflow_uIASearchForFirstParentElementmaxParentsToProcess != null)
                    {
                        uIASearchForFirstParentElement["MaxParentsToProcess"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementmaxParentsToProcess);
                        uIASearchForFirstParentElementpropCount++;
                    }

                    uIASearchForFirstParentElementpropCount++;
                }
                else
                {
                    uIASearchForFirstParentElement["MaxParentsToProcess"] = 50;
                    uIASearchForFirstParentElementpropCount++;
                }

                if (__workflow_uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound != null)
                {
                    if (__workflow_uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound != null)
                    {
                        uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementraiseExceptionIfParentElementNotFound);
                        uIASearchForFirstParentElementpropCount++;
                    }

                    uIASearchForFirstParentElementpropCount++;
                }
                else
                {
                    uIASearchForFirstParentElement["RaiseExceptionIfParentElementNotFound"] = false;
                    uIASearchForFirstParentElementpropCount++;
                }

                uIASearchForFirstParentElementpropCount++;
                uIASearchForFirstParentElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASearchForFirstParentElementworkflow);
                if (uIASearchForFirstParentElementpropCount > 0)
                {
                    callPayload.Body = uIASearchForFirstParentElement;
                }

                return new ApiConnectionAction<UIASearchForFirstParentElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration> UIAGetMultipleElementsAsTable(Expression<Func<string>> uIAGetMultipleElementsAsTableworkflow, Expression<Func<int>> uIAGetMultipleElementsAsTableparentWindowHandle = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementName = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementClassName = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchElementAutomationId = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchLocalizedControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablesearchSubTree = null, Expression<Func<int>> uIAGetMultipleElementsAsTablematchIndex = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchFilter = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesortByColumn = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablematchIndexAscending = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType = null, Expression<Func<string>> uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementControlType = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements = null, Expression<Func<int>> uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablefirstCellSubElementToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn = null, Expression<Func<int>> uIAGetMultipleElementsAsTablerequestedNumberOfColumns = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementTextValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTablecellSubElementNameValuePriority = null, Expression<Func<int>> uIAGetMultipleElementsAsTableminimumCellSubElementWidth = null, Expression<Func<int>> uIAGetMultipleElementsAsTableminimumCellSubElementHeight = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom = null, Expression<Func<bool>> uIAGetMultipleElementsAsTablereadTableAsThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId = null, Expression<Func<int>> uIAGetMultipleElementsAsTablesecondsToWaitForThread = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxElementsToSearch = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetMultipleElementsAsTableworkflow = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableworkflow, nameof(uIAGetMultipleElementsAsTableworkflow), required: true);
            var __workflow_uIAGetMultipleElementsAsTableparentWindowHandle = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableparentWindowHandle, nameof(uIAGetMultipleElementsAsTableparentWindowHandle), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchElementName = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchElementName, nameof(uIAGetMultipleElementsAsTablesearchElementName), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchElementClassName = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchElementClassName, nameof(uIAGetMultipleElementsAsTablesearchElementClassName), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchElementAutomationId = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchElementAutomationId, nameof(uIAGetMultipleElementsAsTablesearchElementAutomationId), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchLocalizedControlType = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchLocalizedControlType, nameof(uIAGetMultipleElementsAsTablesearchLocalizedControlType), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchSubTree = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchSubTree, nameof(uIAGetMultipleElementsAsTablesearchSubTree), required: false);
            var __workflow_uIAGetMultipleElementsAsTablematchIndex = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablematchIndex, nameof(uIAGetMultipleElementsAsTablematchIndex), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchFilter = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchFilter, nameof(uIAGetMultipleElementsAsTablesearchFilter), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesortByColumn = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesortByColumn, nameof(uIAGetMultipleElementsAsTablesortByColumn), required: false);
            var __workflow_uIAGetMultipleElementsAsTablematchIndexAscending = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablematchIndexAscending, nameof(uIAGetMultipleElementsAsTablematchIndexAscending), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType, nameof(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType, nameof(uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementControlType = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementControlType, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementControlType), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements, nameof(uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements), required: false);
            var __workflow_uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn, nameof(uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn), required: false);
            var __workflow_uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn, nameof(uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn), required: false);
            var __workflow_uIAGetMultipleElementsAsTablefirstCellSubElementToReturn = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn, nameof(uIAGetMultipleElementsAsTablefirstCellSubElementToReturn), required: false);
            var __workflow_uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn, nameof(uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn), required: false);
            var __workflow_uIAGetMultipleElementsAsTablerequestedNumberOfColumns = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablerequestedNumberOfColumns, nameof(uIAGetMultipleElementsAsTablerequestedNumberOfColumns), required: false);
            var __workflow_uIAGetMultipleElementsAsTablecellSubElementValuePriority = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablecellSubElementValuePriority, nameof(uIAGetMultipleElementsAsTablecellSubElementValuePriority), required: false);
            var __workflow_uIAGetMultipleElementsAsTablecellSubElementTextValuePriority = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority, nameof(uIAGetMultipleElementsAsTablecellSubElementTextValuePriority), required: false);
            var __workflow_uIAGetMultipleElementsAsTablecellSubElementNameValuePriority = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority, nameof(uIAGetMultipleElementsAsTablecellSubElementNameValuePriority), required: false);
            var __workflow_uIAGetMultipleElementsAsTableminimumCellSubElementWidth = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableminimumCellSubElementWidth, nameof(uIAGetMultipleElementsAsTableminimumCellSubElementWidth), required: false);
            var __workflow_uIAGetMultipleElementsAsTableminimumCellSubElementHeight = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableminimumCellSubElementHeight, nameof(uIAGetMultipleElementsAsTableminimumCellSubElementHeight), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom, nameof(uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom), required: false);
            var __workflow_uIAGetMultipleElementsAsTablereadTableAsThread = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablereadTableAsThread, nameof(uIAGetMultipleElementsAsTablereadTableAsThread), required: false);
            var __workflow_uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId, nameof(uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId), required: false);
            var __workflow_uIAGetMultipleElementsAsTablesecondsToWaitForThread = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablesecondsToWaitForThread, nameof(uIAGetMultipleElementsAsTablesecondsToWaitForThread), required: false);
            var __workflow_uIAGetMultipleElementsAsTablemaxElementsToSearch = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablemaxElementsToSearch, nameof(uIAGetMultipleElementsAsTablemaxElementsToSearch), required: false);
            var __workflow_uIAGetMultipleElementsAsTablemaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth, nameof(uIAGetMultipleElementsAsTablemaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode, nameof(uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse, nameof(uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetMultipleElementsAsTableResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetMultipleElementsAsTable";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetMultipleElementsAsTable = new JObject();
                var uIAGetMultipleElementsAsTablepropCount = 0;
                if (__workflow_uIAGetMultipleElementsAsTableparentWindowHandle != null)
                {
                    uIAGetMultipleElementsAsTable["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableparentWindowHandle);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchElementName != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchElementName);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchElementClassName != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchElementClassName);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchElementAutomationId != null)
                {
                    uIAGetMultipleElementsAsTable["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchElementAutomationId);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchLocalizedControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchSubTree != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchSubTree != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchSubTree);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchSubTree"] = true;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablematchIndex != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablematchIndex != null)
                    {
                        uIAGetMultipleElementsAsTable["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablematchIndex);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MatchIndex"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchFilter != null)
                {
                    uIAGetMultipleElementsAsTable["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchFilter);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesortByColumn != null)
                {
                    uIAGetMultipleElementsAsTable["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesortByColumn);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablematchIndexAscending != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablematchIndexAscending != null)
                    {
                        uIAGetMultipleElementsAsTable["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablematchIndexAscending);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MatchIndexAscending"] = true;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellHeaderSubElementControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellHeaderSubElementControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementLocalizedControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementControlType != null)
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementControlType);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchDescendantsForCellSubElements);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchDescendantsForCellSubElements"] = true;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn != null)
                    {
                        uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablefirstCellHeaderSubElementToReturn);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["FirstCellHeaderSubElementToReturn"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn != null)
                    {
                        uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablemaxCellHeaderSubElementsToReturn);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MaxCellHeaderSubElementsToReturn"] = 0;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablefirstCellSubElementToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablefirstCellSubElementToReturn != null)
                    {
                        uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablefirstCellSubElementToReturn);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["FirstCellSubElementToReturn"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn != null)
                    {
                        uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablemaxCellSubElementsToReturn);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MaxCellSubElementsToReturn"] = 0;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablerequestedNumberOfColumns != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablerequestedNumberOfColumns != null)
                    {
                        uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablerequestedNumberOfColumns);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["RequestedNumberOfColumns"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablecellSubElementValuePriority != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablecellSubElementValuePriority != null)
                    {
                        uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablecellSubElementValuePriority);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["CellSubElementValuePriority"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablecellSubElementTextValuePriority != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablecellSubElementTextValuePriority != null)
                    {
                        uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablecellSubElementTextValuePriority);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["CellSubElementTextValuePriority"] = 2;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablecellSubElementNameValuePriority != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablecellSubElementNameValuePriority != null)
                    {
                        uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablecellSubElementNameValuePriority);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["CellSubElementNameValuePriority"] = 3;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementWidth != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementWidth != null)
                    {
                        uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementWidth);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementWidth"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementHeight != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementHeight != null)
                    {
                        uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableminimumCellSubElementHeight);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MinimumCellSubElementHeight"] = 1;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxLeft);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxLeft"] = -99999;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxRight);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxRight"] = 99999;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxTop);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxTop"] = -99999;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom != null)
                    {
                        uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesearchCellSubElementBoundingBoxBottom);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SearchCellSubElementBoundingBoxBottom"] = 99999;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablereadTableAsThread != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablereadTableAsThread != null)
                    {
                        uIAGetMultipleElementsAsTable["ReadTableAsThread"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablereadTableAsThread);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["ReadTableAsThread"] = false;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId != null)
                {
                    uIAGetMultipleElementsAsTable["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableretrieveOutputDataFromThreadId);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablesecondsToWaitForThread != null)
                    {
                        uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablesecondsToWaitForThread);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["SecondsToWaitForThread"] = 90;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablemaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablemaxElementsToSearch != null)
                    {
                        uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablemaxElementsToSearch);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MaxElementsToSearch"] = 0;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablemaxRelativeSearchDepth != null)
                    {
                        uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablemaxRelativeSearchDepth);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MaxRelativeSearchDepth"] = 0;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTablemaxChildElementsToSearchPerNode);
                        uIAGetMultipleElementsAsTablepropCount++;
                    }

                    uIAGetMultipleElementsAsTablepropCount++;
                }
                else
                {
                    uIAGetMultipleElementsAsTable["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                if (__workflow_uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetMultipleElementsAsTable["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableelementLocalizedControlTypesNotToTraverse);
                    uIAGetMultipleElementsAsTablepropCount++;
                }

                uIAGetMultipleElementsAsTablepropCount++;
                uIAGetMultipleElementsAsTable["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetMultipleElementsAsTableworkflow);
                if (uIAGetMultipleElementsAsTablepropCount > 0)
                {
                    callPayload.Body = uIAGetMultipleElementsAsTable;
                }

                return new ApiConnectionAction<UIAGetMultipleElementsAsTableResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIASetElementScrollPercentageResponse, ApiConnectionActionConfiguration> UIASetElementScrollPercentage(Expression<Func<int>> uIASetElementScrollPercentageparentWindowHandle, Expression<Func<string>> uIASetElementScrollPercentageworkflow, Expression<Func<string>> uIASetElementScrollPercentagesearchElementName = null, Expression<Func<string>> uIASetElementScrollPercentagesearchElementClassName = null, Expression<Func<string>> uIASetElementScrollPercentagesearchElementAutomationId = null, Expression<Func<string>> uIASetElementScrollPercentagesearchLocalizedControlType = null, Expression<Func<bool>> uIASetElementScrollPercentagesearchSubTree = null, Expression<Func<int>> uIASetElementScrollPercentagematchIndex = null, Expression<Func<string>> uIASetElementScrollPercentagesearchFilter = null, Expression<Func<string>> uIASetElementScrollPercentagesortByColumn = null, Expression<Func<bool>> uIASetElementScrollPercentagematchIndexAscending = null, Expression<Func<double>> uIASetElementScrollPercentagehorizontalScrollPercentage = null, Expression<Func<double>> uIASetElementScrollPercentageverticalScrollPercentage = null, Expression<Func<bool>> uIASetElementScrollPercentagetryScrollPattern = null, Expression<Func<bool>> uIASetElementScrollPercentagetryRangeValuePattern = null, Expression<Func<bool>> uIASetElementScrollPercentagetryValuePattern = null, Expression<Func<int>> uIASetElementScrollPercentagemaxElementsToSearch = null, Expression<Func<int>> uIASetElementScrollPercentagemaxRelativeSearchDepth = null, Expression<Func<int>> uIASetElementScrollPercentagemaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIASetElementScrollPercentageparentWindowHandle = WorkflowExpression.Compile(uIASetElementScrollPercentageparentWindowHandle, nameof(uIASetElementScrollPercentageparentWindowHandle), required: true);
            var __workflow_uIASetElementScrollPercentageworkflow = WorkflowExpression.Compile(uIASetElementScrollPercentageworkflow, nameof(uIASetElementScrollPercentageworkflow), required: true);
            var __workflow_uIASetElementScrollPercentagesearchElementName = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchElementName, nameof(uIASetElementScrollPercentagesearchElementName), required: false);
            var __workflow_uIASetElementScrollPercentagesearchElementClassName = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchElementClassName, nameof(uIASetElementScrollPercentagesearchElementClassName), required: false);
            var __workflow_uIASetElementScrollPercentagesearchElementAutomationId = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchElementAutomationId, nameof(uIASetElementScrollPercentagesearchElementAutomationId), required: false);
            var __workflow_uIASetElementScrollPercentagesearchLocalizedControlType = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchLocalizedControlType, nameof(uIASetElementScrollPercentagesearchLocalizedControlType), required: false);
            var __workflow_uIASetElementScrollPercentagesearchSubTree = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchSubTree, nameof(uIASetElementScrollPercentagesearchSubTree), required: false);
            var __workflow_uIASetElementScrollPercentagematchIndex = WorkflowExpression.Compile(uIASetElementScrollPercentagematchIndex, nameof(uIASetElementScrollPercentagematchIndex), required: false);
            var __workflow_uIASetElementScrollPercentagesearchFilter = WorkflowExpression.Compile(uIASetElementScrollPercentagesearchFilter, nameof(uIASetElementScrollPercentagesearchFilter), required: false);
            var __workflow_uIASetElementScrollPercentagesortByColumn = WorkflowExpression.Compile(uIASetElementScrollPercentagesortByColumn, nameof(uIASetElementScrollPercentagesortByColumn), required: false);
            var __workflow_uIASetElementScrollPercentagematchIndexAscending = WorkflowExpression.Compile(uIASetElementScrollPercentagematchIndexAscending, nameof(uIASetElementScrollPercentagematchIndexAscending), required: false);
            var __workflow_uIASetElementScrollPercentagehorizontalScrollPercentage = WorkflowExpression.Compile(uIASetElementScrollPercentagehorizontalScrollPercentage, nameof(uIASetElementScrollPercentagehorizontalScrollPercentage), required: false);
            var __workflow_uIASetElementScrollPercentageverticalScrollPercentage = WorkflowExpression.Compile(uIASetElementScrollPercentageverticalScrollPercentage, nameof(uIASetElementScrollPercentageverticalScrollPercentage), required: false);
            var __workflow_uIASetElementScrollPercentagetryScrollPattern = WorkflowExpression.Compile(uIASetElementScrollPercentagetryScrollPattern, nameof(uIASetElementScrollPercentagetryScrollPattern), required: false);
            var __workflow_uIASetElementScrollPercentagetryRangeValuePattern = WorkflowExpression.Compile(uIASetElementScrollPercentagetryRangeValuePattern, nameof(uIASetElementScrollPercentagetryRangeValuePattern), required: false);
            var __workflow_uIASetElementScrollPercentagetryValuePattern = WorkflowExpression.Compile(uIASetElementScrollPercentagetryValuePattern, nameof(uIASetElementScrollPercentagetryValuePattern), required: false);
            var __workflow_uIASetElementScrollPercentagemaxElementsToSearch = WorkflowExpression.Compile(uIASetElementScrollPercentagemaxElementsToSearch, nameof(uIASetElementScrollPercentagemaxElementsToSearch), required: false);
            var __workflow_uIASetElementScrollPercentagemaxRelativeSearchDepth = WorkflowExpression.Compile(uIASetElementScrollPercentagemaxRelativeSearchDepth, nameof(uIASetElementScrollPercentagemaxRelativeSearchDepth), required: false);
            var __workflow_uIASetElementScrollPercentagemaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode, nameof(uIASetElementScrollPercentagemaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse, nameof(uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIASetElementScrollPercentageResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIASetElementScrollPercentage";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIASetElementScrollPercentage = new JObject();
                var uIASetElementScrollPercentagepropCount = 0;
                uIASetElementScrollPercentagepropCount++;
                uIASetElementScrollPercentage["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentageparentWindowHandle);
                if (__workflow_uIASetElementScrollPercentagesearchElementName != null)
                {
                    uIASetElementScrollPercentage["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchElementName);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesearchElementClassName != null)
                {
                    uIASetElementScrollPercentage["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchElementClassName);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesearchElementAutomationId != null)
                {
                    uIASetElementScrollPercentage["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchElementAutomationId);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesearchLocalizedControlType != null)
                {
                    uIASetElementScrollPercentage["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchLocalizedControlType);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesearchSubTree != null)
                {
                    if (__workflow_uIASetElementScrollPercentagesearchSubTree != null)
                    {
                        uIASetElementScrollPercentage["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchSubTree);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["SearchSubTree"] = true;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagematchIndex != null)
                {
                    if (__workflow_uIASetElementScrollPercentagematchIndex != null)
                    {
                        uIASetElementScrollPercentage["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagematchIndex);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["MatchIndex"] = 1;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesearchFilter != null)
                {
                    uIASetElementScrollPercentage["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesearchFilter);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagesortByColumn != null)
                {
                    uIASetElementScrollPercentage["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagesortByColumn);
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagematchIndexAscending != null)
                {
                    if (__workflow_uIASetElementScrollPercentagematchIndexAscending != null)
                    {
                        uIASetElementScrollPercentage["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagematchIndexAscending);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["MatchIndexAscending"] = true;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagehorizontalScrollPercentage != null)
                {
                    if (__workflow_uIASetElementScrollPercentagehorizontalScrollPercentage != null)
                    {
                        uIASetElementScrollPercentage["HorizontalScrollPercentage"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagehorizontalScrollPercentage);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["HorizontalScrollPercentage"] = -1;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentageverticalScrollPercentage != null)
                {
                    if (__workflow_uIASetElementScrollPercentageverticalScrollPercentage != null)
                    {
                        uIASetElementScrollPercentage["VerticalScrollPercentage"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentageverticalScrollPercentage);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["VerticalScrollPercentage"] = -1;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagetryScrollPattern != null)
                {
                    if (__workflow_uIASetElementScrollPercentagetryScrollPattern != null)
                    {
                        uIASetElementScrollPercentage["TryScrollPattern"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagetryScrollPattern);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["TryScrollPattern"] = true;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagetryRangeValuePattern != null)
                {
                    if (__workflow_uIASetElementScrollPercentagetryRangeValuePattern != null)
                    {
                        uIASetElementScrollPercentage["TryRangeValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagetryRangeValuePattern);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["TryRangeValuePattern"] = true;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagetryValuePattern != null)
                {
                    if (__workflow_uIASetElementScrollPercentagetryValuePattern != null)
                    {
                        uIASetElementScrollPercentage["TryValuePattern"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagetryValuePattern);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["TryValuePattern"] = true;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagemaxElementsToSearch != null)
                {
                    if (__workflow_uIASetElementScrollPercentagemaxElementsToSearch != null)
                    {
                        uIASetElementScrollPercentage["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagemaxElementsToSearch);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["MaxElementsToSearch"] = 0;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagemaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIASetElementScrollPercentagemaxRelativeSearchDepth != null)
                    {
                        uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagemaxRelativeSearchDepth);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["MaxRelativeSearchDepth"] = 0;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentagemaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIASetElementScrollPercentagemaxChildElementsToSearchPerNode != null)
                    {
                        uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentagemaxChildElementsToSearchPerNode);
                        uIASetElementScrollPercentagepropCount++;
                    }

                    uIASetElementScrollPercentagepropCount++;
                }
                else
                {
                    uIASetElementScrollPercentage["MaxChildElementsToSearchPerNode"] = 0;
                    uIASetElementScrollPercentagepropCount++;
                }

                if (__workflow_uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIASetElementScrollPercentage["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentageelementLocalizedControlTypesNotToTraverse);
                    uIASetElementScrollPercentagepropCount++;
                }

                uIASetElementScrollPercentagepropCount++;
                uIASetElementScrollPercentage["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIASetElementScrollPercentageworkflow);
                if (uIASetElementScrollPercentagepropCount > 0)
                {
                    callPayload.Body = uIASetElementScrollPercentage;
                }

                return new ApiConnectionAction<UIASetElementScrollPercentageResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UIAGetElementSearchColourRegion(Expression<Func<int>> uIAGetElementSearchColourRegionparentWindowHandle, Expression<Func<string>> uIAGetElementSearchColourRegionsearchColour, Expression<Func<int>> uIAGetElementSearchColourRegionmaxColourDeviation, Expression<Func<string>> uIAGetElementSearchColourRegionworkflow, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementName = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementClassName = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchElementAutomationId = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementSearchColourRegionsearchSubTree = null, Expression<Func<int>> uIAGetElementSearchColourRegionmatchIndex = null, Expression<Func<string>> uIAGetElementSearchColourRegionsearchFilter = null, Expression<Func<string>> uIAGetElementSearchColourRegionsortByColumn = null, Expression<Func<bool>> uIAGetElementSearchColourRegionmatchIndexAscending = null, Expression<Func<int>> uIAGetElementSearchColourRegionleftPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionrightPixelXOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegiontopPixelYOffset = null, Expression<Func<int>> uIAGetElementSearchColourRegionbottomPixelYOffset = null, Expression<Func<bool>> uIAGetElementSearchColourRegionhideAgent = null, Expression<Func<bool>> uIAGetElementSearchColourRegionreturnPhysicalCoordinates = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetElementSearchColourRegionparentWindowHandle = WorkflowExpression.Compile(uIAGetElementSearchColourRegionparentWindowHandle, nameof(uIAGetElementSearchColourRegionparentWindowHandle), required: true);
            var __workflow_uIAGetElementSearchColourRegionsearchColour = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchColour, nameof(uIAGetElementSearchColourRegionsearchColour), required: true);
            var __workflow_uIAGetElementSearchColourRegionmaxColourDeviation = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmaxColourDeviation, nameof(uIAGetElementSearchColourRegionmaxColourDeviation), required: true);
            var __workflow_uIAGetElementSearchColourRegionworkflow = WorkflowExpression.Compile(uIAGetElementSearchColourRegionworkflow, nameof(uIAGetElementSearchColourRegionworkflow), required: true);
            var __workflow_uIAGetElementSearchColourRegionsearchElementName = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchElementName, nameof(uIAGetElementSearchColourRegionsearchElementName), required: false);
            var __workflow_uIAGetElementSearchColourRegionsearchElementClassName = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchElementClassName, nameof(uIAGetElementSearchColourRegionsearchElementClassName), required: false);
            var __workflow_uIAGetElementSearchColourRegionsearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchElementAutomationId, nameof(uIAGetElementSearchColourRegionsearchElementAutomationId), required: false);
            var __workflow_uIAGetElementSearchColourRegionsearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchLocalizedControlType, nameof(uIAGetElementSearchColourRegionsearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementSearchColourRegionsearchSubTree = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchSubTree, nameof(uIAGetElementSearchColourRegionsearchSubTree), required: false);
            var __workflow_uIAGetElementSearchColourRegionmatchIndex = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmatchIndex, nameof(uIAGetElementSearchColourRegionmatchIndex), required: false);
            var __workflow_uIAGetElementSearchColourRegionsearchFilter = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsearchFilter, nameof(uIAGetElementSearchColourRegionsearchFilter), required: false);
            var __workflow_uIAGetElementSearchColourRegionsortByColumn = WorkflowExpression.Compile(uIAGetElementSearchColourRegionsortByColumn, nameof(uIAGetElementSearchColourRegionsortByColumn), required: false);
            var __workflow_uIAGetElementSearchColourRegionmatchIndexAscending = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmatchIndexAscending, nameof(uIAGetElementSearchColourRegionmatchIndexAscending), required: false);
            var __workflow_uIAGetElementSearchColourRegionleftPixelXOffset = WorkflowExpression.Compile(uIAGetElementSearchColourRegionleftPixelXOffset, nameof(uIAGetElementSearchColourRegionleftPixelXOffset), required: false);
            var __workflow_uIAGetElementSearchColourRegionrightPixelXOffset = WorkflowExpression.Compile(uIAGetElementSearchColourRegionrightPixelXOffset, nameof(uIAGetElementSearchColourRegionrightPixelXOffset), required: false);
            var __workflow_uIAGetElementSearchColourRegiontopPixelYOffset = WorkflowExpression.Compile(uIAGetElementSearchColourRegiontopPixelYOffset, nameof(uIAGetElementSearchColourRegiontopPixelYOffset), required: false);
            var __workflow_uIAGetElementSearchColourRegionbottomPixelYOffset = WorkflowExpression.Compile(uIAGetElementSearchColourRegionbottomPixelYOffset, nameof(uIAGetElementSearchColourRegionbottomPixelYOffset), required: false);
            var __workflow_uIAGetElementSearchColourRegionhideAgent = WorkflowExpression.Compile(uIAGetElementSearchColourRegionhideAgent, nameof(uIAGetElementSearchColourRegionhideAgent), required: false);
            var __workflow_uIAGetElementSearchColourRegionreturnPhysicalCoordinates = WorkflowExpression.Compile(uIAGetElementSearchColourRegionreturnPhysicalCoordinates, nameof(uIAGetElementSearchColourRegionreturnPhysicalCoordinates), required: false);
            var __workflow_uIAGetElementSearchColourRegionmaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmaxElementsToSearch, nameof(uIAGetElementSearchColourRegionmaxElementsToSearch), required: false);
            var __workflow_uIAGetElementSearchColourRegionmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmaxRelativeSearchDepth, nameof(uIAGetElementSearchColourRegionmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode, nameof(uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementSearchColourRegion = new JObject();
                var uIAGetElementSearchColourRegionpropCount = 0;
                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionparentWindowHandle);
                if (__workflow_uIAGetElementSearchColourRegionsearchElementName != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchElementName);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsearchElementClassName != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchElementClassName);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsearchElementAutomationId != null)
                {
                    uIAGetElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchElementAutomationId);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsearchLocalizedControlType != null)
                {
                    uIAGetElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchLocalizedControlType);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsearchSubTree != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionsearchSubTree != null)
                    {
                        uIAGetElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchSubTree);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["SearchSubTree"] = true;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionmatchIndex != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionmatchIndex != null)
                    {
                        uIAGetElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmatchIndex);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["MatchIndex"] = 1;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsearchFilter != null)
                {
                    uIAGetElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchFilter);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionsortByColumn != null)
                {
                    uIAGetElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsortByColumn);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionmatchIndexAscending != null)
                    {
                        uIAGetElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmatchIndexAscending);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["MatchIndexAscending"] = true;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionsearchColour);
                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmaxColourDeviation);
                if (__workflow_uIAGetElementSearchColourRegionleftPixelXOffset != null)
                {
                    uIAGetElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionleftPixelXOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionrightPixelXOffset != null)
                {
                    uIAGetElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionrightPixelXOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegiontopPixelYOffset != null)
                {
                    uIAGetElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegiontopPixelYOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionbottomPixelYOffset != null)
                {
                    uIAGetElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionbottomPixelYOffset);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionhideAgent != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionhideAgent != null)
                    {
                        uIAGetElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionhideAgent);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["HideAgent"] = true;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionreturnPhysicalCoordinates != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionreturnPhysicalCoordinates != null)
                    {
                        uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionreturnPhysicalCoordinates);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["ReturnPhysicalCoordinates"] = false;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionmaxElementsToSearch != null)
                    {
                        uIAGetElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmaxElementsToSearch);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["MaxElementsToSearch"] = 0;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionmaxRelativeSearchDepth != null)
                    {
                        uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmaxRelativeSearchDepth);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionmaxChildElementsToSearchPerNode);
                        uIAGetElementSearchColourRegionpropCount++;
                    }

                    uIAGetElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGetElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                    uIAGetElementSearchColourRegionpropCount++;
                }

                uIAGetElementSearchColourRegionpropCount++;
                uIAGetElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementSearchColourRegionworkflow);
                if (uIAGetElementSearchColourRegionpropCount > 0)
                {
                    callPayload.Body = uIAGetElementSearchColourRegion;
                }

                return new ApiConnectionAction<UIAGetElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration> UIAGlobalMouseClickElementSearchColourRegion(Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchColour, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionworkflow, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionsearchSubTree = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmatchIndex = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsearchFilter = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionsortByColumn = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput>> uIAGlobalMouseClickElementSearchColourRegionmouseButton = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionclickOffsetX = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionclickOffsetY = null, Expression<Func<uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput>> uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds = null, Expression<Func<bool>> uIAGlobalMouseClickElementSearchColourRegionhideAgent = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle, nameof(uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle), required: true);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchColour = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchColour, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchColour), required: true);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation, nameof(uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation), required: true);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionworkflow = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionworkflow, nameof(uIAGlobalMouseClickElementSearchColourRegionworkflow), required: true);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementName = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchElementName, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchElementName), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchSubTree = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchSubTree), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndex = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmatchIndex, nameof(uIAGlobalMouseClickElementSearchColourRegionmatchIndex), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsearchFilter = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsearchFilter, nameof(uIAGlobalMouseClickElementSearchColourRegionsearchFilter), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionsortByColumn = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionsortByColumn, nameof(uIAGlobalMouseClickElementSearchColourRegionsortByColumn), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending, nameof(uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset, nameof(uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset, nameof(uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset, nameof(uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset, nameof(uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmouseButton = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmouseButton, nameof(uIAGlobalMouseClickElementSearchColourRegionmouseButton), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetX = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX, nameof(uIAGlobalMouseClickElementSearchColourRegionclickOffsetX), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetY = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY, nameof(uIAGlobalMouseClickElementSearchColourRegionclickOffsetY), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo, nameof(uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds, nameof(uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionhideAgent = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionhideAgent, nameof(uIAGlobalMouseClickElementSearchColourRegionhideAgent), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch, nameof(uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth, nameof(uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode, nameof(uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse, nameof(uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGlobalMouseClickElementSearchColourRegionResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGlobalMouseClickElementSearchColourRegion";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGlobalMouseClickElementSearchColourRegion = new JObject();
                var uIAGlobalMouseClickElementSearchColourRegionpropCount = 0;
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionparentWindowHandle);
                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementName != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementName);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementClassName);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchElementAutomationId);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchLocalizedControlType);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchSubTree != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchSubTree);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchSubTree"] = true;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndex != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndex != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndex);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndex"] = 1;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchFilter != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchFilter);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionsortByColumn != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsortByColumn);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmatchIndexAscending);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MatchIndexAscending"] = true;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["SearchColour"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionsearchColour);
                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["MaxColourDeviation"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxColourDeviation);
                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["LeftPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionleftPixelXOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["RightPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionrightPixelXOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["TopPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegiontopPixelYOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["BottomPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionbottomPixelYOffset);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmouseButton != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmouseButton);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MouseButton"] = "Left";
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetX != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetX != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetX);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetX"] = 0;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetY != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetY != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionclickOffsetY);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["ClickOffsetY"] = 0;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeTo);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["OffsetRelativeTo"] = "Center";
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegiondelayInMilliseconds);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["DelayInMilliseconds"] = 10;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionhideAgent != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionhideAgent != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionhideAgent);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["HideAgent"] = true;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxElementsToSearch);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxElementsToSearch"] = 0;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxRelativeSearchDepth);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxRelativeSearchDepth"] = 0;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionmaxChildElementsToSearchPerNode);
                        uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                    }

                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }
                else
                {
                    uIAGlobalMouseClickElementSearchColourRegion["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                if (__workflow_uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGlobalMouseClickElementSearchColourRegion["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionelementLocalizedControlTypesNotToTraverse);
                    uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                }

                uIAGlobalMouseClickElementSearchColourRegionpropCount++;
                uIAGlobalMouseClickElementSearchColourRegion["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGlobalMouseClickElementSearchColourRegionworkflow);
                if (uIAGlobalMouseClickElementSearchColourRegionpropCount > 0)
                {
                    callPayload.Body = uIAGlobalMouseClickElementSearchColourRegion;
                }

                return new ApiConnectionAction<UIAGlobalMouseClickElementSearchColourRegionResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetWin32WindowsResponse, ApiConnectionActionConfiguration> UIAGetWin32Windows(Expression<Func<string>> uIAGetWin32Windowsworkflow, Expression<Func<string>> uIAGetWin32WindowssearchClassName = null, Expression<Func<string>> uIAGetWin32WindowssearchWindowTitle = null, Expression<Func<bool>> uIAGetWin32WindowstopLevelWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowsvisibleWindowsOnly = null, Expression<Func<bool>> uIAGetWin32WindowswindowsWithTitlebarOnly = null, Expression<Func<bool>> uIAGetWin32WindowswindowsWithTitleOnly = null, Expression<Func<bool>> uIAGetWin32WindowsignoreTransparentWindows = null, Expression<Func<int>> uIAGetWin32WindowssearchProcessId = null, Expression<Func<string>> uIAGetWin32WindowssearchFilter = null, Expression<Func<string>> uIAGetWin32WindowssortByColumn = null, Expression<Func<bool>> uIAGetWin32WindowsmatchIndexAscending = null, Expression<Func<bool>> uIAGetWin32WindowsreturnElementHandle = null, Expression<Func<int>> uIAGetWin32WindowsfirstItemToReturn = null, Expression<Func<int>> uIAGetWin32WindowsmaxItemsToReturn = null)
        {
            var __workflow_uIAGetWin32Windowsworkflow = WorkflowExpression.Compile(uIAGetWin32Windowsworkflow, nameof(uIAGetWin32Windowsworkflow), required: true);
            var __workflow_uIAGetWin32WindowssearchClassName = WorkflowExpression.Compile(uIAGetWin32WindowssearchClassName, nameof(uIAGetWin32WindowssearchClassName), required: false);
            var __workflow_uIAGetWin32WindowssearchWindowTitle = WorkflowExpression.Compile(uIAGetWin32WindowssearchWindowTitle, nameof(uIAGetWin32WindowssearchWindowTitle), required: false);
            var __workflow_uIAGetWin32WindowstopLevelWindowsOnly = WorkflowExpression.Compile(uIAGetWin32WindowstopLevelWindowsOnly, nameof(uIAGetWin32WindowstopLevelWindowsOnly), required: false);
            var __workflow_uIAGetWin32WindowsvisibleWindowsOnly = WorkflowExpression.Compile(uIAGetWin32WindowsvisibleWindowsOnly, nameof(uIAGetWin32WindowsvisibleWindowsOnly), required: false);
            var __workflow_uIAGetWin32WindowswindowsWithTitlebarOnly = WorkflowExpression.Compile(uIAGetWin32WindowswindowsWithTitlebarOnly, nameof(uIAGetWin32WindowswindowsWithTitlebarOnly), required: false);
            var __workflow_uIAGetWin32WindowswindowsWithTitleOnly = WorkflowExpression.Compile(uIAGetWin32WindowswindowsWithTitleOnly, nameof(uIAGetWin32WindowswindowsWithTitleOnly), required: false);
            var __workflow_uIAGetWin32WindowsignoreTransparentWindows = WorkflowExpression.Compile(uIAGetWin32WindowsignoreTransparentWindows, nameof(uIAGetWin32WindowsignoreTransparentWindows), required: false);
            var __workflow_uIAGetWin32WindowssearchProcessId = WorkflowExpression.Compile(uIAGetWin32WindowssearchProcessId, nameof(uIAGetWin32WindowssearchProcessId), required: false);
            var __workflow_uIAGetWin32WindowssearchFilter = WorkflowExpression.Compile(uIAGetWin32WindowssearchFilter, nameof(uIAGetWin32WindowssearchFilter), required: false);
            var __workflow_uIAGetWin32WindowssortByColumn = WorkflowExpression.Compile(uIAGetWin32WindowssortByColumn, nameof(uIAGetWin32WindowssortByColumn), required: false);
            var __workflow_uIAGetWin32WindowsmatchIndexAscending = WorkflowExpression.Compile(uIAGetWin32WindowsmatchIndexAscending, nameof(uIAGetWin32WindowsmatchIndexAscending), required: false);
            var __workflow_uIAGetWin32WindowsreturnElementHandle = WorkflowExpression.Compile(uIAGetWin32WindowsreturnElementHandle, nameof(uIAGetWin32WindowsreturnElementHandle), required: false);
            var __workflow_uIAGetWin32WindowsfirstItemToReturn = WorkflowExpression.Compile(uIAGetWin32WindowsfirstItemToReturn, nameof(uIAGetWin32WindowsfirstItemToReturn), required: false);
            var __workflow_uIAGetWin32WindowsmaxItemsToReturn = WorkflowExpression.Compile(uIAGetWin32WindowsmaxItemsToReturn, nameof(uIAGetWin32WindowsmaxItemsToReturn), required: false);
            return new DeferredBodyAction<UIAGetWin32WindowsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetWin32Windows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetWin32Windows = new JObject();
                var uIAGetWin32WindowspropCount = 0;
                if (__workflow_uIAGetWin32WindowssearchClassName != null)
                {
                    uIAGetWin32Windows["SearchClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowssearchClassName);
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowssearchWindowTitle != null)
                {
                    uIAGetWin32Windows["SearchWindowTitle"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowssearchWindowTitle);
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowstopLevelWindowsOnly != null)
                {
                    if (__workflow_uIAGetWin32WindowstopLevelWindowsOnly != null)
                    {
                        uIAGetWin32Windows["TopLevelWindowsOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowstopLevelWindowsOnly);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["TopLevelWindowsOnly"] = false;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsvisibleWindowsOnly != null)
                {
                    if (__workflow_uIAGetWin32WindowsvisibleWindowsOnly != null)
                    {
                        uIAGetWin32Windows["VisibleWindowsOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsvisibleWindowsOnly);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["VisibleWindowsOnly"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowswindowsWithTitlebarOnly != null)
                {
                    if (__workflow_uIAGetWin32WindowswindowsWithTitlebarOnly != null)
                    {
                        uIAGetWin32Windows["WindowsWithTitlebarOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowswindowsWithTitlebarOnly);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["WindowsWithTitlebarOnly"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowswindowsWithTitleOnly != null)
                {
                    if (__workflow_uIAGetWin32WindowswindowsWithTitleOnly != null)
                    {
                        uIAGetWin32Windows["WindowsWithTitleOnly"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowswindowsWithTitleOnly);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["WindowsWithTitleOnly"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsignoreTransparentWindows != null)
                {
                    if (__workflow_uIAGetWin32WindowsignoreTransparentWindows != null)
                    {
                        uIAGetWin32Windows["IgnoreTransparentWindows"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsignoreTransparentWindows);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["IgnoreTransparentWindows"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowssearchProcessId != null)
                {
                    uIAGetWin32Windows["SearchProcessId"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowssearchProcessId);
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowssearchFilter != null)
                {
                    uIAGetWin32Windows["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowssearchFilter);
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowssortByColumn != null)
                {
                    uIAGetWin32Windows["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowssortByColumn);
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetWin32WindowsmatchIndexAscending != null)
                    {
                        uIAGetWin32Windows["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsmatchIndexAscending);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["MatchIndexAscending"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsreturnElementHandle != null)
                {
                    if (__workflow_uIAGetWin32WindowsreturnElementHandle != null)
                    {
                        uIAGetWin32Windows["ReturnElementHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsreturnElementHandle);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["ReturnElementHandle"] = true;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsfirstItemToReturn != null)
                {
                    if (__workflow_uIAGetWin32WindowsfirstItemToReturn != null)
                    {
                        uIAGetWin32Windows["FirstItemToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsfirstItemToReturn);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["FirstItemToReturn"] = 1;
                    uIAGetWin32WindowspropCount++;
                }

                if (__workflow_uIAGetWin32WindowsmaxItemsToReturn != null)
                {
                    if (__workflow_uIAGetWin32WindowsmaxItemsToReturn != null)
                    {
                        uIAGetWin32Windows["MaxItemsToReturn"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32WindowsmaxItemsToReturn);
                        uIAGetWin32WindowspropCount++;
                    }

                    uIAGetWin32WindowspropCount++;
                }
                else
                {
                    uIAGetWin32Windows["MaxItemsToReturn"] = 0;
                    uIAGetWin32WindowspropCount++;
                }

                uIAGetWin32WindowspropCount++;
                uIAGetWin32Windows["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetWin32Windowsworkflow);
                if (uIAGetWin32WindowspropCount > 0)
                {
                    callPayload.Body = uIAGetWin32Windows;
                }

                return new ApiConnectionAction<UIAGetWin32WindowsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<SetUIAElementSearchModeResponse, ApiConnectionActionConfiguration> SetUIAElementSearchMode(Expression<Func<setUIAElementSearchModeuIAElementSearchModeInput>> setUIAElementSearchModeuIAElementSearchMode, Expression<Func<string>> setUIAElementSearchModeworkflow)
        {
            var __workflow_setUIAElementSearchModeuIAElementSearchMode = WorkflowExpression.Compile(setUIAElementSearchModeuIAElementSearchMode, nameof(setUIAElementSearchModeuIAElementSearchMode), required: true);
            var __workflow_setUIAElementSearchModeworkflow = WorkflowExpression.Compile(setUIAElementSearchModeworkflow, nameof(setUIAElementSearchModeworkflow), required: true);
            return new DeferredBodyAction<SetUIAElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/SetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var setUIAElementSearchMode = new JObject();
                var setUIAElementSearchModepropCount = 0;
                setUIAElementSearchModepropCount++;
                setUIAElementSearchMode["UIAElementSearchMode"] = ExpressionConverter.ConvertO(__workflow_setUIAElementSearchModeuIAElementSearchMode);
                setUIAElementSearchModepropCount++;
                setUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(__workflow_setUIAElementSearchModeworkflow);
                if (setUIAElementSearchModepropCount > 0)
                {
                    callPayload.Body = setUIAElementSearchMode;
                }

                return new ApiConnectionAction<SetUIAElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<GetUIAElementSearchModeResponse, ApiConnectionActionConfiguration> GetUIAElementSearchMode(Expression<Func<string>> getUIAElementSearchModeworkflow)
        {
            var __workflow_getUIAElementSearchModeworkflow = WorkflowExpression.Compile(getUIAElementSearchModeworkflow, nameof(getUIAElementSearchModeworkflow), required: true);
            return new DeferredBodyAction<GetUIAElementSearchModeResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/GetUIAElementSearchMode";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var getUIAElementSearchMode = new JObject();
                var getUIAElementSearchModepropCount = 0;
                getUIAElementSearchModepropCount++;
                getUIAElementSearchMode["Workflow"] = ExpressionConverter.ConvertO(__workflow_getUIAElementSearchModeworkflow);
                if (getUIAElementSearchModepropCount > 0)
                {
                    callPayload.Body = getUIAElementSearchMode;
                }

                return new ApiConnectionAction<GetUIAElementSearchModeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAGetElementPatternsResponse, ApiConnectionActionConfiguration> UIAGetElementPatterns(Expression<Func<int>> uIAGetElementPatternsparentWindowHandle, Expression<Func<string>> uIAGetElementPatternsworkflow, Expression<Func<string>> uIAGetElementPatternssearchElementName = null, Expression<Func<string>> uIAGetElementPatternssearchElementClassName = null, Expression<Func<string>> uIAGetElementPatternssearchElementAutomationId = null, Expression<Func<string>> uIAGetElementPatternssearchLocalizedControlType = null, Expression<Func<bool>> uIAGetElementPatternssearchSubTree = null, Expression<Func<int>> uIAGetElementPatternsmatchIndex = null, Expression<Func<string>> uIAGetElementPatternssearchFilter = null, Expression<Func<string>> uIAGetElementPatternssortByColumn = null, Expression<Func<bool>> uIAGetElementPatternsmatchIndexAscending = null, Expression<Func<int>> uIAGetElementPatternsmaxElementsToSearch = null, Expression<Func<int>> uIAGetElementPatternsmaxRelativeSearchDepth = null, Expression<Func<int>> uIAGetElementPatternsmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAGetElementPatternselementLocalizedControlTypesNotToTraverse = null)
        {
            var __workflow_uIAGetElementPatternsparentWindowHandle = WorkflowExpression.Compile(uIAGetElementPatternsparentWindowHandle, nameof(uIAGetElementPatternsparentWindowHandle), required: true);
            var __workflow_uIAGetElementPatternsworkflow = WorkflowExpression.Compile(uIAGetElementPatternsworkflow, nameof(uIAGetElementPatternsworkflow), required: true);
            var __workflow_uIAGetElementPatternssearchElementName = WorkflowExpression.Compile(uIAGetElementPatternssearchElementName, nameof(uIAGetElementPatternssearchElementName), required: false);
            var __workflow_uIAGetElementPatternssearchElementClassName = WorkflowExpression.Compile(uIAGetElementPatternssearchElementClassName, nameof(uIAGetElementPatternssearchElementClassName), required: false);
            var __workflow_uIAGetElementPatternssearchElementAutomationId = WorkflowExpression.Compile(uIAGetElementPatternssearchElementAutomationId, nameof(uIAGetElementPatternssearchElementAutomationId), required: false);
            var __workflow_uIAGetElementPatternssearchLocalizedControlType = WorkflowExpression.Compile(uIAGetElementPatternssearchLocalizedControlType, nameof(uIAGetElementPatternssearchLocalizedControlType), required: false);
            var __workflow_uIAGetElementPatternssearchSubTree = WorkflowExpression.Compile(uIAGetElementPatternssearchSubTree, nameof(uIAGetElementPatternssearchSubTree), required: false);
            var __workflow_uIAGetElementPatternsmatchIndex = WorkflowExpression.Compile(uIAGetElementPatternsmatchIndex, nameof(uIAGetElementPatternsmatchIndex), required: false);
            var __workflow_uIAGetElementPatternssearchFilter = WorkflowExpression.Compile(uIAGetElementPatternssearchFilter, nameof(uIAGetElementPatternssearchFilter), required: false);
            var __workflow_uIAGetElementPatternssortByColumn = WorkflowExpression.Compile(uIAGetElementPatternssortByColumn, nameof(uIAGetElementPatternssortByColumn), required: false);
            var __workflow_uIAGetElementPatternsmatchIndexAscending = WorkflowExpression.Compile(uIAGetElementPatternsmatchIndexAscending, nameof(uIAGetElementPatternsmatchIndexAscending), required: false);
            var __workflow_uIAGetElementPatternsmaxElementsToSearch = WorkflowExpression.Compile(uIAGetElementPatternsmaxElementsToSearch, nameof(uIAGetElementPatternsmaxElementsToSearch), required: false);
            var __workflow_uIAGetElementPatternsmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAGetElementPatternsmaxRelativeSearchDepth, nameof(uIAGetElementPatternsmaxRelativeSearchDepth), required: false);
            var __workflow_uIAGetElementPatternsmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAGetElementPatternsmaxChildElementsToSearchPerNode, nameof(uIAGetElementPatternsmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAGetElementPatternselementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAGetElementPatternselementLocalizedControlTypesNotToTraverse, nameof(uIAGetElementPatternselementLocalizedControlTypesNotToTraverse), required: false);
            return new DeferredBodyAction<UIAGetElementPatternsResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAGetElementPatterns";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAGetElementPatterns = new JObject();
                var uIAGetElementPatternspropCount = 0;
                uIAGetElementPatternspropCount++;
                uIAGetElementPatterns["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsparentWindowHandle);
                if (__workflow_uIAGetElementPatternssearchElementName != null)
                {
                    uIAGetElementPatterns["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchElementName);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssearchElementClassName != null)
                {
                    uIAGetElementPatterns["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchElementClassName);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssearchElementAutomationId != null)
                {
                    uIAGetElementPatterns["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchElementAutomationId);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssearchLocalizedControlType != null)
                {
                    uIAGetElementPatterns["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchLocalizedControlType);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssearchSubTree != null)
                {
                    if (__workflow_uIAGetElementPatternssearchSubTree != null)
                    {
                        uIAGetElementPatterns["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchSubTree);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["SearchSubTree"] = true;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternsmatchIndex != null)
                {
                    if (__workflow_uIAGetElementPatternsmatchIndex != null)
                    {
                        uIAGetElementPatterns["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsmatchIndex);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["MatchIndex"] = 1;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssearchFilter != null)
                {
                    uIAGetElementPatterns["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssearchFilter);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternssortByColumn != null)
                {
                    uIAGetElementPatterns["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternssortByColumn);
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternsmatchIndexAscending != null)
                {
                    if (__workflow_uIAGetElementPatternsmatchIndexAscending != null)
                    {
                        uIAGetElementPatterns["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsmatchIndexAscending);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["MatchIndexAscending"] = true;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternsmaxElementsToSearch != null)
                {
                    if (__workflow_uIAGetElementPatternsmaxElementsToSearch != null)
                    {
                        uIAGetElementPatterns["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsmaxElementsToSearch);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["MaxElementsToSearch"] = 0;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternsmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAGetElementPatternsmaxRelativeSearchDepth != null)
                    {
                        uIAGetElementPatterns["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsmaxRelativeSearchDepth);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["MaxRelativeSearchDepth"] = 0;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternsmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAGetElementPatternsmaxChildElementsToSearchPerNode != null)
                    {
                        uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsmaxChildElementsToSearchPerNode);
                        uIAGetElementPatternspropCount++;
                    }

                    uIAGetElementPatternspropCount++;
                }
                else
                {
                    uIAGetElementPatterns["MaxChildElementsToSearchPerNode"] = 0;
                    uIAGetElementPatternspropCount++;
                }

                if (__workflow_uIAGetElementPatternselementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAGetElementPatterns["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternselementLocalizedControlTypesNotToTraverse);
                    uIAGetElementPatternspropCount++;
                }

                uIAGetElementPatternspropCount++;
                uIAGetElementPatterns["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAGetElementPatternsworkflow);
                if (uIAGetElementPatternspropCount > 0)
                {
                    callPayload.Body = uIAGetElementPatterns;
                }

                return new ApiConnectionAction<UIAGetElementPatternsResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAMoveElementResponse, ApiConnectionActionConfiguration> UIAMoveElement(Expression<Func<int>> uIAMoveElementparentWindowHandle, Expression<Func<int>> uIAMoveElementhorizontalPosition, Expression<Func<int>> uIAMoveElementverticalPosition, Expression<Func<string>> uIAMoveElementworkflow, Expression<Func<string>> uIAMoveElementsearchElementName = null, Expression<Func<string>> uIAMoveElementsearchElementClassName = null, Expression<Func<string>> uIAMoveElementsearchElementAutomationId = null, Expression<Func<string>> uIAMoveElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAMoveElementsearchSubTree = null, Expression<Func<int>> uIAMoveElementmatchIndex = null, Expression<Func<string>> uIAMoveElementsearchFilter = null, Expression<Func<string>> uIAMoveElementsortByColumn = null, Expression<Func<bool>> uIAMoveElementmatchIndexAscending = null, Expression<Func<int>> uIAMoveElementmaxElementsToSearch = null, Expression<Func<int>> uIAMoveElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAMoveElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAMoveElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAMoveElementhorizontalMovementTypeInput>> uIAMoveElementhorizontalMovementType = null, Expression<Func<uIAMoveElementverticalMovementTypeInput>> uIAMoveElementverticalMovementType = null)
        {
            var __workflow_uIAMoveElementparentWindowHandle = WorkflowExpression.Compile(uIAMoveElementparentWindowHandle, nameof(uIAMoveElementparentWindowHandle), required: true);
            var __workflow_uIAMoveElementhorizontalPosition = WorkflowExpression.Compile(uIAMoveElementhorizontalPosition, nameof(uIAMoveElementhorizontalPosition), required: true);
            var __workflow_uIAMoveElementverticalPosition = WorkflowExpression.Compile(uIAMoveElementverticalPosition, nameof(uIAMoveElementverticalPosition), required: true);
            var __workflow_uIAMoveElementworkflow = WorkflowExpression.Compile(uIAMoveElementworkflow, nameof(uIAMoveElementworkflow), required: true);
            var __workflow_uIAMoveElementsearchElementName = WorkflowExpression.Compile(uIAMoveElementsearchElementName, nameof(uIAMoveElementsearchElementName), required: false);
            var __workflow_uIAMoveElementsearchElementClassName = WorkflowExpression.Compile(uIAMoveElementsearchElementClassName, nameof(uIAMoveElementsearchElementClassName), required: false);
            var __workflow_uIAMoveElementsearchElementAutomationId = WorkflowExpression.Compile(uIAMoveElementsearchElementAutomationId, nameof(uIAMoveElementsearchElementAutomationId), required: false);
            var __workflow_uIAMoveElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAMoveElementsearchLocalizedControlType, nameof(uIAMoveElementsearchLocalizedControlType), required: false);
            var __workflow_uIAMoveElementsearchSubTree = WorkflowExpression.Compile(uIAMoveElementsearchSubTree, nameof(uIAMoveElementsearchSubTree), required: false);
            var __workflow_uIAMoveElementmatchIndex = WorkflowExpression.Compile(uIAMoveElementmatchIndex, nameof(uIAMoveElementmatchIndex), required: false);
            var __workflow_uIAMoveElementsearchFilter = WorkflowExpression.Compile(uIAMoveElementsearchFilter, nameof(uIAMoveElementsearchFilter), required: false);
            var __workflow_uIAMoveElementsortByColumn = WorkflowExpression.Compile(uIAMoveElementsortByColumn, nameof(uIAMoveElementsortByColumn), required: false);
            var __workflow_uIAMoveElementmatchIndexAscending = WorkflowExpression.Compile(uIAMoveElementmatchIndexAscending, nameof(uIAMoveElementmatchIndexAscending), required: false);
            var __workflow_uIAMoveElementmaxElementsToSearch = WorkflowExpression.Compile(uIAMoveElementmaxElementsToSearch, nameof(uIAMoveElementmaxElementsToSearch), required: false);
            var __workflow_uIAMoveElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAMoveElementmaxRelativeSearchDepth, nameof(uIAMoveElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAMoveElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAMoveElementmaxChildElementsToSearchPerNode, nameof(uIAMoveElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAMoveElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAMoveElementelementLocalizedControlTypesNotToTraverse, nameof(uIAMoveElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAMoveElementhorizontalMovementType = WorkflowExpression.Compile(uIAMoveElementhorizontalMovementType, nameof(uIAMoveElementhorizontalMovementType), required: false);
            var __workflow_uIAMoveElementverticalMovementType = WorkflowExpression.Compile(uIAMoveElementverticalMovementType, nameof(uIAMoveElementverticalMovementType), required: false);
            return new DeferredBodyAction<UIAMoveElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAMoveElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAMoveElement = new JObject();
                var uIAMoveElementpropCount = 0;
                uIAMoveElementpropCount++;
                uIAMoveElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementparentWindowHandle);
                if (__workflow_uIAMoveElementsearchElementName != null)
                {
                    uIAMoveElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchElementName);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsearchElementClassName != null)
                {
                    uIAMoveElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchElementClassName);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsearchElementAutomationId != null)
                {
                    uIAMoveElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchElementAutomationId);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsearchLocalizedControlType != null)
                {
                    uIAMoveElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchLocalizedControlType);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsearchSubTree != null)
                {
                    if (__workflow_uIAMoveElementsearchSubTree != null)
                    {
                        uIAMoveElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchSubTree);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["SearchSubTree"] = true;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementmatchIndex != null)
                {
                    if (__workflow_uIAMoveElementmatchIndex != null)
                    {
                        uIAMoveElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementmatchIndex);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["MatchIndex"] = 1;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsearchFilter != null)
                {
                    uIAMoveElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsearchFilter);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementsortByColumn != null)
                {
                    uIAMoveElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementsortByColumn);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAMoveElementmatchIndexAscending != null)
                    {
                        uIAMoveElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementmatchIndexAscending);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["MatchIndexAscending"] = true;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAMoveElementmaxElementsToSearch != null)
                    {
                        uIAMoveElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementmaxElementsToSearch);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["MaxElementsToSearch"] = 0;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAMoveElementmaxRelativeSearchDepth != null)
                    {
                        uIAMoveElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementmaxRelativeSearchDepth);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["MaxRelativeSearchDepth"] = 0;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAMoveElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAMoveElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementmaxChildElementsToSearchPerNode);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAMoveElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementelementLocalizedControlTypesNotToTraverse);
                    uIAMoveElementpropCount++;
                }

                if (__workflow_uIAMoveElementhorizontalMovementType != null)
                {
                    if (__workflow_uIAMoveElementhorizontalMovementType != null)
                    {
                        uIAMoveElement["HorizontalMovementType"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementhorizontalMovementType);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["HorizontalMovementType"] = "Absolute";
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
                uIAMoveElement["HorizontalPosition"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementhorizontalPosition);
                if (__workflow_uIAMoveElementverticalMovementType != null)
                {
                    if (__workflow_uIAMoveElementverticalMovementType != null)
                    {
                        uIAMoveElement["VerticalMovementType"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementverticalMovementType);
                        uIAMoveElementpropCount++;
                    }

                    uIAMoveElementpropCount++;
                }
                else
                {
                    uIAMoveElement["VerticalMovementType"] = "Absolute";
                    uIAMoveElementpropCount++;
                }

                uIAMoveElementpropCount++;
                uIAMoveElement["VerticalPosition"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementverticalPosition);
                uIAMoveElementpropCount++;
                uIAMoveElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAMoveElementworkflow);
                if (uIAMoveElementpropCount > 0)
                {
                    callPayload.Body = uIAMoveElement;
                }

                return new ApiConnectionAction<UIAMoveElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAResizeElementResponse, ApiConnectionActionConfiguration> UIAResizeElement(Expression<Func<int>> uIAResizeElementparentWindowHandle, Expression<Func<int>> uIAResizeElementnewWidth, Expression<Func<int>> uIAResizeElementnewHeight, Expression<Func<string>> uIAResizeElementworkflow, Expression<Func<string>> uIAResizeElementsearchElementName = null, Expression<Func<string>> uIAResizeElementsearchElementClassName = null, Expression<Func<string>> uIAResizeElementsearchElementAutomationId = null, Expression<Func<string>> uIAResizeElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAResizeElementsearchSubTree = null, Expression<Func<int>> uIAResizeElementmatchIndex = null, Expression<Func<string>> uIAResizeElementsearchFilter = null, Expression<Func<string>> uIAResizeElementsortByColumn = null, Expression<Func<bool>> uIAResizeElementmatchIndexAscending = null, Expression<Func<int>> uIAResizeElementmaxElementsToSearch = null, Expression<Func<int>> uIAResizeElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAResizeElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAResizeElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAResizeElementresizeWidthTypeInput>> uIAResizeElementresizeWidthType = null, Expression<Func<uIAResizeElementresizeHeightTypeInput>> uIAResizeElementresizeHeightType = null)
        {
            var __workflow_uIAResizeElementparentWindowHandle = WorkflowExpression.Compile(uIAResizeElementparentWindowHandle, nameof(uIAResizeElementparentWindowHandle), required: true);
            var __workflow_uIAResizeElementnewWidth = WorkflowExpression.Compile(uIAResizeElementnewWidth, nameof(uIAResizeElementnewWidth), required: true);
            var __workflow_uIAResizeElementnewHeight = WorkflowExpression.Compile(uIAResizeElementnewHeight, nameof(uIAResizeElementnewHeight), required: true);
            var __workflow_uIAResizeElementworkflow = WorkflowExpression.Compile(uIAResizeElementworkflow, nameof(uIAResizeElementworkflow), required: true);
            var __workflow_uIAResizeElementsearchElementName = WorkflowExpression.Compile(uIAResizeElementsearchElementName, nameof(uIAResizeElementsearchElementName), required: false);
            var __workflow_uIAResizeElementsearchElementClassName = WorkflowExpression.Compile(uIAResizeElementsearchElementClassName, nameof(uIAResizeElementsearchElementClassName), required: false);
            var __workflow_uIAResizeElementsearchElementAutomationId = WorkflowExpression.Compile(uIAResizeElementsearchElementAutomationId, nameof(uIAResizeElementsearchElementAutomationId), required: false);
            var __workflow_uIAResizeElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAResizeElementsearchLocalizedControlType, nameof(uIAResizeElementsearchLocalizedControlType), required: false);
            var __workflow_uIAResizeElementsearchSubTree = WorkflowExpression.Compile(uIAResizeElementsearchSubTree, nameof(uIAResizeElementsearchSubTree), required: false);
            var __workflow_uIAResizeElementmatchIndex = WorkflowExpression.Compile(uIAResizeElementmatchIndex, nameof(uIAResizeElementmatchIndex), required: false);
            var __workflow_uIAResizeElementsearchFilter = WorkflowExpression.Compile(uIAResizeElementsearchFilter, nameof(uIAResizeElementsearchFilter), required: false);
            var __workflow_uIAResizeElementsortByColumn = WorkflowExpression.Compile(uIAResizeElementsortByColumn, nameof(uIAResizeElementsortByColumn), required: false);
            var __workflow_uIAResizeElementmatchIndexAscending = WorkflowExpression.Compile(uIAResizeElementmatchIndexAscending, nameof(uIAResizeElementmatchIndexAscending), required: false);
            var __workflow_uIAResizeElementmaxElementsToSearch = WorkflowExpression.Compile(uIAResizeElementmaxElementsToSearch, nameof(uIAResizeElementmaxElementsToSearch), required: false);
            var __workflow_uIAResizeElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAResizeElementmaxRelativeSearchDepth, nameof(uIAResizeElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAResizeElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAResizeElementmaxChildElementsToSearchPerNode, nameof(uIAResizeElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAResizeElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAResizeElementelementLocalizedControlTypesNotToTraverse, nameof(uIAResizeElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAResizeElementresizeWidthType = WorkflowExpression.Compile(uIAResizeElementresizeWidthType, nameof(uIAResizeElementresizeWidthType), required: false);
            var __workflow_uIAResizeElementresizeHeightType = WorkflowExpression.Compile(uIAResizeElementresizeHeightType, nameof(uIAResizeElementresizeHeightType), required: false);
            return new DeferredBodyAction<UIAResizeElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAResizeElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAResizeElement = new JObject();
                var uIAResizeElementpropCount = 0;
                uIAResizeElementpropCount++;
                uIAResizeElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementparentWindowHandle);
                if (__workflow_uIAResizeElementsearchElementName != null)
                {
                    uIAResizeElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchElementName);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsearchElementClassName != null)
                {
                    uIAResizeElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchElementClassName);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsearchElementAutomationId != null)
                {
                    uIAResizeElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchElementAutomationId);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsearchLocalizedControlType != null)
                {
                    uIAResizeElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchLocalizedControlType);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsearchSubTree != null)
                {
                    if (__workflow_uIAResizeElementsearchSubTree != null)
                    {
                        uIAResizeElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchSubTree);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["SearchSubTree"] = true;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementmatchIndex != null)
                {
                    if (__workflow_uIAResizeElementmatchIndex != null)
                    {
                        uIAResizeElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementmatchIndex);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["MatchIndex"] = 1;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsearchFilter != null)
                {
                    uIAResizeElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsearchFilter);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementsortByColumn != null)
                {
                    uIAResizeElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementsortByColumn);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAResizeElementmatchIndexAscending != null)
                    {
                        uIAResizeElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementmatchIndexAscending);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["MatchIndexAscending"] = true;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAResizeElementmaxElementsToSearch != null)
                    {
                        uIAResizeElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementmaxElementsToSearch);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["MaxElementsToSearch"] = 0;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAResizeElementmaxRelativeSearchDepth != null)
                    {
                        uIAResizeElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementmaxRelativeSearchDepth);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["MaxRelativeSearchDepth"] = 0;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAResizeElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAResizeElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementmaxChildElementsToSearchPerNode);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAResizeElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementelementLocalizedControlTypesNotToTraverse);
                    uIAResizeElementpropCount++;
                }

                if (__workflow_uIAResizeElementresizeWidthType != null)
                {
                    if (__workflow_uIAResizeElementresizeWidthType != null)
                    {
                        uIAResizeElement["ResizeWidthType"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementresizeWidthType);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["ResizeWidthType"] = "Relative";
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
                uIAResizeElement["NewWidth"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementnewWidth);
                if (__workflow_uIAResizeElementresizeHeightType != null)
                {
                    if (__workflow_uIAResizeElementresizeHeightType != null)
                    {
                        uIAResizeElement["ResizeHeightType"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementresizeHeightType);
                        uIAResizeElementpropCount++;
                    }

                    uIAResizeElementpropCount++;
                }
                else
                {
                    uIAResizeElement["ResizeHeightType"] = "Relative";
                    uIAResizeElementpropCount++;
                }

                uIAResizeElementpropCount++;
                uIAResizeElement["NewHeight"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementnewHeight);
                uIAResizeElementpropCount++;
                uIAResizeElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAResizeElementworkflow);
                if (uIAResizeElementpropCount > 0)
                {
                    callPayload.Body = uIAResizeElement;
                }

                return new ApiConnectionAction<UIAResizeElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIALocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UIALocateVisibleSearchImageWithinElement(Expression<Func<int>> uIALocateVisibleSearchImageWithinElementparentWindowHandle, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementworkflow, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementClassName = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementsearchSubTree = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmatchIndex = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchFilter = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsortByColumn = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementmatchIndexAscending = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIALocateVisibleSearchImageWithinElementsearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementsearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementsearchImage = null, Expression<Func<uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput>> uIALocateVisibleSearchImageWithinElementaltSearchImageType = null, Expression<Func<string>> uIALocateVisibleSearchImageWithinElementaltSearchImage = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxColourDeviation = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementleftPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementrightPixelXOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementtopPixelYOffset = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementbottomPixelYOffset = null, Expression<Func<uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit = null, Expression<Func<uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput>> uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIALocateVisibleSearchImageWithinElementsearchImageIndex = null, Expression<Func<uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput>> uIALocateVisibleSearchImageWithinElementimageSearchDirection = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementhideAgent = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, Expression<Func<bool>> uIALocateVisibleSearchImageWithinElementshowHighlightRectangle = null)
        {
            var __workflow_uIALocateVisibleSearchImageWithinElementparentWindowHandle = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementparentWindowHandle, nameof(uIALocateVisibleSearchImageWithinElementparentWindowHandle), required: true);
            var __workflow_uIALocateVisibleSearchImageWithinElementworkflow = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementworkflow, nameof(uIALocateVisibleSearchImageWithinElementworkflow), required: true);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchElementName = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchElementName, nameof(uIALocateVisibleSearchImageWithinElementsearchElementName), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchElementClassName = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchElementClassName, nameof(uIALocateVisibleSearchImageWithinElementsearchElementClassName), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchElementAutomationId = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchElementAutomationId, nameof(uIALocateVisibleSearchImageWithinElementsearchElementAutomationId), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType, nameof(uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchSubTree = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchSubTree, nameof(uIALocateVisibleSearchImageWithinElementsearchSubTree), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmatchIndex = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmatchIndex, nameof(uIALocateVisibleSearchImageWithinElementmatchIndex), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchFilter = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchFilter, nameof(uIALocateVisibleSearchImageWithinElementsearchFilter), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsortByColumn = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsortByColumn, nameof(uIALocateVisibleSearchImageWithinElementsortByColumn), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmatchIndexAscending = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmatchIndexAscending, nameof(uIALocateVisibleSearchImageWithinElementmatchIndexAscending), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxElementsToSearch = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch, nameof(uIALocateVisibleSearchImageWithinElementmaxElementsToSearch), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth, nameof(uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode, nameof(uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse, nameof(uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchImageType = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchImageType, nameof(uIALocateVisibleSearchImageWithinElementsearchImageType), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchImage = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchImage, nameof(uIALocateVisibleSearchImageWithinElementsearchImage), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementaltSearchImageType = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementaltSearchImageType, nameof(uIALocateVisibleSearchImageWithinElementaltSearchImageType), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementaltSearchImage = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementaltSearchImage, nameof(uIALocateVisibleSearchImageWithinElementaltSearchImage), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxColourDeviation = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxColourDeviation, nameof(uIALocateVisibleSearchImageWithinElementmaxColourDeviation), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxPixelDifferences = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences, nameof(uIALocateVisibleSearchImageWithinElementmaxPixelDifferences), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences, nameof(uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementleftPixelXOffset = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementleftPixelXOffset, nameof(uIALocateVisibleSearchImageWithinElementleftPixelXOffset), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementrightPixelXOffset = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementrightPixelXOffset, nameof(uIALocateVisibleSearchImageWithinElementrightPixelXOffset), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementtopPixelYOffset = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementtopPixelYOffset, nameof(uIALocateVisibleSearchImageWithinElementtopPixelYOffset), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementbottomPixelYOffset = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementbottomPixelYOffset, nameof(uIALocateVisibleSearchImageWithinElementbottomPixelYOffset), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit, nameof(uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit, nameof(uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementsearchImageIndex = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementsearchImageIndex, nameof(uIALocateVisibleSearchImageWithinElementsearchImageIndex), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementimageSearchDirection = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementimageSearchDirection, nameof(uIALocateVisibleSearchImageWithinElementimageSearchDirection), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementhideAgent = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementhideAgent, nameof(uIALocateVisibleSearchImageWithinElementhideAgent), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates, nameof(uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates), required: false);
            var __workflow_uIALocateVisibleSearchImageWithinElementshowHighlightRectangle = WorkflowExpression.Compile(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle, nameof(uIALocateVisibleSearchImageWithinElementshowHighlightRectangle), required: false);
            return new DeferredBodyAction<UIALocateVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIALocateVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIALocateVisibleSearchImageWithinElement = new JObject();
                var uIALocateVisibleSearchImageWithinElementpropCount = 0;
                uIALocateVisibleSearchImageWithinElementpropCount++;
                uIALocateVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementparentWindowHandle);
                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchElementName != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchElementName);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchElementClassName != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchElementClassName);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchElementAutomationId != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchElementAutomationId);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchLocalizedControlType);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementsearchSubTree != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchSubTree);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["SearchSubTree"] = true;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmatchIndex != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmatchIndex != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmatchIndex);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MatchIndex"] = 1;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchFilter != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchFilter);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsortByColumn != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsortByColumn);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmatchIndexAscending != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmatchIndexAscending);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MatchIndexAscending"] = true;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxElementsToSearch != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxElementsToSearch);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxElementsToSearch"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIALocateVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchImageType != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchImageType);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchImage != null)
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchImage);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementaltSearchImageType != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementaltSearchImageType);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["AltSearchImageType"] = "None";
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementaltSearchImage != null)
                {
                    uIALocateVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementaltSearchImage);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxColourDeviation != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxColourDeviation);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxColourDeviation"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxPixelDifferences != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxPixelDifferences != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxPixelDifferences);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxPixelDifferences"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = 0;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementleftPixelXOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementleftPixelXOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementrightPixelXOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementrightPixelXOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementtopPixelYOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementtopPixelYOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementbottomPixelYOffset != null)
                {
                    uIALocateVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementbottomPixelYOffset);
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnit);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = "Pixel";
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnit);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = "Pixel";
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementsearchImageIndex != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementsearchImageIndex != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementsearchImageIndex);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["SearchImageIndex"] = 1;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementimageSearchDirection != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementimageSearchDirection != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementimageSearchDirection);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["ImageSearchDirection"] = "FromTop";
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementhideAgent != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementhideAgent != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementhideAgent);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["HideAgent"] = true;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = false;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIALocateVisibleSearchImageWithinElementshowHighlightRectangle != null)
                {
                    if (__workflow_uIALocateVisibleSearchImageWithinElementshowHighlightRectangle != null)
                    {
                        uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementshowHighlightRectangle);
                        uIALocateVisibleSearchImageWithinElementpropCount++;
                    }

                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIALocateVisibleSearchImageWithinElement["ShowHighlightRectangle"] = false;
                    uIALocateVisibleSearchImageWithinElementpropCount++;
                }

                uIALocateVisibleSearchImageWithinElementpropCount++;
                uIALocateVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIALocateVisibleSearchImageWithinElementworkflow);
                if (uIALocateVisibleSearchImageWithinElementpropCount > 0)
                {
                    callPayload.Body = uIALocateVisibleSearchImageWithinElement;
                }

                return new ApiConnectionAction<UIALocateVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration> UIAWaitForVisibleSearchImageWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementworkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementparentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementsearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementsearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementsearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput>> uIAWaitForVisibleSearchImageWithinElementaltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageWithinElementaltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementsearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput>> uIAWaitForVisibleSearchImageWithinElementimageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementhideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementsecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound = null, Expression<Func<int>> uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageWithinElementwaitForThread = null)
        {
            var __workflow_uIAWaitForVisibleSearchImageWithinElementworkflow = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementworkflow, nameof(uIAWaitForVisibleSearchImageWithinElementworkflow), required: true);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementparentWindowHandle = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementparentWindowHandle, nameof(uIAWaitForVisibleSearchImageWithinElementparentWindowHandle), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementName = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchElementName, nameof(uIAWaitForVisibleSearchImageWithinElementsearchElementName), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementClassName = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchElementClassName, nameof(uIAWaitForVisibleSearchImageWithinElementsearchElementClassName), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId, nameof(uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType, nameof(uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchSubTree = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchSubTree, nameof(uIAWaitForVisibleSearchImageWithinElementsearchSubTree), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndex = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmatchIndex, nameof(uIAWaitForVisibleSearchImageWithinElementmatchIndex), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchFilter = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchFilter, nameof(uIAWaitForVisibleSearchImageWithinElementsearchFilter), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsortByColumn = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsortByColumn, nameof(uIAWaitForVisibleSearchImageWithinElementsortByColumn), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending, nameof(uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch, nameof(uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth, nameof(uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode, nameof(uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchImageType, nameof(uIAWaitForVisibleSearchImageWithinElementsearchImageType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchImage = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchImage, nameof(uIAWaitForVisibleSearchImageWithinElementsearchImage), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImageType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType, nameof(uIAWaitForVisibleSearchImageWithinElementaltSearchImageType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImage = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementaltSearchImage, nameof(uIAWaitForVisibleSearchImageWithinElementaltSearchImage), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation, nameof(uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences, nameof(uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences, nameof(uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset, nameof(uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset, nameof(uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset, nameof(uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset, nameof(uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit, nameof(uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit, nameof(uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageIndex = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex, nameof(uIAWaitForVisibleSearchImageWithinElementsearchImageIndex), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementimageSearchDirection = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection, nameof(uIAWaitForVisibleSearchImageWithinElementimageSearchDirection), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementhideAgent = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementhideAgent, nameof(uIAWaitForVisibleSearchImageWithinElementhideAgent), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates, nameof(uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle, nameof(uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementsecondsToWait = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementsecondsToWait, nameof(uIAWaitForVisibleSearchImageWithinElementsecondsToWait), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches, nameof(uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound, nameof(uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId, nameof(uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId), required: false);
            var __workflow_uIAWaitForVisibleSearchImageWithinElementwaitForThread = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageWithinElementwaitForThread, nameof(uIAWaitForVisibleSearchImageWithinElementwaitForThread), required: false);
            return new DeferredBodyAction<UIAWaitForVisibleSearchImageWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForVisibleSearchImageWithinElement = new JObject();
                var uIAWaitForVisibleSearchImageWithinElementpropCount = 0;
                if (__workflow_uIAWaitForVisibleSearchImageWithinElementparentWindowHandle != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementparentWindowHandle);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementName != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementName);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementClassName != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementClassName);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchElementAutomationId);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchLocalizedControlType);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchSubTree != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchSubTree);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchSubTree"] = true;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndex != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndex != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndex);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndex"] = 1;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchFilter != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchFilter);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsortByColumn != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsortByColumn);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmatchIndexAscending);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MatchIndexAscending"] = true;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxElementsToSearch);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxElementsToSearch"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxRelativeSearchDepth);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxChildElementsToSearchPerNode);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageType);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImage != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImage"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImage);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImageType != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImageType);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["AltSearchImageType"] = "None";
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImage != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementaltSearchImage);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxColourDeviation);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxColourDeviation"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxPixelDifferences);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxPixelDifferences"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmaxConsecutivePixelDifferences);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MaxConsecutivePixelDifferences"] = 0;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementleftPixelXOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementrightPixelXOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementtopPixelYOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementbottomPixelYOffset);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnit);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["PixelXOffsetsUnit"] = "Pixel";
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnit);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["PixelYOffsetsUnit"] = "Pixel";
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageIndex != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageIndex != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsearchImageIndex);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["SearchImageIndex"] = 1;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementimageSearchDirection != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementimageSearchDirection != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementimageSearchDirection);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["ImageSearchDirection"] = "FromTop";
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementhideAgent != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementhideAgent != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementhideAgent);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["HideAgent"] = true;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementreturnPhysicalCoordinates);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["ReturnPhysicalCoordinates"] = false;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementshowHighlightRectangle);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["ShowHighlightRectangle"] = false;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementsecondsToWait != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementsecondsToWait != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementsecondsToWait);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["SecondsToWait"] = 60;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementmillisecondsBetweenSearches);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["MillisecondsBetweenSearches"] = 5000;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementraiseExceptionIfImageNotFound);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["RaiseExceptionIfImageNotFound"] = true;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId != null)
                {
                    uIAWaitForVisibleSearchImageWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementretrieveOutputDataFromThreadId);
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageWithinElementwaitForThread != null)
                    {
                        uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementwaitForThread);
                        uIAWaitForVisibleSearchImageWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageWithinElement["WaitForThread"] = true;
                    uIAWaitForVisibleSearchImageWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageWithinElementpropCount++;
                uIAWaitForVisibleSearchImageWithinElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageWithinElementworkflow);
                if (uIAWaitForVisibleSearchImageWithinElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForVisibleSearchImageWithinElement;
                }

                return new ApiConnectionAction<UIAWaitForVisibleSearchImageWithinElementResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectui")]
        public IBodyWorkflowAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration> UIAWaitForVisibleSearchImageToNotExistWithinElement(Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType = null, Expression<Func<string>> uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex = null, Expression<Func<uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput>> uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent = null, Expression<Func<int>> uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId = null, Expression<Func<bool>> uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread = null)
        {
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow), required: true);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId), required: false);
            var __workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread = WorkflowExpression.Compile(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread, nameof(uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread), required: false);
            return new DeferredBodyAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/UIAControl/UIAWaitForVisibleSearchImageToNotExistWithinElement";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var uIAWaitForVisibleSearchImageToNotExistWithinElement = new JObject();
                var uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount = 0;
                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ParentWindowHandle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementparentWindowHandle);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementName);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementClassName"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementClassName);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchElementAutomationId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchElementAutomationId);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchLocalizedControlType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchLocalizedControlType);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchSubTree);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchSubTree"] = true;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndex);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndex"] = 1;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchFilter"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchFilter);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SortByColumn"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsortByColumn);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmatchIndexAscending);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MatchIndexAscending"] = true;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxElementsToSearch);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxElementsToSearch"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxRelativeSearchDepth);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxRelativeSearchDepth"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxChildElementsToSearchPerNode);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxChildElementsToSearchPerNode"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ElementLocalizedControlTypesNotToTraverse"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementelementLocalizedControlTypesNotToTraverse);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageType);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImage"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImage);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageType);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImageType"] = "None";
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["AltSearchImage"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImage);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxColourDeviation);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxColourDeviation"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxPixelDifferences);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxPixelDifferences"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmaxConsecutivePixelDifferences);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MaxConsecutivePixelDifferences"] = 0;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["LeftPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementleftPixelXOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RightPixelXOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementrightPixelXOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["TopPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementtopPixelYOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["BottomPixelYOffset"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementbottomPixelYOffset);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnit);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelXOffsetsUnit"] = "Pixel";
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnit);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["PixelYOffsetsUnit"] = "Pixel";
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageIndex);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SearchImageIndex"] = 1;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirection);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ImageSearchDirection"] = "FromTop";
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementhideAgent);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["HideAgent"] = true;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementshowHighlightRectangle);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["ShowHighlightRectangle"] = false;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementsecondsToWait);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["SecondsToWait"] = 60;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementmillisecondsBetweenSearches);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["MillisecondsBetweenSearches"] = 5000;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementraiseExceptionIfImageStillPresent);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RaiseExceptionIfImageStillPresent"] = true;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId != null)
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["RetrieveOutputDataFromThreadId"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementretrieveOutputDataFromThreadId);
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                {
                    if (__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread != null)
                    {
                        uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementwaitForThread);
                        uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                    }

                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }
                else
                {
                    uIAWaitForVisibleSearchImageToNotExistWithinElement["WaitForThread"] = true;
                    uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                }

                uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount++;
                uIAWaitForVisibleSearchImageToNotExistWithinElement["Workflow"] = ExpressionConverter.ConvertO(__workflow_uIAWaitForVisibleSearchImageToNotExistWithinElementworkflow);
                if (uIAWaitForVisibleSearchImageToNotExistWithinElementpropCount > 0)
                {
                    callPayload.Body = uIAWaitForVisibleSearchImageToNotExistWithinElement;
                }

                return new ApiConnectionAction<UIAWaitForVisibleSearchImageToNotExistWithinElementResponse>(callPayload);
            });
        }
    }

    public class IaconnectuiTriggers([ConnectionName] string connectionId)
    {
    }

    public class UIADoesTopLevelWindowExistResponse
    {
        public bool WindowExists { get; set; }
    }

    public class UIAGetHandleForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForTopLevelWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UIADoesProcessHaveWindowResponse
    {
        public bool ProcessHasWindow { get; set; }
    }

    public class UIAGetHandleForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForProcessMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementExists { get; set; }
    }

    public class UIAGetHandleForProcessIdMainWindowResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForProcessIdMainWindowResponse
    {
        public bool ElementExists { get; set; }
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForMainWindowOfFocussedElementResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetHandleForDesktopResponse
    {
        public int WindowHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIADoesElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIADoesDesktopElementExistResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForDesktopElementResponse
    {
        public bool ElementExists { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAWaitForElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    public class UIAWaitForDesktopElementToNotExistResponse
    {
        public bool ElementExistsBeforeWait { get; set; }
        public bool ElementExistsAfterWait { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalMouseClickOnElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalRightMouseClickOnElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalMiddleMouseClickOnElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalDoubleLeftMouseClickOnElementoffsetRelativeToInput
    {
        Center,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public class UIAIsElementCheckedResponse
    {
        public bool ElementIsChecked { get; set; }
    }

    public class UIAGetElementTextValueResponse
    {
        public string ElementTextValue { get; set; }
    }

    public class UIAGetElementValueResponse
    {
        public string ElementValue { get; set; }
    }

    public class UIAGetElementLabelValueResponse
    {
        public string ElementLabelValue { get; set; }
    }

    public class UIAGetElementPropertiesResponse
    {
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementFrameworkId { get; set; }
        public string ElementControlType { get; set; }
        public string ElementLocalizedControlType { get; set; }
        public bool ElementIsEnabled { get; set; }
        public bool ElementIsOffscreen { get; set; }
        public bool ElementIsKeyboardFocusable { get; set; }
        public bool ElementHasKeyboardFocus { get; set; }
        public bool ElementIsPasswordField { get; set; }
        public string ElementAcceleratorKey { get; set; }
        public string ElementAccessKey { get; set; }
        public int ElementLeftEdge { get; set; }
        public int ElementRightEdge { get; set; }
        public int ElementTopEdge { get; set; }
        public int ElementBottomEdge { get; set; }
        public int ElementClickablePointX { get; set; }
        public int ElementClickablePointY { get; set; }
        public int ElementProcessId { get; set; }
        public int ElementHandle { get; set; }
        public string ElementValue { get; set; }
        public string ElementTextValue { get; set; }
    }

    public class UIAGetMultipleElementPropertiesResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIAGetDesktopElementsResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public JToken[] ElementProperties { get; set; }
    }

    public class UIATakeScreenShotOfElementLocationResponse
    {
        public string ScreenBitmapBase64 { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIATakeScreenShotOfElementLocationimageFormatInput
    {
        PNG,
        JPG,
        BMP,
        GIF
    }

    public class UIAGetParentElementHandleResponse
    {
        public int ParentElementHandle { get; set; }
    }

    public class UIAGetDataGridElementContentsResponse
    {
        public string DataGridContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIAGetDataGridElementPropertiesResponse
    {
        public int NumberOfColumns { get; set; }
        public int NumberOfVisibleColumns { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfVisibleRows { get; set; }
        public int FirstVisibleRow { get; set; }
        public int LastVisibleRow { get; set; }
        public int NumberOfScrollbars { get; set; }
        public string ScrollbarNames { get; set; }
    }

    public class UIAGetListElementItemsResponse
    {
        public int NumberOfListItems { get; set; }
        public string ListItemsJSON { get; set; }
        public int NumberOfSelectedItems { get; set; }
        public int IndexOfFirstSelectedItem { get; set; }
        public string SelectedItemName { get; set; }
    }

    public class UIAGetElementPropertiesAsListResponse
    {
        public int NumberOfElementsFound { get; set; }
        public int NumberOfElementsReturned { get; set; }
        public string UIAElementPropertiesJSON { get; set; }
    }

    public class UIAGetElementAtCoordinatesResponse
    {
        public bool ElementFound { get; set; }
        public int ElementHandle { get; set; }
        public string ElementName { get; set; }
        public string ElementClassName { get; set; }
        public string ElementAutomationId { get; set; }
        public string ElementLocalizedControlType { get; set; }
    }

    public class UIAGetMultipleParentElementPropertiesResponse
    {
        public JToken[] UIAParentElements { get; set; }
        public int NumberOfParentElementsReturned { get; set; }
    }

    public class UIASearchForFirstParentElementResponse
    {
        public bool ParentElementFound { get; set; }
        public int ParentElementHandle { get; set; }
        public string ParentElementName { get; set; }
        public string ParentElementClassName { get; set; }
        public string ParentElementAutomationId { get; set; }
        public string ParentElementLocalizedControlType { get; set; }
    }

    public class UIAGetMultipleElementsAsTableResponse
    {
        public int NumberOfCellSubElementsFound { get; set; }
        public int NumberOfCellSubElementsReturned { get; set; }
        public string TableContentsJSON { get; set; }
        public int NumberOfRowsInTable { get; set; }
        public int NumberOfColumnsInTable { get; set; }
        public int ThreadId { get; set; }
    }

    public class UIASetElementScrollPercentageResponse
    {
        public bool UIASetElementScrollPercentageResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class UIAGetElementSearchColourRegionResponse
    {
        public int NumberOfPixelsMatchingColour { get; set; }
        public int ColourMatchBoundingBoxElementLeftPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementRightPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementTopPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxElementBottomPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxElementCenterPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxElementCenterPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenRightPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenTopPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int ColourMatchBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int ColourMatchBoundingBoxScreenCenterPixelYCoord { get; set; }
    }

    public class UIAGlobalMouseClickElementSearchColourRegionResponse
    {
        public bool UIAGlobalMouseClickElementSearchColourRegionResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalMouseClickElementSearchColourRegionmouseButtonInput
    {
        Left,
        Right,
        Middle,
        [EnumMember(Value = "Double left")]
        DoubleLeft
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAGlobalMouseClickElementSearchColourRegionoffsetRelativeToInput
    {
        Center,
        Centre,
        Middle,
        Left,
        Right,
        Top,
        Bottom,
        [EnumMember(Value = "Top Left")]
        TopLeft,
        [EnumMember(Value = "Top Right")]
        TopRight,
        [EnumMember(Value = "Bottom Left")]
        BottomLeft,
        [EnumMember(Value = "Bottom Right")]
        BottomRight
    }

    public class UIAGetWin32WindowsResponse
    {
        public string Win32WindowsJSON { get; set; }
        public int NumberOfWin32Windows { get; set; }
    }

    public class SetUIAElementSearchModeResponse
    {
        public bool SetUIAElementSearchModeResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum setUIAElementSearchModeuIAElementSearchModeInput
    {
        FindAll,
        TreeWalkRaw
    }

    public class GetUIAElementSearchModeResponse
    {
        public string UIAElementSearchMode { get; set; }
    }

    public class UIAGetElementPatternsResponse
    {
        public bool ExpandCollapsePatternAvailable { get; set; }
        public bool InvokePatternAvailable { get; set; }
        public bool RangeValuePatternAvailable { get; set; }
        public bool ScrollPatternAvailable { get; set; }
        public bool SelectionItemPatternAvailable { get; set; }
        public bool TextPatternAvailable { get; set; }
        public bool TogglePatternAvailable { get; set; }
        public bool ValuePatternAvailable { get; set; }
        public bool WindowPatternAvailable { get; set; }
        public bool GridPatternAvailable { get; set; }
        public bool GridItemPatternAvailable { get; set; }
        public bool LegacyIAccessiblePatternAvailable { get; set; }
        public bool SelectionPatternAvailable { get; set; }
        public bool SpreadsheetPatternAvailable { get; set; }
        public bool SpreadsheetItemPatternAvailable { get; set; }
        public bool TablePatternAvailable { get; set; }
        public bool TableItemPatternAvailable { get; set; }
        public bool TextPattern2Available { get; set; }
        public bool TextEditPatternAvailable { get; set; }
        public bool TransformPatternAvailable { get; set; }
    }

    public class UIAMoveElementResponse
    {
        public bool UIAMoveElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAMoveElementhorizontalMovementTypeInput
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAMoveElementverticalMovementTypeInput
    {
        Absolute,
        Relative
    }

    public class UIAResizeElementResponse
    {
        public bool UIAResizeElementResult { get; set; }
        public string ErrorMessage { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAResizeElementresizeWidthTypeInput
    {
        Absolute,
        Relative
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAResizeElementresizeHeightTypeInput
    {
        Absolute,
        Relative
    }

    public class UIALocateVisibleSearchImageWithinElementResponse
    {
        public bool SearchImageLocated { get; set; }
        public int WhichSearchImageLocated { get; set; }
        public int SearchImageBoundingBoxElementLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelYCoord { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIALocateVisibleSearchImageWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIALocateVisibleSearchImageWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIALocateVisibleSearchImageWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIALocateVisibleSearchImageWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIALocateVisibleSearchImageWithinElementimageSearchDirectionInput
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UIAWaitForVisibleSearchImageWithinElementResponse
    {
        public bool SearchImageLocated { get; set; }
        public int WhichSearchImageLocated { get; set; }
        public int SearchImageBoundingBoxElementLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxElementCenterPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenLeftPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenRightPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenTopPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenBottomPixelYCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelXCoord { get; set; }
        public int SearchImageBoundingBoxScreenCenterPixelYCoord { get; set; }
        public int ThreadId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageWithinElementimageSearchDirectionInput
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }

    public class UIAWaitForVisibleSearchImageToNotExistWithinElementResponse
    {
        public bool SearchImagePresentBeforeWait { get; set; }
        public bool SearchImageStillPresentAfterWait { get; set; }
        public int WhichSearchImageStillPresent { get; set; }
        public int ThreadId { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementsearchImageTypeInput
    {
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementaltSearchImageTypeInput
    {
        None,
        [EnumMember(Value = "DirectorFile")]
        DirectorImageFile,
        [EnumMember(Value = "AgentFile")]
        AgentImageFile,
        Base64
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementpixelXOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementpixelYOffsetsUnitInput
    {
        Pixel,
        Percent
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uIAWaitForVisibleSearchImageToNotExistWithinElementimageSearchDirectionInput
    {
        FromTop,
        FromBottom,
        FromLeft,
        FromRight
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectui;

    public partial class WorkflowManagedActions
    {
        public IaconnectuiActions Iaconnectui(string connectionId) => new IaconnectuiActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectuiTriggers Iaconnectui(string connectionId) => new IaconnectuiTriggers(connectionId);
    }
}