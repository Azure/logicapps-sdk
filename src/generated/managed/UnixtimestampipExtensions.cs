//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unixtimestampip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class UnixtimestampipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse> Unix2UTCDateTime(Expression<Func<int>> unixtimestamp = null)
        {
            var __workflow_unixtimestamp = unixtimestamp == null ? null : WorkflowExpression.Compile(unixtimestamp);
            WorkflowExpression.Validate(__workflow_unixtimestamp, nameof(unixtimestamp), required: false);
            return new DeferredBodyAction<Unix2UTCDateTimeResponse>(() =>
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_unixtimestamp != null)
                    callPayload.Queries["unixtimestamp"] = ExpressionConverter.Convert(__workflow_unixtimestamp);
                return new ApiConnectionAction<Unix2UTCDateTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse> Unix2DateTimeTimezone(Expression<Func<string>> bodyunixTimeStamp = null, Expression<Func<string>> bodytimezone = null)
        {
            var __workflow_bodyunixTimeStamp = bodyunixTimeStamp == null ? null : WorkflowExpression.Compile(bodyunixTimeStamp);
            WorkflowExpression.Validate(__workflow_bodyunixTimeStamp, nameof(bodyunixTimeStamp), required: false);
            var __workflow_bodytimezone = bodytimezone == null ? null : WorkflowExpression.Compile(bodytimezone);
            WorkflowExpression.Validate(__workflow_bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<Unix2DateTimeTimezoneResponse>(() =>
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodyunixTimeStamp != null)
                {
                    body["UnixTimeStamp"] = ExpressionConverter.ConvertO(__workflow_bodyunixTimeStamp);
                    bodypropCount++;
                }

                if (__workflow_bodytimezone != null)
                {
                    body["Timezone"] = ExpressionConverter.ConvertO(__workflow_bodytimezone);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<Unix2DateTimeTimezoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse> DateTime2UnixTimestamp(Expression<Func<string>> datetime = null)
        {
            var __workflow_datetime = datetime == null ? null : WorkflowExpression.Compile(datetime);
            WorkflowExpression.Validate(__workflow_datetime, nameof(datetime), required: false);
            return new DeferredBodyAction<DateTime2UnixTimestampResponse>(() =>
            {
                var apiCallPath = "/tounixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["datetime"] = Convert.ToString("now");
                if (__workflow_datetime != null)
                    callPayload.Queries["datetime"] = ExpressionConverter.Convert(__workflow_datetime);
                return new ApiConnectionAction<DateTime2UnixTimestampResponse>(callPayload);
            });
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
