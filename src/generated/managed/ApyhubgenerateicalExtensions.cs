//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class ApyhubgenerateicalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<string> File(Expression<Func<string>> output = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyorganizerEmail = null, Expression<Func<string[]>> bodyattendeesEmails = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodymeetingDate = null, Expression<Func<bool>> bodyrecurring = null, Expression<Func<bodyrecurrencefrequencyInput>> bodyrecurrencefrequency = null, Expression<Func<int>> bodyrecurrencecount = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyorganizerEmail = WorkflowExpression.Compile(bodyorganizerEmail, nameof(bodyorganizerEmail), required: false);
            var __workflow_bodyattendeesEmails = WorkflowExpression.Compile(bodyattendeesEmails, nameof(bodyattendeesEmails), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodymeetingDate = WorkflowExpression.Compile(bodymeetingDate, nameof(bodymeetingDate), required: false);
            var __workflow_bodyrecurring = WorkflowExpression.Compile(bodyrecurring, nameof(bodyrecurring), required: false);
            var __workflow_bodyrecurrencefrequency = WorkflowExpression.Compile(bodyrecurrencefrequency, nameof(bodyrecurrencefrequency), required: false);
            var __workflow_bodyrecurrencecount = WorkflowExpression.Compile(bodyrecurrencecount, nameof(bodyrecurrencecount), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizerEmail != null)
                {
                    body["organizer_email"] = ExpressionConverter.ConvertO(__workflow_bodyorganizerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = ExpressionConverter.ConvertO(__workflow_bodyattendeesEmails);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodymeetingDate != null)
                {
                    body["meeting_date"] = ExpressionConverter.ConvertO(__workflow_bodymeetingDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurring != null)
                {
                    body["recurring"] = ExpressionConverter.ConvertO(__workflow_bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (__workflow_bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (__workflow_bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrencecount);
                    recurrenceObjectpropCount++;
                }

                if (recurrenceObjectpropCount > 0)
                {
                    body["recurrence"] = recurrenceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<string>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<URLPostResponse> URL(Expression<Func<string>> output = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyorganizerEmail = null, Expression<Func<string[]>> bodyattendeesEmails = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodymeetingDate = null, Expression<Func<bool>> bodyrecurring = null, Expression<Func<bodyrecurrencefrequencyInput>> bodyrecurrencefrequency = null, Expression<Func<int>> bodyrecurrencecount = null)
        {
            var __workflow_output = WorkflowExpression.Compile(output, nameof(output), required: false);
            var __workflow_bodysummary = WorkflowExpression.Compile(bodysummary, nameof(bodysummary), required: false);
            var __workflow_bodydescription = WorkflowExpression.Compile(bodydescription, nameof(bodydescription), required: false);
            var __workflow_bodyorganizerEmail = WorkflowExpression.Compile(bodyorganizerEmail, nameof(bodyorganizerEmail), required: false);
            var __workflow_bodyattendeesEmails = WorkflowExpression.Compile(bodyattendeesEmails, nameof(bodyattendeesEmails), required: false);
            var __workflow_bodylocation = WorkflowExpression.Compile(bodylocation, nameof(bodylocation), required: false);
            var __workflow_bodytimeZone = WorkflowExpression.Compile(bodytimeZone, nameof(bodytimeZone), required: false);
            var __workflow_bodystartTime = WorkflowExpression.Compile(bodystartTime, nameof(bodystartTime), required: false);
            var __workflow_bodyendTime = WorkflowExpression.Compile(bodyendTime, nameof(bodyendTime), required: false);
            var __workflow_bodymeetingDate = WorkflowExpression.Compile(bodymeetingDate, nameof(bodymeetingDate), required: false);
            var __workflow_bodyrecurring = WorkflowExpression.Compile(bodyrecurring, nameof(bodyrecurring), required: false);
            var __workflow_bodyrecurrencefrequency = WorkflowExpression.Compile(bodyrecurrencefrequency, nameof(bodyrecurrencefrequency), required: false);
            var __workflow_bodyrecurrencecount = WorkflowExpression.Compile(bodyrecurrencecount, nameof(bodyrecurrencecount), required: false);
            return new DeferredBodyAction<URLPostResponse>(() =>
            {
                var apiCallPath = "/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(__workflow_output);
                var body = new JObject();
                var bodypropCount = 0;
                if (__workflow_bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(__workflow_bodysummary);
                    bodypropCount++;
                }

                if (__workflow_bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(__workflow_bodydescription);
                    bodypropCount++;
                }

                if (__workflow_bodyorganizerEmail != null)
                {
                    body["organizer_email"] = ExpressionConverter.ConvertO(__workflow_bodyorganizerEmail);
                    bodypropCount++;
                }

                if (__workflow_bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = ExpressionConverter.ConvertO(__workflow_bodyattendeesEmails);
                    bodypropCount++;
                }

                if (__workflow_bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(__workflow_bodylocation);
                    bodypropCount++;
                }

                if (__workflow_bodytimeZone != null)
                {
                    body["time_zone"] = ExpressionConverter.ConvertO(__workflow_bodytimeZone);
                    bodypropCount++;
                }

                if (__workflow_bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(__workflow_bodystartTime);
                    bodypropCount++;
                }

                if (__workflow_bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(__workflow_bodyendTime);
                    bodypropCount++;
                }

                if (__workflow_bodymeetingDate != null)
                {
                    body["meeting_date"] = ExpressionConverter.ConvertO(__workflow_bodymeetingDate);
                    bodypropCount++;
                }

                if (__workflow_bodyrecurring != null)
                {
                    body["recurring"] = ExpressionConverter.ConvertO(__workflow_bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (__workflow_bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (__workflow_bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = ExpressionConverter.ConvertO(__workflow_bodyrecurrencecount);
                    recurrenceObjectpropCount++;
                }

                if (recurrenceObjectpropCount > 0)
                {
                    body["recurrence"] = recurrenceObject;
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<URLPostResponse>(callPayload);
            });
        }
    }

    public class ApyhubgenerateicalTriggers([ConnectionName] string connectionId)
    {
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum bodyrecurrencefrequencyInput
    {
        DAILY,
        WEEKLY,
        MONTHLY,
        YEARLY
    }

    public class URLPostResponse
    {
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical;

    public partial class WorkflowManagedActions
    {
        public ApyhubgenerateicalActions Apyhubgenerateical(string connectionId) => new ApyhubgenerateicalActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ApyhubgenerateicalTriggers Apyhubgenerateical(string connectionId) => new ApyhubgenerateicalTriggers(connectionId);
    }
}
