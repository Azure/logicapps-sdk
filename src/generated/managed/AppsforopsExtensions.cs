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
        public IBodyWorkflowAction<NPSCreateResponse> ApiExtNPS(Expression<Func<string>> modelemail, Expression<Func<int>> modelscore, Expression<Func<string>> modelratingDate, Expression<Func<string>> modelname = null, Expression<Func<string>> modelcomments = null, Expression<Func<string>> modeladditionalData = null)
        {
            var apiCallPath = "/api/ext/NPS";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            modelpropCount++;
            model["email"] = CSharpExpressionConverter.ConvertToken(modelemail);
            if (modelname != null)
            {
                model["name"] = CSharpExpressionConverter.ConvertToken(modelname);
                modelpropCount++;
            }

            modelpropCount++;
            model["score"] = CSharpExpressionConverter.ConvertToken(modelscore);
            modelpropCount++;
            model["ratingDate"] = CSharpExpressionConverter.ConvertToken(modelratingDate);
            if (modelcomments != null)
            {
                model["comments"] = CSharpExpressionConverter.ConvertToken(modelcomments);
                modelpropCount++;
            }

            if (modeladditionalData != null)
            {
                model["additionalData"] = CSharpExpressionConverter.ConvertToken(modeladditionalData);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<NPSCreateResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "appsforops")]
        public IBodyWorkflowAction<TimelineCreateResponse> ApiExtTimeline(Expression<Func<string>> modelsource, Expression<Func<string>> modeltitle, Expression<Func<string>> modeldescription, Expression<Func<string>> modeltoDisplayName, Expression<Func<string>> modeltoEmail, Expression<Func<string>> modelfromDisplayName, Expression<Func<string>> modelfromEmail, Expression<Func<string>> modelcreatedByDateTime, Expression<Func<string>> modelculture = null)
        {
            var apiCallPath = "/api/ext/Timeline";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var model = new JObject();
            var modelpropCount = 0;
            modelpropCount++;
            model["source"] = CSharpExpressionConverter.ConvertToken(modelsource);
            modelpropCount++;
            model["title"] = CSharpExpressionConverter.ConvertToken(modeltitle);
            modelpropCount++;
            model["description"] = CSharpExpressionConverter.ConvertToken(modeldescription);
            modelpropCount++;
            model["toDisplayName"] = CSharpExpressionConverter.ConvertToken(modeltoDisplayName);
            modelpropCount++;
            model["toEmail"] = CSharpExpressionConverter.ConvertToken(modeltoEmail);
            modelpropCount++;
            model["fromDisplayName"] = CSharpExpressionConverter.ConvertToken(modelfromDisplayName);
            modelpropCount++;
            model["fromEmail"] = CSharpExpressionConverter.ConvertToken(modelfromEmail);
            modelpropCount++;
            model["createdByDateTime"] = CSharpExpressionConverter.ConvertToken(modelcreatedByDateTime);
            if (modelculture != null)
            {
                model["culture"] = CSharpExpressionConverter.ConvertToken(modelculture);
                modelpropCount++;
            }

            if (modelpropCount > 0)
            {
                callPayload.Body = model;
            }

            return new ApiConnectionAction<TimelineCreateResponse>(callPayload);
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