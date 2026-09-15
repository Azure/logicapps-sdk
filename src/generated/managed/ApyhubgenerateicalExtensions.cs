//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Apyhubgenerateical
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ApyhubgenerateicalActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<string> File(Expression<Func<string>> output = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyorganizerEmail = null, Expression<Func<string[]>> bodyattendeesEmails = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodymeetingDate = null, Expression<Func<bool>> bodyrecurring = null, Expression<Func<bodyrecurrencefrequencyInput>> bodyrecurrencefrequency = null, Expression<Func<int>> bodyrecurrencecount = null)
        {
            var apiCallPath = "/file";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (output != null)
                callPayload.Queries["output"] = CSharpExpressionConverter.ConvertO(output);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysummary != null)
            {
                body["summary"] = CSharpExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyorganizerEmail != null)
            {
                body["organizer_email"] = CSharpExpressionConverter.ConvertToken(bodyorganizerEmail);
                bodypropCount++;
            }

            if (bodyattendeesEmails != null)
            {
                body["attendees_emails"] = CSharpExpressionConverter.ConvertToken(bodyattendeesEmails);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodymeetingDate != null)
            {
                body["meeting_date"] = CSharpExpressionConverter.ConvertToken(bodymeetingDate);
                bodypropCount++;
            }

            if (bodyrecurring != null)
            {
                body["recurring"] = CSharpExpressionConverter.ConvertToken(bodyrecurring);
                bodypropCount++;
            }

            var recurrenceObject = new JObject();
            var recurrenceObjectpropCount = 0;
            if (bodyrecurrencefrequency != null)
            {
                recurrenceObject["frequency"] = CSharpExpressionConverter.Convert(bodyrecurrencefrequency);
                recurrenceObjectpropCount++;
            }

            if (bodyrecurrencecount != null)
            {
                recurrenceObject["count"] = CSharpExpressionConverter.ConvertToken(bodyrecurrencecount);
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
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<URLPostResponse> URL(Expression<Func<string>> output = null, Expression<Func<string>> bodysummary = null, Expression<Func<string>> bodydescription = null, Expression<Func<string>> bodyorganizerEmail = null, Expression<Func<string[]>> bodyattendeesEmails = null, Expression<Func<string>> bodylocation = null, Expression<Func<string>> bodytimeZone = null, Expression<Func<string>> bodystartTime = null, Expression<Func<string>> bodyendTime = null, Expression<Func<string>> bodymeetingDate = null, Expression<Func<bool>> bodyrecurring = null, Expression<Func<bodyrecurrencefrequencyInput>> bodyrecurrencefrequency = null, Expression<Func<int>> bodyrecurrencecount = null)
        {
            var apiCallPath = "/url";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (output != null)
                callPayload.Queries["output"] = CSharpExpressionConverter.ConvertO(output);
            var body = new JObject();
            var bodypropCount = 0;
            if (bodysummary != null)
            {
                body["summary"] = CSharpExpressionConverter.ConvertToken(bodysummary);
                bodypropCount++;
            }

            if (bodydescription != null)
            {
                body["description"] = CSharpExpressionConverter.ConvertToken(bodydescription);
                bodypropCount++;
            }

            if (bodyorganizerEmail != null)
            {
                body["organizer_email"] = CSharpExpressionConverter.ConvertToken(bodyorganizerEmail);
                bodypropCount++;
            }

            if (bodyattendeesEmails != null)
            {
                body["attendees_emails"] = CSharpExpressionConverter.ConvertToken(bodyattendeesEmails);
                bodypropCount++;
            }

            if (bodylocation != null)
            {
                body["location"] = CSharpExpressionConverter.ConvertToken(bodylocation);
                bodypropCount++;
            }

            if (bodytimeZone != null)
            {
                body["time_zone"] = CSharpExpressionConverter.ConvertToken(bodytimeZone);
                bodypropCount++;
            }

            if (bodystartTime != null)
            {
                body["start_time"] = CSharpExpressionConverter.ConvertToken(bodystartTime);
                bodypropCount++;
            }

            if (bodyendTime != null)
            {
                body["end_time"] = CSharpExpressionConverter.ConvertToken(bodyendTime);
                bodypropCount++;
            }

            if (bodymeetingDate != null)
            {
                body["meeting_date"] = CSharpExpressionConverter.ConvertToken(bodymeetingDate);
                bodypropCount++;
            }

            if (bodyrecurring != null)
            {
                body["recurring"] = CSharpExpressionConverter.ConvertToken(bodyrecurring);
                bodypropCount++;
            }

            var recurrenceObject = new JObject();
            var recurrenceObjectpropCount = 0;
            if (bodyrecurrencefrequency != null)
            {
                recurrenceObject["frequency"] = CSharpExpressionConverter.Convert(bodyrecurrencefrequency);
                recurrenceObjectpropCount++;
            }

            if (bodyrecurrencecount != null)
            {
                recurrenceObject["count"] = CSharpExpressionConverter.ConvertToken(bodyrecurrencecount);
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