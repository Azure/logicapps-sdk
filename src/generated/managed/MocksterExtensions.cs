//------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
//------------------------------------------------------------

namespace Microsoft.Azure.Workflows.Sdk.Connectors.Mockster
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    public class MocksterActions([ConnectionName] string connectionId)
    {

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetAirlines))]
        public IBodyWorkflowAction<GetAirlinesResponseItem[]> GetAirlines([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAirlinesResponseItem[]> __BuildGetAirlines(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetAirlinesResponseItem[]>(() =>
            {
                var apiCallPath = "/airlines";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetAirlinesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetAnimals))]
        public IBodyWorkflowAction<GetAnimalsResponseItem[]> GetAnimals([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetAnimalsResponseItem[]> __BuildGetAnimals(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetAnimalsResponseItem[]>(() =>
            {
                var apiCallPath = "/animals";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetAnimalsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetColors))]
        public IBodyWorkflowAction<GetColorsResponseItem[]> GetColors([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetColorsResponseItem[]> __BuildGetColors(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetColorsResponseItem[]>(() =>
            {
                var apiCallPath = "/colors";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetColorsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetCompanies))]
        public IBodyWorkflowAction<GetCompaniesResponseItem[]> GetCompanies([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetCompaniesResponseItem[]> __BuildGetCompanies(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetCompaniesResponseItem[]>(() =>
            {
                var apiCallPath = "/companies";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetCompaniesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetDatabases))]
        public IBodyWorkflowAction<GetDatabasesResponseItem[]> GetDatabases([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDatabasesResponseItem[]> __BuildGetDatabases(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetDatabasesResponseItem[]>(() =>
            {
                var apiCallPath = "/databases";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetDatabasesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetDates))]
        public IBodyWorkflowAction<GetDatesResponseItem[]> GetDates([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetDatesResponseItem[]> __BuildGetDates(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetDatesResponseItem[]>(() =>
            {
                var apiCallPath = "/dates";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetDatesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetFinances))]
        public IBodyWorkflowAction<GetFinancesResponseItem[]> GetFinances([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetFinancesResponseItem[]> __BuildGetFinances(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetFinancesResponseItem[]>(() =>
            {
                var apiCallPath = "/finances";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetFinancesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetGits))]
        public IBodyWorkflowAction<GetGitsResponseItem[]> GetGits([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetGitsResponseItem[]> __BuildGetGits(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetGitsResponseItem[]>(() =>
            {
                var apiCallPath = "/gits";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetGitsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetHackers))]
        public IBodyWorkflowAction<GetHackersResponseItem[]> GetHackers([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetHackersResponseItem[]> __BuildGetHackers(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetHackersResponseItem[]>(() =>
            {
                var apiCallPath = "/hackers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetHackersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetRandomImages))]
        public IBodyWorkflowAction<GetRandomImagesResponseItem[]> GetRandomImages([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> width = null, [WorkflowExpression] Func<int> height = null, [WorkflowExpression] Func<categoryInput> category = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetRandomImagesResponseItem[]> __BuildGetRandomImages(WorkflowExpression<int> count = null, WorkflowExpression<int> width = null, WorkflowExpression<int> height = null, WorkflowExpression<categoryInput> category = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(width, nameof(width), required: false);
            WorkflowExpression.Validate(height, nameof(height), required: false);
            WorkflowExpression.Validate(category, nameof(category), required: false);
            return new DeferredBodyAction<GetRandomImagesResponseItem[]>(() =>
            {
                var apiCallPath = "/images";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (width != null)
                    callPayload.Queries["width"] = ExpressionConverter.Convert(width);
                if (height != null)
                    callPayload.Queries["height"] = ExpressionConverter.Convert(height);
                if (category != null)
                    callPayload.Queries["category"] = ExpressionConverter.Convert(category);
                return new ApiConnectionAction<GetRandomImagesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetInternet))]
        public IBodyWorkflowAction<GetInternetResponseItem[]> GetInternet([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetInternetResponseItem[]> __BuildGetInternet(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetInternetResponseItem[]>(() =>
            {
                var apiCallPath = "/internets";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetInternetResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetLocations))]
        public IBodyWorkflowAction<GetLocationsResponseItem[]> GetLocations([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLocationsResponseItem[]> __BuildGetLocations(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetLocationsResponseItem[]>(() =>
            {
                var apiCallPath = "/locations";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetLocationsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetLorems))]
        public IBodyWorkflowAction<GetLoremsResponseItem[]> GetLorems([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetLoremsResponseItem[]> __BuildGetLorems(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetLoremsResponseItem[]>(() =>
            {
                var apiCallPath = "/lorems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetLoremsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetMusics))]
        public IBodyWorkflowAction<GetMusicsResponseItem[]> GetMusics([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetMusicsResponseItem[]> __BuildGetMusics(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetMusicsResponseItem[]>(() =>
            {
                var apiCallPath = "/musics";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetMusicsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetNumbers))]
        public IBodyWorkflowAction<GetNumbersResponseItem[]> GetNumbers([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetNumbersResponseItem[]> __BuildGetNumbers(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetNumbersResponseItem[]>(() =>
            {
                var apiCallPath = "/numbers";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetNumbersResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetPeople))]
        public IBodyWorkflowAction<GetPeopleResponseItem[]> GetPeople([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPeopleResponseItem[]> __BuildGetPeople(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetPeopleResponseItem[]>(() =>
            {
                var apiCallPath = "/persons";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetPeopleResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetPhones))]
        public IBodyWorkflowAction<GetPhonesResponseItem[]> GetPhones([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetPhonesResponseItem[]> __BuildGetPhones(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetPhonesResponseItem[]>(() =>
            {
                var apiCallPath = "/phones";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetPhonesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetProducts))]
        public IBodyWorkflowAction<GetProductsResponseItem[]> GetProducts([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetProductsResponseItem[]> __BuildGetProducts(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetProductsResponseItem[]>(() =>
            {
                var apiCallPath = "/products";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetProductsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetSciences))]
        public IBodyWorkflowAction<GetSciencesResponseItem[]> GetSciences([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSciencesResponseItem[]> __BuildGetSciences(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetSciencesResponseItem[]>(() =>
            {
                var apiCallPath = "/sciences";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetSciencesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetStrings))]
        public IBodyWorkflowAction<GetStringsResponseItem[]> GetStrings([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetStringsResponseItem[]> __BuildGetStrings(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetStringsResponseItem[]>(() =>
            {
                var apiCallPath = "/strings";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetStringsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetSystems))]
        public IBodyWorkflowAction<GetSystemsResponseItem[]> GetSystems([WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetSystemsResponseItem[]> __BuildGetSystems(WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetSystemsResponseItem[]>(() =>
            {
                var apiCallPath = "/systems";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetSystemsResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetVehicles))]
        public IBodyWorkflowAction<GetVehiclesResponseItem[]> GetVehicles([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetVehiclesResponseItem[]> __BuildGetVehicles(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetVehiclesResponseItem[]>(() =>
            {
                var apiCallPath = "/vehicles";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetVehiclesResponseItem[]>(callPayload);
            });
        }

        [ConnectorOperation(Type = ConnectorType.ApiManagement, ConnectorName = "mockster")]
        [WorkflowExpressionFactory(nameof(__BuildGetWords))]
        public IBodyWorkflowAction<GetWordsResponseItem[]> GetWords([WorkflowExpression] Func<availableLocalesInput> availableLocales = null, [WorkflowExpression] Func<int> count = null, [WorkflowExpression] Func<int> seed = null)
        {
            throw new NotSupportedException("Build this workflow with the SDK expression compiler enabled.");
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public IBodyWorkflowAction<GetWordsResponseItem[]> __BuildGetWords(WorkflowExpression<availableLocalesInput> availableLocales = null, WorkflowExpression<int> count = null, WorkflowExpression<int> seed = null)
        {
            WorkflowExpression.Validate(availableLocales, nameof(availableLocales), required: false);
            WorkflowExpression.Validate(count, nameof(count), required: false);
            WorkflowExpression.Validate(seed, nameof(seed), required: false);
            return new DeferredBodyAction<GetWordsResponseItem[]>(() =>
            {
                var apiCallPath = "/words";
                var apiCallHttpMethod = "get";
                var callPayload = new ApiConnectionActionInput(apiCallPath, apiCallHttpMethod, connectionId);
                if (availableLocales != null)
                    callPayload.Queries["availableLocales"] = ExpressionConverter.Convert(availableLocales);
                if (count != null)
                    callPayload.Queries["count"] = ExpressionConverter.Convert(count);
                if (seed != null)
                    callPayload.Queries["seed"] = ExpressionConverter.Convert(seed);
                return new ApiConnectionAction<GetWordsResponseItem[]>(callPayload);
            });
        }
    }

    public class MocksterTriggers([ConnectionName] string connectionId)
    {
    }

    public class GetAirlinesResponseItem
    {
        [JsonProperty("aircraftType")]
        public string AircraftType { get; set; }

        [JsonProperty("airlineName")]
        public string AirlineName { get; set; }

        [JsonProperty("airlineCode")]
        public string AirlineIATACode { get; set; }

        [JsonProperty("airplaneName")]
        public string AirplaneName { get; set; }

        [JsonProperty("airplaneTypeCode")]
        public string AirplaneIATATypeCode { get; set; }

        [JsonProperty("departureAirportName")]
        public string DepartureAirportName { get; set; }

        [JsonProperty("departureAirportCode")]
        public string DepartureAirportIATACode { get; set; }

        [JsonProperty("arrivalAirportName")]
        public string ArrivalAirportName { get; set; }

        [JsonProperty("arrivalAirportCode")]
        public string ArrivalAirportIATACode { get; set; }

        [JsonProperty("flightNumber")]
        public string FlightNumber { get; set; }

        [JsonProperty("recordLocator")]
        public string RecordLocator { get; set; }

        [JsonProperty("seat")]
        public string Seat { get; set; }
    }

    public class GetAnimalsResponseItem
    {
        [JsonProperty("bear")]
        public string Bear { get; set; }

        [JsonProperty("bird")]
        public string Bird { get; set; }

        [JsonProperty("cat")]
        public string Cat { get; set; }

        [JsonProperty("cetacean")]
        public string Cetacean { get; set; }

        [JsonProperty("cow")]
        public string Cow { get; set; }

        [JsonProperty("crocodilia")]
        public string Crocodilia { get; set; }

        [JsonProperty("dog")]
        public string Dog { get; set; }

        [JsonProperty("fish")]
        public string Fish { get; set; }

        [JsonProperty("horse")]
        public string Horse { get; set; }

        [JsonProperty("insect")]
        public string Insect { get; set; }

        [JsonProperty("lion")]
        public string Lion { get; set; }

        [JsonProperty("rabbit")]
        public string Rabbit { get; set; }

        [JsonProperty("rodent")]
        public string Rodent { get; set; }

        [JsonProperty("snake")]
        public string Snake { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum availableLocalesInput
    {
        [EnumMember(Value = "af_ZA")]
        AfrikaansSouthAfrica,
        [EnumMember(Value = "ar")]
        Arabic,
        [EnumMember(Value = "az")]
        Azerbaijani,
        [EnumMember(Value = "base")]
        Base,
        [EnumMember(Value = "cs_CZ")]
        CzechCzechia,
        [EnumMember(Value = "da")]
        Danish,
        [EnumMember(Value = "de")]
        German,
        [EnumMember(Value = "de_AT")]
        GermanAustria,
        [EnumMember(Value = "de_CH")]
        GermanSwitzerland,
        [EnumMember(Value = "dv")]
        Maldivian,
        [EnumMember(Value = "el")]
        Greek,
        [EnumMember(Value = "en")]
        English,
        [EnumMember(Value = "en_AU")]
        EnglishAustralia,
        [EnumMember(Value = "en_AU_ocker")]
        EnglishAustraliaOcker,
        [EnumMember(Value = "en_BORK")]
        EnglishBork,
        [EnumMember(Value = "en_CA")]
        EnglishCanada,
        [EnumMember(Value = "en_GB")]
        EnglishGreatBritain,
        [EnumMember(Value = "en_GH")]
        EnglishGhana,
        [EnumMember(Value = "en_HK")]
        EnglishHongKong,
        [EnumMember(Value = "en_IE")]
        EnglishIreland,
        [EnumMember(Value = "en_IN")]
        EnglishIndia,
        [EnumMember(Value = "en_NG")]
        EnglishNigeria,
        [EnumMember(Value = "en_US")]
        EnglishUnitedStates,
        [EnumMember(Value = "en_ZA")]
        EnglishSouthAfrica,
        [EnumMember(Value = "eo")]
        Esperanto,
        [EnumMember(Value = "es")]
        Spanish,
        [EnumMember(Value = "es_MX")]
        SpanishMexico,
        [EnumMember(Value = "fa")]
        FarsiPersian,
        [EnumMember(Value = "fi")]
        Finnish,
        [EnumMember(Value = "fr")]
        French,
        [EnumMember(Value = "fr_BE")]
        FrenchBelgium,
        [EnumMember(Value = "fr_CA")]
        FrenchCanada,
        [EnumMember(Value = "fr_CH")]
        FrenchSwitzerland,
        [EnumMember(Value = "fr_LU")]
        FrenchLuxembourg,
        [EnumMember(Value = "fr_SN")]
        FrenchSenegal,
        [EnumMember(Value = "he")]
        Hebrew,
        [EnumMember(Value = "hr")]
        Croatian,
        [EnumMember(Value = "hu")]
        Hungarian,
        [EnumMember(Value = "hy")]
        Armenian,
        [EnumMember(Value = "id_ID")]
        IndonesianIndonesia,
        [EnumMember(Value = "it")]
        Italian,
        [EnumMember(Value = "ja")]
        Japanese,
        [EnumMember(Value = "ka_GE")]
        GeorgianGeorgia,
        [EnumMember(Value = "ko")]
        Korean,
        [EnumMember(Value = "lv")]
        Latvian,
        [EnumMember(Value = "mk")]
        Macedonian,
        [EnumMember(Value = "nb_NO")]
        NorwegianNorway,
        [EnumMember(Value = "ne")]
        Nepali,
        [EnumMember(Value = "nl")]
        Dutch,
        [EnumMember(Value = "nl_BE")]
        DutchBelgium,
        [EnumMember(Value = "pl")]
        Polish,
        [EnumMember(Value = "pt_BR")]
        PortugueseBrazil,
        [EnumMember(Value = "pt_PT")]
        PortuguesePortugal,
        [EnumMember(Value = "ro")]
        Romanian,
        [EnumMember(Value = "ro_MD")]
        RomanianMoldova,
        [EnumMember(Value = "ru")]
        Russian,
        [EnumMember(Value = "sk")]
        Slovak,
        [EnumMember(Value = "sr_RS_latin")]
        SerbianSerbiaLatin,
        [EnumMember(Value = "sv")]
        Swedish,
        [EnumMember(Value = "th")]
        Thai,
        [EnumMember(Value = "tr")]
        Turkish,
        [EnumMember(Value = "uk")]
        Ukrainian,
        [EnumMember(Value = "ur")]
        Urdu,
        [EnumMember(Value = "vi")]
        Vietnamese,
        [EnumMember(Value = "yo_NG")]
        YorubaNigeria,
        [EnumMember(Value = "zh_CN")]
        ChineseChina,
        [EnumMember(Value = "zh_TW")]
        ChineseTaiwan,
        [EnumMember(Value = "zu_ZA")]
        ZuluSouthAfrica
    }

    public class GetColorsResponseItem
    {
        [JsonProperty("cmyk")]
        public double[] CMYK { get; set; }

        [JsonProperty("colorByCSSColorSpace")]
        public double[] ColorByCSSColorSpace { get; set; }

        [JsonProperty("cssSupportedFunction")]
        public string CSSSupportedFunction { get; set; }

        [JsonProperty("cssSupportedSpace")]
        public string CSSSupportedSpace { get; set; }

        [JsonProperty("hsl")]
        public double[] HSL { get; set; }

        [JsonProperty("humanReadableColor")]
        public string HumanReadableColor { get; set; }

        [JsonProperty("hwb")]
        public double[] HWB { get; set; }

        [JsonProperty("lab")]
        public double[] LAB { get; set; }

        [JsonProperty("lch")]
        public double[] LCH { get; set; }

        [JsonProperty("rgb")]
        public string RGB { get; set; }

        [JsonProperty("colorSpace")]
        public string ColorSpace { get; set; }
    }

    public class GetCompaniesResponseItem
    {
        [JsonProperty("buzzAdjective")]
        public string BuzzAdjective { get; set; }

        [JsonProperty("buzzNoun")]
        public string BuzzNoun { get; set; }

        [JsonProperty("buzzPhrase")]
        public string BuzzPhrase { get; set; }

        [JsonProperty("buzzVerb")]
        public string BuzzVerb { get; set; }

        [JsonProperty("catchPhrase")]
        public string CatchPhrase { get; set; }

        [JsonProperty("catchPhraseAdjective")]
        public string CatchPhraseAdjective { get; set; }

        [JsonProperty("catchPhraseDescriptor")]
        public string CatchPhraseDescriptor { get; set; }

        [JsonProperty("catchPhraseNoun")]
        public string CatchPhraseNoun { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("creditLimit")]
        public double CreditLimit { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("mobilePhone")]
        public string MobilePhone { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("numberOfEmployees")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("revenue")]
        public double Revenue { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }
    }

    public class GetDatabasesResponseItem
    {
        [JsonProperty("collation")]
        public string Collation { get; set; }

        [JsonProperty("column")]
        public string Column { get; set; }

        [JsonProperty("engine")]
        public string Engine { get; set; }

        [JsonProperty("mongodbObjectId")]
        public string MongoDBObjectId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class GetDatesResponseItem
    {
        [JsonProperty("anytime")]
        public string Anytime { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("future")]
        public string Future { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("past")]
        public string Past { get; set; }

        [JsonProperty("recent")]
        public string Recent { get; set; }

        [JsonProperty("soon")]
        public string Soon { get; set; }

        [JsonProperty("weekday")]
        public string Weekday { get; set; }

        [JsonProperty("year")]
        public double Year { get; set; }
    }

    public class GetFinancesResponseItem
    {
        [JsonProperty("accountName")]
        public string AccountName { get; set; }

        [JsonProperty("accountNumber")]
        public string AccountType { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("bic")]
        public string BIC { get; set; }

        [JsonProperty("bitcoinAddress")]
        public string BitcoinAddress { get; set; }

        [JsonProperty("creditCardCVV")]
        public string CreditCardCVV { get; set; }

        [JsonProperty("creditCardIssuer")]
        public string CreditCardIssuer { get; set; }

        [JsonProperty("creditCardNumber")]
        public string CreditCardNumber { get; set; }

        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currencyName")]
        public string CurrencyName { get; set; }

        [JsonProperty("currencySymbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("ethereumAddress")]
        public string EthereumAddress { get; set; }

        [JsonProperty("iban")]
        public string IBAN { get; set; }

        [JsonProperty("litecoinAddress")]
        public string LitecoinAddress { get; set; }

        [JsonProperty("maskedNumber")]
        public string MaskedNumber { get; set; }

        [JsonProperty("pin")]
        public string PIN { get; set; }

        [JsonProperty("routingNumber")]
        public string RoutingNumber { get; set; }

        [JsonProperty("transactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }
    }

    public class GetGitsResponseItem
    {
        [JsonProperty("branch")]
        public string Branch { get; set; }

        [JsonProperty("commitDate")]
        public string CommitDate { get; set; }

        [JsonProperty("commitEntry")]
        public string CommitEntry { get; set; }

        [JsonProperty("commitMessage")]
        public string CommitMessage { get; set; }

        [JsonProperty("commitSha")]
        public string CommitSHA { get; set; }
    }

    public class GetHackersResponseItem
    {
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        [JsonProperty("adjective")]
        public string Adjective { get; set; }

        [JsonProperty("ingverb")]
        public string Ingverb { get; set; }

        [JsonProperty("noun")]
        public string Noun { get; set; }

        [JsonProperty("phrase")]
        public string Phrase { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }
    }

    public class GetRandomImagesResponseItem
    {
        [JsonProperty("name")]
        public string ImageName { get; set; }

        [JsonProperty("url")]
        public string ImageUrl { get; set; }
    }

    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum categoryInput
    {
        [EnumMember(Value = "abstract")]
        Abstract,
        [EnumMember(Value = "animals")]
        Animals,
        [EnumMember(Value = "business")]
        Business,
        [EnumMember(Value = "cats")]
        Cats,
        [EnumMember(Value = "city")]
        City,
        [EnumMember(Value = "food")]
        Food,
        [EnumMember(Value = "nightlife")]
        Nightlife,
        [EnumMember(Value = "fashion")]
        Fashion,
        [EnumMember(Value = "people")]
        People,
        [EnumMember(Value = "nature")]
        Nature,
        [EnumMember(Value = "sports")]
        Sports,
        [EnumMember(Value = "technics")]
        Technics,
        [EnumMember(Value = "transport")]
        Transport
    }

    public class GetInternetResponseItem
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("domainSuffix")]
        public string DomainSuffix { get; set; }

        [JsonProperty("domainWord")]
        public string DomainWord { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("exampleEmail")]
        public string ExampleEmail { get; set; }

        [JsonProperty("httpMethod")]
        public string HTTPMethod { get; set; }

        [JsonProperty("httpStatusCode")]
        public int HTTPStatusCode { get; set; }

        [JsonProperty("ip")]
        public string IPAddress { get; set; }

        [JsonProperty("ipv4")]
        public string IPv4Address { get; set; }

        [JsonProperty("ipv6")]
        public string IPv6Address { get; set; }

        [JsonProperty("mac")]
        public string MACAddress { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("port")]
        public int PortNumber { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("userAgent")]
        public string UserAgent { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class GetLocationsResponseItem
    {
        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }

        [JsonProperty("cardinalDirection")]
        public string CardinalDirection { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("ordinalDirection")]
        public string OrdinalDirection { get; set; }

        [JsonProperty("secondaryAddress")]
        public string SecondaryAddress { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }

        [JsonProperty("zipCode")]
        public string ZipCode { get; set; }
    }

    public class GetLoremsResponseItem
    {
        [JsonProperty("lines")]
        public string Lines { get; set; }

        [JsonProperty("paragraph")]
        public string Paragraph { get; set; }

        [JsonProperty("paragraphs")]
        public string Paragraphs { get; set; }

        [JsonProperty("sentence")]
        public string Sentence { get; set; }

        [JsonProperty("sentences")]
        public string Sentences { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("word")]
        public string Word { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }
    }

    public class GetMusicsResponseItem
    {
        [JsonProperty("genre")]
        public string Genre { get; set; }

        [JsonProperty("songName")]
        public string SongName { get; set; }
    }

    public class GetNumbersResponseItem
    {
        [JsonProperty("binary")]
        public string Binary { get; set; }

        [JsonProperty("float")]
        public double Float { get; set; }

        [JsonProperty("hex")]
        public string Hexadecimal { get; set; }

        [JsonProperty("int")]
        public double Integer { get; set; }

        [JsonProperty("octal")]
        public string Octal { get; set; }
    }

    public class GetPeopleResponseItem
    {
        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        [JsonProperty("businessPhone")]
        public string BusinessPhone { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("creditLimit")]
        public double CreditLimit { get; set; }

        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("jobArea")]
        public string JobArea { get; set; }

        [JsonProperty("lastname")]
        public string LastName { get; set; }

        [JsonProperty("sexType")]
        public string SexType { get; set; }
    }

    public class GetPhonesResponseItem
    {
        [JsonProperty("imei")]
        public string IMEI { get; set; }

        [JsonProperty("number")]
        public string PhoneNumber { get; set; }
    }

    public class GetProductsResponseItem
    {
        [JsonProperty("department")]
        public string Department { get; set; }

        [JsonProperty("isbn")]
        public string ISBN { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("product")]
        public string ShortProductName { get; set; }

        [JsonProperty("productAdjective")]
        public string ProductAdjective { get; set; }

        [JsonProperty("productDescription")]
        public string ProductDescription { get; set; }

        [JsonProperty("productMaterial")]
        public string ProductMaterial { get; set; }

        [JsonProperty("productName")]
        public string ProductName { get; set; }
    }

    public class GetSciencesResponseItem
    {
        [JsonProperty("chemicalElementSymbol")]
        public string ChemicalElementSymbol { get; set; }

        [JsonProperty("chemicalElementName")]
        public string ChemicalElementName { get; set; }

        [JsonProperty("chemicalElementAtomicNumber")]
        public int ChemicalElementAtomicNumber { get; set; }

        [JsonProperty("unitName")]
        public string UnitName { get; set; }

        [JsonProperty("unitSymbol")]
        public string UnitSymbol { get; set; }
    }

    public class GetStringsResponseItem
    {
        [JsonProperty("alpha")]
        public string Alpha { get; set; }

        [JsonProperty("alphanumeric")]
        public string Alphanumeric { get; set; }

        [JsonProperty("binary")]
        public string Binary { get; set; }

        [JsonProperty("hexadecimal")]
        public string Hexadecimal { get; set; }

        [JsonProperty("nanoid")]
        public string Nanoid { get; set; }

        [JsonProperty("numeric")]
        public string Numeric { get; set; }

        [JsonProperty("octal")]
        public string Octal { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("uuid")]
        public string UUID { get; set; }
    }

    public class GetSystemsResponseItem
    {
        [JsonProperty("commonFileExt")]
        public string CommonFileExtension { get; set; }

        [JsonProperty("commonFileName")]
        public string CommonFileName { get; set; }

        [JsonProperty("commonFileType")]
        public string CommonFileType { get; set; }

        [JsonProperty("cron")]
        public string Cron { get; set; }

        [JsonProperty("directoryPath")]
        public string DirectoryPath { get; set; }

        [JsonProperty("fileExt")]
        public string FileExtension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        [JsonProperty("fileType")]
        public string FileType { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }

        [JsonProperty("networkInterface")]
        public string NetworkInterface { get; set; }

        [JsonProperty("semver")]
        public string SemanticVersion { get; set; }
    }

    public class GetVehiclesResponseItem
    {
        [JsonProperty("bicycle")]
        public string Bicycle { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("fuel")]
        public string Fuel { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("vehicle")]
        public string Vehicle { get; set; }

        [JsonProperty("vin")]
        public string VIN { get; set; }

        [JsonProperty("vrm")]
        public string VRM { get; set; }
    }

    public class GetWordsResponseItem
    {
        [JsonProperty("adjective")]
        public string Adjective { get; set; }

        [JsonProperty("adverb")]
        public string Adverb { get; set; }

        [JsonProperty("conjunction")]
        public string Conjunction { get; set; }

        [JsonProperty("interjection")]
        public string Interjection { get; set; }

        [JsonProperty("noun")]
        public string Noun { get; set; }

        [JsonProperty("preposition")]
        public string Preposition { get; set; }

        [JsonProperty("sample")]
        public string Sample { get; set; }

        [JsonProperty("verb")]
        public string Verb { get; set; }

        [JsonProperty("words")]
        public string Words { get; set; }
    }
}

namespace Microsoft.Azure.Workflows.Sdk
{
    using Microsoft.Azure.Workflows.Sdk.Connectors.Mockster;

    public partial class WorkflowManagedActions
    {
        public MocksterActions Mockster(string connectionId) => new MocksterActions(connectionId);
    }

    public partial class WorkflowManagedTriggers
    {
        public MocksterTriggers Mockster(string connectionId) => new MocksterTriggers(connectionId);
    }
}