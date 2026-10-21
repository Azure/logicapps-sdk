//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Owlbotip
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class OwlbotipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "owlbotip")]
        public IBodyWorkflowAction<DefResponse> Def(Expression<Func<string>> word)
        {
            var __workflow_word = WorkflowExpression.Compile(word, nameof(word), required: true);
            return new DeferredBodyAction<DefResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/{0}", __workflow_word.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<DefResponse>(callPayload);
            }, WorkflowActionSettingProfiles.RetrySecureTracked);
        }
    }

    public class OwlbotipTriggers([ConnectionName] string connectionId)
    {
    }

    public class DefResponse
    {
        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("pronunciation")]
        public string Pronunciation { get; set; }

        [JsonProperty("definitions")]
        public DefResponseDefinitionsTypeItem[] Definitions { get; set; }
    }

    public class DefResponseDefinitionsTypeItem
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("definition")]
        public string Definition { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Owlbotip;

    public partial class WorkflowManagedActions
    {
        public OwlbotipActions Owlbotip(string connectionId) => new OwlbotipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public OwlbotipTriggers Owlbotip(string connectionId) => new OwlbotipTriggers(connectionId);
    }
}
