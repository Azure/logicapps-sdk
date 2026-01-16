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
        public IBodyWorkflowAction<CardGetResponse> CardGet(Expression<Func<string>> deckId, Expression<Func<string>> cards, Expression<Func<int>> count = null)
        {
            var apiCallPath = String.Format("/deck/{0}/draw/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            return new ApiConnectionAction<CardGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShuffleGetResponse> ShuffleGet(Expression<Func<int>> deckCount = null, Expression<Func<string>> cards = null)
        {
            var apiCallPath = "/deck/new/shuffle/";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (deckCount != null)
                callPayload.Queries["deck_count"] = ExpressionConverter.Convert(deckCount);
            if (cards != null)
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            return new ApiConnectionAction<ShuffleGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReshuffleGetResponse> ReshuffleGet(Expression<Func<string>> deckId, Expression<Func<bool>> remaining = null)
        {
            var apiCallPath = String.Format("/deck/{0}/shuffle/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (remaining != null)
                callPayload.Queries["remaining"] = ExpressionConverter.Convert(remaining);
            return new ApiConnectionAction<ReshuffleGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<PileGetResponse> PileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName, Expression<Func<string>> cards)
        {
            var apiCallPath = String.Format("/deck/{0}/pile/{1}/add/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            return new ApiConnectionAction<PileGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShufflePileGetResponse> ShufflePileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName)
        {
            var apiCallPath = String.Format("/deck/{0}/pile/{1}/shuffle/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<ShufflePileGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<DrawPileGetResponse> DrawPileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName, Expression<Func<int>> count = null)
        {
            var apiCallPath = String.Format("/deck/{0}/pile/{1}/draw/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            if (count != null)
                callPayload.Queries["count"] = ExpressionConverter.Convert(count);
            return new ApiConnectionAction<DrawPileGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReturnGetResponse> ReturnGet(Expression<Func<string>> deckId, Expression<Func<string>> cards)
        {
            var apiCallPath = String.Format("/deck/{0}/return/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
            return new ApiConnectionAction<ReturnGetResponse>(callPayload);
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

namespace Microsoft.Azure.Workflows.Sdk.Connectors
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