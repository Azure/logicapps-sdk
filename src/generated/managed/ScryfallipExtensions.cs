//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Scryfallip
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class ScryfallipActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsSearchGet))]
        public IBodyWorkflowAction<CardsSearchGetResponse> CardsSearchGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<uniqueInput> unique = null, [WorkflowExpression] Func<orderInput> order = null, [WorkflowExpression] Func<dirInput> dir = null, [WorkflowExpression] Func<bool> includeExtras = null, [WorkflowExpression] Func<bool> includeMultilingual = null, [WorkflowExpression] Func<bool> includeVariations = null, [WorkflowExpression] Func<int> page = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsSearchGetResponse> __BuildCardsSearchGet(WorkflowExpression<string> q, WorkflowExpression<uniqueInput> unique = null, WorkflowExpression<orderInput> order = null, WorkflowExpression<dirInput> dir = null, WorkflowExpression<bool> includeExtras = null, WorkflowExpression<bool> includeMultilingual = null, WorkflowExpression<bool> includeVariations = null, WorkflowExpression<int> page = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(unique, nameof(unique), required: false);
            WorkflowExpression.Validate(order, nameof(order), required: false);
            WorkflowExpression.Validate(dir, nameof(dir), required: false);
            WorkflowExpression.Validate(includeExtras, nameof(includeExtras), required: false);
            WorkflowExpression.Validate(includeMultilingual, nameof(includeMultilingual), required: false);
            WorkflowExpression.Validate(includeVariations, nameof(includeVariations), required: false);
            WorkflowExpression.Validate(page, nameof(page), required: false);
            return new DeferredBodyAction<CardsSearchGetResponse>(() =>
            {
                var apiCallPath = "/cards/search";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                callPayload.Queries["unique"] = Convert.ToString("cards");
                if (unique != null)
                    callPayload.Queries["unique"] = ExpressionConverter.Convert(unique);
                callPayload.Queries["order"] = Convert.ToString("name");
                if (order != null)
                    callPayload.Queries["order"] = ExpressionConverter.Convert(order);
                callPayload.Queries["dir"] = Convert.ToString("auto");
                if (dir != null)
                    callPayload.Queries["dir"] = ExpressionConverter.Convert(dir);
                callPayload.Queries["include_extras"] = Convert.ToString(false);
                if (includeExtras != null)
                    callPayload.Queries["include_extras"] = ExpressionConverter.Convert(includeExtras);
                callPayload.Queries["include_multilingual"] = Convert.ToString(false);
                if (includeMultilingual != null)
                    callPayload.Queries["include_multilingual"] = ExpressionConverter.Convert(includeMultilingual);
                callPayload.Queries["include_variations"] = Convert.ToString(false);
                if (includeVariations != null)
                    callPayload.Queries["include_variations"] = ExpressionConverter.Convert(includeVariations);
                if (page != null)
                    callPayload.Queries["page"] = ExpressionConverter.Convert(page);
                return new ApiConnectionAction<CardsSearchGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsNamedGet))]
        public IBodyWorkflowAction<CardsNamedGetResponse> CardsNamedGet([WorkflowExpression] Func<string> exact = null, [WorkflowExpression] Func<string> fuzzy = null, [WorkflowExpression] Func<string> set = null, [WorkflowExpression] Func<versionInput> version = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsNamedGetResponse> __BuildCardsNamedGet(WorkflowExpression<string> exact = null, WorkflowExpression<string> fuzzy = null, WorkflowExpression<string> set = null, WorkflowExpression<versionInput> version = null)
        {
            WorkflowExpression.Validate(exact, nameof(exact), required: false);
            WorkflowExpression.Validate(fuzzy, nameof(fuzzy), required: false);
            WorkflowExpression.Validate(set, nameof(set), required: false);
            WorkflowExpression.Validate(version, nameof(version), required: false);
            return new DeferredBodyAction<CardsNamedGetResponse>(() =>
            {
                var apiCallPath = "/cards/named";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (exact != null)
                    callPayload.Queries["exact"] = ExpressionConverter.Convert(exact);
                if (fuzzy != null)
                    callPayload.Queries["fuzzy"] = ExpressionConverter.Convert(fuzzy);
                if (set != null)
                    callPayload.Queries["set"] = ExpressionConverter.Convert(set);
                callPayload.Queries["version"] = Convert.ToString("large");
                if (version != null)
                    callPayload.Queries["version"] = ExpressionConverter.Convert(version);
                return new ApiConnectionAction<CardsNamedGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsAutocompleteGet))]
        public IBodyWorkflowAction<CardsAutocompleteGetResponse> CardsAutocompleteGet([WorkflowExpression] Func<string> q, [WorkflowExpression] Func<bool> includeExtras = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsAutocompleteGetResponse> __BuildCardsAutocompleteGet(WorkflowExpression<string> q, WorkflowExpression<bool> includeExtras = null)
        {
            WorkflowExpression.Validate(q, nameof(q), required: true);
            WorkflowExpression.Validate(includeExtras, nameof(includeExtras), required: false);
            return new DeferredBodyAction<CardsAutocompleteGetResponse>(() =>
            {
                var apiCallPath = "/cards/autocomplete";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                callPayload.Queries["q"] = ExpressionConverter.Convert(q);
                if (includeExtras != null)
                    callPayload.Queries["include_extras"] = ExpressionConverter.Convert(includeExtras);
                return new ApiConnectionAction<CardsAutocompleteGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsCollection))]
        public IBodyWorkflowAction<CardsCollectionPostResponse> CardsCollection([WorkflowExpression] Func<bodyidentifiersInputItem[]> bodyidentifiers = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsCollectionPostResponse> __BuildCardsCollection(WorkflowExpression<bodyidentifiersInputItem[]> bodyidentifiers = null)
        {
            WorkflowExpression.Validate(bodyidentifiers, nameof(bodyidentifiers), required: false);
            return new DeferredBodyAction<CardsCollectionPostResponse>(() =>
            {
                var apiCallPath = "/cards/collection";
                var apiCallHttpMethod = "post";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                var body = new JObject();
                var bodypropCount = 0;
                if (bodyidentifiers != null)
                {
                    body["identifiers"] = ExpressionConverter.ConvertO(bodyidentifiers);
                    bodypropCount++;
                }

                if (bodypropCount > 0)
                {
                    callPayload.Body = body;
                }

                return new ApiConnectionAction<CardsCollectionPostResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsSetNumberGet))]
        public IBodyWorkflowAction<CardsSetNumberGetResponse> CardsSetNumberGet([WorkflowExpression] Func<string> code, [WorkflowExpression] Func<string> number)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsSetNumberGetResponse> __BuildCardsSetNumberGet(WorkflowExpression<string> code, WorkflowExpression<string> number)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            WorkflowExpression.Validate(number, nameof(number), required: true);
            return new DeferredBodyAction<CardsSetNumberGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}/{1}", ExpressionConverter.ConvertWithUrlEncoding(code, 1), ExpressionConverter.ConvertWithUrlEncoding(number, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsSetNumberGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsMultiverseGet))]
        public IBodyWorkflowAction<CardsMultiverseGetResponse> CardsMultiverseGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsMultiverseGetResponse> __BuildCardsMultiverseGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsMultiverseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/multiverse/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsMultiverseGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsMTGOGet))]
        public IBodyWorkflowAction<CardsMTGOGetResponse> CardsMTGOGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsMTGOGetResponse> __BuildCardsMTGOGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsMTGOGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/mtgo/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsMTGOGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsArenaGet))]
        public IBodyWorkflowAction<CardsArenaGetResponse> CardsArenaGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsArenaGetResponse> __BuildCardsArenaGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsArenaGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/arena/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsArenaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsTCGplayerGet))]
        public IBodyWorkflowAction<CardsTCGplayerGetResponse> CardsTCGplayerGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsTCGplayerGetResponse> __BuildCardsTCGplayerGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsTCGplayerGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/tcgplayer/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsTCGplayerGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsCardmarketGet))]
        public IBodyWorkflowAction<CardsCardmarketGetResponse> CardsCardmarketGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsCardmarketGetResponse> __BuildCardsCardmarketGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsCardmarketGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/cardmarket/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsCardmarketGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildCardsScryfallGet))]
        public IBodyWorkflowAction<CardsScryfallGetResponse> CardsScryfallGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<CardsScryfallGetResponse> __BuildCardsScryfallGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<CardsScryfallGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<CardsScryfallGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<SetsGetResponse> SetsGet()
        {
            var apiCallPath = "/sets";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SetsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildSetGet))]
        public IBodyWorkflowAction<SetGetResponse> SetGet([WorkflowExpression] Func<string> code)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetGetResponse> __BuildSetGet(WorkflowExpression<string> code)
        {
            WorkflowExpression.Validate(code, nameof(code), required: true);
            return new DeferredBodyAction<SetGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sets/{0}", ExpressionConverter.ConvertWithUrlEncoding(code, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SetGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildSetsTCGplayerGet))]
        public IBodyWorkflowAction<SetsTCGplayerGetResponse> SetsTCGplayerGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<SetsTCGplayerGetResponse> __BuildSetsTCGplayerGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<SetsTCGplayerGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/sets/tcgplayer/{0}", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<SetsTCGplayerGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildRulingsMultiverseGet))]
        public IBodyWorkflowAction<RulingsMultiverseGetResponse> RulingsMultiverseGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RulingsMultiverseGetResponse> __BuildRulingsMultiverseGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RulingsMultiverseGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/multiverse/{0}/rulings", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RulingsMultiverseGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildRulingsMTGOGet))]
        public IBodyWorkflowAction<RulingsMTGOGetResponse> RulingsMTGOGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RulingsMTGOGetResponse> __BuildRulingsMTGOGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RulingsMTGOGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/mtgo/{0}/rulings", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RulingsMTGOGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        [WorkflowExpressionFactory(nameof(__BuildRulingsArenaGet))]
        public IBodyWorkflowAction<RulingsArenaGetResponse> RulingsArenaGet([WorkflowExpression] Func<string> id)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<RulingsArenaGetResponse> __BuildRulingsArenaGet(WorkflowExpression<string> id)
        {
            WorkflowExpression.Validate(id, nameof(id), required: true);
            return new DeferredBodyAction<RulingsArenaGetResponse>(() =>
            {
                var apiCallPath = ExpressionConverter.ConvertGeneratedPath("/cards/arena/{0}/rulings", ExpressionConverter.ConvertWithUrlEncoding(id, 1));
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                return new ApiConnectionAction<RulingsArenaGetResponse>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<SymbolsGetResponse> SymbolsGet()
        {
            var apiCallPath = "/symbology";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<SymbolsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogNamesGetResponse> CatalogNamesGet()
        {
            var apiCallPath = "/catalog/card-names";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogNamesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogArtistsGetResponse> CatalogArtistsGet()
        {
            var apiCallPath = "/catalog/artist-names";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogArtistsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogWordsGetResponse> CatalogWordsGet()
        {
            var apiCallPath = "/catalog/word-bank";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogWordsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogCreaturesGetResponse> CatalogCreaturesGet()
        {
            var apiCallPath = "/catalog/creature-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogCreaturesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogPlaneswalkersGetResponse> CatalogPlaneswalkersGet()
        {
            var apiCallPath = "/catalog/planeswalker-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogPlaneswalkersGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogLandsGetResponse> CatalogLandsGet()
        {
            var apiCallPath = "/catalog/land-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogLandsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogArtifactsGetResponse> CatalogArtifactsGet()
        {
            var apiCallPath = "/catalog/artifact-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogArtifactsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogEnchantmentsGetResponse> CatalogEnchantmentsGet()
        {
            var apiCallPath = "/catalog/enchantment-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogEnchantmentsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogSpellGetResponse> CatalogSpellGet()
        {
            var apiCallPath = "/catalog/spell-types";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogSpellGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogPowersGetResponse> CatalogPowersGet()
        {
            var apiCallPath = "/catalog/powers";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogPowersGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogToughnessGetResponse> CatalogToughnessGet()
        {
            var apiCallPath = "/catalog/toughnesses";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogToughnessGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogLoyaltiesGetResponse> CatalogLoyaltiesGet()
        {
            var apiCallPath = "/catalog/loyalties";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogLoyaltiesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogWatermarksGetResponse> CatalogWatermarksGet()
        {
            var apiCallPath = "/catalog/watermarks";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogWatermarksGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogKeyAbilitiesGetResponse> CatalogKeyAbilitiesGet()
        {
            var apiCallPath = "/catalog/keyword-abilities";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogKeyAbilitiesGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogKeyActionsGetResponse> CatalogKeyActionsGet()
        {
            var apiCallPath = "/catalog/keyword-actions";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogKeyActionsGetResponse>(callPayload);
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "scryfallip")]
        public IBodyWorkflowAction<CatalogAbilitiesGetResponse> CatalogAbilitiesGet()
        {
            var apiCallPath = "/catalog/ability-words";
            var apiCallHttpMethod = "get";
            var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
            return new ApiConnectionAction<CatalogAbilitiesGetResponse>(callPayload);
        }
    }

    public class ScryfallipTriggers([ConnectionName] string connectionId)
    {
    }

    public class CardsSearchGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("total_cards")]
        public int TotalCards { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("next_page")]
        public string NextPage { get; set; }

        [JsonProperty("data")]
        public CardsSearchGetResponseDataTypeItem[] Data { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsSearchGetResponseDataTypeItemImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsSearchGetResponseDataTypeItemLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("prices")]
        public CardsSearchGetResponseDataTypeItemPricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsSearchGetResponseDataTypeItemRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsSearchGetResponseDataTypeItemPurchaseUrisType PurchaseUris { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        [JsonProperty("arena_id")]
        public int ArenaId { get; set; }

        [JsonProperty("all_parts")]
        public CardsSearchGetResponseDataTypeItemAllPartsTypeItem[] AllParts { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("promo_types")]
        public string[] PromoTypes { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("frame_effects")]
        public string[] FrameEffects { get; set; }

        [JsonProperty("preview")]
        public CardsSearchGetResponseDataTypeItemPreviewType Preview { get; set; }

        [JsonProperty("watermark")]
        public string Watermark { get; set; }

        [JsonProperty("card_faces")]
        public CardsSearchGetResponseDataTypeItemCardFacesTypeItem[] CardFaces { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemPricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemPurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemAllPartsTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("component")]
        public string Component { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemPreviewType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_uri")]
        public string SourceUri { get; set; }

        [JsonProperty("previewed_at")]
        public string PreviewedAt { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemCardFacesTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_id")]
        public string ArtistId { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("image_uris")]
        public CardsSearchGetResponseDataTypeItemCardFacesTypeItemImageUrisType ImageUris { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("flavor_name")]
        public string FlavorName { get; set; }

        [JsonProperty("color_indicator")]
        public string[] ColorIndicator { get; set; }
    }

    public class CardsSearchGetResponseDataTypeItemCardFacesTypeItemImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum uniqueInput
    {
        [EnumMember(Value = "cards")]
        Cards,
        [EnumMember(Value = "art")]
        Art,
        [EnumMember(Value = "prints")]
        Prints
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum orderInput
    {
        [EnumMember(Value = "name")]
        Name,
        [EnumMember(Value = "set")]
        Set,
        [EnumMember(Value = "released")]
        Released,
        [EnumMember(Value = "rarity")]
        Rarity,
        [EnumMember(Value = "color")]
        Color,
        [EnumMember(Value = "usd")]
        Usd,
        [EnumMember(Value = "tix")]
        Tix,
        [EnumMember(Value = "eur")]
        Eur,
        [EnumMember(Value = "cmc")]
        Cmc,
        [EnumMember(Value = "power")]
        Power,
        [EnumMember(Value = "toughness")]
        Toughness,
        [EnumMember(Value = "edhrec")]
        Edhrec,
        [EnumMember(Value = "penny")]
        Penny,
        [EnumMember(Value = "artist")]
        Artist,
        [EnumMember(Value = "review")]
        Review
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum dirInput
    {
        [EnumMember(Value = "auto")]
        Auto,
        [EnumMember(Value = "asc")]
        Asc,
        [EnumMember(Value = "desc")]
        Desc
    }

    public class CardsNamedGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsNamedGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsNamedGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsNamedGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsNamedGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsNamedGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsNamedGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsNamedGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsNamedGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsNamedGetResponseRelatedUrisType
    {
        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsNamedGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum versionInput
    {
        [EnumMember(Value = "large")]
        Large,
        [EnumMember(Value = "small")]
        Small,
        [EnumMember(Value = "normal")]
        Normal,
        [EnumMember(Value = "png")]
        Png,
        [EnumMember(Value = "art_crop")]
        ArtCrop,
        [EnumMember(Value = "border_crop")]
        BorderCrop
    }

    public class CardsAutocompleteGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CardsCollectionPostResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("not_found")]
        public string[] NotFound { get; set; }

        [JsonProperty("data")]
        public CardsCollectionPostResponseDataTypeItem[] Data { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsCollectionPostResponseDataTypeItemImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsCollectionPostResponseDataTypeItemLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsCollectionPostResponseDataTypeItemPricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsCollectionPostResponseDataTypeItemRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsCollectionPostResponseDataTypeItemPurchaseUrisType PurchaseUris { get; set; }

        [JsonProperty("produced_mana")]
        public string[] ProducedMana { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItemImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItemLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItemPricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItemRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsCollectionPostResponseDataTypeItemPurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class bodyidentifiersInputItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("multiverse_id")]
        public int MultiverseId { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }
    }

    public class CardsSetNumberGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        [JsonProperty("arena_id")]
        public int ArenaId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsSetNumberGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsSetNumberGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsSetNumberGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsSetNumberGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsSetNumberGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsSetNumberGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsSetNumberGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsSetNumberGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsSetNumberGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsSetNumberGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsMultiverseGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsMultiverseGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("produced_mana")]
        public string[] ProducedMana { get; set; }

        [JsonProperty("legalities")]
        public CardsMultiverseGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("prices")]
        public CardsMultiverseGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsMultiverseGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsMultiverseGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsMultiverseGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsMultiverseGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsMultiverseGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsMultiverseGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsMultiverseGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsMTGOGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("mtgo_foil_id")]
        public int MtgoFoilId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsMTGOGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("produced_mana")]
        public string[] ProducedMana { get; set; }

        [JsonProperty("legalities")]
        public CardsMTGOGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsMTGOGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsMTGOGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsMTGOGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsMTGOGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsMTGOGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsMTGOGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsMTGOGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsMTGOGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsArenaGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("arena_id")]
        public int ArenaId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsArenaGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsArenaGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("frame_effects")]
        public string[] FrameEffects { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsArenaGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsArenaGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsArenaGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsArenaGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsArenaGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsArenaGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsArenaGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsArenaGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsTCGplayerGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("arena_id")]
        public int ArenaId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsTCGplayerGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsTCGplayerGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("frame_effects")]
        public string[] FrameEffects { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsTCGplayerGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsTCGplayerGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsTCGplayerGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsTCGplayerGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsTCGplayerGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsTCGplayerGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsTCGplayerGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsTCGplayerGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsCardmarketGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("mtgo_id")]
        public int MtgoId { get; set; }

        [JsonProperty("arena_id")]
        public int ArenaId { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsCardmarketGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("power")]
        public string Power { get; set; }

        [JsonProperty("toughness")]
        public string Toughness { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("legalities")]
        public CardsCardmarketGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("flavor_text")]
        public string FlavorText { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("preview")]
        public CardsCardmarketGetResponsePreviewType Preview { get; set; }

        [JsonProperty("prices")]
        public CardsCardmarketGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsCardmarketGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsCardmarketGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsCardmarketGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsCardmarketGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsCardmarketGetResponsePreviewType
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("source_uri")]
        public string SourceUri { get; set; }

        [JsonProperty("previewed_at")]
        public string PreviewedAt { get; set; }
    }

    public class CardsCardmarketGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsCardmarketGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsCardmarketGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class CardsScryfallGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("multiverse_ids")]
        public int[] MultiverseIds { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("cardmarket_id")]
        public int CardmarketId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("layout")]
        public string Layout { get; set; }

        [JsonProperty("highres_image")]
        public bool HighresImage { get; set; }

        [JsonProperty("image_status")]
        public string ImageStatus { get; set; }

        [JsonProperty("image_uris")]
        public CardsScryfallGetResponseImageUrisType ImageUris { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("color_identity")]
        public string[] ColorIdentity { get; set; }

        [JsonProperty("keywords")]
        public string[] Keywords { get; set; }

        [JsonProperty("card_faces")]
        public CardsScryfallGetResponseCardFacesTypeItem[] CardFaces { get; set; }

        [JsonProperty("legalities")]
        public CardsScryfallGetResponseLegalitiesType Legalities { get; set; }

        [JsonProperty("games")]
        public string[] Games { get; set; }

        [JsonProperty("reserved")]
        public bool Reserved { get; set; }

        [JsonProperty("foil")]
        public bool Foil { get; set; }

        [JsonProperty("nonfoil")]
        public bool Nonfoil { get; set; }

        [JsonProperty("finishes")]
        public string[] Finishes { get; set; }

        [JsonProperty("oversized")]
        public bool Oversized { get; set; }

        [JsonProperty("promo")]
        public bool Promo { get; set; }

        [JsonProperty("reprint")]
        public bool Reprint { get; set; }

        [JsonProperty("variation")]
        public bool Variation { get; set; }

        [JsonProperty("set_id")]
        public string SetId { get; set; }

        [JsonProperty("set")]
        public string Set { get; set; }

        [JsonProperty("set_name")]
        public string SetName { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("set_uri")]
        public string SetUri { get; set; }

        [JsonProperty("set_search_uri")]
        public string SetSearchUri { get; set; }

        [JsonProperty("scryfall_set_uri")]
        public string ScryfallSetUri { get; set; }

        [JsonProperty("rulings_uri")]
        public string RulingsUri { get; set; }

        [JsonProperty("prints_search_uri")]
        public string PrintsSearchUri { get; set; }

        [JsonProperty("collector_number")]
        public string CollectorNumber { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("rarity")]
        public string Rarity { get; set; }

        [JsonProperty("card_back_id")]
        public string CardBackId { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_ids")]
        public string[] ArtistIds { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("border_color")]
        public string BorderColor { get; set; }

        [JsonProperty("frame")]
        public string Frame { get; set; }

        [JsonProperty("security_stamp")]
        public string SecurityStamp { get; set; }

        [JsonProperty("full_art")]
        public bool FullArt { get; set; }

        [JsonProperty("textless")]
        public bool Textless { get; set; }

        [JsonProperty("booster")]
        public bool Booster { get; set; }

        [JsonProperty("story_spotlight")]
        public bool StorySpotlight { get; set; }

        [JsonProperty("edhrec_rank")]
        public int EdhrecRank { get; set; }

        [JsonProperty("penny_rank")]
        public int PennyRank { get; set; }

        [JsonProperty("prices")]
        public CardsScryfallGetResponsePricesType Prices { get; set; }

        [JsonProperty("related_uris")]
        public CardsScryfallGetResponseRelatedUrisType RelatedUris { get; set; }

        [JsonProperty("purchase_uris")]
        public CardsScryfallGetResponsePurchaseUrisType PurchaseUris { get; set; }
    }

    public class CardsScryfallGetResponseImageUrisType
    {
        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("normal")]
        public string Normal { get; set; }

        [JsonProperty("large")]
        public string Large { get; set; }

        [JsonProperty("png")]
        public string Png { get; set; }

        [JsonProperty("art_crop")]
        public string ArtCrop { get; set; }

        [JsonProperty("border_crop")]
        public string BorderCrop { get; set; }
    }

    public class CardsScryfallGetResponseCardFacesTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mana_cost")]
        public string ManaCost { get; set; }

        [JsonProperty("type_line")]
        public string TypeLine { get; set; }

        [JsonProperty("oracle_text")]
        public string OracleText { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_id")]
        public string ArtistId { get; set; }

        [JsonProperty("illustration_id")]
        public string IllustrationId { get; set; }

        [JsonProperty("flavor_name")]
        public string FlavorName { get; set; }
    }

    public class CardsScryfallGetResponseLegalitiesType
    {
        [JsonProperty("standard")]
        public string Standard { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("historic")]
        public string Historic { get; set; }

        [JsonProperty("gladiator")]
        public string Gladiator { get; set; }

        [JsonProperty("pioneer")]
        public string Pioneer { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("modern")]
        public string Modern { get; set; }

        [JsonProperty("legacy")]
        public string Legacy { get; set; }

        [JsonProperty("pauper")]
        public string Pauper { get; set; }

        [JsonProperty("vintage")]
        public string Vintage { get; set; }

        [JsonProperty("penny")]
        public string Penny { get; set; }

        [JsonProperty("commander")]
        public string Commander { get; set; }

        [JsonProperty("oathbreaker")]
        public string Oathbreaker { get; set; }

        [JsonProperty("brawl")]
        public string Brawl { get; set; }

        [JsonProperty("historicbrawl")]
        public string Historicbrawl { get; set; }

        [JsonProperty("alchemy")]
        public string Alchemy { get; set; }

        [JsonProperty("paupercommander")]
        public string Paupercommander { get; set; }

        [JsonProperty("duel")]
        public string Duel { get; set; }

        [JsonProperty("oldschool")]
        public string Oldschool { get; set; }

        [JsonProperty("premodern")]
        public string Premodern { get; set; }

        [JsonProperty("predh")]
        public string Predh { get; set; }
    }

    public class CardsScryfallGetResponsePricesType
    {
        [JsonProperty("usd")]
        public string Usd { get; set; }

        [JsonProperty("usd_foil")]
        public string UsdFoil { get; set; }

        [JsonProperty("usd_etched")]
        public string UsdEtched { get; set; }

        [JsonProperty("eur")]
        public string Eur { get; set; }

        [JsonProperty("eur_foil")]
        public string EurFoil { get; set; }

        [JsonProperty("tix")]
        public string Tix { get; set; }
    }

    public class CardsScryfallGetResponseRelatedUrisType
    {
        [JsonProperty("gatherer")]
        public string Gatherer { get; set; }

        [JsonProperty("tcgplayer_infinite_articles")]
        public string TcgplayerInfiniteArticles { get; set; }

        [JsonProperty("tcgplayer_infinite_decks")]
        public string TcgplayerInfiniteDecks { get; set; }

        [JsonProperty("edhrec")]
        public string Edhrec { get; set; }
    }

    public class CardsScryfallGetResponsePurchaseUrisType
    {
        [JsonProperty("tcgplayer")]
        public string Tcgplayer { get; set; }

        [JsonProperty("cardmarket")]
        public string Cardmarket { get; set; }

        [JsonProperty("cardhoarder")]
        public string Cardhoarder { get; set; }
    }

    public class SetsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public SetsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class SetsGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("mtgo_code")]
        public string MtgoCode { get; set; }

        [JsonProperty("arena_code")]
        public string ArenaCode { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("search_uri")]
        public string SearchUri { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("card_count")]
        public int CardCount { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("nonfoil_only")]
        public bool NonfoilOnly { get; set; }

        [JsonProperty("foil_only")]
        public bool FoilOnly { get; set; }

        [JsonProperty("icon_svg_uri")]
        public string IconSvgUri { get; set; }

        [JsonProperty("parent_set_code")]
        public string ParentSetCode { get; set; }

        [JsonProperty("block_code")]
        public string BlockCode { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }
    }

    public class SetGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("mtgo_code")]
        public string MtgoCode { get; set; }

        [JsonProperty("arena_code")]
        public string ArenaCode { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("search_uri")]
        public string SearchUri { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("card_count")]
        public int CardCount { get; set; }

        [JsonProperty("printed_size")]
        public int PrintedSize { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("nonfoil_only")]
        public bool NonfoilOnly { get; set; }

        [JsonProperty("foil_only")]
        public bool FoilOnly { get; set; }

        [JsonProperty("block_code")]
        public string BlockCode { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("icon_svg_uri")]
        public string IconSvgUri { get; set; }
    }

    public class SetsTCGplayerGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("mtgo_code")]
        public string MtgoCode { get; set; }

        [JsonProperty("arena_code")]
        public string ArenaCode { get; set; }

        [JsonProperty("tcgplayer_id")]
        public int TcgplayerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("scryfall_uri")]
        public string ScryfallUri { get; set; }

        [JsonProperty("search_uri")]
        public string SearchUri { get; set; }

        [JsonProperty("released_at")]
        public string ReleasedAt { get; set; }

        [JsonProperty("set_type")]
        public string SetType { get; set; }

        [JsonProperty("card_count")]
        public int CardCount { get; set; }

        [JsonProperty("parent_set_code")]
        public string ParentSetCode { get; set; }

        [JsonProperty("digital")]
        public bool Digital { get; set; }

        [JsonProperty("nonfoil_only")]
        public bool NonfoilOnly { get; set; }

        [JsonProperty("foil_only")]
        public bool FoilOnly { get; set; }

        [JsonProperty("block_code")]
        public string BlockCode { get; set; }

        [JsonProperty("block")]
        public string Block { get; set; }

        [JsonProperty("icon_svg_uri")]
        public string IconSvgUri { get; set; }
    }

    public class RulingsMultiverseGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public RulingsMultiverseGetResponseDataTypeItem[] Data { get; set; }
    }

    public class RulingsMultiverseGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class RulingsMTGOGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public RulingsMTGOGetResponseDataTypeItem[] Data { get; set; }
    }

    public class RulingsMTGOGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class RulingsArenaGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public RulingsArenaGetResponseDataTypeItem[] Data { get; set; }
    }

    public class RulingsArenaGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("oracle_id")]
        public string OracleId { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("published_at")]
        public string PublishedAt { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }
    }

    public class SymbolsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }

        [JsonProperty("data")]
        public SymbolsGetResponseDataTypeItem[] Data { get; set; }
    }

    public class SymbolsGetResponseDataTypeItem
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("svg_uri")]
        public string SvgUri { get; set; }

        [JsonProperty("loose_variant")]
        public string LooseVariant { get; set; }

        [JsonProperty("english")]
        public string English { get; set; }

        [JsonProperty("transposable")]
        public bool Transposable { get; set; }

        [JsonProperty("represents_mana")]
        public bool RepresentsMana { get; set; }

        [JsonProperty("appears_in_mana_costs")]
        public bool AppearsInManaCosts { get; set; }

        [JsonProperty("mana_value")]
        public int ManaValue { get; set; }

        [JsonProperty("cmc")]
        public int Cmc { get; set; }

        [JsonProperty("funny")]
        public bool Funny { get; set; }

        [JsonProperty("colors")]
        public string[] Colors { get; set; }

        [JsonProperty("gatherer_alternates")]
        public string GathererAlternates { get; set; }
    }

    public class CatalogNamesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogArtistsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogWordsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogCreaturesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogPlaneswalkersGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogLandsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogArtifactsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogEnchantmentsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogSpellGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogPowersGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogToughnessGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogLoyaltiesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogWatermarksGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogKeyAbilitiesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogKeyActionsGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }

    public class CatalogAbilitiesGetResponse
    {
        [JsonProperty("object")]
        public string ObjectEntity { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("total_values")]
        public int TotalValues { get; set; }

        [JsonProperty("data")]
        public string[] Data { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Scryfallip;

    public partial class WorkflowManagedActions
    {
        public ScryfallipActions Scryfallip(string connectionId) => new ScryfallipActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public ScryfallipTriggers Scryfallip(string connectionId) => new ScryfallipTriggers(connectionId);
    }
}