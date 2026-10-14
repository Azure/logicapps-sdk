//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Companyconnect
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CompanyconnectActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ChoicePrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string[]>> requestchoices = null)
        {
            var __workflow_requestprompt = requestprompt == null ? null : WorkflowExpression.Compile(requestprompt);
            WorkflowExpression.Validate(__workflow_requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = requestconversationReference == null ? null : WorkflowExpression.Compile(requestconversationReference);
            WorkflowExpression.Validate(__workflow_requestconversationReference, nameof(requestconversationReference), required: true);
            var __workflow_requestchoices = requestchoices == null ? null : WorkflowExpression.Compile(requestchoices);
            WorkflowExpression.Validate(__workflow_requestchoices, nameof(requestchoices), required: false);
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
        public IWorkflowAction ConfirmPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference, Expression<Func<string>> requestyesText = null, Expression<Func<string>> requestnoText = null)
        {
            var __workflow_requestprompt = requestprompt == null ? null : WorkflowExpression.Compile(requestprompt);
            WorkflowExpression.Validate(__workflow_requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = requestconversationReference == null ? null : WorkflowExpression.Compile(requestconversationReference);
            WorkflowExpression.Validate(__workflow_requestconversationReference, nameof(requestconversationReference), required: true);
            var __workflow_requestyesText = requestyesText == null ? null : WorkflowExpression.Compile(requestyesText);
            WorkflowExpression.Validate(__workflow_requestyesText, nameof(requestyesText), required: false);
            var __workflow_requestnoText = requestnoText == null ? null : WorkflowExpression.Compile(requestnoText);
            WorkflowExpression.Validate(__workflow_requestnoText, nameof(requestnoText), required: false);
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
        public IWorkflowAction ProactiveDialogStart(Expression<Func<string>> id, Expression<Func<string>> bodyupn)
        {
            var __workflow_id = id == null ? null : WorkflowExpression.Compile(id);
            WorkflowExpression.Validate(__workflow_id, nameof(id), required: true);
            var __workflow_bodyupn = bodyupn == null ? null : WorkflowExpression.Compile(bodyupn);
            WorkflowExpression.Validate(__workflow_bodyupn, nameof(bodyupn), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/proactiveDialogs/{0}/start", ExpressionConverter.ConvertWithUrlEncoding(__workflow_id, 1));
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
        public IWorkflowAction Reply(Expression<Func<string>> messageActivitytext, Expression<Func<string>> messageActivityconversationReference = null)
        {
            var __workflow_messageActivitytext = messageActivitytext == null ? null : WorkflowExpression.Compile(messageActivitytext);
            WorkflowExpression.Validate(__workflow_messageActivitytext, nameof(messageActivitytext), required: true);
            var __workflow_messageActivityconversationReference = messageActivityconversationReference == null ? null : WorkflowExpression.Compile(messageActivityconversationReference);
            WorkflowExpression.Validate(__workflow_messageActivityconversationReference, nameof(messageActivityconversationReference), required: false);
            return new DeferredWorkflowAction(() =>
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
        public IWorkflowAction TextPrompt(Expression<Func<string>> requestprompt, Expression<Func<string>> requestconversationReference)
        {
            var __workflow_requestprompt = requestprompt == null ? null : WorkflowExpression.Compile(requestprompt);
            WorkflowExpression.Validate(__workflow_requestprompt, nameof(requestprompt), required: true);
            var __workflow_requestconversationReference = requestconversationReference == null ? null : WorkflowExpression.Compile(requestconversationReference);
            WorkflowExpression.Validate(__workflow_requestconversationReference, nameof(requestconversationReference), required: true);
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
        public IWorkflowTrigger ProactiveDialogSubscribe(Expression<Func<string>> bodytitle, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
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
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionTrigger(callPayload, recurrence: recurrence);
            });
        }

        public IWorkflowTrigger SmartDialogSubscribe(Expression<Func<string>> bodyappId, Expression<Func<string>> bodyintent, Expression<Func<string>> bodydescription, FlowRecurrence recurrence = null)
        {
            var __workflow_bodyappId = bodyappId == null ? null : WorkflowExpression.Compile(bodyappId);
            WorkflowExpression.Validate(__workflow_bodyappId, nameof(bodyappId), required: true);
            var __workflow_bodyintent = bodyintent == null ? null : WorkflowExpression.Compile(bodyintent);
            WorkflowExpression.Validate(__workflow_bodyintent, nameof(bodyintent), required: true);
            var __workflow_bodydescription = bodydescription == null ? null : WorkflowExpression.Compile(bodydescription);
            WorkflowExpression.Validate(__workflow_bodydescription, nameof(bodydescription), required: true);
            return new DeferredWorkflowTrigger(() =>
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

        public IWorkflowTrigger SmartSourceSubscribe(Expression<Func<string>> bodytitle, Expression<Func<string>> bodycategory, Expression<Func<string>> bodyicon = null, FlowRecurrence recurrence = null)
        {
            var __workflow_bodytitle = bodytitle == null ? null : WorkflowExpression.Compile(bodytitle);
            WorkflowExpression.Validate(__workflow_bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodycategory = bodycategory == null ? null : WorkflowExpression.Compile(bodycategory);
            WorkflowExpression.Validate(__workflow_bodycategory, nameof(bodycategory), required: true);
            var __workflow_bodyicon = bodyicon == null ? null : WorkflowExpression.Compile(bodyicon);
            WorkflowExpression.Validate(__workflow_bodyicon, nameof(bodyicon), required: false);
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
