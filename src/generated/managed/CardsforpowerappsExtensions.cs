//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardsforpowerapps
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class CardsforpowerappsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<CreateCardResult> CreateCardInstance([WorkflowExpression] Func<string> cardId, [WorkflowExpression] Func<object> cardRequestinputs = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/cards/{0}/instances", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var cardRequest = new JObject();
                var cardRequestpropCount = 0;
                if (cardRequestinputs != null)
                {
                    cardRequest["inputs"] = SourceExpressionConverter.ConvertToken(cardRequestinputs);
                    cardRequestpropCount++;
                }

                if (cardRequestpropCount > 0)
                {
                    callPayload.Body = cardRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<CreateCardResult>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<PowerCardDescription> GetCardDescription([WorkflowExpression] Func<string> cardId)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/cards/cards/{0}", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<PowerCardDescription>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<JToken> ProcessActivity()
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cards/activities";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var activity = new JObject();
                var activitypropCount = 0;
                if (activitypropCount > 0)
                {
                    callPayload.Body = activity;
                }
                return callPayload;
            }

            return new ApiConnectionAction<JToken>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<GenerateCardResponse> GenerateCard([WorkflowExpression] Func<CardAction[]> generateCardRequestactions = null, [WorkflowExpression] Func<string> generateCardRequestdescription = null)
        {
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/cards/generate/card";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var generateCardRequest = new JObject();
                var generateCardRequestpropCount = 0;
                var dataObject = new JObject();
                var dataObjectpropCount = 0;
                if (dataObjectpropCount > 0)
                {
                    generateCardRequest["data"] = dataObject;
                    generateCardRequestpropCount++;
                }

                if (generateCardRequestactions != null)
                {
                    generateCardRequest["actions"] = SourceExpressionConverter.ConvertToken(generateCardRequestactions);
                    generateCardRequestpropCount++;
                }

                if (generateCardRequestdescription != null)
                {
                    generateCardRequest["description"] = SourceExpressionConverter.ConvertToken(generateCardRequestdescription);
                    generateCardRequestpropCount++;
                }

                if (generateCardRequestpropCount > 0)
                {
                    callPayload.Body = generateCardRequest;
                }
                return callPayload;
            }

            return new ApiConnectionAction<GenerateCardResponse>(BuildSourceInput);
        }
    }

    public class CardsforpowerappsTriggers([ConnectionName] string connectionId)
    {
    }

    public class CreateCardResult
    {
        public JToken Card { get; set; }
    }

    public class PowerCardDescription
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("environmentId")]
        public string EnvironmentId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("connections")]
        public JToken Connections { get; set; }

        [JsonProperty("inputs")]
        public JToken Inputs { get; set; }

        [JsonProperty("output")]
        public JToken Output { get; set; }
    }

    public class GenerateCardResponse
    {
        [JsonProperty("card")]
        public JToken Card { get; set; }

        [JsonProperty("cardId")]
        public string CardId { get; set; }
    }

    public class CardAction
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("connectorName")]
        public string ConnectorName { get; set; }

        [JsonProperty("operationId")]
        public string OperationId { get; set; }

        [JsonProperty("inputs")]
        public JToken Inputs { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Cardsforpowerapps;

    public partial class WorkflowManagedActions
    {
        public CardsforpowerappsActions Cardsforpowerapps(string connectionId) => new CardsforpowerappsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public CardsforpowerappsTriggers Cardsforpowerapps(string connectionId) => new CardsforpowerappsTriggers(connectionId);
    }
}