//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deckofcards
{
    using System.Linq.Expressions;
    using Microsoft.Azure.Workflows.Sdk.Expressions;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeckofcardsActions([ConnectionName] string connectionId)
    {
        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<CardGetResponse, ApiConnectionActionConfiguration> CardGet(Expression<Func<string>> deckId, Expression<Func<string>> cards, Expression<Func<int>> count = null)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<CardGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/draw/", __workflow_deckId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                return new ApiConnectionAction<CardGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShuffleGetResponse, ApiConnectionActionConfiguration> ShuffleGet(Expression<Func<int>> deckCount = null, Expression<Func<string>> cards = null)
        {
            var __workflow_deckCount = WorkflowExpression.Compile(deckCount, nameof(deckCount), required: false);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: false);
            return new DeferredBodyAction<ShuffleGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = "/deck/new/shuffle/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_deckCount != null)
                    callPayload.Queries["deck_count"] = ExpressionConverter.Convert(__workflow_deckCount);
                if (__workflow_cards != null)
                    callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                return new ApiConnectionAction<ShuffleGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReshuffleGetResponse, ApiConnectionActionConfiguration> ReshuffleGet(Expression<Func<string>> deckId, Expression<Func<bool>> remaining = null)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_remaining = WorkflowExpression.Compile(remaining, nameof(remaining), required: false);
            return new DeferredBodyAction<ReshuffleGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/shuffle/", __workflow_deckId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_remaining != null)
                    callPayload.Queries["remaining"] = ExpressionConverter.Convert(__workflow_remaining);
                return new ApiConnectionAction<ReshuffleGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<PileGetResponse, ApiConnectionActionConfiguration> PileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName, Expression<Func<string>> cards)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_pileName = WorkflowExpression.Compile(pileName, nameof(pileName), required: true);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: true);
            return new DeferredBodyAction<PileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/pile/{1}/add/", __workflow_deckId.WithUrlEncoding(1), __workflow_pileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                return new ApiConnectionAction<PileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ShufflePileGetResponse, ApiConnectionActionConfiguration> ShufflePileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_pileName = WorkflowExpression.Compile(pileName, nameof(pileName), required: true);
            return new DeferredBodyAction<ShufflePileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/pile/{1}/shuffle/", __workflow_deckId.WithUrlEncoding(1), __workflow_pileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShufflePileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<DrawPileGetResponse, ApiConnectionActionConfiguration> DrawPileGet(Expression<Func<string>> deckId, Expression<Func<string>> pileName, Expression<Func<int>> count = null)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_pileName = WorkflowExpression.Compile(pileName, nameof(pileName), required: true);
            var __workflow_count = WorkflowExpression.Compile(count, nameof(count), required: false);
            return new DeferredBodyAction<DrawPileGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/pile/{1}/draw/", __workflow_deckId.WithUrlEncoding(1), __workflow_pileName.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (__workflow_count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(__workflow_count);
                return new ApiConnectionAction<DrawPileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        public IBodyWorkflowAction<ReturnGetResponse, ApiConnectionActionConfiguration> ReturnGet(Expression<Func<string>> deckId, Expression<Func<string>> cards)
        {
            var __workflow_deckId = WorkflowExpression.Compile(deckId, nameof(deckId), required: true);
            var __workflow_cards = WorkflowExpression.Compile(cards, nameof(cards), required: true);
            return new DeferredBodyAction<ReturnGetResponse, ApiConnectionActionConfiguration>(() =>
            {
                var apiCallPath = ExpressionConverter.Convert(WorkflowExpression.GeneratedPath("/deck/{0}/return/", __workflow_deckId.WithUrlEncoding(1)));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(__workflow_cards);
                return new ApiConnectionAction<ReturnGetResponse>(callPayload);
            });
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