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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SendSmsResponse> __BuildSendSms(WorkflowValue<string> msisdn, WorkflowValue<string> msg, WorkflowValue<string> sender = null, WorkflowValue<int> serviceid = null, WorkflowValue<string> timetosend = null, WorkflowValue<string> remoteid = null)
        {
            WorkflowValue.Validate(msisdn, nameof(msisdn), required: true);
            WorkflowValue.Validate(msg, nameof(msg), required: true);
            WorkflowValue.Validate(sender, nameof(sender), required: false);
            WorkflowValue.Validate(serviceid, nameof(serviceid), required: false);
            WorkflowValue.Validate(timetosend, nameof(timetosend), required: false);
            WorkflowValue.Validate(remoteid, nameof(remoteid), required: false);
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
