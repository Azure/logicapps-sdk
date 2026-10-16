//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Appsforops
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class AppsforopsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<NPSCreateResponse> ApiExtNPS(Expression<Func<string>> modelemail, Expression<Func<int>> modelscore, Expression<Func<string>> modelratingDate, Expression<Func<string>> modelname = null, Expression<Func<string>> modelcomments = null, Expression<Func<string>> modeladditionalData = null)
        {
            var __workflow_modelemail = WorkflowExpression.Compile(modelemail, nameof(modelemail), required: true);
            var __workflow_modelscore = WorkflowExpression.Compile(modelscore, nameof(modelscore), required: true);
            var __workflow_modelratingDate = WorkflowExpression.Compile(modelratingDate, nameof(modelratingDate), required: true);
            var __workflow_modelname = WorkflowExpression.Compile(modelname, nameof(modelname), required: false);
            var __workflow_modelcomments = WorkflowExpression.Compile(modelcomments, nameof(modelcomments), required: false);
            var __workflow_modeladditionalData = WorkflowExpression.Compile(modeladditionalData, nameof(modeladditionalData), required: false);
            return new DeferredBodyAction<NPSCreateResponse>(() =>
            {
                var apiCallPath = "/api/ext/NPS";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["email"] = ExpressionConverter.ConvertO(__workflow_modelemail);
                if (__workflow_modelname != null)
                {
                    model["name"] = ExpressionConverter.ConvertO(__workflow_modelname);
                    modelpropCount++;
                }

                modelpropCount++;
                model["score"] = ExpressionConverter.ConvertO(__workflow_modelscore);
                modelpropCount++;
                model["ratingDate"] = ExpressionConverter.ConvertO(__workflow_modelratingDate);
                if (__workflow_modelcomments != null)
                {
                    model["comments"] = ExpressionConverter.ConvertO(__workflow_modelcomments);
                    modelpropCount++;
                }

                if (__workflow_modeladditionalData != null)
                {
                    model["additionalData"] = ExpressionConverter.ConvertO(__workflow_modeladditionalData);
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
        public IBodyWorkflowAction<TimelineCreateResponse> ApiExtTimeline(Expression<Func<string>> modelsource, Expression<Func<string>> modeltitle, Expression<Func<string>> modeldescription, Expression<Func<string>> modeltoDisplayName, Expression<Func<string>> modeltoEmail, Expression<Func<string>> modelfromDisplayName, Expression<Func<string>> modelfromEmail, Expression<Func<string>> modelcreatedByDateTime, Expression<Func<string>> modelculture = null)
        {
            var __workflow_modelsource = WorkflowExpression.Compile(modelsource, nameof(modelsource), required: true);
            var __workflow_modeltitle = WorkflowExpression.Compile(modeltitle, nameof(modeltitle), required: true);
            var __workflow_modeldescription = WorkflowExpression.Compile(modeldescription, nameof(modeldescription), required: true);
            var __workflow_modeltoDisplayName = WorkflowExpression.Compile(modeltoDisplayName, nameof(modeltoDisplayName), required: true);
            var __workflow_modeltoEmail = WorkflowExpression.Compile(modeltoEmail, nameof(modeltoEmail), required: true);
            var __workflow_modelfromDisplayName = WorkflowExpression.Compile(modelfromDisplayName, nameof(modelfromDisplayName), required: true);
            var __workflow_modelfromEmail = WorkflowExpression.Compile(modelfromEmail, nameof(modelfromEmail), required: true);
            var __workflow_modelcreatedByDateTime = WorkflowExpression.Compile(modelcreatedByDateTime, nameof(modelcreatedByDateTime), required: true);
            var __workflow_modelculture = WorkflowExpression.Compile(modelculture, nameof(modelculture), required: false);
            return new DeferredBodyAction<TimelineCreateResponse>(() =>
            {
                var apiCallPath = "/api/ext/Timeline";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var model = new JObject();
                var modelpropCount = 0;
                modelpropCount++;
                model["source"] = ExpressionConverter.ConvertO(__workflow_modelsource);
                modelpropCount++;
                model["title"] = ExpressionConverter.ConvertO(__workflow_modeltitle);
                modelpropCount++;
                model["description"] = ExpressionConverter.ConvertO(__workflow_modeldescription);
                modelpropCount++;
                model["toDisplayName"] = ExpressionConverter.ConvertO(__workflow_modeltoDisplayName);
                modelpropCount++;
                model["toEmail"] = ExpressionConverter.ConvertO(__workflow_modeltoEmail);
                modelpropCount++;
                model["fromDisplayName"] = ExpressionConverter.ConvertO(__workflow_modelfromDisplayName);
                modelpropCount++;
                model["fromEmail"] = ExpressionConverter.ConvertO(__workflow_modelfromEmail);
                modelpropCount++;
                model["createdByDateTime"] = ExpressionConverter.ConvertO(__workflow_modelcreatedByDateTime);
                if (__workflow_modelculture != null)
                {
                    model["culture"] = ExpressionConverter.ConvertO(__workflow_modelculture);
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
