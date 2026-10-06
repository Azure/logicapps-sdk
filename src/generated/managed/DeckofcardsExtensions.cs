//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Deckofcards
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class DeckofcardsActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildCardGet))]
        public IBodyWorkflowAction<CardGetResponse> CardGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> cards, [WorkflowExpression] Func<int> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardGetResponse> __BuildCardGet(WorkflowExpression<string> deckId, WorkflowExpression<string> cards, WorkflowExpression<int> count = null)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(cards, nameof(cards), required: true);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<CardGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/draw/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
                return new ApiConnectionAction<CardGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildShuffleGet))]
        public IBodyWorkflowAction<ShuffleGetResponse> ShuffleGet([WorkflowExpression] Func<int> deckCount = null, [WorkflowExpression] Func<string> cards = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShuffleGetResponse> __BuildShuffleGet(WorkflowExpression<int> deckCount = null, WorkflowExpression<string> cards = null)
        {
            WorkflowExpression.Validate(deckCount, nameof(deckCount), required: false);
            WorkflowExpression.Validate(cards, nameof(cards), required: false);
            return new DeferredBodyAction<ShuffleGetResponse>(() =>
            {
                var apiCallPath = "/deck/new/shuffle/";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (deckCount != null)
                    callPayload.Queries["deck_count"] = ExpressionConverter.Convert(deckCount);
                if (cards != null)
                    callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
                return new ApiConnectionAction<ShuffleGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildReshuffleGet))]
        public IBodyWorkflowAction<ReshuffleGetResponse> ReshuffleGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<bool> remaining = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReshuffleGetResponse> __BuildReshuffleGet(WorkflowExpression<string> deckId, WorkflowExpression<bool> remaining = null)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(remaining, nameof(remaining), required: false);
            return new DeferredBodyAction<ReshuffleGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/shuffle/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (remaining != null)
                    callPayload.Queries["remaining"] = ExpressionConverter.Convert(remaining);
                return new ApiConnectionAction<ReshuffleGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildPileGet))]
        public IBodyWorkflowAction<PileGetResponse> PileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName, [WorkflowExpression] Func<string> cards)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<PileGetResponse> __BuildPileGet(WorkflowExpression<string> deckId, WorkflowExpression<string> pileName, WorkflowExpression<string> cards)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(pileName, nameof(pileName), required: true);
            WorkflowExpression.Validate(cards, nameof(cards), required: true);
            return new DeferredBodyAction<PileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/add/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
                return new ApiConnectionAction<PileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildShufflePileGet))]
        public IBodyWorkflowAction<ShufflePileGetResponse> ShufflePileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ShufflePileGetResponse> __BuildShufflePileGet(WorkflowExpression<string> deckId, WorkflowExpression<string> pileName)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(pileName, nameof(pileName), required: true);
            return new DeferredBodyAction<ShufflePileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/shuffle/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<ShufflePileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildDrawPileGet))]
        public IBodyWorkflowAction<DrawPileGetResponse> DrawPileGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> pileName, [WorkflowExpression] Func<int> count = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<DrawPileGetResponse> __BuildDrawPileGet(WorkflowExpression<string> deckId, WorkflowExpression<string> pileName, WorkflowExpression<int> count = null)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(pileName, nameof(pileName), required: true);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            return new DeferredBodyAction<DrawPileGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/pile/{1}/draw/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1), ExpressionConverter.ConvertWithUrlEncoding(pileName, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                return new ApiConnectionAction<DrawPileGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [WorkflowExpressionFactory(nameof(__BuildReturnGet))]
        public IBodyWorkflowAction<ReturnGetResponse> ReturnGet([WorkflowExpression] Func<string> deckId, [WorkflowExpression] Func<string> cards)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "deckofcards")]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<ReturnGetResponse> __BuildReturnGet(WorkflowExpression<string> deckId, WorkflowExpression<string> cards)
        {
            WorkflowExpression.Validate(deckId, nameof(deckId), required: true);
            WorkflowExpression.Validate(cards, nameof(cards), required: true);
            return new DeferredBodyAction<ReturnGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/deck/{0}/return/", ExpressionConverter.ConvertWithUrlEncoding(deckId, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["cards"] = ExpressionConverter.Convert(cards);
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