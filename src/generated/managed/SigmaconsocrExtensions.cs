//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Sigmaconsocr
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class SigmaconsocrActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ProcessjobResponse> Processjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyprocess, [WorkflowExpression] Func<string> bodyaction, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            SourceExpression.Validate(applicationURL, nameof(applicationURL), required: true);
            SourceExpression.Validate(bodyprocess, nameof(bodyprocess), required: true);
            SourceExpression.Validate(bodyaction, nameof(bodyaction), required: true);
            SourceExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: true);
            SourceExpression.Validate(bodywaitForResult, nameof(bodywaitForResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/job/process";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = SourceExpressionConverter.ConvertO(applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["Process"] = SourceExpressionConverter.ConvertToken(bodyprocess);
                bodypropCount++;
                body["Action"] = SourceExpressionConverter.ConvertToken(bodyaction);
                bodypropCount++;
                body["CustomerCode"] = SourceExpressionConverter.ConvertToken(bodycustomerCode);
                if (bodywaitForResult != null)
                {
                    body["WaitForResult"] = SourceExpressionConverter.ConvertToken(bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ProcessjobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ConsolidationjobResponse> Consolidationjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyconsoCode, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            SourceExpression.Validate(applicationURL, nameof(applicationURL), required: true);
            SourceExpression.Validate(bodyconsoCode, nameof(bodyconsoCode), required: true);
            SourceExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: true);
            SourceExpression.Validate(bodywaitForResult, nameof(bodywaitForResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/job/consolidation";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = SourceExpressionConverter.ConvertO(applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ConsoCode"] = SourceExpressionConverter.ConvertToken(bodyconsoCode);
                bodypropCount++;
                body["CustomerCode"] = SourceExpressionConverter.ConvertToken(bodycustomerCode);
                if (bodywaitForResult != null)
                {
                    body["WaitForResult"] = SourceExpressionConverter.ConvertToken(bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ConsolidationjobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ScheduledjobResponse> Scheduledjob([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyjobScheduleName, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            SourceExpression.Validate(applicationURL, nameof(applicationURL), required: true);
            SourceExpression.Validate(bodyjobScheduleName, nameof(bodyjobScheduleName), required: true);
            SourceExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: true);
            SourceExpression.Validate(bodywaitForResult, nameof(bodywaitForResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/job/scheduledjob";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = SourceExpressionConverter.ConvertO(applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["JobScheduleName"] = SourceExpressionConverter.ConvertToken(bodyjobScheduleName);
                bodypropCount++;
                body["CustomerCode"] = SourceExpressionConverter.ConvertToken(bodycustomerCode);
                if (bodywaitForResult != null)
                {
                    body["WaitForResult"] = SourceExpressionConverter.ConvertToken(bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ScheduledjobResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "sigmaconsocr")]
        public IBodyWorkflowAction<ImportFileResponse> ImportFile([WorkflowExpression] Func<string> applicationURL, [WorkflowExpression] Func<string> bodyimportStructureCode, [WorkflowExpression] Func<string> bodycustomerCode, [WorkflowExpression] Func<string> bodybase64File, [WorkflowExpression] Func<bool> bodywaitForResult = null)
        {
            SourceExpression.Validate(applicationURL, nameof(applicationURL), required: true);
            SourceExpression.Validate(bodyimportStructureCode, nameof(bodyimportStructureCode), required: true);
            SourceExpression.Validate(bodycustomerCode, nameof(bodycustomerCode), required: true);
            SourceExpression.Validate(bodybase64File, nameof(bodybase64File), required: true);
            SourceExpression.Validate(bodywaitForResult, nameof(bodywaitForResult), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/hub/import";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["ApplicationURL"] = SourceExpressionConverter.ConvertO(applicationURL);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["ImportStructureCode"] = SourceExpressionConverter.ConvertToken(bodyimportStructureCode);
                bodypropCount++;
                body["CustomerCode"] = SourceExpressionConverter.ConvertToken(bodycustomerCode);
                bodypropCount++;
                body["Base64File"] = SourceExpressionConverter.ConvertToken(bodybase64File);
                if (bodywaitForResult != null)
                {
                    body["WaitForResult"] = SourceExpressionConverter.ConvertToken(bodywaitForResult);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<ImportFileResponse>(BuildSourceInput);
        }
    }

    public class SigmaconsocrTriggers([ConnectionName] string connectionId)
    {
    }

    public class ProcessjobResponse
    {
        public string Message { get; set; }
    }

    public class ConsolidationjobResponse
    {
        public string Message { get; set; }
    }

    public class ScheduledjobResponse
    {
        public string Message { get; set; }
    }

    public class ImportFileResponse
    {
        public string Message { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Sigmaconsocr;

    public partial class WorkflowManagedActions
    {
        public SigmaconsocrActions Sigmaconsocr(string connectionId) => new SigmaconsocrActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public SigmaconsocrTriggers Sigmaconsocr(string connectionId) => new SigmaconsocrTriggers(connectionId);
    }
}