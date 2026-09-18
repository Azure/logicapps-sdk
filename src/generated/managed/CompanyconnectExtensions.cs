//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CompanyconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ChoicePrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string[]> requestchoices = null)
        {
            var apiCallPath = "/choicePrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = ExpressionConverter.ConvertO(requestprompt);
            if (requestchoices != null)
            {
                request["choices"] = ExpressionConverter.ConvertO(requestchoices);
                requestpropCount++;
            }

            requestpropCount++;
            request["conversationReference"] = ExpressionConverter.ConvertO(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ConfirmPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string> requestyesText = null, [WorkflowExpression] Func<string> requestnoText = null)
        {
            var apiCallPath = "/confirmPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = ExpressionConverter.ConvertO(requestprompt);
            if (requestyesText != null)
            {
                if (requestyesText != null)
                {
                    request["yesText"] = ExpressionConverter.ConvertO(requestyesText);
                    requestpropCount++;
                }

                requestpropCount++;
            }
            else
            {
                request["yesText"] = "Yes";
                requestpropCount++;
            }

            if (requestnoText != null)
            {
                if (requestnoText != null)
                {
                    request["noText"] = ExpressionConverter.ConvertO(requestnoText);
                    requestpropCount++;
                }

                requestpropCount++;
            }
            else
            {
                request["noText"] = "No";
                requestpropCount++;
            }

            requestpropCount++;
            request["conversationReference"] = ExpressionConverter.ConvertO(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ProactiveDialogStart([WorkflowExpression(WorkflowExpressionLocation.InlineTemplate)] Func<string> id, [WorkflowExpression] Func<string> bodyupn)
        {
            var apiCallPath = String.Format("/proactiveDialogs/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["upn"] = ExpressionConverter.ConvertO(bodyupn);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction Reply([WorkflowExpression] Func<string> messageActivitytext, [WorkflowExpression] Func<string> messageActivityconversationReference = null)
        {
            var apiCallPath = "/reply";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var messageActivity = new JObject();
            var messageActivitypropCount = 0;
            messageActivitypropCount++;
            messageActivity["text"] = ExpressionConverter.ConvertO(messageActivitytext);
            if (messageActivityconversationReference != null)
            {
                messageActivity["conversationReference"] = ExpressionConverter.ConvertO(messageActivityconversationReference);
                messageActivitypropCount++;
            }

            if (messageActivitypropCount > 0)
            {
                callPayload.Body = messageActivity;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction TextPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference)
        {
            var apiCallPath = "/textPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = ExpressionConverter.ConvertO(requestprompt);
            requestpropCount++;
            request["conversationReference"] = ExpressionConverter.ConvertO(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProactiveDialogSubscribe([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/proactiveDialogs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartDialogSubscribe([WorkflowExpression] Func<string> bodyappId, [WorkflowExpression] Func<string> bodyintent, [WorkflowExpression] Func<string> bodydescription, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/smartDialogs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["appId"] = ExpressionConverter.ConvertO(bodyappId);
            bodypropCount++;
            body["intent"] = ExpressionConverter.ConvertO(bodyintent);
            bodypropCount++;
            body["description"] = ExpressionConverter.ConvertO(bodydescription);
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartSourceSubscribe([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodyicon = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/smartSources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            bodypropCount++;
            body["category"] = ExpressionConverter.ConvertO(bodycategory);
            if (bodyicon != null)
            {
                body["icon"] = ExpressionConverter.ConvertO(bodyicon);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect;

    public partial class WorkflowManagedActions
    {
        public CompanyconnectActions Companyconnect(string connectionId) => new CompanyconnectActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CompanyconnectTriggers Companyconnect(string connectionId) => new CompanyconnectTriggers(connectionId);
    }
}