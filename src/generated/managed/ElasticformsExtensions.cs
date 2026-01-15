//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Elasticforms
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ElasticformsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<AssignFormResponse> AssignForm(Expression<Func<string>> formAssignBodyuser, Expression<Func<string>> formAssignBodyform, Expression<Func<object>> formAssignBodyfields = null)
        {
            var apiCallPath = "/api/external/Form";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var formAssignBody = new JObject();
            var formAssignBodypropCount = 0;
            formAssignBodypropCount++;
            formAssignBody["UserName"] = ExpressionConverter.ConvertO(formAssignBodyuser);
            formAssignBodypropCount++;
            formAssignBody["FormUid"] = ExpressionConverter.ConvertO(formAssignBodyform);
            if (formAssignBodyfields != null)
            {
                formAssignBody["FormData"] = ExpressionConverter.ConvertO(formAssignBodyfields);
                formAssignBodypropCount++;
            }

            if (formAssignBodypropCount > 0)
            {
                callPayload.Body = formAssignBody;
            }

            return new ApiConnectionAction<AssignFormResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "elasticforms")]
        public IBodyWorkflowAction<string> AddData(Expression<Func<string>> formDataBodyform, Expression<Func<object>> formDataBodyfields = null)
        {
            var apiCallPath = "/api/external/FormData";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var formDataBody = new JObject();
            var formDataBodypropCount = 0;
            formDataBodypropCount++;
            formDataBody["FormUid"] = ExpressionConverter.ConvertO(formDataBodyform);
            if (formDataBodyfields != null)
            {
                formDataBody["FormDataObject"] = ExpressionConverter.ConvertO(formDataBodyfields);
                formDataBodypropCount++;
            }

            if (formDataBodypropCount > 0)
            {
                callPayload.Body = formDataBody;
            }

            return new ApiConnectionAction<string>(callPayload);
        }
    }

    public class ElasticformsTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger TrigNewResponse(Expression<Func<string>> requestBodyOfWebhookform)
        {
            var apiCallPath = "/api/external/WebHook";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var requestBodyOfWebhook = new JObject();
            var requestBodyOfWebhookpropCount = 0;
            requestBodyOfWebhook["TriggerUrl"] = "@listcallbackurl()";
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhookpropCount++;
            requestBodyOfWebhook["FormUid"] = ExpressionConverter.ConvertO(requestBodyOfWebhookform);
            if (requestBodyOfWebhookpropCount > 0)
            {
                callPayload.Body = requestBodyOfWebhook;
            }

            return new ApiConnectionTrigger(callPayload);
        }
    }

    public class AssignFormResponse
    {
        public string AssignedFormUrl { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Elasticforms;

    public partial class WorkflowManagedActions
    {
        public ElasticformsActions Elasticforms(string connectionId) => new ElasticformsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ElasticformsTriggers Elasticforms(string connectionId) => new ElasticformsTriggers(connectionId);
    }
}