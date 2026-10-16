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
        public IWorkflowAction SendNotification(Expression<Func<string>> profileId, Expression<Func<string>> bodytitle, Expression<Func<string>> bodytemplateId, Expression<Func<string>> bodycontent, Expression<Func<string[]>> bodyaudienceUsers)
        {
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            var __workflow_bodytitle = WorkflowExpression.Compile(bodytitle, nameof(bodytitle), required: true);
            var __workflow_bodytemplateId = WorkflowExpression.Compile(bodytemplateId, nameof(bodytemplateId), required: true);
            var __workflow_bodycontent = WorkflowExpression.Compile(bodycontent, nameof(bodycontent), required: true);
            var __workflow_bodyaudienceUsers = WorkflowExpression.Compile(bodyaudienceUsers, nameof(bodyaudienceUsers), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(__workflow_profileId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(__workflow_bodytitle);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(__workflow_bodytemplateId);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(__workflow_bodycontent);
                bodypropCount++;
                body["audienceUsers"] = ExpressionConverter.ConvertO(__workflow_bodyaudienceUsers);
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
            });
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
            var __workflow_profileId = WorkflowExpression.Compile(profileId, nameof(profileId), required: true);
            return new DeferredBodyAction<GetTemplatesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(__workflow_profileId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<GetTemplatesResponseItem[]>(callPayload);
            });
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
