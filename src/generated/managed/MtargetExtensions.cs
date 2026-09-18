//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mtarget
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MtargetActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mtarget")]
        public IBodyWorkflowAction<SendSmsResponse> SendSms([WorkflowExpression] Func<string> msisdn, [WorkflowExpression] Func<string> msg, [WorkflowExpression] Func<string> sender = null, [WorkflowExpression] Func<int> serviceid = null, [WorkflowExpression] Func<string> timetosend = null, [WorkflowExpression] Func<string> remoteid = null)
        {
            SourceExpression.Validate(msisdn, nameof(msisdn), required: true);
            SourceExpression.Validate(msg, nameof(msg), required: true);
            SourceExpression.Validate(sender, nameof(sender), required: false);
            SourceExpression.Validate(serviceid, nameof(serviceid), required: false);
            SourceExpression.Validate(timetosend, nameof(timetosend), required: false);
            SourceExpression.Validate(remoteid, nameof(remoteid), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/flow.php";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["msisdn"] = SourceExpressionConverter.ConvertO(msisdn);
                callPayload.Queries["msg"] = SourceExpressionConverter.ConvertO(msg);
                if (sender != null)
                    callPayload.Queries["sender"] = SourceExpressionConverter.ConvertO(sender);
                if (serviceid != null)
                    callPayload.Queries["serviceid"] = SourceExpressionConverter.ConvertO(serviceid);
                if (timetosend != null)
                    callPayload.Queries["timetosend"] = SourceExpressionConverter.ConvertO(timetosend);
                if (remoteid != null)
                    callPayload.Queries["remoteid"] = SourceExpressionConverter.ConvertO(remoteid);
                return callPayload;
            }

            return new ApiConnectionAction<SendSmsResponse>(BuildSourceInput);
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