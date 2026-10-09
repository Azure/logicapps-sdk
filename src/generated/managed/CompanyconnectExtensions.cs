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
        [WorkflowExpressionFactory(nameof(__BuildChoicePrompt))]
        public IWorkflowAction ChoicePrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string[]> requestchoices = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildChoicePrompt(WorkflowExpression<string> requestprompt, WorkflowExpression<string> requestconversationReference, WorkflowExpression<string[]> requestchoices = null)
        {
            WorkflowExpression.Validate(requestprompt, nameof(requestprompt), required: true);
            WorkflowExpression.Validate(requestconversationReference, nameof(requestconversationReference), required: true);
            WorkflowExpression.Validate(requestchoices, nameof(requestchoices), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/choicePrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        [WorkflowExpressionFactory(nameof(__BuildConfirmPrompt))]
        public IWorkflowAction ConfirmPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string> requestyesText = null, [WorkflowExpression] Func<string> requestnoText = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildConfirmPrompt(WorkflowExpression<string> requestprompt, WorkflowExpression<string> requestconversationReference, WorkflowExpression<string> requestyesText = null, WorkflowExpression<string> requestnoText = null)
        {
            WorkflowExpression.Validate(requestprompt, nameof(requestprompt), required: true);
            WorkflowExpression.Validate(requestconversationReference, nameof(requestconversationReference), required: true);
            WorkflowExpression.Validate(requestyesText, nameof(requestyesText), required: false);
            WorkflowExpression.Validate(requestnoText, nameof(requestnoText), required: false);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/confirmPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        [WorkflowExpressionFactory(nameof(__BuildProactiveDialogStart))]
        public IWorkflowAction ProactiveDialogStart([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyupn)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildProactiveDialogStart(WorkflowExpression<string> id, WorkflowExpression<string> bodyupn)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            WorkflowExpression.Validate(bodyupn, nameof(bodyupn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/proactiveDialogs/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        [WorkflowExpressionFactory(nameof(__BuildReply))]
        public IWorkflowAction Reply([WorkflowExpression] Func<string> messageActivitytext, [WorkflowExpression] Func<string> messageActivityconversationReference = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildReply(WorkflowExpression<string> messageActivitytext, WorkflowExpression<string> messageActivityconversationReference = null)
        {
            WorkflowExpression.Validate(messageActivitytext, nameof(messageActivitytext), required: true);
            WorkflowExpression.Validate(messageActivityconversationReference, nameof(messageActivityconversationReference), required: false);
            return new DeferredWorkflowAction(() =>
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
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        [WorkflowExpressionFactory(nameof(__BuildTextPrompt))]
        public IWorkflowAction TextPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildTextPrompt(WorkflowExpression<string> requestprompt, WorkflowExpression<string> requestconversationReference)
        {
            WorkflowExpression.Validate(requestprompt, nameof(requestprompt), required: true);
            WorkflowExpression.Validate(requestconversationReference, nameof(requestconversationReference), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = "/textPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
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
            });
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {

        [WorkflowExpressionFactory(nameof(__BuildProactiveDialogSubscribe))]
        public IWorkflowTrigger ProactiveDialogSubscribe([WorkflowExpression] Func<string> bodytitle,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildProactiveDialogSubscribe(WorkflowExpression<string> bodytitle,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/proactiveDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildSmartDialogSubscribe))]
        public IWorkflowTrigger SmartDialogSubscribe([WorkflowExpression] Func<string> bodyappId,[WorkflowExpression] Func<string> bodyintent,[WorkflowExpression] Func<string> bodydescription,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSmartDialogSubscribe(WorkflowExpression<string> bodyappId,WorkflowExpression<string> bodyintent,WorkflowExpression<string> bodydescription,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodyappId, nameof(bodyappId), required: true);
            WorkflowExpression.Validate(bodyintent, nameof(bodyintent), required: true);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: true);
            return new DeferredWorkflowTrigger(() =>
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
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        [WorkflowExpressionFactory(nameof(__BuildSmartSourceSubscribe))]
        public IWorkflowTrigger SmartSourceSubscribe([WorkflowExpression] Func<string> bodytitle,[WorkflowExpression] Func<string> bodycategory,[WorkflowExpression] Func<string> bodyicon = null,FlowRecurrence recurrence = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowTrigger __BuildSmartSourceSubscribe(WorkflowExpression<string> bodytitle,WorkflowExpression<string> bodycategory,WorkflowExpression<string> bodyicon = null,FlowRecurrence recurrence = null)
        {
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodycategory, nameof(bodycategory), required: true);
            WorkflowExpression.Validate(bodyicon, nameof(bodyicon), required: false);
            return new DeferredWorkflowTrigger(() =>
            {
                var apiCallPath = "/smartSources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
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