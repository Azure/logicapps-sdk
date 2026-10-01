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
        public IWorkflowAction ChoicePrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string[]> requestchoices = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/choicePrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = SourceExpressionConverter.ConvertToken(requestprompt);
                if (requestchoices != null)
                {
                    request["choices"] = SourceExpressionConverter.ConvertToken(requestchoices);
                    requestpropCount++;
                }

                requestpropCount++;
                request["conversationReference"] = SourceExpressionConverter.ConvertToken(requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ConfirmPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference, [WorkflowExpression] Func<string> requestyesText = null, [WorkflowExpression] Func<string> requestnoText = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/confirmPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = SourceExpressionConverter.ConvertToken(requestprompt);
                if (requestyesText != null)
                {
                    if (requestyesText != null)
                    {
                        request["yesText"] = SourceExpressionConverter.ConvertToken(requestyesText);
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
                        request["noText"] = SourceExpressionConverter.ConvertToken(requestnoText);
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
                request["conversationReference"] = SourceExpressionConverter.ConvertToken(requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction ProactiveDialogStart([WorkflowExpression] Func<string> id, [WorkflowExpression] Func<string> bodyupn)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/proactiveDialogs/{0}/start", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["upn"] = SourceExpressionConverter.ConvertToken(bodyupn);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction Reply([WorkflowExpression] Func<string> messageActivitytext, [WorkflowExpression] Func<string> messageActivityconversationReference = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/reply";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var messageActivity = new JObject();
                var messageActivitypropCount = 0;
                messageActivitypropCount++;
                messageActivity["text"] = SourceExpressionConverter.ConvertToken(messageActivitytext);
                if (messageActivityconversationReference != null)
                {
                    messageActivity["conversationReference"] = SourceExpressionConverter.ConvertToken(messageActivityconversationReference);
                    messageActivitypropCount++;
                }

                if (messageActivitypropCount > 0)
                {
                    callPayload.Body = messageActivity;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "companyconnect")]
        public IWorkflowAction TextPrompt([WorkflowExpression] Func<string> requestprompt, [WorkflowExpression] Func<string> requestconversationReference)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/textPrompt";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var request = new JObject();
                var requestpropCount = 0;
                request["callbackUri"] = "#{listCallbackUrl()}";
                requestpropCount++;
                requestpropCount++;
                request["prompt"] = SourceExpressionConverter.ConvertToken(requestprompt);
                requestpropCount++;
                request["conversationReference"] = SourceExpressionConverter.ConvertToken(requestconversationReference);
                if (requestpropCount > 0)
                {
                    callPayload.Body = request;
                }
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }
    }

    public class CompanyconnectTriggers([ConnectionName] string connectionId)
    {
        public IWorkflowTrigger ProactiveDialogSubscribe([WorkflowExpression] Func<string> bodytitle, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/proactiveDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartDialogSubscribe([WorkflowExpression] Func<string> bodyappId, [WorkflowExpression] Func<string> bodyintent, [WorkflowExpression] Func<string> bodydescription, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/smartDialogs";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["appId"] = SourceExpressionConverter.ConvertToken(bodyappId);
                bodypropCount++;
                body["intent"] = SourceExpressionConverter.ConvertToken(bodyintent);
                bodypropCount++;
                body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
        }

        public IWorkflowTrigger SmartSourceSubscribe([WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodycategory, [WorkflowExpression] Func<string> bodyicon = null, string triggerName = null, FlowRecurrence recurrence = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/smartSources";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                body["callbackUrl"] = "#{listCallbackUrl()}";
                bodypropCount++;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["category"] = SourceExpressionConverter.ConvertToken(bodycategory);
                if (bodyicon != null)
                {
                    body["icon"] = SourceExpressionConverter.ConvertToken(bodyicon);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionTrigger(BuildSourceInput, triggerName, recurrence);
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