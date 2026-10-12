//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppsforopsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        [WorkflowExpressionFactory(nameof(__BuildApiExtNPS))]
        public IBodyWorkflowAction<NPSCreateResponse> ApiExtNPS([WorkflowExpression] Func<string> modelemail, [WorkflowExpression] Func<int> modelscore, [WorkflowExpression] Func<string> modelratingDate, [WorkflowExpression] Func<string> modelname = null, [WorkflowExpression] Func<string> modelcomments = null, [WorkflowExpression] Func<string> modeladditionalData = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NPSCreateResponse> __BuildApiExtNPS(WorkflowExpression<string> modelemail, WorkflowExpression<int> modelscore, WorkflowExpression<string> modelratingDate, WorkflowExpression<string> modelname = null, WorkflowExpression<string> modelcomments = null, WorkflowExpression<string> modeladditionalData = null)
        {
            WorkflowExpression.Validate(modelemail, nameof(modelemail), required: true);
            WorkflowExpression.Validate(modelscore, nameof(modelscore), required: true);
            WorkflowExpression.Validate(modelratingDate, nameof(modelratingDate), required: true);
            WorkflowExpression.Validate(modelname, nameof(modelname), required: false);
            WorkflowExpression.Validate(modelcomments, nameof(modelcomments), required: false);
            WorkflowExpression.Validate(modeladditionalData, nameof(modeladditionalData), required: false);
            return new DeferredBodyAction<NPSCreateResponse>(() =>
            {
                var apiCallPath = "/api/ext/NPS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["email"] = ExpressionConverter.ConvertO(modelemail);
                if (modelname != null)
                {
                    model["name"] = ExpressionConverter.ConvertO(modelname);
                    modelpropCount++;
                }

                modelpropCount++;
                model["score"] = ExpressionConverter.ConvertO(modelscore);
                modelpropCount++;
                model["ratingDate"] = ExpressionConverter.ConvertO(modelratingDate);
                if (modelcomments != null)
                {
                    model["comments"] = ExpressionConverter.ConvertO(modelcomments);
                    modelpropCount++;
                }

                if (modeladditionalData != null)
                {
                    model["additionalData"] = ExpressionConverter.ConvertO(modeladditionalData);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<NPSCreateResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        [WorkflowExpressionFactory(nameof(__BuildApiExtTimeline))]
        public IBodyWorkflowAction<TimelineCreateResponse> ApiExtTimeline([WorkflowExpression] Func<string> modelsource, [WorkflowExpression] Func<string> modeltitle, [WorkflowExpression] Func<string> modeldescription, [WorkflowExpression] Func<string> modeltoDisplayName, [WorkflowExpression] Func<string> modeltoEmail, [WorkflowExpression] Func<string> modelfromDisplayName, [WorkflowExpression] Func<string> modelfromEmail, [WorkflowExpression] Func<string> modelcreatedByDateTime, [WorkflowExpression] Func<string> modelculture = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimelineCreateResponse> __BuildApiExtTimeline(WorkflowExpression<string> modelsource, WorkflowExpression<string> modeltitle, WorkflowExpression<string> modeldescription, WorkflowExpression<string> modeltoDisplayName, WorkflowExpression<string> modeltoEmail, WorkflowExpression<string> modelfromDisplayName, WorkflowExpression<string> modelfromEmail, WorkflowExpression<string> modelcreatedByDateTime, WorkflowExpression<string> modelculture = null)
        {
            WorkflowExpression.Validate(modelsource, nameof(modelsource), required: true);
            WorkflowExpression.Validate(modeltitle, nameof(modeltitle), required: true);
            WorkflowExpression.Validate(modeldescription, nameof(modeldescription), required: true);
            WorkflowExpression.Validate(modeltoDisplayName, nameof(modeltoDisplayName), required: true);
            WorkflowExpression.Validate(modeltoEmail, nameof(modeltoEmail), required: true);
            WorkflowExpression.Validate(modelfromDisplayName, nameof(modelfromDisplayName), required: true);
            WorkflowExpression.Validate(modelfromEmail, nameof(modelfromEmail), required: true);
            WorkflowExpression.Validate(modelcreatedByDateTime, nameof(modelcreatedByDateTime), required: true);
            WorkflowExpression.Validate(modelculture, nameof(modelculture), required: false);
            return new DeferredBodyAction<TimelineCreateResponse>(() =>
            {
                var apiCallPath = "/api/ext/Timeline";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["source"] = ExpressionConverter.ConvertO(modelsource);
                modelpropCount++;
                model["title"] = ExpressionConverter.ConvertO(modeltitle);
                modelpropCount++;
                model["description"] = ExpressionConverter.ConvertO(modeldescription);
                modelpropCount++;
                model["toDisplayName"] = ExpressionConverter.ConvertO(modeltoDisplayName);
                modelpropCount++;
                model["toEmail"] = ExpressionConverter.ConvertO(modeltoEmail);
                modelpropCount++;
                model["fromDisplayName"] = ExpressionConverter.ConvertO(modelfromDisplayName);
                modelpropCount++;
                model["fromEmail"] = ExpressionConverter.ConvertO(modelfromEmail);
                modelpropCount++;
                model["createdByDateTime"] = ExpressionConverter.ConvertO(modelcreatedByDateTime);
                if (modelculture != null)
                {
                    model["culture"] = ExpressionConverter.ConvertO(modelculture);
                    modelpropCount++;
                }

                if (modelpropCount > 0)
                {
                    callPayload.Body = model;
                }

                return new ApiConnectionAction<TimelineCreateResponse>(callPayload);
            });
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