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
        public IBodyWorkflowAction<string> File([WorkflowExpression] Func<string> output = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyorganizerEmail = null, [WorkflowExpression] Func<string[]> bodyattendeesEmails = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodymeetingDate = null, [WorkflowExpression] Func<bool> bodyrecurring = null, [WorkflowExpression] Func<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, [WorkflowExpression] Func<int> bodyrecurrencecount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/file";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = SourceExpressionConverter.ConvertO(output);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyorganizerEmail != null)
                {
                    body["organizer_email"] = SourceExpressionConverter.ConvertToken(bodyorganizerEmail);
                    bodypropCount++;
                }

                if (bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = SourceExpressionConverter.ConvertToken(bodyattendeesEmails);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodymeetingDate != null)
                {
                    body["meeting_date"] = SourceExpressionConverter.ConvertToken(bodymeetingDate);
                    bodypropCount++;
                }

                if (bodyrecurring != null)
                {
                    body["recurring"] = SourceExpressionConverter.ConvertToken(bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = SourceExpressionConverter.Convert(bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = SourceExpressionConverter.ConvertToken(bodyrecurrencecount);
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
                return callPayload;
            }

            return new ApiConnectionAction<string>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "apyhubgenerateical")]
        public IBodyWorkflowAction<URLPostResponse> URL([WorkflowExpression] Func<string> output = null, [WorkflowExpression] Func<string> bodysummary = null, [WorkflowExpression] Func<string> bodydescription = null, [WorkflowExpression] Func<string> bodyorganizerEmail = null, [WorkflowExpression] Func<string[]> bodyattendeesEmails = null, [WorkflowExpression] Func<string> bodylocation = null, [WorkflowExpression] Func<string> bodytimeZone = null, [WorkflowExpression] Func<string> bodystartTime = null, [WorkflowExpression] Func<string> bodyendTime = null, [WorkflowExpression] Func<string> bodymeetingDate = null, [WorkflowExpression] Func<bool> bodyrecurring = null, [WorkflowExpression] Func<bodyrecurrencefrequencyInput> bodyrecurrencefrequency = null, [WorkflowExpression] Func<int> bodyrecurrencecount = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/url";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (output != null)
                    callPayload.Queries["output"] = SourceExpressionConverter.ConvertO(output);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodysummary != null)
                {
                    body["summary"] = SourceExpressionConverter.ConvertToken(bodysummary);
                    bodypropCount++;
                }

                if (bodydescription != null)
                {
                    body["description"] = SourceExpressionConverter.ConvertToken(bodydescription);
                    bodypropCount++;
                }

                if (bodyorganizerEmail != null)
                {
                    body["organizer_email"] = SourceExpressionConverter.ConvertToken(bodyorganizerEmail);
                    bodypropCount++;
                }

                if (bodyattendeesEmails != null)
                {
                    body["attendees_emails"] = SourceExpressionConverter.ConvertToken(bodyattendeesEmails);
                    bodypropCount++;
                }

                if (bodylocation != null)
                {
                    body["location"] = SourceExpressionConverter.ConvertToken(bodylocation);
                    bodypropCount++;
                }

                if (bodytimeZone != null)
                {
                    body["time_zone"] = SourceExpressionConverter.ConvertToken(bodytimeZone);
                    bodypropCount++;
                }

                if (bodystartTime != null)
                {
                    body["start_time"] = SourceExpressionConverter.ConvertToken(bodystartTime);
                    bodypropCount++;
                }

                if (bodyendTime != null)
                {
                    body["end_time"] = SourceExpressionConverter.ConvertToken(bodyendTime);
                    bodypropCount++;
                }

                if (bodymeetingDate != null)
                {
                    body["meeting_date"] = SourceExpressionConverter.ConvertToken(bodymeetingDate);
                    bodypropCount++;
                }

                if (bodyrecurring != null)
                {
                    body["recurring"] = SourceExpressionConverter.ConvertToken(bodyrecurring);
                    bodypropCount++;
                }

                var recurrenceObject = new JObject();
                var recurrenceObjectpropCount = 0;
                if (bodyrecurrencefrequency != null)
                {
                    recurrenceObject["frequency"] = SourceExpressionConverter.Convert(bodyrecurrencefrequency);
                    recurrenceObjectpropCount++;
                }

                if (bodyrecurrencecount != null)
                {
                    recurrenceObject["count"] = SourceExpressionConverter.ConvertToken(bodyrecurrencecount);
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
                return callPayload;
            }

            return new ApiConnectionAction<URLPostResponse>(BuildSourceInput);
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