//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unixtimestampip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnixtimestampipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse> Unix2UTCDateTime([WorkflowExpression] Func<int> unixtimestamp = null)
        {
            SourceExpression.Validate(unixtimestamp, nameof(unixtimestamp), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (unixtimestamp != null)
                    callPayload.Queries["unixtimestamp"] = SourceExpressionConverter.ConvertO(unixtimestamp);
                return callPayload;
            }

            return new ApiConnectionAction<Unix2UTCDateTimeResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse> Unix2DateTimeTimezone([WorkflowExpression] Func<string> bodyunixTimeStamp = null, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            SourceExpression.Validate(bodyunixTimeStamp, nameof(bodyunixTimeStamp), required: false);
            SourceExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyunixTimeStamp != null)
                {
                    body["UnixTimeStamp"] = SourceExpressionConverter.ConvertToken(bodyunixTimeStamp);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["Timezone"] = SourceExpressionConverter.ConvertToken(bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }
                return callPayload;
            }

            return new ApiConnectionAction<Unix2DateTimeTimezoneResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse> DateTime2UnixTimestamp([WorkflowExpression] Func<string> datetime = null)
        {
            SourceExpression.Validate(datetime, nameof(datetime), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/tounixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["datetime"] = Convert.ToString("now");
                if (datetime != null)
                    callPayload.Queries["datetime"] = SourceExpressionConverter.ConvertO(datetime);
                return callPayload;
            }

            return new ApiConnectionAction<DateTime2UnixTimestampResponse>(BuildSourceInput);
        }
    }

    public class UnixtimestampipTriggers([ConnectionName] string connectionId)
    {
    }

    public class Unix2UTCDateTimeResponse
    {
        public string Datetime { get; set; }
    }

    public class Unix2DateTimeTimezoneResponse
    {
        public string Datetime { get; set; }
    }

    public class DateTime2UnixTimestampResponse
    {
        public string UnixTimeStamp { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Unixtimestampip;

    public partial class WorkflowManagedActions
    {
        public UnixtimestampipActions Unixtimestampip(string connectionId) => new UnixtimestampipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public UnixtimestampipTriggers Unixtimestampip(string connectionId) => new UnixtimestampipTriggers(connectionId);
    }
}