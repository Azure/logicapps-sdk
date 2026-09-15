//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pling
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlingActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IWorkflowAction SendNotification(Expression<Func<string>> profileId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodycontent, Expression<Func<string[]>> bodyaudienceUsers)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}/messages", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var body = new JObject();
            var bodypropCount = 0;
            bodypropCount++;
            body["title"] = CSharpExpressionConverter.ConvertToken(bodytitle);
            bodypropCount++;
            body["templateId"] = CSharpExpressionConverter.ConvertToken(bodytemplateId);
            bodypropCount++;
            body["content"] = CSharpExpressionConverter.ConvertToken(bodycontent);
            bodypropCount++;
            body["audienceUsers"] = CSharpExpressionConverter.ConvertToken(bodyaudienceUsers);
            var additionalTemplateDataObject = new JObject();
            var additionalTemplateDataObjectpropCount = 0;
            if (additionalTemplateDataObjectpropCount > 0)
            {
                body["additionalTemplateData"] = additionalTemplateDataObject;
                bodypropCount++;
            }

            if (bodypropCount > 0)
            {
                callPayload.Body = body;
            }

            return new ApiConnectionAction(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetProfilesResponseItem[]> GetProfiles()
        {
            var apiCallPath = "/profiles";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetProfilesResponseItem[]>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetTemplatesResponseItem[]> GetTemplates(Expression<Func<string>> profileId)
        {
            var apiCallPath = CSharpExpressionConverter.ConvertGeneratedPath("/profiles/{0}/templates", CSharpExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<GetTemplatesResponseItem[]>(callPayload);
        }
    }

    public class PlingTriggers([ConnectionName] string connectionId)
    {
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