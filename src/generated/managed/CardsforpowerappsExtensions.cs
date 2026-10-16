//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------
namespace Microsoft.Azure.Workflows.Sdk.Connectors.Cardsforpowerapps
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Linq.Expressions;

    public class CardsforpowerappsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<CreateCardResult> CreateCardInstance(Expression<Func<string>> cardId, Expression<Func<object>> cardRequestinputs = null)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            var __workflow_cardRequestinputs = WorkflowExpression.Compile(cardRequestinputs, nameof(cardRequestinputs), required: false);
            return new DeferredBodyAction<CreateCardResult>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/cards/{0}/instances", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var cardRequest = new JObject();
                var cardRequestpropCount = 0;
                if (__workflow_cardRequestinputs != null)
                {
                    cardRequest["inputs"] = ExpressionConverter.ConvertO(__workflow_cardRequestinputs);
                    cardRequestpropCount++;
                }

                if (cardRequestpropCount > 0)
                {
                    callPayload.Body = cardRequest;
                }

                return new ApiConnectionAction<CreateCardResult>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<PowerCardDescription> GetCardDescription(Expression<Func<string>> cardId)
        {
            var __workflow_cardId = WorkflowExpression.Compile(cardId, nameof(cardId), required: true);
            return new DeferredBodyAction<PowerCardDescription>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(__workflow_cardId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<PowerCardDescription>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<JToken> ProcessActivity()
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

            return new ApiConnectionAction<JToken>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "cardsforpowerapps")]
        public IBodyWorkflowAction<GenerateCardResponse> GenerateCard(Expression<Func<CardAction[]>> generateCardRequestactions = null, Expression<Func<string>> generateCardRequestdescription = null)
        {
            var __workflow_generateCardRequestactions = WorkflowExpression.Compile(generateCardRequestactions, nameof(generateCardRequestactions), required: false);
            var __workflow_generateCardRequestdescription = WorkflowExpression.Compile(generateCardRequestdescription, nameof(generateCardRequestdescription), required: false);
            return new DeferredBodyAction<GenerateCardResponse>(() =>
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

                if (__workflow_generateCardRequestactions != null)
                {
                    generateCardRequest["actions"] = ExpressionConverter.ConvertO(__workflow_generateCardRequestactions);
                    generateCardRequestpropCount++;
                }

                if (__workflow_generateCardRequestdescription != null)
                {
                    generateCardRequest["description"] = ExpressionConverter.ConvertO(__workflow_generateCardRequestdescription);
                    generateCardRequestpropCount++;
                }

                if (generateCardRequestpropCount > 0)
                {
                    callPayload.Body = generateCardRequest;
                }

                return new ApiConnectionAction<GenerateCardResponse>(callPayload);
            });
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
