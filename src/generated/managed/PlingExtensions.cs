//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pling
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IWorkflowAction<ApiConnectionActionConfiguration> SendNotification(Expression<Func<string>> profileId, Expression<Func<SendNotificationInput>> body)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_body = WorkflowExpression.Compile(body, nameof(body), required: true);
            return new DeferredWorkflowAction<ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}/messages", __workflow_profileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Body = ExpressionConverter.ConvertO(__workflow_body);
                return new ApiConnectionAction(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetProfilesResponseItem[], ApiConnectionActionConfiguration> GetProfiles()
        {
            return new DeferredBodyAction<GetProfilesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetProfilesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetTemplatesResponseItem[], ApiConnectionActionConfiguration> GetTemplates(Expression<Func<string>> profileId)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            return new DeferredBodyAction<GetTemplatesResponseItem[], ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/profiles/{0}/templates", __workflow_profileId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplatesResponseItem[]>(callPayload);
            });
        }
    }

    public class PlingTriggers([ConnectionName] string connectionId)
    {
    }

    public class SendNotificationInput
    {
        [JsonProperty("title", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Title { get; set; }

        [JsonProperty("templateId", DefaultValueHandling = DefaultValueHandling.Include)]
        public string TemplateId { get; set; }

        [JsonProperty("content", DefaultValueHandling = DefaultValueHandling.Include)]
        public string Content { get; set; }

        [JsonProperty("audienceUsers", DefaultValueHandling = DefaultValueHandling.Include)]
        public string[] AudienceUsers { get; set; }

        [JsonProperty("additionalTemplateData", DefaultValueHandling = DefaultValueHandling.Include)]
        public JToken AdditionalTemplateData { get; set; } = JToken.Parse("{\"imageUrl\":\"Insert your image url here if the chosen template includes an image\",\"priority\":\"Default\",\"property1\":\"Insert more properties here for your custom templates\",\"property2\":\"Find your properties inside the Pling app in Microsoft Teams\"}");
    }

    public class GetProfilesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class GetTemplatesResponseItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Pling;

    public partial class WorkflowManagedActions
    {
        public PlingActions Pling(string connectionId) => new PlingActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public PlingTriggers Pling(string connectionId) => new PlingTriggers(connectionId);
    }
}