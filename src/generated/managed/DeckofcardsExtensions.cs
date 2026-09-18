//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deckofcards
{
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeckofcardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<CardGetResponse> CardGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> cards, [WorkflowExpression] Func<int> count = null)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(cards, nameof(cards), required: true);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/draw/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                callPayload.Queries["cards"] = SourceExpressionConverter.ConvertO(cards);
                return callPayload;
            }

            return new ApiConnectionAction<CardGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShuffleGetResponse> ShuffleGet([WorkflowExpression] Func<int> deckCount = null, [WorkflowExpression] Func<string> cards = null)
        {
            SourceExpression.Validate(deckCount, nameof(deckCount), required: false);
            SourceExpression.Validate(cards, nameof(cards), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = "/deck/new/shuffle/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deckCount != null)
                    callPayload.Queries["deck_count"] = SourceExpressionConverter.ConvertO(deckCount);
                if (cards != null)
                    callPayload.Queries["cards"] = SourceExpressionConverter.ConvertO(cards);
                return callPayload;
            }

            return new ApiConnectionAction<ShuffleGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReshuffleGetResponse> ReshuffleGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<bool> remaining = null)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(remaining, nameof(remaining), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/shuffle/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (remaining != null)
                    callPayload.Queries["remaining"] = SourceExpressionConverter.ConvertO(remaining);
                return callPayload;
            }

            return new ApiConnectionAction<ReshuffleGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<PileGetResponse> PileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName, [WorkflowExpression] Func<string> cards)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(pileName, nameof(pileName), required: true);
            SourceExpression.Validate(cards, nameof(cards), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/add/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = SourceExpressionConverter.ConvertO(cards);
                return callPayload;
            }

            return new ApiConnectionAction<PileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShufflePileGetResponse> ShufflePileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(pileName, nameof(pileName), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/shuffle/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return callPayload;
            }

            return new ApiConnectionAction<ShufflePileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<DrawPileGetResponse> DrawPileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName, [WorkflowExpression] Func<int> count = null)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(pileName, nameof(pileName), required: true);
            SourceExpression.Validate(count, nameof(count), required: false);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/draw/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1), SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = SourceExpressionConverter.ConvertO(count);
                return callPayload;
            }

            return new ApiConnectionAction<DrawPileGetResponse>(BuildSourceInput);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReturnGetResponse> ReturnGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> cards)
        {
            SourceExpression.Validate(deckId, nameof(deckId), required: true);
            SourceExpression.Validate(cards, nameof(cards), required: true);
            ApiConnectionActionInput BuildSourceInput()
            {
                var apiCallPath = SourceExpressionConverter.ConvertGeneratedPath("/deck/{0}/return/", SourceExpressionConverter.ConvertPathArgumentWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = SourceExpressionConverter.ConvertO(cards);
                return callPayload;
            }

            return new ApiConnectionAction<ReturnGetResponse>(BuildSourceInput);
        }
    }

    public class DeckofcardsTriggers([ConnectionName] string connectionId)
    {
    }

    public class CardGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("cards")]
        public CardGetResponseCardsTypeItem[] Cards { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class CardGetResponseCardsTypeItem
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("images")]
        public CardGetResponseCardsTypeItemImagesType Images { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("suit")]
        public string Suit { get; set; }
    }

    public class CardGetResponseCardsTypeItemImagesType
    {
        [JsonProperty("svg")]
        public string Svg { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }
    }

    public class ShuffleGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("shuffled")]
        public bool Shuffled { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class ReshuffleGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("shuffled")]
        public bool Shuffled { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class PileGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("piles")]
        public JToken Piles { get; set; }
    }

    public class ShufflePileGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("piles")]
        public JToken Piles { get; set; }
    }

    public class DrawPileGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("piles")]
        public JToken Piles { get; set; }

        [JsonProperty("cards")]
        public DrawPileGetResponseCardsTypeItem[] Cards { get; set; }
    }

    public class DrawPileGetResponseCardsTypeItem
    {
        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("suit")]
        public string Suit { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public class ReturnGetResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("deck_id")]
        public string DeckId { get; set; }

        [JsonProperty("shuffled")]
        public bool Shuffled { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Deckofcards;

    public partial class WorkflowManagedActions
    {
        public DeckofcardsActions Deckofcards(string connectionId) => new DeckofcardsActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public DeckofcardsTriggers Deckofcards(string connectionId) => new DeckofcardsTriggers(connectionId);
    }
}