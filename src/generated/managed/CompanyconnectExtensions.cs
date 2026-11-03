//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CompanyconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ChoicePrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string[]>> requestchoices = null)
        {
            var __workflow_requestprompt = WorkflowExpression.Compile(requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = WorkflowExpression.Compile(requestconversationReference, nameof(requestconversationReference), required: true);
            var __workflow_requestchoices = WorkflowExpression.Compile(requestchoices, nameof(requestchoices), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/choicePrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = ExpressionConverter.ConvertO(__workflow_requestprompt);
                if (__workflow_requestchoices != null)
                {
                    request["choices"] = ExpressionConverter.ConvertO(__workflow_requestchoices);
                    requestpropCount++;
                }

                requestpropCount++;
                request["conversationReference"] = ExpressionConverter.ConvertO(__workflow_requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ConfirmPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string>> requestyesText = null, Expression<Func<string>> requestnoText = null)
        {
            var __workflow_requestprompt = WorkflowExpression.Compile(requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = WorkflowExpression.Compile(requestconversationReference, nameof(requestconversationReference), required: true);
            var __workflow_requestyesText = WorkflowExpression.Compile(requestyesText, nameof(requestyesText), required: false);
            var __workflow_requestnoText = WorkflowExpression.Compile(requestnoText, nameof(requestnoText), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/confirmPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = ExpressionConverter.ConvertO(__workflow_requestprompt);
                if (__workflow_requestyesText != null)
                {
                    if (__workflow_requestyesText != null)
                    {
                        request["yesText"] = ExpressionConverter.ConvertO(__workflow_requestyesText);
                        requestpropCount++;
                    }

                    requestpropCount++;
                }
                else
                {
                    request["yesText"] = "Yes";
                    requestpropCount++;
                }

                if (__workflow_requestnoText != null)
                {
                    if (__workflow_requestnoText != null)
                    {
                        request["noText"] = ExpressionConverter.ConvertO(__workflow_requestnoText);
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
                request["conversationReference"] = ExpressionConverter.ConvertO(__workflow_requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> ProactiveDialogStart(Expression<Func<string>> id, Expression<Func<string>> bodyupn)
        {
            var __workflow_id = WorkflowExpression.Compile(id, nameof(id), required: true);
            var __workflow_bodyupn = WorkflowExpression.Compile(bodyupn, nameof(bodyupn), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/proactiveDialogs/{0}/start", __workflow_id.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["upn"] = ExpressionConverter.ConvertO(__workflow_bodyupn);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> Reply(Expression<Func<string>> messageActivitytext, Expression<Func<string>> messageActivityconversationReference = null)
        {
            var __workflow_messageActivitytext = WorkflowExpression.Compile(messageActivitytext, nameof(messageActivitytext), required: true);
            var __workflow_messageActivityconversationReference = WorkflowExpression.Compile(messageActivityconversationReference, nameof(messageActivityconversationReference), required: false);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageActivity = new JObject();
                var messageActivitypropCount = 0;
                messageActivitypropCount++;
                messageActivity["text"] = ExpressionConverter.ConvertO(__workflow_messageActivitytext);
                if (__workflow_messageActivityconversationReference != null)
                {
                    messageActivity["conversationReference"] = ExpressionConverter.ConvertO(__workflow_messageActivityconversationReference);
                    messageActivitypropCount++;
                }

                if (messageActivitypropCount > 0)
                {
                    callPayload.Body = messageActivity;
                }

                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction<ApiConnectionActionConfiguration> TextPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference)
        {
            var __workflow_requestprompt = WorkflowExpression.Compile(requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = WorkflowExpression.Compile(requestconversationReference, nameof(requestconversationReference), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/textPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = ExpressionConverter.ConvertO(__workflow_requestprompt);
                requestpropCount++;
                request["conversationReference"] = ExpressionConverter.ConvertO(__workflow_requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }

                return new ApiConnectionAction(callPayload);
            });
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> ProactiveDialogSubscribe(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/proactiveDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SmartDialogSubscribe(Expression<Func<string>> bodyappId, Expression<Func<string>> bodyintent, Expression<Func<string>> bodydescription, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyappId = WorkflowExpression.Compile(bodyappId, nameof(bodyappId), required: true);
            var __workflow_bodyintent = WorkflowExpression.Compile(bodyintent, nameof(bodyintent), required: true);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: true);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/smartDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["appId"] = ExpressionConverter.ConvertO(__workflow_bodyappId);
                bodypropCount++;
                body["intent"] = ExpressionConverter.ConvertO(__workflow_bodyintent);
                bodypropCount++;
                body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger<ApiConnectionTriggerConfiguration> SmartSourceSubscribe(Expression<Func<string>> bodytitle, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyicon = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodycategory = WorkflowExpression.Compile(bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyicon = WorkflowExpression.Compile(bodyicon, nameof(bodyicon), required: false);
            return new DeferredWorkflowTrigger<ApiConnectionTriggerConfiguration>(() =>
            {
                var apiCallPath = "/smartSources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["category"] = ExpressionConverter.ConvertO(__workflow_bodycategory);
                if (__workflow_bodyicon != null)
                {
                    body["icon"] = ExpressionConverter.ConvertO(__workflow_bodyicon);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
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