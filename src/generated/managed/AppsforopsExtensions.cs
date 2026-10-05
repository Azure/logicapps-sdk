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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<NPSCreateResponse> __BuildApiExtNPS(WorkflowValue<string> modelemail, WorkflowValue<int> modelscore, WorkflowValue<string> modelratingDate, WorkflowValue<string> modelname = null, WorkflowValue<string> modelcomments = null, WorkflowValue<string> modeladditionalData = null)
        {
            WorkflowValue.Validate(modelemail, nameof(modelemail), required: true);
            WorkflowValue.Validate(modelscore, nameof(modelscore), required: true);
            WorkflowValue.Validate(modelratingDate, nameof(modelratingDate), required: true);
            WorkflowValue.Validate(modelname, nameof(modelname), required: false);
            WorkflowValue.Validate(modelcomments, nameof(modelcomments), required: false);
            WorkflowValue.Validate(modeladditionalData, nameof(modeladditionalData), required: false);
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
            throw new NotSupportedException("This workflow call requires the SDK source compiler. Build with Microsoft.Azure.Workflows.Sdk build assets enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<TimelineCreateResponse> __BuildApiExtTimeline(WorkflowValue<string> modelsource, WorkflowValue<string> modeltitle, WorkflowValue<string> modeldescription, WorkflowValue<string> modeltoDisplayName, WorkflowValue<string> modeltoEmail, WorkflowValue<string> modelfromDisplayName, WorkflowValue<string> modelfromEmail, WorkflowValue<string> modelcreatedByDateTime, WorkflowValue<string> modelculture = null)
        {
            WorkflowValue.Validate(modelsource, nameof(modelsource), required: true);
            WorkflowValue.Validate(modeltitle, nameof(modeltitle), required: true);
            WorkflowValue.Validate(modeldescription, nameof(modeldescription), required: true);
            WorkflowValue.Validate(modeltoDisplayName, nameof(modeltoDisplayName), required: true);
            WorkflowValue.Validate(modeltoEmail, nameof(modeltoEmail), required: true);
            WorkflowValue.Validate(modelfromDisplayName, nameof(modelfromDisplayName), required: true);
            WorkflowValue.Validate(modelfromEmail, nameof(modelfromEmail), required: true);
            WorkflowValue.Validate(modelcreatedByDateTime, nameof(modelcreatedByDateTime), required: true);
            WorkflowValue.Validate(modelculture, nameof(modelculture), required: false);
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
