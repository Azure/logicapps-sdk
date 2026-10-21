//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mtarget
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MtargetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mtarget")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> msisdn, Expression<Func<string>> msg, Expression<Func<string>> sender = null, Expression<Func<int>> serviceid = null, Expression<Func<string>> timetosend = null, Expression<Func<string>> remoteid = null)
        {
            var __workflow_msisdn = WorkflowExpression.Compile(msisdn, nameof(msisdn), required: true);
            var __workflow_msg = WorkflowExpression.Compile(msg, nameof(msg), required: true);
            var __workflow_sender = WorkflowExpression.Compile(sender, nameof(sender), required: false);
            var __workflow_serviceid = WorkflowExpression.Compile(serviceid, nameof(serviceid), required: false);
            var __workflow_timetosend = WorkflowExpression.Compile(timetosend, nameof(timetosend), required: false);
            var __workflow_remoteid = WorkflowExpression.Compile(remoteid, nameof(remoteid), required: false);
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
            }, WorkflowActionSettingsProfiles.RetrySecureTracked);
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
