//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Pling
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class PlingActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "pling")]
        [WorkflowExpressionFactory(nameof(__BuildSendNotification))]
        public IWorkflowAction SendNotification([WorkflowExpression] Func<string> profileId, [WorkflowExpression] Func<string> bodytitle, [WorkflowExpression] Func<string> bodytemplateId, [WorkflowExpression] Func<string> bodycontent, [WorkflowExpression] Func<string[]> bodyaudienceUsers)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IWorkflowAction __BuildSendNotification(WorkflowExpression<string> profileId, WorkflowExpression<string> bodytitle, WorkflowExpression<string> bodytemplateId, WorkflowExpression<string> bodycontent, WorkflowExpression<string[]> bodyaudienceUsers)
        {
            WorkflowExpression.Validate(profileId, nameof(profileId), required: true);
            WorkflowExpression.Validate(bodytitle, nameof(bodytitle), required: true);
            WorkflowExpression.Validate(bodytemplateId, nameof(bodytemplateId), required: true);
            WorkflowExpression.Validate(bodycontent, nameof(bodycontent), required: true);
            WorkflowExpression.Validate(bodyaudienceUsers, nameof(bodyaudienceUsers), required: true);
            return new DeferredWorkflowAction(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}/messages", ExpressionConverter.ConvertWithUrlEncoding(profileId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                bodypropCount++;
                body["title"] = ExpressionConverter.ConvertO(bodytitle);
                bodypropCount++;
                body["templateId"] = ExpressionConverter.ConvertO(bodytemplateId);
                bodypropCount++;
                body["content"] = ExpressionConverter.ConvertO(bodycontent);
                bodypropCount++;
                body["audienceUsers"] = ExpressionConverter.ConvertO(bodyaudienceUsers);
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
        [WorkflowExpressionFactory(nameof(__BuildGetTemplates))]
        public IBodyWorkflowAction<GetTemplatesResponseItem[]> GetTemplates([WorkflowExpression] Func<string> profileId)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetTemplatesResponseItem[]> __BuildGetTemplates(WorkflowExpression<string> profileId)
        {
            WorkflowExpression.Validate(profileId, nameof(profileId), required: true);
            return new DeferredBodyAction<GetTemplatesResponseItem[]>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/profiles/{0}/templates", ExpressionConverter.ConvertWithUrlEncoding(profileId, 1));
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