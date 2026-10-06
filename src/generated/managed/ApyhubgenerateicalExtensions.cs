//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubgenerateicalActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        [WorkflowExpressionFactory(nameof(__BuildFile))]
        public IBodyWorkflowAction<string> File([WorkflowExpression] Func<string> output = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyorganizerEmail = null, [WorkflowExpression] Func<string[]> bodyattendeesEmails = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodymeetingDate = null, [WorkflowExpression] Func<bool> bodyrecurring = null, [WorkflowExpression] Func<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, [WorkflowExpression] Func<int> bodyrecurrencecount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<string> __BuildFile(WorkflowExpression<string> output = null, WorkflowExpression<string> bodysummary = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyorganizerEmail = null, WorkflowExpression<string[]> bodyattendeesEmails = null, WorkflowExpression<string> bodylocation = null, WorkflowExpression<string> bodytimeZone = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<string> bodymeetingDate = null, WorkflowExpression<bool> bodyrecurring = null, WorkflowExpression<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, WorkflowExpression<int> bodyrecurrencecount = null)
        {
            WorkflowExpression.Validate(output, nameof(output), required: false);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyorganizerEmail, nameof(bodyorganizerEmail), required: false);
            WorkflowExpression.Validate(bodyattendeesEmails, nameof(bodyattendeesEmails), required: false);
            WorkflowExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodymeetingDate, nameof(bodymeetingDate), required: false);
            WorkflowExpression.Validate(bodyrecurring, nameof(bodyrecurring), required: false);
            WorkflowExpression.Validate(bodyrecurrencefrequency, nameof(bodyrecurrencefrequency), required: false);
            WorkflowExpression.Validate(bodyrecurrencecount, nameof(bodyrecurrencecount), required: false);
            return new DeferredBodyAction<string>(() =>
            {
                var apiCallPath = "/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(output);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyorganizerEmail != null)
                {
                    body["organizer_email"] = ExpressionConverter.ConvertO(bodyorganizerEmail);
                    bodypropCount++;
                }

                if (bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = ExpressionConverter.ConvertO(bodyattendeesEmails);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone"] = ExpressionConverter.ConvertO(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodymeetingDate != null)
                {
                    body["meeting_date"] = ExpressionConverter.ConvertO(bodymeetingDate);
                    bodypropCount++;
                }

                if (bodyrecurring != null)
                {
                    body["recurring"] = ExpressionConverter.ConvertO(bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = ExpressionConverter.ConvertO(bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = ExpressionConverter.ConvertO(bodyrecurrencecount);
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
        [WorkflowExpressionFactory(nameof(__BuildURL))]
        public IBodyWorkflowAction<URLPostResponse> URL([WorkflowExpression] Func<string> output = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyorganizerEmail = null, [WorkflowExpression] Func<string[]> bodyattendeesEmails = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodymeetingDate = null, [WorkflowExpression] Func<bool> bodyrecurring = null, [WorkflowExpression] Func<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, [WorkflowExpression] Func<int> bodyrecurrencecount = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<URLPostResponse> __BuildURL(WorkflowExpression<string> output = null, WorkflowExpression<string> bodysummary = null, WorkflowExpression<string> bodydescription = null, WorkflowExpression<string> bodyorganizerEmail = null, WorkflowExpression<string[]> bodyattendeesEmails = null, WorkflowExpression<string> bodylocation = null, WorkflowExpression<string> bodytimeZone = null, WorkflowExpression<string> bodystartTime = null, WorkflowExpression<string> bodyendTime = null, WorkflowExpression<string> bodymeetingDate = null, WorkflowExpression<bool> bodyrecurring = null, WorkflowExpression<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, WorkflowExpression<int> bodyrecurrencecount = null)
        {
            WorkflowExpression.Validate(output, nameof(output), required: false);
            WorkflowExpression.Validate(bodysummary, nameof(bodysummary), required: false);
            WorkflowExpression.Validate(bodydescription, nameof(bodydescription), required: false);
            WorkflowExpression.Validate(bodyorganizerEmail, nameof(bodyorganizerEmail), required: false);
            WorkflowExpression.Validate(bodyattendeesEmails, nameof(bodyattendeesEmails), required: false);
            WorkflowExpression.Validate(bodylocation, nameof(bodylocation), required: false);
            WorkflowExpression.Validate(bodytimeZone, nameof(bodytimeZone), required: false);
            WorkflowExpression.Validate(bodystartTime, nameof(bodystartTime), required: false);
            WorkflowExpression.Validate(bodyendTime, nameof(bodyendTime), required: false);
            WorkflowExpression.Validate(bodymeetingDate, nameof(bodymeetingDate), required: false);
            WorkflowExpression.Validate(bodyrecurring, nameof(bodyrecurring), required: false);
            WorkflowExpression.Validate(bodyrecurrencefrequency, nameof(bodyrecurrencefrequency), required: false);
            WorkflowExpression.Validate(bodyrecurrencecount, nameof(bodyrecurrencecount), required: false);
            return new DeferredBodyAction<URLPostResponse>(() =>
            {
                var apiCallPath = "/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = ExpressionConverter.Convert(output);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysummary != null)
                {
                    body["summary"] = ExpressionConverter.ConvertO(bodysummary);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = ExpressionConverter.ConvertO(bodydescription);
                    bodypropCount++;
                }

                if (bodyorganizerEmail != null)
                {
                    body["organizer_email"] = ExpressionConverter.ConvertO(bodyorganizerEmail);
                    bodypropCount++;
                }

                if (bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = ExpressionConverter.ConvertO(bodyattendeesEmails);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = ExpressionConverter.ConvertO(bodylocation);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone"] = ExpressionConverter.ConvertO(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = ExpressionConverter.ConvertO(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = ExpressionConverter.ConvertO(bodyendTime);
                    bodypropCount++;
                }

                if (bodymeetingDate != null)
                {
                    body["meeting_date"] = ExpressionConverter.ConvertO(bodymeetingDate);
                    bodypropCount++;
                }

                if (bodyrecurring != null)
                {
                    body["recurring"] = ExpressionConverter.ConvertO(bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = ExpressionConverter.ConvertO(bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = ExpressionConverter.ConvertO(bodyrecurrencecount);
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