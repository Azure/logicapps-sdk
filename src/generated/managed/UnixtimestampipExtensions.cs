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
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse> Unix2UTCDateTime(Expression<Func<int>> unixtimestamp = null)
        {
            var apiCallPath = "/fromunixtimestamp";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (unixtimestamp != null)
                callPayload.Queries["unixtimestamp"] = ExpressionConverter.Convert(unixtimestamp);
            return new ApiConnectionAction<Unix2UTCDateTimeResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse> Unix2DateTimeTimezone(Expression<Func<string>> bodyUnixTimeStamp = null, Expression<Func<string>> bodyTimezone = null)
        {
            var apiCallPath = "/fromunixtimestamp";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodyUnixTimeStamp != null)
            {
                body["UnixTimeStamp"] = ExpressionConverter.ConvertO(bodyUnixTimeStamp);
                bodypropCount++;
            }

            if (bodyTimezone != null)
            {
                body["Timezone"] = ExpressionConverter.ConvertO(bodyTimezone);
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction<Unix2DateTimeTimezoneResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse> DateTime2UnixTimestamp(Expression<Func<string>> datetime = null)
        {
            var apiCallPath = "/tounixtimestamp";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["datetime"] = Convert.ToString("now");
            if (datetime != null)
                callPayload.Queries["datetime"] = ExpressionConverter.Convert(datetime);
            return new ApiConnectionAction<DateTime2UnixTimestampResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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