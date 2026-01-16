//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Thesmsworksip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ThesmsworksipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[]> ScheduleMessage(Expression<Func<string>> smsMessagesender, Expression<Func<string>> smsMessagedestination, Expression<Func<string>> smsMessagecontent, Expression<Func<string>> smsMessagedeliveryreporturl = null, Expression<Func<string>> smsMessageschedule = null, Expression<Func<string>> smsMessagetag = null, Expression<Func<double>> smsMessagettl = null, Expression<Func<string[]>> smsMessageresponseemail = null, Expression<Func<JToken[]>> smsMessagemetadata = null, Expression<Func<double>> smsMessagevalidity = null)
        {
            var apiCallPath = "/message/schedule";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var smsMessage = new JObject();
            var smsMessagepropCount = 0;
            smsMessagepropCount++;
            smsMessage["sender"] = ExpressionConverter.ConvertO(smsMessagesender);
            smsMessagepropCount++;
            smsMessage["destination"] = ExpressionConverter.ConvertO(smsMessagedestination);
            smsMessagepropCount++;
            smsMessage["content"] = ExpressionConverter.ConvertO(smsMessagecontent);
            if (smsMessagedeliveryreporturl != null)
            {
                smsMessage["deliveryreporturl"] = ExpressionConverter.ConvertO(smsMessagedeliveryreporturl);
                smsMessagepropCount++;
            }

            if (smsMessageschedule != null)
            {
                smsMessage["schedule"] = ExpressionConverter.ConvertO(smsMessageschedule);
                smsMessagepropCount++;
            }

            if (smsMessagetag != null)
            {
                smsMessage["tag"] = ExpressionConverter.ConvertO(smsMessagetag);
                smsMessagepropCount++;
            }

            if (smsMessagettl != null)
            {
                smsMessage["ttl"] = ExpressionConverter.ConvertO(smsMessagettl);
                smsMessagepropCount++;
            }

            if (smsMessageresponseemail != null)
            {
                smsMessage["responseemail"] = ExpressionConverter.ConvertO(smsMessageresponseemail);
                smsMessagepropCount++;
            }

            if (smsMessagemetadata != null)
            {
                smsMessage["metadata"] = ExpressionConverter.ConvertO(smsMessagemetadata);
                smsMessagepropCount++;
            }

            if (smsMessagevalidity != null)
            {
                smsMessage["validity"] = ExpressionConverter.ConvertO(smsMessagevalidity);
                smsMessagepropCount++;
            }

            if (smsMessagepropCount > 0)
            {
                callPayload.Body = smsMessage;
            }

            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[]> GetMessages(Expression<Func<object>> query = null)
        {
            var apiCallPath = "/messages";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[]> GetInboxMessages(Expression<Func<object>> query = null)
        {
            var apiCallPath = "/messages/inbox";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken[]> GetFailedMessages(Expression<Func<object>> query = null)
        {
            var apiCallPath = "/messages/failed";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(query);
            return new ApiConnectionAction<JToken[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> GetScheduledMessages()
        {
            var apiCallPath = "/messages/schedule";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> CancelScheduledJob(Expression<Func<string>> messageid)
        {
            var apiCallPath = String.Format("/messages/schedule/{0}", ExpressionConverter.ConvertWithUrlEncoding(messageid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> SendAny(Expression<Func<object>> messages = null)
        {
            var apiCallPath = "/batch/any";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Body = ExpressionConverter.ConvertO(messages);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> CancelScheduledBatchJob(Expression<Func<string>> batchid)
        {
            var apiCallPath = String.Format("/batches/schedule/{0}", ExpressionConverter.ConvertWithUrlEncoding(batchid, 1));
            var apiCallHttpMethod = "delete";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> Credits()
        {
            var apiCallPath = "/credits/balance";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "thesmsworksip")]
        public IBodyWorkflowAction<JToken> Test()
        {
            var apiCallPath = "/utils/test";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<JToken>(callPayload);
        }
    }

    public class ThesmsworksipTriggers([ConnectionName] string connectionId)
    {
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Thesmsworksip;

    public partial class WorkflowManagedActions
    {
        public ThesmsworksipActions Thesmsworksip(string connectionId) => new ThesmsworksipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ThesmsworksipTriggers Thesmsworksip(string connectionId) => new ThesmsworksipTriggers(connectionId);
    }
}