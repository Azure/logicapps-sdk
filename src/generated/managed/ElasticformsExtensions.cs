//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Elasticforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElasticformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<AssignFormResponse> AssignForm([WorkflowExpression] Func<string> formAssignBodyuser, [WorkflowExpression] Func<string> formAssignBodyform, [WorkflowExpression] Func<object> formAssignBodyfields = null)
        {
            SourceExpression.Validate(formAssignBodyuser, nameof(formAssignBodyuser), required: true);
            SourceExpression.Validate(formAssignBodyform, nameof(formAssignBodyform), required: true);
            SourceExpression.Validate(formAssignBodyfields, nameof(formAssignBodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/external/Form";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formAssignBody = new JObject();
                var formAssignBodypropCount = 0;
                formAssignBodypropCount++;
                formAssignBody["UserName"] = SourceExpressionConverter.ConvertToken(formAssignBodyuser);
                formAssignBodypropCount++;
                formAssignBody["FormUid"] = SourceExpressionConverter.ConvertToken(formAssignBodyform);
                if (formAssignBodyfields != null)
                {
                    formAssignBody["FormData"] = SourceExpressionConverter.ConvertToken(formAssignBodyfields);
                    formAssignBodypropCount++;
                }

                if (formAssignBodypropCount > 0)
                {
                    callPayload.Body = formAssignBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<AssignFormResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<string> AddData([WorkflowExpression] Func<string> formDataBodyform, [WorkflowExpression] Func<object> formDataBodyfields = null)
        {
            SourceExpression.Validate(formDataBodyform, nameof(formDataBodyform), required: true);
            SourceExpression.Validate(formDataBodyfields, nameof(formDataBodyfields), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/external/FormData";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var formDataBody = new JObject();
                var formDataBodypropCount = 0;
                formDataBodypropCount++;
                formDataBody["FormUid"] = SourceExpressionConverter.ConvertToken(formDataBodyform);
                if (formDataBodyfields != null)
                {
                    formDataBody["FormDataObject"] = SourceExpressionConverter.ConvertToken(formDataBodyfields);
                    formDataBodypropCount++;
                }

                if (formDataBodypropCount > 0)
                {
                    callPayload.Body = formDataBody;
                }
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }
    }

    public class ElasticformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TrigNewResponse([WorkflowExpression] Func<string> requestBodyOfWebhookform, string triggerName = null, FlowRecurrence recurrence = null)
        {
            SourceExpression.Validate(requestBodyOfWebhookform, nameof(requestBodyOfWebhookform), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/external/WebHook";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var requestBodyOfWebhook = new JObject();
                var requestBodyOfWebhookpropCount = 0;
                requestBodyOfWebhook["TriggerUrl"] = "@listCallbackUrl()";
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhookpropCount++;
                requestBodyOfWebhook["FormUid"] = SourceExpressionConverter.ConvertToken(requestBodyOfWebhookform);
                if (requestBodyOfWebhookpropCount > 0)
                {
                    callPayload.Body = requestBodyOfWebhook;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }
    }

    public class AssignFormResponse
    {
        public string AssignedFormUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Elasticforms;

    public partial class WorkflowManagedActions
    {
        public ElasticformsActions Elasticforms(string connectionId) => new ElasticformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElasticformsTriggers Elasticforms(string connectionId) => new ElasticformsTriggers(connectionId);
    }
}