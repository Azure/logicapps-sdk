//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unixtimestampip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnixtimestampipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        [WorkflowExpressionFactory(nameof(__BuildUnix2UTCDateTime))]
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse> Unix2UTCDateTime([WorkflowExpression] Func<int> unixtimestamp = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse> __BuildUnix2UTCDateTime(WorkflowExpression<int> unixtimestamp = null)
        {
            WorkflowExpression.Validate(unixtimestamp, nameof(unixtimestamp), required: false);
            return new DeferredBodyAction<Unix2UTCDateTimeResponse>(() =>
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (unixtimestamp != null)
                    callPayload.Queries["unixtimestamp"] = ExpressionConverter.Convert(unixtimestamp);
                return new ApiConnectionAction<Unix2UTCDateTimeResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        [WorkflowExpressionFactory(nameof(__BuildUnix2DateTimeTimezone))]
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse> Unix2DateTimeTimezone([WorkflowExpression] Func<string> bodyunixTimeStamp = null, [WorkflowExpression] Func<string> bodytimezone = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse> __BuildUnix2DateTimeTimezone(WorkflowExpression<string> bodyunixTimeStamp = null, WorkflowExpression<string> bodytimezone = null)
        {
            WorkflowExpression.Validate(bodyunixTimeStamp, nameof(bodyunixTimeStamp), required: false);
            WorkflowExpression.Validate(bodytimezone, nameof(bodytimezone), required: false);
            return new DeferredBodyAction<Unix2DateTimeTimezoneResponse>(() =>
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyunixTimeStamp != null)
                {
                    body["UnixTimeStamp"] = ExpressionConverter.ConvertO(bodyunixTimeStamp);
                    bodypropCount++;
                }

                if (bodytimezone != null)
                {
                    body["Timezone"] = ExpressionConverter.ConvertO(bodytimezone);
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
        [WorkflowExpressionFactory(nameof(__BuildDateTime2UnixTimestamp))]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse> DateTime2UnixTimestamp([WorkflowExpression] Func<string> datetime = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse> __BuildDateTime2UnixTimestamp(WorkflowExpression<string> datetime = null)
        {
            WorkflowExpression.Validate(datetime, nameof(datetime), required: false);
            return new DeferredBodyAction<DateTime2UnixTimestampResponse>(() =>
            {
                var apiCallPath = "/tounixtimestamp";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["datetime"] = Convert.ToString("now");
                if (datetime != null)
                    callPayload.Queries["datetime"] = ExpressionConverter.Convert(datetime);
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