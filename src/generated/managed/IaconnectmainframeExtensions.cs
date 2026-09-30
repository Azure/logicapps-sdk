//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class IaconnectmainframeActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetHLLAPIdLL([WorkflowExpression] Func<string> hLLAPISetHLLAPIdLLdLLFilename, [WorkflowExpression] Func<string> hLLAPISetHLLAPIdLLworkflow, [WorkflowExpression] Func<string> hLLAPISetHLLAPIdLLiAHLLAPIPath = null, [WorkflowExpression] Func<string> hLLAPISetHLLAPIdLLentryPointName = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIdLLisEnhancedInterface = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIdLLis64BitHLLAPIdLL = null, [WorkflowExpression] Func<bool> hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL = null)
        {
            SourceExpression.Validate(hLLAPISetHLLAPIdLLdLLFilename, nameof(hLLAPISetHLLAPIdLLdLLFilename), required: true);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLworkflow, nameof(hLLAPISetHLLAPIdLLworkflow), required: true);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLiAHLLAPIPath, nameof(hLLAPISetHLLAPIdLLiAHLLAPIPath), required: false);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLentryPointName, nameof(hLLAPISetHLLAPIdLLentryPointName), required: false);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLisEnhancedInterface, nameof(hLLAPISetHLLAPIdLLisEnhancedInterface), required: false);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLis64BitHLLAPIdLL, nameof(hLLAPISetHLLAPIdLLis64BitHLLAPIdLL), required: false);
            SourceExpression.Validate(hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL, nameof(hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISetHLLAPIDLL";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetHLLAPIdLL = new JObject();
                var hLLAPISetHLLAPIdLLpropCount = 0;
                hLLAPISetHLLAPIdLLpropCount++;
                hLLAPISetHLLAPIdLL["DLLFilename"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLdLLFilename);
                if (hLLAPISetHLLAPIdLLiAHLLAPIPath != null)
                {
                    hLLAPISetHLLAPIdLL["IAHLLAPIPath"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLiAHLLAPIPath);
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (hLLAPISetHLLAPIdLLentryPointName != null)
                {
                    hLLAPISetHLLAPIdLL["EntryPointName"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLentryPointName);
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (hLLAPISetHLLAPIdLLisEnhancedInterface != null)
                {
                    if (hLLAPISetHLLAPIdLLisEnhancedInterface != null)
                    {
                        hLLAPISetHLLAPIdLL["IsEnhancedInterface"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLisEnhancedInterface);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["IsEnhancedInterface"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (hLLAPISetHLLAPIdLLis64BitHLLAPIdLL != null)
                {
                    if (hLLAPISetHLLAPIdLLis64BitHLLAPIdLL != null)
                    {
                        hLLAPISetHLLAPIdLL["Is64BitHLLAPIDLL"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLis64BitHLLAPIdLL);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["Is64BitHLLAPIDLL"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                if (hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL != null)
                {
                    if (hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL != null)
                    {
                        hLLAPISetHLLAPIdLL["UseCOMFor64BitHLLAPIDLL"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLuseCOMFor64BitHLLAPIdLL);
                        hLLAPISetHLLAPIdLLpropCount++;
                    }

                    hLLAPISetHLLAPIdLLpropCount++;
                }
                else
                {
                    hLLAPISetHLLAPIdLL["UseCOMFor64BitHLLAPIDLL"] = false;
                    hLLAPISetHLLAPIdLLpropCount++;
                }

                hLLAPISetHLLAPIdLLpropCount++;
                hLLAPISetHLLAPIdLL["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISetHLLAPIdLLworkflow);
                if (hLLAPISetHLLAPIdLLpropCount > 0)
                {
                    callPayload.Body = hLLAPISetHLLAPIdLL;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDispose([WorkflowExpression] Func<string> hLLAPIDisposeworkflow)
        {
            SourceExpression.Validate(hLLAPIDisposeworkflow, nameof(hLLAPIDisposeworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIDispose";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDispose = new JObject();
                var hLLAPIDisposepropCount = 0;
                hLLAPIDisposepropCount++;
                hLLAPIDispose["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIDisposeworkflow);
                if (hLLAPIDisposepropCount > 0)
                {
                    callPayload.Body = hLLAPIDispose;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIConnect([WorkflowExpression] Func<string> hLLAPIConnectsessionId, [WorkflowExpression] Func<string> hLLAPIConnectworkflow)
        {
            SourceExpression.Validate(hLLAPIConnectsessionId, nameof(hLLAPIConnectsessionId), required: true);
            SourceExpression.Validate(hLLAPIConnectworkflow, nameof(hLLAPIConnectworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIConnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIConnect = new JObject();
                var hLLAPIConnectpropCount = 0;
                hLLAPIConnectpropCount++;
                hLLAPIConnect["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIConnectsessionId);
                hLLAPIConnectpropCount++;
                hLLAPIConnect["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIConnectworkflow);
                if (hLLAPIConnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIConnect;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetConnectStatusResponse> HLLAPIGetConnectStatus([WorkflowExpression] Func<string> hLLAPIGetConnectStatussessionId, [WorkflowExpression] Func<string> hLLAPIGetConnectStatusworkflow)
        {
            SourceExpression.Validate(hLLAPIGetConnectStatussessionId, nameof(hLLAPIGetConnectStatussessionId), required: true);
            SourceExpression.Validate(hLLAPIGetConnectStatusworkflow, nameof(hLLAPIGetConnectStatusworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetConnectStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetConnectStatus = new JObject();
                var hLLAPIGetConnectStatuspropCount = 0;
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIGetConnectStatussessionId);
                hLLAPIGetConnectStatuspropCount++;
                hLLAPIGetConnectStatus["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIGetConnectStatusworkflow);
                if (hLLAPIGetConnectStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIGetConnectStatus;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIGetConnectStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIDisconnect([WorkflowExpression] Func<string> hLLAPIDisconnectsessionId, [WorkflowExpression] Func<string> hLLAPIDisconnectworkflow)
        {
            SourceExpression.Validate(hLLAPIDisconnectsessionId, nameof(hLLAPIDisconnectsessionId), required: true);
            SourceExpression.Validate(hLLAPIDisconnectworkflow, nameof(hLLAPIDisconnectworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIDisconnect";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIDisconnect = new JObject();
                var hLLAPIDisconnectpropCount = 0;
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIDisconnectsessionId);
                hLLAPIDisconnectpropCount++;
                hLLAPIDisconnect["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIDisconnectworkflow);
                if (hLLAPIDisconnectpropCount > 0)
                {
                    callPayload.Body = hLLAPIDisconnect;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetCursorPos([WorkflowExpression] Func<string> hLLAPISetCursorPossessionId, [WorkflowExpression] Func<int> hLLAPISetCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISetCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISetCursorPosworkflow)
        {
            SourceExpression.Validate(hLLAPISetCursorPossessionId, nameof(hLLAPISetCursorPossessionId), required: true);
            SourceExpression.Validate(hLLAPISetCursorPoscursorRowIndex, nameof(hLLAPISetCursorPoscursorRowIndex), required: true);
            SourceExpression.Validate(hLLAPISetCursorPoscursorColIndex, nameof(hLLAPISetCursorPoscursorColIndex), required: true);
            SourceExpression.Validate(hLLAPISetCursorPosworkflow, nameof(hLLAPISetCursorPosworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetCursorPos = new JObject();
                var hLLAPISetCursorPospropCount = 0;
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPISetCursorPossessionId);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISetCursorPoscursorRowIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["CursorColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISetCursorPoscursorColIndex);
                hLLAPISetCursorPospropCount++;
                hLLAPISetCursorPos["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISetCursorPosworkflow);
                if (hLLAPISetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISetCursorPos;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIGetCursorPosResponse> HLLAPIGetCursorPos([WorkflowExpression] Func<string> hLLAPIGetCursorPossessionId, [WorkflowExpression] Func<string> hLLAPIGetCursorPosworkflow)
        {
            SourceExpression.Validate(hLLAPIGetCursorPossessionId, nameof(hLLAPIGetCursorPossessionId), required: true);
            SourceExpression.Validate(hLLAPIGetCursorPosworkflow, nameof(hLLAPIGetCursorPosworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIGetCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIGetCursorPos = new JObject();
                var hLLAPIGetCursorPospropCount = 0;
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIGetCursorPossessionId);
                hLLAPIGetCursorPospropCount++;
                hLLAPIGetCursorPos["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIGetCursorPosworkflow);
                if (hLLAPIGetCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIGetCursorPos;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIGetCursorPosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendString([WorkflowExpression] Func<string> hLLAPISendStringinputString, [WorkflowExpression] Func<string> hLLAPISendStringworkflow)
        {
            SourceExpression.Validate(hLLAPISendStringinputString, nameof(hLLAPISendStringinputString), required: true);
            SourceExpression.Validate(hLLAPISendStringworkflow, nameof(hLLAPISendStringworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISendString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendString = new JObject();
                var hLLAPISendStringpropCount = 0;
                hLLAPISendStringpropCount++;
                hLLAPISendString["InputString"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringinputString);
                hLLAPISendStringpropCount++;
                hLLAPISendString["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringworkflow);
                if (hLLAPISendStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISendString;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPassword([WorkflowExpression] Func<string> hLLAPISendPasswordinputPassword, [WorkflowExpression] Func<string> hLLAPISendPasswordworkflow)
        {
            SourceExpression.Validate(hLLAPISendPasswordinputPassword, nameof(hLLAPISendPasswordinputPassword), required: true);
            SourceExpression.Validate(hLLAPISendPasswordworkflow, nameof(hLLAPISendPasswordworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPassword";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPassword = new JObject();
                var hLLAPISendPasswordpropCount = 0;
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["InputPassword"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordinputPassword);
                hLLAPISendPasswordpropCount++;
                hLLAPISendPassword["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordworkflow);
                if (hLLAPISendPasswordpropCount > 0)
                {
                    callPayload.Body = hLLAPISendPassword;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendStringAtCursorPos([WorkflowExpression] Func<string> hLLAPISendStringAtCursorPossessionId, [WorkflowExpression] Func<int> hLLAPISendStringAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISendStringAtCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISendStringAtCursorPosinputString, [WorkflowExpression] Func<string> hLLAPISendStringAtCursorPosworkflow)
        {
            SourceExpression.Validate(hLLAPISendStringAtCursorPossessionId, nameof(hLLAPISendStringAtCursorPossessionId), required: true);
            SourceExpression.Validate(hLLAPISendStringAtCursorPoscursorRowIndex, nameof(hLLAPISendStringAtCursorPoscursorRowIndex), required: true);
            SourceExpression.Validate(hLLAPISendStringAtCursorPoscursorColIndex, nameof(hLLAPISendStringAtCursorPoscursorColIndex), required: true);
            SourceExpression.Validate(hLLAPISendStringAtCursorPosinputString, nameof(hLLAPISendStringAtCursorPosinputString), required: true);
            SourceExpression.Validate(hLLAPISendStringAtCursorPosworkflow, nameof(hLLAPISendStringAtCursorPosworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISendStringAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendStringAtCursorPos = new JObject();
                var hLLAPISendStringAtCursorPospropCount = 0;
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPossessionId);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPoscursorRowIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["CursorColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPoscursorColIndex);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["InputString"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPosinputString);
                hLLAPISendStringAtCursorPospropCount++;
                hLLAPISendStringAtCursorPos["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISendStringAtCursorPosworkflow);
                if (hLLAPISendStringAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendStringAtCursorPos;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISendPasswordAtCursorPos([WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPossessionId, [WorkflowExpression] Func<int> hLLAPISendPasswordAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPISendPasswordAtCursorPoscursorColIndex, [WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPosinputPassword, [WorkflowExpression] Func<string> hLLAPISendPasswordAtCursorPosworkflow)
        {
            SourceExpression.Validate(hLLAPISendPasswordAtCursorPossessionId, nameof(hLLAPISendPasswordAtCursorPossessionId), required: true);
            SourceExpression.Validate(hLLAPISendPasswordAtCursorPoscursorRowIndex, nameof(hLLAPISendPasswordAtCursorPoscursorRowIndex), required: true);
            SourceExpression.Validate(hLLAPISendPasswordAtCursorPoscursorColIndex, nameof(hLLAPISendPasswordAtCursorPoscursorColIndex), required: true);
            SourceExpression.Validate(hLLAPISendPasswordAtCursorPosinputPassword, nameof(hLLAPISendPasswordAtCursorPosinputPassword), required: true);
            SourceExpression.Validate(hLLAPISendPasswordAtCursorPosworkflow, nameof(hLLAPISendPasswordAtCursorPosworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISendPasswordAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISendPasswordAtCursorPos = new JObject();
                var hLLAPISendPasswordAtCursorPospropCount = 0;
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPossessionId);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPoscursorRowIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["CursorColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPoscursorColIndex);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["InputPassword"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPosinputPassword);
                hLLAPISendPasswordAtCursorPospropCount++;
                hLLAPISendPasswordAtCursorPos["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISendPasswordAtCursorPosworkflow);
                if (hLLAPISendPasswordAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPISendPasswordAtCursorPos;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenAtCursorPosResponse> HLLAPIReadScreenAtCursorPos([WorkflowExpression] Func<string> hLLAPIReadScreenAtCursorPossessionId, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPoscursorRowIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPoscursorColIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenAtCursorPosreadScreenLength, [WorkflowExpression] Func<string> hLLAPIReadScreenAtCursorPosworkflow)
        {
            SourceExpression.Validate(hLLAPIReadScreenAtCursorPossessionId, nameof(hLLAPIReadScreenAtCursorPossessionId), required: true);
            SourceExpression.Validate(hLLAPIReadScreenAtCursorPoscursorRowIndex, nameof(hLLAPIReadScreenAtCursorPoscursorRowIndex), required: true);
            SourceExpression.Validate(hLLAPIReadScreenAtCursorPoscursorColIndex, nameof(hLLAPIReadScreenAtCursorPoscursorColIndex), required: true);
            SourceExpression.Validate(hLLAPIReadScreenAtCursorPosreadScreenLength, nameof(hLLAPIReadScreenAtCursorPosreadScreenLength), required: true);
            SourceExpression.Validate(hLLAPIReadScreenAtCursorPosworkflow, nameof(hLLAPIReadScreenAtCursorPosworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenAtCursorPos";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenAtCursorPos = new JObject();
                var hLLAPIReadScreenAtCursorPospropCount = 0;
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPossessionId);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPoscursorRowIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["CursorColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPoscursorColIndex);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["ReadScreenLength"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPosreadScreenLength);
                hLLAPIReadScreenAtCursorPospropCount++;
                hLLAPIReadScreenAtCursorPos["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenAtCursorPosworkflow);
                if (hLLAPIReadScreenAtCursorPospropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenAtCursorPos;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIReadScreenAtCursorPosResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIQuerySessionStatusResponse> HLLAPIQuerySessionStatus([WorkflowExpression] Func<string> hLLAPIQuerySessionStatusworkflow)
        {
            SourceExpression.Validate(hLLAPIQuerySessionStatusworkflow, nameof(hLLAPIQuerySessionStatusworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIQuerySessionStatus";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIQuerySessionStatus = new JObject();
                var hLLAPIQuerySessionStatuspropCount = 0;
                hLLAPIQuerySessionStatuspropCount++;
                hLLAPIQuerySessionStatus["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIQuerySessionStatusworkflow);
                if (hLLAPIQuerySessionStatuspropCount > 0)
                {
                    callPayload.Body = hLLAPIQuerySessionStatus;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIQuerySessionStatusResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIReadScreenRowsResponse> HLLAPIReadScreenRows([WorkflowExpression] Func<string> hLLAPIReadScreenRowssessionId, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsstartRowIndex, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsendRowIndex, [WorkflowExpression] Func<string> hLLAPIReadScreenRowsworkflow, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsnumberOfRowsInSession = null, [WorkflowExpression] Func<int> hLLAPIReadScreenRowsnumberOfColumnsInSession = null)
        {
            SourceExpression.Validate(hLLAPIReadScreenRowssessionId, nameof(hLLAPIReadScreenRowssessionId), required: true);
            SourceExpression.Validate(hLLAPIReadScreenRowsstartRowIndex, nameof(hLLAPIReadScreenRowsstartRowIndex), required: true);
            SourceExpression.Validate(hLLAPIReadScreenRowsendRowIndex, nameof(hLLAPIReadScreenRowsendRowIndex), required: true);
            SourceExpression.Validate(hLLAPIReadScreenRowsworkflow, nameof(hLLAPIReadScreenRowsworkflow), required: true);
            SourceExpression.Validate(hLLAPIReadScreenRowsnumberOfRowsInSession, nameof(hLLAPIReadScreenRowsnumberOfRowsInSession), required: false);
            SourceExpression.Validate(hLLAPIReadScreenRowsnumberOfColumnsInSession, nameof(hLLAPIReadScreenRowsnumberOfColumnsInSession), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIReadScreenRows";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIReadScreenRows = new JObject();
                var hLLAPIReadScreenRowspropCount = 0;
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowssessionId);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["StartRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowsstartRowIndex);
                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["EndRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowsendRowIndex);
                if (hLLAPIReadScreenRowsnumberOfRowsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfRowsInSession"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowsnumberOfRowsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                if (hLLAPIReadScreenRowsnumberOfColumnsInSession != null)
                {
                    hLLAPIReadScreenRows["NumberOfColumnsInSession"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowsnumberOfColumnsInSession);
                    hLLAPIReadScreenRowspropCount++;
                }

                hLLAPIReadScreenRowspropCount++;
                hLLAPIReadScreenRows["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIReadScreenRowsworkflow);
                if (hLLAPIReadScreenRowspropCount > 0)
                {
                    callPayload.Body = hLLAPIReadScreenRows;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIReadScreenRowsResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIIsKeyboardUnlockedResponse> HLLAPIIsKeyboardUnlocked([WorkflowExpression] Func<string> hLLAPIIsKeyboardUnlockedworkflow)
        {
            SourceExpression.Validate(hLLAPIIsKeyboardUnlockedworkflow, nameof(hLLAPIIsKeyboardUnlockedworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIIsKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIIsKeyboardUnlocked = new JObject();
                var hLLAPIIsKeyboardUnlockedpropCount = 0;
                hLLAPIIsKeyboardUnlockedpropCount++;
                hLLAPIIsKeyboardUnlocked["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIIsKeyboardUnlockedworkflow);
                if (hLLAPIIsKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIIsKeyboardUnlocked;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIIsKeyboardUnlockedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForKeyboardUnlockedResponse> HLLAPIWaitForKeyboardUnlocked([WorkflowExpression] Func<double> hLLAPIWaitForKeyboardUnlockedsecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForKeyboardUnlockedworkflow, [WorkflowExpression] Func<double> hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait = null)
        {
            SourceExpression.Validate(hLLAPIWaitForKeyboardUnlockedsecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockedsecondsToWait), required: true);
            SourceExpression.Validate(hLLAPIWaitForKeyboardUnlockedworkflow, nameof(hLLAPIWaitForKeyboardUnlockedworkflow), required: true);
            SourceExpression.Validate(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait, nameof(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForKeyboardUnlocked";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForKeyboardUnlocked = new JObject();
                var hLLAPIWaitForKeyboardUnlockedpropCount = 0;
                hLLAPIWaitForKeyboardUnlockedpropCount++;
                hLLAPIWaitForKeyboardUnlocked["SecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockedsecondsToWait);
                if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockeddeltaSecondsToWait);
                        hLLAPIWaitForKeyboardUnlockedpropCount++;
                    }

                    hLLAPIWaitForKeyboardUnlockedpropCount++;
                }
                else
                {
                    hLLAPIWaitForKeyboardUnlocked["DeltaSecondsToWait"] = 0.05;
                    hLLAPIWaitForKeyboardUnlockedpropCount++;
                }

                hLLAPIWaitForKeyboardUnlockedpropCount++;
                hLLAPIWaitForKeyboardUnlocked["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForKeyboardUnlockedworkflow);
                if (hLLAPIWaitForKeyboardUnlockedpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForKeyboardUnlocked;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIWaitForKeyboardUnlockedResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForSystemReadyResponse> HLLAPIWaitForSystemReady([WorkflowExpression] Func<double> hLLAPIWaitForSystemReadysecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForSystemReadyworkflow, [WorkflowExpression] Func<double> hLLAPIWaitForSystemReadydeltaSecondsToWait = null)
        {
            SourceExpression.Validate(hLLAPIWaitForSystemReadysecondsToWait, nameof(hLLAPIWaitForSystemReadysecondsToWait), required: true);
            SourceExpression.Validate(hLLAPIWaitForSystemReadyworkflow, nameof(hLLAPIWaitForSystemReadyworkflow), required: true);
            SourceExpression.Validate(hLLAPIWaitForSystemReadydeltaSecondsToWait, nameof(hLLAPIWaitForSystemReadydeltaSecondsToWait), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForSystemReady";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForSystemReady = new JObject();
                var hLLAPIWaitForSystemReadypropCount = 0;
                hLLAPIWaitForSystemReadypropCount++;
                hLLAPIWaitForSystemReady["SecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadysecondsToWait);
                if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForSystemReadydeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadydeltaSecondsToWait);
                        hLLAPIWaitForSystemReadypropCount++;
                    }

                    hLLAPIWaitForSystemReadypropCount++;
                }
                else
                {
                    hLLAPIWaitForSystemReady["DeltaSecondsToWait"] = 0.05;
                    hLLAPIWaitForSystemReadypropCount++;
                }

                hLLAPIWaitForSystemReadypropCount++;
                hLLAPIWaitForSystemReady["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForSystemReadyworkflow);
                if (hLLAPIWaitForSystemReadypropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForSystemReady;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIWaitForSystemReadyResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIPressReset([WorkflowExpression] Func<string> hLLAPIPressResetworkflow)
        {
            SourceExpression.Validate(hLLAPIPressResetworkflow, nameof(hLLAPIPressResetworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIPressReset";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIPressReset = new JObject();
                var hLLAPIPressResetpropCount = 0;
                hLLAPIPressResetpropCount++;
                hLLAPIPressReset["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIPressResetworkflow);
                if (hLLAPIPressResetpropCount > 0)
                {
                    callPayload.Body = hLLAPIPressReset;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPISearchForStringResponse> HLLAPISearchForString([WorkflowExpression] Func<string> hLLAPISearchForStringsessionId, [WorkflowExpression] Func<string> hLLAPISearchForStringsearchString, [WorkflowExpression] Func<string> hLLAPISearchForStringworkflow, [WorkflowExpression] Func<bool> hLLAPISearchForStringsearchEntireScreen = null, [WorkflowExpression] Func<int> hLLAPISearchForStringsearchStartRowIndex = null, [WorkflowExpression] Func<int> hLLAPISearchForStringsearchStartColIndex = null)
        {
            SourceExpression.Validate(hLLAPISearchForStringsessionId, nameof(hLLAPISearchForStringsessionId), required: true);
            SourceExpression.Validate(hLLAPISearchForStringsearchString, nameof(hLLAPISearchForStringsearchString), required: true);
            SourceExpression.Validate(hLLAPISearchForStringworkflow, nameof(hLLAPISearchForStringworkflow), required: true);
            SourceExpression.Validate(hLLAPISearchForStringsearchEntireScreen, nameof(hLLAPISearchForStringsearchEntireScreen), required: false);
            SourceExpression.Validate(hLLAPISearchForStringsearchStartRowIndex, nameof(hLLAPISearchForStringsearchStartRowIndex), required: false);
            SourceExpression.Validate(hLLAPISearchForStringsearchStartColIndex, nameof(hLLAPISearchForStringsearchStartColIndex), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISearchForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISearchForString = new JObject();
                var hLLAPISearchForStringpropCount = 0;
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringsessionId);
                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["SearchString"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringsearchString);
                if (hLLAPISearchForStringsearchEntireScreen != null)
                {
                    if (hLLAPISearchForStringsearchEntireScreen != null)
                    {
                        hLLAPISearchForString["SearchEntireScreen"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringsearchEntireScreen);
                        hLLAPISearchForStringpropCount++;
                    }

                    hLLAPISearchForStringpropCount++;
                }
                else
                {
                    hLLAPISearchForString["SearchEntireScreen"] = true;
                    hLLAPISearchForStringpropCount++;
                }

                if (hLLAPISearchForStringsearchStartRowIndex != null)
                {
                    hLLAPISearchForString["SearchStartRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringsearchStartRowIndex);
                    hLLAPISearchForStringpropCount++;
                }

                if (hLLAPISearchForStringsearchStartColIndex != null)
                {
                    hLLAPISearchForString["SearchStartColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringsearchStartColIndex);
                    hLLAPISearchForStringpropCount++;
                }

                hLLAPISearchForStringpropCount++;
                hLLAPISearchForString["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISearchForStringworkflow);
                if (hLLAPISearchForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPISearchForString;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPISearchForStringResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPIWaitForStringResponse> HLLAPIWaitForString([WorkflowExpression] Func<string> hLLAPIWaitForStringsessionId, [WorkflowExpression] Func<string> hLLAPIWaitForStringsearchString, [WorkflowExpression] Func<double> hLLAPIWaitForStringsecondsToWait, [WorkflowExpression] Func<string> hLLAPIWaitForStringworkflow, [WorkflowExpression] Func<bool> hLLAPIWaitForStringsearchEntireScreen = null, [WorkflowExpression] Func<int> hLLAPIWaitForStringsearchStartRowIndex = null, [WorkflowExpression] Func<int> hLLAPIWaitForStringsearchStartColIndex = null, [WorkflowExpression] Func<double> hLLAPIWaitForStringdeltaSecondsToWait = null)
        {
            SourceExpression.Validate(hLLAPIWaitForStringsessionId, nameof(hLLAPIWaitForStringsessionId), required: true);
            SourceExpression.Validate(hLLAPIWaitForStringsearchString, nameof(hLLAPIWaitForStringsearchString), required: true);
            SourceExpression.Validate(hLLAPIWaitForStringsecondsToWait, nameof(hLLAPIWaitForStringsecondsToWait), required: true);
            SourceExpression.Validate(hLLAPIWaitForStringworkflow, nameof(hLLAPIWaitForStringworkflow), required: true);
            SourceExpression.Validate(hLLAPIWaitForStringsearchEntireScreen, nameof(hLLAPIWaitForStringsearchEntireScreen), required: false);
            SourceExpression.Validate(hLLAPIWaitForStringsearchStartRowIndex, nameof(hLLAPIWaitForStringsearchStartRowIndex), required: false);
            SourceExpression.Validate(hLLAPIWaitForStringsearchStartColIndex, nameof(hLLAPIWaitForStringsearchStartColIndex), required: false);
            SourceExpression.Validate(hLLAPIWaitForStringdeltaSecondsToWait, nameof(hLLAPIWaitForStringdeltaSecondsToWait), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIWaitForString";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIWaitForString = new JObject();
                var hLLAPIWaitForStringpropCount = 0;
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SessionID"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsessionId);
                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SearchString"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchString);
                if (hLLAPIWaitForStringsearchEntireScreen != null)
                {
                    if (hLLAPIWaitForStringsearchEntireScreen != null)
                    {
                        hLLAPIWaitForString["SearchEntireScreen"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchEntireScreen);
                        hLLAPIWaitForStringpropCount++;
                    }

                    hLLAPIWaitForStringpropCount++;
                }
                else
                {
                    hLLAPIWaitForString["SearchEntireScreen"] = true;
                    hLLAPIWaitForStringpropCount++;
                }

                if (hLLAPIWaitForStringsearchStartRowIndex != null)
                {
                    hLLAPIWaitForString["SearchStartRowIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchStartRowIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                if (hLLAPIWaitForStringsearchStartColIndex != null)
                {
                    hLLAPIWaitForString["SearchStartColIndex"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsearchStartColIndex);
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["SecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringsecondsToWait);
                if (hLLAPIWaitForStringdeltaSecondsToWait != null)
                {
                    if (hLLAPIWaitForStringdeltaSecondsToWait != null)
                    {
                        hLLAPIWaitForString["DeltaSecondsToWait"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringdeltaSecondsToWait);
                        hLLAPIWaitForStringpropCount++;
                    }

                    hLLAPIWaitForStringpropCount++;
                }
                else
                {
                    hLLAPIWaitForString["DeltaSecondsToWait"] = 0.05;
                    hLLAPIWaitForStringpropCount++;
                }

                hLLAPIWaitForStringpropCount++;
                hLLAPIWaitForString["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIWaitForStringworkflow);
                if (hLLAPIWaitForStringpropCount > 0)
                {
                    callPayload.Body = hLLAPIWaitForString;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPIWaitForStringResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPISetSessionParameter([WorkflowExpression] Func<string> hLLAPISetSessionParameterparameter, [WorkflowExpression] Func<string> hLLAPISetSessionParameterworkflow)
        {
            SourceExpression.Validate(hLLAPISetSessionParameterparameter, nameof(hLLAPISetSessionParameterparameter), required: true);
            SourceExpression.Validate(hLLAPISetSessionParameterworkflow, nameof(hLLAPISetSessionParameterworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPISetSessionParameter";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPISetSessionParameter = new JObject();
                var hLLAPISetSessionParameterpropCount = 0;
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Parameter"] = SourceExpressionConverter.ConvertToken(hLLAPISetSessionParameterparameter);
                hLLAPISetSessionParameterpropCount++;
                hLLAPISetSessionParameter["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPISetSessionParameterworkflow);
                if (hLLAPISetSessionParameterpropCount > 0)
                {
                    callPayload.Body = hLLAPISetSessionParameter;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IWorkflowAction HLLAPIResetSystem([WorkflowExpression] Func<string> hLLAPIResetSystemworkflow)
        {
            SourceExpression.Validate(hLLAPIResetSystemworkflow, nameof(hLLAPIResetSystemworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPIResetSystem";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPIResetSystem = new JObject();
                var hLLAPIResetSystempropCount = 0;
                hLLAPIResetSystempropCount++;
                hLLAPIResetSystem["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPIResetSystemworkflow);
                if (hLLAPIResetSystempropCount > 0)
                {
                    callPayload.Body = hLLAPIResetSystem;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "iaconnectmainframe")]
        public IBodyWorkflowAction<HLLAPICopyOperatorInformationAreaResponse> HLLAPICopyOperatorInformationArea([WorkflowExpression] Func<string> hLLAPICopyOperatorInformationAreaworkflow)
        {
            SourceExpression.Validate(hLLAPICopyOperatorInformationAreaworkflow, nameof(hLLAPICopyOperatorInformationAreaworkflow), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/HLLAPI/HLLAPICopyOperatorInformationArea";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var hLLAPICopyOperatorInformationArea = new JObject();
                var hLLAPICopyOperatorInformationAreapropCount = 0;
                hLLAPICopyOperatorInformationAreapropCount++;
                hLLAPICopyOperatorInformationArea["Workflow"] = SourceExpressionConverter.ConvertToken(hLLAPICopyOperatorInformationAreaworkflow);
                if (hLLAPICopyOperatorInformationAreapropCount > 0)
                {
                    callPayload.Body = hLLAPICopyOperatorInformationArea;
                }
                return callPayload;
            }

            return new ApiConnectionAction<HLLAPICopyOperatorInformationAreaResponse>(BuildSourceInput);
        }
    }

    public class IaconnectmainframeTriggers([ConnectionName] string connectionId)
    {
    }

    public class HLLAPIGetConnectStatusResponse
    {
        public bool ConnectedToSession { get; set; }
        public bool SystemBusy { get; set; }
        public bool KeyboardLocked { get; set; }
        public bool SessionInUseByAnotherHLLAPIApplication { get; set; }
        public int HLLAPIThreadID { get; set; }
        public int COMThreadID { get; set; }
        public int CallCount { get; set; }
    }

    public class HLLAPIGetCursorPosResponse
    {
        public int CursorRowIndex { get; set; }
        public int CursorColIndex { get; set; }
        public int CursorPos { get; set; }
    }

    public class HLLAPIReadScreenAtCursorPosResponse
    {
        public string ScreenContents { get; set; }
    }

    public class HLLAPIQuerySessionStatusResponse
    {
        public string SessionLongName { get; set; }
        public string SessionType { get; set; }
        public int NumberOfRows { get; set; }
        public int NumberOfCols { get; set; }
        public int CodePage { get; set; }
    }

    public class HLLAPIReadScreenRowsResponse
    {
        public string ScreenRowsJSON { get; set; }
    }

    public class HLLAPIIsKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIWaitForKeyboardUnlockedResponse
    {
        public bool KeyBoardIsUnlocked { get; set; }
    }

    public class HLLAPIWaitForSystemReadyResponse
    {
        public bool SystemReady { get; set; }
    }

    public class HLLAPISearchForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPIWaitForStringResponse
    {
        public bool StringFound { get; set; }
        public int StringFoundPosition { get; set; }
        public int StringFoundRowIndex { get; set; }
        public int StringFoundColIndex { get; set; }
    }

    public class HLLAPICopyOperatorInformationAreaResponse
    {
        public string OIAFormat { get; set; }
        public bool SystemWait { get; set; }
        public bool CAPS { get; set; }
        public bool ShiftKey { get; set; }
        public bool SubsystemReady { get; set; }
        public bool InsertMode { get; set; }
        public bool InvalidInput { get; set; }
        public string InputType { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Iaconnectmainframe;

    public partial class WorkflowManagedActions
    {
        public IaconnectmainframeActions Iaconnectmainframe(string connectionId) => new IaconnectmainframeActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public IaconnectmainframeTriggers Iaconnectmainframe(string connectionId) => new IaconnectmainframeTriggers(connectionId);
    }
}