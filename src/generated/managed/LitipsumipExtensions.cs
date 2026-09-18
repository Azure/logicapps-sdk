//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Litipsumip
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class LitipsumipActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "litipsumip")]
        public IBodyWorkflowAction<TextRandomResponse> TextRandom()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/json";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TextRandomResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "litipsumip")]
        public IBodyWorkflowAction<TextTitleResponse> TextTitle([WorkflowExpression] Func<titleInput> title)
        {
            SourceExpression.Validate(title, nameof(title), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/{0}/json", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(title, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<TextTitleResponse>(BuildSourceInput);
        }
    }

    public class LitipsumipTriggers([ConnectionName] string connectionId)
    {
    }

    public class TextRandomResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("text")]
        public string[] Text { get; set; }
    }

    public class TextTitleResponse
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("length")]
        public int Length { get; set; }

        [JsonProperty("text")]
        public string[] Text { get; set; }
    }

    public enum titleInput
    {
        [EnumMember(Value = "adventures-sherlock-holmes")]
        AdventuresSherlockHolmes,
        [EnumMember(Value = "dr-jekyll-and-mr-hyde")]
        DrJekyllAndMrHyde,
        [EnumMember(Value = "dracula")]
        Dracula,
        [EnumMember(Value = "evelina")]
        Evelina,
        [EnumMember(Value = "life-of-samuel-johnson")]
        LifeOfSamuelJohnson,
        [EnumMember(Value = "picture-of-dorian-gray")]
        PictureOfDorianGray,
        [EnumMember(Value = "pride-and-prejudice")]
        PrideAndPrejudice
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Litipsumip;

    public partial class WorkflowManagedActions
    {
        public LitipsumipActions Litipsumip(string connectionId) => new LitipsumipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public LitipsumipTriggers Litipsumip(string connectionId) => new LitipsumipTriggers(connectionId);
    }
}