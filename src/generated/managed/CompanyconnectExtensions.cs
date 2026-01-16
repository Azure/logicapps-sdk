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
            request["callbackUri"] = "@listcallbackurl()";
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
        public IWorkflowAction ConfirmPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string>> requestyesText = null, Expression<Func<string>> requestnoText = null)
        {
            var apiCallPath = "/confirmPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listcallbackurl()";
            requestpropCount++;
            requestpropCount++;
            request["prompt"] = ExpressionConverter.ConvertO(requestprompt);
            if (requestyesText != null)
            {
                request["yesText"] = ExpressionConverter.ConvertO(requestyesText);
                requestpropCount++;
            }

            if (requestnoText != null)
            {
                request["noText"] = ExpressionConverter.ConvertO(requestnoText);
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
        public IWorkflowAction ProactiveDialogStart(Expression<Func<string>> id, Expression<Func<string>> bodyupn)
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
        public IWorkflowAction Reply(Expression<Func<string>> messageActivitytext, Expression<Func<string>> messageActivityconversationReference = null)
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
        public IWorkflowAction TextPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference)
        {
            var apiCallPath = "/textPrompt";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            request["callbackUri"] = "@listcallbackurl()";
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
        public IWorkflowTrigger ProactiveDialogSubscribe(Expression<Func<string>> bodytitle, string triggerName = null)
        {
            var apiCallPath = "/proactiveDialogs";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            bodypropCount++;
            body["title"] = ExpressionConverter.ConvertO(bodytitle);
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger SmartDialogSubscribe(Expression<Func<string>> bodyappId, Expression<Func<string>> bodyintent, Expression<Func<string>> bodydescription, string triggerName = null)
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
            body["callbackUrl"] = "@listcallbackurl()";
            bodypropCount++;
            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionTrigger(callPayload);
        }

        public IWorkflowTrigger SmartSourceSubscribe(Expression<Func<string>> bodytitle, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyicon = null, string triggerName = null)
        {
            var apiCallPath = "/smartSources";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            body["callbackUrl"] = "@listcallbackurl()";
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

            return new ApiConnectionTrigger(callPayload);
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