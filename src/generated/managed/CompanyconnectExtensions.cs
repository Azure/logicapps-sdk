//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CompanyconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ChoicePrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string[]>> requestchoices = null)
        {
            var apiCallPath = "/choicePrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = CSharpExpressionConverter.ConvertToken(requestprompt);
            if (requestchoices != null)
            {
                request["choices"] = CSharpExpressionConverter.ConvertToken(requestchoices);
                requestpropCount++;
            }

            requestpropCount++;
            request["conversationReference"] = CSharpExpressionConverter.ConvertToken(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ConfirmPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string>> requestyesText = null, Expression<Func<string>> requestnoText = null)
        {
            var apiCallPath = "/confirmPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = CSharpExpressionConverter.ConvertToken(requestprompt);
            if (requestyesText != null)
            {
                if (requestyesText != null)
                {
                    request["yesText"] = CSharpExpressionConverter.ConvertToken(requestyesText);
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
                    request["noText"] = CSharpExpressionConverter.ConvertToken(requestnoText);
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
            request["conversationReference"] = CSharpExpressionConverter.ConvertToken(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ProactiveDialogStart(Expression<Func<string>> id, Expression<Func<string>> bodyupn)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/proactiveDialogs/{0}/start", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["upn"] = CSharpExpressionConverter.ConvertToken(bodyupn);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction Reply(Expression<Func<string>> messageActivitytext, Expression<Func<string>> messageActivityconversationReference = null)
        {
            var apiCallPath = "/reply";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var messageActivity = new JObject();
            var messageActivitypropCount = 0;
            messageActivitypropCount++;
            messageActivity["text"] = CSharpExpressionConverter.ConvertToken(messageActivitytext);
            if (messageActivityconversationReference != null)
            {
                messageActivity["conversationReference"] = CSharpExpressionConverter.ConvertToken(messageActivityconversationReference);
                messageActivitypropCount++;
            }

            if (messageActivitypropCount > 0)
            {
                callPayload.Body = messageActivity;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction TextPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference)
        {
            var apiCallPath = "/textPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listCallbackUrl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = CSharpExpressionConverter.ConvertToken(requestprompt);
            requestpropCount++;
            request["conversationReference"] = CSharpExpressionConverter.ConvertToken(requestconversationReference);
            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction(callPayload);
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProactiveDialogSubscribe(Expression<Func<string>> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/proactiveDialogs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartDialogSubscribe(Expression<Func<string>> bodyappId, Expression<Func<string>> bodyintent, Expression<Func<string>> bodydescription, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/smartDialogs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["appId"] = CSharpExpressionConverter.ConvertToken(bodyappId);
            bodypropCount++;
            body["intent"] = CSharpExpressionConverter.ConvertToken(bodyintent);
            bodypropCount++;
            body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartSourceSubscribe(Expression<Func<string>> bodytitle, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyicon = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            var apiCallPath = "/smartSources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listCallbackUrl()";
            bodypropCount++;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            bodypropCount++;
            body["category"] = CSharpExpressionConverter.ConvertToken(bodycategory);
            if (bodyicon != null)
            {
                body["icon"] = CSharpExpressionConverter.ConvertToken(bodyicon);
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