//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Tendocsdocuments
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class TendocsdocumentsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "tendocsdocuments")]
        public IBodyWorkflowAction<AiTemplateBuilderResponse> V1AiTemplateBuilderPost(Expression<Func<string>> requestdescribeTheDocument1000Chars)
        {
            var apiCallPath = "/ai/v1/tasks/templateBuilder";
            var apiCallHttpMethod = "post";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            var request = new JObject();
            var requestpropCount = 0;
            requestpropCount++;
            request["description"] = ExpressionConverter.ConvertO(requestdescribeTheDocument1000Chars);
            var configurationObject = new JObject();
            var configurationObjectpropCount = 0;
            var keysObject = new JObject();
            var keysObjectpropCount = 0;
            if (keysObjectpropCount > 0)
            {
                configurationObject["keys"] = keysObject;
                configurationObjectpropCount++;
            }

            if (configurationObjectpropCount > 0)
            {
                request["configuration"] = configurationObject;
                requestpropCount++;
            }

            if (requestpropCount > 0)
            {
                callPayload.Body = request;
            }

            return new ApiConnectionAction<AiTemplateBuilderResponse>(callPayload);
        }
    }

    public class TendocsdocumentsTriggers([ConnectionName] string connectionId)
    {
    }

    public class AiTemplateBuilderResponse
    {
        [JsonProperty("title")]
        public string DocumentTitle { get; set; }

        [JsonProperty("filename")]
        public string DocumentFilename { get; set; }

        [JsonProperty("outline")]
        public AiTemplateBuilderResponseOutlineTypeItem[] Outline { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem[] Subheadings { get; set; }
    }

    public class AiTemplateBuilderResponseOutlineTypeItemSubheadingsTypeItem
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("summary")]
        public string Description { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }

        [JsonProperty("subheadings")]
        public JToken[] Subsections { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Tendocsdocuments;

    public partial class WorkflowManagedActions
    {
        public TendocsdocumentsActions Tendocsdocuments(string connectionId) => new TendocsdocumentsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public TendocsdocumentsTriggers Tendocsdocuments(string connectionId) => new TendocsdocumentsTriggers(connectionId);
    }
}