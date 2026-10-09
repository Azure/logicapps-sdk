//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mtarget
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MtargetActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mtarget")]
        [WorkflowExpressionFactory(nameof(__BuildSendSms))]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> msisdn, [WorkflowExpression] Func<string> msg, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<int> serviceid = null, [WorkflowExpression] Func<string> timetosend = null, [WorkflowExpression] Func<string> remoteid = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSmsResponse> __BuildSendSms(WorkflowExpression<string> msisdn, WorkflowExpression<string> msg, WorkflowExpression<string> sender = null, WorkflowExpression<int> serviceid = null, WorkflowExpression<string> timetosend = null, WorkflowExpression<string> remoteid = null)
        {
            WorkflowExpression.Validate(msisdn, nameof(msisdn), required: true);
            WorkflowExpression.Validate(msg, nameof(msg), required: true);
            WorkflowExpression.Validate(sender, nameof(sender), required: false);
            WorkflowExpression.Validate(serviceid, nameof(serviceid), required: false);
            WorkflowExpression.Validate(timetosend, nameof(timetosend), required: false);
            WorkflowExpression.Validate(remoteid, nameof(remoteid), required: false);
            return new DeferredBodyAction<SendSmsResponse>(() =>
            {
                var apiCallPath = "/flow.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["msisdn"] = ExpressionConverter.Convert(msisdn);
                callPayload.Queries["msg"] = ExpressionConverter.Convert(msg);
                if (sender != null)
                    callPayload.Queries["sender"] = ExpressionConverter.Convert(sender);
                if (serviceid != null)
                    callPayload.Queries["serviceid"] = ExpressionConverter.Convert(serviceid);
                if (timetosend != null)
                    callPayload.Queries["timetosend"] = ExpressionConverter.Convert(timetosend);
                if (remoteid != null)
                    callPayload.Queries["remoteid"] = ExpressionConverter.Convert(remoteid);
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