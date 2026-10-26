//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Unixtimestampip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class UnixtimestampipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<Unix2UTCDateTimeResponse, ApiConnectionActionConfiguration> Unix2UTCDateTime(Expression<Func<int>> unixtimestamp = null)
        {
            var __workflow_unixtimestamp = WorkflowExpression.Compile(unixtimestamp, nameof(unixtimestamp), required: false);
            return new DeferredBodyAction<Unix2UTCDateTimeResponse, ApiConnectionActionConfiguration>(() =>
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
        public IBodyWorkflowAction<Unix2DateTimeTimezoneResponse, ApiConnectionActionConfiguration> Unix2DateTimeTimezone(Expression<Func<Unix2DateTimeTimezoneInput>> body = null)
        {
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: false);
            return new DeferredBodyAction<Unix2DateTimeTimezoneResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/fromunixtimestamp";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_body != null)
                    callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction<Unix2DateTimeTimezoneResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "unixtimestampip")]
        public IBodyWorkflowAction<DateTime2UnixTimestampResponse, ApiConnectionActionConfiguration> DateTime2UnixTimestamp(Expression<Func<string>> datetime = null)
        {
            var __workflow_datetime = WorkflowExpression.Compile(datetime, nameof(datetime), required: false);
            return new DeferredBodyAction<DateTime2UnixTimestampResponse, ApiConnectionActionConfiguration>(() =>
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

    public class Unix2DateTimeTimezoneInput
    {
        public string UnixTimeStamp { get; set; }
        public string Timezone { get; set; }
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