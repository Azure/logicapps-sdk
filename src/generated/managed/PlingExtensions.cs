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
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string[]> bodyaudienceUsers)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}/messages", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = SourceExpressionConverter.ConvertToken(bodytitle);
                bodypropCount++;
                body["templateId"] = SourceExpressionConverter.ConvertToken(bodytemplateId);
                bodypropCount++;
                body["content"] = SourceExpressionConverter.ConvertToken(bodycontent);
                bodypropCount++;
                body["audienceUsers"] = SourceExpressionConverter.ConvertToken(bodyaudienceUsers);
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
                return callPayload;
            }

            return new ApiConnectionAction(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetProfilesResponseItem[]> GetProfiles()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/profiles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetProfilesResponseItem[]>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        public IBodyWorkflowAction<GetTemplatesResponseItem[]> GetTemplates([WorkflowExpression] Func<string> profileId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/profiles/{0}/templates", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(profileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<GetTemplatesResponseItem[]>(BuildSourceInput);
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