//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mtarget
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class MtargetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mtarget")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> msisdn, Expression<Func<string>> msg, Expression<Func<string>> sender = null, Expression<Func<int>> serviceid = null, Expression<Func<string>> timetosend = null, Expression<Func<string>> remoteid = null)
        {
            var __workflow_msisdn = msisdn == null ? null : WorkflowExpression.Compile(msisdn);
            WorkflowExpression.Validate(__workflow_msisdn, nameof(msisdn), required: true);
            var __workflow_msg = msg == null ? null : WorkflowExpression.Compile(msg);
            WorkflowExpression.Validate(__workflow_msg, nameof(msg), required: true);
            var __workflow_sender = sender == null ? null : WorkflowExpression.Compile(sender);
            WorkflowExpression.Validate(__workflow_sender, nameof(sender), required: false);
            var __workflow_serviceid = serviceid == null ? null : WorkflowExpression.Compile(serviceid);
            WorkflowExpression.Validate(__workflow_serviceid, nameof(serviceid), required: false);
            var __workflow_timetosend = timetosend == null ? null : WorkflowExpression.Compile(timetosend);
            WorkflowExpression.Validate(__workflow_timetosend, nameof(timetosend), required: false);
            var __workflow_remoteid = remoteid == null ? null : WorkflowExpression.Compile(remoteid);
            WorkflowExpression.Validate(__workflow_remoteid, nameof(remoteid), required: false);
            return new DeferredBodyAction<SendSmsResponse>(() =>
            {
                var apiCallPath = "/flow.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["msisdn"] = ExpressionConverter.Convert(__workflow_msisdn);
                callPayload.Queries["msg"] = ExpressionConverter.Convert(__workflow_msg);
                if (__workflow_sender != null)
                    callPayload.Queries["sender"] = ExpressionConverter.Convert(__workflow_sender);
                if (__workflow_serviceid != null)
                    callPayload.Queries["serviceid"] = ExpressionConverter.Convert(__workflow_serviceid);
                if (__workflow_timetosend != null)
                    callPayload.Queries["timetosend"] = ExpressionConverter.Convert(__workflow_timetosend);
                if (__workflow_remoteid != null)
                    callPayload.Queries["remoteid"] = ExpressionConverter.Convert(__workflow_remoteid);
                return new ApiConnectionAction<SendSmsResponse>(callPayload);
            });
        }
    }

    public class MtargetTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendSmsResponse
    {
        [JsonProperty("results")]
        public SendSmsResponseResultsTypeItem[] Results { get; set; }
    }

    public class SendSmsResponseResultsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("msisdn")]
        public string Msisdn { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("smscount")]
        public string Smscount { get; set; }

        [JsonProperty("ticket")]
        public string Ticket { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mtarget;

    public partial class WorkflowManagedActions
    {
        public MtargetActions Mtarget(string connectionId) => new MtargetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MtargetTriggers Mtarget(string connectionId) => new MtargetTriggers(connectionId);
    }
}
