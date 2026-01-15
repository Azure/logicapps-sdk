//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Mtarget
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MtargetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mtarget")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms(Expression<Func<string>> msisdn, Expression<Func<string>> msg, Expression<Func<string>> sender = null, Expression<Func<int>> serviceid = null, Expression<Func<string>> timetosend = null, Expression<Func<string>> remoteid = null)
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
    using Microsoft.Azure.Workflows.Sdk.Mtarget;

    public partial class WorkflowManagedActions
    {
        public MtargetActions Mtarget(string connectionId) => new MtargetActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MtargetTriggers Mtarget(string connectionId) => new MtargetTriggers(connectionId);
    }
}