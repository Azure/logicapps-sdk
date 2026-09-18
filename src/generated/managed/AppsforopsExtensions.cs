//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppsforopsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<NPSCreateResponse> ApiExtNPS([WorkflowExpression] Func<string> modelemail, [WorkflowExpression] Func<int> modelscore, [WorkflowExpression] Func<string> modelratingDate, [WorkflowExpression] Func<string> modelname = null, [WorkflowExpression] Func<string> modelcomments = null, [WorkflowExpression] Func<string> modeladditionalData = null)
        {
            SourceExpression.Validate(modelemail, nameof(modelemail), required: true);
            SourceExpression.Validate(modelscore, nameof(modelscore), required: true);
            SourceExpression.Validate(modelratingDate, nameof(modelratingDate), required: true);
            SourceExpression.Validate(modelname, nameof(modelname), required: false);
            SourceExpression.Validate(modelcomments, nameof(modelcomments), required: false);
            SourceExpression.Validate(modeladditionalData, nameof(modeladditionalData), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ext/NPS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["email"] = SourceExpressionConverter.ConvertToken(modelemail);
                if (modelname != null)
                {
                    model["name"] = SourceExpressionConverter.ConvertToken(modelname);
                    modelpropCount++;
                }

                modelpropCount++;
                model["score"] = SourceExpressionConverter.ConvertToken(modelscore);
                modelpropCount++;
                model["ratingDate"] = SourceExpressionConverter.ConvertToken(modelratingDate);
                if (modelcomments != null)
                {
                    model["comments"] = SourceExpressionConverter.ConvertToken(modelcomments);
                    modelpropCount++;
                }

                if (modeladditionalData != null)
                {
                    model["additionalData"] = SourceExpressionConverter.ConvertToken(modeladditionalData);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }
                return callPayload;
            }

            return new ApiConnectionAction<NPSCreateResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<TimelineCreateResponse> ApiExtTimeline([WorkflowExpression] Func<string> modelsource, [WorkflowExpression] Func<string> modeltitle, [WorkflowExpression] Func<string> modeldescription, [WorkflowExpression] Func<string> modeltoDisplayName, [WorkflowExpression] Func<string> modeltoEmail, [WorkflowExpression] Func<string> modelfromDisplayName, [WorkflowExpression] Func<string> modelfromEmail, [WorkflowExpression] Func<string> modelcreatedByDateTime, [WorkflowExpression] Func<string> modelculture = null)
        {
            SourceExpression.Validate(modelsource, nameof(modelsource), required: true);
            SourceExpression.Validate(modeltitle, nameof(modeltitle), required: true);
            SourceExpression.Validate(modeldescription, nameof(modeldescription), required: true);
            SourceExpression.Validate(modeltoDisplayName, nameof(modeltoDisplayName), required: true);
            SourceExpression.Validate(modeltoEmail, nameof(modeltoEmail), required: true);
            SourceExpression.Validate(modelfromDisplayName, nameof(modelfromDisplayName), required: true);
            SourceExpression.Validate(modelfromEmail, nameof(modelfromEmail), required: true);
            SourceExpression.Validate(modelcreatedByDateTime, nameof(modelcreatedByDateTime), required: true);
            SourceExpression.Validate(modelculture, nameof(modelculture), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/api/ext/Timeline";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["source"] = SourceExpressionConverter.ConvertToken(modelsource);
                modelpropCount++;
                model["title"] = SourceExpressionConverter.ConvertToken(modeltitle);
                modelpropCount++;
                model["description"] = SourceExpressionConverter.ConvertToken(modeldescription);
                modelpropCount++;
                model["toDisplayName"] = SourceExpressionConverter.ConvertToken(modeltoDisplayName);
                modelpropCount++;
                model["toEmail"] = SourceExpressionConverter.ConvertToken(modeltoEmail);
                modelpropCount++;
                model["fromDisplayName"] = SourceExpressionConverter.ConvertToken(modelfromDisplayName);
                modelpropCount++;
                model["fromEmail"] = SourceExpressionConverter.ConvertToken(modelfromEmail);
                modelpropCount++;
                model["createdByDateTime"] = SourceExpressionConverter.ConvertToken(modelcreatedByDateTime);
                if (modelculture != null)
                {
                    model["culture"] = SourceExpressionConverter.ConvertToken(modelculture);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }
                return callPayload;
            }

            return new ApiConnectionAction<TimelineCreateResponse>(BuildSourceInput);
        }
    }

    public class AppsforopsTriggers([ConnectionName] string connectionId)
    {
    }

    public class NPSCreateResponse
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("comments")]
        public string Comments { get; set; }

        [JsonProperty("additionalData")]
        public string AdditionalData { get; set; }
    }

    public class TimelineCreateResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("channelName")]
        public string ChannelName { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; set; }

        [JsonProperty("fromDisplayName")]
        public string FromDisplayName { get; set; }

        [JsonProperty("toEmail")]
        public string ToEmail { get; set; }

        [JsonProperty("toDisplayName")]
        public string ToDisplayName { get; set; }

        [JsonProperty("createdByDateTime")]
        public string CreatedByDateTime { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops;

    public partial class WorkflowManagedActions
    {
        public AppsforopsActions Appsforops(string connectionId) => new AppsforopsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public AppsforopsTriggers Appsforops(string connectionId) => new AppsforopsTriggers(connectionId);
    }
}